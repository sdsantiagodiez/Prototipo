using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Datos;
using LibreriaClasesCompartidas;

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
            CatalogoPersonas lcl_cat_personas = new CatalogoPersonas();

            return lcl_cat_personas.buscarPersona(null, Constantes.ParametrosBusqueda.Entidades.Personas.All);
        }
        /// <summary>
        /// Retorna personas en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="p_mod_persona"></param>
        /// <returns>Lista de personas</returns>
        public List<ModeloPersonas> buscarPersonas(ModeloPersonas p_mod_persona)
        {
            CatalogoPersonas lcl_cat_personas = new CatalogoPersonas();
            p_mod_persona.convertirDatos();

            return lcl_cat_personas.buscarPersona(p_mod_persona,Constantes.ParametrosBusqueda.Entidades.Personas.Any);            
        }
        /// <summary>
        /// Busca personas que cumplan con un parámetro de búsqueda.
        /// </summary>
        /// <param name="p_mod_persona">Persona con variable a buscar inicializada con algún valor</param>
        /// <param name="p_paramentroBusqueda">Constante dentro de LibreriaClasesCompartidas.Constantes.ParametrosBusqueda</param>
        /// <returns>Lista de personas</returns>
        public List<ModeloPersonas> buscarPersonas(ModeloPersonas p_mod_persona, string p_paramentroBusqueda)
        {
            CatalogoPersonas lcl_cat_personas = new CatalogoPersonas();

            return lcl_cat_personas.buscarPersona(p_mod_persona, p_paramentroBusqueda);
        }

        #endregion

        #region Proveedores
        /// <summary>
        /// Retorna todos los proveedores de la base de datos
        /// </summary>
        /// <returns>Lista de personas</returns>
        public List<ModeloProveedor> buscarProveedores()
        {
            CatalogoProveedores lcl_cat_proveedores = new CatalogoProveedores();
            
            return lcl_cat_proveedores.buscarProveedor(null,Constantes.ParametrosBusqueda.Entidades.Proveedores.All);
        }
        /// <summary>
        /// Retorna proveedores en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="p_mod_proveedor"></param>
        /// <returns>Lista de proveedores</returns>
        public List<ModeloProveedor> buscarProveedores(ModeloProveedor p_mod_proveedor)
        {
            CatalogoProveedores lcl_cat_proveedores = new CatalogoProveedores();
            p_mod_proveedor.convertirDatos();

            return lcl_cat_proveedores.buscarProveedor(p_mod_proveedor, Constantes.ParametrosBusqueda.Entidades.Proveedores.Any);
        }
        /// <summary>
        /// Busca proveedores que cumplan con un parámetro de búsqueda
        /// </summary>
        /// <param name="p_mod_proveedor">Proveedor con variable a buscar inicializada con algún valor</param>
        /// <param name="p_paramentroBusqueda">Constante dentro de LibreriaClasesCompartidas.Constantes.ParametrosBusqueda</param>
        /// <returns>Lista de proveedores</returns>
        public List<ModeloProveedor> buscarProveedores(ModeloProveedor p_mod_proveedor, string p_paramentroBusqueda)
        {
            CatalogoProveedores lcl_cat_proveedores = new CatalogoProveedores();

            return  lcl_cat_proveedores.buscarProveedor(p_mod_proveedor, p_paramentroBusqueda);    
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
            CatalogoArticulos lcl_cat_articulos = new CatalogoArticulos();

            return lcl_cat_articulos.getAll(); 
        }
        /// <summary>
        /// Retorna articulos en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="pmArticulo"></param>
        /// <returns>Lista de proveedores</returns>
        public List<ModeloArticulos> buscarArticulos(ModeloArticulos p_mod_articulo)
        {
            CatalogoArticulos lcl_cat_articulos = new CatalogoArticulos();
            
            return lcl_cat_articulos.buscarArticulo(p_mod_articulo); 
        }
        /// <summary>
        /// Busca proveedores que cumplan con un parámetro de búsqueda
        /// </summary>
        /// <param name="p_mod_articulo">Proveedor con variable a buscar inicializada con algún valor</param>
        /// <param name="p_paramentroBusqueda">Constante dentro de LibreriaClasesCompartidas.Constantes.ParametrosBusqueda</param>
        /// <returns>Lista de proveedores</returns>
        public List<ModeloArticulos> buscarArticulos(ModeloArticulos p_mod_articulo, string p_paramentroBusqueda)
        {
            List<ModeloArticulos> lcl_lst_mod_articulo = new List<ModeloArticulos>();
            CatalogoArticulos lcl_cat_articulos = new CatalogoArticulos();
            if (p_paramentroBusqueda == Constantes.ParametrosBusqueda.Articulos.CodigoOriginal)
            {
                lcl_lst_mod_articulo.Add(lcl_cat_articulos.getOne(p_mod_articulo.codigoOriginal));
            }
            else
            {
                if (p_paramentroBusqueda == Constantes.ParametrosBusqueda.Articulos.All)
                {
                    lcl_lst_mod_articulo = lcl_cat_articulos.getAll();
                }
                else
                {
                    lcl_lst_mod_articulo = lcl_cat_articulos.buscarArticulo(p_mod_articulo.descripcion, p_paramentroBusqueda);
                }
            }

            return lcl_lst_mod_articulo;
        }

        #endregion
        
        #region ArticuloProveedores
        /// <summary>
        /// Retorna todos los ArticulosProveedores de la base de datos
        /// </summary>
        /// <returns>Lista de Articulos</returns>
        public List<ModeloArticuloProveedores> buscarArticuloProveedores()
        {
            CatalogoArticuloProveedores lcl_cat_articuloProveedores = new CatalogoArticuloProveedores();

            return lcl_cat_articuloProveedores.getAll(); ;
        }
        /// <summary>
        /// Retorna proveedores en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="p_mod_articuloProveedores"></param>
        /// <returns>Lista de proveedores</returns>
        public List<ModeloArticuloProveedores> buscarArticulosProveedores(ModeloArticuloProveedores p_mod_articuloProveedores)
        {
            CatalogoArticuloProveedores lcl_cat_articuloProveedores = new CatalogoArticuloProveedores();
            
            return lcl_cat_articuloProveedores.buscarArticuloProveedor(p_mod_articuloProveedores); 
        }
        /// <summary>
        /// Busca proveedores que cumplan con un parámetro de búsqueda
        /// </summary>
        /// <param name="p_mod_articuloProveedores">Proveedor con variable a buscar inicializada con algún valor</param>
        /// <param name="p_paramentroBusqueda">Constante dentro de LibreriaClasesCompartidas.Constantes.ParametrosBusqueda</param>
        /// <returns>Lista de proveedores</returns>
        public List<ModeloArticuloProveedores> buscarArticuloProveedores(ModeloArticuloProveedores p_mod_articuloProveedores, string p_paramentroBusqueda)
        {
            List<ModeloArticuloProveedores> lcl_lst_mod_articuloProveedores = new List<ModeloArticuloProveedores>();
            CatalogoArticuloProveedores lcl_cat_articuloProveedores = new CatalogoArticuloProveedores();
            if (p_paramentroBusqueda == Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoOriginal)
            {
                lcl_lst_mod_articuloProveedores.Add(lcl_cat_articuloProveedores.getOne(p_mod_articuloProveedores.codigoOriginal,p_mod_articuloProveedores.codigoArticuloProveedor));
            }
            else
            {
                if (p_paramentroBusqueda == Constantes.ParametrosBusqueda.ArticulosProveedores.All)
                {
                    lcl_lst_mod_articuloProveedores = lcl_cat_articuloProveedores.getAll();
                }
                else
                {
                    //lmArticuloProveedores = lcl_cat_articuloProveedores.buscarArticuloProveedor(pmArticuloProveedores, paramentroBusqueda); Ver como redefinir dicho metodo - parametros
                }
            }

            return lcl_lst_mod_articuloProveedores;
        }

        #endregion
                             
        #region Provincias
        /// <summary>
        /// Retorna todas las provincias de la base de datos
        /// </summary>
        /// <returns></returns>
        
        public List<ModeloProvincia> buscarProvincias()
        {
            CatalogoProvincias lcl_cat_provincias = new CatalogoProvincias();

            return lcl_cat_provincias.getAll();
        }

        /// <summary>
        /// Retorna articulos en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="p_mod_provincia"></param>
        /// <returns>Lista de proveedores</returns>
        public ModeloProvincia buscarProvincia(ModeloProvincia p_mod_provincia)
        {
            CatalogoProvincias lcl_cat_provincias = new CatalogoProvincias();

            return lcl_cat_provincias.getOne(p_mod_provincia.codigo);
        }

        #endregion

        #region Paises
        /// <summary>
        /// Retorna todas los paises de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<ModeloPais> buscarPaises()
        {
            CatalogoPaises lcl_cat_paises = new CatalogoPaises();
            return lcl_cat_paises.getAll();
        }

        /// <summary>
        /// Retorna articulos en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="p_mod_pais"></param>
        /// <returns>Lista de Paises</returns>
        public ModeloPais buscarPaises(ModeloPais p_mod_pais)
        {
            CatalogoPaises lcl_cat_paises = new CatalogoPaises();
            return lcl_cat_paises.getOne(p_mod_pais.codigo);
        }

        #endregion

        #region Domicilios
        /// <summary>
        /// Retorna articulos en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="p_mod_domicilio"></param>
        /// <returns>Lista de Paises</returns>
        public List<ModeloDomicilio> buscarDomicilios(ModeloDomicilio p_mod_domicilio)
        {
            CatalogoDomicilios lcl_cat_domicilios = new CatalogoDomicilios();
            
            return lcl_cat_domicilios.getDomicilios(p_mod_domicilio.codigoDomicilio);            
        }

        #endregion

        #region Mails
        /// <summary>
        /// Retorna articulos en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="p_mod_mails"></param>
        /// <returns>Lista de Mails</returns>
        public List<ModeloMail> buscarMails(ModeloMail p_mod_mails)
        {
            CatalogoMails lcl_cat_mails = new CatalogoMails();
            
            return lcl_cat_mails.getMails(p_mod_mails.codigoMail);
        }

        #endregion

        #region Telefonos
        /// <summary>
        /// Retorna articulos en base a los valores inicializados en los atributos del modelo
        /// </summary>
        /// <param name="p_mod_telefonos"></param>
        /// <returns>Lista de Mails</returns>
        public List<ModeloTelefono> buscarTelefonos(ModeloTelefono p_mod_telefonos)
        {
            CatalogoTelefonos lcl_cat_telefonos = new CatalogoTelefonos();

            return lcl_cat_telefonos.getTelefonos(p_mod_telefonos.codigoTelefono);
        }

        #endregion

       }
}
