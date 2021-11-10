using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Datos
{
    public class DatosReportes
    {
        public List<REPORTES> ListaReportes()
        {
            ReportesDBEntities db = new ReportesDBEntities();

            return db.REPORTES.ToList();
        }

        public void GuardarReporte(int idEmpleado, string nombreReporte, int idDeptDestino)
        {
            using (ReportesDBEntities db = new ReportesDBEntities())
            {
                db.GuardarReporte(idEmpleado, nombreReporte, idDeptDestino);
            }
        }
    }
}
