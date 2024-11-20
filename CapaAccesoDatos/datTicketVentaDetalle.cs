using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class datTicketVentaDetalle
    {
        #region sigleton
        //Patron singleton
        //Variable estatica para la instancia
        private static readonly datTicketVentaDetalle _instancia = new datTicketVentaDetalle();
        //privado para evitar la instancia directa
        public static datTicketVentaDetalle Instancia
        {
            get
            {
                return datTicketVentaDetalle._instancia;
            }
        }
        #endregion sigleton
        #region Métodos

        // Insertar TicketVenta
        public void InsertarTicketVentaDetalle(entTicketVentaDetalle detalle)
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarTicketVentaDetalle", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdTicketVenta", detalle.IdTicketVenta);
                cmd.Parameters.AddWithValue("@IdProducto", detalle.IdProducto);
                cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                cmd.Parameters.AddWithValue("@PrecioUnitario", detalle.PrecioUnitario);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection.State == ConnectionState.Open)
                    cmd.Connection.Close();
            }
        }

        #endregion

    }
}
