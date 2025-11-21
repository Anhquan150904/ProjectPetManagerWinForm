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
        private DataTable dtNhanVien = new DataTable();
        public QuanLyNhanVien()
        {
            InitializeComponent();
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

            // Tạo một hàng dữ liệu mới
            DataRow newRow = dtNhanVien.NewRow();

            // Gán giá trị từ TextBox vào các cột tương ứng
            newRow["ID"] = id;
            newRow["Name"] = textName.Text;
            newRow["Address"] = textAddress.Text;
            newRow["PhoneNumber"] = textPhone.Text;
            newRow["Sex"] = textSex.Text;
            newRow["Email"] = textEmail.Text;
            newRow["Position"] = textPosition.Text;

            // Thêm hàng vào DataTable (DataGridView sẽ tự động cập nhật)
            dtNhanVien.Rows.Add(newRow);


            textID.Text = string.Empty;
            textName.Text = string.Empty;
            textAddress.Text = string.Empty;
            textPhone.Text = string.Empty;
            textSex.Text = string.Empty;
            textEmail.Text = string.Empty;
            textPosition.Text = string.Empty;
            textID.Focus();
        }
    }
}