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

        public LoginMiembroService(LoginMiembroDao dao)
        {
            this.loginDao = dao;
        }

        public LoginMiembroService()
        {
            this.loginDao = new LoginMiembroDao();
        }

        public bool AutenticarUsuario(string identificador, string password)
        {
            CargarDatos();
            bool autenticado = loginDao.AutenticarUsuario(identificador, password);

            if (autenticado)
            {
                // Establecer el miembro autenticado
                miembroAutenticado = loginDao.BuscarPorIdentificador(identificador);
            }
            else
            {
                miembroAutenticado = null; // Limpiar si falla la autenticación
            }

            return autenticado;
        }

        public static int ObtenerMiembroId()
        {
            if (miembroAutenticado != null)
            {
                return miembroAutenticado.ID;
            }
            else
            {
                throw new Exception("No hay ningún miembro autenticado.");
            }
        }

        public void CargarDatos()
        {
            if (!File.Exists(filepath)) return;

            try
            {
                using (var fs = new FileStream(filepath, FileMode.Open, FileAccess.Read))
                using (var br = new BinaryReader(fs))
                {
                    loginDao.GetMiembros().Clear();

                    while (fs.Position < fs.Length)
                    {
                        try
                        {
                            int id = br.ReadInt32();
                            string name = br.ReadString();
                            string lastname = br.ReadString();
                            string userType = br.ReadString();
                            string email = br.ReadString();
                            string cif = br.ReadString();
                            string cedula = br.ReadString();
                            string password = br.ReadString();

                            loginDao.AgregarMiembro(new RegistroMiembro(id, name, lastname, userType, email, password, cif, cedula));
                        }
                        catch
                        {
                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
