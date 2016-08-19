using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloReporteDetalleComprobante
    {
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public string CodigoArticulo { get; set; }
        public decimal Precio { get; set; }
        public decimal Descuento { get; set; }
        public decimal PrecioUnitario { get; set; }

        public ModeloReporteDetalleComprobante(ModeloLineaPedido p_lineaPedido)
        {
            this.Cantidad = p_lineaPedido.cantidadArticulos;
            this.CodigoArticulo = p_lineaPedido.articulo.codigoArticuloProveedor;
            this.Descripcion = p_lineaPedido.articulo.descripcionArticuloProveedor;
            this.PrecioUnitario = p_lineaPedido.valorUnitario;
            this.Precio = p_lineaPedido.valorParcial;
            this.Descuento = p_lineaPedido.descuentoTotalMonto;
        }

        //public ModeloReporteDetalleComprobante(ModeloArticuloProveedores p_articuloProveedorDescuento,ModeloDescuentoLineaPedido p_descuentoLP)
        //{
        //    Descripcion = "Descuento de " + p_descuentoLP.porcentaje.ToString() + "en " + p_articuloProveedorDescuento.descripcion;
        //    Cantidad = 1;
        //    CodigoArticulo = p_articuloProveedorDescuento.codigoArticuloProveedor;
        //    Precio = -p_descuentoLP.montoTotal;
        //    PrecioUnitario = p_descuentoLP.montoTotal;
        //}
    }
}
