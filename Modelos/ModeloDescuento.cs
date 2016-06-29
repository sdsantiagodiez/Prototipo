using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloDescuento : Modelo 
    {
        public string CodigoArticuloProveedor { get; set; }
        public string CodigoOriginal {get;set;}
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public int numeroDescuento { get; set; }

    }
}
