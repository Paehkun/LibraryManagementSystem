using LibraryManagement.Domain.Shared;
using System;

namespace LibraryManagementSystem.Domain.Entities
{
    public class BorrowReturn : BaseClass
    {
        public enum BorrowStatus
        {
            Returned = 0,
            Borrowed = 1
            
        }
        public string BorrowId { get; set; }
        public string Title { get; set; }           
        public string ISBN { get; set; }            
        public int MemberId { get; set; }           
        public string Name { get; set; }            
        public string Phone { get; set; }           
        public DateTime BorrowDate { get; set; }    
        public DateTime DueDate { get; set; }       
        public DateTime? ReturnDate { get; set; }
        public BorrowStatus Status { get; set; }
    }
}
