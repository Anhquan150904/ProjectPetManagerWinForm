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
        private List<Product> product = new List<Product>();
        private int oldProductId;
        public QuanLySanPham()
        {
            InitializeComponent();
            ThongTinSanPham_Load();
        }

        private void ThongTinSanPham_Load()
        {

            ID.DataPropertyName = "ID";
            product_Name.DataPropertyName = "product_Name";
            Quantity.DataPropertyName = "Quantity";
            Price.DataPropertyName = "Price";
            Country.DataPropertyName = "Country";
            Condition.DataPropertyName = "Condition";
            dvgProduct.AutoGenerateColumns = false;

            // Code khởi tạo form và load dữ liệu sanr phaamr

            product = new List<Product>()
            {
                   new Product { ID = 1, product_Name = "Sản phẩm A", Quantity = 10, Price =150000 ,Country = "USA", Condition = "New 100%"},
                    new Product { ID = 2, product_Name = "Sản phẩm B", Quantity = 10, Price =150000 ,Country = "USA", Condition = "New 100%"},
                    new Product { ID = 2, product_Name = "D E F", Quantity = 10, Price =150000 ,Country = "USA", Condition = "New 100%"},
            };
            dvgProduct.DataSource = product;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            var result = product.Where(c =>
                c.product_Name.ToLower().Contains(keyword) ||
                c.Country.ToLower().Contains(keyword)
            ).ToList();

            dvgProduct.DataSource = null;
            dvgProduct.DataSource = result;
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            dvgProduct.DataSource = null;
            dvgProduct.DataSource = product;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dvgProduct.Rows[e.RowIndex];

            txtId.Text = row.Cells["ID"].Value?.ToString();
            txtName.Text = row.Cells["product_Name"].Value?.ToString();
            txtQuantity.Text = row.Cells["Quantity"].Value?.ToString();

            txtCondition.Text = row.Cells["Condition"].Value?.ToString();
            txtCountry.Text = row.Cells["Country"].Value?.ToString();
            txtPrice.Text = row.Cells["Price"].Value?.ToString();

            oldProductId = Convert.ToInt32(row.Cells["ID"].Value);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newProduct = new Product
            {
                ID = int.Parse(txtId.Text),
                product_Name = txtName.Text,
                Price = decimal.Parse(txtPrice.Text),
                Quantity = int.Parse(txtQuantity.Text),
                Country = txtCountry.Text,
                Condition = txtCondition.Text,
            };

            product.Add(newProduct);
            ReloadGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var oldProduct = product.FirstOrDefault(p => p.ID == oldProductId);

            if (oldProduct != null)
                product.Remove(oldProduct);

            var newProduct = new Product
            {
                ID = int.Parse(txtId.Text),
                product_Name = txtName.Text,
                Price = decimal.Parse(txtPrice.Text),
                Quantity = int.Parse(txtQuantity.Text),
                Country = txtCountry.Text,
                Condition = txtCondition.Text,
            };

            product.Add(newProduct);
            ReloadGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var oldProduct = product.FirstOrDefault(p => p.ID == oldProductId);

            if (oldProduct != null)
                product.Remove(oldProduct);
            ReloadGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            txtId.Text = "";
            txtName.Text = "";
            txtQuantity.Text = "";

            txtCondition.Text = "";
            txtCountry.Text = "";
            txtPrice.Text = "";
        }
        private void ReloadGrid()
        {
            dvgProduct.DataSource = null;
            dvgProduct.DataSource = product;
        }
    }
}
