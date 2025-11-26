
using LibraryManagement.Domain.Shared;

namespace LibraryManagement.Domain.Model
{
    public class Book : BaseClass
    {
        public string Title { get; set; } = default!;
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Category { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public int CopiesAvailable { get; set; }
        public string ShelfLocation { get; set; }
    }

}
