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

        #region ALTA/BAJA/MODIFICACIÓN entidades
        /*
         * True si se realizó correctamente
         * False si ocurrió algún error
         */
        public bool agregarNuevaEntidad(ModeloPersonas pmPersona)
        {
            ModeloEntidad mEntidad = new ModeloEntidad();
            mEntidad.cuit = pmPersona.cuit;
            mEntidad.tipoEntidad = pmPersona.tipoEntidad;
            mEntidad.observaciones = pmPersona.observaciones;
            
            mEntidad.mails = pmPersona.mails;
            mEntidad.telefonos = pmPersona.telefonos;
            mEntidad.domicilios = pmPersona.domicilios;

            return (this.agregarNuevaEntidad(mEntidad));
        }
        public bool agregarNuevaEntidad(ModeloProveedor pmProveedor)
        {
            ModeloEntidad mEntidad = new ModeloEntidad();
            mEntidad.cuit = pmProveedor.cuit;
            mEntidad.tipoEntidad = pmProveedor.tipoEntidad;
            mEntidad.observaciones = pmProveedor.observaciones;
            
            mEntidad.mails = pmProveedor.mails;
            mEntidad.telefonos = pmProveedor.telefonos;
            mEntidad.domicilios = pmProveedor.domicilios;
            
            return (this.agregarNuevaEntidad(mEntidad));
        }

        public bool agregarNuevaEntidad(ModeloEntidad pmEntidad)
        {
            //Aseguramos que no se haya ingresado algún codigo a la entidad
            pmEntidad.codigo = 0;
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "INSERT INTO [entidades] ([tipo_entidad],[cuit],[observaciones] "+
                "VALUES (@tipo_entidad, @cuit, @observaciones)";
            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro(pmEntidad.tipoEntidad, "@tipo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(pmEntidad.cuit, "@cuit"));
            comando.Parameters.Add(this.instanciarParametro(pmEntidad.observaciones, "@observaciones"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            {
                pmEntidad.codigo = this.getUltimoCodigo();

                CatalogoMails cm = new CatalogoMails();
                List<ModeloMail> listaMails = pmEntidad.mails;
                foreach (ModeloMail m in listaMails)
                {
                    cm.agregarMails(m,pmEntidad.codigo);
                }

                CatalogoTelefonos ct = new CatalogoTelefonos();
                List<ModeloTelefono> listaTelefonos = pmEntidad.telefonos;
                foreach(ModeloTelefono t in listaTelefonos)
                {
                    ct.agregarTelefonos(t,pmEntidad.codigo);
                }

                CatalogoDomicilios cd = new CatalogoDomicilios();
                List<ModeloDomicilio> listaDomicilios = pmEntidad.domicilios;
                foreach(ModeloDomicilio d in listaDomicilios)
                {
                    cd.agregarDomicilios(d,pmEntidad.codigo);
                }
                
               return true;
            }
            else
            {
                return false;
            }
        }
        
        #endregion
        /// <summary>
        /// Obtiene el último código de entidad generado en la base de datos
        /// </summary>
        /// <returns>ultimo codigo generado; 0 si hubo algún error</returns>
        public int getUltimoCodigo()
        {
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "select IDENT_CURRENT('entidades') as codigo";
            comando.Connection.Open();

            SqlDataReader drEntidades = comando.ExecuteReader();

            int ultimoCodigoGenerado = 0;

            while (drEntidades.Read())
            {
                ultimoCodigoGenerado = (int)drEntidades["codigo"];
            }
            drEntidades.Close();
            comando.Connection.Close();

            return ultimoCodigoGenerado;
        }

        public List<ModeloMail> getMails(int codigoEntidad)
        {
            
            CatalogoMails cm = new CatalogoMails();
            return cm.getMails(codigoEntidad);
        }

        public List<ModeloDomicilio> getDomicilios(int codigoEntidad)
        {
            CatalogoDomicilios cd = new CatalogoDomicilios();
            return cd.getDomicilios(codigoEntidad);
        }
       
        public List<ModeloTelefono> getTelefonos(int codigoEntidad)
        {
            CatalogoTelefonos ct = new CatalogoTelefonos();
            return ct.getTelefonos(codigoEntidad);
        }

    }
}
