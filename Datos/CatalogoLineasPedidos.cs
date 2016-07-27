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
            lcl_mod_lineaPedido.articulo.codigoOriginal= (string)p_drLineasPedidos["codigo_original"];
            lcl_mod_lineaPedido.articulo.codigoArticuloProveedor= (string)p_drLineasPedidos["codigo_articulo_proveedor"];

            lcl_mod_lineaPedido.cantidadArticulos = (int)p_drLineasPedidos["cantidad"];
            lcl_mod_lineaPedido.valorUnitario = (decimal)p_drLineasPedidos["valor_unitario"];
            lcl_mod_lineaPedido.valorParcial = (decimal)p_drLineasPedidos["valor_parcial"];

            lcl_mod_lineaPedido.valorParcialSinDescuento = (p_drLineasPedidos["valor_parcial_sin_descuento"] != DBNull.Value) ? (decimal)p_drLineasPedidos["valor_parcial_sin_descuento"] : 0;
            lcl_mod_lineaPedido.descuentoTotalMonto = (p_drLineasPedidos["descuento_total_monto"] != DBNull.Value) ? (decimal)p_drLineasPedidos["descuento_total_monto"] : 0;
            lcl_mod_lineaPedido.descuentoTotalPorcentaje = (p_drLineasPedidos["descuento_total_porcentaje"] != DBNull.Value) ? (decimal)p_drLineasPedidos["descuento_total_porcentaje"] : 0;
            
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
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.articulo.codigoArticuloProveedor, "@codigo_articulo_proveedor"));
                    return " codigo_articulo_proveedor = @codigo_articulo_proveedor ";
                case Constantes.ParametrosBusqueda.LineasPedidos.CodigoOriginal:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.articulo.codigoOriginal, "@codigo_original"));
                    return " codigo_original = @codigo_original ";
                case Constantes.ParametrosBusqueda.LineasPedidos.Descripcion:
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(p_mod_lineaPedido.articulo.descripcionArticuloProveedor), "@descripcion"));
                    return " descripcion LIKE @descripcion ";
                case Constantes.ParametrosBusqueda.Any:
                    
                    int? numeroPedido = p_mod_lineaPedido.numeroPedido == 0 ? null : (int?)p_mod_lineaPedido.numeroPedido;
                    p_comando.Parameters.Add(this.instanciarParametro(numeroPedido, "@numero_pedido"));
                    string numeroPedidoQuery = this.parametroBusqueda("@numero_pedido", "numero_pedido", "=");

                    string codigoOriginal = String.IsNullOrWhiteSpace(p_mod_lineaPedido.articulo.codigoOriginal)? null : p_mod_lineaPedido.articulo.codigoOriginal;
                    p_comando.Parameters.Add(this.instanciarParametro(codigoOriginal, "@codigo_original"));
                    string codigoOriginalQuery = this.parametroBusqueda("@codigo_original", "codigo_original", "=");

                    string codigoArticuloProveedor = String.IsNullOrWhiteSpace(p_mod_lineaPedido.articulo.codigoArticuloProveedor) ? null : p_mod_lineaPedido.articulo.codigoArticuloProveedor;
                    p_comando.Parameters.Add(this.instanciarParametro(codigoArticuloProveedor, "@codigo_articulo_proveedor"));
                    string codigoArticuloProveedorQuery = this.parametroBusqueda("@codigo_articulo_proveedor", "codigo_articulo_proveedor", "=");

                    string descripcion = String.IsNullOrWhiteSpace(p_mod_lineaPedido.articulo.descripcionArticuloProveedor) ? null : p_mod_lineaPedido.articulo.descripcionArticuloProveedor;
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
                "SELECT [numero_pedido],[codigo_original],[codigo_articulo_proveedor],[cantidad],[valor_unitario],[valor_parcial],"+
                "   [valor_parcial_sin_descuento],[descuento_total_monto],[descuento_total_porcentaje] " +
                "   FROM [lineas_pedidos] " +
                "   WHERE " + querySQL;

            comando.Connection.Open();

            SqlDataReader drLineasPedidos = comando.ExecuteReader();

            List<ModeloLineaPedido> lcl_lst_mod_lineasPedido = new List<ModeloLineaPedido>();
            ModeloLineaPedido lcl_mod_lineaPedido = new ModeloLineaPedido();
            CatalogoArticuloProveedores lcl_cat_articulosProveedores = new CatalogoArticuloProveedores();
            CatalogoDescuentoLineasPedido lcl_cat_descuentoLP = new CatalogoDescuentoLineasPedido();
            while (drLineasPedidos.Read())
            {
                lcl_mod_lineaPedido = new ModeloLineaPedido();
                lcl_mod_lineaPedido = this.leerDatosLineaPedido(drLineasPedidos);
                lcl_mod_lineaPedido.articulo = lcl_cat_articulosProveedores.buscar(lcl_mod_lineaPedido.articulo, Constantes.ParametrosBusqueda.One)[0];
                
                lcl_cat_descuentoLP.getDescuentos(lcl_mod_lineaPedido);

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
                "INSERT INTO [lineas_pedidos]([numero_pedido],[codigo_original],[codigo_articulo_proveedor],[cantidad],"+
                "   [valor_unitario],[valor_parcial],[valor_parcial_sin_descuento],[descuento_total_monto],[descuento_total_porcentaje]) " +
                "VALUES (@numero_pedido, @codigo_original, @codigo_articulo_proveedor,@cantidad,@valor_unitario,@valor_parcial," +
                "   @valor_parcial_sin_descuento,@descuento_total_monto, @descuento_total_porcentaje)";
            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.numeroPedido, "@numero_pedido"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.articulo.codigoOriginal, "@codigo_original"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.articulo.codigoArticuloProveedor, "@codigo_articulo_proveedor"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.cantidadArticulos, "@cantidad"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.valorParcial, "@valor_parcial"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.valorUnitario, "@valor_unitario"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.valorParcialSinDescuento, "@valor_parcial_sin_descuento"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.descuentoTotalMonto, "@descuento_total_monto"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.descuentoTotalPorcentaje, "@descuento_total_porcentaje"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected > 0)
            {
                p_mod_lineaPedido.asignarDatosADescuentos();
                CatalogoDescuentoLineasPedido lcl_cat_descuentosLP = new CatalogoDescuentoLineasPedido();
                return lcl_cat_descuentosLP.add(p_mod_lineaPedido.descuentos);
            }
            else
            { return false; }
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

    public class CatalogoDescuentoLineasPedido : Catalogo
    {
        private ModeloDescuentoLineaPedido leerDatosDescuentoLineaPedido(SqlDataReader p_drDescuentoLP)
        {
            ModeloDescuentoLineaPedido lcl_mod_descuentoLP = new ModeloDescuentoLineaPedido();

            lcl_mod_descuentoLP.numeroPedido = (int)p_drDescuentoLP["numero_pedido"];
            lcl_mod_descuentoLP.codigoOriginalArticulo = (string)p_drDescuentoLP["codigo_original"];
            lcl_mod_descuentoLP.codigoArticuloProveedor = (string)p_drDescuentoLP["codigo_articulo_proveedor"];
            lcl_mod_descuentoLP.codigoDescuento = (int)p_drDescuentoLP["numero_descuento"];
            lcl_mod_descuentoLP.descripcion = (p_drDescuentoLP["descripcion_descuento"] != DBNull.Value) ? (string)p_drDescuentoLP["descripcion_descuento"] : null;
            lcl_mod_descuentoLP.porcentaje = (decimal)p_drDescuentoLP["porcentaje_descuento"];
            lcl_mod_descuentoLP.montoDescontadoSobreTotal = (decimal)p_drDescuentoLP["monto_a_descontar"];
            return lcl_mod_descuentoLP;
        }
        public void getDescuentos(ModeloLineaPedido p_mod_lineaPedido)
        {
            string query =
                        "SELECT " +
                        "   numero_pedido, codigo_original, codigo_articulo_proveedor, numero_descuento, descripcion_descuento, " +
                        "   porcentaje_descuento, monto_a_descontar"+
                        "   FROM [descuentos_lineas_pedido] " +
                        "   WHERE (codigo_original = @codigo_original AND codigo_articulo_proveedor = @codigo_articulo_proveedor "+
                        "       AND numero_pedido = @numero_pedido)";

            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());

            comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.numeroPedido, "@numero_pedido"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.articulo.codigoOriginal, "@codigo_original"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_lineaPedido.articulo.codigoArticuloProveedor, "@codigo_articulo_proveedor"));

            comando.Connection.Open();
            SqlDataReader drDescuentoLineaPedido = comando.ExecuteReader();
            ModeloDescuentoLineaPedido lcl_mod_descuentoLP;

            while (drDescuentoLineaPedido.Read())
            {
                lcl_mod_descuentoLP = new ModeloDescuentoLineaPedido();
                lcl_mod_descuentoLP = this.leerDatosDescuentoLineaPedido(drDescuentoLineaPedido);
                p_mod_lineaPedido.addDescuento(lcl_mod_descuentoLP);
            }
            drDescuentoLineaPedido.Close();
            comando.Connection.Close();
        }

        public bool add(List<ModeloDescuentoLineaPedido> p_lst_mod_descuentoLP)
        {
            foreach (ModeloDescuentoLineaPedido d_ap in p_lst_mod_descuentoLP)
            {
                if (!this.add(d_ap))
                {
                    return false;
                }
            }
            return true;
        }
        public bool add(ModeloDescuentoLineaPedido p_mod_descuentoLP)
        {
            //Si descuento no existe (codigo 0) se lo agrega
            if (p_mod_descuentoLP.codigoDescuento == 0 )
            {
                //No se pudo agregar descuento
                return false;
            }

            string query =
                "INSERT INTO [descuentos_lineas_pedido] ([numero_pedido], [codigo_original],[codigo_articulo_proveedor], [numero_descuento], " +
                "   [descripcion_descuento], [porcentaje_descuento], [monto_a_descontar]) " +
                "    VALUES (@numero_pedido,  @codigo_original, @codigo_articulo_proveedor, @numero_descuento, " +
                "   @descripcion_descuento, @porcentaje_descuento, @monto_a_descontar)";

            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());

            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuentoLP.codigoDescuento, "@numero_descuento"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuentoLP.numeroPedido, "@numero_pedido"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuentoLP.codigoOriginalArticulo, "@codigo_original"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuentoLP.codigoArticuloProveedor, "@codigo_articulo_Proveedor"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuentoLP.descripcion, "@descripcion_descuento"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuentoLP.porcentaje, "@porcentaje_descuento"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuentoLP.montoDescontadoSobreTotal, "@monto_a_descontar"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            { return true; }
            else
            {
                //Confirmar que pase por aca cuando descuento ya exista
                return false;
            }
        }
    }
}
