using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoSITEB.Datos
{
    public class Contexto
    {
        public DBSITEPEntities TraerContexto()
        {
            DBSITEPEntities Esquema = new DBSITEPEntities();
            return Esquema;
        }
        //master
    }
}
