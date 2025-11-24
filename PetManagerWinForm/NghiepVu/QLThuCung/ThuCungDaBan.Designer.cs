namespace PetManagerWinForm.NghiepVu.QLThuCung
{
    partial class ThuCungDaBan
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnRefresh = new Button();
            label2 = new Label();
            label1 = new Label();
            btn_ShowAll = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dgvPets = new DataGridView();
            colPetId = new DataGridViewTextBoxColumn();
            colPetName = new DataGridViewTextBoxColumn();
            colPetType = new DataGridViewTextBoxColumn();
            colPetAge = new DataGridViewTextBoxColumn();
            colPetPrice = new DataGridViewTextBoxColumn();
            txtId = new TextBox();
            txtName = new TextBox();
            txtType = new TextBox();
            txtAge = new TextBox();
            txtPrice = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCancelSold = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPets).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(893, 281);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 41;
            label7.Text = "Price:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(893, 241);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 40;
            label6.Text = "Age:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(893, 201);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 39;
            label5.Text = "Type:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(893, 161);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 38;
            label4.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(893, 121);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 37;
            label3.Text = "ID:";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1177, 116);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 30);
            btnRefresh.TabIndex = 36;
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(692, 86);
            label2.Name = "label2";
            label2.Size = new Size(222, 20);
            label2.TabIndex = 35;
            label2.Text = "Form để thêm/sửa/xóa/hủy bán:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(692, 22);
            label1.Name = "label1";
            label1.Size = new Size(208, 20);
            label1.TabIndex = 34;
            label1.Text = "Tìm kiếm theo tên/giống/giá :";
            // 
            // btn_ShowAll
            // 
            btn_ShowAll.Location = new Point(1269, 19);
            btn_ShowAll.Name = "btn_ShowAll";
            btn_ShowAll.Size = new Size(90, 30);
            btn_ShowAll.TabIndex = 33;
            btn_ShowAll.Text = "ShowAll";
            btn_ShowAll.Click += btnShowAll_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1159, 19);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 30);
            btnSearch.TabIndex = 32;
            btnSearch.Text = "Search";
            btnSearch.Click += btn_Search_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(906, 19);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 27);
            txtSearch.TabIndex = 31;
            // 
            // dgvPets
            // 
            dgvPets.AllowUserToAddRows = false;
            dgvPets.ColumnHeadersHeight = 29;
            dgvPets.Columns.AddRange(new DataGridViewColumn[] { colPetId, colPetName, colPetType, colPetAge, colPetPrice });
            dgvPets.Location = new Point(3, 12);
            dgvPets.Name = "dgvPets";
            dgvPets.ReadOnly = true;
            dgvPets.RowHeadersWidth = 51;
            dgvPets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPets.Size = new Size(683, 471);
            dgvPets.TabIndex = 21;
            dgvPets.CellClick += dgvPets_CellClick;
            // 
            // colPetId
            // 
            colPetId.HeaderText = "ID";
            colPetId.MinimumWidth = 6;
            colPetId.Name = "colPetId";
            colPetId.ReadOnly = true;
            colPetId.Width = 125;
            // 
            // colPetName
            // 
            colPetName.HeaderText = "Name";
            colPetName.MinimumWidth = 6;
            colPetName.Name = "colPetName";
            colPetName.ReadOnly = true;
            colPetName.Width = 125;
            // 
            // colPetType
            // 
            colPetType.HeaderText = "Type";
            colPetType.MinimumWidth = 6;
            colPetType.Name = "colPetType";
            colPetType.ReadOnly = true;
            colPetType.Width = 125;
            // 
            // colPetAge
            // 
            colPetAge.HeaderText = "Age";
            colPetAge.MinimumWidth = 6;
            colPetAge.Name = "colPetAge";
            colPetAge.ReadOnly = true;
            colPetAge.Width = 125;
            // 
            // colPetPrice
            // 
            colPetPrice.HeaderText = "Price";
            colPetPrice.MinimumWidth = 6;
            colPetPrice.Name = "colPetPrice";
            colPetPrice.ReadOnly = true;
            colPetPrice.Width = 125;
            // 
            // txtId
            // 
            txtId.Location = new Point(956, 118);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(200, 27);
            txtId.TabIndex = 22;
            // 
            // txtName
            // 
            txtName.Location = new Point(956, 158);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 23;
            // 
            // txtType
            // 
            txtType.Location = new Point(956, 198);
            txtType.Name = "txtType";
            txtType.Size = new Size(200, 27);
            txtType.TabIndex = 24;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(956, 238);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(200, 27);
            txtAge.TabIndex = 25;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(956, 278);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 27);
            txtPrice.TabIndex = 26;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1186, 236);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 30);
            btnUpdate.TabIndex = 28;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1186, 276);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 30);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancelSold
            // 
            btnCancelSold.Location = new Point(1283, 238);
            btnCancelSold.Name = "btnCancelSold";
            btnCancelSold.Size = new Size(90, 68);
            btnCancelSold.TabIndex = 30;
            btnCancelSold.Text = "Cancel Sold";
            btnCancelSold.Click += btnCancelSold_Click;
            // 
            // ThuCungDaBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 515);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnRefresh);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_ShowAll);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvPets);
            Controls.Add(txtId);
            Controls.Add(txtName);
            Controls.Add(txtType);
            Controls.Add(txtAge);
            Controls.Add(txtPrice);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnCancelSold);
            Name = "ThuCungDaBan";
            Text = "ThuCungDaBan";
            ((System.ComponentModel.ISupportInitialize)dgvPets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnRefresh;
        private Label label2;
        private Label label1;
        private Button btn_ShowAll;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgvPets;
        private DataGridViewTextBoxColumn colPetId;
        private DataGridViewTextBoxColumn colPetName;
        private DataGridViewTextBoxColumn colPetType;
        private DataGridViewTextBoxColumn colPetAge;
        private DataGridViewTextBoxColumn colPetPrice;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtType;
        private TextBox txtAge;
        private TextBox txtPrice;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCancelSold;
    }
}