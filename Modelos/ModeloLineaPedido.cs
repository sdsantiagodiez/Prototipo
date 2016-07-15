﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{//Ver que pasa con los descuentos y los pedidos a proveedores
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

        List<ModeloDescuentoLineaPedido> _descuentos;
        public List<ModeloDescuentoLineaPedido> descuentos
        {
            get { return _descuentos; }
            set 
            {
                _descuentos = value;
                this.getValorParcialConDescuento();
            }
        }
        #endregion
        
        #region Constructores
        public ModeloLineaPedido()
        {
            descuentos = new List<ModeloDescuentoLineaPedido>();
            articulo = new ModeloArticuloProveedores();
        }

        public ModeloLineaPedido(ModeloArticuloProveedores p_mod_articuloProveedor, int p_cantidad, LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos p_tipoPedido) : this()
        {
            this.addArticulo(p_mod_articuloProveedor, p_cantidad, p_tipoPedido);   
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
        public decimal getValorParcialConDescuento()
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
            foreach (ModeloDescuentoLineaPedido d in descuentos)
            {
                descuento += d.asignarDescuento(p_valorParcial);
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
        public void addDescuento(ModeloDescuentoLineaPedido p_descuento)
        {
            if (p_descuento.codigoDescuento == 0)
            {
                p_descuento.codigoDescuento = getUltimoCodigoDescuento();
            }
            ModeloDescuentoLineaPedido descuento = new ModeloDescuentoLineaPedido(p_descuento, this.getValorParcialSinDescuentos());
            this.descuentos.Add(descuento);
            this.getValorParcialConDescuento();
        }       
        /// <summary>
        /// Remueve descuento de la linea
        /// </summary>
        /// <param name="p_descuento"></param>
        /// <returns>falso si el descuento no se encuentra en la linea</returns>
        public bool removeDescuento(ModeloDescuentoLineaPedido p_descuento)
        {
            ModeloDescuentoLineaPedido descuentoToRemove = this.descuentos.FirstOrDefault(d => d.codigoDescuento == p_descuento.codigoDescuento );
            if (descuentoToRemove == null)
            {
                return false;                
            }

            this.descuentos.Remove(descuentoToRemove);
            this.getValorParcialConDescuento();
            return true;
        }
        public void updateDescuentos()
        {
            decimal valorParcialSinDescuentos = this.getValorParcialSinDescuentos();
            for (int i = 0; i < this.descuentos.Count; i++ )
            {
                this.descuentos[i] = new ModeloDescuentoLineaPedido(this.descuentos[i], valorParcialSinDescuentos);
            }
            this.getValorParcialConDescuento();
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
                    this.getValorParcialConDescuento();
                    break;
                case LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.TipoPedidoProveedor:
                    this.valorUnitario = Convert.ToDecimal(p_mod_articuloProveedor.valorCompra.valorArticulo);
                    break;
            }
        }
        /// <summary>
        /// Se presupone que los rangos entre 100 y 1000 no se usarán para descuentos
        /// </summary>
        /// <returns></returns>
        private int getUltimoCodigoDescuento()
        {
            int i = 100;
            foreach(ModeloDescuentoLineaPedido d in descuentos)
            {
                if (d.codigoDescuento > i && d.codigoDescuento < 1000)
                {
                    i = d.codigoDescuento;
                }
            }
            return i++;
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
}
