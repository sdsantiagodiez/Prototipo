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
         * public float valorParcial { get; set; }
         * 
         */
        public List<ModeloLineaPedido> lineaPedido { get; set; }

        public void inicializar()
        {
            /*Quizas este metodo deberia volar, ya que el multiobjeto de lineas de pedido se crea como una variable mas del Pedido*/
        }
        public void agregarLinea(ModeloLineaPedido pLineaPedido)
        {
            this.lineaPedido.Add(pLineaPedido);
        }

        public ModeloLineaPedido buscarLinea(string pCodArtProv)
        {
            ModeloLineaPedido modlpReturn = new ModeloLineaPedido();
          
                foreach (ModeloLineaPedido mLP in lineaPedido)
                {
                    if (String.Equals(mLP.codigoArProveedor, pCodArtProv) == true)
                    {
                        modlpReturn = mLP;
                        break;
                    }
                }
                return modlpReturn;
            }

        public void bajaLinea(ModeloLineaPedido pLinea)
        {
            lineaPedido.Remove(pLinea);
        }
        public void actualizaLinea(ModeloLineaPedido pLinea)
        {
            lineaPedido.Remove(pLinea);/*Al no existir un metodo que permita actualizar, lo quito y lo vuelvo a agregar, no se si funcionara*/
            lineaPedido.Add(pLinea);
            
        }

    }
}


