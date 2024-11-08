using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entEmpleado
    {
        public int IdEmpleado { get; set; }
        public string Dni { get; set; } 
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string telefono { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Boolean Estado { get; set; }
        public string NameLogin { get; set; }
        public string Password { get;set; }
        public int IdCargo { get; set; }
        public int IdEmpleadoRegistro { get; set; }
    }
}
