﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloLineaPedido
    {
        #region Getters/Setters
        string _codigoArtProveedor;
        public string codigoArtProveedor
        {
            get { return _codigoArtProveedor; }
            set { this._codigoArtProveedor = value; }
        }
        string _codigoOriginalArt;
        public string codigoOriginalArt
        {
            get { return _codigoOriginalArt; }
            set { this._codigoOriginalArt = value; }
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
        #endregion

        public ModeloLineaPedido()
        { }

        public ModeloLineaPedido(ModeloArticuloProveedores pModArtProv, int pCantidad)
        {
            this.codigoArtProveedor = pModArtProv.codigoArticuloProveedor;
            this.codigoOriginalArt = pModArtProv.codigoOriginal;
            this.cantidadArticulos = pCantidad;
            //Sólo considera que la linea sea de venta de artículo y no para una compra a proveedor
            this.valorUnitario = pModArtProv.valorVenta.valorArticulo;
            //Recordar que se pueden aplicar descuentos
            this.valorParcial = this.cantidadArticulos * this.valorUnitario;
        }
    }
}
