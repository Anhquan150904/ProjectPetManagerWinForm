using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PetManagerWinForm.NghiepVu.QLNhanVien
{
    public partial class QuanLyNhanVien : Form
    {
        private int currentRowIndex = -1;
        private DataTable dtNhanVien = new DataTable();
        public QuanLyNhanVien()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }
        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dtNhanVien.Columns.Add("ID", typeof(int));
            dtNhanVien.Columns.Add("Name", typeof(string));
            dtNhanVien.Columns.Add("Address", typeof(string));
            dtNhanVien.Columns.Add("PhoneNumber", typeof(string));
            dtNhanVien.Columns.Add("Sex", typeof(string));
            dtNhanVien.Columns.Add("Email", typeof(string));
            dtNhanVien.Columns.Add("Position", typeof(string));
            dtNhanVien.Rows.Add(1, "Hải Long", "Thái Pìng", "0123456789", "Nam", "long@mail.com", "Quét rác");
            dtNhanVien.Rows.Add(2, "Anh Quân", "Ning Pìng", "0987654321", "Nam", "quan@mail.com", "Cắt tỉa");
            dtNhanVien.Rows.Add(3, "Thiên Khôi", "Hà Lội", "0112233445", "Nam", "khoi@mail.com", "Kế toán");
            dataGridView1.DataSource = dtNhanVien;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textID.Text, out int id))
            {
                MessageBox.Show("ID không hợp lệ. Vui lòng nhập số nguyên.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textID.Focus();
                return;
            }

            foreach (DataRow row in dtNhanVien.Rows)
            {
                if (row.RowState != DataRowState.Deleted && Convert.ToInt32(row["ID"]) == id)
                {
                    MessageBox.Show("Mã nhân viên (ID) này đã tồn tại! Vui lòng nhập ID khác.", "Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textID.Focus();
                    textID.SelectAll(); 
                    return;
                }
            }

            DataRow newRow = dtNhanVien.NewRow();

            newRow["ID"] = id;
            newRow["Name"] = textName.Text;
            newRow["Address"] = textAddress.Text;
            newRow["PhoneNumber"] = textPhone.Text;
            newRow["Sex"] = textSex.Text;
            newRow["Email"] = textEmail.Text;
            newRow["Position"] = textPosition.Text;

            dtNhanVien.Rows.Add(newRow);

            MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
            ClearTextbox(); 
            textID.Focus();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            currentRowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            textID.Text = row.Cells["ID"].Value.ToString();
            textName.Text = row.Cells["Name"].Value.ToString();
            textAddress.Text = row.Cells["Address"].Value.ToString();
            textPhone.Text = row.Cells["PhoneNumber"].Value.ToString();
            textSex.Text = row.Cells["Sex"].Value.ToString();
            textEmail.Text = row.Cells["Email"].Value.ToString();
            textPosition.Text = row.Cells["Position"].Value.ToString();
        }
        private void btnUpt_Click(object sender, EventArgs e)
        {
            if (currentRowIndex < 0)
            {
                MessageBox.Show("Chọn dòng cần cập nhật.", "Thông báo");
                return;
            }

            if (!int.TryParse(textID.Text, out int id))
            {
                MessageBox.Show("ID phải là số.", "Lỗi");
                return;
            }

            DataRow row = dtNhanVien.Rows[currentRowIndex];

            row["ID"] = id;
            row["Name"] = textName.Text;
            row["Address"] = textAddress.Text;
            row["PhoneNumber"] = textPhone.Text;
            row["Sex"] = textSex.Text;
            row["Email"] = textEmail.Text;
            row["Position"] = textPosition.Text;

            MessageBox.Show("Đã cập nhật.");
            ClearTextbox();
        }
        private void btnDel_Click(object sender, EventArgs e) // nút Delete
        {
            if (currentRowIndex < 0)
            {
                MessageBox.Show("Chọn dòng cần xóa.", "Thông báo");
                return;
            }

            dtNhanVien.Rows.RemoveAt(currentRowIndex);
            currentRowIndex = -1;

            MessageBox.Show("Đã xóa.");
            ClearTextbox();
        }
        private void ClearTextbox()
        {
            textID.Text = "";
            textName.Text = "";
            textAddress.Text = "";
            textPhone.Text = "";
            textSex.Text = "";
            textEmail.Text = "";
            textPosition.Text = "";
        }
    }
}