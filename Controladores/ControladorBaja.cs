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
        public bool eliminar(ModeloEntidad p_mod_entidad)
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

            return lcl_catalogo.remove(p_mod_entidad);
        }


        ////public bool eliminar(ModeloPersonas p_mod_persona)
        ////{
        ////    CatalogoPersonas lcl_cat_personas = new CatalogoPersonas();

        ////    return lcl_cat_personas.remove(p_mod_persona);
        ////}
        ////public bool eliminar(ModeloProveedor p_mod_proveedor)
        ////{
        ////    CatalogoProveedores lcl_cat_proveedores = new CatalogoProveedores();

        ////    return lcl_cat_proveedores.remove(p_mod_proveedor);
        ////}

        public bool eliminar(ModeloArticulos p_mod_articulo)
        {
            CatalogoArticulos lcl_cat_articulos = new CatalogoArticulos();

            return lcl_cat_articulos.remove(p_mod_articulo);
        }

        public bool eliminar(ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            CatalogoArticuloProveedores lcl_cat_articuloProveedores = new CatalogoArticuloProveedores();

            return lcl_cat_articuloProveedores.remove(p_mod_articuloProveedor);
        }
    }
}
