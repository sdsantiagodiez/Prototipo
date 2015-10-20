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
        public List<ModeloPersonas> buscar(ModeloPersonas pmPersona)
        {
            CatalogoPersonas cp = new CatalogoPersonas();
            pmPersona.convertirDatos();
            List<ModeloPersonas> lmPersonas = new List<ModeloPersonas>();
            lmPersonas = cp.buscarPersona(pmPersona);            
            
            return lmPersonas;
        }
        /// <summary>
        /// Busca personas que cumplan con un parámetro de búsqueda
        /// </summary>
        /// <param name="pmPersona">Persona con variable a buscar inicializada con algún valor</param>
        /// <param name="paramentroBusqueda">codigoEntidad,cuit,dni,nombre,apellido,usuario,tipoPersona</param>
        /// <returns>Lista de personas</returns>
        public List<ModeloPersonas> buscar(ModeloPersonas pmPersona, string paramentroBusqueda)
        {
            List<ModeloPersonas> lmPersonas = new List<ModeloPersonas>();
            CatalogoPersonas cp = new CatalogoPersonas();
            if (paramentroBusqueda != "codigoEntidad")
            {
                lmPersonas = cp.buscarPersona(pmPersona, paramentroBusqueda);
            }
            else
            {
                lmPersonas.Add(cp.getOne(pmPersona.codigo));
            }
            return lmPersonas;
        }

        #endregion

        #region Proveedores
        public List<ModeloProveedor> buscar(ModeloProveedor pmProveedor)
        {
            CatalogoProveedores cp = new CatalogoProveedores();
            pmProveedor.convertirDatos();
            List<ModeloProveedor> lmProveedor = new List<ModeloProveedor>();
            lmProveedor = cp.buscarProveedor(pmProveedor);
            
            return lmProveedor;
        }

        public List<ModeloProveedor> buscar(ModeloProveedor pmProveedor, string paramentroBusqueda)
        {
            List<ModeloProveedor> lmProveedor = new List<ModeloProveedor>();

            return lmProveedor;
        }

        #endregion

        #endregion
    }
}
