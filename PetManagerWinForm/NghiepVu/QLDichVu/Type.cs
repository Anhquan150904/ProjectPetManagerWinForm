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

                // convert to enumerable and optionally filter by name (case-insensitive)
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

                // prevent auto-generating columns (avoids duplicates)
                dgvTypes.AutoGenerateColumns = false;
                dgvTypes.DataSource = dtDisplay;

                // map columns (use existing column names from Designer)
                // colTypeId will show ordinal index
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
                // the bound row contains Ordinal, TypeId, TypeName
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
                // raise event to notify parent
                TypeSaved?.Invoke(this, new TypeSavedEventArgs(id));
                LoadTypes();
                // select new
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
                // raise event to notify parent (id remains same)
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
