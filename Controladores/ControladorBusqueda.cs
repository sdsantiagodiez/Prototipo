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
        #region getClase()
        /// <summary>
        /// Retorna todas las entidades de la base de datos
        /// </summary>
        /// <returns>Lista de personas</returns>
        public static List<ModeloEntidad> getEntidades()
        {
            return ControladorBusqueda.buscar(new ModeloEntidad(), Constantes.ParametrosBusqueda.All);
        }
        /// <summary>
        /// Retorna todas las personas de la base de datos
        /// </summary>
        /// <returns>Lista de personas</returns>
        public static List<ModeloPersonas> getPersonas()
        {
            return ControladorBusqueda.buscar(new ModeloPersonas(), Constantes.ParametrosBusqueda.All);
        }
        /// <summary>
        /// Retorna todos los proveedores de la base de datos
        /// </summary>
        /// <returns>Lista de personas</returns>
        public static  List<ModeloProveedor> getProveedores()
        {
            return ControladorBusqueda.buscar(new ModeloProveedor(), Constantes.ParametrosBusqueda.All);
        }
        public static List<ModeloCliente> getClientes()
        {
            ModeloCliente lcl_mod_cliente = new ModeloCliente();
            return ControladorBusqueda.buscar(lcl_mod_cliente as object, Constantes.ParametrosBusqueda.All).Cast<ModeloCliente>().ToList();
        }
        public static List<ModeloUsuario> getUsuarios()
        {
            ModeloUsuario lcl_mod_usuario = new ModeloUsuario();
            return ControladorBusqueda.buscar(lcl_mod_usuario as object, Constantes.ParametrosBusqueda.All).Cast<ModeloUsuario>().ToList();
        }
        public static List<ModeloContactoProveedor> getContactosProveedores()
        {
            ModeloContactoProveedor lcl_mod_contactoProveedor = new ModeloContactoProveedor();
            return ControladorBusqueda.buscar(lcl_mod_contactoProveedor as object, Constantes.ParametrosBusqueda.All).Cast<ModeloContactoProveedor>().ToList();
        }
        /// <summary>
        /// Retorna todos los Articulos de la base de datos
        /// </summary>
        /// <returns>Lista de Articulos</returns>
        public static List<ModeloArticulos> getArticulos()
        {
            return ControladorBusqueda.buscar(new ModeloArticulos(), Constantes.ParametrosBusqueda.All);
        }
        /// <summary>
        /// Retorna todos los ArticulosProveedores de la base de datos
        /// </summary>
        /// <returns>Lista de Articulos de proveedores</returns>
        public static List<ModeloArticuloProveedores> getArticulosProveedores()
        {
            ModeloArticuloProveedores lcl_mod_articuloProveedor = new ModeloArticuloProveedores();
            return ControladorBusqueda.buscar(lcl_mod_articuloProveedor, Constantes.ParametrosBusqueda.All);
        }
        /// <summary>
        /// Descuentos Predeterminados
        /// </summary>
        /// <returns></returns>
        public static List<ModeloDescuento> getDescuentosBase()
        {
            List<int> lst_porcentajes = new List<int>() { 5, 10, 15, 20, 25, 30, 40, 50, 60, 70, 80 };
            List<ModeloDescuento> lcl_lst_DescuentosBase = new List<ModeloDescuento>();
            int codigo = 1;
            foreach (int i in lst_porcentajes)
            {
                lcl_lst_DescuentosBase.Add(new ModeloDescuento()
                {
                    codigoDescuento = codigo,
                    porcentaje = Convert.ToDecimal(i) / 100,
                    descripcion = i.ToString() + " %"
                });
                codigo++;
            }
            return lcl_lst_DescuentosBase;
        }
        /// <summary>
        /// Descuentos Predeterminados y descuentos creados por usuario
        /// </summary>
        /// <returns></returns>
        public static List<ModeloDescuento> getDescuentos()
        {
            return new List<ModeloDescuento>();
        }
        /// <summary>
        /// Descuentos asignados a artículos
        /// </summary>
        /// <returns></returns>
        public static List<ModeloDescuentoArticuloProveedor> getDescuentosArticulosProveedores()
        {
            return new List<ModeloDescuentoArticuloProveedor>();
        }
        /// <summary>
        /// Retorna todas las provincias de la base de datos
        /// </summary>
        /// <returns>Lista de provincias</returns>
        public static List<ModeloProvincia> getProvincias()
        {
            CatalogoProvincias lcl_cat_provincias = new CatalogoProvincias();

            return lcl_cat_provincias.getAll();
        }
        /// <summary>
        /// Retorna todas los paises de la base de datos
        /// </summary>
        /// <returns>lista de Países</returns>
        public static List<ModeloPais> getPaises()
        {
            CatalogoPaises lcl_cat_paises = new CatalogoPaises();
            return lcl_cat_paises.getAll();
        }
        /// <summary>
        /// Retorna todas roles de la base de datos
        /// </summary>
        /// <returns></returns>
        public static List<ModeloRoles> getRoles()
        {
            ModeloRoles lcl_mod_rol = new ModeloRoles();
            return ControladorBusqueda.buscar(lcl_mod_rol, Constantes.ParametrosBusqueda.All);
        }

        public static List<TipoDocumento> getTiposDocumentos()
        {
            CatalogoEntidades lcl_cat_entidades = new CatalogoEntidades();
            return lcl_cat_entidades.getTiposDocumentos();
        }
        #endregion

        #region buscar(object)
        public static List<Object> buscar(object p_objeto)
        {
            Type T = p_objeto.GetType();
            IEnumerable<object> lcl_ienum_objeto;
            if (T == typeof(ModeloArticuloProveedores))
            {
                lcl_ienum_objeto = ControladorBusqueda.buscar(p_objeto as ModeloArticuloProveedores);

            }
            else if (T == typeof(ModeloArticulos))
            {
                lcl_ienum_objeto = ControladorBusqueda.buscar(p_objeto as ModeloArticulos);
            }
            else if (T == typeof(ModeloPedido))
            {
                lcl_ienum_objeto = ControladorBusqueda.buscar(p_objeto as ModeloPedido);
            }
            else
            {
                lcl_ienum_objeto = ControladorBusqueda.buscar(p_objeto as ModeloEntidad);
            }
            return lcl_ienum_objeto.ToList();
        }
        /// <summary>
        /// Retorna entidades (o alguno de sus derivados) en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="p_mod_entidad"></param>
        /// <returns>Lista de entidades (o alguno de sus derivados)</returns>
        public static List<ModeloEntidad> buscar(ModeloEntidad p_mod_entidad)
        {
            return ControladorBusqueda.buscar(p_mod_entidad, Constantes.ParametrosBusqueda.Any);
        }
        ///// <summary>
        ///// Retorna personas en base a los valores inicializados en los atributos del modelo
        ///// </summary>
        ///// <param name="p_mod_persona"></param>
        ///// <returns>Lista de personas</returns>
        //public List<ModeloPersonas> buscar(ModeloPersonas p_mod_persona)
        //{
        //    CatalogoPersonas lcl_cat_personas = new CatalogoPersonas();

        //    return lcl_cat_personas.buscarPersonas(p_mod_persona, Constantes.ParametrosBusqueda.Any);
        //}
        ///// <summary>
        ///// Retorna proveedores en base a los valores inicializados en los atributos del modelo
        ///// </summary>
        ///// <param name="p_mod_proveedor"></param>
        ///// <returns>Lista de proveedores</returns>
        //public List<ModeloProveedor> buscar(ModeloProveedor p_mod_proveedor)
        //{
        //    CatalogoProveedores lcl_cat_proveedores = new CatalogoProveedores();

        //    return lcl_cat_proveedores.buscarProveedor(p_mod_proveedor, Constantes.ParametrosBusqueda.Any);
        //}
        /// <summary>
        /// Retorna articulos en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="pmArticulo"></param>
        /// <returns>Lista de articulos</returns>
        public static List<ModeloArticulos> buscar(ModeloArticulos p_mod_articulo)
        {
            CatalogoArticulos lcl_cat_articulos = new CatalogoArticulos();

            return lcl_cat_articulos.buscar(p_mod_articulo, Constantes.ParametrosBusqueda.Any);
        }
        /// <summary>
        /// Retorna artículos de proveedores en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="p_mod_articuloProveedores"></param>
        /// <returns>Lista de Artículos de proveedores</returns>
        public static List<ModeloArticuloProveedores> buscar(ModeloArticuloProveedores p_mod_articuloProveedores)
        {
            CatalogoArticuloProveedores lcl_cat_articuloProveedores = new CatalogoArticuloProveedores();
            return lcl_cat_articuloProveedores.buscar(p_mod_articuloProveedores, Constantes.ParametrosBusqueda.Any);
        }
        /// <summary>
        /// Retorna pedidos en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="p_mod_pedido"></param>
        /// <returns>Lista de pedidos</returns>
        public static List<ModeloPedido> buscarPedido(ModeloPedido p_mod_pedido)
        {//sin uso
            CatalogoPedidos lcl_cat_articulos = new CatalogoPedidos();

            return lcl_cat_articulos.buscarPedido(p_mod_pedido, Constantes.ParametrosBusqueda.Any);
        }
        public static List<ModeloPedido> buscar(ModeloPedido p_mod_pedido)
        {
            CatalogoPedidos lcl_cat_pedidos = new CatalogoPedidos();
            if (p_mod_pedido.tipoComprobante == 1)
            {
                return lcl_cat_pedidos.getAllTipo(Constantes.CodigosTiposPedidos.TipoPedidoPersona);
            }
            else 
            {
                return lcl_cat_pedidos.getAllTipo(Constantes.CodigosTiposPedidos.TipoPedidoProveedor);
            }
            
        }
        /// <summary>
        /// Retorna líneas pedidos en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="p_mod_lineaPedido"></param>
        /// <returns>Lista de líneas pedidos</returns>
        public static List<ModeloLineaPedido> buscar(ModeloLineaPedido p_mod_lineaPedido)
        {
            CatalogoLineasPedidos lcl_cat_articulos = new CatalogoLineasPedidos();

            return lcl_cat_articulos.buscarLineasPedido(p_mod_lineaPedido, Constantes.ParametrosBusqueda.Any);
        }
        #endregion

        #region buscar(object,parametroBusqueda)
        public static IEnumerable<Object> buscar(object p_objeto, string p_parametroBusqueda)
        {
            Type T = p_objeto.GetType();
            IEnumerable<object> lcl_ienum_objeto;
            if (T == typeof(ModeloArticuloProveedores))
            {
                lcl_ienum_objeto = ControladorBusqueda.buscar(p_objeto as ModeloArticuloProveedores, p_parametroBusqueda);
            }
            else if (T == typeof(ModeloArticulos))
            {
                lcl_ienum_objeto = ControladorBusqueda.buscar(p_objeto as ModeloArticulos, p_parametroBusqueda);
            }
            else
            {
                lcl_ienum_objeto = ControladorBusqueda.buscar(p_objeto as ModeloEntidad, p_parametroBusqueda);
            }

            return lcl_ienum_objeto.ToList();
        }
        /// <summary>
        /// Busca entidades (o alguno de sus derivados) que cumplan con un parámetro de búsqueda.
        /// </summary>
        /// <param name="p_mod_entidad">modelo con variable a buscar inicializada con algún valor</param>
        /// <param name="p_paramentroBusqueda">Constante dentro de LibreriaClasesCompartidas.Constantes.ParametrosBusqueda</param>
        /// <returns>Lista de modeloEntidad (o alguno de sus derivados)</returns>
        public static List<ModeloEntidad> buscar(ModeloEntidad p_mod_entidad, string p_paramentroBusqueda)
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
        /// <summary>
        /// Busca personas que cumplan con un parámetro de búsqueda.
        /// </summary>
        /// <param name="p_mod_persona">Persona con variable a buscar inicializada con algún valor</param>
        /// <param name="p_paramentroBusqueda">Constante dentro de LibreriaClasesCompartidas.Constantes.ParametrosBusqueda</param>
        /// <returns>Lista de personas</returns>
        public static List<ModeloPersonas> buscar(ModeloPersonas p_mod_persona, string p_paramentroBusqueda)
        {
            CatalogoPersonas lcl_cat_personas = new CatalogoPersonas();

            return lcl_cat_personas.buscarPersonas(p_mod_persona, p_paramentroBusqueda);
        }
        public static List<ModeloCliente> buscar(ModeloCliente p_mod_cliente, string p_paramentroBusqueda)
        {
            CatalogoClientes lcl_cat_clientes = new CatalogoClientes();
            return lcl_cat_clientes.buscarCliente(p_mod_cliente,p_paramentroBusqueda);
        }
        public static List<ModeloUsuario> buscar(ModeloUsuario p_mod_usuario, string p_paramentroBusqueda)
        {
            CatalogoUsuarios lcl_cat_usuarios = new CatalogoUsuarios();
            return lcl_cat_usuarios.buscarUsuario(p_mod_usuario, p_paramentroBusqueda);
        }
        public static List<ModeloContactoProveedor> buscar(ModeloContactoProveedor p_mod_contactoProveedor, string p_paramentroBusqueda)
        {
            CatalogoContactoProveedores lcl_cat_contactosProveedores = new CatalogoContactoProveedores();
            return lcl_cat_contactosProveedores.buscarContactoProveedor(p_mod_contactoProveedor, p_paramentroBusqueda);
        }
        /// <summary>
        /// Busca proveedores que cumplan con un parámetro de búsqueda
        /// </summary>
        /// <param name="p_mod_proveedor">Proveedor con variable a buscar inicializada con algún valor</param>
        /// <param name="p_paramentroBusqueda">Constante dentro de LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Proveedores</param>
        /// <returns>Lista de proveedores</returns>
        public static List<ModeloProveedor> buscar(ModeloProveedor p_mod_proveedor, string p_paramentroBusqueda)
        {
            CatalogoProveedores lcl_cat_proveedores = new CatalogoProveedores();

            return lcl_cat_proveedores.buscarProveedor(p_mod_proveedor, p_paramentroBusqueda);
        }
        /// <summary>
        /// Busca articulos que cumplan con un parámetro de búsqueda
        /// </summary>
        /// <param name="p_mod_articulo">Articulo con variable a buscar inicializada con algún valor</param>
        /// <param name="p_paramentroBusqueda">Constante dentro de LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Articulos</param>
        /// <returns>Lista de artículos</returns>
        public static List<ModeloArticulos> buscar(ModeloArticulos p_mod_articulo, string p_paramentroBusqueda)
        {
            CatalogoArticulos lcl_cat_articulos = new CatalogoArticulos();

            return lcl_cat_articulos.buscar(p_mod_articulo, p_paramentroBusqueda);
        }
        /// <summary>
        /// Busca artículos de proveedores que cumplan con un parámetro de búsqueda
        /// </summary>
        /// <param name="p_mod_articuloProveedores">Proveedor con variable a buscar inicializada con algún valor</param>
        /// <param name="p_paramentroBusqueda">Constante dentro de LibreriaClasesCompartidas.Constantes.ParametrosBusqueda</param>
        /// <returns>Lista de artículos de proveedores</returns>
        public static List<ModeloArticuloProveedores> buscar(ModeloArticuloProveedores p_mod_articuloProveedores, string p_paramentroBusqueda)
        {
            CatalogoArticuloProveedores lcl_cat_articulosProveedores = new CatalogoArticuloProveedores();
            switch (p_paramentroBusqueda)
            {
                case Constantes.ParametrosBusqueda.ArticulosProveedores.Descripcion:
                    return ControladorBusqueda.buscarArticuloProveedor_descripcionArticulo(p_mod_articuloProveedores);
                default:
                    return lcl_cat_articulosProveedores.buscar(p_mod_articuloProveedores, p_paramentroBusqueda);
            }
        }
        /// <summary>
        /// Busca articuloProveedor por descripción de Articulo. Habría que hacerlo en el catálogo
        /// </summary>
        /// <param name="p_mod_articuloProveedores"></param>
        /// <returns></returns>
        private static List<ModeloArticuloProveedores> buscarArticuloProveedor_descripcionArticulo(ModeloArticuloProveedores p_mod_articuloProveedores)
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
            foreach (ModeloArticulos a in ControladorBusqueda.buscar(lcl_mod_articulo, Constantes.ParametrosBusqueda.Articulos.Descripcion))
            {
                lcl_mod_articuloProveedor.codigoOriginal = a.codigoOriginal;
                foreach (ModeloArticuloProveedores ap in ControladorBusqueda.buscar(lcl_mod_articuloProveedor, Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoOriginal))
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
        /// <summary>
        /// Busca articulos que cumplan con un parámetro de búsqueda
        /// </summary>
        /// <param name="p_mod_pedido">Pedido con variable a buscar inicializada con algún valor</param>
        /// <param name="p_paramentroBusqueda">Constante dentro de LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Pedidos</param>
        /// <returns>Lista de pedidos</returns>
        public static List<ModeloPedido> buscar(ModeloPedido p_mod_pedido, string p_paramentroBusqueda)
        {
            CatalogoPedidos lcl_cat_articulos = new CatalogoPedidos();

            return lcl_cat_articulos.buscarPedido(p_mod_pedido, p_paramentroBusqueda);
        }
        /// <summary>
        /// Busca líneas pedidos que cumplan con un parámetro de búsqueda
        /// </summary>
        /// <param name="p_mod_lineaPedido">Línea pedido con variable a buscar inicializada con algún valor</param>
        /// <param name="p_paramentroBusqueda">Constante dentro de LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.LineasPedidos</param>
        /// <returns>Lista de líneas pedidos</returns>
        public static List<ModeloLineaPedido> buscar(ModeloLineaPedido p_mod_lineaPedido, string p_paramentroBusqueda)
        {
            CatalogoLineasPedidos lcl_cat_articulos = new CatalogoLineasPedidos();

            return lcl_cat_articulos.buscarLineasPedido(p_mod_lineaPedido, p_paramentroBusqueda);
        }
        public static List<ModeloRoles> buscar(ModeloRoles p_mod_rol, string p_parametroBusqueda)
        {
            CatalogoRoles lcl_cat_roles = new CatalogoRoles();

            return lcl_cat_roles.buscar(p_mod_rol, p_parametroBusqueda);
        }
        #endregion

        #region getOne(object,parametroBusqueda)
        //Como buscar(object,parametroBusqueda), pero en vez de una lista devuelve un solo objeto
        public static ModeloEntidad getOne(ModeloEntidad p_mod_entidad, string p_parametroBusqueda)
        {
            List<ModeloEntidad> lcl_lst_mod_entidad = ControladorBusqueda.buscar(p_mod_entidad, p_parametroBusqueda);
            if (lcl_lst_mod_entidad.Count > 0)
            {
                return lcl_lst_mod_entidad[0];
            }
            else
            {
                return null;
            }
        }
        public static ModeloPersonas getOne(ModeloPersonas p_mod_persona, string p_parametroBusqueda)
        {
            List<ModeloPersonas> lcl_lst_mod_personas = ControladorBusqueda.buscar(p_mod_persona, p_parametroBusqueda);
            if (lcl_lst_mod_personas.Count > 0)
            {
                return lcl_lst_mod_personas[0];
            }
            else
            {
                return null;
            }
        }
        public static ModeloCliente getOne(ModeloCliente p_mod_cliente, string p_parametroBusqueda)
        {
            List<ModeloCliente> lcl_lst_mod_clientes = ControladorBusqueda.buscar(p_mod_cliente, p_parametroBusqueda);
            if (lcl_lst_mod_clientes.Count > 0)
            {
                return lcl_lst_mod_clientes[0];
            }
            else
            {
                return null;
            }
        }
        public static ModeloUsuario getOne(ModeloUsuario p_mod_usuario, string p_parametroBusqueda)
        {
            List<ModeloUsuario> lcl_lst_mod_usuarios = ControladorBusqueda.buscar(p_mod_usuario, p_parametroBusqueda);
            if (lcl_lst_mod_usuarios.Count > 0)
            {
                return lcl_lst_mod_usuarios[0];
            }
            else
            {
                return null;
            }
        }
        public static ModeloProveedor getOne(ModeloProveedor p_mod_proveedor, string p_parametroBusqueda)
        {
            List<ModeloProveedor> lcl_lst_mod_proveedores = ControladorBusqueda.buscar(p_mod_proveedor, p_parametroBusqueda);
            if (lcl_lst_mod_proveedores.Count > 0)
            {
                return lcl_lst_mod_proveedores[0];
            }
            else
            {
                return null;
            }
        }
        public static ModeloArticuloProveedores getOne(ModeloArticuloProveedores p_mod_articuloProveedor, string p_parametroBusqueda)
        {
            List<ModeloArticuloProveedores> lcl_lst_mod_articuloProveedor = ControladorBusqueda.buscar(p_mod_articuloProveedor, p_parametroBusqueda);
            if (lcl_lst_mod_articuloProveedor.Count > 0)
            {
                return lcl_lst_mod_articuloProveedor[0];
            }
            else
            {
                return null;
            }
        }
        public static ModeloPedido getOne(ModeloPedido p_mod_pedido, string p_parametroBusqueda)
        {
            List<ModeloPedido> lcl_lst_mod_pedidos = ControladorBusqueda.buscar(p_mod_pedido, p_parametroBusqueda);
            if (lcl_lst_mod_pedidos.Count > 0)
            {
                return lcl_lst_mod_pedidos[0];
            }
            else
            {
                return null;
            }
        }

        #endregion


        #region Sin uso?

        #region Provincia
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
        public List<ModeloPedido> getPedidos()
        {
            CatalogoPedidos lcl_cat_articulos = new CatalogoPedidos();

            return lcl_cat_articulos.buscarPedido(null, Constantes.ParametrosBusqueda.All);
        }
        #endregion
       
        #region LineasPedido
        /// <summary>
        /// Retorna todos las líneas pedidos de la base de datos
        /// </summary>
        /// <returns>Lista de líneas pedidos</returns>
        public List<ModeloLineaPedido> getLineasPedido()
        {
            CatalogoLineasPedidos lcl_cat_articulos = new CatalogoLineasPedidos();

            return lcl_cat_articulos.buscarLineasPedido(null, Constantes.ParametrosBusqueda.All);
        }
        public static List<ModeloDescuentoArticuloProveedor> getDescuentos(string p_codigoOriginal, string p_codigoArticuloProveedor)
        {
            CatalogoDescuentos lcl_cat_descuentos = new CatalogoDescuentos();
            List<ModeloDescuentoArticuloProveedor> lcl_lst_mod_descuento = new List<ModeloDescuentoArticuloProveedor>();
            lcl_lst_mod_descuento= lcl_cat_descuentos.buscarDescuentos(p_codigoOriginal, p_codigoArticuloProveedor);
            return lcl_lst_mod_descuento;

        }

        public static List<ModeloDescuentoArticuloProveedor> getDescuentosVigentes(DateTime p_fecha)
        {
            CatalogoDescuentos lcl_cat_descuentos = new CatalogoDescuentos();
            List<ModeloDescuentoArticuloProveedor> lcl_lst_mod_descuento = new List<ModeloDescuentoArticuloProveedor>();
            lcl_lst_mod_descuento = lcl_cat_descuentos.buscarDescuentosVigentes(p_fecha);
            return lcl_lst_mod_descuento;

        }

        public static ModeloDescuentoArticuloProveedor getDescuentoArticuloVigente(List<ModeloDescuentoArticuloProveedor> p_lst_mod_descuentoArticulo, DateTime p_fechaPedido)
        {
            ModeloDescuentoArticuloProveedor lcl_mod_descuentoArticulo = new ModeloDescuentoArticuloProveedor();
            foreach (ModeloDescuentoArticuloProveedor md in p_lst_mod_descuentoArticulo)
            {
                if (md.fechaVigenciaDesde <= p_fechaPedido && md.fechaVigenciaHasta >= p_fechaPedido)
                {
                    lcl_mod_descuentoArticulo = md;
                }
            }
            return lcl_mod_descuentoArticulo;
        
        }

        #endregion
        #region Roles
        /// <summary>
        /// Retorna roles en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="p_mod_rol"></param>
        /// <returns>Lista de provincias</returns>
        public List<ModeloRoles> buscar(ModeloRoles p_mod_rol)
        {
            CatalogoRoles lcl_cat_roles = new CatalogoRoles();

            return lcl_cat_roles.buscar(p_mod_rol, Constantes.ParametrosBusqueda.Any);
        }
        #endregion
        
        #endregion
    }
}
