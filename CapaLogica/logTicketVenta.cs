using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logTicketVenta
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logTicketVenta _instancia = new logTicketVenta();
        //privado para evitar la instanciación directa
        public static logTicketVenta Instancia
        {
            get
            {
                return logTicketVenta._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public void RegistrarTicket(entTicketVenta ticket)
        {
            try
            {
                int idTicketVenta = datTicketVenta.Instancia.InsertarTicketVenta(ticket);

                foreach (var detalle in ticket.Detalle)
                {
                    detalle.IdTicketVenta = idTicketVenta;
                    datTicketVentaDetalle.Instancia.InsertarTicketVentaDetalle(detalle);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion metodos

    }
}
