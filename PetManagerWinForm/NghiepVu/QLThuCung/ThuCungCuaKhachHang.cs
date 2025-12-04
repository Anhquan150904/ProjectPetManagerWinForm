using PetManagerData.Controllers; // Giả sử có CustomerPetServiceController
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace PetManagerWinForm.NghiepVu.QLThuCung
{
    // Đổi tên form
    public partial class QLThuCungDichVu : Form
    {
        // Khởi tạo Controller cho nghiệp vụ mới
        private CustomerPetServiceController _cpsController;

        public QLThuCungDichVu()
        {
            InitializeComponent();
        }

        // Hàm làm sạch TextBox/Controls
        public void RefreshForm()
        {
            txtPetId.Text = "";
            txtPetName.Text = "";
            txtPetAge.Text = "";
            cmbService.DataSource = null; // Hoặc gán lại danh sách dịch vụ nếu cần
            cmbService.Text = "";
        }

        private void QLThuCungDichVu_Load(object sender, EventArgs e)
        {
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["PetDb"].ConnectionString;
                // Khởi tạo BLL/Controller mới
                _cpsController = new CustomerPetServiceController(connStr);

                // Tải dữ liệu các dịch vụ đang được sử dụng
                LoadServicesInProgress();
                // Tải danh sách dịch vụ vào ComboBox
                LoadServiceComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm tải danh sách dịch vụ (để hiển thị/chọn)
        private void LoadServiceComboBox()
        {
            // Giả sử có hàm lấy tất cả dịch vụ từ Controller
            var dtServices = _cpsController.GetAllServices();
            cmbService.DataSource = dtServices;
            cmbService.DisplayMember = "ServiceName"; // Tên cột hiển thị
            cmbService.ValueMember = "ServiceId";     // Tên cột lấy giá trị
            cmbService.SelectedIndex = -1; // Không chọn gì ban đầu
        }

        // Hàm tải dữ liệu dịch vụ đang sử dụng
        private void LoadServicesInProgress()
        {
            // Giả sử Controller có hàm lấy tất cả các dịch vụ đang được sử dụng (Status = 'In Use')
            var dt = _cpsController.GetServicesInProgress();

            dgvCustomerPets.AutoGenerateColumns = false;
            dgvCustomerPets.DataSource = dt;
            // colPetId, colPetName, colPetAge, colServiceName... đã được thiết lập DataPropertyName
        }

        private void dgvCustomerPets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvCustomerPets.Rows[e.RowIndex];

            // Hiển thị lên Controls
            txtPetId.Text = row.Cells["colPetId"].Value?.ToString() ?? "";
            txtPetName.Text = row.Cells["colPetName"].Value?.ToString() ?? "";
            txtPetAge.Text = row.Cells["colPetAge"].Value?.ToString() ?? "";

            // Gán dịch vụ đang sử dụng lên ComboBox
            string serviceName = row.Cells["colServiceName"].Value?.ToString();
            if (!string.IsNullOrEmpty(serviceName))
            {
                cmbService.Text = serviceName;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm (Tên thú cưng hoặc Dịch vụ).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Giả sử có hàm tìm kiếm theo tên pet hoặc tên dịch vụ
                DataTable dt = _cpsController.SearchServicesInProgress(keyword);

                dgvCustomerPets.DataSource = dt;

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Làm mới form và tải lại dữ liệu
            RefreshForm();
            LoadServicesInProgress();
        }

        private void btnDoneService_Click(object sender, EventArgs e)
        {
            if (dgvCustomerPets.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần hoàn thành trong danh sách.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy ID của bản ghi CustomerPetService đang được chọn
            int cpsId = Convert.ToInt32(dgvCustomerPets.SelectedRows[0].Cells["colCPS_Id"].Value);

            if (MessageBox.Show("Xác nhận đã **XONG** dịch vụ này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Giả sử Controller có hàm cập nhật trạng thái
                    _cpsController.MarkServiceDone(cpsId);
                    MessageBox.Show("Dịch vụ đã được cập nhật hoàn thành!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadServicesInProgress(); // Tải lại danh sách
                    RefreshForm(); // Làm sạch form nhập
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}