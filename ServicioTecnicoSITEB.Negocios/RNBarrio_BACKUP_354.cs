using ServicioTecnicoSITEB.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoSITEB.Negocios
{
<<<<<<< HEAD
    public class RNBarrio : Contexto
=======
    public class RNBarrio:Contexto
>>>>>>> tapiaCode
    {
        DBSITEPEntities Esquema;

        public RNBarrio()
        {
            Esquema = this.TraerContexto();
        }

        public List<Barrio> TraerBarrio(Int64 id)
        {
            if (id == 0)
            {
                return (from e in Esquema.Barrio select e).ToList();
            }
            else
            {
                return (from e in Esquema.Barrio where e.Id_Barrio.Equals(id) select e).ToList();
            }
        }

        public List<Barrio> TraerBarrioPorZona(Int64 idZona)
        {
            return (from e in Esquema.Barrio where e.IdZona.Equals(idZona) select e).ToList();
        }
    }
}
