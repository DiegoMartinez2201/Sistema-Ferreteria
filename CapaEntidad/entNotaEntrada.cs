using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entNotaEntrada
    {
        public int IdNotaEntrada { get; set; }
        public int IdProveedor { get; set; }
        public int IdGuiaRemision { get; set; }
        public DateTime FechaRegistro { get; set; } 
        public int IdEmpleado { get; set; }
        public List<entNotaEntradaDetalle> Detalle { get; set; } = new List<entNotaEntradaDetalle>();

    }
}
