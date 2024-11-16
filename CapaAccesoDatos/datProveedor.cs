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
    public class datProveedor
    {
        #region sigleton
        //Patron singleton
        //Variable estatica para la instancia
        private static readonly datProveedor _instancia = new datProveedor();
        //privado para evitar la instancia directa
        public static datProveedor Instancia
        {
            get
            {
                return datProveedor._instancia;
            }
        }
        #endregion sigleton
        #region metodos


        ///Lista de Proveedor
        public List<entProveedor> ListarProveedor()
        {
            SqlCommand cmd = null;
            List<entProveedor> lista = new List<entProveedor>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProveedor proveedor = new entProveedor();

                    proveedor.IdProveedor = Convert.ToInt32(dr["IdProveedor"]);
                    proveedor.RazonSocial = dr["RazonSocial"].ToString();
                    proveedor.RUC = dr["Ruc"].ToString();
                    proveedor.Correo = dr["Correo"].ToString();
                    proveedor.Telefono = dr["Telefono"].ToString();
                    proveedor.Direccion = dr["Direccion"].ToString();
                    proveedor.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                    proveedor.Estado = Convert.ToBoolean(dr["Estado"]);
                    proveedor.IdEmpleado = Convert.ToInt32(dr["IdEmpleado"]);
                    proveedor.IdCategoria = Convert.ToInt32(dr["IdCategoria"]);
                    lista.Add(proveedor);
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

        ///Inserta Cliente
        public Boolean InsertarProveedor(entProveedor proveedor)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RUC", proveedor.RUC);
                cmd.Parameters.AddWithValue("RazonSocial", proveedor.RazonSocial);
                cmd.Parameters.AddWithValue("@Correo", proveedor.Correo);
                cmd.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", proveedor.Direccion);
                cmd.Parameters.AddWithValue("@FechaCreacion", proveedor.FechaCreacion);
                cmd.Parameters.AddWithValue("@Estado", proveedor.Estado);
                cmd.Parameters.AddWithValue("@IdEmpleado", proveedor.IdEmpleado);
                cmd.Parameters.AddWithValue("@IdCategoria", proveedor.IdCategoria);

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

        ///Edita Cliente
        public Boolean EditarProveedor(entProveedor proveedor)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProveedor", proveedor.IdProveedor);
                cmd.Parameters.AddWithValue("@RUC", proveedor.RUC);
                cmd.Parameters.AddWithValue("@RazonSocial", proveedor.RazonSocial);
                cmd.Parameters.AddWithValue("@Correo", proveedor.Correo);
                cmd.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", proveedor.Direccion);
                cmd.Parameters.AddWithValue("@IdEmpleado", proveedor.IdEmpleado);
                cmd.Parameters.AddWithValue("@IdCategoria", proveedor.IdCategoria);

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

        //Deshabilita Cliente
        public Boolean DeshabilitarProveedor(entProveedor proveedor)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProveedor", proveedor.IdProveedor);
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
