#nullable disable
using System;
using System.Data;
using System.Windows.Forms;

namespace PetManagerWinForm.NghiepVu.QLNhanVien
{
    public partial class FormPhanCa : Form
    {
        private DataTable _duLieuNhanVien;
        private ComboBox cmbChonNhanVien;

        private bool _isLoading = true;
        public string ID_Nhan { get; set; }
        public string Ten_Nhan { get; set; }
        public string ViTri_Nhan { get; set; }

        // [SỬA] Constructor nhận thêm tham số currentID (có thể null)
        public FormPhanCa()
        {
            InitializeComponent();

            // Đăng ký sự kiện Load và Click cho nút Đóng
            this.Load += FormPhanCa_Load;
            btnDong.Click += btnDong_Click;
        }

        private void FormPhanCa_Load(object sender, EventArgs e)
        {
            // Đổ dữ liệu từ biến vào các Label hiển thị
            lblID.Text = ID_Nhan;
            lblName.Text = Ten_Nhan;
            lblPosition.Text = ViTri_Nhan;

            // Khởi tạo dữ liệu mẫu cho lịch (nếu cần)
            KhoiTaoDuLieuMauLichLam();
        }

        private void TaoComboBoxChonNhanVien()
        {
            cmbChonNhanVien = new ComboBox();
            cmbChonNhanVien.Parent = this.groupBox1;
            cmbChonNhanVien.Location = new System.Drawing.Point(120, 70);
            cmbChonNhanVien.Size = new System.Drawing.Size(200, 25);
            cmbChonNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;

            // Sự kiện này sẽ bị biến _isLoading chặn lại khi Form mới mở
            cmbChonNhanVien.SelectedIndexChanged += CmbChonNhanVien_SelectedIndexChanged;

            // Gán dữ liệu sau cùng
            cmbChonNhanVien.DataSource = _duLieuNhanVien;
            cmbChonNhanVien.DisplayMember = "Name";
            cmbChonNhanVien.ValueMember = "ID";
        }

        private void CmbChonNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nếu đang trong quá trình Load Form thì KHÔNG làm gì cả (tránh ghi đè dữ liệu truyền vào)
            if (_isLoading) return;

            UpdateLabelFromCombo();
        }

        private void UpdateLabelFromCombo()
        {
            if (cmbChonNhanVien.SelectedItem is DataRowView rowView)
            {
                lblID.Text = rowView["ID"].ToString();
                lblName.Text = rowView["Name"].ToString();
                lblPosition.Text = rowView["Position"].ToString();
            }
        }
        private void HienThiThongTinNhanVien()
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (cmbChonNhanVien.SelectedItem is DataRowView rowView)
            {
                // Lấy dữ liệu từ dòng đó gán vào Label
                lblID.Text = rowView["ID"].ToString();
                lblName.Text = rowView["Name"].ToString();
                lblPosition.Text = rowView["Position"].ToString();
            }
        }

        private void btnThemCa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbCa.Text))
            {
                MessageBox.Show("Vui lòng chọn ca làm việc!");
                return;
            }

            string ngay = dtpNgay.Value.ToString("dd/MM/yyyy");
            string thu = dtpNgay.Value.DayOfWeek.ToString(); // Có thể việt hóa Thứ
            string ca = cmbCa.Text;

            // Kiểm tra xem ngày này đã có trong lưới chưa
            bool found = false;
            foreach (DataGridViewRow row in dataGridViewLich.Rows)
            {
                if (row.Cells["colNgay"].Value?.ToString() == ngay)
                {
                    // Update cột tương ứng theo Ca
                    if (ca.Contains("Sáng")) row.Cells["colCaSang"].Value = "X";
                    if (ca.Contains("Chiều")) row.Cells["colCaChieu"].Value = "X";
                    if (ca.Contains("Tối")) row.Cells["colCaToi"].Value = "X";
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                int index = dataGridViewLich.Rows.Add();
                DataGridViewRow newRow = dataGridViewLich.Rows[index];
                newRow.Cells["colNgay"].Value = ngay;
                newRow.Cells["colThu"].Value = thu;
                if (ca.Contains("Sáng")) newRow.Cells["colCaSang"].Value = "X";
                if (ca.Contains("Chiều")) newRow.Cells["colCaChieu"].Value = "X";
                if (ca.Contains("Tối")) newRow.Cells["colCaToi"].Value = "X";
            }
        }

        private void btnXoaCa_Click(object sender, EventArgs e)
        {
            if (dataGridViewLich.CurrentRow != null)
            {
                dataGridViewLich.Rows.Remove(dataGridViewLich.CurrentRow);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng lịch cần xóa.");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Đã lưu lịch làm việc cho nhân viên: {lblName.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- Helper: Mock Data ---
        private void KhoiTaoDuLieuMauLichLam()
        {
            // Dữ liệu giả định để test giao diện
            dataGridViewLich.Rows.Add("12/12/2025", "Friday", "X", "", "");
            dataGridViewLich.Rows.Add("13/12/2025", "Saturday", "", "X", "");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}