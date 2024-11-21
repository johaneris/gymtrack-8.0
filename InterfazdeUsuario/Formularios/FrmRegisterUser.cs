﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace InterfazdeUsuario.Formularios
{
    public partial class FrmRegisterUser : MetroFramework.Forms.MetroForm
    {
        public FrmRegisterUser()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
           FrmLoginUser user2 = new FrmLoginUser();
            user2.ShowDialog();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            this.Close();
            principal.Show();
        }

        private void lnkCambiarcContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLoginUser login = new FrmLoginUser();
            this.Hide();
            login.ShowDialog();
        }
    }
}
