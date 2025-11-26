using System.Data;
using Npgsql;

namespace LibraryManagementSystem.Domain.Repository
{
    public class UserRepository
    {
        private readonly DBConnection _db;

        public UserRepository(DBConnection db)
        {
            _db = db;
        }

        public DataTable GetAllUsers(string search = "")
        {
            DataTable dt = new DataTable();
            using (var conn = _db.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT id, name, role, username, password, email, phone
            FROM users
            WHERE (@search = '' 
                OR CAST(id AS TEXT) ILIKE @pattern
                OR name ILIKE @pattern 
                OR username ILIKE @pattern 
                OR password ILIKE @pattern
                OR email ILIKE @pattern
                OR CAST(phone AS TEXT) ILIKE @pattern) 
            ORDER BY id ASC";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", search);
                    cmd.Parameters.AddWithValue("@pattern", "%" + search + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }

            return dt;
        }
    }
}
