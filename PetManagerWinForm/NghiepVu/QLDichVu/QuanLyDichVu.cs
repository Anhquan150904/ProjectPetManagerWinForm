using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetManagerData.Controllers;

namespace PetManagerWinForm.NghiepVu.QLDichVu
{
    public partial class QuanLyDichVu : Form
    {
        private ServiceController _serviceController;
        private ServiceTypeController _typeController;

        // Mock mode for testing without DB
        private readonly bool _useMock = false;
        private BindingList<Service> _mockServices;
        private int _nextMockId = 1;

        // track selected row index
        private int currentRowIndex = -1;
        // remember latest saved type id from Type form
        private int _lastSavedTypeId = 0;

        public QuanLyDichVu()
        {
            InitializeComponent();

            if (_useMock)
            {
                InitializeMockData();
                LoadTypesMock();
                LoadSer();
            }
            else
            {
                try
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PetDb"].ConnectionString;
                    _serviceController = new ServiceController(connStr);
                    _typeController = new ServiceTypeController(connStr);
                    LoadTypes();
                    LoadSer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể kết nối tới cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Wire events
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnSearch.Click += btnSearch_Click;
            btn_ShowAll.Click += btn_ShowAll_Click;
            btnRefresh.Click += BtnRefresh_Click;
            btnAddType.Click += btnAddType_Click;
            btnUpdateType.Click += btnUpdateType_Click;
            btnDeleteType.Click += btnDeleteType_Click;

            dgvSer.CellContentClick -= dgvSer_CellContentClick;
            dgvSer.CellContentClick += dgvSer_CellContentClick;

            dgvSer.CellClick -= dgvSer_CellClick;
            dgvSer.CellClick += dgvSer_CellClick;

            // context menu for type ComboBox: Edit / Delete
            var cms = new ContextMenuStrip();
            var miEdit = new ToolStripMenuItem("Edit");
            var miDelete = new ToolStripMenuItem("Delete");
            miEdit.Click += btnUpdateType_Click;
            miDelete.Click += btnDeleteType_Click;
            cms.Items.AddRange(new ToolStripItem[] { miEdit, miDelete });
            cmbType.ContextMenuStrip = cms;
        }

        // Simple in-memory model for mock data
        private class Service
        {
            public int ServiceId { get; set; }
            public string ServiceName { get; set; } = string.Empty;
            public string Type { get; set; } = string.Empty;
            public decimal Price { get; set; }
        }

        private void InitializeMockData()
        {
            _mockServices = new BindingList<Service>
            {
                new Service { ServiceId = _nextMockId++, ServiceName = "Tắm", Type = "Spa", Price = 300000m },
                new Service { ServiceId = _nextMockId++, ServiceName = "Cắt tỉa lông", Type = "Spa", Price = 100000m },
                new Service { ServiceId = _nextMockId++, ServiceName = "Huấn luyện", Type = "Behavior", Price = 500000m }
            };
        }

        private void LoadTypes()
        {
            if (_typeController == null) return;
            try
            {
                var dt = _typeController.GetTypes(); // already ordered by TypeName

                // Build display table with numbering
                var dtDisplay = new DataTable();
                dtDisplay.Columns.Add("TypeId", typeof(int));
                dtDisplay.Columns.Add("TypeName", typeof(string));
                dtDisplay.Columns.Add("DisplayName", typeof(string));

                int idx = 1;
                foreach (DataRow r in dt.Rows)
                {
                    var id = Convert.ToInt32(r["TypeId"]);
                    var name = r["TypeName"]?.ToString() ?? string.Empty;
                    var disp = string.Format("{0}. {1}", idx, name);
                    dtDisplay.Rows.Add(id, name, disp);
                    idx++;
                }

                cmbType.DisplayMember = "DisplayName";
                cmbType.ValueMember = "TypeId";
                cmbType.DataSource = dtDisplay;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể load danh sách loại dịch vụ: " + ex.Message);
            }
        }

        private void LoadTypesMock()
        {
            var types = _mockServices.Select(x => x.Type).Distinct().ToList();
            cmbType.DataSource = types;
        }

        private void btnAddType_Click(object? sender, EventArgs e)
        {
            // Open the dedicated Type management form so user can Add/Edit/Delete types
            try
            {
                using (var frm = new Type())
                {
                    // subscribe to event to get created/updated TypeId
                    _lastSavedTypeId = 0;
                    EventHandler<PetManagerWinForm.NghiepVu.QLDichVu.TypeSavedEventArgs> handler = (s, ev) =>
                    {
                        _lastSavedTypeId = ev.TypeId;
                    };

                    frm.TypeSaved += handler;

                    frm.ShowDialog(this);

                    frm.TypeSaved -= handler;

                    // After the Type form closes, reload types to reflect changes
                    LoadTypes();

                    if (_lastSavedTypeId > 0)
                    {
                        try { cmbType.SelectedValue = _lastSavedTypeId; } catch { }
                        _lastSavedTypeId = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở form quản lý loại: " + ex.Message);
            }
        }

        private void btnUpdateType_Click(object? sender, EventArgs e)
        {
            if (cmbType.SelectedItem == null || cmbType.SelectedValue == null) return;
            if (!int.TryParse(cmbType.SelectedValue.ToString(), out int typeId)) return;

            // If the ComboBox is bound to a DataTable (LoadTypes), the SelectedItem will be a DataRowView
            // where the actual type name is stored in the "TypeName" column. Use that instead of
            // the DisplayMember which contains numbering (e.g., "1. Name"). For mock mode the SelectedItem
            // may be a plain string so fall back to cmbType.Text.
            string current = cmbType.Text;
            if (cmbType.SelectedItem is DataRowView drv && drv.Row.Table.Columns.Contains("TypeName"))
            {
                current = drv["TypeName"]?.ToString() ?? current;
            }

            string newName = PromptForType(current);
            if (string.IsNullOrWhiteSpace(newName) || newName == current) return;

            bool ok = _typeController.UpdateType(typeId, newName);
            if (ok)
            {
                LoadTypes();
                try { cmbType.SelectedValue = typeId; cmbType.Text = newName; } catch { }
                MessageBox.Show("Cập nhật loại thành công.");
            }
            else
            {
                MessageBox.Show("Cập nhật loại thất bại.");
            }
        }

        private void btnDeleteType_Click(object? sender, EventArgs e)
        {
            if (cmbType.SelectedItem == null || cmbType.SelectedValue == null) return;
            if (!int.TryParse(cmbType.SelectedValue.ToString(), out int typeId)) return;

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa loại dịch vụ này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            bool ok = _typeController.DeleteType(typeId);
            if (ok)
            {
                LoadTypes();
                MessageBox.Show("Xóa loại thành công.");
            }
            else
            {
                MessageBox.Show("Xóa loại thất bại (có thể đang được sử dụng). Nếu muốn, hãy chuyển các dịch vụ sang loại khác trước khi xóa.");
            }
        }

        private void dgvSer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var column = dgvSer.Columns[e.ColumnIndex];
            if (column == null) return;

            if (column.Name == "colEdit")
            {
                var row = dgvSer.Rows[e.RowIndex];
                txtId.Text = row.Cells["colSerId"].Value?.ToString() ?? string.Empty;
                txtName.Text = row.Cells["colSerName"].Value?.ToString() ?? string.Empty;
                cmbType.Text = row.Cells["colSerType"].Value?.ToString() ?? string.Empty;
                txtPrice.Text = row.Cells["colSerPrice"].Value?.ToString() ?? string.Empty;
                txtName.Focus();
            }
        }

        private void dgvSer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            currentRowIndex = e.RowIndex;

            if (dgvSer.Rows[e.RowIndex].DataBoundItem is DataRowView drv)
            {
                DataRow row = drv.Row;
                txtId.Text = row.Table.Columns.Contains("ServiceId") ? row["ServiceId"]?.ToString() ?? string.Empty : string.Empty;
                txtName.Text = row.Table.Columns.Contains("ServiceName") ? row["ServiceName"]?.ToString() ?? string.Empty : string.Empty;
                cmbType.Text = row.Table.Columns.Contains("Type") ? row["Type"]?.ToString() ?? string.Empty : string.Empty;
                txtPrice.Text = row.Table.Columns.Contains("Price") ? row["Price"]?.ToString() ?? string.Empty : string.Empty;
            }
            else
            {
                var row = dgvSer.Rows[e.RowIndex];
                txtId.Text = row.Cells["colSerId"].Value?.ToString() ?? string.Empty;
                txtName.Text = row.Cells["colSerName"].Value?.ToString() ?? string.Empty;
                cmbType.Text = row.Cells["colSerType"].Value?.ToString() ?? string.Empty;
                txtPrice.Text = row.Cells["colSerPrice"].Value?.ToString() ?? string.Empty;
            }

            txtName.Focus();
        }

        private void LoadSer()
        {
            if (_useMock)
            {
                dgvSer.AutoGenerateColumns = false;
                dgvSer.DataSource = new BindingSource(_mockServices, null);
                colSerId.DataPropertyName = "ServiceId";
                colSerName.DataPropertyName = "ServiceName";
                colSerType.DataPropertyName = "Type";
                colSerPrice.DataPropertyName = "Price";
                return;
            }

            if (_serviceController == null) return;
            var dt = _serviceController.GetServices();
            dgvSer.AutoGenerateColumns = false;
            dgvSer.DataSource = dt;
            colSerId.DataPropertyName = "ServiceId";
            colSerName.DataPropertyName = "ServiceName";
            colSerType.DataPropertyName = "Type";
            colSerPrice.DataPropertyName = "Price";
        }

        public void Refresh()
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            cmbType.SelectedIndex = -1;
        }

        private void BtnRefresh_Click(object? sender, EventArgs e)
        {
            LoadSer();
            Refresh();
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!_useMock && _serviceController == null)
                {
                    MessageBox.Show("Không có kết nối DB.");
                    return;
                }

                string name = txtName.Text.Trim();
                string type = cmbType.Text.Trim();
                if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price)) price = 0m;

                if (_useMock)
                {
                    var svc = new Service { ServiceId = _nextMockId++, ServiceName = name, Type = type, Price = price };
                    _mockServices.Add(svc);
                    MessageBox.Show("Thêm thành công (mock)");
                    LoadSer();
                    return;
                }

                bool success = _serviceController.AddService(name, type, price);
                MessageBox.Show(success ? "Thêm thành công" : "Thêm thất bại");
                if (success) LoadSer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!_useMock && _serviceController == null)
                {
                    MessageBox.Show("Không có kết nối DB.");
                    return;
                }

                if (!int.TryParse(txtId.Text.Trim(), out int id) || id <= 0)
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ cần sửa từ lưới.");
                    return;
                }

                string name = txtName.Text.Trim();
                string type = cmbType.Text.Trim();
                if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price)) price = 0m;

                if (_useMock)
                {
                    var item = _mockServices.FirstOrDefault(x => x.ServiceId == id);
                    if (item != null)
                    {
                        item.ServiceName = name;
                        item.Type = type;
                        item.Price = price;
                        // refresh binding
                        dgvSer.Refresh();
                        MessageBox.Show("Cập nhật thành công (mock)");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dịch vụ (mock)");
                    }

                    return;
                }

                bool success = _serviceController.UpdateService(id, name, type, price);
                MessageBox.Show(success ? "Cập nhật thành công" : "Cập nhật thất bại");
                if (success) LoadSer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!_useMock && _serviceController == null)
                {
                    MessageBox.Show("Không có kết nối DB.");
                    return;
                }

                if (!int.TryParse(txtId.Text.Trim(), out int id) || id <= 0)
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ cần xóa từ lưới.");
                    return;
                }

                var confirm = MessageBox.Show($"Bạn có chắc muốn xóa dịch vụ ID {id}?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    if (_useMock)
                    {
                        var item = _mockServices.FirstOrDefault(x => x.ServiceId == id);
                        if (item != null) _mockServices.Remove(item);
                        MessageBox.Show("Xóa thành công");
                        LoadSer();
                        Refresh();
                        return;
                    }

                    bool success = _serviceController.DeleteService(id);
                    MessageBox.Show(success ? "Xóa thành công" : "Xóa thất bại");
                    if (success) LoadSer();
                    Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            if (_useMock)
            {
                string q = txtSearch.Text.Trim();
                if (string.IsNullOrEmpty(q))
                {
                    LoadSer();
                    return;
                }

                var filtered = _mockServices.Where(x => x.ServiceName.Contains(q, StringComparison.OrdinalIgnoreCase)
                                                      || x.Type.Contains(q, StringComparison.OrdinalIgnoreCase)
                                                      || x.Price.ToString().Contains(q))
                                           .ToList();

                dgvSer.DataSource = new BindingSource(new BindingList<Service>(filtered), null);

                return;
             }

             if (_serviceController == null) return;
             string q2 = txtSearch.Text.Trim();
             if (string.IsNullOrEmpty(q2))
             {
                 LoadSer();
                 return;
             }

             var dt = _serviceController.SearchServices(q2);
             dgvSer.DataSource = dt;
         }

        private void btn_ShowAll_Click(object? sender, EventArgs e)
        {
            LoadSer();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            // keep compatibility with designer-generated event
            LoadSer();
            Refresh();
        }

        private string PromptForType(string initial = "")
        {
            using (Form prompt = new Form())
            {
                prompt.Width = 520;
                prompt.Height = 160;
                prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
                prompt.StartPosition = FormStartPosition.CenterParent;
                prompt.Text = "Thêm/Chỉnh sửa loại dịch vụ";

                Label textLabel = new Label() { Left = 10, Top = 10, Text = "Tên loại:" };
                TextBox input = new TextBox() { Left = 100, Top = 10, Width = 380, Text = initial };
                Button confirmation = new Button() { Text = "OK", Left = 300, Width = 80, Top = 50, DialogResult = DialogResult.OK };
                Button cancel = new Button() { Text = "Cancel", Left = 400, Width = 80, Top = 50, DialogResult = DialogResult.Cancel };
                // set DialogResult only, no explicit Close handler
                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(input);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(cancel);
                prompt.AcceptButton = confirmation;
                prompt.CancelButton = cancel;

                return prompt.ShowDialog() == DialogResult.OK ? input.Text.Trim() : string.Empty;
            }
        }
    }
}
