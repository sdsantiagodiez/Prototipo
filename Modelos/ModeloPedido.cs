using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloPedido
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
        
        float _monto_total;
        public float monto_total
        {
            get { return _monto_total; }
            set { this._monto_total = value; }
        }

        string _fecha;
        public string fecha 
        {
            get { return _fecha; }
            set { this._fecha = value; }
        }

        string _observaciones;
        public string observaciones 
        {
            get { return _observaciones; }
            set { this._observaciones = value; }
        }

        int _codigo_tipo_pedido;
        public int codigo_tipo_pedido 
        {
            get { return _codigo_tipo_pedido; }
            set { this._codigo_tipo_pedido = value;}
        }
        
        #endregion

        public ModeloPedido()
        {
            _lineasPedido = new List<ModeloLineaPedido>();
        }
        
        public void inicializar()
        {
            //También hay que asignar numero de pedido
            /*Quizas este metodo deberia volar, ya que el multiobjeto de lineas de pedido se crea como una variable mas del Pedido*/
        }
        
        public ModeloLineaPedido findDetail(string p_codigoOriginal, string p_codigoArticuloProveedor)
        {
            ModeloLineaPedido lcl_mod_orderDetail = null;
            foreach (ModeloLineaPedido detail in _lineasPedido)
            {
                if (String.Equals(detail.codigoArtProveedor, p_codigoArticuloProveedor) && String.Equals(detail.codigoOriginalArt,p_codigoOriginal))
                {
                    lcl_mod_orderDetail = detail;
                    break;
                }
            }
            return lcl_mod_orderDetail;
        }
        public bool existeLineaPedido(ModeloLineaPedido pLineaPedido)
        {
            bool existe = false;
            if (findDetail(pLineaPedido.codigoOriginalArt, pLineaPedido.codigoArtProveedor) != null )
            {
                existe = true;
            }
            return existe;
        }

        public bool existeLineaPedido(ModeloArticuloProveedores p_mod_Article)
        {
            bool exists = false;
            if (findDetail(p_mod_Article.codigoOriginal, p_mod_Article.codigoArticuloProveedor) != null)
            {
                exists = true;
            }
            return exists;
        }

        public decimal getCurrentTotal()
        {
            decimal lcl_total = 0;
            foreach (ModeloLineaPedido detail in _lineasPedido)
            {
                lcl_total = lcl_total + detail.valorParcial;
            }
            return lcl_total;
        }
        public bool restartOrderDetails()
        {
            bool lcl_answer = true;
            _lineasPedido = new List<ModeloLineaPedido>();
            return lcl_answer;
        }

        #region Agregar, Bajar y Actualizar lineas de pedido
        /*
         * Devuelven true si se pudo realizar la operación
         * false si no fue posible
         */
        public bool addDetail(ModeloLineaPedido pLineaPedido)
        {
            ////Si linea ya existe, se suman las cantidades de las dos lineas y permanece la última ingresada
            bool respuesta = true;
            //if (existeLineaPedido(pLineaPedido))
            //{
            //    ModeloLineaPedido lpActual = findDetail(pLineaPedido.codigoOriginalArt ,pLineaPedido.codigoArtProveedor);
            //    pLineaPedido.cantidadArticulos = lpActual.cantidadArticulos + pLineaPedido.cantidadArticulos;
            //    respuesta = _lineasPedido.Remove(lpActual);
            //}
            //if(respuesta)
            //{
                this._lineasPedido.Add(pLineaPedido);
            //}
            return respuesta;
        }
        public bool bajarLinea(ModeloLineaPedido p_mod_detail)
        {
            bool answer = true;
            _lineasPedido.Remove(p_mod_detail);
            return answer;
        }
        public bool actualizarLinea(ModeloLineaPedido pLinea)
        {
            /*TEMPORAL: puse que se busque la linea en vez de sacarla porque como la linea viene modificada por la actualización quizas no la detecte al no ser igual (no estoy seguro)*/
            bool respuesta = true;
            ModeloLineaPedido lpActual = findDetail(pLinea.codigoOriginalArt ,pLinea.codigoArtProveedor);
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


