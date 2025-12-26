using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using PetManagerData.DataAccess;
using PetManagerData.Models;

namespace PetManagerWinForm.NghiepVu.QLKhachHang
{
    public partial class ThuCungCuaKhangHang : Form
    {
        private PetCusRepository _repo;
        private int _customerId;
        private string _customerName;

        // Constructor mặc định (cho Designer)
        public ThuCungCuaKhangHang()
        {
            InitializeComponent();

            // Đọc chuỗi kết nối từ App.Config
            string strConn = ConfigurationManager.ConnectionStrings["PetDb"].ConnectionString;
            _repo = new PetCusRepository(strConn);
        }

        // Constructor nhận thông tin khách hàng
        public ThuCungCuaKhangHang(int customerId, string customerName) : this()
        {
            _customerId = customerId;
            _customerName = customerName;

            this.Load += ThuCungCuaKhangHang_Load;
        }

        private void ThuCungCuaKhangHang_Load(object sender, EventArgs e)
        {
            dgvPets.AutoGenerateColumns = false;

            // Map cột
            colPetId.DataPropertyName = "Pet_Id";
            colPetName.DataPropertyName = "Pet_Name";
            colPetType.DataPropertyName = "Pet_Breed";
            colPetAge.DataPropertyName = "Pet_Age";
            colServiceUsed.DataPropertyName = "ServiceUsed";
            colOwnerName.DataPropertyName = "Cus_Name";

            // Cập nhật tiêu đề form
            if (!string.IsNullOrEmpty(_customerName))
            {
                this.Text = $"Thú cưng của khách hàng: {_customerName}";
            }

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Nếu có customerId thì lấy thú cưng của khách hàng cụ thể
                if (_customerId > 0)
                {
                    dgvPets.DataSource = _repo.GetPetsByCustomerId(_customerId);
                }
                else
                {
                    // Nếu không có customerId (mở form trực tiếp) thì hiển thị tất cả
                    dgvPets.DataSource = _repo.GetAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPets.Rows[e.RowIndex];

                txtId.Text = row.Cells[colPetId.Index].Value?.ToString();
                txtName.Text = row.Cells[colPetName.Index].Value?.ToString();
                txtType.Text = row.Cells[colPetType.Index].Value?.ToString();
                txtAge.Text = row.Cells[colPetAge.Index].Value?.ToString();
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
                // Tìm kiếm trong phạm vi khách hàng này (nếu có)
                if (_customerId > 0)
                {
                    dgvPets.DataSource = _repo.Search(keyword, _customerId);
                }
                else
                {
                    dgvPets.DataSource = _repo.Search(keyword);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshInput();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra có khách hàng được chọn không
            if (_customerId <= 0)
            {
                MessageBox.Show("Vui lòng mở form này từ màn hình Khách hàng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thú cưng.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PetCus newPet = new PetCus
            {
                Cus_Id = _customerId,  // Gán khách hàng hiện tại
                Pet_Name = txtName.Text.Trim(),
                Pet_Breed = txtType.Text.Trim(),
                Pet_Age = int.TryParse(txtAge.Text, out int age) ? age : (int?)null
            };

            try
            {
                int newId = _repo.Add(newPet);
                if (newId > 0)
                {
                    MessageBox.Show($"Thêm thành công! Mã Pet: {newId}", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    RefreshInput();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int petId))
            {
                MessageBox.Show("Vui lòng chọn thú cưng để sửa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PetCus petUpdate = new PetCus
            {
                Pet_Id = petId,
                Cus_Id = _customerId > 0 ? _customerId : 0, // Giữ nguyên customerId
                Pet_Name = txtName.Text.Trim(),
                Pet_Breed = txtType.Text.Trim(),
                Pet_Age = int.TryParse(txtAge.Text, out int age) ? age : (int?)null
            };

            try
            {
                if (_repo.Update(petUpdate))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    RefreshInput();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int petId))
            {
                MessageBox.Show("Vui lòng chọn thú cưng để xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa thú cưng này?\nLưu ý: Tất cả dịch vụ liên quan cũng sẽ bị xóa.",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (_repo.Delete(petId))
                    {
                        MessageBox.Show("Đã xóa thành công!", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        RefreshInput();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshInput();
        }

        private void RefreshInput()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtType.Text = "";
            txtAge.Text = "";
            txtSearch.Text = "";
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dgvPets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}