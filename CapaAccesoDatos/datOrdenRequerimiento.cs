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
    public class datOrdenRequerimiento
    {
        #region Singleton
        private static readonly datOrdenRequerimiento _instancia = new datOrdenRequerimiento();
        public static datOrdenRequerimiento Instancia
        {
            get { return _instancia; }
        }
        #endregion Singleton

        #region Métodos

        // Listar Orden de Requerimiento
        public List<entOrdenRequerimiento> ListarOrdenRequerimiento()
        {
            SqlCommand cmd = null;
            List<entOrdenRequerimiento> lista = new List<entOrdenRequerimiento>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // Asegúrate de tener una clase Conexion
                cmd = new SqlCommand("spListaOrdenRequerimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrdenRequerimiento orden = new entOrdenRequerimiento
                    {
                        IdOrdenRequerimiento = Convert.ToInt32(dr["IdOrdenRequerimiento"]),
                        FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]),
                        Estado = Convert.ToBoolean(dr["Estado"]),
                        IdProveedor = new entProveedor { IdProveedor = Convert.ToInt32(dr["IdProveedor"]) },
                    };
                    lista.Add(orden);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }
            return lista;
        }

        // Insertar Orden de Requerimiento
        public int InsertarOrdenRequerimiento(entOrdenRequerimiento orden, SqlConnection cn, SqlTransaction transaction)
        {
            using (SqlCommand cmd = new SqlCommand("sp_InsertarOrdenRequerimiento", cn, transaction))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FechaRegistro", orden.FechaRegistro);
                cmd.Parameters.AddWithValue("@Estado", orden.Estado);
                cmd.Parameters.AddWithValue("@IdProveedor", orden.IdProveedor.IdProveedor);

                SqlParameter outputIdParam = new SqlParameter("@IdOrdenRequerimiento", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputIdParam);

                cmd.ExecuteNonQuery();
                return (int)outputIdParam.Value; // Devuelve el ID de la orden insertada
            }
        }

        #endregion Métodos
    }
}
