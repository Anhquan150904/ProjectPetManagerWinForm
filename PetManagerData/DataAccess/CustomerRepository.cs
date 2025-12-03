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
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                string query = "SELECT * FROM Customer";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public int Add(Customer cus)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = "INSERT INTO Customer (Cus_Name, Address, Cus_PhoneNumber, Cus_Email) " +
                               "VALUES (@name, @address, @phone, @email); SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", cus.Cus_Name);
                    cmd.Parameters.AddWithValue("@address", cus.Address);
                    cmd.Parameters.AddWithValue("@phone", cus.Cus_PhoneNumber);
                    cmd.Parameters.AddWithValue("@email", cus.Cus_Email);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
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
    }
}
