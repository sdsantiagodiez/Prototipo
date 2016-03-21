using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
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
            set { this._numero = value; }
        }
        /// <summary>
        /// TEL: teléfono fijo; CEL: celular; FAX: fax
        /// </summary>
        string _tipo;
        public string tipo
        {
            get { return _tipo; }
            set { this._tipo = value; }
        }
        #endregion
        #region Validación
        public bool validar()
        {
            return (this.validarCodigo() == true && this.validarTipo() == true && this.validarNumero() == true);
        }

        public bool validarCodigo()
        {
            return true;
        }
        public bool validarTipo()
        {
            return true;
        }
        public bool validarNumero()
        {
            return true;
        }
        #endregion
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

    }
}
