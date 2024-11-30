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
            
        }

        private void Btn_PerfilAdmin_Click(object sender, EventArgs e)
        {
            EditProfile edit = new EditProfile();
            this.Hide();
            edit.Show(); 
        }
    }
}
