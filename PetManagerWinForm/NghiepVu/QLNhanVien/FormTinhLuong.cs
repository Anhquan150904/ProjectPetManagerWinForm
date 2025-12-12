#nullable disable
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace PetManagerWinForm.NghiepVu.QLNhanVien
{
    public partial class FormTinhLuong : Form
    {
        // 1. Các biến nhận dữ liệu từ Form cha
        public string ID_Nhan { get; set; }
        public string Ten_Nhan { get; set; }
        public string ViTri_Nhan { get; set; }

        private const double DON_GIA_GIO = 25000;
        public FormTinhLuong()
        {
            InitializeComponent();

            this.Load += FormTinhLuong_Load;

            // Gán sự kiện click
            btnTinhLuong.Click += btnTinhLuong_Click;
            btnDong.Click += (s, e) => this.Close();
        }

        private void FormTinhLuong_Load(object sender, EventArgs e)
        {
            // 3. Đổ dữ liệu từ biến vào giao diện
            lblID.Text = ID_Nhan;
            lblName.Text = Ten_Nhan;
            lblPosition.Text = ViTri_Nhan;

            // 4. Tính toán phụ cấp (Chuyển logic từ ComboBox cũ sang đây)
            TinhPhuCapTheoViTri();

            // 5. Cài đặt thời gian mặc định
            cmbThang.Text = DateTime.Now.Month.ToString();

            // Populate năm (Ví dụ 5 năm gần nhất)
            int currentYear = DateTime.Now.Year;
            cmbNam.Items.Clear(); // Xóa cũ nếu có để tránh duplicate khi reload (nếu có)
            for (int i = currentYear - 2; i <= currentYear + 2; i++)
            {
                cmbNam.Items.Add(i);
            }
            cmbNam.Text = currentYear.ToString();

            // Reset form về trạng thái ban đầu
            ResetForm();
        }
        private void TinhPhuCapTheoViTri()
        {
            double phuCap = 0;
            // Logic giả định phụ cấp theo vị trí
            if (lblPosition.Text.Contains("Quản lý")) phuCap = 500000;
            else if (lblPosition.Text.Contains("Thu ngân")) phuCap = 200000;

            lblPhuCap.Text = phuCap.ToString("N0") + " VNĐ";
        }

        

        private void ResetForm()
        {
            dataGridViewChiTiet.Rows.Clear();
            lblTongGio.Text = "0.0 giờ";
            lblLuongCoBan.Text = "0 VNĐ";
            lblThucLanh.Text = "0 VNĐ";
            txtThuong.Text = "0";
            txtPhat.Text = "0";
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            // 1. Giả lập dữ liệu chấm công (vì chưa kết nối DB chấm công thật)
            // Trong thực tế: SELECT * FROM ChamCong WHERE ID = @ID AND Month = @M ...
            MockDataChamCong();

            // 2. Tính tổng giờ
            double tongGio = 0;
            foreach (DataGridViewRow row in dataGridViewChiTiet.Rows)
            {
                if (row.Cells["colTongGio"].Value != null)
                    tongGio += Convert.ToDouble(row.Cells["colTongGio"].Value);
            }
            lblTongGio.Text = tongGio.ToString() + " giờ";

            // 3. Tính Lương cơ bản = Tổng giờ * Đơn giá
            double luongCoBan = tongGio * DON_GIA_GIO;
            lblLuongCoBan.Text = luongCoBan.ToString("N0") + " VNĐ";

            // 4. Lấy giá trị Thưởng/Phạt
            double thuong = 0, phat = 0;
            double.TryParse(txtThuong.Text, out thuong);
            double.TryParse(txtPhat.Text, out phat);

            // 5. Lấy phụ cấp (xoá chữ VNĐ để parse)
            double phuCap = 0;
            string strPhuCap = lblPhuCap.Text.Replace(" VNĐ", "").Replace(",", "").Trim();
            double.TryParse(strPhuCap, out phuCap);

            // 6. Tính Thực lãnh
            double thucLanh = luongCoBan + phuCap + thuong - phat;
            lblThucLanh.Text = thucLanh.ToString("N0") + " VNĐ";
        }

        private void MockDataChamCong()
        {
            // Hàm này sinh dữ liệu giả để test tính năng tính toán
            dataGridViewChiTiet.Rows.Clear();
            Random rnd = new Random();
            int daysInMonth = DateTime.DaysInMonth(int.Parse(cmbNam.Text), int.Parse(cmbThang.Text));

            for (int i = 1; i <= 20; i++) // Giả sử đi làm 20 ngày
            {
                int day = rnd.Next(1, daysInMonth);
                double hours = rnd.Next(4, 9); // Làm từ 4 đến 8 tiếng
                double thanhTien = hours * DON_GIA_GIO;

                dataGridViewChiTiet.Rows.Add(
                    $"{day}/{cmbThang.Text}/{cmbNam.Text}",
                    "08:00",
                    (8 + hours).ToString("00") + ":00",
                    hours,
                    thanhTien.ToString("N0")
                );
            }
        }
    }
}