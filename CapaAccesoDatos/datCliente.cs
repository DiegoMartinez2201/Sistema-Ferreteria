using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class datCliente
    {
        #region sigleton
        //Patron singleton
        //Variable estatica para la instancia
        private static readonly datCliente _instancia = new datCliente();
        //privado para evitar la instancia directa
        public static datCliente Instancia
        {
            get
            {
                return datCliente._instancia;
            }
        }
        #endregion sigleton
    }
}
