using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
   public class ModeloProveedor : ModeloEntidad
   {
       #region Constructores
       public ModeloProveedor()
        {
            this.tipoEntidad = LibreriaClasesCompartidas.Constantes.TiposEntidad.Proveedor;
        }

       public ModeloProveedor(ModeloEntidad p_mod_entidad) : base(p_mod_entidad)
        {
            this.tipoEntidad = LibreriaClasesCompartidas.Constantes.TiposEntidad.Proveedor;
        }

       public ModeloProveedor(ModeloProveedor p_mod_proveedor) : this(p_mod_proveedor as ModeloEntidad)
        {
            razonSocial = p_mod_proveedor.razonSocial;
        }
       #endregion

       #region Getters/Setters
        string _razonSocial;
        public string razonSocial
        {
            get { return _razonSocial; }
            set { this._razonSocial = this.convertirString(value); }
        }
        #endregion
       
       #region Validación
        new public bool validar()
        {
            return base.validar() 
                && validarRazonSocial(this.razonSocial);
        }

        public static bool validarRazonSocial(string p_razonSocial)
        {
            if (Modelo.convertString(p_razonSocial) != null)
            {
                return true;
            }
            return false;
        }
        #endregion
        
       #region Equals
        public override bool Equals(object p_objeto)
        {
            if (p_objeto is ModeloProveedor == false)
                return false;
            return Equals((ModeloProveedor)p_objeto);
        }

        public override bool Equals(ModeloEntidad p_mod_entidad)
        {
            return base.Equals(p_mod_entidad)
                && this.Equals(p_mod_entidad as ModeloProveedor);
        }

        public bool Equals(ModeloProveedor p_mod_proveedor)
        {
            return this.Equals(this.razonSocial,p_mod_proveedor.razonSocial);
        }
        #endregion
   }
}
