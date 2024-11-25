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
        public void AgregarFactura(ValidarFactura nuevaFactura)
        {
            if (nuevaFactura != null)
            {
                facturas.Add(nuevaFactura);
            }
        }

        // Método para buscar facturas por su número de factura y referencia
        public ValidarFactura BuscarPorNumeroYReferencia(string numeroFactura, string referencia)
        {
            foreach (ValidarFactura factura in facturas)
            {
                if (factura.NumeroFactura == numeroFactura && factura.Referencia == referencia)
                {
                    return factura;
                }
            }
            return null; // Si no se encuentra, retorna null
        }

        // Método para actualizar la información de una factura
        public bool ActualizarFactura(ValidarFactura facturaActualizada)
        {
            for (int i = 0; i < facturas.Count; i++)
            {
                if (facturas[i].NumeroFactura == facturaActualizada.NumeroFactura &&
                    facturas[i].Referencia == facturaActualizada.Referencia)
                {
                    facturas[i] = facturaActualizada;
                    return true; // Actualización exitosa
                }
            }
            return false; // No se encontró la factura
        }

        // Método para obtener todas las facturas de un miembro específico por CIF o Cédula
        public List<ValidarFactura> ObtenerHistorialPorIdentificador(string identificador)
        {
            List<ValidarFactura> historial = new List<ValidarFactura>();

            foreach (ValidarFactura factura in facturas)
            {
                if (factura.CifMembresia == identificador || factura.CedulaMembresia == identificador)
                {
                    historial.Add(factura);
                }
            }

            return historial;
        }

        // Obtener la lista completa de factura 
        public List<ValidarFactura> ObtenerTodasLasFacturas()
        {
            return facturas;
        }
    }
}
