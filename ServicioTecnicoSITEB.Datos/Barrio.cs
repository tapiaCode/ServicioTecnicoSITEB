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
    
    public partial class Barrio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Barrio()
        {
            this.Cliente = new HashSet<Cliente>();
        }
    
        public long Id_Barrio { get; set; }
        public string Nombre_Barrio { get; set; }
        public string Descripcion { get; set; }
        public long IdZona { get; set; }
    
        public virtual Zona Zona { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
