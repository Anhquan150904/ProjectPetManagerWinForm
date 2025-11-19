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
            ThongTinKhachHang_Load();
        }

        private List<Customer> cus = new List<Customer>();
        private int idoldcus;
        private void ThongTinKhachHang_Load()
        {
            // Code khởi tạo form và load dữ liệu khách hàng
            cus = new List<Customer>()
            {
                        new Customer { Cus_Id = 1, Cus_Name = "Khách Hàng A", Address = "Hcm", Cus_Email ="ssss@gmail.com" ,Cus_PhoneNumber = "9999999999999"},
                        new Customer { Cus_Id = 2, Cus_Name = "Cún Vàng", Address = "hhh", Cus_Email ="hhhh" ,Cus_PhoneNumber = "hhh"},
                        new Customer {Cus_Id = 3, Cus_Name = "Vẹt Xanh", Address = "hhh", Cus_Email = "hhh", Cus_PhoneNumber = "hh"}
            };
            dgvCustomers.DataSource = cus;
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // lấy cus được chọn rồi gán text cho nó 

            // Không xử lý khi click vào header
            if (e.RowIndex < 0) return;

            // Lấy hàng hiện tại
            DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];

            // Gán dữ liệu lên textbox
            txtId.Text = row.Cells["Cus_Id"].Value?.ToString();
            txtName.Text = row.Cells["Cus_Name"].Value?.ToString();
            txtAddress.Text = row.Cells["Address"].Value?.ToString();
            txtEmail.Text = row.Cells["Cus_Email"].Value?.ToString();
            txtPhoneNumber.Text = row.Cells["Cus_PhoneNumber"].Value?.ToString();

            idoldcus = Convert.ToInt32(row.Cells["Cus_Id"].Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer newCus = new Customer
            {
                Cus_Id = int.Parse(txtId.Text),
                Cus_Name = txtName.Text,
                Address = txtAddress.Text,
                Cus_Email = txtEmail.Text,
                Cus_PhoneNumber = txtPhoneNumber.Text
            };
            cus.Add(newCus);
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = cus;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Code cập nhật khách hàng
            Customer newCus = new Customer
            {
                Cus_Id = int.Parse(txtId.Text),
                Cus_Name = txtName.Text,
                Address = txtAddress.Text,
                Cus_Email = txtEmail.Text,
                Cus_PhoneNumber = txtPhoneNumber.Text
            };
            cus.Add(newCus);
            var cusDelete = cus.FirstOrDefault(c => c.Cus_Id == idoldcus);            
            cus.Remove(cusDelete);
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = cus;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);

            // Tìm customer cần xóa
            var cusDelete = cus.FirstOrDefault(c => c.Cus_Id == id);

            cus.Remove(cusDelete);

            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = cus;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            // foreach()
        }
    }
}
