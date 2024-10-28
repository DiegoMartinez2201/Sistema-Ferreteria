﻿using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logTipoCliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logTipoCliente _instancia = new logTipoCliente();
        //privado para evitar la instanciación directa
        public static logTipoCliente Instancia
        {
            get
            {
                return logTipoCliente._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //listado
        public List<entTipoCliente> ListarTipoCliente()
        {
            return datTipoCliente.Instancia.ListarTipoCliente();
        }
        #endregion metodos
    }
}