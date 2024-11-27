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
    public class datTicketVenta
    {
        #region sigleton
        //Patron singleton
        //Variable estatica para la instancia
        private static readonly datTicketVenta _instancia = new datTicketVenta();
        //privado para evitar la instancia directa
        public static datTicketVenta Instancia
        {
            get
            {
                return datTicketVenta._instancia;
            }
        }

        #endregion sigleton
        #region Metodos

        // Insertar TicketVenta
        public int InsertarTicketVenta(entTicketVenta ticket)
        {
            SqlCommand cmd = null;
            int idTicketVenta = 0;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarTicketVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdCliente", ticket.IdCliente);
                cmd.Parameters.AddWithValue("@FechaRegistro", ticket.FechaRegistro);
                cmd.Parameters.AddWithValue("@IdMetodoPago", ticket.IdMetodoPago);
                cmd.Parameters.AddWithValue("@IdEmpleado", ticket.IdEmpleado);

                SqlParameter outputId = new SqlParameter("@IdTicketVenta", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputId);

                cn.Open();
                cmd.ExecuteNonQuery();

                idTicketVenta = Convert.ToInt32(outputId.Value);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection.State == ConnectionState.Open)
                    cmd.Connection.Close();
            }

            return idTicketVenta;
        }
        public List<entTicketVenta> ListarTickeVenta(DateTime FechaInicio, DateTime FechaFin)
        {
            SqlCommand cmd = null;
            List<entTicketVenta> lista = new List<entTicketVenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarTicketVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaInicio", FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", FechaFin);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTicketVenta ticketVenta = new entTicketVenta();
                    ticketVenta.IdTicketVenta = Convert.ToInt32(dr["IdTicketVenta"]);
                    ticketVenta.FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]);
                    lista.Add(ticketVenta);
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

        #endregion Metodos
    }
}
