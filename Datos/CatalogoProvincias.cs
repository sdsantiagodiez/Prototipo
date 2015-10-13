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
    }
}
