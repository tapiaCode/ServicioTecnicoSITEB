using ServicioTecnicoSITEB.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoSITEB.Negocios
{
    public class RNEjemplar : Contexto
    {
        DBSITEPEntities Esquema;

        public RNEjemplar()
        {
            Esquema = this.TraerContexto();
        }
        public Int64 GenerarIDEjemplar()
        {
            try
            {
                return (from e in Esquema.Ejemplar select e.Id_Ejemplar).Max() + 1;
            }
            catch (Exception e)
            {
                return 1;
            }
        }
        public List<Ejemplar> TraerEjemplarDisponible(Int64 id)
        {
            if (id == 0)
            {
                return (from e in Esquema.Ejemplar where e.Disponible select e).ToList();
            }
            else
            {
                return (from e in Esquema.Ejemplar where e.Disponible && e.IdProducto == id select e).ToList();
            }
        }
        public Boolean InsertarDatosEjemplar(Ejemplar ObjEjemplar)
        {
            try
            {
                Esquema.Ejemplar.Add(ObjEjemplar);
                return Esquema.SaveChanges() == 1;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
