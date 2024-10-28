using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logEmpleado
    {
        private static readonly logEmpleado _instancia = new logEmpleado();
        public static logEmpleado Instancia
        {
            get { return _instancia; }
        }
        public entEmpleado ValidarEmpleado(string usuario, string contrasena)
        {
            return datEmpleado.Instancia.ValidarEmpleado(usuario, contrasena);
        }
    }
}
