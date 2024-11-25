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

        //estamos usando los atributos medelos de registro
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

        public RegistroMiembro BuscarPorCedulaOCif(string identificador)
        {
            foreach (RegistroMiembro miembro in miembros)
            {
                if (miembro.Cif == identificador || miembro.Cedula == identificador)
                {
                    return miembro;
                }
            }
            return null;
        }

        public bool AutenticarUsuario(string identificador, string password)
        {
            foreach (RegistroMiembro miembro in miembros)
            {
                if ((miembro.Cif == identificador || miembro.Cedula == identificador) && miembro.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
