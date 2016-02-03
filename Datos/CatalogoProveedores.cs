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

        /// <summary>
        /// determina existencia de proveedor de acuerdo a cuit y razonSocial ingresados
        /// </summary>
        /// <param name="cuit">cuit de proveedor</param>
        /// <param name="razonSocial">razón social de proveedor</param>
        /// <returns>true si existe, false si no existe</returns>
        public bool existeEntidad(int p_codigoEntidad)
        {
            bool respuesta = false;
            if (getOne(p_codigoEntidad) != null)
            {
                respuesta = true;
            }
            return respuesta;
        }

        public ModeloProveedor leerDatosProveedor(SqlDataReader p_drProveedores)
        {
            ModeloProveedor lcl_mod_proveedor = new ModeloProveedor();

            lcl_mod_proveedor.codigo = (int)p_drProveedores["codigo"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            lcl_mod_proveedor.razonSocial = (p_drProveedores["razon_social"] != DBNull.Value) ? (string)p_drProveedores["razon_social"] : null;

            lcl_mod_proveedor.cuit = (p_drProveedores["cuit"] != DBNull.Value) ? (string)p_drProveedores["cuit"] : null;
            lcl_mod_proveedor.tipoEntidad = (p_drProveedores["tipo_entidad"] != DBNull.Value) ? (string)p_drProveedores["tipo_entidad"] : null;
            lcl_mod_proveedor.observaciones = (p_drProveedores["observaciones"] != DBNull.Value) ? (string)p_drProveedores["observaciones"] : null;

            return lcl_mod_proveedor;
        }
        
        /// <summary>
        /// Genera string a insertar en clausula WHERE de sql de acuerdo a los parámetros de búsqueda
        /// </summary>
        /// <param name="p_mod_proveedor">modeloProveedor con variables posiblemente inicializadas</param>
        /// <param name="p_parametroBusqueda">constante encontrada en LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Proveedores</param>
        /// <param name="p_comando">comando sql que será modificado para incluir parámetros</param>
        /// <returns></returns>
        private string getCondicionBusqueda(ModeloProveedor p_mod_proveedor,string p_parametroBusqueda,ref SqlCommand p_comando)
        {
            switch (p_parametroBusqueda)
            {
                case Constantes.ParametrosBusqueda.Entidades.Proveedores.CodigoEntidad:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_proveedor.codigo, "@codigo"));
                    return " codigo = @codigo ";
                    
                case Constantes.ParametrosBusqueda.Entidades.Proveedores.Cuit:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_proveedor.cuit, "@cuit"));
                    return " cuit = @cuit ";
                    
                case Constantes.ParametrosBusqueda.Entidades.Proveedores.RazonSocial:
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(p_mod_proveedor.razonSocial), "@razon_social"));
                    return " razon_social LIKE @razon_social ";
                    
                case Constantes.ParametrosBusqueda.Entidades.Proveedores.Any:
                    int? codigoEntidad = p_mod_proveedor.codigo == 0 ? null : (int?)p_mod_proveedor.codigo;
                    p_comando.Parameters.Add(this.instanciarParametro(codigoEntidad, "@codigo_entidad"));
                    string codigoEntidadQuery = @" (@codigo_entidad IS NULL OR @codigo_entidad = codigo_entidad) ";

                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_proveedor.cuit, "@cuit"));
                    string cuitQuery = this.parametroBusqueda("@cuit", "cuit", "=");

                    string razonSocial = p_mod_proveedor.razonSocial == "" ? null : p_mod_proveedor.razonSocial;
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(razonSocial), "@razon_social"));
                    string razonSocialQuery = this.parametroBusqueda("@razon_social", "razon_social", "LIKE");

                    return codigoEntidadQuery + " AND " + cuitQuery + " AND " + razonSocialQuery;
                    
                case Constantes.ParametrosBusqueda.Entidades.Proveedores.All:
                    //retorna true y devuelve todas las filas
                    return " 1 = 1 ";
                default:
                    //hace que sql no retorne filas
                    return " 1 = 2 ";
            }
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
                "SELECT [entidades].codigo,[entidades].tipo_entidad,[entidades].cuit,[entidades].observaciones,[proveedores].razon_social" +
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

                lcl_mod_proveedor.mails = this.getMails(lcl_mod_proveedor.codigo);
                lcl_mod_proveedor.telefonos = this.getTelefonos(lcl_mod_proveedor.codigo);
                lcl_mod_proveedor.domicilios = this.getDomicilios(lcl_mod_proveedor.codigo);

                lcl_lst_mod_proveedor.Add(lcl_mod_proveedor);
            }
            drProveedores.Close();

            comando.Connection.Close();

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
        public new List<ModeloProveedor> getAll()
        {
            return this.buscarProveedor(null, Constantes.ParametrosBusqueda.Entidades.Proveedores.All);
        }
        

        #region Alta/Baja/Modificación
        /*
         * True si se realizó correctamente
         * False si ocurrió algún error
         */
        override public bool add(ref ModeloProveedor p_mod_proveedor)
        {
            //*REVISAR (validar existencia a traves de codigo de una entidad que puede no tener código?)
            //y continua si se creó exitosamente la entidad
            if (base.add(ref p_mod_proveedor))
            {
                //Creo la conexion y la abro
                SqlConnection ConexionSQL = Conexion.crearConexion();

                //crea SQL command
                SqlCommand comando = new SqlCommand();

                comando.Connection = ConexionSQL;

                comando.CommandType = CommandType.Text;

                comando.CommandText =
                    "INSERT INTO [Proveedores] ([codigo_entidad], [razon_social]) "+
                    "VALUES (@codigo_entidad, @razon_social)";
                //Indica los parametros
                comando.Parameters.Add(this.instanciarParametro(p_mod_proveedor.codigo, "@codigo_entidad"));
                comando.Parameters.Add(this.instanciarParametro(p_mod_proveedor.razonSocial, "@razon_social"));
                
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
            else
            {
                return false;
            }
        }     

        //No se podrá modificar razonSocial
        override public bool update(ModeloProveedor p_mod_proveedor)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = 
                "UPDATE [proveedores] SET [razon_social] = @razon_social "+
                "WHERE [proveedores].codigo_entidad=@codigo_entidad";

            comando.Parameters.Add(this.instanciarParametro(p_mod_proveedor.razonSocial, "@razon_social"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_proveedor.codigo, "@codigo_entidad"));
            
            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();           
            comando.Connection.Close();

            if (rowaffected != 0 && base.update(p_mod_proveedor))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool remove(ModeloProveedor p_mod_proveedor)
        {
            //INCOMPLETO
            return base.remove(p_mod_proveedor.codigo);
        }
        #endregion
    }

}

