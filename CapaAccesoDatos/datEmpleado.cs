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
        #endregion metodos
    }
}
