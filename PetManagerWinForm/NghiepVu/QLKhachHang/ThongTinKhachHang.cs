using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetManagerData.Models;

namespace PetManagerWinForm.NghiepVu.QLKhachHang
{
    public partial class ThongTinKhachHang : Form
    {
        public ThongTinKhachHang()
        {
            InitializeComponent();
            this.Load += ThongTinKhachHang_Load;

        }

        private List<Customer> cus = new List<Customer>();
        private int idoldcus;

        private void ThongTinKhachHang_Load(object sender, EventArgs e)
        {
            cus = new List<Customer>()
            {
        new Customer { Cus_Id = 1, Cus_Name = "Khách Hàng A", Address = "Hcm", Cus_Email ="ssss@gmail.com" ,Cus_PhoneNumber = "9999999999999"},
        new Customer { Cus_Id = 2, Cus_Name = "Lò Văn Việt", Address = "hhh", Cus_Email ="hhhh" ,Cus_PhoneNumber = "hhh"},
        new Customer {Cus_Id = 3, Cus_Name = "Vẹt Xanh", Address = "hhh", Cus_Email = "hhh", Cus_PhoneNumber = "hh"}
    };
            dgvCustomers.DataSource = cus;
        }

        private void RefreshGrid()
        {
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = cus;
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];

                txtId.Text = row.Cells["Cus_Id"].Value.ToString();
                txtName.Text = row.Cells["Cus_Name"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtPhoneNumber.Text = row.Cells["Cus_PhoneNumber"].Value.ToString();
                txtEmail.Text = row.Cells["Cus_Email"].Value.ToString();

                idoldcus = int.Parse(txtId.Text);

                MessageBox.Show("Đã chọn ID gốc = " + idoldcus);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);

            if (cus.Any(c => c.Cus_Id == id)) {
                MessageBox.Show("ID đã tồn tại, không thể thêm.");
                return;
            }

            Customer newCus = new Customer {
                Cus_Id = id,
                Cus_Name = txtName.Text,
                Address = txtAddress.Text,
                Cus_Email = txtEmail.Text,
                Cus_PhoneNumber = txtPhoneNumber.Text
            };

            cus.Add(newCus);
            RefreshGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txtId.Text);
            Customer cusUpdate = cus.FirstOrDefault(c => c.Cus_Id == id);

            if (cusUpdate == null) {
                MessageBox.Show("Không tìm thấy khách để cập nhật.");
                return;
            }

           
            cusUpdate.Cus_Name = txtName.Text;
            cusUpdate.Address = txtAddress.Text;
            cusUpdate.Cus_Email = txtEmail.Text;
            cusUpdate.Cus_PhoneNumber = txtPhoneNumber.Text;

            RefreshGrid();
            MessageBox.Show("Cập nhật thành công!");
        }



        public void Refresh()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var cusDelete = cus.FirstOrDefault(c => c.Cus_Id == id);

            if (cusDelete == null) {
                MessageBox.Show("Không tìm thấy khách để xóa.");
                return;
            }

            cus.Remove(cusDelete);
            RefreshGrid();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
   
            string keyword = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword)) {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!");
                return;
            }


            List<Customer> result = new List<Customer>();

   
            foreach (Customer c in cus) {
                string idStr = c.Cus_Id.ToString().ToLower();
                string nameStr = c.Cus_Name.ToLower();
                string phoneStr = c.Cus_PhoneNumber.ToLower();

                bool idMatch = idStr.Contains(keyword);
                bool nameMatch = nameStr.Contains(keyword);
                bool phoneMatch = phoneStr.Contains(keyword);

                if (idMatch || nameMatch || phoneMatch) {
                    result.Add(c);
                }
            }

            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = result;

            MessageBox.Show($"Tìm thấy {result.Count} kết quả.");
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = cus;
        }

        private void btnTransHis_Click(object sender, EventArgs e)
        {

        }
    }
}
