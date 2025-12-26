namespace PetManagerWinForm.NghiepVu.QLThuCung
{
    partial class ThuCungDaBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Khai báo lại các controls được sử dụng trong designer
        private DataGridView dgvPets;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtType;
        private TextBox txtAge;
        private TextBox txtPrice;
        private DataGridViewTextBoxColumn colPetId;
        private DataGridViewTextBoxColumn colPetName;
        private DataGridViewTextBoxColumn colPetType;
        private DataGridViewTextBoxColumn colPetAge;
        private DataGridViewTextBoxColumn colPetPrice;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btn_ShowAll;
        private Button btnRefresh;

        // Khai báo các Panels và Labels mới
        private Panel panelLeft;
        private Panel panelRight;
        private Label lblSearch;
        private Label lblTitle;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;


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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            panelLeft.Margin = new Padding(3, 2, 3, 2);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(9, 8, 9, 8);
            panelLeft.Size = new Size(569, 775);
            panelLeft.TabIndex = 0;
            // 
            // dgvPets
            // 
            dgvPets.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 240, 240);
            dgvPets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPets.BackgroundColor = Color.White;
            dgvPets.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(220, 100, 100);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPets.ColumnHeadersHeight = 40;
            dgvPets.Columns.AddRange(new DataGridViewColumn[] { colPetId, colPetName, colPetType, colPetAge, colPetPrice });
            dgvPets.Dock = DockStyle.Fill;
            dgvPets.EnableHeadersVisualStyles = false;
            dgvPets.GridColor = Color.FromArgb(255, 230, 230);
            dgvPets.Location = new Point(9, 8);
            dgvPets.Margin = new Padding(3, 2, 3, 2);
            dgvPets.Name = "dgvPets";
            dgvPets.ReadOnly = true;
            dgvPets.RowHeadersVisible = false;
            dgvPets.RowHeadersWidth = 10;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dgvPets.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvPets.RowTemplate.Height = 35;
            dgvPets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPets.Size = new Size(551, 759);
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            colPetAge.DefaultCellStyle = dataGridViewCellStyle3;
            colPetAge.HeaderText = "Tuổi";
            colPetAge.MinimumWidth = 6;
            colPetAge.Name = "colPetAge";
            colPetAge.ReadOnly = true;
            colPetAge.Width = 80;
            // 
            // colPetPrice
            // 
            dataGridViewCellStyle4.Format = "#,##0.##";
            colPetPrice.DefaultCellStyle = dataGridViewCellStyle4;
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
            panelRight.Controls.Add(btnRefresh);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(569, 0);
            panelRight.Margin = new Padding(3, 2, 3, 2);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(26, 22, 26, 22);
            panelRight.Size = new Size(1095, 775);
            panelRight.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSearch.Location = new Point(18, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(165, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm theo tên hoặc giá:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(18, 41);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(246, 23);
            txtSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 210, 210);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSearch.ForeColor = Color.DimGray;
            btnSearch.Location = new Point(280, 38);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(114, 30);
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
            btn_ShowAll.Location = new Point(398, 38);
            btn_ShowAll.Margin = new Padding(3, 2, 3, 2);
            btn_ShowAll.Name = "btn_ShowAll";
            btn_ShowAll.Size = new Size(114, 30);
            btn_ShowAll.TabIndex = 12;
            btn_ShowAll.Text = "Tất cả";
            btn_ShowAll.UseVisualStyleBackColor = false;
            btn_ShowAll.Click += btnShowAll_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(18, 86);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(272, 25);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Thông tin thú cưng (Đã bán):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(18, 122);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 14;
            label3.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(131, 120);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(246, 23);
            txtId.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(18, 160);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 15;
            label4.Text = "Tên:";
            // 
            // txtName
            // 
            txtName.Location = new Point(131, 158);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(246, 23);
            txtName.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(18, 197);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 16;
            label5.Text = "Giống:";
            // 
            // txtType
            // 
            txtType.Location = new Point(131, 195);
            txtType.Margin = new Padding(3, 2, 3, 2);
            txtType.Name = "txtType";
            txtType.ReadOnly = true;
            txtType.Size = new Size(246, 23);
            txtType.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(18, 235);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 17;
            label6.Text = "Tuổi:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(131, 232);
            txtAge.Margin = new Padding(3, 2, 3, 2);
            txtAge.Name = "txtAge";
            txtAge.ReadOnly = true;
            txtAge.Size = new Size(246, 23);
            txtAge.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(18, 272);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 18;
            label7.Text = "Giá:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(131, 270);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(246, 23);
            txtPrice.TabIndex = 5;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(255, 210, 210);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.DimGray;
            btnRefresh.Location = new Point(192, 311);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(114, 30);
            btnRefresh.TabIndex = 15;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ThuCungDaBan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 230, 230);
            ClientSize = new Size(1664, 775);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ThuCungDaBan";
            Text = "Quản lý thú cưng đã bán";
            WindowState = FormWindowState.Maximized;
            Load += ThuCungDaBan_Load;
            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPets).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // ... (Khai báo fields đã được giữ lại ở đầu class)
    }
}