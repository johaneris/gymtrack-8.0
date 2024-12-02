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
    public partial class FrmInitialPageUser : Form
    {
        LoginMiembroService loginMiembroService = new LoginMiembroService();
        
        public FrmInitialPageUser()
        {
            InitializeComponent();
            
        }

 
        private void BtnRegistrarMebresia_Click(object sender, EventArgs e)
        {
            ValidarMembresia validarMembresia = new ValidarMembresia();
            pnlContentUser.Controls.Clear();
            validarMembresia.Dock = DockStyle.Fill;
            pnlContentUser.Controls.Add(validarMembresia);
        }

        private void Btno_Horarios_Click(object sender, EventArgs e)
        {


            // Crear una nueva instancia del control de historial
            var historialMembresias = new HistorialDeMembresias();

            // Limpiar y cargar el panel con el control
            pnlContentUser.Controls.Clear();
            historialMembresias.Dock = DockStyle.Fill;
            pnlContentUser.Controls.Add(historialMembresias);
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            EditProfile profile = new EditProfile();
            pnlContentUser.Controls.Clear();
            profile.Dock = DockStyle.Fill;
            pnlContentUser.Controls.Add(profile);
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            this.Close();
            principal.Show();
        }
    }
}
