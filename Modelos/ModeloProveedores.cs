using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
   public class ModeloProveedores
   {
       #region Getters/Setters
       string _razonSocialProv;
        public string razonSocialProv
        {
            get { return _razonSocialProv; }
            set { this._razonSocialProv = value; }
        }

        string _cuitProv;
        public string cuitProv
        {
            get { return _cuitProv; }
            set { _cuitProv = value; }
        }
       
        string _direccionProv;
        public string direccionProv
        {
            get { return _direccionProv; }
            set { _direccionProv = value; }
        }
       
        string _ciudadProv;
        public string ciudadProv
        {
            get { return _ciudadProv; }
            set { _ciudadProv = value; }
        }

        string _provinciaProv;
        public string provinciaProv
        {
            get { return _provinciaProv; }
            set { _provinciaProv = value; }
        }

        string _codigoPostalProv;
        public string codigoPostalProv
        {
            get { return _codigoPostalProv; }
            set { _codigoPostalProv = value; }
        }
       
        string _obsProv;
        public string obsProv
        {
            get { return _obsProv; }
            set { _obsProv = value; }
        }
       #endregion
   }
}
