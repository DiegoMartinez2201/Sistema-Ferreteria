using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logCliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logCliente _instancia = new logCliente();
        //privado para evitar la instanciación directa
        public static logCliente Instancia
        {
            get
            {
                return logCliente._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //listado
        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }
        
        //inserta
        public void InsertaCliente(entCliente Cli) 
        {
            datCliente.Instancia.InsertarCliente(Cli);
        }
        //edita
        public void EditaCliente(entCliente Cli)
        {
            datCliente.Instancia.EditarCliente(Cli);
        }
        
        #endregion metodos
    }
}
