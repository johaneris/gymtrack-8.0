using InterfazdeUsuario.Formularios;
using Spire.Additions.Xps.Schema;
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using InterfazdeUsuario.Service;

namespace InterfazdeUsuario
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            //imagenDelForm();
            this.Text =string.Empty;
            this.DoubleBuffered = true;
            //el maxomizado de la pantalal igual al area de trabajo
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            //ManualDeAyuda();
        }        

        private void btnAbout_Click(object sender, EventArgs e)
        {

            FrmAbout frm = new FrmAbout();
            frm.Show();
           
        }       

        private void btnAyuda_Click_1(object sender, EventArgs e)
        {
            MnualDeAyuda ayuda = new MnualDeAyuda();
            ayuda.ManualDeAyuda();


        }

        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            FrmAbout frm = new FrmAbout();
            frm.Show();
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            FrmLogin admin = new FrmLogin();
            this.Hide();
            admin.ShowDialog();
            
        }

        private void btnMiembros_Click(object sender, EventArgs e)
        {
            FrmLoginUser user = new FrmLoginUser();
            this.Hide();
            user.ShowDialog();
        }
    }
}
