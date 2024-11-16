using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logConsultaProveedor
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logConsultaProveedor _instancia = new logConsultaProveedor();
        //privado para evitar la instanciación directa
        public static logConsultaProveedor Instancia
        {
            get
            {
                return logConsultaProveedor._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //listado
        public List<entProveedor> ListarProveedor()
        {
            return datProveedor.Instancia.ListarProveedor();
        }

        #endregion metodos
    }
}
