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
        static string dbNombre = "DBPrueba";
        static string connectionString = "";
        public Conexion()
        {
           
        }
        
        public static SqlConnection crearConexion()
        {
            string startupPath = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            startupPath = startupPath + @"\Datos\DBPrueba.mdf";
            //startupPath = rutaBD();
            //connectionString = @"Data Source=(localDB)\v11.0;AttachDbFilename="+startupPath+";Initial Catalog="+dbNombre+";Integrated Security=True";
            connectionString = Properties.Settings.Default.DBPruebaConnectionString;
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

        public static bool backUpDatabase(string p_direccionCarpeta)
        {
            bool resp = false;
            string p_direccionArchivo = p_direccionCarpeta + @"\DBPrueba-" +
                        //pad left para que los números de un digito aparezcan con 2 (7 -> 07) y no generen confusión
                        DateTime.Now.Year + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0') + 
                        DateTime.Now.Hour.ToString().PadLeft(2, '0') + DateTime.Now.Minute.ToString().PadLeft(2, '0') + DateTime.Now.Second.ToString().PadLeft(2, '0') + 
                        ".bak";
            SqlConnection ConexionSQL = Conexion.crearConexion();
            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "backup database [DBPrueba] to disk='" + p_direccionArchivo +
                "' ";//with init, stats=10 ";
            comando.Connection.Open();
            if (comando.ExecuteNonQuery() == -1)
            { resp = true; }
            
            comando.Connection.Close();
            ConexionSQL.Dispose();

            return resp;
        }

        public static bool restoreDatabase(string p_direccionArcivo)
        {
            //string query =
            //"use master; RESTORE DATABASE "+dbNombre+" FROM DISK = '"+p_direccionArcivo+"'";

            //SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());

            //comando.Connection.Open();
            ////Si falla, tira exception
            //comando.ExecuteNonQuery();
            
            //comando.Connection.Close();


            SqlConnection con = Conexion.crearConexion();
            string database = con.Database.ToString();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            try
            {
                string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand bu2 = new SqlCommand(sqlStmt2, con);
                bu2.ExecuteNonQuery();

                string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + p_direccionArcivo + "'WITH REPLACE;";
                SqlCommand bu3 = new SqlCommand(sqlStmt3, con);
                bu3.ExecuteNonQuery();

                string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand bu4 = new SqlCommand(sqlStmt4, con);
                bu4.ExecuteNonQuery();

                
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
