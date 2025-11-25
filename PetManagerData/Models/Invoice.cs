using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManagerData.Models
{
    public class Invoice
    {
        public int ID { get; set; }
        public int Cus_ID { get; set; }
        public string Product_Service_Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public string Time_to_create { get; set; }
    }

    public class InvoiceDetail
    {
        public int ID { get; set; }
        public string product_Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Country { get; set; }
        public string Condition { get; set; }
    }
}
