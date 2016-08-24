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
        #region Atributos
        int _codigoTipoResponsable;
        public int codigoTipoResponsable
        {
            get { return _codigoTipoResponsable; }
            set { _codigoTipoResponsable = value; }
        }
        string _razonSocial;
        public string razonSocial
        {
            get { return _razonSocial; }
            set { this._razonSocial = this.convertirString(value); }
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

        public override string ToString()
        {
            string str_base = base.ToString();
            if (String.IsNullOrWhiteSpace(str_base))
            {
                return razonSocial;
            }
            if (String.IsNullOrWhiteSpace(razonSocial))
            {
                return str_base;
            }
            else
            {
                return razonSocial + ", " + str_base;
            }
        }

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
            return string.Equals(this.razonSocial,p_mod_cliente.razonSocial);
        }
        #endregion
    }
}
