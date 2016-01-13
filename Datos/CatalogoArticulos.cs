using System;
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
    //buscarPorCodigoOriginal y getOne hacen lo mismo
    //revisar y modificar, si corresponde, existeEntidad y buscarArticulo
    public class CatalogoArticulos : Catalogo
    {

        /// <summary>
        /// permite inicializar substring para consulta sql donde el valor del atributo 
        /// </summary>
        /// <param name="p_nombreParametro">Valor que luego es comparado con una celda de la tabla de datos</param>
        /// <param name="p_nombreParametroTabla">nombre de la columna en tabla de datos</param>
        /// <returns></returns>
        private string parametroBusqueda(string p_nombreParametro, string p_nombreParametroTabla, string p_comparador)
        {
            string querySQL =
                @" (" + p_nombreParametro + " IS NULL OR " + p_nombreParametro + " " + p_comparador + " " + "LOWER(" + p_nombreParametroTabla + ") ) ";
            return querySQL;
        }

        public bool validarDatos(ModeloArticulos p_mod_articulo)
        {
            // Validar si los datos son correctos
            return true;
        }

        /// <summary>
        /// Determina existencia de articulo de acuerdo a codigoOriginal ingresado
        /// </summary>
        /// <param name="p_codigoOriginal">código original de artículo</param>
        /// <returns>true si existe, false si no existe</returns>
        public bool existeEntidad(string p_codigoOriginal)
        {
            bool respuesta = false;
            if(getOne(p_codigoOriginal) != null)
            {
                respuesta = true;
            }
            return respuesta;
        }
        
        private ModeloArticulos leerDatosArticulo(SqlDataReader p_drArticulos)
        {
            ModeloArticulos modArt = new ModeloArticulos();

            modArt.codigoOriginal = (string)p_drArticulos["codigo_original"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            modArt.descripcion = (p_drArticulos["descripcion"] != DBNull.Value) ? (string)p_drArticulos["descripcion"] : null;
            modArt.modelos= (p_drArticulos["modelos"] != DBNull.Value) ? (string)p_drArticulos["modelos"] : null;
            modArt.observaciones = (p_drArticulos["observaciones"] != DBNull.Value) ? (string)p_drArticulos["observaciones"] : null;

            return modArt;
        }

        /// <summary>
        /// Busca por codigoOriginal o descripción y devuelve lista de artículos
        /// </summary>
        /// <param name="tipoParametro">"codigoOriginal" o "descripcion"</param>
        /// <param name="descripcionParametro">string por el que se buscará artículo</param>
        /// <returns></returns>
        /// 

        public List<ModeloArticulos> buscarArticulo(ModeloArticulos p_mod_articulo)
        {
            List<ModeloArticulos> lmArticulo = new List<ModeloArticulos>();

            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(this.instanciarParametro(p_mod_articulo.codigoOriginal, "@codigo_original"));
            string codigoEntidadQuery = @" (@codigo_original IS NULL OR @codigo_original = codigo_original) ";
            comando.Parameters.Add(this.instanciarParametro(p_mod_articulo.descripcion, "@descripcion"));
            string descripcionQuery = this.parametroBusqueda("@descripcion", "descripcion", "=");
            comando.Parameters.Add(this.instanciarParametro(p_mod_articulo.modelos, "@modelos"));
            string modeloQuery = this.parametroBusqueda("@modelos", "modelos", "=");
            comando.Parameters.Add(this.instanciarParametro(p_mod_articulo.observaciones, "@observaciones"));
            string observacionesQuery = this.parametroBusqueda("@observaciones", "observaciones", "LIKE");
            
            string querySQL = codigoEntidadQuery + " AND " + descripcionQuery + " AND " + modeloQuery + " AND " + observacionesQuery;

            comando.CommandText =
                "SELECT [Articulos].codigo_original ,[Articulos].descripcion,[Articulos].modelos,[Articulos].observaciones " +
                    "FROM [Articulos] " +
                    "WHERE " + querySQL;

            comando.Connection.Open();

            SqlDataReader drArticulos = comando.ExecuteReader();

            ModeloArticulos modArt = new ModeloArticulos();

            while (drArticulos.Read())
            {
                modArt = new ModeloArticulos();
                modArt = this.leerDatosArticulo(drArticulos);

                
                lmArticulo.Add(modArt);
            }
            drArticulos.Close();
            comando.Connection.Close();

            return lmArticulo;
        }
        public List<ModeloArticulos> buscarArticulo(ModeloArticulos p_mod_articulo, string p_parametroBusqueda)
        {
            List<ModeloArticulos> lcl_lst_mod_articulos = new List<ModeloArticulos>();

            string querySQL = "";

            switch (p_parametroBusqueda)
            { 
                case Constantes.ParametrosBusqueda.Articulos.Descripcion:
                    querySQL = " descripcion = @descripcion ";
                    break;
                default:
                    //hace que sql no retorne filas
                    querySQL = " 1 = 2 ";
                    break;
            }

            return lcl_lst_mod_articulos;
        }
        public List<ModeloArticulos> buscarArticulo(string p_tipoParametro, string p_descripcionParametro)
        {
            List<ModeloArticulos> lcl_lst_mod_articulos = new List<ModeloArticulos>();

            switch (p_tipoParametro.ToLower())
            {
                case "codigooriginal":
                    lcl_lst_mod_articulos = buscarPorCodigoOriginal(p_descripcionParametro);
                    break;
                case "descripcion":
                    lcl_lst_mod_articulos = buscarPorDescripcion(p_descripcionParametro);
                    break;
                default:
                    break;
            }
            return lcl_lst_mod_articulos;
        }

        private List<ModeloArticulos> buscarPorCodigoOriginal(string p_codigoOriginal)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText = 
                "SELECT [codigo_original],[descripcion],[modelos],[observaciones] FROM [articulos] "+
                "WHERE codigo_original LIKE @codigo_original";

            comando.Parameters.Add(new SqlParameter("@codigo_original", SqlDbType.VarChar));
            comando.Parameters["@codigo_original"].Value = "%" + p_codigoOriginal + "%";

            comando.Connection.Open();

            SqlDataReader drArticulos = comando.ExecuteReader();

            List<ModeloArticulos> listaArticulos = new List<ModeloArticulos>();
            ModeloArticulos modArt = new ModeloArticulos();

            while (drArticulos.Read())
            {
                modArt = this.leerDatosArticulo(drArticulos);
                listaArticulos.Add(modArt);
            }

            drArticulos.Close();
            comando.Connection.Close();

            return listaArticulos;
        }
       
        private List<ModeloArticulos> buscarPorDescripcion(string p_descripcion)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText = 
                "SELECT [codigo_original],[descripcion],[modelos],[observaciones] FROM [articulos] "+
                "WHERE descripcion LIKE @descripcion";

            comando.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));
            comando.Parameters["@descripcion"].Value = "%" + p_descripcion + "%";

            comando.Connection.Open();

            SqlDataReader drArticulos = comando.ExecuteReader();

            List<ModeloArticulos> listaArticulos = new List<ModeloArticulos>();
            ModeloArticulos modArt = new ModeloArticulos();

            while (drArticulos.Read())
            {
                modArt = this.leerDatosArticulo(drArticulos);
                listaArticulos.Add(modArt);
            }

            drArticulos.Close();
            comando.Connection.Close();

            return listaArticulos;
        }

        public ModeloArticulos getOne(string p_codigoOriginal)
        {
            ModeloArticulos lcl_mod_articulo = null;
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText = 
                "SELECT [codigo_original],[descripcion],[modelos],[observaciones] FROM [articulos] "+
                "WHERE codigo_original = @codigo_original";

            comando.Parameters.Add(instanciarParametro(p_codigoOriginal, "@codigo_original"));   
            comando.Connection.Open();

            SqlDataReader drArticulos = comando.ExecuteReader();

            while (drArticulos.Read())
            {
                lcl_mod_articulo = new ModeloArticulos();
                lcl_mod_articulo = this.leerDatosArticulo(drArticulos);
            }
            drArticulos.Close();
            comando.Connection.Close();

            return lcl_mod_articulo;
        }

        public List<ModeloArticulos> getAll()
        {
            List<ModeloArticulos> lcl_lst_mod_articulos = new List<ModeloArticulos>();
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = 
                "SELECT [codigo_original],[descripcion],[modelos],[observaciones] FROM [articulos]";

            comando.Connection.Open();

            SqlDataReader drArticulos = comando.ExecuteReader();
            while (drArticulos.Read())
            {
                ModeloArticulos modArt = new ModeloArticulos();
                modArt = this.leerDatosArticulo(drArticulos);
                lcl_lst_mod_articulos.Add(modArt);
            }
            drArticulos.Close();

            comando.Connection.Close();

            return lcl_lst_mod_articulos;
        }

        #region Alta/Baja/Modificación
        /*
         * True si se realizó correctamente
         * False si ocurrió algún error
         */
        public bool agregarNuevaEntidad(ModeloArticulos p_mod_articulo)
        {
            if (!this.existeEntidad(p_mod_articulo.codigoOriginal))
            {
                SqlConnection ConexionSQL = Conexion.crearConexion();
                SqlCommand comando = new SqlCommand();

                comando.Connection = ConexionSQL;

                comando.CommandType = CommandType.Text;

                comando.CommandText = 
                    "INSERT INTO [articulos]([codigo_original],[descripcion],[modelos],[observaciones]) "+
                    "VALUES (@codigo_original, @descripcion, @modelos, @observaciones)";
                //Indica los parametros
                comando.Parameters.Add(this.instanciarParametro(p_mod_articulo.codigoOriginal, "@codigo_original"));
                comando.Parameters.Add(this.instanciarParametro(p_mod_articulo.descripcion, "@descripcion"));
                comando.Parameters.Add(this.instanciarParametro(p_mod_articulo.modelos, "@modelos"));
                comando.Parameters.Add(this.instanciarParametro(p_mod_articulo.observaciones, "@observaciones"));
                
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
            else
            {
                return false;
            }
        }

        public bool actualizarEntidad(ModeloArticulos p_mod_articulo)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = 
                "UPDATE [articulos] SET [descripcion]=@descripcion,[modelos]=@modelos,[observaciones]=@observaciones "+
                "WHERE [articulos].codigo_original=@codigo_original";

            comando.Parameters.Add(this.instanciarParametro(p_mod_articulo.codigoOriginal, "@codigo_original"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articulo.descripcion, "@descripcion"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articulo.modelos, "@modelos"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articulo.observaciones, "@observaciones"));
            
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

        public bool bajaEntidad(ModeloArticulos p_mod_articulo)
        {
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = 
                "DELETE FROM [articulos] WHERE [articulos].codigo_original=@codigo_original";

            comando.Parameters.Add(this.instanciarParametro(p_mod_articulo.codigoOriginal, "@codigo_original"));

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
        #endregion
    }
       
}

