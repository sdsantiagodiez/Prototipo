using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Models;

namespace Controlador
{
    class Controlador
    {

        /// <summary>
        /// Busca y retorna lista de articulosProveedores. Retorna lista vacía si no encuntra coincidencias
        /// </summary>
        /// <param name="parametro">string por la que se buscará articuloProveedor</param>
        /// <returns>Lista de articulosProveedores o lista vacía si no se ha encontrado coincidencia</returns>
        public List<ModeloArticuloProveedores> buscarArticulosProveedor(string parametro)
        {
            List<ModeloArticuloProveedores> apEncontrados = new List<ModeloArticuloProveedores>();
            CatalogoArticuloProveedores cap = new CatalogoArticuloProveedores();

            //Se intenta buscar en primer lugar por codigoOriginal 
            apEncontrados = cap.buscarArticuloProveedor("codigoOriginal", parametro);
            
            //En caso de que codigoOriginal no exista o 
            //parametro sea codigoArticuloProveedor o descripción
            if (apEncontrados.Count == 0)
            {
                apEncontrados = cap.buscarArticuloProveedor("codigoArticuloProveedor", parametro);
                if(apEncontrados.Count == 0)
                {
                    CatalogoArticulos ca = new CatalogoArticulos();
                    List<ModeloArticulos> aEncontrados = new List<ModeloArticulos>();
                    aEncontrados = ca.buscarArticulo("descripcion", parametro);
                    foreach(ModeloArticulos ma in aEncontrados)
                    {
                        apEncontrados.AddRange(cap.buscarArticuloProveedor("codigoOriginal",ma.codigoOriginalArt));
                    }
                }
            }

        return apEncontrados;
        }

        /// <summary>
        /// Busca y retorna lista de articulos. Retorna lista vacía si no encuntra coincidencias
        /// </summary>
        /// <param name="parametro">string por la que se buscará articulo</param>
        /// <returns>Lista de articulos o lista vacía si no se ha encontrado coincidencia</returns>
        public List<ModeloArticulos> buscarArticulo(string parametro)
        {
            List<ModeloArticulos> aEncontrados = new List<ModeloArticulos>();
            CatalogoArticulos ca = new CatalogoArticulos();

            //Se intenta busqueda por codigoOriginal
            aEncontrados = ca.buscarArticulo("codigoOriginal", parametro);
            
            //En caso de que codigoOriginal no exista o parametro es descripcion de artículo
            if (aEncontrados.Count == 0)
            {
                aEncontrados = ca.buscarArticulo("descripcion", parametro);
            }

            return aEncontrados;
        }

        /// <summary>
        /// Busca y retorna lista de proveedores. Retorna lista vacía si no encuentra coincidencias
        /// </summary>
        /// <param name="parametro">string por la que se buscará proveedor</param>
        /// <returns>Lista de proveedores o lista vacía si no se ha encontrado coincidencia</returns>
        public List<ModeloProveedores> buscarProveedor(string parametro)
        {
            List<ModeloProveedores> pEncontrados = new List<ModeloProveedores>();
            CatalogoProveedores cp = new CatalogoProveedores();

            pEncontrados = cp.buscarProveedores("razonSocial",parametro);
            if (pEncontrados.Count == 0)
            {
                pEncontrados = cp.buscarProveedores("cuit", parametro);
            }
            return pEncontrados;
        }
    }
}
