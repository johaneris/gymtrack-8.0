using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace InterfazdeUsuario.models
{
    internal class LoginMiembro
    {
        public string Password { get; set; }
        public string CifCedula {get; set;}

        public LoginMiembro(string password, string cifcedula)
        {
            Password = password.Trim();
            CifCedula = cifcedula;
        }
    }
}
