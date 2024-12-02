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

        public void SaveFile(List<RegistroMiembro> miembros)
        {
            using (var fs = new FileStream(filepath, FileMode.Create, FileAccess.Write))
            using (var bw = new BinaryWriter(fs))
            {
                foreach (var m in miembros)
                {
                    bw.Write(m.ID);
                    bw.Write(m.Name);
                    bw.Write(m.LastName);
                    bw.Write(m.UserType);
                    bw.Write(m.Email);
                    bw.Write(m.Cif ?? "");
                    bw.Write(m.Cedula ?? "");
                    bw.Write(m.Password);
                    bw.Write(m.FechaRegistro.ToBinary());
                    bw.Write(m.Historial ?? "");
                }
            }
        }

        public List<RegistroMiembro> Load()
        {
            var miembros = new List<RegistroMiembro>();
            if (!File.Exists(filepath)) return miembros;

            using (var fs = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            using (var br = new BinaryReader(fs))
            {
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
                    DateTime fechaRegistro = DateTime.FromBinary(br.ReadInt64());
                    string historial = br.ReadString();

                    var miembro = new RegistroMiembro(id, name, lastname, userType, email, password, cif, cedula)
                    {
                        FechaRegistro = fechaRegistro,
                        Historial = historial
                    };
                    miembros.Add(miembro);
                }
            }
            return miembros;
        }
    }
}
