﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;
using System.Text.RegularExpressions;
using System.Transactions;


namespace Controladores
{
    public class ControladorAlta : Controlador
    {
        public bool agregar(List<object> p_lista)
        {
            if (p_lista.Count < 1)
            {
                return true;
            }
            bool respuesta = false;
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    string mensaje= "";
                    foreach (object o in p_lista)
                    {
                        if (!this.agregar(o, out mensaje))
                        {
                            throw new Exception(mensaje);
                        }
                    }
                    respuesta = true;
                    scope.Complete();
                }
            }
            catch (TransactionAbortedException ex)
            {
                errorActual = "TransactionAbortedException Message: " + ex.Message;
            }
            catch (ApplicationException ex)
            {
                errorActual = "ApplicationException Message: " + ex.Message;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                errorActual = "SQLexception Message: " + ex.Message;
            }
            catch (Exception ex)
            {
                errorActual = ex.Message;
            }
            return respuesta;
        }

        private bool agregar(object p_object, out string mensaje)
        {
            mensaje = "";
            Type T = p_object.GetType();
            if (T == typeof(ModeloArticulos))
            {
                if (!this.agregar(p_object as ModeloArticulos))
                {
                    mensaje = "Ha ocurrido un error al guardar " + (p_object as ModeloArticulos).codigoOriginal + ", " + (p_object as ModeloArticulos).descripcion;
                    return false;
                }
            }
            else if (T == typeof(ModeloArticuloProveedores))
            {
                if(!this.agregar(p_object as ModeloArticuloProveedores))
                {
                    mensaje = "Ha ocurrido un error al guardar " + (p_object as ModeloArticuloProveedores).codigoOriginal + ", " + (p_object as ModeloArticuloProveedores).codigoArticuloProveedor;
                    return false;
                }
            }
            else if (T == typeof(ModeloCliente))
            {
                if (!this.agregar(p_object as ModeloCliente))
                {
                    mensaje = "Ha ocurrido un error al guardar " + (p_object as ModeloCliente).dni + ", " + (p_object as ModeloCliente).nombre + ", " + (p_object as ModeloCliente).apellido;
                    return false;
                }
            }
            else if (T == typeof(ModeloProveedor))
            {
                if (!this.agregar(p_object as ModeloProveedor))
                {
                    mensaje = "Ha ocurrido un error al guardar " + (p_object as ModeloProveedor).cuit + ", " + (p_object as ModeloProveedor).razonSocial;
                    return false;
                }
            }
            else if (T == typeof(ModeloPedido))
            {
                if (!this.agregar(p_object as ModeloPedido))
                {
                    mensaje = "Ha ocurrido un error al guardar pedidos";
                    return false;
                }
            }
            else
            {
                return false;
            }

            return true;
        }


        /// <summary>
        /// Se comunica con la capa de datos para realizar INSERT en la base de datos. Acepta modeloEntidad o cualquiera de sus descendientes.
        /// </summary>
        /// <param name="p_mod_entidad"></param>
        /// <returns>true si se ha insertado, false y excepción si ha habido fallo</returns>
        public bool agregar(ModeloEntidad p_mod_entidad)
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
            if (!this.validarExistencia(p_mod_entidad))
            {
                return false;
            }
            bool respuesta = false;
            //errorActual = "No se ha podido realizar al operación.";
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    respuesta = lcl_catalogo.add(ref p_mod_entidad);
                    scope.Complete();
                }
            }
            catch (TransactionAbortedException ex)
            {
                errorActual = "TransactionAbortedException Message: " + ex.Message;
            }
            catch (ApplicationException ex)
            {
                errorActual = "ApplicationException Message: " + ex.Message;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                errorActual = "SQLexception Message: " + ex.Message;
            }
            catch (Exception ex)
            {
                errorActual = ex.Message;
            }
            return respuesta;
        }

        private bool validarExistencia(ModeloEntidad p_mod_entidad)
        {
            //Revisa que no exista CUIT
            if (!string.IsNullOrEmpty(p_mod_entidad.cuit))
            {
                if (ControladorBusqueda.buscar(p_mod_entidad, LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Cuit).Count > 0)
                {
                    errorActual = "El CUIT indicado ya existe";
                    return false;
                }
            }
            //Revisa que no exista DNI
            if (p_mod_entidad.GetType() != typeof(ModeloProveedor))
            {
                if (ControladorBusqueda.buscar(p_mod_entidad as ModeloPersonas, LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Personas.Dni).Count > 0)
                {
                    errorActual = "El DNI indicado ya existe";
                    return false;
                }
            }
            //Revisa que no exista Razón Social
            if (p_mod_entidad.GetType() == typeof(ModeloProveedor))
            {
                //Se hace una búsqueda con el resultado porque la busqueda por razón social retorna proveedores con razon social parecida, no unicamente igual
                List<ModeloProveedor> lcl_lst_mod_proveedores = ControladorBusqueda.buscar(p_mod_entidad as ModeloProveedor, LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Proveedores.RazonSocial);
                foreach(ModeloProveedor p in lcl_lst_mod_proveedores)
                {
                    if (p.razonSocial == (p_mod_entidad as ModeloProveedor).razonSocial)
                    {
                        errorActual = "La Razón Social indicada ya existe";
                    return false;
                    }
                }
            }
            //Revisa que no exista Usuario
            if (p_mod_entidad.GetType() == typeof(ModeloUsuario))
            {
                if (ControladorBusqueda.buscar(p_mod_entidad as ModeloUsuario, LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Usuario).Count > 0)
                {
                    errorActual = "El usuario indicado ya existe";
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Se comunica con la capa de datos para realizar INSERT en la base de datos.
        /// </summary>
        /// <param name="p_mod_articuloProveedor"></param>
        /// <returns>true si se ha insertado, false y excepción si ha habido fallo</returns>
        public bool agregar(ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            CatalogoArticuloProveedores lcl_cat_articuloProveedores = new CatalogoArticuloProveedores();
            
            bool respuesta = false;
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    respuesta = lcl_cat_articuloProveedores.add(p_mod_articuloProveedor);
                    scope.Complete();
                }
            }
            catch (TransactionAbortedException ex)
            {
                errorActual = "TransactionAbortedException Message: " + ex.Message;
            }
            catch (ApplicationException ex)
            {
                errorActual = "ApplicationException Message: " + ex.Message;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                errorActual = "SQLexception Message: " + ex.Message;
            }
            catch (Exception ex)
            {
                errorActual = ex.Message;
            }
            return respuesta;
        }
        
        /// <summary>
        /// Se comunica con la capa de datos para realizar INSERT en la base de datos.
        /// </summary>
        /// <param name="p_mod_articulo"></param>
        /// <returns>true si se ha insertado, false y excepción si ha habido fallo</returns>
        public bool agregar(ModeloArticulos p_mod_articulo)
        {
            CatalogoArticulos lcl_cat_articulos = new CatalogoArticulos();
            bool respuesta = false;
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    respuesta = lcl_cat_articulos.add(p_mod_articulo);
                    scope.Complete();
                }
            }
            catch (TransactionAbortedException ex)
            {
                errorActual = "TransactionAbortedException Message: " + ex.Message;
            }
            catch (ApplicationException ex)
            {
                errorActual = "ApplicationException Message: " + ex.Message;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                errorActual = "SQLexception Message: " + ex.Message;
            }
            catch (Exception ex)
            {
                errorActual = ex.Message;
            }
            return respuesta;
            
        }

        /// <summary>
        /// Se comunica con la capa de datos para realizar INSERT en la base de datos.
        /// </summary>
        /// <param name="p_mod_pedido"></param>
        /// <returns>true si se ha insertado, false y excepción si ha habido fallo</returns>
        public bool agregar(ModeloPedido p_mod_pedido)
        {
            CatalogoPedidos lcl_cat_pedidos = new CatalogoPedidos();
            if (!p_mod_pedido.validar())
            {
                errorActual = "El pedido no es válido.";
                return false;
            }
            
            bool respuesta = false;
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    respuesta = lcl_cat_pedidos.add(ref p_mod_pedido) && this.agregarLineasPedido(p_mod_pedido);
                    if (!respuesta)
                    {
                        throw new Exception(errorActual);
                    }
                    scope.Complete();
                }
            }
            catch (TransactionAbortedException ex)
            {
                errorActual = "TransactionAbortedException Message: " + ex.Message;
            }
            catch (ApplicationException ex)
            {
                errorActual = "ApplicationException Message: " + ex.Message;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                errorActual = "SQLexception Message: " + ex.Message;
            }
            catch (Exception ex)
            {
                errorActual = ex.Message;
            }
            
            return respuesta;
        }

        public bool agregarDevolucion(ModeloPedido p_mod_pedido, ModeloPedido p_mod_pedido_devuelto)
        {
            CatalogoPedidos lcl_cat_pedidos = new CatalogoPedidos();
            
            bool respuesta = false;
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    respuesta = lcl_cat_pedidos.addDevolucion(p_mod_pedido,p_mod_pedido_devuelto);
                    if (!respuesta)
                    {
                        throw new Exception(errorActual);
                    }
                    scope.Complete();
                }
            }
            catch (TransactionAbortedException ex)
            {
                errorActual = "TransactionAbortedException Message: " + ex.Message;
            }
            catch (ApplicationException ex)
            {
                errorActual = "ApplicationException Message: " + ex.Message;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                errorActual = "SQLexception Message: " + ex.Message;
            }
            catch (Exception ex)
            {
                errorActual = ex.Message;
            }

            return respuesta;
        }

        private bool agregarLineasPedido(ModeloPedido p_mod_pedido)
        {
            foreach (ModeloLineaPedido lp in p_mod_pedido.lineasPedido)
            {
                this.agrearLineaPedido(lp);       
            }

            if (p_mod_pedido.tipoComprobante == 1 || p_mod_pedido.tipoComprobante == 6)
            {
                ControladorModificacion lcl_con = new ControladorModificacion();

                foreach (ModeloLineaPedido lp in p_mod_pedido.lineasPedido)
                {
                    if (!lcl_con.bajarStock(lp))
                    {
                        errorActual = lcl_con.errorActual;
                        return false;
                    }
                }
            }

            return true;
        }

        

        private bool agrearLineaPedido(ModeloLineaPedido p_mod_lineaPedido)
        {
            CatalogoLineasPedidos lcl_cat_lineasPedidos = new CatalogoLineasPedidos();
            ControladorModificacion lcl_con_modificacion = new ControladorModificacion();

            if (!lcl_cat_lineasPedidos.add(p_mod_lineaPedido))
            {
                throw new Exception();
            }
            return true;
        }
        
        #region Posible DELETE si no se les encuentra uso
        ///// <summary>
        ///// Se debería usar este método en vez de lo implementado en la capa Datos CatalogoEntidades
        ///// </summary>
        ///// <param name="p_mod_domicilio"></param>
        ///// <returns></returns>
        //private bool agregar(ModeloDomicilio p_mod_domicilio, int p_codigoEntidad)
        //{
        //    CatalogoDomicilios lcl_cat_domicilios = new CatalogoDomicilios();
        //    if (p_mod_domicilio.validar())
        //    {
        //        return lcl_cat_domicilios.add(p_mod_domicilio, p_codigoEntidad);
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        ///// <summary>
        ///// Se debería usar este método en vez de lo implementado en la capa Datos CatalogoEntidades.
        ///// </summary>
        ///// <param name="p_mod_telefono"></param>
        ///// <returns></returns>
        //private bool agregar(ModeloTelefono p_mod_telefono, int p_codigoEntidad)
        //{
        //    CatalogoTelefonos lcl_cat_telefonos = new CatalogoTelefonos();
        //    return lcl_cat_telefonos.add(p_mod_telefono, p_codigoEntidad);
        //}
        ///// <summary>
        ///// Se debería usar este método en vez de lo implementado en la capa Datos CatalogoEntidades
        ///// </summary>
        ///// <param name="p_mod_mail"></param>
        ///// <param name="p_codigoEntidad"></param>
        ///// <returns></returns>
        //private bool agregar(ModeloMail p_mod_mail, int p_codigoEntidad)
        //{
        //    CatalogoMails lcl_cat_mails = new CatalogoMails();
        //    return lcl_cat_mails.add(p_mod_mail, p_codigoEntidad);
        //}
        //public bool agregar(ModeloPais p_mod_pais)
        //{
        //    CatalogoPaises lcl_cat_paises = new CatalogoPaises();
        //    return false;
        //}
        //public bool agregar(ModeloProvincia p_mod_provincia)
        //{
        //    CatalogoProvincias lcl_cat_provincias = new CatalogoProvincias();
        //    return false;
        //}

        //private bool agregar(ModeloValorArticulo p_mod_valorArticulo)
        //{
        //    return false;
        //}
        #endregion
    }
}
