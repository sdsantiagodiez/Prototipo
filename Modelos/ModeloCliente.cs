using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesCompartidas;

namespace Modelos
{
    public class ModeloCliente: ModeloPersonas
    {
        public ModeloCliente()
        {
            this.tipoPersona = Constantes.TiposEntidad.TiposPersona.Cliente;
        }

        public ModeloCliente(ModeloEntidad p_mod_entidad) : base(p_mod_entidad)
        {
            this.tipoPersona = Constantes.TiposEntidad.TiposPersona.Cliente;
        }

        public ModeloCliente(ModeloPersonas p_mod_persona) : base(p_mod_persona)
        {
            this.tipoPersona = Constantes.TiposEntidad.TiposPersona.Cliente;
        }

        override public bool validar()
        {
            return base.validar();
        }
    }
}
