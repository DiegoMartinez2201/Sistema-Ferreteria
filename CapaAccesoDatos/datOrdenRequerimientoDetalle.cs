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
    public class datOrdenRequerimientoDetalle
    {
        #region Singleton
        private static readonly datOrdenRequerimientoDetalle _instancia = new datOrdenRequerimientoDetalle();
        public static datOrdenRequerimientoDetalle Instancia
        {
            get { return _instancia; }
        }
        #endregion Singleton

        #region Métodos

        // Listar Detalle de Orden de Requerimiento
        public List<entOrdenRequerimientoDetalle> ListarOrdenRequerimientoDetalle(int idOrden)
        {
            SqlCommand cmd = null;
            List<entOrdenRequerimientoDetalle> lista = new List<entOrdenRequerimientoDetalle>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaOrdenRequerimientoDetalle", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdOrdenRequerimiento", idOrden);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrdenRequerimientoDetalle detalle = new entOrdenRequerimientoDetalle
                    {
                        IdOrdenRequerimiento = Convert.ToInt32(dr["IdOrdenRequerimiento"]),
                        IdProducto = new entProducto { IdProducto = Convert.ToInt32(dr["IdProducto"]) },
                        Cantidad = Convert.ToInt32(dr["Cantidad"])
                    };
                    lista.Add(detalle);
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

        // Insertar Detalle de Orden de Requerimiento
        public void InsertarOrdenRequerimientoDetalle(entOrdenRequerimientoDetalle detalle, SqlConnection cn, SqlTransaction transaction)
        {
            using (SqlCommand cmd = new SqlCommand("sp_InsertarOrdenRequerimientoDetalle", cn, transaction))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdOrdenRequerimiento", detalle.IdOrdenRequerimiento);
                cmd.Parameters.AddWithValue("@IdProducto", detalle.IdProducto.IdProducto);
                cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);

                cmd.ExecuteNonQuery();
            }
        }

        #endregion Métodos
    }
}
