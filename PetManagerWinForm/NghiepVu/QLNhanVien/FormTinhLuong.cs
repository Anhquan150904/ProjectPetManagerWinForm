using System;
using System.Data; // <--- Đừng quên dòng này
using System.Windows.Forms;

namespace PetManagerWinForm.NghiepVu.QLNhanVien
{
    public partial class FormTinhLuong : Form
    {
        private DataTable duLieuNhanVien;

        // Sửa constructor nhận DataTable
        public FormTinhLuong(DataTable dt)
        {
            InitializeComponent();
            this.duLieuNhanVien = dt;
        }

        private void FormTinhLuong_Load(object sender, EventArgs e)
        {
            // Code xử lý khi load form tính lương sau này viết ở đây
        }
    }
}