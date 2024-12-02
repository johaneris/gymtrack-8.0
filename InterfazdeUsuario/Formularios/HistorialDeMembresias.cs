using InterfazdeUsuario.Dao;
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



        private void CargarHistorialMembresias()
        {

            try
            {
                if (membresiaService == null)
                    throw new InvalidOperationException("El servicio de membresías no está inicializado.");

                if (miembroId <= 0)
                    throw new ArgumentException("El ID del miembro no es válido.");

                var historial = membresiaService.ObtenerHistorialDeMembresias(miembroId);

                if (historial == null || !historial.Any())
                {
                    MessageBox.Show("No hay historial de membresías para este miembro.", "Información");
                    return;
                }

                dgvHistorialDeMembresias.DataSource = historial.Select(f => new
                {
                    Nombre = f.Referencia,
                    CIFoCedula = f.MiembroId,
                    FechaPago = f.FechaPago.ToShortDateString(),
                    FechaFinalizacion = f.FechaPago.Add(f.DuracionMembresia).ToShortDateString(),
                    Activa = f.Estado ? "Sí" : "No"
                }).ToList();
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
        }
    }

}