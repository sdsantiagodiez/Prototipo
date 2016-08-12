using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;
using System.Windows;
using LibreriaClasesCompartidas;

namespace Controladores
{
    public class ControladorReportes
    {
        public ModeloReporteEncabezado getEncabezado(Constantes.Reportes.Clientes p_reporte, List<DateTime> p_periodo, ModeloCliente p_cliente, int p_cantidad)
        {
            CatalogoPedidos lcl_cat_pedidos = new CatalogoPedidos();

            return lcl_cat_pedidos.getReporte(p_reporte, p_periodo, p_cliente, p_cantidad);
        }

        public ModeloReporteEncabezado getEncabezado(Constantes.Reportes.Proveedores p_reporte, List<DateTime> p_periodo, ModeloProveedor p_proveedor, int p_cantidad)
        {
            CatalogoPedidos lcl_cat_pedidos = new CatalogoPedidos();

            return lcl_cat_pedidos.getReporte(p_reporte, p_periodo, p_proveedor, p_cantidad);
        }

        public ModeloReporteEncabezado getEncabezado(Constantes.Reportes.Articulos p_reporte, List<DateTime> p_periodo, int p_cantidad)
        {
            CatalogoPedidos lcl_cat_pedidos = new CatalogoPedidos();
            switch (p_reporte)
            {
                case Constantes.Reportes.Articulos.ArticulosMasVendidos:
                    return lcl_cat_pedidos.getReporte(p_reporte,p_periodo,p_cantidad);
                case Constantes.Reportes.Articulos.DescuentosVigentes:
                    return this.getReporteDescuentosVigentes(DateTime.Today);
                case Constantes.Reportes.Articulos.InformeStock:
                    return this.getReporteStock();
                default:
                    return null;
            }
        }

        private ModeloReporteEncabezado getReporteDescuentosVigentes(DateTime p_fechaVigencia)
        {
            ModeloReporteEncabezado lcl_mod_reporteEncabezado = new ModeloReporteEncabezado();
            
            ModeloDescuento lcl_mod_descuentoAP;
            foreach (ModeloArticuloProveedores ap in ControladorBusqueda.getArticulosProveedores())
            {
                lcl_mod_descuentoAP = new ModeloDescuento();    //modeloDescuento en vez de ModeloDescuentoArticuloProveedor????
                lcl_mod_descuentoAP = ap.getDescuentoVigente(p_fechaVigencia);
                if (lcl_mod_descuentoAP != null)
                {
                    lcl_mod_reporteEncabezado.detalleArticulosDescuentos.Add(new ModeloReporteDetalle_ArticulosDescuentos(ap, lcl_mod_descuentoAP));
                }
            }
            return lcl_mod_reporteEncabezado;
        }
        private ModeloReporteEncabezado getReporteStock()
        {
            ModeloReporteEncabezado lcl_mod_reporteEncabezado = new ModeloReporteEncabezado();
            
            foreach (ModeloArticuloProveedores ap in ControladorBusqueda.getArticulosProveedores())
            {
                lcl_mod_reporteEncabezado.detalleArticulosDescuentos.Add(new ModeloReporteDetalle_ArticulosDescuentos(ap));
            }

            return lcl_mod_reporteEncabezado;
        }
    }
}
