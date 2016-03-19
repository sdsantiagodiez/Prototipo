﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data.SqlClient;
using System.Data;
using LibreriaClasesCompartidas;

namespace Datos
{
    public class CatalogoProveedores : CatalogoEntidades
    {
        public bool validarDatos(ModeloProveedor p_mod_proveedor)
        {
            //Valida que los parametros sean Validos en el dominio
            return true;
        }    

        public ModeloProveedor leerDatosProveedor(SqlDataReader p_drProveedores)
        {
            ModeloProveedor lcl_mod_proveedor = new ModeloProveedor(this.leerDatosEntidades(p_drProveedores));

            lcl_mod_proveedor.razonSocial = (p_drProveedores["razon_social"] != DBNull.Value) ? (string)p_drProveedores["razon_social"] : null;
            
            return lcl_mod_proveedor;
        }
        
        #region Búsqueda
        
        /// <summary>
        /// Genera string a insertar en clausula WHERE de sql de acuerdo a los parámetros de búsqueda
        /// </summary>
        /// <param name="p_mod_proveedor">modeloProveedor con variables posiblemente inicializadas</param>
        /// <param name="p_parametroBusqueda">constante encontrada en LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Proveedores</param>
        /// <param name="p_comando">comando sql que será modificado para incluir parámetros</param>
        /// <returns></returns>
        protected string getCondicionBusqueda(ModeloProveedor p_mod_proveedor,string p_parametroBusqueda,ref SqlCommand p_comando)
        {
            switch (p_parametroBusqueda)
            {
                case Constantes.ParametrosBusqueda.Entidades.Proveedores.RazonSocial:
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(p_mod_proveedor.razonSocial), "@razon_social"));
                    return " razon_social LIKE @razon_social ";
                    
                case Constantes.ParametrosBusqueda.Entidades.Proveedores.Any:
                    string queryBase = base.getCondicionBusqueda(p_mod_proveedor,p_parametroBusqueda,ref p_comando);

                    string razonSocial = p_mod_proveedor.razonSocial == "" ? null : p_mod_proveedor.razonSocial;
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(razonSocial), "@razon_social"));
                    string razonSocialQuery = this.parametroBusqueda("@razon_social", "razon_social", "LIKE");

                    return queryBase + " AND " + razonSocialQuery;
                    
                default:
                    //Prueba condiciones de atributos propios de modeloEntidad
                    return base.getCondicionBusqueda(p_mod_proveedor, p_parametroBusqueda, ref p_comando);
            }
        }

        public override IEnumerable<ModeloEntidad> buscar(ModeloEntidad p_mod_entidad, string p_parametroBusqueda)
        {
            IEnumerable<ModeloProveedor> lcl_lst_mod_proveedores = this.buscar(p_mod_entidad as ModeloProveedor, p_parametroBusqueda);
            IEnumerable<ModeloEntidad> lcl_lst_mod_entidades = lcl_lst_mod_proveedores;
            return lcl_lst_mod_entidades;
        }

        public virtual IEnumerable<ModeloProveedor> buscar(ModeloProveedor p_mod_proveedor, string p_parametroBusqueda)
        {
            return this.buscarProveedor(p_mod_proveedor, p_parametroBusqueda);
        }

        /// <summary>
        /// Busca proveedor(es) en base al parámetro ingresado
        /// </summary>
        /// <param name="p_mod_proveedor">modeloProveedor con variables posiblemente inicializadas</param>
        /// <param name="p_parametroBusqueda">Constantes obtenidas en LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Proveedores</param>
        /// <returns></returns>
        public List<ModeloProveedor> buscarProveedor(ModeloProveedor p_mod_proveedor, string p_parametroBusqueda)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;

            string querySQL = this.getCondicionBusqueda(p_mod_proveedor,p_parametroBusqueda,ref comando);
            
            comando.CommandText =
                "SELECT [proveedores].codigo_entidad,[entidades].tipo_entidad,[entidades].cuit,[entidades].observaciones,[proveedores].razon_social" +
                "   FROM [proveedores] " +
                "   INNER JOIN [entidades] on [entidades].codigo = [proveedores].codigo_entidad " +
                "   WHERE " + querySQL;

            comando.Connection.Open();

            SqlDataReader drProveedores = comando.ExecuteReader();

            List<ModeloProveedor> lcl_lst_mod_proveedor = new List<ModeloProveedor>();
            ModeloProveedor lcl_mod_proveedor = new ModeloProveedor();

            while (drProveedores.Read())
            {
                lcl_mod_proveedor = new ModeloProveedor();
                lcl_mod_proveedor = this.leerDatosProveedor(drProveedores);

                lcl_mod_proveedor.mails = this.getMails(lcl_mod_proveedor.codigo);
                lcl_mod_proveedor.telefonos = this.getTelefonos(lcl_mod_proveedor.codigo);
                lcl_mod_proveedor.domicilios = this.getDomicilios(lcl_mod_proveedor.codigo);

                lcl_lst_mod_proveedor.Add(lcl_mod_proveedor);
            }
            drProveedores.Close();

            comando.Connection.Close();

            return lcl_lst_mod_proveedor;
        }
        
        /// <summary>
        /// Busca proveedor de acuerdo a codigo de entidad
        /// </summary>
        /// <param name="p_codigoEntidad">codigo entidad del proveedor a buscar</param>
        /// <returns>ModeloProveedor si encuentra, null si no encuentra resultado</returns>
        new public ModeloProveedor getOne(int p_codigoEntidad)
        {
            ModeloProveedor lcl_mod_proveedor = new ModeloProveedor();
            List<ModeloProveedor> lcl_lst_mod_proveedor = new List<ModeloProveedor>();
            lcl_mod_proveedor.codigo = p_codigoEntidad;
            lcl_lst_mod_proveedor = this.buscarProveedor(lcl_mod_proveedor, Constantes.ParametrosBusqueda.Entidades.Proveedores.CodigoEntidad);
            
            if (lcl_lst_mod_proveedor.Count > 0)
            {
                return lcl_lst_mod_proveedor[0];
            }
            else
            {
                return null;
            }
        }
       
        /// <summary>
        /// Busca todos los proveedores que se encuentren en la base de datos
        /// </summary>
        /// <returns></returns>
        public new List<ModeloProveedor> getAll()
        {
            return this.buscarProveedor(null, Constantes.ParametrosBusqueda.Entidades.Proveedores.All);
        }

        #endregion

        #region Alta/Baja/Modificación

        public override bool add(ref ModeloEntidad p_mod_entidad)
        {
            if (!base.add(ref p_mod_entidad))
            {
                return false;
            }
            return this.add(p_mod_entidad as ModeloProveedor);
        }

        private bool add(ModeloProveedor p_mod_proveedor)
        {
            SqlConnection ConexionSQL = Conexion.crearConexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "INSERT INTO [Proveedores] ([codigo_entidad], [razon_social]) "+
                "VALUES (@codigo_entidad, @razon_social)";
            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro(p_mod_proveedor.codigo, "@codigo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_proveedor.razonSocial, "@razon_social"));
                
            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //No se podrá modificar razonSocial
        public bool update(ModeloProveedor p_mod_proveedor)
        {
            return base.update(p_mod_proveedor);
        }

        public override bool remove(ModeloEntidad p_mod_entidad)
        {
            return this.remove(p_mod_entidad as ModeloProveedor);
        }

        public bool remove(ModeloProveedor p_mod_proveedor)
        {
            //INCOMPLETO. Igual que en CatalogoPersonas
            return base.remove(p_mod_proveedor);
        }
        #endregion
    }

}

