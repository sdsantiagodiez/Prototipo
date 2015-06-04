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
        string _codigoOriginalArt;
        public string codigoOriginalArt 
        {
            get {return _codigoOriginalArt;} 
            set {this._codigoOriginalArt = value;} 
        }
        string _codigoArtProveedor;
        public string codigoArtProveedor
        {
            get { return _codigoArtProveedor; }
            set { this._codigoArtProveedor = value; }
        }

        ModeloValorArticulo _valorVentaArticuloProveedor;
        public ModeloValorArticulo valorVentaArticuloProveedor
        {
            get { return _valorVentaArticuloProveedor; }
            set { this._valorVentaArticuloProveedor = value; }
        }
        ModeloValorArticulo _valorCompraArticuloProveedor;
        public ModeloValorArticulo valorCompraArticuloProveedor
        {
            get { return _valorCompraArticuloProveedor; }
            set { this._valorCompraArticuloProveedor = value; }
        }

        int _stockMinimoArtPro;
        public int stockMinimoArtPro
        {
            get { return _stockMinimoArtPro; }
            set { this._stockMinimoArtPro = value; }
        }
        int _stockActualArtPro;
        public int stockActualArtPro
        {
            get { return _stockActualArtPro; }
            set 
            { 
                this._stockActualArtPro = value;
                this.fechaUltimaActualizacionArtPro = DateTime.Today;
            }
        }
        string _obsArtPro;
        public string obsArtPro
        {
            get { return _obsArtPro; }
            set { this._obsArtPro = value; }
        }
        DateTime _fechaUltimaActualizacionArtPro;
        public DateTime fechaUltimaActualizacionArtPro
        {
            get { return _fechaUltimaActualizacionArtPro; }
            set { this._fechaUltimaActualizacionArtPro = value; }
        }
        string _razonSocialProv;
        public string razonSocialProv
        {
            get { return _razonSocialProv; }
            set { this._razonSocialProv = value; }
        }
        string _descripArtPro;
        public string descripArtPro
        {
            get { return _descripArtPro; }
            set { this._descripArtPro = value; }
        }
        #endregion
    }
}
