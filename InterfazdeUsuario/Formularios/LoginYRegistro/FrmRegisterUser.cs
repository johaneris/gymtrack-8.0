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
        public FrmRegisterUser()
        {
            InitializeComponent();
        }

        private void lnkCambiarcContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLoginUser login = new FrmLoginUser();
            this.Hide();
            login.ShowDialog();
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            string name = tbNombre.Text.Trim();
            string lastname = tbApellido.Text.Trim();
            string email = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();
            string cif = string.Empty;    
            string cedula = string.Empty; 
            string userType;

            // Determinar el tipo de usuario según los RadioButton
            if (rbtnUserType.Checked)
            {
                userType = "Estudiante";
                cif = tbIdentify.Text.Trim(); // CIF ingresado
            }
            else if (rbtnUserType2.Checked)
            {
                userType = "Miembro Externo";
                cedula = tbIdentify.Text.Trim(); // Cédula ingresada
            }
            else
            {
                MetroMessageBox.Show(this, "Seleccione un tipo de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Llamar al servicio de registro
            RegisterService service = new RegisterService(new RegistroMiembroDao(), new RegistroDeMiembroService());
            string resultado = service.RegisterMember(name, lastname, email, password, userType, cif, cedula);

            // Mostrar mensaje y actuar según el resultado
            if (resultado == "Registro exitoso.")
            {
                MetroMessageBox.Show(this, resultado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmLoginUser login = new FrmLoginUser();
                this.Close();
                login.Show();
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

