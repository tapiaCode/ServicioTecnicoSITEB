using ServicioTecnicoSITEB.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoSITEB.Negocios
{
    public class RNPrecio : Contexto
    {
        DBSITEPEntities Esquema;
        public RNPrecio()
        {
            Esquema = this.TraerContexto();
        }


        public Int64 GenerarIDPrecio()
        {
            try
            {
                return (from e in Esquema.Precio select e.Id_Precio).Max() + 1;
            }
            catch (Exception e)
            {
                return 1;
            }
        }
        public List<Precio> TraerPrecio(Int64 id)
        {
            if (id == 0)
            {
                return (from e in Esquema.Precio select e).ToList();
            }
            else
            {
                return (from e in Esquema.Precio where e.Id_Precio.Equals(id) select e).ToList();
            }
        }
        public Boolean InsertarDatosPrecio(Precio ObjPrecio)
        {
            try
            {
                Esquema.Precio.Add(ObjPrecio);
                return Esquema.SaveChanges() == 1;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
