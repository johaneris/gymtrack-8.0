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
        public DateTime Fechapago { get; set; } //ingresa la fecha que se realiaa el pago y el sistema calculo cuandos e acab
        public string Monto { get; set; } //si paga 15 0 3 dolares 
        public string Duracionmembresia {  get; set; } // dependiendo del monto se puede elegir la duracion de la membresia 
        public bool Estado { get; set; } //mmbresia activa o inactiva
        public int MiembroId { get; set; }

        public ValidarFactura(int id, string numeroFactura, string referencia, DateTime fechapago, string monto, string duracion, bool estado, int miembroid )
        {
            Id = id;
            NumeroFactura = numeroFactura;
            Referencia = referencia;
            Monto = monto;
            Fechapago = fechapago;
            Duracionmembresia = duracion;
            Estado = estado;
            MiembroId = miembroid;
        }
        
        
    }
}
