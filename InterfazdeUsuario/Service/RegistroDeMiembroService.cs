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

                foreach(RegistroMiembro m in miembros)
                {
                    bw.Write(m.ID);
                    bw.Write(m.Name);
                    bw.Write(m.LastName);
                    bw.Write(m.UserType);
                    bw.Write(m.Email);
                    bw.Write(m.Identify);
                    bw.Write(m.Password);
                    

                }
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

                while(fs.Position != fs.Length)
                {
                    int id = br.ReadInt32();
                    string name = br.ReadString();
                    string lastname = br.ReadString();
                    string usertype = br.ReadString();
                    string email = br.ReadString();
                    string identify = br.ReadString();
                    string password = br.ReadString();  
                    

                    miembros.Add(new RegistroMiembro(id, name, lastname, usertype, email, identify, password));
                }


            }
            finally
            {
                if(fs != null) fs.Close();
                if (br != null) br.Close();
            }

            return miembros;
        }
    }
}
