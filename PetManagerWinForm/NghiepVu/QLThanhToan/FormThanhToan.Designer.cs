// FrmThanhToan.Designer.cs — FULL VERSION

namespace PetManagerWinForm.NghiepVu
{
    partial class FrmThanhToan
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlAddCus;
        private System.Windows.Forms.Label lblAddTitle;
        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAddCustomer;

        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.NumericUpDown nudProductQty;
        private System.Windows.Forms.Button btnAddProduct;

        private System.Windows.Forms.Panel pnlServices;
        private System.Windows.Forms.ComboBox cbServices;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.NumericUpDown nudServiceQty;
        private System.Windows.Forms.Button btnAddService;

        private System.Windows.Forms.Panel pnlPets;
        private System.Windows.Forms.ComboBox cbPets;
        private System.Windows.Forms.Label lblPet;
        private System.Windows.Forms.Button btnAddPet;
        private System.Windows.Forms.Button btnChoosePet;
        private System.Windows.Forms.Label lblSelectedPet;

        private System.Windows.Forms.Panel pnlCart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btnRemove;

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnThanhToan;


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
            pnlAddCus = new Panel();
            lblAddTitle = new Label();
            lblCusName = new Label();
            lblAddr = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            txtCusName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            btnAddCustomer = new Button();
            pnlProducts = new Panel();
            lblProduct = new Label();
            cbProducts = new ComboBox();
            nudProductQty = new NumericUpDown();
            btnAddProduct = new Button();
            pnlServices = new Panel();
            txtChoosePet = new TextBox();
            lblService = new Label();
            cbServices = new ComboBox();
            nudServiceQty = new NumericUpDown();
            btnChoosePet = new Button();
            btnAddService = new Button();
            pnlPets = new Panel();
            lblPet = new Label();
            cbPets = new ComboBox();
            btnAddPet = new Button();
            lblSelectedPet = new Label();
            pnlCart = new Panel();
            dgvCart = new DataGridView();
            btnRemove = new Button();
            pnlFooter = new Panel();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnThanhToan = new Button();
            btnSelectOldCustomer = new Button();
            pnlAddCus.SuspendLayout();
            pnlProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudProductQty).BeginInit();
            pnlServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudServiceQty).BeginInit();
            pnlPets.SuspendLayout();
            pnlCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAddCus
            // 
            pnlAddCus.BackColor = Color.SeaShell;
            pnlAddCus.BorderStyle = BorderStyle.FixedSingle;
            pnlAddCus.Controls.Add(btnSelectOldCustomer);
            pnlAddCus.Controls.Add(lblAddTitle);
            pnlAddCus.Controls.Add(lblCusName);
            pnlAddCus.Controls.Add(lblAddr);
            pnlAddCus.Controls.Add(lblPhone);
            pnlAddCus.Controls.Add(lblEmail);
            pnlAddCus.Controls.Add(txtCusName);
            pnlAddCus.Controls.Add(txtAddress);
            pnlAddCus.Controls.Add(txtPhone);
            pnlAddCus.Controls.Add(txtEmail);
            pnlAddCus.Controls.Add(btnAddCustomer);
            pnlAddCus.Location = new Point(10, 10);
            pnlAddCus.Name = "pnlAddCus";
            pnlAddCus.Size = new Size(537, 260);
            pnlAddCus.TabIndex = 1;
            // 
            // lblAddTitle
            // 
            lblAddTitle.AutoSize = true;
            lblAddTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAddTitle.Location = new Point(10, 5);
            lblAddTitle.Name = "lblAddTitle";
            lblAddTitle.Size = new Size(133, 15);
            lblAddTitle.TabIndex = 0;
            lblAddTitle.Text = "Thêm khách hàng mới:";
            // 
            // lblCusName
            // 
            lblCusName.AutoSize = true;
            lblCusName.Location = new Point(10, 45);
            lblCusName.Name = "lblCusName";
            lblCusName.Size = new Size(29, 15);
            lblCusName.TabIndex = 1;
            lblCusName.Text = "Tên:";
            // 
            // lblAddr
            // 
            lblAddr.AutoSize = true;
            lblAddr.Location = new Point(10, 94);
            lblAddr.Name = "lblAddr";
            lblAddr.Size = new Size(46, 15);
            lblAddr.TabIndex = 2;
            lblAddr.Text = "Địa chỉ:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(10, 143);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(31, 15);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "SĐT:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(10, 192);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // txtCusName
            // 
            txtCusName.Location = new Point(70, 42);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new Size(268, 23);
            txtCusName.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(70, 91);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(268, 23);
            txtAddress.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(70, 140);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(268, 23);
            txtPhone.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(70, 189);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(268, 23);
            txtEmail.TabIndex = 8;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.FromArgb(255, 210, 210);
            btnAddCustomer.FlatAppearance.BorderSize = 0;
            btnAddCustomer.FlatStyle = FlatStyle.Flat;
            btnAddCustomer.Location = new Point(368, 69);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(150, 40);
            btnAddCustomer.TabIndex = 9;
            btnAddCustomer.Text = "Thêm khách hàng mới";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // pnlProducts
            // 
            pnlProducts.BackColor = Color.Bisque;
            pnlProducts.BorderStyle = BorderStyle.FixedSingle;
            pnlProducts.Controls.Add(lblProduct);
            pnlProducts.Controls.Add(cbProducts);
            pnlProducts.Controls.Add(nudProductQty);
            pnlProducts.Controls.Add(btnAddProduct);
            pnlProducts.Location = new Point(636, 12);
            pnlProducts.Name = "pnlProducts";
            pnlProducts.Size = new Size(701, 80);
            pnlProducts.TabIndex = 2;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(10, 10);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(63, 15);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Sản phẩm:";
            // 
            // cbProducts
            // 
            cbProducts.Location = new Point(100, 8);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(448, 23);
            cbProducts.TabIndex = 1;
            // 
            // nudProductQty
            // 
            nudProductQty.Location = new Point(100, 40);
            nudProductQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudProductQty.Name = "nudProductQty";
            nudProductQty.Size = new Size(120, 23);
            nudProductQty.TabIndex = 2;
            nudProductQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(571, 13);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(91, 44);
            btnAddProduct.TabIndex = 3;
            btnAddProduct.Text = "Thêm";
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // pnlServices
            // 
            pnlServices.BackColor = Color.PeachPuff;
            pnlServices.BorderStyle = BorderStyle.FixedSingle;
            pnlServices.Controls.Add(txtChoosePet);
            pnlServices.Controls.Add(lblService);
            pnlServices.Controls.Add(cbServices);
            pnlServices.Controls.Add(nudServiceQty);
            pnlServices.Controls.Add(btnChoosePet);
            pnlServices.Controls.Add(btnAddService);
            pnlServices.Location = new Point(636, 104);
            pnlServices.Name = "pnlServices";
            pnlServices.Size = new Size(701, 80);
            pnlServices.TabIndex = 3;
            // 
            // txtChoosePet
            // 
            txtChoosePet.Location = new Point(226, 40);
            txtChoosePet.Name = "txtChoosePet";
            txtChoosePet.Size = new Size(230, 23);
            txtChoosePet.TabIndex = 4;
            txtChoosePet.TextAlign = HorizontalAlignment.Right;
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Location = new Point(10, 10);
            lblService.Name = "lblService";
            lblService.Size = new Size(50, 15);
            lblService.TabIndex = 0;
            lblService.Text = "Dịch vụ:";
            // 
            // cbServices
            // 
            cbServices.Location = new Point(100, 8);
            cbServices.Name = "cbServices";
            cbServices.Size = new Size(356, 23);
            cbServices.TabIndex = 1;
            // 
            // nudServiceQty
            // 
            nudServiceQty.Location = new Point(100, 40);
            nudServiceQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudServiceQty.Name = "nudServiceQty";
            nudServiceQty.Size = new Size(120, 23);
            nudServiceQty.TabIndex = 2;
            nudServiceQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnChoosePet
            // 
            btnChoosePet.Location = new Point(475, 11);
            btnChoosePet.Name = "btnChoosePet";
            btnChoosePet.Size = new Size(90, 42);
            btnChoosePet.TabIndex = 3;
            btnChoosePet.Text = "Chọn Pet";
            btnChoosePet.Click += btnChoosePet_Click;
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(571, 10);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(91, 44);
            btnAddService.TabIndex = 3;
            btnAddService.Text = "Thêm";
            btnAddService.Click += btnAddService_Click;
            // 
            // pnlPets
            // 
            pnlPets.BackColor = Color.SandyBrown;
            pnlPets.BorderStyle = BorderStyle.FixedSingle;
            pnlPets.Controls.Add(lblPet);
            pnlPets.Controls.Add(cbPets);
            pnlPets.Controls.Add(btnAddPet);
            pnlPets.Controls.Add(lblSelectedPet);
            pnlPets.Location = new Point(636, 190);
            pnlPets.Name = "pnlPets";
            pnlPets.Size = new Size(701, 80);
            pnlPets.TabIndex = 4;
            // 
            // lblPet
            // 
            lblPet.AutoSize = true;
            lblPet.Location = new Point(10, 32);
            lblPet.Name = "lblPet";
            lblPet.Size = new Size(61, 15);
            lblPet.TabIndex = 0;
            lblPet.Text = "Thú cưng:";
            // 
            // cbPets
            // 
            cbPets.Location = new Point(100, 29);
            cbPets.Name = "cbPets";
            cbPets.Size = new Size(448, 23);
            cbPets.TabIndex = 1;
            // 
            // btnAddPet
            // 
            btnAddPet.Location = new Point(571, 18);
            btnAddPet.Name = "btnAddPet";
            btnAddPet.Size = new Size(91, 42);
            btnAddPet.TabIndex = 2;
            btnAddPet.Text = "Thêm";
            btnAddPet.Click += btnAddPet_Click;
            // 
            // lblSelectedPet
            // 
            lblSelectedPet.AutoSize = true;
            lblSelectedPet.Location = new Point(100, 45);
            lblSelectedPet.Name = "lblSelectedPet";
            lblSelectedPet.Size = new Size(0, 15);
            lblSelectedPet.TabIndex = 4;
            // 
            // pnlCart
            // 
            pnlCart.BackColor = Color.FloralWhite;
            pnlCart.BorderStyle = BorderStyle.FixedSingle;
            pnlCart.Controls.Add(dgvCart);
            pnlCart.Controls.Add(btnRemove);
            pnlCart.Location = new Point(10, 280);
            pnlCart.Name = "pnlCart";
            pnlCart.Size = new Size(1327, 250);
            pnlCart.TabIndex = 5;
            // 
            // dgvCart
            // 
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.BackgroundColor = Color.MistyRose;
            dgvCart.ColumnHeadersHeight = 29;
            dgvCart.GridColor = Color.NavajoWhite;
            dgvCart.Location = new Point(10, 10);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(1305, 200);
            dgvCart.TabIndex = 0;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.Location = new Point(10, 215);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(91, 30);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Xóa";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(255, 224, 192);
            pnlFooter.BorderStyle = BorderStyle.FixedSingle;
            pnlFooter.Controls.Add(lblTotal);
            pnlFooter.Controls.Add(txtTotal);
            pnlFooter.Controls.Add(btnThanhToan);
            pnlFooter.Location = new Point(10, 559);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1327, 80);
            pnlFooter.TabIndex = 6;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(10, 20);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(61, 15);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Tổng tiền:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(100, 18);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(150, 23);
            txtTotal.TabIndex = 1;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.LightGreen;
            btnThanhToan.Location = new Point(1135, 11);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(180, 40);
            btnThanhToan.TabIndex = 2;
            btnThanhToan.Text = "THANH TOÁN";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnSelectOldCustomer
            // 
            btnSelectOldCustomer.BackColor = Color.FromArgb(255, 210, 210);
            btnSelectOldCustomer.FlatAppearance.BorderSize = 0;
            btnSelectOldCustomer.FlatStyle = FlatStyle.Flat;
            btnSelectOldCustomer.Location = new Point(368, 143);
            btnSelectOldCustomer.Name = "btnSelectOldCustomer";
            btnSelectOldCustomer.Size = new Size(150, 40);
            btnSelectOldCustomer.TabIndex = 10;
            btnSelectOldCustomer.Text = "Chọn khách hàng cũ";
            btnSelectOldCustomer.UseVisualStyleBackColor = false;
            // 
            // FrmThanhToan
            // 
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(1902, 1033);
            Controls.Add(pnlAddCus);
            Controls.Add(pnlProducts);
            Controls.Add(pnlServices);
            Controls.Add(pnlPets);
            Controls.Add(pnlCart);
            Controls.Add(pnlFooter);
            Name = "FrmThanhToan";
            Text = "Thanh Toán";
            Load += FrmThanhToan_Load;
            pnlAddCus.ResumeLayout(false);
            pnlAddCus.PerformLayout();
            pnlProducts.ResumeLayout(false);
            pnlProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudProductQty).EndInit();
            pnlServices.ResumeLayout(false);
            pnlServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudServiceQty).EndInit();
            pnlPets.ResumeLayout(false);
            pnlPets.PerformLayout();
            pnlCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ResumeLayout(false);
        }
        private TextBox txtChoosePet;
        private Button btnSelectOldCustomer;
    }
}
