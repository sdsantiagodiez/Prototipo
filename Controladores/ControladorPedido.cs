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
    public class ControladorPedido : Controlador
    {
        #region Atributos
        //funciones a programar
        //buscarReserva

        public List<ModeloArticuloProveedores> resultadoBusquedaArticulosProveedores;
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
        /// <summary>
        /// Busca artículos proveedores y retorna cantidad encontrada
        /// </summary>
        /// <param name="p_categoriaBusquedaSeleccionada"></param>
        /// <param name="p_descripcionParcialArticulo"></param>
        /// <returns></returns>
        public int buscarArticulos(string p_categoriaBusquedaSeleccionada, string p_descripcionParcialArticulo)
        {
            var lcl_mod_ArticuloProveedor = new ModeloArticuloProveedores();
            switch (p_categoriaBusquedaSeleccionada)
            {
                case Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoOriginal:
                    lcl_mod_ArticuloProveedor.codigoOriginal = p_descripcionParcialArticulo; break;

                case Constantes.ParametrosBusqueda.ArticulosProveedores.DescripcionArticuloProveedor:
                    p_categoriaBusquedaSeleccionada = LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.ArticulosProveedores.DescripcionAmbas;
                    lcl_mod_ArticuloProveedor.descripcionArticuloProveedor = p_descripcionParcialArticulo; break;

                case Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoArticuloProveedor:
                    lcl_mod_ArticuloProveedor.codigoArticuloProveedor = p_descripcionParcialArticulo; break;
                default:
                    return 0;
            }

            resultadoBusquedaArticulosProveedores = ControladorBusqueda.buscar(lcl_mod_ArticuloProveedor, p_categoriaBusquedaSeleccionada);
            return resultadoBusquedaArticulosProveedores.Count;
        }

        public ModeloArticuloProveedores getArticuloBusqueda(int p_indice)
        {
            return resultadoBusquedaArticulosProveedores[p_indice];
        }
        #endregion

        public virtual bool iniciarDevolucion(ModeloPedido p_pedido)
        {
            return false;
        }
        public virtual bool validarIniciarDevolucion(ModeloPedido p_pedido)
        {
            return false;
        }
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

        public virtual bool guardarPedido()
        {
            ControladorAlta lcl_con_alta = new ControladorAlta();
            
            if (!lcl_con_alta.agregar(_pedidoActual))
            {
                errorActual = lcl_con_alta.errorActual;
                return false;
            }

            return true;
        }
        public string getTotal()
        {
            this.pedidoActual.getTotal();
            return this.pedidoActual.montoTotal.ToString("0.##");
        }
        public string getSubTotal()
        {
            this.pedidoActual.getSubTotal();
            return this.pedidoActual.montoSubTotal.ToString("0.##");
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
        public virtual void removeLineaPedido(ModeloLineaPedido p_lineaPedido)
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
        public virtual void updateLineaPedido(ModeloLineaPedido p_lineaPedido)
        {
            this.pedidoActual.updateLineaPedido(p_lineaPedido);
        }
        public static string getNombreComprobante(int codigoComprobante)
        {
            switch (codigoComprobante)
            {
                case 1:
                    return "Factura A";
                case 2:
                    return "Nota de Débito A";
                case 3:
                    return "Nota de Crédito A";
                case 4:
                    return "Recibo A";
                case 5:
                    return "Nota de Venta al Contado A";
                case 6:
                    return "Factura B";
                case 7:
                    return "Nota de Débito B";
                case 8:
                    return "Nota de Crédito B";
                case 9:
                    return "Recibo B";
                case 10:
                    return "Nota de Venta al Contado B";
                case 88:
                    return "Remito Electrónico";
                case (int)Constantes.TipoComprobanteCompra.Pedido_Proveedor:
                    return Constantes.TipoComprobanteCompra.Pedido_Proveedor.GetDescription();
                case (int)Constantes.TipoComprobanteVenta.Presupuesto:
                    return Constantes.TipoComprobanteVenta.Presupuesto.GetDescription();
                case (int)Constantes.TipoComprobanteVenta.Reserva:
                    return Constantes.TipoComprobanteVenta.Reserva.GetDescription();
                default:
                    return "Otro";
            }
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

        public ControladorPedidoProveedor() : base(Constantes.CodigosTiposPedidos.Proveedor)
        {
            pedidosProveedores = new List<ModeloPedido>();
            pedidosProveedores.Add(this.getPedidoGlobal());
            //Cada pedido se identifica por el proveedor
        }

        public override void removeLineaPedido(ModeloLineaPedido p_lineaPedido)
        {
            bool esPedidoGlobal = pedidoActual.Equals(pedidosProveedores[0]);
            
            base.removeLineaPedido(p_lineaPedido);
            
            this.getPedidosProveedores(esPedidoGlobal? pedidoActual: getPedidoGlobal());
        }
        public override void updateLineaPedido(ModeloLineaPedido p_lineaPedido)
        {
            bool esPedidoGlobal = pedidoActual.entidad.Equals(pedidosProveedores[0].entidad);

            base.updateLineaPedido(p_lineaPedido);

            this.getPedidosProveedores(esPedidoGlobal ? pedidoActual : getPedidoGlobal());
        }
      

        /// <summary>
        /// Retorna multiples pedidos (e inicializa propiedad pedidosProveedores) de acuerdo al proveedor de cada articulo en las lineas de pedido
        /// </summary>
        /// <param name="p_mod_pedido"></param>
        /// <returns></returns>
        public List<ModeloPedido> getPedidosProveedores(ModeloPedido p_mod_pedido)
        {
            List<ModeloPedido> lcl_lst_mod_pedidos = new List<ModeloPedido>();
            
            bool lineaAgregada= false;
            foreach (ModeloLineaPedido lp in p_mod_pedido.lineasPedido)
            {
                lineaAgregada = false;
                foreach (ModeloPedido pedido in lcl_lst_mod_pedidos)
                {
                    if (lp.articulo.codigoEntidad == pedido.entidad.codigo)
                    {
                        //Se agrega linea al pedido que tenga como entidad al proveedor del articulo proveedor y se marca la bandera
                        pedido.lineasPedido.Add(lp);
                        lineaAgregada = true;   
                        break;
                    }
                }

                if (!lineaAgregada)
                {
                    ModeloEntidad p_mod_entidadAuxiliar = new ModeloProveedor();
                    p_mod_entidadAuxiliar.codigo = lp.articulo.codigoEntidad;
                    //Se crea pedido con proveedor como entidad del pedido 
                    ModeloPedido p_mod_pedidoAuxiliar = new ModeloPedido(ControladorBusqueda.getOne(p_mod_entidadAuxiliar, Constantes.ParametrosBusqueda.One));
                    p_mod_pedidoAuxiliar.lineasPedido.Add(lp);

                    lcl_lst_mod_pedidos.Add(p_mod_pedidoAuxiliar);
                }
            }
            this.pedidosProveedores = lcl_lst_mod_pedidos;
            foreach (ModeloPedido p in this.pedidosProveedores)
            {
                p.actualizarMontos();
            }
            
            this.pedidosProveedores.Insert(0, new ModeloPedido());
            this.pedidosProveedores[0] = this.getPedidoGlobal();
            return lcl_lst_mod_pedidos;
        }

        public ModeloPedido getPedidoGlobal()
        {
            ModeloPedido lcl_mod_pedidoGlobalProveedores = new ModeloPedido() { codigoTipoPedido = Constantes.CodigosTiposPedidos.Proveedor};
            if (pedidosProveedores.Count > 0)
            {
                //Si es mayor a 0, puede que el pedido global ya se le haya asignado alguna forma de pago. Si es menor a 0, todavia no se asigno
                lcl_mod_pedidoGlobalProveedores.formasDePago = pedidosProveedores[0].formasDePago ;
            }
            
            
            for (int i = 1; i < pedidosProveedores.Count;i++ )
            {
                lcl_mod_pedidoGlobalProveedores.addLineaPedidoList(pedidosProveedores[i].lineasPedido);
            }
            return lcl_mod_pedidoGlobalProveedores;
        }

        public bool guardarPedidos()
        {
            List<object> lcl_lst_pedidos_a_guardar = new List<object>();
            //obviamos el indice 0 porque ahí estan todos los pedidos
            for(int i=1;i < pedidosProveedores.Count; i++)
            {
                pedidosProveedores[i].actualizarMontos();
                pedidosProveedores[i].formasDePago = pedidosProveedores[0].formasDePago;
                lcl_lst_pedidos_a_guardar.Add(pedidosProveedores[i]);
            }
            ControladorAlta lcl_con_alta = new ControladorAlta();
            return lcl_con_alta.agregar(lcl_lst_pedidos_a_guardar);
        }
        public int getIndice(ModeloPedido p_pedido)
        {
            int indice = 0;
            for (int i = 0; i < pedidosProveedores.Count; i++)
            {
                if (p_pedido.entidad.Equals(pedidosProveedores[i].entidad))
                {
                    indice = i;
                    break;
                }
            }
            
            return indice;
        }
    }
    public class ControladorPedidoCliente : ControladorPedido
    {
        private ModeloPedido _pedidoDevuelto;
        public ModeloPedido pedidoDevuelto
        {
            get { return _pedidoDevuelto; }
            set { _pedidoDevuelto = value; }
        }

        public ControladorPedidoCliente() : base(Constantes.CodigosTiposPedidos.Persona)
        {
 
        }

        #region Métodos
        #region Devolución
        public override bool guardarPedido()
        {
            if (!base.guardarPedido())
            {
                return false;
            }
            
            if (pedidoActual.tipoComprobante == 3 || pedidoActual.tipoComprobante == 8)
            {
                ControladorAlta lcl_con_alta = new ControladorAlta();
                if (!lcl_con_alta.agregarDevolucion(pedidoActual, pedidoDevuelto))
                {
                    errorActual = lcl_con_alta.errorActual;
                    return false;
                }
            }

            return true;

        }
        public override bool iniciarDevolucion(ModeloPedido p_pedido)
        {
            if (!this.validarIniciarDevolucion(p_pedido))
            {
                return false;
            }

            pedidoDevuelto = p_pedido;

            return true;
        }
        public override bool validarIniciarDevolucion(ModeloPedido p_pedido)
        {
            if (p_pedido.tipoComprobante == 3 || p_pedido.tipoComprobante == 8)
            {
                //no se permite devolución de un comprobante de Nota de crédito
                return false;
            }
            //Si el pedido todavía no tiene devolución correspondiente, retorna null el método del catálogo
            return (new CatalogoPedidos().getDevolucionDePedido(p_pedido) == null) ? true : false;
        }
        #endregion

        #region Facturación AFIP
        /// <summary>
        /// Devuelvo codigoTipoComprobante de AFIP de acuerdo a los parámetros
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
                //case Constantes.TipoComprobanteVenta.NotaDebito:
                //    codigoTipoComprobante = p_codigoTipoResponsable == 1 ? 2 : 7; //2=A,7=B
                //    break;
                //case Constantes.TipoComprobanteVenta.NotaCredito:
                //    codigoTipoComprobante = p_codigoTipoResponsable == 1 ? 3 : 8; //3=A,8=B
                //    break;
                //case Constantes.TipoComprobanteVenta.Recibo:
                //    codigoTipoComprobante = p_codigoTipoResponsable == 1 ? 4 : 9; //4=A,9=B
                //    break;
                //case Constantes.TipoComprobanteVenta.NotaVentaAlContado:
                //    codigoTipoComprobante = p_codigoTipoResponsable == 1 ? 5 : 10; //5=A,10=B
                //    break;
                default :
                    codigoTipoComprobante = (int)p_tipoComprobante;
                    break;
            }
            return codigoTipoComprobante;
        }
        /// <summary>
        /// Devuelvo codigoTipoComprobante de AFIP de acuerdo a los parámetros
        /// </summary>
        /// <param name="p_tipoComprobante"></param>
        /// <param name="p_codigoTipoResponsable"></param>
        /// <returns></returns>
        public static int getCodigoComprobante(Constantes.TipoComprobanteDevolucion p_tipoComprobante, int p_codigoTipoResponsable)
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
                //case Constantes.TipoComprobanteDevolucion.NotaDebito:
                //    codigoTipoComprobante = p_codigoTipoResponsable == 1 ? 2 : 7; //2=A,7=B
                //    break;
                case Constantes.TipoComprobanteDevolucion.NotaCredito:
                    codigoTipoComprobante = p_codigoTipoResponsable == 1 ? 3 : 8; //3=A,8=B
                    break;
                default:
                    codigoTipoComprobante = 0;//No se asigna. No hay código para tal (presupuesto, reserva, otro)
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
            if (pedidoActual.aprobadoAFIP == "A")
            {
                errorActual = "El pedido ya esta aprobado por AFIP.";
                return false;
            }
            if (pedidoActual.tipoComprobante != 0)
            {
                try
                {
                    ControladorAFIP lcl_con_AFIP = new ControladorAFIP();
                    if (!lcl_con_AFIP.validarConexion())
                    {
                        this.errorActual = lcl_con_AFIP.errorActual;
                        return false;
                    } 
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
       
        #region Cliente Genérico
        public void asignarClienteGenerico()
        {
            ModeloCliente lcl_mod_cliente = new ModeloCliente();
            lcl_mod_cliente.codigo = CatalogoPedidos.codigoClienteGenerico;
            pedidoActual.entidad = lcl_mod_cliente;
        }
        public bool esClienteGenerico()
        {
            return this.pedidoActual.entidad.codigo == CatalogoPedidos.codigoClienteGenerico ||
                this.pedidoActual.entidad.codigo == 0;

        }
        public static bool esClienteGenerico(ModeloCliente p_mod_cliente)
        {
            if (p_mod_cliente == null)
            {
                return true;
            }
            return p_mod_cliente.codigo == CatalogoPedidos.codigoClienteGenerico ||
                p_mod_cliente.codigo == 0;
        }
        #endregion

        #endregion
    }
}
