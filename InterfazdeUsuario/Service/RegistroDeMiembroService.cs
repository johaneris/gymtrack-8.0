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
            FileStream fs = null;
            BinaryWriter bw = null;

            try
            {
                fs = new FileStream(filepath, FileMode.Create, FileAccess.Write);
                bw = new BinaryWriter(fs);

                foreach (RegistroMiembro m in miembros)
                {
                    bw.Write(m.ID);
                    bw.Write(m.Name);
                    bw.Write(m.LastName);
                    bw.Write(m.UserType);
                    bw.Write(m.Email);
                    bw.Write(m.Cif);
                    bw.Write(m.Cedula);
                    bw.Write(m.Password);


                }
            }
            catch(Exception)
            {
               
            }
            finally
            {
                if (fs != null) fs.Close();
                if (bw != null) bw.Close();
            }


        }

        public List<RegistroMiembro> Load()
        {
            List<RegistroMiembro> miembros = new List<RegistroMiembro>();

            if (!File.Exists(filepath))
                return miembros;

            FileStream fs = null;
            BinaryReader br = null;

            try
            {
                fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);

                while (fs.Position < fs.Length) // Verifica si quedan datos por leer
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

                        miembros.Add(new RegistroMiembro(id, name, lastname, usertype, email, cif, cedula, password));
                    }
                    catch (EndOfStreamException)
                    {
                        // Maneja cualquier posible lectura incompleta
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                // Loguea el error si es necesario
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");
            }
            finally
            {
                if (fs != null) fs.Close();
                if (br != null) br.Close();
            }

            return miembros;
        }
    }
}
