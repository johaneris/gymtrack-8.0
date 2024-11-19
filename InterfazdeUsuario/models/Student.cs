using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazdeUsuario.models
{
    internal class Student
    {
        public string Name {  get; set; }
        public string Cif {  get; set; }
        public string Email { get; set; }


        // Crear constructor
        public Student(string name, string cif, string email)
        {
            Name = name;
            Cif = cif;
            Email = email;
        }
    }
}
