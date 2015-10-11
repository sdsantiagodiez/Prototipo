using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloArticuloProveedores
    {
        #region Getters/Setters
        string _codigoOriginal;
        public string codigoOriginal 
        {
            get {return _codigoOriginal;} 
            set {this._codigoOriginal = value;} 
        }
        string _codigoArticuloProveedor;
        public string codigoArticuloProveedor
        {
            get { return _codigoArticuloProveedor; }
            set { this._codigoArticuloProveedor = value; }
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
        string _observaciones;
        public string observaciones
        {
            get { return _observaciones; }
            set { this._observaciones = value; }
        }
        //DateTime nullable en caso de que este definido NULL en la base de datos
        DateTime? _fechaActualizacion;
        public DateTime? fechaActualizacion
        {
            get { return _fechaActualizacion; }
            set { this._fechaActualizacion = value; }
        }
        string _razonSocialProveedor;
        public string razonSocialProveedor
        {
            get { return _razonSocialProveedor; }
            set { this._razonSocialProveedor = value; }
        }
        string _descripcion;
        public string descripcion
        {
            get { return _descripcion; }
            set { this._descripcion = value; }
        }
        string _ubicacion;
        public string ubicacion
        {
            get { return _ubicacion; }
            set { this._ubicacion = value; }
        }
        #endregion
    }
}
