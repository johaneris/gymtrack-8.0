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
            ((Form)this.Parent).Close();
        }

        private void CargarHistorialMembresias()
        {

            try
            {
                if (membresiaService == null)
                    throw new InvalidOperationException("El servicio de membresías no está inicializado.");
                if (miembroId < 0)
                    throw new ArgumentException("El ID del miembro no es válido.");

                var miembros = new RegistroDeMiembroService().Load();

                bool miembroEncontrado = false;
                RegistroMiembro miembroHistorial;
                foreach (RegistroMiembro m in miembros)
                {
                    if (m.ID == miembroId)
                    {
                        miembroEncontrado = true;
                        miembroHistorial = m;
                        break;
                    }
                }

                if (!miembroEncontrado)
                {
                    MessageBox.Show("No se encontró el miembro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var historial = membresiaService.ObtenerHistorialDeMembresias(miembroId);

                if (historial == null || !historial.Any())
                {
                    MessageBox.Show("No hay historial de membresías para este miembro.", "Información");
                    return;
                }

                dgvHistorialDeMembresias.DataSource = null;

                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[] { new DataColumn("# de Factura"), new DataColumn("# de Referncia"),
                    new DataColumn("Fecha Pago"), new DataColumn("FechaFinalización"), new DataColumn("Activa") });

                foreach (ValidarFactura f in historial)
                {
                    dt.Rows.Add(new object[] {f.NumeroFactura, f.Referencia, f.FechaPago.ToShortDateString(),
                    f.FechaPago.Add(f.DuracionMembresia).ToShortDateString(), f.Estado ? "Sí" : "No"});
                }

                dgvHistorialDeMembresias.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el historial: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            FrmPrincipalAdmin admin = new FrmPrincipalAdmin();
            admin.Show();

            Cerrar();
        }
    }

}