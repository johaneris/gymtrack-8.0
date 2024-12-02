using InterfazdeUsuario.Dao;
using InterfazdeUsuario.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazdeUsuario.Service
{
    public class LoginMiembroService
    {

        private string filepath = "miembros.bin";
        private LoginMiembroDao loginDao;

        // Variable estática para rastrear al miembro autenticado
        private static RegistroMiembro miembroAutenticado;

        public LoginMiembroService()
        {
            var miembros = new RegistroDeMiembroService().Load();
            loginDao = new LoginMiembroDao();

            if (miembros != null && miembros.Count > 0)
            {
                foreach (var miembro in miembros)
                {
                    loginDao.AgregarMiembro(miembro);
                }
            }
        }

        public bool AutenticarUsuario(string identificador, string password)
        {
            CargarDatos();
            var miembro = loginDao.BuscarPorIdentificador(identificador);

            if (miembro != null && miembro.Password == password)
            {
                miembroAutenticado = miembro;
                miembro.AgregarEventoHistorial("Inicio de sesión exitoso.");
                new RegistroDeMiembroService().SaveFile(loginDao.GetMiembros());
                return true;
            }

            return false;
        }

        public static RegistroMiembro ObtenerMiembroAutenticado()
        {
            if (miembroAutenticado == null)
            {
                throw new Exception("No hay ningún miembro autenticado.");
            }

            return miembroAutenticado;
        }

        public static int ObtenerMiembroId()
        {
            return ObtenerMiembroAutenticado().ID;
        }

        private void CargarDatos()
        {
            if (!File.Exists(filepath)) return;

            var miembros = new RegistroDeMiembroService().Load();
            loginDao.GetMiembros().Clear();

            foreach (var miembro in miembros)
            {
                loginDao.AgregarMiembro(miembro);
            }

        }
    }
}
