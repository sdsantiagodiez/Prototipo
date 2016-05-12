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

namespace Controladores
{
    public class ControladorReportes
    {
        public static CatalogoProveedores glb_con_proveedores = new CatalogoProveedores();
        public static CatalogoPedidos glb_con_pedidos = new CatalogoPedidos();
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

        public frmImpresionFactura ImpresionFacturas(ModeloReporteEncabezadoFactura p_modEncabezado, string tipoComprobante)
        {
            frmImpresionFactura lcl_frm_factura = new frmImpresionFactura(p_modEncabezado, tipoComprobante);
            return lcl_frm_factura;
        }
         
        
    }
}
