using ServicioTecnicoSITEB.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoSITEB.Negocios
{
    public class RNControlPedido : Contexto
    {
        DBSITEPEntities Esquema;
        public RNControlPedido()
        {
            Esquema = this.TraerContexto();
        }
        public Int64 GenerarId()
        {
            try
            {
                return ((from e in Esquema.Pedido select e.Id_Pedido).Max()) + 1;
            }
            catch (Exception e)
            {

                return 1;
            }

        }
        public Boolean InsertarPedido(Pedido ObjPedido)
        {
            try
            {
                Esquema.Pedido.Add(ObjPedido);
                return Esquema.SaveChanges() == 1;
            }
            catch (Exception e)
            {
                return false;
            }

        }
    }
}
