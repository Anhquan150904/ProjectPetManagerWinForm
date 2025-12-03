using Microsoft.Data.SqlClient;

namespace PetManagerData.DataAccess
{
    public class InvoiceRepository
    {
        private string _connStr;
        public InvoiceRepository(string connStr) { _connStr = connStr; }

        public int CreateInvoice(int cusId, decimal total)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = "INSERT INTO Invoice (Cus_Id, Total) VALUES (@cus, @total); SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cus", cusId);
                    cmd.Parameters.AddWithValue("@total", total);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public void AddInvoiceDetail(int invoiceId, int itemId, string type, int qty, decimal price)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = "INSERT INTO InvoiceDetail (InvoiceId, ItemId, Type, Quantity, Price, Status) " +
                               "VALUES (@inv, @item, @type, @qty, @price, 0)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@inv", invoiceId);
                    cmd.Parameters.AddWithValue("@item", itemId);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@qty", qty);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
