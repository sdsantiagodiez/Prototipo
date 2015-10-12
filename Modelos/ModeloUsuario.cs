using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloUsuario : ModeloPersonas
    {
        string _usuario;
        public string usuario
        {
            get { return _usuario; }
            set { this._usuario = value; }
        }
        string _contrasenia;
        public string contrasenia
        {
            get { return _contrasenia; }
            set { this._contrasenia = value; }
        }
        List<ModeloRoles> _roles;
        public List<ModeloRoles> roles
        {
            get { return _roles; }
            set { this._roles = value;}
        }
    }
}
