using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entNotaSalida
    {
        public int IdNotaSalida { get; set; }
        public int IdTicketVenta { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdEmpleado { get; set; }
        public List<entNotaSalidaDetalle> Detalle { get; set; } = new List<entNotaSalidaDetalle>();

    }
}
