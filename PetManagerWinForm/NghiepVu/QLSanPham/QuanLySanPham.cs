using PetManagerData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetManagerWinForm.NghiepVu.QLSanPham
{
    public partial class QuanLySanPham : Form
    {
        public QuanLySanPham()
        {
            InitializeComponent();
        }

        private void ThongTinSanPham_Load()
        {
            // Code khởi tạo form và load dữ liệu khách hàng
            var product = new List<Product>()
            {
                   
            };
            dvgProduct.DataSource = product;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
