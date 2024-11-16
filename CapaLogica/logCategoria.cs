using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logCategoria
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logCategoria _instancia = new logCategoria();
        //privado para evitar la instanciación directa
        public static logCategoria Instancia
        {
            get
            {
                return logCategoria._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //listado
        public List<entCategoria> ListarCategoria()
        {
            return datCategoria.Instancia.ListarCategoria();
        }

        //inserta
        public void InsertaCategoria(entCategoria categoria)
        {
            datCategoria.Instancia.InsertarCategoria(categoria);
        }
        //edita
        public void EditaCategoria(entCategoria categoria)
        {
            datCategoria.Instancia.EditarCategoria(categoria);
        }
        //deshabilita
        public void DeshabilitarCategoria(entCategoria categoria)
        {
            datCategoria.Instancia.DeshabilitarCategoria(categoria);
        }

        #endregion metodos
    }
}
