using PetManagerData.Controllers; // Nhớ using Controller
using PetManagerData.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PetManagerWinForm.NghiepVu.QLSanPham
{
    public partial class QuanLySanPham : Form
    {
        // 1. Khai báo Controller
        private ProductController2 _controller;

        // Thay chuỗi kết nối của bạn vào đây
        string strConnect = ConfigurationManager.ConnectionStrings["PetDb"].ConnectionString;

        public QuanLySanPham()
        {
            InitializeComponent();

            // 2. Khởi tạo Controller
            _controller = new ProductController2(strConnect);

            LoadSanPham();
        }

        private void LoadSanPham()
        {
            // Cấu hình DataPropertyName để map dữ liệu từ DataTable vào DataGridView
            colId.DataPropertyName = "ID";
            colName.DataPropertyName = "Product_Name";
            colQuantity.DataPropertyName = "Quantity";
            colPrice.DataPropertyName = "Price";
            colCountry.DataPropertyName = "Country";
            colCondition.DataPropertyName = "Condition";

            dgvProduct.AutoGenerateColumns = false;

            // 3. Gọi dữ liệu từ Database thông qua Controller
            try
            {
                DataTable dt = _controller.GetAllProducts();
                dgvProduct.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // ------------------- CLICK ROW -------------------------
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Lấy dòng hiện tại
            // Lưu ý: Khi dùng DataSource là DataTable, DataBoundItem là DataRowView
            DataGridViewRow row = dgvProduct.Rows[e.RowIndex];

            txtId.Text = row.Cells["colId"].Value?.ToString();
            txtName.Text = row.Cells["colName"].Value?.ToString();
            txtQuantity.Text = row.Cells["colQuantity"].Value?.ToString();
            txtPrice.Text = row.Cells["colPrice"].Value?.ToString();
            txtCountry.Text = row.Cells["colCountry"].Value?.ToString();
            txtCondition.Text = row.Cells["colCondition"].Value?.ToString();
        }

        // ------------------- ADD -------------------------
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var newProduct = new Product
                {
                    // ID thường tự tăng trong DB nên không cần truyền vào khi thêm mới
                    // Nếu DB không tự tăng thì mới cần: ID = int.Parse(txtId.Text),
                    product_Name = txtName.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Country = txtCountry.Text,
                    Condition = txtCondition.Text,
                };

                if (_controller.AddProduct(newProduct))
                {
                    MessageBox.Show("Thêm thành công!");
                    LoadSanPham(); // Tải lại lưới
                    btnRefresh_Click(null, null); // Xóa trắng ô nhập
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập liệu: " + ex.Message);
            }
        }

        // ------------------- UPDATE -------------------------
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text)) return;

            try
            {
                var updatedProduct = new Product
                {
                    ID = int.Parse(txtId.Text), // Cần ID để biết sửa dòng nào
                    product_Name = txtName.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Country = txtCountry.Text,
                    Condition = txtCondition.Text,
                };

                if (_controller.UpdateProduct(updatedProduct))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadSanPham();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // ------------------- DELETE -------------------------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = int.Parse(txtId.Text);
                if (_controller.DeleteProduct(id))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadSanPham();
                    btnRefresh_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        // ------------------- SEARCH ---------------------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            DataTable dt = _controller.SearchProducts(keyword);
            dgvProduct.DataSource = dt;
        }

        // ------------------- SHOW ALL --------------------------
        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            LoadSanPham();
        }

        // ------------------- REFRESH TEXTBOX -------------------
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtCountry.Text = "";
            txtCondition.Text = "";
            txtSearch.Text = "";
        }
    }
}