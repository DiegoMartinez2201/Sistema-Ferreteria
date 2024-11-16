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
    public class datCargoEmpleado
    {
        #region sigleton
        //Patron singleton
        //Variable estatica para la instancia
        private static readonly datCargoEmpleado _instancia = new datCargoEmpleado();
        //privado para evitar la instancia directa
        public static datCargoEmpleado Instancia
        {
            get
            {
                return datCargoEmpleado._instancia;
            }
        }
        #endregion sigleton
        #region metodos


        ///Lista de Categoria
        public List<entCargoEmpleado> ListarCargo()
        {
            SqlCommand cmd = null;
            List<entCargoEmpleado> lista = new List<entCargoEmpleado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaCargoEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCargoEmpleado cargo = new entCargoEmpleado();

                    cargo.IdCargo = Convert.ToInt32(dr["IdCargo"]);
                    cargo.nombre = dr["nombre"].ToString();
                    cargo.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                    cargo.Estado = Convert.ToBoolean(dr["Estado"]);
                    cargo.IdEmpleado = Convert.ToInt32(dr["IdEmpleado"]);
                    lista.Add(cargo);
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
        public Boolean InsertarCargo(entCargoEmpleado cargo)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaCargoEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", cargo.nombre);
                cmd.Parameters.AddWithValue("@FechaCreacion", cargo.FechaCreacion);
                cmd.Parameters.AddWithValue("@Estado", cargo.Estado);
                cmd.Parameters.AddWithValue("@IdEmpleado", cargo.IdEmpleado);
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
        public Boolean EditarCargo(entCargoEmpleado cargoEmpleado)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaCargoEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCargo", cargoEmpleado.IdCargo);
                cmd.Parameters.AddWithValue("@nombre", cargoEmpleado.nombre);
                cmd.Parameters.AddWithValue("@IdEmpleado", cargoEmpleado.IdEmpleado);
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
        public Boolean DeshabilitarCargo(entCargoEmpleado cargoEmpleado)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaCargoEmpleado", cn);
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
