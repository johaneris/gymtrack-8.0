using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazdeUsuario.models
{
    internal class RegisterUser
    {
        public string Name {  get; set; }
        public string Cif {  get; set; }
        public string Email { get; set; }
        public string Password { get; set; }    
        public string User {  get; set; }   


        // Crear constructor
        public RegisterUser(string name, string cif, string email, string password, string user)
        {
            Name = name;
            Cif = cif;
            Email = email;
            Password = password;
            User = user;
        }
    }
}
