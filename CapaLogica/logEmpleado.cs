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
        #region Singleton
        private static readonly logEmpleado _instancia = new logEmpleado();
        public static logEmpleado Instancia
        {
            get { return _instancia; }
        }
        #endregion Singleton
        #region Metodos

        public entEmpleado ValidarEmpleado(string usuario, string contrasena)
        {
            return datEmpleado.Instancia.ValidarEmpleado(usuario, contrasena);
        }
        public List<entEmpleado> ListarEmpleado()
        {
            return datEmpleado.Instancia.ListarEmpleado();
        }
        public void InsertEmpleado(entEmpleado empleado)
        {
            datEmpleado.Instancia.InsertaEmpleado(empleado);
        }
        public void EditaEmpleado(entEmpleado empleado)
        {
            datEmpleado.Instancia.EditarEmpleado(empleado);
        }
        public void DeshabilitarEmpleado(entEmpleado empleado)
        {
            datEmpleado.Instancia.DeshabilitarEmpleado(empleado);
        }
        #endregion Metodos
    }
}
