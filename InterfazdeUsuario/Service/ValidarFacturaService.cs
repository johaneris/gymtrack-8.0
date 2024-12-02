using InterfazdeUsuario.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using InterfazdeUsuario.Dao;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace InterfazdeUsuario.Service
{

    public class ValidarFacturaService
    {

        private string filepath = "facturas.bin";
        private RegistroMiembroDao miembroDao;
        private List<ValidarFactura> facturas;
        private RegistroDeMiembroService miembroService;

        public ValidarFacturaService(RegistroMiembroDao miembroDao)
        {
            if (miembroDao == null)
                throw new ArgumentNullException("El DAO de miembros no puede ser nulo.");

            this.miembroDao = miembroDao;
            this.miembroService = new RegistroDeMiembroService(); // Inicialización correcta
            this.facturas = new List<ValidarFactura>();

            //miembroService.Load(); // Ahora no debería causar una excepción
            miembroDao.CargarMiembros(miembroService.Load());

            //CargarFacturasDesdeArchivo();
            Load();
            Save(facturas);
        }

        public ValidarFacturaService()
        {
            Load();
            
        }

        public string AgregarFactura(ValidarFactura nuevaFactura)
        {
            try
            {

                if (nuevaFactura == null) return "La factura no puede ser nula.";

                nuevaFactura.Id = facturas.Count > 0 ? facturas.Max(f => f.Id) + 1 : 1; // Generar un nuevo ID único

                //RegistroMiembro miembro = //miembroDao.ObtenerMiembroPorIdentificador(nuevaFactura.MiembroId.ToString());
                // if (miembro == null) return "El miembro asociado a la factura no existe.";

                // Validar y agregar factura '
                if (facturas.Any(f => f.NumeroFactura == nuevaFactura.NumeroFactura && f.Referencia == nuevaFactura.Referencia))
                    return "Ya existe una factura con el mismo número y referencia.";
                if (!EsNumeroValido(nuevaFactura.Referencia, 8))
                    return "La referencia debe contener exactamente 8 dígitos numéricos.";

                if (!EsNumeroValido(nuevaFactura.NumeroFactura, 6))
                    return "El número de factura debe contener exactamente 6 dígitos numéricos.";

                if (FacturaDuplicada(nuevaFactura, out string mensajeError))
                    return mensajeError;
                if (nuevaFactura.FechaPago >= DateTime.MaxValue || nuevaFactura.FechaPago <= DateTime.MinValue)
                    return "La fecha de pago no es válida.";


                facturas.Add(nuevaFactura);
                //GuardarFacturasEnArchivo();
                Save(facturas);

                return "Factura registrada exitosamente.";
            }
            catch (Exception ex)
            {
                return "Error al agregar factura: " + ex.Message;
            }
        }
        public List<ValidarFactura> ObtenerHistorialFacturas() => new List<ValidarFactura>(facturas);

        public ValidarFactura BuscarFacturaPorId(int id) =>
            facturas.FirstOrDefault(f => f.Id == id);
        private int ObtenerMiembroId()
        {
            try
            {
                RegistroMiembro miembro = LoginMiembroService.ObtenerMiembroAutenticado();
                return miembro.ID;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener ID de miembro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; // ID inválido
            }
        }

        private bool FacturaDuplicada(ValidarFactura nuevaFactura, out string mensajeError)
        {
            mensajeError = string.Empty;
            foreach (ValidarFactura factura in facturas)
            {
                if (factura.NumeroFactura == nuevaFactura.NumeroFactura &&
                    factura.Referencia == nuevaFactura.Referencia)
                {
                    mensajeError = "Ya existe una factura con el mismo número y referencia.";
                    return true;
                }
            }
            return false;
        }




        private bool EsNumeroValido(string valor, int longitud)
        {
            if (string.IsNullOrWhiteSpace(valor) || valor.Length != longitud)
                return false;

            foreach (char c in valor)
            {
                if (!char.IsDigit(c)) return false;
            }
            return true;
        }

        public List<ValidarFactura> ObtenerHistorialDeMembresias(int identificador)
        {
            List<ValidarFactura> historial = new List<ValidarFactura>();
            try
            {
                var miembros = new RegistroDeMiembroService().Load();
                //RegistroMiembro miembro = miembroDao.ObtenerMiembroPorId( identificador);
                if (!miembros.Any(m => (m.ID == identificador)))
                {
                    throw new Exception("No se encontró un miembro con el identificador proporcionado.");
                }

                foreach (ValidarFactura factura in facturas)
                {
                    if (factura.MiembroId == identificador)
                        historial.Add(factura);
                }
                return historial;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el historial: " + ex.Message);
            }
        }

        private void CargarFacturasDesdeArchivo()
        {
            if (!File.Exists(filepath)) return;

            try
            {
                using (var fs = new FileStream(filepath, FileMode.Open, FileAccess.Read))
                using (var br = new BinaryReader(fs))
                {
                    while (fs.Position < fs.Length)
                    {
                        try
                        {
                            int id = br.ReadInt32();
                            string numeroFactura = br.ReadString();
                            string referencia = br.ReadString();
                            Int64 fechaTicks = br.ReadInt64();

                            // Validar que la fecha sea válida
                            /*if (fechaTicks < DateTime.MinValue.Ticks || fechaTicks > DateTime.MaxValue.Ticks)
                                throw new InvalidDataException($"Fecha inválida en el archivo: {fechaTicks}");*/

                            DateTime fechaPago = DateTime.FromBinary(fechaTicks);
                            decimal monto = br.ReadDecimal();
                            int miembroId = br.ReadInt32();

                            var factura = new ValidarFactura(id, numeroFactura, referencia, fechaPago, monto, miembroId);
                            facturas.Add(factura);
                        }
                        catch (Exception ex)
                        {
                            // Manejo de errores para facturas individuales
                            MessageBox.Show($"Error al procesar una factura: {ex.Message}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar las facturas desde el archivo: " + ex.Message);
            }
        }

        private void GuardarFacturasEnArchivo()
        {
            try
            {
                using (FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.Write))
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    foreach (var factura in facturas)
                    {
                        bw.Write(factura.Id);
                        bw.Write(factura.NumeroFactura);
                        bw.Write(factura.Referencia);
                        bw.Write(factura.FechaPago.ToBinary());
                        bw.Write(factura.Monto);
                        bw.Write(factura.MiembroId);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar las facturas en el archivo: " + ex.Message);
            }
        }

        public void Save(List<ValidarFactura> facturas, [CallerMemberName] string callerName = "")
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
                        bw.Write(factura.FechaPago.ToBinary());
                        bw.Write(factura.Monto);
                        bw.Write(factura.MiembroId);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar las facturas en el archivo: " + ex.Message);
            }
        }


        public List<ValidarFactura> Load([CallerMemberName] string callerName = "")
        {
            var facturas = new List<ValidarFactura>();
            if (!File.Exists(filepath)) return facturas;
            try
            {
                using (var fs = new FileStream(filepath, FileMode.Open, FileAccess.Read))
                using (var br = new BinaryReader(fs))
                {
                    while (fs.Position < fs.Length)
                    {

                        try
                        {
                            int id = br.ReadInt32();
                            string numeroFactura = br.ReadString();
                            string referencia = br.ReadString();
                            Int64 fechaTicks = br.ReadInt64();

                            // Validar que la fecha sea válida
                            /*if (fechaTicks < DateTime.MinValue.Ticks || fechaTicks > DateTime.MaxValue.Ticks)
                                throw new InvalidDataException($"Fecha inválida en el archivo: {fechaTicks}");*/

                            DateTime fechaPago = DateTime.FromBinary(fechaTicks);
                            decimal monto = br.ReadDecimal();
                            int miembroId = br.ReadInt32();

                            var factura = new ValidarFactura(id, numeroFactura, referencia, fechaPago, monto, miembroId);
                            facturas.Add(factura);

                        }
                        catch (Exception)
                        {

                        }
                    }



                }
            }
            catch (Exception)
            {

            }
            return facturas;
        }
    }
}
    


