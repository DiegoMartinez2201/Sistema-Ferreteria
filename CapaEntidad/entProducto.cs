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
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Stock { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public entCategoria IdCategoria { get; set; }   
        public entCategoria NombreCategoria { get; set; }
        public entUnidadMedida IdUnidadMedida { get; set; }
        public entUnidadMedida NombreMedida { get; set; }
        public entProveedor IdProveedor { get; set; }
        public entProveedor NombreProveedor { get; set; }


    }
}
