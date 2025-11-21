using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManagerData.Models
{
    public class PetCustomerInfo
    {
        public int Pet_Id { get; set; }
        public string Pet_Name { get; set; }
        public string Pet_Type { get; set; }

        public int Cus_Id { get; set; }
        public string Cus_Name { get; set; }
        public string Cus_Email { get; set; }
        public string Cus_Phone { get; set; }

        public string Time { get; set; }
    }
}
