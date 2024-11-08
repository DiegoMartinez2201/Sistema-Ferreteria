using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CapaAccesoDatos
{
    public class datCargoEmpleado
    {
        #region singleton

        //Patron singleton
        //variable estatica para la instancia
        private static readonly datCargoEmpleado _instancia = new datCargoEmpleado();
        //privado para evitar la instancia directa
        public static datCargoEmpleado Instancia
        {
            get 
            { 
                return datCargoEmpleado._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entCargoEmpleado> ListarCargoEmpleado()
        {
            SqlCommand cmd = null;
            List<entCargoEmpleado> lista = new List<entCargoEmpleado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaCargoEmpleado",cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCargoEmpleado cargoEmpleado = new entCargoEmpleado()
                    {
                        IdCargo = Convert.ToInt32(dr["IdCargo"]),
                        nombre = dr["nombre"].ToString(),
                        FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]),
                        Estado = Convert.ToBoolean(dr["Estado"]),
                        IdEmpleado = Convert.ToInt32(dr["IdEmpleado"])
                    };
                    lista.Add(cargoEmpleado);
                }
                dr.Close();
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        public Boolean InsertarCargoEmpleado(entCargoEmpleado Carg)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaCargoEmpleado",cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre",Carg.nombre);
                cmd.Parameters.AddWithValue("@FechaCreacion", Carg.FechaCreacion);
                cmd.Parameters.AddWithValue("@Estado", Carg.Estado);
                cmd.Parameters.AddWithValue("@IdEmpleado", Carg.IdEmpleado);
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
            finally { cmd.Connection.Close(); }
            return inserta;
        }
        public Boolean EditaCargoEmpleado(entCargoEmpleado cargoEmpleado)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaCargoEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCargo", cargoEmpleado.IdCargo);
                cmd.Parameters.AddWithValue("@nombre",cargoEmpleado.nombre);
                cmd.Parameters.AddWithValue("@IdEmpleado",cargoEmpleado.IdEmpleado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i>0)
                {
                    edita = true;
                }
            }
            catch(Exception e) 
            { 
                throw e; 
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }
        public Boolean DeshabilitaCargoEmpleado(entCargoEmpleado cargoEmpleado)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaCargoEmpleado",cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCargo", cargoEmpleado.IdCargo);
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
