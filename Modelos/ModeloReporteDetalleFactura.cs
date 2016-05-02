using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloReporteDetalleFactura
    {
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public string CodigoArticulo { get; set; }
        public decimal Precio { get; set; }
        public decimal PrecioUnitario { get; set; }

    }
}
