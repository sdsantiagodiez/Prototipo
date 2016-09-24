using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;
using System.Transactions;

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

            if (!this.validarExistencia(p_mod_entidad))
            {
                return false;
            }
            bool respuesta = false;
            errorActual = "No se ha podido realizar la modificación.";
            try
            {
                ModeloEntidad lcl_m = lcl_catalogo.getOne(p_mod_entidad.codigo);
                if (lcl_m == null)//en el caso que no exista la entidad que se esta buscando
                {
                    errorActual = "Ha surgido un error inesperado";
                    return false;
                }
                using (TransactionScope scope = new TransactionScope())
                {
                    respuesta = lcl_catalogo.update(lcl_m,p_mod_entidad);
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
                List<ModeloEntidad> lcl_lst_mod_entidades = ControladorBusqueda.buscar(p_mod_entidad, LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Cuit);
                foreach (ModeloEntidad e in lcl_lst_mod_entidades)
                {
                    if (e.codigo != p_mod_entidad.codigo)
                    {
                        errorActual = "El CUIT indicado ya existe";
                        return false;
                    }
                }
                
            }
            //Revisa que no exista DNI
            if (p_mod_entidad.GetType() != typeof(ModeloProveedor))
            {
                List<ModeloPersonas> lcl_lst_mod_personas = ControladorBusqueda.buscar(p_mod_entidad as ModeloPersonas, LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Personas.Dni);
                foreach(ModeloPersonas p in lcl_lst_mod_personas)
                {
                    if (p.codigo != p_mod_entidad.codigo)
                    {
                        errorActual = "El DNI indicado ya existe";
                        return false;
                    }
                }
            }
            //Revisa que no exista Razón Social
            if (p_mod_entidad.GetType() == typeof(ModeloProveedor))
            {
                //Se hace una búsqueda con el resultado porque la busqueda por razón social retorna proveedores con razon social parecida, no unicamente igual
                List<ModeloProveedor> lcl_lst_mod_proveedores = ControladorBusqueda.buscar(p_mod_entidad as ModeloProveedor, LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Proveedores.RazonSocial);
                foreach (ModeloProveedor p in lcl_lst_mod_proveedores)
                {
                    if (p.razonSocial == (p_mod_entidad as ModeloProveedor).razonSocial && p.codigo != p_mod_entidad.codigo)
                    {
                        errorActual = "La Razón Social indicada ya existe";
                        return false;
                    }
                }
            }
            //Revisa que no exista Usuario
            if (p_mod_entidad.GetType() == typeof(ModeloUsuario))
            {
                List<ModeloUsuario> lcl_lst_mod_usuarios = ControladorBusqueda.buscar(p_mod_entidad as ModeloUsuario, LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Usuario);
                foreach(ModeloUsuario u in lcl_lst_mod_usuarios)
                {
                    if (u.codigo != p_mod_entidad.codigo)
                    {
                        errorActual = "El usuario indicado ya existe";
                        return false;
                    }
                }
            }

            return true;
        }

        public bool modificar(ModeloArticulos p_mod_articulo)
        {
            CatalogoArticulos lcl_cat_articulos = new CatalogoArticulos();
            bool respuesta = false;
            errorActual = "No se ha podido realizar la modificación.";
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    respuesta = lcl_cat_articulos.update(p_mod_articulo);
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
        public bool modificar(ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            CatalogoArticuloProveedores lcl_cat_articuloProveedores = new CatalogoArticuloProveedores();
            bool respuesta = false;
            errorActual = "No se ha podido realizar la modificación.";
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    respuesta = lcl_cat_articuloProveedores.update(p_mod_articuloProveedor);
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

        public bool modificar(ModeloPedido p_mod_pedido)
        {
            return true;
        }
        public static bool actualizarAprobacionAFIP(ModeloPedido p_mod_pedido)
        {
            CatalogoPedidos lcl_cat_pedidos = new CatalogoPedidos();
            return lcl_cat_pedidos.updateAprobadoAFIP(p_mod_pedido);
        }
        
        public bool modificarValorArticulo(ModeloArticuloProveedores p_mod_articuloProveedor, string p_tipoValorArticulo)
        {
            CatalogoArticuloProveedores lcl_cat_articuloProveedores = new CatalogoArticuloProveedores();
            bool respuesta = false;
            errorActual = "No se ha podido realizar la actualizacion.";
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    respuesta = lcl_cat_articuloProveedores.updateValor(p_mod_articuloProveedor,p_tipoValorArticulo);
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

        public bool modificarValoresArticulos(List<object> p_lst_articulosProveedores, string p_tipoValorArticulo)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                int i = 1;
                foreach (ModeloArticuloProveedores ap in p_lst_articulosProveedores)
                {
                    if (!this.modificarValorArticulo(ap, p_tipoValorArticulo))
                    {
                        errorActual = "No se han podido realizar la actualización. Error al agregar a la base de datos el valor de artículo ubicado en la fila "+i.ToString()+". Verifique que el artículo exista en la base de datos y que los valores ingresados sean correctos.";
                        return false;
                    }
                    i++;
                }
                scope.Complete();
            }
            return true;
        }

        public bool bajarStock(ModeloLineaPedido p_lineaPedido)
        {
            ModeloArticuloProveedores lcl_mod_articuloProveedores = new ModeloArticuloProveedores()
            {
                codigoOriginal = p_lineaPedido.articulo.codigoOriginal,
                codigoArticuloProveedor = p_lineaPedido.articulo.codigoArticuloProveedor
            };

            lcl_mod_articuloProveedores = ControladorBusqueda.getOne(lcl_mod_articuloProveedores, LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.One);
            //Si no se encuentra artículo tira excepción de índice

            lcl_mod_articuloProveedores.stockActual = lcl_mod_articuloProveedores.stockActual - p_lineaPedido.cantidadArticulos;
            //Excepcion si stock negativo y no esta permitido    
            if (lcl_mod_articuloProveedores.stockActual < 0 && !p_lineaPedido.permitirStockNegativo)
            {
                errorActual = "La cantidad solicitada es mayor al stock actual para el artículo " + lcl_mod_articuloProveedores.getDescripciones() + ", " +
                                lcl_mod_articuloProveedores.codigoArticuloProveedor;
                return false;
            }

            //Si hay error al modificar la base de datos agregando linea o modificando stock
            if (!new ControladorModificacion().modificar(lcl_mod_articuloProveedores))
            {
                errorActual = "Error al modificar stock en la base de datos de artículo " + lcl_mod_articuloProveedores.getDescripciones() + ", " +
                                lcl_mod_articuloProveedores.codigoArticuloProveedor;
                return false;
            }

            return true;
        }

        public bool subirStock(ModeloLineaPedido p_lineaPedido)
        {
            ModeloArticuloProveedores lcl_mod_articuloProveedores = new ModeloArticuloProveedores()
            {
                codigoOriginal = p_lineaPedido.articulo.codigoOriginal,
                codigoArticuloProveedor = p_lineaPedido.articulo.codigoArticuloProveedor
            };

            lcl_mod_articuloProveedores = ControladorBusqueda.getOne(lcl_mod_articuloProveedores, LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.One);
            //Si no se encuentra artículo tira excepción de índice

            lcl_mod_articuloProveedores.stockActual = lcl_mod_articuloProveedores.stockActual + p_lineaPedido.cantidadArticulos;

            //Si hay error al modificar la base de datos agregando linea o modificando stock
            if (!this.modificar(lcl_mod_articuloProveedores))
            {
                errorActual = "Error al modificar stock en la base de datos de artículo " + lcl_mod_articuloProveedores.getDescripciones() + ", " +
                                lcl_mod_articuloProveedores.codigoArticuloProveedor;
                return false;
            }

            return true;
        }
        public bool recepcionarPedidosProveedor(List<ModeloPedido> p_lst_pedidos)
        {
            bool respuesta = p_lst_pedidos.Count > 0;
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    foreach (ModeloPedido p in p_lst_pedidos)
                    {
                        if (!this.recepcionarPedidoProveedor(p))
                        {
                            throw new Exception(errorActual);
                        }
                    }
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                errorActual = ex.Message;
            }
            return respuesta;
        }
        public bool recepcionarPedidoProveedor(ModeloPedido p)
        {
            if (!new CatalogoPedidos().recepcionarPedidoProveedor(p))
            {
                return false;
            }

            foreach (ModeloLineaPedido lp in p.lineasPedido)
            {
                if (!this.subirStock(lp))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
