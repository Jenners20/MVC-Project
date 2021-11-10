using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Negocio
{   
    public class NegocioEmpleado
    {
        DatosEmpleado empleado = new DatosEmpleado();

        public EMPLEADOS IniciarSesion(string correo, string contraseña)
        {
            return empleado.IniciarSesion(correo, contraseña);
        }

        public void GuardarEmpleado(string nombre, string apellido, string contraseña, string correo,
            string cargo, int @id_departamento)
        {
            
            empleado.GuardarEmpleado(nombre, apellido, contraseña, correo, cargo, id_departamento);
            
        }
    }
}
