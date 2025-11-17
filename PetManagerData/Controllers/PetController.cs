using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace PetManagerData.Controllers
{
    public class PetController
    {
        private readonly string _connStr;

        public PetController(string connectionString)
        {
            _connStr = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        // Lấy danh sách thú cưng chưa bán
        public DataTable GetPetsNotSold()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = "SELECT * FROM Pets WHERE IsSold = 0";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        // Thêm thú cưng
        public bool AddPet(string name, string type, int age, decimal price)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = @"INSERT INTO Pets (PetName, Type, Age, Price, IsSold) 
                                 VALUES (@name, @type, @age, @price, 0)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@price", price);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Cập nhật thú cưng
        public bool UpdatePet(int id, string name, string type, int age, decimal price)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = @"UPDATE Pets 
                                 SET PetName=@name, Type=@type, Age=@age, Price=@price
                                 WHERE PetId=@id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@price", price);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Xóa thú cưng
        public bool DeletePet(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = "DELETE FROM Pets WHERE PetId = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Đánh dấu thú cưng đã bán
        public bool MarkAsSold(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = "UPDATE Pets SET IsSold = 1 WHERE PetId = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
