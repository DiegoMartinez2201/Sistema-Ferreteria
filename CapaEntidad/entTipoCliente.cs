using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entTipoCliente
    {
        public int IdTipoCliente { get; set; }
        public string Nombre { get; set; }

        public DateTime FechaCreacion { get; set; }
        public Boolean Estado {  get; set; }
    }
}
