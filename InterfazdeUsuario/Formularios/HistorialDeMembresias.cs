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
        private string Identificador;
        LoginMiembroService loginMiembroService = new LoginMiembroService();
        
       
        public HistorialDeMembresias()
        {
            InitializeComponent();
           CargarHistorialMembresias();

        }

        private void HistorialDeMembresias_Load(object sender, EventArgs e)
        {
            CargarHistorialMembresias();
        }

        

        private void CargarHistorialMembresias()
        {

            //string identificador = loginMiembroService.ObtenerIdentificador();
            //// Obtener el identificador del usuario autenticado
            

            //if (string.IsNullOrEmpty(identificador))
            //{
            //    MessageBox.Show("No se pudo obtener el identificador del usuario.", "Error");
            //    return;
            //}

            //ValidarFacturaService validar = new ValidarFacturaService(new ValidarFacturaDao(), new LoginMiembroService());
            //validar.CargarFacturasDesdeArchivo();
            //validar.EstadoFactura();


            // Filtrar las facturas por el identificador
            //var historial = validar.ObtenerHistorialDeMembresias(identificador);
            //ValidarFacturaService validar = new ValidarFacturaService(new ValidarFacturaDao(), new LoginMiembroService());
            //validar.CargarFacturasDesdeArchivo();
            //validar.EstadoFactura();

            //var historial = validar.ConsultarFacturas();
            //dgvHistorialDeMembresias.Rows.Clear();

            //if (historial == null || !historial.Any())
            //{
            //    MessageBox.Show("No se encontraron membresías registradas.", "Información");
            //    return;
            //}

            //foreach (var factura in historial)
            //{
            //    dgvHistorialDeMembresias.Rows.Add(
            //        factura.NameMembresia,
            //        factura.CifMembresia ?? factura.CedulaMembresia, // Mostrar CIF o Cédula según aplique
            //        factura.Fechapago.ToString("dd/MM/yyyy HH:mm"),  // Fecha y hora de pago
            //        factura.Monto == "15" ? factura.Fechapago.AddDays(30).ToString("dd/MM/yyyy HH:mm") :
            //                                factura.Fechapago.AddHours(4).ToString("dd/MM/yyyy HH:mm"), // Fecha final
            //        factura.Estado ? "Activo" : "Inactivo" // Estado
            //    );
            //}
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            FrmPrincipalAdmin admin = new FrmPrincipalAdmin();
            admin.Show();
        }
    }

}