using InterfazdeUsuario;
using InterfazdeUsuario.Dao;
using InterfazdeUsuario.Service;
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
    public partial class FrmLoginUser : MetroFramework.Forms.MetroForm
    {
        public FrmLoginUser()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            this.Close();
            principal.Show();
        }

        private void lnkCambiarcContra2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmResetPassword resetpassword = new FrmResetPassword();
            this.Hide();
            resetpassword.ShowDialog(); 
        }       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegisterUser register = new FrmRegisterUser();
            this.Hide();
            register.ShowDialog();
        }

        private void btnLoginUser_Click(object sender, EventArgs e)
        {
            string cifCedula = tbCifPasswordLogin.Text.Trim();
            string password = tbPasswordLogin.Text.Trim();

            //validar si los campos estan vacíos
            if(string.IsNullOrEmpty(cifCedula) || string.IsNullOrEmpty(password) )
            {
                MessageBox.Show("Por favor, complete los dos campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Autenticar archivos
            RegistroMiembroDao registroDao = new RegistroMiembroDao();

            // Verificar las credenciales con el método AutenticarUsuario
            bool isAuthenticated = registroDao.AutenticarUsuario(cifCedula, password); ;

            //validar el resultado
            if(isAuthenticated)
            {
                MessageBox.Show("Inicio se sesion exitoso.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmInitialPageUser initialpage = new FrmInitialPageUser();
                this.Hide();
                initialpage.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Cif/Cedula o contraseña son incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}