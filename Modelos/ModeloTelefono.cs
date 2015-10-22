using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloTelefono
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

        public bool validar()
        {
            return true;
        }
    }
}
