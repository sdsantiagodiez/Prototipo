using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Datos
{
    public class Conexion
    {
        static string connectionString = "Data Source=; Persist Security Info=True;";
        

        public static SqlConnection crearConexion()
        {
            SqlConnection Conexion;
            try
            {
                Conexion = new SqlConnection(connectionString);
                return Conexion;

            }
            finally
            {
                Conexion = null;
            }

        }




    }
}
