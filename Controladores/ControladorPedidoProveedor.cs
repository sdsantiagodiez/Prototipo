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

        CatalogoArticuloProveedores cap = new CatalogoArticuloProveedores();
        
        public string agregarArticulo(string ptipoCodigo, string pcodArtProv, int pcantidad)
        {
            
           
            ModeloArticuloProveedores ap = new ModeloArticuloProveedores();

            ap = cap.buscarArticuloProveedor(ptipoCodigo, pcodArtProv)[0];

            /*Inicializar la linea de Pedido con El articulo de proveedor y la cantidad*/

            /*Agregar la linea de Pedido al pedido Actual que lo deberia tener el mismo controlador*/


            return "El se ha agregado un articulo al pedido";
        }

        public List<string[]> buscarArticulosProveedor(string ptipoCodigo, string pRazonSocial)
        {
            List<ModeloArticuloProveedores> apActuales = new List<ModeloArticuloProveedores>();

            List<string[]> respuesta = new List<string[]>();

            apActuales = cap.buscarArticuloProveedor(ptipoCodigo, pRazonSocial);

            foreach (ModeloArticuloProveedores ModArtProv in apActuales)
            {
                string[] artipro = { ModArtProv.codigoOriginalArt, ModArtProv.codigoArProveedor,ModArtProv.descripArPro, ModArtProv.stockActualArPro.ToString(), ModArtProv.stockMinimoArPro.ToString(), ModArtProv.fechaUltimaActualizacionArPro.ToShortDateString()};

                respuesta.Add(artipro);
            }

            return respuesta;
        }

        public void crearPedido()
        {
            ModeloPedidoArtProv pActual = new ModeloPedidoArtProv();            
        
        }


    
    }
}
