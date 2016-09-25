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
            CatalogoDescuentoArticuloProveedores lcl_cat_descuentosAP = new CatalogoDescuentoArticuloProveedores();
            return lcl_cat_descuentosAP.getDescuentoBase();
            //List<int> lst_porcentajes = new List<int>() { 5, 10, 15, 20, 25, 30, 40, 50, 60, 70, 80 };
            //List<ModeloDescuento> lcl_lst_DescuentosBase = new List<ModeloDescuento>();
            //int codigo = 1;
            //foreach (int i in lst_porcentajes)
            //{
            //    lcl_lst_DescuentosBase.Add(new ModeloDescuento()
            //    {
            //        codigoDescuento = codigo,
            //        porcentaje = Convert.ToDecimal(i) / 100,
            //        descripcion = i.ToString() + " %"
            //    });
            //    codigo++;
            //}
            //return lcl_lst_DescuentosBase;
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
        public static List<ModeloPedido> buscar(ModeloPedido p_mod_pedido)
        {//sin uso
            CatalogoPedidos lcl_cat_articulos = new CatalogoPedidos();

            return lcl_cat_articulos.buscarPedido(p_mod_pedido, Constantes.ParametrosBusqueda.Any);
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

        public static List<ModeloPedido> buscar(ModeloPedido p_mod_pedido, List<DateTime> p_periodo, List<Constantes.TipoComprobanteCompra> p_tipoCompra,
                                        List<Constantes.TipoComprobanteVenta> p_tipoVenta, List<Constantes.TipoComprobanteDevolucion> p_tipoDevolucion,
                                        List<Constantes.TipoPedido> p_tipoPedido, bool? p_facturadoElectronicamente)
        {
            var temp_entidad = p_mod_pedido.entidad;//se copia a una variable temporal porque tipoPedido tiene un constructor que si se activa elimina los valores que habia en entidad
            bool? clienteGenerico = ControladorBusqueda.getTipoPedido(p_tipoPedido, p_mod_pedido);
            
            List<int> lcl_lst_codigosComprobantes = ControladorBusqueda.getCodigosComprobantes(p_tipoCompra, p_tipoVenta, p_tipoDevolucion);
            p_mod_pedido.entidad = temp_entidad;
            return new CatalogoPedidos().buscar(p_mod_pedido, p_periodo, lcl_lst_codigosComprobantes, clienteGenerico, p_facturadoElectronicamente);
        }

        private static List<int> getCodigosComprobantes(List<Constantes.TipoComprobanteCompra> p_tipoCompra, List<Constantes.TipoComprobanteVenta> p_tipoVenta, List<Constantes.TipoComprobanteDevolucion> p_tipoDevolucion)
        {
            List<int> lcl_lst_codigosComprobantes = new List<int>();

            foreach (var item in p_tipoCompra)
            {
                if ((int)item >= 1000)
                {
                    lcl_lst_codigosComprobantes.Add((int)item);
                }
            }

            foreach (var item in p_tipoVenta)
            {
                if ((int)item < 1000)
                {
                    lcl_lst_codigosComprobantes.Add(ControladorPedidoCliente.getCodigoComprobante(item, 1));//Responsable inscripto
                    lcl_lst_codigosComprobantes.Add(ControladorPedidoCliente.getCodigoComprobante(item, 2));//Responsable inscripto
                }
                else
                {
                    lcl_lst_codigosComprobantes.Add((int)item);
                }
            }

            foreach (var item in p_tipoDevolucion)
            {
                lcl_lst_codigosComprobantes.Add(ControladorPedidoCliente.getCodigoComprobante(item, 1));//Responsable inscripto
                lcl_lst_codigosComprobantes.Add(ControladorPedidoCliente.getCodigoComprobante(item, 2));//Responsable inscripto
            }

            return lcl_lst_codigosComprobantes.Distinct().ToList(); //remueve items repetidos y deja uno, los 0 para aquellos codigos de comprobante que no se facturan por afip
        }
        /// <summary>
        /// Inicializa codigoTipoPedido en pedido pasado como parámetro y devuelve si se considera cliente genérico
        /// </summary>
        /// <param name="p_tipoPedido"></param>
        /// <param name="p_mod_pedido"></param>
        /// <returns>Genérico: null -> no se considera; true -> solo genéricos; false -> excluye genéricos</returns>
        private static bool? getTipoPedido(List<Constantes.TipoPedido> p_tipoPedido, ModeloPedido p_mod_pedido)
        {
            bool? generico = null;
            if (p_tipoPedido.Count >= 3 || p_tipoPedido.Count <= 0)
            {
                generico = null;
                p_mod_pedido.codigoTipoPedido = 0;
            }
            else if (p_tipoPedido.Contains(Constantes.TipoPedido.PedidoCliente) && p_tipoPedido.Contains(Constantes.TipoPedido.PedidoClienteGenerico))
            {//2 seleccionados
                generico = null;
                p_mod_pedido.codigoTipoPedido = Constantes.CodigosTiposPedidos.Persona;
            }
            else 
            {//entra cuando hay 1 o 2 tiposPedidos seleccionados
                
                foreach (Constantes.TipoPedido p in p_tipoPedido)
                {
                    if (p.Equals(Constantes.TipoPedido.PedidoProveedor)
                        && p_mod_pedido.codigoTipoPedido == 0)
                    {
                        p_mod_pedido.codigoTipoPedido = Constantes.CodigosTiposPedidos.Proveedor;

                    }
                    else if ((p.Equals(Constantes.TipoPedido.PedidoCliente) || p.Equals(Constantes.TipoPedido.PedidoClienteGenerico))
                        && (p_mod_pedido.codigoTipoPedido == 0 || p_mod_pedido.codigoTipoPedido == Constantes.CodigosTiposPedidos.Persona))
                    {
                        p_mod_pedido.codigoTipoPedido = Constantes.CodigosTiposPedidos.Persona;
                        generico = p.Equals(Constantes.TipoPedido.PedidoClienteGenerico);
                    }
                    else
                    {
                        p_mod_pedido.codigoTipoPedido = 0;
                    }
                    
                }
            }

            return generico;
        }
    }
}
