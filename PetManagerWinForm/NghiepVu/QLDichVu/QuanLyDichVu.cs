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

        // Mock mode for testing without DB
        private readonly bool _useMock = true;
        private BindingList<Service> _mockServices;
        private int _nextMockId = 1;

        // track selected row index
        private int currentRowIndex = -1;

        public QuanLyDichVu()
        {
            InitializeComponent();

            if (_useMock)
            {
                InitializeMockData();
                LoadSer();
            }
            else
            {
                // Initialize controller and load data
                try
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PetDb"].ConnectionString;
                    _serviceController = new ServiceController(connStr);
                    LoadSer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể kết nối tới cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Wire designer buttons if not wired
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnSearch.Click += btnSearch_Click;
            btn_ShowAll.Click += btn_ShowAll_Click;
            btnRefresh.Click += BtnRefresh_Click;

            // Ensure grid click wired
            dgvSer.CellContentClick -= dgvSer_CellContentClick;
            dgvSer.CellContentClick += dgvSer_CellContentClick;

            // wire CellClick so clicking a row populates the form
            dgvSer.CellClick -= dgvSer_CellClick;
            dgvSer.CellClick += dgvSer_CellClick;
        }

        // Simple in-memory model for mock data
        private class Service
        {
            public int ServiceId { get; set; }
            public string ServiceName { get; set; } = string.Empty;
            public string Type { get; set; } = string.Empty;
            // Amount removed
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

        private void dgvSer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // header clicked

            var column = dgvSer.Columns[e.ColumnIndex];
            if (column == null) return;

            if (column.Name == "colEdit")
            {
                // Populate form fields from selected row for editing
                var row = dgvSer.Rows[e.RowIndex];
                txtId.Text = row.Cells["colSerId"].Value?.ToString() ?? string.Empty;
                txtName.Text = row.Cells["colSerName"].Value?.ToString() ?? string.Empty;
                txtType.Text = row.Cells["colSerType"].Value?.ToString() ?? string.Empty;
                txtPrice.Text = row.Cells["colSerPrice"].Value?.ToString() ?? string.Empty;

                // Optionally set focus to name for quick editing
                txtName.Focus();
            }
        }

        // populate inputs when a row is clicked (works with DataTable or BindingList)
        private void dgvSer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            currentRowIndex = e.RowIndex;

            // If bound to DataTable, use DataRowView
            if (dgvSer.Rows[e.RowIndex].DataBoundItem is DataRowView drv)
            {
                DataRow row = drv.Row;

                txtId.Text = row.Table.Columns.Contains("ServiceId") ? row["ServiceId"]?.ToString() ?? string.Empty : string.Empty;
                txtName.Text = row.Table.Columns.Contains("ServiceName") ? row["ServiceName"]?.ToString() ?? string.Empty : string.Empty;
                txtType.Text = row.Table.Columns.Contains("Type") ? row["Type"]?.ToString() ?? string.Empty : string.Empty;
                txtPrice.Text = row.Table.Columns.Contains("Price") ? row["Price"]?.ToString() ?? string.Empty : string.Empty;
            }
            else
            {
                var row = dgvSer.Rows[e.RowIndex];
                txtId.Text = row.Cells["colSerId"].Value?.ToString() ?? string.Empty;
                txtName.Text = row.Cells["colSerName"].Value?.ToString() ?? string.Empty;
                txtType.Text = row.Cells["colSerType"].Value?.ToString() ?? string.Empty;
                txtPrice.Text = row.Cells["colSerPrice"].Value?.ToString() ?? string.Empty;
            }

            txtName.Focus();
        }

        private void LoadSer()
        {
            if (_useMock)
            {
                dgvSer.AutoGenerateColumns = false; // use existing columns
                dgvSer.DataSource = new BindingSource(_mockServices, null);

                // Map columns to data fields
                colSerId.DataPropertyName = "ServiceId";
                colSerName.DataPropertyName = "ServiceName";
                colSerType.DataPropertyName = "Type";
                colSerPrice.DataPropertyName = "Price";

                return;
            }

            if (_serviceController == null) return;

            var dt = _serviceController.GetServices();

            dgvSer.AutoGenerateColumns = false; // use existing columns
            dgvSer.DataSource = dt;

            // Map columns to data fields (adjust names to match DB)
            colSerId.DataPropertyName = "ServiceId";
            colSerName.DataPropertyName = "ServiceName";
            colSerType.DataPropertyName = "Type";
            colSerPrice.DataPropertyName = "Price";
        }

        public void Refresh()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtType.Text = "";
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
                string type = txtType.Text.Trim();
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
                string type = txtType.Text.Trim();
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
    }
}
