using PetManagerData.Controllers;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PetManagerWinForm.NghiepVu.QLThuCung
{
    public partial class ThuCungChuaBan : Form
    {
        private PetController _petController;

        public ThuCungChuaBan()
        {
            InitializeComponent();
        }
        // Hàm này dùng để thêm 2 cột "Edit" và "Delete" vào grid
        private void SetupGridViewButtons()
        {
            // Nút Edit
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.HeaderText = "Edit";
            btnEdit.Name = "btnEdit";
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;
            dgvPets.Columns.Add(btnEdit);

            // Nút Delete
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "Delete";
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            dgvPets.Columns.Add(btnDelete);
        }

        private void ThuCungChuaBan_Load(object sender, EventArgs e)
        {
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["PetDb"].ConnectionString;
                _petController = new PetController(connStr);

                SetupGridViewButtons();

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
            var dt = _petController.GetPetsNotSold();

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
            int petId = Convert.ToInt32(row.Cells["PetId"].Value);
            string petName = row.Cells["PetName"].Value.ToString();
            string petType = row.Cells["PetType"].Value.ToString();
            int petAge = Convert.ToInt32(row.Cells["PetAge"].Value);
            decimal petPrice = Convert.ToDecimal(row.Cells["PetPrice"].Value);

            // Hiển thị lên TextBox
            txtId.Text = petId.ToString();
            txtName.Text = petName;
            txtType.Text = petType;
            txtAge.Text = petAge.ToString();
            txtPrice.Text = petPrice.ToString();

            // Xử lý click nút (chỉ nút trong grid)
            string columnName = dgvPets.Columns[e.ColumnIndex].Name;

            switch (columnName)
            {
                case "btnEdit":
                    MessageBox.Show($"Bạn đang chọn sửa thú cưng: {petName}. Hãy sửa thông tin bên phải và nhấn 'Update'.");
                    break;

                case "btnDelete":
                    var confirmDelete = MessageBox.Show($"Bạn có chắc muốn xóa {petName}?",
                                                      "Xác nhận", MessageBoxButtons.YesNo);
                    if (confirmDelete == DialogResult.Yes)
                    {
                        bool success = _petController.DeletePet(petId);
                        MessageBox.Show(success ? "Xóa thành công!" : "Xóa thất bại!");
                        LoadPets();
                    }
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy data từ TextBox
                string name = txtName.Text;
                string type = txtType.Text;
                int age = Convert.ToInt32(txtAge.Text);
                decimal price = Convert.ToDecimal(txtPrice.Text);

                bool success = _petController.AddPet(name, type, age, price);
                MessageBox.Show(success ? "Thêm thành công!" : "Thêm thất bại!");

                if (success)
                    LoadPets(); // Tải lại 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }

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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void btnSold_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                if (id <= 0)
                {
                    MessageBox.Show("Vui lòng chọn thú cưng từ lưới trước.");
                    return;
                }

                var confirmSold = MessageBox.Show($"Đánh dấu thú cưng ID {id} là đã bán?",
                                                  "Xác nhận", MessageBoxButtons.YesNo);
                if (confirmSold == DialogResult.Yes)
                {
                    bool success = _petController.MarkAsSold(id);
                    MessageBox.Show(success ? "Đã đánh dấu 'Đã bán'!" : "Không thể đánh dấu!");
                    if (success)
                        LoadPets(); // Tải lại 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đánh dấu đã bán: " + ex.Message);
            }
        }
    }
}