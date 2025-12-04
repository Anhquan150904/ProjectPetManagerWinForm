using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManagerData.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int Cus_Id { get; set; }
        public decimal Total { get; set; }
        public DateTime CreatedAt { get; set; }
    }


    public class InvoiceDetail
    {
        public int DetailId { get; set; }
        public int InvoiceId { get; set; }
        public int ItemId { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int Status { get; set; }
    }

}
