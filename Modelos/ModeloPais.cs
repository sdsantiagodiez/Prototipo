using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloPais : Modelo
    {
        #region Getters/Setters
        string _codigo;
        public string codigo
        {
            get { return _codigo; }
            set { this._codigo = validarCodigo(value) ? value : null; }
        }
        string _pais;
        public string pais
        {
            get { return _pais; }
            set { _pais = this.convertirString(value);
            }
        }
        #endregion

        #region Validación
        public bool validar()
        {
            return validarCodigo(this.codigo) 
                && validarPais(this.pais);
        }
        public static bool validarCodigo(string p_codigo)
        {
            return !string.IsNullOrWhiteSpace(p_codigo);
        }
        public static bool validarPais(string p_pais)
        {
            return !string.IsNullOrWhiteSpace(p_pais);
        }
        #endregion

        #region Equals
        public override bool Equals(object p_objeto)
        {
            if (p_objeto is ModeloPais == false)
                return false;
            return Equals((ModeloPais)p_objeto);
        }

        public bool Equals(ModeloPais p_mod_pais)
        {
            return this.Equals(this.codigo,p_mod_pais.codigo) 
                && this.Equals(this.pais,p_mod_pais.pais);
        }
        #endregion

        public override string ToString()
        {
            return this.pais;
        }
    }
}
