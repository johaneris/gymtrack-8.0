using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazdeUsuario.Formularios
{
    public partial class UserControl1 : UserControl
    {
        private string nombre;
        private string apellido;
        private string correo;
        private string carrera;
        private string contraseñaActual;
        private string contraseñaNueva;
        private string confirmContraseña;
        public UserControl1()
        {
            InitializeComponent();
            this.nombre = nombre;
            this.correo = correo;
            this.carrera = carrera;
            this.contraseñaActual = contraseñaActual;
        }

        private void cargarDatos()
        {
            tbNombre.Text = nombre;
            tbApellido.Text = apellido;
            tbCorreoElectro.Text = correo;
            tbCarrera.Text = carrera;
            tbContraseña.Text = contraseñaActual;
            tbNewPassword.Text = contraseñaNueva;
            tbConfirmPassword.Text = confirmContraseña;
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            string nuevoNombre = tbNombre.Text;
            string nuevoApellido = tbApellido.Text;
            string nuevaCarrera = tbCarrera.Text.Trim();
            string Nuevocorreo = tbCorreoElectro.Text.Trim();
            string contraseñaActual = tbContraseña.Text.Trim();
            string confirmarContraseña = tbConfirmPassword.Text.Trim();
            string ContraseñaNueva = tbNewPassword.Text.Trim();

            if (contraseñaActual != contraseñaActual)
            {
                MostrarError("La contraseña actual no es correcta.");
                return;
            }

            if (ContraseñaNueva != ContraseñaNueva)
            {
                MostrarError("Las contraseñas no coinciden.");
                return;
            }

            if (string.IsNullOrEmpty(nuevoNombre) || string.IsNullOrEmpty(Nuevocorreo) || string.IsNullOrEmpty(nuevaCarrera))
            {
                MessageBox.Show("Todos los campos deben ser completados.");
                return;
            }

            // Simula la actualización de datos en la base de datos
            nombre = nuevoNombre;
            correo = Nuevocorreo;
            carrera = nuevaCarrera;
            contraseñaActual = !string.IsNullOrEmpty(ContraseñaNueva) ? contraseñaNueva : contraseñaActual;

            MessageBox.Show("Perfil actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarErrores();
        }

        private void MostrarError(string mensaje)
        {
            lblErrorMessage.Text = mensaje;
            lblErrorMessage.Visible = true;
        }

        private void LimpiarErrores()
        {
            lblErrorMessage.Text = string.Empty;
            lblErrorMessage.Visible = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            cargarDatos();
            tbContraseña.Clear();
            tbConfirmPassword.Clear();
            tbContraseña.Clear();
        }
    }
}
