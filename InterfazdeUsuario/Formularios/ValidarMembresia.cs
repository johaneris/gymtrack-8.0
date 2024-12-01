using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazdeUsuario.Service;
using InterfazdeUsuario.Dao;
using InterfazdeUsuario.models;

namespace InterfazdeUsuario.Formularios
{
    public partial class ValidarMembresia : UserControl
    {

        // Variables DAO y Service
        private ValidarFacturaDao facturaDao;
        private ValidarFacturaService facturaService;
        public ValidarMembresia()
        {
            InitializeComponent();
            // Inicializa el DAO y el Servicio de Facturas

            // Inicializar las instancias de DAO y Service
            facturaDao = new ValidarFacturaDao();
            facturaService = new ValidarFacturaService(new RegistroMiembroDao());


            // Configuración inicial del formulario
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            cmbMonto.Items.Add("15$");
            cmbMonto.Items.Add("3$");

            dtpFechaPago.MinDate = new DateTime(2024, 11, 1);
            dtpFechaPago.MaxDate = new DateTime(2025, 12, 31);

            // Validar que SelectedItem no sea null
            if (cmbMonto.SelectedItem != null)
            {
                string valorSeleccionado = cmbMonto.SelectedItem.ToString();

                // Limpiar el ComboBox de duraciones
                cmbDuracion.Items.Clear();

                if (valorSeleccionado == "15$")
                {
                    cmbDuracion.Items.Add("Un mes");
                }
                else if (valorSeleccionado == "3$")
                {
                    cmbDuracion.Items.Add("Un día");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void cmbMonto_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Validar que SelectedItem no sea null
            if (cmbMonto.SelectedItem != null)
            {
                string valorSeleccionado = cmbMonto.SelectedItem.ToString();

                // Limpiar el ComboBox de duraciones
                cmbDuracion.Items.Clear();

                if (valorSeleccionado == "15$")
                {
                    cmbDuracion.Items.Add("Un mes");
                }
                else if (valorSeleccionado == "3$")
                {
                    cmbDuracion.Items.Add("Un día");
                }
            }
            //else
            //{
            //    MessageBox.Show("Por favor, selecciona un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void btnRegistarMembresia_Click(object sender, EventArgs e)
        {

            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(tbFactura.Text) ||
                string.IsNullOrWhiteSpace(tbReferencia.Text) ||
                cmbMonto.SelectedItem == null)
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validación del número de factura: debe ser numérico y tener 6 dígitos
            if (!EsNumeroValido(tbFactura.Text, 6))
            {
                MessageBox.Show("El número de factura debe contener exactamente 6 dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validación del número de referencia: debe ser numérico y tener 8 dígitos
            if (!EsNumeroValido(tbReferencia.Text, 8))
            {
                MessageBox.Show("La referencia debe contener exactamente 8 dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear nueva instancia de ValidarFactura
            ValidarFactura nuevaFactura = new ValidarFactura(
                id: 0, // Será generado automáticamente
                numeroFactura: tbFactura.Text,
                referencia: tbReferencia.Text,
                fechapago: dtpFechaPago.Value,
                monto: ObtenerMonto(),
                duracion: string.Empty, // Se calculará en el servicio
                estado: false, // Se actualizará según la lógica del servicio
                miembroid: ObtenerMiembroId()
            );

            // Intentar registrar la factura a través del servicio
            string resultado = facturaService.AgregarFactura(nuevaFactura);

            // Mostrar el resultado al usuario
            if (resultado.Contains("registrada exitosamente"))
            {
                MessageBox.Show(resultado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario(); // Limpia el formulario tras un registro exitoso
            }
            else
            {
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EsNumeroValido(string valor, int longitud)
        {
            return valor.Length == longitud && valor.All(char.IsDigit);
        }

        private string ObtenerMonto()
        {
            return cmbMonto.SelectedItem.ToString() == "15$" ? "15" : "3";
        }

        private int ObtenerMiembroId()
        {
            try
            {
                int idMiembro = LoginMiembroService.ObtenerMiembroId(); // Supuesta autenticación
                if (idMiembro > 0)
                {
                    return idMiembro;
                }
                throw new Exception("No se encontró un miembro autenticado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener ID de miembro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void LimpiarFormulario()
        {
            
            tbFactura.Clear();
            tbReferencia.Clear();
            cmbMonto.SelectedIndex = -1;
            cmbDuracion.Items.Clear();
            dtpFechaPago.Value = DateTime.Today;
        }
    }
}
        

