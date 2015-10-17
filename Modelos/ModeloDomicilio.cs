using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloDomicilio
    {
        #region Getters/Setters
        int _codigoDomicilio;
        public int codigoDomicilio
        {
            get { return _codigoDomicilio; }
            set { this._codigoDomicilio = value; }
        }
        string _calle;
        public string calle
        {
            get { return _calle; }
            set { this._calle = value; }
        }
        string _numero;
        public string numero
        {
            get { return _numero; }
            set { this._numero = value; }
        }string _piso;
        public string piso
        {
            get { return _piso; }
            set { this._piso = value; }
        }
        string _departamento;
        public string departamento
        {
            get { return _departamento; }
            set { this._departamento = value; }
        }
        string _ciudad;
        public string ciudad
        {
            get { return _ciudad; }
            set { this._ciudad = value; }
        }
        string _codigoPostal;
        public string codigoPostal
        {
            get { return _codigoPostal; }
            set { this._codigoPostal = value; }
        }
        ModeloProvincia _provincia;
        public ModeloProvincia provincia
        {
            get { return _provincia; }
            set { this._provincia = value; }
        }
        ModeloPais _pais;
        public ModeloPais pais
        {
            get { return _pais; }
            set { this._pais = value; }
        }
        #endregion
    }
}
