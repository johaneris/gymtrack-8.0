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
    }
}
