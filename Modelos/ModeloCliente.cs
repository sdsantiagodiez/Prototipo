using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesCompartidas;

namespace Modelos
{
    [Serializable]
    public class ModeloCliente: ModeloPersonas
    {
        #region Getters/Setters
        int _codigoTipoResponsable;
        int codigoTipoResponsable
        {
            get { return _codigoTipoResponsable; }
            set { _codigoTipoResponsable = value; }
        }
        #endregion

        #region Constructores
        public ModeloCliente()
        {
            this.tipoPersona = Constantes.TiposEntidad.TiposPersona.Cliente;
            codigoTipoResponsable = 5;//Consumidor Final por defecto
        }

        public ModeloCliente(ModeloEntidad p_mod_entidad) : base(p_mod_entidad)
        {
            this.tipoPersona = Constantes.TiposEntidad.TiposPersona.Cliente;
            codigoTipoResponsable = 5;//Consumidor Final por defecto
        }

        public ModeloCliente(ModeloPersonas p_mod_persona) : base(p_mod_persona)
        {
            this.tipoPersona = Constantes.TiposEntidad.TiposPersona.Cliente;
            codigoTipoResponsable = 5;//Consumidor Final por defecto
        }
        #endregion

        #region Validación
        new public bool validar()
        {
            return base.validar() && this.validarCodigoTipoResponsable(this.codigoTipoResponsable);
        }
        private bool validarCodigoTipoResponsable(int p_codigo)
        {
            return p_codigo > 0 && p_codigo < 15;
        }
        #endregion

        #region Equals
        public override bool Equals(object p_objeto)
        {
            if (p_objeto is ModeloCliente == false)
                return false;
            return Equals((ModeloCliente)p_objeto);
        }

        public override bool Equals(ModeloPersonas p_mod_persona)
        {
            return base.Equals(p_mod_persona)
                && this.Equals(p_mod_persona as ModeloCliente);
        }

        public bool Equals(ModeloCliente p_mod_cliente)
        {
            return true;
        }
        #endregion
    }
}
