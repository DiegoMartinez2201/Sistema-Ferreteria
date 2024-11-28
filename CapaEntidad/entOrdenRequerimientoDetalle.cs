using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entOrdenRequerimientoDetalle
    {
        public int IdOrdenRequerimiento { get; set; }
        public entProducto IdProducto { get; set; }  // Asegúrate de que esto sea public
        public int Cantidad { get; set; }
    }
}
