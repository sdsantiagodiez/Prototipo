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
            ModeloMail lcl_mod_mail = new ModeloMail();

            lcl_mod_mail.codigoMail = (int)drMails["codigo_mail"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            lcl_mod_mail.mail = (drMails["mail"] != DBNull.Value) ? (string)drMails["mail"] : null;

            return lcl_mod_mail;
        }

        public List<ModeloMail> getMails(int codigoEntidad)
        {
            List<ModeloMail> lcl_lst_mod_mails = new List<ModeloMail>();
            
            SqlConnection ConexionSQL = Conexion.crearConexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT [codigo_mail], [mail] " +
                "   FROM [mails_entidad] " +
                "   WHERE mails_entidad.codigo_entidad = @codigo_entidad";

            comando.Parameters.Add(new SqlParameter("@codigo_entidad", SqlDbType.Int));
            comando.Parameters["@codigo_entidad"].Value = codigoEntidad;

            comando.Connection.Open();

            SqlDataReader drMails = comando.ExecuteReader();
            ModeloMail lcl_mod_mail = new ModeloMail();
            while (drMails.Read())
            {
                lcl_mod_mail = new ModeloMail();
                lcl_mod_mail = this.leerDatosMail(drMails);
                lcl_lst_mod_mails.Add(lcl_mod_mail);
            }
            drMails.Close();
            comando.Connection.Close();

            return lcl_lst_mod_mails;
        }
       
        #region Alta/Baja/Modificación
        public bool add(ModeloMail p_mod_mail, int codigoEntidad)
        {
            string query =
                "INSERT INTO [mails_entidad] ([codigo_entidad],[mail]) " +
                "   VALUES (@codigo_entidad, @mail)";

            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());
            
            comando.Parameters.Add(this.instanciarParametro(codigoEntidad, "@codigo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_mail.mail, "@mail"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            { return true; }
            else
            { return false; }
        }

        public bool update(ModeloMail p_mod_mail)
        {
            string query =
                "UPDATE [mails_entidad] SET [mail]=@mail " +
                "   WHERE [codigo_mail]=@codigo_mail";

            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());

            comando.Parameters.Add(this.instanciarParametro(p_mod_mail.codigoMail, "@codigo_mail"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_mail.mail, "@mail"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            { return true; }
            else
            { return false; }
        }

        public bool remove(ModeloMail p_mod_mail)
        {
            string query =
                "DELETE FROM [mails_entidad] " +
                "   WHERE [mails_entidad].codigo_mail=@codigo_mail";

            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());
               
            comando.Parameters.Add(this.instanciarParametro(p_mod_mail.codigoMail, "@codigo_mail"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_mail.mail, "@mail"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            { return true; }
            else
            { return false; }
        }
        #endregion
    }
}
