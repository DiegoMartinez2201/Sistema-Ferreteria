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
    public class datRepresentanteProveedor
    {
        #region sigleton
        //Patron singleton
        //Variable estatica para la instancia
        private static readonly datRepresentanteProveedor _instancia = new datRepresentanteProveedor();
        //privado para evitar la instancia directa
        public static datRepresentanteProveedor Instancia
        {
            get
            {
                return datRepresentanteProveedor._instancia;
            }
        }
        #endregion sigleton
        #region metodos


        ///Lista de Cliente
        public List<entRepresentanteProveedor> ListarRepresentante()
        {
            SqlCommand cmd = null;
            List<entRepresentanteProveedor> lista = new List<entRepresentanteProveedor>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaRepresentanteProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entRepresentanteProveedor repreProveedor = new entRepresentanteProveedor();

                    repreProveedor.IdRepresentante = Convert.ToInt32(dr["IdRepresentante"]);
                    repreProveedor.IdProveedor = Convert.ToInt32(dr["IdProveedor"]);
                    repreProveedor.Nombres = dr["Nombres"].ToString();
                    repreProveedor.Apellidos = dr["Apellidos"].ToString();
                    repreProveedor.Correo = dr["Correo"].ToString();
                    repreProveedor.Telefono = dr["Telefono"].ToString();
                    repreProveedor.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                    repreProveedor.Estado = Convert.ToBoolean(dr["Estado"]);
                    repreProveedor.IdEmpleado = Convert.ToInt32(dr["IdEmpleado"]);

                 
                    lista.Add(repreProveedor);


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

        ///Inserta Representante Proveedor
        public Boolean InsertarRepresentanteProveedor(entRepresentanteProveedor representanteProveedor)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaRepresentanteProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProveedor", representanteProveedor.IdProveedor);
                cmd.Parameters.AddWithValue("@Nombres", representanteProveedor.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", representanteProveedor.Apellidos);
                cmd.Parameters.AddWithValue("@Correo", representanteProveedor.Correo);
                cmd.Parameters.AddWithValue("@Telefono", representanteProveedor.Telefono);
                cmd.Parameters.AddWithValue("@FechaCreacion", representanteProveedor.FechaCreacion);
                cmd.Parameters.AddWithValue("@Estado", representanteProveedor.Estado);
                cmd.Parameters.AddWithValue("@IdEmpleado", representanteProveedor.IdEmpleado);

                
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

        ///Edita Cliente
        public Boolean EditarRepresentateProveedor(entRepresentanteProveedor representanteProveedor)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaRepresentanteProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdRepresentante", representanteProveedor.IdRepresentante);
                cmd.Parameters.AddWithValue("@IdProveedor", representanteProveedor.IdProveedor);
                cmd.Parameters.AddWithValue("@Nombres", representanteProveedor.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", representanteProveedor.Apellidos);
                cmd.Parameters.AddWithValue("@Correo", representanteProveedor.Correo);
                cmd.Parameters.AddWithValue("@Telefono", representanteProveedor.Telefono);
             
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

        //Deshabilita Cliente
        public Boolean DeshabilitarRepresentateProveedor(entRepresentanteProveedor representanteProveedor)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdRepresentante", representanteProveedor.IdRepresentante);
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
