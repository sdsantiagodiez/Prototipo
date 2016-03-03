using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloReporteTop10Articulos
    {
        public string codigoArticulo { get; set; }
        public int cantidadArticulos { get; set; }
        public decimal precioPromedioVenta { get; set; }
        public int cantidadDeVentas { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public decimal MontoTotal { get; set; }
    }
}
