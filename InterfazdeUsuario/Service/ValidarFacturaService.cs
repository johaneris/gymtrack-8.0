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
        private RegistroMiembroDao miembroDao;
        private List<ValidarFactura> facturas;

        public ValidarFacturaService(RegistroMiembroDao miembroDao)
        {
            this.miembroDao = miembroDao;
            facturas = new List<ValidarFactura>();
            CargarFacturasDesdeArchivo();
        }

        // Método para generar un nuevo ID único
        private int GenerarNuevoIdFactura()
        {
            return facturas.Any() ? facturas.Max(f => f.Id) + 1 : 1;
        }

        // Método para agregar una factura con validaciones completas
        public string AgregarFactura(ValidarFactura nuevaFactura)
        {
           
                try
                {
                    nuevaFactura.Id = GenerarNuevoIdFactura();

                    var miembro = miembroDao.ObtenerMiembroPorId(nuevaFactura.MiembroId);
                    if (miembro == null)
                    {
                        return "El miembro asociado a la factura no existe.";
                    }

                    if (!EsNumeroValido(nuevaFactura.Referencia, 8))
                    {
                        return "La referencia debe contener exactamente 8 dígitos numéricos.";
                    }

                    if (!EsNumeroValido(nuevaFactura.NumeroFactura, 6))
                    {
                        return "El número de factura debe contener exactamente 6 dígitos numéricos.";
                    }

                    if (FacturaDuplicada(nuevaFactura, out string mensajeError))
                    {
                        return mensajeError;
                    }

                    CalcularDuracionMembresia(nuevaFactura);

                    facturas.Add(nuevaFactura);
                    GuardarFacturasEnArchivo();
                    return $"Factura registrada exitosamente con ID: {nuevaFactura.Id}.";
                }
                catch (Exception ex)
                {
                    return $"Error al agregar factura: {ex.Message}";
                }
            }

            private bool FacturaDuplicada(ValidarFactura nuevaFactura, out string mensajeError)
            {
                mensajeError = string.Empty;
                var facturaExistente = facturas.FirstOrDefault(f =>
                    f.NumeroFactura == nuevaFactura.NumeroFactura &&
                    f.Referencia == nuevaFactura.Referencia);

                if (facturaExistente != null)
                {
                    mensajeError = "Ya existe una factura con el mismo número y referencia.";
                    return true;
                }

                return false;
            }

            private void CalcularDuracionMembresia(ValidarFactura factura)
            {
                switch (factura.Monto)
                {
                    case "15":
                        factura.Duracionmembresia = "1 mes";
                        factura.Estado = true;
                        break;
                    case "3":
                        factura.Duracionmembresia = "1 día";
                        factura.Estado = true;
                        break;
                    default:
                        factura.Duracionmembresia = "Invalida";
                        factura.Estado = false;
                        break;
                }
            }

            private bool EsNumeroValido(string valor, int longitud)
            {
                return valor.Length == longitud && valor.All(char.IsDigit);
            }

            public string ImprimirFactura(int facturaId)
            {
                var factura = facturas.FirstOrDefault(f => f.Id == facturaId);
                if (factura == null)
                {
                    return "Factura no encontrada.";
                }

                return $"Factura ID: {factura.Id}\n" +
                       $"Número: {factura.NumeroFactura}\n" +
                       $"Referencia: {factura.Referencia}\n" +
                       $"Fecha de Pago: {factura.Fechapago.ToShortDateString()}\n" +
                       $"Monto: ${factura.Monto}\n" +
                       $"Duración: {factura.Duracionmembresia}\n" +
                       $"Estado: {(factura.Estado ? "Activa" : "Inactiva")}\n" +
                       $"Miembro ID: {factura.MiembroId}";
            }

            public void EliminarFactura(int facturaId)
            {
                var factura = facturas.FirstOrDefault(f => f.Id == facturaId);
                if (factura != null)
                {
                    facturas.Remove(factura);
                    GuardarFacturasEnArchivo();
                }
                else
                {
                    throw new Exception("La factura no existe.");
                }
            }

            private void CargarFacturasDesdeArchivo()
            {
                if (!File.Exists(filepath)) return;

                using (var fs = new FileStream(filepath, FileMode.Open, FileAccess.Read))
                using (var br = new BinaryReader(fs))
                {
                    while (fs.Position < fs.Length)
                    {
                        var id = br.ReadInt32();
                        var numeroFactura = br.ReadString();
                        var referencia = br.ReadString();
                        var fechapago = DateTime.FromBinary(br.ReadInt64());
                        var monto = br.ReadString();
                        var duracion = br.ReadString();
                        var estado = br.ReadBoolean();
                        var miembroId = br.ReadInt32();

                        facturas.Add(new ValidarFactura(id, numeroFactura, referencia, fechapago, monto, duracion, estado, miembroId));
                    }
                }
            }

        private void GuardarFacturasEnArchivo()
        {
            try
            {

                using (var fs = new FileStream(filepath, FileMode.Create, FileAccess.Write))
                using (var bw = new BinaryWriter(fs))
                {
                    foreach (var factura in facturas)
                    {
                        bw.Write(factura.Id);
                        bw.Write(factura.NumeroFactura);
                        bw.Write(factura.Referencia);
                        bw.Write(factura.Fechapago.ToBinary());
                        bw.Write(factura.Monto);
                        bw.Write(factura.Duracionmembresia);
                        bw.Write(factura.Estado);
                        bw.Write(factura.MiembroId);
                    }
                }
            }
            catch (IOException ex)
            {
                throw new Exception("Error al guardar las facturas en archivo.", ex);
            }
        }   
    }
}
