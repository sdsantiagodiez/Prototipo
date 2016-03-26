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
    public class CatalogoRoles : Catalogo
    {
        public ModeloRoles leerDatosRoles(SqlDataReader p_drRoles)
        {
            ModeloRoles lcl_mod_rol = new ModeloRoles();
            lcl_mod_rol.codigo = (int)p_drRoles["codigo"];
            lcl_mod_rol.descripcion = (string)p_drRoles["descripcion"];
            return lcl_mod_rol;
        }

        #region Búsqueda
        /// <summary>
        /// Genera string a insertar en clausula WHERE de sql de acuerdo a los parámetros de búsqueda
        /// </summary>
        /// <param name="p_mod_roles">modelo con variables posiblemente inicializadas</param>
        /// <param name="p_parametroBusqueda">constante encontrada en LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Proveedores</param>
        /// <param name="p_comando">comando sql que será modificado para incluir parámetros</param>
        /// <returns></returns>
        private string getCondicionBusqueda(ModeloRoles p_mod_roles, string p_parametroBusqueda, ref SqlCommand p_comando)
        {
            switch (p_parametroBusqueda)
            {
                case Constantes.ParametrosBusqueda.Roles.codigoRol:
                case Constantes.ParametrosBusqueda.Any:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_roles.codigo, "@codigo_rol"));
                    return " codigo = @codigo_rol ";
                
                default:
                    return base.getCondicionBusqueda(p_parametroBusqueda);
            }
        }

        /// <summary>
        /// Busca roles en base al parámetro ingresado
        /// </summary>
        /// <param name="p_mod_roles">modelo con variables posiblemente inicializadas</param>
        /// <param name="p_paramentroBusqueda">string contenida en LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Personas</param>
        /// <returns></returns>
        public List<ModeloRoles> buscar(ModeloRoles p_mod_roles, string p_paramentroBusqueda)
        {
            List<ModeloRoles> lcl_lst_mod_roles = new List<ModeloRoles>();

            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            string querySQL = this.getCondicionBusqueda(p_mod_roles, p_paramentroBusqueda, ref comando);

            comando.CommandText =
                "SELECT codigo, descripcion " +
                "   FROM [Rol] " +
                "   WHERE "+ querySQL;

            comando.Connection.Open();

            SqlDataReader drRoles = comando.ExecuteReader();

            while (drRoles.Read())
            {
                p_mod_roles = new ModeloRoles();
                p_mod_roles = this.leerDatosRoles(drRoles);

                lcl_lst_mod_roles.Add(p_mod_roles);
            }
            drRoles.Close();
            comando.Connection.Close();

            return lcl_lst_mod_roles;
        }

        #endregion
    }
}
