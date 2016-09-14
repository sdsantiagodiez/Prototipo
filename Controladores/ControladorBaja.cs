using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Datos;
using System.Transactions;

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
            bool respuesta = false;
            errorActual = "No se ha podido realizar la eliminación.";
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    respuesta = lcl_catalogo.remove(p_mod_entidad);
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
                switch (ex.Number)
                {
                    case 547:
                        if (T == typeof(ModeloCliente))
                        {
                            errorActual = "No es posible eliminar cliente ya que tiene pedidos asociados.";
                        }
                        else if (T == typeof(ModeloContactoProveedor))
                        {
                            errorActual = "No es posible eliminar contacto de proveedor ya que tiene pedidos asociados.";
                        }
                        else if (T == typeof(ModeloProveedor))
                        {
                            errorActual = "No es posible eliminar proveedor ya que tiene artículos asociados.";
                        }
                        else
                        {
                            errorActual = "No es posible realizar la eliminación.";
                        }
                        
                        break;
                    default:
                        errorActual = "SQLexception Message: " + ex.Message;
                        break;
                }
            }
            catch (Exception ex)
            {
                errorActual = ex.Message;
            }
            return respuesta;
        }

        public bool eliminar(ModeloArticulos p_mod_articulo)
        {
            CatalogoArticulos lcl_cat_articulos = new CatalogoArticulos();
            bool respuesta = false;
            errorActual = "No se ha podido realizar la eliminación.";
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    respuesta = lcl_cat_articulos.remove(p_mod_articulo);
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
                switch (ex.Number)
                {
                    case 547:
                        errorActual = "No es posible eliminar artículo ya que tiene artículos proveedor asociados.";
                        break;
                    default:
                        errorActual = "SQLexception Message: " + ex.Message;
                        break;
                }
                
            }
            catch (Exception ex)
            {
                errorActual = ex.Message;
            }
            return respuesta;
        }

        public bool eliminar(ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            CatalogoArticuloProveedores lcl_cat_articuloProveedores = new CatalogoArticuloProveedores();
            bool respuesta = false;
            errorActual = "No se ha podido realizar la eliminación.";
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    respuesta = lcl_cat_articuloProveedores.remove(p_mod_articuloProveedor);
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
                switch (ex.Number)
                {
                    case 547:
                        errorActual = "No es posible eliminar artículo ya que tiene pedidos o descuentos asociados.";
                        break;
                    default:
                        errorActual = "SQLexception Message: " + ex.Message;
                        break;
                }
            }
            catch (Exception ex)
            {
                errorActual = ex.Message;
            }
            return respuesta;
        }
        public bool eliminar(ModeloPedido p_mod_pedido)
        {
            CatalogoPedidos lcl_cat_pedidos = new CatalogoPedidos();
            bool respuesta = false;
            errorActual = "No se ha podido realizar la eliminación.";
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    respuesta = lcl_cat_pedidos.remove(p_mod_pedido)&& this.devolverStock(p_mod_pedido);
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
                switch (ex.Number)
                {
                   default:
                        errorActual = "SQLexception Message: " + ex.Message;
                        break;
                }

            }
            catch (Exception ex)
            {
                errorActual = ex.Message;
            }
            return respuesta;
        }
        public bool devolverStock(ModeloPedido p_mod_pedido)
        {
            ModeloArticuloProveedores lcl_mod_articuloProveedores;
            ControladorModificacion lcl_con_modificacion = new ControladorModificacion();
            if (p_mod_pedido.tipoComprobante != 0)
            {
                foreach (ModeloLineaPedido lp in p_mod_pedido.lineasPedido)
                {
                    //se debe modificar stock
                    lcl_mod_articuloProveedores = new ModeloArticuloProveedores();

                    lcl_mod_articuloProveedores.codigoOriginal = lp.articulo.codigoOriginal;
                    lcl_mod_articuloProveedores.codigoArticuloProveedor = lp.articulo.codigoArticuloProveedor;

                    lcl_mod_articuloProveedores = ControladorBusqueda.getOne(lcl_mod_articuloProveedores, LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.One);
                    //Si no se encuentra artículo tira excepción de índice
                    if (p_mod_pedido.tipoComprobante != 8 && p_mod_pedido.tipoComprobante != 3)//Se agrega para que cuando sea devolucion no suba Stock.
                    {
                        if (p_mod_pedido.tipoComprobante != 2001)
                        {
                            lcl_mod_articuloProveedores.stockActual = lcl_mod_articuloProveedores.stockActual + lp.cantidadArticulos;
                            //Excepcion si stock negativo y no esta permitido    
                            
                        }
                        else
                        { lcl_mod_articuloProveedores.stockActual = lcl_mod_articuloProveedores.stockActual - lp.cantidadArticulos;
                            if (lcl_mod_articuloProveedores.stockActual < 0 && !lp.permitirStockNegativo)
                            {
                                errorActual = "La cantidad solicitada es mayor al stock actual para el artículo " + lcl_mod_articuloProveedores.getDescripciones() + ", " +
                                                lcl_mod_articuloProveedores.codigoArticuloProveedor;
                                return false;
                            }
                        }

                        //Si hay error al modificar la base de datos agregando linea o modificando stock
                        if (!lcl_con_modificacion.modificar(lcl_mod_articuloProveedores))
                        {
                            errorActual = "Error al modificar stock en la base de datos de artículo " + lcl_mod_articuloProveedores.getDescripciones() + ", " +
                                            lcl_mod_articuloProveedores.codigoArticuloProveedor;
                            return false;
                        }
                    }
                }
            }
            return true;
        }
      

    }
}
