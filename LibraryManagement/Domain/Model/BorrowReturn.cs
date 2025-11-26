using LibraryManagement.Domain.Shared;
using System;

namespace LibraryManagementSystem.Domain.Entities
{
    public class BorrowReturn : BaseClass
    {
        public enum BorrowStatus
        {
            Borrowed = 0,
            Returned = 1
        }
//table ubah jadi id
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
