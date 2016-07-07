using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;
using Reportes;
using Vista;
using System.Windows;
using LibreriaClasesCompartidas;

namespace Controladores
{
    public class ControladorReportes
    {
        public static CatalogoProveedores glb_con_proveedores = new CatalogoProveedores();
        public static CatalogoPedidos glb_con_pedidos = new CatalogoPedidos();
        public static CatalogoArticuloProveedores glb_cat_artP = new CatalogoArticuloProveedores();
        public static List<ModeloPedido> glb_lst_mod_pedidos = new List<ModeloPedido>();
        decimal glb_var_MaxMontoTotal = 0;
        decimal glb_var_MontoTotalProveedor = 0;
        int glb_var_CantidadTotalArticulos = 0;
        public ModeloReportePedidoEntreFechas glb_mod_pedidoentrefechas = new ModeloReportePedidoEntreFechas();
        public ModeloReporteVentaEntreFechas glb_mod_ventaentrefechas = new ModeloReporteVentaEntreFechas();
        public ModeloReporteTop10Articulos glb_mod_Top10Articulos = new ModeloReporteTop10Articulos();


        public string crearReporte(String[] p_var_razonSocial, DateTime p_date_fechaInicio, DateTime p_date_fechaFin)
        {
            string lcl_var_respuesta="";
            
            if (String.Equals(p_var_razonSocial, "") == false && (p_date_fechaFin > p_date_fechaInicio || p_date_fechaFin <= DateTime.Today))
            {
                glb_lst_mod_pedidos = glb_con_pedidos.getPedidos("Pedido a proveedor");
                
                foreach (string RSocial in p_var_razonSocial)
                {
                    foreach (ModeloPedido lcl_mod_pedido in glb_lst_mod_pedidos) 
                    {
                        ModeloProveedor lcl_mod_proveedor = new ModeloProveedor();
                        lcl_mod_proveedor = glb_con_pedidos.getProveedorPedido(lcl_mod_pedido.numeroPedido);
                        if (lcl_mod_proveedor.razonSocial == RSocial)
                        {
                            if (Convert.ToDateTime(lcl_mod_pedido.fecha) >= p_date_fechaInicio && Convert.ToDateTime(lcl_mod_pedido.fecha) <= p_date_fechaFin)
                            {
                                glb_var_MaxMontoTotal = (lcl_mod_pedido.montoTotal>glb_var_MaxMontoTotal)? lcl_mod_pedido.montoTotal : glb_var_MaxMontoTotal ;
                                glb_var_MontoTotalProveedor = glb_var_MontoTotalProveedor + lcl_mod_pedido.montoTotal;
                                foreach (ModeloLineaPedido lcl_mod_lineapedido in lcl_mod_pedido.lineasPedido)
                                {
                                    glb_var_CantidadTotalArticulos = glb_var_CantidadTotalArticulos + lcl_mod_lineapedido.cantidadArticulos;
                                }
                            }

                        }

                    }

                }
                /*Hecho para un solo proveedor*/
                string detalleProveedores = p_var_razonSocial + Convert.ToString(glb_var_MontoTotalProveedor) + Convert.ToString(glb_var_MaxMontoTotal) + Convert.ToString(glb_var_CantidadTotalArticulos);
                lcl_var_respuesta = "Fecha Inicio:" + Convert.ToString(p_date_fechaInicio) + "Fecha Fin:" + Convert.ToString(p_date_fechaFin) + detalleProveedores;
            }
            else
            {
                if (String.Equals(p_var_razonSocial, ""))
                {
                    lcl_var_respuesta = "Debe seleccionar al menos 1 proveedor";
                }
                else
                {
                    lcl_var_respuesta = "Fechas no válidas";
                }
            }
        return lcl_var_respuesta;
        }

        public List<string> iniciarReporte()
        {
            List<string> lcl_var_respuesta = null;
            List<ModeloProveedor> lcl_mod_proveedor = glb_con_proveedores.getAll();

            foreach(ModeloProveedor prov in lcl_mod_proveedor)
            {
                string proveedor = prov.cuit + ", " + prov.razonSocial;
                lcl_var_respuesta.Add(proveedor);
            }

            return lcl_var_respuesta;
        }

        public FormReportes ReportePedidoEntreFechas(DateTime p_fechaInicio, DateTime p_fechaFin, int p_codProveedor) 
        {
            ModeloReporteEncabezado lcl_mod_ReporteEncabezado = new ModeloReporteEncabezado();
            if (p_codProveedor == 0)// indica que son todos los proveedores
            {
                lcl_mod_ReporteEncabezado = glb_con_pedidos.getPedidosEntreFechas(p_fechaInicio, p_fechaFin);
            }
            else
            {
                lcl_mod_ReporteEncabezado = glb_con_pedidos.getPedidosEntreFechas(p_fechaInicio, p_fechaFin, p_codProveedor);
            }
             FormReportes lcl_frm_reporte = new FormReportes(lcl_mod_ReporteEncabezado,"PedidoEntreFechas");
                                   
            return lcl_frm_reporte;
        
        }
        public FormReportes ReporteVentaEntreFechas(DateTime p_fechaInicio, DateTime p_fechaFin, int p_codCliente)
        {
            ModeloReporteEncabezado lcl_mod_ReporteEncabezado = new ModeloReporteEncabezado();
            if (p_codCliente == 0)// indica que son todos los clientes
            {
                lcl_mod_ReporteEncabezado = glb_con_pedidos.getVentaEntreFechas(p_fechaInicio, p_fechaFin);
            }
            else
            {
                lcl_mod_ReporteEncabezado = glb_con_pedidos.getVentaEntreFechas(p_fechaInicio, p_fechaFin, p_codCliente);
            }
            FormReportes lcl_frm_reporte = new FormReportes(lcl_mod_ReporteEncabezado, "VentaEntreFechas");

            return lcl_frm_reporte;



        }

        public FormReportes ReporteTop10Articulos(DateTime p_fechaInicio, DateTime p_fechaFin)
        {
            ModeloReporteEncabezado lcl_mod_ReporteEncabezadoTop10Articulos = new ModeloReporteEncabezado();

            lcl_mod_ReporteEncabezadoTop10Articulos = glb_con_pedidos.getTop10Articulos(p_fechaInicio, p_fechaFin);

            FormReportes lcl_frm_reporte = new FormReportes(lcl_mod_ReporteEncabezadoTop10Articulos,"Top 10 Articulos");

            return lcl_frm_reporte;
            

        }
        public FormReportes ReporteEmitePedido(ModeloPedido p_modeloPedido, ModeloPersonas p_modeloPersona)
        {

            FormReportes lcl_frm_reporte = new FormReportes(p_modeloPedido, p_modeloPersona);

            return lcl_frm_reporte;
            

        }

        public FormReportes StockInventario()
        {
            List<ModeloArticuloProveedores> lcl_lst_mod_artP = new List<ModeloArticuloProveedores>();
            ModeloArticuloProveedores lcl_mod_artP = new ModeloArticuloProveedores();
            ControladorPedido lcl_con_ped = new ControladorPedido();
            int Cantidad = lcl_con_ped.buscarArticulos("descripcionArticuloProveedor", "%");
            lcl_lst_mod_artP = lcl_con_ped.resultadoBusquedaArticulosProveedores;
            //lcl_lst_mod_artP=glb_cat_artP.buscar(lcl_mod_artP,Constantes.ParametrosBusqueda.ArticulosProveedores.Descripcion);
            FormReportes lcl_frm_reporte = new FormReportes(lcl_lst_mod_artP);
            return lcl_frm_reporte;
        }

        public FormReportes DescuentosVigentes(DateTime p_fecha)
        {
            List<ModeloDescuentoArticulo> lcl_lst_mod_descA = new List<ModeloDescuentoArticulo>();

            ControladorDescuento lcl_con_des = new ControladorDescuento();
            lcl_lst_mod_descA = lcl_con_des.buscarDescuentosVigentes(p_fecha);
            //Pasar descipcion y precio al modelodescuentoArticulo
            List<ModeloArticuloProveedores> lcl_lst_mod_artP = new List<ModeloArticuloProveedores>();
            ControladorPedido lcl_con_ped = new ControladorPedido();
            int Cantidad = lcl_con_ped.buscarArticulos("descripcionArticuloProveedor", "%");
            lcl_lst_mod_artP = lcl_con_ped.resultadoBusquedaArticulosProveedores;
            foreach (ModeloArticuloProveedores modArtP in lcl_lst_mod_artP)
            {
                foreach (ModeloDescuentoArticulo modDes in lcl_lst_mod_descA)
                {
                    if (modArtP.codigoArticuloProveedor == modDes.CodigoArticuloProveedor && modArtP.codigoOriginal == modDes.CodigoOriginal)
                    {
                        modDes.descripcionArticulo = modArtP.descripcionArticuloProveedor;
                        modDes.precioVenta = (decimal)modArtP.valorVenta.valorArticulo;
                    }
                }
            }
            

            FormReportes lcl_frm_reporte = new FormReportes(lcl_lst_mod_descA);
            return lcl_frm_reporte;
        }

        public frmImpresionFactura ImpresionFacturas(ModeloPedido p_mod_pedido)
        {

            frmImpresionFactura lcl_frm_factura = new frmImpresionFactura(this.CompletaEntidadFactura(p_mod_pedido), p_mod_pedido.tipoComprobante.ToString());
            return lcl_frm_factura;
        }
        public frmImpresionLoteFacturas ImpresionLoteFacturas(List<ModeloPedido> p_lst_mod_pedidos)
        {
            List<ModeloReporteEncabezadoFactura> lcl_lst_mod_EncFac = new List<ModeloReporteEncabezadoFactura>();
            foreach (ModeloPedido modPed in p_lst_mod_pedidos)
            {
                ModeloReporteEncabezadoFactura lcl_mod_encFac = new ModeloReporteEncabezadoFactura();
                lcl_mod_encFac = this.CompletaEntidadFactura(modPed);
                
                lcl_lst_mod_EncFac.Add(lcl_mod_encFac);
            }

            frmImpresionLoteFactura lcl_frm_factura = new frmImpresionLoteFactura(lcl_lst_mod_EncFac, p_mod_pedido.tipoComprobante.ToString());
            return lcl_frm_factura;
        }
        public bool ComprobanteAprobado(ModeloPedido p_mod_pedido)
        {
            if (p_mod_pedido.aprobadoAFIP == "SI")
            { return true; }
            else { return false; } 
        }

        private ModeloReporteEncabezadoFactura CompletaEntidadFactura(ModeloPedido p_mod_pedido)
        {
            // Carga en modelo Reportepedido Que hacemos si no esta aprobado, donde validamos?
            ModeloReporteEncabezadoFactura lcl_mod_Factura = new ModeloReporteEncabezadoFactura();
            lcl_mod_Factura.detalleFactura = new List<ModeloReporteDetalleFactura>();
            lcl_mod_Factura.CAINumero = p_mod_pedido.CAE;
            lcl_mod_Factura.Alicuota = Convert.ToDecimal(p_mod_pedido.alicuota.iva.porcentaje);
            lcl_mod_Factura.CentroEmisor = "0001";//p_mod_pedido.numeroComprobante;
            lcl_mod_Factura.NumeroComprobante = p_mod_pedido.numeroComprobante;
            lcl_mod_Factura.Comprador_Cuit = p_mod_pedido.entidad.cuit;
            //lcl_mod_Factura.Comprador_IVAResponsableI = p_mod_pedido.documentoComprador.tipo.descripcion;
            if (p_mod_pedido.domicilioDeFacturacion==null)
            { lcl_mod_Factura.Comprador_Domicilio = ""; }
            else
            {
                lcl_mod_Factura.Comprador_Domicilio = p_mod_pedido.domicilioDeFacturacion.calle + " " +
                    p_mod_pedido.domicilioDeFacturacion.numero + ", " +
                    p_mod_pedido.domicilioDeFacturacion.ciudad + ", " +
                    p_mod_pedido.domicilioDeFacturacion.provincia;
            }
            lcl_mod_Factura.Comprador_RazonSocial = p_mod_pedido.entidad.ToString();
            //lcl_mod_Factura.ConceptosNoGravados = p_mod_pedido.
            lcl_mod_Factura.CondicionVenta = p_mod_pedido.formasDePago[0].forma.ToString();
            for (int i=0;i<p_mod_pedido.lineasPedido.Count;i++)
            {
                ModeloReporteDetalleFactura lcl_mod_detalle = new ModeloReporteDetalleFactura();
                lcl_mod_detalle.Cantidad=p_mod_pedido.lineasPedido[i].cantidadArticulos;
                lcl_mod_detalle.CodigoArticulo = p_mod_pedido.lineasPedido[i].articulo.codigoArticuloProveedor;
                lcl_mod_detalle.Descripcion = p_mod_pedido.lineasPedido[i].articulo.descripcion;
                lcl_mod_detalle.PrecioUnitario = p_mod_pedido.lineasPedido[i].valorUnitario;
                lcl_mod_detalle.Precio = p_mod_pedido.lineasPedido[i].valorParcial;
                lcl_mod_detalle.Descuento = p_mod_pedido.lineasPedido[i].getDescuento();

                lcl_mod_Factura.detalleFactura.Add(lcl_mod_detalle);
            }
            
            lcl_mod_Factura.FechaComprobante = p_mod_pedido.fecha;
            //lcl_mod_Factura.FechaVencimiento = p_mod_pedido.//tiene fecha Vto?
            lcl_mod_Factura.IVAComprobante = p_mod_pedido.alicuota.monto;
            lcl_mod_Factura.Remito = p_mod_pedido.numeroPedido.ToString();
            lcl_mod_Factura.SubtotalComprobante = p_mod_pedido.montoSubTotal;
            lcl_mod_Factura.TotalComprobante = p_mod_pedido.montoTotal;
            
            return lcl_mod_Factura;
        }
        
    }
}
