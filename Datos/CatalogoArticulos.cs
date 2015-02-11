using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class CatalogoArticulos
    {
        public bool validarDatos(string[] pDatos)
        {
            // Validar si los datos son correctos?
            return true;
        }

        public bool existeEntidad(string[] pDatos)
        {
            // Se crea la variable a retornar
            bool respuesta = false;
            //Creamos la lista de todos los Articulos
            List<ModeloArticulos> listArt = this.getAll();
            
            foreach (ModeloArticulos modArt in listArt)
            {
                if (pDatos[1] == modArt.codigoOriginalArt)// Se busca si el articulo ya existe comparando el codigo original
                {
                    respuesta = true;
                    break;
                }
                else { respuesta = false; }

            }

            return respuesta;
        }

        /// <summary>
        /// Busca por codigoOriginal o descripción y devuelve lista de artículos
        /// </summary>
        /// <param name="parametro">códigoOriginal o descripción de artículo</param>
        /// <returns>lista=0 si no encuentra, =1 si parametro es codigoOriginal y >=1 si es descripcion</returns>
        public List<ModeloArticulos> buscarArticulo(string parametro)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "SELECT [codigoOriginalArt],[descripArt],[modelosArt],[obsArt] FROM [proyecto].[dbo].[articulos] WHERE codigoOriginalArt = @Parametro";

            comando.Parameters.Add(new SqlParameter("@Parametro", SqlDbType.NVarChar));

            comando.Parameters["@paramtro"].Value = parametro;

            comando.Connection.Open();

            SqlDataReader drArticulos = comando.ExecuteReader();

            List<ModeloArticulos> listaArticulos = new List<ModeloArticulos>();
            ModeloArticulos modArt = new ModeloArticulos();

            if (!drArticulos.HasRows)
            {
                comando.CommandText = "SELECT [codigoOriginalArt],[descripArt],[modelosArt],[obsArt] FROM [proyecto].[dbo].[articulos] WHERE descipArt LIKE @Parametro";
                drArticulos = comando.ExecuteReader();
            }
            if (drArticulos.HasRows)
            {
                while (drArticulos.Read())
                {
                    modArt.codigoOriginalArt = (string)drArticulos["codigoOriginalArt"];
                    modArt.descripArt = (string)drArticulos["descripArt"];
                    modArt.modelosArt = (string)drArticulos["modelosArt"];
                    modArt.obsArt = (string)drArticulos["obsArt"];
                    listaArticulos.Add(modArt);
                }
            }

            drArticulos.Close();
            comando.Connection.Close();

            return listaArticulos;
        }

        public List<ModeloArticulos> getAll()
        { 
            List<ModeloArticulos>allArts = new List<ModeloArticulos>();
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            
            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType= CommandType.Text;

            comando.CommandText = "SELECT [codigoOriginalArt],[descripArt],[modelosArt],[obsArt] FROM [proyecto].[dbo].[articulos]";

            comando.Connection.Open();

            SqlDataReader drArticulos = comando.ExecuteReader();
            while (drArticulos.Read())
            {
                ModeloArticulos modArt = new ModeloArticulos();
                modArt.codigoOriginalArt = (string)drArticulos["codigoOriginalArt"];
                modArt.descripArt = (string)drArticulos["descripArt"];
                modArt.modelosArt = (string)drArticulos["modelosArt"];
                modArt.obsArt = (string)drArticulos["obsArt"];
                allArts.Add(modArt);
            }
            drArticulos.Close();

            comando.Connection.Close();

            return allArts;
        }

        public ModeloArticulos getOne(string pCodigoOriginal)
        {

            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "SELECT [codigoOriginalArt],[descripArt],[modelosArt],[obsArt] FROM [proyecto].[dbo].[articulos] WHERE codigoOriginalArt = @CodigoOriginal";

            comando.Parameters.Add(new SqlParameter("@CodigoArt", SqlDbType.NVarChar));

            comando.Parameters["@CodigoOriginal"].Value = pCodigoOriginal;

            comando.Connection.Open();

            SqlDataReader drArticulos = comando.ExecuteReader();

            ModeloArticulos modArt = new ModeloArticulos();

            while (drArticulos.Read())
            {
                modArt.codigoOriginalArt = (string)drArticulos["codigoOriginalArt"];
                modArt.descripArt = (string)drArticulos["descripArt"];
                modArt.modelosArt = (string)drArticulos["modelosArt"];
                modArt.obsArt = (string)drArticulos["obsArt"];
            }

            drArticulos.Close();
            comando.Connection.Close();

            return modArt;
        }

        public void agregarNuevaEntidad(ModeloArticulos pModArt)
        { 
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            
            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType= CommandType.Text;

            comando.CommandText = "INSERT INTO [proyecto].[dbo].[articulos]([descripArt],[modelosArt],[obsArt])VALUES (@descripArt, @modelosArt, @obsArt)";
            //Indica los parametros
            comando.Parameters.Add(new SqlParameter("@descripArt", SqlDbType.NVarChar));
            comando.Parameters["@descripArt"].Value = pModArt.descripArt;
            comando.Parameters.Add(new SqlParameter("@modelosArt", SqlDbType.NVarChar));
            comando.Parameters["@modelosArt"].Value = pModArt.modelosArt;
            comando.Parameters.Add(new SqlParameter("@obsArt", SqlDbType.NVarChar));
            comando.Parameters["@obsArt"].Value = pModArt.obsArt;

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        //Insertar un nuevo Articulo
        }     

        public string actualizarArticulo(ModeloArticulos modArt, string[] pModificar)//el parametro pModificar solo contiene el codigoOriginalArt si es que es cambiado.
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "UPDATE [proyecto].[dbo].[articulos] SET [codigoOriginalArt]=@codigoOriginalArtNew, [descripArt]=@descripArt,[modelosArt]=@modelosArt,[obsArt]=@obsArt WHERE [articulos].codigoOriginalArt=@codigoOriginalArtAnt";

            comando.Parameters.Add(new SqlParameter("@codigoOriginalAnt", SqlDbType.NVarChar));
            comando.Parameters["@codigoOriginalAnt"].Value = modArt.codigoOriginalArt;

            comando.Parameters.Add(new SqlParameter("@codigoOriginalNew", SqlDbType.NVarChar));
            comando.Parameters["@codigoOriginalAnt"].Value = pModificar[0];

            comando.Parameters.Add(new SqlParameter("@descripArt", SqlDbType.NVarChar));
            comando.Parameters["@descripArt"].Value = modArt.descripArt;

            comando.Parameters.Add(new SqlParameter("@modelosArt", SqlDbType.NVarChar));
            comando.Parameters["@modelosArt"].Value = modArt.modelosArt;

            comando.Parameters.Add(new SqlParameter("@obsArt", SqlDbType.NVarChar));
            comando.Parameters["@obsArt"].Value = modArt.obsArt;

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected == 0)
            {
                return "Error en actualizar";
            }
            else
            {
                return "Actualizacion finalizada";
            }


        }

        public string bajaArticulo(string pCodigoOriginal)
        {
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "DELETE FROM [proyecto].[dbo].[articulos] WHERE [articulos].codigoOriginalArt=@codigoOriginalArt";

            comando.Parameters.Add(new SqlParameter("@codigoOriginalArt", SqlDbType.NVarChar));
            comando.Parameters["@codigoOriginalArt"].Value = pCodigoOriginal;

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected == 0)
            {
                return "Operacion Cancelada";
            }
            else
            {
                return "Articulo dado de baja";
            }


        }
        
        
        

    }
       
}

