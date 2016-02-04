using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data;
using System.Data.SqlClient;
using LibreriaClasesCompartidas;

namespace Datos
{
    public class CatalogoPedidos : Catalogo
    {
        /// <summary>
        /// NO USAR. Usar método buscarPedido(ModeloPedido,Constantes...TipoPedido) (BORRAR)
        /// </summary>
        /// <param name="tipoPedido"></param>
        /// <returns></returns>
        public List<ModeloPedido> getPedidos(string tipoPedido)
        {
            return null;
            //List<ModeloPedido> listPedidos = new List<ModeloPedido>();

            ////Creo la conexion y la abro
            //SqlConnection ConexionSQL = Conexion.crearConexion();

            ////crea SQL command
            //SqlCommand comando = new SqlCommand();

            //comando.Connection = ConexionSQL;

            //comando.CommandType = CommandType.Text;

            //comando.CommandText = "SELECT Pedidos.numero_pedido, Pedidos.fecha, Pedidos.monto_total, Pedidos.observaciones," +
            //    " Pedidos.codigo_tipo_pedido FROM Pedidos WHERE Pedidos.codigo_tipo_pedido =@tipoPedido ";
            //comando.Parameters.Add(new SqlParameter("@codigo", SqlDbType.VarChar));
            //comando.Parameters["@tipoPedido"].Value = tipoPedido;

            //comando.Connection.Open();

            //SqlDataReader drPedidos = comando.ExecuteReader();

            //while (drPedidos.Read())
            //{
            //    ModeloPedido modPedido = new ModeloPedido();
            //    modPedido = this.leerDatosPedidos(drPedidos);
            //    listPedidos.Add(modPedido);
            //}

            //drPedidos.Close();
            //comando.Connection.Close();
            //return listPedidos;
        }

        /// <summary>
        /// NO USAR Reemplazar por métodos válidos (BORRAR)
        /// </summary>
        /// <param name="codigoPedido"></param>
        /// <returns></returns>
        public ModeloProveedor getProveedorPedido(int codigoPedido)
        {
            return null;

            //ModeloProveedor modProv = new ModeloProveedor();
            //CatalogoProveedores catProv = new CatalogoProveedores();
            ////Creo la conexion y la abro
            //SqlConnection ConexionSQL = Conexion.crearConexion();

            ////crea SQL command
            //SqlCommand comando = new SqlCommand();

            //comando.Connection = ConexionSQL;

            //comando.CommandType = CommandType.Text;
            ///*VER consulta con parametro
            //comando.CommandText = "SELECT Proveedores.razon_social,Proveedores.codigo_entidad AS codigo, Entidades.cuit, Entidades.observaciones, Entidades.tipo_entidad " +
            //                      "FROM Pedidos INNER JOIN Pedidos_Proveedores ON Pedidos.numero_pedido=Pedidos_Proveedores.numero_pedido"+
            //                      "INNER JOIN Proveedores ON Pedidos_Proveedores.codigo_entidad = Proveedores.codigo_entidad INNER JOIN Entidades ON"+
            //                      "Entidades.codigo = Proveedores.codigo_entidad WHERE numero_pedido = @codigoPedido;
            //*/
            //comando.Parameters.Add(new SqlParameter("@codigoPedido", SqlDbType.Int));
            //comando.Parameters["@codigoPedido"].Value = codigoPedido;

            //comando.Connection.Open();

            //SqlDataReader drProveedor = comando.ExecuteReader();

            //while (drProveedor.Read())
            //{
            //    modProv = catProv.leerDatosProveedor(drProveedor);
            //}
            //return modProv;
        }





        private ModeloPedido leerDatosPedido(SqlDataReader p_drPedidos)
        {
            ModeloPedido lcl_mod_pedido = new ModeloPedido();

            lcl_mod_pedido.nroPedido = (int)p_drPedidos["numero_pedido"];
            lcl_mod_pedido.fecha = (DateTime)p_drPedidos["fecha"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            
            lcl_mod_pedido.monto_total = (p_drPedidos["monto_total"] != DBNull.Value) ? (decimal)p_drPedidos["monto_total"] : 0;
            lcl_mod_pedido.observaciones = (p_drPedidos["observaciones"] != DBNull.Value) ? (string)p_drPedidos["observaciones"] : null;
            lcl_mod_pedido.codigo_tipo_pedido = (p_drPedidos["codigo_tipo_pedido"] != DBNull.Value) ? (int)p_drPedidos["codigo_tipo_pedido"] : 0;

            return lcl_mod_pedido;
        }

        public bool validarDatos(ModeloPedido p_mod_pedido)
        {
            // Validar si los datos son correctos
            return true;
        }

        /// <summary>
        /// Determina existencia de pedido de acuerdo a numeroPedido ingresado
        /// </summary>
        /// <param name="p_nroPedido">número de pedido del pedido</param>
        /// <returns>true si existe, false si no existe</returns>
        public bool existeEntidad(int p_nroPedido)
        {
            bool respuesta = false;
            if (getOne(p_nroPedido) != null)
            {
                respuesta = true;
            }
            return respuesta;
        }

        /// <summary>
        /// Genera string a insertar en clausula WHERE de sql de acuerdo a los parámetros de búsqueda
        /// </summary>
        /// <param name="p_mod_pedido">modeloPedido con variables posiblemente inicializadas</param>
        /// <param name="p_parametroBusqueda">constante encontrada en LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Pedidos</param>
        /// <param name="p_comando">comando sql que será modificado para incluir parámetros</param>
        /// <returns></returns>
        private string getCondicionBusqueda(ModeloPedido p_mod_pedido, string p_parametroBusqueda, ref SqlCommand p_comando)
        {
            switch (p_parametroBusqueda)
            {
                case Constantes.ParametrosBusqueda.Pedidos.NumeroPedido:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.nroPedido, "@numero_pedido"));
                    return " numero_pedido = @numero_pedido ";

                case Constantes.ParametrosBusqueda.Pedidos.Tipo:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.codigo_tipo_pedido, "@codigo_tipo_pedido"));
                    return " codigo_tipo_pedido = @codigo_tipo_pedido ";
                case Constantes.ParametrosBusqueda.Pedidos.Fecha:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.fecha, "@fecha"));
                    return " fecha = @fecha ";
                case Constantes.ParametrosBusqueda.Pedidos.Any:
                    int? numeroPedido = p_mod_pedido.nroPedido == 0 ? null : (int?)p_mod_pedido.nroPedido;
                    p_comando.Parameters.Add(this.instanciarParametro(numeroPedido, "@numero_pedido"));
                    string numeroPedidoQuery = this.parametroBusqueda("@numero_pedido", "numero_pedido", "=");

                    int? codigoTipoPedido = p_mod_pedido.codigo_tipo_pedido == 0 ? null : (int?)p_mod_pedido.codigo_tipo_pedido;
                    p_comando.Parameters.Add(this.instanciarParametro(codigoTipoPedido, "@codigo_tipo_pedido"));
                    string codigoTipoPedidoQuery = this.parametroBusqueda("@codigo_tipo_pedido", "codigo_tipo_pedido", "=");

                    DateTime? fecha = p_mod_pedido.fecha.Year == 1? null : (DateTime?)p_mod_pedido.fecha;
                    p_comando.Parameters.Add(this.instanciarParametro(fecha, "@fecha"));
                    string fechaQuery = this.parametroBusqueda("@fecha", "fecha", "=");

                    return numeroPedidoQuery + " AND " + codigoTipoPedidoQuery + " AND " + fechaQuery;
                case Constantes.ParametrosBusqueda.Pedidos.All:
                    //retorna true y devuelve todas las filas
                    return " 1 = 1 ";
                default:
                    //hace que sql no retorne filas
                    return " 1 = 2 ";
            }
        }

        public List<ModeloPedido> buscarPedido(ModeloPedido p_mod_pedido, string p_parametroBusqueda)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;

            string querySQL = this.getCondicionBusqueda(p_mod_pedido, p_parametroBusqueda, ref comando);

            comando.CommandText =
                "SELECT [numero_pedido],[fecha],[monto_total],[observaciones],[codigo_tipo_pedido] " +
                "   FROM [pedidos] " +
                "   WHERE " + querySQL;

            comando.Connection.Open();

            SqlDataReader drPedidos = comando.ExecuteReader();

            List<ModeloPedido> lcl_lst_mod_pedido = new List<ModeloPedido>();
            ModeloPedido lcl_mod_pedido = new ModeloPedido();

            CatalogoLineasPedidos lcl_cat_lineasPedidos = new CatalogoLineasPedidos();
            ModeloLineaPedido lcl_mod_lineaPedido = null;
            while (drPedidos.Read())
            {
                
                lcl_mod_pedido = new ModeloPedido();
                lcl_mod_pedido = this.leerDatosPedido(drPedidos);

                lcl_mod_lineaPedido = new ModeloLineaPedido();
                lcl_mod_lineaPedido.numeroPedido = lcl_mod_pedido.nroPedido;
                lcl_mod_pedido.lineasPedido = lcl_cat_lineasPedidos.buscarLineasPedido(lcl_mod_lineaPedido, Constantes.ParametrosBusqueda.LineasPedidos.NumeroPedido);

                lcl_lst_mod_pedido.Add(lcl_mod_pedido);
            }
            drPedidos.Close();
            comando.Connection.Close();

            return lcl_lst_mod_pedido;
        }

        public ModeloPedido getOne(int p_numeroPedido)
        {
            ModeloPedido lcl_mod_pedido = new ModeloPedido();
            List<ModeloPedido> lcl_lst_mod_pedidos = new List<ModeloPedido>();
            lcl_mod_pedido.nroPedido = p_numeroPedido;
            lcl_lst_mod_pedidos = this.buscarPedido(lcl_mod_pedido, Constantes.ParametrosBusqueda.Pedidos.NumeroPedido);

            if (lcl_lst_mod_pedidos.Count > 0)
            {
                return lcl_lst_mod_pedidos[0];
            }
            else
            {
                return null;
            }
        }

        public List<ModeloPedido> getAll()
        {
            return this.buscarPedido(null, Constantes.ParametrosBusqueda.Articulos.All);
        }

        #region Alta/Baja/Modificación
        /*
         * True si se realizó correctamente
         * False si ocurrió algún error
         */
        public bool add(ref ModeloPedido p_mod_pedido)
        {
            SqlConnection ConexionSQL = Conexion.crearConexion();
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "INSERT INTO [pedidos]([fecha],[monto_total],[observaciones],[codigo_tipo_pedido]) " +
                "OUTPUT INSERTED.NUMERO_PEDIDO " +
                "VALUES (@fecha, @monto_total, @observaciones,@codigo_tipo_pedido)";
            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.fecha, "@fecha"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.monto_total, "@monto_total"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.observaciones, "@observaciones"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.codigo_tipo_pedido, "@codigo_tipo_pedido"));

            comando.Connection.Open();
            int? nuevoNumeroPedido = (int?)comando.ExecuteScalar();
            comando.Connection.Close();

            if (nuevoNumeroPedido != null)
            {
                p_mod_pedido.nroPedido = Convert.ToInt32(nuevoNumeroPedido);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool update(ModeloPedido p_mod_pedido)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "UPDATE [pedidos] SET [fecha]=@fecha,[monto_total]=@monto_total,[observaciones]=@observaciones, [codigo_tipo_pedido]=@codigo_tipo_pedido " +
                "WHERE [pedidos].numero_pedido=@numero_pedido";

            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.fecha, "@fecha"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.monto_total, "@monto_total"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.observaciones, "@observaciones"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.codigo_tipo_pedido, "@codigo_tipo_pedido"));

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

        public bool remove(ModeloPedido p_mod_pedido)
        {
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "DELETE FROM [pedidos] "+
                "   WHERE [pedidos].numero_pedido=@numero_pedido";

            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.nroPedido, "@numero_pedido"));

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
