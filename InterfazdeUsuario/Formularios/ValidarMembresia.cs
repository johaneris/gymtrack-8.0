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
        LoginMiembroService loginService = new LoginMiembroService();
        
        public ValidarMembresia()
        {
            InitializeComponent();
            // Inicializa el DAO y el Servicio de Facturas

            facturaService = new ValidarFacturaService(facturaDao, loginService);


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
            else
            {
                MessageBox.Show("Por favor, selecciona un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegistarMembresia_Click(object sender, EventArgs e)
        {
            string identificador = tbCif_cedula.Text.Trim();
            if (!ValidarIdentificador(identificador, out string tipoUsuario))
            {
                MessageBox.Show("El identificador no es válido. Ingrese un CIF o Cédula correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ValidarFactura nuevaFactura = CrearFactura(identificador, tipoUsuario);

            string resultado = facturaService.AgregarFactura(nuevaFactura);

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

        private bool ValidarIdentificador(string identificador, out string tipoUsuario)
        {
            tipoUsuario = string.Empty;

            if (loginService.EsEstudiante(identificador))
            {
                tipoUsuario = "CIF";
                return true;
            }
            if (loginService.EsMiembroExterno(identificador))
            {
                tipoUsuario = "Cédula";
                return true;
            }

            return false;
        }
        private ValidarFactura CrearFactura(string identificador, string tipoUsuario)
        {
            return new ValidarFactura
            {
                Id = facturaService.ObtenerHistorialDeMembresias(identificador).Count + 1,
                NameMembresia = tbNombreMembresia.Text.Trim(),
                CifMembresia = tipoUsuario == "CIF" ? identificador : "",
                CedulaMembresia = tipoUsuario == "Cédula" ? identificador : "",
                CelularMembresia = tbCelular.Text.Trim(),
                NumeroFactura = tbFactura.Text.Trim(),
                Referencia = tbReferencia.Text.Trim(),
                Fechapago = dtpFechaPago.Value,
                Monto = cmbMonto.SelectedItem?.ToString().Replace("$", "").Trim(),
                Duracionmembresia = cmbDuracion.SelectedItem?.ToString(),
                Estado = false
            };
        }

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
        

