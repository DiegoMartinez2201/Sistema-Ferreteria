﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCategoria
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set;}
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdEmpleado { get; set; }
        public Boolean Estado { get; set; } 

    }
}
