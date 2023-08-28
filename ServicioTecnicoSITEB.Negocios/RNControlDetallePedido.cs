using ServicioTecnicoSITEB.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoSITEB.Negocios
{
    public class RNControlDetallePedido : Contexto
    {
        DBSITEPEntities Esquema;
        public RNControlDetallePedido()
        {
            Esquema = this.TraerContexto();
        }
        public Int64 GenerarId()
        {
            try
            {
                return ((from d in Esquema.Detalle_Pedido select d.IdPedido).Max()) + 1;

            }
            catch (Exception e)
            {

                return 1;
            }

        }
        public Boolean InsertarDetallePedido(Detalle_Pedido ObjDetallePedido)
        {
            try
            {
                Esquema.Detalle_Pedido.Add(ObjDetallePedido);
                return Esquema.SaveChanges() == 1;
            }
            catch (Exception e)
            {
                return false;
            }

        }
    }
}
