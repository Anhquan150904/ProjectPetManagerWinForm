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
    }
}
