using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace PetManagerData.Controllers
{
    public class ServiceTypeController
    {
        private readonly string _connStr;

        public ServiceTypeController(string connectionString)
        {
            _connStr = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
            EnsureTableExists();
        }

        private void EnsureTableExists()
        {
            using var conn = new SqlConnection(_connStr);
            conn.Open();
            string check = @"IF OBJECT_ID('dbo.ServiceType','U') IS NULL
                              CREATE TABLE dbo.ServiceType (
                                  TypeId INT IDENTITY(1,1) PRIMARY KEY,
                                  TypeName NVARCHAR(100) NOT NULL UNIQUE
                              );";
            using var cmd = new SqlCommand(check, conn);
            cmd.ExecuteNonQuery();
        }

        public DataTable GetTypes()
        {
            DataTable dt = new DataTable();
            using var conn = new SqlConnection(_connStr);
            conn.Open();
            string query = "SELECT TypeId, TypeName FROM dbo.ServiceType ORDER BY TypeName";
            using var cmd = new SqlCommand(query, conn);
            using var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        // Returns the TypeId of the existing or newly inserted type; 0 on failure
        public int AddType(string typeName)
        {
            if (string.IsNullOrWhiteSpace(typeName)) return 0;
            using var conn = new SqlConnection(_connStr);
            conn.Open();

            // If exists return existing id
            using (var chk = new SqlCommand("SELECT TypeId FROM dbo.ServiceType WHERE TypeName = @name", conn))
            {
                chk.Parameters.AddWithValue("@name", typeName.Trim());
                var obj = chk.ExecuteScalar();
                if (obj != null) return Convert.ToInt32(obj);
            }

            // Insert and return new id
            using (var ins = new SqlCommand("INSERT INTO dbo.ServiceType (TypeName) VALUES (@name); SELECT SCOPE_IDENTITY();", conn))
            {
                ins.Parameters.AddWithValue("@name", typeName.Trim());
                var idObj = ins.ExecuteScalar();
                if (idObj == null) return 0;
                return Convert.ToInt32(idObj);
            }
        }

        public bool UpdateType(int typeId, string newName)
        {
            if (typeId <= 0 || string.IsNullOrWhiteSpace(newName)) return false;

            using var conn = new SqlConnection(_connStr);
            conn.Open();
            using var tran = conn.BeginTransaction();
            try
            {
                // Check uniqueness
                using (var chk = new SqlCommand("SELECT COUNT(1) FROM dbo.ServiceType WHERE TypeName = @name AND TypeId <> @id", conn, tran))
                {
                    chk.Parameters.AddWithValue("@name", newName.Trim());
                    chk.Parameters.AddWithValue("@id", typeId);
                    int exists = Convert.ToInt32(chk.ExecuteScalar());
                    if (exists > 0)
                    {
                        tran.Rollback();
                        return false;
                    }
                }

                // Get old name
                string oldName;
                using (var get = new SqlCommand("SELECT TypeName FROM dbo.ServiceType WHERE TypeId = @id", conn, tran))
                {
                    get.Parameters.AddWithValue("@id", typeId);
                    var o = get.ExecuteScalar();
                    if (o == null)
                    {
                        tran.Rollback();
                        return false;
                    }
                    oldName = o.ToString();
                }

                // Update ServiceType
                using (var upd = new SqlCommand("UPDATE dbo.ServiceType SET TypeName = @name WHERE TypeId = @id", conn, tran))
                {
                    upd.Parameters.AddWithValue("@name", newName.Trim());
                    upd.Parameters.AddWithValue("@id", typeId);
                    upd.ExecuteNonQuery();
                }

                // Update Services that referenced old name to new name
                using (var su = new SqlCommand("UPDATE dbo.Service SET Type = @new WHERE Type = @old", conn, tran))
                {
                    su.Parameters.AddWithValue("@new", newName.Trim());
                    su.Parameters.AddWithValue("@old", oldName);
                    su.ExecuteNonQuery();
                }

                tran.Commit();
                return true;
            }
            catch
            {
                try { tran.Rollback(); } catch { }
                return false;
            }
        }

        public bool DeleteType(int typeId)
        {
            if (typeId <= 0) return false;

            using var conn = new SqlConnection(_connStr);
            conn.Open();

            // Get type name
            string typeName;
            using (var get = new SqlCommand("SELECT TypeName FROM dbo.ServiceType WHERE TypeId = @id", conn))
            {
                get.Parameters.AddWithValue("@id", typeId);
                var o = get.ExecuteScalar();
                if (o == null) return false;
                typeName = o.ToString();
            }

            // Check if any service uses this type
            using (var chk = new SqlCommand("SELECT COUNT(1) FROM dbo.Service WHERE Type = @t", conn))
            {
                chk.Parameters.AddWithValue("@t", typeName);
                int cnt = Convert.ToInt32(chk.ExecuteScalar());
                if (cnt > 0) return false; // cannot delete, in use
            }

            using (var del = new SqlCommand("DELETE FROM dbo.ServiceType WHERE TypeId = @id", conn))
            {
                del.Parameters.AddWithValue("@id", typeId);
                return del.ExecuteNonQuery() > 0;
            }
        }
    }
}
