using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logMetodoPago
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logMetodoPago _instancia = new logMetodoPago();
        //privado para evitar la instanciación directa
        public static logMetodoPago Instancia
        {
            get
            {
                return logMetodoPago._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //listado
        public List<entMetodoPago> ListarMetodoPago()
        {
            return datMetodoPago.Instancia.ListarMetodoPago();
        }

        //inserta
        public void InsertarMetodoPago(entMetodoPago metodoPago)
        {
            datMetodoPago.Instancia.InsertarMetodoPago(metodoPago);
        }
        //edita
        public void EditaMetodoPago(entMetodoPago metodoPago)
        {
            datMetodoPago.Instancia.EditarMetodoPago(metodoPago);
        }
        //deshabilita
        public void DeshabilitarMetodoPago(entMetodoPago metodoPago)
        {
            datMetodoPago.Instancia.DeshabilitarMetodoPago(metodoPago);
        }

        #endregion metodos
    }
}
