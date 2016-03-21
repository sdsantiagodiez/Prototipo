﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
   public class ModeloProveedor : ModeloEntidad
   {
        #region Getters/Setters
       string _razonSocial;
        public string razonSocial
        {
            get { return _razonSocial; }
            set { this._razonSocial = value; }
        }
       #endregion

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
        new public void convertirDatos()
        {
            base.convertirDatos();
            razonSocial = this.convertirString(razonSocial);
        }
        #region Validación
        new public bool validar()
        {
            return (base.validar() == true && this.validarRazonSocial() == true);
        }

        public bool validarRazonSocial()
        {
            return true;
        }
        #endregion

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
   }
}
