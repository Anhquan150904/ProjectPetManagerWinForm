using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace PetManagerData.DataAccess // DAL
{
    public class PetRepository
    {
        private readonly string _connStr;

        public PetRepository(string connectionString)
        {
            _connStr = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        // Lấy danh sách thú cưng ĐÃ bán
        public DataTable GetPetsIsSold()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = "SELECT * FROM Pets WHERE IsSold = 1";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
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
        public bool InsertPet(string name, string type, int age, decimal price)
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

        // Cập nhật trạng thái bán hàng
        public bool UpdateSoldStatus(int id, bool isSold)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = "UPDATE Pets SET IsSold = @isSold WHERE PetId = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@isSold", isSold ? 1 : 0);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Tìm kiếm thú cưng ĐÃ BÁN
        public DataTable SearchPetsIsSold(string searchString)
        {
            DataTable dt = new DataTable();
            string searchPattern = $"%{searchString}%";

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = @"SELECT * FROM Pets 
                                 WHERE (PetName LIKE @pattern OR 
                                        Type LIKE @pattern OR 
                                        CONVERT(NVARCHAR(50), Price) LIKE @pattern)
                                 AND IsSold = 1"; // Chỉ tìm thú cưng ĐÃ bán

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pattern", searchPattern);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public DataTable SearchPetsNotSold(string searchString)
        {
            DataTable dt = new DataTable();
            string searchPattern = $"%{searchString}%";

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = @"SELECT * FROM Pets 
                                 WHERE (PetName LIKE @pattern OR 
                                        Type LIKE @pattern OR 
                                        CONVERT(NVARCHAR(50), Price) LIKE @pattern)
                                 AND IsSold = 0"; // Chỉ tìm thú cưng ĐÃ bán

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pattern", searchPattern);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }


        public DataTable GetPetDetail(int id)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = @"SELECT TOP 1 * FROM Pets WHERE PetId = @id"; // Chỉ tìm thú cưng ĐÃ bán

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

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