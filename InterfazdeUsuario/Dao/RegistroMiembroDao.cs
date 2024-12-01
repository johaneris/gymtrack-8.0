using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfazdeUsuario.models;

namespace InterfazdeUsuario.Dao
{
    public class RegistroMiembroDao
    {
        // Lista para almacenar los miembros registrados
        private List<RegistroMiembro> miembros;

        // Constructor para inicializar la lista
        public RegistroMiembroDao()
        {
            miembros = new List<RegistroMiembro>();
        }

        // Método para cargar una lista inicial de miembros (útil para persistencia futura)
        public void CargarMiembros(List<RegistroMiembro> miembrosIniciales)
        {
            if (miembrosIniciales != null)
            {
                miembros = miembrosIniciales;
            }
        }

        // Método para obtener la lista completa de miembros
        public List<RegistroMiembro> ObtenerMiembros()
        {
            return miembros;
        }

        // Método para agregar un nuevo miembro
        public void AgregarMiembro(RegistroMiembro nuevoMiembro)
        {
            if (nuevoMiembro != null)
            {
                miembros.Add(nuevoMiembro);
            }
        }

        // Método para buscar un miembro por su correo
        public RegistroMiembro BuscarPorCorreo(string email)
        {
            return miembros.FirstOrDefault(m => m.Email == email);
        }

        // Método para buscar un miembro por su ID
        public RegistroMiembro ObtenerMiembroPorId(int id)
        {
            return miembros.FirstOrDefault(m => m.ID == id);
        }

        // Método para buscar un miembro por su identificador (CIF o cédula)
        public RegistroMiembro ObtenerMiembroPorIdentificador(string identificador)
        {
            return miembros.FirstOrDefault(m => m.Cif == identificador || m.Cedula == identificador);
        }

        // Método para eliminar un miembro por su ID
        public bool EliminarMiembro(int id)
        {
            var miembro = ObtenerMiembroPorId(id);
            if (miembro != null)
            {
                miembros.Remove(miembro);
                return true;
            }
            return false;
        }

        // Método para actualizar los datos de un miembro
        public bool ActualizarMiembro(RegistroMiembro miembroActualizado)
        {
            var index = miembros.FindIndex(m => m.ID == miembroActualizado.ID);
            if (index != -1)
            {
                miembros[index] = miembroActualizado;
                return true;
            }
            return false;
        }

        // Método para autenticar un usuario por correo y contraseña
        public bool AutenticarUsuario(string email, string password)
        {
            return miembros.Any(m => m.Email == email && m.Password == password);
        }
    }
}
