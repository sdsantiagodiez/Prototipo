using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    [Serializable]
    public class ModeloProvincia : Modelo
    {
        #region Getters/Setters
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
            set { this._provincia = this.convertirString(value); }
        }
        string _codigoPais;
        public string codigoPais
        {
            get { return _codigoPais; }
            set { _codigoPais = ModeloPais.validarCodigo(value) ? value : null; }
        }
        #endregion

        #region Validación
        public bool validar()
        {
            return this.validarCodigo()
                && ModeloPais.validarCodigo(this.codigoPais)
                && validarProvincia(this.provincia);
        }
        public bool validarCodigo()
        {
            return !string.IsNullOrWhiteSpace(this.codigoPais);
        }
        public static bool validarProvincia(string p_provincia)
        {
            return !string.IsNullOrWhiteSpace(p_provincia);
        }
        #endregion

        #region Equals
        public override bool Equals(object p_objeto)
        {
            if (p_objeto is ModeloProvincia == false)
                return false;
            return Equals((ModeloProvincia)p_objeto);
        }

        public bool Equals(ModeloProvincia p_mod_provincia)
        {
            return this.Equals(this.codigo,p_mod_provincia.codigo) 
                && this.Equals(this.provincia,p_mod_provincia.provincia) 
                && this.Equals(this.codigoPais,p_mod_provincia.codigoPais);
        }
        #endregion

        public override string ToString()
        {
            return this.provincia;
        }
    }
}
