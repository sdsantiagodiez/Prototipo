using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesCompartidas;

namespace Modelos
{
    public class ModeloContactoProveedor : ModeloPersonas
    {
        public ModeloContactoProveedor()
        {
            this.tipoPersona = Constantes.TiposEntidad.TiposPersona.ContactoProveedor;
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

        #region Getters/Setters
        private ModeloProveedor _proveedor;
        public ModeloProveedor proveedor
        {
            get { return _proveedor; }
            set { _proveedor = value; }
        }
        #endregion

        public bool validar()
        {
            return (base.validar() && this.validarProveedor());
        }

        public bool validarProveedor()
        {
            return true;
        }
    }
}
