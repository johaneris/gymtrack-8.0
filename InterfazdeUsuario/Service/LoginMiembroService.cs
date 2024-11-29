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

        public LoginMiembroService(LoginMiembroDao dao)
        {
            this.loginDao = dao;
        }

        // Constructor sin parámetros
        public LoginMiembroService()
        {
            this.loginDao = new LoginMiembroDao(); // Inicializa un Dao predeterminado
        }


        public bool AutenticarUsuario(string identificador, string password)
        {
            CargarDatos();
            return loginDao.AutenticarUsuario(identificador, password);
        }

        public bool EsEstudiante(string cif)
        {
            CargarDatos(); // Asegúrate de cargar los datos antes de validar
            var miembro = loginDao.BuscarPorIdentificador(cif);
            return miembro != null && !string.IsNullOrWhiteSpace(miembro.Cif); // Verifica si es un estudiante con CIF válido
        }

        public bool EsMiembroExterno(string cedula)
        {
            CargarDatos(); // Asegúrate de cargar los datos antes de validar
            var miembro = loginDao.BuscarPorIdentificador(cedula);
            return miembro != null && !string.IsNullOrWhiteSpace(miembro.Cedula); // Verifica si es un miembro externo con cédula válida
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
