using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logTicketVentaDetalle
    {
        #region sigleton
        private static readonly logTicketVentaDetalle _instancia = new logTicketVentaDetalle();
        public static logTicketVentaDetalle Instancia
        {
            get
            {
                return logTicketVentaDetalle._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entTicketVentaDetalle> ListarTicketVentaDetalle(int IdTicketVenta)
        {
            return datTicketVentaDetalle.Instancia.ListarTickeVentaDetalle(IdTicketVenta);
        }

        #endregion metodos


    }
}
