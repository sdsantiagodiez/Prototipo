using System;
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
        /// Retorna una persona completa (con mails, telefonos, domicilios)
        /// </summary>
        /// <returns>ModeloPersona</returns>
        public ModeloPersonas busqPersCompleta(string dni){
            ModeloPersonas per = new ModeloPersonas();
            per.dni=dni;
            per = this.buscarPersonas(per)[0];
            var mails = new List<ModeloMail>();
            var tels = new List<ModeloTelefono>();
            var doms = new List<ModeloDomicilio>();

            mails = this.getMail(per.codigo);
            tels = this.getTel(per.codigo);
            doms = this.getDoms(per.codigo);

            per.mails = mails;
            per.telefonos = tels;
            per.domicilios = doms;
            
            return per;
        }
        
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

        private List<ModeloDomicilio> getDoms(int codigoEntidad)
        {
            var catDom = new CatalogoDomicilios();
            return catDom.getDomicilios(codigoEntidad);
        }

        private List<ModeloTelefono> getTel(int codigoEntidad)
        {
            var catTel = new CatalogoTelefonos();
            return catTel.getTelefonos(codigoEntidad);
        }

        private List<ModeloMail> getMail(int codigoEntidad)
        {
            var catMail = new CatalogoMails();
            return catMail.getMails(codigoEntidad);
        } 
    }
}
