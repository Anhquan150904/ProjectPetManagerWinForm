namespace PetManagerWinForm.NghiepVu
{
    partial class FrmThanhToan
    {
        private System.ComponentModel.IContainer components = null;

        // Controls (Giữ nguyên khai báo fields)
        private ComboBox cbCustomers;
        private Label lblCus;
        private TextBox txtCusName;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Button btnAddCustomer;

        private ComboBox cbProducts;
        private ComboBox cbServices;
        private ComboBox cbPets;
        private ComboBox cbServicePet; // <<< THÊM CONTROL MỚI CHO DỊCH VỤ >>>
        private NumericUpDown nudProductQty;
        private NumericUpDown nudServiceQty;
        private Button btnAddProduct;
        private Button btnAddService;
        private Button btnAddPet;
        private Button btnRemove;

        private DataGridView dgvCart;
        private Label lblTotalTitle;
        private TextBox txtTotal;
        private Button btnPay;

        // Layout Panels (Giữ nguyên khai báo fields)
        private Panel pnlTop;
        private Panel pnlTopLeft;
        private Panel pnlTopRight;
        private Panel pnlCartBody;
        private Panel pnlFooter;
        private Panel pnlAddCus;
        private FlowLayoutPanel flpItems;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // Khai báo các Labels chi tiết cần dùng trong pnlAddCus
            Label lblAddTitle = new Label();
            Label lblCusName = new Label();
            Label lblAddr = new Label();
            Label lblPhone = new Label();
            Label lblEmail = new Label();

            // Khai báo các Panels/FlowLayoutPanel
            this.pnlTop = new Panel();
            this.pnlTopLeft = new Panel();
            this.pnlAddCus = new Panel();
            this.pnlTopRight = new Panel();
            this.flpItems = new FlowLayoutPanel();
            this.pnlCartBody = new Panel();
            this.pnlFooter = new Panel();
            
            // Khởi tạo Controls
            this.cbCustomers = new ComboBox();
            this.lblCus = new Label();
            this.txtCusName = new TextBox();
            this.txtAddress = new TextBox();
            this.txtPhone = new TextBox();
            this.txtEmail = new TextBox();
            this.btnAddCustomer = new Button();
            this.cbProducts = new ComboBox();
            this.cbServices = new ComboBox();
            this.cbPets = new ComboBox();
            this.cbServicePet = new ComboBox(); // <<< KHỞI TẠO CONTROL MỚI >>>
            this.nudProductQty = new NumericUpDown();
            this.nudServiceQty = new NumericUpDown();
            this.btnAddProduct = new Button();
            this.btnAddService = new Button();
            this.btnAddPet = new Button();
            this.btnRemove = new Button();
            this.dgvCart = new DataGridView();
            this.txtTotal = new TextBox();
            this.btnPay = new Button();
            this.lblTotalTitle = new Label();
            
            // Khởi tạo các Panels con dùng trong FlowLayoutPanel
            Panel p1 = new Panel();
            Panel p2 = new Panel();
            Panel p3 = new Panel();

            this.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlTopLeft.SuspendLayout();
            this.pnlAddCus.SuspendLayout();
            this.pnlTopRight.SuspendLayout();
            this.flpItems.SuspendLayout();
            this.pnlCartBody.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServiceQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();

            // Thiết lập Form
            this.Text = "Thanh Toán & Quản lý Đơn hàng";
            this.ClientSize = new Size(1200, 750);
            this.BackColor = Color.FromArgb(255, 230, 230);
            this.Padding = new Padding(10);
            this.Load += FrmThanhToan_Load;

            // =======================================================
            // === 1. TOP SECTION (Khách hàng & Chọn mặt hàng) ===
            // =======================================================

            // --- pnlTop (Container cho TopLeft & TopRight) ---
            this.pnlTop.Dock = DockStyle.Top;
            this.pnlTop.Height = 260; // Tăng chiều cao để chứa thêm lựa chọn Pet cho Dịch vụ
            this.pnlTop.BackColor = Color.Transparent;
            this.pnlTop.Controls.Add(this.pnlTopRight);
            this.pnlTop.Controls.Add(this.pnlTopLeft);

            // --- pnlTopLeft: Dock Left (Cố định 450px) ---
            this.pnlTopLeft.Dock = DockStyle.Left;
            this.pnlTopLeft.Width = 450;
            this.pnlTopLeft.BackColor = Color.Transparent;

            // Controls trong pnlTopLeft (Selection KH)
            this.lblCus.Text = "Chọn Khách hàng:"; this.lblCus.Location = new Point(10, 5); this.lblCus.Font = new Font("Segoe UI", 10F, FontStyle.Bold); this.lblCus.AutoSize = true;
            this.cbCustomers.Location = new Point(160, 2); this.cbCustomers.Size = new Size(250, 25); this.cbCustomers.DropDownStyle = ComboBoxStyle.DropDownList;

            // Panel Thêm khách hàng (pnlAddCus)
            this.pnlAddCus.Location = new Point(10, 35);
            this.pnlAddCus.Size = new Size(430, 170); // Điều chỉnh lại
            this.pnlAddCus.BorderStyle = BorderStyle.FixedSingle; this.pnlAddCus.BackColor = Color.White;

            lblAddTitle.Text = "Thêm Khách hàng Mới:"; lblAddTitle.Location = new Point(10, 5); lblAddTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold); lblAddTitle.AutoSize = true;
            lblCusName.Text = "Tên:"; lblCusName.Location = new Point(10, 30); lblCusName.AutoSize = true; 
            lblAddr.Text = "Địa chỉ:"; lblAddr.Location = new Point(10, 55); lblAddr.AutoSize = true; 
            lblPhone.Text = "SĐT:"; lblPhone.Location = new Point(10, 80); lblPhone.AutoSize = true; 
            lblEmail.Text = "Email:"; lblEmail.Location = new Point(10, 105); lblEmail.AutoSize = true; 

            this.txtCusName.Location = new Point(70, 30); this.txtCusName.Size = new Size(150, 23);
            this.txtAddress.Location = new Point(70, 55); this.txtAddress.Size = new Size(150, 23);
            this.txtPhone.Location = new Point(70, 80); this.txtPhone.Size = new Size(150, 23);
            this.txtEmail.Location = new Point(70, 105); this.txtEmail.Size = new Size(150, 23);

            this.btnAddCustomer.Text = "Thêm KH"; this.btnAddCustomer.Location = new Point(230, 30);
            this.btnAddCustomer.Size = new Size(150, 40); this.btnAddCustomer.BackColor = Color.FromArgb(255, 210, 210);
            this.btnAddCustomer.FlatStyle = FlatStyle.Flat; this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.Click += btnAddCustomer_Click;

            this.pnlTopLeft.Controls.AddRange(new Control[] { this.lblCus, this.cbCustomers, this.pnlAddCus });
            this.pnlAddCus.Controls.AddRange(new Control[] { lblAddTitle, lblCusName, lblAddr, lblPhone, lblEmail, this.txtCusName, this.txtAddress, this.txtPhone, this.txtEmail, this.btnAddCustomer });


            // --- pnlTopRight: Dock Fill (Co giãn chiều rộng) ---
            this.pnlTopRight.Dock = DockStyle.Fill;
            this.pnlTopRight.BackColor = Color.Transparent;
            this.pnlTopRight.Padding = new Padding(10, 0, 0, 0);

            // FlowLayoutPanel cho Item Selection
            this.flpItems.Dock = DockStyle.Fill;
            this.flpItems.FlowDirection = FlowDirection.LeftToRight;
            this.flpItems.WrapContents = true;
            this.flpItems.AutoScroll = true;
            this.flpItems.BackColor = Color.Transparent;

            this.pnlTopRight.Controls.Add(flpItems);

            // Tái tạo các Item Control bằng cách tạo Panel thủ công:

            // *** 1. Sản phẩm (p1) *** (Cao 110px)
            p1.Width = 350; p1.Height = 110; p1.Margin = new Padding(5); p1.BorderStyle = BorderStyle.FixedSingle; p1.BackColor = Color.White;
            Label lblPTitle = new Label() { Text = "1. Sản phẩm:", Location = new Point(5, 5), Font = new Font("Segoe UI", 10F, FontStyle.Bold), AutoSize = true };
            Label lblPName = new Label() { Text = "Tên:", Location = new Point(5, 35), AutoSize = true };
            this.cbProducts.Location = new Point(50, 32); this.cbProducts.Size = new Size(280, 25); this.cbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            Label lblPQty = new Label() { Text = "SL:", Location = new Point(5, 65), AutoSize = true };
            this.nudProductQty.Location = new Point(50, 62); this.nudProductQty.Minimum = 1; this.nudProductQty.Value = 1; this.nudProductQty.Size = new Size(60, 25);
            this.btnAddProduct.Text = "Thêm SP"; this.btnAddProduct.Location = new Point(140, 58); this.btnAddProduct.Size = new Size(150, 35);
            this.btnAddProduct.BackColor = Color.FromArgb(255, 220, 220); this.btnAddProduct.FlatStyle = FlatStyle.Flat; this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.Click += btnAddProduct_Click;
            p1.Controls.AddRange(new Control[] { lblPTitle, lblPName, this.cbProducts, lblPQty, this.nudProductQty, this.btnAddProduct });
            this.flpItems.Controls.Add(p1);

            // *** 2. Dịch vụ (p2) *** (CAO 140px để thêm Pet)
            p2.Width = 350; p2.Height = 140; // Tăng chiều cao
            p2.Margin = new Padding(5); p2.BorderStyle = BorderStyle.FixedSingle; p2.BackColor = Color.White;
            Label lblSTitle = new Label() { Text = "2. Dịch vụ:", Location = new Point(5, 5), Font = new Font("Segoe UI", 10F, FontStyle.Bold), AutoSize = true };
            Label lblSName = new Label() { Text = "Tên:", Location = new Point(5, 35), AutoSize = true };
            this.cbServices.Location = new Point(50, 32); this.cbServices.Size = new Size(280, 25); this.cbServices.DropDownStyle = ComboBoxStyle.DropDownList;
            
            // Lựa chọn Pet cho Dịch vụ
            Label lblServicePet = new Label() { Text = "Pet:", Location = new Point(5, 65), AutoSize = true }; 
            this.cbServicePet.Location = new Point(50, 62); this.cbServicePet.Size = new Size(280, 25); this.cbServicePet.DropDownStyle = ComboBoxStyle.DropDownList;
            
            Label lblSQty = new Label() { Text = "SL:", Location = new Point(5, 95), AutoSize = true }; // Dịch chuyển xuống
            this.nudServiceQty.Location = new Point(50, 92); this.nudServiceQty.Minimum = 1; this.nudServiceQty.Value = 1; this.nudServiceQty.Size = new Size(60, 25);
            this.btnAddService.Text = "Thêm DV"; this.btnAddService.Location = new Point(140, 92); // Dịch chuyển xuống
            this.btnAddService.Size = new Size(150, 35);
            this.btnAddService.BackColor = Color.FromArgb(255, 220, 220); this.btnAddService.FlatStyle = FlatStyle.Flat; this.btnAddService.FlatAppearance.BorderSize = 0;
            this.btnAddService.Click += btnAddService_Click;
            
            p2.Controls.AddRange(new Control[] { lblSTitle, lblSName, this.cbServices, lblServicePet, this.cbServicePet, lblSQty, this.nudServiceQty, this.btnAddService });
            this.flpItems.Controls.Add(p2);

            // *** 3. Thú cưng (p3) *** (Cao 110px)
            p3.Width = 350; p3.Height = 110; p3.Margin = new Padding(5); p3.BorderStyle = BorderStyle.FixedSingle; p3.BackColor = Color.White;
            Label lblPeTitle = new Label() { Text = "3. Thú cưng:", Location = new Point(5, 5), Font = new Font("Segoe UI", 10F, FontStyle.Bold), AutoSize = true };
            Label lblPeName = new Label() { Text = "Tên:", Location = new Point(5, 35), AutoSize = true };
            this.cbPets.Location = new Point(50, 32); this.cbPets.Size = new Size(280, 25); this.cbPets.DropDownStyle = ComboBoxStyle.DropDownList;
            this.btnAddPet.Text = "Thêm Pet"; this.btnAddPet.Location = new Point(50, 58); this.btnAddPet.Size = new Size(150, 35);
            this.btnAddPet.BackColor = Color.FromArgb(255, 220, 220); this.btnAddPet.FlatStyle = FlatStyle.Flat; this.btnAddPet.FlatAppearance.BorderSize = 0;
            this.btnAddPet.Click += btnAddPet_Click;
            p3.Controls.AddRange(new Control[] { lblPeTitle, lblPeName, this.cbPets, this.btnAddPet });
            this.flpItems.Controls.Add(p3);


            // =======================================================
            // === 2. CART BODY (Giỏ hàng) ===
            // =======================================================

            this.pnlCartBody.Dock = DockStyle.Fill;
            this.pnlCartBody.BackColor = Color.Transparent;
            this.pnlCartBody.Padding = new Padding(10, 5, 10, 5);

            this.btnRemove.Text = "Xóa khỏi giỏ";
            this.btnRemove.Dock = DockStyle.Top;
            this.btnRemove.Height = 30;
            this.btnRemove.BackColor = Color.FromArgb(255, 192, 192);
            this.btnRemove.FlatStyle = FlatStyle.Flat;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.Click += btnRemove_Click;

            this.dgvCart.Dock = DockStyle.Fill;
            this.dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.BackgroundColor = Color.White;
            this.dgvCart.BorderStyle = BorderStyle.FixedSingle;

            this.pnlCartBody.Controls.Add(this.dgvCart);
            this.pnlCartBody.Controls.Add(this.btnRemove);


            // =======================================================
            // === 3. FOOTER (Total & Pay) ===
            // =======================================================

            this.pnlFooter.Dock = DockStyle.Bottom;
            this.pnlFooter.Height = 50;
            this.pnlFooter.BackColor = Color.Transparent;
            this.pnlFooter.Padding = new Padding(10);

            // Total Label
            this.lblTotalTitle.Text = "TỔNG TIỀN:";
            this.lblTotalTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblTotalTitle.ForeColor = Color.DarkRed;
            this.lblTotalTitle.AutoSize = true;

            // Total TextBox
            this.txtTotal.Text = "0";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.BorderStyle = BorderStyle.None;
            this.txtTotal.BackColor = this.BackColor;
            this.txtTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.txtTotal.Size = new Size(230, 25);
            this.txtTotal.TextAlign = HorizontalAlignment.Right;

            // Button Pay
            this.btnPay.Text = "T.TOÁN";
            this.btnPay.Size = new Size(150, 35);
            this.btnPay.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnPay.BackColor = Color.FromArgb(192, 255, 192);
            this.btnPay.FlatStyle = FlatStyle.Flat;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.Click += btnThanhToan_Click;


            // Căn chỉnh Footer Controls bằng Anchor Right
            this.lblTotalTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.txtTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnPay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            
            // Tính toán vị trí dựa trên ClientSize.Width (1200) - Padding (20) = 1180
            int pnlWidth = 1180;
            
            // 1. Pay Button (Căn sát phải)
            this.btnPay.Location = new Point(pnlWidth - this.btnPay.Width - 10, 8); // 1180 - 150 - 10 = 1020

            // 2. Total Text (Căn sát trái của Pay, cách 10px)
            this.txtTotal.Width = 180; // Giảm nhẹ chiều rộng Total Text
            this.txtTotal.Location = new Point(this.btnPay.Left - this.txtTotal.Width - 10, 10); // 1020 - 180 - 10 = 830

            // 3. Total Label (Căn sát trái của Total Text)
            // Lấy chiều rộng ước tính của lblTotalTitle (khoảng 150px)
            this.lblTotalTitle.Location = new Point(this.txtTotal.Left - 100, 10); // 830 - 100 = 730
            
            // Thêm vào Footer Panel
            this.pnlFooter.Controls.AddRange(new Control[] { this.lblTotalTitle, this.txtTotal, this.btnPay });


            // =======================================================
            // === FINAL LAYOUT (Đảo ngược thứ tự Docking) ===
            // =======================================================

            // Đặt Fill Panel (pnlCartBody) đầu tiên để nó chiếm phần lớn không gian
            this.Controls.Add(this.pnlCartBody);
            // Sau đó Dock các Panel cố định (pnlTop và pnlFooter)
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlFooter);

            this.pnlTop.BringToFront();
            this.pnlFooter.SendToBack();
            this.pnlCartBody.BringToFront();


            this.ResumeLayout(false);
            this.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlTopLeft.ResumeLayout(false);
            this.pnlTopLeft.PerformLayout();
            this.pnlAddCus.ResumeLayout(false);
            this.pnlAddCus.PerformLayout();
            this.pnlTopRight.ResumeLayout(false);
            this.pnlTopRight.PerformLayout();
            this.flpItems.ResumeLayout(false);
            this.flpItems.PerformLayout();
            this.pnlCartBody.ResumeLayout(false);
            this.pnlCartBody.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServiceQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
        }
    }
}