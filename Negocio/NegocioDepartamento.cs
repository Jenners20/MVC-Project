using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Negocio
{
    public class NegocioDepartamento
    {
        DatosDepartamento departamento = new DatosDepartamento();
        public List<Departamentos> ListaDepartamentos()
        {
            return departamento.ListaDepartamentos();
        }

        public void CrearDepartamento(string nombre, string siglas)
        {            
            departamento.CrearDepartamento(nombre, siglas);            
        }
    }
}
