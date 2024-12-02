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
    public partial class FrmCambiarContra : MetroFramework.Forms.MetroForm
    {
        public FrmCambiarContra()
        {
            InitializeComponent();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            FrmInitialPageUser user = new FrmInitialPageUser();
            user.Show();
        }
    }
}
