using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PetManagerData.Models;

namespace PetManagerData.DataAccess
{
    public class PetCusRepository
    {
        private readonly string _connectionString;

        public PetCusRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Lấy tất cả thú cưng của một khách hàng
        public DataTable GetPetsByCustomerId(int customerId)
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT 
                    pc.Pet_Id,
                    pc.Pet_Name,
                    pc.Pet_Breed,
                    pc.Pet_Age,
                    c.Cus_Name,
                    STUFF((
                        SELECT ', ' + s.ServiceName
                        FROM CustomerPetService cps
                        INNER JOIN Service s ON cps.ServiceId = s.ServiceId
                        WHERE cps.Pet_Id = pc.Pet_Id 
                          AND cps.Status = 'In Use'
                        FOR XML PATH('')
                    ), 1, 2, '') AS ServiceUsed
                FROM PetCus pc
                INNER JOIN Customer c ON pc.Cus_Id = c.Cus_Id
                WHERE pc.Cus_Id = @CustomerId
                ORDER BY pc.Pet_Name";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", customerId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        // Lấy tất cả thú cưng
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT 
                    pc.Pet_Id,
                    pc.Pet_Name,
                    pc.Pet_Breed,
                    pc.Pet_Age,
                    c.Cus_Name,
                    STUFF((
                        SELECT ', ' + s.ServiceName
                        FROM CustomerPetService cps
                        INNER JOIN Service s ON cps.ServiceId = s.ServiceId
                        WHERE cps.Pet_Id = pc.Pet_Id 
                          AND cps.Status = 'In Use'
                        FOR XML PATH('')
                    ), 1, 2, '') AS ServiceUsed
                FROM PetCus pc
                INNER JOIN Customer c ON pc.Cus_Id = c.Cus_Id
                ORDER BY pc.Pet_Name";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        // Thêm thú cưng mới
        public int Add(PetCus pet)
        {
            string query = @"
                INSERT INTO PetCus (Cus_Id, Pet_Name, Pet_Age, Pet_Breed)
                VALUES (@Cus_Id, @Pet_Name, @Pet_Age, @Pet_Breed);
                SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cus_Id", pet.Cus_Id);
                    cmd.Parameters.AddWithValue("@Pet_Name", pet.Pet_Name ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Pet_Age", pet.Pet_Age ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Pet_Breed", pet.Pet_Breed ?? (object)DBNull.Value);

                    conn.Open();
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        // Cập nhật thú cưng
        public bool Update(PetCus pet)
        {
            string query = @"
                UPDATE PetCus
                SET Pet_Name = @Pet_Name,
                    Pet_Age = @Pet_Age,
                    Pet_Breed = @Pet_Breed
                WHERE Pet_Id = @Pet_Id";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Pet_Id", pet.Pet_Id);
                    cmd.Parameters.AddWithValue("@Pet_Name", pet.Pet_Name ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Pet_Age", pet.Pet_Age ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Pet_Breed", pet.Pet_Breed ?? (object)DBNull.Value);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Xóa thú cưng
        public bool Delete(int petId)
        {
            string query = @"
                DELETE FROM CustomerPetService WHERE Pet_Id = @Pet_Id;
                DELETE FROM PetCus WHERE Pet_Id = @Pet_Id;";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Pet_Id", petId);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Tìm kiếm thú cưng
        public DataTable Search(string keyword, int? customerId = null)
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT 
                    pc.Pet_Id,
                    pc.Pet_Name,
                    pc.Pet_Breed,
                    pc.Pet_Age,
                    c.Cus_Name,
                    STUFF((
                        SELECT ', ' + s.ServiceName
                        FROM CustomerPetService cps
                        INNER JOIN Service s ON cps.ServiceId = s.ServiceId
                        WHERE cps.Pet_Id = pc.Pet_Id 
                          AND cps.Status = 'In Use'
                        FOR XML PATH('')
                    ), 1, 2, '') AS ServiceUsed
                FROM PetCus pc
                INNER JOIN Customer c ON pc.Cus_Id = c.Cus_Id
                WHERE (pc.Pet_Name LIKE @Keyword OR pc.Pet_Breed LIKE @Keyword)";

            if (customerId.HasValue)
            {
                query += " AND pc.Cus_Id = @CustomerId";
            }

            query += " ORDER BY pc.Pet_Name";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                    if (customerId.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@CustomerId", customerId.Value);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }
}