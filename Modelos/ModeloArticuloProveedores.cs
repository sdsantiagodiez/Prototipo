using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloArticuloProveedores : ModeloArticulos
    {
        #region Getters/Setters

        #region Variables de Proveedor al que pertenece Artículo Proveedor
        int _codigoEntidad;
        public int codigoEntidad
        {
            get { return _codigoEntidad; }
            set { this._codigoEntidad = value; }
        }
        string _razonSocialProveedor;
        public string razonSocialProveedor
        {
            get { return _razonSocialProveedor; }
            set { this._razonSocialProveedor = value; }
        }
        #endregion

        string _codigoArticuloProveedor;
        public string codigoArticuloProveedor
        {
            get { return _codigoArticuloProveedor; }
            set { this._codigoArticuloProveedor = value; }
        }

        string _descripcionArticuloProveedor;
        public string descripcionArticuloProveedor
        {
            get { return _descripcionArticuloProveedor; }
            set { this._descripcionArticuloProveedor = value; }
        }

        string _observacionesArticuloProveedor;
        public string observacionesArticuloProveedor
        {
            get { return _observacionesArticuloProveedor; }
            set { this._observacionesArticuloProveedor = value; }
        }

        ModeloValorArticulo _valorVenta;
        public ModeloValorArticulo valorVenta
        {
            get { return _valorVenta; }
            set { this._valorVenta = value; }
        }
        
        ModeloValorArticulo _valorCompraArticuloProveedor;
        public ModeloValorArticulo valorCompraArticuloProveedor
        {
            get { return _valorCompraArticuloProveedor; }
            set { this._valorCompraArticuloProveedor = value; }
        }
        
        //int nullable en caso de que este definido NULL en la base de datos
        int? _stockMinimo;
        public int? stockMinimo
        {
            get { return _stockMinimo; }
            set { this._stockMinimo = value; }
        }
        //int nullable en caso de que este definido NULL en la base de datos
        int? _stockActual;
        public int? stockActual
        {
            get { return _stockActual; }
            set 
            { 
                this._stockActual = value;
                this.fechaActualizacion = DateTime.Today;
            }
        }
        
        //DateTime nullable en caso de que este definido NULL en la base de datos
        DateTime? _fechaActualizacion;
        public DateTime? fechaActualizacion
        {
            get { return _fechaActualizacion; }
            set { this._fechaActualizacion = value; }
        }
        
        
        string _ubicacion;
        public string ubicacion
        {
            get { return _ubicacion; }
            set { this._ubicacion = value; }
        }
        
        #endregion

        #region Validaciones

        public bool validar()
        {
            return (this.validarCodOrig() == true && this.validarCodArtProv() == true && this.validarValores() == true && this.validarStocks() == true
                && this.validarCodEntidad() == true && this.validarRazonSocialProv() == true && this.validarUbicacion() == true);
        }

        private bool validarUbicacion()
        {
            return true;
        }

        private bool validarRazonSocialProv()
        {
            return true;
        }

        private bool validarCodEntidad()
        {
            return true;
        }

        private bool validarStocks()
        {
            return true;
        }

        private bool validarValores()
        {
            return true;
        }

        private bool validarCodArtProv()
        {
            return true;
        }

        private bool validarCodOrig()
        {
            return true;
        }

        #endregion
    }
}
