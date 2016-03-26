using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesCompartidas;

namespace Modelos
{
    public class ModeloUsuario : ModeloPersonas
    {
        #region Constructores
        public ModeloUsuario()
        {
            roles = new List<ModeloRoles>();
            this.tipoPersona = Constantes.TiposEntidad.TiposPersona.Usuario;
        }
        public ModeloUsuario(ModeloEntidad p_mod_entidad) : base(p_mod_entidad)
        {
            roles = new List<ModeloRoles>();
            this.tipoPersona = Constantes.TiposEntidad.TiposPersona.Usuario;
        }
        public ModeloUsuario(ModeloPersonas p_mod_persona) : base(p_mod_persona)
        {
            roles = new List<ModeloRoles>();
            this.tipoPersona = Constantes.TiposEntidad.TiposPersona.Usuario;
        }

        public ModeloUsuario(ModeloUsuario p_mod_usuario) : this(p_mod_usuario as ModeloPersonas)
        {
            roles = p_mod_usuario.roles;
            usuario = p_mod_usuario.usuario;
            contrasenia = p_mod_usuario.contrasenia;
        }
        #endregion

        #region Getters/Setters
        string _usuario;
        public string usuario
        {
            get { return _usuario; }
            set { this._usuario = validarUsuario(value) ? value : null; }
        }
        string _contrasenia;
        public string contrasenia
        {
            get { return _contrasenia; }
            set { this._contrasenia = validarContrasenia(value)?value:null; }
            //set { this._contrasenia = validarContrasenia(value)?this.encriptarContraseña(value):null; }
        }
        List<ModeloRoles> _roles;
        public List<ModeloRoles> roles
        {
            get { return _roles; }
            set { this._roles = value; }
        }
        #endregion

        #region Validación
        new public bool validar()
        {
            return base.validar() 
                && validarUsuario(this.usuario) 
                && validarContrasenia(this.contrasenia) 
                && this.validarRoles();
        }

        public static bool validarUsuario(string p_usuario)
        {
            if (!string.IsNullOrWhiteSpace(p_usuario))
            {
                return !System.Text.RegularExpressions.Regex.IsMatch(p_usuario, "[^0-9a-zA-Z_]");
            }
            return false;
            
        }
        public static bool validarContrasenia(string p_contrasenia)
        {
            if (!String.IsNullOrWhiteSpace(p_contrasenia))
            {
                return p_contrasenia.Length >= 8;
            }
            return false;
        }
        public bool validarRoles()
        {
            if (_roles.Count > 0)
            {
                foreach (ModeloRoles rol in _roles)
                {
                    if (!rol.validar())
                    {
                        return false;
                    }
                }
                return true;
            }
            //Usuario debe tener por lo menos 1 rol asignado
            return false;

        }
        #endregion

        #region Equals
        public override bool Equals(object p_objeto)
        {
            if (p_objeto is ModeloUsuario == false)
                return false;
            return Equals((ModeloUsuario)p_objeto);
        }

        public override bool Equals(ModeloPersonas p_mod_persona)
        {
            return base.Equals(p_mod_persona)
                && this.Equals(p_mod_persona as ModeloUsuario);
        }

        public bool Equals(ModeloUsuario p_mod_usuario)
        {
            return this.Equals(this.usuario, p_mod_usuario.usuario)
                && this.Equals(this._contrasenia, p_mod_usuario.contrasenia)
                && this.Equals(this.roles, p_mod_usuario.roles);
        }
        #endregion

        #region Encripción
        /// <summary>
        /// Convierte valor contraseña a su correspondiente hash encriptado
        /// </summary>
        public string encriptarContraseña(string p_contrasenia)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(p_contrasenia);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            return System.Text.Encoding.ASCII.GetString(data);   
        }
        #endregion
    }
}
