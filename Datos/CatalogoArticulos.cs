using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    //buscarPorCodigoOriginal y getOne hacen lo mismo
    //revisar y modificar, si corresponde, existeEntidad y buscarArticulo
    public class CatalogoArticulos : Catalogo
    {
        public bool validarDatos(ModeloArticulos articulo)
        {
            // Validar si los datos son correctos
            return true;
        }

        /// <summary>
        /// Determina existencia de articulo de acuerdo a codigoOriginal ingresado
        /// </summary>
        /// <param name="codigoOriginal">código original de artículo</param>
        /// <returns>true si existe, false si no existe</returns>
        public bool existeEntidad(string codigoOriginal)
        {
            bool respuesta = false;
            if(getOne(codigoOriginal) != null)
            {
                respuesta = true;
            }
            return respuesta;
        }
        
        private ModeloArticulos leerDatosArticulo(SqlDataReader drArticulos)
        {
            ModeloArticulos modArt = new ModeloArticulos();

            modArt.codigoOriginal = (string)drArticulos["codigo_original"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            modArt.descripcion = (drArticulos["descripcion"] != DBNull.Value) ? (string)drArticulos["descripcion"] : null;
            modArt.modelos= (drArticulos["modelos"] != DBNull.Value) ? (string)drArticulos["modelos"] : null;
            modArt.observaciones = (drArticulos["observaciones"] != DBNull.Value) ? (string)drArticulos["observaciones"] : null;

            return modArt;
        }

        /// <summary>
        /// Busca por codigoOriginal o descripción y devuelve lista de artículos
        /// </summary>
        /// <param name="tipoParametro">"codigoOriginal" o "descripcion"</param>
        /// <param name="descripcionParametro">string por el que se buscará artículo</param>
        /// <returns></returns>
        public List<ModeloArticulos> buscarArticulo(string tipoParametro, string descripcionParametro)
        {
            List<ModeloArticulos> listaArticulos = new List<ModeloArticulos>();

            switch (tipoParametro.ToLower())
            {
                case "codigooriginal":
                    listaArticulos = buscarPorCodigoOriginal(descripcionParametro);
                    break;
                case "descripcion":
                    listaArticulos = buscarPorDescripcion(descripcionParametro);
                    break;
                default:
                    break;
            }
            return listaArticulos;
        }

        private List<ModeloArticulos> buscarPorCodigoOriginal(string codigoOriginal)
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
            comando.Parameters["@codigo_original"].Value = "%" + codigoOriginal + "%";

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
       
        private List<ModeloArticulos> buscarPorDescripcion(string descripcion)
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
            comando.Parameters["@descripcion"].Value = "%" + descripcion + "%";

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

        public ModeloArticulos getOne(string pCodigoOriginal)
        {
            ModeloArticulos modArt = null;
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText = 
                "SELECT [codigo_original],[descripcion],[modelos],[observaciones] FROM [articulos] "+
                "WHERE codigo_original = @codigo_original";

            comando.Parameters.Add(instanciarParametro(pCodigoOriginal, "@codigo_original"));   
            comando.Connection.Open();

            SqlDataReader drArticulos = comando.ExecuteReader();

            while (drArticulos.Read())
            {
                modArt = new ModeloArticulos();
                modArt = this.leerDatosArticulo(drArticulos);
            }
            drArticulos.Close();
            comando.Connection.Close();

            return modArt;
        }

        public List<ModeloArticulos> getAll()
        {
            List<ModeloArticulos> allArts = new List<ModeloArticulos>();
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
                allArts.Add(modArt);
            }
            drArticulos.Close();

            comando.Connection.Close();

            return allArts;
        }

        #region Alta/Baja/Modificación
        /*
         * True si se realizó correctamente
         * False si ocurrió algún error
         */
        public bool agregarNuevaEntidad(ModeloArticulos pModArt)
        {
            if (!this.existeEntidad(pModArt.codigoOriginal))
            {
                SqlConnection ConexionSQL = Conexion.crearConexion();
                SqlCommand comando = new SqlCommand();

                comando.Connection = ConexionSQL;

                comando.CommandType = CommandType.Text;

                comando.CommandText = 
                    "INSERT INTO [articulos]([codigo_original],[descripcion],[modelos],[observaciones]) "+
                    "VALUES (@codigo_original, @descripcion, @modelos, @observaciones)";
                //Indica los parametros
                comando.Parameters.Add(this.instanciarParametro(pModArt.codigoOriginal, "@codigo_original"));
                comando.Parameters.Add(this.instanciarParametro(pModArt.descripcion, "@descripcion"));
                comando.Parameters.Add(this.instanciarParametro(pModArt.modelos, "@modelos"));
                comando.Parameters.Add(this.instanciarParametro(pModArt.observaciones, "@observaciones"));
                
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

        public bool actualizarEntidad(ModeloArticulos pModArt)
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

            comando.Parameters.Add(this.instanciarParametro(pModArt.codigoOriginal, "@codigo_original"));
            comando.Parameters.Add(this.instanciarParametro(pModArt.descripcion, "@descripcion"));
            comando.Parameters.Add(this.instanciarParametro(pModArt.modelos, "@modelos"));
            comando.Parameters.Add(this.instanciarParametro(pModArt.observaciones, "@observaciones"));
            
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

        public bool bajaEntidad(ModeloArticulos pModArt)
        {
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = 
                "DELETE FROM [articulos] WHERE [articulos].codigo_original=@codigo_original";

            comando.Parameters.Add(this.instanciarParametro(pModArt.codigoOriginal, "@codigo_original"));

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

