using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloReporteVentaEntreFechas
    {
        public int codigo_cliente { get; set;}
        public string nombre_cliente { get; set; }
        public int cantidad_ventas { get; set; }
        public int cantidad_articulos { get; set; }
        public float monto_ventas { get; set; }


    }
}
