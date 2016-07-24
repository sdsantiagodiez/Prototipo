using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data;
using System.Data.SqlClient;
using LibreriaClasesCompartidas;

namespace Datos
{
    public class CatalogoClientes : CatalogoPersonas
    {
        new private  ModeloCliente leerDatosPersonas(SqlDataReader p_drClientes)
        {
            ModeloCliente lcl_mod_cliente =  new ModeloCliente(base.leerDatosPersonas(p_drClientes));
            return lcl_mod_cliente;
        }

        #region Búsqueda
        /// <summary>
        /// Genera string a insertar en clausula WHERE de sql de acuerdo a los parámetros de búsqueda
        /// </summary>
        /// <param name="p_mod_contactoProveedor">modeloCliente con variables posiblemente inicializadas</param>
        /// <param name="p_parametroBusqueda">constante encontrada en LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Proveedores</param>
        /// <param name="p_comando">comando sql que será modificado para incluir parámetros</param>
        /// <returns></returns>
        private string getCondicionBusqueda(ModeloCliente p_mod_cliente, string p_parametroBusqueda, ref SqlCommand p_comando)
        {
            switch (p_parametroBusqueda)
            {
                default:
                    //Prueba condiciones de atributos propios de modeloPersona
                    return base.getCondicionBusqueda(p_mod_cliente, p_parametroBusqueda, ref p_comando);
            }
        }

        public override IEnumerable<ModeloPersonas> buscar(ModeloPersonas p_mod_persona, string p_parametroBusqueda)
        {
            IEnumerable<ModeloCliente> lcl_lst_mod_cliente = this.buscar(p_mod_persona as ModeloCliente, p_parametroBusqueda);
            IEnumerable<ModeloPersonas> lcl_lst_mod_personas = lcl_lst_mod_cliente;
            return lcl_lst_mod_personas;
        }

        public IEnumerable<ModeloCliente> buscar(ModeloCliente p_mod_cliente, string p_parametroBusqueda)
        {
            return this.buscarCliente(p_mod_cliente, p_parametroBusqueda);
        }

        /// <summary>
        /// Busca personas en base al parámetro ingresado (no se diferencia codigo entidad de proveedor y de contactoProveedor)
        /// </summary>
        /// <param name="p_mod_cliente">modeloCliente con variables posiblemente inicializadas</param>
        /// <param name="p_paramentroBusqueda">string contenida en LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Personas</param>
        /// <returns></returns>
        public List<ModeloCliente> buscarCliente(ModeloCliente p_mod_cliente, string p_paramentroBusqueda)
        {
            List<ModeloCliente> lcl_lst_mod_clientes = new List<ModeloCliente>();

            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            string querySQL = this.getCondicionBusqueda(p_mod_cliente, p_paramentroBusqueda, ref comando);

            comando.CommandText =
                "SELECT [personas].codigo_entidad,[entidades].tipo_entidad,[entidades].cuit,[entidades].observaciones,[personas].dni," +
                "[personas].nombre,[personas].apellido,[personas].tipo_persona, [entidades].activo " +
                    "FROM [personas] " +
                    "INNER JOIN [entidades] on [entidades].codigo = [personas].codigo_entidad " +
                    "WHERE [personas].tipo_persona = '" + Constantes.TiposEntidad.TiposPersona.Cliente + "' AND " + querySQL;

            comando.Connection.Open();

            SqlDataReader drUsuarios = comando.ExecuteReader();

            while (drUsuarios.Read())
            {
                p_mod_cliente = new ModeloCliente();
                p_mod_cliente = this.leerDatosPersonas(drUsuarios);

                lcl_lst_mod_clientes.Add(p_mod_cliente);
            }
            drUsuarios.Close();
            comando.Connection.Close();


            foreach (ModeloCliente c in lcl_lst_mod_clientes)
            {
                this.getDatosAdicionales(c);
            }

            return lcl_lst_mod_clientes;
        }
               

        #endregion

        #region Alta/Baja/Modificación
        public override bool add(ModeloPersonas p_mod_persona)
        {
            return this.add(p_mod_persona as ModeloCliente);
        }

        public bool add(ModeloCliente p_mod_cliente)
        {
            return base.add(p_mod_cliente as ModeloPersonas);
        }

        //public override bool update(ModeloPersonas p_mod_persona)
        //{
        //    return this.update(p_mod_persona as ModeloCliente);
        //}

        public bool update(ModeloCliente p_mod_cliente)
        {
            return base.update(p_mod_cliente as ModeloPersonas);
        }

        public override bool remove(ModeloPersonas p_mod_persona)
        {
            return this.remove(p_mod_persona as ModeloCliente);
        }

        public bool remove(ModeloCliente p_mod_cliente)
        {
            return base.remove(p_mod_cliente as ModeloPersonas);
        }

        #endregion
    }
}
