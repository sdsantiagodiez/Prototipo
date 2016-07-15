using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
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
            //startupPath = this.rutaBD();
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
        public string rutaBD()
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
    }
}
