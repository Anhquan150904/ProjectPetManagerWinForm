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
            txtId.Location = new Point(773, 12);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(200, 23);
            txtId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(773, 52);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 2;
            // 
            // txtType
            // 
            txtType.Location = new Point(773, 92);
            txtType.Name = "txtType";
            txtType.Size = new Size(200, 23);
            txtType.TabIndex = 3;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(773, 132);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(200, 23);
            txtAge.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(773, 172);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 23);
            txtPrice.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(773, 222);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 30);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(883, 222);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 30);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(773, 262);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 30);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSold
            // 
            btnSold.Location = new Point(883, 262);
            btnSold.Name = "btnSold";
            btnSold.Size = new Size(90, 30);
            btnSold.TabIndex = 9;
            btnSold.Text = "Sold";
            btnSold.Click += btnSold_Click;
            // 
            // ThuCungChuaBan
            // 
            ClientSize = new Size(1026, 511);
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
    }
}