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

        // Método para obtener la lista completa de miembros
        public List<RegistroMiembro> GetMiembros()
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
            foreach (RegistroMiembro miembro in miembros)
            {
                if (miembro.Email == email)
                {
                    return miembro;
                }
            }
            return null; // Si no se encuentra, retorna null
        }

        // Método para eliminar un miembro por su ID
        public bool EliminarMiembro(int id)
        {
            foreach (RegistroMiembro miembro in miembros)
            {
                if (miembro.ID == id)
                {
                    miembros.Remove(miembro);
                    return true; // Eliminación exitosa
                }
            }
            return false; // No se encontró el miembro
        }

        // Método para actualizar los datos de un miembro
        public bool ActualizarMiembro(RegistroMiembro miembroActualizado)
        {
            for (int i = 0; i < miembros.Count; i++)
            {
                if (miembros[i].ID == miembroActualizado.ID)
                {
                    miembros[i] = miembroActualizado;
                    return true; // Actualización exitosa
                }
            }
            return false; // No se encontró el miembro
        }

        public bool AutenticarUsuario(string email, string password)
        {
            foreach (RegistroMiembro miembro in miembros)
            {
                if (miembro.Email == email && miembro.Password == password)
                {
                    return true; // Credenciales correctas
                }
            }
            return false; // Credenciales incorrectas
        }

    }
}
