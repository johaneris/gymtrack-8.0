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

        // Método para agregar una nueva factura
        public bool AgregarFactura(ValidarFactura nuevaFactura)
        {
            if (nuevaFactura == null)
            {
                return false; // No se puede agregar una factura nula.
            }

            if (BuscarPorNumeroYReferencia(nuevaFactura.NumeroFactura, nuevaFactura.Referencia) != null)
            {
                return false; // Ya existe una factura con el mismo número y referencia.
            }

            facturas.Add(nuevaFactura);
            return true; // Factura agregada con éxito.
        }

        // Método para buscar facturas por su número de factura y referencia
        public ValidarFactura BuscarPorNumeroYReferencia(string numeroFactura, string referencia)
        {
            return facturas.FirstOrDefault(f => f.NumeroFactura == numeroFactura && f.Referencia == referencia);
        }

        // Método para actualizar la información de una factura
        public bool ActualizarFacturaPorrefencia(ValidarFactura facturaActualizada)
        {
            var facturaExistente = BuscarPorNumeroYReferencia(facturaActualizada.NumeroFactura, facturaActualizada.Referencia);
            if (facturaExistente != null)
            {
                facturaExistente.Fechapago = facturaActualizada.Fechapago;
                facturaExistente.Monto = facturaActualizada.Monto;
                facturaExistente.Duracionmembresia = facturaActualizada.Duracionmembresia;
                facturaExistente.Estado = facturaActualizada.Estado;
                return true; // Actualización exitosa.
            }
            return false; // No se encontró la factura.
        }

        public bool ActualizarFactura(ValidarFactura facturaActualizada)
        {
            var facturaExistente = facturas.FirstOrDefault(f => f.Id == facturaActualizada.Id);
            if (facturaExistente != null)
            {
                // Actualizar todos los campos excepto el Id
                facturaExistente.Fechapago = facturaActualizada.Fechapago;
                facturaExistente.Monto = facturaActualizada.Monto;
                facturaExistente.Duracionmembresia = facturaActualizada.Duracionmembresia;
                facturaExistente.Estado = facturaActualizada.Estado;
                facturaExistente.NumeroFactura = facturaActualizada.NumeroFactura;
                facturaExistente.Referencia = facturaActualizada.Referencia;

                return true;
            }
            return false; // No se encontró la factura.
        }

        // Método para obtener todas las facturas de un miembro específico
        public List<ValidarFactura> ObtenerHistorialPorMiembroId(int miembroId)
        {
            return facturas.Where(f => f.MiembroId == miembroId).ToList();
        }

        // Obtener la lista completa de facturas
        public List<ValidarFactura> ObtenerTodasLasFacturas()
        {
            return facturas;
        }

        // Método para eliminar una factura por su ID
        public bool EliminarFacturaPorId(int facturaId)
        {
            var factura = facturas.FirstOrDefault(f => f.Id == facturaId);
            if (factura != null)
            {
                facturas.Remove(factura);
                return true; // Eliminación exitosa.
            }
            return false; // No se encontró la factura.
        }

    }
}
