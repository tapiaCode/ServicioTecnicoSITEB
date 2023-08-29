using ServicioTecnicoSITEB.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoSITEB.Negocios
{
    public class RNCtrlCliente : Contexto
    {
        DBSITEPEntities Esquema;
        public RNCtrlCliente()
        {
            Esquema = this.TraerContexto();
        }
        public Int64 GenerarId()
        {
            try
            {
                return ((from e in Esquema.Cliente select e.Id_Cliente).Max()) + 1;
            }
            catch (Exception e)
            {

                return 1;
            }

        }
        public Boolean InsertarClienteNatural(Cliente ObjCliente, Natural ObjNatural)
        {
            try
            {
                Esquema.Cliente.Add(ObjCliente);
                Esquema.Natural.Add(ObjNatural);
                return Esquema.SaveChanges() == 2;
            }
            catch (Exception e)
            {
                return false;
            }

        }
    }

}
