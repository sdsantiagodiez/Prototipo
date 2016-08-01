using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesCompartidas;

namespace Modelos
{
    [Serializable]
    /// <summary>
    /// Una persona puede ser un cliente, contacto de proveedor o usuario de sistema
    /// </summary>
    public class ModeloPersonas : ModeloEntidad
    {
        #region Atributos
        string _dni;
        public string dni
        {
            get { return _dni; }
            set { this._dni = validarDNI(value) ? normalizarDNI(value) : null; }
        }
        string _nombre;
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = validarNombre(value) ? this.convertirString(value) : null; }
        }
        string _apellido;
        public string apellido
        {
            get { return _apellido; }
            set { _apellido = validarApellido(value) ? this.convertirString(value) : null; }
        }
        /// <summary>
        /// Ver Constantes.TipoEntidad.TipoPersona
        /// </summary>
        string _tipoPersona;
        public string tipoPersona
        {
            get { return _tipoPersona; }
            set { _tipoPersona = validarTipoPersona(value) ? value : null; }
        }

        #endregion

        #region Constructores
        public ModeloPersonas()
        {
            this.tipoEntidad = Constantes.TiposEntidad.Persona;
        }

        public ModeloPersonas(ModeloEntidad p_mod_entidad) : base(p_mod_entidad) 
        {
            this.tipoEntidad = Constantes.TiposEntidad.Persona;
        }

        public ModeloPersonas(ModeloPersonas p_mod_persona) : this(p_mod_persona as ModeloEntidad)
        {
            dni = p_mod_persona.dni;
            nombre = p_mod_persona.nombre;
            apellido = p_mod_persona.apellido;
            tipoPersona = p_mod_persona.tipoPersona;
        }
        #endregion

        #region Validación
        /// <summary>
        /// Valida todos los atributos de la persona
        /// </summary>
        /// <returns>true si todos son válidos. False si al menos uno no es válido</returns>
        new public bool validar()
        {
            return base.validar()
                && validarDNI(this.dni) 
                && validarNombre(this.nombre) 
                && validarApellido(this.apellido) 
                && this.validarTipoPersona(this.tipoPersona);
        }

        public static bool validarDNI(string p_dni)
        {
            p_dni = Modelo.convertString(p_dni);
            if (p_dni != null && !System.Text.RegularExpressions.Regex.IsMatch(p_dni, @"[^0-9\.]"))
            {
                return true;
            }
            return false;
        }
        public static bool validarApellido(string p_apellido)
        {
            if (Modelo.convertString(p_apellido) != null)
            {
                return true;
            }
            return false;
        }
        public static bool validarNombre(string p_nombre)
        {
            if (Modelo.convertString(p_nombre) != null)
            {
                return true;
            }
            return false;
        } 
        public bool validarTipoPersona(string p_tipoPersona)
        {
            if (p_tipoPersona == Constantes.TiposEntidad.TiposPersona.Cliente ||
                p_tipoPersona == Constantes.TiposEntidad.TiposPersona.ContactoProveedor ||
                p_tipoPersona == Constantes.TiposEntidad.TiposPersona.Usuario)
            {
                return true; 
            }
            return false;   
        }
        #endregion

        static public string normalizarDNI(string p_dni)
        {
            p_dni = p_dni.Replace(".", string.Empty);
            int longitud = p_dni.Length;
            if (longitud > 3)
            {
                p_dni = p_dni.Insert(longitud - 3, ".");
                if (longitud > 6)
                    p_dni = p_dni.Insert(longitud - 6, ".");

            }
            return p_dni;
        }

        public override string ToString()
        {
            string normalizado = "";

            normalizado += this.apellido;
            if (this.apellido != null)
            {
                normalizado += ", ";
            }
            normalizado += this.nombre;

            return normalizado;
        }

        #region Equals
        public override bool Equals(object p_objeto)
        {
            if (p_objeto is ModeloPersonas == false)
                return false;
            return Equals((ModeloPersonas)p_objeto);
        }

        public override bool Equals(ModeloEntidad p_mod_entidad)
        {
            return base.Equals(p_mod_entidad)
                && this.Equals(p_mod_entidad as ModeloPersonas);
        }

        public virtual bool Equals(ModeloPersonas p_mod_persona)
        {
            return this.Equals(this.apellido,p_mod_persona.apellido)
                && this.Equals(this.nombre,p_mod_persona.nombre)
                && this.Equals(this.dni,p_mod_persona.dni)
                && this.Equals(this.tipoPersona,p_mod_persona.tipoPersona);
        }
        #endregion
    }
}
