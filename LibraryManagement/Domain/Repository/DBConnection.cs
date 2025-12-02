using Npgsql;

namespace LibraryManagementSystem.Domain.Repository
{
    public class DBConnection
    {
        private readonly string _connectionString;

        public DBConnection()
        {
            _connectionString = "Host=localhost;Port=5432;Username=postgres;Password=db123;Database=library_db;";
        }

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }
    }
}
