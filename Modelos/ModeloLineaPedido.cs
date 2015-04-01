using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloLineaPedido
    {
        public string codigoArProveedor { get; set; }
        public string codigoOriginalAr { get; set; }
        public int cantidadArticulos { get; set; }
        public float valorParcial { get; set; }

        public ModeloLineaPedido()
        { }

        public ModeloLineaPedido(ModeloArticuloProveedores pModArtProv, int pCantidad)
        {
            this.codigoArProveedor = pModArtProv.codigoArProveedor;
            this.codigoOriginalAr = pModArtProv.codigoOriginalArt;
            this.cantidadArticulos = pCantidad;
            /* this.valorParcial = */ //Deberiamos agregarle el valor Parcial

        }

    }
}
