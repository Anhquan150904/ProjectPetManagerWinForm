using System;
using System.Data;
using System.Data.SqlClient;

namespace PetManagerData.DataAccess
{
    /// <summary>
    /// DataAccess cho Phân Ca
    /// </summary>
    public class ShiftDataAccess
    {
        /// <summary>
        /// Thêm hoặc cập nhật phân ca
        /// </summary>
        public static void UpsertShift(int employeeId, DateTime date, bool caSang, bool caChieu, bool caToi)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@EmployeeID", employeeId),
                new SqlParameter("@Date", date.Date),
                new SqlParameter("@CaSang", caSang),
                new SqlParameter("@CaChieu", caChieu),
                new SqlParameter("@CaToi", caToi)
            };

            DatabaseHelper.ExecuteNonQuery("sp_UpsertShift", parameters);
        }

        /// <summary>
        /// Lấy lịch phân ca của nhân viên
        /// </summary>
        public static DataTable GetShiftSchedule(int employeeId)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@EmployeeID", employeeId)
            };

            return DatabaseHelper.ExecuteQuery("sp_GetShiftSchedule", parameters);
        }

        /// <summary>
        /// Xóa một ca làm việc
        /// </summary>
        public static void DeleteShift(int shiftId)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@ID", shiftId)
            };

            DatabaseHelper.ExecuteNonQuery("sp_DeleteShift", parameters);
        }
    }
}