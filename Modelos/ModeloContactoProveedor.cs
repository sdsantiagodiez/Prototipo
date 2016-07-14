using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesCompartidas;

namespace Modelos
{
    [Serializable]
    public class ModeloContactoProveedor : ModeloPersonas
    {
        #region Constructores
        public ModeloContactoProveedor()
        {
            this.tipoPersona = Constantes.TiposEntidad.TiposPersona.ContactoProveedor;
            this.proveedor = new ModeloProveedor();
        }

        public ModeloContactoProveedor(ModeloEntidad p_mod_entidad) : base(p_mod_entidad)
        {
            this.tipoPersona = Constantes.TiposEntidad.TiposPersona.ContactoProveedor;
        }

        public ModeloContactoProveedor(ModeloPersonas p_mod_persona) : base(p_mod_persona)
        {
            this.tipoPersona = Constantes.TiposEntidad.TiposPersona.ContactoProveedor;
        }

        public ModeloContactoProveedor(ModeloContactoProveedor p_mod_contactoProveedor) : this(p_mod_contactoProveedor as ModeloPersonas)
        {
            proveedor = p_mod_contactoProveedor.proveedor;
        }

        public ModeloContactoProveedor(ModeloPersonas p_mod_persona, ModeloProveedor p_mod_proveedor) : this(p_mod_persona)
        {
            this.proveedor = p_mod_proveedor;
        }
        #endregion
        
        #region Getters/Setters
        private ModeloProveedor _proveedor;
        public ModeloProveedor proveedor
        {
            get { return _proveedor; }
            set { _proveedor = this.validarProveedor(value) ? value : null; }
        }
        #endregion

        #region Validación
        new public bool validar()
        {
            return base.validar() 
                && this.validarProveedor(proveedor);
        }

        public bool validarProveedor(ModeloProveedor p_mod_proveedor)
        {
            if (p_mod_proveedor != null)
            {
                return p_mod_proveedor.validar();
            }
            return false;
        }
        #endregion

        #region Equals
        public override bool Equals(object p_objeto)
        {
            if (p_objeto is ModeloContactoProveedor == false)
                return false;
            return Equals((ModeloContactoProveedor)p_objeto);
        }

        public override bool Equals(ModeloPersonas p_mod_persona)
        {
            return base.Equals(p_mod_persona)
                && this.Equals(p_mod_persona as ModeloContactoProveedor);
        }

        public bool Equals(ModeloContactoProveedor p_mod_contactoProveedor)
        {
            return this.Equals(this.proveedor, p_mod_contactoProveedor.proveedor);
        }
        #endregion
    }
}
