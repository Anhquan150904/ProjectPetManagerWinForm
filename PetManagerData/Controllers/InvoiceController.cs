//using PetManagerData.DataAccess;
//using PetManagerData.Models;
//using System.Collections.Generic;

//namespace PetManagerData.Controllers
//{
//    public class InvoiceService
//    {
//        private readonly InvoiceRepository _repo;

//        public InvoiceService(InvoiceRepository repo)
//        {
//            _repo = repo;
//        }

//        public List<Invoice> GetInvoices()
//        {
//            return _repo.GetAll();
//        }

//        public Invoice GetInvoiceById(int id)
//        {
//            return _repo.GetById(id);
//        }

//        public List<InvoiceDetail> GetInvoiceDetails(int invoiceId)
//        {
//            return _repo.GetDetails(invoiceId);
//        }
//    }
//}
