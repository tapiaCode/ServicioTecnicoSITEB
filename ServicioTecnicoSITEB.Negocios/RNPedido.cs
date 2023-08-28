using ServicioTecnicoSITEB.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoSITEB.Negocios
{
    public class RNPedido : Contexto
    {
        DBSITEPEntities Esquema;
        public RNPedido()
        {
            Esquema = this.TraerContexto();
        }
        public Int64 GenerarID()
        {
            try
            {
                return (from e in Esquema.Pedido select e.Id_Pedido).Max() + 1;
            }
            catch (Exception e)
            {

                return 1;
            }
        }
    }
}
