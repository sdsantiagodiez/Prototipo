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

            lcl_mod_pedido.numeroPedido = (int)p_drPedidos["numero_pedido"];
            lcl_mod_pedido.fecha = (DateTime)p_drPedidos["fecha"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            lcl_mod_pedido.codigoEntidad = (int)p_drPedidos["codigo_entidad"];
            lcl_mod_pedido.montoTotal = (p_drPedidos["monto_total"] != DBNull.Value) ? (decimal)p_drPedidos["monto_total"] : 0;
            lcl_mod_pedido.observaciones = (p_drPedidos["observaciones"] != DBNull.Value) ? (string)p_drPedidos["observaciones"] : null;
            lcl_mod_pedido.codigoTipoPedido = (Constantes.CodigosTiposPedidos)p_drPedidos["codigo_tipo_pedido"];

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
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.numeroPedido, "@numero_pedido"));
                    return " numero_pedido = @numero_pedido ";

                case Constantes.ParametrosBusqueda.Pedidos.Tipo:
                    p_comando.Parameters.Add(this.instanciarParametro((int)p_mod_pedido.codigoTipoPedido, "@codigo_tipo_pedido"));
                    return " codigo_tipo_pedido = @codigo_tipo_pedido ";
                case Constantes.ParametrosBusqueda.Pedidos.Fecha:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.fecha, "@fecha"));
                    return " fecha = @fecha ";
                case Constantes.ParametrosBusqueda.Pedidos.Any:
                    int? numeroPedido = p_mod_pedido.numeroPedido == 0 ? null : (int?)p_mod_pedido.numeroPedido;
                    p_comando.Parameters.Add(this.instanciarParametro(numeroPedido, "@numero_pedido"));
                    string numeroPedidoQuery = this.parametroBusqueda("@numero_pedido", "numero_pedido", "=");

                    int? codigoTipoPedido = p_mod_pedido.codigoTipoPedido == 0 ? null : (int?)p_mod_pedido.codigoTipoPedido;
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
                "SELECT [numero_pedido],[fecha],[monto_total],[observaciones],[codigo_tipo_pedido], [codigo_entidad] "+
	            "FROM "+
	            "( "+
                "    (SELECT pedidos.[numero_pedido],[fecha],[monto_total],[observaciones],[codigo_tipo_pedido], [codigo_entidad] " +
		        "       FROM pedidos, Pedidos_Personas "+
		        "       WHERE pedidos.numero_pedido = Pedidos_Personas.numero_pedido "+
		        "    ) "+
	            "UNION "+
		        "    (SELECT pedidos.[numero_pedido],[fecha],[monto_total],[observaciones],[codigo_tipo_pedido], [codigo_entidad] "+
		        "       FROM pedidos, Pedidos_Proveedores "+
		        "       WHERE pedidos.numero_pedido = pedidos_proveedores.numero_pedido "+
                "    ) " +
	            ") as tbl "+
                "WHERE " + querySQL ;

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
                lcl_mod_lineaPedido.numeroPedido = lcl_mod_pedido.numeroPedido;
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
            lcl_mod_pedido.numeroPedido = p_numeroPedido;
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

        public ModeloReporteEncabezado getPedidosEntreFechas(DateTime p_FechaInicio, DateTime P_FechaFin, int p_CodigoProveedor)
        {
          
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "SELECT Entidades.codigo AS codigo_proveedor, Proveedores.razon_social as razon_social," +
                "COUNT(pedidos.numero_pedido) as cantidad_pedidos,SUM(cantidad) as cantidad_articulos," +
                "SUM(Lineas_Pedidos.valor_parcial) as monto_total FROM Pedidos" +
                "INNER JOIN Lineas_Pedidos ON Pedidos.numero_pedido = Lineas_Pedidos.numero_pedido" +
                "INNER JOIN Pedidos_Proveedores ON Pedidos_Proveedores.numero_pedido= Pedidos.numero_pedido" +
                "INNER JOIN Entidades ON Entidades.codigo= Pedidos_Proveedores.codigo_entidad" +
                "INNER JOIN Proveedores ON Proveedores.codigo_entidad= Entidades.codigo" +
                "WHERE Pedidos.fecha>= @fecha_desde AND Pedidos.fecha<=@fecha_hasta AND Entidades.codigo=@codigo_proveedor " +
                "GROUP BY Entidades.codigo, Proveedores.razon_social";

            comando.Parameters.Add(new SqlParameter("@fecha_desde", SqlDbType.Date));
            comando.Parameters["@fecha_desde"].Value = p_FechaInicio;
            comando.Parameters.Add(new SqlParameter("@fecha_hasta", SqlDbType.Date));
            comando.Parameters["@fecha_hasta"].Value = P_FechaFin;
            comando.Parameters.Add(new SqlParameter("@codigo_proveedor", SqlDbType.Int));
            comando.Parameters["@codigo_proveedor"].Value = p_CodigoProveedor;

            comando.Connection.Open();

            SqlDataReader drPedidosEntreFechas = comando.ExecuteReader();

            ModeloReporteEncabezado lcl_mod_ReporteEncabezado = new ModeloReporteEncabezado();
            int i =0;
            lcl_mod_ReporteEncabezado.FechaDesde = p_FechaInicio;
            lcl_mod_ReporteEncabezado.FechaHasta = P_FechaFin;
            lcl_mod_ReporteEncabezado.PersonaDesde = p_CodigoProveedor.ToString();
            lcl_mod_ReporteEncabezado.PersonaHasta = p_CodigoProveedor.ToString();
            lcl_mod_ReporteEncabezado.FechaInforme = DateTime.Today;
            
                
            while (drPedidosEntreFechas.Read())
            {
                lcl_mod_ReporteEncabezado.detallePedido[i].codProveedor = (string)drPedidosEntreFechas["codigo_proveedor"];
                lcl_mod_ReporteEncabezado.detallePedido[i].razonSocial = (string)drPedidosEntreFechas["razon_social"];
                lcl_mod_ReporteEncabezado.detallePedido[i].CantidadArticulos = (int)drPedidosEntreFechas["cantidad_articulos"];
                lcl_mod_ReporteEncabezado.detallePedido[i].CantidadPedidos = (int)drPedidosEntreFechas["cantidad_pedidos"];
                lcl_mod_ReporteEncabezado.detallePedido[i].MontoTotal = (decimal)drPedidosEntreFechas["monto_total"];
                lcl_mod_ReporteEncabezado.MontoTotal = lcl_mod_ReporteEncabezado.MontoTotal + lcl_mod_ReporteEncabezado.detallePedido[i].MontoTotal;
                i++;
            }
            drPedidosEntreFechas.Close();

            comando.Connection.Close();

            return lcl_mod_ReporteEncabezado;
        }

        public ModeloReporteEncabezado getPedidosEntreFechas(DateTime p_FechaInicio, DateTime P_FechaFin)
        {
            
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "SELECT Entidades.codigo AS codigo_proveedor, Proveedores.razon_social as razon_social,"+
                "COUNT(pedidos.numero_pedido) as cantidad_pedidos,SUM(cantidad) as cantidad_articulos,"+
                "SUM(Lineas_Pedidos.valor_parcial) as monto_total FROM Pedidos"+
                "INNER JOIN Lineas_Pedidos ON Pedidos.numero_pedido = Lineas_Pedidos.numero_pedido"+
                "INNER JOIN Pedidos_Proveedores ON Pedidos_Proveedores.numero_pedido= Pedidos.numero_pedido"+
                "INNER JOIN Entidades ON Entidades.codigo= Pedidos_Proveedores.codigo_entidad"+
                "INNER JOIN Proveedores ON Proveedores.codigo_entidad= Entidades.codigo"+
                "WHERE Pedidos.fecha>= @fecha_desde AND Pedidos.fecha<=@fecha_hasta " +
                "GROUP BY Entidades.codigo, Proveedores.razon_social";

            comando.Parameters.Add(new SqlParameter("@fecha_desde", SqlDbType.Date));
            comando.Parameters["@fecha_desde"].Value = p_FechaInicio;
            comando.Parameters.Add(new SqlParameter("@fecha_hasta", SqlDbType.Date));
            comando.Parameters["@fecha_hasta"].Value = P_FechaFin;
           
            comando.Connection.Open();

            SqlDataReader drPedidosEntreFechas = comando.ExecuteReader();

            ModeloReporteEncabezado lcl_mod_ReporteEncabezado = new ModeloReporteEncabezado();
            int i = 0;
            lcl_mod_ReporteEncabezado.FechaDesde = p_FechaInicio;
            lcl_mod_ReporteEncabezado.FechaHasta = P_FechaFin;
            lcl_mod_ReporteEncabezado.PersonaDesde = "000000000";
            lcl_mod_ReporteEncabezado.PersonaHasta = "999999999";
            lcl_mod_ReporteEncabezado.FechaInforme = DateTime.Today;
            

            while (drPedidosEntreFechas.Read())
            {
                lcl_mod_ReporteEncabezado.detallePedido[i].codProveedor = (string)drPedidosEntreFechas["codigo_proveedor"];
                lcl_mod_ReporteEncabezado.detallePedido[i].razonSocial = (string)drPedidosEntreFechas["razon_social"];
                lcl_mod_ReporteEncabezado.detallePedido[i].CantidadArticulos = (int)drPedidosEntreFechas["cantidad_articulos"];
                lcl_mod_ReporteEncabezado.detallePedido[i].CantidadPedidos = (int)drPedidosEntreFechas["cantidad_pedidos"];
                lcl_mod_ReporteEncabezado.detallePedido[i].MontoTotal = (decimal)drPedidosEntreFechas["monto_total"];
                lcl_mod_ReporteEncabezado.MontoTotal = lcl_mod_ReporteEncabezado.MontoTotal + lcl_mod_ReporteEncabezado.detallePedido[i].MontoTotal;
                i++;

            }
            drPedidosEntreFechas.Close();

            comando.Connection.Close();

            return lcl_mod_ReporteEncabezado;
        }

        public ModeloReporteEncabezado getVentaEntreFechas(DateTime p_FechaInicio, DateTime P_FechaFin, int p_CodigoCliente)
        {
            
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "SELECT Entidades.codigo AS codigo_cliente, CONCAT(Personas.apellido, ', ', Personas.nombre) as nombre_cliente,"+
                "COUNT(pedidos.numero_pedido) as cantidad_ventas,SUM(cantidad) as cantidad_articulos,"+
                "SUM(Lineas_Pedidos.valor_parcial) as monto_ventas FROM Pedidos"+
                "INNER JOIN Lineas_Pedidos ON Pedidos.numero_pedido = Lineas_Pedidos.numero_pedido"+
                "INNER JOIN Pedidos_Personas ON Pedidos_Personas.numero_pedido= Pedidos.numero_pedido"+
                "INNER JOIN Entidades ON Entidades.codigo= Pedidos_Personas.codigo_entidad"+
                "INNER JOIN Personas ON Personas.codigo_entidad= Entidades.codigo"+
                "WHERE Pedidos.fecha>= @fecha_desde AND Pedidos.fecha<=@fecha_hasta AND Entidades.Codigo=@codigo_cliente" +
                "GROUP BY Entidades.codigo, Personas.apellido, personas.nombre";

            comando.Parameters.Add(new SqlParameter("@fecha_desde", SqlDbType.Date));
            comando.Parameters["@fecha_desde"].Value = p_FechaInicio;
            comando.Parameters.Add(new SqlParameter("@fecha_hasta", SqlDbType.Date));//No estoy seguro de que pueda hacer bien la comparacion
            comando.Parameters["@fecha_hasta"].Value = P_FechaFin;
            comando.Parameters.Add(new SqlParameter("@codigo_cliente", SqlDbType.Int));
            comando.Parameters["@codigo_cliente"].Value = p_CodigoCliente;

            comando.Connection.Open();

            SqlDataReader drVentasEntreFechas = comando.ExecuteReader();

            ModeloReporteEncabezado lcl_mod_ReporteEncabezadoVentaEntreFechas = new ModeloReporteEncabezado();

            lcl_mod_ReporteEncabezadoVentaEntreFechas.FechaDesde = p_FechaInicio;
            lcl_mod_ReporteEncabezadoVentaEntreFechas.FechaHasta = P_FechaFin;
            lcl_mod_ReporteEncabezadoVentaEntreFechas.PersonaDesde = p_CodigoCliente.ToString();
            lcl_mod_ReporteEncabezadoVentaEntreFechas.PersonaHasta = p_CodigoCliente.ToString();
            lcl_mod_ReporteEncabezadoVentaEntreFechas.FechaInforme = DateTime.Today;
            int i = 0;
            while (drVentasEntreFechas.Read())
            {
                lcl_mod_ReporteEncabezadoVentaEntreFechas.detalleVenta[i].codigo_cliente = (int)drVentasEntreFechas["codigo_cliente"];
                lcl_mod_ReporteEncabezadoVentaEntreFechas.detalleVenta[i].nombre_cliente = (string)drVentasEntreFechas["nombre_cliente"];
                lcl_mod_ReporteEncabezadoVentaEntreFechas.detalleVenta[i].cantidad_ventas = (int)drVentasEntreFechas["cantidad_ventas"];
                lcl_mod_ReporteEncabezadoVentaEntreFechas.detalleVenta[i].cantidad_articulos = (int)drVentasEntreFechas["cantidad_articulos"];
                lcl_mod_ReporteEncabezadoVentaEntreFechas.detalleVenta[i].monto_ventas = (decimal)drVentasEntreFechas["monto_ventas"];
                lcl_mod_ReporteEncabezadoVentaEntreFechas.MontoTotal = lcl_mod_ReporteEncabezadoVentaEntreFechas.MontoTotal + lcl_mod_ReporteEncabezadoVentaEntreFechas.detalleVenta[i].monto_ventas;
                i++;
            }
            drVentasEntreFechas.Close();

            comando.Connection.Close();

            return lcl_mod_ReporteEncabezadoVentaEntreFechas;
        }
        public ModeloReporteEncabezado getVentaEntreFechas(DateTime p_FechaInicio, DateTime P_FechaFin)
        {
           
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "SELECT Entidades.codigo AS codigo_cliente, CONCAT(Personas.apellido, ', ', Personas.nombre) as nombre_cliente, " +
                "COUNT(pedidos.numero_pedido) as cantidad_ventas,SUM(cantidad) as cantidad_articulos, " +
                "SUM(Lineas_Pedidos.valor_parcial) as monto_ventas FROM Pedidos " +
                "INNER JOIN Lineas_Pedidos ON Pedidos.numero_pedido = Lineas_Pedidos.numero_pedido " +
                "INNER JOIN Pedidos_Personas ON Pedidos_Personas.numero_pedido= Pedidos.numero_pedido " +
                "INNER JOIN Entidades ON Entidades.codigo= Pedidos_Personas.codigo_entidad " +
                "INNER JOIN Personas ON Personas.codigo_entidad= Entidades.codigo " +
                "WHERE Pedidos.fecha>= @fecha_desde AND Pedidos.fecha<=@fecha_hasta " +
                "GROUP BY Entidades.codigo, Personas.apellido, personas.nombre ";

            comando.Parameters.Add(new SqlParameter("@fecha_desde", SqlDbType.Date));
            comando.Parameters["@fecha_desde"].Value = p_FechaInicio;
            comando.Parameters.Add(new SqlParameter("@fecha_hasta", SqlDbType.Date));
            comando.Parameters["@fecha_hasta"].Value = P_FechaFin;
           
            comando.Connection.Open();

            SqlDataReader drVentasEntreFechas = comando.ExecuteReader();

            ModeloReporteEncabezado lcl_mod_ReporteEncabezadoVentaEntreFechas = new ModeloReporteEncabezado();
            lcl_mod_ReporteEncabezadoVentaEntreFechas.detalleVenta = new List<ModeloReporteVentaEntreFechas>();

            lcl_mod_ReporteEncabezadoVentaEntreFechas.FechaDesde = p_FechaInicio;
            lcl_mod_ReporteEncabezadoVentaEntreFechas.FechaHasta = P_FechaFin;
            lcl_mod_ReporteEncabezadoVentaEntreFechas.PersonaDesde = "00000000";
            lcl_mod_ReporteEncabezadoVentaEntreFechas.PersonaHasta = "99999999";
            lcl_mod_ReporteEncabezadoVentaEntreFechas.FechaInforme = DateTime.Today;
           
            while (drVentasEntreFechas.Read())
            {
                ModeloReporteVentaEntreFechas lcl_var_modeloEFechas = new ModeloReporteVentaEntreFechas();
                lcl_var_modeloEFechas.codigo_cliente = (int)drVentasEntreFechas["codigo_cliente"];
                lcl_var_modeloEFechas.nombre_cliente = (string)drVentasEntreFechas["nombre_cliente"];
                lcl_var_modeloEFechas.cantidad_ventas = (int)drVentasEntreFechas["cantidad_ventas"];
                lcl_var_modeloEFechas.cantidad_articulos = (int)drVentasEntreFechas["cantidad_articulos"];
                lcl_var_modeloEFechas.monto_ventas = (decimal)drVentasEntreFechas["monto_ventas"];
                lcl_mod_ReporteEncabezadoVentaEntreFechas.MontoTotal = lcl_mod_ReporteEncabezadoVentaEntreFechas.MontoTotal + lcl_var_modeloEFechas.monto_ventas;
                lcl_mod_ReporteEncabezadoVentaEntreFechas.detalleVenta.Add(lcl_var_modeloEFechas);
   
            }
            drVentasEntreFechas.Close();

            comando.Connection.Close();

            return lcl_mod_ReporteEncabezadoVentaEntreFechas;
        }

        #region Alta/Baja/Modificación
        /*
         * True si se realizó correctamente
         * False si ocurrió algún error
         */
        private string getTablaTipoPedido(ModeloPedido p_mod_pedido)
        {
            switch (p_mod_pedido.codigoTipoPedido)
            {
                case Constantes.CodigosTiposPedidos.TipoPedidoPersona:
                    return " Pedidos_Personas ";
                case Constantes.CodigosTiposPedidos.TipoPedidoProveedor:
                    return " Pedidos_Proveedores ";
                default:
                    return "";
            }
        }
        public bool add(ref ModeloPedido p_mod_pedido)
        {
            SqlConnection ConexionSQL = Conexion.crearConexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            SqlTransaction transaccion;
            ConexionSQL.Open();

            transaccion = ConexionSQL.BeginTransaction("InsertarPedido");
            comando.Transaction = transaccion;

            
            try
            {
                comando.CommandText =
                "INSERT INTO [pedidos]([fecha],[monto_total],[observaciones],[codigo_tipo_pedido]) " +
                "OUTPUT INSERTED.NUMERO_PEDIDO " +
                "VALUES (@fecha, @monto_total, @observaciones,@codigo_tipo_pedido)";

                //Indica los parametros
                comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.fecha, "@fecha"));
                comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.montoTotal, "@monto_total"));
                comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.observaciones, "@observaciones"));
                comando.Parameters.Add(this.instanciarParametro((int)p_mod_pedido.codigoTipoPedido, "@codigo_tipo_pedido"));
                comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.codigoEntidad, "@codigo_entidad"));

                int? nuevoNumeroPedido = (int?)comando.ExecuteScalar();

                string tablaTipoPedidoQuery = this.getTablaTipoPedido(p_mod_pedido);
                
                comando.CommandText =
                "INSERT INTO " + tablaTipoPedidoQuery + " (numero_pedido,codigo_entidad) " +
                "    VALUES( @numeroPedidoActual,@codigo_entidad) ";
                comando.Parameters.Add(this.instanciarParametro(nuevoNumeroPedido,"@numeroPedidoActual"));
                int rowsAffected = comando.ExecuteNonQuery();


                if (nuevoNumeroPedido != null && rowsAffected == 1)
                {
                    p_mod_pedido.numeroPedido = Convert.ToInt32(nuevoNumeroPedido);
                    transaccion.Commit();
                    return true;
                }
                else
                {
                    try
                    {
                        transaccion.Rollback();
                        return false;
                    }
                    catch (Exception ex2)
                    {
                        return false;
                    }
                }

            }
            catch (Exception ex)
            {
                try
                {
                    transaccion.Rollback();
                    return false;
                }
                catch (Exception ex3)
                {
                    return false;
                }
            }
            finally
            {
                ConexionSQL.Close();
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
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.montoTotal, "@monto_total"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.observaciones, "@observaciones"));
            comando.Parameters.Add(this.instanciarParametro((int)p_mod_pedido.codigoTipoPedido, "@codigo_tipo_pedido"));

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

            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.numeroPedido, "@numero_pedido"));

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
