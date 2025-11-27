namespace PetManagerWinForm
{
    partial class FormTrangChu
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelLeft;
        private Panel panelContent;

        private Button btnThuCungChuaBan;
        private Button btnThuCungDaBan;
        private Button btnThuCungKhachHang;
        private Button btnKhachHang;
        private Button btnSanPham;
        private Button btnDichVu;
        private Button btnHoaDon;
        private Button btnNhanVien;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangChu));
            panelLeft = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            btnThuCungChuaBan = new Button();
            btnThuCungDaBan = new Button();
            btnThuCungKhachHang = new Button();
            btnKhachHang = new Button();
            btnSanPham = new Button();
            btnDichVu = new Button();
            btnHoaDon = new Button();
            btnNhanVien = new Button();
            panelContent = new Panel();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(255, 192, 192);
            panelLeft.Controls.Add(pictureBox1);
            panelLeft.Controls.Add(button1);
            panelLeft.Controls.Add(btnThuCungChuaBan);
            panelLeft.Controls.Add(btnThuCungDaBan);
            panelLeft.Controls.Add(btnThuCungKhachHang);
            panelLeft.Controls.Add(btnKhachHang);
            panelLeft.Controls.Add(btnSanPham);
            panelLeft.Controls.Add(btnDichVu);
            panelLeft.Controls.Add(btnHoaDon);
            panelLeft.Controls.Add(btnNhanVien);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(10);
            panelLeft.Size = new Size(350, 1041);
            panelLeft.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 748);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 262);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.DimGray;
            button1.Location = new Point(10, 530);
            button1.Name = "button1";
            button1.Size = new Size(320, 50);
            button1.TabIndex = 8;
            button1.Text = "Thanh Toán";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnThuCungChuaBan
            // 
            btnThuCungChuaBan.BackColor = Color.FromArgb(255, 224, 192);
            btnThuCungChuaBan.FlatAppearance.BorderSize = 0;
            btnThuCungChuaBan.FlatStyle = FlatStyle.Flat;
            btnThuCungChuaBan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThuCungChuaBan.ForeColor = Color.DimGray;
            btnThuCungChuaBan.Location = new Point(10, 20);
            btnThuCungChuaBan.Name = "btnThuCungChuaBan";
            btnThuCungChuaBan.Size = new Size(320, 50);
            btnThuCungChuaBan.TabIndex = 0;
            btnThuCungChuaBan.Text = "Thú cưng chưa bán";
            btnThuCungChuaBan.UseVisualStyleBackColor = false;
            btnThuCungChuaBan.Click += btnThuCungChuaBan_Click;
            // 
            // btnThuCungDaBan
            // 
            btnThuCungDaBan.BackColor = Color.FromArgb(255, 224, 192);
            btnThuCungDaBan.FlatAppearance.BorderSize = 0;
            btnThuCungDaBan.FlatStyle = FlatStyle.Flat;
            btnThuCungDaBan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThuCungDaBan.ForeColor = Color.DimGray;
            btnThuCungDaBan.Location = new Point(10, 80);
            btnThuCungDaBan.Name = "btnThuCungDaBan";
            btnThuCungDaBan.Size = new Size(320, 50);
            btnThuCungDaBan.TabIndex = 1;
            btnThuCungDaBan.Text = "Thú cưng đã bán";
            btnThuCungDaBan.UseVisualStyleBackColor = false;
            btnThuCungDaBan.Click += btnThuCungDaBan_Click;
            // 
            // btnThuCungKhachHang
            // 
            btnThuCungKhachHang.BackColor = Color.FromArgb(255, 224, 192);
            btnThuCungKhachHang.FlatAppearance.BorderSize = 0;
            btnThuCungKhachHang.FlatStyle = FlatStyle.Flat;
            btnThuCungKhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThuCungKhachHang.ForeColor = Color.DimGray;
            btnThuCungKhachHang.Location = new Point(10, 140);
            btnThuCungKhachHang.Name = "btnThuCungKhachHang";
            btnThuCungKhachHang.Size = new Size(320, 50);
            btnThuCungKhachHang.TabIndex = 2;
            btnThuCungKhachHang.Text = "Thú cưng khách hàng";
            btnThuCungKhachHang.UseVisualStyleBackColor = false;
            btnThuCungKhachHang.Click += btnThuCungKhachHang_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.FromArgb(255, 224, 192);
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnKhachHang.ForeColor = Color.DimGray;
            btnKhachHang.Location = new Point(10, 200);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(320, 50);
            btnKhachHang.TabIndex = 3;
            btnKhachHang.Text = "Khách hàng";
            btnKhachHang.UseVisualStyleBackColor = false;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.BackColor = Color.FromArgb(255, 224, 192);
            btnSanPham.FlatAppearance.BorderSize = 0;
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSanPham.ForeColor = Color.DimGray;
            btnSanPham.Location = new Point(10, 260);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(320, 50);
            btnSanPham.TabIndex = 4;
            btnSanPham.Text = "Sản phẩm";
            btnSanPham.UseVisualStyleBackColor = false;
            btnSanPham.Click += btnSanPham_Click;
            // 
            // btnDichVu
            // 
            btnDichVu.BackColor = Color.FromArgb(255, 224, 192);
            btnDichVu.FlatAppearance.BorderSize = 0;
            btnDichVu.FlatStyle = FlatStyle.Flat;
            btnDichVu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDichVu.ForeColor = Color.DimGray;
            btnDichVu.Location = new Point(10, 320);
            btnDichVu.Name = "btnDichVu";
            btnDichVu.Size = new Size(320, 50);
            btnDichVu.TabIndex = 5;
            btnDichVu.Text = "Dịch vụ";
            btnDichVu.UseVisualStyleBackColor = false;
            btnDichVu.Click += btnDichVu_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = Color.FromArgb(255, 224, 192);
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHoaDon.ForeColor = Color.DimGray;
            btnHoaDon.Location = new Point(10, 380);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(320, 50);
            btnHoaDon.TabIndex = 6;
            btnHoaDon.Text = "Hóa đơn";
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.FromArgb(255, 224, 192);
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNhanVien.ForeColor = Color.DimGray;
            btnNhanVien.Location = new Point(10, 440);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(320, 50);
            btnNhanVien.TabIndex = 7;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.WhiteSmoke;
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(350, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1554, 1041);
            panelContent.TabIndex = 0;
            // 
            // FormTrangChu
            // 
            BackColor = Color.LightCoral;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panelContent);
            Controls.Add(panelLeft);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormTrangChu";
            Text = "Trang chủ quản lý thú cưng";
            WindowState = FormWindowState.Maximized;
            Load += FormTrangChu_Load;
            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }
        private Button button1;
        private PictureBox pictureBox1;
    }
}
