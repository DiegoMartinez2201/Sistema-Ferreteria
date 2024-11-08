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
        #region singleton
        //Patron singleton 
        //variable estatica para la instancia
        private static readonly logCategoria _instancia = new logCategoria();
        //privado para evitar la instanciacion directa
        public static logCategoria Instancia
        {
            get 
            { 
                return logCategoria._instancia;
            }
        }
        #endregion singleton
        //listado
        public List<entCategoria> ListarCategoria()
        {
            return datCategoria.Instancia.ListarCategoria();
        }
        public void InsertarCategoria(entCategoria categoria)
        {
            datCategoria.Instancia.InsertarCategoria(categoria);
        }
        public void EditarCategoria(entCategoria categoria)
        {
            datCategoria.Instancia.EditarCategoria(categoria);  
        }
        public void DeshabilitarCategoria(entCategoria categoria)
        {
            datCategoria.Instancia.DeshabilitarCategoria(categoria);
        }

    }
}
