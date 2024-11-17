using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProducto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdCategoria { get; set; }
        public int IdUnidadMedida { get; set; }
        public int IdProveedor { get; set; }
        public int Stock { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Boolean Estado { get; set; }
        public int IdEmpleado { get; set; }
    }
}
