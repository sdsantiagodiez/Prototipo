using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using LibreriaClasesCompartidas;

namespace Controladores
{
    public class ControladorPedido : Controlador
    {
        #region Atributos
        //funciones a programar
        //buscarReserva

        public List<ModeloArticuloProveedores> resultadoBusqueda;
        public Constantes.CodigosTiposPedidos tipoPedido
        {
            get { return pedidoActual.codigoTipoPedido; }
        }
        
        private ModeloPedido _pedidoActual;
        public ModeloPedido pedidoActual
        {
            get { return _pedidoActual; }
            set { _pedidoActual = value; }
        }

        public ModeloEntidad entidadActual
        {
            get { return this.pedidoActual.entidad; }
            set { this.pedidoActual.entidad = value; }
        }
        #endregion

        #region Constructores
        public ControladorPedido()
        {
            this.pedidoActual = new ModeloPedido();
        }

        public ControladorPedido(Constantes.CodigosTiposPedidos p_codigo) : this()
        {
            this.pedidoActual.codigoTipoPedido = p_codigo;
        }
        #endregion

        #region Métodos
        #region Búsqueda
        public int buscarArticulos(string p_categoriaBusquedaSeleccionada, string p_descripcionParcialArticulo)
        {
            var lcl_mod_ArticuloProveedor = new ModeloArticuloProveedores();
            switch (p_categoriaBusquedaSeleccionada)
            {
                case Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoOriginal:
                    lcl_mod_ArticuloProveedor.codigoOriginal = p_descripcionParcialArticulo; break;

                case Constantes.ParametrosBusqueda.ArticulosProveedores.DescripcionArticuloProveedor:
                    lcl_mod_ArticuloProveedor.descripcionArticuloProveedor = p_descripcionParcialArticulo; break;

                case Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoArticuloProveedor:
                    lcl_mod_ArticuloProveedor.codigoArticuloProveedor = p_descripcionParcialArticulo; break;
                default:
                    return 0;
            }

            resultadoBusqueda = ControladorBusqueda.buscar(lcl_mod_ArticuloProveedor, p_categoriaBusquedaSeleccionada);
            return resultadoBusqueda.Count;
        }
        public void buscarCliente(string p_dni)
        {
            ModeloCliente lcl_mod_cliente = new ModeloCliente();
            lcl_mod_cliente.dni = p_dni;
            entidadActual = ControladorBusqueda.buscar(lcl_mod_cliente, Constantes.ParametrosBusqueda.Entidades.Personas.Dni)[0];
        }

        public ModeloArticuloProveedores getArticuloBusqueda(int p_indice)
        {
            return resultadoBusqueda[p_indice];
        }

        public ModeloLineaPedido getArticulo(int p_indice)
        {
            return pedidoActual.lineasPedido[p_indice];
        }
        #endregion

        public void addArticulo(ModeloArticuloProveedores p_articulo, Int32 p_cantidad)
        {
            //le cambio el formato  y lo agrego a la lista de articulos ya seleccionados
            ModeloLineaPedido lcl_mod_nuevaLinea = new ModeloLineaPedido(p_articulo, p_cantidad,this.tipoPedido);
            this.pedidoActual.addLineaPedido(lcl_mod_nuevaLinea);
        }
        public void addCliente(ModeloPersonas p_nuevoCliente)
        {
            //CatalogoPersonas lcl_cat_personas = new CatalogoPersonas();
            //lcl_cat_personas.add(ref p_nuevoCliente);
            //CAMBIOS
        }

        public void cerrarPedido()
        {
            ControladorModificacion lcl_con_modificacion = new ControladorModificacion();
            ModeloArticuloProveedores lcl_mod_articuloProveedores = new ModeloArticuloProveedores();

            foreach (ModeloLineaPedido lcl_mod_linea in pedidoActual.lineasPedido)
            {
                lcl_mod_articuloProveedores.codigoOriginal = lcl_mod_linea.articulo.codigoOriginal;
                lcl_mod_articuloProveedores.codigoArticuloProveedor = lcl_mod_linea.articulo.codigoArticuloProveedor;

                lcl_mod_articuloProveedores = ControladorBusqueda.buscar(lcl_mod_articuloProveedores, Constantes.ParametrosBusqueda.One)[0]; 
                lcl_mod_articuloProveedores.stockActual = lcl_mod_articuloProveedores.stockActual - lcl_mod_linea.cantidadArticulos;
                lcl_con_modificacion.modificar(lcl_mod_articuloProveedores);
            }

            //calcular lo que falta calcular(como total)
            //guardar lineas
            //guardar pedido
        }
        public void deleteCurrentDetails()
        {
            this.pedidoActual.removeAllLineaPedido();
        }
        public bool exists(ModeloArticuloProveedores p_articulo)
        {
            return this.pedidoActual.existeLineaPedido(p_articulo);
        }
       

        public int getCantidadLineas()
        {
            return pedidoActual.lineasPedido.Count;
        }
        public string getTotal()
        {
            return this.pedidoActual.getTotal().ToString("0.##");
        }
        public void removeLineaPedido(ModeloLineaPedido p_lineaPedido)
        {
            this.pedidoActual.removeLineaPedido(p_lineaPedido);
        }
        #endregion
    }

    public class ControladorPedidoProveedor : ControladorPedido
    {
        List<ModeloPedido> _pedidosProveedores;
        public List<ModeloPedido> pedidosProveedores
        {
            get { return _pedidosProveedores; }
            set { this._pedidosProveedores = value; }
        }

        public ControladorPedidoProveedor() : base(Constantes.CodigosTiposPedidos.TipoPedidoProveedor)
        {
            //Cada pedido se identifica por el proveedor
        }
        
        /// <summary>
        /// Retorna multiples pedidos (e inicializa propiedad pedidosProveedores) de acuerdo al proveedor de cada articulo en las lineas de pedido
        /// </summary>
        /// <param name="p_mod_pedido"></param>
        /// <returns></returns>
        public List<ModeloPedido> getPedidosProveedores(ModeloPedido p_mod_pedido)
        {
            List<ModeloPedido> p_lst_mod_pedidos = new List<ModeloPedido>();

            bool lineaAgregada= false;
            foreach (ModeloLineaPedido linea in p_mod_pedido.lineasPedido)
            {
                lineaAgregada = false;
                foreach(ModeloPedido pedido in p_lst_mod_pedidos)
                {
                    if (linea.articulo.codigoEntidad == pedido.entidad.codigo)
                    {
                        //Se agrega linea al pedido que tenga como entidad al proveedor del articulo proveedor y se marca la bandera
                        pedido.lineasPedido.Add(linea);
                        lineaAgregada = true;   
                        break;
                    }
                }

                if (!lineaAgregada)
                {
                    ModeloEntidad p_mod_entidadAuxiliar = new ModeloProveedor();
                    p_mod_entidadAuxiliar.codigo = linea.articulo.codigoEntidad;
                    //Se crea pedido con proveedor como entidad del pedido 
                    ModeloPedido p_mod_pedidoAuxiliar = new ModeloPedido(ControladorBusqueda.buscar(p_mod_entidadAuxiliar, Constantes.ParametrosBusqueda.One)[0]);
                    p_mod_pedidoAuxiliar.lineasPedido.Add(linea);
                    
                    p_lst_mod_pedidos.Add(p_mod_pedidoAuxiliar);
                }
            }

            this.pedidosProveedores = p_lst_mod_pedidos;
            return p_lst_mod_pedidos;
        }
 
    }
    public class ControladorPedidoCliente : ControladorPedido
    {
        public ControladorPedidoCliente() : base(Constantes.CodigosTiposPedidos.TipoPedidoPersona)
        {
 
        }
 
    }
}
