using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class ModeloPedidoArtProv
    {
        public int nroPedido { get; set; }
        public string codigoArProveedor { get; set; }
        public string codigoOriginalAr { get; set; }
        public int cantidadArticulos { get; set; }
        public float valorParcial { get; set; }

    }
}
