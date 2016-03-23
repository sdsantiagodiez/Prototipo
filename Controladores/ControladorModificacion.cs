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
        public bool modificar(ModeloEntidad p_mod_entidad)
        {
            Type T = p_mod_entidad.GetType();
            CatalogoEntidades lcl_catalogo;
            if (T == typeof(ModeloCliente))
            {
                lcl_catalogo = new CatalogoClientes();
            }
            else if (T == typeof(ModeloUsuario))
            {
                lcl_catalogo = new CatalogoUsuarios();
            }
            else if (T == typeof(ModeloContactoProveedor))
            {
                lcl_catalogo = new CatalogoContactoProveedores();
            }
            else if (T == typeof(ModeloProveedor))
            {
                lcl_catalogo = new CatalogoProveedores();
            }
            else if (T == typeof(ModeloPersonas))
            {
                lcl_catalogo = new CatalogoPersonas();
            }
            else
            {
                lcl_catalogo = new CatalogoEntidades();
            }
            return lcl_catalogo.update(p_mod_entidad);
        }


        //public bool modificar(ModeloPersonas p_mod_persona)
        //{
        //    CatalogoPersonas lcl_cat_personas = new CatalogoPersonas();
        //    if (p_mod_persona.validar())
        //    {
        //        return lcl_cat_personas.update(p_mod_persona);
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public bool modificar(ModeloProveedor p_mod_proveedor)
        //{
        //    CatalogoProveedores lcl_cat_proveedores = new CatalogoProveedores();
        //    if (p_mod_proveedor.validar())
        //    {
        //        return lcl_cat_proveedores.update(p_mod_proveedor);
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

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
