using System.Data;
using Microsoft.Data.SqlClient;

namespace PetManagerData.DataAccess
{
    public class CustomerPetServiceRepository
    {
        private readonly string _connectionString;

        public CustomerPetServiceRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        /**
         * Lấy danh sách thú cưng đang sử dụng dịch vụ (Status = 'In Use')
         * Trả về DataTable bao gồm thông tin Customer, Pet, và Service.
         */
        public DataTable GetServicesInProgress()
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT 
                    CPS.CPS_Id, 
                    P.Pet_Id, 
                    P.Pet_Name, 
                    P.Pet_Age, 
                    S.ServiceName, 
                    S.Price,
                    C.Cus_Name,
                    CPS.StartDate,
                    CPS.Status
                FROM 
                    CustomerPetService AS CPS
                JOIN 
                    PetCus AS P ON CPS.Pet_Id = P.Pet_Id
                JOIN 
                    Customer AS C ON CPS.Cus_Id = C.Cus_Id
                JOIN 
                    Service AS S ON CPS.ServiceId = S.ServiceId
                WHERE 
                    CPS.Status = 'In Use'";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        /**
         * Tìm kiếm thú cưng đang sử dụng dịch vụ theo từ khóa (Tên Pet hoặc Tên Dịch vụ)
         */
        public DataTable SearchServicesInProgress(string keyword)
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT 
                    CPS.CPS_Id, 
                    P.Pet_Id, 
                    P.Pet_Name, 
                    P.Pet_Age, 
                    S.ServiceName, 
                    S.Price,
                    C.Cus_Name,
                    CPS.StartDate,
                    CPS.Status
                FROM 
                    CustomerPetService AS CPS
                JOIN 
                    PetCus AS P ON CPS.Pet_Id = P.Pet_Id
                JOIN 
                    Customer AS C ON CPS.Cus_Id = C.Cus_Id
                JOIN 
                    Service AS S ON CPS.ServiceId = S.ServiceId
                WHERE 
                    CPS.Status = 'In Use' AND 
                    (P.Pet_Name LIKE @Keyword OR S.ServiceName LIKE @Keyword)";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Thêm tham số SQL để ngăn chặn SQL Injection
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        /**
         * Cập nhật trạng thái dịch vụ là 'Done' và thêm CompletionDate
         */
        public void MarkServiceDone(int cpsId)
        {
            string query = @"
                UPDATE CustomerPetService 
                SET 
                    Status = 'Done', 
                    CompletionDate = GETDATE() 
                WHERE 
                    CPS_Id = @CpsId AND Status = 'In Use'";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CpsId", cpsId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /**
         * Lấy tất cả dịch vụ từ bảng Service (dùng cho ComboBox)
         */
        public DataTable GetAllServices()
        {
            DataTable dt = new DataTable();
            string query = "SELECT ServiceId, ServiceName FROM Service";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}