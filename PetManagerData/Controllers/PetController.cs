using System;
using System.Data;
using PetManagerData.DataAccess; 

namespace PetManagerData.Controllers 
{
    public class PetController
    {
        private readonly PetRepository _petRepository;

        public PetController(string connectionString)
        {
            _petRepository = new PetRepository(connectionString);
        }

        // Lấy danh sách thú cưng đã bán 
        public DataTable GetPetsIsSold()
        {
            return _petRepository.GetPetsIsSold();
        }
        public DataTable GetPetsNotSold()
        {
            return _petRepository.GetPetsNotSold();
        }

        // Cập nhật thú cưng
        public bool UpdatePet(int id, string name, string type, int age, decimal price)
        {
            // (Thêm logic kiểm tra tại đây nếu cần)
            return _petRepository.UpdatePet(id, name, type, age, price);
        }

        public bool InsertPet(string name, string type, int age, decimal price)
        {
            // (Thêm logic kiểm tra tại đây nếu cần)
            return _petRepository.InsertPet(name, type, age, price);
        }

        // Xóa thú cưng 
        public bool DeletePet(int id)
        {
            return _petRepository.DeletePet(id);
        }

        // Hủy bán thú cưng
        public bool ReturnMarkAsSold(int id)
        {
            // Dùng hàm chung UpdateSoldStatus với IsSold = false (0)
            return _petRepository.UpdateSoldStatus(id, true);
        }

        // Tìm kiếm thú cưng ĐÃ BÁN 
        public DataTable SearchPetsIsSold(string searchString)
        {
            return _petRepository.SearchPetsIsSold(searchString);
        }

        public DataTable SearchPetsNotSold(string searchString)
        {
            return _petRepository.SearchPetsNotSold(searchString);
        }

        public DataTable GetPetDetail(int id)
        {
            return _petRepository.GetPetDetail(id);
        }
    }
}