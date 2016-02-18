using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloReportePedidoEncabezado
    {
        DateTime FechaReporte;
        DateTime FechaDesde;
        DateTime FechaHasta;
        string PersonaDesde;
        string PersonaHasta;
        List<ModeloReportePedidoEntreFechas> detallePedido = new List<ModeloReportePedidoEntreFechas>();
        List<ModeloReporteVentaEntreFechas> detalleVenta = new List<ModeloReporteVentaEntreFechas>();



    }
}
