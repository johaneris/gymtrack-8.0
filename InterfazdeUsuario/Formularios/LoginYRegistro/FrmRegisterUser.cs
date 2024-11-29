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
using MetroFramework;
using InterfazdeUsuario.Dao;
using InterfazdeUsuario.Service;


namespace InterfazdeUsuario.Formularios
{
    public partial class FrmRegisterUser : MetroFramework.Forms.MetroForm
    {
        private RegisterService service;
        public FrmRegisterUser()
        {
            InitializeComponent();
            service = new RegisterService(new RegistroDeMiembroService());
        }

        private void lnkCambiarcContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLoginUser login = new FrmLoginUser();
            this.Hide();
            login.ShowDialog();
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            // Capturar valores del formulario
            string name = tbNombre.Text.Trim();
            string lastname = tbApellido.Text.Trim();
            string email = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();
            string userType = string.Empty;
            string cif = string.Empty;
            string cedula = string.Empty;

            // Determinar el tipo de usuario según los RadioButton
            if (rbtnUserType.Checked)
            {
                userType = "Estudiante";
                cif = tbIdentify.Text.Trim();
            }
            else if (rbtnUserType2.Checked)
            {
                userType = "Miembro Externo";
                cedula = tbIdentify.Text.Trim();
            }
            else
            {
                MetroMessageBox.Show(this, "Seleccione un tipo de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Registrar miembro
            string resultado = service.RegisterMember(name, lastname, email, password, userType, cif, cedula);

            // Mostrar mensaje según el resultado
            if (resultado == "Registro exitoso.")
            {
                MetroMessageBox.Show(this, resultado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                new FrmLoginUser().Show();
            }
            else
            {
                MetroMessageBox.Show(this, resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmLoginUser login = new FrmLoginUser();
            this.Close();
            login.Show();
        }
    }
}

