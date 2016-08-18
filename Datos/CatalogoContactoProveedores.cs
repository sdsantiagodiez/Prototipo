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
    public class CatalogoContactoProveedores : CatalogoPersonas
    {
        #region Leer datos

        private ModeloContactoProveedor leerDatosContactoProveedor(SqlDataReader p_drContactoProveedor)
        {
            ModeloContactoProveedor lcl_mod_contactoProveedor = new ModeloContactoProveedor(base.leerDatosPersonas(p_drContactoProveedor));

            ModeloProveedor lcl_mod_proveedor = new ModeloProveedor();

            lcl_mod_proveedor.codigo = (int)p_drContactoProveedor["codigo_proveedor"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            lcl_mod_proveedor.cuit = (p_drContactoProveedor["cuit_proveedor"] != DBNull.Value) ? (string)p_drContactoProveedor["cuit_proveedor"] : null;
            lcl_mod_proveedor.razonSocial = (p_drContactoProveedor["razon_social_proveedor"] != DBNull.Value) ? (string)p_drContactoProveedor["razon_social_proveedor"] : null;

            lcl_mod_contactoProveedor.proveedor = lcl_mod_proveedor;
            return lcl_mod_contactoProveedor;

        }
 
        #endregion

        #region Búsqueda
        /// <summary>
        /// Genera string a insertar en clausula WHERE de sql de acuerdo a los parámetros de búsqueda
        /// </summary>
        /// <param name="p_mod_contactoProveedor">modeloContactoProveedor con variables posiblemente inicializadas</param>
        /// <param name="p_parametroBusqueda">constante encontrada en LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Proveedores</param>
        /// <param name="p_comando">comando sql que será modificado para incluir parámetros</param>
        /// <returns></returns>
        private string getCondicionBusqueda(ModeloContactoProveedor p_mod_contactoProveedor, string p_parametroBusqueda, ref SqlCommand p_comando)
        {
            //(no se diferencia codigo entidad de proveedor y de contactoProveedor)
            switch (p_parametroBusqueda)
            {
                //Con estas condiciones se obtienen todos los contactos de proveedor de un proveedor
                case Constantes.ParametrosBusqueda.Entidades.Personas.ContactoProveedor.CodigoEntidad_Proveedor:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_contactoProveedor.proveedor.codigo, "@codigo_proveedor"));
                    return " codigo_proveedor = @codigo_proveedor ";
                case Constantes.ParametrosBusqueda.Entidades.Personas.ContactoProveedor.RazonSocial_Proveedor:
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(p_mod_contactoProveedor.proveedor.razonSocial), "@razon_social"));
                    return " razon_social_proveedor LIKE @razon_social ";
                case Constantes.ParametrosBusqueda.Entidades.Personas.ContactoProveedor.Cuit:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_contactoProveedor.proveedor.cuit, "@cuit_prooveedor"));
                    return " cuit_proveedor = @cuit_proveedor ";
                case Constantes.ParametrosBusqueda.Any:
                    string queryBase = base.getCondicionBusqueda(p_mod_contactoProveedor, p_parametroBusqueda, ref p_comando);
                    if (p_mod_contactoProveedor.proveedor != null)
                    {
                        string razonSocial = String.IsNullOrWhiteSpace(p_mod_contactoProveedor.proveedor.razonSocial ) ? null : p_mod_contactoProveedor.proveedor.razonSocial;
                    p_comando.Parameters.Add(this.instanciarParametro(razonSocial, "@razon_social"));
                    string razonSocialQuery = " (@razon_social is null or razon_social_proveedor LIKE @razon_social) ";

                    int? codigoProveedor = (p_mod_contactoProveedor.proveedor.codigo == 0) ? null : (int?)p_mod_contactoProveedor.proveedor.codigo;
                    p_comando.Parameters.Add(this.instanciarParametro(codigoProveedor, "@codigo_proveedor"));
                    string codigoProveedorQuery =" (@codigo_proveedor is null or codigo_proveedor=@codigo_proveedor) ";

                    string cuit = String.IsNullOrWhiteSpace(p_mod_contactoProveedor.proveedor.cuit) ? null : p_mod_contactoProveedor.proveedor.cuit;
                    p_comando.Parameters.Add(this.instanciarParametro(cuit, "@cuit_proveedor"));
                    string cuitProveedorQuery = " (@cuit_proveedor is null OR cuit_proveedor=@cuit_proveedor) ";

                    string extraQuery = " NOT(@razon_social is null AND @codigo_proveedor is null AND @cuit_proveedor is null) ";//algo debe ser distinto de null
                    return queryBase + " AND " +razonSocialQuery + " AND " +codigoProveedorQuery+ " AND "+cuitProveedorQuery + " AND "+ extraQuery;
                    }
                    return queryBase;
                default:
                    //Prueba condiciones de atributos propios de modeloPersona
                    return base.getCondicionBusqueda(p_mod_contactoProveedor, p_parametroBusqueda, ref p_comando);
            }
        }

        public override IEnumerable<ModeloPersonas> buscar(ModeloPersonas p_mod_persona, string p_parametroBusqueda)
        {
            IEnumerable<ModeloContactoProveedor> lcl_lst_mod_contactoProveedores = this.buscar(p_mod_persona as ModeloContactoProveedor, p_parametroBusqueda);
            IEnumerable<ModeloPersonas> lcl_lst_mod_personas = lcl_lst_mod_contactoProveedores;
            return lcl_lst_mod_personas;
        }

        public IEnumerable<ModeloContactoProveedor> buscar(ModeloContactoProveedor p_mod_usuario, string p_parametroBusqueda)
        {
            return this.buscarContactoProveedor(p_mod_usuario, p_parametroBusqueda);
        }

        /// <summary>
        /// Busca personas en base al parámetro ingresado (no se diferencia codigo entidad de proveedor y de contactoProveedor)
        /// </summary>
        /// <param name="p_mod_contactoProveedor">modeloContactoProveedor con variables posiblemente inicializadas</param>
        /// <param name="p_paramentroBusqueda">string contenida en LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Personas</param>
        /// <returns></returns>
        public List<ModeloContactoProveedor> buscarContactoProveedor(ModeloContactoProveedor p_mod_contactoProveedor, string p_paramentroBusqueda)
        {
            List<ModeloContactoProveedor> lcl_lst_mod_contactoProveedor = new List<ModeloContactoProveedor>();
            SqlConnection ConexionSQL = Conexion.crearConexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            string querySQL = this.getCondicionBusqueda(p_mod_contactoProveedor, p_paramentroBusqueda, ref comando);

            comando.CommandText =
                "SELECT * FROM ("+
                "SELECT per_1.codigo_entidad,e_1.tipo_entidad,e_1.cuit,e_1.observaciones,per_1.dni," +
                "per_1.nombre,per_1.apellido,per_1.tipo_persona, pro.codigo_entidad as codigo_proveedor,pro.razon_social as razon_social_proveedor, " +
                "e_2.cuit as cuit_proveedor, e_1.activo, " +
                "   e_1.situacion_iva " +
                    "FROM personas per_1 " +
                    "INNER JOIN [entidades] e_1 on e_1.codigo = per_1.codigo_entidad " +
                    "INNER JOIN [Contactos_Proveedores] cp on cp.codigo_contacto = e_1.codigo  " +
                    "INNER JOIN [Proveedores] pro on pro.codigo_entidad = cp.codigo_proveedor  "+
                    "INNER JOIN [Entidades] e_2 on e_2.codigo = pro.codigo_entidad " +
                
                    ") tbl_ContactoProveedor WHERE tipo_persona = '" + Constantes.TiposEntidad.TiposPersona.ContactoProveedor + "' AND " + querySQL;

            comando.Connection.Open();

            SqlDataReader drContactoProveedor = comando.ExecuteReader();

            while (drContactoProveedor.Read())
            {
                p_mod_contactoProveedor = new ModeloContactoProveedor();
                p_mod_contactoProveedor = this.leerDatosContactoProveedor(drContactoProveedor);

                lcl_lst_mod_contactoProveedor.Add(p_mod_contactoProveedor);
            }
            drContactoProveedor.Close();
            comando.Connection.Close();

            foreach (ModeloContactoProveedor c in lcl_lst_mod_contactoProveedor)
            {
                this.getDatosAdicionales(c);
            }

            return lcl_lst_mod_contactoProveedor;
        }
               
        #endregion

        #region Alta/Baja/Modificación

        public override bool add(ModeloPersonas p_mod_persona)
        {
            return this.add(p_mod_persona as ModeloContactoProveedor);
        }
        
        public bool add(ModeloContactoProveedor p_mod_contactoProveedor)
        {
            if (base.add(p_mod_contactoProveedor as ModeloPersonas) && this.addContactoProveedor(p_mod_contactoProveedor))
            {
                return true;
            }
            throw new Exception("Ha ocurrido un error en la base de datos. No se ha podido registrar Contacto de Proveedor.");
        }

        private bool addContactoProveedor(ModeloContactoProveedor p_mod_contactoProveedor)
        {
            string query =
                 "INSERT INTO [Contactos_Proveedores]([codigo_proveedor],[codigo_contacto]) " +
                 "VALUES (@codigo_proveedor, @codigo_contacto)";
            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());

            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro(p_mod_contactoProveedor.proveedor.codigo, "@codigo_proveedor"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_contactoProveedor.codigo, "@codigo_contacto"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            { return true; }
            else
            { return false; }
        }

        public override bool update(ModeloEntidad p_mod_entidad_original, ModeloEntidad p_mod_entidad_nueva)
        {
            if (!p_mod_entidad_original.Equals(p_mod_entidad_nueva))
            {
                if (!this.updateContactoProveedor(p_mod_entidad_nueva as ModeloContactoProveedor))
                {
                    return false;
                }
            }
            return base.update(p_mod_entidad_original, p_mod_entidad_nueva);
        }

        private bool updateContactoProveedor(ModeloContactoProveedor p_mod_contactoProveedor)
        {
            string query =
                "UPDATE [Contactos_Proveedores] SET " +
                "[codigo_proveedor]=@codigo_proveedor " +
                "WHERE codigo_contacto=@codigo_contacto";
            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());

            comando.Parameters.Add(this.instanciarParametro(p_mod_contactoProveedor.proveedor.codigo, "@codigo_proveedor"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_contactoProveedor.codigo, "@codigo_contacto"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            { return true; }
            else
            { return false; }
        }

        public override bool remove(ModeloPersonas p_mod_persona)
        {
            return this.remove(p_mod_persona as ModeloContactoProveedor);
        }

        public bool remove(ModeloContactoProveedor p_mod_contactoProveedor)
        {
            if (this.removeContactoProveedor(p_mod_contactoProveedor))
            {
                return base.remove(p_mod_contactoProveedor as ModeloPersonas);
            }
            return false;
        }

        private bool removeContactoProveedor(ModeloContactoProveedor p_mod_contactoProveedor)
        {
            string query =
                 "DELETE FROM [Contactos_Proveedores] " +
                 "  WHERE @codigo_proveedor=codigo_proveedor AND @codigo_contacto=codigo_contacto";
            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());

            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro(p_mod_contactoProveedor.proveedor.codigo, "@codigo_proveedor"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_contactoProveedor.codigo, "@codigo_contacto"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            { return true; }
            else
            { return false; }
        }

        #endregion
    }
}
