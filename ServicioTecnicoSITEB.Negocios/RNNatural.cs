using ServicioTecnicoSITEB.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoSITEB.Negocios
{
    public class RNNatural : Contexto
    {
        DBSITEPEntities Esquema;
        public RNNatural()
        {
            Esquema = this.TraerContexto();
        }
        public List<Natural> TraerClienteNatural(Int64 id)
        {
            if (id == 0)
            {
                return (from e in Esquema.Natural select e).ToList();
            }
            else
            {
                return (from e in Esquema.Natural where e.Id_Natural.Equals(id) select e).ToList();
            }
        }
    }
}
