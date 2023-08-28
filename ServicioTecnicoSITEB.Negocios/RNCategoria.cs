using ServicioTecnicoSITEB.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoSITEB.Negocios
{
    public class RNCategoria : Contexto
    {
        DBSITEPEntities Esquema;
        public RNCategoria()
        {
            Esquema = this.TraerContexto();
        }
        public List<Categoria> TraerCategoria(Int64 id)
        {
            if (id == 0)
            {
                return (from e in Esquema.Categoria select e).ToList();
            }
            else
            {
                return (from e in Esquema.Categoria where e.Id_Categoria.Equals(id) select e).ToList();
            }
        }
        public Boolean InsertarDatosCategoria(Categoria ObjCategoria)
        {
            try
            {
                Esquema.Categoria.Add(ObjCategoria);
                return Esquema.SaveChanges() == 1;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
