using ServicioTecnicoSITEB.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoSITEB.Negocios
{
    public class RNSubcategoria : Contexto
    {
        DBSITEPEntities Esquema;

        public RNSubcategoria()
        {
            Esquema = this.TraerContexto();
        }
        public List<Sub_Categoria> TraerSubCategoria(Int64 id)
        {
            if (id == 0)
            {
                return (from e in Esquema.Sub_Categoria select e).ToList();
            }
            else
            {
                return (from e in Esquema.Sub_Categoria where e.Id_SubCategoria.Equals(id) select e).ToList();
            }
        }
    }
}
