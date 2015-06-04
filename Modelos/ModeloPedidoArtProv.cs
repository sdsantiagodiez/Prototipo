using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloPedidoArtProv
    {
        #region Getters/Setters
        int _nroPedido;
        public int nroPedido
        {
            get { return _nroPedido; }
            set { this._nroPedido = value; }
        }
        List<ModeloLineaPedido> _lineasPedido;
        public List<ModeloLineaPedido> lineasPedido
        {
            get { return _lineasPedido; }
            set { this._lineasPedido = value; }
        }
        #endregion

        public ModeloPedidoArtProv()
        {
            _lineasPedido = new List<ModeloLineaPedido>();
        }
        
        public void inicializar()
        {
            //También hay que asignar numero de pedido
            /*Quizas este metodo deberia volar, ya que el multiobjeto de lineas de pedido se crea como una variable mas del Pedido*/
        }
        
        public ModeloLineaPedido buscarLinea(string pCodArtProv)
        {
            ModeloLineaPedido modlpReturn = null;
            foreach (ModeloLineaPedido mLP in _lineasPedido)
            {
                if (String.Equals(mLP.codigoArtProveedor, pCodArtProv))
                {
                    modlpReturn = mLP;
                    break;
                }
            }
            return modlpReturn;
        }
        private bool existeLineaPedido(ModeloLineaPedido pLineaPedido)
        {
            bool existe = false;
            if (buscarLinea(pLineaPedido.codigoArtProveedor) != null )
            {
                existe = true;
            }
            return existe;
        }

        #region Agregar, Bajar y Actualizar lineas de pedido
        /*
         * Devuelven true si se pudo realizar la operación
         * false si no fue posible
         */
        public bool agregarLinea(ModeloLineaPedido pLineaPedido)
        {
            //Si linea ya existe, se suman las cantidades de las dos lineas y permanece la última ingresada
            bool respuesta = true;
            if (existeLineaPedido(pLineaPedido))
            {
                ModeloLineaPedido lpActual = buscarLinea(pLineaPedido.codigoArtProveedor);
                pLineaPedido.cantidadArticulos = lpActual.cantidadArticulos + pLineaPedido.cantidadArticulos;
                respuesta = _lineasPedido.Remove(lpActual);
            }
            if(respuesta)
            {
                this._lineasPedido.Add(pLineaPedido);
            }
            
            return respuesta;
        }
        public bool bajaLinea(ModeloLineaPedido pLinea)
        {
            return _lineasPedido.Remove(pLinea);
        }  
        public bool actualizaLinea(ModeloLineaPedido pLinea)
        {
            /*TEMPORAL: puse que se busque la linea en vez de sacarla porque como la linea viene modificada por la actualización quizas no la detecte al no ser igual (no estoy seguro)*/
            bool respuesta = true;
            ModeloLineaPedido lpActual = buscarLinea(pLinea.codigoArtProveedor);
            respuesta = _lineasPedido.Remove(lpActual);
            if (respuesta)
            {
                _lineasPedido.Add(pLinea);
            }
            return respuesta;
        }
        #endregion
    }
}


