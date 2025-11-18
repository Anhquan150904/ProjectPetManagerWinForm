namespace PetManagerWinForm.NghiepVu.QLThuCung
{
    partial class ThuCungChuaBan
    {
        private System.ComponentModel.IContainer components = null;

        private DataGridView dgvPets;

        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtType;
        private TextBox txtAge;
        private TextBox txtPrice;

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSold;

        private DataGridViewTextBoxColumn colPetId;
        private DataGridViewTextBoxColumn colPetName;
        private DataGridViewTextBoxColumn colPetType;
        private DataGridViewTextBoxColumn colPetAge;
        private DataGridViewTextBoxColumn colPetPrice;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
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
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSold = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btn_ShowAll = new Button();
            label1 = new Label();
            label2 = new Label();
            btnRefresh = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPets).BeginInit();
            SuspendLayout();
            // 
            // dgvPets
            // 
            dgvPets.AllowUserToAddRows = false;
            dgvPets.ColumnHeadersHeight = 29;
            dgvPets.Columns.AddRange(new DataGridViewColumn[] { colPetId, colPetName, colPetType, colPetAge, colPetPrice });
            dgvPets.Location = new Point(12, 12);
            dgvPets.Name = "dgvPets";
            dgvPets.ReadOnly = true;
            dgvPets.RowHeadersWidth = 51;
            dgvPets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPets.Size = new Size(678, 471);
            dgvPets.TabIndex = 0;
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
            txtId.Location = new Point(965, 118);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(200, 27);
            txtId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(965, 158);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 2;
            // 
            // txtType
            // 
            txtType.Location = new Point(965, 198);
            txtType.Name = "txtType";
            txtType.Size = new Size(200, 27);
            txtType.TabIndex = 3;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(965, 238);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(200, 27);
            txtAge.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(965, 278);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 27);
            txtPrice.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1186, 236);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 30);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1296, 236);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 30);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1186, 276);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 30);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSold
            // 
            btnSold.Location = new Point(1296, 276);
            btnSold.Name = "btnSold";
            btnSold.Size = new Size(90, 30);
            btnSold.TabIndex = 9;
            btnSold.Text = "Sold";
            btnSold.Click += btnSold_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(915, 19);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 27);
            txtSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1168, 19);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 30);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.Click += btn_Search_Click;
            // 
            // btn_ShowAll
            // 
            btn_ShowAll.Location = new Point(1278, 19);
            btn_ShowAll.Name = "btn_ShowAll";
            btn_ShowAll.Size = new Size(90, 30);
            btn_ShowAll.TabIndex = 12;
            btn_ShowAll.Text = "ShowAll";
            btn_ShowAll.Click += btnShowAll_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(701, 22);
            label1.Name = "label1";
            label1.Size = new Size(208, 20);
            label1.TabIndex = 13;
            label1.Text = "Tìm kiếm theo tên/giống/giá :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(701, 118);
            label2.Name = "label2";
            label2.Size = new Size(195, 20);
            label2.TabIndex = 14;
            label2.Text = "Form để thêm/sửa/xóa/bán:";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1186, 116);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 30);
            btnRefresh.TabIndex = 15;
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(902, 121);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 16;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(902, 161);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 17;
            label4.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(902, 201);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 18;
            label5.Text = "Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(902, 241);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 19;
            label6.Text = "Age:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(902, 281);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 20;
            label7.Text = "Price:";
            // 
            // ThuCungChuaBan
            // 
            ClientSize = new Size(1396, 511);
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
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSold);
            Name = "ThuCungChuaBan";
            Text = "Quản lý thú cưng chưa bán";
            Load += ThuCungChuaBan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btn_ShowAll;
        private Label label1;
        private Label label2;
        private Button btnRefresh;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}