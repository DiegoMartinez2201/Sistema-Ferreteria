using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logUnidadMedida
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logUnidadMedida _instancia = new logUnidadMedida();
        //privado para evitar la instanciación directa
        public static logUnidadMedida Instancia
        {
            get
            {
                return logUnidadMedida._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entUnidadMedida> ListarUnidadMedida()
        {
            return datUnidadMedida.Instancia.ListarUnidadMedida();
        }
        #endregion metodos
    }
}
