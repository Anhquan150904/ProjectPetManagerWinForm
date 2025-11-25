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
        private Button btnFind;

        //private DataGridViewTextBoxColumn colCus_Id;
        //private DataGridViewTextBoxColumn colCus_Name;
        //private DataGridViewTextBoxColumn colAddress;
        //private DataGridViewTextBoxColumn colPhoneNumber;
        //private DataGridViewTextBoxColumn colEmail;

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
            txtId = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtSearch = new TextBox();
            btnShowAll = new Button();
            btnTransHis = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.ColumnHeadersHeight = 29;
            dgvCustomers.Location = new Point(12, 12);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(678, 471);
            dgvCustomers.TabIndex = 0;
            dgvCustomers.CellClick += dgvCustomers_CellClick;
            // 
            // txtId
            // 
            txtId.Location = new Point(967, 172);
            txtId.Name = "txtId";
            txtId.Size = new Size(200, 23);
            txtId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(967, 201);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(967, 230);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 23);
            txtAddress.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(967, 259);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(200, 23);
            txtPhoneNumber.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(967, 288);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1267, 172);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 30);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1267, 208);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 30);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1267, 244);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 30);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(1198, 26);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(90, 30);
            btnFind.TabIndex = 9;
            btnFind.Text = "Find";
            btnFind.Click += btnFind_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(837, 172);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 10;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(837, 204);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 11;
            label2.Text = "Customer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(837, 233);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 12;
            label3.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(837, 262);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 13;
            label4.Text = "PhoneNumber:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(837, 288);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 14;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(696, 29);
            label6.Name = "label6";
            label6.Size = new Size(264, 15);
            label6.TabIndex = 15;
            label6.Text = "Thông tin khách hàng (ID,Name,PhoneNumber):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(995, 132);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 16;
            label7.Text = "Thêm/Sửa/Xóa";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(967, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 23);
            txtSearch.TabIndex = 17;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(1294, 26);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(90, 30);
            btnShowAll.TabIndex = 18;
            btnShowAll.Text = "Show All";
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnTransHis
            // 
            btnTransHis.Location = new Point(1198, 62);
            btnTransHis.Name = "btnTransHis";
            btnTransHis.Size = new Size(186, 30);
            btnTransHis.TabIndex = 19;
            btnTransHis.Text = "Transaction history";
            btnTransHis.Click += btnTransHis_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1267, 283);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 30);
            btnRefresh.TabIndex = 20;
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ThongTinKhachHang
            // 
            ClientSize = new Size(1420, 511);
            Controls.Add(btnRefresh);
            Controls.Add(btnTransHis);
            Controls.Add(btnShowAll);
            Controls.Add(txtSearch);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCustomers);
            Controls.Add(txtId);
            Controls.Add(txtName);
            Controls.Add(txtAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnFind);
            Name = "ThongTinKhachHang";
            Text = "Thông Tin Khách Hàng";
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtSearch;
        private Button btnShowAll;
        private Button btnTransHis;
        private Button btnRefresh;
    }
}