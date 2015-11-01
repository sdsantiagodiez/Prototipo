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

        public ModeloEntidad getValoresEntidad(ModeloEntidad pmEntidad)
        {
            ModeloEntidad mEntidad = new ModeloEntidad();
            mEntidad.codigo = pmEntidad.codigo;
            mEntidad.cuit = pmEntidad.cuit;
            mEntidad.tipoEntidad = pmEntidad.tipoEntidad;
            mEntidad.observaciones = pmEntidad.observaciones;

            mEntidad.mails = pmEntidad.mails;
            mEntidad.telefonos = pmEntidad.telefonos;
            mEntidad.domicilios = pmEntidad.domicilios;

            return mEntidad;
        }
       
        #region ALTA/BAJA/MODIFICACIÓN entidades
        /*
         * True si se realizó correctamente
         * False si ocurrió algún error
         */
        /// <summary>
        /// Agrega persona a base de datos entidades con sus respectivos atributos
        /// </summary>
        /// <param name="pmPersona"></param>
        /// <returns></returns>
        virtual public bool agregarNuevaEntidad(ModeloPersonas pmPersona)
        {
            ModeloEntidad mEntidad = this.getValoresEntidad(pmPersona);
            mEntidad.tipoEntidad = "PER";
            return (this.agregarNuevaEntidad(mEntidad));
        }
        /// <summary>
        /// Agrega proveedor a base de datos entidades con sus respectivos atributos
        /// </summary>
        /// <param name="pmProveedor"></param>
        /// <returns></returns>
        virtual public bool agregarNuevaEntidad(ModeloProveedor pmProveedor)
        {
            ModeloEntidad mEntidad = this.getValoresEntidad(pmProveedor);
            mEntidad.tipoEntidad = "PRO";
            return (this.agregarNuevaEntidad(mEntidad));
        }
        
        /// <summary>
        /// Agrega entidad propiamente dicha a base de datos
        /// </summary>
        /// <param name="pmEntidad"></param>
        /// <returns></returns>
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
                "INSERT INTO [entidades] ([tipo_entidad],[cuit],[observaciones]) "+
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

                List<ModeloMail> listaMails = pmEntidad.mails;
                foreach (ModeloMail m in listaMails)
                {
                    this.agregarNuevoMail(m,pmEntidad.codigo);
                }

                List<ModeloTelefono> listaTelefonos = pmEntidad.telefonos;
                foreach(ModeloTelefono t in listaTelefonos)
                {
                    this.agregarNuevoTelefono(t,pmEntidad.codigo);
                }

                List<ModeloDomicilio> listaDomicilios = pmEntidad.domicilios;
                foreach(ModeloDomicilio d in listaDomicilios)
                {
                    this.agregarNuevoDomicilio(d,pmEntidad.codigo);
                }
                
               return true;
            }
            else
            {
                return false;
            }
        }


        #region ABM MAILS
        public bool agregarNuevoMail(ModeloMail pmMail, int pcodigoEntidad)
        {
            CatalogoMails cm = new CatalogoMails();
            return cm.agregarNuevaEntidad(pmMail, pcodigoEntidad);
        }
        public bool bajaMail(ModeloMail pmMail)
        {
            CatalogoMails cm = new CatalogoMails();
            return cm.bajaEntidad(pmMail);
        }
        public bool actualizarMail(ModeloMail pmMail)
        {
            CatalogoMails cm = new CatalogoMails();
            return cm.actualizarEntidad(pmMail);
        }
        #endregion
        #region ABM DOMICILIOS
        public bool agregarNuevoDomicilio(ModeloDomicilio pmDomicilio, int pcodigoEntidad)
        {
            CatalogoDomicilios cd = new CatalogoDomicilios();
            return cd.agregarNuevaEntidad(pmDomicilio, pcodigoEntidad);
        }
        public bool bajaDomicilio(ModeloDomicilio pmDomicilio)
        {
            CatalogoDomicilios cd = new CatalogoDomicilios();
            return cd.bajaEntidad(pmDomicilio);
        }
        public bool actualizarDomicilio(ModeloDomicilio pmDomicilio)
        {
            CatalogoDomicilios cd = new CatalogoDomicilios();
            return cd.actualizarEntidad(pmDomicilio);
        }
        #endregion
        #region ABM TELEFONOS
        public bool agregarNuevoTelefono(ModeloTelefono pmTelefono, int pcodigoEntidad)
        {
            CatalogoTelefonos ct = new CatalogoTelefonos();
            return ct.agregarNuevaEntidad(pmTelefono, pcodigoEntidad);
        }
        
        public bool bajaTelefono(ModeloTelefono pmTelefono)
        {
            CatalogoTelefonos ct = new CatalogoTelefonos();
            return ct.bajaEntidad(pmTelefono);
        }
        public bool actualizarTelefono(ModeloTelefono pmTelefono)
        {
            CatalogoTelefonos ct = new CatalogoTelefonos();
            return ct.actualizarEntidad(pmTelefono);
        }

        #endregion
        
        
        virtual public bool actualizarEntidad(ModeloPersonas pmPersona)
        {
            return actualizarEntidad(this.getValoresEntidad(pmPersona));
        }
        virtual public bool actualizarEntidad(ModeloProveedor pmProveedor)
        {
            return actualizarEntidad(this.getValoresEntidad(pmProveedor));
        }

        public bool actualizarEntidad(ModeloEntidad pmEntidad)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "UPDATE [entidades] SET [cuit]=@cuit, [observaciones]=@observaciones,[tipo_entidad]=@tipo_entidad " +
                "WHERE [entidades].codigo=@codigo_entidad";

            comando.Parameters.Add(this.instanciarParametro(pmEntidad.codigo, "@codigo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(pmEntidad.cuit, "@cuit"));
            comando.Parameters.Add(this.instanciarParametro(pmEntidad.observaciones, "@observaciones"));
            comando.Parameters.Add(this.instanciarParametro(pmEntidad.tipoEntidad, "@tipo_entidad"));
            
            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();
            
            List<ModeloMail> listaMails = pmEntidad.mails;
            foreach (ModeloMail m in listaMails)
            {
                this.actualizarMail(m);
            }

            List<ModeloTelefono> listaTelefonos = pmEntidad.telefonos;
            foreach (ModeloTelefono t in listaTelefonos)
            {
                this.actualizarTelefono(t);
            }

            List<ModeloDomicilio> listaDomicilios = pmEntidad.domicilios;
            foreach (ModeloDomicilio d in listaDomicilios)
            {
                this.actualizarDomicilio(d);
            }

            if (rowaffected != 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        
        public bool bajaEntidad(int pCodigoEntidad)
        {
            //INCOMPLETO
            return true;
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
                "select IDENT_CURRENT('entidades') as codigo ";
            comando.Connection.Open();

            int ultimoCodigoGenerado = Convert.ToInt32(comando.ExecuteScalar());


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
