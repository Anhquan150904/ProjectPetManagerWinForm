using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; // <--- Quan trọng: Phải có dòng này mới hiểu DataTable là gì
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetManagerWinForm.NghiepVu.QLNhanVien
{
    public partial class FormPhanCa : Form
    {
        // Tạo một biến để lưu trữ danh sách nhân viên được truyền sang
        private DataTable duLieuNhanVien;

        // --- SỬA DÒNG NÀY ---
        // Thêm "DataTable dt" vào trong ngoặc
        public FormPhanCa(DataTable dt)
        {
            InitializeComponent();

            // Lưu dữ liệu nhận được vào biến của Form này để dùng sau này
            this.duLieuNhanVien = dt;
        }

        private void FormPhanCa_Load(object sender, EventArgs e)
        {
            // Ví dụ: Kiểm tra xem dữ liệu đã qua chưa
            // MessageBox.Show("Đã nhận được danh sách " + duLieuNhanVien.Rows.Count + " nhân viên!");
        }
    }
}