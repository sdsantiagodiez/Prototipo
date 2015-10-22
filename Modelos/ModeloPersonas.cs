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

        new public void convertirDatos()
        {
            base.convertirDatos();
            dni = this.convertirString(dni);
            nombre = this.convertirString(nombre);
            apellido = this.convertirString(apellido);
            usuario = this.convertirString(usuario);
        }
        /// <summary>
        /// Valida todos los atributos de la persona
        /// </summary>
        /// <returns>true si todos son válidos. False si al menos uno no es válido</returns>
        new public bool validar()
        {
            return (base.validar() == true && this.validarDNI() == true && this.validarNombre() == true
                && this.validarApellido() == true && this.validarUsuario() == true && this.validarContrasenia() == true
                && this.validarRoles() == true && this.validarTipoPersona() == true);
        }

        public bool validarDNI()
        {
            return true;
        }
        public bool validarApellido()
        {
            return true;
        }
        public bool validarNombre()
        {
            return true;
        }
        public bool validarUsuario()
        {
            return true;
        }
        public bool validarContrasenia()
        {
            return true;
        }
        public bool validarRoles()
        {
            if(tipoPersona == "USR")
            {
                if(roles.Count > 0)
                {
                    foreach(ModeloRoles rol in roles)
                    {
                        if(rol.validar()== false )
                        {
                            return false;
                        }
                    }
                    return true;
                }
                    //Usuario debe tener por lo menos 1 rol asignado
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
        public bool validarTipoPersona()
        {
            if(tipoPersona == "CLI" || tipoPersona == "USR" || tipoPersona == "CON")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
