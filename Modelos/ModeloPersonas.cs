using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesCompartidas;

namespace Modelos
{
    /// <summary>
    /// Una persona puede ser un cliente, contacto de proveedor o usuario de sistema
    /// </summary>
    public class ModeloPersonas : ModeloEntidad
    {
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
        /// Ver Constantes.TipoEntidad.TipoPersona
        /// </summary>
        string _tipoPersona;
        public string tipoPersona
        {
            get { return _tipoPersona; }
            set { this._tipoPersona = value; }
        }

        #endregion

        new public void convertirDatos()
        {
            base.convertirDatos();
            dni = this.convertirString(dni);
            nombre = this.convertirString(nombre);
            apellido = this.convertirString(apellido);
        }
        /// <summary>
        /// Valida todos los atributos de la persona
        /// </summary>
        /// <returns>true si todos son válidos. False si al menos uno no es válido</returns>
        new public virtual bool validar()
        {
            return (base.validar() && this.validarDNI() && this.validarNombre() 
                && this.validarApellido() && this.validarTipoPersona() );
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
        public bool validarTipoPersona()
        {
            return (tipoPersona == Constantes.TiposEntidad.TiposPersona.Cliente ||
                tipoPersona == Constantes.TiposEntidad.TiposPersona.Usuario ||
                tipoPersona == Constantes.TiposEntidad.TiposPersona.ContactoProveedor);   
        }
    }
}
