using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloPersonas
    {
        #region Getters/Setters
        string _dni;
        public string dni 
        {
            get{return _dni;}
            set{this._dni = value;} 
        }
        string _cuit;
        public string cuit
        {
            get { return _cuit; }
            set { this._cuit = value; }
        }
        string _nombre;
        public string nombre
        {
            get { return _nombre; }
            set { this._nombre = value; }
        }
        string _apellido;
        public string apellido
        {
            get { return _apellido; }
            set { this._apellido = value; }
        }
        string _ciudad;
        public string ciudad
        {
            get { return _ciudad; }
            set { this._ciudad = value; }
        }
        string _provincia;
        public string provincia
        {
            get { return _provincia; }
            set { this._provincia = value; }
        }
        string _codigoPostal;
        public string codigoPostal
        {
            get { return _codigoPostal; }
            set { this._codigoPostal = value; }
        }
        string _observaciones;
        public string observaciones
        {
            get { return _observaciones; }
            set { this._observaciones = value; }
        }
        string _usuario;
        public string usuario
        {
            get { return _usuario; }
            set { this._usuario = value; }
        }
        string _contrasenia;
        public string contrasenia
        {
            get { return _contrasenia; }
            set { this._contrasenia = value; }
        }
        string _razonSocialProv;
        public string razonSocialProv
        {
            get { return _razonSocialProv; }
            set { this._razonSocialProv = value; }
        }
        string _direccion;
        public string direccion
        {
            get { return _direccion; }
            set { this._direccion = value; }
        }
        #endregion
    }
}
