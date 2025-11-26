using Npgsql;

namespace LibraryManagementSystem.Domain.Repository
{
    public class DBConnection
    {
        private readonly string _connectionString;

        public DBConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }
    }
}
