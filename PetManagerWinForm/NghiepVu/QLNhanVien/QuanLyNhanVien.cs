#nullable disable
using PetManagerData.Controllers;
using System;
using System.Data;
using System.Security.Claims;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace PetManagerWinForm.NghiepVu.QLNhanVien
{
    public partial class QuanLyNhanVien : Form
    {
        private int currentRowIndex = -1;
        private DataTable dtNhanVien = new DataTable();
        private DataRow selectedEmployee = null;
        public QuanLyNhanVien()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
            radioButton1.Checked = true;
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            clmID.DataPropertyName = "ID";
            clmName.DataPropertyName = "Name";
            clmAddress.DataPropertyName = "Address";
            clmPhone.DataPropertyName = "PhoneNumber";
            clmSex.DataPropertyName = "Sex";
            clmEmail.DataPropertyName = "Email";
            clmPosition.DataPropertyName = "Position";
            clmStatus.DataPropertyName = "Status";

            dtNhanVien.Columns.Add("ID", typeof(int));
            dtNhanVien.Columns.Add("Name", typeof(string));
            dtNhanVien.Columns.Add("Address", typeof(string));
            dtNhanVien.Columns.Add("PhoneNumber", typeof(string));
            dtNhanVien.Columns.Add("Sex", typeof(string));
            dtNhanVien.Columns.Add("Email", typeof(string));
            dtNhanVien.Columns.Add("Position", typeof(string));
            dtNhanVien.Columns.Add("Status", typeof(string));

            dtNhanVien.Rows.Add(1, "Hải Long", "Thái Bình", "0123456789", "Nam", "long@mail.com", "Quét rác", "Đang làm");
            dtNhanVien.Rows.Add(2, "Anh Quân", "Ninh Bình", "0987654321", "Nam", "quan@mail.com", "Cắt tỉa", "Đang làm");
            dtNhanVien.Rows.Add(3, "Thiên Khôi", "Hà Nội", "0123456788", "Nam", "khoi@mail.com", "Tắm", "Đang làm");
            dtNhanVien.Rows.Add(4, "Tạ Hiền", "Hà Nội", "09987654322", "Nữ", "hien@mail.com", "Thu ngân", "Đang làm");
            dataGridView1.DataSource = dtNhanVien;

            DisableEmployeeActionButtons();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textID.Text, out int id))
            {
                MessageBox.Show("ID phải là số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textID.Focus();
                return;
            }

            foreach (DataRow checkRow in dtNhanVien.Rows)
            {
                if (checkRow.RowState != DataRowState.Deleted && Convert.ToInt32(checkRow["ID"]) == id)
                {
                    MessageBox.Show("ID này đã tồn tại! Vui lòng nhập ID khác hoặc bấm Reset.", "Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }


            DataRow newRow = dtNhanVien.NewRow();
            newRow["ID"] = id;
            newRow["Name"] = textName.Text;
            newRow["Address"] = textAddress.Text;
            newRow["PhoneNumber"] = textPhone.Text;
            newRow["Sex"] = radioButton1.Checked ? "Nam" : "Nữ";
            newRow["Email"] = textEmail.Text;
            newRow["Position"] = textPosition.Text;
            newRow["Status"] = comboBox1.Text;

            dtNhanVien.Rows.Add(newRow);

            MessageBox.Show("Thêm thành công!");
            ClearTextbox();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            currentRowIndex = e.RowIndex;
            DataRowView rowView = (DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            DataRow row = rowView.Row;

            selectedEmployee = row;

            textID.Text = row["ID"].ToString();
            textName.Text = row["Name"].ToString();
            textAddress.Text = row["Address"].ToString();
            textPhone.Text = row["PhoneNumber"].ToString();

            string sex = row["Sex"].ToString();
            if (sex == "Nam") radioButton1.Checked = true;
            else radioButton2.Checked = true;

            textEmail.Text = row["Email"].ToString();
            textPosition.Text = row["Position"].ToString();

            comboBox1.Text = row["Status"] != DBNull.Value ? row["Status"].ToString() : "Chưa xác định";
            //DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            //textID.Text = row.Cells["clmId"].Value?.ToString();
            //textName.Text = row.Cells["clmName"].Value?.ToString();
            //textAddress.Text = row.Cells["clmAddress"].Value?.ToString();
            //textPhone.Text = row.Cells["clmPhone"].Value?.ToString();

            //string sex = row.Cells["clmSex"].Value?.ToString();
            //if (sex == "Nam") radioButton1.Checked = true;
            //else radioButton2.Checked = true;

            //textEmail.Text = row.Cells["clmEmail"].Value?.ToString();
            //textPosition.Text = row.Cells["clmPosition"].Value?.ToString();
            //textPosition.Text = row.Cells["clmPosition"].Value?.ToString();
            EnableEmployeeActionButtons();
        }

        private void btnUpt_Click(object sender, EventArgs e)
        {
            if (currentRowIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa trên lưới.", "Thông báo");
                return;
            }
            if (!int.TryParse(textID.Text, out int id))
            {
                MessageBox.Show("ID phải là số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRowView rowView = (DataRowView)dataGridView1.Rows[currentRowIndex].DataBoundItem;
            DataRow row = rowView.Row;

            foreach (DataRow checkRow in dtNhanVien.Rows)
            {

                if (checkRow.RowState != DataRowState.Deleted &&
                    Convert.ToInt32(checkRow["ID"]) == id &&
                    checkRow != row)
                {
                    MessageBox.Show("ID này đã tồn tại ở một nhân viên khác! Vui lòng chọn ID khác.", "Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            row["ID"] = id;
            row["Name"] = textName.Text;
            row["Address"] = textAddress.Text;
            row["PhoneNumber"] = textPhone.Text;
            row["Sex"] = radioButton1.Checked ? "Nam" : "Nữ";
            row["Email"] = textEmail.Text;
            row["Position"] = textPosition.Text;
            row["Status"] = comboBox1.Text;

            MessageBox.Show("Cập nhật thành công!");
            ClearTextbox();
        }

        //private void btnDel_Click(object sender, EventArgs e)
        //{
        //    if (currentRowIndex < 0)
        //    {
        //        MessageBox.Show("Vui lòng chọn dòng cần xóa.", "Thông báo");
        //        return;
        //    }

        //    if (MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        DataRowView rowView = (DataRowView)dataGridView1.Rows[currentRowIndex].DataBoundItem;
        //        rowView.Row.Delete();
        //        ClearTextbox();
        //    }
        //}
        private void btnDel_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra chọn dòng (giữ nguyên logic cũ của bạn)
            if (currentRowIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.", "Thông báo");
                return;
            }

            // 2. Hộp thoại xác nhận lần 1 (Yes/No)
            DialogResult result = MessageBox.Show(
                "Bạn chắc chắn muốn xóa nhân viên này?\nHành động này không thể hoàn tác!",
                "Cảnh báo xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                // 3. Hiện ô nhập chữ "xac nhan" (Gọi hàm tự viết ở dưới)
                string inputCode = ShowInputDialog("Để xác nhận xóa, vui lòng nhập chính xác cụm từ: 'xac nhan'", "Xác thực hành động");

                // 4. Kiểm tra chuỗi nhập vào
                if (inputCode == "xac nhan")
                {
                    // Thực hiện xóa (Logic cũ của bạn)
                    DataRowView rowView = (DataRowView)dataGridView1.Rows[currentRowIndex].DataBoundItem;
                    rowView.Row.Delete();

                    MessageBox.Show("Đã xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextbox();
                }
                else if (!string.IsNullOrEmpty(inputCode)) // Người dùng nhập sai (bỏ qua trường hợp bấm Cancel/X)
                {
                    MessageBox.Show("Mã xác nhận không đúng. Hủy bỏ lệnh xóa.", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            dtNhanVien.DefaultView.RowFilter = "";
            ClearTextbox();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm.", "Thông báo");
                return;
            }

            string filter = string.Format("Name LIKE '%{0}%' OR Position LIKE '%{0}%' OR Convert(ID, 'System.String') LIKE '%{0}%'", keyword);

            dtNhanVien.DefaultView.RowFilter = filter;
        }
        private void ClearTextbox()
        {
            textID.Text = "";
            textName.Text = "";
            textAddress.Text = "";
            textPhone.Text = "";
            textEmail.Text = "";
            textPosition.Text = "";
            radioButton1.Checked = true;
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
            currentRowIndex = -1;
            selectedEmployee = null;
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            textBox1.Text = "";
            textID.Focus();
            DisableEmployeeActionButtons();
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
        }
        private string ShowInputDialog(string text, string caption)
        {
            // Tạo Form
            Form prompt = new Form()
            {
                Width = 400,
                Height = 180,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false
            };

            // Tạo Label hướng dẫn
            Label textLabel = new Label() { Left = 20, Top = 20, Text = text, Width = 350 };

            // Tạo TextBox để nhập
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 340 };

            // Tạo nút Xác nhận
            Button confirmation = new Button() { Text = "Xóa", Left = 200, Width = 70, Top = 90, DialogResult = DialogResult.OK };
            confirmation.BackColor = System.Drawing.Color.Red; // Màu đỏ cho nút xóa để cảnh báo
            confirmation.ForeColor = System.Drawing.Color.White;

            // Tạo nút Hủy
            Button cancel = new Button() { Text = "Hủy", Left = 290, Width = 70, Top = 90, DialogResult = DialogResult.Cancel };

            // Sự kiện Click (đóng form)
            confirmation.Click += (sender, e) => { prompt.Close(); };
            cancel.Click += (sender, e) => { prompt.Close(); };

            // Add các control vào Form
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);

            // Thiết lập nút mặc định
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancel;

            // Hiển thị Form và trả về kết quả
            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPhanCa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem textID có dữ liệu không (tức là đã chọn nhân viên chưa)
            if (string.IsNullOrEmpty(textID.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên từ danh sách trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // [ĐÃ SỬA] Khởi tạo FormPhanCa không cần truyền DataTable
            FormPhanCa frm = new FormPhanCa();

            // Truyền thông tin nhân viên đang chọn sang các biến Public của FormPhanCa
            frm.ID_Nhan = textID.Text;
            frm.Ten_Nhan = textName.Text;
            frm.ViTri_Nhan = textPosition.Text;

            // Hiển thị form
            frm.ShowDialog();
        }
        // 2. Nút Chấm Công
        private void btnChamCong_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra đã chọn nhân viên chưa
            if (string.IsNullOrEmpty(textID.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên từ danh sách trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Khởi tạo FormChamCong (Không truyền DataTable nữa)
            FormChamCong frm = new FormChamCong();

            // 3. Truyền dữ liệu sang các biến Public
            frm.ID_Nhan = textID.Text;
            frm.Ten_Nhan = textName.Text;
            frm.ViTri_Nhan = textPosition.Text;

            // 4. Hiển thị Form
            frm.ShowDialog();
        }

        // 3. Nút Tính Lương
        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra đã chọn nhân viên chưa
            if (string.IsNullOrEmpty(textID.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên từ danh sách trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Khởi tạo FormTinhLuong (Không truyền DataTable)
            FormTinhLuong frm = new FormTinhLuong();

            // 3. Truyền dữ liệu
            frm.ID_Nhan = textID.Text;
            frm.Ten_Nhan = textName.Text;
            frm.ViTri_Nhan = textPosition.Text;

            // 4. Hiển thị form
            frm.ShowDialog();
        }
        private void EnableEmployeeActionButtons()
        {
            btnPhanCa.Enabled = true;
            btnChamCong.Enabled = true;
            btnTinhLuong.Enabled = true;

            // Đổi màu để thấy rõ button đã active
            btnPhanCa.BackColor = System.Drawing.SystemColors.Control;
            btnChamCong.BackColor = System.Drawing.SystemColors.Control;
            btnTinhLuong.BackColor = System.Drawing.SystemColors.Control;
        }
        private void DisableEmployeeActionButtons()
        {
            btnPhanCa.Enabled = false;
            btnChamCong.Enabled = false;
            btnTinhLuong.Enabled = false;

            // Đổi màu xám để thấy rõ button bị disable
            btnPhanCa.BackColor = System.Drawing.Color.LightGray;
            btnChamCong.BackColor = System.Drawing.Color.LightGray;
            btnTinhLuong.BackColor = System.Drawing.Color.LightGray;
        }

    }
}