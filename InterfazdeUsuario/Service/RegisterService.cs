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

        public RegisterService(RegistroDeMiembroService service)
        {
            this.registroService = service;
        }

        public string RegisterMember(string name, string lastname, string email, string password, string userType, string cif, string cedula)
        {
            // Validaciones iniciales
            if (!IsValidName(name)) return "El nombre no es válido. Debe contener solo letras.";
            if (!IsValidName(lastname)) return "El apellido no es válido. Debe contener solo letras.";
            if (!IsValidEmail(email)) return "El correo electrónico no tiene un formato válido.";
            if (string.IsNullOrWhiteSpace(password)) return "La contraseña no puede estar vacía.";
            password = password.Trim().Substring(0, Math.Min(password.Length, 10)); // Máximo 10 caracteres

            if (userType == "Estudiante")
            {
                if (!IsValidCIF(cif)) return "El CIF debe tener exactamente 8 dígitos.";
                if (!email.EndsWith("@uamv.edu.ni")) return "El correo debe terminar con '@uamv.edu.ni'.";
                if (!string.IsNullOrEmpty(cedula)) return "Un estudiante no puede registrar una cédula.";
            }
            else if (userType == "Miembro Externo")
            {
                if (!IsValidCedula(cedula)) return "La cédula es inválida. Debe contener solo números.";
                if (!string.IsNullOrEmpty(cif)) return "Un miembro externo no puede registrar un CIF.";
            }
            else
            {
                return "El tipo de usuario no es válido.";
            }

            // Cargar lista de miembros
            var miembros = registroService.Load();

            // Verificar duplicados
            if (miembros.Any(m => m.Email.Equals(email, StringComparison.OrdinalIgnoreCase)))
                return "El correo ya está registrado.";
            if (userType == "Estudiante" && miembros.Any(m => m.Cif == cif))
                return "El CIF ya está registrado.";
            if (userType == "Miembro Externo" && miembros.Any(m => m.Cedula == cedula))
                return "La cédula ya está registrada.";

            // Generar ID único
            int newId = miembros.Count > 0 ? miembros.Max(m => m.ID) + 1 : 1;

            // Crear nuevo miembro
            var nuevoMiembro = new RegistroMiembro(newId, name, lastname, userType, email, password, cif, cedula);
            miembros.Add(nuevoMiembro);

            // Guardar la lista actualizada
            registroService.SaveFile(miembros);

            return "Registro exitoso.";
        }

        // Validaciones privadas
        private bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) && name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidCIF(string cif)
        {
            return !string.IsNullOrWhiteSpace(cif) && cif.Length == 8 && cif.All(char.IsDigit);
        }

        private bool IsValidCedula(string cedula)
        {
            return !string.IsNullOrWhiteSpace(cedula) && cedula.All(char.IsDigit);
        }
    }
}
