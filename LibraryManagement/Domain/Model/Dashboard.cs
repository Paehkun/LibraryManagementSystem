using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.Entities
{
    public class DashboardStats
    {
        public int TotalBooks { get; set; }
        public int TotalBookRows { get; set; }
        public int TotalMembers { get; set; }
        public int TotalBorrowedBooks { get; set; }
        public int TotalLateReturnedBooks { get; set; }
    }
}

