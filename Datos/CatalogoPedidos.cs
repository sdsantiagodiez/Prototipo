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
        private ModeloPedido leerDatosPedido(SqlDataReader p_drPedidos)
        {
            ModeloPedido lcl_mod_pedido = new ModeloPedido();

            lcl_mod_pedido.numeroPedido = (int)p_drPedidos["numero_pedido"];
            lcl_mod_pedido.fecha = (DateTime)p_drPedidos["fecha"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            lcl_mod_pedido.entidad.codigo = (int)p_drPedidos["codigo_entidad"];
            lcl_mod_pedido.codigoTipoPedido = (Constantes.CodigosTiposPedidos)p_drPedidos["codigo_tipo_pedido"];
            lcl_mod_pedido.alicuota.monto = (p_drPedidos["alicuota"] != DBNull.Value) ? (decimal)p_drPedidos["alicuota"] : 0;
            lcl_mod_pedido.montoSubTotal = (p_drPedidos["monto_subtotal"] != DBNull.Value) ? (decimal)p_drPedidos["monto_subtotal"] : 0;
            lcl_mod_pedido.montoTotal = (p_drPedidos["monto_total"] != DBNull.Value) ? (decimal)p_drPedidos["monto_total"] : 0;
            lcl_mod_pedido.observaciones = (p_drPedidos["observaciones"] != DBNull.Value) ? (string)p_drPedidos["observaciones"] : null;

            lcl_mod_pedido.descuentos.descuento_monto_1 = (p_drPedidos["descuento_1_monto"] != DBNull.Value) ? (decimal)p_drPedidos["descuento_1_monto"] : 0;
            lcl_mod_pedido.descuentos.descuento_monto_2 = (p_drPedidos["descuento_2_monto"] != DBNull.Value) ? (decimal)p_drPedidos["descuento_2_monto"] : 0;

            #region Datos Pedidos_Personas
            if (lcl_mod_pedido.codigoTipoPedido == Constantes.CodigosTiposPedidos.TipoPedidoPersona)
            {
            lcl_mod_pedido.numeroComprobante = (p_drPedidos["numero_comprobante"] != DBNull.Value) ? (string)p_drPedidos["numero_comprobante"] : null; ;
            lcl_mod_pedido.CAE = (p_drPedidos["cae"] != DBNull.Value) ? (string)p_drPedidos["cae"] : null; ;
            lcl_mod_pedido.aprobadoAFIP = (p_drPedidos["aprobado_afip"] != DBNull.Value) ? (string)p_drPedidos["aprobado_afip"] : null; ;
            (lcl_mod_pedido.entidad as ModeloCliente).nombre = (p_drPedidos["nombre_entidad"] != DBNull.Value) ? (string)p_drPedidos["nombre_entidad"] : null; ;
            (lcl_mod_pedido.entidad as ModeloCliente).apellido = (p_drPedidos["apellido_entidad"] != DBNull.Value) ? (string)p_drPedidos["apellido_entidad"] : null; ;
            lcl_mod_pedido.documentoComprador.tipo.codigo = (p_drPedidos["codigo_documento"] != DBNull.Value) ? (int)p_drPedidos["codigo_documento"] : 0; ;
            lcl_mod_pedido.documentoComprador.numero = (p_drPedidos["numero_documento_entidad"] != DBNull.Value) ? (string)p_drPedidos["numero_documento_entidad"] : null; ;
            lcl_mod_pedido.tipoComprobante = (p_drPedidos["codigo_comprobante"] != DBNull.Value) ? (int)p_drPedidos["codigo_comprobante"] : 0; ;
            }
            #endregion

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

        #region Búsqueda

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
                case Constantes.ParametrosBusqueda.Pedidos.CAE:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.CAE, "@cae"));
                    return " cae = @cae ";
                case Constantes.ParametrosBusqueda.Pedidos.Tipo:
                    p_comando.Parameters.Add(this.instanciarParametro((int)p_mod_pedido.codigoTipoPedido, "@codigo_tipo_pedido"));
                    return " codigo_tipo_pedido = @codigo_tipo_pedido ";
                case Constantes.ParametrosBusqueda.Pedidos.Fecha:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.fecha, "@fecha"));
                    return " fecha = @fecha ";
                case Constantes.ParametrosBusqueda.Any:
                    int? numeroPedido = p_mod_pedido.numeroPedido == 0 ? null : (int?)p_mod_pedido.numeroPedido;
                    p_comando.Parameters.Add(this.instanciarParametro(numeroPedido, "@numero_pedido"));
                    string numeroPedidoQuery = this.parametroBusqueda("@numero_pedido", "numero_pedido", "=");

                    int? codigoTipoPedido = p_mod_pedido.codigoTipoPedido == 0 ? null : (int?)p_mod_pedido.codigoTipoPedido;
                    p_comando.Parameters.Add(this.instanciarParametro(codigoTipoPedido, "@codigo_tipo_pedido"));
                    string codigoTipoPedidoQuery = this.parametroBusqueda("@codigo_tipo_pedido", "codigo_tipo_pedido", "=");

                    DateTime? fecha = p_mod_pedido.fecha.Year == 1? null : (DateTime?)p_mod_pedido.fecha;
                    p_comando.Parameters.Add(this.instanciarParametro(fecha, "@fecha"));
                    string fechaQuery = this.parametroBusqueda("@fecha", "fecha", "=");

                    string cae = String.IsNullOrWhiteSpace(p_mod_pedido.CAE)  ? null : p_mod_pedido.CAE;
                    p_comando.Parameters.Add(this.instanciarParametro(cae, "@cae"));
                    string caeQuery = this.parametroBusqueda("@cae", "cae", "=");

                    return numeroPedidoQuery + " AND " + codigoTipoPedidoQuery + " AND " + fechaQuery;
                default:
                    return base.getCondicionBusqueda(p_parametroBusqueda);
            }
        }
        private string getCondicionBusqueda(ModeloPedido p_mod_pedido, List<DateTime> p_periodo, List<int> p_codigosComprobantes, bool p_clienteGenerico, bool? p_facturadoElectronicament,ref SqlCommand p_comando)
        {
            int? numeroPedido = p_mod_pedido.numeroPedido == 0 ? null : (int?)p_mod_pedido.numeroPedido;
            p_comando.Parameters.Add(this.instanciarParametro(numeroPedido, "@numero_pedido"));
            string numeroPedidoQuery = this.parametroBusqueda("@numero_pedido", "numero_pedido", "=");

            string cae = String.IsNullOrWhiteSpace(p_mod_pedido.CAE) ? null : p_mod_pedido.CAE;
            p_comando.Parameters.Add(this.instanciarParametro(cae, "@cae"));
            string caeQuery = this.parametroBusqueda("@cae", "cae", "=");

            string numeroDocumento = String.IsNullOrWhiteSpace(p_mod_pedido.documentoComprador.numero) ? null : p_mod_pedido.CAE;
            p_comando.Parameters.Add(this.instanciarParametro(numeroDocumento, "@numero_documento"));
            string numeroDocumentoQuery = this.parametroBusqueda("@numero_documento", "numero_documento_entidad", "=");

            int? codigoTipoPedido = p_mod_pedido.codigoTipoPedido == 0 ? null : (int?)p_mod_pedido.codigoTipoPedido;
            p_comando.Parameters.Add(this.instanciarParametro(codigoTipoPedido, "@codigo_tipo_pedido"));
            string codigoTipoPedidoQuery = this.parametroBusqueda("@codigo_tipo_pedido", "codigo_tipo_pedido", "=");

            p_comando.Parameters.Add(this.instanciarParametro(p_periodo[0], "@fecha_desde"));
            p_comando.Parameters.Add(this.instanciarParametro(p_periodo[1], "@fecha_hasta"));
            string periodoQuery = " fecha BETWEEN @fecha_desde AND @fecha_hasta ";

            string numeroEntidadQuery = p_clienteGenerico ? " AND (codigo_entidad = 106242) " : "";//106242 CLIENTE GENERICO ACTUAL -> MODIFICAR en base de datos

            string facturadoElectronicamenteQuery = "";
            if (p_facturadoElectronicament != null)
            {
                string facturadoElectronicamente = p_facturadoElectronicament == true ? "A" : null;
                p_comando.Parameters.Add(this.instanciarParametro(facturadoElectronicamente, "@aprobado_afip"));
                facturadoElectronicamenteQuery = " AND " + this.parametroBusqueda("@aprobado_afip", "aprobado_afip", "=");
            }

            string codigoComprobanteQuery = "";
            if (p_codigosComprobantes.Count > 0)
            {
                codigoComprobanteQuery += " AND ( ";
                for (int i= 0; i< p_codigosComprobantes.Count; i++)
                {
                    codigoComprobanteQuery += " codigo_comprobante = "+p_codigosComprobantes[i].ToString()+" ";
                    if (i + 1 < p_codigosComprobantes.Count)
                    {
                        codigoComprobanteQuery += " OR ";
                    }
                }
                codigoComprobanteQuery += " ) ";
            }

            return " ( " + numeroPedidoQuery + " AND " + caeQuery + " AND " + numeroDocumentoQuery +
                " AND " + codigoTipoPedidoQuery + " AND " + periodoQuery + numeroEntidadQuery + 
                facturadoElectronicamenteQuery + codigoComprobanteQuery + " ) ";
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
                "SELECT  [numero_pedido],[codigo_tipo_pedido],[fecha],[alicuota],[monto_subtotal],[monto_total],[observaciones], "+
                "        [codigo_entidad], "+
                "        [numero_comprobante],[cae],[aprobado_afip],[nombre_entidad],[apellido_entidad],[codigo_documento],[numero_documento_entidad],[codigo_comprobante]  "+
                "    FROM  "+
                "    (  "+
                "        (SELECT pedidos.[numero_pedido],[codigo_tipo_pedido],[fecha],[alicuota],[monto_subtotal],[monto_total],[observaciones], "+
                "                Pedidos_Personas.[codigo_entidad], "+
	            "                [numero_comprobante],[cae],[aprobado_afip],[nombre_entidad],[apellido_entidad], "+
	            "                [codigo_documento],[numero_documento_entidad],[codigo_comprobante] "+
                "            FROM pedidos, Pedidos_Personas  "+
                "            WHERE pedidos.numero_pedido = Pedidos_Personas.numero_pedido  "+
                "        )  "+
                "    UNION  "+
                "        (SELECT pedidos.[numero_pedido],[codigo_tipo_pedido],[fecha],[alicuota],[monto_subtotal],[monto_total],[observaciones], "+
                "                Pedidos_Proveedores.[codigo_entidad], "+
	            "                NULL as [numero_comprobante],NULL as [cae],NULL as [aprobado_afip],NULL as [nombre_entidad],NULL as [apellido_entidad], "+
	            "                NULL as [codigo_documento],NULL as [numero_documento_entidad],NULL as [codigo_comprobante] "+
                "            FROM pedidos, Pedidos_Proveedores  "+
                "            WHERE pedidos.numero_pedido = pedidos_proveedores.numero_pedido  "+
                "        )  "+
                "    ) as tbl " +
                "   WHERE " + querySQL ;

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
                lcl_mod_pedido.addLineaPedidoList(lcl_cat_lineasPedidos.buscarLineasPedido(lcl_mod_lineaPedido, Constantes.ParametrosBusqueda.LineasPedidos.NumeroPedido));

                lcl_lst_mod_pedido.Add(lcl_mod_pedido);
            }
            drPedidos.Dispose();
            comando.Connection.Close();

            return lcl_lst_mod_pedido;
        }

        public List<ModeloPedido> buscarPedido(ModeloPedido p_mod_pedido,Constantes.CodigosTiposPedidos p_tipoPedido, string p_parametroBusqueda)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;

            string querySQL = this.getCondicionBusqueda(p_mod_pedido, p_parametroBusqueda, ref comando);
            int tipo = 0;
            switch(p_tipoPedido){
                case Constantes.CodigosTiposPedidos.TipoPedidoPersona:
                    tipo = 1;
                    break;
                case Constantes.CodigosTiposPedidos.TipoPedidoProveedor:
                    tipo = 2;
                    break;
                default:tipo=0;break;
            }

            comando.CommandText =
                "SELECT  [numero_pedido],[codigo_tipo_pedido],[fecha],[alicuota],[monto_subtotal],[monto_total],[observaciones], " +
                "        [codigo_entidad], " +
                "        [numero_comprobante],[cae],[aprobado_afip],[nombre_entidad],[apellido_entidad],[codigo_documento],[numero_documento_entidad],[codigo_comprobante]  " +
                "    FROM  " +
                "    (  " +
                "        (SELECT pedidos.[numero_pedido],[codigo_tipo_pedido],[fecha],[alicuota],[monto_subtotal],[monto_total],[observaciones], " +
                "                Pedidos_Personas.[codigo_entidad], " +
                "                [numero_comprobante],[cae],[aprobado_afip],[nombre_entidad],[apellido_entidad], " +
                "                [codigo_documento],[numero_documento_entidad],[codigo_comprobante] " +
                "            FROM pedidos, Pedidos_Personas  " +
                "            WHERE pedidos.numero_pedido = Pedidos_Personas.numero_pedido  " +
                "        )  " +
                "    UNION  " +
                "        (SELECT pedidos.[numero_pedido],[codigo_tipo_pedido],[fecha],[alicuota],[monto_subtotal],[monto_total],[observaciones], " +
                "                Pedidos_Proveedores.[codigo_entidad], " +
                "                NULL as [numero_comprobante],NULL as [cae],NULL as [aprobado_afip],NULL as [nombre_entidad],NULL as [apellido_entidad], " +
                "                NULL as [codigo_documento],NULL as [numero_documento_entidad],NULL as [codigo_comprobante] " +
                "            FROM pedidos, Pedidos_Proveedores  " +
                "            WHERE pedidos.numero_pedido = pedidos_proveedores.numero_pedido  " +
                "        )  " +
                "    ) as tbl " +
                "   WHERE codigo_tipo_pedido ="+tipo+" AND " + querySQL;

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
                lcl_mod_pedido.addLineaPedidoList(lcl_cat_lineasPedidos.buscarLineasPedido(lcl_mod_lineaPedido, Constantes.ParametrosBusqueda.LineasPedidos.NumeroPedido));

                lcl_lst_mod_pedido.Add(lcl_mod_pedido);
            }
            drPedidos.Dispose();
            comando.Connection.Close();

            return lcl_lst_mod_pedido;
        }

        public List<ModeloPedido> buscar(ModeloPedido p_mod_pedido, List<DateTime> p_periodo,List<int> p_codigosComprobantes, bool p_clienteGenerico, bool? p_facturadoElectronicamente)
        {
            SqlCommand comando = Conexion.crearComando();            
            string querySQL = this.getCondicionBusqueda(p_mod_pedido,p_periodo, p_codigosComprobantes, p_clienteGenerico, p_facturadoElectronicamente, ref comando);
            comando.CommandText =
                 "SELECT  [numero_pedido],[codigo_tipo_pedido],[fecha],[alicuota],[monto_subtotal],[monto_total],[observaciones], " +
                "        [codigo_entidad], " +
                "        [numero_comprobante],[cae],[aprobado_afip],[nombre_entidad],[apellido_entidad],[codigo_documento],[numero_documento_entidad],[codigo_comprobante],  " +
                "           [descuento_1_monto],[descuento_2_monto] "+
                "    FROM  " +
                "    (  " +
                "        (SELECT pedidos.[numero_pedido],[codigo_tipo_pedido],[fecha],[alicuota],[monto_subtotal],[monto_total],[observaciones], " +
                "                Pedidos_Personas.[codigo_entidad], " +
                "                [numero_comprobante],[cae],[aprobado_afip],[nombre_entidad],[apellido_entidad], " +
                "                [codigo_documento],[numero_documento_entidad],[codigo_comprobante], "+
                "               pedidos.[descuento_1_monto], pedidos.[descuento_2_monto] " +
                "            FROM pedidos, Pedidos_Personas  " +
                "            WHERE pedidos.numero_pedido = Pedidos_Personas.numero_pedido  " +
                "        )  " +
                "    UNION  " +
                "        (SELECT pedidos.[numero_pedido],[codigo_tipo_pedido],[fecha],[alicuota],[monto_subtotal],[monto_total],[observaciones], " +
                "                Pedidos_Proveedores.[codigo_entidad], " +
                "                NULL as [numero_comprobante],NULL as [cae],NULL as [aprobado_afip],NULL as [nombre_entidad],NULL as [apellido_entidad], " +
                "                NULL as [codigo_documento],NULL as [numero_documento_entidad],NULL as [codigo_comprobante], " +
                "               pedidos.[descuento_1_monto], pedidos.[descuento_2_monto] " +
                "            FROM pedidos, Pedidos_Proveedores  " +
                "            WHERE pedidos.numero_pedido = pedidos_proveedores.numero_pedido  " +
                "        )  " +
                "    ) as tbl " +
                "   WHERE " + querySQL;

            comando.Connection.Open();
            SqlDataReader drPedidos = comando.ExecuteReader();

            List<ModeloPedido> lcl_mod_pedidosEncontrados = new List<ModeloPedido>();
            ModeloPedido lcl_mod_pedido = new ModeloPedido();

            CatalogoLineasPedidos lcl_cat_lineasPedidos = new CatalogoLineasPedidos();
            ModeloLineaPedido lcl_mod_lineaPedido = null;
            while (drPedidos.Read())
            {
                lcl_mod_pedido = new ModeloPedido();
                lcl_mod_pedido = this.leerDatosPedido(drPedidos);

                lcl_mod_lineaPedido = new ModeloLineaPedido();
                lcl_mod_lineaPedido.numeroPedido = lcl_mod_pedido.numeroPedido;
                lcl_mod_pedido.addLineaPedidoList(lcl_cat_lineasPedidos.buscarLineasPedido(lcl_mod_lineaPedido, Constantes.ParametrosBusqueda.LineasPedidos.NumeroPedido));

                lcl_mod_pedidosEncontrados.Add(lcl_mod_pedido);
            }
            drPedidos.Dispose();
            comando.Connection.Close();

            return lcl_mod_pedidosEncontrados;
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
            return this.buscarPedido(null, Constantes.ParametrosBusqueda.All);
        }
        public List<ModeloPedido> getAllTipo(Constantes.CodigosTiposPedidos p_tipoPedido)
        {
            return this.buscarPedido(null, p_tipoPedido, Constantes.ParametrosBusqueda.All);
        }

        public string getUltimoComprobante(string p_tipoComprobante)
        {
            string rta = "";

            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "SELECT ISNULL(MAX(numero_comprobante),0) as UltimoComprobante from Pedidos_Personas WHERE codigo_comprobante=@codigo_comprobante";

            comando.Parameters.Add(new SqlParameter("@codigo_comprobante", SqlDbType.NVarChar));
            comando.Parameters["@codigo_comprobante"].Value = p_tipoComprobante;
            

            comando.Connection.Open();

            SqlDataReader drUltimoComprobante = comando.ExecuteReader();
            drUltimoComprobante.Read();
            rta = (string)drUltimoComprobante["UltimoComprobante"];
              
            
            drUltimoComprobante.Close();

            comando.Connection.Close();
            if (rta == null)
            {return "0"; }
            else {return rta;}

        }

        public List<ModeloPedido> getComprobantesNoFacturados(string[] p_tipoComprobante)
        {
            List<ModeloPedido> lcl_lst_mod_ped = new List<ModeloPedido>();
            

            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "SELECT pedidos.[numero_pedido],[codigo_tipo_pedido],[fecha],[alicuota],[monto_subtotal],[monto_total],[observaciones], " +
                "                Pedidos_Personas.[codigo_entidad], " +
                "                [numero_comprobante],[cae],[aprobado_afip],[nombre_entidad],[apellido_entidad], " +
                "                [codigo_documento],[numero_documento_entidad],[codigo_comprobante] " +
                "            FROM pedidos, Pedidos_Personas  " +
                "            WHERE pedidos.numero_pedido = Pedidos_Personas.numero_pedido AND Pedidos_Personas.cae Is NULL "+
                "                   AND (codigo_comprobante=@tipo1 OR codigo_comprobante=@tipo2 OR codigo_comprobante=@tipo3"+
                "                       OR codigo_comprobante=@tipo4) ";

            comando.Parameters.Add(new SqlParameter("@tipo1", SqlDbType.NVarChar));
            comando.Parameters["@tipo1"].Value = p_tipoComprobante[0];
            comando.Parameters.Add(new SqlParameter("@tipo2", SqlDbType.NVarChar));
            comando.Parameters["@tipo2"].Value = p_tipoComprobante[1];
            comando.Parameters.Add(new SqlParameter("@tipo3", SqlDbType.NVarChar));
            comando.Parameters["@tipo3"].Value = p_tipoComprobante[2];
            comando.Parameters.Add(new SqlParameter("@tipo4", SqlDbType.NVarChar));
            comando.Parameters["@tipo4"].Value = p_tipoComprobante[3];

            comando.Connection.Open();

            SqlDataReader drPedidoSinCAE = comando.ExecuteReader();

            while (drPedidoSinCAE.Read())
            { 
                ModeloPedido lcl_mod_ped = new ModeloPedido();
                lcl_mod_ped = leerDatosPedido(drPedidoSinCAE);

                lcl_lst_mod_ped.Add(lcl_mod_ped);
            }
            
            drPedidoSinCAE.Close();

            comando.Connection.Close();
            return lcl_lst_mod_ped;

        }

        public List<ModeloPedido> getComprobantesDesdeHasta(int p_numDesde, int p_numHasta)
        {
            List<ModeloPedido> lcl_lst_mod_ped = new List<ModeloPedido>();
            ModeloLineaPedido lcl_mod_lineaPedido = new ModeloLineaPedido();
            CatalogoLineasPedidos lcl_cat_lineasPedidos = new CatalogoLineasPedidos();


            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "SELECT pedidos.[numero_pedido],[codigo_tipo_pedido],[fecha],[alicuota],[monto_subtotal],[monto_total],[observaciones], " +
                "                Pedidos_Personas.[codigo_entidad], " +
                "                [numero_comprobante],[cae],[aprobado_afip],[nombre_entidad],[apellido_entidad], " +
                "                [codigo_documento],[numero_documento_entidad],[codigo_comprobante] " +
                "            FROM pedidos, Pedidos_Personas  " +
                "            WHERE pedidos.numero_pedido = Pedidos_Personas.numero_pedido " +
                "                   AND pedidos.numero_pedido>=@num_desde AND pedidos.numero_pedido<=@num_hasta ";

            comando.Parameters.Add(new SqlParameter("@num_desde", SqlDbType.Int));
            comando.Parameters["@num_desde"].Value = p_numDesde;
            comando.Parameters.Add(new SqlParameter("@num_hasta", SqlDbType.Int));
            comando.Parameters["@num_hasta"].Value = p_numHasta;
            

            comando.Connection.Open();

            SqlDataReader drPedido = comando.ExecuteReader();

            while (drPedido.Read())
            {
                ModeloPedido lcl_mod_ped = new ModeloPedido();
                lcl_mod_ped = leerDatosPedido(drPedido);

                lcl_mod_lineaPedido = new ModeloLineaPedido();
                lcl_mod_lineaPedido.numeroPedido = lcl_mod_ped.numeroPedido;
                lcl_mod_ped.addLineaPedidoList(lcl_cat_lineasPedidos.buscarLineasPedido(lcl_mod_lineaPedido, Constantes.ParametrosBusqueda.LineasPedidos.NumeroPedido));

                lcl_lst_mod_ped.Add(lcl_mod_ped);
            }

            drPedido.Close();

            comando.Connection.Close();
            return lcl_lst_mod_ped;

        }

        #endregion

        #region Reportes
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
                "SELECT Entidades.codigo AS codigo_proveedor, Proveedores.razon_social as razon_social, "+
                "COUNT(pedidos.numero_pedido) as cantidad_pedidos,SUM(cantidad) as cantidad_articulos, "+
                "SUM(Lineas_Pedidos.valor_parcial) as monto_total FROM Pedidos "+
                "INNER JOIN Lineas_Pedidos ON Pedidos.numero_pedido = Lineas_Pedidos.numero_pedido "+
                "INNER JOIN Pedidos_Proveedores ON Pedidos_Proveedores.numero_pedido= Pedidos.numero_pedido "+
                "INNER JOIN Entidades ON Entidades.codigo= Pedidos_Proveedores.codigo_entidad "+
                "INNER JOIN Proveedores ON Proveedores.codigo_entidad= Entidades.codigo "+
                "WHERE Pedidos.fecha>= @fecha_desde AND Pedidos.fecha<=@fecha_hasta " +
                "GROUP BY Entidades.codigo, Proveedores.razon_social";

            comando.Parameters.Add(new SqlParameter("@fecha_desde", SqlDbType.Date));
            comando.Parameters["@fecha_desde"].Value = p_FechaInicio;
            comando.Parameters.Add(new SqlParameter("@fecha_hasta", SqlDbType.Date));
            comando.Parameters["@fecha_hasta"].Value = P_FechaFin;
           
            comando.Connection.Open();

            SqlDataReader drPedidosEntreFechas = comando.ExecuteReader();

            ModeloReporteEncabezado lcl_mod_ReporteEncabezado = new ModeloReporteEncabezado();
            lcl_mod_ReporteEncabezado.detallePedido = new List<ModeloReportePedidoEntreFechas>();
            
            lcl_mod_ReporteEncabezado.FechaDesde = p_FechaInicio;
            lcl_mod_ReporteEncabezado.FechaHasta = P_FechaFin;
            lcl_mod_ReporteEncabezado.PersonaDesde = "000000000";
            lcl_mod_ReporteEncabezado.PersonaHasta = "999999999";
            lcl_mod_ReporteEncabezado.FechaInforme = DateTime.Today;

            ModeloReportePedidoEntreFechas lcl_mod_det;
            while (drPedidosEntreFechas.Read())
            {
                lcl_mod_det = new ModeloReportePedidoEntreFechas();

                lcl_mod_det.codProveedor = Convert.ToString((int)drPedidosEntreFechas["codigo_proveedor"]);
                lcl_mod_det.razonSocial = (string)drPedidosEntreFechas["razon_social"];
                lcl_mod_det.CantidadArticulos = (int)drPedidosEntreFechas["cantidad_articulos"];
                lcl_mod_det.CantidadPedidos = (int)drPedidosEntreFechas["cantidad_pedidos"];
                lcl_mod_det.MontoTotal = (decimal)drPedidosEntreFechas["monto_total"];
                lcl_mod_ReporteEncabezado.MontoTotal = lcl_mod_ReporteEncabezado.MontoTotal + lcl_mod_det.MontoTotal;

                lcl_mod_ReporteEncabezado.detallePedido.Add(lcl_mod_det);

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
                "COUNT(DISTINCT pedidos.numero_pedido) as cantidad_ventas,SUM(cantidad) as cantidad_articulos, " +
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

        public ModeloReporteEncabezado getTop10Articulos(DateTime p_FechaInicio, DateTime P_FechaFin)
        {

            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                " SELECT Articulos.codigo_original AS codigo_articulo,SUM(CANTIDAD) AS cantidad_articulos, "+
				"AVG(valor_unitario) AS precio_promedio,COUNT(DISTINCT PEDIDOS.numero_pedido) AS cantidad_ventas " +
				"FROM Pedidos  "+
                "INNER JOIN Lineas_Pedidos ON Pedidos.numero_pedido = Lineas_Pedidos.numero_pedido "+
                "INNER JOIN Articulos ON Articulos.codigo_original=Lineas_Pedidos.codigo_original "+
                "WHERE Pedidos.fecha>= @fecha_desde AND Pedidos.fecha<=@fecha_hasta " +
                "GROUP BY Articulos.codigo_original";

            comando.Parameters.Add(new SqlParameter("@fecha_desde", SqlDbType.Date));
            comando.Parameters["@fecha_desde"].Value = p_FechaInicio;
            comando.Parameters.Add(new SqlParameter("@fecha_hasta", SqlDbType.Date));
            comando.Parameters["@fecha_hasta"].Value = P_FechaFin;

            comando.Connection.Open();

            SqlDataReader drTop10Articulos = comando.ExecuteReader();
            
            ModeloReporteEncabezado lcl_mod_ReporteEncabezadoTop10Articulos = new ModeloReporteEncabezado();

            lcl_mod_ReporteEncabezadoTop10Articulos.detalleArticulos = new List<ModeloReporteTop10Articulos>();
            
            lcl_mod_ReporteEncabezadoTop10Articulos.FechaDesde = p_FechaInicio;
            lcl_mod_ReporteEncabezadoTop10Articulos.FechaHasta = P_FechaFin;
            
            while (drTop10Articulos.Read())
            {
                ModeloReporteTop10Articulos lcl_var_Top10Articulos = new ModeloReporteTop10Articulos();
                lcl_var_Top10Articulos.cantidadArticulos = (int)drTop10Articulos["cantidad_articulos"];
                lcl_var_Top10Articulos.cantidadDeVentas= (int)drTop10Articulos["cantidad_ventas"];
                lcl_var_Top10Articulos.codigoArticulo = (string)drTop10Articulos["codigo_articulo"];
                lcl_var_Top10Articulos.precioPromedioVenta = (decimal)drTop10Articulos["precio_promedio"];

                lcl_mod_ReporteEncabezadoTop10Articulos.MontoTotal = lcl_mod_ReporteEncabezadoTop10Articulos.MontoTotal+(lcl_var_Top10Articulos.cantidadArticulos*lcl_var_Top10Articulos.precioPromedioVenta);
                lcl_mod_ReporteEncabezadoTop10Articulos.detalleArticulos.Add(lcl_var_Top10Articulos);
            }
            drTop10Articulos.Close();

            comando.Connection.Close();

            return lcl_mod_ReporteEncabezadoTop10Articulos;
        }
        #endregion

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

            comando.CommandText =
            "INSERT INTO [pedidos](codigo_tipo_pedido,fecha,alicuota,monto_subtotal,monto_total,observaciones, "+
            "   senia, descuento_1_monto, descuento_1_porcentaje, descuento_2_monto, descuento_2_porcentaje, "+
            "   descuento_lineas_monto, descuento_lineas_porcentaje, descuento_total_monto, descuento_total_porcentaje) " +
            "   OUTPUT INSERTED.NUMERO_PEDIDO " +
            "   VALUES (@codigo_tipo_pedido,@fecha, @alicuota,@monto_subtotal,@monto_total, @observaciones, "+
            "   @senia, @descuento_1_monto, @descuento_1_porcentaje, @descuento_2_monto, @descuento_2_porcentaje, " +
            "   @descuento_lineas_monto, @descuento_lineas_porcentaje, @descuento_total_monto, @descuento_total_porcentaje) ";

            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro((int)p_mod_pedido.codigoTipoPedido, "@codigo_tipo_pedido"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.fecha, "@fecha"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.alicuota.monto, "@alicuota"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.montoSubTotal, "@monto_subtotal"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.montoTotal, "@monto_total"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.observaciones, "@observaciones"));

            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.senia, "@senia"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.descuentos.descuento_monto_1, "@descuento_1_monto"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.descuentos.descuento_porcentaje_1, "@descuento_1_porcentaje"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.descuentos.descuento_monto_2, "@descuento_2_monto"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.descuentos.descuento_porcentaje_2, "@descuento_2_porcentaje"));
            decimal descuento_lineas_monto = p_mod_pedido.getDescuentoLineas();
            decimal descuento_lineas_porcentaje = descuento_lineas_monto / p_mod_pedido.montoTotal;
            comando.Parameters.Add(this.instanciarParametro(descuento_lineas_monto, "@descuento_lineas_monto"));
            comando.Parameters.Add(this.instanciarParametro(descuento_lineas_porcentaje, "@descuento_lineas_porcentaje"));
            decimal descuento_total_monto = p_mod_pedido.getDescuentoTotal();
            decimal descuento_total_porcentaje = descuento_total_monto / p_mod_pedido.montoTotal;
            comando.Parameters.Add(this.instanciarParametro(descuento_total_monto, "@descuento_total_monto"));
            comando.Parameters.Add(this.instanciarParametro(descuento_total_porcentaje, "@descuento_total_porcentaje"));

            comando.Connection.Open();
            //falta agregar domicilio, mail y telefono de facturacion
            int? nuevoNumeroPedido = (int?)comando.ExecuteScalar();

            if (nuevoNumeroPedido == null)
            {
                //return false?
                throw new Exception("Ha ocurrido un error al intentar registrar el Pedido actual.");
            }

            p_mod_pedido.numeroPedido = Convert.ToInt32(nuevoNumeroPedido);
            int rowsAffected;

            if (p_mod_pedido.codigoTipoPedido == Constantes.CodigosTiposPedidos.TipoPedidoPersona)
            {
                rowsAffected = this.addPedidoCliente(comando,p_mod_pedido);
            }
            else if (p_mod_pedido.codigoTipoPedido == Constantes.CodigosTiposPedidos.TipoPedidoProveedor)
            {
                rowsAffected = this.addPedidoProveedor(comando, p_mod_pedido);
            }
            else
            {
                //return false?
                throw new Exception("Ha ocurrido un error al intentar registrar el Pedido actual. No se ha detectado el tipo de pedido.");
            }

            comando.Connection.Close();
            if (rowsAffected == 1)
            {
                return true;
            }
            else
            {
                //return false?
                throw new Exception("Ha ocurrido un error al intentar registrar el Pedido actual.");
            }
            
        }

        private int addPedidoCliente(SqlCommand p_comando,ModeloPedido p_mod_pedido)
        {
            p_comando.CommandText =
           "INSERT INTO  Pedidos_Personas  (numero_pedido,numero_comprobante,cae,aprobado_afip,codigo_entidad,nombre_entidad,apellido_entidad,codigo_documento,"+
           "    numero_documento_entidad,codigo_comprobante) " +
           "    VALUES( @numeroPedidoActual,@numero_comprobante,@cae,@aprobado_afip,@codigo_entidad,@nombre_entidad,@apellido_entidad,@codigo_documento,"+
           "        @numero_documento_entidad,@codigo_comprobante) ";
            
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.numeroPedido, "@numeroPedidoActual"));
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.numeroComprobante, "@numero_comprobante"));
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.CAE, "@cae"));
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.aprobadoAFIP, "@aprobado_afip"));
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.entidad.codigo, "@codigo_entidad"));
            p_comando.Parameters.Add(this.instanciarParametro((p_mod_pedido.entidad as ModeloCliente).nombre, "@nombre_entidad"));
            p_comando.Parameters.Add(this.instanciarParametro((p_mod_pedido.entidad as ModeloCliente).apellido, "@apellido_entidad"));
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.documentoComprador.tipo.codigo, "@codigo_documento"));
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.documentoComprador.numero, "@numero_documento_entidad"));
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.tipoComprobante, "@codigo_comprobante"));
            

            return p_comando.ExecuteNonQuery();
        }

        private int addPedidoProveedor(SqlCommand p_comando, ModeloPedido p_mod_pedido)
        {
            p_comando.CommandText =
            "INSERT INTO  Pedidos_Proveedores  (numero_pedido,codigo_entidad) " +
            "    VALUES( @numeroPedidoActual,@codigo_entidad) ";
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.numeroPedido, "@numeroPedidoActual"));
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.entidad.codigo, "@codigo_entidad"));
            return p_comando.ExecuteNonQuery();
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
                "UPDATE [pedidos] "+
                "SET fecha=@fecha, alicuota=@alicuota,monto_subtotal=@monto_subtotal,monto_total=@monto_total, observaciones=@observaciones, " +
                "   senia=@senia, descuento_1_monto=@descuento_1_monto, descuento_1_porcentaje=@descuento_1_porcentaje, "+
                "   descuento_2_monto=@descuento_2_monto, descuento_2_porcentaje=@descuento_2_porcentaje, " +
                "   descuento_lineas_monto=@descuento_lineas_monto, descuento_lineas_porcentaje=@descuento_lineas_porcentaje, "+
                "   descuento_total_montno=@descuento_total_monto, descuento_total_porcentaje=@descuento_total_porcentaje " +
                "WHERE [pedidos].numero_pedido=@numero_pedido";

            //Indica los parametros
            
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.fecha, "@fecha"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.alicuota.monto, "@alicuota"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.montoSubTotal, "@monto_subtotal"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.montoTotal, "@monto_total"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.observaciones, "@observaciones"));

            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.senia, "@senia"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.descuentos.descuento_monto_1, "@descuento_1_monto"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.descuentos.descuento_porcentaje_1, "@descuento_1_porcentaje"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.descuentos.descuento_monto_2, "@descuento_2_monto"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.descuentos.descuento_porcentaje_2, "@descuento_2_porcentaje"));
            decimal descuento_lineas_monto = p_mod_pedido.getDescuentoLineas();
            decimal descuento_lineas_porcentaje = descuento_lineas_monto / p_mod_pedido.montoTotal;
            comando.Parameters.Add(this.instanciarParametro(descuento_lineas_monto, "@descuento_lineas_monto"));
            comando.Parameters.Add(this.instanciarParametro(descuento_lineas_porcentaje, "@descuento_lineas_porcentaje"));
            decimal descuento_total_monto = p_mod_pedido.getDescuentoTotal();
            decimal descuento_total_porcentaje = descuento_total_monto / p_mod_pedido.montoTotal;
            comando.Parameters.Add(this.instanciarParametro(descuento_total_monto, "@descuento_total_monto"));
            comando.Parameters.Add(this.instanciarParametro(descuento_total_porcentaje, "@descuento_total_porcentaje"));

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
