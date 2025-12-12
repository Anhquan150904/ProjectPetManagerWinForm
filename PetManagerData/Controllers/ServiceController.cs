using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace PetManagerData.Controllers
{
    public class ServiceController
    {
        private readonly string _connStr;

        public ServiceController(string connectionString)
        {
            _connStr = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        public DataTable GetServices()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = "SELECT ServiceId, ServiceName, Type, Price FROM dbo.Service";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public bool DeleteService(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = "DELETE FROM dbo.Service WHERE ServiceId = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Add service without Amount column
        public bool AddService(string name, string type, decimal price)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = @"INSERT INTO dbo.Service (ServiceName, Type, Price)
                                 VALUES (@name, @type, @price)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name ?? string.Empty);
                    cmd.Parameters.AddWithValue("@type", type ?? string.Empty);
                    cmd.Parameters.AddWithValue("@price", price);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Update service without Amount column
        public bool UpdateService(int id, string name, string type, decimal price)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = @"UPDATE dbo.Service
                                 SET ServiceName = @name,
                                     Type = @type,
                                     Price = @price
                                 WHERE ServiceId = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name ?? string.Empty);
                    cmd.Parameters.AddWithValue("@type", type ?? string.Empty);
                    cmd.Parameters.AddWithValue("@price", price);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable SearchServices(string searchString)
        {
            DataTable dt = new DataTable();
            string pattern = $"%{searchString}%";

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = @"SELECT ServiceId, ServiceName, Type, Price FROM dbo.Service
                                 WHERE (ServiceName LIKE @pattern OR
                                        Type LIKE @pattern OR
                                        CONVERT(NVARCHAR(50), Price) LIKE @pattern)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pattern", pattern);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }

        // Additional methods can be added later as needed
    }
}
