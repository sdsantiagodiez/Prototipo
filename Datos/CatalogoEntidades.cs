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
            lcl_mod_entidad.activo = p_drEntidades.GetBoolean(p_drEntidades.GetOrdinal("activo"));
            lcl_mod_entidad.codigoTipoResponsable = (p_drEntidades["codigo_tipo_responsable"] != DBNull.Value) ? (int?)p_drEntidades["codigo_tipo_responsable"] : null;

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
                "SELECT [codigo] as codigo_entidad,[tipo_entidad],[cuit],[observaciones],[activo],[codigo_tipo_responsable] " +
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

            this.getDatosAdicionales(lcl_mod_entidad);

            return lcl_mod_entidad;
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

        protected void getDatosAdicionales(ModeloEntidad p_mod_entidad)
        {
            p_mod_entidad.mails = new CatalogoMails().getMails(p_mod_entidad.codigo);
            p_mod_entidad.telefonos = new CatalogoTelefonos().getTelefonos(p_mod_entidad.codigo);
            p_mod_entidad.domicilios = new CatalogoDomicilios().getDomicilios(p_mod_entidad.codigo);
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
                "INSERT INTO [entidades] ([tipo_entidad],[cuit],[observaciones],[activo],[codigo_tipo_responsable]) " +
                "OUTPUT INSERTED.CODIGO " +
                "VALUES (@tipo_entidad, @cuit, @observaciones,@activo,@codigo_tipo_responsable)";
            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro(p_mod_entidad.tipoEntidad, "@tipo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_entidad.cuit, "@cuit"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_entidad.observaciones, "@observaciones"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_entidad.activo? 1:0, "@activo"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_entidad.codigoTipoResponsable, "@codigo_tipo_responsable"));

            comando.Connection.Open();
            int? nuevoCodigoEntidad = (int?)comando.ExecuteScalar();

            comando.Connection.Close();

            if (nuevoCodigoEntidad != null)
            { 
                this.actualizarMails(p_mod_entidad);
                this.actualizarTelefonos(p_mod_entidad);
                this.actualizarDomicilio(p_mod_entidad);

                return true;
            }
            else
            {
                throw new Exception("Ha ocurrido un error en la base de datos. No se ha podido registrar entidad.");
            }
        }

        protected bool updateEntidad(ModeloEntidad p_mod_entidad)
        {
            SqlCommand comando = Conexion.crearComando();

            comando.CommandText =
                "UPDATE [entidades] SET [cuit]=@cuit, [observaciones]=@observaciones,[tipo_entidad]=@tipo_entidad,[activo]=@activo, " +
                " codigo_tipo_responsable=@codigo_tipo_responsable WHERE [entidades].codigo=@codigo_entidad";

            comando.Parameters.Add(this.instanciarParametro(p_mod_entidad.codigo, "@codigo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_entidad.cuit, "@cuit"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_entidad.observaciones, "@observaciones"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_entidad.tipoEntidad, "@tipo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_entidad.activo ? 1 : 0, "@activo"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_entidad.codigoTipoResponsable, "@codigo_tipo_responsable"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            this.actualizarMails(p_mod_entidad);
            this.actualizarTelefonos(p_mod_entidad);
            this.actualizarDomicilio(p_mod_entidad);
            
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

        #region Mails, Teléfonos y Domicilios
        public bool actualizarMails(ModeloEntidad p_entidad)
        {
            CatalogoMails catalogo = new CatalogoMails();
            List<ModeloMail> mailsBaseDeDatos = catalogo.getMails(p_entidad.codigo);
            List<ModeloMail> mailsActuales = p_entidad.mails;
            List<ModeloMail> mailsAgregados = new List<ModeloMail>();

            foreach (ModeloMail m_bd in mailsBaseDeDatos)
            {
                bool esEliminacion = true;
                foreach (ModeloMail m_actual in mailsActuales)
                {
                    if (m_actual.codigoMail == 0 && !mailsAgregados.Exists(x => x.Equals(m_actual)))
                    {
                        catalogo.add(m_actual, p_entidad.codigo);
                        mailsAgregados.Add(m_actual);
                        continue;
                    }
                    if (m_actual.codigoMail == m_bd.codigoMail)
                    {//Si son iguales puede ser que se haya modificado o dejado como estaba
                        if (!m_bd.Equals(m_actual))
                        {
                            catalogo.update(m_actual);
                        }
                        esEliminacion = false;
                        continue;
                    }
                }
                if (esEliminacion)
                {
                    catalogo.remove(m_bd);
                }
            }

            if (mailsBaseDeDatos.Count == 0 && mailsActuales.Count > 0)
            {//si es 0 no entra en el loop anterior
                foreach (ModeloMail m in mailsActuales)
                {
                    catalogo.add(m, p_entidad.codigo);
                }
            }

            return true;

        }

        public bool actualizarDomicilio(ModeloEntidad p_entidad)
        {
            CatalogoDomicilios catalogo = new CatalogoDomicilios();
            List<ModeloDomicilio> domiciliosBaseDeDatos = catalogo.getDomicilios(p_entidad.codigo);
            List<ModeloDomicilio> domiciliosActuales = p_entidad.domicilios;
            List<ModeloDomicilio> domiciliosAgregados = new List<ModeloDomicilio>();

            foreach (ModeloDomicilio d_bd in domiciliosBaseDeDatos)
            {
                bool esEliminacion = true;
                foreach (ModeloDomicilio d_actual in domiciliosActuales)
                {
                    if (d_actual.codigoDomicilio == 0 && !domiciliosAgregados.Exists(x => x.Equals(d_actual)))
                    {
                        catalogo.add(d_actual, p_entidad.codigo);
                        domiciliosAgregados.Add(d_actual);
                        break;
                    }
                    if (d_actual.codigoDomicilio == d_bd.codigoDomicilio)
                    {//Si son iguales puede ser que se haya modificado o dejado como estaba
                        if (!d_bd.Equals(d_actual))
                        {
                            catalogo.update(d_actual);
                        }
                        esEliminacion = false;
                        continue; ;
                    }
                }
                if (esEliminacion)
                {
                    catalogo.remove(d_bd);
                }
            }

            if (domiciliosBaseDeDatos.Count == 0 && domiciliosActuales.Count > 0)
            {//si es 0 no entra en el loop anterior
                foreach (ModeloDomicilio d in domiciliosActuales)
                {
                    catalogo.add(d, p_entidad.codigo);
                }
            }

            return true;

        }

        public bool actualizarTelefonos(ModeloEntidad p_entidad)
        {
            CatalogoTelefonos catalogo = new CatalogoTelefonos();
            List<ModeloTelefono> telefonosBaseDeDatos = catalogo.getTelefonos(p_entidad.codigo);
            List<ModeloTelefono> telefonosActuales = p_entidad.telefonos;
            List<ModeloTelefono> telefonosAgregados = new List<ModeloTelefono>();

            foreach (ModeloTelefono t_bd in telefonosBaseDeDatos)
            {
                bool esEliminacion = true;
                foreach (ModeloTelefono t_actual in telefonosActuales)
                {
                    if (t_actual.codigoTelefono == 0 && !telefonosAgregados.Exists(x=> x.Equals(t_actual)))
                    {
                        catalogo.add(t_actual, p_entidad.codigo);
                        telefonosAgregados.Add(t_actual);
                        continue;
                    }
                    if (t_actual.codigoTelefono == t_bd.codigoTelefono)
                    {//Si son iguales puede ser que se haya modificado o dejado como estaba
                        if (!t_bd.Equals(t_actual))
                        {
                            catalogo.update(t_actual);
                        }
                        esEliminacion = false;
                        continue;
                    }
                }
                if (esEliminacion)
                {
                    catalogo.remove(t_bd);
                }
            }

            if (telefonosBaseDeDatos.Count == 0 && telefonosActuales.Count > 0)
            {//si es 0 no entra en el loop anterior
                foreach (ModeloTelefono d in telefonosActuales)
                {
                    catalogo.add(d, p_entidad.codigo);
                }
            }

            return true;

        }
        #endregion

        #endregion
    }
}
