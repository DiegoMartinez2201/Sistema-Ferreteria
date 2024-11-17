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
    public class datProducto
    {
        #region sigleton
        //Patron singleton
        //Variable estatica para la instancia
        private static readonly datProducto _instancia = new datProducto();
        //privado para evitar la instancia directa
        public static datProducto Instancia
        {
            get
            {
                return datProducto._instancia;
            }
        }
        #endregion sigleton
        #region metodos


        ///Lista de Producto
        public List<entProducto> ListarProducto()
        {
            SqlCommand cmd = null;
            List<entProducto> lista = new List<entProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProducto productos = new entProducto();
                    productos.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                    productos.Nombre = dr["Nombre"].ToString();
                    productos.Descripcion = dr["Descripcion"].ToString();
                    productos.IdCategoria = Convert.ToInt32(dr["IdCategoria"]);
                    productos.IdUnidadMedida = Convert.ToInt32(dr["IdUnidadMedida"]);
                    productos.IdProveedor = Convert.ToInt32(dr["IdProveedor"]);
                    productos.Stock = Convert.ToInt32(dr["Stock"]);
                    productos.FechaVencimiento = Convert.ToDateTime(dr["FechaVencimiento"]);
                    productos.PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"]);
                    productos.PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]);
                    productos.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                    productos.Estado = Convert.ToBoolean(dr["Estado"]);
                    productos.FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"]);
                    productos.IdEmpleado = Convert.ToInt32(dr["IdEmpleado"]);
                    lista.Add(productos);
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

        ///Inserta Productos
        public Boolean InsertarProducto(entProducto productos)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", productos.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", productos.Descripcion);
                cmd.Parameters.AddWithValue("@IdCategoria", productos.IdCategoria);
                cmd.Parameters.AddWithValue("@IdUnidadMedida", productos.IdUnidadMedida);
                cmd.Parameters.AddWithValue("@IdProveedor", productos.IdProveedor);
                cmd.Parameters.AddWithValue("@Stock", productos.Stock);
                cmd.Parameters.AddWithValue("@FechaVencimiento", productos.FechaVencimiento);
                cmd.Parameters.AddWithValue("@PrecioCompra", productos.PrecioCompra);
                cmd.Parameters.AddWithValue("@PrecioVenta", productos.PrecioVenta);
                cmd.Parameters.AddWithValue("@FechaCreacion", productos.FechaCreacion);
                cmd.Parameters.AddWithValue("@Estado", productos.Estado);
                cmd.Parameters.AddWithValue("@FechaIngreso", productos.FechaIngreso);
                cmd.Parameters.AddWithValue("@IdEmpleado", productos.IdEmpleado);
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

        ///Edita Producto
        public Boolean EditarProducto(entProducto productos)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProducto", productos.IdProducto);
                cmd.Parameters.AddWithValue("@Nombre", productos.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", productos.Descripcion);
                cmd.Parameters.AddWithValue("@IdCategoria", productos.IdCategoria);
                cmd.Parameters.AddWithValue("@IdUnidadMedida", productos.IdUnidadMedida);
                cmd.Parameters.AddWithValue("@IdProveedor", productos.IdProveedor);
                cmd.Parameters.AddWithValue("@Stock", productos.Stock);
                cmd.Parameters.AddWithValue("@FechaVencimiento", productos.FechaVencimiento);
                cmd.Parameters.AddWithValue("@PrecioCompra", productos.PrecioCompra);
                cmd.Parameters.AddWithValue("@PrecioVenta", productos.PrecioVenta);
                cmd.Parameters.AddWithValue("@FechaIngreso", productos.FechaIngreso);
                cmd.Parameters.AddWithValue("@IdEmpleado", productos.IdEmpleado);
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

        //Deshabilita Producto
        public Boolean DeshabilitarProductos(entProducto productos)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProducto", productos.IdProducto);
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
