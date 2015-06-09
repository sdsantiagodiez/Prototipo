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
    public class CatalogoPedidos
    {
        public int ultimoNroPedido()
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "SELECT MAX(nroPedido) FROM [pedidos]";

            comando.Connection.Open();

            int ultimopedido = (int)comando.ExecuteScalar();
            
            comando.Connection.Close();
            return ultimopedido;
        }



    }
}
