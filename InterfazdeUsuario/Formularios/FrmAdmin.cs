﻿using System;
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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportes frm = new FrmReportes();    
            frm.ShowDialog();
        }
    }
}
