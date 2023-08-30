using ServicioTecnicoSITEB.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoSITEB.Negocios
{
    public class RNEmpleado : Contexto
    {
        DBSITEPEntities Esquema;
        public RNEmpleado()
        {
            Esquema = this.TraerContexto();
        }
        public List<Empleado> TrearEmpleado(Int64 id)
        {
            if (id == 0)
            {
                return (from e in Esquema.Empleado select e).ToList();
            }
            else
            {
                return (from e in Esquema.Empleado where e.Id_Empleado.Equals(id) select e).ToList();
            }
        }
        public List<Empleado> TraerEmpleadoPorNombre(string nombreEmpleado)
        {
            return (from e in Esquema.Empleado where e.Nombre_Empleado.ToUpper().StartsWith(nombreEmpleado.ToUpper()) select e).ToList();
        }
    }
}
