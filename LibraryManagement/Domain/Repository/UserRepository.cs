using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System.Data;
using LibraryManagement.Domain.Model;
using LibraryManagementSystem.Domain.Entities;

namespace LibraryManagementSystem.Domain.Repository
{
    public class UserRepository
    {
        private readonly DBConnection _db;

        public UserRepository(DBConnection db)
        {
            _db = db;
        }

        public List<Users> GetAllUsers(string search)
        {
            List<Users> users = new List<Users>();

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
                        while (reader.Read())
                        {
                            users.Add(new Users
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Role = reader.GetString(2),
                                Username = reader.GetString(3),
                                Password = reader.GetString(4),
                                Email = reader.GetString(5),
                                Phone = reader.GetString(6)
                            });
                        }
                    }
                }
            }

            return users;
        }
        public Users? GetUserByUsername(string username)
        {
            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT username, name, role FROM users WHERE username = @username";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Users
                                {
                                    Username = reader.GetString(reader.GetOrdinal("username")),
                                    Name = reader.GetString(reader.GetOrdinal("name")),
                                    Role = reader.GetString(reader.GetOrdinal("role"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle error
                throw new Exception("Error fetching user: " + ex.Message);
            }

            return null;
        }
    }
}
