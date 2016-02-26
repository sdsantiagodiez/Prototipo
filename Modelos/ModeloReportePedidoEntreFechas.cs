using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloReportePedidoEntreFechas
    {
        public String razonSocial { get; set; }
        public String codProveedor { get; set; }
        public int CantidadPedidos { get; set; }
        public int CantidadArticulos { get; set; }
        public decimal MontoTotal { get; set; }
    }
}
