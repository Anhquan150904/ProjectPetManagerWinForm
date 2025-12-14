#nullable disable
using PetManagerData.DataAccess;
using System;
using System.Data;
using System.Windows.Forms;

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

            textID.ReadOnly = true;
            textID.BackColor = System.Drawing.SystemColors.Control;

            LoadEmployees();
            DisableEmployeeActionButtons();
        }

        private void LoadEmployees()
        {
            try
            {
                dtNhanVien = EmployeeDataAccess.GetAllEmployees();
                dataGridView1.DataSource = dtNhanVien;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate
                if (string.IsNullOrWhiteSpace(textName.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên nhân viên.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textName.Focus();
                    return;
                }

                // Thêm vào database
                int newId = EmployeeDataAccess.InsertEmployee(
                    textName.Text,
                    textAddress.Text,
                    textPhone.Text,
                    radioButton1.Checked ? "Nam" : "Nữ",
                    textEmail.Text,
                    textPosition.Text,
                    comboBox1.Text
                );

                MessageBox.Show($"Thêm thành công! ID: {newId}", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadEmployees();
                ClearTextbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm nhân viên: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            EnableEmployeeActionButtons();
        }

        private void btnUpt_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentRowIndex < 0 || string.IsNullOrEmpty(textID.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần sửa.", "Thông báo");
                    return;
                }

                if (!int.TryParse(textID.Text, out int id))
                {
                    MessageBox.Show("ID không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cập nhật database
                EmployeeDataAccess.UpdateEmployee(
                    id,
                    textName.Text,
                    textAddress.Text,
                    textPhone.Text,
                    radioButton1.Checked ? "Nam" : "Nữ",
                    textEmail.Text,
                    textPosition.Text,
                    comboBox1.Text
                );

                MessageBox.Show("Cập nhật thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadEmployees();
                ClearTextbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentRowIndex < 0 || string.IsNullOrEmpty(textID.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần xóa.", "Thông báo");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Bạn chắc chắn muốn xóa nhân viên này?\nHành động này không thể hoàn tác!",
                    "Cảnh báo xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    string inputCode = ShowInputDialog(
                        "Để xác nhận xóa, vui lòng nhập chính xác cụm từ: 'xac nhan'",
                        "Xác thực hành động");

                    if (inputCode == "xac nhan")
                    {
                        int id = int.Parse(textID.Text);
                        EmployeeDataAccess.DeleteEmployee(id);

                        MessageBox.Show("Đã xóa nhân viên thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadEmployees();
                        ClearTextbox();
                    }
                    else if (!string.IsNullOrEmpty(inputCode))
                    {
                        MessageBox.Show("Mã xác nhận không đúng. Hủy bỏ lệnh xóa.", "Lỗi xác thực",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadEmployees();
            ClearTextbox();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = textBox1.Text.Trim();

                if (string.IsNullOrEmpty(keyword))
                {
                    MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm.", "Thông báo");
                    return;
                }

                dtNhanVien = EmployeeDataAccess.SearchEmployees(keyword);
                dataGridView1.DataSource = dtNhanVien;

                if (dtNhanVien.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        }

        private string ShowInputDialog(string text, string caption)
        {
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

            Label textLabel = new Label() { Left = 20, Top = 20, Text = text, Width = 350 };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 340 };
            Button confirmation = new Button() { Text = "Xóa", Left = 200, Width = 70, Top = 90, DialogResult = DialogResult.OK };
            confirmation.BackColor = System.Drawing.Color.Red;
            confirmation.ForeColor = System.Drawing.Color.White;
            Button cancel = new Button() { Text = "Hủy", Left = 290, Width = 70, Top = 90, DialogResult = DialogResult.Cancel };

            confirmation.Click += (sender, e) => { prompt.Close(); };
            cancel.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancel;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnPhanCa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textID.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên từ danh sách trước!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormPhanCa frm = new FormPhanCa
            {
                ID_Nhan = textID.Text,
                Ten_Nhan = textName.Text,
                ViTri_Nhan = textPosition.Text
            };

            frm.ShowDialog();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textID.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên từ danh sách trước!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormChamCong frm = new FormChamCong
            {
                ID_Nhan = textID.Text,
                Ten_Nhan = textName.Text,
                ViTri_Nhan = textPosition.Text
            };

            frm.ShowDialog();
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textID.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên từ danh sách trước!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormTinhLuong frm = new FormTinhLuong
            {
                ID_Nhan = textID.Text,
                Ten_Nhan = textName.Text,
                ViTri_Nhan = textPosition.Text
            };

            frm.ShowDialog();
        }

        private void EnableEmployeeActionButtons()
        {
            btnPhanCa.Enabled = true;
            btnChamCong.Enabled = true;
            btnTinhLuong.Enabled = true;

            btnPhanCa.BackColor = System.Drawing.SystemColors.Control;
            btnChamCong.BackColor = System.Drawing.SystemColors.Control;
            btnTinhLuong.BackColor = System.Drawing.SystemColors.Control;
        }

        private void DisableEmployeeActionButtons()
        {
            btnPhanCa.Enabled = false;
            btnChamCong.Enabled = false;
            btnTinhLuong.Enabled = false;

            btnPhanCa.BackColor = System.Drawing.Color.LightGray;
            btnChamCong.BackColor = System.Drawing.Color.LightGray;
            btnTinhLuong.BackColor = System.Drawing.Color.LightGray;
        }
    }
}