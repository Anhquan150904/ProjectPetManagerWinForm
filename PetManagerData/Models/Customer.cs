using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManagerData.Models
{
    public class Customer
    {
        public int Cus_Id { get; set; }
        public string Cus_Name { get; set; }
        public string Address { get; set; }
        public string Cus_PhoneNumber { get; set; }
        public string Cus_Email { get; set; }
    }
}
