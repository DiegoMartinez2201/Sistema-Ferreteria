﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entRepresentanteProveedor
    {
        public int IdRepresentante { get; set; }
        public entProveedor IdProveedor { get; set; }
        public string Nombres { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

    }
}
