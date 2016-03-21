using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloRoles : Modelo
    {
        
        #region Getters/Setters
        int _codigo;
        public int codigo
        {
            get { return _codigo; }
            set { this._codigo = value;}
        }

        string _descripcion;
        public string descripcion
        {
            get { return _descripcion; }
            set { this._descripcion = value; }
        }
        #endregion
        
        #region Validación
        public bool validar()
        {
            return (this.validarCodigo() == true && this.validarDescripcion() == true);
        }

        public bool validarDescripcion()
        {
            return true;
        }
        
        public bool validarCodigo()
        {
            return true;
        }
        #endregion
        
        public override bool Equals(object p_objeto)
        {
            if (p_objeto is ModeloRoles == false)
                return false;
            return Equals((ModeloRoles)p_objeto);
        }

        public bool Equals(ModeloRoles p_mod_rol)
        {
            return this.Equals(this.codigo,p_mod_rol.codigo) 
                && this.Equals(this.descripcion, p_mod_rol.descripcion);
        }
    }
}

    
