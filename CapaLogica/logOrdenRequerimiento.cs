using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logOrdenRequerimiento

    {
        // Patrón singleton
        private static readonly logOrdenRequerimiento _instancia = new logOrdenRequerimiento();
        public static logOrdenRequerimiento Instancia
        {
            get
            {
                return _instancia;
            }
        }

        // Método para listar órdenes
        public List<entOrdenRequerimiento> ListarOrdenRequerimiento()
        {
            return datOrdenRequerimiento.Instancia.ListarOrdenRequerimiento();
        }

        // Método para insertar una orden
        public bool InsertarOrdenRequerimiento(entOrdenRequerimiento orden, List<entOrdenRequerimientoDetalle> detalles)
        {
            SqlConnection cn = null;
            SqlTransaction transaction = null;

            try
            {
                cn = Conexion.Instancia.Conectar();
                cn.Open();
                transaction = cn.BeginTransaction();

                // Insert main order and get its ID
                int idOrden = datOrdenRequerimiento.Instancia.InsertarOrdenRequerimiento(orden, cn, transaction);

                // Insert each detail with the order ID
                foreach (var detalle in detalles)
                {
                    detalle.IdOrdenRequerimiento = idOrden;
                    datOrdenRequerimientoDetalle.Instancia.InsertarOrdenRequerimientoDetalle(detalle, cn, transaction);
                }

                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                // Log the full exception details
                System.Diagnostics.Debug.WriteLine($"Insertion Error: {ex.Message}\n{ex.StackTrace}");
                return false;
            }
            finally
            {
                cn?.Close();
            }
        }
    }
}
