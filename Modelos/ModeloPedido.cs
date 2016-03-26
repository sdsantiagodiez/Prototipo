using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloPedido : Modelo
    {
        #region Getters/Setters
        int _codigoEntidad;
        public int codigoEntidad
        {
            get { return _codigoEntidad; }
            set { this._codigoEntidad = value; }
        }
        
        int _numeroPedido;
        public int numeroPedido
        {
            get { return _numeroPedido; }
            set 
            { 
                this._numeroPedido = value;
                this.insertarNumeroPedidoEnLineas(value);
            }
        }
        List<ModeloLineaPedido> _lineasPedido;
        public List<ModeloLineaPedido> lineasPedido
        {
            get { return _lineasPedido; }
            set { this._lineasPedido = value; }
        }
        
        decimal _montoTotal;
        public decimal montoTotal
        {
            get { return _montoTotal; }
            set { this._montoTotal = value; }
        }

        DateTime _fecha;
        public DateTime fecha 
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

        LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos _codigoTipoPedido;
        public LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos codigoTipoPedido 
        {
            get { return _codigoTipoPedido; }
            set { this._codigoTipoPedido = value;}
        }
        
        #endregion

        public ModeloPedido()
        {
            lineasPedido = new List<ModeloLineaPedido>();
        }
        
        public void inicializar()
        {
            //También hay que asignar numero de pedido
            /*Quizas este metodo deberia volar, ya que el multiobjeto de lineas de pedido se crea como una variable mas del Pedido*/
        }
        #region Validación
        public bool validar()
        {
            return this.validarCantidadLineasPedido();
        }
        /// <summary>
        /// Valida que la cantidad de líneas de pedido sea mayor a 0
        /// </summary>
        /// <returns></returns>
        private bool validarCantidadLineasPedido()
        {
            return Convert.ToBoolean(this.lineasPedido.Count);
        }
        #endregion

        private void insertarNumeroPedidoEnLineas(int p_numeroPedido)
        {
            foreach (ModeloLineaPedido lp in this.lineasPedido)
            {
                lp.numeroPedido = p_numeroPedido;
            }
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

        #region Equals
        public override bool Equals(object p_objeto)
        {
            if (p_objeto is ModeloPedido == false)
                return false;
            return Equals((ModeloPedido)p_objeto);
        }

        public virtual bool Equals(ModeloPedido p_mod_pedido)
        {
            return this.Equals(this.codigoEntidad,p_mod_pedido.codigoEntidad)
                && this.Equals(this.codigoTipoPedido,p_mod_pedido.codigoTipoPedido)
                && this.Equals(this.fecha,p_mod_pedido.fecha)
                && this.Equals(this.lineasPedido,p_mod_pedido.lineasPedido)
                && this.Equals(this.montoTotal,p_mod_pedido.montoTotal)
                && this.Equals(this.numeroPedido,p_mod_pedido.numeroPedido)
                && this.Equals(this.observaciones,p_mod_pedido.observaciones);
        }
        #endregion
    }
}


