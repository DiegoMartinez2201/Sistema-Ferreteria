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
                        Estado = Convert.ToBoolean(dr["Estado"])
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
        #endregion metodos

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

    }
}
