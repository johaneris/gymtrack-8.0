using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfazdeUsuario.Dao;

namespace InterfazdeUsuario.models
{
    public class ValidarFactura
    {
        public int Id { get; set; }
        public string NameMembresia { get; set; }
        public string CifMembresia { get; set; } //si es estudiante solo puede ingresar el cif
        public string CedulaMembresia { get; set; } //si es mimebo externo solo puede ingresaer cedula
        public string CelularMembresia { get; set; }
        public string NumeroFactura { get; set; }
        public string Referencia { get; set; }  
        public DateTime Fechapago { get; set; } //ingresa la fecha que se realiaa el pago y el sistema calculo cuandos e acab
        public string Monto { get; set; } //si paga 15 0 3 dolares 
        public string Duracionmembresia {  get; set; } // dependiendo del monto se puede elegir la duracion de la membresia 
        public bool Estado { get; set; } //mmbresia activa o inactiva



        public ValidarFactura()
        {

        }
        public ValidarFactura(int id, string nameMembresia, string cifMembresia, string cedulaMembresia, string celularMembresia, string numeroFactura, string referencia, DateTime fechapago, string monto, string duracionmembresia, bool estado)
        {
            Id = id;
            NameMembresia = nameMembresia;
            CifMembresia = cifMembresia;
            CedulaMembresia = cedulaMembresia;
            CelularMembresia = celularMembresia;
            NumeroFactura = numeroFactura;
            Referencia = referencia;
            Fechapago = fechapago;
            Monto = monto;
            Duracionmembresia = duracionmembresia;
            Estado = estado;
        }
    }
}
