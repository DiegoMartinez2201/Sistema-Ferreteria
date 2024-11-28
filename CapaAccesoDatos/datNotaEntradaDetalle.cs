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
    public class datNotaEntradaDetalle
    {
        #region sigleton
        //Patron singleton
        //Variable estatica para la instancia
        private static readonly datNotaEntradaDetalle _instancia = new datNotaEntradaDetalle();
        //privado para evitar la instancia directa
        public static datNotaEntradaDetalle Instancia
        {
            get
            {
                return datNotaEntradaDetalle._instancia;
            }
        }
        #endregion sigleton
        #region Metodos

        // Insertar
        public bool InsertarNotaEntradaDetalle(entNotaEntradaDetalle detalle)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarNotaEntradaDetalle", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdNotaEntrada", detalle.IdNotaEntrada);
                cmd.Parameters.AddWithValue("@IdProducto", detalle.IdProducto);
                cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);

                cn.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception)
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

        #endregion Metodos
    }
}
