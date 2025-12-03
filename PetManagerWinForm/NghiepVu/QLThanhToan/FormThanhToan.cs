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



            LoadCustomers();

            LoadProducts();

            LoadServices();

            LoadPets();

            RefreshCart();

        }



        #region Load dữ liệu



        private void LoadCustomers()

        {

            try

            {

                // Giả định CustomerController có phương thức GetAllCustomers()

                _dtCustomers = _customerCtrl.GetAllCustomers();

                cbCustomers.DataSource = _dtCustomers;

                cbCustomers.DisplayMember = "Cus_Name";

                cbCustomers.ValueMember = "Cus_Id";

            }

            catch (Exception ex)

            {

                MessageBox.Show("Lỗi tải danh sách khách hàng: " + ex.Message);

            }

        }



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



            // Lấy giá từ DataTable

            DataRow[] rows = _dtProducts.Select($"ID={id}");

            if (rows.Length == 0) return;

            decimal price = Convert.ToDecimal(rows[0]["Price"]);





            _cart.Add(new InvoiceDetailItem

            {

                ItemId = id,

                Name = name,

                Type = "Product",

                Quantity = qty,

                Price = price

            });

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

            if (cbCustomers.SelectedValue == null)

            {

                MessageBox.Show("Vui lòng chọn khách hàng");

                return;

            }

            if (_cart.Count == 0)

            {

                MessageBox.Show("Giỏ hàng trống");

                return;

            }



            int cusId = (int)cbCustomers.SelectedValue;

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



                // Xóa trường nhập liệu khách hàng mới (nếu có)

                // txtCusName.Text = txtAddress.Text = txtPhone.Text = txtEmail.Text = string.Empty;

            }

            catch (Exception ex)

            {

                MessageBox.Show("Lỗi trong quá trình thanh toán: " + ex.Message, "Lỗi Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        #endregion



        #region Thêm khách hàng mới

        private void btnAddCustomer_Click(object sender, EventArgs e)

        {

            if (string.IsNullOrWhiteSpace(txtCusName.Text))

            {

                MessageBox.Show("Tên khách hàng không được để trống");

                return;

            }

            var cus = new Customer

            {

                Cus_Name = txtCusName.Text,

                Address = txtAddress.Text,

                Cus_PhoneNumber = txtPhone.Text,

                Cus_Email = txtEmail.Text

            };

            try

            {

                // Giả định AddCustomer trả về ID mới

                int newId = _customerCtrl.AddCustomer(cus);

                LoadCustomers();

                cbCustomers.SelectedValue = newId;



                // Xóa trường nhập liệu sau khi thêm

                txtCusName.Text = txtAddress.Text = txtPhone.Text = txtEmail.Text = string.Empty;

            }

            catch (Exception ex)

            {

                MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message);

            }

        }

        #endregion

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