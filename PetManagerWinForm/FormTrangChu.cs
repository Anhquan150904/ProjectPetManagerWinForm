using System;
using System.Windows.Forms;
using PetManagerWinForm.NghiepVu.QLThuCung;
using PetManagerWinForm.NghiepVu.QLKhachHang;
using PetManagerWinForm.NghiepVu.QLSanPham;
using PetManagerWinForm.NghiepVu.QLDichVu;
using PetManagerWinForm.NghiepVu.QLHoaDon;
using PetManagerWinForm.NghiepVu.QLNhanVien;
using PetManagerWinForm.NghiepVu;

namespace PetManagerWinForm
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }

        private void LoadForm(Form frm)
        {
            panelContent.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(frm);
            frm.Show();
        }

        private Button currentButton = null;

        private void SetActiveButton(Button btn)
        {
            // Nếu có nút cũ -> reset màu
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(255, 224, 192);
            }

            // Đặt nút mới
            currentButton = btn;
            currentButton.BackColor = Color.FromArgb(238, 213, 210); // màu nổi bật
        }

        private void btnThuCungChuaBan_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            LoadForm(new ThuCungChuaBan());
        }

        private void btnThuCungDaBan_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            LoadForm(new ThuCungDaBan());
        }

        private void btnThuCungKhachHang_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            LoadForm(new ThuCungCuaKhachHang());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            LoadForm(new ThongTinKhachHang());
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            LoadForm(new QuanLySanPham());
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            LoadForm(new QuanLyDichVu());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            LoadForm(new QuanLyHoaDon());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            LoadForm(new QuanLyNhanVien());
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            LoadForm(new FrmThanhToan());
        }

    }
}
