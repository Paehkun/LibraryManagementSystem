using LibraryManagementSystem.Domain.Repository;
using Npgsql;
using System;
using System.Collections.Generic;

namespace LibraryManagement.Domain.Repository
{
    public class CategoryRepository
    {
        private readonly DBConnection _db;

        public CategoryRepository(DBConnection db)
        {
            _db = db;
        }

        // ✅ Get all categories ordered by ID
        public List<string> GetAllCategories()
        {
            List<string> categories = new List<string>();

            using (var conn = _db.GetConnection())
            {
                conn.Open();
                string query = "SELECT category FROM categories WHERE is_deleted = FALSE ORDER BY id ASC";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string cat = reader.GetString(0);
                        if (!string.IsNullOrWhiteSpace(cat))
                            categories.Add(cat);
                    }
                }
            }

            return categories;
        }

        // ✅ Add a new category
        public void AddCategory(string categoryName, int userId)
        {
            using (var conn = _db.GetConnection())
            {
                conn.Open();
                string query = @"
                    INSERT INTO categories (category, create_by, created_at, last_modified, is_deleted)
                    VALUES (@category, @userId, NOW(), NOW(), FALSE)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@category", categoryName);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ✅ Update a category
        public void UpdateCategory(int categoryId, string categoryName, int userId)
        {
            using (var conn = _db.GetConnection())
            {
                conn.Open();
                string query = @"
                    UPDATE categories 
                    SET category = @category, 
                        last_modified_by = @userId,
                        last_modified = NOW()
                    WHERE id = @id AND is_deleted = FALSE";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@category", categoryName);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@id", categoryId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ✅ Soft delete a category
        public void DeleteCategory(int categoryId, int userId)
        {
            using (var conn = _db.GetConnection())
            {
                conn.Open();
                string query = @"
                    UPDATE categories 
                    SET is_deleted = TRUE, 
                        last_modified_by = @userId,
                        last_modified = NOW()
                    WHERE id = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@id", categoryId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ✅ Check if category exists
        public bool CategoryExists(string categoryName)
        {
            using (var conn = _db.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM categories WHERE LOWER(category) = LOWER(@category) AND is_deleted = FALSE";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@category", categoryName);
                    return (long)cmd.ExecuteScalar() > 0;
                }
            }
        }
    }
}