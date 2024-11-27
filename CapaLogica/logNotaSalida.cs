using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logNotaSalida
    {
        #region sigleton
        private static readonly logNotaSalida _instancia = new logNotaSalida();
        public static logNotaSalida Instancia
        {
            get
            {
                return logNotaSalida._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public bool InsertarNotaSalida(entNotaSalida notaSalida, List<entNotaSalidaDetalle> detalles)
        {
            try
            {
                // Asignar los detalles a la nota de salida
                notaSalida.Detalle = detalles;

                // Registrar la Nota de Salida
                int idNotaSalida = datNotaSalida.Instancia.InsertarNotaSalida(notaSalida);

                if (idNotaSalida <= 0)
                    return false;

                // Registrar cada detalle
                foreach (var detalle in detalles)
                {
                    detalle.IdNotaSalida = idNotaSalida;
                    bool resultado = datNotaSalidaDetalle.Instancia.InsertarNotaSalidaDetalle(detalle);
                    if (!resultado)
                    {
                        // Si falla la inserción de un detalle, consideramos que toda la operación falló
                        return false;
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion metodos

    }
}
