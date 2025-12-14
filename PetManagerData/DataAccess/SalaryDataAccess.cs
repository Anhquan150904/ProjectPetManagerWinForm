using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace PetManagerData.DataAccess
{
    public class SalaryDataAccess
    {
        /// <summary>
        /// Tính lương cho nhân viên
        /// </summary>
        public static DataRow CalculateSalary(int employeeId, int month, int year,
                                              decimal bonus = 0, decimal penalty = 0)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@EmployeeID", employeeId),
                new SqlParameter("@Month", month),
                new SqlParameter("@Year", year),
                new SqlParameter("@Bonus", bonus),
                new SqlParameter("@Penalty", penalty)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery("sp_CalculateSalary", parameters);

            if (dt.Rows.Count > 0)
                return dt.Rows[0];

            return null;
        }
    }
}
