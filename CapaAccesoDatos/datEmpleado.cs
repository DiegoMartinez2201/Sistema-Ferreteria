using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class datEmpleado
    {
        #region singleton
        //Patron singleton
        //variable estatica para la instancia
        private static readonly datEmpleado _instancia = new datEmpleado();
        //privado para evitar la instancia directa
        public static datEmpleado Instancia
        {
            get 
            { 
                return datEmpleado._instancia; 
            } 
        }
        #endregion singleton
        #region metodos
        //Validacion de Empleados
        public entEmpleado ValidarEmpleado(string usuario, string contrasena)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            entEmpleado objEmpleado = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spValidarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NameLogin", usuario);
                cmd.Parameters.AddWithValue("@Password", contrasena);
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    objEmpleado = new entEmpleado
                    {
                        IdEmpleado = Convert.ToInt32(dr["IdEmpleado"]),
                        Nombres = dr["Nombres"].ToString(),
                        IdCargo = Convert.ToInt32(dr["IdCargo"])
                    };
                    
                }
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            finally
            {
                if (dr != null) dr.Close();
                if (cmd != null) cmd.Connection.Close();
            }
            return objEmpleado;
        }

        public List<entEmpleado> ListarEmpleado()
        {
            SqlCommand cmd = null;
            List<entEmpleado> lista = new List<entEmpleado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaEmpleado",cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEmpleado empleado = new entEmpleado();

                    empleado.IdEmpleado = Convert.ToInt32(dr["IdEmpleado"]);
                    empleado.Dni = dr["Dni"].ToString();
                    empleado.Nombres = dr["Nombres"].ToString();
                    empleado.Apellidos = dr["Apellidos"].ToString();
                    empleado.telefono = dr["telefono"].ToString();
                    empleado.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                    empleado.Estado = Convert.ToBoolean(dr["Estado"]);
                    empleado.NameLogin = dr["NameLogin"].ToString();
                    empleado.Password = dr["Password"].ToString();
                    empleado.IdCargo = Convert.ToInt32(dr["IdCargo"]);
                    empleado.IdEmpleadoRegistro = Convert.ToInt32(dr["IdEmpleado"]);
                    lista.Add(empleado);

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
        public Boolean InsertaEmpleado(entEmpleado empleado)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Dni", empleado.Dni);
                cmd.Parameters.AddWithValue("@Nombres", empleado.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", empleado.Apellidos);
                cmd.Parameters.AddWithValue("@telefono", empleado.telefono);
                cmd.Parameters.AddWithValue("@FechaCreacion", empleado.FechaCreacion);
                cmd.Parameters.AddWithValue("@Estado", empleado.Estado);
                cmd.Parameters.AddWithValue("@NameLogin", empleado.NameLogin);
                cmd.Parameters.AddWithValue("@Password", empleado.Password);
                cmd.Parameters.AddWithValue("@IdCargo", empleado.IdCargo);
                cmd.Parameters.AddWithValue("@IdEmpleadoRegistro", empleado.IdEmpleadoRegistro);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i>0)
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
        public Boolean EditarEmpleado(entEmpleado empleado)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado);
                cmd.Parameters.AddWithValue("@Dni", empleado.Dni);
                cmd.Parameters.AddWithValue("@Nombres", empleado.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", empleado.Apellidos);
                cmd.Parameters.AddWithValue("@telefono", empleado.telefono);
                cmd.Parameters.AddWithValue("@IdCargo", empleado.IdCargo);
                cmd.Parameters.AddWithValue("@NameLogin", empleado.NameLogin);
                cmd.Parameters.AddWithValue("@IdEmpleadoRegistro", empleado.IdEmpleadoRegistro);
                cmd.Parameters.AddWithValue("@Password", empleado.Password);

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
            finally
            {
                cmd.Connection.Close();
            }
            return edita;
        }
        public Boolean DeshabilitarEmpleado(entEmpleado empleado)
        {

            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado);
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
