using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;

namespace Controlador
{
    public class ControladorPedidoProveedor:Controlador
    {
        public string agregarArticulo(string tipoCodigo, string codArtProv, int cantidad)
        {
            
            CatalogoArticuloProveedores cap = new CatalogoArticuloProveedores();
            ModeloArticuloProveedores ap = new ModeloArticuloProveedores();

            ap = cap.buscarArticuloProveedor(tipoCodigo, codArtProv)[0];

            /*Inicializar la linea de Pedido con El articulo de proveedor y la cantidad*/

            /*Agregar la linea de Pedido al pedido Actual que lo deberia tener el mismo controlador*/


            return "El se ha agregado un articulo al pedido";
        }
    }
}
