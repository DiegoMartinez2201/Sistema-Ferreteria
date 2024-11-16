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
    public class datUnidadMedida
    {
        #region sigleton
        //Patron singleton
        //Variable estatica para la instancia
        private static readonly datUnidadMedida _instancia = new datUnidadMedida();
        //privado para evitar la instancia directa
        public static datUnidadMedida Instancia
        {
            get
            {
                return datUnidadMedida._instancia;
            }
        }
        #endregion sigleton
        #region metodos
        // Método para listar los tipos de cliente
        public List<entUnidadMedida> ListarUnidadMedida()
        {
            SqlCommand cmd = null;
            List<entUnidadMedida> lista = new List<entUnidadMedida>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // Asumiendo que tienes un singleton para la conexión
                cmd = new SqlCommand("spListaUnidadMedida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entUnidadMedida unidadMedida = new entUnidadMedida
                    {
                        IdUnidadMedida = Convert.ToInt32(dr["IdUnidadMedida"]),
                        Nombre = dr["Nombre"].ToString(),
                        Abreviatura = dr["Abreviatura"].ToString(),
                        FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]),
                        Estado = Convert.ToBoolean(dr["Estado"]),
                        IdEmpleado = Convert.ToInt32(dr["IdEmpleado"])
                    };
                    lista.Add(unidadMedida);
                }
                dr.Close();
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
       

        public Boolean InsertarUnidadMedida(entUnidadMedida Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaUnidadMedida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Cli.Nombre);
                cmd.Parameters.AddWithValue("@Abreviatura", Cli.Abreviatura);
                cmd.Parameters.AddWithValue("@FechaCreacion", Cli.FechaCreacion);
                cmd.Parameters.AddWithValue("@Estado", Cli.Estado);
                cmd.Parameters.AddWithValue("@IdEmpleado", Cli.IdEmpleado);
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
        public Boolean EditaUnidadMedida(entUnidadMedida unidadMedida)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaUnidadMedida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUnidadMedida", unidadMedida.IdUnidadMedida);
                cmd.Parameters.AddWithValue("@Nombre", unidadMedida.Nombre);
                cmd.Parameters.AddWithValue("@Abreviatura", unidadMedida.Abreviatura);
                cmd.Parameters.AddWithValue("@IdEmpleado", unidadMedida.IdEmpleado);
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
        public Boolean DeshabilitarUnidadMedida(entUnidadMedida unidadMedida)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaUnidadMedida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUnidadMedida", unidadMedida.IdUnidadMedida);
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
