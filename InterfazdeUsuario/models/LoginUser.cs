using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace InterfazdeUsuario.models
{
    internal class LoginUser
    {
        public string Email { get; set; }   
        public string Password {  get; set; }
        

        public LoginUser(string email, string password)
        {
            Email = email;
            Password = password;   
        }
    }
}
