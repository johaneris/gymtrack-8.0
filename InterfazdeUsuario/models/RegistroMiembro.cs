using System;
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
        public string UserType { get; set; }
        public string Email { get; set; }
        public string Cif { get; set; }
        public string Cedula { get; set; }
        public string Password { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Historial { get; set; } // Almacena actividades importantes del miembro

        public RegistroMiembro(int id, string name, string lastname, string userType, string email, string password, string cif, string cedula)
        {
            ID = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            LastName = lastname ?? throw new ArgumentNullException(nameof(lastname));
            UserType = userType ?? throw new ArgumentNullException(nameof(userType));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Password = password.Trim() ?? throw new ArgumentNullException(nameof(password));
            Cif = cif;
            Cedula = cedula;
            FechaRegistro = DateTime.Now;
            Historial = string.Empty; // Inicialización por defecto
        }

        public void AgregarEventoHistorial(string evento)
        {
            Historial += $"{DateTime.Now}: {evento}\n";
        }
    }
}
