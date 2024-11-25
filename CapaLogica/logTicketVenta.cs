using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;

namespace CapaLogica
{
    public class logTicketVenta
    {
        #region sigleton
        private static readonly logTicketVenta _instancia = new logTicketVenta();
        public static logTicketVenta Instancia
        {
            get
            {
                return logTicketVenta._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public bool InsertarVenta(entTicketVenta ticket, List<entTicketVentaDetalle> detalles)
        {
            try
            {
                // Asignar los detalles al ticket
                ticket.Detalle = detalles;

                // Registrar el ticket
                int idTicketVenta = datTicketVenta.Instancia.InsertarTicketVenta(ticket);

                if (idTicketVenta <= 0)
                    return false;

                // Registrar cada detalle
                foreach (var detalle in detalles)
                {
                    detalle.IdTicketVenta = idTicketVenta;
                    bool resultado = datTicketVentaDetalle.Instancia.InsertarTicketVentaDetalle(detalle);
                    if (!resultado)
                    {
                        // Si falla la inserción de un detalle, consideramos que toda la operación falló
                        return false;
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RegistrarTicket(entTicketVenta ticket)
        {
            try
            {
                int idTicketVenta = datTicketVenta.Instancia.InsertarTicketVenta(ticket);
                if (idTicketVenta <= 0)
                    return false;

                foreach (var detalle in ticket.Detalle)
                {
                    detalle.IdTicketVenta = idTicketVenta;
                    if (!datTicketVentaDetalle.Instancia.InsertarTicketVentaDetalle(detalle))
                        return false;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion metodos
    }
}