using Npgsql;
using System.Data;

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
                string query = "SELECT id, title, author, category, copies FROM books ORDER BY id ASC";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            return dt;
        }

        public static void AddBook(string title, string author, string category, int copies)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO books (title, author, category, copies) VALUES (@title, @author, @category, @copies)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@copies", copies);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
