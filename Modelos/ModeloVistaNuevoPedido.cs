using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloVistaNuevoPedido
    {
        #region Getters/Setters
        string _codigoOriginal;
        public string codigoOriginal
        {
            get { return _codigoOriginal; }
            set { this._codigoOriginal = value; }
        }
        string _codigoArticuloProveedor;
        public string codigoArticuloProveedor
        {
            get { return _codigoArticuloProveedor; }
            set { this._codigoArticuloProveedor = value; }
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
        
        decimal _valorVenta;
        public decimal valorVenta
        {
            get { return _valorVenta; }
            set { this._valorVenta = value; }
        }
        #endregion
    }
}
