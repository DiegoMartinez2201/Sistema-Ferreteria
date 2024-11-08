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
        #region singleton
        //Patron Singleton
        //Variable estatica para la instancia
        private static readonly logCargoEmpleado _instancia = new logCargoEmpleado();
        //privado para evitar la instanciacion directa
        public static logCargoEmpleado Instancia
        {
            get
            {
                return logCargoEmpleado._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entCargoEmpleado> ListarCargoEmpleado()
        {
            return datCargoEmpleado.Instancia.ListarCargoEmpleado();
        }
        public void InsertaCargoEmpleado(entCargoEmpleado cargoEmpleado)
        {
            datCargoEmpleado.Instancia.InsertarCargoEmpleado(cargoEmpleado);
        }
        public void EditaCargoEmpleado(entCargoEmpleado cargoEmpleado)
        {
            datCargoEmpleado.Instancia.EditaCargoEmpleado(cargoEmpleado);
        }
        public void DeshabilitaCargoEmpleado(entCargoEmpleado cargoEmpleado)
        {
            datCargoEmpleado.Instancia.DeshabilitaCargoEmpleado(cargoEmpleado);
        }

        #endregion metodos
    }
}
