using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoSITEB.Negocios
{
    public class RNClienteViewModel
    {
        public long Id_Cliente { get; set; }
        public string NombreCliente { get; set; }
        public string Carnet_Identidad { get; set; }
        public string Genero { get; set; }
    }
}
