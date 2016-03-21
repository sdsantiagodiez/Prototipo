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
            set { this._codigo = value; }
        }
        string _pais;
        public string pais
        {
            get { return _pais; }
            set { this._pais = value; }
        }
        #endregion
        #region Validación
        public bool validar()
        {
            return (this.validarCodigo() == true && this.validarPais() == true);
        }
        public bool validarCodigo()
        {
            return true;
        }
        public bool validarPais()
        {
            return true;
        }
        #endregion
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
    }
}
