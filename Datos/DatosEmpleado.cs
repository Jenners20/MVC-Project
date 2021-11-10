using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;


namespace Datos
{
    public class DatosEmpleado
    {
        public EMPLEADOS IniciarSesion(string correo, string contraseña)
        {
            var userFinal = new EMPLEADOS();

            using (ReportesDBEntities db = new ReportesDBEntities())
            {                

                var user = from u in db.EMPLEADOS
                           where u.Correo == correo && u.Contraseña == contraseña
                           select u;

                if (user.Count() > 0)
                {
                    foreach (var results in user)
                    {
                        userFinal = results;
                    }

                    return userFinal;
                }
                else
                {
                    return null;
                }            

            }
        }

        public void GuardarEmpleado(string nombre, string apellido, string contraseña, string correo, 
            string cargo, int @id_departamento)
        {
            using (ReportesDBEntities db = new ReportesDBEntities())
            {
                db.GuardarEmpleado(nombre, apellido, contraseña, correo, cargo, id_departamento);
            }
        }
    }
}
