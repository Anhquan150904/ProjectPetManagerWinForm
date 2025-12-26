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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            panelLeft = new Panel();
            dgvPets = new DataGridView();
            colPetId = new DataGridViewTextBoxColumn();
            colPetName = new DataGridViewTextBoxColumn();
            colPetType = new DataGridViewTextBoxColumn();
            colPetAge = new DataGridViewTextBoxColumn();
            colServiceUsed = new DataGridViewTextBoxColumn();
            colOwnerName = new DataGridViewTextBoxColumn();
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
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
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
            dataGridViewCellStyle10.BackColor = Color.FromArgb(255, 240, 240);
            dgvPets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvPets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPets.BackgroundColor = Color.White;
            dgvPets.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(220, 100, 100);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvPets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle18.BackColor = SystemColors.Window;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle18.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle18.SelectionForeColor = Color.Black;
            dgvPets.RowsDefaultCellStyle = dataGridViewCellStyle18;
            dgvPets.RowTemplate.Height = 35;
            dgvPets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPets.Size = new Size(807, 665);
            dgvPets.TabIndex = 0;
            dgvPets.CellClick += dgvPets_CellClick;
            // 
            // colPetId
            // 
            colPetId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colPetId.DefaultCellStyle = dataGridViewCellStyle12;
            colPetId.FillWeight = 6F;
            colPetId.HeaderText = "Mã Pet";
            colPetId.MinimumWidth = 6;
            colPetId.Name = "colPetId";
            colPetId.ReadOnly = true;
            // 
            // colPetName
            // 
            colPetName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colPetName.DefaultCellStyle = dataGridViewCellStyle13;
            colPetName.FillWeight = 30F;
            colPetName.HeaderText = "Tên Thú Cưng";
            colPetName.MinimumWidth = 6;
            colPetName.Name = "colPetName";
            colPetName.ReadOnly = true;
            // 
            // colPetType
            // 
            colPetType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colPetType.DefaultCellStyle = dataGridViewCellStyle14;
            colPetType.FillWeight = 18F;
            colPetType.HeaderText = "Giống";
            colPetType.MinimumWidth = 6;
            colPetType.Name = "colPetType";
            colPetType.ReadOnly = true;
            // 
            // colPetAge
            // 
            colPetAge.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleRight;
            colPetAge.DefaultCellStyle = dataGridViewCellStyle15;
            colPetAge.FillWeight = 6F;
            colPetAge.HeaderText = "Tuổi";
            colPetAge.MinimumWidth = 6;
            colPetAge.Name = "colPetAge";
            colPetAge.ReadOnly = true;
            // 
            // colServiceUsed
            // 
            colServiceUsed.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colServiceUsed.DefaultCellStyle = dataGridViewCellStyle16;
            colServiceUsed.FillWeight = 20F;
            colServiceUsed.HeaderText = "Dịch vụ đã sử dụng";
            colServiceUsed.MinimumWidth = 6;
            colServiceUsed.Name = "colServiceUsed";
            colServiceUsed.ReadOnly = true;
            // 
            // colOwnerName
            // 
            colOwnerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colOwnerName.DefaultCellStyle = dataGridViewCellStyle17;
            colOwnerName.FillWeight = 20F;
            colOwnerName.HeaderText = "Chủ sở hữu";
            colOwnerName.MinimumWidth = 6;
            colOwnerName.Name = "colOwnerName";
            colOwnerName.ReadOnly = true;
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
            lblId.Size = new Size(57, 20);
            lblId.TabIndex = 14;
            lblId.Text = "Mã Pet:";
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
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 210, 210);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAdd.ForeColor = Color.DimGray;
            btnAdd.Location = new Point(132, 360);
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
            btnUpdate.Location = new Point(263, 360);
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
            btnDelete.Location = new Point(132, 404);
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
            btnRefresh.Location = new Point(263, 404);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(114, 30);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
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