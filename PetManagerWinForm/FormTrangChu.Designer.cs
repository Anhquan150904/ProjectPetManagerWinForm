namespace PetManagerWinForm
{
    partial class FormTrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuQuanLy = new MenuStrip();
            menuQuảnLToolStripMenuItem = new ToolStripMenuItem();
            quanLyThuCungToolStripMenuItem = new ToolStripMenuItem();
            thuCungChuaBanToolStripMenuItem = new ToolStripMenuItem();
            thuCungDaBanToolStripMenuItem = new ToolStripMenuItem();
            thuCungKhachHangToolStripMenuItem = new ToolStripMenuItem();
            quanLySanPhamToolStripMenuItem = new ToolStripMenuItem();
            quanLyDichVuToolStripMenuItem = new ToolStripMenuItem();
            quanLyKhachHangToolStripMenuItem = new ToolStripMenuItem();
            quảnLyHoaDonToolStripMenuItem = new ToolStripMenuItem();
            quanLyNhanVienToolStripMenuItem = new ToolStripMenuItem();
            TaiKhoanToolStripMenuItem = new ToolStripMenuItem();
            doiMatKhauToolStripMenuItem = new ToolStripMenuItem();
            dangXuatToolStripMenuItem = new ToolStripMenuItem();
            menuQuanLy.SuspendLayout();
            SuspendLayout();
            // 
            // menuQuanLy
            // 
            menuQuanLy.BackColor = SystemColors.ControlLight;
            menuQuanLy.Font = new Font("Segoe UI", 15F);
            menuQuanLy.ImageScalingSize = new Size(20, 20);
            menuQuanLy.Items.AddRange(new ToolStripItem[] { menuQuảnLToolStripMenuItem, TaiKhoanToolStripMenuItem });
            menuQuanLy.Location = new Point(0, 0);
            menuQuanLy.Name = "menuQuanLy";
            menuQuanLy.Padding = new Padding(5, 2, 0, 2);
            menuQuanLy.Size = new Size(700, 36);
            menuQuanLy.TabIndex = 0;
            menuQuanLy.Text = "menuQuanLy";
            // 
            // menuQuảnLToolStripMenuItem
            // 
            menuQuảnLToolStripMenuItem.BackColor = SystemColors.GradientActiveCaption;
            menuQuảnLToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quanLyThuCungToolStripMenuItem, quanLySanPhamToolStripMenuItem, quanLyDichVuToolStripMenuItem, quanLyKhachHangToolStripMenuItem, quảnLyHoaDonToolStripMenuItem, quanLyNhanVienToolStripMenuItem });
            menuQuảnLToolStripMenuItem.ForeColor = SystemColors.Highlight;
            menuQuảnLToolStripMenuItem.Name = "menuQuảnLToolStripMenuItem";
            menuQuảnLToolStripMenuItem.Size = new Size(143, 32);
            menuQuảnLToolStripMenuItem.Text = "Menu quản lý";
            // 
            // quanLyThuCungToolStripMenuItem
            // 
            quanLyThuCungToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thuCungChuaBanToolStripMenuItem, thuCungDaBanToolStripMenuItem, thuCungKhachHangToolStripMenuItem });
            quanLyThuCungToolStripMenuItem.Name = "quanLyThuCungToolStripMenuItem";
            quanLyThuCungToolStripMenuItem.Size = new Size(256, 32);
            quanLyThuCungToolStripMenuItem.Text = "Quản lý thú cưng";
            // 
            // thuCungChuaBanToolStripMenuItem
            // 
            thuCungChuaBanToolStripMenuItem.Name = "thuCungChuaBanToolStripMenuItem";
            thuCungChuaBanToolStripMenuItem.Size = new Size(305, 32);
            thuCungChuaBanToolStripMenuItem.Text = "Thú cưng chưa bán";
            thuCungChuaBanToolStripMenuItem.Click += thuCungChuaBanToolStripMenuItem_Click;
            // 
            // thuCungDaBanToolStripMenuItem
            // 
            thuCungDaBanToolStripMenuItem.Name = "thuCungDaBanToolStripMenuItem";
            thuCungDaBanToolStripMenuItem.Size = new Size(305, 32);
            thuCungDaBanToolStripMenuItem.Text = "Thú cưng đã bán";
            thuCungDaBanToolStripMenuItem.Click += thuCungDaBanToolStripMenuItem_Click;
            // 
            // thuCungKhachHangToolStripMenuItem
            // 
            thuCungKhachHangToolStripMenuItem.Name = "thuCungKhachHangToolStripMenuItem";
            thuCungKhachHangToolStripMenuItem.Size = new Size(305, 32);
            thuCungKhachHangToolStripMenuItem.Text = "Thú cưng của khách hàng";
            thuCungKhachHangToolStripMenuItem.Click += thuCungKhachHangToolStripMenuItem_Click;
            // 
            // quanLySanPhamToolStripMenuItem
            // 
            quanLySanPhamToolStripMenuItem.Name = "quanLySanPhamToolStripMenuItem";
            quanLySanPhamToolStripMenuItem.Size = new Size(256, 32);
            quanLySanPhamToolStripMenuItem.Text = "Quản lý sản phẩm";
            // 
            // quanLyDichVuToolStripMenuItem
            // 
            quanLyDichVuToolStripMenuItem.Name = "quanLyDichVuToolStripMenuItem";
            quanLyDichVuToolStripMenuItem.Size = new Size(256, 32);
            quanLyDichVuToolStripMenuItem.Text = "Quản lý dịch vụ";
            // 
            // quanLyKhachHangToolStripMenuItem
            // 
            quanLyKhachHangToolStripMenuItem.Name = "quanLyKhachHangToolStripMenuItem";
            quanLyKhachHangToolStripMenuItem.Size = new Size(256, 32);
            quanLyKhachHangToolStripMenuItem.Text = "Quản lý khách hàng";
            // 
            // quảnLyHoaDonToolStripMenuItem
            // 
            quảnLyHoaDonToolStripMenuItem.Name = "quảnLyHoaDonToolStripMenuItem";
            quảnLyHoaDonToolStripMenuItem.Size = new Size(256, 32);
            quảnLyHoaDonToolStripMenuItem.Text = "Quản lý hóa đơn";
            // 
            // quanLyNhanVienToolStripMenuItem
            // 
            quanLyNhanVienToolStripMenuItem.Name = "quanLyNhanVienToolStripMenuItem";
            quanLyNhanVienToolStripMenuItem.Size = new Size(256, 32);
            quanLyNhanVienToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // TaiKhoanToolStripMenuItem
            // 
            TaiKhoanToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            TaiKhoanToolStripMenuItem.BackColor = SystemColors.GradientActiveCaption;
            TaiKhoanToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doiMatKhauToolStripMenuItem, dangXuatToolStripMenuItem });
            TaiKhoanToolStripMenuItem.ForeColor = SystemColors.Highlight;
            TaiKhoanToolStripMenuItem.Name = "TaiKhoanToolStripMenuItem";
            TaiKhoanToolStripMenuItem.Size = new Size(106, 32);
            TaiKhoanToolStripMenuItem.Text = "Tài khoản";
            // 
            // doiMatKhauToolStripMenuItem
            // 
            doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            doiMatKhauToolStripMenuItem.Size = new Size(201, 32);
            doiMatKhauToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // dangXuatToolStripMenuItem
            // 
            dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            dangXuatToolStripMenuItem.Size = new Size(201, 32);
            dangXuatToolStripMenuItem.Text = "Đăng xuất";
            // 
            // FormTrangChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(menuQuanLy);
            MainMenuStrip = menuQuanLy;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormTrangChu";
            Text = "FormTrangChu";
            menuQuanLy.ResumeLayout(false);
            menuQuanLy.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuQuanLy;
        private ToolStripMenuItem menuQuảnLToolStripMenuItem;
        private ToolStripMenuItem quanLyThuCungToolStripMenuItem;
        private ToolStripMenuItem thuCungChuaBanToolStripMenuItem;
        private ToolStripMenuItem thuCungDaBanToolStripMenuItem;
        private ToolStripMenuItem thuCungKhachHangToolStripMenuItem;
        private ToolStripMenuItem quanLySanPhamToolStripMenuItem;
        private ToolStripMenuItem quanLyKhachHangToolStripMenuItem;
        private ToolStripMenuItem quanLyDichVuToolStripMenuItem;
        private ToolStripMenuItem quảnLyHoaDonToolStripMenuItem;
        private ToolStripMenuItem quanLyNhanVienToolStripMenuItem;
        private ToolStripMenuItem TaiKhoanToolStripMenuItem;
        private ToolStripMenuItem doiMatKhauToolStripMenuItem;
        private ToolStripMenuItem dangXuatToolStripMenuItem;
    }
}