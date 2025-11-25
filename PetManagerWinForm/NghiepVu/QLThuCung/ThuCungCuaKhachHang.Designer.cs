namespace PetManagerWinForm.NghiepVu.QLThuCung
{
    partial class ThuCungCuaKhachHang
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
            dataGridView1 = new DataGridView();
            ID_Pet = new DataGridViewTextBoxColumn();
            Pet_Name = new DataGridViewTextBoxColumn();
            Pet_Type = new DataGridViewTextBoxColumn();
            Cus_ID = new DataGridViewTextBoxColumn();
            Cus_Name = new DataGridViewTextBoxColumn();
            Cus_Email = new DataGridViewTextBoxColumn();
            Cus_Phone = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnRefresh = new Button();
            label2 = new Label();
            label1 = new Label();
            btn_ShowAll = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            txtId = new TextBox();
            txtPetName = new TextBox();
            txtPetType = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSold = new Button();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtCusID = new TextBox();
            txtCus_Name = new TextBox();
            txtCusEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtTime = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID_Pet, Pet_Name, Pet_Type, Cus_ID, Cus_Name, Cus_Email, Cus_Phone, Time });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1053, 288);
            dataGridView1.TabIndex = 0;
            // 
            // ID_Pet
            // 
            ID_Pet.DataPropertyName = "Pet_Id";
            ID_Pet.HeaderText = "ID Pet";
            ID_Pet.MinimumWidth = 6;
            ID_Pet.Name = "ID_Pet";
            ID_Pet.Width = 125;
            // 
            // Pet_Name
            // 
            Pet_Name.DataPropertyName = "Pet_Name";
            Pet_Name.HeaderText = "Pet Name";
            Pet_Name.MinimumWidth = 6;
            Pet_Name.Name = "Pet_Name";
            Pet_Name.Width = 125;
            // 
            // Pet_Type
            // 
            Pet_Type.DataPropertyName = "Pet_Type";
            Pet_Type.HeaderText = "Pet Type";
            Pet_Type.MinimumWidth = 6;
            Pet_Type.Name = "Pet_Type";
            Pet_Type.Width = 125;
            // 
            // Cus_ID
            // 
            Cus_ID.DataPropertyName = "Cus_Id";
            Cus_ID.HeaderText = "Customer ID";
            Cus_ID.MinimumWidth = 6;
            Cus_ID.Name = "Cus_ID";
            Cus_ID.Width = 125;
            // 
            // Cus_Name
            // 
            Cus_Name.DataPropertyName = "Cus_Name";
            Cus_Name.HeaderText = "Customer Name";
            Cus_Name.MinimumWidth = 6;
            Cus_Name.Name = "Cus_Name";
            Cus_Name.Width = 125;
            // 
            // Cus_Email
            // 
            Cus_Email.DataPropertyName = "Cus_Email";
            Cus_Email.HeaderText = "Customer Email";
            Cus_Email.MinimumWidth = 6;
            Cus_Email.Name = "Cus_Email";
            Cus_Email.Width = 125;
            // 
            // Cus_Phone
            // 
            Cus_Phone.DataPropertyName = "Cus_Phone";
            Cus_Phone.HeaderText = "Customer Phone Number";
            Cus_Phone.MinimumWidth = 6;
            Cus_Phone.Name = "Cus_Phone";
            Cus_Phone.Width = 125;
            // 
            // Time
            // 
            Time.DataPropertyName = "Time";
            Time.HeaderText = "Time";
            Time.MinimumWidth = 6;
            Time.Name = "Time";
            Time.Width = 125;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(197, 452);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 38;
            label5.Text = "Pet Type:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(194, 412);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 37;
            label4.Text = "Pet Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 372);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 36;
            label3.Text = "Pet ID:";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(843, 367);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 30);
            btnRefresh.TabIndex = 35;
            btnRefresh.Text = "Refresh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 369);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 34;
            label2.Text = "Form để thêm/sửa/xóa:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 309);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 33;
            label1.Text = "Tìm kiếm:";
            // 
            // btn_ShowAll
            // 
            btn_ShowAll.Location = new Point(589, 306);
            btn_ShowAll.Name = "btn_ShowAll";
            btn_ShowAll.Size = new Size(90, 30);
            btn_ShowAll.TabIndex = 32;
            btn_ShowAll.Text = "ShowAll";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(479, 306);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 30);
            btnSearch.TabIndex = 31;
            btnSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(276, 306);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 27);
            txtSearch.TabIndex = 30;
            // 
            // txtId
            // 
            txtId.Location = new Point(276, 369);
            txtId.Name = "txtId";
            txtId.Size = new Size(200, 27);
            txtId.TabIndex = 21;
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(276, 409);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(200, 27);
            txtPetName.TabIndex = 22;
            // 
            // txtPetType
            // 
            txtPetType.Location = new Point(276, 449);
            txtPetType.Name = "txtPetType";
            txtPetType.Size = new Size(200, 27);
            txtPetType.TabIndex = 23;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(843, 487);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 30);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Add";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(953, 487);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 30);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(843, 527);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 30);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            // 
            // btnSold
            // 
            btnSold.Location = new Point(953, 527);
            btnSold.Name = "btnSold";
            btnSold.Size = new Size(90, 30);
            btnSold.TabIndex = 29;
            btnSold.Text = "Sold";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(555, 532);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 50;
            label8.Text = "Time:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(504, 492);
            label9.Name = "label9";
            label9.Size = new Size(108, 20);
            label9.TabIndex = 49;
            label9.Text = "Phone Number";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(493, 412);
            label11.Name = "label11";
            label11.Size = new Size(119, 20);
            label11.TabIndex = 47;
            label11.Text = "Customer Name:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(518, 372);
            label12.Name = "label12";
            label12.Size = new Size(94, 20);
            label12.TabIndex = 46;
            label12.Text = "Customer ID:";
            // 
            // txtCusID
            // 
            txtCusID.Location = new Point(618, 369);
            txtCusID.Name = "txtCusID";
            txtCusID.Size = new Size(200, 27);
            txtCusID.TabIndex = 41;
            // 
            // txtCus_Name
            // 
            txtCus_Name.Location = new Point(618, 409);
            txtCus_Name.Name = "txtCus_Name";
            txtCus_Name.Size = new Size(200, 27);
            txtCus_Name.TabIndex = 42;
            // 
            // txtCusEmail
            // 
            txtCusEmail.Location = new Point(618, 449);
            txtCusEmail.Name = "txtCusEmail";
            txtCusEmail.Size = new Size(200, 27);
            txtCusEmail.TabIndex = 43;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(618, 489);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(200, 27);
            txtPhoneNumber.TabIndex = 44;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(618, 529);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(200, 27);
            txtTime.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(493, 449);
            label6.Name = "label6";
            label6.Size = new Size(116, 20);
            label6.TabIndex = 51;
            label6.Text = "Customer Email:";
            // 
            // ThuCungCuaKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 586);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(txtCusID);
            Controls.Add(txtCus_Name);
            Controls.Add(txtCusEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtTime);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnRefresh);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_ShowAll);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(txtId);
            Controls.Add(txtPetName);
            Controls.Add(txtPetType);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Name = "ThuCungCuaKhachHang";
            Text = "ThuCungCuaKhachHang";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnRefresh;
        private Label label2;
        private Label label1;
        private Button btn_ShowAll;
        private Button btnSearch;
        private TextBox txtSearch;
        private TextBox txtId;
        private TextBox txtPetName;
        private TextBox txtPetType;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSold;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label12;
        private TextBox txtCusID;
        private TextBox txtCus_Name;
        private TextBox txtCusEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtTime;
        private DataGridViewTextBoxColumn ID_Pet;
        private DataGridViewTextBoxColumn Pet_Name;
        private DataGridViewTextBoxColumn Pet_Type;
        private DataGridViewTextBoxColumn Cus_ID;
        private DataGridViewTextBoxColumn Cus_Name;
        private DataGridViewTextBoxColumn Cus_Email;
        private DataGridViewTextBoxColumn Cus_Phone;
        private DataGridViewTextBoxColumn Time;
        private Label label6;
    }
}