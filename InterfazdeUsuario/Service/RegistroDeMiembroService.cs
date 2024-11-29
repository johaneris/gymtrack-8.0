using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfazdeUsuario.models;

namespace InterfazdeUsuario.Service
{
    public class RegistroDeMiembroService
    {
        private string filepath = "miembros.bin";

       

            // Guardar lista de miembros en un archivo binario
            public void SaveFile(List<RegistroMiembro> miembros)
            {
                using (FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.Write))
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    foreach (RegistroMiembro m in miembros)
                    {
                        bw.Write(m.ID);
                        bw.Write(m.Name);
                        bw.Write(m.LastName);
                        bw.Write(m.UserType);
                        bw.Write(m.Email);
                        bw.Write(m.Cif ?? ""); // Guardar cadenas vacías para evitar nulos
                        bw.Write(m.Cedula ?? "");
                        bw.Write(m.Password);
                    }
                }
            }

            // Cargar lista de miembros desde un archivo binario
            public List<RegistroMiembro> Load()
            {
                List<RegistroMiembro> miembros = new List<RegistroMiembro>();

                if (!File.Exists(filepath))
                    return miembros;

                using (FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read))
                using (BinaryReader br = new BinaryReader(fs))
                {
                    while (fs.Position < fs.Length)
                    {
                        try
                        {
                            int id = br.ReadInt32();
                            string name = br.ReadString();
                            string lastname = br.ReadString();
                            string usertype = br.ReadString();
                            string email = br.ReadString();
                            string cif = br.ReadString();
                            string cedula = br.ReadString();
                            string password = br.ReadString();

                            miembros.Add(new RegistroMiembro(id, name, lastname, usertype, email, password, cif, cedula));
                        }
                        catch (EndOfStreamException)
                        {
                            break;
                        }
                    }
                }
                return miembros;
            }
        }
}
