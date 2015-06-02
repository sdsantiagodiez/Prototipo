using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloPersonas
    {
        string _dniPers;
        public string dniPers 
        {
            get{return _dniPers;}
            set{this._dniPers = value;} 
        }
        string _cuitPers;
        public string cuitPers
        {
            get { return _cuitPers; }
            set { this._cuitPers = value; }
        }
        string _nombrePres;
        public string nombrePres
        {
            get { return _nombrePres; }
            set { this._nombrePres = value; }
        }
        string _apellidoPers;
        public string apellidoPers
        {
            get { return _apellidoPers; }
            set { this._apellidoPers = value; }
        }
        string _ciudadPers;
        public string ciudadPers
        {
            get { return _ciudadPers; }
            set { this._ciudadPers = value; }
        }
        string _provinciaPers;
        public string provinciaPers
        {
            get { return _provinciaPers; }
            set { this._provinciaPers = value; }
        }
        string _codigoPostalPers;
        public string codigoPostalPers
        {
            get { return _codigoPostalPers; }
            set { this._codigoPostalPers = value; }
        }
        string _obsPers;
        public string obsPers
        {
            get { return _obsPers; }
            set { this._obsPers = value; }
        }
        string _usuarioPers;
        public string usuarioPers
        {
            get { return _usuarioPers; }
            set { this._usuarioPers = value; }
        }
        string _contraseniaPers;
        public string contraseniaPers
        {
            get { return _contraseniaPers; }
            set { this._contraseniaPers = value; }
        }
        string _razonSocialProv;
        public string razonSocialProv
        {
            get { return _razonSocialProv; }
            set { this._razonSocialProv = value; }
        }
        string _direccPers;
        public string direccPers
        {
            get { return _direccPers; }
            set { this._direccPers = value; }
        }
    }
}
