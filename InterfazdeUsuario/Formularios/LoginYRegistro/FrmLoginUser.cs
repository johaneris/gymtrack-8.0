using InterfazdeUsuario;
using InterfazdeUsuario.Dao;
using InterfazdeUsuario.Service;
using MetroFramework;
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
        LoginMiembroService loginMiembroService;
        public FrmLoginUser()
        {
            InitializeComponent();
            loginMiembroService = new LoginMiembroService();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            this.Close();
            principal.Show();
        }

        private void lnkCambiarcContra2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmResetPassword resetPassword = new FrmResetPassword();
            this.Hide();
            resetPassword.ShowDialog();
            this.Show();
        }       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegisterUser register = new FrmRegisterUser();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }

        private void btnLoginUser_Click(object sender, EventArgs e)
        {
            string identificador = tbCifPasswordLogin.Text.Trim();
            string password = tbPasswordLogin.Text.Trim();

            // Validar si los campos están vacíos
            if (string.IsNullOrEmpty(identificador) || string.IsNullOrEmpty(password))
            {
                MetroMessageBox.Show(this, "Por favor, complete ambos campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar las credenciales
            if (loginMiembroService.AutenticarUsuario(identificador, password))
            {
                FrmInitialPageUser initialPage = new FrmInitialPageUser();
                this.Hide();
                initialPage.ShowDialog();
                this.Close(); // Cerrar la ventana de login.
            }
            else
            {
                MetroMessageBox.Show(this, "Identificador o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}