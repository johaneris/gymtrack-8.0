using InterfazdeUsuario.Dao;
using InterfazdeUsuario.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazdeUsuario.Service
{
    public class MembresiaService
    {
        private ValidarFacturaDao facturaDao;
        ValidarFacturaService validarFacturaService;
        public MembresiaService()
        {
            RegistroMiembroDao rmd = new RegistroMiembroDao();
            validarFacturaService = new ValidarFacturaService(rmd);

            facturaDao = new ValidarFacturaDao();
        }

        public List<ValidarFactura> ObtenerHistorialDeMembresias(int miembroId)
        {
            return validarFacturaService.ObtenerHistorialDeMembresias(miembroId);
        }
    }
}
