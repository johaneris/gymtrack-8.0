using InterfazdeUsuario.models;
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
    public partial class FrmLoginAdmin : MetroFramework.Forms.MetroForm
    {
        LoginService loginService = new LoginService();
        Admin admin;
        public FrmLoginAdmin()
        {
            InitializeComponent();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            this.Close();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string user = tbUser.Text;
            string password = TbPassword.Text;
            this.Close();

            string autenticar = loginService.Authenticate(user, password); 

            if (autenticar == "ok")
            {
                FrmPrincipalAdmin admin = new FrmPrincipalAdmin();
                
                admin.Show();
                //FrmInitialPageUser initialPage = new FrmInitialPageUser();
                //this.Hide();
                //initialPage.ShowDialog();
                //this.Close(); // Cerrar la ventana de login.
            }
            else
            {
                MetroMessageBox.Show(this, autenticar, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
              
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmPrincipal admin = new FrmPrincipal();
            this.Close();
            
        
        }
    }
}
