﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{       
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
                    case LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.TipoPedidoPersona:
                        this.entidad = new ModeloCliente();
                        break;
                    case LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.TipoPedidoProveedor:
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

        ModeloDescuento _descuento_1;
        public ModeloDescuento descuento_1
        {
            get { return _descuento_1; }
            set { _descuento_1 = new ModeloDescuento(value, this.getTotalSinDescuento()); }
        }

        ModeloDescuento _descuento_2;
        public ModeloDescuento descuento_2
        {
            get { return _descuento_2; }
            set { _descuento_2 = new ModeloDescuento(value, this.getTotalSinDescuento()); }
        }

        decimal _senia;
        public decimal senia
        {
            get { return _senia; }
            set { _senia = value; }
        }
        #endregion

        public ModeloPedido()
        {
            lineasPedido = new List<ModeloLineaPedido>();
            this.alicuota = new Alicuota();
            this.documentoComprador = new Documento();
            //AFIP BASE que se debe modificar
            this.tipoComprobante = 1; //FACTURA A
            this.documentoComprador.tipo.codigo = 80; 
            this.documentoComprador.tipo.descripcion = "CUIT";
            this.documentoComprador.numero = "20111111112";
            //-AFIP
            this.fecha = DateTime.Today;
            this.descuento_1 = new ModeloDescuento();
            this.descuento_2 = new ModeloDescuento();
            this.formasDePago = new List<FormaPago>();
        }

        public ModeloPedido(ModeloEntidad p_mod_entidad) : this()
        {
            if(p_mod_entidad.GetType() == typeof(ModeloProveedor))
            {
                this.codigoTipoPedido = LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.TipoPedidoProveedor;
            }
            else if (p_mod_entidad.GetType() == typeof(ModeloCliente))
            {
                this.codigoTipoPedido = LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.TipoPedidoPersona;
            }
            this.entidad = p_mod_entidad;

            this.domicilioDeFacturacion = p_mod_entidad.domicilios.Count > 0 ? p_mod_entidad.domicilios[0] : null;
            this.telefonoContacto = p_mod_entidad.telefonos.Count > 0 ? p_mod_entidad.telefonos[0] : null;
            this.mailContacto = p_mod_entidad.mails.Count > 0 ? p_mod_entidad.mails[0] : null;
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

        public decimal getDescuentoTotal()
        {
            return 
                this.getDescuentoLineas() + 
                this.descuento_1.getDescuento(this.getTotalSinDescuento()) + 
                this.descuento_2.getDescuento(this.getTotalSinDescuento()) +
                this.senia;
        }
        public decimal getTotalSinDescuento()
        {
            decimal lcl_total = 0;
            foreach (ModeloLineaPedido linea in lineasPedido)
            {
                lcl_total += linea.getValorParcialSinDescuentos();
            }
            return lcl_total;
        }
        private decimal getTotal()
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

        private decimal getSubTotal()
        {
            decimal divisorIVA = 1 + (Convert.ToDecimal(this.alicuota.iva.porcentaje) / 100);
            decimal total = this.getTotal();

            this.montoSubTotal = Decimal.Divide(total, divisorIVA);
            this.montoSubTotal = Math.Round(this.montoSubTotal, 2);
            return this.montoSubTotal;
        }
       
        private decimal getIVAMonto()
        {
            this.alicuota.monto = this.getTotal() - this.getSubTotal();
            this.alicuota.monto = Math.Round(this.alicuota.monto, 2);
            return this.alicuota.monto;
        }
        private void actualizarMontos()
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
        public bool addLineaPedido(ModeloLineaPedido p_lineaPedido)
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
                this._lineasPedido.Add(p_lineaPedido);
            //}
            this.actualizarMontos();
            return respuesta;
        }
        public bool updateLineaPedido(ModeloLineaPedido p_lineaPedido)
        {
            /*TEMPORAL: puse que se busque la linea en vez de sacarla porque como la linea viene modificada por la actualización quizas no la detecte al no ser igual (no estoy seguro)*/
            bool respuesta = true;
            ModeloLineaPedido lpActual = getLineaPedido(p_lineaPedido.articulo);
            respuesta = lineasPedido.Remove(lpActual);
            if (respuesta)
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


