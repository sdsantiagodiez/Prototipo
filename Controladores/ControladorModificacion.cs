﻿using System;
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
        public string errorActual;

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
            bool respuesta = false;
            errorActual = "No se ha podido realizar la modificación.";
            try
            {
                ModeloEntidad lcl_m = lcl_catalogo.getOne(p_mod_entidad.codigo);
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
    }
}
