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
        
        #region Búsqueda
        public ModeloArticulos leerDatosArticulo(SqlDataReader p_drArticulos)
        {
            ModeloArticulos lcl_mod_articulo = new ModeloArticulos();

            lcl_mod_articulo.codigoOriginal = (string)p_drArticulos["codigo_original"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            lcl_mod_articulo.descripcion = (p_drArticulos["descripcion"] != DBNull.Value) ? (string)p_drArticulos["descripcion"] : null;
            lcl_mod_articulo.modelos= (p_drArticulos["modelos"] != DBNull.Value) ? (string)p_drArticulos["modelos"] : null;
            lcl_mod_articulo.observaciones = (p_drArticulos["observaciones"] != DBNull.Value) ? (string)p_drArticulos["observaciones"] : null;
            lcl_mod_articulo.imagen = (p_drArticulos["imagen"] != DBNull.Value) ? (string)p_drArticulos["imagen"] : null;

            return lcl_mod_articulo;
        }
        
        /// <summary>
        /// Genera string a insertar en clausula WHERE de sql de acuerdo a los parámetros de búsqueda
        /// </summary>
        /// <param name="p_mod_articulo">modeloArticulo con variables posiblemente inicializadas</param>
        /// <param name="p_parametroBusqueda">constante encontrada en LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Articulos</param>
        /// <param name="p_comando">comando sql que será modificado para incluir parámetros</param>
        /// <returns></returns>
        private string getCondicionBusqueda(ModeloArticulos p_mod_articulo, string p_parametroBusqueda, ref SqlCommand p_comando)
        {
            switch (p_parametroBusqueda)
            {
                case Constantes.ParametrosBusqueda.One:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_articulo.codigoOriginal, "@codigo_original"));
                    return " codigo_original = @codigo_original ";
                case Constantes.ParametrosBusqueda.Articulos.CodigoOriginal:
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(p_mod_articulo.codigoOriginal), "@codigo_original"));
                    return " codigo_original LIKE @codigo_original ";

                case Constantes.ParametrosBusqueda.Articulos.Descripcion:
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(p_mod_articulo.descripcion), "@descripcion"));
                    return " descripcion LIKE @descripcion ";
                case Constantes.ParametrosBusqueda.Any:
                    
                    string codigoOriginal = p_mod_articulo.codigoOriginal == "" ? null : p_mod_articulo.codigoOriginal;
                    p_comando.Parameters.Add(this.instanciarParametro(codigoOriginal, "@codigo_original"));
                    string codigoOriginalQuery = this.parametroBusqueda("@codigo_original", "codigo_original", "=");

                    string descripcion = p_mod_articulo.descripcion == "" ? null : p_mod_articulo.descripcion;
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(descripcion), "@descripcion"));
                    string descripcionQuery = this.parametroBusqueda("@descripcion", "descripcion", "LIKE");

                    return codigoOriginalQuery + " AND " + descripcionQuery;
                default:
                    return base.getCondicionBusqueda(p_parametroBusqueda);
            }
        }

        public List<ModeloArticulos> buscar(ModeloArticulos p_mod_articulo, string p_parametroBusqueda)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;

            string querySQL = this.getCondicionBusqueda(p_mod_articulo,p_parametroBusqueda,ref comando);

            comando.CommandText =
                "SELECT [codigo_original],[descripcion],[modelos],[observaciones],[imagen] "+
                "   FROM [articulos] " +
                "   WHERE " + querySQL;

            comando.Connection.Open();

            SqlDataReader drArticulos = comando.ExecuteReader();

            List<ModeloArticulos> lcl_lst_mod_articulo = new List<ModeloArticulos>();
            ModeloArticulos lcl_mod_articulo = new ModeloArticulos();

            while (drArticulos.Read())
            {
                lcl_mod_articulo = new ModeloArticulos();
                lcl_mod_articulo = this.leerDatosArticulo(drArticulos);

                lcl_lst_mod_articulo.Add(lcl_mod_articulo);
            }
            drArticulos.Close();
            comando.Connection.Close();

            return lcl_lst_mod_articulo;
        }

        public ModeloArticulos getOne(string p_codigoOriginal)
        {
            ModeloArticulos lcl_mod_articulo = new ModeloArticulos();
            List<ModeloArticulos> lcl_lst_mod_articulos = new List<ModeloArticulos>();
            lcl_mod_articulo.codigoOriginal = p_codigoOriginal;
            lcl_lst_mod_articulos = this.buscar(lcl_mod_articulo, Constantes.ParametrosBusqueda.One);

            if (lcl_lst_mod_articulos.Count > 0)
            {
                return lcl_lst_mod_articulos[0];
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region Alta/Baja/Modificación
        public bool add(ModeloArticulos p_mod_articulo)
        {
            if (this.existeEntidad(p_mod_articulo.codigoOriginal))
            { throw new Exception("El Artículo ya existe."); }

            SqlConnection ConexionSQL = Conexion.crearConexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "INSERT INTO [articulos]([codigo_original],[descripcion],[modelos],[observaciones],[imagen]) " +
                "   VALUES (@codigo_original, @descripcion, @modelos, @observaciones, @imagen)";
                
            comando.Parameters.Add(this.instanciarParametro(p_mod_articulo.codigoOriginal, "@codigo_original"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articulo.descripcion, "@descripcion"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articulo.modelos, "@modelos"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articulo.observaciones, "@observaciones"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articulo.imagen, "@imagen"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            { return true; }
            else
            { throw new Exception("Ha ocurrido un error en la base de datos. No se ha podido registrar Artículo."); }
        }

        public bool update(ModeloArticulos p_mod_articulo)
        {
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText = 
                "UPDATE [articulos] SET [descripcion]=@descripcion,[modelos]=@modelos,[observaciones]=@observaciones, "+
                " [imagen]=@imagen   WHERE [articulos].codigo_original=@codigo_original";

            comando.Parameters.Add(this.instanciarParametro(p_mod_articulo.codigoOriginal, "@codigo_original"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articulo.descripcion, "@descripcion"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articulo.modelos, "@modelos"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articulo.observaciones, "@observaciones"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articulo.imagen, "@imagen"));
            
            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            { return true; }
            else
            { return false; }

        }

        public bool remove(ModeloArticulos p_mod_articulo)
        {
            SqlConnection ConexionSQL = Conexion.crearConexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText = 
                "DELETE FROM [articulos] "+
                "   WHERE [articulos].codigo_original=@codigo_original ";

            comando.Parameters.Add(this.instanciarParametro(p_mod_articulo.codigoOriginal, "@codigo_original"));

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

