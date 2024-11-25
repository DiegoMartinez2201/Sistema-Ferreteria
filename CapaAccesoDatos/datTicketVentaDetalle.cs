using CapaEntidad;
using System;
using System.Data.SqlClient;
using System.Data;

namespace CapaAccesoDatos
{
    public class datTicketVentaDetalle
    {
        #region sigleton
        private static readonly datTicketVentaDetalle _instancia = new datTicketVentaDetalle();
        public static datTicketVentaDetalle Instancia
        {
            get
            {
                return datTicketVentaDetalle._instancia;
            }
        }
        #endregion sigleton

        #region Métodos
        public bool InsertarTicketVentaDetalle(entTicketVentaDetalle detalle)
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
                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception e)
            {
                // Registrar el error si tienes un sistema de logging
                return false;
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