using PetManagerData.Controllers;
using PetManagerData.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PetManagerWinForm.NghiepVu
{
    public partial class FrmThanhToan : Form
    {
        private CustomerController _customerCtrl;
        private ProductController _productCtrl;
        private ServiceController2 _serviceCtrl;
        private InvoiceController _invoiceCtrl;
        private PetController _petCtrl;

        private DataTable _dtCustomers, _dtProducts, _dtServices, _dtPets;
        private List<InvoiceDetailItem> _cart;

        // NEW: lưu ID khách hàng hiện tại (đã tìm hoặc vừa thêm)
        private int _currentCustomerId = 0;

        public FrmThanhToan()
        {
            InitializeComponent();
        }

        private void FrmThanhToan_Load(object sender, EventArgs e)
        {
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["PetDb"].ConnectionString;
            _customerCtrl = new CustomerController(connStr);
            _productCtrl = new ProductController(connStr);
            _serviceCtrl = new ServiceController2(connStr);
            _invoiceCtrl = new InvoiceController(connStr);
            _petCtrl = new PetController(connStr);

            _cart = new List<InvoiceDetailItem>();

            // Lưu ý: vẫn tải ds khách để fallback nếu controller không có GetCustomerByPhone
            //LoadCustomers();
            LoadProducts();
            LoadServices();
            LoadPets();
            RefreshCart();

            // Tùy: bạn có thể disable cbCustomers trong designer hoặc ẩn nó (nếu đã remove trong designer thì ko cần)
            // cbCustomers.Visible = false;
        }

        #region Load dữ liệu

        //private void LoadCustomers()
        //{
        //    try
        //    {
        //        // Giả định CustomerController có phương thức GetAllCustomers()
        //        _dtCustomers = _customerCtrl.GetAllCustomers();
        //        // Nếu bạn đã xóa cbCustomers trên giao diện thì bỏ qua phần binding này
        //        if (cbCustomers != null)
        //        {
        //            cbCustomers.DataSource = _dtCustomers;
        //            cbCustomers.DisplayMember = "Cus_Name";
        //            cbCustomers.ValueMember = "Cus_Id";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi tải danh sách khách hàng: " + ex.Message);
        //    }
        //}

        private void LoadProducts()
        {
            try
            {
                // Giả định ProductController có phương thức GetAll()
                _dtProducts = _productCtrl.GetAll();
                cbProducts.DataSource = _dtProducts;
                cbProducts.DisplayMember = "Product_Name"; // Đã sửa tên cột Products
                cbProducts.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách sản phẩm: " + ex.Message);
            }
        }

        private void LoadServices()
        {
            try
            {
                // Giả định ServiceController2 có phương thức GetAll()
                _dtServices = _serviceCtrl.GetAll();
                cbServices.DataSource = _dtServices;
                cbServices.DisplayMember = "ServiceName";
                cbServices.ValueMember = "ServiceId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách dịch vụ: " + ex.Message);
            }
        }

        private void LoadPets()
        {
            try
            {
                // Gọi PetController để lấy Pet chưa bán
                // Giả định PetController có phương thức GetPetsNotSold()
                _dtPets = _petCtrl.GetPetsNotSold();
                cbPets.DataSource = _dtPets;
                cbPets.DisplayMember = "PetName";
                cbPets.ValueMember = "PetId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thú cưng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Giỏ hàng
        private void RefreshCart()
        {
            dgvCart.DataSource = null;
            dgvCart.DataSource = _cart.Select(x => new
            {
                x.ItemId,
                x.Name,
                x.Type,
                x.Quantity,
                x.Price,
                x.Total
            }).ToList();

            txtTotal.Text = _cart.Sum(x => x.Total).ToString("N0");
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (cbProducts.SelectedValue == null) return;

            int id = (int)cbProducts.SelectedValue;
            string name = cbProducts.Text;
            int qty = (int)nudProductQty.Value;

            // Lấy dữ liệu sản phẩm từ DataTable
            DataRow[] rows = _dtProducts.Select($"ID={id}");
            if (rows.Length == 0) return;

            decimal price = Convert.ToDecimal(rows[0]["Price"]);
            int stock = Convert.ToInt32(rows[0]["Quantity"]); // tồn kho

            // Lấy số lượng đang có trong giỏ với sản phẩm này
            int qtyInCart = _cart
                .Where(x => x.ItemId == id && x.Type == "Product")
                .Sum(x => x.Quantity);

            // Tổng sau khi muốn thêm
            int totalAfterAdd = qtyInCart + qty;

            if (totalAfterAdd > stock)
            {
                MessageBox.Show(
                    $"Số lượng sản phẩm trong kho không đủ!\n" +
                    $"Trong kho còn lại: {stock}\n",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Nếu sản phẩm đã tồn tại trong giỏ → cộng dồn số lượng
            var existing = _cart.FirstOrDefault(
                x => x.ItemId == id && x.Type == "Product"
            );

            if (existing != null)
            {
                existing.Quantity += qty;
            }
            else
            {
                // Chưa có, thêm mới
                _cart.Add(new InvoiceDetailItem
                {
                    ItemId = id,
                    Name = name,
                    Type = "Product",
                    Quantity = qty,
                    Price = price
                });
            }

            RefreshCart();
        }


        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (cbServices.SelectedValue == null) return;

            int id = (int)cbServices.SelectedValue;
            string name = cbServices.Text;
            int qty = (int)nudServiceQty.Value;

            // Lấy giá từ DataTable
            DataRow[] rows = _dtServices.Select($"ServiceId={id}");
            if (rows.Length == 0) return;
            decimal price = Convert.ToDecimal(rows[0]["Price"]);

            _cart.Add(new InvoiceDetailItem
            {
                ItemId = id,
                Name = name,
                Type = "Service",
                Quantity = qty,
                Price = price
            });
            RefreshCart();
        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            if (cbPets.SelectedValue == null) return;

            int id = (int)cbPets.SelectedValue;
            string name = cbPets.Text;
            int qty = 1; // Pet luôn có Quantity = 1

            DataRow[] rows = _dtPets.Select($"PetId={id}");
            if (rows.Length == 0) return;
            decimal price = Convert.ToDecimal(rows[0]["Price"]);

            // Kiểm tra xem Pet đã có trong giỏ hàng chưa (Pet chỉ được bán 1 lần)
            if (_cart.Any(item => item.ItemId == id && item.Type == "Pet"))
            {
                MessageBox.Show("Thú cưng này đã có trong giỏ hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _cart.Add(new InvoiceDetailItem
            {
                ItemId = id,
                Name = name,
                Type = "Pet",
                Quantity = qty,
                Price = price
            });
            RefreshCart();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow != null)
            {
                int itemId = Convert.ToInt32(dgvCart.CurrentRow.Cells["ItemId"].Value);
                string type = dgvCart.CurrentRow.Cells["Type"].Value.ToString();
                var item = _cart.FirstOrDefault(x => x.ItemId == itemId && x.Type == type);
                if (item != null)
                {
                    _cart.Remove(item);
                    RefreshCart();
                }
            }
        }
        #endregion

        #region Thanh toán
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // NOW: require _currentCustomerId instead of cbCustomers.SelectedValue
            if (_currentCustomerId == 0)
            {
                MessageBox.Show("Vui lòng tìm hoặc thêm khách hàng trước khi thanh toán.");
                return;
            }

            if (_cart.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống");
                return;
            }

            int cusId = _currentCustomerId;
            decimal total = _cart.Sum(x => x.Total);

            try
            {
                // Xử lý tạo Invoice
                int invoiceId = _invoiceCtrl.CreateInvoice(cusId, total);
                foreach (var item in _cart)
                {
                    _invoiceCtrl.AddInvoiceDetail(invoiceId, item.ItemId, item.Type, item.Quantity, item.Price);
                    // Nếu là Pet: mark as sold
                    if (item.Type == "Pet")
                    {
                        _petCtrl.ReturnMarkAsSold(item.ItemId); // Dùng PetController
                    }
                }

                MessageBox.Show("Thanh toán thành công!");
                _cart.Clear();
                RefreshCart();
                LoadProducts();
                LoadServices();
                LoadPets(); // Tải lại danh sách Pet (để loại bỏ Pet vừa bán)

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình thanh toán: " + ex.Message, "Lỗi Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Tìm / Thêm khách hàng bằng SĐT
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại để tìm hoặc thêm khách hàng.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            try
            {
                // 1) Thử gọi Controller GetCustomerByPhone nếu có
                Customer found = null;
                try
                {
                    // Nếu CustomerController triển khai GetCustomerByPhone
                    found = _customerCtrl.GetCustomerByPhone(phone);
                }
                catch
                {
                    // ignore - fallback xuống tìm trong _dtCustomers
                    found = null;
                }

                // 2) Fallback: nếu controller không có, tìm trong _dtCustomers nếu đã load
                if (found == null && _dtCustomers != null)
                {
                    DataRow[] rows = _dtCustomers.Select($"Cus_PhoneNumber = '{EscapeForSelect(phone)}'");
                    if (rows.Length > 0)
                    {
                        DataRow r = rows[0];
                        found = new Customer
                        {
                            Cus_Id = Convert.ToInt32(r["Cus_Id"]),
                            Cus_Name = r["Cus_Name"].ToString(),
                            Address = r["Address"].ToString(),
                            Cus_PhoneNumber = r["Cus_PhoneNumber"].ToString(),
                            Cus_Email = r["Cus_Email"].ToString()
                        };
                    }
                }

                if (found != null)
                {
                    // Nếu tìm thấy -> fill lên form và lưu _currentCustomerId
                    _currentCustomerId = found.Cus_Id;

                    txtCusName.Text = found.Cus_Name;
                    txtAddress.Text = found.Address;
                    txtEmail.Text = found.Cus_Email;

                    // Disable edit nếu bạn muốn
                    txtCusName.Enabled = false;
                    txtAddress.Enabled = false;
                    txtEmail.Enabled = false;

                    MessageBox.Show("Đã tìm thấy khách hàng trong hệ thống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Nếu không tìm thấy, yêu cầu nhập tên để thêm mới
                if (string.IsNullOrWhiteSpace(txtCusName.Text))
                {
                    MessageBox.Show("Không tìm thấy khách hàng. Vui lòng nhập tên (và có thể địa chỉ/email) để thêm mới.", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCusName.Enabled = true;
                    txtAddress.Enabled = true;
                    txtEmail.Enabled = true;
                    txtCusName.Focus();
                    return;
                }

                // Thêm KH mới
                var newCus = new Customer
                {
                    Cus_Name = txtCusName.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    Cus_PhoneNumber = phone,
                    Cus_Email = txtEmail.Text.Trim()
                };

                int newId = _customerCtrl.AddCustomer(newCus); // giả định trả về ID mới
                if (newId > 0)
                {
                    _currentCustomerId = newId;

                    // Refresh danh sách khách hàng nội bộ
                    //LoadCustomers();

                    MessageBox.Show("Thêm khách hàng thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Disable edit nếu muốn
                    txtCusName.Enabled = false;
                    txtAddress.Enabled = false;
                    txtEmail.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Không thể thêm khách hàng. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm/thêm khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // helper: escape đơn giản cho DataTable.Select string (đổi ' thành '' để tránh lỗi)
        private string EscapeForSelect(string input)
        {
            return input.Replace("'", "''");
        }
        #endregion

        private void btnSearchCus_Click(object sender, EventArgs e)
        {

        }
    }

    public class InvoiceDetailItem
    {
        public int ItemId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total => Quantity * Price;
    }
}
