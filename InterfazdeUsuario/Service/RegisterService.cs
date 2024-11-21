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

        public string RegisterMember(string name, string lastname, string email, string password, string userType, string identify)
        {
            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(name))
                return "El nombre no puede estar vacío";
            if (string.IsNullOrWhiteSpace(lastname))
                return "El apellido no puede estar vacío";
            if (string.IsNullOrWhiteSpace(email))
                return "El correo no puede estar vacío";
            if (string.IsNullOrWhiteSpace(password))
                return "La contraseña no puede estar vacía";
            if (string.IsNullOrWhiteSpace(userType))
                return "El tipo de usuario no puede estar vacío";
            if (string.IsNullOrWhiteSpace(identify))
                return "El CIF o Cédula no puede estar vacío";

            if (!IsValidEmail(email))
                return "El formato del correo no es válido";

            // Validar si el correo ya existe
            List<RegistroMiembro> miembros = registroService.Load();
            foreach (RegistroMiembro miembro in miembros)
            {
                if (miembro.Email == email)
                {
                    return "El correo ya está registrado.";
                }
            }
            // Validar formato de CIF o Cédula
            if (userType == "Estudiante")
            {
                if (!Regex.IsMatch(identify, @"^\d{8}$")) // CIF: Solo 8 dígitos
                    return "El CIF es inválido";
            }
            else if (userType == "Miembro Externo")
            {
                if (!Regex.IsMatch(identify, @"^\d{10,12}[A-Za-z]$"))
                    return "Cedula inválida";
            }

            // Validar contraseña
            password = password.Trim();
            if (password.Length > 10)
                password = password.Substring(0, 10);

            //REVISAR
            // Generar un ID único
            int newId = miembros.Count > 0 ? miembros[miembros.Count - 1].ID + 1 : 1;

            // Crear nuevo miembro
            RegistroMiembro nuevoMiembro = new RegistroMiembro(newId, name, lastname, userType, email, identify, password);

            // Guardar en la lista y escribir en el archivo
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
