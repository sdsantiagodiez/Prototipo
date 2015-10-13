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
                "SELECT [mails_entidad.mail] " +
                    "FROM [mails_entidad] " +
                    "WHERE mails_entidad.codigo_entidad = @codigo_entidad";

            comando.Parameters.Add(new SqlParameter("@codigo_entidad", SqlDbType.Int));
            comando.Parameters["@codigo_entidad"].Value = codigoEntidad;

            comando.Connection.Open();

            SqlDataReader drMails = comando.ExecuteReader();

            ModeloMail modMail = new ModeloMail();

            while (drMails.Read())
            {
                modMail.mail = (string)drMails["mail"];
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
        public bool agregarMails(ModeloMail pmMail, int pCodigoEntidad)
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
        #endregion
    }
}
