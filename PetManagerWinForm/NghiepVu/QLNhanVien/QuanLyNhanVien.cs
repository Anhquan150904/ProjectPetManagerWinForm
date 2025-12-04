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

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (currentRowIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.", "Thông báo");
                return;
            }

            if (MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataRowView rowView = (DataRowView)dataGridView1.Rows[currentRowIndex].DataBoundItem;
                rowView.Row.Delete(); 
                ClearTextbox();
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
            textID.Focus();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Detail detailForm = new Detail();
            detailForm.ShowDialog();

        }

    }
}