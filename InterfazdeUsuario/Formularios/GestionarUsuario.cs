using InterfazdeUsuario.models;
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
    public partial class GestionarUsuario : UserControl
    {
        private string Busqueda = "";
        public GestionarUsuario()
        {
            InitializeComponent();
            ActualizarDataGridView();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            FrmPrincipalAdmin admin = new FrmPrincipalAdmin();
            admin.Show();
        }

        private void ActualizarDataGridView()
        {
            var miembros = new RegistroDeMiembroService().Load();

            // Limpiamos el DataSource del DataGridView
            dgvUsuarios.DataSource = null;

            // Creamos un DataTable y definimos las columnas
            DataTable dt = new DataTable();
                        dt.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID"),
                new DataColumn("Nombre"),
                new DataColumn("Apellido"),
                new DataColumn("Tipo de Usuario"),
                new DataColumn("Email"),
                new DataColumn("CIF"),
                new DataColumn("Cédula"),
                new DataColumn("Fecha de Registro"),
            });

            // Iteramos sobre la lista de miembros y añadimos filas al DataTable
            foreach (RegistroMiembro miembro in miembros)
            {
                if (Busqueda != string.Empty)
                {
                    if (!miembro.Email.Contains(Busqueda))
                    {
                        continue;
                    }
                }

                    dt.Rows.Add(new object[] {
                    miembro.ID,
                    miembro.Name,
                    miembro.LastName,
                    miembro.UserType,
                    miembro.Email,
                    miembro.Cif,
                    miembro.Cedula,
                    miembro.FechaRegistro.ToShortDateString(),
                });
            }

            // Asignamos el DataTable como DataSource del DataGridView
            dgvUsuarios.DataSource = dt;
        }

        private void txt_CorreoBusqueda_TextChanged(object sender, EventArgs e)
        {
            Busqueda = txt_CorreoBusqueda.Text;
            ActualizarDataGridView();
        }
    }
}
