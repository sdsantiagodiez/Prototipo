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

      

    }
}
