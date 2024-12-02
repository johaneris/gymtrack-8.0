using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
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
    public partial class FrmPrincipalAdmin : Form
    {
        public FrmPrincipalAdmin()
        {
            InitializeComponent();
        }

        

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            pnl_ContenidoAdmin.Controls.Clear();
            reportes.Dock = DockStyle.Fill;

            pnl_ContenidoAdmin.Controls.Add(reportes);


        }

        private void btnGestionarmemresias_Click(object sender, EventArgs e)
        {
            GestionDemembresias membresias = new GestionDemembresias();
            pnl_ContenidoAdmin.Controls.Clear();
            membresias.Dock = DockStyle.Fill;

            pnl_ContenidoAdmin.Controls.Add(membresias);
        }

        private void Btn_PerfilAdmin_Click(object sender, EventArgs e)
        {
            EditProfile edit = new EditProfile();
            pnl_ContenidoAdmin.Controls.Clear();
            edit.Dock = DockStyle.Fill;

            pnl_ContenidoAdmin.Controls.Add(edit);
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            this.Close();
            principal.Show();
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            GestionarUsuario user = new GestionarUsuario();
            pnl_ContenidoAdmin.Controls.Clear();
            user.Dock = DockStyle.Fill;

            pnl_ContenidoAdmin.Controls.Add(user);
        }
    }
}
