using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logNotaEntrada
    {
        #region sigleton
        private static readonly logNotaEntrada _instancia = new logNotaEntrada();
        public static logNotaEntrada Instancia
        {
            get
            {
                return logNotaEntrada._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public bool InsertarNotaEntrada(entNotaEntrada notaEntrada, List<entNotaEntradaDetalle> detalles)
        {
            try
            {
                // Asignar los detalles a la nota de entrada
                notaEntrada.Detalle = detalles;

                // Registrar la Nota de Salida
                int idNotaEntrada = datNotaEntrada.Instancia.InsertarNotaEntrada(notaEntrada);

                if (idNotaEntrada <= 0)
                    return false;

                // Registrar cada detalle
                foreach (var detalle in detalles)
                {
                    detalle.IdNotaEntrada = idNotaEntrada;
                    bool resultado = datNotaEntradaDetalle.Instancia.InsertarNotaEntradaDetalle(detalle);
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
