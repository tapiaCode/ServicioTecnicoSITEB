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
    
    public partial class Juridico
    {
        public long Id_Juridico { get; set; }
        public string Razon_Social { get; set; }
        public string Representacion_legal { get; set; }
        public string Nit { get; set; }
        public long IdCliente { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}