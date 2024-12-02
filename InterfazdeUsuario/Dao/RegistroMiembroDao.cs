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
        private List<RegistroMiembro> miembros;

        public RegistroMiembroDao()
        {
            miembros = new List<RegistroMiembro>();
        }

        public void CargarMiembros(List<RegistroMiembro> miembrosIniciales)
        {
            miembros = miembrosIniciales ?? new List<RegistroMiembro>();
        }

        public List<RegistroMiembro> ObtenerMiembros() => new List<RegistroMiembro>(miembros);

        public string AgregarMiembro(RegistroMiembro nuevoMiembro)
        {
            if (nuevoMiembro == null) return "El miembro no puede ser nulo.";
            if (EsMiembroDuplicado(nuevoMiembro)) return "Duplicado: CIF o cédula ya registrados.";

            miembros.Add(nuevoMiembro);
            nuevoMiembro.AgregarEventoHistorial("Miembro agregado.");
            return "Miembro agregado exitosamente.";
        }

        public RegistroMiembro BuscarPorCorreo(string email) =>
            miembros.FirstOrDefault(m => m.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

        public bool EliminarMiembro(int id)
        {
            var miembro = ObtenerMiembroPorId(id);
            if (miembro == null) return false;
            miembros.Remove(miembro);
            return true;
        }

        private bool EsMiembroDuplicado(RegistroMiembro miembro) =>
            miembros.Any(m => m.Cif == miembro.Cif || m.Cedula == miembro.Cedula);

        private RegistroMiembro ObtenerMiembroPorId(int id) =>
            miembros.FirstOrDefault(m => m.ID == id);
    }

    //public RegistroMiembro BuscarPorCorreo(string email)
    //    {
    //        if (string.IsNullOrWhiteSpace(email))
    //        {
    //            throw new ArgumentException("El correo no puede estar vacío.");
    //        }

    //        foreach (RegistroMiembro miembro in miembros)
    //        {
    //            if (miembro.Email == email)
    //            {
    //                return miembro;
    //            }
    //        }

    //        return null;
    //    }

    //    public RegistroMiembro ObtenerMiembroPorId(int id)
    //    {
    //        foreach (RegistroMiembro miembro in miembros)
    //        {
    //            if (miembro.ID == id)
    //            {
    //                return miembro;
    //            }
    //        }

    //        return null;
    //    }

    //    public RegistroMiembro ObtenerMiembroPorIdentificador(string identificador)
    //    {
    //        //if (string.IsNullOrWhiteSpace(identificador))
    //        //{
    //        //    throw new ArgumentException("El identificador no puede estar vacío.");
    //        //}

    //        //foreach (RegistroMiembro miembro in miembros)
    //        //{
    //        //    if (miembro.Cif == identificador || miembro.Cedula == identificador)
    //        //    {
    //        //        return miembro;
    //        //    }
    //        //}
    //        //}
    //    //    return miembros.FirstOrDefault(m =>
    //    //m.Cif == identificador || m.Cedula == identificador);

    //        if (string.IsNullOrWhiteSpace(identificador))
    //{
    //    throw new ArgumentException("El identificador no puede estar vacío.");
    //}

    //var miembro = miembros.FirstOrDefault(m => m.Cif == identificador || m.Cedula == identificador);

    //if (miembro == null)
    //{
    //    throw new Exception("Miembro no encontrado con ese identificador.");
    //}

    //return miembro;

    //    }

    //    public bool EliminarMiembro(int id)
    //    {
    //        RegistroMiembro miembro = ObtenerMiembroPorId(id);
    //        if (miembro != null)
    //        {
    //            miembros.Remove(miembro);
    //            return true;
    //        }
    //        return false;
    //    }

    //    public bool ActualizarMiembro(RegistroMiembro miembroActualizado)
    //    {
    //        if (miembroActualizado == null)
    //        {
    //            throw new ArgumentNullException("El miembro actualizado no puede ser nulo.");
    //        }

    //        for (int i = 0; i < miembros.Count; i++)
    //        {
    //            if (miembros[i].ID == miembroActualizado.ID)
    //            {
    //                miembros[i] = miembroActualizado;
    //                return true;
    //            }
    //        }

    //        return false;
    //    }

    //    public bool AutenticarUsuario(string email, string password)
    //    {
    //        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
    //        {
    //            throw new ArgumentException("El correo o la contraseña no pueden estar vacíos.");
    //        }

    //        foreach (RegistroMiembro miembro in miembros)
    //        {
    //            if (miembro.Email == email && miembro.Password == password)
    //            {
    //                return true;
    //            }
    //        }

    //        return false;
    //    }
}

