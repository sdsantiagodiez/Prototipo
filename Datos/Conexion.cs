using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;
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
            //startupPath = rutaBD();
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

        public static SqlCommand crearComando()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.crearConexion();
            comando.CommandType = System.Data.CommandType.Text;
            return comando;
        }
        public static string rutaBD()
        {
            string path = "";
            try
            {
                StreamReader file = new StreamReader(@"c:\Archivos de Programa\SDG v1.0\Datos\pathBD.txt");
                path = file.ReadLine();
                file.Close();
            }
            catch (Exception ex)
            {
                return "No se pudo encontrar la base de datos." + ex.Message;
            }
            finally
            {
                path = "";
            }
            return path;
        }

        public static SqlCommand crearComando(string p_query)
        {
            SqlCommand comando = Conexion.crearComando();
            comando.CommandText = p_query;
            return comando;
        }

        public static bool backUpDatabase()
        {
            bool resp = false;
                        
            string endPath = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            endPath = endPath + @"\Datos\DBPrueba-" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour +
            DateTime.Now.Minute + DateTime.Now.Second + ".bak";
            SqlConnection ConexionSQL = Conexion.crearConexion();
            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "backup database [DBPrueba] to disk='" + endPath +
                "' ";//with init, stats=10 ";
            comando.Connection.Open();
            if (comando.ExecuteNonQuery() == -1)
            { resp = true; }
            
            comando.Connection.Close();
            ConexionSQL.Dispose();

            return resp;
        }
    }
}
