using PetManagerData.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace PetManagerWinForm.NghiepVu.QLThuCung
{
    public partial class ThuCungDaBan : Form
    {
        private PetController _petController;
        public ThuCungDaBan()
        {
            InitializeComponent();
            ThuCungDaBan_Load();
        }
        public void Refresh()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtType.Text = "";
            txtAge.Text = "";
            txtPrice.Text = "";
        }
        private void ThuCungDaBan_Load()
        {
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["PetDb"].ConnectionString;
                _petController = new PetController(connStr);

                // Tải dữ liệu
                LoadPets();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPets()
        {
            var dt = _petController.GetPetsIsSold();

            dgvPets.AutoGenerateColumns = false; // dùng cột có sẵn
            dgvPets.DataSource = dt;

            colPetId.DataPropertyName = "PetId";
            colPetName.DataPropertyName = "PetName";
            colPetType.DataPropertyName = "Type";
            colPetAge.DataPropertyName = "Age";
            colPetPrice.DataPropertyName = "Price";
        }

        private void dgvPets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Lấy dữ liệu ô của dòng hiện tại
            DataGridViewRow row = dgvPets.Rows[e.RowIndex];

            // Truy cập cột bằng TÊN định nghĩa trong Designer
            int petId = Convert.ToInt32(row.Cells["colPetId"].Value);
            string petName = row.Cells["colPetName"].Value.ToString();
            string petType = row.Cells["colPetType"].Value.ToString();
            int petAge = Convert.ToInt32(row.Cells["colPetAge"].Value);
            decimal petPrice = Convert.ToDecimal(row.Cells["colPetPrice"].Value);

            // Hiển thị lên TextBox
            txtId.Text = petId.ToString();
            txtName.Text = petName;
            txtType.Text = petType;
            txtAge.Text = petAge.ToString();
            txtPrice.Text = petPrice.ToString();
        }

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Lấy data từ TextBox
        //        string name = txtName.Text;
        //        string type = txtType.Text;
        //        int age = Convert.ToInt32(txtAge.Text);
        //        decimal price = Convert.ToDecimal(txtPrice.Text);

        //        bool success = _petController.AddPet(name, type, age, price);
        //        MessageBox.Show(success ? "Thêm thành công!" : "Thêm thất bại!");

        //        if (success)
        //            LoadPets(); // Tải lại 
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi thêm: " + ex.Message);
        //    }
        //}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy data từ TextBox
                int id = Convert.ToInt32(txtId.Text);
                string name = txtName.Text;
                string type = txtType.Text;
                int age = Convert.ToInt32(txtAge.Text);
                decimal price = Convert.ToDecimal(txtPrice.Text);

                bool success = _petController.UpdatePet(id, name, type, age, price);
                MessageBox.Show(success ? "Cập nhật thành công!" : "Cập nhật thất bại!");

                if (success)
                    LoadPets(); // Tải lại 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                if (id <= 0)
                {
                    MessageBox.Show("Vui lòng chọn thú cưng từ lưới trước.");
                    return;
                }

                var confirmDelete = MessageBox.Show($"Bạn có chắc muốn xóa thú cưng ID {id}?",
                                                  "Xác nhận", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    bool success = _petController.DeletePet(id);
                    MessageBox.Show(success ? "Xóa thành công!" : "Xóa thất bại!");
                    if (success)
                        LoadPets(); // Tải lại 
                    Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void btnCancelSold_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                if (id <= 0)
                {
                    MessageBox.Show("Vui lòng chọn thú cưng từ lưới trước.");
                    return;
                }

                var confirmSold = MessageBox.Show($"Hủy bán thú cưng ID {id}?",
                                                  "Xác nhận", MessageBoxButtons.YesNo);
                if (confirmSold == DialogResult.Yes)
                {
                    bool success = _petController.ReturnMarkAsSold(id);
                    MessageBox.Show(success ? "Đã hủy đánh dấu 'Đã bán'!" : "Không thể đánh dấu!");
                    if (success)
                        LoadPets(); // Tải lại 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đánh dấu đã bán: " + ex.Message);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            // Lấy nội dung từ ô tìm kiếm
            string keyword = txtSearch.Text;

            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
                return;
            }

            try
            {
                // Gọi hàm SearchPets mới trong controller
                DataTable dt = _petController.SearchPets(keyword);

                // Cập nhật DataGridView với kết quả tìm kiếm
                dgvPets.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả nào.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Text = ""; // Xóa ô tìm kiếm
            LoadPets(); // Chỉ cần gọi lại hàm LoadPets gốc
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

    }
}
