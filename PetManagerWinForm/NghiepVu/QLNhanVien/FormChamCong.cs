using System;
using System.Data; // <--- Đừng quên dòng này
using System.Windows.Forms;

namespace PetManagerWinForm.NghiepVu.QLNhanVien
{
    public partial class FormChamCong : Form
    {
        private DataTable duLieuNhanVien;

        // Sửa constructor nhận DataTable
        public FormChamCong(DataTable dt)
        {
            InitializeComponent();
            this.duLieuNhanVien = dt;
        }

        private void FormChamCong_Load(object sender, EventArgs e)
        {
            // Code xử lý khi load form chấm công sau này viết ở đây
        }
    }
}