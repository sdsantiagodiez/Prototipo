using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class CatalogoPaises : Catalogo
    {
        private ModeloPais leerDatosPais(SqlDataReader drPais)
        {
            ModeloPais modPais = new ModeloPais();

            modPais.codigo = (string)drPais["codigo"];
            modPais.pais = (string)drPais["pais"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string

            return modPais;
        }

        public bool existeEntidad(String pCodigo)
        {
            bool respuesta = false;
            if (getOne(pCodigo) != null)
            {
                respuesta = true;
            }
            return respuesta;
        }

        public List<ModeloPais> getAll()
        {
            List<ModeloPais> lmPaises = new List<ModeloPais>();
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT [paises].codigo,[paises].pais " +
                    "FROM [paises] ";

            comando.Connection.Open();
            ModeloPais modPais;
            SqlDataReader drPaises = comando.ExecuteReader();
            while (drPaises.Read())
            {
                modPais = new ModeloPais();
                modPais = this.leerDatosPais(drPaises);

                lmPaises.Add(modPais);
            }
            drPaises.Close();

            comando.Connection.Close();

            return lmPaises;
        }

        public ModeloPais getOne(String pCodigo)
        {
            ModeloPais modPai = null;
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT [codigo],[pais] FROM [pais] " +
                "WHERE codigo = @codigo";

            comando.Parameters.Add(instanciarParametro(pCodigo, "@codigo"));
            comando.Connection.Open();

            SqlDataReader drPaises = comando.ExecuteReader();

            while (drPaises.Read())
            {
                modPai = new ModeloPais();
                modPai = this.leerDatosPais(drPaises);
            }
            drPaises.Close();
            comando.Connection.Close();

            return modPai;
        }

        #region Alta/Baja/Modificación
        /*
         * True si se realizó correctamente
         * False si ocurrió algún error
         */
        public bool agregarNuevaEntidad(ModeloPais pModPai)
        {
            if (!this.existeEntidad(pModPai.codigo))
            {
                SqlConnection ConexionSQL = Conexion.crearConexion();
                SqlCommand comando = new SqlCommand();

                comando.Connection = ConexionSQL;

                comando.CommandType = CommandType.Text;

                comando.CommandText =
                    "INSERT INTO [pais]([codigo],[pais]) " +
                    "VALUES (@codigo, @pais)";
                //Indica los parametros
                comando.Parameters.Add(this.instanciarParametro(pModPai.codigo, "@codigo"));
                comando.Parameters.Add(this.instanciarParametro(pModPai.pais, "@pais"));
                
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

        public bool actualizarEntidad(ModeloPais pModPai)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "UPDATE [pais] SET [pais]=@pais" +
                "WHERE [pais].codigo=@codigo";

            comando.Parameters.Add(this.instanciarParametro(pModPai.codigo, "@codigo"));
            comando.Parameters.Add(this.instanciarParametro(pModPai.pais, "@pais"));
            
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

        public bool bajaEntidad(ModeloPais pModPai)
        {
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "DELETE FROM [pais] WHERE [pais].codigo=@codigo";

            comando.Parameters.Add(this.instanciarParametro(pModPai.codigo, "@codigo"));

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
