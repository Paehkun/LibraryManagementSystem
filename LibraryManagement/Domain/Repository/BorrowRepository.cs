using LibraryManagement.Domain.Model;
using LibraryManagementSystem.Domain.Entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static LibraryManagementSystem.Domain.Entities.BorrowReturn;

namespace LibraryManagementSystem.Domain.Repository
{
    public class BorrowRepository
    {
        private readonly DBConnection _db;

        public BorrowRepository(DBConnection db)
        {
            _db = db;
        }

        public DataTable GetBorrowRecords()
        {
            DataTable dt = new DataTable();

            using (var conn = _db.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT * 
                    FROM borrowreturn
                    ORDER BY 
                        CASE WHEN status = 1 THEN 0 ELSE 1 END,
                        borrowdate DESC";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }

            return dt;
        }

        // ✅ Add borrow record
        public void AddBorrowRecord(
    string title,
    string isbn,
    int memberId,
    DateTime borrowDate,
    DateTime dueDate)
        {
            string borrowId = GenerateUniqueBorrowId();

            using (var conn = _db.GetConnection())
            {
                conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // ✅ Insert borrow record
                        string insertSql = @"
                    INSERT INTO borrowreturn
                    (borrowid, title, isbn, memberid, name, phone, borrowdate, duedate, returndate, status)
                    SELECT
                        @borrowid,
                        @title,
                        @isbn,
                        m.memberid,
                        m.name,
                        m.phone,
                        @borrowdate,
                        @duedate,
                        NULL,
                        1
                    FROM member m
                    WHERE m.memberid = @memberid";

                        using (var cmd = new NpgsqlCommand(insertSql, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@borrowid", borrowId);
                            cmd.Parameters.AddWithValue("@title", title);
                            cmd.Parameters.AddWithValue("@isbn", isbn);
                            cmd.Parameters.AddWithValue("@memberid", memberId);
                            cmd.Parameters.AddWithValue("@borrowdate", borrowDate.Date);
                            cmd.Parameters.AddWithValue("@duedate", dueDate.Date);

                            cmd.ExecuteNonQuery();
                        }

                        // ✅ Reduce book copies
                        string updateBooksSql = @"
                    UPDATE books
                    SET copiesavailable = copiesavailable - 1
                    WHERE isbn = @isbn AND copiesavailable > 0";

                        using (var cmd = new NpgsqlCommand(updateBooksSql, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@isbn", isbn);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        // ✅ Get borrow record by ID
        public DataRow GetBorrowById(string borrowId)
        {
            using (var conn = _db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM borrowreturn WHERE borrowid = @borrowid";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@borrowid", borrowId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt.Rows.Count > 0 ? dt.Rows[0] : null;
                    }
                }
            }
        }

        // ✅ Helpers
        private string GenerateUniqueBorrowId()
        {
            var rnd = new Random();
            string borrowId;

            do
            {
                borrowId = rnd.Next(100000, 1000000).ToString();
            }
            while (BorrowIdExists(borrowId));

            return borrowId;
        }

        private bool BorrowIdExists(string borrowId)
        {
            using (var conn = _db.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM borrowreturn WHERE borrowid = @borrowid";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@borrowid", borrowId);
                    return (long)cmd.ExecuteScalar() > 0;
                }
            }
        }

        // ✅ Return book - REPLACE THIS ENTIRE METHOD
        public void ReturnBook(string borrowId)
        {
            using (var conn = _db.GetConnection())
            {
                conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Get the ISBN and status before updating
                        string getIsbnQuery = "SELECT isbn, status FROM borrowreturn WHERE borrowid = @borrowid";
                        string isbn;
                        int statusValue;

                        using (var cmd = new NpgsqlCommand(getIsbnQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@borrowid", borrowId);
                            using (var reader = cmd.ExecuteReader())
                            {
                                if (!reader.Read())
                                {
                                    throw new Exception("No record found for this Borrow ID.");
                                }

                                isbn = reader.GetString(reader.GetOrdinal("isbn"));
                                statusValue = reader.GetInt32(reader.GetOrdinal("status"));
                            }
                        }

                        // Check if already returned
                        BorrowStatus status = (BorrowStatus)statusValue;
                        if (status == BorrowStatus.Returned)
                        {
                            throw new Exception("This book has already been returned.");
                        }

                        // Update borrow record
                        string updateBorrow = @"
                    UPDATE borrowreturn
                    SET returndate = @returndate,
                        status = @status
                    WHERE borrowid = @borrowid";

                        using (var cmd = new NpgsqlCommand(updateBorrow, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@returndate", DateTime.Now.Date);
                            cmd.Parameters.AddWithValue("@status", (int)BorrowStatus.Returned);
                            cmd.Parameters.AddWithValue("@borrowid", borrowId);
                            cmd.ExecuteNonQuery();
                        }

                        // Increment book copies
                        string updateCopies = @"
                    UPDATE books
                    SET copiesavailable = copiesavailable + 1
                    WHERE isbn = @isbn";

                        using (var cmd = new NpgsqlCommand(updateCopies, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@isbn", isbn);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public DataTable GetReturnedBooks(
    string titleFilter = "",
    string memberFilter = "",
    DateTime? startDate = null,
    DateTime? endDate = null)
        {
            using (var conn = _db.GetConnection())
            {
                conn.Open();

                string sql = @"
            SELECT
                borrowid,
                title,
                isbn,
                memberid,
                name,
                phone,
                borrowdate,
                duedate,
                returndate,
                status
            FROM borrowreturn
            WHERE status = @status";

                if (!string.IsNullOrWhiteSpace(titleFilter))
                    sql += " AND LOWER(title) LIKE LOWER(@title)";

                if (!string.IsNullOrWhiteSpace(memberFilter))
                    sql += " AND LOWER(name) LIKE LOWER(@name)";

                if (startDate.HasValue && endDate.HasValue)
                    sql += " AND returndate BETWEEN @startDate AND @endDate";

                sql += " ORDER BY returndate DESC";

                using var cmd = new NpgsqlCommand(sql, conn);

                // ✅ enum status parameter
                cmd.Parameters.AddWithValue("@status", (int)BorrowStatus.Returned);

                if (!string.IsNullOrWhiteSpace(titleFilter))
                    cmd.Parameters.AddWithValue("@title", $"%{titleFilter}%");

                if (!string.IsNullOrWhiteSpace(memberFilter))
                    cmd.Parameters.AddWithValue("@name", $"%{memberFilter}%");

                if (startDate.HasValue && endDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@startDate", startDate.Value.Date);
                    cmd.Parameters.AddWithValue("@endDate", endDate.Value.Date);
                }

                DataTable dt = new DataTable();
                using var adapter = new NpgsqlDataAdapter(cmd);
                adapter.Fill(dt);

                return dt;
            }
        }


    }
}
