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
        private RegistroMiembro usuarioAutenticado;

        public LoginMiembroService(LoginMiembroDao dao)
        {
            this.loginDao = dao;
        }

        public LoginMiembroService()
        {

        }
        public bool AutenticarUsuario(string identificador, string password)
        {
            CargarDatos();
            usuarioAutenticado = loginDao.GetMiembros()
            .FirstOrDefault(m =>
                (m.Cif == identificador || m.Cedula == identificador) &&
                m.Password == password);

            return usuarioAutenticado != null;
        }
        public bool EsEstudiante(string identificador)
        {
            // Por ejemplo, si los CIF tienen un prefijo o cierta longitud específica.
            return identificador.Length == 8 && identificador.StartsWith("C"); // Ajustar según reglas
        }

        public bool EsMiembroExterno(string identificador)
        {
            // Por ejemplo, si las cédulas tienen un formato numérico de 7 u 8 dígitos.
            return identificador.Length == 7 || identificador.Length == 8; // Ajustar según reglas
        }

        public RegistroMiembro ObtenerUsuarioAutenticado()
        {
            return usuarioAutenticado;
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
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error leyendo datos: " + ex.Message);
                            break;
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error al cargar archivo: " + ex.Message);
            }
        }


    }
}
