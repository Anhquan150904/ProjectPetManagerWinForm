using System;
using System.Data;
using System.Data.SqlClient;

namespace PetManagerData.DataAccess
{
    public class AttendanceDataAccess
    {
        /// <summary>
        /// Thêm bản ghi chấm công (Check-in)
        /// </summary>
        public static void InsertAttendance(int employeeId, DateTime date, TimeSpan timeIn, string note)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@EmployeeID", employeeId),
                new SqlParameter("@Date", date.Date),
                new SqlParameter("@TimeIn", timeIn),
                new SqlParameter("@TimeOut", DBNull.Value),
                new SqlParameter("@TotalHours", DBNull.Value),
                new SqlParameter("@Note", note ?? (object)DBNull.Value)
            };

            DatabaseHelper.ExecuteNonQuery("sp_InsertAttendance", parameters);
        }

        /// <summary>
        /// Cập nhật giờ ra (Check-out)
        /// </summary>
        public static void UpdateCheckOut(int employeeId, DateTime date, TimeSpan timeOut, decimal totalHours)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@EmployeeID", employeeId),
                new SqlParameter("@Date", date.Date),
                new SqlParameter("@TimeOut", timeOut),
                new SqlParameter("@TotalHours", totalHours)
            };

            DatabaseHelper.ExecuteNonQuery("sp_UpdateAttendanceCheckOut", parameters);
        }

        /// <summary>
        /// Lấy lịch sử chấm công của nhân viên
        /// </summary>
        public static DataTable GetAttendanceHistory(int employeeId)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@EmployeeID", employeeId)
            };

            return DatabaseHelper.ExecuteQuery("sp_GetAttendanceHistory", parameters);
        }

        /// <summary>
        /// Lấy chấm công theo tháng
        /// </summary>
        public static DataTable GetAttendanceByMonth(int employeeId, int month, int year)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@EmployeeID", employeeId),
                new SqlParameter("@Month", month),
                new SqlParameter("@Year", year)
            };

            return DatabaseHelper.ExecuteQuery("sp_GetAttendanceByMonth", parameters);
        }
        /// <summary>
        /// Xóa bản ghi chấm công
        /// </summary>
        public static void DeleteAttendance(int employeeId, DateTime date)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@EmployeeID", employeeId),
                new SqlParameter("@Date", date.Date)
            };

            // Gọi Stored Procedure xóa
            DatabaseHelper.ExecuteNonQuery("sp_DeleteAttendance", parameters);
        }

        /// <summary>
        /// Cập nhật đầy đủ thông tin chấm công (Sửa thủ công)
        /// </summary>
        public static void UpdateAttendanceFull(int employeeId, DateTime date, TimeSpan timeIn, TimeSpan timeOut, decimal totalHours, string note)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@EmployeeID", employeeId),
                new SqlParameter("@Date", date.Date),
                new SqlParameter("@TimeIn", timeIn),
                new SqlParameter("@TimeOut", timeOut),
                new SqlParameter("@TotalHours", totalHours),
                new SqlParameter("@Note", note ?? (object)DBNull.Value)
            };

            // Gọi Stored Procedure cập nhật đầy đủ
            DatabaseHelper.ExecuteNonQuery("sp_UpdateAttendanceFull", parameters);
        }
    }
}