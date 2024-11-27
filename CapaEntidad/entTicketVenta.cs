using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entTicketVenta
    {
        public int IdTicketVenta { get; set; }  
        public int IdCliente { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdMetodoPago { get; set; }
        public int IdEmpleado { get; set; }

        public List<entTicketVentaDetalle> Detalle { get; set; } = new List<entTicketVentaDetalle>();
       


    }
}
