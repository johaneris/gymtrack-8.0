using InterfazdeUsuario.Dao;
using InterfazdeUsuario.models;
using InterfazdeUsuario.Service;
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
            return new List<RegistroMiembro>(miembros);
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
    }
}
