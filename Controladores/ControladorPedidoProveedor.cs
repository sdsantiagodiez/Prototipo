using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;

namespace Controladores
{
    public class ControladorPedidoProveedor: Controlador
    {

        CatalogoArticuloProveedores cap = new CatalogoArticuloProveedores();

        ModeloPedidoArtProv pActual = new ModeloPedidoArtProv();
        public string agregarArticulo(string ptipoCodigo, string pcodArtProv, int pcantidad)
        {
            
           
            ModeloArticuloProveedores ap = new ModeloArticuloProveedores();

            ap = cap.buscarArticuloProveedor(ptipoCodigo, pcodArtProv)[0];

            ModeloLineaPedido lp = new ModeloLineaPedido(ap, pcantidad);

            pActual.agregarLinea(lp);

            return "El se ha agregado un articulo al pedido actual";
        }

        public List<string[]> buscarArticulosProveedor(string ptipoCodigo, string pRazonSocial)
        {
            List<ModeloArticuloProveedores> apActuales = new List<ModeloArticuloProveedores>();

            List<string[]> respuesta = new List<string[]>();

            apActuales = cap.buscarArticuloProveedor(ptipoCodigo, pRazonSocial);

            foreach (ModeloArticuloProveedores ModArtProv in apActuales)
            {
                string[] artipro = { ModArtProv.codigoOriginalArt, ModArtProv.codigoArtProveedor,ModArtProv.descripArtPro, ModArtProv.stockActualArtPro.ToString(), ModArtProv.stockMinimoArtPro.ToString(), ModArtProv.fechaUltimaActualizacionArtPro.ToShortDateString()};

                respuesta.Add(artipro);
            }

            return respuesta;
        }

        public void crearPedido()
        {
            ModeloPedidoArtProv pActual = new ModeloPedidoArtProv();            
        
        }

        public void modificarCantidadArticulo(string pCodArtProv, int pCant)
        { 
            if(pCant>0)
            {
                ModeloLineaPedido linea = pActual.buscarLinea(pCodArtProv);
                
                int Cantidad = linea.cantidadArticulos;

                if (pCant >= Cantidad)
                {
                    pActual.bajaLinea(linea);
                }
                else
                {
                    linea.cantidadArticulos = (Cantidad-pCant);
                    pActual.actualizaLinea(linea);
                    
                }


            }
        
        }

    
    }
}
