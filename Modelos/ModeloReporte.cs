using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloReporte
    {
        public ModeloReporteEncabezado encabezado { get; set; }
        public List<ModeloReporteDetalle> detalle { get; set; }

        public ModeloReporte()
        {
            
        }
    }

    public class ModeloReporteEncabezado
    {
        public DateTime FechaInforme { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public string PersonaDesde { get; set; }
        public string PersonaHasta { get; set; }
        
        public List<ModeloReporteDetalle_Pedidos> detallePedido { get; set; }
        public List<ModeloReporteDetalle_Articulos> detalleArticulos { get; set; }
        public List<ModeloReporteDetalle_ArticulosDescuentos> detalleArticulosDescuentos { get; set; }
        public List<ModeloPedido> pedidos { get; set; }
        public decimal MontoTotal { get; set; }

        public ModeloReporteEncabezado()
        {
            detalleArticulos = new List<ModeloReporteDetalle_Articulos>();
            detallePedido = new List<ModeloReporteDetalle_Pedidos>();
            detalleArticulosDescuentos = new List<ModeloReporteDetalle_ArticulosDescuentos>();
			pedidos = new List<ModeloPedido>();
        }
    }

    public class ModeloReporteDetalle
    {
 
    }
    /// <summary>
    /// Detalle de pedidos entre fechas de proveedores y clientes
    /// </summary>
    public class ModeloReporteDetalle_Pedidos : ModeloReporteDetalle
    {
        public int codigoEntidad { get; set; }
        public string descripcionEntidad { get; set; }
        public int cantidadPedidos { get; set; }
        public int cantidadArticulos { get; set; }
        public decimal montoTotal { get; set; }
    }

    public class ModeloReporteDetalle_Articulos : ModeloReporteDetalle
    {
        public string codigoArticulo { get; set; }
        public int cantidadArticulos { get; set; }
        public decimal precioPromedioVenta { get; set; }
        public int cantidadDeVentas { get; set; }
        //public DateTime FechaDesde { get; set; }
        //public DateTime FechaHasta { get; set; }
        public decimal MontoTotal { get; set; }
    }

    public class ModeloReporteDetalle_ArticulosDescuentos : ModeloReporteDetalle
    {
        public string codigoArticulo { get; set; }
        public string codigoArticuloProveedor { get; set; }
        public string descripcionArticulo { get; set; }
        public string descripcionArticuloProveedor { get; set; }
        public int stockActual { get; set; }
        public decimal descuento { get; set; }
        public DateTime fechaVigenciaDescuento_Desde { get; set; }
        public DateTime fechaVigenciaDescuento_Hasta { get; set; }
        public decimal valorVentaSinDescuento { get; set; }
        public decimal valorVentaConDescuento { get { return valorVentaSinDescuento - (valorVentaSinDescuento*descuento); } }

        public ModeloReporteDetalle_ArticulosDescuentos(ModeloArticuloProveedores p_articuloProveedor)
        {
            codigoArticulo = p_articuloProveedor.codigoOriginal;
            codigoArticuloProveedor = p_articuloProveedor.codigoArticuloProveedor;
            descripcionArticulo = p_articuloProveedor.getDescripciones();
            stockActual = p_articuloProveedor.stockActual ?? default(int);
            descuento = (p_articuloProveedor.getDescuentoVigente() != null) ? p_articuloProveedor.getDescuentoVigente().porcentaje : 0;
            valorVentaSinDescuento = p_articuloProveedor.valorVenta.valorArticulo ?? default(decimal);

        }
        public ModeloReporteDetalle_ArticulosDescuentos(ModeloArticuloProveedores p_articuloProveedor, ModeloDescuento p_descuento):this(p_articuloProveedor)
        {
            descuento = p_descuento.porcentaje;
            //fechaVigenciaDescuento_Desde = 
            //fechaVigenciaDescuento_Hasta = 
            valorVentaSinDescuento = p_articuloProveedor.valorVenta.valorArticulo ?? default(decimal);
        }
        
    }
}
