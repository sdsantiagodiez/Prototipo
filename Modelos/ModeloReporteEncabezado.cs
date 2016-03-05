using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
   public class ModeloReporteEncabezado
    {
       public DateTime FechaInforme { get; set; }
       public DateTime FechaDesde { get; set; }
       public DateTime FechaHasta { get; set; }
       public string PersonaDesde { get; set; }
       public string PersonaHasta { get; set; }
       public List<ModeloReportePedidoEntreFechas> detallePedido { get; set; }
       public List<ModeloReporteVentaEntreFechas> detalleVenta { get; set; }
       public List<ModeloReporteTop10Articulos> detalleArticulos { get; set; }
       public decimal MontoTotal { get; set; }
    }
}
