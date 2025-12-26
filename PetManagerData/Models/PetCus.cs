using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManagerData.Models
{
    public class PetCus
    {
        public int Pet_Id { get; set; }
        public int Cus_Id { get; set; }
        public string Pet_Name { get; set; }
        public int? Pet_Age { get; set; }
        public string Pet_Breed { get; set; }

        // Thông tin bổ sung từ join với các bảng khác
        public string Cus_Name { get; set; }  // Tên chủ sở hữu
        public string ServiceName { get; set; }  // Dịch vụ đang sử dụng
    }
}
