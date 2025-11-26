

using LibraryManagement.Domain.Shared;

namespace LibraryManagement.Domain.Model
{
    public class Member : BaseClass
    {
        //table ubah jadi id
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime MembershipDate { get; set; }

    }
}
