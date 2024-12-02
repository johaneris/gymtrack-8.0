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
    public partial class GestionDemembresias : UserControl
    {
        private string buscar = "";
        public GestionDemembresias()
        {
            InitializeComponent();
            ActualizarDataGridView();
        }

        private void ActualizarDataGridView()
        {
            // Cargar datos de servicios
            var miembros = new RegistroDeMiembroService().Load();
            var facturas = new ValidarFacturaService().Load();

            // Crear DataTable con todas las columnas necesarias
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
        new DataColumn("N° de Factura"),
        new DataColumn("Referencia"),
        new DataColumn("Monto"),
        new DataColumn("Duración"),
        new DataColumn("Estado"),
    });

            // Unir miembros y facturas por miembro ID
            foreach (var miembro in miembros)
            {
                // Filtrar miembros por búsqueda
                if (!string.IsNullOrEmpty(buscar) && !miembro.Email.Contains(buscar))
                    continue;

                // Buscar factura asociada
                var factura = facturas.FirstOrDefault(f => f.MiembroId == miembro.ID);

                // Agregar fila al DataTable
                dt.Rows.Add(new object[] {
            miembro.ID,
            miembro.Name,
            miembro.LastName,
            miembro.UserType,
            miembro.Email,
            miembro.Cif,
            miembro.Cedula,
            miembro.FechaRegistro.ToShortDateString(),
            factura?.NumeroFactura ?? "Sin factura",
            factura?.Referencia ?? "Sin referencia",
            factura?.Monto ?? 0,
            factura != null ? "Activo" : "Inactivo"
        });
            }

            // Asignar DataTable al DataGridView
            dgvMembresiasGestion.DataSource = dt;



        }
    }   
}
