using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PetManagerData.Controllers;

namespace PetManagerWinForm.NghiepVu.QLDichVu
{
    public partial class Type : Form
    {
        private ServiceTypeController _typeController;
        private readonly string _connStr;

        public event EventHandler<TypeSavedEventArgs>? TypeSaved;

        public Type()
        {
            InitializeComponent();
            _connStr = System.Configuration.ConfigurationManager.ConnectionStrings["PetDb"].ConnectionString;
            _typeController = new ServiceTypeController(_connStr);

            dgvTypes.SelectionChanged += DgvTypes_SelectionChanged;
            this.Load += Type_Load;
        }

        private void Type_Load(object sender, EventArgs e)
        {
            LoadTypes();
        }

        private void LoadTypes(string filter = null)
        {
            try
            {
                var dt = _typeController.GetTypes();

                // Chuyển sang enumerable và có thể lọc theo tên (không phân biệt hoa thường)
                var rows = dt.AsEnumerable()
                             .Select(r => new { TypeId = Convert.ToInt32(r["TypeId"]), TypeName = r["TypeName"]?.ToString() ?? string.Empty })
                             .Where(x => string.IsNullOrEmpty(filter) || x.TypeName.IndexOf(filter ?? string.Empty, StringComparison.OrdinalIgnoreCase) >= 0)
                             .OrderBy(x => x.TypeName, StringComparer.OrdinalIgnoreCase)
                             .ToList();

                var dtDisplay = new DataTable();
                dtDisplay.Columns.Add("Ordinal", typeof(int));
                dtDisplay.Columns.Add("TypeId", typeof(int));
                dtDisplay.Columns.Add("TypeName", typeof(string));

                int ord = 1;
                foreach (var item in rows)
                {
                    dtDisplay.Rows.Add(ord++, item.TypeId, item.TypeName);
                }

                // Không để tự động tạo cột (tránh tạo trùng)
                dgvTypes.AutoGenerateColumns = false;
                dgvTypes.DataSource = dtDisplay;

                // ánh xạ cột (dùng tên cột đã có trong Designer)
                // colTypeId sẽ hiển thị số thứ tự
                if (dgvTypes.Columns.Contains("colTypeId"))
                {
                    dgvTypes.Columns["colTypeId"].DataPropertyName = "Ordinal";
                    dgvTypes.Columns["colTypeId"].HeaderText = "ID";
                    dgvTypes.Columns["colTypeId"].Visible = true;
                    dgvTypes.Columns["colTypeId"].Width = 60;
                }

                if (dgvTypes.Columns.Contains("colTypeName"))
                {
                    dgvTypes.Columns["colTypeName"].DataPropertyName = "TypeName";
                    dgvTypes.Columns["colTypeName"].HeaderText = "Name";
                    dgvTypes.Columns["colTypeName"].Width = 260;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load loại: " + ex.Message);
            }
        }

        private void DgvTypes_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvTypes.SelectedRows.Count > 0)
            {
                var row = (DataRowView)dgvTypes.SelectedRows[0].DataBoundItem;
                // hàng bind chứa Ordinal, TypeId, TypeName
                txtTypeName.Text = row["TypeName"].ToString();
            }
            else
            {
                txtTypeName.Text = string.Empty;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var q = (txtSearch?.Text ?? string.Empty).Trim();
            LoadTypes(string.IsNullOrEmpty(q) ? null : q);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var name = txtTypeName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên loại.");
                return;
            }

            int id = _typeController.AddType(name);
            if (id > 0)
            {
                MessageBox.Show("Thêm loại thành công.");
                // phát sự kiện để thông báo cho parent
                TypeSaved?.Invoke(this, new TypeSavedEventArgs(id));
                LoadTypes();
                // chọn mục mới
                try { dgvTypes.CurrentCell = dgvTypes.Rows.Cast<DataGridViewRow>().First(r => r.Cells["TypeId"].Value.ToString() == id.ToString()).Cells[0]; } catch { }
            }
            else
            {
                MessageBox.Show("Thêm thất bại hoặc đã tồn tại.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTypes.SelectedRows.Count == 0) return;
            var row = (DataRowView)dgvTypes.SelectedRows[0].DataBoundItem;
            int id = Convert.ToInt32(row["TypeId"]);
            string newName = txtTypeName.Text.Trim();
            if (string.IsNullOrEmpty(newName)) { MessageBox.Show("Tên mới không hợp lệ."); return; }

            bool ok = _typeController.UpdateType(id, newName);
            if (ok)
            {
                MessageBox.Show("Cập nhật thành công.");
                // phát sự kiện để thông báo cho parent (id không đổi)
                TypeSaved?.Invoke(this, new TypeSavedEventArgs(id));
                LoadTypes();
            }
            else { MessageBox.Show("Cập nhật thất bại."); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTypes.SelectedRows.Count == 0) return;
            var row = (DataRowView)dgvTypes.SelectedRows[0].DataBoundItem;
            int id = Convert.ToInt32(row["TypeId"]);
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            bool ok = _typeController.DeleteType(id);
            if (ok) { MessageBox.Show("Xóa thành công."); LoadTypes(); } else { MessageBox.Show("Xóa thất bại (type đang được sử dụng)."); }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTypes();
        }
    }

    public class TypeSavedEventArgs : EventArgs
    {
        public int TypeId { get; }
        public TypeSavedEventArgs(int typeId) => TypeId = typeId;
    }
}
