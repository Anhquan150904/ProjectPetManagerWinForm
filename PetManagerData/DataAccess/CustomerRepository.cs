using PetManagerData.Models;
using System.Data;
using Microsoft.Data.SqlClient; 

namespace PetManagerData.DataAccess
{
    public class CustomerRepository
    {
        private string _connStr;
        public CustomerRepository(string connStr) { _connStr = connStr; }

        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connStr)) {
                conn.Open();
                string query = "SELECT * FROM Customer";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd)) {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        // 2. 
        public int Add(Customer cus)
        {
            using (SqlConnection conn = new SqlConnection(_connStr)) {
                conn.Open();

                string query = "INSERT INTO Customer (Cus_Name, Address, Cus_PhoneNumber, Cus_Email) " +
                               "VALUES (@name, @address, @phone, @email); SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@name", cus.Cus_Name);
                    cmd.Parameters.AddWithValue("@address", cus.Address);
                    cmd.Parameters.AddWithValue("@phone", cus.Cus_PhoneNumber);
                    cmd.Parameters.AddWithValue("@email", cus.Cus_Email);

  
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public bool Update(Customer cus)
        {
            using (SqlConnection conn = new SqlConnection(_connStr)) {
                conn.Open();
                string query = "UPDATE Customer SET Cus_Name = @name, Address = @address, " +
                               "Cus_PhoneNumber = @phone, Cus_Email = @email WHERE Cus_Id = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@id", cus.Cus_Id);
                    cmd.Parameters.AddWithValue("@name", cus.Cus_Name);
                    cmd.Parameters.AddWithValue("@address", cus.Address);
                    cmd.Parameters.AddWithValue("@phone", cus.Cus_PhoneNumber);
                    cmd.Parameters.AddWithValue("@email", cus.Cus_Email);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connStr)) {
                conn.Open();
                string query = "DELETE FROM Customer WHERE Cus_Id = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable Search(string keyword)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connStr)) {
                conn.Open();
                string query = @"SELECT * FROM Customer 
                                 WHERE Cus_Name LIKE @key OR Cus_PhoneNumber LIKE @key";
                using (SqlCommand cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@key", "%" + keyword + "%");
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd)) {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public DataTable SearchCusByPhone(string searchString)
        {
            DataTable dt = new DataTable();
            string searchPattern = $"%{searchString}%";

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = @"SELECT * FROM Customer
                                 WHERE Cus_PhoneNumber LIKE @pattern";

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
        public Customer GetCustomerByPhone(string phone)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = @"SELECT TOP 1 * FROM Customer WHERE Cus_PhoneNumber = @phone";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@phone", phone);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Customer
                            {
                                Cus_Id = Convert.ToInt32(reader["Cus_Id"]),
                                Cus_Name = reader["Cus_Name"].ToString(),
                                Address = reader["Address"].ToString(),
                                Cus_PhoneNumber = reader["Cus_PhoneNumber"].ToString(),
                                Cus_Email = reader["Cus_Email"].ToString()
                            };
                        }
                    }
                }
            }

            return null; // Không tìm thấy
        }

        public Customer GetCustomerById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = @"SELECT TOP 1 * FROM Customer WHERE Cus_Id = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Customer
                            {
                                Cus_Id = Convert.ToInt32(reader["Cus_Id"]),
                                Cus_Name = reader["Cus_Name"].ToString(),
                                Address = reader["Address"].ToString(),
                                Cus_PhoneNumber = reader["Cus_PhoneNumber"].ToString(),
                                Cus_Email = reader["Cus_Email"].ToString()
                            };
                        }
                    }
                }
            }

            return null; // Không tìm thấy
        }
    }
}