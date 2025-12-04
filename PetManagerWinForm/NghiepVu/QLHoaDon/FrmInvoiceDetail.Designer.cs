using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace PetManagerWinForm.NghiepVu.QLHoaDon
{
    partial class FrmInvoiceDetail
    {
        private IContainer components = null;

        // Controls chính
        private Label lblMainTitle;
        private DataGridView dgvDetails; // Chi tiết Sản phẩm/Dịch vụ
        private GroupBox grpCustomer;
        private GroupBox grpPetInfo;
        private GroupBox grpSummary;
        private Button btnClose;

        // Controls trong GroupBox
        private Label lblCusName, lblCusPhone, lblCusEmail, lblCusAddress;
        private Label lblPetName, lblPetBreed, lblPetAge;
        private Label lblTotal, lblDate, lblInvoiceId;
        private FlowLayoutPanel pnlPetContainer; // Chứa nhiều Pet nếu có

        // Columns cho dgvDetails
        private DataGridViewTextBoxColumn colItemType;
        private DataGridViewTextBoxColumn colItemName;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colTotal;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // Màu sắc theme
            Color themeColor = Color.FromArgb(255, 230, 230); // Hồng nhạt
            Color headerColor = Color.FromArgb(220, 100, 100); // Đỏ đậm

            // Thiết lập Form
            this.BackColor = themeColor;
            this.Text = "Chi tiết Hóa đơn";
            this.ClientSize = new Size(1000, 750);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // === 1. Tiêu đề chính ===
            lblMainTitle = new Label()
            {
                Text = "THÔNG TIN CHI TIẾT HÓA ĐƠN",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 20),
                ForeColor = headerColor
            };

            // === 2. GroupBox Thông tin Khách hàng (Cột trái) ===
            grpCustomer = new GroupBox()
            {
                Text = "Khách hàng",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Location = new Point(20, 70),
                Size = new Size(350, 230),
                BackColor = Color.White
            };

            lblCusName = new Label() { Location = new Point(10, 30), Text = "Tên: [Tên KH]", AutoSize = true, Font = new Font("Segoe UI", 10F, FontStyle.Regular) };
            lblCusPhone = new Label() { Location = new Point(10, 60), Text = "SĐT: [Số điện thoại]", AutoSize = true, Font = new Font("Segoe UI", 10F, FontStyle.Regular) };
            lblCusEmail = new Label() { Location = new Point(10, 90), Text = "Email: [Email]", AutoSize = true, Font = new Font("Segoe UI", 10F, FontStyle.Regular) };
            lblCusAddress = new Label() { Location = new Point(10, 120), Text = "Địa chỉ: [Địa chỉ]", AutoSize = true, Font = new Font("Segoe UI", 10F, FontStyle.Regular) };

            grpCustomer.Controls.AddRange(new Control[] { lblCusName, lblCusPhone, lblCusEmail, lblCusAddress });


            // === 3. GroupBox Tóm tắt Hóa đơn (Cột trái) ===
            grpSummary = new GroupBox()
            {
                Text = "Tóm tắt Hóa đơn",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Location = new Point(20, 310),
                Size = new Size(350, 150),
                BackColor = Color.White
            };

            lblInvoiceId = new Label() { Location = new Point(10, 30), Text = "ID HĐ: #...", AutoSize = true, Font = new Font("Segoe UI", 10F, FontStyle.Regular) };
            lblDate = new Label() { Location = new Point(10, 60), Text = "Ngày tạo: ...", AutoSize = true, Font = new Font("Segoe UI", 10F, FontStyle.Regular) };
            lblTotal = new Label() { Location = new Point(10, 90), Text = "Tổng cộng: ... VNĐ", AutoSize = true, Font = new Font("Segoe UI", 12F, FontStyle.Bold), ForeColor = headerColor };

            grpSummary.Controls.AddRange(new Control[] { lblInvoiceId, lblDate, lblTotal });


            // === 4. GroupBox Chi tiết Thú cưng (Cột trái) ===
            grpPetInfo = new GroupBox()
            {
                Text = "Chi tiết Thú cưng",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Location = new Point(20, 480),
                Size = new Size(350, 200),
                BackColor = Color.White
            };

            pnlPetContainer = new FlowLayoutPanel()
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false
            };
            grpPetInfo.Controls.Add(pnlPetContainer);

            // === 5. DataGridView Chi tiết mục (Cột phải) ===
            dgvDetails = new DataGridView()
            {
                Location = new Point(400, 70),
                Size = new Size(580, 610),
                BackgroundColor = Color.White,
                ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle() { BackColor = headerColor, ForeColor = Color.White, Font = new Font("Segoe UI", 10F, FontStyle.Bold) },
                EnableHeadersVisualStyles = false,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AutoGenerateColumns = false
            };

            colItemType = new DataGridViewTextBoxColumn { HeaderText = "Loại", DataPropertyName = "Loai", Width = 80 };
            colItemName = new DataGridViewTextBoxColumn { HeaderText = "Tên Mục/Pet", DataPropertyName = "TenItem", Width = 180 };
            colQuantity = new DataGridViewTextBoxColumn { HeaderText = "SL", DataPropertyName = "SL", Width = 50 };
            colPrice = new DataGridViewTextBoxColumn { HeaderText = "Đơn giá", DataPropertyName = "DonGia", Width = 100 };
            colTotal = new DataGridViewTextBoxColumn { HeaderText = "Thành tiền", DataPropertyName = "ThanhTien", Width = 150 };

            dgvDetails.Columns.AddRange(new DataGridViewColumn[] { colItemType, colItemName, colQuantity, colPrice, colTotal });

            // === 6. Nút Đóng ===
            btnClose = new Button()
            {
                Text = "Đóng",
                Location = new Point(880, 690),
                Size = new Size(100, 40),
                BackColor = Color.LightGray,
                FlatStyle = FlatStyle.Flat
            };
            btnClose.Click += (sender, e) => this.Close();


            // Thêm tất cả vào Form
            this.Controls.AddRange(new Control[] { lblMainTitle, grpCustomer, grpSummary, grpPetInfo, dgvDetails, btnClose });
        }
    }
}