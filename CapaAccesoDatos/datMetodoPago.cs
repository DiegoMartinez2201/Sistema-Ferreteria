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
    public class datMetodoPago
    {
        #region sigleton
        //Patron singleton
        //Variable estatica para la instancia
        private static readonly datMetodoPago _instancia = new datMetodoPago();
        //privado para evitar la instancia directa
        public static datMetodoPago Instancia
        {
            get
            {
                return datMetodoPago._instancia;
            }
        }

        #endregion sigleton
        #region metodos


        ///Lista de MetodoPago
        public List<entMetodoPago> ListarMetodoPago()
        {
            SqlCommand cmd = null;
            List<entMetodoPago> lista = new List<entMetodoPago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMetodoPago metodoPago = new entMetodoPago();

                    metodoPago.IdMetodoPago = Convert.ToInt32(dr["IdMetodoPago"]);
                    metodoPago.Nombre = dr["Nombre"].ToString();
                    metodoPago.Descripcion = dr["Descripcion"].ToString();
                    metodoPago.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                    metodoPago.Estado = Convert.ToBoolean(dr["Estado"]);
                    metodoPago.IdEmpleado = Convert.ToInt32(dr["IdEmpleado"]);
                  
                    lista.Add(metodoPago);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        ///Inserta MetodoPago
        public Boolean InsertarMetodoPago(entMetodoPago metodoPago)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", metodoPago.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", metodoPago.Descripcion);
                cmd.Parameters.AddWithValue("@FechaCreacion", metodoPago.FechaCreacion);
                cmd.Parameters.AddWithValue("@Estado", metodoPago.Estado);
                cmd.Parameters.AddWithValue("@IdEmpleado", metodoPago.IdEmpleado);
               
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        ///Edita MetodoPago
        public Boolean EditarMetodoPago(entMetodoPago metodoPago)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdMetodoPago", metodoPago.IdMetodoPago);
                cmd.Parameters.AddWithValue("@Nombre", metodoPago.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", metodoPago.Descripcion);
                cmd.Parameters.AddWithValue("@IdEmpleado", metodoPago.IdEmpleado);
               
               
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        //Deshabilita MetodoPago
        public Boolean DeshabilitarMetodoPago(entMetodoPago metodoPago)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdMetodoPago", metodoPago.IdMetodoPago);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }

        #endregion metodos
    }
}
