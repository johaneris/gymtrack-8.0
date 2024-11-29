using InterfazdeUsuario.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using InterfazdeUsuario.Dao;
using System.Text;
using System.Threading.Tasks;

namespace InterfazdeUsuario.Service
{
    public class ValidarFacturaService
    {
        private string filepath = "facturas.bin";
        private ValidarFacturaDao facturaDao;
        private LoginMiembroService loginService;

        public ValidarFacturaService(ValidarFacturaDao dao, LoginMiembroService loginService)
        {
            this.facturaDao = dao;
            this.loginService = loginService;
        }

        public string AgregarFactura(ValidarFactura nuevaFactura)
        {
            try
            {
                // Validar los datos de la factura
                if (!ValidarFacturaDatos(nuevaFactura, out string mensajeError))
                    return mensajeError;

                // Validar si el usuario es estudiante o miembro externo
                if (!ValidarTipoDeUsuario(nuevaFactura, out mensajeError))
                    return mensajeError;

                // Verificar duplicados
                if (FacturaDuplicada(nuevaFactura, out mensajeError))
                    return mensajeError;

                // Asignar ID único
                nuevaFactura.Id = facturaDao.ObtenerTodasLasFacturas().Count > 0
                    ? facturaDao.ObtenerTodasLasFacturas().Max(f => f.Id) + 1
                    : 1;

                // Calcular duración de membresía y estado inicial
                CalcularDuracionMembresia(nuevaFactura);

                // Registrar factura
                facturaDao.AgregarFactura(nuevaFactura);
                GuardarFacturasEnArchivo();

                return "Factura registrada exitosamente.";
            }
            catch (Exception ex)
            {
                return $"Error al agregar factura: {ex.Message}";
            }
        }

        private bool ValidarFacturaDatos(ValidarFactura factura, out string mensajeError)
        {
            mensajeError = string.Empty;

            if (string.IsNullOrWhiteSpace(factura.Referencia) || factura.Referencia.Length != 8 || !factura.Referencia.All(char.IsDigit))
            {
                mensajeError = "La referencia debe contener exactamente 8 dígitos numéricos.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(factura.NumeroFactura) || factura.NumeroFactura.Length != 6 || !factura.NumeroFactura.All(char.IsDigit))
            {
                mensajeError = "El número de factura debe contener exactamente 6 dígitos numéricos.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(factura.Monto) || (factura.Monto != "15" && factura.Monto != "3"))
            {
                mensajeError = "El monto debe ser de 15 o 3 dólares.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(factura.Duracionmembresia))
            {
                mensajeError = "La duración de la membresía no ha sido seleccionada.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(factura.NameMembresia) || factura.NameMembresia.Length < 3)
            {
                mensajeError = "El nombre de la membresía debe tener al menos 3 caracteres.";
                return false;
            }

            return true;
        }

        private bool ValidarTipoDeUsuario(ValidarFactura factura, out string mensajeError)
        {
            mensajeError = string.Empty;

            if (!string.IsNullOrWhiteSpace(factura.CifMembresia) && loginService.EsEstudiante(factura.CifMembresia))
            {
                // Es un estudiante
                return true;
            }

            if (!string.IsNullOrWhiteSpace(factura.CedulaMembresia) && loginService.EsMiembroExterno(factura.CedulaMembresia))
            {
                // Es un miembro externo
                return true;
            }

            mensajeError = "El CIF o cédula no corresponde a un estudiante o miembro externo registrado.";
            return false;
        }

        private bool FacturaDuplicada(ValidarFactura nuevaFactura, out string mensajeError)
        {
            mensajeError = string.Empty;

            var facturasExistentes = facturaDao.ObtenerTodasLasFacturas();

            if (facturasExistentes.Any(f => f.NumeroFactura == nuevaFactura.NumeroFactura))
            {
                mensajeError = "Ya existe una factura con el mismo número.";
                return true;
            }

            if (facturasExistentes.Any(f => f.Referencia == nuevaFactura.Referencia))
            {
                mensajeError = "Ya existe una factura con la misma referencia.";
                return true;
            }

            return false;
        }

        private void CalcularDuracionMembresia(ValidarFactura factura)
        {
            factura.Duracionmembresia = factura.Monto == "15" ? "30 días" : "1 día";
            factura.Fechapago = DateTime.Now.AddDays(factura.Monto == "15" ? 30 : 1);
            factura.Estado = true; // Activa inicialmente
        }

        public void GuardarFacturasEnArchivo()
        {
            try
            {
                using (var fs = new FileStream(filepath, FileMode.Create, FileAccess.Write))
                using (var bw = new BinaryWriter(fs))
                {
                    foreach (var factura in facturaDao.ObtenerTodasLasFacturas())
                    {
                        bw.Write(factura.Id);
                        bw.Write(factura.NameMembresia);
                        bw.Write(factura.CifMembresia ?? "");
                        bw.Write(factura.CedulaMembresia ?? "");
                        bw.Write(factura.CelularMembresia ?? "");
                        bw.Write(factura.NumeroFactura);
                        bw.Write(factura.Referencia);
                        bw.Write(factura.Fechapago.ToBinary());
                        bw.Write(factura.Monto);
                        bw.Write(factura.Duracionmembresia);
                        bw.Write(factura.Estado);
                    }
                }
            }
            catch (IOException ex)
            {
                throw new Exception("Error al guardar las facturas en archivo.", ex);
            }
        }

        public List<ValidarFactura> ObtenerHistorialDeMembresias(string identificador)
        {
            try
            {
                var todasLasFacturas = facturaDao.ObtenerTodasLasFacturas();

                // Filtrar facturas según el identificador (CIF o Cédula)
                return todasLasFacturas
                    .Where(f => f.CifMembresia == identificador || f.CedulaMembresia == identificador)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el historial de membresías.", ex);
            }
        }
    }
}
