//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicioTecnicoSITEB.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Monitoreo
    {
        public long Id_Monitoreo { get; set; }
        public string Saturacion { get; set; }
        public Nullable<System.DateTime> Fecha_Actualizacion { get; set; }
        public long IdProducto { get; set; }
    
        public virtual Producto Producto { get; set; }
    }
}