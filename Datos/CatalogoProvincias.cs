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
    public class CatalogoProvincias : Catalogo
    {
        private ModeloProvincia leerDatosProvincia(SqlDataReader drProvincia)
        {
            ModeloProvincia modProv = new ModeloProvincia();

            modProv.codigo = (string)drProvincia["codigo_provincia"];
            modProv.provincia = (string)drProvincia["provincia"];
            modProv.codigoPais = (string)drProvincia["codigo_pais"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            
            return modProv;
        }

        public string getCodigoProvinciaPorNombre(string nombreProvincia)
        {
            string codigoProvincia = "";
            
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT [codigo_provincia] " +
                    "FROM [provincias]  " +
                    "WHERE [provincias].provincia = @nombreProvincia";
            comando.Parameters.Add(new SqlParameter("@nombreProvincia", SqlDbType.VarChar));
            comando.Parameters["@nombreProvincia"].Value = nombreProvincia.ToLower();
            comando.Connection.Open();

            SqlDataReader drEntidades = comando.ExecuteReader();

            while (drEntidades.Read())
            {
                codigoProvincia = (drEntidades["codigo_provincia"] != DBNull.Value) ? (string)drEntidades["codigo_provincia"] : null;
            }
            drEntidades.Close();
            comando.Connection.Close();

            return codigoProvincia;
        }

        public List<ModeloProvincia> getAll()
        {
            List<ModeloProvincia> lmProvincias = new List<ModeloProvincia>();
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT [provincias].codigo_provincia, [provincias].provincia, [provincias].codigo_pais " +
                    "FROM [provincias]  ";
            
            comando.Connection.Open();

            SqlDataReader drProvincias = comando.ExecuteReader();
            ModeloProvincia mProvincia = new ModeloProvincia();
            while (drProvincias.Read())
            {
                mProvincia = new ModeloProvincia();
                mProvincia = this.leerDatosProvincia(drProvincias);
                
                lmProvincias.Add(mProvincia);
            }
            drProvincias.Close();
            comando.Connection.Close();

            return lmProvincias;
        }

        public ModeloProvincia getOne(String pCodigo)
        {
            ModeloProvincia modPro = null;
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT [provincias].codigo_provincia, [provincias].provincia, [provincias].codigo_pais " +
                "FROM [provincias] WHERE codigo = @codigo";

            comando.Parameters.Add(instanciarParametro(pCodigo, "@codigo"));
            comando.Connection.Open();

            SqlDataReader drProvincias = comando.ExecuteReader();

            while (drProvincias.Read())
            {
                modPro = new ModeloProvincia();
                modPro = this.leerDatosProvincia(drProvincias);
            }
            drProvincias.Close();
            comando.Connection.Close();

            return modPro;
        }

    }
}
