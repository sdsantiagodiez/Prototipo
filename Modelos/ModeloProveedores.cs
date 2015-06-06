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
       string _razonSocial;
        public string razonSocial
        {
            get { return _razonSocial; }
            set { this._razonSocial = value; }
        }

        string _cuit;
        public string cuit
        {
            get { return _cuit; }
            set { _cuit = value; }
        }
       
        string _direccion;
        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
       
        string _ciudad;
        public string ciudad
        {
            get { return _ciudad; }
            set { _ciudad = value; }
        }

        string _provincia;
        public string provincia
        {
            get { return _provincia; }
            set { _provincia = value; }
        }

        string _codigoPostal;
        public string codigoPostal
        {
            get { return _codigoPostal; }
            set { _codigoPostal = value; }
        }
       
        string _observaciones;
        public string observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }
       #endregion
   }
}
