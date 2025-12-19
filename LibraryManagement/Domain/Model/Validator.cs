using LibraryManagement.Domain.Model;
using System;
using System.Collections.Generic;

namespace LibraryManagement.Domain.Validation
{
    public static class Validator
    {
        //book validation
        public static void ValidateBook(Book book)
        {
            if (book == null)
                throw new ArgumentNullException("Book cannot be null.");

            if (string.IsNullOrWhiteSpace(book.Title))
                throw new ArgumentException("Title is required.");

            if (string.IsNullOrWhiteSpace(book.Author))
                throw new ArgumentException("Author is required.");

            if (string.IsNullOrWhiteSpace(book.ISBN))
                throw new ArgumentException("ISBN is required.");

            if (string.IsNullOrWhiteSpace(book.Category) || book.Category == "Select Category")
                throw new ArgumentException("Please select a valid category.");

            if (string.IsNullOrWhiteSpace(book.Publisher))
                throw new ArgumentException("Publisher is required.");

            if (book.Year <= 0)
                throw new ArgumentException("Year must be a positive number.");

            if (book.CopiesAvailable < 0)
                throw new ArgumentException("Copies available must be 0 or more.");

            if (string.IsNullOrWhiteSpace(book.ShelfLocation))
                throw new ArgumentException("Shelf location is required.");

            if (string.IsNullOrWhiteSpace(book.Image))
                throw new ArgumentException("Image path is required.");
        }
        //book validation error return
        public static List<string> GetBookValidationErrors(Book book)
        {
            var errors = new List<string>();

            if (book == null) errors.Add("Book cannot be null.");
            else
            {
                if (string.IsNullOrWhiteSpace(book.Title)) errors.Add("Title is required.");
                if (string.IsNullOrWhiteSpace(book.Author)) errors.Add("Author is required.");
                if (string.IsNullOrWhiteSpace(book.ISBN)) errors.Add("ISBN is required.");
                if (string.IsNullOrWhiteSpace(book.Category) || book.Category == "Select Category")
                    errors.Add("Please select a valid category.");
                if (string.IsNullOrWhiteSpace(book.Publisher)) errors.Add("Publisher is required.");
                if (book.Year <= 0) errors.Add("Year must be a positive number.");
                if (book.CopiesAvailable < 0) errors.Add("Copies available must be 0 or more.");
                if (string.IsNullOrWhiteSpace(book.ShelfLocation)) errors.Add("Shelf location is required.");
                if (string.IsNullOrWhiteSpace(book.Image)) errors.Add("Image path is required.");
            }

            return errors;
        }
    }
}
