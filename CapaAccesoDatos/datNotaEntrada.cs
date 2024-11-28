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
    public class datNotaEntrada
    {
        #region sigleton
        //Patron singleton
        //Variable estatica para la instancia
        private static readonly datNotaEntrada _instancia = new datNotaEntrada();
        //privado para evitar la instancia directa
        public static datNotaEntrada Instancia
        {
            get
            {
                return datNotaEntrada._instancia;
            }
        }
        #endregion sigleton
        #region Metodos

        // Insertar
        public int InsertarNotaEntrada(entNotaEntrada notaEntrada)
        {
            SqlCommand cmd = null;
            int idNotaEntrada = 0;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarNotaEntrada", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FechaRegistro", notaEntrada.FechaRegistro);

                cmd.Parameters.AddWithValue("@IdEmpleado", notaEntrada.IdEmpleado);
                cmd.Parameters.AddWithValue("@IdGuiaRemision", notaEntrada.IdGuiaRemision);
                cmd.Parameters.AddWithValue("@IdProveedor", notaEntrada.IdProveedor);

                SqlParameter outputId = new SqlParameter("@IdNotaEntrada", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputId);

                cn.Open();
                cmd.ExecuteNonQuery();

                idNotaEntrada = Convert.ToInt32(outputId.Value);
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

            return idNotaEntrada;
        }

        #endregion Metodos
    }
}
