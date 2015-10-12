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
    public class CatalogoEntidades : Catalogo
    {
        private ModeloEntidad leerDatosEntidades(SqlDataReader drEntidades)
        {
            ModeloEntidad mEntidad = new ModeloEntidad();

            mEntidad.codigo = (int)drEntidades["codigo"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            mEntidad.cuit = (drEntidades["cuit"] != DBNull.Value) ? (string)drEntidades["cuit"] : null;
            mEntidad.tipoEntidad = (drEntidades["tipo_entidad"] != DBNull.Value) ? (string)drEntidades["tipo_entidad"] : null;
            mEntidad.observaciones = (drEntidades["observaciones"] != DBNull.Value) ? (string)drEntidades["observaciones"] : null;
            
            return mEntidad;
        }

        public ModeloEntidad getOne(int codigoEntidad)
        {
            ModeloEntidad modEntidad = null;
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT [codigo],[tipo_entidad],[cuit],[observaciones] " +
                    "FROM [entidades]  " +
                    "WHERE [entidades].codigo = @codigo";
            comando.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int));
            comando.Parameters["@codigo"].Value = codigoEntidad;
            comando.Connection.Open();

            SqlDataReader drEntidades = comando.ExecuteReader();

            while (drEntidades.Read())
            {
                modEntidad = new ModeloEntidad();
                modEntidad = this.leerDatosEntidades(drEntidades);
            }
            drEntidades.Close();
            comando.Connection.Close();

            modEntidad.mails = this.getMails(codigoEntidad);
            modEntidad.telefonos = this.getTelefonos(codigoEntidad);
            modEntidad.domicilios = this.getDomicilios(codigoEntidad);

            return modEntidad;
        }

        public List<ModeloEntidad> getAll()
        {
            List<ModeloEntidad> entidades = new List<ModeloEntidad>();
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                   "SELECT [codigo],[tipo_entidad],[cuit],[observaciones] " +
                       "FROM [entidades]  ";

            comando.Connection.Open();
            ModeloEntidad modEntidad;
            SqlDataReader drPersonas = comando.ExecuteReader();
            while (drPersonas.Read())
            {
                modEntidad = new ModeloEntidad();
                modEntidad = this.leerDatosEntidades(drPersonas);

                modEntidad.mails = this.getMails(modEntidad.codigo);
                modEntidad.telefonos = this.getTelefonos(modEntidad.codigo);
                modEntidad.domicilios = this.getDomicilios(modEntidad.codigo);

                entidades.Add(modEntidad);
            }
            drPersonas.Close();

            comando.Connection.Close();

            return entidades;
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
                "SELECT [mails_entidad.mail] "+
                    "FROM [mails_entidad] "+
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

        public List<ModeloDomicilio> getDomicilios(int codigoEntidad)
        {
            List<ModeloDomicilio> domicilios = new List<ModeloDomicilio>();

            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT [domicilios_entidad.calle],[domicilios_entidad.numero],[domicilios_entidad.piso],[domicilios_entidad.departamento], " +
                "[domicilios_entidad.ciudad],[domicilios_entidad.codigo_postal],[provincias.provincia],[paises.pais]" +
                    "FROM [domicilios_entidad] " +
                    "INNER JOIN [provincias] on [provincias.codigo_provincia] = [domicilios_entidad.codigo_provincia]"+
                    "INNER JOIN [paises] on [paises.codigo] = [provincias.codigo_pais]"+
                    "WHERE ([domicilios_entidad.codigo_entidad] = @codigo_entidad)";

            comando.Parameters.Add(new SqlParameter("@codigo_entidad", SqlDbType.Int));
            comando.Parameters["@codigo_entidad"].Value = codigoEntidad;

            comando.Connection.Open();

            SqlDataReader drDomicilios = comando.ExecuteReader();

            ModeloDomicilio modDomicilio = new ModeloDomicilio();

            while (drDomicilios.Read())
            {
                modDomicilio.calle = (string)drDomicilios["calle"];
                modDomicilio.numero = (string)drDomicilios["numero"];
                modDomicilio.piso = (string)drDomicilios["piso"];
                modDomicilio.departamento = (string)drDomicilios["departamento"];
                modDomicilio.ciudad = (string)drDomicilios["ciudad"];
                modDomicilio.codigoPostal = (string)drDomicilios["codigo_postal"];
                modDomicilio.provincia = (string)drDomicilios["provincia"];
                modDomicilio.pais = (string)drDomicilios["pais"];
                domicilios.Add(modDomicilio);
            }
            drDomicilios.Close();

            comando.Connection.Close();

            return domicilios;
        }

        public List<ModeloTelefono> getTelefonos(int codigoEntidad)
        {
            List<ModeloTelefono> telefonos = new List<ModeloTelefono>();

            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText = 
                "SELECT [telefonos_entidad.tipo],[telefonos_entidad.numero] "+
                    "FROM [telefonos_entidad] " +
                    "WHERE ([telefonos_entidad.codigo_entidad] = @codigo_entidad)";

            comando.Parameters.Add(new SqlParameter("@codigo_entidad", SqlDbType.Int));
            comando.Parameters["@codigo_entidad"].Value = codigoEntidad;

            comando.Connection.Open();

            SqlDataReader drTelefonos = comando.ExecuteReader();

            ModeloTelefono modTelefono = new ModeloTelefono();

            while (drTelefonos.Read())
            {
                modTelefono.tipo = (string)drTelefonos["descripcion"];
                modTelefono.numero = (string)drTelefonos["descripcion"];
                telefonos.Add(modTelefono);
            }
            drTelefonos.Close();

            comando.Connection.Close();

            return telefonos;
        }

    }
}
