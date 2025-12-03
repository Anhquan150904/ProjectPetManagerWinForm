using PetManagerData.Controllers; // Business Logic Layer (BLL)
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace PetManagerWinForm.NghiepVu.QLThuCung
{
    public partial class ThuCungChuaBan : Form
    {
        private PetController _petController;

        public ThuCungChuaBan()
        {
            InitializeComponent();
        }

        // Hàm làm sạch TextBox (Giữ nguyên)
        public void Refresh()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtType.Text = "";
            txtAge.Text = "";
            txtPrice.Text = "";
        }

        private void ThuCungChuaBan_Load(object sender, EventArgs e)
        {
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["PetDb"].ConnectionString;
                _petController = new PetController(connStr); // Khởi tạo BLL


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
            // Gọi BLL để lấy dữ liệu thú cưng chưa bán
            var dt = _petController.GetPetsNotSold();

            dgvPets.AutoGenerateColumns = false;
            dgvPets.DataSource = dt;

            // Mapping DataPropertyName (Giữ nguyên)
            colPetId.DataPropertyName = "PetId";
            colPetName.DataPropertyName = "PetName";
            colPetType.DataPropertyName = "Type";
            colPetAge.DataPropertyName = "Age";
            colPetPrice.DataPropertyName = "Price";
        }

        private void dgvPets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvPets.Rows[e.RowIndex];

            // Đảm bảo dữ liệu không null trước khi chuyển đổi
            if (row.Cells["colPetId"].Value == null) return;

            int petId = Convert.ToInt32(row.Cells["colPetId"].Value);
            string petName = row.Cells["colPetName"].Value?.ToString() ?? "";
            string petType = row.Cells["colPetType"].Value?.ToString() ?? "";
            int petAge = Convert.ToInt32(row.Cells["colPetAge"].Value);
            decimal petPrice = Convert.ToDecimal(row.Cells["colPetPrice"].Value);

            // Hiển thị lên TextBox
            txtId.Text = petId.ToString();
            txtName.Text = petName;
            txtType.Text = petType;
            txtAge.Text = petAge.ToString();
            txtPrice.Text = petPrice.ToString();

            // Xử lý click nút (Nếu bạn đã thêm các nút vào GridView)
            string columnName = dgvPets.Columns[e.ColumnIndex].Name;

            switch (columnName)
            {
                // Logic xử lý nút trong Gridview: XÓA
                case "btnDelete":
                    var confirmDelete = MessageBox.Show($"Bạn có chắc muốn xóa {petName}?",
                                                        "Xác nhận", MessageBoxButtons.YesNo);
                    if (confirmDelete == DialogResult.Yes)
                    {
                        bool success = _petController.DeletePet(petId); // Gọi BLL
                        MessageBox.Show(success ? "Xóa thành công!" : "Xóa thất bại!");
                        if (success) LoadPets();
                    }
                    break;

                    // (Thêm các case khác nếu có nút trong GridView)
                    // Ví dụ: case "btnEdit": (Nếu bạn dùng nút Edit trong grid thay vì nút Update ngoài form)
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

                bool success = _petController.InsertPet(name, type, age, price); // Gọi BLL
                MessageBox.Show(success ? "Thêm thành công!" : "Thêm thất bại!");

                if (success)
                    LoadPets();
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

                bool success = _petController.UpdatePet(id, name, type, age, price); // Gọi BLL
                MessageBox.Show(success ? "Cập nhật thành công!" : "Cập nhật thất bại!");

                if (success)
                    LoadPets();
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
                    bool success = _petController.DeletePet(id); // Gọi BLL
                    MessageBox.Show(success ? "Xóa thành công!" : "Xóa thất bại!");
                    if (success)
                        LoadPets();
                    Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }


        private void btn_Search_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
                return;
            }

            try
            {
                // Gọi hàm SearchPetsNotSold mới trong BLL
                DataTable dt = _petController.SearchPetsNotSold(keyword);

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
            txtSearch.Text = "";
            LoadPets();
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}