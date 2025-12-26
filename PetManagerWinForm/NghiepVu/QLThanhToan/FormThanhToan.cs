using Microsoft.Data.SqlClient;
using PetManagerData.Controllers;
using PetManagerData.DataAccess;
using PetManagerData.Models;
using PetManagerWinForm.NghiepVu.QLKhachHang;
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
        // selected pet for using service
        private int _selectedPetId = 0;
        private string _selectedPetName = string.Empty;

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

        // handler for choose pet button -> show popup with pets of current customer
        private void btnChoosePet_Click(object sender, EventArgs e)
        {
            if (_currentCustomerId == 0)
            {
                MessageBox.Show("Vui lòng tìm hoặc chọn khách hàng trước khi chọn thú cưng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var frm = new Form())
            {
                // Form styling - TĂNG SIZE
                frm.Text = "Chọn Thú Cưng";
                frm.Size = new Size(1076, 500);
                frm.FormBorderStyle = FormBorderStyle.FixedDialog;
                frm.MaximizeBox = false;
                frm.MinimizeBox = false;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.BackColor = Color.FromArgb(240, 244, 248);

                // Header panel
                var pnlHeader = new Panel
                {
                    Dock = DockStyle.Top,
                    Height = 60,
                    BackColor = Color.FromArgb(59, 130, 246),
                    Padding = new Padding(20, 15, 20, 15)
                };

                var lblTitle = new Label
                {
                    Text = "🐾 Danh sách thú cưng",
                    Font = new Font("Segoe UI", 14, FontStyle.Bold),
                    ForeColor = Color.White,
                    AutoSize = true,
                    Location = new Point(20, 10)
                };

                var lblSubtitle = new Label
                {
                    Text = $"Khách hàng ID: {_currentCustomerId}",
                    Font = new Font("Segoe UI", 9),
                    ForeColor = Color.FromArgb(220, 230, 255),
                    AutoSize = true,
                    Location = new Point(20, 35)
                };

                pnlHeader.Controls.Add(lblTitle);
                pnlHeader.Controls.Add(lblSubtitle);

                // DataGridView container panel
                var pnlGrid = new Panel
                {
                    Dock = DockStyle.Fill,
                    Padding = new Padding(20, 15, 20, 15),
                    BackColor = Color.FromArgb(240, 244, 248)
                };

                // DataGridView styling
                var dgv = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    ReadOnly = true,
                    SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None, // ← ĐỔI THÀNH None
                    AllowUserToAddRows = false,
                    AllowUserToDeleteRows = false,
                    AllowUserToResizeRows = false,
                    AllowUserToResizeColumns = true, // ← CHO PHÉP RESIZE CỘT
                    RowHeadersVisible = false,
                    BackgroundColor = Color.White,
                    BorderStyle = BorderStyle.None,
                    CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
                    ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None,
                    GridColor = Color.FromArgb(230, 230, 230),
                    AutoGenerateColumns = false, // ← QUAN TRỌNG: Tắt tự động tạo cột

                    // Header styling
                    EnableHeadersVisualStyles = false,
                    ColumnHeadersHeight = 40,
                    ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing,

                    // Row styling
                    RowTemplate = { Height = 45 },

                    // Selection colors
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Font = new Font("Segoe UI", 10),
                        ForeColor = Color.FromArgb(51, 51, 51),
                        BackColor = Color.White,
                        SelectionBackColor = Color.FromArgb(219, 234, 254),
                        SelectionForeColor = Color.FromArgb(30, 64, 175),
                        Padding = new Padding(10, 5, 10, 5)
                    },

                    ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                    {
                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                        ForeColor = Color.FromArgb(71, 85, 105),
                        BackColor = Color.FromArgb(248, 250, 252),
                        SelectionBackColor = Color.FromArgb(248, 250, 252),
                        Padding = new Padding(10, 5, 10, 5)
                    },

                    AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
                    {
                        BackColor = Color.FromArgb(249, 250, 251)
                    }
                };

                // Tạo các cột thủ công với WIDTH CỐ ĐỊNH
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Pet_Id",
                    DataPropertyName = "Pet_Id",
                    HeaderText = "Mã số",
                    Width = 80,
                    DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
                });

                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Pet_Name",
                    DataPropertyName = "Pet_Name",
                    HeaderText = "Tên thú cưng",
                    Width = 200,
                    DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleLeft }
                });

                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Pet_Breed",
                    DataPropertyName = "Pet_Breed",
                    HeaderText = "Giống loài",
                    Width = 180,
                    DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleLeft }
                });

                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Pet_Age",
                    DataPropertyName = "Pet_Age",
                    HeaderText = "Tuổi",
                    Width = 80,
                    DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
                });

                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "ServiceUsed",
                    DataPropertyName = "ServiceUsed",
                    HeaderText = "Dịch vụ đã dùng",
                    Width = 280,
                    DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleLeft }
                });

                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Cus_Name",
                    DataPropertyName = "Cus_Name",
                    HeaderText = "Tên chủ nhân",
                    Width = 200,
                    DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleLeft }
                });

                try
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PetDb"].ConnectionString;
                    var petRepo = new PetCusRepository(connStr);
                    var dt = petRepo.GetPetsByCustomerId(_currentCustomerId);
                    dgv.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải thú cưng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                pnlGrid.Controls.Add(dgv);

                // Button panel
                var pnlButtons = new Panel
                {
                    Dock = DockStyle.Bottom,
                    Height = 70,
                    BackColor = Color.White,
                    Padding = new Padding(20, 15, 20, 15)
                };

                var btnOk = new Button
                {
                    Text = "✓ Chọn thú cưng này",
                    Width = 160,
                    Height = 40,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(34, 197, 94),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Cursor = Cursors.Hand,
                    Location = new Point(pnlButtons.Width - 180, 15)
                };
                btnOk.FlatAppearance.BorderSize = 0;

                var btnCancel = new Button
                {
                    Text = "Hủy",
                    Width = 100,
                    Height = 40,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(226, 232, 240),
                    ForeColor = Color.FromArgb(71, 85, 105),
                    Font = new Font("Segoe UI", 10),
                    Cursor = Cursors.Hand,
                    Location = new Point(pnlButtons.Width - 300, 15)
                };
                btnCancel.FlatAppearance.BorderSize = 0;

                // Button hover effects
                btnOk.MouseEnter += (s, ev) => btnOk.BackColor = Color.FromArgb(22, 163, 74);
                btnOk.MouseLeave += (s, ev) => btnOk.BackColor = Color.FromArgb(34, 197, 94);

                btnCancel.MouseEnter += (s, ev) => btnCancel.BackColor = Color.FromArgb(203, 213, 225);
                btnCancel.MouseLeave += (s, ev) => btnCancel.BackColor = Color.FromArgb(226, 232, 240);

                // Button click events
                btnOk.Click += (s, ev) =>
                {
                    if (dgv.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Vui lòng chọn một thú cưng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    var row = (DataRowView)dgv.SelectedRows[0].DataBoundItem;
                    _selectedPetId = Convert.ToInt32(row["Pet_Id"]);
                    _selectedPetName = row["Pet_Name"].ToString();

                    try { txtChoosePet.Text = _selectedPetName; } catch { }

                    frm.DialogResult = DialogResult.OK;
                    frm.Close();
                };

                btnCancel.Click += (s, ev) =>
                {
                    frm.DialogResult = DialogResult.Cancel;
                    frm.Close();
                };

                // Double-click to select
                dgv.CellDoubleClick += (s, ev) =>
                {
                    if (ev.RowIndex >= 0)
                    {
                        btnOk.PerformClick();
                    }
                };

                pnlButtons.Controls.Add(btnOk);
                pnlButtons.Controls.Add(btnCancel);

                // Add all controls to form
                frm.Controls.Add(pnlGrid);
                frm.Controls.Add(pnlButtons);
                frm.Controls.Add(pnlHeader);

                frm.ShowDialog(this);
            }
        }

        #region Load dữ liệu

        private void LoadProducts()
        {
            try
            {
                _dtProducts = _productCtrl.GetAll();
                cbProducts.DataSource = _dtProducts;
                cbProducts.DisplayMember = "Product_Name";
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

            DataRow[] rows = _dtProducts.Select($"ID={id}");
            if (rows.Length == 0) return;

            decimal price = Convert.ToDecimal(rows[0]["Price"]);
            int stock = Convert.ToInt32(rows[0]["Quantity"]);

            int qtyInCart = _cart
                .Where(x => x.ItemId == id && x.Type == "Product")
                .Sum(x => x.Quantity);

            int totalAfterAdd = qtyInCart + qty;

            if (totalAfterAdd > stock)
            {
                MessageBox.Show($"Số lượng sản phẩm trong kho không đủ!\nTrong kho còn lại: {stock}\n", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existing = _cart.FirstOrDefault(x => x.ItemId == id && x.Type == "Product");

            if (existing != null)
            {
                existing.Quantity += qty;
            }
            else
            {
                _cart.Add(new InvoiceDetailItem { ItemId = id, Name = name, Type = "Product", Quantity = qty, Price = price });
            }

            RefreshCart();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (cbServices.SelectedValue == null) return;

            int id = (int)cbServices.SelectedValue;
            string name = cbServices.Text;
            int qty = (int)nudServiceQty.Value;

            DataRow[] rows = _dtServices.Select($"ServiceId={id}");
            if (rows.Length == 0) return;
            decimal price = Convert.ToDecimal(rows[0]["Price"]);

            // If a pet is selected for service and customer is set, create CustomerPetService record via direct SQL
            if (_selectedPetId > 0 && _currentCustomerId > 0)
            {
                try
                {
                    int cpsId = InsertCustomerPetService(_currentCustomerId, _selectedPetId, id);
                    if (cpsId > 0)
                    {
                        MessageBox.Show($"Ghi nhận dịch vụ cho thú cưng {_selectedPetName} (ID {cpsId}).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể ghi nhận dịch vụ cho thú cưng: " + ex.Message);
                }
            }

            _cart.Add(new InvoiceDetailItem { ItemId = id, Name = name, Type = "Service", Quantity = qty, Price = price });
            RefreshCart();
        }

        private int InsertCustomerPetService(int cusId, int petId, int serviceId)
        {
            string connStr = ConfigurationManager.ConnectionStrings["PetDb"].ConnectionString;
            using (var conn = new SqlConnection(connStr))
            {
                string sql = @"INSERT INTO CustomerPetService (Cus_Id, Pet_Id, ServiceId, StartDate, Status)
                               VALUES (@CusId, @PetId, @ServiceId, GETDATE(), 'In Use');
                               SELECT CAST(SCOPE_IDENTITY() AS INT);";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@CusId", cusId);
                    cmd.Parameters.AddWithValue("@PetId", petId);
                    cmd.Parameters.AddWithValue("@ServiceId", serviceId);
                    conn.Open();
                    var obj = cmd.ExecuteScalar();
                    if (obj != null && int.TryParse(obj.ToString(), out int id)) return id;
                }
            }
            return 0;
        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            if (cbPets.SelectedValue == null) return;

            int id = (int)cbPets.SelectedValue;
            string name = cbPets.Text;
            int qty = 1;

            DataRow[] rows = _dtPets.Select($"PetId={id}");
            if (rows.Length == 0) return;
            decimal price = Convert.ToDecimal(rows[0]["Price"]);

            if (_cart.Any(item => item.ItemId == id && item.Type == "Pet"))
            {
                MessageBox.Show("Thú cưng này đã có trong giỏ hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _cart.Add(new InvoiceDetailItem { ItemId = id, Name = name, Type = "Pet", Quantity = qty, Price = price });
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
                int invoiceId = _invoiceCtrl.CreateInvoice(cusId, total);
                foreach (var item in _cart)
                {
                    _invoiceCtrl.AddInvoiceDetail(invoiceId, item.ItemId, item.Type, item.Quantity, item.Price);
                    if (item.Type == "Pet")
                    {
                        _petCtrl.ReturnMarkAsSold(item.ItemId);
                    }
                }

                MessageBox.Show("Thanh toán thành công!");
                _cart.Clear();
                RefreshCart();
                LoadProducts();
                LoadServices();
                LoadPets();

                // Reset thông tin khách hàng
                ClearCustomerInfo();
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
                Customer found = null;
                try
                {
                    found = _customerCtrl.GetCustomerByPhone(phone);
                }
                catch
                {
                    found = null;
                }

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

                    // Load customer's pets into pets combo so payment UI updates
                    try { LoadPets(); } catch { }

                    MessageBox.Show("Đã tìm thấy khách hàng trong hệ thống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCusName.Text))
                {
                    MessageBox.Show("Không tìm thấy khách hàng. Vui lòng nhập tên (và có thể địa chỉ/email) để thêm mới.", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCusName.Enabled = true;
                    txtAddress.Enabled = true;
                    txtEmail.Enabled = true;
                    txtCusName.Focus();
                    return;
                }

                var newCus = new Customer { Cus_Name = txtCusName.Text.Trim(), Address = txtAddress.Text.Trim(), Cus_PhoneNumber = phone, Cus_Email = txtEmail.Text.Trim() };

                int newId = _customerCtrl.AddCustomer(newCus);
                if (newId > 0)
                {
                    _currentCustomerId = newId;

                    // Refresh danh sách khách hàng nội bộ
                    //LoadCustomers();

                    // Load the newly created customer's pets into pets combo
                    try { LoadPets(); } catch { }

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
        #region Chọn khách hàng cũ
        private void btnSelectOldCustomer_Click(object sender, EventArgs e)
        {
            // Mở form ThongTinKhachHang ở chế độ chọn
            ThongTinKhachHang formSelectCustomer = new ThongTinKhachHang(true);

            if (formSelectCustomer.ShowDialog() == DialogResult.OK)
            {
                // Lấy khách hàng đã chọn
                Customer selectedCustomer = formSelectCustomer.SelectedCustomer;

                if (selectedCustomer != null)
                {
                    FillCustomerInfo(selectedCustomer);
                    MessageBox.Show($"Đã chọn khách hàng: {selectedCustomer.Cus_Name}",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void FillCustomerInfo(Customer customer)
        {
            _currentCustomerId = customer.Cus_Id;
            txtCusName.Text = customer.Cus_Name;
            txtAddress.Text = customer.Address;
            txtPhone.Text = customer.Cus_PhoneNumber;
            txtEmail.Text = customer.Cus_Email;

            // Disable edit
            txtCusName.Enabled = false;
            txtAddress.Enabled = false;
            txtEmail.Enabled = false;
        }

        // Helper method để xóa thông tin khách hàng
        private void ClearCustomerInfo()
        {
            _currentCustomerId = 0;
            txtCusName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";

            // Enable lại để có thể nhập khách mới
            txtCusName.Enabled = true;
            txtAddress.Enabled = true;
            txtEmail.Enabled = true;
        }
        #endregion
        private string EscapeForSelect(string input) => input.Replace("'", "''");
        #endregion

        private void btnSearchCus_Click(object sender, EventArgs e) { }

        private void lblAddTitle_Click(object sender, EventArgs e)
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