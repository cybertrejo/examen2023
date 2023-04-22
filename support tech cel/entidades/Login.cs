using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Login
    {
        public string CodeUser { get; set; }
        public string Password { get; set; }

        public Login()
        {
        }

        public Login(string codeUser, string password)
        {
            CodeUser = codeUser;
            Password = password;
        }

    }
}
    
