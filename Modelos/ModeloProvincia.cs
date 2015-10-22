using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloProvincia
    {
        string _codigo;
        public string codigo
        {
            get { return _codigo; }
            set { this._codigo = value; }
        }
        string _provincia;
        public string provincia
        {
            get { return _provincia; }
            set { this._provincia = value; }
        }
        string _codigoPais;
        public string codigoPais
        {
            get { return _codigoPais; }
            set { _codigoPais = value; }
        }
        public bool validar()
        {
            return (this.validarCodigo() == true && this.validarCodigoPais() == true && this.validarProvincia() == true);
        }
        public bool validarCodigo()
        {
            return true;
        }
        public bool validarProvincia()
        {
            return true;
        }
        public bool validarCodigoPais()
        {
            ModeloPais mPais = new ModeloPais();
            mPais.codigo = codigoPais;
            return mPais.validarCodigo();
        }
        

    }
}
