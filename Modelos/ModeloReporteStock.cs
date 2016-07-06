using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloReporteStock
    {
        public string codigoArticulo { get; set; }
        public string descripcionArticulo { get; set; }
        public int stockActual { get; set; }
        public decimal descuento { get; set; }
        public DateTime fDesde_descuento { get; set; }
        public DateTime fHasta_descuento { get; set; }
        public decimal precioVenta { get; set; }


    }
}
