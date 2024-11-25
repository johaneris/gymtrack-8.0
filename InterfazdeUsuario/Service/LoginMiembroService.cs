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
        public bool EsEstudiante()
        {
            return usuarioAutenticado != null && !string.IsNullOrWhiteSpace(usuarioAutenticado.Cif);
        }

        public bool EsMiembroExterno()
        {
            return usuarioAutenticado != null && !string.IsNullOrWhiteSpace(usuarioAutenticado.Cedula);
        }

        public RegistroMiembro ObtenerUsuarioAutenticado()
        {
            return usuarioAutenticado;
        }
        public void CargarDatos()
        {
            if (!File.Exists(filepath)) return;

            FileStream fs = null;
            BinaryReader br = null;

            try
            {
                fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);

                loginDao.GetMiembros().Clear(); 

                while (fs.Position < fs.Length)
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
            }
            finally
            {
                if (fs != null) fs.Close();
                if (br != null) br.Close();
            }
        }


    }
}
