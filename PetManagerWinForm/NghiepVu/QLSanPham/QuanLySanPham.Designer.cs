namespace PetManagerWinForm.NghiepVu.QLSanPham
{
    partial class QuanLySanPham
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelLeft;
        private Panel panelRight;

        private DataGridView dgvProduct;

        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtCountry;
        private TextBox txtCondition;
        private TextBox txtSearch;

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnSearch;
        private Button btn_ShowAll;

        private Label lblSearch;
        private Label lblTitle;
        private Label lblId;
        private Label lblName;
        private Label lblQuantity;
        private Label lblPrice;
        private Label lblCountry;
        private Label lblCondition;

        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colCountry;
        private DataGridViewTextBoxColumn colCondition;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();

            // Khởi tạo các biến
            panelLeft = new Panel();
            dgvProduct = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colCountry = new DataGridViewTextBoxColumn();
            colCondition = new DataGridViewTextBoxColumn();
            panelRight = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btn_ShowAll = new Button();
            lblTitle = new Label();
            lblId = new Label();
            txtId = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblCountry = new Label();
            txtCountry = new TextBox();
            lblCondition = new Label();
            txtCondition = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();

            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            panelRight.SuspendLayout();
            SuspendLayout();

            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.White;
            panelLeft.Controls.Add(dgvProduct);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(10);
            panelLeft.Size = new Size(650, 600); // Tăng chiều cao để khớp form
            panelLeft.TabIndex = 1;

            // 
            // dgvProduct (Giữ nguyên cấu hình của bạn)
            // 
            dgvProduct.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 240, 240);
            dgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(220, 100, 100);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProduct.ColumnHeadersHeight = 40;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colQuantity, colPrice, colCountry, colCondition });
            dgvProduct.Dock = DockStyle.Fill;
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.GridColor = Color.FromArgb(255, 230, 230);
            dgvProduct.Location = new Point(10, 10);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.RowHeadersVisible = false;
            dgvProduct.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgvProduct.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvProduct.RowTemplate.Height = 35;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.Size = new Size(630, 580);
            dgvProduct.TabIndex = 0;
            dgvProduct.CellClick += dataGridView1_CellClick;

            // Cấu hình các cột (Giữ nguyên)
            colId.HeaderText = "ID"; colId.Width = 60; colId.Name = "colId"; colId.ReadOnly = true;
            colName.HeaderText = "Tên SP"; colName.Width = 150; colName.Name = "colName"; colName.ReadOnly = true;
            colQuantity.HeaderText = "Số lượng"; colQuantity.Width = 100; colQuantity.Name = "colQuantity"; colQuantity.ReadOnly = true;
            colPrice.HeaderText = "Giá"; colPrice.Width = 100; colPrice.Name = "colPrice"; colPrice.ReadOnly = true;
            colCountry.HeaderText = "Xuất xứ"; colCountry.Width = 100; colCountry.Name = "colCountry"; colCountry.ReadOnly = true;
            colCondition.HeaderText = "Tình trạng"; colCondition.Width = 100; colCondition.Name = "colCondition"; colCondition.ReadOnly = true;

            // 
            // panelRight
            // 
            panelRight.BackColor = Color.FromArgb(255, 230, 230);
            panelRight.Controls.Add(lblSearch);
            panelRight.Controls.Add(txtSearch);
            panelRight.Controls.Add(btnSearch);
            panelRight.Controls.Add(btn_ShowAll);
            panelRight.Controls.Add(lblTitle);

            // Add Input controls
            panelRight.Controls.Add(lblId); panelRight.Controls.Add(txtId);
            panelRight.Controls.Add(lblName); panelRight.Controls.Add(txtName);
            panelRight.Controls.Add(lblQuantity); panelRight.Controls.Add(txtQuantity);
            panelRight.Controls.Add(lblPrice); panelRight.Controls.Add(txtPrice);
            panelRight.Controls.Add(lblCountry); panelRight.Controls.Add(txtCountry);
            panelRight.Controls.Add(lblCondition); panelRight.Controls.Add(txtCondition);

            // Add Buttons
            panelRight.Controls.Add(btnAdd);
            panelRight.Controls.Add(btnUpdate);
            panelRight.Controls.Add(btnDelete);
            panelRight.Controls.Add(btnRefresh);

            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(650, 0);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(30);
            panelRight.Size = new Size(450, 600); // Kích thước ảo để design
            panelRight.TabIndex = 0;

            // --- PHẦN TÌM KIẾM ---
            // lblSearch
            lblSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSearch.Location = new Point(30, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(200, 25);
            lblSearch.Text = "Tìm kiếm sản phẩm:";

            // txtSearch
            txtSearch.Location = new Point(30, 50);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 27);

            // btnSearch
            btnSearch.Location = new Point(290, 48);
            btnSearch.Size = new Size(80, 30);
            btnSearch.Text = "Tìm";
            btnSearch.Click += btnSearch_Click;

            // btn_ShowAll
            btn_ShowAll.Location = new Point(380, 48);
            btn_ShowAll.Size = new Size(80, 30);
            btn_ShowAll.Text = "Tất cả";
            btn_ShowAll.Click += btn_ShowAll_Click;

            // --- TITLE ---
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Maroon;
            lblTitle.Location = new Point(30, 100);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 30);
            lblTitle.Text = "Thông tin chi tiết";

            // --- CÁC Ô NHẬP LIỆU (Sắp xếp dọc xuống dưới) ---
            int labelX = 30;
            int txtX = 140;
            int startY = 150;
            int stepY = 40;

            // ID
            lblId.Text = "Mã SP:"; lblId.Location = new Point(labelX, startY); lblId.AutoSize = true;
            txtId.Location = new Point(txtX, startY - 3); txtId.Size = new Size(250, 27); txtId.ReadOnly = true; // Thường ID không cho sửa

            // Name
            lblName.Text = "Tên SP:"; lblName.Location = new Point(labelX, startY + stepY); lblName.AutoSize = true;
            txtName.Location = new Point(txtX, startY + stepY - 3); txtName.Size = new Size(250, 27);

            // Quantity
            lblQuantity.Text = "Số lượng:"; lblQuantity.Location = new Point(labelX, startY + stepY * 2); lblQuantity.AutoSize = true;
            txtQuantity.Location = new Point(txtX, startY + stepY * 2 - 3); txtQuantity.Size = new Size(250, 27);

            // Price
            lblPrice.Text = "Đơn giá:"; lblPrice.Location = new Point(labelX, startY + stepY * 3); lblPrice.AutoSize = true;
            txtPrice.Location = new Point(txtX, startY + stepY * 3 - 3); txtPrice.Size = new Size(250, 27);

            // Country
            lblCountry.Text = "Xuất xứ:"; lblCountry.Location = new Point(labelX, startY + stepY * 4); lblCountry.AutoSize = true;
            txtCountry.Location = new Point(txtX, startY + stepY * 4 - 3); txtCountry.Size = new Size(250, 27);

            // Condition
            lblCondition.Text = "Tình trạng:"; lblCondition.Location = new Point(labelX, startY + stepY * 5); lblCondition.AutoSize = true;
            txtCondition.Location = new Point(txtX, startY + stepY * 5 - 3); txtCondition.Size = new Size(250, 27);

            // --- CÁC NÚT CHỨC NĂNG (Xếp ngang bên dưới) ---
            int btnY = 420;

            // btnAdd
            btnAdd.Text = "Thêm";
            btnAdd.Location = new Point(30, btnY);
            btnAdd.Size = new Size(90, 40);
            btnAdd.BackColor = Color.White;
            btnAdd.Click += btnAdd_Click;

            // btnUpdate
            btnUpdate.Text = "Sửa";
            btnUpdate.Location = new Point(130, btnY);
            btnUpdate.Size = new Size(90, 40);
            btnUpdate.BackColor = Color.White;
            btnUpdate.Click += btnUpdate_Click;

            // btnDelete
            btnDelete.Text = "Xóa";
            btnDelete.Location = new Point(230, btnY);
            btnDelete.Size = new Size(90, 40);
            btnDelete.BackColor = Color.White;
            btnDelete.Click += btnDelete_Click;

            // btnRefresh
            btnRefresh.Text = "Làm mới";
            btnRefresh.Location = new Point(330, btnY);
            btnRefresh.Size = new Size(90, 40);
            btnRefresh.BackColor = Color.White;
            btnRefresh.Click += btnRefresh_Click;

            // 
            // QuanLySanPham
            // 
            // Tăng kích thước Form để chứa đủ PanelLeft (650) + PanelRight (~450)
            ClientSize = new Size(1150, 600);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Name = "QuanLySanPham";
            Text = "Quản lý sản phẩm";
            StartPosition = FormStartPosition.CenterScreen; // Mở form ở giữa màn hình
            WindowState = FormWindowState.Normal; // Để Normal để thấy đúng kích thước đã set

            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);
        }

        // Helpers ---------------------------------------------
        private void AddLabel(Label lbl, string text, int x, int y)
        {
            lbl.Text = text;
            lbl.Font = new Font("Segoe UI", 11F);
            lbl.Location = new Point(x, y);
        }

        private void AddTextBox(TextBox txt, int x, int y)
        {
            txt.Location = new Point(x, y);
            txt.Size = new Size(260, 27);
        }

        private void StyleButton(Button btn, int x, int y, string? text = null)
        {
            if (text != null) btn.Text = text;

            btn.BackColor = Color.FromArgb(255, 210, 210);
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn.ForeColor = Color.DimGray;
            btn.Location = new Point(x, y);
            btn.Size = new Size(130, 40);
        }
    }
}
