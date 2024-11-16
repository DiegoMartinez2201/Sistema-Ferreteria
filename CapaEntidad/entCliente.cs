using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCliente
    {
        public int IdCliente { get; set; }
        public string Correo { get; set; }
        public string TipoDocumento { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public int IdTipoCliente { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Boolean Estado { get; set; }
        public string DNI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Ruc { get; set; }  
        public string RazonSocial { get; set; } 
    }
}
