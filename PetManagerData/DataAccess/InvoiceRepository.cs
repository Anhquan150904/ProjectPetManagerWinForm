using Microsoft.Data.SqlClient;
using PetManagerData.Models;
using System.Data;

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
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connStr))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Invoice", conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            return dt;
        }


        public List<InvoiceDetail> GetDetails(int invoiceId)
        {
            List<InvoiceDetail> list = new List<InvoiceDetail>();

            using (SqlConnection conn = new SqlConnection(_connStr))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM InvoiceDetail WHERE InvoiceId=@id", conn))
            {
                cmd.Parameters.AddWithValue("@id", invoiceId);
                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    list.Add(new InvoiceDetail
                    {
                        DetailId = Convert.ToInt32(rd["DetailId"]),
                        InvoiceId = Convert.ToInt32(rd["InvoiceId"]),
                        ItemId = Convert.ToInt32(rd["ItemId"]),
                        Type = rd["Type"].ToString(),
                        Quantity = Convert.ToInt32(rd["Quantity"]),
                        Price = Convert.ToDecimal(rd["Price"]),
                        Status = Convert.ToInt32(rd["Status"])
                    });
                }
            }

            return list;
        }

        public Invoice GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Invoice WHERE InvoiceId=@id", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    return new Invoice
                    {
                        InvoiceId = Convert.ToInt32(rd["InvoiceId"]),
                        Cus_Id = Convert.ToInt32(rd["Cus_Id"]),
                        Total = Convert.ToDecimal(rd["Total"]),
                        CreatedAt = Convert.ToDateTime(rd["CreatedAt"])
                    };
                }
            }
            return null;
        }
    }
}
