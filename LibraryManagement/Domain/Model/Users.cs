
using LibraryManagement.Domain.Shared;

namespace LibraryManagement.Domain.Model
{
    public class Users : BaseClass
    {
        public string Username { get; set;  } = default!;
        public string Password { get; set; }
        public string Role { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}
