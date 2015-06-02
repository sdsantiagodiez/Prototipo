using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloPedidoArtProv
    {

        public int nroPedido { get; set; }
        /* Estarian incluidos dentro de la linea de pedido
         * 
         * public string codigoArProveedor { get; set; } 
         * public string codigoOriginalAr { get; set; }
         * public int cantidadArticulos { get; set; }
         * public decimal valorParcial { get; set; }
         * 
         */
        public List<ModeloLineaPedido> lineasPedido { get; set; }

        public void inicializar()
        {
            /*Quizas este metodo deberia volar, ya que el multiobjeto de lineas de pedido se crea como una variable mas del Pedido*/
        }
        public void agregarLinea(ModeloLineaPedido pLineaPedido)
        {
            //Si linea ya existe, se suman las cantidades de las dos lineas y permanece la última ingresada
            if (existeLineaPedido(pLineaPedido))
            {
                ModeloLineaPedido lpActual = buscarLinea(pLineaPedido.codigoArtProveedor);
                pLineaPedido.cantidadArticulos = lpActual.cantidadArticulos + pLineaPedido.cantidadArticulos;
                lineasPedido.Remove(lpActual);
            }

            this.lineasPedido.Add(pLineaPedido);
        }
        private bool existeLineaPedido(ModeloLineaPedido pLineaPedido)
        {
            bool existe = false;
            if (buscarLinea(pLineaPedido.codigoArtProveedor) != null)
            {
                existe = true;
            }
            return existe;
        }

        public ModeloLineaPedido buscarLinea(string pCodArtProv)
        {
            ModeloLineaPedido modlpReturn = new ModeloLineaPedido();
          
                foreach (ModeloLineaPedido mLP in lineasPedido)
                {
                    if (String.Equals(mLP.codigoArtProveedor, pCodArtProv))
                    {
                        modlpReturn = mLP;
                    }
                }
            return modlpReturn;
        }

        public void bajaLinea(ModeloLineaPedido pLinea)
        {
            lineasPedido.Remove(pLinea);
        }
        /*TEMPORAL: puse que se busque la linea en vez de sacarla porque como la linea viene modificada por la actualización quizas no la detecte al no ser igual (no estoy seguro)*/
        public void actualizaLinea(ModeloLineaPedido pLinea)
        {
            ModeloLineaPedido lpActual = buscarLinea(pLinea.codigoArtProveedor);
            lineasPedido.Remove(lpActual);
            lineasPedido.Add(pLinea);   
        }

    }
}


