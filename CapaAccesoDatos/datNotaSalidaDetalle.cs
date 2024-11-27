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
    public class datNotaSalidaDetalle
    {
        #region sigleton
        private static readonly datNotaSalidaDetalle _instancia = new datNotaSalidaDetalle();
        public static datNotaSalidaDetalle Instancia
        {
            get
            {
                return datNotaSalidaDetalle._instancia;
            }
        }
        #endregion sigleton
        #region Métodos
        public bool InsertarNotaSalidaDetalle(entNotaSalidaDetalle detalle)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarTicketNotaSalidaDetalle", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdNotaSalida", detalle.IdNotaSalida);
                cmd.Parameters.AddWithValue("@IdProducto", detalle.IdProducto);
                cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);

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
