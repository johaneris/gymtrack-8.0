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
            // Obtener todas las facturas existentes
            List<ValidarFactura> facturasExistentes = facturaDao.ObtenerTodasLasFacturas();

            // Generar un nuevo Id
            nuevaFactura.Id = facturasExistentes.Count > 0
                ? facturasExistentes.Max(f => f.Id) + 1
                : 1;


            // Validar referencia y número de factura
            if (string.IsNullOrWhiteSpace(nuevaFactura.Referencia) || nuevaFactura.Referencia.Length != 8 || !nuevaFactura.Referencia.All(char.IsDigit))
                return "La referencia debe contener exactamente 8 dígitos.";

            if (string.IsNullOrWhiteSpace(nuevaFactura.NumeroFactura) || nuevaFactura.NumeroFactura.Length != 6 || !nuevaFactura.NumeroFactura.All(char.IsDigit))
                return "El número de factura debe contener exactamente 6 dígitos.";

            // Validar monto
            if (nuevaFactura.Monto != "15" && nuevaFactura.Monto != "3")
                return "El monto debe ser de 15 o 3 dólares.";

            // Determinar reglas según el tipo de usuario autenticado
            if (loginService.EsEstudiante())
            {
                // Usuario estudiante: solo puede usar CIF
                if (string.IsNullOrWhiteSpace(nuevaFactura.CifMembresia) || nuevaFactura.CifMembresia.Length != 8 || !nuevaFactura.CifMembresia.All(char.IsDigit))
                    return "El CIF debe contener exactamente 8 dígitos.";

                if (!string.IsNullOrWhiteSpace(nuevaFactura.CedulaMembresia))
                    return "Si es estudiante, no debe ingresar cédula.";
            }
            else if (loginService.EsMiembroExterno())
            {
                // Usuario miembro externo: solo puede usar Cédula
                if (string.IsNullOrWhiteSpace(nuevaFactura.CedulaMembresia) || !nuevaFactura.CedulaMembresia.All(char.IsDigit))
                    return "La cédula debe ser un valor numérico.";

                if (!string.IsNullOrWhiteSpace(nuevaFactura.CifMembresia))
                    return "Si es miembro externo, no debe ingresar CIF.";
            }
            else
            {
                return "Usuario no autenticado o tipo de identificación desconocido.";
            }

            // Calcular duración de membresía y estado
            nuevaFactura.Duracionmembresia = nuevaFactura.Monto == "15" ? "30 días" : "1 día";
            nuevaFactura.Fechapago = DateTime.Now.AddDays(nuevaFactura.Monto == "15" ? 30 : 1);
            nuevaFactura.Estado = true;

            // Registrar la factura
            facturaDao.AgregarFactura(nuevaFactura);
            GuardarFacturasEnArchivo();

            return "Factura registrada exitosamente.";
        }

        private void GuardarFacturasEnArchivo()
        {
            FileStream fs = null;
            BinaryWriter bw = null;

            try
            {
                fs = new FileStream(filepath, FileMode.Create, FileAccess.Write);
                bw = new BinaryWriter(fs);

                List<ValidarFactura> facturas = facturaDao.ObtenerTodasLasFacturas();

                foreach (ValidarFactura factura in facturas)
                {
                    bw.Write(factura.Id);
                    bw.Write(factura.NameMembresia);
                    bw.Write(factura.CifMembresia);
                    bw.Write(factura.CedulaMembresia);
                    bw.Write(factura.CelularMembresia);
                    bw.Write(factura.NumeroFactura);
                    bw.Write(factura.Referencia);
                    bw.Write(factura.Fechapago.ToBinary());
                    bw.Write(factura.Monto);
                    bw.Write(factura.Duracionmembresia);
                    bw.Write(factura.Estado);
                }
            }
            finally
            {
                if (fs != null) fs.Close();
                if (bw != null) bw.Close();
            }
        }

        public void CargarFacturasDesdeArchivo()
        {
            if (!File.Exists(filepath)) return;

            FileStream fs = null;
            BinaryReader br = null;

            try
            {
                fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);

                facturaDao.ObtenerTodasLasFacturas().Clear();

                while (fs.Position < fs.Length)
                {
                    int id = br.ReadInt32();
                    string nameMembresia = br.ReadString();
                    string cifMembresia = br.ReadString();
                    string cedulaMembresia = br.ReadString();
                    string celularMembresia = br.ReadString();
                    string numeroFactura = br.ReadString();
                    string referencia = br.ReadString();
                    DateTime fechapago = DateTime.FromBinary(br.ReadInt64());
                    string monto = br.ReadString();
                    string duracionmembresia = br.ReadString();
                    bool estado = br.ReadBoolean();

                    ValidarFactura factura = new ValidarFactura(id, nameMembresia, cifMembresia, cedulaMembresia, celularMembresia, numeroFactura, referencia, fechapago, monto, duracionmembresia, estado);
                    facturaDao.AgregarFactura(factura);
                }
            }
            finally
            {
                if (fs != null) fs.Close();
                if (br != null) br.Close();
            }
        }

        public List<ValidarFactura> ObtenerHistorialDeMembresias(string identificador)
        {
            return facturaDao.ObtenerTodasLasFacturas()
                .Where(f => f.CifMembresia == identificador || f.CedulaMembresia == identificador)
                .ToList();
        }

        public List<ValidarFactura> ConsultarFacturas()
        {
            return facturaDao.ObtenerTodasLasFacturas();
        }

    }
}

