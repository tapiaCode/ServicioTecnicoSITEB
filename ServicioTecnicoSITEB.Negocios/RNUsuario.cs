using ServicioTecnicoSITEB.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoSITEB.Negocios
{
    public class RNUsuario : Contexto
    {
        DBSITEPEntities Esquema;
        public RNUsuario()
        {
            Esquema = this.TraerContexto();
        }
        public Int64 GenerarID()
        {
            try
            {
                return (from e in Esquema.inicio_sesion select e.id).Max() + 1;
            }
            catch (Exception e)
            {

                return 1;
            }
        }
        public Boolean InsertarUsuario(inicio_sesion objUsuario)
        {
            Esquema.inicio_sesion.Add(objUsuario);
            return Esquema.SaveChanges() == 1;
        }

        public Boolean EliminarUsuario(inicio_sesion objUsuario)
        {
            try
            {
                inicio_sesion ObjUsuarioAux = Esquema.inicio_sesion.FirstOrDefault(a => a.id == objUsuario.id);
                Esquema.inicio_sesion.Remove(ObjUsuarioAux);
                return Esquema.SaveChanges() > 0;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Boolean EditarUsuario(inicio_sesion objUsuario)
        {
            try
            {
                inicio_sesion Usuario = Esquema.inicio_sesion.FirstOrDefault(a => a.id == objUsuario.id);
                if (Usuario != null)
                {
                    Usuario.usuario = objUsuario.usuario;
                    Usuario.clave_acceso = objUsuario.clave_acceso;
                    Usuario.cargo = objUsuario.cargo;
                    return Esquema.SaveChanges() > 0;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<inicio_sesion> TraerUsuarios(Int64 id)
        {
            if (id == 0)
            {
                return (from e in Esquema.inicio_sesion select e).ToList();
            }
            else
            {
                return (from e in Esquema.inicio_sesion where e.id.Equals(id) select e).ToList();
            }
        }

        public List<inicio_sesion> TraerUsuariosPorNombre(string nombreUsuario)
        {

            return (from e in Esquema.inicio_sesion where e.usuario.ToUpper().StartsWith(nombreUsuario.ToUpper()) select e).ToList();
        }
    }
}
