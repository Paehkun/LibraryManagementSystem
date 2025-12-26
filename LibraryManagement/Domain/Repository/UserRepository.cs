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
                WHERE is_deleted = FALSE
                AND (
                    @search = '' 
                    OR CAST(id AS TEXT) ILIKE @pattern
                    OR name ILIKE @pattern 
                    OR username ILIKE @pattern 
                    OR password ILIKE @pattern
                    OR email ILIKE @pattern
                    OR CAST(phone AS TEXT) ILIKE @pattern
                )
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
        public bool AddUser(Users user)
        {
            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO users (name, username, password, role, email, phone)
                           VALUES (@name, @username, @password, @role, @email, @phone)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", user.Name);
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        cmd.Parameters.AddWithValue("@password", user.Password);
                        cmd.Parameters.AddWithValue("@role", user.Role);
                        cmd.Parameters.AddWithValue("@email", user.Email);
                        cmd.Parameters.AddWithValue("@phone", user.Phone);

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                // Log or handle error
                throw new Exception("Error adding user: " + ex.Message);
            }
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
        public bool UserExists(int userId)
        {
            using (var conn = _db.GetConnection())
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM users WHERE id = @id AND is_deleted = FALSE";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", userId);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }
        public void SoftDeleteUser(int userId)
        {
            using (var conn = _db.GetConnection())
            {
                conn.Open();

                string query = "UPDATE users SET is_deleted = TRUE WHERE id = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Users? GetUserById(int userId)
        {
            using (var conn = _db.GetConnection())
            {
                conn.Open();
                string query = @"SELECT id, name, username, password, role, email, phone 
                         FROM users WHERE id = @id AND is_deleted = FALSE";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", userId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Users
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Username = reader.GetString(2),
                                Password = reader.GetString(3),
                                Role = reader.GetString(4),
                                Email = reader.GetString(5),
                                Phone = reader.GetString(6)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void EditUser(Users user)
        {
            using (var conn = _db.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE users 
                         SET name=@name, username=@username, password=@password, role=@role,
                             email=@email, phone=@phone
                         WHERE id=@id AND is_deleted = FALSE";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", user.Name);
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@password", user.Password);
                    cmd.Parameters.AddWithValue("@role", user.Role);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@phone", user.Phone);
                    cmd.Parameters.AddWithValue("@id", user.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Users? Authenticate(string username, string password)
        {
            using (var conn = _db.GetConnection())
            {
                conn.Open();
                string query = @"SELECT id, name, username, role, email, phone 
                         FROM users 
                         WHERE username = @username AND password = @password AND is_deleted = FALSE";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Users
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Username = reader.GetString(2),
                                Role = reader.GetString(3),
                                Email = reader["email"] == DBNull.Value ? "" : reader.GetString(4),
                                Phone = reader["phone"] == DBNull.Value ? "" : reader.GetString(5)
                            };
                        }
                    }
                }
            }
            return null;
        }


    }
}
