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

        public List<ModeloPedido> getPedidos(string tipoPedido)
        {
            List<ModeloPedido> listPedidos = new List<ModeloPedido>();

            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "SELECT Pedidos.numero_pedido, Pedidos.fecha, Pedidos.monto_total, Pedidos.observaciones,"+
                " Pedidos.codigo_tipo_pedido FROM Pedidos WHERE Pedidos.codigo_tipo_pedido =@tipoPedido ";
            comando.Parameters.Add(new SqlParameter("@codigo", SqlDbType.VarChar));
            comando.Parameters["@tipoPedido"].Value = tipoPedido;
            
            comando.Connection.Open();

            SqlDataReader drPedidos = comando.ExecuteReader();

            while (drPedidos.Read())
            {
                ModeloPedido modPedido = new ModeloPedido();
                modPedido = this.leerDatosPedidos(drPedidos);
                listPedidos.Add(modPedido);
            }
     
            drPedidos.Close();
            comando.Connection.Close();
            return listPedidos;
        }

        private ModeloPedido leerDatosPedidos(SqlDataReader drPedidos)
        {
            ModeloPedido modPed = new ModeloPedido();

            modPed.nroPedido = (int)drPedidos["numero_pedido"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            modPed.fecha = (drPedidos["fecha"] != DBNull.Value) ? (string)drPedidos["fecha"] : null;
            modPed.monto_total = (drPedidos["monto_total"] != DBNull.Value) ? (float)drPedidos["monto_total"] : 0;
            modPed.observaciones = (drPedidos["observaciones"] != DBNull.Value) ? (string)drPedidos["observaciones"] : null;
            modPed.codigo_tipo_pedido = (drPedidos["codigo_tipo_pedido"] != DBNull.Value) ? (int)drPedidos["codigo_tipo_pedido"] : 0;

            return modPed;
        }

    }
}
