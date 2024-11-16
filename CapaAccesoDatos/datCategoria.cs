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
    public class datCategoria
    {
        #region sigleton
        //Patron singleton
        //Variable estatica para la instancia
        private static readonly datCategoria _instancia = new datCategoria();
        //privado para evitar la instancia directa
        public static datCategoria Instancia
        {
            get
            {
                return datCategoria._instancia;
            }
        }
        #endregion sigleton
        #region metodos


        ///Lista de Categoria
        public List<entCategoria> ListarCategoria()
        {
            SqlCommand cmd = null;
            List<entCategoria> lista = new List<entCategoria>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCategoria categoria = new entCategoria();

                    categoria.IdCategoria = Convert.ToInt32(dr["IdCategoria"]);
                    categoria.Nombre = dr["Nombre"].ToString();
                    categoria.Descripcion = dr["Descripcion"].ToString();
                    categoria.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                    categoria.IdEmpleado = Convert.ToInt32(dr["IdEmpleado"]);
                    categoria.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(categoria);
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

        ///Inserta Categoria
        public Boolean InsertarCategoria(entCategoria categoria)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                cmd.Parameters.AddWithValue("@FechaCreacion", categoria.FechaCreacion);
                cmd.Parameters.AddWithValue("@IdEmpleado", categoria.IdEmpleado);
                cmd.Parameters.AddWithValue("@Estado", categoria.Estado);
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

        ///Edita Categoria
        public Boolean EditarCategoria(entCategoria categoria)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCategoria", categoria.IdCategoria);
                cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                cmd.Parameters.AddWithValue("@IdEmpleado", categoria.IdEmpleado);
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

        //Deshabilita Categoria
        public Boolean DeshabilitarCategoria(entCategoria categoria)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCategoria", categoria.IdCategoria);
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
