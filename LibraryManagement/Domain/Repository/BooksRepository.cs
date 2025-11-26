using LibraryManagement.Domain.Model;
using LibraryManagementSystem.Domain.Entities;
using Npgsql;
using System;
using System.Collections.Generic;

namespace LibraryManagementSystem.Domain.Repository
{
    public class BookRepository
    {
        private readonly DBConnection _db;

        public BookRepository(DBConnection db)
        {
            _db = db;
        }

        public List<Book> GetAllBooks()
        {
            var books = new List<Book>();

            using (var conn = _db.GetConnection())
            {
                conn.Open();
                string query = "SELECT id, title, author, isbn, category, publisher, year, copiesavailable, shelflocation FROM books ORDER BY id ASC";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var book = new Book
                        {
                            Id = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Author = reader.GetString(2),
                            ISBN = reader.GetString(3),
                            Category = reader.GetString(4),
                            Publisher = reader.GetString(5),
                            Year = reader.GetInt32(6),
                            CopiesAvailable = reader.GetInt32(7),
                            ShelfLocation = reader.GetString(8)
                        };
                        books.Add(book);
                    }
                }
            }
            return books;
        }

        public List<Book> GetAllBooksAdd()
        {
            var books = new List<Book>();

            using (var conn = _db.GetConnection())
            {
                conn.Open();
                string query = "SELECT id, title, isbn, category, copiesavailable FROM books ORDER BY id ASC";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var book = new Book
                        {
                            Id = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            ISBN = reader.GetString(2),
                            Category = reader.GetString(3),
                            CopiesAvailable = reader.GetInt32(4)
                        };
                        books.Add(book);
                    }
                }
            }

            return books;
        }

        public Book? GetBookByISBN(string isbn)
        {
            using (var conn = _db.GetConnection())
            {
                conn.Open();
                string query = "SELECT id, title, author, isbn, category, publisher, year, copiesavailable, shelflocation FROM books WHERE isbn = @isbn";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@isbn", isbn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Book
                            {
                                Id = reader.GetInt32(0),
                                Title = reader.GetString(1),
                                Author = reader.GetString(2),
                                ISBN = reader.GetString(3),
                                Category = reader.GetString(4),
                                Publisher = reader.GetString(5),
                                Year = reader.GetInt32(6),
                                CopiesAvailable = reader.GetInt32(7),
                                ShelfLocation = reader.GetString(8)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void AddBook(Book book)
        {
            using (var conn = _db.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO books 
                    (title, author, isbn, category, publisher, year, copiesavailable, shelflocation)
                    VALUES (@title, @author, @isbn, @category, @publisher, @year, @copies, @shelf)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@title", book.Title);
                    cmd.Parameters.AddWithValue("@author", book.Author);
                    cmd.Parameters.AddWithValue("@isbn", book.ISBN);
                    cmd.Parameters.AddWithValue("@category", book.Category);
                    cmd.Parameters.AddWithValue("@publisher", book.Publisher);
                    cmd.Parameters.AddWithValue("@year", book.Year);
                    cmd.Parameters.AddWithValue("@copies", book.CopiesAvailable);
                    cmd.Parameters.AddWithValue("@shelf", book.ShelfLocation);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateBook(Book book)
        {
            using (var conn = _db.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE books 
                                 SET title=@title, author=@author, category=@category, publisher=@publisher, 
                                     year=@year, copiesavailable=@copies, shelflocation=@shelf
                                 WHERE isbn=@isbn";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@title", book.Title);
                    cmd.Parameters.AddWithValue("@author", book.Author);
                    cmd.Parameters.AddWithValue("@category", book.Category);
                    cmd.Parameters.AddWithValue("@publisher", book.Publisher);
                    cmd.Parameters.AddWithValue("@year", book.Year);
                    cmd.Parameters.AddWithValue("@copies", book.CopiesAvailable);
                    cmd.Parameters.AddWithValue("@shelf", book.ShelfLocation);
                    cmd.Parameters.AddWithValue("@isbn", book.ISBN);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteBook(string isbn)
        {
            using (var conn = _db.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM books WHERE isbn=@isbn";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@isbn", isbn);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
