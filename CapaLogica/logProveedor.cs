using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProveedor
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logProveedor _instancia = new logProveedor();
        //privado para evitar la instanciación directa
        public static logProveedor Instancia
        {
            get
            {
                return logProveedor._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //listado
        public List<entProveedor> ListarProveedor()
        {
            return datProveedor.Instancia.ListarProveedor();
        }

        //inserta
        public void InsertaProveedor(entProveedor proveedor)
        {
            datProveedor.Instancia.InsertarProveedor(proveedor);
        }
        //edita
        public void EditaProveedor(entProveedor proveedor)
        {
            datProveedor.Instancia.EditarProveedor(proveedor);
        }
        //deshabilita
        public void DeshabilitarProveedor(entProveedor proveedor)
        {
            datProveedor.Instancia.DeshabilitarProveedor(proveedor);
        }

        #endregion metodos
    }
}
