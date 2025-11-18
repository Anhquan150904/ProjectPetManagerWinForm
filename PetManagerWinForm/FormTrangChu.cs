using PetManagerWinForm.NghiepVu.QLThuCung;
using PetManagerWinForm.NghiepVu.QLKhachHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetManagerWinForm.NghiepVu.QLSanPham;
using PetManagerWinForm.NghiepVu.QLDichVu;
using PetManagerWinForm.NghiepVu.QLHoaDon;
using PetManagerWinForm.NghiepVu.QLNhanVien;

namespace PetManagerWinForm
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }

        private void thuCungChuaBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThuCungChuaBan frm = new ThuCungChuaBan();
            frm.Show();
        }

        private void thuCungDaBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThuCungDaBan frm = new ThuCungDaBan();
            frm.Show();
        }

        private void thuCungKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThuCungCuaKhachHang frm = new ThuCungCuaKhachHang();
            frm.Show();
        }

        private void thongTinKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinKhachHang frm = new ThongTinKhachHang();
            frm.Show();
        }

        private void lichSuGiaoDichToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LichSuGiaoDich frm = new LichSuGiaoDich();
            frm.Show();
        }

        private void quanLySanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySanPham frm = new QuanLySanPham();
            frm.Show();
        }

        private void quanLyDichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDichVu quanLyDichVu = new QuanLyDichVu();
            quanLyDichVu.Show();
        }

        private void quảnLyHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHoaDon frm = new QuanLyHoaDon();
            frm.Show();
        }

        private void quanLyNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien quanLyNhanVien = new QuanLyNhanVien();
            quanLyNhanVien.Show();
        }
    }
}
