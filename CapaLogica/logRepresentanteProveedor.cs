using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logRepresentanteProveedor
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logRepresentanteProveedor _instancia = new logRepresentanteProveedor();
        //privado para evitar la instanciación directa
        public static logRepresentanteProveedor Instancia
        {
            get
            {
                return logRepresentanteProveedor._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //listado
        public List<entRepresentanteProveedor> ListarRepresentateProveedor()
        {
            return datRepresentanteProveedor.Instancia.ListarRepresentante();
        }

        //inserta
        public void InsertaRepresentanteProveedor(entRepresentanteProveedor representanteProveedor)
        {
            datRepresentanteProveedor.Instancia.InsertarRepresentanteProveedor(representanteProveedor);
        }
        //edita
        public void EditaRepresentanteProveedor(entRepresentanteProveedor representanteProveedor)
        {
            datRepresentanteProveedor.Instancia.EditarRepresentateProveedor(representanteProveedor);
        }
        //deshabilita
        public void DeshabilitarRepresentateProveedor(entRepresentanteProveedor representanteProveedor)
        {
            datRepresentanteProveedor.Instancia.DeshabilitarRepresentateProveedor(representanteProveedor);
        }

        #endregion metodos
    }
}
