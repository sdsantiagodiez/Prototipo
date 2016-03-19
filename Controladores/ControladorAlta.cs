using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;
using System.Text.RegularExpressions;


namespace Controladores
{
    public class ControladorAlta : Controlador
    {
        public bool agregar(ref ModeloEntidad p_mod_entidad)
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

            return lcl_catalogo.add(ref p_mod_entidad);
        }


        public bool agregar(ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            CatalogoArticuloProveedores lcl_cat_articuloProveedores = new CatalogoArticuloProveedores();
            return lcl_cat_articuloProveedores.add(p_mod_articuloProveedor);
        }
        public bool agregar(ModeloArticulos p_mod_articulo)
        {
            CatalogoArticulos lcl_cat_articulos = new CatalogoArticulos();
            return lcl_cat_articulos.add(p_mod_articulo);
        }
        /// <summary>
        /// Se debería usar este método en vez de lo implementado en la capa Datos CatalogoEntidades
        /// </summary>
        /// <param name="p_mod_domicilio"></param>
        /// <returns></returns>
        private bool agregar(ModeloDomicilio p_mod_domicilio,int p_codigoEntidad)
        {
            CatalogoDomicilios lcl_cat_domicilios = new CatalogoDomicilios();
            if (p_mod_domicilio.validar())
            {
                return lcl_cat_domicilios.add(p_mod_domicilio, p_codigoEntidad);
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Agrega lineas de pedido a la capa de datos
        /// </summary>
        /// <param name="p_mod_lineaPedido"></param>
        /// <returns></returns>
        public bool agregar(ModeloLineaPedido p_mod_lineaPedido)
        {
            CatalogoLineasPedidos lcl_cat_lineasPedidos = new CatalogoLineasPedidos();
            return lcl_cat_lineasPedidos.add(p_mod_lineaPedido);
        }
        /// <summary>
        /// Se debería usar este método en vez de lo implementado en la capa Datos CatalogoEntidades
        /// </summary>
        /// <param name="p_mod_mail"></param>
        /// <param name="p_codigoEntidad"></param>
        /// <returns></returns>
        private bool agregar(ModeloMail p_mod_mail, int p_codigoEntidad)
        {
            CatalogoMails lcl_cat_mails = new CatalogoMails();
            return lcl_cat_mails.add(p_mod_mail, p_codigoEntidad);
        }
        public bool agregar(ModeloPais p_mod_pais)
        {
            CatalogoPaises lcl_cat_paises = new CatalogoPaises();
            return false;
        }
        /// <summary>
        /// Agrega pedido con sus lineas de pedido correspondientes a la capa de datos
        /// </summary>
        /// <param name="p_mod_pedido"></param>
        /// <returns></returns>
        public bool agregar(ref ModeloPedido p_mod_pedido)
        {
            CatalogoPedidos lcl_cat_pedidos = new CatalogoPedidos();
            if (p_mod_pedido.validar())
            {
                //Ver que hacer si se agrega el pedido correctamente, pero hay problemas en agregar alguna linea de pedido. Try catch?
                if (lcl_cat_pedidos.add(ref p_mod_pedido))
                {
                    foreach (ModeloLineaPedido lp in p_mod_pedido.lineasPedido)
                    {
                        lp.numeroPedido = p_mod_pedido.numeroPedido;
                        this.agregar(lp);
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }
      
        ///// <summary>
        ///// Agrega persona a la capa de datos
        ///// </summary>
        ///// <param name="p_mod_persona"></param>
        ///// <returns></returns>
        //public bool agregar(ref ModeloPersonas p_mod_persona)
        //{
        //    CatalogoPersonas lcl_cat_personas = new CatalogoPersonas();

        //    if (p_mod_persona.validar())
        //    {
        //        return true;// lcl_cat_personas.add(ref p_mod_persona);
        //        //CAMBIOS
        //    }
        //    else
        //    {
        //        return false;
        //    }   
        //}
        ///// <summary>
        ///// Agrega proveedor a la capa de datos
        ///// </summary>
        ///// <param name="p_mod_proveedor"></param>
        ///// <returns></returns>
        //public bool agregar(ref ModeloProveedor p_mod_proveedor)
        //{
        //    CatalogoProveedores lcl_cat_proveedores = new CatalogoProveedores();

        //    if (p_mod_proveedor.validar())
        //    {
        //        return true;// lcl_cat_proveedores.add(ref p_mod_proveedor);
        //        //CAMBIOS
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        
        public bool agregar(ModeloProvincia p_mod_provincia)
        {
            CatalogoProvincias lcl_cat_provincias = new CatalogoProvincias();
            return false;
        }
        /// <summary>
        /// Se debería usar este método en vez de lo implementado en la capa Datos CatalogoEntidades.
        /// </summary>
        /// <param name="p_mod_telefono"></param>
        /// <returns></returns>
        private bool agregar(ModeloTelefono p_mod_telefono, int p_codigoEntidad)
        {
            CatalogoTelefonos lcl_cat_telefonos = new CatalogoTelefonos();
            return lcl_cat_telefonos.add(p_mod_telefono, p_codigoEntidad);
        }
        private bool agregar(ModeloValorArticulo p_mod_valorArticulo)
        {
            return false;
        }
    }
}
