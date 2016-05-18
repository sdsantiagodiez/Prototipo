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
    public class CatalogoPaises : Catalogo
    {
        private ModeloPais leerDatosPais(SqlDataReader p_drPais)
        {
            ModeloPais lcl_mod_pais = new ModeloPais();

            lcl_mod_pais.codigo = (string)p_drPais["codigo"];
            lcl_mod_pais.pais = (string)p_drPais["pais"];

            return lcl_mod_pais;
        }

        private bool existeEntidad(string p_codigo)
        {
            return (getOne(p_codigo) != null);
        }
        
        #region Búsqueda
        /// <summary>
        /// Genera string a insertar en clausula WHERE de sql de acuerdo a los parámetros de búsqueda
        /// </summary>
        /// <param name="p_mod_pais">modeloPais con variables posiblemente inicializadas</param>
        /// <param name="p_parametroBusqueda">constante encontrada en LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Articulos</param>
        /// <param name="p_comando">comando sql que será modificado para incluir parámetros</param>
        /// <returns></returns>
        private string getCondicionBusqueda(ModeloPais p_mod_pais, string p_parametroBusqueda, ref SqlCommand p_comando)
        {
            switch (p_parametroBusqueda)
            {
                case Constantes.ParametrosBusqueda.Paises.Codigo:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_pais.codigo, "@codigo_pais"));
                    return " codigo = @codigo_pais ";
                case Constantes.ParametrosBusqueda.Paises.Pais:
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(p_mod_pais.pais), "@pais"));
                    return " pais LIKE @pais ";

                case Constantes.ParametrosBusqueda.Any:
                    string codigoPais = String.IsNullOrWhiteSpace(p_mod_pais.codigo )? null : p_mod_pais.codigo;
                    p_comando.Parameters.Add(this.instanciarParametro(codigoPais, "@codigo_pais"));
                    string codigoPaisQuery = this.parametroBusqueda("@codigo_pais", "codigo", "=");

                    string pais = String.IsNullOrWhiteSpace(p_mod_pais.pais )? null : p_mod_pais.pais;
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(pais), "@pais"));
                    string paisQuery = this.parametroBusqueda("@pais", "pais", "LIKE");

                    return codigoPaisQuery + " AND " + paisQuery + " AND " + codigoPaisQuery;

                default:
                    return base.getCondicionBusqueda(p_parametroBusqueda);
            }
        }

        public List<ModeloPais> buscarPais(ModeloPais p_mod_pais, string p_parametroBusqueda)
        {
            SqlConnection ConexionSQL = Conexion.crearConexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;

            string querySQL = this.getCondicionBusqueda(p_mod_pais, p_parametroBusqueda, ref comando);

            comando.CommandText =
                "SELECT [paises].codigo,[paises].pais " +
                "   FROM [paises] "+
                "   WHERE " + querySQL;

            comando.Connection.Open();

            SqlDataReader drPais = comando.ExecuteReader();

            List<ModeloPais> lcl_lst_mod_pais = new List<ModeloPais>();
            ModeloPais lcl_mod_pais = new ModeloPais();

            while (drPais.Read())
            {
                lcl_mod_pais = new ModeloPais();
                lcl_mod_pais = this.leerDatosPais(drPais);

                lcl_lst_mod_pais.Add(lcl_mod_pais);
            }
            drPais.Close();
            comando.Connection.Close();

            return lcl_lst_mod_pais;
        }

        public List<ModeloPais> getAll()
        {
            return this.buscarPais(null, Constantes.ParametrosBusqueda.All);
        }

        public ModeloPais getOne(string p_codigoPais)
        {
            ModeloPais lcl_mod_pais = new ModeloPais();
            List<ModeloPais> lcl_lst_mod_pais = new List<ModeloPais>();
            lcl_mod_pais.codigo = p_codigoPais;
            lcl_lst_mod_pais = this.buscarPais(lcl_mod_pais, Constantes.ParametrosBusqueda.Paises.Codigo);

            if (lcl_lst_mod_pais.Count > 0)
            {
                return lcl_lst_mod_pais[0];
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region Alta/Baja/Modificación
        /*
         * True si se realizó correctamente
         * False si ocurrió algún error
         */
        public bool add(ModeloPais p_mod_pais)
        {
            if(this.existeEntidad(p_mod_pais.codigo))
            { return false; }

            string query =
                "INSERT INTO [pais]([codigo],[pais]) " +
                "   VALUES (@codigo, @pais)";

            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());

            comando.Parameters.Add(this.instanciarParametro(p_mod_pais.codigo, "@codigo"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pais.pais, "@pais"));
                
            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            { return true; }
            else
            { return false; }
        }

        public bool update(ModeloPais p_mod_pais)
        {
            string query =
                "UPDATE [pais] SET [pais]=@pais" +
                "   WHERE [pais].codigo=@codigo";

            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());
                
            comando.Parameters.Add(this.instanciarParametro(p_mod_pais.codigo, "@codigo"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pais.pais, "@pais"));
            
            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            { return true; }
            else
            { return false; }
        }

        public bool remove(ModeloPais p_mod_pais)
        {
            string query =
                "DELETE FROM [pais] "+
                "   WHERE [pais].codigo=@codigo";

            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());         

            comando.Parameters.Add(this.instanciarParametro(p_mod_pais.codigo, "@codigo"));

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
