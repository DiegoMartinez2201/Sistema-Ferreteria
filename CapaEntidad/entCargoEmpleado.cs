using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCargoEmpleado
    {
        public int IdCargo { get; set; }    
        public string nombre { get; set; }  
        public DateTime FechaCreacion { get; set; }
        public int IdEmpleado { get; set; }
        public Boolean Estado { get; set; }
    }
}
