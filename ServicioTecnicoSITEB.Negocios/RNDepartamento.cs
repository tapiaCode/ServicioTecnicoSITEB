using ServicioTecnicoSITEB.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoSITEB.Negocios
{
<<<<<<< HEAD
    public class RNDepartamento : Contexto
=======
    public class RNDepartamento:Contexto
>>>>>>> tapiaCode
    {
        DBSITEPEntities Esquema;

        public RNDepartamento()
        {
            Esquema = this.TraerContexto();
        }

        public List<Departamento> TraerDepartamento(Int64 id)
        {
            if (id == 0)
            {
                return (from e in Esquema.Departamento select e).ToList();
            }
            else
            {
                return (from e in Esquema.Departamento where e.Id_Departamento.Equals(id) select e).ToList();
            }
        }
    }
}
