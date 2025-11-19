using Npgsql;
using System.Data;
using System.Security.Policy;

namespace LibraryManagementSystem
{
    public static class DatabaseHelper
    {
        // ✅ Change this connection string to match your DB
        private static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=db123;Database=library_db";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }

        public static DataTable GetAllBooks()
        {
            DataTable dt = new DataTable();
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT id, title, author, isbn, category, publisher, year, copiesavailable, shelflocation FROM books ORDER BY id ASC";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            return dt;
        }
        public static DataTable GetAllBooksAdd()
        {
            DataTable dt = new DataTable();
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT id, title, isbn, category, copiesavailable FROM books ORDER BY id ASC";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            return dt;
        }

        public static DataTable GetAllMembers(string search = "")
        {
            DataTable dt = new DataTable();

            using (var conn = GetConnection())
            {
                conn.Open();

                string query = @"
            SELECT memberid, name, email, phone, address, membershipdate
            FROM member
            WHERE (@search = '' 
                OR CAST(memberid AS TEXT) ILIKE @pattern
                OR name ILIKE @pattern 
                OR email ILIKE @pattern 
                OR phone ILIKE @pattern) 
            ORDER BY memberid ASC";

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

        public static DataTable GetAllMembersAdd(string search = "")
        {
            DataTable dt = new DataTable();

            using (var conn = GetConnection())
            {
                conn.Open();

                string query = @"
            SELECT memberid, name, email, phone
            FROM member
            WHERE (@search = '' 
                OR CAST(memberid AS TEXT) ILIKE @pattern
                OR name ILIKE @pattern 
                OR email ILIKE @pattern 
                OR phone ILIKE @pattern) 
            ORDER BY memberid ASC";

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

        public static DataTable GetAllUsers(string search = "")
        {
            DataTable dt = new DataTable();

            using (var conn = GetConnection())
            {
                conn.Open();

                string query = @"
            SELECT id, name, role, username, password
            FROM users
            WHERE (@search = '' 
                OR CAST(id AS TEXT) ILIKE @pattern
                OR name ILIKE @pattern 
                OR username ILIKE @pattern 
                OR password ILIKE @pattern) 
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


        public static void DeleteMember(int memberId)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM member WHERE memberid = @memberid";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@memberid", memberId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void EditMember(int memberId, string name, string email, string phone, string address)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE member SET name = @name, email = @email, phone = @phone, address = @address WHERE memberid = @memberid";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@memberid", memberId);
                    cmd.ExecuteNonQuery();
                }
            }
        }



        public static void AddBook(string title, string author, string isbn, string category, string publisher, int year, int copiesavailable, string shelflocation)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO books (title, author, isbn, category, publisher, year, copiesavailable, shelflocation) VALUES (@title, @author, @isbn, @category, @publisher, @year, @copiesavailable, @shelflocation)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@isbn", isbn);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@publisher", publisher);
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@copiesavailable", copiesavailable);
                    cmd.Parameters.AddWithValue("@shelflocation", shelflocation);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static DataTable GetBorrowRecords()
        {
            DataTable dt = new DataTable();
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM borrowreturn ORDER BY CASE WHEN status = 'Borrowed' THEN 1 ELSE 2 END, borrowdate DESC;";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            return dt;
        }


        public static DataRow GetMemberById(int memberId)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM member WHERE memberid = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", memberId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt.Rows.Count > 0 ? dt.Rows[0] : null;
                    }
                }
            }
        }

        public static DataRow GetBookByISBN(string isbn)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM books WHERE isbn = @isbn";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@isbn", isbn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt.Rows.Count > 0 ? dt.Rows[0] : null;
                    }
                }
            }
        }

        public static DataTable GetHistoryRecords()
        {
            string query = "SELECT * FROM borrowreturn WHERE status = 'Returned' ORDER BY returndate DESC";
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }


        public static void AddBorrowRecord(string title, string isbn, int memberid, DateTime borrowdate, DateTime duedate)
        {
            string borrowid = GenerateUniqueBorrowId();

            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
            INSERT INTO borrowreturn (borrowid, title, isbn, memberid, name, phone, borrowdate, duedate, returndate, status)
            SELECT 
                @borrowid, @title, @isbn, m.memberid, m.name, m.phone, @borrowdate, @duedate, NULL, 'Borrowed'
            FROM member m
            WHERE m.memberid = @memberid";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("borrowid", borrowid);
                    cmd.Parameters.AddWithValue("title", title);
                    cmd.Parameters.AddWithValue("isbn", isbn);
                    cmd.Parameters.AddWithValue("memberid", memberid);
                    cmd.Parameters.AddWithValue("borrowdate", borrowdate.Date);
                    cmd.Parameters.AddWithValue("duedate", duedate.Date);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static string GenerateUniqueBorrowId()
        {
            var rnd = new Random();
            string borrowId;

            do
            {
                borrowId = rnd.Next(100000, 1000000).ToString(); // 6 digits
            } while (CheckBorrowIdExists(borrowId));

            return borrowId;
        }


        public static bool CheckBorrowIdExists(string borrowId)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM borrowreturn WHERE borrowid = @borrowid";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("borrowid", borrowId);
                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public static DataTable ExecuteQuery(string query, object parameters = null)
        {
            using (var conn = GetConnection())
            using (var cmd = new NpgsqlCommand(query, conn))
            {
                conn.Open();
                if (parameters != null)
                {
                    foreach (var prop in parameters.GetType().GetProperties())
                    {
                        cmd.Parameters.AddWithValue("@" + prop.Name, prop.GetValue(parameters) ?? DBNull.Value);
                    }
                }

                DataTable dt = new DataTable();
                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                return dt;
            }
        }

        // ✅ Generic ExecuteNonQuery for UPDATE / DELETE / INSERT
        public static int ExecuteNonQuery(string query, object parameters = null)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        foreach (var prop in parameters.GetType().GetProperties())
                        {
                            cmd.Parameters.AddWithValue("@" + prop.Name, prop.GetValue(parameters) ?? DBNull.Value);
                        }
                    }

                    return cmd.ExecuteNonQuery(); // returns affected row count
                }
            }
        }


    }
}
