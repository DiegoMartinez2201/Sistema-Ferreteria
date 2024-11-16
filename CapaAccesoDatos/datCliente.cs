using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class datCliente
    {
        #region sigleton
        //Patron singleton
        //Variable estatica para la instancia
        private static readonly datCliente _instancia = new datCliente();
        //privado para evitar la instancia directa
        public static datCliente Instancia
        {
            get
            {
                return datCliente._instancia;
            }
        }
        #endregion sigleton
        #region metodos
        
       
        ///Lista de Cliente
        public List<entCliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Cli = new entCliente();
                    
                    Cli.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                    Cli.Telefono = dr["Telefono"].ToString();
                    Cli.Direccion = dr["Direccion"].ToString();
                    Cli.Correo = dr["Correo"].ToString();
                    Cli.TipoDocumento = dr["TipoDocumento"].ToString();
                    Cli.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                    Cli.Estado = Convert.ToBoolean(dr["Estado"]);
                    Cli.IdTipoCliente = Convert.ToInt32(dr["IdTipoCliente"]);
                    Cli.IdEmpleado = Convert.ToInt32(dr ["IdEmpleado"]);
                    Cli.DNI = dr["DNI"].ToString();
                    Cli.Nombres = dr["Nombres"].ToString();
                    Cli.Apellidos = dr["Apellidos"].ToString();
                    Cli.Ruc = dr["Ruc"].ToString();
                    Cli.RazonSocial = dr["RazonSocial"].ToString();
                    lista.Add(Cli);
                    

                }
            }
            catch(Exception e)
            {
                throw e;
            }
            finally {
                cmd.Connection.Close();
            }
            return lista;
        }
        
        ///Inserta Cliente
        public Boolean InsertarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Telefono", Cli.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", Cli.Direccion);
                cmd.Parameters.AddWithValue("@Correo", Cli.Correo);
                cmd.Parameters.AddWithValue("@TipoDocumento", Cli.TipoDocumento);
                cmd.Parameters.AddWithValue("@IdTipoCliente", Cli.IdTipoCliente);
                cmd.Parameters.AddWithValue("@FechaCreacion", Cli.FechaCreacion);
                cmd.Parameters.AddWithValue("@Estado", Cli.Estado);
                cmd.Parameters.AddWithValue("@IdEmpleado", Cli.IdEmpleado);
                //Parametros si es persona natural
                cmd.Parameters.AddWithValue("@Dni",Cli.DNI);
                cmd.Parameters.AddWithValue("@Nombres", Cli.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", Cli.Apellidos);
                //Parametros si es empresa
                cmd.Parameters.AddWithValue("@Ruc",Cli.Ruc);
                cmd.Parameters.AddWithValue("RazonSocial", Cli.RazonSocial);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) 
                {
                    inserta = true;
                }

            }
            catch(Exception e) 
            {
                throw e;
            }
            finally {cmd.Connection.Close();}
            return inserta; 
        }
        
        ///Edita Cliente
        public Boolean EditarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCliente", Cli.IdCliente);
                cmd.Parameters.AddWithValue("@Telefono", Cli.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", Cli.Direccion);
                cmd.Parameters.AddWithValue("@Correo", Cli.Correo);
                cmd.Parameters.AddWithValue("@TipoDocumento", Cli.TipoDocumento);
                cmd.Parameters.AddWithValue("@IdTipoCliente", Cli.IdTipoCliente);
                cmd.Parameters.AddWithValue("@IdEmpleado", Cli.IdEmpleado);
                //Parametros para Persona Natural
                cmd.Parameters.AddWithValue("@Dni", Cli.DNI);
                cmd.Parameters.AddWithValue("@Nombres",Cli.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos",Cli.Apellidos);
                //Parametros para Empresa
                cmd.Parameters.AddWithValue("@Ruc", Cli.Ruc);
                cmd.Parameters.AddWithValue("@RazonSocial",Cli.RazonSocial);
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
            finally { cmd.Connection.Close();}
            return edita;
        }
        
        //Deshabilita Cliente
        public Boolean DeshabilitarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCliente",Cli.IdCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch(Exception e) 
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }
        
        #endregion metodos
    }
}
