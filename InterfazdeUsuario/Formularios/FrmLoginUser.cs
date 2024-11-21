using InterfazdeUsuario;
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

        private void FrmLoginUser_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FrmRegisterUser register = new FrmRegisterUser();
            register.ShowDialog();
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

        private void btnLoginUser_Click(object sender, EventArgs e)
        {
         
        }
    }
}


