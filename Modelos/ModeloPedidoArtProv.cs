﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloPedidoArtProv
    {
        public int nroPedido { get; set; }
        public string codigoArProveedor { get; set; }
        public string codigoOriginalAr { get; set; }
        public int cantidadArticulos { get; set; }
        public float valorParcial { get; set; }

        public void inicializar()
        { 
        /*Pendiente de crear lineas de pedido*/
        }

    }
}
