using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entTicketVentaDetalle
    {
        public int IdTicketVenta { get; set; }  
        public int IdProducto { get; set; } 
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        public decimal Total
        {
            get
            {
                return Cantidad * PrecioUnitario;
            }
        }
    }
}
