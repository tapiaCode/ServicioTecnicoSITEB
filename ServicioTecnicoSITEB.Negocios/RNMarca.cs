using ServicioTecnicoSITEB.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoSITEB.Negocios
{
    public class RNMarca : Contexto
    {
        DBSITEPEntities Esquema;
        public RNMarca()
        {
            Esquema = this.TraerContexto();
        }
        public List<Marca> TraerMarca(Int64 id)
        {
            if (id == 0)
            {
                return (from e in Esquema.Marca select e).ToList();
            }
            else
            {
                return (from e in Esquema.Marca where e.Id_Marca.Equals(id) select e).ToList();
            }
        }

        public Boolean InsertarDatosMarca(Marca ObjMarca)
        {
            try
            {
                Esquema.Marca.Add(ObjMarca);
                return Esquema.SaveChanges() == 1;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
