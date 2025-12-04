
using PetManagerData.DataAccess; // Đảm bảo đúng namespace cho Repository
using System.Data;
using System;

namespace PetManagerData.Controllers
{
    public class CustomerPetServiceController
    {
        private readonly CustomerPetServiceRepository _repository;

        public CustomerPetServiceController(string connectionString)
        {
            // Khởi tạo Repository để giao tiếp với DB
            _repository = new CustomerPetServiceRepository(connectionString);
        }

        /**
         * Lấy danh sách dịch vụ đang được thực hiện.
         */
        public DataTable GetServicesInProgress()
        {
            try
            {
                return _repository.GetServicesInProgress();
            }
            catch (Exception ex)
            {
                // Nên có Log lỗi ở đây
                throw new Exception("Lỗi khi tải dữ liệu dịch vụ đang thực hiện: " + ex.Message);
            }
        }

        /**
         * Lấy danh sách tất cả dịch vụ (dùng cho ComboBox).
         */
        public DataTable GetAllServices()
        {
            try
            {
                return _repository.GetAllServices();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tải danh sách dịch vụ: " + ex.Message);
            }
        }

        /**
         * Tìm kiếm dịch vụ đang được thực hiện.
         */
        public DataTable SearchServicesInProgress(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                // Trả về tất cả nếu từ khóa rỗng (hoặc ném exception tùy quy tắc)
                return GetServicesInProgress();
            }

            try
            {
                return _repository.SearchServicesInProgress(keyword);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm kiếm dịch vụ: " + ex.Message);
            }
        }

        /**
         * Hoàn thành dịch vụ (cập nhật Status).
         */
        public void MarkServiceDone(int cpsId)
        {
            if (cpsId <= 0)
            {
                throw new ArgumentException("ID dịch vụ không hợp lệ.");
            }

            try
            {
                _repository.MarkServiceDone(cpsId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi đánh dấu hoàn thành cho ID {cpsId}: " + ex.Message);
            }
        }
    }
}