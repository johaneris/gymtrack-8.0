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
            if (!ValidarCampos())
                return;

            try
            {
                // Crear instancia de ValidarFactura
                ValidarFactura nuevaFactura = new ValidarFactura(
                    id: 0, // Será generado automáticamente
                    numeroFactura: tbFactura.Text.Trim(),
                    referencia: tbReferencia.Text.Trim(),
                    fechaPago: dtpFechaPago.Value,
                    monto: decimal.Parse(ObtenerMonto()), // Convertir a decimal
                    miembroId: ObtenerMiembroId() // Obtener ID del miembro autenticado
                );

                // Registrar factura usando el servicio
                string resultado = facturaService.AgregarFactura(nuevaFactura);

                if (resultado.Contains("exitosamente"))
                {
                    MessageBox.Show(resultado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario(); // Limpiar formulario tras registro exitoso
                }
                else
                {
                    MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(tbFactura.Text) || string.IsNullOrWhiteSpace(tbReferencia.Text) ||cmbMonto.SelectedItem == null |cmbDuracion.SelectedItem == null)
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar número de factura (6 dígitos)
            if (!EsNumeroValido(tbFactura.Text, 6))
            {
                MessageBox.Show("El número de factura debe tener exactamente 6 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar referencia (8 dígitos)
            if (!EsNumeroValido(tbReferencia.Text, 8))
            {
                MessageBox.Show("La referencia debe tener exactamente 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool EsNumeroValido(string valor, int longitud)
        {
            return valor.Length == longitud && valor.All(char.IsDigit);
        }

        private string ObtenerMonto()
        {
            return cmbMonto.SelectedItem?.ToString() == "15$" ? "15" : "3";
        }

        private int ObtenerMiembroId()
        {
            try
            {
                int idMiembro = LoginMiembroService.ObtenerMiembroId(); // Supuesta autenticación
                if (idMiembro >= 0)
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

        

