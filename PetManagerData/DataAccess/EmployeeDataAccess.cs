using System;
using System.Data;
using System.Data.SqlClient;

namespace PetManagerData.DataAccess
{
    public class EmployeeDataAccess
    {
        /// <summary>
        /// Lấy tất cả nhân viên
        /// </summary>
        public static DataTable GetAllEmployees()
        {
            return DatabaseHelper.ExecuteQuery("sp_GetAllEmployees");
        }

        /// <summary>
        /// Thêm nhân viên mới
        /// </summary>
        public static int InsertEmployee(string name, string address, string phone,
                                        string sex, string email, string position, string status)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Name", name),
                new SqlParameter("@Address", address ?? (object)DBNull.Value),
                new SqlParameter("@PhoneNumber", phone ?? (object)DBNull.Value),
                new SqlParameter("@Sex", sex ?? (object)DBNull.Value),
                new SqlParameter("@Email", email ?? (object)DBNull.Value),
                new SqlParameter("@Position", position ?? (object)DBNull.Value),
                new SqlParameter("@Status", status ?? "Đang làm")
            };

            object result = DatabaseHelper.ExecuteScalar("sp_InsertEmployee", parameters);
            return Convert.ToInt32(result);
        }

        /// <summary>
        /// Cập nhật thông tin nhân viên
        /// </summary>
        public static void UpdateEmployee(int id, string name, string address, string phone,
                                         string sex, string email, string position, string status)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@ID", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@Address", address ?? (object)DBNull.Value),
                new SqlParameter("@PhoneNumber", phone ?? (object)DBNull.Value),
                new SqlParameter("@Sex", sex ?? (object)DBNull.Value),
                new SqlParameter("@Email", email ?? (object)DBNull.Value),
                new SqlParameter("@Position", position ?? (object)DBNull.Value),
                new SqlParameter("@Status", status ?? "Đang làm")
            };

            DatabaseHelper.ExecuteNonQuery("sp_UpdateEmployee", parameters);
        }

        /// <summary>
        /// Xóa nhân viên
        /// </summary>
        public static void DeleteEmployee(int id)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@ID", id)
            };

            DatabaseHelper.ExecuteNonQuery("sp_DeleteEmployee", parameters);
        }

        /// <summary>
        /// Tìm kiếm nhân viên
        /// </summary>
        public static DataTable SearchEmployees(string keyword)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Keyword", keyword ?? "")
            };

            return DatabaseHelper.ExecuteQuery("sp_SearchEmployees", parameters);
        }
    }
}