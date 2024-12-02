using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using InterfazdeUsuario.Dao;

namespace InterfazdeUsuario.models
{
    public class ValidarFactura
    {
        public int Id { get; set; }
        public string NumeroFactura { get; set; }
        public string Referencia { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; } // Usamos decimal para operaciones financieras
        public TimeSpan DuracionMembresia { get; set; } // Almacenamos duración en días
        public bool Estado { get; set; } // True si la membresía está activa
        public int MiembroId { get; set; }

        public ValidarFactura(int id, string numeroFactura, string referencia, DateTime fechaPago, decimal monto, int miembroId)
        {
            Id = id;
            NumeroFactura = numeroFactura ?? throw new ArgumentNullException(nameof(numeroFactura));
            Referencia = referencia ?? throw new ArgumentNullException(nameof(referencia));
            FechaPago = fechaPago;
            Monto = monto;
            MiembroId = miembroId;
            Estado = true; // Por defecto activamos la membresía al registrar factura
            DuracionMembresia = CalcularDuracion(monto);
        }
        public ValidarFactura() { }

        private TimeSpan CalcularDuracion(decimal monto)
        {
            if (monto == 15) return TimeSpan.FromDays(30);
            if (monto == 3) return TimeSpan.FromDays(1);
            Estado = false; // Inactiva si el monto no corresponde a las opciones
            return TimeSpan.Zero;
        }
    }
}