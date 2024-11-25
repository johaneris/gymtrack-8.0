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
        ValidarFacturaService facturaService;
        ValidarFacturaDao facturaDao = new ValidarFacturaDao();
        LoginMiembroDao loginMiembroDao = new LoginMiembroDao();
        LoginMiembroService loginService2 = new LoginMiembroService();
        
        public ValidarMembresia()
        {
            InitializeComponent();
            // Inicializa el DAO y el Servicio de Facturas

            facturaService = new ValidarFacturaService(facturaDao, loginService2);


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
            if(cmbMonto.SelectedItem.ToString() == "15$")
            {
                cmbMonto.Items.Clear();
                cmbDuracion.Items.Add("Un mes");

            }
            else if (cmbMonto.SelectedItem.ToString() == "3")
            {
                cmbMonto.Items.Clear();
                cmbMonto.Items.Add("Un día");
            }
        }

        private void btnRegistarMembresia_Click(object sender, EventArgs e)
        {
            string nameMembresia = tbNombreMembresia.Text.Trim();
            string identificador = tbCif_cedula.Text.Trim(); // CIF o cédula
            string celularMembresia = tbCelular.Text.Trim();
            string numeroFactura = tbFactura.Text.Trim();
            string referencia = tbReferencia.Text.Trim();
            string monto = cmbMonto.SelectedItem?.ToString().Replace("$", "").Trim();

            // Validar campos requeridos
            if (string.IsNullOrWhiteSpace(nameMembresia) || string.IsNullOrWhiteSpace(identificador) ||
                string.IsNullOrWhiteSpace(celularMembresia) || string.IsNullOrWhiteSpace(numeroFactura) ||
                string.IsNullOrWhiteSpace(referencia) || string.IsNullOrWhiteSpace(monto))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear la factura
            ValidarFactura nuevaFactura = new ValidarFactura
            {

                Id = facturaService.ObtenerHistorialDeMembresias(identificador).Count + 1,
                NameMembresia = nameMembresia,
                CifMembresia = loginService2.EsEstudiante() ? identificador : "",
                CedulaMembresia = loginService2.EsMiembroExterno() ? identificador : "",
                CelularMembresia = celularMembresia,
                NumeroFactura = numeroFactura,
                Referencia = referencia,
                Fechapago = DateTime.Today,
                Monto = monto,
                Duracionmembresia = "",
                Estado = false
            };

            // Registrar factura
            string resultado = facturaService.AgregarFactura(nuevaFactura);

            // Mostrar resultado
            if (resultado == "Factura registrada exitosamente.")
            {
                MessageBox.Show(resultado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para limpiar el formulario después de un registro exitoso
        private void LimpiarFormulario()
        {
            tbNombreMembresia.Clear();
            tbCif_cedula.Clear();
            tbCelular.Clear();
            tbFactura.Clear();
            tbReferencia.Clear();
            cmbMonto.SelectedIndex = -1;
            cmbDuracion.Items.Clear();
            dtpFechaPago.Value = DateTime.Today;
        }
    }
    }

