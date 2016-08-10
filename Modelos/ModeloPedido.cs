using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Modelos
{       //ver getDescuentoTotal()
    [Serializable]
    public class ModeloPedido : Modelo
    {
        #region Getters/Setters
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

        string _numeroComprobante;
        public string numeroComprobante
        {
            get { return _numeroComprobante; }
            set { _numeroComprobante = value; }
        }

        string _CAE;
        public string CAE
        {
            get { return _CAE; }
            set { _CAE = value; }
        }

        string _aprobadoAFIP;
        public string aprobadoAFIP
        {
            get { return _aprobadoAFIP; }
            set { _aprobadoAFIP = value; }
        }

        int _tipoComprobante;
        public int tipoComprobante
        {
            get { return _tipoComprobante; }
            set { _tipoComprobante = value; }
        }

        Documento _documentoComprador;
        public Documento documentoComprador
        {
            get { return _documentoComprador; }
            set { _documentoComprador = value; }
        }

        DateTime _fecha;
        public DateTime fecha
        {
            get { return _fecha; }
            set { this._fecha = value; }
        }

        List<ModeloLineaPedido> _lineasPedido;
        public List<ModeloLineaPedido> lineasPedido
        {
            get { return _lineasPedido; }
            private set { this._lineasPedido = value; }
        }

        decimal _montoTotal;
        public decimal montoTotal
        {
            get { return _montoTotal; }
            set { this._montoTotal = value>0?value:0; }
        }
        
        decimal _montoSubTotal;
        public decimal montoSubTotal
        {
            get { return _montoSubTotal; }
            set { this._montoSubTotal = value>0?value:0; }
        }
        
        //Puede ser un proveedor o un cliente persona
        ModeloEntidad _entidad;
        public ModeloEntidad entidad
        {
            get { return _entidad; }
            set { _entidad = value; }
        }
       
        #region Contacto (Domicilio, Mail y Teléfono)
        ModeloDomicilio _domicilioDeFacturacion;
        public ModeloDomicilio domicilioDeFacturacion
        {
            get { return _domicilioDeFacturacion; }
            set { _domicilioDeFacturacion = value; }
        }

        ModeloTelefono _telefonoContacto;
        public ModeloTelefono telefonoContacto
        {
            get { return _telefonoContacto; }
            set { _telefonoContacto = value; }
        }

        ModeloMail _mailContacto;
        public ModeloMail mailContacto
        {
            get { return _mailContacto; }
            set { _mailContacto = value; }
        }
        #endregion
        
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
            set 
            {
                switch (value)
                {
                    case LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.Persona:
                        this.entidad = new ModeloCliente();
                        break;
                    case LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.Proveedor:
                        this.entidad = new ModeloProveedor();
                        break;
                }
                this._codigoTipoPedido = value;
            }
        }

        //Se podría pagar una parte en tarjeta y otra en efectivo
        List<FormaPago> _formasDePago;
        public List<FormaPago> formasDePago
        {
            get { return _formasDePago; }
            set { _formasDePago = value; }
        }

        Alicuota _alicuota;
        public Alicuota alicuota
        {
            get { return _alicuota; }
            set { _alicuota = value; }
        }

        ModeloDescuentoPedido _descuentos;
        public ModeloDescuentoPedido descuentos
        {
            get { return _descuentos; }
            set { _descuentos = value; }
        }

        decimal _senia;
        public decimal senia
        {
            get { return _senia; }
            set { _senia = value; }
        }

        DateTime _vencimientoCAE;
        public DateTime VencimientoCAE
        {
            get { return _vencimientoCAE; }
            set { _vencimientoCAE = value; }
        }

        #endregion

        public ModeloPedido()
        {
            this.lineasPedido = new List<ModeloLineaPedido>();
            this.alicuota = new Alicuota();
            this.documentoComprador = new Documento();
            this.fecha = DateTime.Today;
            this.descuentos = new ModeloDescuentoPedido();
            this.descuentos.asignarMontoTotal(this.getTotalSinDescuento());
            this.formasDePago = new List<FormaPago>();
            this.addFormaPago(new FormaPago() { forma = LibreriaClasesCompartidas.Constantes.FormaDePago.Contado, restante = true });
            this.entidad = new ModeloEntidad();
        }

        public ModeloPedido(ModeloEntidad p_mod_entidad) : this()
        {
            if(p_mod_entidad.GetType() == typeof(ModeloProveedor))
            {
                this.codigoTipoPedido = LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.Proveedor;
            }
            else if (p_mod_entidad.GetType() == typeof(ModeloCliente))
            {
                this.codigoTipoPedido = LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.Persona;
            }
            this.entidad = p_mod_entidad;

            this.domicilioDeFacturacion = p_mod_entidad.domicilios.Count > 0 ? p_mod_entidad.domicilios[0] : null;
            this.telefonoContacto = p_mod_entidad.telefonos.Count > 0 ? p_mod_entidad.telefonos[0] : null;
            this.mailContacto = p_mod_entidad.mails.Count > 0 ? p_mod_entidad.mails[0] : null;
        }
        /// <summary>
        /// Inicializa datos básico. No considera datos particulares a un pedido en especial (generados al momento de facturar, guardar pedido en base de datos, lineas, señas, observaciones, etc)
        /// </summary>
        /// <param name="p_mod_pedido"></param>
        public ModeloPedido(ModeloPedido p_mod_pedido) : this()
        {
            this.codigoTipoPedido = p_mod_pedido.codigoTipoPedido;
            this.documentoComprador = p_mod_pedido.documentoComprador;
            this.domicilioDeFacturacion = p_mod_pedido.domicilioDeFacturacion;
            this.mailContacto = p_mod_pedido.mailContacto;
            this.telefonoContacto = p_mod_pedido.telefonoContacto;
            this.entidad = p_mod_pedido.entidad;
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

        public ModeloLineaPedido getLineaPedido(ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            foreach (ModeloLineaPedido lp in lineasPedido)
            {
                if (lp.articulo.Equals(p_mod_articuloProveedor))
                {
                    return lp;
                }
            }
            return null;
        }
        public bool existeLineaPedido(ModeloLineaPedido pLineaPedido)
        {
            return getLineaPedido(pLineaPedido.articulo) != null;
        }

        public bool existeLineaPedido(ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            return (getLineaPedido(p_mod_articuloProveedor) != null);
        }

        public decimal getDescuentoLineas()
        {
            decimal descuento = 0;
            foreach (ModeloLineaPedido linea in this.lineasPedido)
            {
                descuento += linea.getDescuento();
            }
            return descuento;
        }
        public decimal getDescuentoLineasPorcentaje()
        {
            if(this.montoTotal == 0)
            {
                return 0;
            }
            return this.getDescuentoLineas() / this.montoTotal;
        }
        public decimal getDescuentoTotal()
        {
            return 
                this.getDescuentoLineas() + 
                this.descuentos.descuento_total_monto +
                //VER si correspondería sacar la seña a un método diferente
                this.senia;
        }
        public decimal getDescuentoTotalPorcentaje()
        {
            if (this.montoTotal == 0)
            {
                return 0;
            }

            return this.getDescuentoTotal() / this.montoTotal;
        }
        public decimal getTotalSinDescuento()
        {
            decimal lcl_total = 0;
            foreach (ModeloLineaPedido linea in lineasPedido)
            {
                lcl_total += linea.getValorParcialSinDescuentos();
            }
            this.descuentos.asignarMontoTotal(lcl_total);
            return lcl_total;
        }
        public decimal getTotal()
        {
            this.montoTotal = this.getTotalSinDescuento() - this.getDescuentoTotal();
            this.montoTotal = Math.Round(this.montoTotal, 2);
            //decimal lcl_total = 0;
            //foreach (ModeloLineaPedido linea in lineasPedido)
            //{
            //    lcl_total += linea.getValorParcial();
            //}
            //this.montoTotal =  lcl_total - descuento_1.descuento - descuento_2.descuento;
            return this.montoTotal;
        }
        /// <summary>
        /// Discrimina Alícuota
        /// </summary>
        /// <returns></returns>
        public decimal getSubTotal()
        {
            decimal divisorIVA = 1 + (Convert.ToDecimal(this.alicuota.iva.porcentaje) / 100);
            decimal total = this.getTotal();

            this.montoSubTotal = Decimal.Divide(total, divisorIVA);
            this.montoSubTotal = Math.Round(this.montoSubTotal, 2);
            return this.montoSubTotal;
        }
       
        public decimal getIVAMonto()
        {
            this.alicuota.monto = this.getTotal() - this.getSubTotal();
            this.alicuota.monto = Math.Round(this.alicuota.monto, 2);
            return this.alicuota.monto;
        }
        public void actualizarMontos()
        {
            this.getTotal();
            this.getSubTotal();
            this.getIVAMonto();
        }
        #region Agregar, Bajar y Actualizar lineas de pedido
        /// <summary>
        /// Agrega lista de lineasPedido al pedido
        /// Ver si vale la pena. Se usa para dejar readonly a las lineas de pedido, para que no se pueda hacer pedido.lineas.add() desde afuera del objeto
        /// </summary>
        /// <param name="p_lst_lineasPedido"></param>
        public void addLineaPedidoList(List<ModeloLineaPedido> p_lst_lineasPedido)
        {
            //Podria cambiar de void a bool si hay alguna validación en las lineas
            foreach (ModeloLineaPedido lp in p_lst_lineasPedido)
            {
                lineasPedido.Add(lp);
            }
            this.actualizarMontos();
        }
        /// <summary>
        /// Agrega línea o suma cantidades si ya existe
        /// </summary>
        /// <param name="p_lineaPedido"></param>
        /// <returns></returns>
        public bool addLineaPedido(ModeloLineaPedido p_lineaPedido)
        {
            ////Si linea ya existe, se suman las cantidades de las dos lineas y permanece la última ingresada
            bool respuesta = true;

            ModeloLineaPedido lcl_mod_lineaPedido = this.getLineaPedido(p_lineaPedido.articulo);
            if (lcl_mod_lineaPedido != null)
            {
                //la linea de pedido ya existe. Se suman las cantidades y se mantiene lcl_mod_lineaPedido en la lista
                lcl_mod_lineaPedido.cantidadArticulos += p_lineaPedido.cantidadArticulos;
                p_lineaPedido.cantidadArticulos = lcl_mod_lineaPedido.cantidadArticulos;
                lcl_mod_lineaPedido = p_lineaPedido;
            }
            else
            {
                this._lineasPedido.Add(p_lineaPedido);
            }

            this.actualizarMontos();
            return respuesta;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_lineaPedido"></param>
        /// <returns></returns>
        public bool updateLineaPedido(ModeloLineaPedido p_lineaPedido)
        {
            /*TEMPORAL: puse que se busque la linea en vez de sacarla porque como la linea viene modificada por la actualización quizas no la detecte al no ser igual (no estoy seguro)*/
            bool respuesta = true;
            ModeloLineaPedido lpActual = getLineaPedido(p_lineaPedido.articulo);
            respuesta = lineasPedido.Remove(lpActual);
            if (respuesta && p_lineaPedido.cantidadArticulos != 0)
            {
                lineasPedido.Add(p_lineaPedido);
            }
            this.actualizarMontos();
            return respuesta;
        }
        public bool removeLineaPedido(ModeloLineaPedido p_lineaPedido)
        {
            bool answer = true;
            lineasPedido.Remove(p_lineaPedido);
            this.actualizarMontos();
            return answer;
        }
        public void removeAllLineaPedido()
        {
            lineasPedido = new List<ModeloLineaPedido>();
            this.actualizarMontos();
        }
        #endregion

        private bool actualizarMontoFormaPagoRestante()
        {
            decimal valor = this.getMontoFormaPagoRestante();
            if (valor < 0)
            {
                // no se puede porque se ha asignado más monto del que se debe pagar
                return false;
            }

            foreach (FormaPago fp in this.formasDePago)
            {
                if (fp.restante)
                {
                    //se asigna valor
                    fp.monto = valor;
                    return true;
                }

            }
            //no hay formaDePago designada como restante
            return false;
        }
        private decimal getMontoFormaPagoRestante()
        {
            decimal valor = new decimal();
            foreach (FormaPago fp in this.formasDePago)
            {
                if (!fp.restante)
                {
                    valor += fp.monto;
                }
            }
            return this.getTotal() - valor;
        }

        public bool addFormaPago(FormaPago p_formaPago)
        {
            if (!p_formaPago.restante)
            {
                if ((this.getMontoFormaPagoRestante() - p_formaPago.monto) < 0)
                    //el monto distribuido en los distintos pagos es mayor al que hay que pagar
                    return false;
            }

            //Eliminamos la forma de pago seteado como restante, si la nueva a agregar es restante
            if(p_formaPago.restante)
            {
                //se agrega .ToList() porque si no, no corre
                foreach (FormaPago fp in this.formasDePago.ToList())
                {
                    if (fp.restante)
                    {
                        this.removeFormaPago(fp);
                    }
                }
            }

            bool modificado = false;
            foreach(FormaPago fp in this.formasDePago)
            {
                //si la forma de pago ya existe, se suman los montos
                if (fp.forma == p_formaPago.forma)
                {
                    fp.monto += p_formaPago.monto;
                    fp.restante = p_formaPago.restante;
                    modificado = true;
                    break;
                }
            }
            if (!modificado)
            {
                this.formasDePago.Add(p_formaPago);
            }

            return this.actualizarMontoFormaPagoRestante();

        }
        public bool removeFormaPago(FormaPago p_formaPago)
        {
            if (p_formaPago.restante)
            {
                //no se puede eliminar restante. Sólo se puede reemplazar
                //return false;
            }
            FormaPago formaPagoToRemove = this.formasDePago.FirstOrDefault(fp => fp.forma == p_formaPago.forma);
            if (formaPagoToRemove == null)
            {
                return false;
            }

            this.formasDePago.Remove(formaPagoToRemove);

            
            if (!this.actualizarMontoFormaPagoRestante() && !p_formaPago.restante)
            {//Quiere decir que se removio formaPago con restante=true y que no se esta reemplazando por otro restante
                if (this.formasDePago.Count == 0)
                {//Se agrega una forma de pago en caso de que no haya ninguna
                    this.formasDePago.Add(new FormaPago() { forma = LibreriaClasesCompartidas.Constantes.FormaDePago.Contado, restante = true});
                }
                else
                {//Se establece la primer formaPago en la lista como restante=true
                    this.formasDePago[0].restante = true;
                }
                this.actualizarMontoFormaPagoRestante();
            }
            return true;
        }

        public int codigoBarra()
        {
            
            string fec_vto = this.VencimientoCAE.ToString("yyyyMMdd", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

            string [] codigo_barra = {this.entidad.cuit.ToString() + this.tipoComprobante.ToString() + "0001" + this.CAE + fec_vto};
            String.Concat(codigo_barra);

            int codigo_barra_con_verificador = this.calculaVerificador(codigo_barra);
            

            return codigo_barra_con_verificador;
        }

        public int calculaVerificador(string [] codigo_barra)
        {   int pares=0;
            int impares=0;

            for (int i = 0; i > 39; i++)
            {
                if ((i % 2) == 0)
                { pares = pares + Convert.ToInt32(codigo_barra[i]); }
                else
                { impares = impares + Convert.ToInt32(codigo_barra[i]); }
            }
            
            long total = pares + (impares*3);
            string verificador = "";

            if ((total % 10) == 0)
            { verificador = "0"; }
            else
            { verificador = (10 - total % 10).ToString(); }

            codigo_barra[39] = verificador;
                return Convert.ToInt32(codigo_barra);
        }

        #region Equals
        public override bool Equals(object p_objeto)
        {
            if (p_objeto is ModeloPedido == false)
                return false;
            return Equals((ModeloPedido)p_objeto);
        }

        public virtual bool Equals(ModeloPedido p_mod_pedido)
        {
            return this.Equals(this.entidad,p_mod_pedido.entidad)
                && this.Equals(this.codigoTipoPedido,p_mod_pedido.codigoTipoPedido)
                && this.Equals(this.fecha,p_mod_pedido.fecha)
                && this.Equals(this.lineasPedido,p_mod_pedido.lineasPedido)
                && this.Equals(this.montoTotal,p_mod_pedido.montoTotal)
                && this.Equals(this.numeroPedido,p_mod_pedido.numeroPedido)
                && this.Equals(this.observaciones,p_mod_pedido.observaciones);
        }
        #endregion
    }
    [Serializable]
    public class FormaPago
    {
        LibreriaClasesCompartidas.Constantes.FormaDePago _forma;
        public LibreriaClasesCompartidas.Constantes.FormaDePago forma
        {
            get { return _forma; }
            set { _forma = value; }
        }

        decimal _monto;
        public decimal monto
        {
            get { return _monto; }
            set { _monto = value; }
        }

        bool _restante;
        public bool restante
        {
            get { return _restante; }
            set { _restante = value; }
        }
    }
    [Serializable]
    public class IVA
    {
        int _codigo;
        public int codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        double _porcentaje;
        public double porcentaje
        {
            get { return _porcentaje; }
            set { _porcentaje = value; }
        }
    }
    [Serializable]
    public class Alicuota
    {
        IVA _iva;
        public IVA iva
        {
            get { return _iva; }
            set { _iva = value; }
        }
        decimal _monto;
        public decimal monto
        {
            get { return _monto; }
            set { _monto = value; }
        }
        public Alicuota()
        {
            this.iva = new IVA();
            this.iva.codigo = 5;//código AFIP
            this.iva.porcentaje = 21;
        }
    }
    [Serializable]
    public class TipoDocumento
    {
        int _codigo;
        public int codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        string _descripcion;
        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
    }
    [Serializable]
    public class Documento
    {
        TipoDocumento _tipo;
        public TipoDocumento tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        string _numero;
        public string numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        public Documento()
        {
            tipo = new TipoDocumento();
        }
    }
    

}


