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
    }
}
