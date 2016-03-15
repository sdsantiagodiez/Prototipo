using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;

namespace Controladores
{
    public class ControladorModificacion : Controlador
    {
        public bool modificar(ModeloPersonas p_mod_persona)
        {
            CatalogoPersonas lcl_cat_personas = new CatalogoPersonas();
            if (p_mod_persona.validar())
            {
                return lcl_cat_personas.update(p_mod_persona);
            }
            else
            {
                return false;
            }
        }
        public bool modificar(ModeloProveedor p_mod_proveedor)
        {
            CatalogoProveedores lcl_cat_proveedores = new CatalogoProveedores();
            if (p_mod_proveedor.validar())
            {
                return lcl_cat_proveedores.update(p_mod_proveedor);
            }
            else
            {
                return false;
            }
        }

        public bool modificar(ModeloArticulos p_mod_articulo)
        {
            CatalogoArticulos lcl_cat_articulos = new CatalogoArticulos();
            
            return lcl_cat_articulos.update(p_mod_articulo);

        }
        public bool modificar(ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            CatalogoArticuloProveedores lcl_cat_articuloProveedores = new CatalogoArticuloProveedores();
            if (p_mod_articuloProveedor.validar())
            {
                return lcl_cat_articuloProveedores.update(p_mod_articuloProveedor);
            }
            else
            {
                return false;
            }
        }
    }
}
