namespace PetManagerWinForm.NghiepVu.QLDichVu
{
    partial class QuanLyDichVu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvSer = new DataGridView();
            colSerId = new DataGridViewTextBoxColumn();
            colSerName = new DataGridViewTextBoxColumn();
            colSerType = new DataGridViewTextBoxColumn();
            colSerPrice = new DataGridViewTextBoxColumn();
            panelControl = new Panel();
            labelSearch = new Label();
            btn_ShowAll = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            labelTitle = new Label();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            labelPrice = new Label();
            txtPrice = new TextBox();
            btnDeleteType = new Button();
            btnUpdateType = new Button();
            btnAddType = new Button();
            labelType = new Label();
            cmbType = new ComboBox();
            labelName = new Label();
            txtName = new TextBox();
            labelID = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSer).BeginInit();
            panelControl.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSer
            // 
            dgvSer.AllowUserToAddRows = false;
            dgvSer.BackgroundColor = Color.White;
            dgvSer.BorderStyle = BorderStyle.None;
            dgvSer.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(231, 84, 84);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(231, 84, 84);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSer.ColumnHeadersHeight = 40;
            dgvSer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSer.Columns.AddRange(new DataGridViewColumn[] { colSerId, colSerName, colSerType, colSerPrice });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 229, 229);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSer.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSer.Dock = DockStyle.Fill;
            dgvSer.EnableHeadersVisualStyles = false;
            dgvSer.GridColor = Color.FromArgb(255, 200, 200);
            dgvSer.Location = new Point(0, 0);
            dgvSer.Margin = new Padding(4, 3, 4, 3);
            dgvSer.MultiSelect = false;
            dgvSer.Name = "dgvSer";
            dgvSer.ReadOnly = true;
            dgvSer.RowHeadersVisible = false;
            dgvSer.RowTemplate.Height = 35;
            dgvSer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSer.Size = new Size(630, 786);
            dgvSer.TabIndex = 0;
            dgvSer.CellClick += dgvSer_CellClick;
            dgvSer.CellContentClick += dgvSer_CellContentClick;
            // 
            // colSerId
            // 
            colSerId.HeaderText = "Mã";
            colSerId.MinimumWidth = 6;
            colSerId.Name = "colSerId";
            colSerId.ReadOnly = true;
            colSerId.Width = 80;
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
            colSerType.Width = 150;
            // 
            // colSerPrice
            // 
            colSerPrice.HeaderText = "Giá (VND)";
            colSerPrice.MinimumWidth = 6;
            colSerPrice.Name = "colSerPrice";
            colSerPrice.ReadOnly = true;
            colSerPrice.Width = 150;
            // 
            // panelControl
            // 
            panelControl.BackColor = Color.FromArgb(255, 240, 241);
            panelControl.Controls.Add(labelSearch);
            panelControl.Controls.Add(btn_ShowAll);
            panelControl.Controls.Add(btnSearch);
            panelControl.Controls.Add(txtSearch);
            panelControl.Controls.Add(labelTitle);
            panelControl.Controls.Add(btnRefresh);
            panelControl.Controls.Add(btnDelete);
            panelControl.Controls.Add(btnUpdate);
            panelControl.Controls.Add(btnAdd);
            panelControl.Controls.Add(labelPrice);
            panelControl.Controls.Add(txtPrice);
            panelControl.Controls.Add(btnDeleteType);
            panelControl.Controls.Add(btnUpdateType);
            panelControl.Controls.Add(btnAddType);
            panelControl.Controls.Add(labelType);
            panelControl.Controls.Add(cmbType);
            panelControl.Controls.Add(labelName);
            panelControl.Controls.Add(txtName);
            panelControl.Controls.Add(labelID);
            panelControl.Controls.Add(txtId);
            panelControl.Dock = DockStyle.Right;
            panelControl.Location = new Point(630, 0);
            panelControl.Margin = new Padding(4, 3, 4, 3);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(804, 786);
            panelControl.TabIndex = 1;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 10F);
            labelSearch.ForeColor = Color.FromArgb(90, 30, 30);
            labelSearch.Location = new Point(21, 17);
            labelSearch.Margin = new Padding(4, 0, 4, 0);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(145, 19);
            labelSearch.TabIndex = 42;
            labelSearch.Text = "Tìm theo tên hoặc giá:";
            // 
            // btn_ShowAll
            // 
            btn_ShowAll.BackColor = Color.FromArgb(149, 165, 166);
            btn_ShowAll.FlatAppearance.BorderSize = 0;
            btn_ShowAll.FlatStyle = FlatStyle.Flat;
            btn_ShowAll.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_ShowAll.ForeColor = Color.White;
            btn_ShowAll.Location = new Point(365, 43);
            btn_ShowAll.Margin = new Padding(4, 3, 4, 3);
            btn_ShowAll.Name = "btn_ShowAll";
            btn_ShowAll.Size = new Size(82, 33);
            btn_ShowAll.TabIndex = 41;
            btn_ShowAll.Text = "Tất cả";
            btn_ShowAll.UseVisualStyleBackColor = false;
            btn_ShowAll.Click += btn_ShowAll_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(231, 76, 60);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(276, 43);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 33);
            btnSearch.TabIndex = 40;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F);
            txtSearch.Location = new Point(24, 43);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(244, 29);
            txtSearch.TabIndex = 39;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(90, 30, 30);
            labelTitle.Location = new Point(19, 104);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(173, 25);
            labelTitle.TabIndex = 36;
            labelTitle.Text = "Thông tin dịch vụ:";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Gray;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(314, 522);
            btnRefresh.Margin = new Padding(4, 3, 4, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(133, 39);
            btnRefresh.TabIndex = 35;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 57, 43);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(314, 475);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(133, 39);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(41, 128, 185);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(169, 475);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(138, 39);
            btnUpdate.TabIndex = 33;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(39, 174, 96);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(24, 475);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 39);
            btnAdd.TabIndex = 32;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 12F);
            labelPrice.ForeColor = Color.FromArgb(90, 30, 30);
            labelPrice.Location = new Point(20, 387);
            labelPrice.Margin = new Padding(4, 0, 4, 0);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(36, 21);
            labelPrice.TabIndex = 31;
            labelPrice.Text = "Giá:";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F);
            txtPrice.Location = new Point(24, 414);
            txtPrice.Margin = new Padding(4, 3, 4, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(422, 29);
            txtPrice.TabIndex = 30;
            // 
            // btnDeleteType
            // 
            btnDeleteType.BackColor = Color.FromArgb(192, 57, 43);
            btnDeleteType.FlatAppearance.BorderSize = 0;
            btnDeleteType.FlatStyle = FlatStyle.Flat;
            btnDeleteType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteType.ForeColor = Color.White;
            btnDeleteType.Location = new Point(401, 333);
            btnDeleteType.Margin = new Padding(4, 3, 4, 3);
            btnDeleteType.Name = "btnDeleteType";
            btnDeleteType.Size = new Size(46, 33);
            btnDeleteType.TabIndex = 29;
            btnDeleteType.Text = "Xóa";
            btnDeleteType.UseVisualStyleBackColor = false;
            btnDeleteType.Click += btnDeleteType_Click;
            // 
            // btnUpdateType
            // 
            btnUpdateType.BackColor = Color.FromArgb(41, 128, 185);
            btnUpdateType.FlatAppearance.BorderSize = 0;
            btnUpdateType.FlatStyle = FlatStyle.Flat;
            btnUpdateType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdateType.ForeColor = Color.White;
            btnUpdateType.Location = new Point(350, 333);
            btnUpdateType.Margin = new Padding(4, 3, 4, 3);
            btnUpdateType.Name = "btnUpdateType";
            btnUpdateType.Size = new Size(47, 33);
            btnUpdateType.TabIndex = 28;
            btnUpdateType.Text = "Sửa";
            btnUpdateType.UseVisualStyleBackColor = false;
            btnUpdateType.Click += btnUpdateType_Click;
            // 
            // btnAddType
            // 
            btnAddType.BackColor = Color.FromArgb(39, 174, 96);
            btnAddType.FlatAppearance.BorderSize = 0;
            btnAddType.FlatStyle = FlatStyle.Flat;
            btnAddType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddType.ForeColor = Color.White;
            btnAddType.Location = new Point(309, 333);
            btnAddType.Margin = new Padding(4, 3, 4, 3);
            btnAddType.Name = "btnAddType";
            btnAddType.Size = new Size(36, 33);
            btnAddType.TabIndex = 27;
            btnAddType.Text = "+";
            btnAddType.UseVisualStyleBackColor = false;
            btnAddType.Click += btnAddType_Click;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI", 12F);
            labelType.ForeColor = Color.FromArgb(90, 30, 30);
            labelType.Location = new Point(20, 306);
            labelType.Margin = new Padding(4, 0, 4, 0);
            labelType.Name = "labelType";
            labelType.Size = new Size(42, 21);
            labelType.TabIndex = 26;
            labelType.Text = "Loại:";
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Font = new Font("Segoe UI", 12F);
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(24, 333);
            cmbType.Margin = new Padding(4, 3, 4, 3);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(277, 29);
            cmbType.TabIndex = 25;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.ForeColor = Color.FromArgb(90, 30, 30);
            labelName.Location = new Point(20, 225);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(36, 21);
            labelName.TabIndex = 24;
            labelName.Text = "Tên:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(24, 253);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(422, 29);
            txtName.TabIndex = 23;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 12F);
            labelID.ForeColor = Color.FromArgb(90, 30, 30);
            labelID.Location = new Point(20, 144);
            labelID.Margin = new Padding(4, 0, 4, 0);
            labelID.Name = "labelID";
            labelID.Size = new Size(28, 21);
            labelID.TabIndex = 22;
            labelID.Text = "ID:";
            // 
            // txtId
            // 
            txtId.BackColor = Color.WhiteSmoke;
            txtId.Font = new Font("Segoe UI", 12F);
            txtId.Location = new Point(24, 172);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(422, 29);
            txtId.TabIndex = 21;
            // 
            // QuanLyDichVu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1434, 786);
            Controls.Add(dgvSer);
            Controls.Add(panelControl);
            Margin = new Padding(4, 3, 4, 3);
            Name = "QuanLyDichVu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý dịch vụ";
            ((System.ComponentModel.ISupportInitialize)dgvSer).EndInit();
            panelControl.ResumeLayout(false);
            panelControl.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSer;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDeleteType;
        private System.Windows.Forms.Button btnUpdateType;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button btn_ShowAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerPrice;
    }
}