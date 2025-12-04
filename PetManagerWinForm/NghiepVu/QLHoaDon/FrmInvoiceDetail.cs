using PetManagerData.Models; // Cần các Model: InvoiceModel, CustomerModel, PetModel, InvoiceDetail
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System;

namespace PetManagerWinForm.NghiepVu.QLHoaDon
{
    public partial class FrmInvoiceDetail : Form
    {
        public FrmInvoiceDetail()
        {
            InitializeComponent();
        }

        /**
         * Phương thức chính để nhận và thiết lập dữ liệu cho form
         */
        public void SetInvoiceData(Invoice invoice, Customer customer, List<InvoiceDetail> details, List<Pet> pets)
        {
            // === 1. Thông tin Tóm tắt Hóa đơn ===
            lblInvoiceId.Text = $"ID HĐ: #{invoice.InvoiceId}";
            lblDate.Text = $"Ngày tạo: {invoice.CreatedAt:dd/MM/yyyy HH:mm}";
            lblTotal.Text = $"Tổng cộng: {invoice.Total:N0} VNĐ";

            // === 2. Thông tin Khách hàng ===
            if (customer != null)
            {
                lblCusName.Text = $"Tên: {customer.Cus_Name}";
                lblCusPhone.Text = $"SĐT: {customer.Cus_PhoneNumber}";
                lblCusEmail.Text = $"Email: {customer.Cus_Email}";
                lblCusAddress.Text = $"Địa chỉ: {customer.Address}";
            }
            else
            {
                lblCusName.Text = "Tên: KH Lẻ/Ẩn danh";
                lblCusPhone.Text = "SĐT: N/A";
                lblCusEmail.Text = "Email: N/A";
                lblCusAddress.Text = "Địa chỉ: N/A";
            }

            // === 3. Chi tiết Hóa đơn (DataGridView) ===
            var detailView = details.Select(d => new
            {
                Loai = d.Type,
                TenItem = d.Type == "Pet" ? pets.FirstOrDefault(p => p.PetId == d.ItemId)?.PetName ?? "Thú Cưng Bán" : d.Type,
                SL = d.Quantity,
                DonGia = d.Price.ToString("N0"),
                ThanhTien = (d.Quantity * d.Price).ToString("N0")
                // Không hiển thị Status trong lưới này để đơn giản
            }).ToList();

            dgvDetails.DataSource = detailView;

            // === 4. Chi tiết Thú cưng (FlowLayoutPanel) ===
            pnlPetContainer.Controls.Clear();
            if (pets.Any())
            {
                int petCount = 1;
                foreach (var pet in pets)
                {
                    Label lbl = new Label()
                    {
                        Text = $"({petCount}) Tên: {pet.PetName}, Giống: {pet.Type}, Tuổi: {pet.Age} năm",
                        AutoSize = true,
                        Font = new Font("Segoe UI", 9F, FontStyle.Italic)
                    };
                    pnlPetContainer.Controls.Add(lbl);
                    petCount++;
                }
            }
            else
            {
                Label lbl = new Label()
                {
                    Text = "Không có thú cưng nào được bán trong hóa đơn này.",
                    AutoSize = true
                };
                pnlPetContainer.Controls.Add(lbl);
            }
        }
    }
}