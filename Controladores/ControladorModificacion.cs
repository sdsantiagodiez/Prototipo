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
        public bool modificar(ModeloArticuloProveedores p_mod_articuloProveedorOriginal, ModeloArticuloProveedores p_mod_articuloProveedorModificado)
        {
            CatalogoArticuloProveedores lcl_cat_articuloProveedores = new CatalogoArticuloProveedores();
            
            bool exito = false;
            if (p_mod_articuloProveedorOriginal.valorCompra.valorArticulo != p_mod_articuloProveedorModificado.valorCompra.valorArticulo)
            {
                exito = lcl_cat_articuloProveedores.updatePrecio(p_mod_articuloProveedorModificado, LibreriaClasesCompartidas.Constantes.TipoValorArticulo.Compra);
                if (!exito)
                {
                    return false;
                }
            }
            
            if (p_mod_articuloProveedorOriginal.valorVenta.valorArticulo != p_mod_articuloProveedorModificado.valorVenta.valorArticulo)
            {
                exito = lcl_cat_articuloProveedores.updatePrecio(p_mod_articuloProveedorModificado, LibreriaClasesCompartidas.Constantes.TipoValorArticulo.Venta);
                if (!exito)
                {
                    return false;
                }
            }
            
            if (this.objetoModificado(p_mod_articuloProveedorOriginal, p_mod_articuloProveedorModificado))
            {
                exito = lcl_cat_articuloProveedores.update(p_mod_articuloProveedorModificado);
                if (!exito)
                {
                    return false;
                }
            }
            //else if (!exito)
            //{
            //    //No se realizaron cambios en ninguno de los tres if's
                    //En caso de que se quiera mostrar mensaje que no ha habido modificaciones
            //    return false;
            //}
            //se realizaron cambios
            return true;
        }

        private bool objetoModificado(ModeloArticuloProveedores p_mod_articuloProveedorOriginal, ModeloArticuloProveedores p_mod_articuloProveedorModificado)
        { 
            return (
                p_mod_articuloProveedorOriginal.observacionesArticuloProveedor!=p_mod_articuloProveedorModificado.observacionesArticuloProveedor ||
                p_mod_articuloProveedorOriginal.stockActual!=p_mod_articuloProveedorModificado.stockActual ||
                p_mod_articuloProveedorOriginal.stockMinimo!=p_mod_articuloProveedorModificado.stockMinimo ||
                p_mod_articuloProveedorOriginal.ubicacion!=p_mod_articuloProveedorModificado.ubicacion 
                );
        }


    }
}
