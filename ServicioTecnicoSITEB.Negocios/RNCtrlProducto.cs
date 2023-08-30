using ServicioTecnicoSITEB.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoSITEB.Negocios
{
    public class RNCtrlProducto : Contexto
    {
        DBSITEPEntities Esquema;
        public RNCtrlProducto()
        {
            Esquema = this.TraerContexto();
        }
        public Int64 GenerarID()
        {
            try
            {
                return (from e in Esquema.Producto select e.Id_Producto).Max() + 1;
            }
            catch (Exception e)
            {
                return 1;
            }
        }
        public Boolean InsertarDatosProducto(Producto ObjProducto)
        {
            try
            {
                Esquema.Producto.Add(ObjProducto);
                return Esquema.SaveChanges() == 1;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
