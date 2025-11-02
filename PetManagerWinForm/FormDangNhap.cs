using PetManagerWinForm.Controllers;
using System.Configuration;
namespace PetManagerWinForm
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["PetDb"].ConnectionString;
            DangNhapController dangNhap = new DangNhapController(connStr);

            bool hopLe = dangNhap.KiemTraDangNhap(txtUser.Text, txtPassword.Text);

            if (hopLe)
            {
                MessageBox.Show("Đăng nhập thành công!");
                // mở form chính
                FormTrangChu formTrangChu = new FormTrangChu();
                formTrangChu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }
    }
}
