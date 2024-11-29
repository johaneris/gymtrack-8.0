using InterfazdeUsuario.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazdeUsuario.Dao
{
    public class LoginMiembroDao
    {

        private List<RegistroMiembro> miembros;

        public LoginMiembroDao()
        {
            miembros = new List<RegistroMiembro>();
        }

        public List<RegistroMiembro> GetMiembros()
        {
            return miembros;
        }

        public void AgregarMiembro(RegistroMiembro nuevoMiembro)
        {
            if (nuevoMiembro != null)
            {
                miembros.Add(nuevoMiembro);
            }
        }

        public RegistroMiembro BuscarPorIdentificador(string identificador)
        {
            return miembros.Find(m => m.Cif == identificador || m.Cedula == identificador);
        }

        public bool AutenticarUsuario(string identificador, string password)
        {
            var miembro = BuscarPorIdentificador(identificador);
            return miembro != null && miembro.Password == password;
        }
    }
}
