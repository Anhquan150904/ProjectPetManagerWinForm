using PetManagerData.Models;
using System.Data;
using Microsoft.Data.SqlClient;

namespace PetManagerData.DataAccess
{
    public class ProductRepository
    {
        private string _connStr;
        public ProductRepository(string connStr) { _connStr = connStr; }

        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                string query = "SELECT * FROM Product WHERE Quantity > 0";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public void UpdateQuantity(int id, int qtySold)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = "UPDATE Product SET Quantity = Quantity - @qty WHERE ID = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@qty", qtySold);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
