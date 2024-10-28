using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPersonaNatural
    {
        public int IdPersonaNatural { get; set; }
        public string DNI { get;set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public entCliente IdCliente { get; set; }   
    }
}
