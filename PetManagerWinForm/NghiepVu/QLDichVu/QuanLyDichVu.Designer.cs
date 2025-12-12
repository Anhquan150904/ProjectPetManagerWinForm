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
            label7.Location = new Point(902, 246);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 41;
            label7.Text = "Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(902, 201);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 39;
            label5.Text = "Type:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(902, 161);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 38;
            label4.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(902, 121);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 37;
            label3.Text = "ID:";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1186, 116);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 30);
            btnRefresh.TabIndex = 36;
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(701, 118);
            label2.Name = "label2";
            label2.Size = new Size(156, 15);
            label2.TabIndex = 35;
            label2.Text = "Form để thêm/sửa/xóa/bán:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(701, 22);
            label1.Name = "label1";
            label1.Size = new Size(167, 15);
            label1.TabIndex = 34;
            label1.Text = "Tìm kiếm theo tên/giống/giá :";
            // 
            // btn_ShowAll
            // 
            btn_ShowAll.Location = new Point(1278, 19);
            btn_ShowAll.Name = "btn_ShowAll";
            btn_ShowAll.Size = new Size(90, 30);
            btn_ShowAll.TabIndex = 33;
            btn_ShowAll.Text = "ShowAll";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1168, 19);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 30);
            btnSearch.TabIndex = 32;
            btnSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(915, 19);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 23);
            txtSearch.TabIndex = 31;
            // 
            // dgvSer
            // 
            dgvSer.AllowUserToAddRows = false;
            dgvSer.ColumnHeadersHeight = 29;
            dgvSer.Columns.AddRange(new DataGridViewColumn[] { colSerId, colSerName, colSerType, colSerPrice });
            dgvSer.Location = new Point(12, 12);
            dgvSer.Name = "dgvSer";
            dgvSer.ReadOnly = true;
            dgvSer.RowHeadersWidth = 51;
            dgvSer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSer.Size = new Size(678, 471);
            dgvSer.TabIndex = 21;
            dgvSer.CellContentClick += dgvSer_CellContentClick;
            // 
            // colSerId
            // 
            colSerId.HeaderText = "ID";
            colSerId.MinimumWidth = 6;
            colSerId.Name = "colSerId";
            colSerId.ReadOnly = true;
            colSerId.Width = 125;
            // 
            // colSerName
            // 
            colSerName.HeaderText = "Name";
            colSerName.MinimumWidth = 6;
            colSerName.Name = "colSerName";
            colSerName.ReadOnly = true;
            colSerName.Width = 125;
            // 
            // colSerType
            // 
            colSerType.HeaderText = "Type";
            colSerType.MinimumWidth = 6;
            colSerType.Name = "colSerType";
            colSerType.ReadOnly = true;
            colSerType.Width = 125;
            // 
            // colSerPrice
            // 
            colSerPrice.HeaderText = "Price";
            colSerPrice.MinimumWidth = 6;
            colSerPrice.Name = "colSerPrice";
            colSerPrice.ReadOnly = true;
            colSerPrice.Width = 125;
            // 
            // txtId
            // 
            txtId.Location = new Point(965, 118);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(200, 23);
            txtId.TabIndex = 22;
            // 
            // txtName
            // 
            txtName.Location = new Point(965, 158);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 23;
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(965, 197);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(200, 23);
            cmbType.TabIndex = 24;
            // 
            // btnAddType
            // 
            btnAddType.Location = new Point(1186, 197);
            btnAddType.Name = "btnAddType";
            btnAddType.Size = new Size(30, 23);
            btnAddType.TabIndex = 25;
            btnAddType.Text = "+";
            btnAddType.UseVisualStyleBackColor = true;
            btnAddType.Click += btnAddType_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1186, 276);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 30);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1186, 236);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 30);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Add";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1296, 236);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 30);
            btnUpdate.TabIndex = 28;
            btnUpdate.Text = "Update";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(965, 238);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 23);
            txtPrice.TabIndex = 26;
            // 
            // btnUpdateType
            // 
            btnUpdateType.Location = new Point(1228, 197);
            btnUpdateType.Name = "btnUpdateType";
            btnUpdateType.Size = new Size(60, 23);
            btnUpdateType.TabIndex = 26;
            btnUpdateType.Text = "Edit";
            btnUpdateType.UseVisualStyleBackColor = true;
            btnUpdateType.Click += btnUpdateType_Click;
            // 
            // btnDeleteType
            // 
            btnDeleteType.Location = new Point(1296, 197);
            btnDeleteType.Name = "btnDeleteType";
            btnDeleteType.Size = new Size(60, 23);
            btnDeleteType.TabIndex = 27;
            btnDeleteType.Text = "Delete";
            btnDeleteType.UseVisualStyleBackColor = true;
            btnDeleteType.Click += btnDeleteType_Click;
            // 
            // QuanLyDichVu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1416, 499);
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
    }
}