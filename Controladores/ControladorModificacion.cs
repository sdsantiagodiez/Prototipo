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
                foreach (ModeloArticuloProveedores ap in p_lst_articulosProveedores)
                {
                    if (!this.modificarValorArticulo(ap, p_tipoValorArticulo))
                    {
                        return false;
                    }
                }
                scope.Complete();
            }
            return true;
        }
    }
}
