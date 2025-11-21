using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Windows.Forms;
using PetManagerData.Models;

namespace PetManagerWinForm.NghiepVu.QLHoaDon
{
    public partial class QuanLyHoaDon : Form
    {
        public QuanLyHoaDon()
        {
            InitializeComponent();
            QuanLyHoaDon_Load();
        }

        private List<Invoice> invoices = new List<Invoice>();
        private int oldInvoiceId;

        private void QuanLyHoaDon_Load()
        {
            ID.DataPropertyName = "ID";
            Cus_ID.DataPropertyName = "Cus_ID";
            Product_Service_Name.DataPropertyName = "Product_Service_Name";
            Quantity.DataPropertyName = "Quantity";
            Price.DataPropertyName = "Price";
            TotalPrice.DataPropertyName = "TotalPrice";
            Time_to_create.DataPropertyName = "Time_to_create";
            dataGridView1.AutoGenerateColumns = false;
            invoices = new List<Invoice>()
            {
                new Invoice { ID = 1, Cus_ID = 101, Product_Service_Name = "Tắm spa cho chó", Quantity = 1, Price = 150000, TotalPrice = 150000, Time_to_create = "2024-11-21" },
                new Invoice { ID = 2, Cus_ID = 102, Product_Service_Name = "Mua hạt Royal Canin", Quantity = 2, Price = 120000, TotalPrice = 240000, Time_to_create = "2024-11-22" },
                new Invoice { ID = 3, Cus_ID = 103, Product_Service_Name = "Cắt tỉa lông", Quantity = 1, Price = 200000, TotalPrice = 200000, Time_to_create = "2024-11-23" },
            };

            dataGridView1.DataSource = invoices;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            txtId.Text = row.Cells["ID"].Value.ToString();
            txtCusID.Text = row.Cells["Cus_ID"].Value.ToString();
            txtProductServiceName.Text = row.Cells["Product_Service_Name"].Value.ToString();
            txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
            txtPrice.Text = row.Cells["Price"].Value.ToString();
            txtTotalPrice.Text = row.Cells["TotalPrice"].Value.ToString();
            txtTimeToCreated.Text = row.Cells["Time_to_create"].Value.ToString();

            oldInvoiceId = Convert.ToInt32(row.Cells["ID"].Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Invoice newInv = new Invoice
            {
                ID = int.Parse(txtId.Text),
                Cus_ID = int.Parse(txtCusID.Text),
                Product_Service_Name = txtProductServiceName.Text,
                Quantity = int.Parse(txtQuantity.Text),
                Price = decimal.Parse(txtPrice.Text),
                TotalPrice = decimal.Parse(txtTotalPrice.Text),
                Time_to_create = txtTimeToCreated.Text
            };

            invoices.Add(newInv);

            ReloadGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Invoice updated = new Invoice
            {
                ID = int.Parse(txtId.Text),
                Cus_ID = int.Parse(txtCusID.Text),
                Product_Service_Name = txtProductServiceName.Text,
                Quantity = int.Parse(txtQuantity.Text),
                Price = decimal.Parse(txtPrice.Text),
                TotalPrice = decimal.Parse(txtTotalPrice.Text),
                Time_to_create = txtTimeToCreated.Text
            };

            invoices.Add(updated);

            var old = invoices.FirstOrDefault(i => i.ID == oldInvoiceId);
            if (old != null)
                invoices.Remove(old);

            ReloadGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);

            var del = invoices.FirstOrDefault(i => i.ID == id);
            if (del != null)
                invoices.Remove(del);

            ReloadGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();

            var result = invoices.Where(i =>
                i.ID.ToString().Contains(keyword) ||
                i.Cus_ID.ToString().Contains(keyword) ||
                i.Product_Service_Name.ToLower().Contains(keyword)
            ).ToList();

            dataGridView1.DataSource = result;
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            ReloadGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtCusID.Clear();
            txtProductServiceName.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            txtTotalPrice.Clear();
            txtTimeToCreated.Clear();
            txtSearch.Clear();
        }

        private void ReloadGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = invoices;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn!", "Thông báo");
                return;
            }

            // Hard-code thông tin khách hàng
            string customerName = "Nguyễn Văn A";
            string customerPhone = "0901234567";
            string customerAddress = "123 đường ABC, Hà Nội";
            string customerEmail = "vana@example.com";

            // Hard-code thời gian tạo hóa đơn
            string createdAt = txtTimeToCreated.Text;

            InvoiceDetail detail = new InvoiceDetail
            {
                ID = int.Parse(txtId.Text),
                product_Name = txtProductServiceName.Text,
                Quantity = int.Parse(txtQuantity.Text),
                Price = decimal.Parse(txtPrice.Text),
                Country = "Việt Nam",
                Condition = "New"
            };

            // Thành tiền = Số lượng * Đơn giá
            decimal totalAmount = detail.Quantity * detail.Price;

            string customerInfo =
                $"--- Thông tin khách hàng ---\n" +
                $"Tên KH: {customerName}\n" +
                $"SĐT: {customerPhone}\n" +
                $"Địa chỉ: {customerAddress}\n" +
                $"Email: {customerEmail}\n\n";

            string invoiceInfo =
                $"--- Thông tin hóa đơn ---\n" +
                $"ID: {detail.ID}\n" +
                $"Tên SP/DV: {detail.product_Name}\n" +
                $"Số lượng: {detail.Quantity}\n" +
                $"Đơn giá: {detail.Price:N0} VNĐ\n" +
                $"Thành tiền: {totalAmount:N0} VNĐ\n" +
                $"Thời gian tạo: {createdAt}\n" +
                $"Quốc gia: {detail.Country}\n" +
                $"Tình trạng: {detail.Condition}";

            MessageBox.Show(customerInfo + invoiceInfo, "Invoice Detail");
        }

    }
}
