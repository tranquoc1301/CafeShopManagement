using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShopManagement
{
    public class User
    {
        public int Id {  get; set; }
        public string Role {  get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public User(string role, string fullName, DateTime dateOfBirth, string email, string phoneNumber)
        {
            Role = role;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Email = email;
            PhoneNumber = phoneNumber;
        }
        public User() { }

    }
}
