
using LibraryManagement.Domain.Shared;

namespace LibraryManagement.Domain.Model
{
    public class Users : BaseClass
    {
        public string Username { get; set;  }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}
