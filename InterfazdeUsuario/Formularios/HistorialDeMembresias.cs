using InterfazdeUsuario.Dao;
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
    public partial class HistorialDeMembresias : UserControl
    {
        
        private MembresiaService membresiaService;
        private int miembroId;


        public HistorialDeMembresias()
        {
            InitializeComponent();
            
            membresiaService = new MembresiaService();
            CargarHistorialMembresias();
        }

        public HistorialDeMembresias(int miembroId) : this()
        {
            this.miembroId = miembroId;
        }

        private void HistorialDeMembresias_Load(object sender, EventArgs e)
        {
            CargarHistorialMembresias();
        }

        public void Cerrar()
        {
            LimpiarHistorial();
            ((Form)this.Parent).Close();
        }

        private void CargarHistorialMembresias()
        {

            try
            {
                if (miembroId < 0)
                {
                    MessageBox.Show("ID del miembro no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var historial = membresiaService.ObtenerHistorialDeMembresias(miembroId);

                dgvHistorialDeMembresias.DataSource = null;

                if (historial == null || !historial.Any())
                {
                    MessageBox.Show("No hay historial de membresías para este miembro.", "Información");
                    return;
                }

                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn("# de Factura"),
                    new DataColumn("# de Referencia"),
                    new DataColumn("Fecha Pago"),
                    new DataColumn("Fecha Finalización"),
                    new DataColumn("Activa")
                });

                foreach (ValidarFactura f in historial)
                {
                    dt.Rows.Add(f.NumeroFactura, f.Referencia, f.FechaPago.ToShortDateString(),
                                f.FechaPago.Add(f.DuracionMembresia).ToShortDateString(), f.Estado ? "Sí" : "No");
                }

                dgvHistorialDeMembresias.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el historial: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LimpiarHistorial()
        {
            dgvHistorialDeMembresias.DataSource = null;
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            LimpiarHistorial();
            FrmPrincipalAdmin admin = new FrmPrincipalAdmin();
            admin.Show();

            Cerrar();
        }
    }

}