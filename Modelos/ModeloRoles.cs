using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloRoles
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
    }
}

    
