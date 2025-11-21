namespace PetManagerWinForm.NghiepVu.QLSanPham
{
    partial class QuanLySanPham
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
            dvgProduct = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            product_Name = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Country = new DataGridViewTextBoxColumn();
            Condition = new DataGridViewTextBoxColumn();
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
            txtId = new TextBox();
            txtName = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label8 = new Label();
            txtCondition = new TextBox();
            txtCountry = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dvgProduct).BeginInit();
            SuspendLayout();
            // 
            // dvgProduct
            // 
            dvgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProduct.Columns.AddRange(new DataGridViewColumn[] { ID, product_Name, Quantity, Price, Country, Condition });
            dvgProduct.Location = new Point(12, 12);
            dvgProduct.Name = "dvgProduct";
            dvgProduct.RowHeadersWidth = 51;
            dvgProduct.Size = new Size(801, 389);
            dvgProduct.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // product_Name
            // 
            product_Name.HeaderText = "Product Name";
            product_Name.MinimumWidth = 6;
            product_Name.Name = "product_Name";
            product_Name.Width = 125;
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
            // Country
            // 
            Country.HeaderText = "Country";
            Country.MinimumWidth = 6;
            Country.Name = "Country";
            Country.Width = 125;
            // 
            // Condition
            // 
            Condition.HeaderText = "Condition";
            Condition.MinimumWidth = 6;
            Condition.Name = "Condition";
            Condition.Width = 125;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(876, 293);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 40;
            label7.Text = "Country:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(895, 253);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 39;
            label6.Text = "Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(884, 213);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 38;
            label5.Text = "Quantity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(845, 173);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 37;
            label4.Text = "Product Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(895, 133);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 36;
            label3.Text = "ID:";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1289, 331);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 30);
            btnRefresh.TabIndex = 35;
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(819, 107);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 34;
            label2.Text = "Form để thêm/sửa/xóa:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(819, 36);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 33;
            label1.Text = "Tìm kiếm";
            // 
            // btn_ShowAll
            // 
            btn_ShowAll.Location = new Point(1271, 31);
            btn_ShowAll.Name = "btn_ShowAll";
            btn_ShowAll.Size = new Size(90, 30);
            btn_ShowAll.TabIndex = 32;
            btn_ShowAll.Text = "ShowAll";
            btn_ShowAll.Click += btn_ShowAll_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1161, 31);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 30);
            btnSearch.TabIndex = 31;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(908, 31);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 27);
            txtSearch.TabIndex = 30;
            // 
            // txtId
            // 
            txtId.Location = new Point(958, 130);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(200, 27);
            txtId.TabIndex = 21;
            // 
            // txtName
            // 
            txtName.Location = new Point(958, 170);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 22;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(958, 210);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(200, 27);
            txtQuantity.TabIndex = 23;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(958, 250);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 27);
            txtPrice.TabIndex = 24;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1179, 293);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 30);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1289, 293);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 30);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1179, 333);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 30);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(876, 336);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 42;
            label8.Text = "Condition:";
            // 
            // txtCondition
            // 
            txtCondition.Location = new Point(958, 333);
            txtCondition.Name = "txtCondition";
            txtCondition.Size = new Size(200, 27);
            txtCondition.TabIndex = 41;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(958, 293);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(200, 27);
            txtCountry.TabIndex = 43;
            // 
            // QuanLySanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 456);
            Controls.Add(txtCountry);
            Controls.Add(label8);
            Controls.Add(txtCondition);
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
            Controls.Add(txtId);
            Controls.Add(txtName);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dvgProduct);
            Name = "QuanLySanPham";
            Text = "QuanLySanPham";
            ((System.ComponentModel.ISupportInitialize)dvgProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgProduct;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn product_Name;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
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
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridViewTextBoxColumn Country;
        private DataGridViewTextBoxColumn Condition;
        private Label label8;
        private TextBox txtCondition;
        private TextBox txtCountry;
    }
}