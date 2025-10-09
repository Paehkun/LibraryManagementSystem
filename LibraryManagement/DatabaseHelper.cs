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
    }
}
