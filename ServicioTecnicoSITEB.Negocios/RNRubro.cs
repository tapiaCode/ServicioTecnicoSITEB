using ServicioTecnicoSITEB.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoSITEB.Negocios
{
    public class RNRubro : Contexto
    {
        DBSITEPEntities Esquema;

        public RNRubro()
        {
            Esquema = this.TraerContexto();
        }

        public List<Rubro> TraerRubro(Int64 id)
        {
            if (id == 0)
            {
                return (from e in Esquema.Rubro select e).ToList();
            }
            else
            {
                return (from e in Esquema.Rubro where e.Id_Rubro.Equals(id) select e).ToList();
            }
        }
    }
}
