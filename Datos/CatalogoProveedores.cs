using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data.SqlClient;
using System.Data;
using LibreriaClasesCompartidas;

namespace Datos
{
    public class CatalogoProveedores : CatalogoEntidades
    {
        public bool validarDatos(ModeloProveedor p_mod_proveedor)
        {
            //Valida que los parametros sean Validos en el dominio
            return true;
        }    

        public ModeloProveedor leerDatosProveedor(SqlDataReader p_drProveedores)
        {
            ModeloProveedor lcl_mod_proveedor = new ModeloProveedor(this.leerDatosEntidades(p_drProveedores));

            lcl_mod_proveedor.razonSocial = (p_drProveedores["razon_social"] != DBNull.Value) ? (string)p_drProveedores["razon_social"] : null;
            lcl_mod_proveedor.codigoTipoResponsable = (p_drProveedores["codigo_tipo_responsable"] != DBNull.Value) ? (int)p_drProveedores["codigo_tipo_responsable"] : 0;
            
            return lcl_mod_proveedor;
        }
        
        #region Búsqueda
        
        /// <summary>
        /// Genera string a insertar en clausula WHERE de sql de acuerdo a los parámetros de búsqueda
        /// </summary>
        /// <param name="p_mod_proveedor">modeloProveedor con variables posiblemente inicializadas</param>
        /// <param name="p_parametroBusqueda">constante encontrada en LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Proveedores</param>
        /// <param name="p_comando">comando sql que será modificado para incluir parámetros</param>
        /// <returns></returns>
        protected string getCondicionBusqueda(ModeloProveedor p_mod_proveedor,string p_parametroBusqueda,ref SqlCommand p_comando)
        {
            switch (p_parametroBusqueda)
            {
                case Constantes.ParametrosBusqueda.Entidades.Proveedores.RazonSocial:
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(p_mod_proveedor.razonSocial), "@razon_social"));
                    return " razon_social LIKE @razon_social ";
                    
                case Constantes.ParametrosBusqueda.Any:
                    string queryBase = base.getCondicionBusqueda(p_mod_proveedor,p_parametroBusqueda,ref p_comando);

                    string razonSocial = String.IsNullOrWhiteSpace(p_mod_proveedor.razonSocial)? null : p_mod_proveedor.razonSocial;
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(razonSocial), "@razon_social"));
                    string razonSocialQuery = this.parametroBusqueda("@razon_social", "razon_social", "LIKE");

                    return queryBase + " AND " + razonSocialQuery;
                    
                default:
                    //Prueba condiciones de atributos propios de modeloEntidad
                    return base.getCondicionBusqueda(p_mod_proveedor, p_parametroBusqueda, ref p_comando);
            }
        }

        public override IEnumerable<ModeloEntidad> buscar(ModeloEntidad p_mod_entidad, string p_parametroBusqueda)
        {
            IEnumerable<ModeloProveedor> lcl_lst_mod_proveedores = this.buscar(p_mod_entidad as ModeloProveedor, p_parametroBusqueda);
            IEnumerable<ModeloEntidad> lcl_lst_mod_entidades = lcl_lst_mod_proveedores;
            return lcl_lst_mod_entidades;
        }

        public virtual IEnumerable<ModeloProveedor> buscar(ModeloProveedor p_mod_proveedor, string p_parametroBusqueda)
        {
            return this.buscarProveedor(p_mod_proveedor, p_parametroBusqueda);
        }

        /// <summary>
        /// Busca proveedor(es) en base al parámetro ingresado
        /// </summary>
        /// <param name="p_mod_proveedor">modeloProveedor con variables posiblemente inicializadas</param>
        /// <param name="p_parametroBusqueda">Constantes obtenidas en LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Proveedores</param>
        /// <returns></returns>
        public List<ModeloProveedor> buscarProveedor(ModeloProveedor p_mod_proveedor, string p_parametroBusqueda)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;

            string querySQL = this.getCondicionBusqueda(p_mod_proveedor,p_parametroBusqueda,ref comando);
            
            comando.CommandText =
                "SELECT [proveedores].codigo_entidad,[entidades].tipo_entidad,[entidades].cuit,[entidades].observaciones,[proveedores].razon_social, "+
                "   [entidades].activo, [entidades].situacion_iva, [proveedores].codigo_tipo_responsable " +
                "   FROM [proveedores] " +
                "   INNER JOIN [entidades] on [entidades].codigo = [proveedores].codigo_entidad " +
                "   WHERE " + querySQL;

            comando.Connection.Open();

            SqlDataReader drProveedores = comando.ExecuteReader();

            List<ModeloProveedor> lcl_lst_mod_proveedor = new List<ModeloProveedor>();
            ModeloProveedor lcl_mod_proveedor = new ModeloProveedor();

            while (drProveedores.Read())
            {
                lcl_mod_proveedor = new ModeloProveedor();
                lcl_mod_proveedor = this.leerDatosProveedor(drProveedores);

                lcl_lst_mod_proveedor.Add(lcl_mod_proveedor);
            }
            drProveedores.Close();

            comando.Connection.Close();

            foreach (ModeloProveedor p in lcl_lst_mod_proveedor)
            {
                this.getDatosAdicionales(p);
            }

            return lcl_lst_mod_proveedor;
        }
        
        /// <summary>
        /// Busca proveedor de acuerdo a codigo de entidad
        /// </summary>
        /// <param name="p_codigoEntidad">codigo entidad del proveedor a buscar</param>
        /// <returns>ModeloProveedor si encuentra, null si no encuentra resultado</returns>
        new public ModeloProveedor getOne(int p_codigoEntidad)
        {
            ModeloProveedor lcl_mod_proveedor = new ModeloProveedor();
            List<ModeloProveedor> lcl_lst_mod_proveedor = new List<ModeloProveedor>();
            lcl_mod_proveedor.codigo = p_codigoEntidad;
            lcl_lst_mod_proveedor = this.buscarProveedor(lcl_mod_proveedor, Constantes.ParametrosBusqueda.Entidades.Proveedores.CodigoEntidad);
            
            if (lcl_lst_mod_proveedor.Count > 0)
            {
                return lcl_lst_mod_proveedor[0];
            }
            else
            {
                return null;
            }
        }
       
        /// <summary>
        /// Busca todos los proveedores que se encuentren en la base de datos
        /// </summary>
        /// <returns></returns>
        public List<ModeloProveedor> getAll()
        {
            return this.buscarProveedor(null, Constantes.ParametrosBusqueda.All);
        }

        #endregion

        #region Alta/Baja/Modificación

        public override bool add(ref ModeloEntidad p_mod_entidad)
        {
            if (base.add(ref p_mod_entidad) && this.add(p_mod_entidad as ModeloProveedor))
            {
                return true;
            }
            throw new Exception("Ha ocurrido un error en la base de datos. No se ha podido registrar proveedor.");
        }

        private bool add(ModeloProveedor p_mod_proveedor)
        {
            SqlConnection ConexionSQL = Conexion.crearConexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "INSERT INTO [Proveedores] ([codigo_entidad], [razon_social],[codigo_tipo_responsable]) " +
                "VALUES (@codigo_entidad, @razon_social, @codigo_tipo_responsable)";
            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro(p_mod_proveedor.codigo, "@codigo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_proveedor.razonSocial, "@razon_social"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_proveedor.codigoTipoResponsable, "@codigo_tipo_responsable"));
                
            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            { return true; }
            else
            { return false; }
        }

        public override bool update(ModeloEntidad p_mod_entidad)
        {
            return this.update(p_mod_entidad as ModeloProveedor);
        }

        public virtual bool update(ModeloProveedor p_mod_proveedor_nuevo)
        {
            ModeloProveedor lcl_mod_proveedor_original = this.buscar(p_mod_proveedor_nuevo, Constantes.ParametrosBusqueda.Entidades.Proveedores.CodigoEntidad).ToList()[0];
            if (lcl_mod_proveedor_original != null)
                return update(lcl_mod_proveedor_original, p_mod_proveedor_nuevo);
            else
                return false;
        }
        protected bool update(ModeloProveedor lcl_mod_proveedor_original, ModeloProveedor p_mod_proveedor_nuevo)
        {
            if (!lcl_mod_proveedor_original.Equals(p_mod_proveedor_nuevo))
            {
                if (!this.updateProveedor(p_mod_proveedor_nuevo))
                {
                    return false;
                }
            }
            ModeloEntidad lcl_mod_entidad_original = new ModeloEntidad(lcl_mod_proveedor_original as ModeloEntidad);
            ModeloEntidad lcl_mod_entidad_nueva = new ModeloEntidad(p_mod_proveedor_nuevo as ModeloEntidad);
            return base.update(lcl_mod_entidad_original, lcl_mod_entidad_nueva);
        }

        private bool updateProveedor(ModeloProveedor p_mod_proveedor)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "UPDATE [Proveedores] SET [razon_social]=@razon_social, [codigo_tipo_responsable]=@codigo_tipo_responsable " +
                "WHERE [Proveedores].codigo_entidad=@codigo_entidad";

            comando.Parameters.Add(this.instanciarParametro(p_mod_proveedor.codigo, "@codigo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_proveedor.razonSocial, "@razon_social"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_proveedor.codigoTipoResponsable, "@codigo_tipo_responsable"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            {
                return true;
            }
            else
            {
                return false;;
            }
        }
        public override bool remove(ModeloEntidad p_mod_entidad)
        {
            return this.remove(p_mod_entidad as ModeloProveedor);
        }

        public bool remove(ModeloProveedor p_mod_proveedor)
        {
            //INCOMPLETO. Igual que en CatalogoPersonas
            return base.remove(p_mod_proveedor);
        }
        #endregion
    }

}

