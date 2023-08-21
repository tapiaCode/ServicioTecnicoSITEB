using ServicioTecnicoSITEB.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoSITEB.Negocios
{
    public class RNCtrlEmpleado : Contexto
    {
        DBSITEPEntities Esquema;
        public RNCtrlEmpleado()
        {
            Esquema = this.TraerContexto();
        }
        public Int64 GenerarId()
        {
            try
            {
                return ((from e in Esquema.Empleado select e.Id_Empleado).Max()) + 1;
            }
            catch (Exception e)
            {
                return 1;
            }

        }
        public Boolean InsertarEmpleado(Empleado ObjEmpleado)
        {
            try
            {
                Esquema.Empleado.Add(ObjEmpleado);
                return Esquema.SaveChanges() == 1;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public Boolean EditarEmpleado(VistaEmpleadoCargo objempleado)
        {
            try
            {
                Empleado empleado = Esquema.Empleado.FirstOrDefault(a => a.Id_Empleado == objempleado.Id_Empleado);
                Cargo cargo = Esquema.Cargo.FirstOrDefault(b => b.Id_Cargo == objempleado.IdCargo);

                if (empleado != null && cargo != null)
                {
                    empleado.Nombre_Empleado = objempleado.Nombre_Empleado;
                    empleado.Apellido_Paterno = objempleado.Apellido_Paterno;
                    empleado.Apellido_Materno = objempleado.Apellido_Materno;
                    empleado.Fecha_Nacimiento = objempleado.Fecha_Nacimiento;
                    empleado.Carnet_Identidad = objempleado.Carnet_Identidad;
                    cargo.Id_Cargo = objempleado.IdCargo;

                    return Esquema.SaveChanges() > 0;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public Boolean Eliminar(VistaEmpleadoCargo empleado)
        {
            try
            {
                Empleado ObjEmpleado = Esquema.Empleado.FirstOrDefault(a => a.Id_Empleado == empleado.Id_Empleado);
                Cargo ObjCargo = Esquema.Cargo.FirstOrDefault(a => a.Id_Cargo == empleado.Id_Empleado);

                if (ObjEmpleado != null && ObjCargo != null)
                {
                    Esquema.Empleado.Remove(ObjEmpleado);
                    Esquema.Cargo.Remove(ObjCargo);

                    return Esquema.SaveChanges() > 0;
                }

                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public List<VistaEmpleadoCargo> TraerEmpleadoCargo(Int64 id)
        {
            if (id == 0)
            {
                return (from e in Esquema.VistaEmpleadoCargo select e).ToList();
            }
            else
            {
                return (from e in Esquema.VistaEmpleadoCargo where e.Id_Empleado.Equals(id) select e).ToList();
            }
        }

        public List<VistaEmpleadoCargo> TraerEmpleadoCargoPorNombre(string nombre)
        {

            return (from e in Esquema.VistaEmpleadoCargo where e.Nombre_Empleado.ToUpper().StartsWith(nombre.ToUpper()) select e).ToList();
        }

    }
}
