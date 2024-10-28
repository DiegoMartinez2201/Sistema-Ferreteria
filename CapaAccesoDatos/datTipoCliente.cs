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
                SqlConnection cn = Conexion.Instancia.Conectar(); // Asumiendo que tienes un singleton para la conexión
                cmd = new SqlCommand("spCargarComboboxTipoCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entTipoCliente tipoCliente = new entTipoCliente
                    {
                        IdTipoCliente = Convert.ToInt32(dr["IdTipoCliente"]),
                        Nombre = dr["Nombre"].ToString()
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
        #endregion metodos
    }
}
