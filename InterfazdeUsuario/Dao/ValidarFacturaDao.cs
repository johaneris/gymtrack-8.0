using InterfazdeUsuario.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazdeUsuario.Dao
{

    public class ValidarFacturaDao
    {
        // Lista para almacenar facturas en memoria
        private List<ValidarFactura> facturas;

        // Constructor para inicializar la lista
        public ValidarFacturaDao()
        {
            facturas = new List<ValidarFactura>();
        }

        // Método para cargar facturas desde la lista en memoria (útil para Service)
        public List<ValidarFactura> ObtenerFacturas()
        {
            return new List<ValidarFactura>(facturas); // Retorna una copia para evitar modificaciones externas
        }

        // Método para agregar una nueva factura
        public bool AgregarFactura(ValidarFactura nuevaFactura)
        {
            if (nuevaFactura == null) throw new ArgumentNullException(nameof(nuevaFactura));

            // Validar que no exista una factura duplicada
            if (facturas.Any(f => f.NumeroFactura == nuevaFactura.NumeroFactura &&
                                  f.Referencia == nuevaFactura.Referencia))
            {
                return false; // Ya existe una factura con el mismo número y referencia
            }

            facturas.Add(nuevaFactura);
            return true; // Factura agregada con éxito
        }

        // Método para buscar una factura por número y referencia
        public ValidarFactura BuscarPorNumeroYReferencia(string numeroFactura, string referencia)
        {
            if (string.IsNullOrWhiteSpace(numeroFactura) || string.IsNullOrWhiteSpace(referencia))
                throw new ArgumentException("Número de factura y referencia no pueden estar vacíos.");

            return facturas.FirstOrDefault(f => f.NumeroFactura == numeroFactura && f.Referencia == referencia);
        }

        // Método para buscar una factura por su ID
        public ValidarFactura BuscarPorId(int id)
        {
            return facturas.FirstOrDefault(f => f.Id == id);
        }

        // Método para actualizar una factura por ID
        public bool ActualizarFactura(ValidarFactura facturaActualizada)
        {
            if (facturaActualizada == null) throw new ArgumentNullException(nameof(facturaActualizada));

            var facturaExistente = BuscarPorId(facturaActualizada.Id);
            if (facturaExistente != null)
            {
                facturaExistente.NumeroFactura = facturaActualizada.NumeroFactura;
                facturaExistente.Referencia = facturaActualizada.Referencia;
                facturaExistente.FechaPago = facturaActualizada.FechaPago;
                facturaExistente.Monto = facturaActualizada.Monto;
                facturaExistente.Estado = facturaActualizada.Estado;
                facturaExistente.DuracionMembresia = facturaActualizada.DuracionMembresia;
                facturaExistente.MiembroId = facturaActualizada.MiembroId;
                return true; // Actualización exitosa
            }
            return false; // No se encontró la factura
        }

        // Método para eliminar una factura por su ID
        public bool EliminarFacturaPorId(int facturaId)
        {
            var factura = BuscarPorId(facturaId);
            if (factura != null)
            {
                facturas.Remove(factura);
                return true; // Eliminación exitosa
            }
            return false; // No se encontró la factura
        }

        // Método para obtener el historial de facturas de un miembro específico
        public List<ValidarFactura> ObtenerHistorialPorMiembroId(int miembroId)
        {
            return facturas.Where(f => f.MiembroId == miembroId).ToList();
        }

        // Método para obtener todas las facturas (para reportes o historial general)
        public List<ValidarFactura> ObtenerTodasLasFacturas()
        {
            return new List<ValidarFactura>(facturas); // Retorna una copia segura
        }
    }
}
