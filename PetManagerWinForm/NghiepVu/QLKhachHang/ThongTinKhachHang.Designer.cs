namespace PetManagerWinForm.NghiepVu.QLKhachHang
{
    partial class ThongTinKhachHang
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private DataGridView dgvCustomers;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private TextBox txtSearch;

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnFind;
        private Button btnShowAll;
        private Button btnRefresh;

        // DataGridView columns
        private DataGridViewTextBoxColumn colCusId;
        private DataGridViewTextBoxColumn colCusName;
        private DataGridViewTextBoxColumn colAddress;
        private DataGridViewTextBoxColumn colPhoneNumber;
        private DataGridViewTextBoxColumn colEmail;

        // Panels and labels
        private Panel panelLeft;
        private Panel panelRight;
        private Label lblSearch;
        private Label lblTitle;
        private Label labelId;
        private Label labelName;
        private Label labelAddress;
        private Label labelPhone;
        private Label labelEmail;
        private Label labelSection;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelLeft = new Panel();
            dgvCustomers = new DataGridView();
            colCusId = new DataGridViewTextBoxColumn();
            colCusName = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            colPhoneNumber = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            panelRight = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnFind = new Button();
            btnShowAll = new Button();
            lblTitle = new Label();
            labelSection = new Label();
            labelId = new Label();
            txtId = new TextBox();
            labelName = new Label();
            txtName = new TextBox();
            labelAddress = new Label();
            txtAddress = new TextBox();
            labelPhone = new Label();
            txtPhoneNumber = new TextBox();
            labelEmail = new Label();
            txtEmail = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.White;
            panelLeft.Controls.Add(dgvCustomers);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(9, 8, 9, 8);
            panelLeft.Size = new Size(700, 775);
            panelLeft.TabIndex = 0;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 240, 240);
            dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(220, 100, 100);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCustomers.ColumnHeadersHeight = 40;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { colCusId, colCusName, colAddress, colPhoneNumber, colEmail });
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.EnableHeadersVisualStyles = false;
            dgvCustomers.GridColor = Color.FromArgb(255, 230, 230);
            dgvCustomers.Location = new Point(9, 8);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.RowHeadersWidth = 10;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvCustomers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCustomers.RowTemplate.Height = 35;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(682, 759);
            dgvCustomers.TabIndex = 0;
            dgvCustomers.CellClick += dgvCustomers_CellClick;
            // 
            // colCusId
            // 
            colCusId.HeaderText = "ID";
            colCusId.MinimumWidth = 6;
            colCusId.Name = "colCusId";
            colCusId.ReadOnly = true;
            colCusId.Width = 80;
            // 
            // colCusName
            // 
            colCusName.HeaderText = "Tên";
            colCusName.MinimumWidth = 6;
            colCusName.Name = "colCusName";
            colCusName.ReadOnly = true;
            colCusName.Width = 180;
            // 
            // colAddress
            // 
            colAddress.HeaderText = "Địa chỉ";
            colAddress.MinimumWidth = 6;
            colAddress.Name = "colAddress";
            colAddress.ReadOnly = true;
            colAddress.Width = 220;
            // 
            // colPhoneNumber
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            colPhoneNumber.DefaultCellStyle = dataGridViewCellStyle3;
            colPhoneNumber.HeaderText = "Số ĐT";
            colPhoneNumber.MinimumWidth = 6;
            colPhoneNumber.Name = "colPhoneNumber";
            colPhoneNumber.ReadOnly = true;
            colPhoneNumber.Width = 120;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Width = 200;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.FromArgb(255, 230, 230);
            panelRight.Controls.Add(lblSearch);
            panelRight.Controls.Add(txtSearch);
            panelRight.Controls.Add(btnFind);
            panelRight.Controls.Add(btnShowAll);
            panelRight.Controls.Add(lblTitle);
            panelRight.Controls.Add(labelSection);
            panelRight.Controls.Add(labelId);
            panelRight.Controls.Add(txtId);
            panelRight.Controls.Add(labelName);
            panelRight.Controls.Add(txtName);
            panelRight.Controls.Add(labelAddress);
            panelRight.Controls.Add(txtAddress);
            panelRight.Controls.Add(labelPhone);
            panelRight.Controls.Add(txtPhoneNumber);
            panelRight.Controls.Add(labelEmail);
            panelRight.Controls.Add(txtEmail);
            panelRight.Controls.Add(btnAdd);
            panelRight.Controls.Add(btnUpdate);
            panelRight.Controls.Add(btnDelete);
            panelRight.Controls.Add(btnRefresh);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(700, 0);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(26, 22, 26, 22);
            panelRight.Size = new Size(964, 775);
            panelRight.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSearch.Location = new Point(18, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(234, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm theo tên hoặc số điện thoại:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(18, 41);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(320, 23);
            txtSearch.TabIndex = 10;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.FromArgb(255, 210, 210);
            btnFind.FlatAppearance.BorderSize = 0;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnFind.ForeColor = Color.DimGray;
            btnFind.Location = new Point(350, 38);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(114, 30);
            btnFind.TabIndex = 11;
            btnFind.Text = "Tìm kiếm";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = Color.FromArgb(255, 210, 210);
            btnShowAll.FlatAppearance.BorderSize = 0;
            btnShowAll.FlatStyle = FlatStyle.Flat;
            btnShowAll.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnShowAll.ForeColor = Color.DimGray;
            btnShowAll.Location = new Point(470, 38);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(114, 30);
            btnShowAll.TabIndex = 12;
            btnShowAll.Text = "Tất cả";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(18, 159);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(211, 25);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Thông tin khách hàng:";
            // 
            // labelSection
            // 
            labelSection.AutoSize = true;
            labelSection.Font = new Font("Segoe UI", 9F);
            labelSection.Location = new Point(18, 167);
            labelSection.Name = "labelSection";
            labelSection.Size = new Size(0, 15);
            labelSection.TabIndex = 14;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 11F);
            labelId.Location = new Point(18, 204);
            labelId.Name = "labelId";
            labelId.Size = new Size(27, 20);
            labelId.TabIndex = 15;
            labelId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(131, 204);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(246, 23);
            txtId.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 11F);
            labelName.Location = new Point(18, 244);
            labelName.Name = "labelName";
            labelName.Size = new Size(35, 20);
            labelName.TabIndex = 16;
            labelName.Text = "Tên:";
            // 
            // txtName
            // 
            txtName.Location = new Point(131, 244);
            txtName.Name = "txtName";
            txtName.Size = new Size(246, 23);
            txtName.TabIndex = 2;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 11F);
            labelAddress.Location = new Point(18, 284);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(58, 20);
            labelAddress.TabIndex = 17;
            labelAddress.Text = "Địa chỉ:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(131, 284);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(246, 23);
            txtAddress.TabIndex = 3;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 11F);
            labelPhone.Location = new Point(18, 324);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(100, 20);
            labelPhone.TabIndex = 18;
            labelPhone.Text = "Số điện thoại:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(131, 324);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(246, 23);
            txtPhoneNumber.TabIndex = 4;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 11F);
            labelEmail.Location = new Point(18, 364);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(49, 20);
            labelEmail.TabIndex = 19;
            labelEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(131, 364);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(246, 23);
            txtEmail.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 210, 210);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAdd.ForeColor = Color.DimGray;
            btnAdd.Location = new Point(131, 404);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 30);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 210, 210);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.DimGray;
            btnUpdate.Location = new Point(262, 404);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(114, 30);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 210, 210);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDelete.ForeColor = Color.DimGray;
            btnDelete.Location = new Point(131, 448);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 30);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(255, 210, 210);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.DimGray;
            btnRefresh.Location = new Point(262, 448);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(114, 30);
            btnRefresh.TabIndex = 20;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ThongTinKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 230, 230);
            ClientSize = new Size(1664, 775);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Name = "ThongTinKhachHang";
            Text = "Thông Tin Khách Hàng";
            WindowState = FormWindowState.Maximized;
            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);
        }
    }
}