using ServicioTecnicoSITEB.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoSITEB.Negocios
{
    public class RNProducto : Contexto
    {
        DBSITEPEntities Esquema;

        public RNProducto()
        {
            Esquema = this.TraerContexto();
        }
        public List<Producto> TraerProducto(Int64 id)
        {
            if (id == 0)
            {
                return (from e in Esquema.Producto select e).ToList();
            }
            else
            {
                return (from e in Esquema.Producto where e.Id_Producto.Equals(id) select e).ToList();
            }
        }

        public List<Producto> TraerProductoPorNombre(string nameProducto)
        {
            var result = Esquema.Producto.Where(x => x.Nombre_Producto.ToUpper().StartsWith(nameProducto.ToUpper())).ToList();
            return result;
        }
    }
}
