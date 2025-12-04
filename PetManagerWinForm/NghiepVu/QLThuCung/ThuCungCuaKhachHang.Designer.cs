// DESIGNER REWORKED FOR FORM QLThuCungDichVu
// Style giống ThuCungDaBan: Panel trái màu trắng, phải màu hồng nhạt,
// DataGridView header đỏ, search bar, title bold.

using System.Windows.Forms;
using System.Drawing;

namespace PetManagerWinForm.NghiepVu.QLThuCung
{
    partial class QLThuCungDichVu
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelLeft;
        private Panel panelRight;

        private DataGridView dgvCustomerPets;

        private Label lblTitle;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;

        private Label labelPetId;
        private TextBox txtPetId;

        private Label labelPetName;
        private TextBox txtPetName;

        private Label labelPetAge;
        private TextBox txtPetAge;

        private Label labelService;
        private ComboBox cmbService;

        private Button btnDoneService;

        // DataGridView Columns
        private DataGridViewTextBoxColumn colCPS_Id;
        private DataGridViewTextBoxColumn colPetId;
        private DataGridViewTextBoxColumn colPetName;
        private DataGridViewTextBoxColumn colPetAge;
        private DataGridViewTextBoxColumn colServiceName;
        private DataGridViewTextBoxColumn colStartDate;
        private DataGridViewTextBoxColumn colStatus;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            // Column styles
            DataGridViewCellStyle dgvHeader = new DataGridViewCellStyle();
            dgvHeader.BackColor = Color.FromArgb(220, 100, 100);
            dgvHeader.ForeColor = Color.White;
            dgvHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dgvHeader.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DataGridViewCellStyle dgvAlt = new DataGridViewCellStyle();
            dgvAlt.BackColor = Color.FromArgb(255, 240, 240);

            DataGridViewCellStyle dgvRow = new DataGridViewCellStyle();
            dgvRow.Font = new Font("Segoe UI", 10F);
            dgvRow.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dgvRow.SelectionForeColor = Color.Black;

            // === Main Panels ===
            panelLeft = new Panel()
            {
                Dock = DockStyle.Left,
                Width = 750,
                BackColor = Color.White,
                Padding = new Padding(10)
            };

            panelRight = new Panel()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(255, 230, 230),
                Padding = new Padding(30)
            };

            // === DataGridView ===
            dgvCustomerPets = new DataGridView()
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.White,
                AlternatingRowsDefaultCellStyle = dgvAlt,
                ColumnHeadersDefaultCellStyle = dgvHeader,
                ColumnHeadersHeight = 40,
                EnableHeadersVisualStyles = false,
                ReadOnly = true,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                RowTemplate = { Height = 35 },
                AutoGenerateColumns = false
            };

            // Declare Columns
            colCPS_Id = new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "CPS_Id", Width = 80 };
            colPetId = new DataGridViewTextBoxColumn { HeaderText = "Pet ID", DataPropertyName = "Pet_Id", Width = 90 };
            colPetName = new DataGridViewTextBoxColumn { HeaderText = "Tên Thú Cưng", DataPropertyName = "Pet_Name", Width = 150 };
            colPetAge = new DataGridViewTextBoxColumn { HeaderText = "Tuổi", DataPropertyName = "Pet_Age", Width = 80 };
            colServiceName = new DataGridViewTextBoxColumn { HeaderText = "Dịch Vụ", DataPropertyName = "ServiceName", Width = 150 };
            colStartDate = new DataGridViewTextBoxColumn { HeaderText = "Ngày Bắt Đầu", DataPropertyName = "StartDate", Width = 130 };
            colStatus = new DataGridViewTextBoxColumn { HeaderText = "Trạng Thái", DataPropertyName = "Status", Width = 120 };

            dgvCustomerPets.Columns.AddRange(
                colCPS_Id, colPetId, colPetName, colPetAge,
                colServiceName, colStartDate, colStatus
            );

            panelLeft.Controls.Add(dgvCustomerPets);

            // === Right Panel Controls ===

            lblTitle = new Label()
            {
                Text = "Quản Lý Thú Cưng Đang Sử Dụng Dịch Vụ",
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                AutoSize = true,
                Top = 10,
                Left = 10
            };

            // Search
            lblSearch = new Label()
            {
                Text = "Tìm kiếm:",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                AutoSize = true,
                Top = 70,
                Left = 10
            };

            txtSearch = new TextBox()
            {
                Top = 105,
                Left = 10,
                Width = 260
            };

            btnSearch = new Button()
            {
                Text = "Tìm",
                Top = 100,
                Left = 280,
                Width = 110,
                Height = 40,
                BackColor = Color.FromArgb(255, 210, 210),
                FlatStyle = FlatStyle.Flat
            };
            btnSearch.FlatAppearance.BorderSize = 0;

            btnRefresh = new Button()
            {
                Text = "Làm mới",
                Top = 100,
                Left = 400,
                Width = 110,
                Height = 40,
                BackColor = Color.FromArgb(255, 210, 210),
                FlatStyle = FlatStyle.Flat
            };
            btnRefresh.FlatAppearance.BorderSize = 0;

            // Pet Info Inputs
            labelPetId = new Label() { Text = "ID Thú Cưng:", Top = 180, Left = 10, AutoSize = true };
            txtPetId = new TextBox() { Top = 205, Left = 10, Width = 240, ReadOnly = true };

            labelPetName = new Label() { Text = "Tên Thú Cưng:", Top = 255, Left = 10, AutoSize = true };
            txtPetName = new TextBox() { Top = 280, Left = 10, Width = 240, ReadOnly = true };

            labelPetAge = new Label() { Text = "Tuổi:", Top = 330, Left = 10, AutoSize = true };
            txtPetAge = new TextBox() { Top = 355, Left = 10, Width = 240, ReadOnly = true };

            labelService = new Label() { Text = "Dịch Vụ:", Top = 405, Left = 10, AutoSize = true };
            cmbService = new ComboBox() { Top = 430, Left = 10, Width = 240 };

            btnDoneService = new Button()
            {
                Text = "Xong Dịch Vụ",
                Top = 490,
                Left = 10,
                Width = 200,
                Height = 45,
                BackColor = Color.FromArgb(255, 210, 210),
                FlatStyle = FlatStyle.Flat
            };
            btnDoneService.FlatAppearance.BorderSize = 0;

            // Add controls to Right Panel
            panelRight.Controls.Add(lblTitle);
            panelRight.Controls.Add(lblSearch);
            panelRight.Controls.Add(txtSearch);
            panelRight.Controls.Add(btnSearch);
            panelRight.Controls.Add(btnRefresh);

            panelRight.Controls.Add(labelPetId);
            panelRight.Controls.Add(txtPetId);
            panelRight.Controls.Add(labelPetName);
            panelRight.Controls.Add(txtPetName);
            panelRight.Controls.Add(labelPetAge);
            panelRight.Controls.Add(txtPetAge);
            panelRight.Controls.Add(labelService);
            panelRight.Controls.Add(cmbService);
            panelRight.Controls.Add(btnDoneService);

            // === Form ===
            this.Text = "Quản Lý Thú Cưng - Dịch Vụ";
            this.ClientSize = new Size(1400, 900);
            this.Controls.Add(panelRight);
            this.Controls.Add(panelLeft);

            // Events
            this.Load += QLThuCungDichVu_Load;
            dgvCustomerPets.CellClick += dgvCustomerPets_CellClick;
            btnDoneService.Click += btnDoneService_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnSearch.Click += btnSearch_Click;
        }
    }
}
