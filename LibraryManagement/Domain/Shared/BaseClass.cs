using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Domain.Shared
{
    public class BaseClass
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastModified { get; set; } = DateTime.Now;
        public Boolean IsDeleted { get; set; }    
        public DateTime CreateBy { get; set; } = DateTime.Now;
        public DateTime LastModifiedBy { get; set; } = DateTime.Now;
    }
}
