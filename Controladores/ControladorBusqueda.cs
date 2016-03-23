using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Datos;
using LibreriaClasesCompartidas;

namespace Controladores
{
    public class ControladorBusqueda
    {
        public List<Object> buscar(object p_objeto)
        {
            Type T = p_objeto.GetType();
            IEnumerable<object> lcl_ienum_objeto;
            if (T == typeof(ModeloArticuloProveedores))
            {
                lcl_ienum_objeto = this.buscarArticulosProveedores(p_objeto as ModeloArticuloProveedores);
                
            }
            else if (T == typeof(ModeloArticulos))
            {
                lcl_ienum_objeto = this.buscarArticulos(p_objeto as ModeloArticulos);
            }
            else 
            {
                lcl_ienum_objeto = this.buscar(p_objeto as ModeloEntidad);
            }
            return lcl_ienum_objeto.ToList();
        }

        public List<Object> buscar(object p_objeto, string p_parametroBusqueda)
        {
            Type T = p_objeto.GetType();
            IEnumerable<object> lcl_ienum_objeto;
            if (T == typeof(ModeloArticuloProveedores))
            {
                lcl_ienum_objeto = this.buscarArticulosProveedores(p_objeto as ModeloArticuloProveedores,p_parametroBusqueda);

            }
            else if (T == typeof(ModeloArticulos))
            {
                lcl_ienum_objeto = this.buscarArticulos(p_objeto as ModeloArticulos, p_parametroBusqueda);
            }
            else
            {
                lcl_ienum_objeto = this.buscar(p_objeto as ModeloEntidad, p_parametroBusqueda);
            }

            return lcl_ienum_objeto.ToList();
        }


        #region Entidades
        /// <summary>
        /// Retorna todas las entidades de la base de datos
        /// </summary>
        /// <returns>Lista de personas</returns>
        public List<ModeloEntidad> buscarEntidades()
        {
            CatalogoEntidades lcl_cat_entidades = new CatalogoEntidades();
            return lcl_cat_entidades.buscar(null,Constantes.ParametrosBusqueda.Entidades.All).ToList();
        }
        /// <summary>
        /// Retorna entidades (o alguno de sus derivados) en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="p_mod_entidad"></param>
        /// <returns>Lista de entidades (o alguno de sus derivados)</returns>
        public List<ModeloEntidad> buscar(ModeloEntidad p_mod_entidad)
        {
            return this.buscar(p_mod_entidad,Constantes.ParametrosBusqueda.Entidades.Any);
        }
        /// <summary>
        /// Busca entidades (o alguno de sus derivados) que cumplan con un parámetro de búsqueda.
        /// </summary>
        /// <param name="p_mod_entidad">modelo con variable a buscar inicializada con algún valor</param>
        /// <param name="p_paramentroBusqueda">Constante dentro de LibreriaClasesCompartidas.Constantes.ParametrosBusqueda</param>
        /// <returns>Lista de modeloEntidad (o alguno de sus derivados)</returns>
        public List<ModeloEntidad> buscar(ModeloEntidad p_mod_entidad, string p_paramentroBusqueda)
        {
            Type T = p_mod_entidad.GetType();
            CatalogoEntidades lcl_catalogo;
            if (T == typeof(ModeloCliente))
            {
                lcl_catalogo = new CatalogoClientes();
            }
            else if (T == typeof(ModeloUsuario))
            {
                lcl_catalogo = new CatalogoUsuarios();
            }
            else if (T == typeof(ModeloContactoProveedor))
            {
                lcl_catalogo = new CatalogoContactoProveedores();
            }
            else if (T == typeof(ModeloProveedor))
            {
                lcl_catalogo = new CatalogoProveedores();
            }
            else if (T == typeof(ModeloPersonas))
            {
                lcl_catalogo = new CatalogoPersonas();
            }
            else
            {
                lcl_catalogo = new CatalogoEntidades();
            }

            return lcl_catalogo.buscar(p_mod_entidad, p_paramentroBusqueda).ToList();
        }

        #region ELIMINAR
        #region Personas
        /// <summary>
        /// Retorna todas las personas de la base de datos
        /// </summary>
        /// <returns>Lista de personas</returns>
        public List<ModeloPersonas> buscarPersonas()
        {
            CatalogoPersonas lcl_cat_personas = new CatalogoPersonas();

            return lcl_cat_personas.buscarPersonas(null, Constantes.ParametrosBusqueda.Entidades.Personas.All);
        }
        /// <summary>
        /// Retorna personas en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="p_mod_persona"></param>
        /// <returns>Lista de personas</returns>
        public List<ModeloPersonas> buscarPersonas(ModeloPersonas p_mod_persona)
        {
            CatalogoPersonas lcl_cat_personas = new CatalogoPersonas();

            return lcl_cat_personas.buscarPersonas(p_mod_persona, Constantes.ParametrosBusqueda.Entidades.Personas.Any);
        }
        /// <summary>
        /// Busca personas que cumplan con un parámetro de búsqueda.
        /// </summary>
        /// <param name="p_mod_persona">Persona con variable a buscar inicializada con algún valor</param>
        /// <param name="p_paramentroBusqueda">Constante dentro de LibreriaClasesCompartidas.Constantes.ParametrosBusqueda</param>
        /// <returns>Lista de personas</returns>
        public List<ModeloPersonas> buscarPersonas(ModeloPersonas p_mod_persona, string p_paramentroBusqueda)
        {
            CatalogoPersonas lcl_cat_personas = new CatalogoPersonas();

            return lcl_cat_personas.buscarPersonas(p_mod_persona, p_paramentroBusqueda);
        }

        #endregion

        #region Proveedores
        /// <summary>
        /// Retorna todos los proveedores de la base de datos
        /// </summary>
        /// <returns>Lista de personas</returns>
        public List<ModeloProveedor> buscarProveedores()
        {
            CatalogoProveedores lcl_cat_proveedores = new CatalogoProveedores();

            return lcl_cat_proveedores.buscarProveedor(null, Constantes.ParametrosBusqueda.Entidades.Proveedores.All);
        }
        /// <summary>
        /// Retorna proveedores en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="p_mod_proveedor"></param>
        /// <returns>Lista de proveedores</returns>
        public List<ModeloProveedor> buscarProveedores(ModeloProveedor p_mod_proveedor)
        {
            CatalogoProveedores lcl_cat_proveedores = new CatalogoProveedores();

            return lcl_cat_proveedores.buscarProveedor(p_mod_proveedor, Constantes.ParametrosBusqueda.Entidades.Proveedores.Any);
        }
        /// <summary>
        /// Busca proveedores que cumplan con un parámetro de búsqueda
        /// </summary>
        /// <param name="p_mod_proveedor">Proveedor con variable a buscar inicializada con algún valor</param>
        /// <param name="p_paramentroBusqueda">Constante dentro de LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Proveedores</param>
        /// <returns>Lista de proveedores</returns>
        public List<ModeloProveedor> buscarProveedores(ModeloProveedor p_mod_proveedor, string p_paramentroBusqueda)
        {
            CatalogoProveedores lcl_cat_proveedores = new CatalogoProveedores();

            return lcl_cat_proveedores.buscarProveedor(p_mod_proveedor, p_paramentroBusqueda);
        }

        #endregion
        #endregion
        #endregion

        #region Articulos
        /// <summary>
        /// Retorna todos los Articulos de la base de datos
        /// </summary>
        /// <returns>Lista de Articulos</returns>
        public List<ModeloArticulos> buscarArticulos()
        {
            CatalogoArticulos lcl_cat_articulos = new CatalogoArticulos();

            return lcl_cat_articulos.buscarArticulo(null, Constantes.ParametrosBusqueda.Articulos.All);
        }
        /// <summary>
        /// Retorna articulos en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="pmArticulo"></param>
        /// <returns>Lista de articulos</returns>
        public List<ModeloArticulos> buscarArticulos(ModeloArticulos p_mod_articulo)
        {
            CatalogoArticulos lcl_cat_articulos = new CatalogoArticulos();
            
            return lcl_cat_articulos.buscarArticulo(p_mod_articulo,Constantes.ParametrosBusqueda.Articulos.Any); 
        }
        /// <summary>
        /// Busca articulos que cumplan con un parámetro de búsqueda
        /// </summary>
        /// <param name="p_mod_articulo">Articulo con variable a buscar inicializada con algún valor</param>
        /// <param name="p_paramentroBusqueda">Constante dentro de LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Articulos</param>
        /// <returns>Lista de artículos</returns>
        public List<ModeloArticulos> buscarArticulos(ModeloArticulos p_mod_articulo, string p_paramentroBusqueda)
        {
            CatalogoArticulos lcl_cat_articulos = new CatalogoArticulos();

            return lcl_cat_articulos.buscarArticulo(p_mod_articulo, p_paramentroBusqueda);
        }

        #endregion
        
        #region ArticuloProveedores
        /// <summary>
        /// Retorna todos los ArticulosProveedores de la base de datos
        /// </summary>
        /// <returns>Lista de Articulos de proveedores</returns>
        public List<ModeloArticuloProveedores> buscarArticulosProveedores()
        {
            CatalogoArticuloProveedores lcl_cat_articuloProveedores = new CatalogoArticuloProveedores();
            //Cambiar a buscarArticulo(null,All) cuando deje de ser ambigua la llamada
            return lcl_cat_articuloProveedores.buscar(null,Constantes.ParametrosBusqueda.ArticulosProveedores.All);
        }
        /// <summary>
        /// Retorna artículos de proveedores en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="p_mod_articuloProveedores"></param>
        /// <returns>Lista de Artículos de proveedores</returns>
        public List<ModeloArticuloProveedores> buscarArticulosProveedores(ModeloArticuloProveedores p_mod_articuloProveedores)
        {
            CatalogoArticuloProveedores lcl_cat_articuloProveedores = new CatalogoArticuloProveedores();
            
            return lcl_cat_articuloProveedores.buscar(p_mod_articuloProveedores,Constantes.ParametrosBusqueda.ArticulosProveedores.Any); 
        }
        /// <summary>
        /// Busca artículos de proveedores que cumplan con un parámetro de búsqueda
        /// </summary>
        /// <param name="p_mod_articuloProveedores">Proveedor con variable a buscar inicializada con algún valor</param>
        /// <param name="p_paramentroBusqueda">Constante dentro de LibreriaClasesCompartidas.Constantes.ParametrosBusqueda</param>
        /// <returns>Lista de artículos de proveedores</returns>
        public List<ModeloArticuloProveedores> buscarArticulosProveedores(ModeloArticuloProveedores p_mod_articuloProveedores, string p_paramentroBusqueda)
        {
            CatalogoArticuloProveedores lcl_cat_articulosProveedores = new CatalogoArticuloProveedores();
            switch (p_paramentroBusqueda)
            {
                case Constantes.ParametrosBusqueda.ArticulosProveedores.Descripcion:
                    return this.buscarArticuloProveedor_descripcionArticulo(p_mod_articuloProveedores);
                default:
                    return lcl_cat_articulosProveedores.buscar(p_mod_articuloProveedores, p_paramentroBusqueda);
            }
        }

        private List<ModeloArticuloProveedores> buscarArticuloProveedor_descripcionArticulo(ModeloArticuloProveedores p_mod_articuloProveedores)
        {
            /*
            * Para buscar articuloProveedor por descripcion de articulo empezamos buscando 
            * todos los articulos que tengan esa descripcion por métodos de CatalogoArticulos
            */
            ModeloArticulos lcl_mod_articulo = new ModeloArticulos();
            lcl_mod_articulo.descripcion = "";//Falta determinar de donde sacar valor de descripcion   //p_mod_articuloProveedores.;
            CatalogoArticulos lcl_cat_articulos = new CatalogoArticulos();

            List<ModeloArticuloProveedores> lcl_lst_mod_articulosProveedores = new List<ModeloArticuloProveedores>();
            ModeloArticuloProveedores lcl_mod_articuloProveedor = null;
            /*
             *Obtenemos codigoOriginal de cada articulo encontrado y 
             *buscamos articulos de proveedores por métodos de CatalogoArticuloProveedores 
             */
            foreach (ModeloArticulos a in this.buscarArticulos(lcl_mod_articulo, Constantes.ParametrosBusqueda.Articulos.Descripcion))
            {
                lcl_mod_articuloProveedor.codigoOriginal = a.codigoOriginal;
                foreach (ModeloArticuloProveedores ap in this.buscarArticulosProveedores(lcl_mod_articuloProveedor, Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoOriginal))
                {
                    lcl_lst_mod_articulosProveedores.Add(ap);
                }
            }
            if (lcl_lst_mod_articulosProveedores.Count > 0)
            {
                return lcl_lst_mod_articulosProveedores;
            }
            {
                return null;
            }
        }
        
        #endregion
                             
        #region Provincias
        /// <summary>
        /// Retorna todas las provincias de la base de datos
        /// </summary>
        /// <returns>Lista de provincias</returns>
        
        public List<ModeloProvincia> buscarProvincias()
        {
            CatalogoProvincias lcl_cat_provincias = new CatalogoProvincias();

            return lcl_cat_provincias.getAll();
        }

        /// <summary>
        /// Retorna provincias en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="p_mod_provincia"></param>
        /// <returns>Lista de provincias</returns>
        public ModeloProvincia buscarProvincia(ModeloProvincia p_mod_provincia)
        {
            CatalogoProvincias lcl_cat_provincias = new CatalogoProvincias();

            return lcl_cat_provincias.getOne(p_mod_provincia.codigo);
        }

        #endregion

        #region Paises
        /// <summary>
        /// Retorna todas los paises de la base de datos
        /// </summary>
        /// <returns>lista de Países</returns>
        public List<ModeloPais> buscarPaises()
        {
            CatalogoPaises lcl_cat_paises = new CatalogoPaises();
            return lcl_cat_paises.getAll();
        }

        /// <summary>
        /// Retorna paises en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="p_mod_pais"></param>
        /// <returns>Lista de Países</returns>
        public ModeloPais buscarPaises(ModeloPais p_mod_pais)
        {
            CatalogoPaises lcl_cat_paises = new CatalogoPaises();
            return lcl_cat_paises.getOne(p_mod_pais.codigo);
        }

        #endregion

        #region Domicilios
        /// <summary>
        /// Retorna domicilios en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="p_mod_domicilio"></param>
        /// <returns>Lista de domicilios</returns>
        public List<ModeloDomicilio> buscarDomicilios(ModeloDomicilio p_mod_domicilio)
        {
            CatalogoDomicilios lcl_cat_domicilios = new CatalogoDomicilios();
            
            return lcl_cat_domicilios.getDomicilios(p_mod_domicilio.codigoDomicilio);            
        }

        #endregion

        #region Mails
        /// <summary>
        /// Retorna mails en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="p_mod_mails"></param>
        /// <returns>Lista de Mails</returns>
        public List<ModeloMail> buscarMails(ModeloMail p_mod_mails)
        {
            CatalogoMails lcl_cat_mails = new CatalogoMails();
            
            return lcl_cat_mails.getMails(p_mod_mails.codigoMail);
        }

        #endregion

        #region Telefonos
        /// <summary>
        /// Retorna teléfonos en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="p_mod_telefonos"></param>
        /// <returns>Lista de teléfonos</returns>
        public List<ModeloTelefono> buscarTelefonos(ModeloTelefono p_mod_telefonos)
        {
            CatalogoTelefonos lcl_cat_telefonos = new CatalogoTelefonos();

            return lcl_cat_telefonos.getTelefonos(p_mod_telefonos.codigoTelefono);
        }

        #endregion

        #region Pedidos
        /// <summary>
        /// Retorna todos los pedidos de la base de datos
        /// </summary>
        /// <returns>Lista de Pedidos</returns>
        public List<ModeloPedido> buscarPedido()
        {
            CatalogoPedidos lcl_cat_articulos = new CatalogoPedidos();

            return lcl_cat_articulos.buscarPedido(null, Constantes.ParametrosBusqueda.Pedidos.All);
        }
        /// <summary>
        /// Retorna pedidos en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="p_mod_pedido"></param>
        /// <returns>Lista de pedidos</returns>
        public List<ModeloPedido> buscarPedido(ModeloPedido p_mod_pedido)
        {
            CatalogoPedidos lcl_cat_articulos = new CatalogoPedidos();

            return lcl_cat_articulos.buscarPedido(p_mod_pedido, Constantes.ParametrosBusqueda.Pedidos.Any);
        }
        /// <summary>
        /// Busca articulos que cumplan con un parámetro de búsqueda
        /// </summary>
        /// <param name="p_mod_pedido">Pedido con variable a buscar inicializada con algún valor</param>
        /// <param name="p_paramentroBusqueda">Constante dentro de LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Pedidos</param>
        /// <returns>Lista de pedidos</returns>
        public List<ModeloPedido> buscarPedido(ModeloPedido p_mod_pedido, string p_paramentroBusqueda)
        {
            CatalogoPedidos lcl_cat_articulos = new CatalogoPedidos();

            return lcl_cat_articulos.buscarPedido(p_mod_pedido, p_paramentroBusqueda);
        }
        #endregion

        #region LineasPedido
        /// <summary>
        /// Retorna todos las líneas pedidos de la base de datos
        /// </summary>
        /// <returns>Lista de líneas pedidos</returns>
        public List<ModeloLineaPedido> buscarLineaPedido()
        {
            CatalogoLineasPedidos lcl_cat_articulos = new CatalogoLineasPedidos();

            return lcl_cat_articulos.buscarLineasPedido(null, Constantes.ParametrosBusqueda.LineasPedidos.All);
        }
        /// <summary>
        /// Retorna líneas pedidos en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="p_mod_lineaPedido"></param>
        /// <returns>Lista de líneas pedidos</returns>
        public List<ModeloLineaPedido> buscarLineaPedido(ModeloLineaPedido p_mod_lineaPedido)
        {
            CatalogoLineasPedidos lcl_cat_articulos = new CatalogoLineasPedidos();

            return lcl_cat_articulos.buscarLineasPedido(p_mod_lineaPedido, Constantes.ParametrosBusqueda.LineasPedidos.Any);
        }
        /// <summary>
        /// Busca líneas pedidos que cumplan con un parámetro de búsqueda
        /// </summary>
        /// <param name="p_mod_lineaPedido">Línea pedido con variable a buscar inicializada con algún valor</param>
        /// <param name="p_paramentroBusqueda">Constante dentro de LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.LineasPedidos</param>
        /// <returns>Lista de líneas pedidos</returns>
        public List<ModeloLineaPedido> buscarLineaPedido(ModeloLineaPedido p_mod_lineaPedido, string p_paramentroBusqueda)
        {
            CatalogoLineasPedidos lcl_cat_articulos = new CatalogoLineasPedidos();

            return lcl_cat_articulos.buscarLineasPedido(p_mod_lineaPedido, p_paramentroBusqueda);
        }
        #endregion

        #region Roles
        /// <summary>
        /// Retorna todas roles de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<ModeloRoles> buscarRoles()
        {
            CatalogoRoles lcl_cat_roles = new CatalogoRoles();
            ModeloRoles lcl_mod_rol = null;
            return this.buscar(lcl_mod_rol, Constantes.ParametrosBusqueda.All);
        }

        /// <summary>
        /// Retorna roles en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="p_mod_rol"></param>
        /// <returns>Lista de provincias</returns>
        public List<ModeloRoles> buscar(ModeloRoles p_mod_rol)
        {
            CatalogoRoles lcl_cat_roles = new CatalogoRoles();

            return lcl_cat_roles.buscar(p_mod_rol,Constantes.ParametrosBusqueda.Roles.Any);
        }
        public List<ModeloRoles> buscar(ModeloRoles p_mod_rol, string p_parametroBusqueda)
        {
            CatalogoRoles lcl_cat_roles = new CatalogoRoles();

            return lcl_cat_roles.buscar(p_mod_rol,p_parametroBusqueda);
        }
        #endregion
    }
}
