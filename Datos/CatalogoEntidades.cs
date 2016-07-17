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
        protected bool validarDatos(ModeloEntidad p_mod_entidad)
        {
            return true;
        }

        protected ModeloEntidad leerDatosEntidades(SqlDataReader p_drEntidades)
        {
            ModeloEntidad lcl_mod_entidad = new ModeloEntidad();

            lcl_mod_entidad.codigo = (int)p_drEntidades["codigo_entidad"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            lcl_mod_entidad.cuit = (p_drEntidades["cuit"] != DBNull.Value) ? (string)p_drEntidades["cuit"] : null;
            lcl_mod_entidad.tipoEntidad = (p_drEntidades["tipo_entidad"] != DBNull.Value) ? (string)p_drEntidades["tipo_entidad"] : null;
            lcl_mod_entidad.observaciones = (p_drEntidades["observaciones"] != DBNull.Value) ? (string)p_drEntidades["observaciones"] : null;

            lcl_mod_entidad.mails = this.getMails(lcl_mod_entidad.codigo);
            lcl_mod_entidad.telefonos = this.getTelefonos(lcl_mod_entidad.codigo);
            lcl_mod_entidad.domicilios = this.getDomicilios(lcl_mod_entidad.codigo);

            return lcl_mod_entidad;
        }

        #region Búsqueda

        /// <summary>
        /// Genera string a insertar en clausula WHERE de sql de acuerdo a los parámetros de búsqueda
        /// </summary>
        /// <param name="p_mod_entidad">modeloEntidad con variables posiblemente inicializadas</param>
        /// <param name="p_parametroBusqueda">constante encontrada en LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Proveedores</param>
        /// <param name="p_comando">comando sql que será modificado para incluir parámetros</param>
        /// <returns></returns>
        protected string getCondicionBusqueda(ModeloEntidad p_mod_entidad, string p_parametroBusqueda, ref SqlCommand p_comando)
        {
            switch (p_parametroBusqueda)
            {
                case Constantes.ParametrosBusqueda.One:
                case Constantes.ParametrosBusqueda.Entidades.CodigoEntidad:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_entidad.codigo, "@codigo_entidad"));
                    return " codigo_entidad = @codigo_entidad ";

                case Constantes.ParametrosBusqueda.Entidades.Cuit:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_entidad.cuit, "@cuit"));
                    return " cuit = @cuit ";

                case Constantes.ParametrosBusqueda.Any:
                    int? codigoEntidad = p_mod_entidad.codigo == 0 ? null : (int?)p_mod_entidad.codigo;
                    p_comando.Parameters.Add(this.instanciarParametro(codigoEntidad, "@codigo_entidad"));
                    string codigoEntidadQuery = @" (@codigo_entidad IS NULL OR @codigo_entidad = codigo_entidad) ";

                    string cuit = String.IsNullOrWhiteSpace(p_mod_entidad.cuit ) ? null : p_mod_entidad.cuit;
                    p_comando.Parameters.Add(this.instanciarParametro(cuit, "@cuit"));
                    string cuitQuery = " (@cuit is null OR cuit=@cuit) ";

                    return codigoEntidadQuery + " AND " + cuitQuery;

                default:
                    //retorna false y no devuelve filas
                    return base.getCondicionBusqueda(p_parametroBusqueda);
            }
        }

        public virtual IEnumerable<ModeloEntidad> buscar(ModeloEntidad p_mod_entidad, string p_parametroBusqueda)
        {
            return null;
        }

        public virtual ModeloEntidad getOne(int p_codigoEntidad)
        {
            ModeloEntidad lcl_mod_entidad = null;
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT [codigo] as codigo_entidad,[tipo_entidad],[cuit],[observaciones] " +
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

            return lcl_mod_entidad;
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

        public List<TipoDocumento> getTiposDocumentos()
        {
            SqlConnection ConexionSQL = Conexion.crearConexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "SELECT [Tipos_Documentos].codigo,[Tipos_Documentos].descripcion " +
                "   FROM [Tipos_Documentos] ";

            comando.Connection.Open();

            SqlDataReader drTiposDocumentos = comando.ExecuteReader();

            List<TipoDocumento> lcl_lst_tiposDocumentos = new List<TipoDocumento>();
            TipoDocumento lcl_tipoDocumento = new TipoDocumento();

            while (drTiposDocumentos.Read())
            {
                lcl_tipoDocumento = new TipoDocumento();
                lcl_tipoDocumento.codigo = (int)drTiposDocumentos["codigo"];
                lcl_tipoDocumento.descripcion = (string)drTiposDocumentos["descripcion"];

                lcl_lst_tiposDocumentos.Add(lcl_tipoDocumento);
            }
            drTiposDocumentos.Close();
            comando.Connection.Close();

            return lcl_lst_tiposDocumentos;
        }
        #endregion

        #region Alta/Baja/Modificación

        /// <summary>
        /// Agrega entidad propiamente dicha a base de datos
        /// </summary>
        /// <param name="p_mod_entidad"></param>
        /// <returns></returns>
        public virtual bool add(ref ModeloEntidad p_mod_entidad)
        {
            //Aseguramos que no se haya ingresado algún codigo a la entidad
            p_mod_entidad.codigo = 0;
            SqlConnection ConexionSQL = Conexion.crearConexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "INSERT INTO [entidades] ([tipo_entidad],[cuit],[observaciones]) " +
                "OUTPUT INSERTED.CODIGO " +
                "VALUES (@tipo_entidad, @cuit, @observaciones)";
            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro(p_mod_entidad.tipoEntidad, "@tipo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_entidad.cuit, "@cuit"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_entidad.observaciones, "@observaciones"));

            comando.Connection.Open();
            int? nuevoCodigoEntidad = (int?)comando.ExecuteScalar();

            comando.Connection.Close();

            if (nuevoCodigoEntidad != null)
            { 
                p_mod_entidad.codigo = Convert.ToInt32(nuevoCodigoEntidad);
                List<ModeloMail> lcl_lst_mails = p_mod_entidad.mails;
                foreach (ModeloMail m in lcl_lst_mails)
                {
                    this.agregarNuevoMail(m, Convert.ToInt32(p_mod_entidad.codigo));
                }

                List<ModeloTelefono> lcl_lst_telefonos = p_mod_entidad.telefonos;
                foreach (ModeloTelefono t in lcl_lst_telefonos)
                {
                    this.agregarNuevoTelefono(t, Convert.ToInt32(p_mod_entidad.codigo));
                }

                List<ModeloDomicilio> lcl_lst_domicilios = p_mod_entidad.domicilios;
                foreach (ModeloDomicilio d in lcl_lst_domicilios)
                {
                    this.agregarNuevoDomicilio(d, Convert.ToInt32(p_mod_entidad.codigo));
                }

                return true;
            }
            else
            {
                throw new Exception("Ha ocurrido un error en la base de datos. No se ha podido registrar entidad.");
            }
        }

        #region ABM Mails
        public bool agregarNuevoMail(ModeloMail p_mod_mail, int p_codigoEntidad)
        {
            CatalogoMails lcl_cat_mails = new CatalogoMails();
            if (lcl_cat_mails.add(p_mod_mail, p_codigoEntidad))
            {
                return true;
            }
            throw new Exception("Ha ocurrido un error en la base de datos. No se ha podido registrar entidad. Inconveniente con mail.");
            
        }
        public bool bajaMail(ModeloMail p_mod_mail)
        {
            CatalogoMails lcl_cat_mails = new CatalogoMails();
            return lcl_cat_mails.remove(p_mod_mail);
        }
        public bool actualizarMail(ModeloMail p_mod_mail)
        {
            CatalogoMails lcl_cat_mails = new CatalogoMails();
            return lcl_cat_mails.update(p_mod_mail);
        }
        #endregion
        #region ABM Domicilios
        public bool agregarNuevoDomicilio(ModeloDomicilio p_mod_domicilio, int p_codigoEntidad)
        {
            CatalogoDomicilios lcl_cat_domicilios = new CatalogoDomicilios();
            if(lcl_cat_domicilios.add(p_mod_domicilio, p_codigoEntidad))
            {
                return true;
            }
            throw new Exception("Ha ocurrido un error en la base de datos. No se ha podido registrar entidad. Inconveniente con domicilio.");
        }
        public bool bajaDomicilio(ModeloDomicilio p_mod_domicilio)
        {
            CatalogoDomicilios lcl_cat_domicilios = new CatalogoDomicilios();
            return lcl_cat_domicilios.remove(p_mod_domicilio);
        }
        public bool actualizarDomicilio(ModeloDomicilio p_mod_domicilio)
        {
            CatalogoDomicilios lcl_cat_domicilios = new CatalogoDomicilios();
            return lcl_cat_domicilios.update(p_mod_domicilio);
        }
        #endregion
        #region ABM Teléfonos
        public bool agregarNuevoTelefono(ModeloTelefono p_mod_telefono, int p_codigoEntidad)
        {
            CatalogoTelefonos lcl_cat_telefonos = new CatalogoTelefonos();
            if(lcl_cat_telefonos.add(p_mod_telefono, p_codigoEntidad))
            {
                return true;
            }
            throw new Exception("Ha ocurrido un error en la base de datos. No se ha podido registrar entidad. Inconveniente con telefono.");
        }

        public bool bajaTelefono(ModeloTelefono p_mod_telefono)
        {
            CatalogoTelefonos lcl_cat_telefonos = new CatalogoTelefonos();
            return lcl_cat_telefonos.remove(p_mod_telefono);
        }
        public bool actualizarTelefono(ModeloTelefono p_mod_telefono)
        {
            CatalogoTelefonos lcl_cat_telefonos = new CatalogoTelefonos();
            return lcl_cat_telefonos.update(p_mod_telefono);
        }

        #endregion

        protected bool updateEntidad(ModeloEntidad p_mod_entidad)
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

        protected bool estadoEntidad(ModeloEntidad p_mod_entidad, string p_activo)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "UPDATE [entidades] SET [activo]=@activo WHERE [entidades].codigo=@codigo_entidad";

            comando.Parameters.Add(this.instanciarParametro(p_mod_entidad.codigo, "@codigo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(p_activo, "@activo"));
            
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

        public virtual bool update(ModeloEntidad p_mod_entidad_original, ModeloEntidad p_mod_entidad_nueva)
        {
            if (!p_mod_entidad_original.Equals(p_mod_entidad_nueva))
            {
                return this.updateEntidad(p_mod_entidad_nueva);
            }
            
            return true;
        }

        public virtual bool update(ModeloEntidad p_mod_entidad_nueva)
        {
            ModeloEntidad lcl_mod_entidad_original = this.buscar(p_mod_entidad_nueva,Constantes.ParametrosBusqueda.Entidades.CodigoEntidad).ToList()[0];
            if (lcl_mod_entidad_original != null)
                return this.update(lcl_mod_entidad_original, p_mod_entidad_nueva);
            else
                return false;
        }

        public virtual bool remove(ModeloEntidad p_mod_entidad)
        {
            SqlConnection ConexionSQL = Conexion.crearConexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "DELETE FROM [entidades] "+
                "   WHERE [entidades].codigo=@codigo_entidad";

            comando.Parameters.Add(this.instanciarParametro(p_mod_entidad.codigo, "@codigo_entidad"));

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
