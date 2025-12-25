using PetManagerData.Models;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

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
                conn.Open();
                // Lấy tất cả, không chỉ những cái > 0 để quản lý
                string query = "SELECT * FROM Product";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public bool Add(Product p)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                // Lưu ý: Nếu ID trong DB là tự tăng (Identity), bỏ cột ID trong câu INSERT
                string query = @"INSERT INTO Product (Product_Name, Quantity, Price, Country, Condition) 
                                 VALUES (@name, @qty, @price, @country, @condition)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", p.product_Name);
                    cmd.Parameters.AddWithValue("@qty", p.Quantity);
                    cmd.Parameters.AddWithValue("@price", p.Price);
                    cmd.Parameters.AddWithValue("@country", p.Country);
                    cmd.Parameters.AddWithValue("@condition", p.Condition);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Update(Product p)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = @"UPDATE Product 
                                 SET Product_Name = @name, Quantity = @qty, Price = @price, 
                                     Country = @country, Condition = @condition 
                                 WHERE ID = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", p.ID);
                    cmd.Parameters.AddWithValue("@name", p.product_Name);
                    cmd.Parameters.AddWithValue("@qty", p.Quantity);
                    cmd.Parameters.AddWithValue("@price", p.Price);
                    cmd.Parameters.AddWithValue("@country", p.Country);
                    cmd.Parameters.AddWithValue("@condition", p.Condition);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = "DELETE FROM Product WHERE ID = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Tìm kiếm theo tên (nếu muốn tìm trực tiếp từ DB)
        public DataTable Search(string keyword)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                string query = "SELECT * FROM Product WHERE Product_Name LIKE @key OR Country LIKE @key";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@key", "%" + keyword + "%");
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        // Giữ lại hàm cũ của bạn nếu cần dùng ở chỗ khác
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