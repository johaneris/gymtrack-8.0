using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace InterfazdeUsuario.Formularios
{
    public partial class FrmStudent : MetroFramework.Forms.MetroForm
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            string name = tbNombre.Text;
            string email = tbEmail.Text;
            string cif = tbCif.Text;

            //Validacion
            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(cif))
            {
                MessageBox.Show("Por favor rellene todos los campos.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Formato para guardar en archivo
            string userData = $"{name},{email},{cif}";

            // Guardar en archivo
            string filePath = @"C:\Users\gabri\OneDrive\Documentos\gymtrack4\Gymtrack-4.0\InterfazdeUsuario"; // Cambia la ruta según tu preferencia
            try
            {
                // Si el archivo no existe, se crea
                if (!File.Exists(filePath))
                {
                    File.WriteAllText(filePath, "Nombre,Correo,CIF\n"); // Encabezados
                }

                // Agregar datos del usuario
                File.AppendAllText(filePath, userData + Environment.NewLine);

                MessageBox.Show("Registro exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos después del registro
                tbNombre.Clear();
                tbEmail.Clear();
                tbCif.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
