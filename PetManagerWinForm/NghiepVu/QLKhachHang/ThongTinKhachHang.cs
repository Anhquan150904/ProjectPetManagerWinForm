using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using PetManagerData.DataAccess;
using PetManagerData.Models;

namespace PetManagerWinForm.NghiepVu.QLKhachHang
{
    public partial class ThongTinKhachHang : Form
    {
        private CustomerRepository _repo;

        // Thêm properties để hỗ trợ chế độ chọn khách hàng
        public bool IsSelectionMode { get; set; } = false;
        public Customer SelectedCustomer { get; private set; }

        // Constructor mặc định
        public ThongTinKhachHang()
        {
            InitializeComponent();
            InitializeForm();
        }

        // Constructor mới cho chế độ chọn khách hàng
        public ThongTinKhachHang(bool selectionMode)
        {
            InitializeComponent();
            IsSelectionMode = selectionMode;
            InitializeForm();
        }

        private void InitializeForm()
        {
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

            // Nếu đang ở chế độ chọn khách hàng
            if (IsSelectionMode)
            {
                // Ẩn các nút thêm/sửa/xóa
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                btnThucungcuakhanghang.Visible = false;

                // Đổi text của btnRefresh thành "Chọn khách hàng"
                btnRefresh.Text = "Chọn khách hàng";
                btnRefresh.Width = 245;

                // Thay đổi title
                this.Text = "Chọn khách hàng";
                lblTitle.Text = "Chọn khách hàng cần thanh toán:";

                // Disable các textbox nhập liệu
                txtName.Enabled = false;
                txtAddress.Enabled = false;
                txtPhoneNumber.Enabled = false;
                txtEmail.Enabled = false;
            }
        }

        private void LoadData()
        {
            try
            {
                dgvCustomers.DataSource = _repo.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
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
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.");
                return;
            }

            Customer newCus = new Customer
            {
                Cus_Name = txtName.Text,
                Address = txtAddress.Text,
                Cus_Email = txtEmail.Text,
                Cus_PhoneNumber = txtPhoneNumber.Text
            };

            try
            {
                int newId = _repo.Add(newCus);
                if (newId > 0)
                {
                    MessageBox.Show($"Thêm thành công! ID mới: {newId}");
                    LoadData();
                    RefreshInput();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để sửa.");
                return;
            }

            Customer cusUpdate = new Customer
            {
                Cus_Id = id,
                Cus_Name = txtName.Text,
                Address = txtAddress.Text,
                Cus_Email = txtEmail.Text,
                Cus_PhoneNumber = txtPhoneNumber.Text
            };

            try
            {
                if (_repo.Update(cusUpdate))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                    RefreshInput();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa.");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (_repo.Delete(id))
                    {
                        MessageBox.Show("Đã xóa!");
                        LoadData();
                        RefreshInput();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa: " + ex.Message);
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadData();
                return;
            }

            try
            {
                dgvCustomers.DataSource = _repo.Search(keyword);
            }
            catch (Exception ex)
            {
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
            if (IsSelectionMode)
            {
                // Chế độ chọn khách hàng
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("Vui lòng chọn một khách hàng từ danh sách!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng Customer từ thông tin đã chọn
                SelectedCustomer = new Customer
                {
                    Cus_Id = int.Parse(txtId.Text),
                    Cus_Name = txtName.Text,
                    Address = txtAddress.Text,
                    Cus_PhoneNumber = txtPhoneNumber.Text,
                    Cus_Email = txtEmail.Text
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // Chế độ bình thường - làm mới
                RefreshInput();
            }
        }

        public void RefreshInput()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
            txtSearch.Text = "";
        }

        private void btnThucungcuakhanghang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng từ danh sách trước!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int customerId = int.Parse(txtId.Text);
            string customerName = txtName.Text;
            ThuCungCuaKhangHang frm = new ThuCungCuaKhangHang(customerId, customerName);
            frm.ShowDialog();
        }
    }
}