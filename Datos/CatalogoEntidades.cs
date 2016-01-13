using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data;
using System.Data.SqlClient;
using LibreriaClasesCompartidas;

namespace Datos
{
    public class CatalogoEntidades : Catalogo
    {
        private ModeloEntidad leerDatosEntidades(SqlDataReader p_drEntidades)
        {
            ModeloEntidad lcl_mod_entidad = new ModeloEntidad();

            lcl_mod_entidad.codigo = (int)p_drEntidades["codigo"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            lcl_mod_entidad.cuit = (p_drEntidades["cuit"] != DBNull.Value) ? (string)p_drEntidades["cuit"] : null;
            lcl_mod_entidad.tipoEntidad = (p_drEntidades["tipo_entidad"] != DBNull.Value) ? (string)p_drEntidades["tipo_entidad"] : null;
            lcl_mod_entidad.observaciones = (p_drEntidades["observaciones"] != DBNull.Value) ? (string)p_drEntidades["observaciones"] : null;
            
            return lcl_mod_entidad;
        }

        public ModeloEntidad getOne(int p_codigoEntidad)
        {
            ModeloEntidad lcl_mod_entidad = null;
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
            comando.Parameters["@codigo"].Value = p_codigoEntidad;
            comando.Connection.Open();

            SqlDataReader drEntidades = comando.ExecuteReader();

            while (drEntidades.Read())
            {
                lcl_mod_entidad = new ModeloEntidad();
                lcl_mod_entidad = this.leerDatosEntidades(drEntidades);
            }
            drEntidades.Close();
            comando.Connection.Close();

            lcl_mod_entidad.mails = this.getMails(p_codigoEntidad);
            lcl_mod_entidad.telefonos = this.getTelefonos(p_codigoEntidad);
            lcl_mod_entidad.domicilios = this.getDomicilios(p_codigoEntidad);

            return lcl_mod_entidad;
        }

        public List<ModeloEntidad> getAll()
        {
            List<ModeloEntidad> lcl_lst_mod_entidades = new List<ModeloEntidad>();
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
            ModeloEntidad lcl_mod_entidad;
            SqlDataReader drPersonas = comando.ExecuteReader();
            while (drPersonas.Read())
            {
                lcl_mod_entidad = new ModeloEntidad();
                lcl_mod_entidad = this.leerDatosEntidades(drPersonas);

                lcl_mod_entidad.mails = this.getMails(lcl_mod_entidad.codigo);
                lcl_mod_entidad.telefonos = this.getTelefonos(lcl_mod_entidad.codigo);
                lcl_mod_entidad.domicilios = this.getDomicilios(lcl_mod_entidad.codigo);

                lcl_lst_mod_entidades.Add(lcl_mod_entidad);
            }
            drPersonas.Close();

            comando.Connection.Close();

            return lcl_lst_mod_entidades;
        }

        public ModeloEntidad getValoresEntidad(ModeloEntidad p_mod_entidad)
        {
            ModeloEntidad lcl_mod_entidad = new ModeloEntidad();
            lcl_mod_entidad.codigo = p_mod_entidad.codigo;
            lcl_mod_entidad.cuit = p_mod_entidad.cuit;
            lcl_mod_entidad.tipoEntidad = p_mod_entidad.tipoEntidad;
            lcl_mod_entidad.observaciones = p_mod_entidad.observaciones;

            lcl_mod_entidad.mails = p_mod_entidad.mails;
            lcl_mod_entidad.telefonos = p_mod_entidad.telefonos;
            lcl_mod_entidad.domicilios = p_mod_entidad.domicilios;

            return lcl_mod_entidad;
        }
       
        #region ALTA/BAJA/MODIFICACIÓN entidades
        /*
         * True si se realizó correctamente
         * False si ocurrió algún error
         */
        /// <summary>
        /// Agrega persona a base de datos entidades con sus respectivos atributos
        /// </summary>
        /// <param name="p_mod_persona"></param>
        /// <returns></returns>
        virtual public bool agregarNuevaEntidad(ModeloPersonas p_mod_persona)
        {
            ModeloEntidad lcl_mod_entidad = this.getValoresEntidad(p_mod_persona);
            lcl_mod_entidad.tipoEntidad = Constantes.TiposEntidad.Persona;
            return (this.agregarNuevaEntidad(lcl_mod_entidad));
        }
        /// <summary>
        /// Agrega proveedor a base de datos entidades con sus respectivos atributos
        /// </summary>
        /// <param name="pmProveedor"></param>
        /// <returns></returns>
        virtual public bool agregarNuevaEntidad(ModeloProveedor p_mod_proveedor)
        {
            ModeloEntidad lcl_mod_entidad = this.getValoresEntidad(p_mod_proveedor);
            lcl_mod_entidad.tipoEntidad = Constantes.TiposEntidad.Proveedor;
            return (this.agregarNuevaEntidad(lcl_mod_entidad));
        }
        
        /// <summary>
        /// Agrega entidad propiamente dicha a base de datos
        /// </summary>
        /// <param name="pmEntidad"></param>
        /// <returns></returns>
        public bool agregarNuevaEntidad(ModeloEntidad p_mod_entidad)
        {
            //Aseguramos que no se haya ingresado algún codigo a la entidad
            p_mod_entidad.codigo = 0;
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
            comando.Parameters.Add(this.instanciarParametro(p_mod_entidad.tipoEntidad, "@tipo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_entidad.cuit, "@cuit"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_entidad.observaciones, "@observaciones"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            {
                p_mod_entidad.codigo = this.getUltimoCodigo();

                List<ModeloMail> lcl_lst_mails = p_mod_entidad.mails;
                foreach (ModeloMail m in lcl_lst_mails)
                {
                    this.agregarNuevoMail(m, p_mod_entidad.codigo);
                }

                List<ModeloTelefono> lcl_lst_telefonos = p_mod_entidad.telefonos;
                foreach(ModeloTelefono t in lcl_lst_telefonos)
                {
                    this.agregarNuevoTelefono(t, p_mod_entidad.codigo);
                }

                List<ModeloDomicilio> lcl_lst_domicilios = p_mod_entidad.domicilios;
                foreach(ModeloDomicilio d in lcl_lst_domicilios)
                {
                    this.agregarNuevoDomicilio(d, p_mod_entidad.codigo);
                }
                
               return true;
            }
            else
            {
                return false;
            }
        }


        #region ABM MAILS
        public bool agregarNuevoMail(ModeloMail p_mod_mail, int p_codigoEntidad)
        {
            CatalogoMails lcl_cat_mails = new CatalogoMails();
            return lcl_cat_mails.agregarNuevaEntidad(p_mod_mail, p_codigoEntidad);
        }
        public bool bajaMail(ModeloMail p_mod_mail)
        {
            CatalogoMails lcl_cat_mails = new CatalogoMails();
            return lcl_cat_mails.bajaEntidad(p_mod_mail);
        }
        public bool actualizarMail(ModeloMail p_mod_mail)
        {
            CatalogoMails lcl_cat_mails = new CatalogoMails();
            return lcl_cat_mails.actualizarEntidad(p_mod_mail);
        }
        #endregion
        #region ABM DOMICILIOS
        public bool agregarNuevoDomicilio(ModeloDomicilio p_mod_domicilio, int p_codigoEntidad)
        {
            CatalogoDomicilios lcl_cat_domicilios = new CatalogoDomicilios();
            return lcl_cat_domicilios.agregarNuevaEntidad(p_mod_domicilio, p_codigoEntidad);
        }
        public bool bajaDomicilio(ModeloDomicilio p_mod_domicilio)
        {
            CatalogoDomicilios lcl_cat_domicilios = new CatalogoDomicilios();
            return lcl_cat_domicilios.bajaEntidad(p_mod_domicilio);
        }
        public bool actualizarDomicilio(ModeloDomicilio p_mod_domicilio)
        {
            CatalogoDomicilios lcl_cat_domicilios = new CatalogoDomicilios();
            return lcl_cat_domicilios.actualizarEntidad(p_mod_domicilio);
        }
        #endregion
        #region ABM TELEFONOS
        public bool agregarNuevoTelefono(ModeloTelefono p_mod_telefono, int p_codigoEntidad)
        {
            CatalogoTelefonos lcl_cat_telefonos = new CatalogoTelefonos();
            return lcl_cat_telefonos.agregarNuevaEntidad(p_mod_telefono, p_codigoEntidad);
        }

        public bool bajaTelefono(ModeloTelefono p_mod_telefono)
        {
            CatalogoTelefonos lcl_cat_telefonos = new CatalogoTelefonos();
            return lcl_cat_telefonos.bajaEntidad(p_mod_telefono);
        }
        public bool actualizarTelefono(ModeloTelefono p_mod_telefono)
        {
            CatalogoTelefonos lcl_cat_telefonos = new CatalogoTelefonos();
            return lcl_cat_telefonos.actualizarEntidad(p_mod_telefono);
        }

        #endregion
        
        
        virtual public bool actualizarEntidad(ModeloPersonas p_mod_persona)
        {
            return actualizarEntidad(this.getValoresEntidad(p_mod_persona));
        }
        virtual public bool actualizarEntidad(ModeloProveedor p_mod_proveedor)
        {
            return actualizarEntidad(this.getValoresEntidad(p_mod_proveedor));
        }

        public bool actualizarEntidad(ModeloEntidad p_mod_entidad)
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

            comando.Parameters.Add(this.instanciarParametro(p_mod_entidad.codigo, "@codigo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_entidad.cuit, "@cuit"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_entidad.observaciones, "@observaciones"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_entidad.tipoEntidad, "@tipo_entidad"));
            
            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            List<ModeloMail> lcl_lst_mod_mails = p_mod_entidad.mails;
            foreach (ModeloMail m in lcl_lst_mod_mails)
            {
                this.actualizarMail(m);
            }

            List<ModeloTelefono> lcl_lst_mod_telefonos = p_mod_entidad.telefonos;
            foreach (ModeloTelefono t in lcl_lst_mod_telefonos)
            {
                this.actualizarTelefono(t);
            }

            List<ModeloDomicilio> lcl_lst_mod_domicilios = p_mod_entidad.domicilios;
            foreach (ModeloDomicilio d in lcl_lst_mod_domicilios)
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
        
        public bool bajaEntidad(int p_codigoEntidad)
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

        public List<ModeloMail> getMails(int p_codigoEntidad)
        {
            
            CatalogoMails lcl_cat_mails = new CatalogoMails();
            return lcl_cat_mails.getMails(p_codigoEntidad);
        }

        public List<ModeloDomicilio> getDomicilios(int p_codigoEntidad)
        {
            CatalogoDomicilios lcl_cat_domicilios = new CatalogoDomicilios();
            return lcl_cat_domicilios.getDomicilios(p_codigoEntidad);
        }

        public List<ModeloTelefono> getTelefonos(int p_codigoEntidad)
        {
            CatalogoTelefonos lcl_cat_telefonos = new CatalogoTelefonos();
            return lcl_cat_telefonos.getTelefonos(p_codigoEntidad);
        }

    }
}
