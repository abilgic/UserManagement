using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string BirthPlace { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public ICollection<UserRole> Roles { get; set; }
        public ICollection<UserPassword> UserPasswords { get; set; }
        public UserIdentityCard UserIdentityCard { get; set; }
    }
}
