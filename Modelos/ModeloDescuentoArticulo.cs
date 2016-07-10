using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
     [Serializable]
    public class ModeloDescuentoArticulo : Modelo 
    {
        public string CodigoArticuloProveedor { get; set; }
        public string CodigoOriginal {get;set;}
        public string descripcionArticulo { get;set; }
        public decimal precioVenta { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public int numeroDescuento { get; set; }
        public decimal descuentoSobreTotal { get; set; }

    }
}
