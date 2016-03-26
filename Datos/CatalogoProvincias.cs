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
    public class CatalogoProvincias : Catalogo
    {
        private ModeloProvincia leerDatosProvincia(SqlDataReader p_drProvincia)
        {
            ModeloProvincia lcl_mod_provincia = new ModeloProvincia();

            lcl_mod_provincia.codigo = (string)p_drProvincia["codigo_provincia"];
            lcl_mod_provincia.provincia = (string)p_drProvincia["provincia"];
            lcl_mod_provincia.codigoPais = (string)p_drProvincia["codigo_pais"];
            
            return lcl_mod_provincia;
        }
        
        #region Búsqueda
        /// <summary>
        /// Genera string a insertar en clausula WHERE de sql de acuerdo a los parámetros de búsqueda
        /// </summary>
        /// <param name="p_mod_provincia">modeloProvincia con variables posiblemente inicializadas</param>
        /// <param name="p_parametroBusqueda">constante encontrada en LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Articulos</param>
        /// <param name="p_comando">comando sql que será modificado para incluir parámetros</param>
        /// <returns></returns>
        private string getCondicionBusqueda(ModeloProvincia p_mod_provincia, string p_parametroBusqueda, ref SqlCommand p_comando)
        {
            switch (p_parametroBusqueda)
            {
                case Constantes.ParametrosBusqueda.Provincias.CodigoProvincia:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_provincia.codigo, "@codigo_provincia"));
                    return " codigo_provincia = @codigo_provincia ";
                case Constantes.ParametrosBusqueda.Provincias.Provincia:
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(p_mod_provincia.provincia), "@provincia"));
                    return " provincia LIKE @provincia ";
                case Constantes.ParametrosBusqueda.Provincias.CodigoPais:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_provincia.codigoPais, "@codigo_pais"));
                    return " codigo_pais = @codigo_pais ";
                
                case Constantes.ParametrosBusqueda.Any:
                    string codigoProvincia = p_mod_provincia.codigo == "" ? null : p_mod_provincia.codigo;
                    p_comando.Parameters.Add(this.instanciarParametro(codigoProvincia, "@codigo_provincia"));
                    string codigoProvinciaQuery = this.parametroBusqueda("@codigo_provincia", "codigo_provincia", "=");

                    string provincia = p_mod_provincia.provincia == "" ? null : p_mod_provincia.provincia;
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(provincia), "@provincia"));
                    string provinciaQuery = this.parametroBusqueda("@provincia", "provincia", "LIKE");

                    string codigoPais = p_mod_provincia.codigoPais == "" ? null : p_mod_provincia.codigoPais;
                    p_comando.Parameters.Add(this.instanciarParametro(codigoPais, "@codigo_pais"));
                    string codigoPaisQuery = this.parametroBusqueda("@codigo_pais", "codigo_pais", "=");

                    return codigoProvinciaQuery + " AND " + provinciaQuery + " AND " + codigoPaisQuery;

                default:
                    return base.getCondicionBusqueda(p_parametroBusqueda);
            }
        }

        public List<ModeloProvincia> buscarProvincia(ModeloProvincia p_mod_provincia, string p_parametroBusqueda)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;

            string querySQL = this.getCondicionBusqueda(p_mod_provincia, p_parametroBusqueda, ref comando);

            comando.CommandText =
                "SELECT [provincias].codigo_provincia, [provincias].provincia, [provincias].codigo_pais " +
                "   FROM [provincias]  "+
                "   WHERE " + querySQL;

            comando.Connection.Open();

            SqlDataReader drProvincias = comando.ExecuteReader();

            List<ModeloProvincia> lcl_lst_mod_articulo = new List<ModeloProvincia>();
            ModeloProvincia lcl_mod_articulo = new ModeloProvincia();

            while (drProvincias.Read())
            {
                lcl_mod_articulo = new ModeloProvincia();
                lcl_mod_articulo = this.leerDatosProvincia(drProvincias);

                lcl_lst_mod_articulo.Add(lcl_mod_articulo);
            }
            drProvincias.Close();
            comando.Connection.Close();

            return lcl_lst_mod_articulo;
        }
        
        public List<ModeloProvincia> getAll()
        {
            return this.buscarProvincia(null, Constantes.ParametrosBusqueda.All);
        }

        public ModeloProvincia getOne(string p_codigoProvincia)
        {
            ModeloProvincia lcl_mod_provincia = new ModeloProvincia();
            List<ModeloProvincia> lcl_lst_mod_provincia = new List<ModeloProvincia>();
            lcl_mod_provincia.codigo = p_codigoProvincia;
            lcl_lst_mod_provincia = this.buscarProvincia(lcl_mod_provincia, Constantes.ParametrosBusqueda.Provincias.CodigoProvincia);

            if (lcl_lst_mod_provincia.Count > 0)
            {
                return lcl_lst_mod_provincia[0];
            }
            else
            {
                return null;
            }
        }
        #endregion

    }
}
