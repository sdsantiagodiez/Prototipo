using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    /// <summary>
    /// Una persona puede ser un cliente, contacto de proveedor o usuario de sistema
    /// </summary>
    public class ModeloPersonas : ModeloEntidad
    {
        #region Getters/Setters
        string _dni;
        public string dni 
        {
            get{return _dni;}
            set{this._dni = value;} 
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
        /// <summary>
        /// CLI: CLIENTE;
        /// USR: USUARIO;
        /// CON: CONTACTO DE PROVEEDOR;
        /// </summary>
        string _tipoPersona;
        public string tipoPersona
        {
            get { return _tipoPersona; }
            set { this._tipoPersona = value; }
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
        List<ModeloRoles> _roles;
        public List<ModeloRoles> roles
        {
            get { return _roles; }
            set { this._roles = value; }
        }
        #endregion
    }
}
