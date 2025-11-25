namespace PetManagerWinForm.NghiepVu.QLHoaDon
{
    partial class QuanLyHoaDon
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
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Cus_ID = new DataGridViewTextBoxColumn();
            Product_Service_Name = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            Time_to_create = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtTotalPrice = new TextBox();
            txtTimeToCreated = new TextBox();
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
            txtCusID = new TextBox();
            txtProductServiceName = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnDetail = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Cus_ID, Product_Service_Name, Quantity, Price, TotalPrice, Time_to_create });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(929, 551);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // Cus_ID
            // 
            Cus_ID.HeaderText = "Cus_ID";
            Cus_ID.MinimumWidth = 6;
            Cus_ID.Name = "Cus_ID";
            Cus_ID.Width = 125;
            // 
            // Product_Service_Name
            // 
            Product_Service_Name.HeaderText = "Product/Service Name";
            Product_Service_Name.MinimumWidth = 6;
            Product_Service_Name.Name = "Product_Service_Name";
            Product_Service_Name.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "TotalPrice";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Width = 125;
            // 
            // Time_to_create
            // 
            Time_to_create.HeaderText = "Time to Create";
            Time_to_create.MinimumWidth = 6;
            Time_to_create.Name = "Time_to_create";
            Time_to_create.Width = 125;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1085, 358);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 76;
            label6.Text = "Total Price:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1064, 398);
            label9.Name = "label9";
            label9.Size = new Size(108, 20);
            label9.TabIndex = 74;
            label9.Text = "Time to create:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1122, 318);
            label11.Name = "label11";
            label11.Size = new Size(44, 20);
            label11.TabIndex = 73;
            label11.Text = "Price:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1098, 278);
            label12.Name = "label12";
            label12.Size = new Size(68, 20);
            label12.TabIndex = 72;
            label12.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(1178, 275);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(200, 27);
            txtQuantity.TabIndex = 67;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(1178, 315);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 27);
            txtPrice.TabIndex = 68;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(1178, 355);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(200, 27);
            txtTotalPrice.TabIndex = 69;
            // 
            // txtTimeToCreated
            // 
            txtTimeToCreated.Location = new Point(1178, 395);
            txtTimeToCreated.Name = "txtTimeToCreated";
            txtTimeToCreated.Size = new Size(200, 27);
            txtTimeToCreated.TabIndex = 70;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1114, 234);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 66;
            label5.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1112, 194);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 65;
            label4.Text = "Cus ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1139, 154);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 64;
            label3.Text = "ID:";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1178, 494);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 30);
            btnRefresh.TabIndex = 63;
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1002, 121);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 62;
            label2.Text = "Form để thêm/sửa/xóa:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1099, 37);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 61;
            label1.Text = "Tìm kiếm:";
            // 
            // btn_ShowAll
            // 
            btn_ShowAll.Location = new Point(1288, 67);
            btn_ShowAll.Name = "btn_ShowAll";
            btn_ShowAll.Size = new Size(90, 30);
            btn_ShowAll.TabIndex = 60;
            btn_ShowAll.Text = "ShowAll";
            btn_ShowAll.Click += btn_ShowAll_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1184, 67);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 30);
            btnSearch.TabIndex = 59;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1178, 34);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 27);
            txtSearch.TabIndex = 58;
            // 
            // txtId
            // 
            txtId.Location = new Point(1178, 151);
            txtId.Name = "txtId";
            txtId.Size = new Size(200, 27);
            txtId.TabIndex = 52;
            // 
            // txtCusID
            // 
            txtCusID.Location = new Point(1178, 191);
            txtCusID.Name = "txtCusID";
            txtCusID.Size = new Size(200, 27);
            txtCusID.TabIndex = 53;
            // 
            // txtProductServiceName
            // 
            txtProductServiceName.Location = new Point(1178, 231);
            txtProductServiceName.Name = "txtProductServiceName";
            txtProductServiceName.Size = new Size(200, 27);
            txtProductServiceName.TabIndex = 54;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1178, 446);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 30);
            btnAdd.TabIndex = 55;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1288, 446);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 30);
            btnUpdate.TabIndex = 56;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1288, 494);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 30);
            btnDelete.TabIndex = 57;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(1178, 548);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(200, 30);
            btnDetail.TabIndex = 77;
            btnDetail.Text = "Detail";
            btnDetail.Click += btnDetail_Click;
            // 
            // QuanLyHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 612);
            Controls.Add(btnDetail);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtTotalPrice);
            Controls.Add(txtTimeToCreated);
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
            Controls.Add(txtCusID);
            Controls.Add(txtProductServiceName);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Name = "QuanLyHoaDon";
            Text = "QLHoaDon";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Cus_ID;
        private DataGridViewTextBoxColumn Product_Service_Name;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewTextBoxColumn Time_to_create;
        private Label label6;
        private Label label9;
        private Label label11;
        private Label label12;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtTotalPrice;
        private TextBox txtTimeToCreated;
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
        private TextBox txtCusID;
        private TextBox txtProductServiceName;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnDetail;
    }
}