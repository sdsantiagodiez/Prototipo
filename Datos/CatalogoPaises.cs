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
    }
}
