using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetManagerData.Models; // Đảm bảo namespace này đúng với project của bạn

namespace PetManagerWinForm.NghiepVu.QLKhachHang
{
    public partial class ThongTinKhachHang : Form
    {
        public ThongTinKhachHang()
        {
            InitializeComponent();
            // Sự kiện Load đã được gán trong Designer hoặc gán ở đây
            this.Load += ThongTinKhachHang_Load;
        }

        private List<Customer> cus = new List<Customer>();
        private int idoldcus;

        private void ThongTinKhachHang_Load(object sender, EventArgs e)
        {
            // 1. QUAN TRỌNG: Tắt tự động sinh cột để không bị thừa cột
            dgvCustomers.AutoGenerateColumns = false;

            // 2. Ánh xạ dữ liệu: Gắn tên Property của class Customer vào từng cột giao diện
            // Lưu ý: Chuỗi string phải trùng khớp chính xác tên biến trong class Customer
            colCusId.DataPropertyName = "Cus_Id";
            colCusName.DataPropertyName = "Cus_Name";
            colAddress.DataPropertyName = "Address";
            colPhoneNumber.DataPropertyName = "Cus_PhoneNumber"; // Kiểm tra kỹ tên property trong class Model
            colEmail.DataPropertyName = "Cus_Email";

            // Tạo dữ liệu giả
            cus = new List<Customer>()
            {
                new Customer { Cus_Id = 1, Cus_Name = "Khách Hàng A", Address = "Hcm", Cus_Email ="ssss@gmail.com" ,Cus_PhoneNumber = "0999999999"},
                new Customer { Cus_Id = 2, Cus_Name = "Lò Văn Việt", Address = "Hà Nội", Cus_Email ="viet@gmail.com" ,Cus_PhoneNumber = "0988888888"},
                new Customer { Cus_Id = 3, Cus_Name = "Vẹt Xanh", Address = "Đà Nẵng", Cus_Email = "vet@gmail.com", Cus_PhoneNumber = "0977777777"}
            };

            // Đổ dữ liệu
            dgvCustomers.DataSource = cus;
        }

        private void RefreshGrid()
        {
            // Reset datasource để cập nhật lại giao diện
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = cus;
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                // Lấy dòng hiện tại đang chọn (đối tượng Customer)
                // Cách an toàn hơn là lấy từ list gốc hoặc ép kiểu DataBoundItem
                // Tuy nhiên, để sửa nhanh theo code cũ của bạn, ta truy cập qua tên cột Design:

                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];

                // Lưu ý: Phải dùng tên biến cột (colCusId) hoặc tên Name trong Design ("colCusId")
                // Code cũ của bạn dùng "Cus_Id" sẽ lỗi vì đó là tên Property, không phải tên cột trong Grid

                txtId.Text = row.Cells[colCusId.Index].Value?.ToString();
                txtName.Text = row.Cells[colCusName.Index].Value?.ToString();
                txtAddress.Text = row.Cells[colAddress.Index].Value?.ToString();
                txtPhoneNumber.Text = row.Cells[colPhoneNumber.Index].Value?.ToString();
                txtEmail.Text = row.Cells[colEmail.Index].Value?.ToString();

                if (int.TryParse(txtId.Text, out int parsedId)) {
                    idoldcus = parsedId;
                    // MessageBox.Show("Đã chọn ID gốc = " + idoldcus); // Comment lại cho đỡ phiền khi test
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 1. Tự động tính toán ID mới
            int newId = 1; // Mặc định là 1 nếu danh sách rỗng
            if (cus.Count > 0) {
                // Lấy ID lớn nhất hiện tại + 1
                newId = cus.Max(c => c.Cus_Id) + 1;
            }

            // 2. Validate dữ liệu nhập (Tên, SDT...)
            if (string.IsNullOrWhiteSpace(txtName.Text)) {
                MessageBox.Show("Vui lòng nhập tên khách hàng.");
                return;
            }

            // 3. Tạo đối tượng mới với ID vừa tính
            Customer newCus = new Customer {
                Cus_Id = newId, // Sử dụng ID tự tăng
                Cus_Name = txtName.Text,
                Address = txtAddress.Text,
                Cus_Email = txtEmail.Text,
                Cus_PhoneNumber = txtPhoneNumber.Text
            };

            // 4. Thêm vào danh sách và cập nhật Grid
            cus.Add(newCus);
            RefreshGrid();

            // 5. Xóa trắng các ô nhập liệu để sẵn sàng nhập người tiếp theo
            Refresh();

            MessageBox.Show($"Thêm thành công khách hàng với ID: {newId}");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id)) return;

            Customer cusUpdate = cus.FirstOrDefault(c => c.Cus_Id == id);

            if (cusUpdate == null) {
                MessageBox.Show("Không tìm thấy khách để cập nhật.");
                return;
            }

            cusUpdate.Cus_Name = txtName.Text;
            cusUpdate.Address = txtAddress.Text;
            cusUpdate.Cus_Email = txtEmail.Text;
            cusUpdate.Cus_PhoneNumber = txtPhoneNumber.Text;

            RefreshGrid();
            MessageBox.Show("Cập nhật thành công!");
        }

        public new void Refresh() // Lưu ý: Form đã có hàm Refresh(), nên dùng 'new' hoặc đổi tên hàm thành ClearInput
        {
            txtId.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id)) return;

            var cusDelete = cus.FirstOrDefault(c => c.Cus_Id == id);

            if (cusDelete == null) {
                MessageBox.Show("Không tìm thấy khách để xóa.");
                return;
            }

            DialogResult confirm = MessageBox.Show($"Bạn có chắc muốn xóa khách hàng {cusDelete.Cus_Name}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes) {
                cus.Remove(cusDelete);
                Refresh(); // Xóa trắng các ô nhập liệu sau khi xóa
                RefreshGrid();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword)) {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!");
                return;
            }

            List<Customer> result = new List<Customer>();

            foreach (Customer c in cus) {
                // Cần check null trước khi gọi ToString() hoặc ToLower() để tránh lỗi
                string idStr = c.Cus_Id.ToString();
                string nameStr = c.Cus_Name?.ToLower() ?? "";
                string phoneStr = c.Cus_PhoneNumber?.ToLower() ?? "";

                bool idMatch = idStr.Contains(keyword);
                bool nameMatch = nameStr.Contains(keyword);
                bool phoneMatch = phoneStr.Contains(keyword);

                if (idMatch || nameMatch || phoneMatch) {
                    result.Add(c);
                }
            }

            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = result;

            MessageBox.Show($"Tìm thấy {result.Count} kết quả.");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh(); // Xóa ô nhập liệu
            btnShowAll_Click(null, null); // Load lại toàn bộ danh sách
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnTransHis_Click(object sender, EventArgs e)
        {
            // Code xử lý lịch sử giao dịch
        }
    }
}