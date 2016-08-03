using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesCompartidas;
namespace Modelos
{
    [Serializable]
    public class ModeloTelefono : Modelo
    {
        #region Getters/Setters
        int _codigoTelefono;
        public int codigoTelefono
        {
            get { return _codigoTelefono; }
            set { this._codigoTelefono = value; }
        }
        string _numero;
        public string numero
        {
            get { return _numero; }
            set { this._numero = this.convertirString(value); }
        }
       
        string _tipo;
        /// <summary>
        /// Constantes.TipoTelefono
        /// </summary>
        public string tipo
        {
            get { return _tipo; }
            set { _tipo = validarTipo(value) ? value : null; }
        }
        #endregion
        
        #region Validación
        public bool validar()
        {
            return validarTipo(this.tipo);
        }

        
        public static bool validarTipo(string p_tipo)
        {
            return p_tipo == Constantes.TipoTelefono.Celular ||
                   p_tipo == Constantes.TipoTelefono.Fijo ||
                   p_tipo == Constantes.TipoTelefono.Fax;
        }
        #endregion
       
        public override string ToString()
        {
            return this.tipo.ToString() + ", " + this.numero.ToString();
        }

        #region Equals
        public override bool Equals(object p_objeto)
        {
            if (p_objeto is ModeloTelefono == false)
                return false;
            return Equals((ModeloTelefono)p_objeto);
        }

        public bool Equals(ModeloTelefono p_mod_telefono)
        {
            return this.Equals(this.codigoTelefono,p_mod_telefono.codigoTelefono) 
                && this.Equals(this.numero,p_mod_telefono.numero) 
                && this.Equals(this.tipo,p_mod_telefono.tipo);
        }
        #endregion

    }
}
