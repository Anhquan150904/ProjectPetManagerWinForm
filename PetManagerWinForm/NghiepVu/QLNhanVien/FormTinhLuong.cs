#nullable disable
using PetManagerData.DataAccess;
using System;
using System.Data;
using System.Windows.Forms;

namespace PetManagerWinForm.NghiepVu.QLNhanVien
{
    public partial class FormTinhLuong : Form
    {
        public string ID_Nhan { get; set; }
        public string Ten_Nhan { get; set; }
        public string ViTri_Nhan { get; set; }

        private const double DON_GIA_GIO = 25000;

        public FormTinhLuong()
        {
            InitializeComponent();
            this.Load += FormTinhLuong_Load;
            btnTinhLuong.Click += btnTinhLuong_Click;
            btnDong.Click += (s, e) => this.Close();

            txtThuong.TextChanged += TinhLaiThucLanh;
            txtPhat.TextChanged += TinhLaiThucLanh;

            txtThuong.KeyPress += ChiChoNhapSo;
            txtPhat.KeyPress += ChiChoNhapSo;
        }
        private void ChiChoNhapSo(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép số, phím Backspace và dấu âm (nếu cần)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TinhLaiThucLanh(object sender, EventArgs e)
        {
            try
            {
                // Lấy lương cơ bản
                string strLuongCoBan = lblLuongCoBan.Text.Replace(" VNĐ", "").Replace(",", "").Trim();
                if (!double.TryParse(strLuongCoBan, out double luongCoBan))
                    return;

                // Lấy phụ cấp
                string strPhuCap = lblPhuCap.Text.Replace(" VNĐ", "").Replace(",", "").Trim();
                double.TryParse(strPhuCap, out double phuCap);

                // Lấy thưởng và phạt
                double.TryParse(txtThuong.Text, out double thuong);
                double.TryParse(txtPhat.Text, out double phat);

                // Tính lương thực lãnh
                double thucLanh = luongCoBan + phuCap + thuong - phat;
                lblThucLanh.Text = thucLanh.ToString("N0") + " VNĐ";
            }
            catch { }
        }

        private void FormTinhLuong_Load(object sender, EventArgs e)
        {
            lblID.Text = ID_Nhan;
            lblName.Text = Ten_Nhan;
            lblPosition.Text = ViTri_Nhan;

            TinhPhuCapTheoViTri();

            cmbThang.Text = DateTime.Now.Month.ToString();
            int currentYear = DateTime.Now.Year;
            cmbNam.Items.Clear();
            for (int i = currentYear - 2; i <= currentYear + 2; i++)
            {
                cmbNam.Items.Add(i);
            }
            cmbNam.Text = currentYear.ToString();

            ResetForm();
        }


        private void TinhPhuCapTheoViTri()
        {
            double phuCap = 0;
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
            try
            {
                if (!int.TryParse(lblID.Text, out int employeeId))
                {
                    MessageBox.Show("ID nhân viên không hợp lệ!");
                    return;
                }

                int month = int.Parse(cmbThang.Text);
                int year = int.Parse(cmbNam.Text);

                // Lấy dữ liệu chấm công từ database
                DataTable dt = AttendanceDataAccess.GetAttendanceByMonth(employeeId, month, year);

                DataView dv = dt.DefaultView;
                dv.Sort = "Date ASC";
                dt = dv.ToTable();

                dataGridViewChiTiet.Rows.Clear();
                double tongGio = 0;

                foreach (DataRow row in dt.Rows)
                {
                    if (row["TotalHours"] != DBNull.Value)
                    {
                        double hours = Convert.ToDouble(row["TotalHours"]);
                        tongGio += hours;

                        int index = dataGridViewChiTiet.Rows.Add();
                        DataGridViewRow gridRow = dataGridViewChiTiet.Rows[index];

                        gridRow.Cells["colNgay"].Value = Convert.ToDateTime(row["Date"]).ToString("dd/MM/yyyy");

                        if (row["TimeIn"] != DBNull.Value)
                            gridRow.Cells["colGioVao"].Value = ((TimeSpan)row["TimeIn"]).ToString(@"hh\:mm");

                        if (row["TimeOut"] != DBNull.Value)
                            gridRow.Cells["colGioRa"].Value = ((TimeSpan)row["TimeOut"]).ToString(@"hh\:mm");

                        gridRow.Cells["colTongGio"].Value = hours;
                        gridRow.Cells["colThanhTien"].Value = (hours * DON_GIA_GIO).ToString("N0");
                    }
                }

                lblTongGio.Text = tongGio.ToString() + " giờ";

                // Tính lương
                double luongCoBan = tongGio * DON_GIA_GIO;
                lblLuongCoBan.Text = luongCoBan.ToString("N0") + " VNĐ";

                double.TryParse(txtThuong.Text, out double thuong);
                double.TryParse(txtPhat.Text, out double phat);

                string strPhuCap = lblPhuCap.Text.Replace(" VNĐ", "").Replace(",", "").Trim();
                double.TryParse(strPhuCap, out double phuCap);

                double thucLanh = luongCoBan + phuCap + thuong - phat;
                lblThucLanh.Text = thucLanh.ToString("N0") + " VNĐ";

                // Lưu vào database
                decimal bonus = Convert.ToDecimal(thuong);
                decimal penalty = Convert.ToDecimal(phat);

                SalaryDataAccess.CalculateSalary(employeeId, month, year, bonus, penalty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tính lương: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}