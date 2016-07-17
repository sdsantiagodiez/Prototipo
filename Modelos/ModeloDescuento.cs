using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    [Serializable]
    public class ModeloDescuento : Modelo
    {
        #region Atributos
        int _codigoDescuento;
        public int codigoDescuento
        {
            get { return _codigoDescuento; }
            set { _codigoDescuento = value; }
        }
        string _descripcion;
        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        //en base de datos debería ser decimal(5,4)-> 0.1234
        decimal _porcentaje;
        public decimal porcentaje
        {
            get { return _porcentaje; }
            set { _porcentaje = value; }
        }
      
        #endregion

        public ModeloDescuento()
        { }

        public ModeloDescuento(ModeloDescuento p_mod_descuento) : this()
        {
            if (p_mod_descuento.validar())
            {
                this.codigoDescuento = p_mod_descuento.codigoDescuento;
                this.descripcion = p_mod_descuento.descripcion;
                this.porcentaje = p_mod_descuento.porcentaje;
            }
        }

        #region Métodos
        public override string ToString()
        {
            return String.Format("{0:0.00}", porcentaje * 100);
        }

        /// <summary>
        /// Convierte porcentaje string en decimal
        /// </summary>
        /// <param name="p_porcentaje"></param>
        /// <returns></returns>
        public bool asignarPorcentaje(string p_porcentaje)
        {
            Decimal p;
            if (!Decimal.TryParse(p_porcentaje, out p))
            {
                //no se pudo realizar la conversión de string a decimal
                return false;
            }

            if (!this.validarPorcentaje(p))
            {
                return false;
            }

            this.porcentaje = p / 100;
            return true;
        }
     

        #region Validacion
        public virtual bool validar()
        {
            return this.validarPorcentaje(this.porcentaje);
        }
       
        public bool validarPorcentaje(decimal p_porcentaje)
        {
            if (p_porcentaje >= 1 || p_porcentaje <= 0)
            {
                //valores no válidos
                return false;
            }
            return true;
        }

        #endregion

        #endregion
        
        #region Equals
        public override bool Equals(object p_objeto)
        {
            if (p_objeto is ModeloDescuento == false)
                return false;
            return Equals((ModeloDescuento)p_objeto);
        }

        public virtual bool Equals(ModeloDescuento p_mod_descuento)
        {
            return this.Equals(this.codigoDescuento, p_mod_descuento.codigoDescuento)
                            && this.Equals(this.descripcion, p_mod_descuento.descripcion);
        }
        #endregion
    }

    [Serializable]
    public class ModeloDescuentoArticuloProveedor : ModeloDescuento
    {
        #region Atributos
        string _codigoOriginalArticulo;
        public string codigoOriginalArticulo
        {
            get { return _codigoOriginalArticulo; }
            set { _codigoOriginalArticulo = value; }
        }
        string _codigoArticuloProveedor;
        public string codigoArticuloProveedor
        {
            get { return _codigoArticuloProveedor; }
            set { _codigoArticuloProveedor = value; }
        }
        DateTime _fechaVigenciaDesde;
        public DateTime fechaVigenciaDesde
        {
            get { return _fechaVigenciaDesde.Date; }
            set
            {
                _fechaVigenciaDesde = value;
                _fechaVigenciaDesde = fechaVigenciaDesde.Date;
            }
        }
        DateTime _fechaVigenciaHasta;
        public DateTime fechaVigenciaHasta
        {
            get { return _fechaVigenciaHasta.Date; }
            set
            {
                _fechaVigenciaHasta = value;
                _fechaVigenciaHasta = _fechaVigenciaHasta.Date;
            }
        }
        #endregion

        public ModeloDescuentoArticuloProveedor()
        {
            this.fechaVigenciaDesde = this.fechaVigenciaHasta = DateTime.Today.Date;
        }

        public ModeloDescuentoArticuloProveedor(ModeloDescuento p_mod_descuento) : base(p_mod_descuento) 
        {
            
        }

        #region Validación
        public override bool validar()
        {
            return this.validarFechas() && base.validar();
        }
        public bool validarFechas()
        {
            return this.fechaVigenciaDesde <= this._fechaVigenciaHasta;
        }
        #endregion

        #region Vigencia
        /// <summary>
        /// Retorna si es vigente el descuento al día de hoy
        /// </summary>
        /// <returns></returns>
        public bool esVigente()
        {
            return this.esVigente(DateTime.Today.Date);
        }
        /// <summary>
        /// Retorna si es vigente el descuento al día de la fecha ingresada
        /// </summary>
        /// <param name="p_dia"></param>
        /// <returns></returns>
        public bool esVigente(DateTime p_dia)
        {
            if (fechaVigenciaDesde <= p_dia.Date && fechaVigenciaHasta >= p_dia.Date)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Equals
        public override bool Equals(object p_objeto)
        {
            if (p_objeto is ModeloDescuentoArticuloProveedor == false)
                return false;
            return Equals((ModeloDescuentoArticuloProveedor)p_objeto);
        }

        public override bool Equals(ModeloDescuento p_mod_descuento)
        {
            return base.Equals(p_mod_descuento)
                && this.Equals(p_mod_descuento as ModeloDescuentoArticuloProveedor);
        }

        public bool Equals(ModeloDescuentoArticuloProveedor p_mod_descuentoAP)
        {
            return base.Equals(p_mod_descuentoAP as ModeloDescuento)
                && this.Equals(this.fechaVigenciaDesde, p_mod_descuentoAP.fechaVigenciaDesde)
                && this.Equals(this.fechaVigenciaHasta, p_mod_descuentoAP.fechaVigenciaHasta)
                && this.Equals(this.codigoOriginalArticulo, p_mod_descuentoAP.codigoOriginalArticulo)
                && this.Equals(this.codigoArticuloProveedor, p_mod_descuentoAP.codigoArticuloProveedor);
        }
        #endregion
    }

    [Serializable]
    public class ModeloDescuentoLineaPedido : ModeloDescuento
    {
        int _numeroPedido;
        public int numeroPedido
        {
            get { return _numeroPedido; }
            set { _numeroPedido = value; }
        }
        string _codigoArticuloProveedor;
        public string codigoArticuloProveedor
        {
            get { return _codigoArticuloProveedor; }
            set { _codigoArticuloProveedor = value; }
        }
        string _codigoOriginalArticulo;
        public string codigoOriginalArticulo
        {
            get { return _codigoOriginalArticulo; }
            set { _codigoOriginalArticulo = value; }
        }
        bool porcentual;
        decimal _montoDescontadoSobreTotal;
        public decimal montoDescontadoSobreTotal
        {
            get { return _montoDescontadoSobreTotal; }
            set { _montoDescontadoSobreTotal = value; }
        }

        decimal _montoTotal;
        /// <summary>
        /// El valor total que se tomará para realizar el descuento
        /// </summary>
        public decimal montoTotal
        {
            get { return _montoTotal; }
            set { _montoTotal = value; }
        }

        public ModeloDescuentoLineaPedido()
        {
            this.descripcion = "Estándar";
            this.porcentual = true;
        }
        public ModeloDescuentoLineaPedido(ModeloLineaPedido p_mod_lineaPedido) : this()
        {
            this.asignarDatosLineaPedido(p_mod_lineaPedido);
        }
        public ModeloDescuentoLineaPedido(ModeloDescuento p_descuento) : this()
        {
            this.codigoDescuento = p_descuento.codigoDescuento;
            this.descripcion = p_descuento.descripcion;
            this.porcentaje = p_descuento.porcentaje;
        }
        public ModeloDescuentoLineaPedido(ModeloDescuentoLineaPedido p_descuento, decimal valorParcial) : this(p_descuento)
        {
            this.montoDescontadoSobreTotal =p_descuento.montoDescontadoSobreTotal;
            
            this.asignarValorTotalLinea(valorParcial);

            this.asignarDescuento(valorParcial);
        }

        #region Validación
        public bool validarTotal(decimal p_total)
        {
            return p_total > 0;
        }
        public bool validarDescuentoSobreTotal(decimal p_descuentoSobreTotal)
        {
            return p_descuentoSobreTotal > 0 && (p_descuentoSobreTotal <= this.montoTotal ) ;
        }
        public bool validar()
        {
            return this.validarTotal(this.montoTotal) && this.validarDescuentoSobreTotal(this.montoDescontadoSobreTotal)
                && base.validar();
        }
        #endregion

        #region Asignar Linea
        public void asignarDatosLineaPedido(ModeloLineaPedido p_mod_lineaPedido)
        {
            this.numeroPedido = p_mod_lineaPedido.numeroPedido;
            this.codigoOriginalArticulo = p_mod_lineaPedido.articulo.codigoOriginal;
            this.codigoArticuloProveedor = p_mod_lineaPedido.articulo.codigoArticuloProveedor;
            this.montoTotal = p_mod_lineaPedido.getValorParcialSinDescuentos();
        }
        #endregion

        #region Asignar Descuento de Línea
        public void asignarValorTotalLinea(decimal p_valorTotal)
        {
            this.montoTotal = this.validarTotal(p_valorTotal) ? p_valorTotal : 0;
        }
        /// <summary>
        /// Calcula monto a descontar de acuerdo a MontoTotal y porcentaje o montoADescontar ya ingresados
        /// </summary>
        /// <returns>Devuelve monto a descontar. 0 si algún valor no es válido</returns>
        public decimal asignarDescuento()
        {
            return this.asignarDescuento(this.montoTotal);
        }
        /// <summary>
        /// Asigna descuento a un valor total de linea de pedido de acuerdo a parámetros ya inicializados en el descuento
        /// </summary>
        /// <param name="p_valorTotal"></param>
        /// <returns>Devuelve monto a descontar. 0 si algún valor no es válido</returns>
        public decimal asignarDescuento(decimal p_valorTotal)
        {
            //Si el porcentaje es válido, se toma como predeterminado aplicar porcentaje
            if (porcentual && this.validarPorcentaje(this.porcentaje))
            {
                return this.asignarDescuentoPorcentual(p_valorTotal);
            }
            else if(!porcentual)
            {//Si no es válido, se presupone que hay que hacer un descuento neto
                return this.asignarDescuentoNeto(p_valorTotal);
            }
            //cuando es porcentual, pero el porcentaje ingresado no es válido
            return 0;
        }

        /// <summary>
        /// Inicializa monto total y montoADescontar utilizando porcentaje ya asignado previamente
        /// </summary>
        /// <param name="p_valorTotal"></param>
        /// <returns>Devuelve monto a descontar. 0 si algún valor no es válido</returns>
        public decimal asignarDescuentoPorcentual(decimal p_valorTotal)
        {
            return this.asignarDescuentoPorcentual(p_valorTotal, this.porcentaje);
        }
        /// <summary>
        /// Inicializa monto total, porcentaje y monto a descontar
        /// </summary>
        /// <param name="p_valorTotal"></param>
        /// <param name="p_porcentaje"></param>
        /// <returns>Devuelve monto a descontar. 0 si algún valor no es válido</returns>
        public decimal asignarDescuentoPorcentual(decimal p_valorTotal, decimal p_porcentaje)
        {
            porcentual = true;
            if (!this.validarPorcentaje(p_porcentaje) || !this.validarTotal(p_valorTotal))
            {
                return 0;
            }

            this.montoTotal = p_valorTotal;
            this.porcentaje = p_porcentaje;
            this.montoDescontadoSobreTotal = p_valorTotal * p_porcentaje;

            return montoDescontadoSobreTotal;
        }
        /// <summary>
        /// Inicializa monto total y porcentaje utilizando montoADescontar ya asignado previamente
        /// </summary>
        /// <param name="p_valorTotal"></param>
        /// <returns>Devuelve monto a descontar. 0 si algún valor no es válido</returns>
        public decimal asignarDescuentoNeto(decimal p_valorTotal)
        {
            return this.asignarDescuentoNeto(p_valorTotal,this.montoDescontadoSobreTotal);
        }
        /// <summary>
        /// Inicializa monto total, porcentaje y monto a descontar
        /// </summary>
        /// <param name="p_valorTotal"></param>
        /// <param name="p_montoDescontar"></param>
        /// <returns>Devuelve monto a descontar. 0 si algún valor no es válido</returns>
        public decimal asignarDescuentoNeto(decimal p_valorTotal, decimal p_montoDescontar)
        {
            porcentual = false;
            if (p_montoDescontar <= 0 || p_montoDescontar > p_valorTotal || !this.validarTotal(p_valorTotal))
            {
                return 0;
            }

            this.montoTotal = p_valorTotal;
            this.montoDescontadoSobreTotal = p_montoDescontar;
            this.porcentaje = p_montoDescontar / p_valorTotal;

            return montoDescontadoSobreTotal;
        }
        #endregion
    }
    [Serializable]
    public class ModeloDescuentoPedido : Modelo
    {
        decimal montoTotal;

        decimal _descuento_total_monto;
        public decimal descuento_total_monto
        {
            get { return _descuento_total_monto; }
            set { _descuento_total_monto = value; }
        }
        decimal _descuento_total_porcentaje;
        public decimal descuento_total_porcentaje
        {
            get { return _descuento_total_porcentaje; }
            set { _descuento_total_porcentaje = value; }
        }

        bool descuento_1_porcentual = true;
        decimal _descuento_monto_1;
        public decimal descuento_monto_1
        {
            get { return _descuento_monto_1; }
            set 
            { 
                _descuento_monto_1 = value;
                descuento_1_porcentual = false;
                this.actualizarDescuentos();
            }
        }
        decimal _descuento_porcentaje_1;
        public decimal descuento_porcentaje_1
        {
            get { return _descuento_porcentaje_1; }
            set 
            { 
                _descuento_porcentaje_1 = value;
                descuento_1_porcentual = true;
                this.actualizarDescuentos();
            }
        }
        
        bool descuento_2_porcentual = true;
        decimal _descuento_monto_2;
        public decimal descuento_monto_2
        {
            get { return _descuento_monto_2; }
            set 
            { 
                _descuento_monto_2 = value;
                descuento_2_porcentual = false;
                this.actualizarDescuentos();
            }
        }
        decimal _descuento_porcentaje_2;
        public decimal descuento_porcentaje_2
        {
            get { return _descuento_porcentaje_2; }
            set 
            { 
                _descuento_porcentaje_2 = value;
                descuento_2_porcentual = true;
                this.actualizarDescuentos();
            }
        }

        private bool validarTotal(decimal p_total)
        {
            return p_total > 0;
        }
        
        #region Asignar Descuento de Línea
        public void asignarMontoTotal(decimal p_valorTotal)
        {
            this.montoTotal = this.validarTotal(p_valorTotal) ? p_valorTotal : 0;
            this.actualizarDescuentos();
        }
        public void actualizarDescuentos()
        {
            if (!this.validarTotal(this.montoTotal))
            {
                return;
            }
            /*
             * Se utilizan los atributos con _ (ej this._descuento_monto_1 en vez de this.descuento_monto_1) 
             * para no activar las propiedades 
             */

            if (this.descuento_1_porcentual)
            {
                this._descuento_monto_1 = this.montoTotal * this._descuento_porcentaje_1;
            }
            else
            {
                this._descuento_porcentaje_1 = (this.descuento_monto_1 / this.montoTotal) ;
            }

            if (this.descuento_2_porcentual)
            {
                this._descuento_monto_2 = this.montoTotal * this.descuento_porcentaje_2;
            }
            else
            {
                this._descuento_porcentaje_2 = (this.descuento_monto_2 / this.montoTotal) ;
            }

            this.descuento_total_monto = this.descuento_monto_1 + this.descuento_monto_2 ;
            this.descuento_total_porcentaje = this.descuento_porcentaje_1 + this.descuento_porcentaje_2;
        }

        #endregion
    }
}
