using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logCargoEmpleado
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logCargoEmpleado _instancia = new logCargoEmpleado();
        //privado para evitar la instanciación directa
        public static logCargoEmpleado Instancia
        {
            get
            {
                return logCargoEmpleado._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //listado
        public List<entCargoEmpleado> ListarCargo()
        {
            return datCargoEmpleado.Instancia.ListarCargo();
        }

        //inserta
        public void InsertarCargo(entCargoEmpleado cargoEmpleado)
        {
            datCargoEmpleado.Instancia.InsertarCargo(cargoEmpleado);
        }
        //edita
        public void EditarCargo(entCargoEmpleado cargoEmpleado)
        {
            datCargoEmpleado.Instancia.EditarCargo(cargoEmpleado);
        }
        //deshabilita
        public void DeshabilitarCargo(entCargoEmpleado cargoEmpleado)
        {
            datCargoEmpleado.Instancia.DeshabilitarCargo(cargoEmpleado);
        }

        #endregion metodos
    }
}
