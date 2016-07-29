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
            this.Descripcion = p_lineaPedido.articulo.descripcion;
            this.PrecioUnitario = p_lineaPedido.valorUnitario;
            this.Precio = p_lineaPedido.valorParcial;
            this.Descuento = p_lineaPedido.descuentoTotalMonto;
        }
    }
}
