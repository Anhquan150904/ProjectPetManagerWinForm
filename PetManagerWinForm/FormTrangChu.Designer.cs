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
            thôngTinKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            lịchSửGiaoDịchToolStripMenuItem = new ToolStripMenuItem();
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
            menuQuanLy.Padding = new Padding(6, 3, 0, 3);
            menuQuanLy.Size = new Size(800, 45);
            menuQuanLy.TabIndex = 0;
            menuQuanLy.Text = "menuQuanLy";
            // 
            // menuQuảnLToolStripMenuItem
            // 
            menuQuảnLToolStripMenuItem.BackColor = SystemColors.GradientActiveCaption;
            menuQuảnLToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quanLyThuCungToolStripMenuItem, quanLySanPhamToolStripMenuItem, quanLyDichVuToolStripMenuItem, quanLyKhachHangToolStripMenuItem, quảnLyHoaDonToolStripMenuItem, quanLyNhanVienToolStripMenuItem });
            menuQuảnLToolStripMenuItem.ForeColor = SystemColors.Highlight;
            menuQuảnLToolStripMenuItem.Name = "menuQuảnLToolStripMenuItem";
            menuQuảnLToolStripMenuItem.Size = new Size(180, 39);
            menuQuảnLToolStripMenuItem.Text = "Menu quản lý";
            // 
            // quanLyThuCungToolStripMenuItem
            // 
            quanLyThuCungToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thuCungChuaBanToolStripMenuItem, thuCungDaBanToolStripMenuItem, thuCungKhachHangToolStripMenuItem });
            quanLyThuCungToolStripMenuItem.Name = "quanLyThuCungToolStripMenuItem";
            quanLyThuCungToolStripMenuItem.Size = new Size(324, 40);
            quanLyThuCungToolStripMenuItem.Text = "Quản lý thú cưng";
            // 
            // thuCungChuaBanToolStripMenuItem
            // 
            thuCungChuaBanToolStripMenuItem.Name = "thuCungChuaBanToolStripMenuItem";
            thuCungChuaBanToolStripMenuItem.Size = new Size(389, 40);
            thuCungChuaBanToolStripMenuItem.Text = "Thú cưng chưa bán";
            thuCungChuaBanToolStripMenuItem.Click += thuCungChuaBanToolStripMenuItem_Click;
            // 
            // thuCungDaBanToolStripMenuItem
            // 
            thuCungDaBanToolStripMenuItem.Name = "thuCungDaBanToolStripMenuItem";
            thuCungDaBanToolStripMenuItem.Size = new Size(389, 40);
            thuCungDaBanToolStripMenuItem.Text = "Thú cưng đã bán";
            thuCungDaBanToolStripMenuItem.Click += thuCungDaBanToolStripMenuItem_Click;
            // 
            // thuCungKhachHangToolStripMenuItem
            // 
            thuCungKhachHangToolStripMenuItem.Name = "thuCungKhachHangToolStripMenuItem";
            thuCungKhachHangToolStripMenuItem.Size = new Size(389, 40);
            thuCungKhachHangToolStripMenuItem.Text = "Thú cưng của khách hàng";
            thuCungKhachHangToolStripMenuItem.Click += thuCungKhachHangToolStripMenuItem_Click;
            // 
            // quanLySanPhamToolStripMenuItem
            // 
            quanLySanPhamToolStripMenuItem.Name = "quanLySanPhamToolStripMenuItem";
            quanLySanPhamToolStripMenuItem.Size = new Size(324, 40);
            quanLySanPhamToolStripMenuItem.Text = "Quản lý sản phẩm";
            quanLySanPhamToolStripMenuItem.Click += quanLySanPhamToolStripMenuItem_Click;
            // 
            // quanLyDichVuToolStripMenuItem
            // 
            quanLyDichVuToolStripMenuItem.Name = "quanLyDichVuToolStripMenuItem";
            quanLyDichVuToolStripMenuItem.Size = new Size(324, 40);
            quanLyDichVuToolStripMenuItem.Text = "Quản lý dịch vụ";
            quanLyDichVuToolStripMenuItem.Click += quanLyDichVuToolStripMenuItem_Click;
            // 
            // quanLyKhachHangToolStripMenuItem
            // 
            quanLyKhachHangToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinKháchHàngToolStripMenuItem, lịchSửGiaoDịchToolStripMenuItem });
            quanLyKhachHangToolStripMenuItem.Name = "quanLyKhachHangToolStripMenuItem";
            quanLyKhachHangToolStripMenuItem.Size = new Size(324, 40);
            quanLyKhachHangToolStripMenuItem.Text = "Quản lý khách hàng";
            // 
            // thôngTinKháchHàngToolStripMenuItem
            // 
            thôngTinKháchHàngToolStripMenuItem.Name = "thôngTinKháchHàngToolStripMenuItem";
            thôngTinKháchHàngToolStripMenuItem.Size = new Size(357, 40);
            thôngTinKháchHàngToolStripMenuItem.Text = "Thông Tin Khách Hàng";
            thôngTinKháchHàngToolStripMenuItem.Click += thongTinKhachHangToolStripMenuItem_Click;
            // 
            // lịchSửGiaoDịchToolStripMenuItem
            // 
            lịchSửGiaoDịchToolStripMenuItem.Name = "lịchSửGiaoDịchToolStripMenuItem";
            lịchSửGiaoDịchToolStripMenuItem.Size = new Size(357, 40);
            lịchSửGiaoDịchToolStripMenuItem.Text = "Lịch Sử Giao Dịch";
            lịchSửGiaoDịchToolStripMenuItem.Click += lichSuGiaoDichToolStripMenuItem_Click;
            // 
            // quảnLyHoaDonToolStripMenuItem
            // 
            quảnLyHoaDonToolStripMenuItem.Name = "quảnLyHoaDonToolStripMenuItem";
            quảnLyHoaDonToolStripMenuItem.Size = new Size(324, 40);
            quảnLyHoaDonToolStripMenuItem.Text = "Quản lý hóa đơn";
            quảnLyHoaDonToolStripMenuItem.Click += quảnLyHoaDonToolStripMenuItem_Click;
            // 
            // quanLyNhanVienToolStripMenuItem
            // 
            quanLyNhanVienToolStripMenuItem.Name = "quanLyNhanVienToolStripMenuItem";
            quanLyNhanVienToolStripMenuItem.Size = new Size(324, 40);
            quanLyNhanVienToolStripMenuItem.Text = "Quản lý nhân viên";
            quanLyNhanVienToolStripMenuItem.Click += quanLyNhanVienToolStripMenuItem_Click;
            // 
            // TaiKhoanToolStripMenuItem
            // 
            TaiKhoanToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            TaiKhoanToolStripMenuItem.BackColor = SystemColors.GradientActiveCaption;
            TaiKhoanToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doiMatKhauToolStripMenuItem, dangXuatToolStripMenuItem });
            TaiKhoanToolStripMenuItem.ForeColor = SystemColors.Highlight;
            TaiKhoanToolStripMenuItem.Name = "TaiKhoanToolStripMenuItem";
            TaiKhoanToolStripMenuItem.Size = new Size(133, 39);
            TaiKhoanToolStripMenuItem.Text = "Tài khoản";
            // 
            // doiMatKhauToolStripMenuItem
            // 
            doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            doiMatKhauToolStripMenuItem.Size = new Size(253, 40);
            doiMatKhauToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // dangXuatToolStripMenuItem
            // 
            dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            dangXuatToolStripMenuItem.Size = new Size(253, 40);
            dangXuatToolStripMenuItem.Text = "Đăng xuất";
            // 
            // FormTrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(menuQuanLy);
            MainMenuStrip = menuQuanLy;
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
        private ToolStripMenuItem thôngTinKháchHàngToolStripMenuItem;
        private ToolStripMenuItem lịchSửGiaoDịchToolStripMenuItem;
    }
}