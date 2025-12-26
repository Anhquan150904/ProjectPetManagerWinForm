namespace PetManagerWinForm.NghiepVu.QLKhachHang
{
    partial class ThuCungCuaKhangHang
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private Panel panelLeft;
        private Panel panelRight;

        private DataGridView dgvPets;

        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnFind;

        private Label lblTitle;
        private Label lblId;
        private TextBox txtId;
        private Label lblName;
        private TextBox txtName;
        private Label lblType;
        private TextBox txtType;
        private Label lblAge;
        private TextBox txtAge;
        private Label lbldichvu;
        private TextBox txtDichVu;

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;

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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelLeft = new Panel();
            dgvPets = new DataGridView();
            panelRight = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnFind = new Button();
            lblTitle = new Label();
            lblId = new Label();
            txtId = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblType = new Label();
            txtType = new TextBox();
            lblAge = new Label();
            txtAge = new TextBox();
            lbldichvu = new Label();
            txtDichVu = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            colOwnerName = new DataGridViewTextBoxColumn();
            colServiceUsed = new DataGridViewTextBoxColumn();
            colPetAge = new DataGridViewTextBoxColumn();
            colPetType = new DataGridViewTextBoxColumn();
            colPetName = new DataGridViewTextBoxColumn();
            colPetId = new DataGridViewTextBoxColumn();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPets).BeginInit();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.White;
            panelLeft.Controls.Add(dgvPets);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(9, 8, 9, 8);
            panelLeft.Size = new Size(825, 681);
            panelLeft.TabIndex = 0;
            // 
            // dgvPets
            // 
            dgvPets.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 240, 240);
            dgvPets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPets.BackgroundColor = Color.White;
            dgvPets.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(220, 100, 100);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPets.ColumnHeadersHeight = 40;
            dgvPets.Columns.AddRange(new DataGridViewColumn[] { colPetId, colPetName, colPetType, colPetAge, colServiceUsed, colOwnerName });
            dgvPets.Dock = DockStyle.Fill;
            dgvPets.EnableHeadersVisualStyles = false;
            dgvPets.GridColor = Color.FromArgb(255, 230, 230);
            dgvPets.Location = new Point(9, 8);
            dgvPets.Name = "dgvPets";
            dgvPets.ReadOnly = true;
            dgvPets.RowHeadersVisible = false;
            dgvPets.RowHeadersWidth = 10;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dgvPets.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvPets.RowTemplate.Height = 35;
            dgvPets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPets.Size = new Size(807, 665);
            dgvPets.TabIndex = 0;
            dgvPets.CellClick += dgvPets_CellClick;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.FromArgb(255, 230, 230);
            panelRight.Controls.Add(lblSearch);
            panelRight.Controls.Add(txtSearch);
            panelRight.Controls.Add(btnFind);
            panelRight.Controls.Add(lblTitle);
            panelRight.Controls.Add(lblId);
            panelRight.Controls.Add(txtId);
            panelRight.Controls.Add(lblName);
            panelRight.Controls.Add(txtName);
            panelRight.Controls.Add(lblType);
            panelRight.Controls.Add(txtType);
            panelRight.Controls.Add(lblAge);
            panelRight.Controls.Add(txtAge);
            panelRight.Controls.Add(lbldichvu);
            panelRight.Controls.Add(txtDichVu);
            panelRight.Controls.Add(btnAdd);
            panelRight.Controls.Add(btnUpdate);
            panelRight.Controls.Add(btnDelete);
            panelRight.Controls.Add(btnRefresh);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(825, 0);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(26, 22, 26, 22);
            panelRight.Size = new Size(439, 681);
            panelRight.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSearch.Location = new Point(18, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(195, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm theo tên hoặc ghi chú:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(18, 41);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(359, 23);
            txtSearch.TabIndex = 10;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.FromArgb(255, 210, 210);
            btnFind.FlatAppearance.BorderSize = 0;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnFind.ForeColor = Color.DimGray;
            btnFind.Location = new Point(262, 70);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(114, 30);
            btnFind.TabIndex = 11;
            btnFind.Text = "Tìm kiếm";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(18, 143);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(240, 25);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Thú cưng của khách hàng";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 11F);
            lblId.Location = new Point(18, 193);
            lblId.Name = "lblId";
            lblId.Size = new Size(54, 20);
            lblId.TabIndex = 14;
            lblId.Text = "Mã PC:";
            // 
            // txtId
            // 
            txtId.Location = new Point(131, 193);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(246, 23);
            txtId.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 11F);
            lblName.Location = new Point(18, 233);
            lblName.Name = "lblName";
            lblName.Size = new Size(35, 20);
            lblName.TabIndex = 15;
            lblName.Text = "Tên:";
            // 
            // txtName
            // 
            txtName.Location = new Point(131, 233);
            txtName.Name = "txtName";
            txtName.Size = new Size(246, 23);
            txtName.TabIndex = 2;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 11F);
            lblType.Location = new Point(18, 273);
            lblType.Name = "lblType";
            lblType.Size = new Size(52, 20);
            lblType.TabIndex = 16;
            lblType.Text = "Giống:";
            // 
            // txtType
            // 
            txtType.Location = new Point(131, 273);
            txtType.Name = "txtType";
            txtType.Size = new Size(246, 23);
            txtType.TabIndex = 3;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 11F);
            lblAge.Location = new Point(18, 313);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(41, 20);
            lblAge.TabIndex = 17;
            lblAge.Text = "Tuổi:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(131, 313);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(246, 23);
            txtAge.TabIndex = 4;
            // 
            // lbldichvu
            // 
            lbldichvu.AutoSize = true;
            lbldichvu.Font = new Font("Segoe UI", 11F);
            lbldichvu.Location = new Point(18, 353);
            lbldichvu.Name = "lbldichvu";
            lbldichvu.Size = new Size(61, 20);
            lbldichvu.TabIndex = 18;
            lbldichvu.Text = "Dịch vụ:";
            // 
            // txtDichVu
            // 
            txtDichVu.Location = new Point(131, 353);
            txtDichVu.Name = "txtDichVu";
            txtDichVu.Size = new Size(246, 23);
            txtDichVu.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 210, 210);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAdd.ForeColor = Color.DimGray;
            btnAdd.Location = new Point(131, 393);
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
            btnUpdate.Location = new Point(262, 393);
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
            btnDelete.Location = new Point(131, 437);
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
            btnRefresh.Location = new Point(262, 437);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(114, 30);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // colOwnerName
            // 
            colOwnerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colOwnerName.DefaultCellStyle = dataGridViewCellStyle8;
            colOwnerName.FillWeight = 20F;
            colOwnerName.HeaderText = "Chủ sở hữu";
            colOwnerName.MinimumWidth = 6;
            colOwnerName.Name = "colOwnerName";
            colOwnerName.ReadOnly = true;
            // 
            // colServiceUsed
            // 
            colServiceUsed.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colServiceUsed.DefaultCellStyle = dataGridViewCellStyle7;
            colServiceUsed.FillWeight = 20F;
            colServiceUsed.HeaderText = "Dịch vụ đã sử dụng";
            colServiceUsed.MinimumWidth = 6;
            colServiceUsed.Name = "colServiceUsed";
            colServiceUsed.ReadOnly = true;
            // 
            // colPetAge
            // 
            colPetAge.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            colPetAge.DefaultCellStyle = dataGridViewCellStyle6;
            colPetAge.FillWeight = 6F;
            colPetAge.HeaderText = "Tuổi";
            colPetAge.MinimumWidth = 6;
            colPetAge.Name = "colPetAge";
            colPetAge.ReadOnly = true;
            // 
            // colPetType
            // 
            colPetType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colPetType.DefaultCellStyle = dataGridViewCellStyle5;
            colPetType.FillWeight = 18F;
            colPetType.HeaderText = "Giống";
            colPetType.MinimumWidth = 6;
            colPetType.Name = "colPetType";
            colPetType.ReadOnly = true;
            // 
            // colPetName
            // 
            colPetName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colPetName.DefaultCellStyle = dataGridViewCellStyle4;
            colPetName.FillWeight = 30F;
            colPetName.HeaderText = "Tên Thú Cưng";
            colPetName.MinimumWidth = 6;
            colPetName.Name = "colPetName";
            colPetName.ReadOnly = true;
            // 
            // colPetId
            // 
            colPetId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colPetId.DefaultCellStyle = dataGridViewCellStyle3;
            colPetId.FillWeight = 6F;
            colPetId.HeaderText = "Mã Pet";
            colPetId.MinimumWidth = 6;
            colPetId.Name = "colPetId";
            colPetId.ReadOnly = true;
            // 
            // ThuCungCuaKhangHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 230, 230);
            ClientSize = new Size(1264, 681);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Name = "ThuCungCuaKhangHang";
            Text = "Thú cưng của khách hàng";
            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPets).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);
        }
        private DataGridViewTextBoxColumn colPetId;
        private DataGridViewTextBoxColumn colPetName;
        private DataGridViewTextBoxColumn colPetType;
        private DataGridViewTextBoxColumn colPetAge;
        private DataGridViewTextBoxColumn colServiceUsed;
        private DataGridViewTextBoxColumn colOwnerName;
    }
}