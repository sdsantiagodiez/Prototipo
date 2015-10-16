using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class CatalogoMails : Catalogo
    {
        private ModeloMail leerDatosMail(SqlDataReader drMails)
        {
            ModeloMail modMail = new ModeloMail();

            modMail.codigoMail = (int)drMails["codigo_mail"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            modMail.mail = (drMails["mail"] != DBNull.Value) ? (string)drMails["mail"] : null;

            return modMail;
        }

        public List<ModeloMail> getMails(int codigoEntidad)
        {
            List<ModeloMail> mails = new List<ModeloMail>();

            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT [codigo_mail], [mail] " +
                    "FROM [mails_entidad] " +
                    "WHERE mails_entidad.codigo_entidad = @codigo_entidad";

            comando.Parameters.Add(new SqlParameter("@codigo_entidad", SqlDbType.Int));
            comando.Parameters["@codigo_entidad"].Value = codigoEntidad;

            comando.Connection.Open();

            SqlDataReader drMails = comando.ExecuteReader();

            ModeloMail modMail = new ModeloMail();

            while (drMails.Read())
            {
                modMail = new ModeloMail();
                modMail = this.leerDatosMail(drMails);
                mails.Add(modMail);
            }
            drMails.Close();

            comando.Connection.Close();

            return mails;
        }
       
        #region ALTA/BAJA/MODIFICACIÓN mails
        /*
         * True si se realizó correctamente
         * False si ocurrió algún error
         */
        public bool agregarNuevaEntidad(ModeloMail pmMail, int pCodigoEntidad)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "INSERT INTO [mails_entidad] ([codigo_entidad],[mail]) " +
                "VALUES (@codigo_entidad, @mail)";
            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro(pCodigoEntidad, "@codigo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(pmMail.mail, "@mail"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool actualizarEntidad(ModeloMail pmMail)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "UPDATE [mails_entidad] SET [mail]=@mail "+
                "WHERE [codigo_mail]=@codigo_mail";

            comando.Parameters.Add(this.instanciarParametro(pmMail.codigoMail, "@codigo_mail"));
            comando.Parameters.Add(this.instanciarParametro(pmMail.mail, "@mail"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool bajaEntidad(ModeloMail pModMail)
        {
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "DELETE FROM [mails_entidad] " +
                    "WHERE [mails_entidad].codigo_mail=@codigo_mail";

            comando.Parameters.Add(this.instanciarParametro(pModMail.codigoMail, "@codigo_mail"));
            comando.Parameters.Add(this.instanciarParametro(pModMail.mail, "@mail"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
