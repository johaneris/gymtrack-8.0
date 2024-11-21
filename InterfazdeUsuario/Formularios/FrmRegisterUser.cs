using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MetroFramework;
using InterfazdeUsuario.Dao;
using InterfazdeUsuario.Service;


namespace InterfazdeUsuario.Formularios
{
    public partial class FrmRegisterUser : MetroFramework.Forms.MetroForm
    {
        public FrmRegisterUser()
        {
            InitializeComponent();
        }

        private void lnkCambiarcContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLoginUser login = new FrmLoginUser();
            this.Hide();
            login.ShowDialog();
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            string name = tbEmail.Text.Trim();
            string lastname = tbApellido.Text.Trim();
            string email = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();
            string identify = tbIdentify.Text.Trim();
            string usertype;

            if (rbtnUserType.Checked)
            {
                usertype = "Estudiante";
            }
            else if (rbtnUserType.Checked)
            {
                usertype = "Persona Externa";
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            RegisterService service = new RegisterService(new RegistroMiembroDao(), new RegistroDeMiembroService());
            string resultado = service.RegisterMember(name, lastname, email, password, usertype, identify);

            MetroMessageBox.Show(this, resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmLoginUser login = new FrmLoginUser();
            this.Close();
            login.Show();
        }
    }
}

