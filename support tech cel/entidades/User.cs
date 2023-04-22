using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    class User
    {
        public string CodeUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
        public string Role { get; set; }
        public bool Active { get; set; }

        public User( )
        {

        }

        public User(string codeUser, string username, string password, string email, DateTime createDate, string role, bool active)
        {
            CodeUser = codeUser;
            Username = username;
            Password = password;
            Email = email;
            CreateDate = createDate;
            Role = role;
            Active = active;
        }
    }
}
