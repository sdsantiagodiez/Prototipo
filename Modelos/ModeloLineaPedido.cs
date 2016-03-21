using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloLineaPedido : Modelo
    {
        #region Getters/Setters

        int _numeroPedido;
        public int numeroPedido
        {
            get { return _numeroPedido; }
            set { this._numeroPedido = value; }
        }
        string _codigoArticuloProveedor;
        public string codigoArtProveedor
        {
            get { return _codigoArticuloProveedor; }
            set { this._codigoArticuloProveedor = value; }
        }
        string _codigoOriginalArticulo;
        public string codigoOriginalArt
        {
            get { return _codigoOriginalArticulo; }
            set { this._codigoOriginalArticulo = value; }
        }
        int _cantidadArticulos;
        public int cantidadArticulos
        {
            get { return _cantidadArticulos; }
            set { this._cantidadArticulos = value; }
        }
        decimal _valorParcial;
        public decimal valorParcial
        {
            get { return _valorParcial; }
            set { this._valorParcial = value; }
        }
        decimal _valorUnitario;
        public decimal valorUnitario
        {
            get { return _valorUnitario; }
            set { this._valorUnitario = value; }
        }
        string _descripcion;
        public string descripcion
        {
            get { return _descripcion; }
            set { this._descripcion = value; }
        }
        #endregion

        public ModeloLineaPedido()
        { }

        public ModeloLineaPedido(ModeloArticuloProveedores p_mod_articuloProveedor, int pCantidad)
        {
            this.codigoArtProveedor = p_mod_articuloProveedor.codigoArticuloProveedor;
            this.codigoOriginalArt = p_mod_articuloProveedor.codigoOriginal;
            this.cantidadArticulos = pCantidad;
            this.descripcion = p_mod_articuloProveedor.descripcionArticuloProveedor;
            //Sólo considera que la linea sea de venta de artículo y no para una compra a proveedor
            this.valorUnitario = Convert.ToDecimal(p_mod_articuloProveedor.valorVenta.valorArticulo);
            //Recordar que se pueden aplicar descuentos
            this.valorParcial = this.cantidadArticulos * this.valorUnitario;
        }

        public override bool Equals(object p_objeto)
        {
            if (p_objeto is ModeloLineaPedido == false)
                return false;
            return Equals((ModeloLineaPedido)p_objeto);
        }

        public virtual bool Equals(ModeloLineaPedido p_mod_lineaPedido)
        {
            return this.Equals(this.cantidadArticulos,p_mod_lineaPedido.cantidadArticulos)
                && this.Equals(this.codigoArtProveedor, p_mod_lineaPedido.codigoArtProveedor)
                && this.Equals(this.codigoOriginalArt, p_mod_lineaPedido.codigoOriginalArt)
                && this.Equals(this.descripcion,p_mod_lineaPedido.descripcion)
                && this.Equals(this.numeroPedido,p_mod_lineaPedido.numeroPedido)
                && this.Equals(this.valorParcial,p_mod_lineaPedido.valorParcial)
                && this.Equals(this.valorUnitario,p_mod_lineaPedido.valorUnitario);
        }
    }
}
