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
    public class datTipoCliente
    {
        #region sigleton
        //Patron singleton
        //Variable estatica para la instancia
        private static readonly datTipoCliente _instancia = new datTipoCliente();
        //privado para evitar la instancia directa
        public static datTipoCliente Instancia
        {
            get
            {
                return datTipoCliente._instancia;
            }
        }
        #endregion sigleton
        #region metodos
        // Método para listar los tipos de cliente
        public List<entTipoCliente> ListarTipoCliente()
        {
            SqlCommand cmd = null;
            List<entTipoCliente> lista = new List<entTipoCliente>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); 
                cmd = new SqlCommand("spListaTipoCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entTipoCliente tipoCliente = new entTipoCliente
                    {
                        IdTipoCliente = Convert.ToInt32(dr["IdTipoCliente"]),
                        Nombre = dr["Nombre"].ToString(),
                        FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]),
                        Estado = Convert.ToBoolean(dr["Estado"]),
                        IdEmpleado = Convert.ToInt32(dr["IdEmpleado"])
                    };
                    lista.Add(tipoCliente);
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
        public Boolean InsertarTipoCliente(entTipoCliente tipoCliente)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaTipoCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", tipoCliente.Nombre);
                cmd.Parameters.AddWithValue("@FechaCreacion", tipoCliente.FechaCreacion);
                cmd.Parameters.AddWithValue("@Estado", tipoCliente.Estado);
                cmd.Parameters.AddWithValue("@IdEmpleado", tipoCliente.IdEmpleado);
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
        public Boolean EditaTipoCliente(entTipoCliente tipoCliente)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaTipoCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTipoCliente", tipoCliente.IdTipoCliente);
                cmd.Parameters.AddWithValue("@Nombre", tipoCliente.Nombre);
                cmd.Parameters.AddWithValue("@IdEmpleado", tipoCliente.IdEmpleado);
                cn.Open() ;
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }

            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return edita;
        }
        public Boolean DeshabilitarTipoCliente(entTipoCliente tipoCliente)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaTipoCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTipoCliente", tipoCliente.IdTipoCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch(Exception e) { throw e; }
            finally { cmd.Connection.Close(); } 
            return delete;
        }
        #endregion metodos
    }
}
