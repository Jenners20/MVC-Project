using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Negocio
{
    public class NegocioReporte
    {
        DatosReportes reportes = new DatosReportes();

        public List<REPORTES> ListaReportes()
        {
            return reportes.ListaReportes();
        }

        public void GuardarReporte(int idEmpleado, string nombreReporte, int idDeptDestino)
        {
            reportes.GuardarReporte(idEmpleado, nombreReporte, idDeptDestino);
        }

    }
}
