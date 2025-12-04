using PetManagerData.Models;
using System.Data;
using Microsoft.Data.SqlClient;

namespace PetManagerData.DataAccess
{
    public class ServiceRepository
    {
        private string _connStr;
        public ServiceRepository(string connStr) { _connStr = connStr; }

        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                string query = "SELECT * FROM Service";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }
}
