﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Datos;

namespace Controladores
{
    public class ControladorBusqueda
    {
        #region Entidades
        
        #region Personas
        /// <summary>
        /// Retorna todas las personas de la base de datos
        /// </summary>
        /// <returns>Lista de personas</returns>
        public List<ModeloPersonas> buscarPersonas()
        {
            CatalogoPersonas cp = new CatalogoPersonas();
            
            return cp.getAll();
        }
        /// <summary>
        /// Retorna personas en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="pmPersona"></param>
        /// <returns>Lista de personas</returns>
        public List<ModeloPersonas> buscarPersonas(ModeloPersonas pmPersona)
        {
            CatalogoPersonas cp = new CatalogoPersonas();
            pmPersona.convertirDatos();
            List<ModeloPersonas> lmPersonas = new List<ModeloPersonas>();
            lmPersonas = cp.buscarPersona(pmPersona);            
            
            return lmPersonas;
        }
        /// <summary>
        /// Busca personas que cumplan con un parámetro de búsqueda o retorna todas si se especifica "all"
        /// </summary>
        /// <param name="pmPersona">Persona con variable a buscar inicializada con algún valor</param>
        /// <param name="paramentroBusqueda">all o codigoEntidad,cuit,dni,nombre,apellido,usuario,tipoPersona</param>
        /// <returns>Lista de personas</returns>
        public List<ModeloPersonas> buscarPersonas(ModeloPersonas pmPersona, string paramentroBusqueda)
        {
            List<ModeloPersonas> lmPersonas = new List<ModeloPersonas>();
            CatalogoPersonas cp = new CatalogoPersonas();
            if (paramentroBusqueda == "codigoEntidad")
            {
                lmPersonas.Add(cp.getOne(pmPersona.codigo));
                
            }
            else
            {
                if (paramentroBusqueda == "all")
                {
                    lmPersonas = cp.getAll();
                }
                else
                {
                    lmPersonas = cp.buscarPersona(pmPersona, paramentroBusqueda);    
                }
            }
            return lmPersonas;
        }

        #endregion

        #region Proveedores
        /// <summary>
        /// Retorna todos los proveedores de la base de datos
        /// </summary>
        /// <returns>Lista de personas</returns>
        public List<ModeloProveedor> buscarProveedores()
        {
            CatalogoProveedores cp = new CatalogoProveedores();

            return cp.getAll(); ;
        }
        /// <summary>
        /// Retorna proveedores en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="pmProveedor"></param>
        /// <returns>Lista de proveedores</returns>
        public List<ModeloProveedor> buscarProveedores(ModeloProveedor pmProveedor)
        {
            CatalogoProveedores cp = new CatalogoProveedores();
            pmProveedor.convertirDatos();
            List<ModeloProveedor> lmProveedor = new List<ModeloProveedor>();
            lmProveedor = cp.buscarProveedor(pmProveedor);
            
            return lmProveedor;
        }
        /// <summary>
        /// Busca proveedores que cumplan con un parámetro de búsqueda o retorna todas si se especifica "all"
        /// </summary>
        /// <param name="pmProveedor">Proveedor con variable a buscar inicializada con algún valor</param>
        /// <param name="paramentroBusqueda">all o codigoEntidad,cuit,razonSocial</param>
        /// <returns>Lista de proveedores</returns>
        public List<ModeloProveedor> buscarProveedores(ModeloProveedor pmProveedor, string paramentroBusqueda)
        {
            List<ModeloProveedor> lmProveedor = new List<ModeloProveedor>();
            CatalogoProveedores cp = new CatalogoProveedores();
            if (paramentroBusqueda == "codigoEntidad")
            {
                lmProveedor.Add(cp.getOne(pmProveedor.codigo));    
            }
            else
            {
                if (paramentroBusqueda == "all")
                {
                    lmProveedor = cp.getAll();
                }
                else
                {
                    lmProveedor = cp.buscarProveedor(pmProveedor, paramentroBusqueda);    
                }
            }
        
            return lmProveedor;
        }

        #endregion

       

        #endregion
        
        #region Articulos
         /// <summary>
        /// Retorna todos los Articulos de la base de datos
        /// </summary>
        /// <returns>Lista de Articulos</returns>
        public List<ModeloArticulos> buscarArticulos()
        {
            CatalogoArticulos ca = new CatalogoArticulos();

            return ca.getAll(); 
        }
        /// <summary>
        /// Retorna articulos en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="pmArticulo"></param>
        /// <returns>Lista de proveedores</returns>
        public List<ModeloArticulos> buscarArticulos(ModeloArticulos pmArticulo)
        {
            CatalogoArticulos ca = new CatalogoArticulos();
            //pmArticulo.convertirDatos(); Que Hace este Metodo? Martin.
            List<ModeloArticulos> lmArticulo = new List<ModeloArticulos>();
            lmArticulo = ca.buscarArticulo(pmArticulo); //Ver como continuar Martin.
            return lmArticulo;
        }
        /// <summary>
        /// Busca proveedores que cumplan con un parámetro de búsqueda o retorna todas si se especifica "all"
        /// </summary>
        /// <param name="pmArticulo">Proveedor con variable a buscar inicializada con algún valor</param>
        /// <param name="paramentroBusqueda">string por el que se buscará artículo</param>
        /// <returns>Lista de proveedores</returns>
        public List<ModeloArticulos> buscarArticulos(ModeloArticulos pmArticulo, string paramentroBusqueda)
        {
            List<ModeloArticulos> lmArticulo = new List<ModeloArticulos>();
            CatalogoArticulos ca = new CatalogoArticulos();
            if (paramentroBusqueda == "codigooriginal")
            {
                lmArticulo.Add(ca.getOne(pmArticulo.codigoOriginal));
            }
            else
            {
                if (paramentroBusqueda == "all")
                {
                    lmArticulo = ca.getAll();
                }
                else
                {
                    lmArticulo = ca.buscarArticulo(pmArticulo.descripcion, paramentroBusqueda);
                }
            }

            return lmArticulo;
        }

        #endregion

        #region ArticuloProveedores
        /// <summary>
        /// Retorna todos los ArticulosProveedores de la base de datos
        /// </summary>
        /// <returns>Lista de Articulos</returns>
        public List<ModeloArticuloProveedores> buscarArticuloProveedores()
        {
            CatalogoArticuloProveedores cap = new CatalogoArticuloProveedores();

            return cap.getAll(); ;
        }
        /// <summary>
        /// Retorna proveedores en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="pmArticuloProveedores"></param>
        /// <returns>Lista de proveedores</returns>
        public List<ModeloArticuloProveedores> buscarArticulosProveedores(ModeloProveedor pmArticuloProveedores)
        {
            CatalogoArticuloProveedores cap = new CatalogoArticuloProveedores();
            pmArticuloProveedores.convertirDatos();
            List<ModeloArticuloProveedores> lmArticuloProveedores = new List<ModeloArticuloProveedores>();
           // lmArticuloProveedores = cap.buscarArticuloProveedor(pmArticuloProveedores); Ver como definir esto que tambien pasa en Entidad Articulos.

            return lmArticuloProveedores;
        }
        /// <summary>
        /// Busca proveedores que cumplan con un parámetro de búsqueda o retorna todas si se especifica "all"
        /// </summary>
        /// <param name="pmArticuloProveedores">Proveedor con variable a buscar inicializada con algún valor</param>
        /// <param name="paramentroBusqueda">all o codigooriginal,codigoarticuloproveedor,descripcion</param>
        /// <returns>Lista de proveedores</returns>
        public List<ModeloArticuloProveedores> buscarArticuloProveedores(ModeloArticuloProveedores pmArticuloProveedores, string paramentroBusqueda)
        {
            List<ModeloArticuloProveedores> lmArticuloProveedores = new List<ModeloArticuloProveedores>();
            CatalogoArticuloProveedores cap = new CatalogoArticuloProveedores();
            if (paramentroBusqueda == "codigooriginal")
            {
                lmArticuloProveedores.Add(cap.getOne(pmArticuloProveedores.codigoOriginal,pmArticuloProveedores.codigoArticuloProveedor));
            }
            else
            {
                if (paramentroBusqueda == "all")
                {
                    lmArticuloProveedores = cap.getAll();
                }
                else
                { 
                    
                    //lmArticuloProveedores = cap.buscarArticuloProveedor(pmArticuloProveedores, paramentroBusqueda); Ver como redefinir dicho metodo - parametros
                }
            }

            return lmArticuloProveedores;
        }

        #endregion
                             
        #region Provincias
        /// <summary>
        /// Retorna todas las provincias de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<ModeloProvincia> buscarProvincias()
        {
            CatalogoProvincias cp = new CatalogoProvincias();

            return cp.getAll();
        }

        #endregion
        
        #region Paises
        public List<ModeloPais> buscarPaises()
        {
            CatalogoPaises cp = new CatalogoPaises();
            return cp.getAll();
        }
        #endregion
    
    }
}
