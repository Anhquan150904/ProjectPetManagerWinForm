namespace PetManagerWinForm.NghiepVu.QLKhachHang
{
    partial class ThongTinKhachHang
    {
       
        private System.ComponentModel.IContainer components = null;

        private DataGridView dgvCustomers;

        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;

        private DataGridViewTextBoxColumn colCus_Id;
        private DataGridViewTextBoxColumn colCus_Name;
        private DataGridViewTextBoxColumn colAddress;
        private DataGridViewTextBoxColumn colPhoneNumber;
        private DataGridViewTextBoxColumn colEmail;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
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
            dgvCustomers = new DataGridView();
            colCus_Id = new DataGridViewTextBoxColumn();
            colCus_Name = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            colPhoneNumber = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            txtId = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.ColumnHeadersHeight = 29;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { colCus_Id, colCus_Name, colAddress, colPhoneNumber, colEmail });
            dgvCustomers.Location = new Point(12, 12);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(678, 471);
            dgvCustomers.TabIndex = 0;
            dgvCustomers.CellClick += dgvCustomers_CellClick;
            // 
            // colCus_Id
            // 
            colCus_Id.HeaderText = "ID";
            colCus_Id.MinimumWidth = 6;
            colCus_Id.Name = "colCus_Id";
            colCus_Id.ReadOnly = true;
            colCus_Id.Width = 125;
            // 
            // colCus_Name
            // 
            colCus_Name.HeaderText = "Name";
            colCus_Name.MinimumWidth = 6;
            colCus_Name.Name = "colCus_Name";
            colCus_Name.ReadOnly = true;
            colCus_Name.Width = 125;
            // 
            // colAddress
            // 
            colAddress.HeaderText = "Address";
            colAddress.MinimumWidth = 6;
            colAddress.Name = "colAddress";
            colAddress.ReadOnly = true;
            colAddress.Width = 125;
            // 
            // colPhoneNumber
            // 
            colPhoneNumber.HeaderText = "PhoneNumber";
            colPhoneNumber.MinimumWidth = 6;
            colPhoneNumber.Name = "colPhoneNumber";
            colPhoneNumber.ReadOnly = true;
            colPhoneNumber.Width = 125;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Width = 125;
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
            // txtAddress
            // 
            txtAddress.Location = new Point(773, 92);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 23);
            txtAddress.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(773, 132);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(200, 23);
            txtPhoneNumber.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(773, 172);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 5;
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
            // ThongTinKhachHang
            // 
            ClientSize = new Size(1026, 511);
            Controls.Add(dgvCustomers);
            Controls.Add(txtId);
            Controls.Add(txtName);
            Controls.Add(txtAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Name = "ThongTinKhachHang";
            Text = "Thông Tin Khách Hàng";
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}