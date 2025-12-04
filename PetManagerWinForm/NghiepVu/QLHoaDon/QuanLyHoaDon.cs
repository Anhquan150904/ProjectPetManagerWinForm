using PetManagerData.Controllers;
using PetManagerData.Models;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic; // Cần cho List<InvoiceDetail>

namespace PetManagerWinForm.NghiepVu.QLHoaDon
{
    public partial class QuanLyHoaDon : Form
    {
        private InvoiceController _invoiceCtrl;
        private CustomerController _customerCtrl;
        private PetController _petCtrl;

        public QuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["PetDb"].ConnectionString;
                // Giả định InvoiceController đã tồn tại và có các phương thức cần thiết
                _invoiceCtrl = new InvoiceController(connStr);
                _customerCtrl = new CustomerController(connStr);
                _petCtrl = new PetController(connStr);

                LoadInvoices();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ====================== LOAD HÓA ĐƠN ======================
        private void LoadInvoices()
        {
            try
            {
                DataTable dt = _invoiceCtrl.GetInvoices();

                dgvInvoice.AutoGenerateColumns = false;
                dgvInvoice.DataSource = dt;

                // Đảm bảo DataPropertyName đã được gán trong Designer
                // colInvoiceId.DataPropertyName = "InvoiceId"; ...

                txtSearch.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ====================== CLICK ROW ======================
        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Đảm bảo chỉ số Row không vượt quá số lượng hàng
            if (e.RowIndex >= dgvInvoice.Rows.Count) return;

            DataGridViewRow row = dgvInvoice.Rows[e.RowIndex];

            txtInvoiceId.Text = row.Cells["colInvoiceId"].Value?.ToString() ?? "";
            txtCusId.Text = row.Cells["colCusId"].Value?.ToString() ?? "";
            txtTotal.Text = row.Cells["colTotal"].Value?.ToString() ?? "";
            txtCreatedAt.Text = row.Cells["colCreatedAt"].Value?.ToString() ?? "";
        }

        // ====================== SEARCH ======================
        private void btnSearch_Click(object sender, EventArgs e) // Đã bỏ chú thích
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm (VD: ID Hóa đơn, ID Khách hàng).", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Giả định InvoiceController có phương thức SearchInvoices
                // và trả về DataTable chứa kết quả tìm kiếm.
                //DataTable dt = _invoiceCtrl.SearchInvoices(keyword);
                //dgvInvoice.DataSource = dt;

                //if (dt.Rows.Count == 0)
                //{
                //    MessageBox.Show("Không tìm thấy kết quả nào.");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadInvoices();
        }

        // ====================== LÀM MỚI FORM CHI TIẾT ======================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtInvoiceId.Text = "";
            txtCusId.Text = "";
            txtTotal.Text = "";
            txtCreatedAt.Text = "";
            // Không làm mới lưới, chỉ làm mới form chi tiết
        }

        // ====================== XEM CHI TIẾT ======================
        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInvoiceId.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để xem chi tiết!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtInvoiceId.Text, out int invoiceId))
            {
                MessageBox.Show("ID Hóa đơn không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var invoice = _invoiceCtrl.GetInvoiceById(invoiceId);
                if (invoice == null)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                List<InvoiceDetail> details = _invoiceCtrl.GetInvoiceDetails(invoiceId);

                // Lấy thông tin Khách hàng
                var customer = _customerCtrl.GetCustomerById(invoice.Cus_Id);

                List<Pet> petsInDetail = new List<Pet>();
                // Đảm bảo bạn đang sử dụng kiểu dữ liệu PetModel (class model)

                foreach (var detail in details.Where(d => d.Type == "Pet"))
                {
                    // ItemId chính là PetId
                    DataTable petDt = _petCtrl.GetPetDetail(detail.ItemId);

                    if (petDt != null && petDt.Rows.Count > 0)
                    {
                        // Lấy hàng đầu tiên (vì GetPetDetail chỉ trả về 1 Pet)
                        DataRow row = petDt.Rows[0];

                        // Khởi tạo PetModel từ DataRow và thêm vào danh sách
                        Pet pet = new Pet
                        {
                            PetId = Convert.ToInt32(row["PetId"]),
                            PetName = row["PetName"].ToString(),
                            Age = Convert.ToInt32(row["Age"]),
                            Type = row["Type"].ToString()
                            // Thêm các thuộc tính khác nếu cần
                        };
                        petsInDetail.Add(pet);
                    }
                }


                // 1. Khởi tạo form chi tiết (bạn phải tự thiết kế form này)
                FrmInvoiceDetail detailForm = new FrmInvoiceDetail();

                // 2. Truyền dữ liệu sang form chi tiết
                detailForm.SetInvoiceData(invoice, customer, details, petsInDetail);

                // 3. Hiển thị form
                detailForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xem chi tiết hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }
}