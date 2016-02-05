using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Datos;

namespace Controladores
{
    public class ControladorBaja : Controlador
    {
        public bool eliminarPersona(ModeloPersonas pmPersona)
        {
            CatalogoPersonas cp = new CatalogoPersonas();

            return cp.remove(pmPersona);
        }
        public bool eliminarProveedor(ModeloProveedor pmProveedor)
        {
            CatalogoProveedores cp = new CatalogoProveedores();

            return cp.remove(pmProveedor);
        }
    }
}
