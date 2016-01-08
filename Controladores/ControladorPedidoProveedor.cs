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

        private ModeloPedido pActual;
        private List<ModeloLineaPedido> artPedidoActual;
       

        public void crearPedido()
        {
            pActual = new ModeloPedido();
            artPedidoActual = new List<ModeloLineaPedido>();
        }

        //public string agregarArticulo(string ptipoCodigo, string pcodArtProv, int pcantidad)
        //{


        //    ModeloArticuloProveedores ap = new ModeloArticuloProveedores();

        //    ap = cap.buscarArticuloProveedor(ptipoCodigo, pcodArtProv)[0];

        //    ModeloLineaPedido lp = new ModeloLineaPedido(ap, pcantidad);

        //    pActual.agregarLinea(lp);

        //    return "El se ha agregado un articulo al pedido actual";
        //}

        //public List<string[]> buscarArticulosProveedor(string ptipoCodigo, string pRazonSocial)
        //{
        //    List<ModeloArticuloProveedores> apActuales = new List<ModeloArticuloProveedores>();

        //    List<string[]> respuesta = new List<string[]>();

        //    apActuales = cap.buscarArticuloProveedor(ptipoCodigo, pRazonSocial);

        //    foreach (ModeloArticuloProveedores ModArtProv in apActuales)
        //    {
        //        string[] artipro = { ModArtProv.codigoOriginal, ModArtProv.codigoArticuloProveedor,ModArtProv.descripcion, ModArtProv.stockActual.ToString(), ModArtProv.stockMinimo.ToString(), Convert.ToDateTime(ModArtProv.fechaActualizacion).ToShortDateString()};

        //        respuesta.Add(artipro);
        //    }

        //    return respuesta;
        //}

        //public void modificarCantidadArticulo(string pCodArtProv, int pCant)
        //{ 
        //    if(pCant>0)
        //    {
        //        ModeloLineaPedido linea = pActual.buscarLinea(pCodArtProv);
                
        //        int Cantidad = linea.cantidadArticulos;

        //        if (pCant >= Cantidad)
        //        {
        //            pActual.bajarLinea(linea);
        //        }
        //        else
        //        {
        //            linea.cantidadArticulos = (Cantidad-pCant);
        //            pActual.actualizarLinea(linea);
                    
        //        }


        //    }
        
        //}



        public bool exists(ModeloArticuloProveedores artSelecBusq)
        {
            throw new NotImplementedException();
        }

        public void addToPedido(ModeloArticuloProveedores artSelecBusq, int p)
        {
            throw new NotImplementedException();
        }

        public string getTotal()
        {
            throw new NotImplementedException();
        }

        public List<ModeloLineaPedido> getPedidoActual()
        {
            return artPedidoActual;
        }

        public void borrarActual()
        {
            throw new NotImplementedException();
        }

        public void removeFromPedido(ModeloLineaPedido modeloLineaPedido)
        {
            throw new NotImplementedException();
        }

        public List<ModeloArticuloProveedores> buscarArticulos(string categBusq, string busqArt)
        {
            throw new NotImplementedException();
        }
    }
}
