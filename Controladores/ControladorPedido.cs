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
            entidadActual = ControladorBusqueda.buscar(new ModeloCliente(){dni=p_dni}, Constantes.ParametrosBusqueda.Entidades.Personas.Dni)[0];
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

        private bool validarFormaDePago()
        {
            if (this.pedidoActual.formasDePago.Count == 1)
            {
                this.pedidoActual.formasDePago[0].monto = this.pedidoActual.montoTotal;
                return true;
            }

            decimal total = new decimal();
            foreach (FormaPago fp in this.pedidoActual.formasDePago)
            {
                total += fp.monto;
            }
            if (total != this.pedidoActual.montoTotal)
            {
                return false;
                //mensaje de error que debe revisar las formas de pago
            }
            return true;
        }

        //public bool cerrarPedido()
        //{
            
        //    return true;
        //}
        public bool guardarPedido()
        {
            ControladorAlta lcl_con_alta = new ControladorAlta();
            
            if (!lcl_con_alta.agregar(ref _pedidoActual))
            {
                errorActual = lcl_con_alta.errorActual;
                return false;
            }

            return true;
        }
        public string getTotal()
        {
            return this.pedidoActual.montoTotal.ToString("0.##");
        }

        public void addArticulo(ModeloArticuloProveedores p_articulo, Int32 p_cantidad)
        {
            //le cambio el formato  y lo agrego a la lista de articulos ya seleccionados
            ModeloLineaPedido lcl_mod_nuevaLinea = new ModeloLineaPedido(p_articulo, p_cantidad, this.tipoPedido);
            this.pedidoActual.addLineaPedido(lcl_mod_nuevaLinea);
        }
        public bool exists(ModeloArticuloProveedores p_articulo)
        {
            return this.pedidoActual.existeLineaPedido(p_articulo);
        }

        public int getCantidadLineas()
        {
            return pedidoActual.lineasPedido.Count;
        }
        /// <summary>
        /// Remueve la seleccionada
        /// </summary>
        /// <param name="p_lineaPedido"></param>
        public void removeLineaPedido(ModeloLineaPedido p_lineaPedido)
        {
            this.pedidoActual.removeLineaPedido(p_lineaPedido);
        }
        /// <summary>
        /// Remueve todas
        /// </summary>
        public void removeLineasPedidos()
        {
            this.pedidoActual.removeAllLineaPedido();
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

        #region Métodos
        
        #region Facturación AFIP
        /// <summary>
        /// Devuelvo codigoTipoComprobante de AFIP de acuerdo a los parámetros. Considera que Vendedor es Responsable Inscripto
        /// </summary>
        /// <param name="p_tipoComprobante"></param>
        /// <param name="p_codigoTipoResponsable"></param>
        /// <returns></returns>
        public static int getCodigoComprobante(Constantes.TipoComprobanteVenta p_tipoComprobante,int p_codigoTipoResponsable)
        {
            #region codigos tipo responsable
            ///1	IVA Responsable Inscripto
            ///2	IVA Responsable no Inscripto
            ///3	IVA no Responsable
            ///4	IVA Sujeto Exento
            ///5	Consumidor Final
            ///6	Responsable Monotributo
            ///7	Sujeto no Categorizado
            ///8	Proveedor del Exterior
            ///9	Cliente del Exterior
            //10    IVA Liberado – Ley Nº 19.640
            //11    IVA Responsable Inscripto – Agente de Percepción
            //12    Pequeño Contribuyente Eventual
            //13	Monotributista Social
            //14	Pequeño Contribuyente Eventual Social
            #endregion

            int codigoTipoComprobante;
            switch (p_tipoComprobante)
            {
                case Constantes.TipoComprobanteVenta.Factura:
                    codigoTipoComprobante = p_codigoTipoResponsable == 1 ? 1 : 6; //1=A,6=B
                    break;
                case Constantes.TipoComprobanteVenta.NotaDebito:
                    codigoTipoComprobante = p_codigoTipoResponsable == 1 ? 2 : 7; //2=A,7=B
                    break;
                case Constantes.TipoComprobanteVenta.NotaCredito:
                    codigoTipoComprobante = p_codigoTipoResponsable == 1 ? 3 : 8; //3=A,8=B
                    break;
                case Constantes.TipoComprobanteVenta.Recibo:
                    codigoTipoComprobante = p_codigoTipoResponsable == 1 ? 4 : 9; //4=A,9=B
                    break;
                case Constantes.TipoComprobanteVenta.NotaVentaAlContado:
                    codigoTipoComprobante = p_codigoTipoResponsable == 1 ? 5 : 10; //5=A,10=B
                    break;
                default :
                    codigoTipoComprobante = 0;//No se asigna. No hay código para tal
                    break;
            }
            return codigoTipoComprobante;
        }

        public bool verificarConexionAFIP()
        {
            ControladorAFIP lcl_con_AFIP = new ControladorAFIP();
            return lcl_con_AFIP.validarConexion();
        }
        /// <summary>
        /// Hace facturación electrónica. Si Comprobante no corresponde a facturación, devuelve true
        /// </summary>
        /// <returns></returns>
        public bool facturarAFIP()
        {
            if (pedidoActual.tipoComprobante != 0)
            {
                try
                {
                    ControladorAFIP lcl_con_AFIP = new ControladorAFIP();
                    if (!lcl_con_AFIP.facturar(pedidoActual))
                    {
                        errorActual = lcl_con_AFIP.errorActual;
                        return false;
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    errorActual = ex.Message;
                    return false;
                }
            }
            return false;
        }
        #endregion

        public void addCliente(ModeloCliente p_nuevoCliente)
        {
            //CatalogoPersonas lcl_cat_personas = new CatalogoPersonas();
            //lcl_cat_personas.add(ref p_nuevoCliente);
            //CAMBIOS
        }
        public void asignarClienteGenerico()
        {
            //codigo cliente genérico actual 106242
            //cuando se haga de nuevo la base, cambiar a algo más representativo como el 100000 o algo
            ModeloCliente lcl_mod_cliente = new ModeloCliente();
            lcl_mod_cliente.codigo = 106242;
            pedidoActual.entidad = lcl_mod_cliente;
        }
        #endregion
    }
}
