namespace PetManagerWinForm.NghiepVu.QLDichVu
{
    partial class QuanLyDichVu
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnRefresh = new Button();
            label2 = new Label();
            label1 = new Label();
            btn_ShowAll = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dgvSer = new DataGridView();
            colIndex = new DataGridViewTextBoxColumn();
            colSerId = new DataGridViewTextBoxColumn();
            colSerName = new DataGridViewTextBoxColumn();
            colSerType = new DataGridViewTextBoxColumn();
            colSerPrice = new DataGridViewTextBoxColumn();
            txtId = new TextBox();
            txtName = new TextBox();
            cmbType = new ComboBox();
            btnAddType = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            txtPrice = new TextBox();
            btnUpdateType = new Button();
            btnDeleteType = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSer).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(90, 30, 30);
            label7.Location = new Point(715, 284);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 41;
            label7.Text = "Giá:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(90, 30, 30);
            label5.Location = new Point(715, 202);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 39;
            label5.Text = "Loại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(90, 30, 30);
            label4.Location = new Point(715, 162);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 38;
            label4.Text = "Tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(90, 30, 30);
            label3.Location = new Point(715, 122);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 37;
            label3.Text = "ID:";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(255, 200, 200);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.FromArgb(90, 30, 30);
            btnRefresh.Location = new Point(877, 411);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 34);
            btnRefresh.TabIndex = 36;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(90, 30, 30);
            label2.Location = new Point(720, 90);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 35;
            label2.Text = "Thông tin dịch vụ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(90, 30, 30);
            label1.Location = new Point(720, 2);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 34;
            label1.Text = "Tìm theo tên hoặc giá:";
            // 
            // btn_ShowAll
            // 
            btn_ShowAll.BackColor = Color.FromArgb(255, 200, 200);
            btn_ShowAll.FlatAppearance.BorderSize = 0;
            btn_ShowAll.FlatStyle = FlatStyle.Flat;
            btn_ShowAll.ForeColor = Color.FromArgb(90, 30, 30);
            btn_ShowAll.Location = new Point(1080, 18);
            btn_ShowAll.Name = "btn_ShowAll";
            btn_ShowAll.Size = new Size(80, 28);
            btn_ShowAll.TabIndex = 33;
            btn_ShowAll.Text = "Tất cả";
            btn_ShowAll.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 200, 200);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.FromArgb(90, 30, 30);
            btnSearch.Location = new Point(990, 18);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 28);
            btnSearch.TabIndex = 32;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(720, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(260, 23);
            txtSearch.TabIndex = 31;
            // 
            // dgvSer
            // 
            dgvSer.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 245, 245);
            dgvSer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            // default rows appearance (pale pink)
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 245, 245);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 220, 220);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dgvSer.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(231, 84, 84);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSer.ColumnHeadersHeight = 36;
            dgvSer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSer.Columns.AddRange(new DataGridViewColumn[] { colIndex, colSerId, colSerName, colSerType, colSerPrice });
            dgvSer.EnableHeadersVisualStyles = false;
            // subtle pink horizontal separators
            dgvSer.GridColor = Color.FromArgb(255, 225, 225);
            dgvSer.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSer.Location = new Point(12, 12);
            dgvSer.Name = "dgvSer";
            dgvSer.ReadOnly = true;
            dgvSer.RowHeadersWidth = 51;
            dgvSer.RowTemplate.Height = 30;
            dgvSer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSer.Size = new Size(560, 696);
            dgvSer.TabIndex = 21;
            dgvSer.CellContentClick += dgvSer_CellContentClick;
            // 
            // colIndex
            // 
            colIndex.HeaderText = "STT";
            colIndex.MinimumWidth = 6;
            colIndex.Name = "colIndex";
            colIndex.ReadOnly = true;
            colIndex.Width = 50;
            // 
            // colSerId
            // 
            colSerId.HeaderText = "Mã";
            colSerId.MinimumWidth = 6;
            colSerId.Name = "colSerId";
            colSerId.ReadOnly = true;
            colSerId.Width = 60;
            // 
            // colSerName
            // 
            colSerName.HeaderText = "Tên Dịch Vụ";
            colSerName.MinimumWidth = 6;
            colSerName.Name = "colSerName";
            colSerName.ReadOnly = true;
            colSerName.Width = 250;
            // 
            // colSerType
            // 
            colSerType.HeaderText = "Loại";
            colSerType.MinimumWidth = 6;
            colSerType.Name = "colSerType";
            colSerType.ReadOnly = true;
            colSerType.Width = 120;
            // 
            // colSerPrice
            // 
            colSerPrice.HeaderText = "Giá (VND)";
            colSerPrice.MinimumWidth = 6;
            colSerPrice.Name = "colSerPrice";
            colSerPrice.ReadOnly = true;
            colSerPrice.Width = 120;
            // 
            // txtId
            // 
            txtId.Location = new Point(755, 119);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(389, 23);
            txtId.TabIndex = 22;
            // 
            // txtName
            // 
            txtName.Location = new Point(755, 159);
            txtName.Name = "txtName";
            txtName.Size = new Size(389, 23);
            txtName.TabIndex = 23;
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(755, 199);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(389, 23);
            cmbType.TabIndex = 24;
            // 
            // btnAddType
            // 
            btnAddType.BackColor = Color.FromArgb(255, 220, 220);
            btnAddType.FlatAppearance.BorderSize = 0;
            btnAddType.FlatStyle = FlatStyle.Flat;
            btnAddType.ForeColor = Color.FromArgb(90, 30, 30);
            btnAddType.Location = new Point(760, 238);
            btnAddType.Name = "btnAddType";
            btnAddType.Size = new Size(30, 26);
            btnAddType.TabIndex = 25;
            btnAddType.Text = "+";
            btnAddType.UseVisualStyleBackColor = false;
            btnAddType.Click += btnAddType_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 200, 200);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.FromArgb(90, 30, 30);
            btnDelete.Location = new Point(1035, 346);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 34);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 200, 200);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.FromArgb(90, 30, 30);
            btnAdd.Location = new Point(715, 346);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 34);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 200, 200);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.FromArgb(90, 30, 30);
            btnUpdate.Location = new Point(877, 346);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 34);
            btnUpdate.TabIndex = 28;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(755, 281);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(389, 23);
            txtPrice.TabIndex = 26;
            // 
            // btnUpdateType
            // 
            btnUpdateType.BackColor = Color.FromArgb(255, 220, 220);
            btnUpdateType.FlatAppearance.BorderSize = 0;
            btnUpdateType.FlatStyle = FlatStyle.Flat;
            btnUpdateType.ForeColor = Color.FromArgb(90, 30, 30);
            btnUpdateType.Location = new Point(796, 238);
            btnUpdateType.Name = "btnUpdateType";
            btnUpdateType.Size = new Size(60, 26);
            btnUpdateType.TabIndex = 26;
            btnUpdateType.Text = "Sửa";
            btnUpdateType.UseVisualStyleBackColor = false;
            btnUpdateType.Click += btnUpdateType_Click;
            // 
            // btnDeleteType
            // 
            btnDeleteType.BackColor = Color.FromArgb(255, 220, 220);
            btnDeleteType.FlatAppearance.BorderSize = 0;
            btnDeleteType.FlatStyle = FlatStyle.Flat;
            btnDeleteType.ForeColor = Color.FromArgb(90, 30, 30);
            btnDeleteType.Location = new Point(860, 238);
            btnDeleteType.Name = "btnDeleteType";
            btnDeleteType.Size = new Size(60, 26);
            btnDeleteType.TabIndex = 27;
            btnDeleteType.Text = "Xóa";
            btnDeleteType.UseVisualStyleBackColor = false;
            btnDeleteType.Click += btnDeleteType_Click;
            // 
            // QuanLyDichVu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 240, 241);
            ClientSize = new Size(1229, 720);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnRefresh);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_ShowAll);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvSer);
            Controls.Add(txtId);
            Controls.Add(txtName);
            Controls.Add(cmbType);
            Controls.Add(btnAddType);
            Controls.Add(btnUpdateType);
            Controls.Add(btnDeleteType);
            Controls.Add(txtPrice);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Font = new Font("Segoe UI", 9F);
            Name = "QuanLyDichVu";
            Text = "QuanLyDichVu";
            ((System.ComponentModel.ISupportInitialize)dgvSer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnRefresh;
        private Label label2;
        private Label label1;
        private Button btn_ShowAll;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgvSer;
        private TextBox txtId;
        private TextBox txtName;
        private ComboBox cmbType;
        private Button btnAddType;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnUpdate;
        private DataGridViewTextBoxColumn colSerId;
        private DataGridViewTextBoxColumn colSerName;
        private DataGridViewTextBoxColumn colSerType;
        private DataGridViewTextBoxColumn colSerPrice;
        private TextBox txtPrice;
        private Button btnUpdateType;
        private Button btnDeleteType;
        private DataGridViewTextBoxColumn colIndex;
    }
}