#nullable disable
using PetManagerData.DataAccess;
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
            btnGioVao.Click += btnGioVao_Click;
            btnGioRa.Click += btnGioRa_Click;
            btnDong.Click += (s, e) => this.Close();

            btnLuu.Click += btnLuu_Click; // Sự kiện sửa/lưu lại thông tin
            btnXoa.Click += btnXoa_Click; // Sự kiện xóa
            dataGridViewLichSu.CellClick += dataGridViewLichSu_CellClick;
        }
        private void dataGridViewLichSu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridViewLichSu.Rows[e.RowIndex];

            // Lấy ngày
            if (DateTime.TryParse(row.Cells["colNgay"].Value?.ToString(), out DateTime ngay))
                dtpNgay.Value = ngay;

            // Lấy giờ vào
            if (TimeSpan.TryParse(row.Cells["colGioVao"].Value?.ToString(), out TimeSpan gioVao))
                dtpGioVao.Value = DateTime.Today.Add(gioVao);

            // Lấy giờ ra
            if (row.Cells["colGioRa"].Value != null && TimeSpan.TryParse(row.Cells["colGioRa"].Value.ToString(), out TimeSpan gioRa))
                dtpGioRa.Value = DateTime.Today.Add(gioRa);

            // Lấy ghi chú
            txtGhiChu.Text = row.Cells["colGhiChu"].Value?.ToString() ?? "";
        }
        private void FormChamCong_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin nhân viên
            lblID.Text = ID_Nhan;
            lblName.Text = Ten_Nhan;
            lblPosition.Text = ViTri_Nhan;

            // Reset giá trị
            dtpGioVao.Value = DateTime.Now;
            dtpGioRa.Value = DateTime.Now;
            dataGridViewLichSu.Columns["colID"].Visible = false;
            // Tải lịch sử chấm công
            LoadAttendanceHistory();
        }

        private void LoadAttendanceHistory()
        {
            try
            {
                if (!int.TryParse(lblID.Text, out int employeeId))
                    return;

                DataTable dt = AttendanceDataAccess.GetAttendanceHistory(employeeId);
                DataView dv = dt.DefaultView;
                dv.Sort = "Date ASC"; // ASC = tăng dần (cũ nhất trước)
                dt = dv.ToTable();

                dataGridViewLichSu.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    int index = dataGridViewLichSu.Rows.Add();
                    DataGridViewRow gridRow = dataGridViewLichSu.Rows[index];

                    gridRow.Cells["colID"].Value = row["EmployeeID"].ToString();
                    gridRow.Cells["colNgay"].Value = Convert.ToDateTime(row["Date"]).ToString("dd/MM/yyyy");

                    if (row["TimeIn"] != DBNull.Value)
                        gridRow.Cells["colGioVao"].Value = ((TimeSpan)row["TimeIn"]).ToString(@"hh\:mm");

                    if (row["TimeOut"] != DBNull.Value)
                        gridRow.Cells["colGioRa"].Value = ((TimeSpan)row["TimeOut"]).ToString(@"hh\:mm");

                    if (row["TotalHours"] != DBNull.Value)
                        gridRow.Cells["colTongGio"].Value = row["TotalHours"];

                    if (row["Note"] != DBNull.Value)
                        gridRow.Cells["colGhiChu"].Value = row["Note"];
                }

                TinhTongGioThang();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải lịch sử: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGioVao_Click(object sender, EventArgs e)
        {
            // Chỉ set giá trị thời gian trên giao diện
            dtpGioVao.Value = DateTime.Now;
            MessageBox.Show("Đã lấy giờ vào hiện tại. Vui lòng bấm 'Lưu' để ghi nhận.", "Thông báo");
        }

        private void btnGioRa_Click(object sender, EventArgs e)
        {
            // Chỉ set giá trị thời gian trên giao diện
            dtpGioRa.Value = DateTime.Now;
            MessageBox.Show("Đã lấy giờ ra hiện tại. Vui lòng bấm 'Lưu' để ghi nhận.", "Thông báo");
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
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewLichSu.CurrentRow == null || dataGridViewLichSu.CurrentRow.Index < 0)
                {
                    MessageBox.Show("Vui lòng chọn dòng chấm công cần xóa!", "Thông báo");
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu chấm công ngày này?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int employeeId = int.Parse(lblID.Text);
                    // Lấy ngày từ cột trong grid (vì dtpNgay có thể đã bị người dùng sửa)
                    string dateString = dataGridViewLichSu.CurrentRow.Cells["colNgay"].Value.ToString();
                    DateTime dateToDelete = DateTime.ParseExact(dateString, "dd/MM/yyyy", null);

                    // Gọi hàm xóa trong DataAccess (Bạn cần đảm bảo hàm này tồn tại bên AttendanceDataAccess)
                    AttendanceDataAccess.DeleteAttendance(employeeId, dateToDelete);

                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    LoadAttendanceHistory(); // Tải lại danh sách
                    TinhTongGioThang(); // Tính lại tổng giờ
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi");
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Lấy dữ liệu từ giao diện
                if (!int.TryParse(lblID.Text, out int employeeId))
                {
                    MessageBox.Show("Không xác định được nhân viên.", "Lỗi");
                    return;
                }

                DateTime ngayLam = dtpNgay.Value.Date;
                TimeSpan gioVao = dtpGioVao.Value.TimeOfDay;
                TimeSpan gioRa = dtpGioRa.Value.TimeOfDay;
                string ghiChu = txtGhiChu.Text;

                // 2. Kiểm tra xem ngày này đã tồn tại trong Grid chưa (để quyết định Thêm hay Sửa)
                bool daTonTai = false;
                foreach (DataGridViewRow row in dataGridViewLichSu.Rows)
                {
                    // So sánh ngày trong grid với ngày đang chọn
                    if (row.Cells["colNgay"].Value.ToString() == ngayLam.ToString("dd/MM/yyyy"))
                    {
                        daTonTai = true;
                        break;
                    }
                }

                // 3. Xử lý lưu dữ liệu
                if (!daTonTai)
                {
                    // --- TRƯỜNG HỢP 1: CHƯA CÓ -> THÊM MỚI (INSERT) ---
                    // Lưu ý: Hàm Insert mặc định chỉ lưu Giờ Vào.
                    AttendanceDataAccess.InsertAttendance(employeeId, ngayLam, gioVao, ghiChu);
                    MessageBox.Show("Đã tạo mới bản ghi chấm công!", "Thành công");
                }
                else
                {
                    // --- TRƯỜNG HỢP 2: ĐÃ CÓ -> CẬP NHẬT (UPDATE) ---

                    // Tính tổng giờ làm
                    double tongGio = 0;
                    if (gioRa > gioVao)
                    {
                        tongGio = Math.Round((gioRa - gioVao).TotalHours, 1);
                    }
                    else
                    {
                        // Cảnh báo nhẹ nếu giờ ra nhỏ hơn giờ vào, nhưng vẫn cho lưu nếu muốn sửa sau
                        DialogResult ktr = MessageBox.Show("Giờ ra đang nhỏ hơn hoặc bằng Giờ vào. Bạn có chắc chắn muốn lưu?",
                            "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (ktr == DialogResult.No) return;
                    }

                    // Gọi hàm UpdateAttendanceFull mà chúng ta đã thêm ở bước trước
                    AttendanceDataAccess.UpdateAttendanceFull(
                        employeeId,
                        ngayLam,
                        gioVao,
                        gioRa,
                        (decimal)tongGio,
                        ghiChu
                    );
                    MessageBox.Show("Đã cập nhật thông tin chấm công!", "Thành công");
                }

                // 4. Tải lại dữ liệu lên lưới
                LoadAttendanceHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}", "Lỗi");
            }
        }
    }
}