using PetManagerData.Controllers; 
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace PetManagerWinForm.NghiepVu.QLThuCung
{
    public partial class ThuCungDaBan : Form
    {
        private PetController _petController;

        public ThuCungDaBan()
        {
            InitializeComponent();
        }

        // Hàm làm sạch TextBox
        public void Refresh()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtType.Text = "";
            txtAge.Text = "";
            txtPrice.Text = "";
        }

        private void ThuCungDaBan_Load(object sender, EventArgs e)
        {
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["PetDb"].ConnectionString;
                _petController = new PetController(connStr); // Khởi tạo BLL

                // Tải dữ liệu thú cưng ĐÃ bán
                LoadSoldPets();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm tải dữ liệu thú cưng ĐÃ bán
        private void LoadSoldPets()
        {
            // Gọi BLL để lấy dữ liệu thú cưng chưa bán
            var dt = _petController.GetPetsIsSold();

            dgvPets.AutoGenerateColumns = false;
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

            DataGridViewRow row = dgvPets.Rows[e.RowIndex];

            // Hiển thị lên TextBox
            // Đảm bảo cột có dữ liệu trước khi gọi .ToString()
            txtId.Text = row.Cells["colPetId"].Value?.ToString() ?? "";
            txtName.Text = row.Cells["colPetName"].Value?.ToString() ?? "";
            txtType.Text = row.Cells["colPetType"].Value?.ToString() ?? "";
            txtAge.Text = row.Cells["colPetAge"].Value?.ToString() ?? "";
            txtPrice.Text = row.Cells["colPetPrice"].Value?.ToString() ?? "";
        }



        private void btn_Search_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = _petController.SearchPetsIsSold(keyword); 

                dgvPets.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả nào.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadSoldPets();
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}