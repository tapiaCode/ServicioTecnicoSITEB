using ServicioTecnicoSITEB.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoSITEB.Negocios
{
<<<<<<< HEAD
    public class RNZona : Contexto
=======
    public class RNZona:Contexto
>>>>>>> tapiaCode
    {
        DBSITEPEntities Esquema;

        public RNZona()
        {
            Esquema = this.TraerContexto();
        }

        public List<Zona> TraerZona(Int64 id)
        {
            if (id == 0)
            {
                return (from e in Esquema.Zona select e).ToList();
            }
            else
            {
                return (from e in Esquema.Zona where e.Id_Zona.Equals(id) select e).ToList();
            }
        }

        public List<Zona> TraerZonaPorDepartamento(Int64 idDepartamento)
        {
            return (from e in Esquema.Zona where e.IdDepartamento.Equals(idDepartamento) select e).ToList();
        }
    }
}
