using System;
using System.Configuration; // Cần thêm Reference: System.Configuration
using System.Data;
using System.Windows.Forms;
using PetManagerData.DataAccess;
using PetManagerData.Models;

namespace PetManagerWinForm.NghiepVu.QLKhachHang
{
    public partial class ThongTinKhachHang : Form
    {
        private CustomerRepository _repo;

        public ThongTinKhachHang()
        {
            InitializeComponent();

            // Đọc chuỗi kết nối từ App.Config
            string strConn = ConfigurationManager.ConnectionStrings["PetDb"].ConnectionString;
            _repo = new CustomerRepository(strConn);

            this.Load += ThongTinKhachHang_Load;
        }

        private void ThongTinKhachHang_Load(object sender, EventArgs e)
        {
            dgvCustomers.AutoGenerateColumns = false;

            // Map tên cột trong SQL với cột trên GridView
            colCusId.DataPropertyName = "Cus_Id";
            colCusName.DataPropertyName = "Cus_Name";
            colAddress.DataPropertyName = "Address";
            colPhoneNumber.DataPropertyName = "Cus_PhoneNumber";
            colEmail.DataPropertyName = "Cus_Email";

            LoadData();
        }

        private void LoadData()
        {
            try {
                // Lấy DataTable từ SQL đổ vào Grid
                dgvCustomers.DataSource = _repo.GetAll();
            } catch (Exception ex) {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];

                txtId.Text = row.Cells[colCusId.Index].Value?.ToString();
                txtName.Text = row.Cells[colCusName.Index].Value?.ToString();
                txtAddress.Text = row.Cells[colAddress.Index].Value?.ToString();
                txtPhoneNumber.Text = row.Cells[colPhoneNumber.Index].Value?.ToString();
                txtEmail.Text = row.Cells[colEmail.Index].Value?.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text)) {
                MessageBox.Show("Vui lòng nhập tên khách hàng.");
                return;
            }

            Customer newCus = new Customer {
                // Không gán ID, SQL tự tăng
                Cus_Name = txtName.Text,
                Address = txtAddress.Text,
                Cus_Email = txtEmail.Text,
                Cus_PhoneNumber = txtPhoneNumber.Text
            };

            try {
                int newId = _repo.Add(newCus);
                if (newId > 0) {
                    MessageBox.Show($"Thêm thành công! ID mới: {newId}");
                    LoadData();
                    RefreshInput();
                } else {
                    MessageBox.Show("Thêm thất bại.");
                }
            } catch (Exception ex) {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id)) {
                MessageBox.Show("Vui lòng chọn khách hàng để sửa.");
                return;
            }

            Customer cusUpdate = new Customer {
                Cus_Id = id,
                Cus_Name = txtName.Text,
                Address = txtAddress.Text,
                Cus_Email = txtEmail.Text,
                Cus_PhoneNumber = txtPhoneNumber.Text
            };

            try {
                if (_repo.Update(cusUpdate)) {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                    RefreshInput();
                } else {
                    MessageBox.Show("Cập nhật thất bại.");
                }
            } catch (Exception ex) {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id)) {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa.");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                try {
                    if (_repo.Delete(id)) {
                        MessageBox.Show("Đã xóa!");
                        LoadData();
                        RefreshInput();
                    } else {
                        MessageBox.Show("Xóa thất bại.");
                    }
                } catch (Exception ex) {
                    MessageBox.Show("Lỗi xóa: " + ex.Message);
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword)) {
                LoadData(); // Nếu ô tìm kiếm rỗng thì load lại tất cả
                return;
            }

            try {
                dgvCustomers.DataSource = _repo.Search(keyword);
            } catch (Exception ex) {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshInput();
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshInput();
        }

        // Đổi tên hàm Refresh của bạn thành RefreshInput để tránh nhầm với hàm hệ thống
        public void RefreshInput()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
            txtSearch.Text = "";
        }

        private void btnTransHis_Click(object sender, EventArgs e)
        {
            // Code xử lý lịch sử
        }
    }
}