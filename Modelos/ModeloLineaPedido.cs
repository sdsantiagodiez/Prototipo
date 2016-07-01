using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    [Serializable]
    public class ModeloLineaPedido : Modelo
    {
        #region Getters/Setters

        int _numeroPedido;
        public int numeroPedido
        {
            get { return _numeroPedido; }
            set { this._numeroPedido = value; }
        }

        ModeloArticuloProveedores _articulo;
        public ModeloArticuloProveedores articulo
        {
            get { return _articulo; }
            set { _articulo = value; }
        }

        bool _permitirStockNegativo;
        public bool permitirStockNegativo
        {
            get { return _permitirStockNegativo; }
            set { _permitirStockNegativo = value; }
        }
        int _cantidadArticulos;
        public int cantidadArticulos
        {
            get { return _cantidadArticulos; }
            set 
            { 
                this._cantidadArticulos = value;
                this.updateDescuentos();
            }
        }
        decimal _valorUnitario;
        public decimal valorUnitario
        {
            get { return _valorUnitario; }
            set 
            {
                this._valorUnitario = value;
                this.updateDescuentos();
            }
        }
        decimal _valorParcial;
        public decimal valorParcial
        {
            get { return _valorParcial; }
            set { this._valorParcial = value; }
        }

        List<ModeloDescuento> _descuentos;
        public List<ModeloDescuento> descuentos
        {
            get { return _descuentos; }
            set 
            {
                _descuentos = value;
                this.getValorParcial();
            }
        }
        public ModeloDescuentoArticulo descuentoLinea { get; set; }

        #endregion
        
        #region Constructores
        public ModeloLineaPedido()
        {
            descuentos = new List<ModeloDescuento>();
            articulo = new ModeloArticuloProveedores();
        }

        public ModeloLineaPedido(ModeloArticuloProveedores p_mod_articuloProveedor, int p_cantidad, LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos p_tipoPedido) : this()
        {
            this.addArticulo(p_mod_articuloProveedor, p_cantidad, p_tipoPedido);   
            this.getValorParcial();
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Asigna y devuelve valor parcial sin tener en cuenta descuentos
        /// </summary>
        /// <returns></returns>
        public decimal getValorParcialSinDescuentos()
        {
            return this.valorUnitario * this.cantidadArticulos;
            //return this.valorParcial;
        }
        /// <summary>
        /// Asigna y devuelve valor parcial teniendo en cuenta descuentos
        /// </summary>
        /// <returns>0 si los descuentos superan el valor de la linea</returns>
        public decimal getValorParcial()
        {
            decimal vParcial = this.getValorParcialSinDescuentos();
            //AplicarDescuentos
            vParcial =  vParcial - this.getDescuento(vParcial);
            if (vParcial < 0)
            {
                this.valorParcial = 0;
            }
            else
            {
                this.valorParcial = vParcial;
            }
            return this.valorParcial;
        }
        /// <summary>
        /// Devuelve el descuento total que se aplicaría a la linea
        /// </summary>
        /// <param name="p_valorParcial"></param>
        /// <returns></returns>
        private decimal getDescuento(decimal p_valorParcial)
        {
            decimal descuento = 0;
            foreach (ModeloDescuento d in descuentos)
            {
                descuento += d.getDescuento(p_valorParcial);
            }
            return descuento;
        }

        public decimal getDescuento()
        {
            return this.getDescuento(this.getValorParcialSinDescuentos());
        }
        /// <summary>
        /// Agrega descuento a linea
        /// </summary>
        /// <param name="p_descuento"></param>
        /// <returns></returns>
        public void addDescuento(ModeloDescuento p_descuento)
        {
            ModeloDescuento descuento = new ModeloDescuento(p_descuento, this.getValorParcialSinDescuentos());
            this.descuentos.Add(descuento);
            this.getValorParcial();
        }       
        /// <summary>
        /// Remueve descuento de la linea
        /// </summary>
        /// <param name="p_descuento"></param>
        /// <returns>falso si el descuento no se encuentra en la linea</returns>
        public bool removeDescuento(ModeloDescuento p_descuento)
        {
            ModeloDescuento descuentoToRemove = this.descuentos.FirstOrDefault(d => d.descuento == p_descuento.descuento && d.descripcion == p_descuento.descripcion);
            if (descuentoToRemove == null)
            {
                return false;                
            }

            this.descuentos.Remove(descuentoToRemove);
            this.getValorParcial();
            return true;
        }
        public void updateDescuentos()
        {
            decimal valorParcialSinDescuentos = this.getValorParcialSinDescuentos();
            for (int i = 0; i < this.descuentos.Count; i++ )
            {
                this.descuentos[i] = new ModeloDescuento(this.descuentos[i], valorParcialSinDescuentos);
            }
            this.getValorParcial();
        }
        public void addArticulo(ModeloArticuloProveedores p_mod_articuloProveedor, int p_cantidad, LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos p_tipoPedido)
        {
            this.articulo = p_mod_articuloProveedor;
            this.cantidadArticulos = p_cantidad;
            //Sólo considera que la linea sea de venta de artículo y no para una compra a proveedor
            switch (p_tipoPedido)
            {
                case LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.TipoPedidoPersona:
                    this.valorUnitario = Convert.ToDecimal(p_mod_articuloProveedor.valorVenta.valorArticulo);
                    break;
                case LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.TipoPedidoProveedor:
                    this.valorUnitario = Convert.ToDecimal(p_mod_articuloProveedor.valorCompra.valorArticulo);
                    break;
            }
        }

        #region Equals
        public override bool Equals(object p_objeto)
        {
            if (p_objeto is ModeloLineaPedido == false)
                return false;
            return Equals((ModeloLineaPedido)p_objeto);
        }

        public virtual bool Equals(ModeloLineaPedido p_mod_lineaPedido)
        {
            return this.articulo.Equals(p_mod_lineaPedido.articulo)
                && this.Equals(this.cantidadArticulos, p_mod_lineaPedido.cantidadArticulos)
                && this.Equals(this.numeroPedido, p_mod_lineaPedido.numeroPedido)
                && this.Equals(this.valorParcial, p_mod_lineaPedido.valorParcial)
                && this.Equals(this.valorUnitario, p_mod_lineaPedido.valorUnitario);
        }

        //public virtual bool Equals(ModeloLineaPedido p_mod_lineaPedido)
        //{
        //    return this.Equals(this.cantidadArticulos,p_mod_lineaPedido.cantidadArticulos)
        //        && this.Equals(this.articulo.codigoArticuloProveedor, p_mod_lineaPedido.articulo.codigoArticuloProveedor)
        //        && this.Equals(this.articulo.codigoOriginal, p_mod_lineaPedido.articulo.codigoOriginal)
        //        && this.Equals(this.articulo.descripcionArticuloProveedor,p_mod_lineaPedido.articulo.descripcionArticuloProveedor)
        //        && this.Equals(this.numeroPedido,p_mod_lineaPedido.numeroPedido)
        //        && this.Equals(this.valorParcial,p_mod_lineaPedido.valorParcial)
        //        && this.Equals(this.valorUnitario,p_mod_lineaPedido.valorUnitario);
        //}
        #endregion
        #endregion
    }
    [Serializable]
    public class ModeloDescuento
    {
        public ModeloDescuento()
        {
            this.descripcion = "Estándar";
        }
        public ModeloDescuento(ModeloDescuento descuento,decimal valorParcial)
        {
            this.descripcion = descuento.descripcion;
            this.descuento = descuento.descuento;
            this.porcentajeSobreTotal = descuento.porcentajeSobreTotal;
            this.getDescuento(valorParcial);
        }

        string _descripcion;
        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = string.IsNullOrWhiteSpace(value)?_descripcion:value; }
        }
        //mayor a 0 para neto
        decimal _descuento;
        public decimal descuento
        {
            get { return _descuento; }
            set { _descuento = value>0?value:0; }
        }
        double _porcentajeSobreTotal;
        /// <summary>
        /// el valor debe estar entre 0 y 1
        /// </summary>
        public double porcentajeSobreTotal
        {
            get { return _porcentajeSobreTotal; }
            set 
            {
                if (value > 1)
                {
                    _porcentajeSobreTotal = 1;
                }
                else if (value < 0)
                {
                    _porcentajeSobreTotal = 0;
                }
                else if (_porcentajeSobreTotal == 0)
                {
                    _porcentajeSobreTotal = value;
                }
                //quiere decir que estamos actualizando el porcentaje y se necesita inicializar .descuento
                else if (_porcentajeSobreTotal != value)
                {
                    _porcentajeSobreTotal = value;
                    this.descuento = 0;
                }
            }
        }

        public decimal getDescuento(decimal p_valorParcial)
        {               
            //si es mayor a 0 fue inicializada
            if (this.descuento > 0)
            {
                if (this.descuento > p_valorParcial)
                {
                    this.porcentajeSobreTotal = 1;
                    return p_valorParcial;
                }

                this.porcentajeSobreTotal = Convert.ToDouble(Decimal.Divide(this.descuento,p_valorParcial));
                return this.descuento;
            }
            else if(this.porcentajeSobreTotal > 0)
            {
                this.descuento = p_valorParcial * Convert.ToDecimal(this.porcentajeSobreTotal);
                return this.descuento;
            }
            return 0;
        }
    }
    
}
