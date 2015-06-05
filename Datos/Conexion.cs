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
    
        static string connectionString = "";
        public Conexion()
        {
           
        }
        
        public static SqlConnection crearConexion()
        {
            string startupPath = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            startupPath = startupPath + @"\Datos\DBPrueba.mdf";
            connectionString = @"Data Source=(localDB)\v11.0;AttachDbFilename="+startupPath+";Initial Catalog=DBPrueba;Integrated Security=True";
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
