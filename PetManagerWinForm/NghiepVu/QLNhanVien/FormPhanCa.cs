#nullable disable
using PetManagerData.DataAccess;
using System;
using System.Data;
using System.Windows.Forms;

namespace PetManagerWinForm.NghiepVu.QLNhanVien
{
    public partial class FormPhanCa : Form
    {
        public string ID_Nhan { get; set; }
        public string Ten_Nhan { get; set; }
        public string ViTri_Nhan { get; set; }

        public FormPhanCa()
        {
            InitializeComponent();
            this.Load += FormPhanCa_Load;
            btnDong.Click += btnDong_Click;
        }

        private void FormPhanCa_Load(object sender, EventArgs e)
        {
            lblID.Text = ID_Nhan;
            lblName.Text = Ten_Nhan;
            lblPosition.Text = ViTri_Nhan;

            LoadShiftSchedule();
        }

        private void LoadShiftSchedule()
        {
            try
            {
                if (!int.TryParse(lblID.Text, out int employeeId))
                    return;

                DataTable dt = ShiftDataAccess.GetShiftSchedule(employeeId);

                dataGridViewLich.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    int index = dataGridViewLich.Rows.Add();
                    DataGridViewRow gridRow = dataGridViewLich.Rows[index];

                    DateTime date = Convert.ToDateTime(row["Date"]);
                    gridRow.Cells["colNgay"].Value = date.ToString("dd/MM/yyyy");
                    gridRow.Cells["colThu"].Value = LayThuTiengViet(date.DayOfWeek);

                    gridRow.Cells["colCaSang"].Value = Convert.ToBoolean(row["CaSang"]) ? "X" : "";
                    gridRow.Cells["colCaChieu"].Value = Convert.ToBoolean(row["CaChieu"]) ? "X" : "";
                    gridRow.Cells["colCaToi"].Value = Convert.ToBoolean(row["CaToi"]) ? "X" : "";

                    gridRow.Tag = row["ID"]; // Lưu ID để xóa sau này
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải lịch: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemCa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmbCa.Text))
                {
                    MessageBox.Show("Vui lòng chọn ca làm việc!");
                    return;
                }

                if (!int.TryParse(lblID.Text, out int employeeId))
                {
                    MessageBox.Show("ID nhân viên không hợp lệ!");
                    return;
                }

                string ca = cmbCa.Text;
                bool caSang = ca.Contains("Sáng");
                bool caChieu = ca.Contains("Chiều");
                bool caToi = ca.Contains("Tối");

                ShiftDataAccess.UpsertShift(employeeId, dtpNgay.Value, caSang, caChieu, caToi);

                MessageBox.Show("Đã lưu phân ca!", "Thành công");
                LoadShiftSchedule();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm ca: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaCa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewLich.CurrentRow != null && dataGridViewLich.CurrentRow.Tag != null)
                {
                    int shiftId = Convert.ToInt32(dataGridViewLich.CurrentRow.Tag);
                    ShiftDataAccess.DeleteShift(shiftId);

                    MessageBox.Show("Đã xóa ca làm việc!", "Thành công");
                    LoadShiftSchedule();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng lịch cần xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Lịch làm việc đã được tự động lưu!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private string LayThuTiengViet(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Monday: return "Thứ Hai";
                case DayOfWeek.Tuesday: return "Thứ Ba";
                case DayOfWeek.Wednesday: return "Thứ Tư";
                case DayOfWeek.Thursday: return "Thứ Năm";
                case DayOfWeek.Friday: return "Thứ Sáu";
                case DayOfWeek.Saturday: return "Thứ Bảy";
                case DayOfWeek.Sunday: return "Chủ Nhật";
                default: return "";
            }
        }
    }

}