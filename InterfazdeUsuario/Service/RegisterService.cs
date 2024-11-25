using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfazdeUsuario.models;
using InterfazdeUsuario.Dao;
using System.Security.Principal;
using System.Text.RegularExpressions;

namespace InterfazdeUsuario.Service
{
    public class RegisterService
    {
        private RegistroMiembroDao registroDao;
        private RegistroDeMiembroService registroService;

        public RegisterService(RegistroMiembroDao dao, RegistroDeMiembroService service)
        {
            this.registroDao = dao;
            this.registroService = service;
        }

        public string RegisterMember(string name, string lastname, string email, string password, string userType, string cif, string cedula)
        {
            if (string.IsNullOrWhiteSpace(name) || !name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                return "El nombre solo puede contener letras y no puede estar vacío.";

            if (string.IsNullOrWhiteSpace(lastname) || !lastname.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                return "El apellido solo puede contener letras y no puede estar vacío.";

            if (string.IsNullOrWhiteSpace(email))
                return "El correo no puede estar vacío.";
            if (!IsValidEmail(email))
                return "El correo electrónico no tiene un formato válido.";

            if (string.IsNullOrWhiteSpace(password))
                return "La contraseña no puede estar vacía.";
            if (password.Length > 10)
                password = password.Substring(0, 10);

            if (userType == "Estudiante")
            {
                if (!string.IsNullOrWhiteSpace(cedula))
                    return "Los estudiantes no deben registrar una cédula.";
                if (string.IsNullOrWhiteSpace(cif) || cif.Length != 8 || !cif.All(char.IsDigit))
                    return "El CIF es obligatorio, debe tener exactamente 8 dígitos y solo números.";
                if (!email.EndsWith("@uamv.edu.ni"))
                    return "El correo de un estudiante debe terminar con '@uamv.edu.ni'.";
            }
            else if (userType == "Miembro Externo")
            {
                if (!string.IsNullOrWhiteSpace(cif))
                    return "Los miembros externos no deben registrar un CIF.";
                if (string.IsNullOrWhiteSpace(cedula) || !cedula.All(char.IsDigit))
                    return "La cédula es obligatoria y debe contener solo números.";
            }
            else
            {
                return "El tipo de usuario no es válido.";
            }

            List<RegistroMiembro> miembros = registroService.Load();

            if (miembros.Any(miembro => miembro.Email.Equals(email, StringComparison.OrdinalIgnoreCase)))
                return "El correo ya está registrado.";

            if (userType == "Estudiante" && miembros.Any(miembro => !string.IsNullOrWhiteSpace(miembro.Cif) && miembro.Cif.Equals(cif, StringComparison.OrdinalIgnoreCase)))
                return "El CIF ya está registrado.";

            if (userType == "Miembro Externo" && miembros.Any(miembro => !string.IsNullOrWhiteSpace(miembro.Cedula) && miembro.Cedula.Equals(cedula, StringComparison.OrdinalIgnoreCase)))
                return "La cédula ya está registrada.";

            int newId = miembros.Count > 0 ? miembros.Max(miembro => miembro.ID) + 1 : 1;
            RegistroMiembro nuevoMiembro = new RegistroMiembro(newId, name, lastname, userType, email, password, cif, cedula);

            miembros.Add(nuevoMiembro);
            registroService.SaveFile(miembros);

            return "Registro exitoso.";
        }


        private bool IsValidEmail(string email)
        {
            try
            {
                System.Net.Mail.MailAddress addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;

            }
            catch
            {
                return false;
            }
            
        }
    }
}
