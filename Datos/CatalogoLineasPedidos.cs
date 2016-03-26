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
    public class CatalogoLineasPedidos : Catalogo
    {
        private ModeloLineaPedido leerDatosLineaPedido(SqlDataReader p_drLineasPedidos)
        {
            ModeloLineaPedido lcl_mod_lineaPedido = new ModeloLineaPedido();
            lcl_mod_lineaPedido.numeroPedido = (int)p_drLineasPedidos["numero_pedido"];
            
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            lcl_mod_lineaPedido.codigoOriginalArt= (string)p_drLineasPedidos["codigo_original"];
            lcl_mod_lineaPedido.codigoArtProveedor = (string)p_drLineasPedidos["codigo_articulo_proveedor"];

            lcl_mod_lineaPedido.cantidadArticulos = (int)p_drLineasPedidos["cantidad"];
            lcl_mod_lineaPedido.valorParcial = (decimal)p_drLineasPedidos["valor_parcial"];
            lcl_mod_lineaPedido.valorUnitario = (decimal)p_drLineasPedidos["valor_unitario"];

            lcl_mod_lineaPedido.descripcion = (p_drLineasPedidos["descripcion"] != DBNull.Value) ? (string)p_drLineasPedidos["descripcion"] : null;
                
            return lcl_mod_lineaPedido;
        }

        public bool validarDatos(ModeloLineaPedido p_mod_lineaPedido)
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
        /// <param name="p_mod_lineaPedido">ModeloLineaPedido con variables posiblemente inicializadas</param>
        /// <param name="p_parametroBusqueda">constante encontrada en LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Pedidos</param>
        /// <param name="p_comando">comando sql que será modificado para incluir parámetros</param>
        /// <returns></returns>
        private string getCondicionBusqueda(ModeloLineaPedido p_mod_lineaPedido, string p_parametroBusqueda, ref SqlCommand p_comando)
        {
            switch (p_parametroBusqueda)
            {
                case Constantes.ParametrosBusqueda.LineasPedidos.NumeroPedido:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.numeroPedido, "@numero_pedido"));
                    return " numero_pedido = @numero_pedido ";
                case Constantes.ParametrosBusqueda.LineasPedidos.CodigoArticuloProveedor:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.codigoArtProveedor, "@codigo_articulo_proveedor"));
                    return " codigo_articulo_proveedor = @codigo_articulo_proveedor ";
                case Constantes.ParametrosBusqueda.LineasPedidos.CodigoOriginal:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.codigoOriginalArt, "@codigo_original"));
                    return " codigo_original = @codigo_original ";
                case Constantes.ParametrosBusqueda.LineasPedidos.Descripcion:
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(p_mod_lineaPedido.descripcion), "@descripcion"));
                    return " descripcion LIKE @descripcion ";
                case Constantes.ParametrosBusqueda.Any:
                    
                    int? numeroPedido = p_mod_lineaPedido.numeroPedido == 0 ? null : (int?)p_mod_lineaPedido.numeroPedido;
                    p_comando.Parameters.Add(this.instanciarParametro(numeroPedido, "@numero_pedido"));
                    string numeroPedidoQuery = this.parametroBusqueda("@numero_pedido", "numero_pedido", "=");

                    string codigoOriginal = p_mod_lineaPedido.codigoOriginalArt == "" ? null : p_mod_lineaPedido.codigoOriginalArt;
                    p_comando.Parameters.Add(this.instanciarParametro(codigoOriginal, "@codigo_original"));
                    string codigoOriginalQuery = this.parametroBusqueda("@codigo_original", "codigo_original", "=");

                    string codigoArticuloProveedor = p_mod_lineaPedido.codigoArtProveedor == "" ? null : p_mod_lineaPedido.codigoArtProveedor;
                    p_comando.Parameters.Add(this.instanciarParametro(codigoArticuloProveedor, "@codigo_articulo_proveedor"));
                    string codigoArticuloProveedorQuery = this.parametroBusqueda("@codigo_articulo_proveedor", "codigo_articulo_proveedor", "=");

                    string descripcion = p_mod_lineaPedido.descripcion == "" ? null : p_mod_lineaPedido.descripcion;
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(descripcion), "@descripcion"));
                    string descripcionQuery = this.parametroBusqueda("@descripcion", "descripcion", "LIKE");

                    return numeroPedidoQuery + " AND " + codigoOriginalQuery + " AND " + codigoArticuloProveedorQuery + " AND " + descripcionQuery;
                default:
                    return base.getCondicionBusqueda(p_parametroBusqueda);
            }
        }

        /// <summary>
        /// Busca líneas de pedidos en base al parámetro ingresado
        /// </summary>
        /// <param name="p_mod_lineaPedido">modeloLineaPedido con variables posiblemente inicializadas</param>
        /// <param name="p_parametroBusqueda">string contenida en LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.LineasPedidos</param>
        /// <returns></returns>
        public List<ModeloLineaPedido> buscarLineasPedido(ModeloLineaPedido p_mod_lineaPedido, string p_parametroBusqueda)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;

            string querySQL = this.getCondicionBusqueda(p_mod_lineaPedido, p_parametroBusqueda, ref comando);

            comando.CommandText =
                "SELECT [numero_pedido],[codigo_articulo_proveedor],[codigo_original],[descripcion],[cantidad],[valor_unitario],[valor_parcial] " +
                "   FROM [lineas_pedidos] " +
                "   WHERE " + querySQL;

            comando.Connection.Open();

            SqlDataReader drLineasPedidos = comando.ExecuteReader();

            List<ModeloLineaPedido> lcl_lst_mod_lineasPedido = new List<ModeloLineaPedido>();
            ModeloLineaPedido lcl_mod_lineaPedido = new ModeloLineaPedido();

            while (drLineasPedidos.Read())
            {
                lcl_mod_lineaPedido = new ModeloLineaPedido();
                lcl_mod_lineaPedido = this.leerDatosLineaPedido(drLineasPedidos);

                lcl_lst_mod_lineasPedido.Add(lcl_mod_lineaPedido);
            }
            drLineasPedidos.Close();
            comando.Connection.Close();

            return lcl_lst_mod_lineasPedido;
        }

        public ModeloLineaPedido getOne(int p_numeroPedido)
        {
            ModeloLineaPedido lcl_mod_lineaPedido = new ModeloLineaPedido();
            List<ModeloLineaPedido> lcl_lst_mod_lineasPedidos = new List<ModeloLineaPedido>();
            lcl_mod_lineaPedido.numeroPedido = p_numeroPedido;
            lcl_lst_mod_lineasPedidos = this.buscarLineasPedido(lcl_mod_lineaPedido, Constantes.ParametrosBusqueda.Pedidos.NumeroPedido);

            if (lcl_lst_mod_lineasPedidos.Count > 0)
            {
                return lcl_lst_mod_lineasPedidos[0];
            }
            else
            {
                return null;
            }
        }

        public List<ModeloLineaPedido> getAll()
        {
            return this.buscarLineasPedido(null, Constantes.ParametrosBusqueda.All);
        }

        #region Alta/Baja/Modificación
        /*
         * True si se realizó correctamente
         * False si ocurrió algún error
         */
        public bool add(ModeloLineaPedido p_mod_lineaPedido)
        {
            SqlConnection ConexionSQL = Conexion.crearConexion();
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "INSERT INTO [lineas_pedidos]([numero_pedido],[codigo_original],[codigo_articulo_proveedor],[descripcion],[cantidad],"+
                "   [valor_parcial],[valor_unitario]) " +
                "VALUES (@numero_pedido, @codigo_original, @codigo_articulo_proveedor,@descripcion,@cantidad,@valor_parcial,@valor_unitario)";
            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.numeroPedido, "@numero_pedido"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.codigoOriginalArt, "@codigo_original"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.codigoArtProveedor, "@codigo_articulo_proveedor"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.descripcion, "@descripcion"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.cantidadArticulos, "@cantidad"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.valorParcial, "@valor_parcial"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.valorUnitario, "@valor_unitario"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //AL día 03/02/16 se considera no avanzar en estos métodos ya que no se le encuentra uso práctico
        //public bool update(ModeloLineaPedido p_mod_lineaPedido)
        //{
        //    //Creo la conexion y la abro
        //    SqlConnection ConexionSQL = Datos.Conexion.crearConexion();

        //    //crea SQL command
        //    SqlCommand comando = new SqlCommand();

        //    comando.Connection = ConexionSQL;

        //    comando.CommandType = CommandType.Text;

        //    comando.CommandText =
        //        "UPDATE [lineas_pedidos] SET [fecha]=@fecha,[monto_total]=@monto_total,[observaciones]=@observaciones, [codigo_tipo_pedido]=@codigo_tipo_pedido " +
        //        "WHERE [lineas_pedidos].numero_pedido=@numero_pedido";

        //    //Indica los parametros
        //    //HABRÍA QUE AGREGARLA AL MODELO
        //    comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.numeroPedido, "@numero_pedido"));
        //    comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.codigoOriginalArt, "@codigo_original"));
        //    comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.codigoArtProveedor, "@codigo_articulo_proveedor"));
        //    comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.cantidadArticulos, "@cantidad"));
        //    //FALTA AGREGAR DESCRIPCION a BASE DE DATOS y QUERY
        //    //comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.descripcion, "@descripcion"));
        //    comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.valorParcial, "@valor_parcial"));
        //    comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.valorUnitario, "@valor_unitario"));

        //    comando.Connection.Open();
        //    int rowaffected = comando.ExecuteNonQuery();
        //    comando.Connection.Close();

        //    if (rowaffected != 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}

        //public bool remove(ModeloLineaPedido p_mod_lineaPedido)
        //{
        //    SqlConnection ConexionSQL = Conexion.crearConexion();

        //    //crea SQL command
        //    SqlCommand comando = new SqlCommand();

        //    comando.Connection = ConexionSQL;

        //    comando.CommandType = CommandType.Text;

        //    comando.CommandText =
        //        "DELETE FROM [pedidos] " +
        //        "   WHERE [pedidos].numero_pedido=@numero_pedido";

        //    comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.numeroPedido, "@numero_pedido"));

        //    comando.Connection.Open();
        //    int rowaffected = comando.ExecuteNonQuery();
        //    comando.Connection.Close();

        //    if (rowaffected != 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        
        
        
        #endregion

    }
}
