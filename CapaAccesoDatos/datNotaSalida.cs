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
    public class datNotaSalida
    {
        #region sigleton
        //Patron singleton
        //Variable estatica para la instancia
        private static readonly datNotaSalida _instancia = new datNotaSalida();
        //privado para evitar la instancia directa
        public static datNotaSalida Instancia
        {
            get
            {
                return datNotaSalida._instancia;
            }
        }
        #endregion sigleton
        #region Metodos

        // Insertar
        public int InsertarNotaSalida(entNotaSalida notaSalida)
        {
            SqlCommand cmd = null;
            int idNotaSalida = 0;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarNotaSalida", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdTicketVenta", notaSalida.IdTicketVenta);
                cmd.Parameters.AddWithValue("@FechaRegistro", notaSalida.FechaRegistro);
                cmd.Parameters.AddWithValue("@IdEmpleado", notaSalida.IdEmpleado);

                SqlParameter outputId = new SqlParameter("@IdNotaSalida", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputId);

                cn.Open();
                cmd.ExecuteNonQuery();

                idNotaSalida = Convert.ToInt32(outputId.Value);
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

            return idNotaSalida;
        }

        #endregion Metodos
    }
}
