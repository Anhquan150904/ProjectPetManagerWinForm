namespace PetManagerWinForm.NghiepVu.QLThuCung
{
    partial class ThuCungChuaBan
    {
        private System.ComponentModel.IContainer components = null;

        // KHAI BÁO CÁC FIELDS (Đảm bảo chỉ khai báo MỘT LẦN ở đây)
        private DataGridView dgvPets;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtType;
        private TextBox txtAge;
        private TextBox txtPrice;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridViewTextBoxColumn colPetId;
        private DataGridViewTextBoxColumn colPetName;
        private DataGridViewTextBoxColumn colPetType;
        private DataGridViewTextBoxColumn colPetAge;
        private DataGridViewTextBoxColumn colPetPrice;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btn_ShowAll;
        private Button btnRefresh;

        // Panels và Labels
        private Panel panelLeft;
        private Panel panelRight;
        private Label lblSearch;
        private Label lblTitle;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panelLeft = new Panel();
            dgvPets = new DataGridView();
            colPetId = new DataGridViewTextBoxColumn();
            colPetName = new DataGridViewTextBoxColumn();
            colPetType = new DataGridViewTextBoxColumn();
            colPetAge = new DataGridViewTextBoxColumn();
            colPetPrice = new DataGridViewTextBoxColumn();
            panelRight = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btn_ShowAll = new Button();
            lblTitle = new Label();
            label3 = new Label();
            txtId = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label5 = new Label();
            txtType = new TextBox();
            label6 = new Label();
            txtAge = new TextBox();
            label7 = new Label();
            txtPrice = new TextBox();
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
            panelLeft.Padding = new Padding(10);
            panelLeft.Size = new Size(650, 1033);
            panelLeft.TabIndex = 0;
            // 
            // dgvPets
            // 
            dgvPets.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 240, 240);
            dgvPets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvPets.BackgroundColor = Color.White;
            dgvPets.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(220, 100, 100);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvPets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvPets.ColumnHeadersHeight = 40;
            dgvPets.Columns.AddRange(new DataGridViewColumn[] { colPetId, colPetName, colPetType, colPetAge, colPetPrice });
            dgvPets.Dock = DockStyle.Fill;
            dgvPets.EnableHeadersVisualStyles = false;
            dgvPets.GridColor = Color.FromArgb(255, 230, 230);
            dgvPets.Location = new Point(10, 10);
            dgvPets.Name = "dgvPets";
            dgvPets.ReadOnly = true;
            dgvPets.RowHeadersVisible = false;
            dgvPets.RowHeadersWidth = 10;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dgvPets.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvPets.RowTemplate.Height = 35;
            dgvPets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPets.Size = new Size(630, 1013);
            dgvPets.TabIndex = 0;
            dgvPets.CellClick += dgvPets_CellClick;
            // 
            // colPetId
            // 
            colPetId.HeaderText = "Mã Pet";
            colPetId.MinimumWidth = 6;
            colPetId.Name = "colPetId";
            colPetId.ReadOnly = true;
            colPetId.Width = 90;
            // 
            // colPetName
            // 
            colPetName.HeaderText = "Tên Thú Cưng";
            colPetName.MinimumWidth = 6;
            colPetName.Name = "colPetName";
            colPetName.ReadOnly = true;
            colPetName.Width = 150;
            // 
            // colPetType
            // 
            colPetType.HeaderText = "Giống";
            colPetType.MinimumWidth = 6;
            colPetType.Name = "colPetType";
            colPetType.ReadOnly = true;
            colPetType.Width = 150;
            // 
            // colPetAge
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10F);
            colPetAge.DefaultCellStyle = dataGridViewCellStyle8;
            colPetAge.HeaderText = "Tuổi";
            colPetAge.MinimumWidth = 6;
            colPetAge.Name = "colPetAge";
            colPetAge.ReadOnly = true;
            colPetAge.Width = 80;
            // 
            // colPetPrice
            // 
            dataGridViewCellStyle9.Format = "#,##0.##";
            colPetPrice.DefaultCellStyle = dataGridViewCellStyle9;
            colPetPrice.HeaderText = "Giá (VNĐ)";
            colPetPrice.MinimumWidth = 6;
            colPetPrice.Name = "colPetPrice";
            colPetPrice.ReadOnly = true;
            colPetPrice.Width = 150;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.FromArgb(255, 230, 230);
            panelRight.Controls.Add(lblSearch);
            panelRight.Controls.Add(txtSearch);
            panelRight.Controls.Add(btnSearch);
            panelRight.Controls.Add(btn_ShowAll);
            panelRight.Controls.Add(lblTitle);
            panelRight.Controls.Add(label3);
            panelRight.Controls.Add(txtId);
            panelRight.Controls.Add(label4);
            panelRight.Controls.Add(txtName);
            panelRight.Controls.Add(label5);
            panelRight.Controls.Add(txtType);
            panelRight.Controls.Add(label6);
            panelRight.Controls.Add(txtAge);
            panelRight.Controls.Add(label7);
            panelRight.Controls.Add(txtPrice);
            panelRight.Controls.Add(btnAdd);
            panelRight.Controls.Add(btnUpdate);
            panelRight.Controls.Add(btnDelete);
            panelRight.Controls.Add(btnRefresh);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(650, 0);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(30);
            panelRight.Size = new Size(1252, 1033);
            panelRight.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSearch.Location = new Point(20, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(208, 25);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm theo tên hoặc giá:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(20, 55);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(280, 27);
            txtSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 210, 210);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSearch.ForeColor = Color.DimGray;
            btnSearch.Location = new Point(320, 50);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(130, 40);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btn_Search_Click;
            // 
            // btn_ShowAll
            // 
            btn_ShowAll.BackColor = Color.FromArgb(255, 210, 210);
            btn_ShowAll.FlatAppearance.BorderSize = 0;
            btn_ShowAll.FlatStyle = FlatStyle.Flat;
            btn_ShowAll.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_ShowAll.ForeColor = Color.DimGray;
            btn_ShowAll.Location = new Point(455, 50);
            btn_ShowAll.Name = "btn_ShowAll";
            btn_ShowAll.Size = new Size(130, 40);
            btn_ShowAll.TabIndex = 12;
            btn_ShowAll.Text = "Tất cả";
            btn_ShowAll.UseVisualStyleBackColor = false;
            btn_ShowAll.Click += btnShowAll_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 115);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(242, 32);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Thông tin thú cưng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(20, 163);
            label3.Name = "label3";
            label3.Size = new Size(34, 25);
            label3.TabIndex = 14;
            label3.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(150, 160);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(280, 27);
            txtId.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(20, 213);
            label4.Name = "label4";
            label4.Size = new Size(45, 25);
            label4.TabIndex = 15;
            label4.Text = "Tên:";
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 210);
            txtName.Name = "txtName";
            txtName.Size = new Size(280, 27);
            txtName.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(20, 263);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 16;
            label5.Text = "Giống:";
            // 
            // txtType
            // 
            txtType.Location = new Point(150, 260);
            txtType.Name = "txtType";
            txtType.Size = new Size(280, 27);
            txtType.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(20, 313);
            label6.Name = "label6";
            label6.Size = new Size(53, 25);
            label6.TabIndex = 17;
            label6.Text = "Tuổi:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(150, 310);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(280, 27);
            txtAge.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(20, 363);
            label7.Name = "label7";
            label7.Size = new Size(44, 25);
            label7.TabIndex = 18;
            label7.Text = "Giá:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(150, 360);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(280, 27);
            txtPrice.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 210, 210);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAdd.ForeColor = Color.DimGray;
            btnAdd.Location = new Point(150, 410);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 40);
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
            btnUpdate.Location = new Point(300, 410);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 40);
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
            btnDelete.Location = new Point(150, 470);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 40);
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
            btnRefresh.Location = new Point(300, 470);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(130, 40);
            btnRefresh.TabIndex = 15;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ThuCungChuaBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 230, 230);
            ClientSize = new Size(1902, 1033);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Name = "ThuCungChuaBan";
            Text = "Quản lý thú cưng chưa bán";
            WindowState = FormWindowState.Maximized;
            Load += ThuCungChuaBan_Load;
            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPets).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);
        }
    }
}