using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetManagerWinForm.NghiepVu.QLKhachHang
{
    public partial class ThuCungCuaKhangHang : Form
    {
        public ThuCungCuaKhangHang()
        {
            InitializeComponent();
        }
        // 1. Sự kiện khi click vào một dòng trong bảng
        private void dgvPets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Viết code hiển thị dữ liệu từ dòng được chọn lên các TextBox tại đây
        }

        // 2. Nút Tìm kiếm
        private void btnFind_Click(object sender, EventArgs e)
        {
            // Viết code tìm kiếm tại đây
        }

        // 3. Nút Hiển thị tất cả
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            // Viết code load lại toàn bộ danh sách tại đây
        }

        // 4. Nút Thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Viết code thêm mới thú cưng tại đây
        }

        // 5. Nút Cập nhật (Sửa)
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Viết code cập nhật thông tin tại đây
        }

        // 6. Nút Xóa
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Viết code xóa tại đây
        }

        // 7. Nút Làm mới
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Viết code xóa trắng các ô nhập liệu tại đây
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
