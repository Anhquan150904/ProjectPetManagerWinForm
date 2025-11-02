using System;
using Microsoft.Data.SqlClient;

namespace PetManagerWinForm.Controllers
{
    public class DangNhapController
    {
        private readonly string _connStr;

        public DangNhapController(string connectionString)
        {
            _connStr = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        public bool KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @u AND Password = @p";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", taiKhoan);
                cmd.Parameters.AddWithValue("@p", matKhau);

                int count = (int)cmd.ExecuteScalar();
                return count > 0; // có thì true, không có thì false
            }
        }
    }
}
