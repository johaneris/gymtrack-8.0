﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazdeUsuario.models
{
    public class RegistroMiembro
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserType{ get; set; }
      
        public string Email {  get; set; }
        public string Cif {  get; set; }
        public string Cedula { get; set; }
        public string Password { get; set; }



        public RegistroMiembro(int iD, string name, string lastname, string usertipe, string email, string password, string cif, string cedula)
        {
            ID = iD;
            Name = name;
            LastName = lastname;
            UserType = usertipe;
          
            Email = email;
            Cif = cif; 
            
            Password = password.Trim();
        }
    }
}
