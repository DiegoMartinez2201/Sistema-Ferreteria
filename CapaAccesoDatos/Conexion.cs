using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class Conexion
    {
        //patrón de Diseño Singleton
        private static readonly Conexion _instancia = new Conexion();

        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }

        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source= DESKTOP-HNG11PV\\SQLEXPRESS; Initial Catalog= DB_Ferreteria;" +// "User ID=sa; Password=123";
                                 "Integrated Security = true";
            return cn;
        }
    }
}
