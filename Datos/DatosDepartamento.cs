using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Datos
{
    public class DatosDepartamento
    {
        public List<Departamentos> ListaDepartamentos()
        {
            ReportesDBEntities db = new ReportesDBEntities();

            return db.Departamentos.ToList();
        }

        public void CrearDepartamento(string nombre, string siglas)
        {
            using (ReportesDBEntities db = new ReportesDBEntities())
            {
                db.CrearDepartamento(nombre, siglas);
            }
        }
    }
}
