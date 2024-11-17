using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProducto
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logProducto _instancia = new logProducto();
        //privado para evitar la instanciación directa
        public static logProducto Instancia
        {
            get
            {
                return logProducto._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //listado
        public List<entProducto> Listarproductos()
        {
            return datProducto.Instancia.ListarProducto();
        }

        //inserta
        public void InsertaProducto(entProducto producto)
        {
            datProducto.Instancia.InsertarProducto(producto);
        }
        //edita
        public void EditaProducto(entProducto producto)
        {
            datProducto.Instancia.EditarProducto(producto);
        }
        //deshabilita
        public void DeshabilitarProducto(entProducto producto)
        {
            datProducto.Instancia.DeshabilitarProductos(producto);
        }
        #endregion metodos
    }
}
