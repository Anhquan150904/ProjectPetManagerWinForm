#nullable disable
using System;
using System.Data;
using System.Windows.Forms;

namespace PetManagerWinForm.NghiepVu.QLNhanVien
{
    public partial class FormChamCong : Form
    {
        public string ID_Nhan { get; set; }
        public string Ten_Nhan { get; set; }
        public string ViTri_Nhan { get; set; }

        public FormChamCong()
        {
            InitializeComponent();

            this.Load += FormChamCong_Load;

            // Gán sự kiện cho các nút
            btnGioVao.Click += btnGioVao_Click;
            btnGioRa.Click += btnGioRa_Click;

            // Xử lý nút Đóng
            btnDong.Click += (s, e) => this.Close();
        }

        private void FormChamCong_Load(object sender, EventArgs e)
        {
            // 3. Gán dữ liệu từ biến vào Label hiển thị ngay khi Load form
            lblID.Text = ID_Nhan;
            lblName.Text = Ten_Nhan;
            lblPosition.Text = ViTri_Nhan;

            // Reset hiển thị giờ
            dtpGioVao.Value = DateTime.Now;
            dtpGioRa.Value = DateTime.Now;

            // Xóa dòng này: TaoComboBoxChonNhanVien(); -> Không dùng nữa
        }

        

        private void btnGioVao_Click(object sender, EventArgs e)
        {
            // Thêm dòng mới vào Grid Lịch sử (Check-in)
            int index = dataGridViewLichSu.Rows.Add();
            DataGridViewRow row = dataGridViewLichSu.Rows[index];

            row.Cells["colID"].Value = lblID.Text;
            row.Cells["colNgay"].Value = dtpNgay.Value.ToShortDateString();
            row.Cells["colGioVao"].Value = dtpGioVao.Value.ToString("HH:mm");
            row.Cells["colGhiChu"].Value = txtGhiChu.Text;

            MessageBox.Show("Đã ghi nhận giờ vào!", "Thành công");
        }

        private void btnGioRa_Click(object sender, EventArgs e)
        {
            // Logic: Tìm dòng nào của ngày hôm nay mà chưa có giờ ra để cập nhật
            string today = dtpNgay.Value.ToShortDateString();
            bool updated = false;

            foreach (DataGridViewRow row in dataGridViewLichSu.Rows)
            {
                if (row.Cells["colNgay"].Value?.ToString() == today &&
                    row.Cells["colGioRa"].Value == null)
                {
                    DateTime inTime = DateTime.Parse(today + " " + row.Cells["colGioVao"].Value.ToString());
                    DateTime outTime = dtpGioRa.Value;

                    if (outTime < inTime)
                    {
                        MessageBox.Show("Giờ ra không thể nhỏ hơn giờ vào!");
                        return;
                    }

                    row.Cells["colGioRa"].Value = outTime.ToString("HH:mm");

                    // Tính tổng giờ
                    TimeSpan span = outTime - inTime;
                    double totalHours = Math.Round(span.TotalHours, 1);
                    row.Cells["colTongGio"].Value = totalHours;

                    lblTongGio.Text = totalHours.ToString() + " giờ";
                    updated = true;
                    break;
                }
            }

            if (!updated)
            {
                MessageBox.Show("Không tìm thấy lượt vào nào chưa check-out trong ngày này. Vui lòng check-in trước.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TinhTongGioThang();
            }
        }

        private void TinhTongGioThang()
        {
            double tong = 0;
            foreach (DataGridViewRow row in dataGridViewLichSu.Rows)
            {
                if (row.Cells["colTongGio"].Value != null)
                {
                    tong += Convert.ToDouble(row.Cells["colTongGio"].Value);
                }
            }
            lblTongGioThang.Text = tong + " giờ";
        }
    }
}