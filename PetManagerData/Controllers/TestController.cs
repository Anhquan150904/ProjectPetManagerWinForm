using PetManagerData.DataAccess;
using PetManagerData.Models;
using System.Data;

namespace PetManagerData.Controllers
{
    public class CustomerController
    {
        private CustomerRepository _repo;
        public CustomerController(string connStr) { _repo = new CustomerRepository(connStr); }

        public DataTable GetAllCustomers() => _repo.GetAll();
        public int AddCustomer(Customer cus) => _repo.Add(cus);

        public DataTable SearchCusByPhone(string Phone) => _repo.SearchCusByPhone(Phone);
    }

    public class ProductController
    {
        private ProductRepository _repo;
        public ProductController(string connStr) { _repo = new ProductRepository(connStr); }
        public DataTable GetAll() => _repo.GetAll();
        public void UpdateQuantity(int id, int qty) => _repo.UpdateQuantity(id, qty);
    }

    public class ServiceController2
    {
        private ServiceRepository _repo;
        public ServiceController2(string connStr) { _repo = new ServiceRepository(connStr); }
        public DataTable GetAll() => _repo.GetAll();
    }

    public class InvoiceController
    {
        private InvoiceRepository _repo;
        private ProductController _productController;
        public InvoiceController(string connStr)
        {
            _repo = new InvoiceRepository(connStr);
            _productController = new ProductController(connStr);
        }

        public int CreateInvoice(int cusId, decimal total) => _repo.CreateInvoice(cusId, total);

        public void AddInvoiceDetail(int invoiceId, int itemId, string type, int qty, decimal price)
        {
            _repo.AddInvoiceDetail(invoiceId, itemId, type, qty, price);
            if (type == "Product") _productController.UpdateQuantity(itemId, qty);
            // Pet đã xử lý riêng ở Form (MarkAsSold)
        }
    }
}

