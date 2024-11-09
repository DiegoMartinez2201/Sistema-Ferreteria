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
        #region singleton
        //Patron singleton
        //Variable estatica para la instancia
        private static readonly logMetodoPago _instancia = new logMetodoPago(); 
        //privado para evitar la instancia directa
        public static logMetodoPago Instancia
        {
            get
            {
                return logMetodoPago._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entMetodoPago> ListarMetodoPago()
        {
            return datMetodoPago.Instancia.ListarMetodoPago();
        }
        public void InsertaMetodoPago(entMetodoPago metodoPago)
        {
            datMetodoPago.Instancia.InsertaMetodoPago(metodoPago);
        }
        public void EditaMetodoPago(entMetodoPago metodoPago)
        {
            datMetodoPago.Instancia.EditarMetodoPago(metodoPago);
        }
        public void DeshabilitaMetodoPago(entMetodoPago metodoPago)
        {
            datMetodoPago.Instancia.DeshabilitarMetodoPago(metodoPago);
        }
        #endregion metodos

    }
}
