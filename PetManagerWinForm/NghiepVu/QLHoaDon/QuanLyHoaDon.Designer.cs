using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel; // Dùng IContainer

namespace PetManagerWinForm.NghiepVu.QLHoaDon
{
    partial class QuanLyHoaDon
    {
        private IContainer components = null;

        // Khai báo Panels
        private Panel panelLeft;
        private Panel panelRight;

        // Khai báo Controls 
        private DataGridView dgvInvoice;
        private DataGridViewTextBoxColumn colInvoiceId;
        private DataGridViewTextBoxColumn colCusId;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colCreatedAt;

        private Label label1, label2, label3, label4, label5;
        private TextBox txtSearch, txtInvoiceId, txtCusId, txtTotal, txtCreatedAt;
        private Button btnSearch, btnShowAll, btnRefresh, btnDetail;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // Thiết lập màu sắc và kiểu dáng (Đồng nhất với ThuCungDaBan)
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

            components = new Container();

            // === Main Panels ===
            panelLeft = new Panel()
            {
                Dock = DockStyle.Left,
                Width = 600, // Tối ưu chiều rộng để giảm khoảng trắng thừa
                BackColor = Color.White,
                Padding = new Padding(10)
            };

            panelRight = new Panel()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(255, 230, 230), // Hồng nhạt
                Padding = new Padding(30)
            };

            // ===================== DataGridView ============================
            dgvInvoice = new DataGridView()
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
            dgvInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoice.CellClick += dgvInvoice_CellClick;

            // ===================== Columns (Sửa lỗi Name) ============================
            colInvoiceId = new DataGridViewTextBoxColumn
            {
                Name = "colInvoiceId", // Cần thiết để truy cập trong CellClick
                HeaderText = "ID Hóa Đơn",
                DataPropertyName = "InvoiceId",
                Width = 100
            };
            colCusId = new DataGridViewTextBoxColumn
            {
                Name = "colCusId", // Cần thiết để truy cập trong CellClick
                HeaderText = "ID KH",
                DataPropertyName = "Cus_Id",
                Width = 120
            };
            colTotal = new DataGridViewTextBoxColumn
            {
                Name = "colTotal", // Cần thiết để truy cập trong CellClick
                HeaderText = "Tổng Tiền",
                DataPropertyName = "Total",
                MinimumWidth = 150,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill // Tự động co giãn
            };
            colCreatedAt = new DataGridViewTextBoxColumn
            {
                Name = "colCreatedAt", // Cần thiết để truy cập trong CellClick
                HeaderText = "Ngày Tạo",
                DataPropertyName = "CreatedAt",
                Width = 150
            };

            // Thêm cột vào DataGridView
            dgvInvoice.Columns.AddRange(new DataGridViewColumn[]
            {
                colInvoiceId, colCusId, colTotal, colCreatedAt
            });

            panelLeft.Controls.Add(dgvInvoice);


            // ===================== Right Panel Controls ============================
            int x_label = 10;
            int x_input = 150;
            int y_start = 20;
            int y_step = 40;

            // Search controls
            label1 = new Label() { Text = "Tìm kiếm:", AutoSize = true, Font = new Font("Segoe UI", 11F, FontStyle.Bold), Top = y_start, Left = x_label };
            txtSearch = new TextBox() { Top = y_start + 25, Left = x_label, Width = 230 };

            btnSearch = new Button() { Text = "Search", Top = y_start + 20, Left = 270, Width = 100, Height = 30 };
            btnSearch.BackColor = Color.FromArgb(255, 210, 210);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.Click += btnSearch_Click; // Kích hoạt sự kiện

            btnShowAll = new Button() { Text = "Tất cả", Top = y_start + 20, Left = 380, Width = 100, Height = 30 };
            btnShowAll.BackColor = Color.FromArgb(255, 210, 210);
            btnShowAll.FlatStyle = FlatStyle.Flat;
            btnShowAll.FlatAppearance.BorderSize = 0;
            btnShowAll.Click += btnShowAll_Click;

            // Detail fields (Đặt label và input/readonly box)
            label2 = new Label() { Text = "Invoice ID:", AutoSize = true, Top = y_start + 100, Left = x_label };
            txtInvoiceId = new TextBox() { Top = y_start + 100, Left = x_input, Width = 150, ReadOnly = true };

            label3 = new Label() { Text = "Customer ID:", AutoSize = true, Top = y_start + 100 + y_step, Left = x_label };
            txtCusId = new TextBox() { Top = y_start + 100 + y_step, Left = x_input, Width = 150, ReadOnly = true };

            label4 = new Label() { Text = "Tổng tiền:", AutoSize = true, Top = y_start + 100 + y_step * 2, Left = x_label };
            txtTotal = new TextBox() { Top = y_start + 100 + y_step * 2, Left = x_input, Width = 150, ReadOnly = true };

            label5 = new Label() { Text = "Ngày tạo:", AutoSize = true, Top = y_start + 100 + y_step * 3, Left = x_label };
            txtCreatedAt = new TextBox() { Top = y_start + 100 + y_step * 3, Left = x_input, Width = 150, ReadOnly = true };

            // Buttons
            btnRefresh = new Button() { Text = "Làm mới", Top = y_start + 100 + y_step * 4 + 20, Left = x_label, Width = 150, Height = 35 };
            btnRefresh.BackColor = Color.FromArgb(255, 210, 210);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Click += btnRefresh_Click;

            btnDetail = new Button() { Text = "Xem chi tiết hóa đơn", Top = y_start + 100 + y_step * 5 + 30, Left = x_label, Width = 250, Height = 40 };
            btnDetail.BackColor = Color.FromArgb(220, 100, 100);
            btnDetail.ForeColor = Color.White;
            btnDetail.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDetail.FlatStyle = FlatStyle.Flat;
            btnDetail.FlatAppearance.BorderSize = 0;
            btnDetail.Click += btnDetail_Click;

            // Thêm controls vào Panel Right
            panelRight.Controls.Add(label1);
            panelRight.Controls.Add(txtSearch);
            panelRight.Controls.Add(btnSearch);
            panelRight.Controls.Add(btnShowAll);
            panelRight.Controls.Add(label2);
            panelRight.Controls.Add(label3);
            panelRight.Controls.Add(label4);
            panelRight.Controls.Add(label5);
            panelRight.Controls.Add(txtInvoiceId);
            panelRight.Controls.Add(txtCusId);
            panelRight.Controls.Add(txtTotal);
            panelRight.Controls.Add(txtCreatedAt);
            panelRight.Controls.Add(btnRefresh);
            panelRight.Controls.Add(btnDetail);

            // ===================== Form ============================
            ClientSize = new Size(1200, 620);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);

            Name = "QuanLyHoaDon";
            Text = "Quản Lý Hóa Đơn";
            Load += QuanLyHoaDon_Load;

            ((ISupportInitialize)dgvInvoice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}