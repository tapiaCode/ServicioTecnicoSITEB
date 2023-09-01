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
<<<<<<< HEAD
    }

=======
        public List<Natural> TrearClientes(Int64 id)
        {
            if (id == 0)
            {
                return (from e in Esquema.Natural select e).ToList();
            }
            else
            {
                return (from e in Esquema.Natural where e.Id_Natural.Equals(id) select e).ToList();
            }
        }

        public List<Natural> TraerClientePorNombre(string nameCliente)
        {
            var result = Esquema.Natural.Where(
                x => x.Nombre.ToUpper().StartsWith(nameCliente.ToUpper()) ||
                x.Apellido_Paterno.ToUpper().StartsWith(nameCliente.ToUpper()) ||
                x.Apellido_Materno.ToUpper().StartsWith(nameCliente.ToUpper())).ToList();
            return result;
        }
    }
>>>>>>> tapiaCode
}
