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
        public static int codigoClienteGenerico = 106242;
        private ModeloPedido leerDatosPedido(SqlDataReader p_drPedidos)
        {
            ModeloPedido lcl_mod_pedido = new ModeloPedido();

            lcl_mod_pedido.numeroPedido = (int)p_drPedidos["numero_pedido"];
            lcl_mod_pedido.fecha = (DateTime)p_drPedidos["fecha"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            lcl_mod_pedido.codigoTipoPedido = (Constantes.CodigosTiposPedidos)p_drPedidos["codigo_tipo_pedido"];
            lcl_mod_pedido.numeroComprobanteTipo = (p_drPedidos["numero_pedido_tipo"] != DBNull.Value)?(string)p_drPedidos["numero_pedido_tipo"]:null;
            lcl_mod_pedido.entidad.codigo = (int)p_drPedidos["codigo_entidad"];
            lcl_mod_pedido.alicuota.monto = (p_drPedidos["alicuota"] != DBNull.Value) ? (decimal)p_drPedidos["alicuota"] : 0;
            lcl_mod_pedido.montoSubTotal = (p_drPedidos["monto_subtotal"] != DBNull.Value) ? (decimal)p_drPedidos["monto_subtotal"] : 0;
            lcl_mod_pedido.montoTotal = (p_drPedidos["monto_total"] != DBNull.Value) ? (decimal)p_drPedidos["monto_total"] : 0;
            lcl_mod_pedido.observaciones = (p_drPedidos["observaciones"] != DBNull.Value) ? (string)p_drPedidos["observaciones"] : null;
            
            lcl_mod_pedido.descuentos.descuento_monto_1 = (p_drPedidos["descuento_1_monto"] != DBNull.Value) ? (decimal)p_drPedidos["descuento_1_monto"] : 0;
            lcl_mod_pedido.descuentos.descuento_monto_2 = (p_drPedidos["descuento_2_monto"] != DBNull.Value) ? (decimal)p_drPedidos["descuento_2_monto"] : 0;

            #region Datos Pedidos_Personas
            if (lcl_mod_pedido.codigoTipoPedido == Constantes.CodigosTiposPedidos.Persona)
            {
                lcl_mod_pedido.numeroComprobante = (p_drPedidos["numero_comprobante"] != DBNull.Value) ? (string)p_drPedidos["numero_comprobante"] : null; 
                lcl_mod_pedido.CAE = (p_drPedidos["cae"] != DBNull.Value) ? (string)p_drPedidos["cae"] : null;
                lcl_mod_pedido.VencimientoCAE = (p_drPedidos["vencimiento_cae"] != DBNull.Value) ? (DateTime)p_drPedidos["vencimiento_cae"] : DateTime.Now;
                lcl_mod_pedido.aprobadoAFIP = (p_drPedidos["aprobado_afip"] != DBNull.Value) ? (string)p_drPedidos["aprobado_afip"] : null; 
                (lcl_mod_pedido.entidad as ModeloCliente).nombre = (p_drPedidos["nombre_entidad"] != DBNull.Value) ? (string)p_drPedidos["nombre_entidad"] : null; 
                (lcl_mod_pedido.entidad as ModeloCliente).apellido = (p_drPedidos["apellido_entidad"] != DBNull.Value) ? (string)p_drPedidos["apellido_entidad"] : null;
                (lcl_mod_pedido.entidad as ModeloCliente).razonSocial = (p_drPedidos["razon_social_entidad"] != DBNull.Value) ? (string)p_drPedidos["razon_social_entidad"] : null; 
                lcl_mod_pedido.documentoComprador.tipo.codigo = (p_drPedidos["codigo_documento"] != DBNull.Value) ? (int)p_drPedidos["codigo_documento"] : 0; 
                lcl_mod_pedido.documentoComprador.numero = (p_drPedidos["numero_documento_entidad"] != DBNull.Value) ? (string)p_drPedidos["numero_documento_entidad"] : null; 
                lcl_mod_pedido.tipoComprobante = (p_drPedidos["codigo_comprobante"] != DBNull.Value) ? (int)p_drPedidos["codigo_comprobante"] : 0;
                lcl_mod_pedido.estado = (p_drPedidos["estado"] != DBNull.Value) ? (string)p_drPedidos["estado"] : "C";
            }
            else
            {
                lcl_mod_pedido.tipoComprobante = 2001;
            }
            #endregion

            #region Datos adicionales (Domicilio, teléfono, mail)
            lcl_mod_pedido.mailContacto = new ModeloMail() { mail = (p_drPedidos["mail"] != DBNull.Value) ? (string)p_drPedidos["mail"] : null };
            lcl_mod_pedido.telefonoContacto = new ModeloTelefono() 
            {
                tipo = (p_drPedidos["tipo"] != DBNull.Value) ? (string)p_drPedidos["tipo"] : null,
                numero = (p_drPedidos["numero_telefono"] != DBNull.Value) ? (string)p_drPedidos["numero_telefono"] : null
            };
            lcl_mod_pedido.domicilioDeFacturacion = new ModeloDomicilio()
            {
                calle = (p_drPedidos["calle"] != DBNull.Value) ? (string)p_drPedidos["calle"] : null,
                numero = (p_drPedidos["numero_domicilio"] != DBNull.Value) ? (string)p_drPedidos["numero_domicilio"] : null,
                piso = (p_drPedidos["piso"] != DBNull.Value) ? (string)p_drPedidos["piso"] : null,
                departamento = (p_drPedidos["departamento"] != DBNull.Value) ? (string)p_drPedidos["departamento"] : null,
                ciudad = (p_drPedidos["ciudad"] != DBNull.Value) ? (string)p_drPedidos["ciudad"] : null,
                codigoPostal = (p_drPedidos["codigo_postal"] != DBNull.Value) ? (string)p_drPedidos["codigo_postal"] : null,
                provincia = new ModeloProvincia() 
                {
                    codigo = (p_drPedidos["codigo_provincia"] != DBNull.Value) ? (string)p_drPedidos["codigo_provincia"] : null
                }
            };
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
                    return " tbl.numero_pedido = @numero_pedido ";
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
        private string getCondicionBusqueda(ModeloPedido p_mod_pedido, List<DateTime> p_periodo, List<int> p_codigosComprobantes, bool? p_clienteGenerico, bool? p_facturadoElectronicamente,ref SqlCommand p_comando)
        {
            int? numeroPedido = p_mod_pedido.numeroPedido == 0 ? null : (int?)p_mod_pedido.numeroPedido;
            p_comando.Parameters.Add(this.instanciarParametro(numeroPedido, "@numero_pedido"));
            string numeroPedidoQuery = this.parametroBusqueda("@numero_pedido", "tbl.numero_pedido", "=");

            string cae = String.IsNullOrWhiteSpace(p_mod_pedido.CAE) ? null : p_mod_pedido.CAE;
            p_comando.Parameters.Add(this.instanciarParametro(cae, "@cae"));
            string caeQuery = this.parametroBusqueda("@cae", "cae", "=");

            string numeroDocumento = String.IsNullOrWhiteSpace(p_mod_pedido.documentoComprador.numero) ? null : p_mod_pedido.documentoComprador.numero;
            p_comando.Parameters.Add(this.instanciarParametro(numeroDocumento, "@numero_documento"));
            string numeroDocumentoQuery = this.parametroBusqueda("@numero_documento", "numero_documento_entidad", "=");

            int? codigoTipoPedido = p_mod_pedido.codigoTipoPedido == 0 ? null : (int?)p_mod_pedido.codigoTipoPedido;
            p_comando.Parameters.Add(this.instanciarParametro(codigoTipoPedido, "@codigo_tipo_pedido"));
            string codigoTipoPedidoQuery = this.parametroBusqueda("@codigo_tipo_pedido", "codigo_tipo_pedido", "=");

            string periodoQuery = "";
            if (p_periodo != null)
            {
                p_comando.Parameters.Add(this.instanciarParametro(p_periodo[0].Date, "@fecha_desde"));
                p_comando.Parameters.Add(this.instanciarParametro(p_periodo[1].Date, "@fecha_hasta"));
                periodoQuery = " AND fecha BETWEEN @fecha_desde AND @fecha_hasta ";
            }

            string numeroEntidadQuery = "";
            if (p_clienteGenerico != null)
            {
                string comparador = p_clienteGenerico == true? " = ":" <> ";
                
                numeroEntidadQuery = " AND (codigo_entidad " + comparador + CatalogoPedidos.codigoClienteGenerico.ToString() + ") ";
            }

            string facturadoElectronicamenteQuery = "";
            if (p_facturadoElectronicamente != null)
            {
                facturadoElectronicamenteQuery = p_facturadoElectronicamente == true? " AND (aprobado_afip = 'A' ) " : " AND (aprobado_afip <> 'A' OR aprobado_afip IS NULL) ";   
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
            string nombreEntidad;
            string apellidoEntidad;
            string razonSocialEntidad;
            if (p_mod_pedido.entidad.GetType() == typeof(ModeloProveedor))
            {
                nombreEntidad = null;
                apellidoEntidad = null;
                razonSocialEntidad = String.IsNullOrWhiteSpace((p_mod_pedido.entidad as ModeloProveedor).razonSocial)?null:(p_mod_pedido.entidad as ModeloProveedor).razonSocial;
            }
            else
            {
                nombreEntidad = String.IsNullOrWhiteSpace((p_mod_pedido.entidad as ModeloCliente).nombre) ? null : (p_mod_pedido.entidad as ModeloCliente).nombre;
                apellidoEntidad = String.IsNullOrWhiteSpace((p_mod_pedido.entidad as ModeloCliente).apellido) ? null : (p_mod_pedido.entidad as ModeloCliente).apellido;
                razonSocialEntidad = String.IsNullOrWhiteSpace((p_mod_pedido.entidad as ModeloCliente).razonSocial) ? null : (p_mod_pedido.entidad as ModeloCliente).razonSocial;
            }

            p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(nombreEntidad), "@nombre_entidad"));
            string nombreEntidadQuery = this.parametroBusqueda("@nombre_entidad", "nombre_entidad", "LIKE");
            
            p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(apellidoEntidad), "@apellido_entidad"));
            string apellidoEntidadQuery = this.parametroBusqueda("@apellido_entidad", "apellido_entidad", "LIKE");

            p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(razonSocialEntidad), "@razon_social_entidad"));
            string razonSocialEntidadQuery = this.parametroBusqueda("@razon_social_entidad", "razon_social_entidad", "LIKE");

            return " ( " + numeroPedidoQuery + " AND " + caeQuery + " AND " + numeroDocumentoQuery +
                " AND " + nombreEntidadQuery + " AND " + apellidoEntidadQuery + " AND " + razonSocialEntidadQuery +
                " AND " + codigoTipoPedidoQuery +  periodoQuery + numeroEntidadQuery + 
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
                "SELECT  tbl.[numero_pedido],[codigo_tipo_pedido],[fecha],[alicuota],[monto_subtotal],[monto_total],[observaciones], "+
                "        [codigo_entidad], [razon_social_entidad],[descuento_1_monto],[descuento_2_monto], " +
                "        [numero_comprobante],[cae],[vencimiento_cae],[aprobado_afip],[nombre_entidad],[apellido_entidad],[codigo_documento],[numero_documento_entidad],[codigo_comprobante],[estado],  " +
                "       mail.mail, numero_pedido_tipo, " +
		        "       telefono.tipo,telefono.numero as numero_telefono,  "+
		        "       domicilio.calle,domicilio.numero as numero_domicilio,domicilio.piso,domicilio.departamento,domicilio.ciudad,domicilio.codigo_postal,domicilio.codigo_provincia "+
                "    FROM  "+
                "    (  "+
                "        (SELECT pedidos.[numero_pedido],[codigo_tipo_pedido],[fecha],[alicuota],[monto_subtotal],[monto_total],[observaciones], "+
                "                Pedidos_Personas.[codigo_entidad], Pedidos_Personas.[razon_social_entidad],[descuento_1_monto],[descuento_2_monto], " +
	            "                [numero_comprobante],[cae],[vencimiento_cae],[aprobado_afip],[nombre_entidad],[apellido_entidad], "+
                "                [codigo_documento],[numero_documento_entidad],[codigo_comprobante],[estado],[numero_pedido_tipo] " +
                "            FROM pedidos, Pedidos_Personas  "+
                "            WHERE pedidos.numero_pedido = Pedidos_Personas.numero_pedido  "+
                "        )  "+
                "    UNION  "+
                "        (SELECT pedidos.[numero_pedido],[codigo_tipo_pedido],[fecha],[alicuota],[monto_subtotal],[monto_total],[observaciones], "+
                "                Pedidos_Proveedores.[codigo_entidad], NULL as [razon_social_entidad],[descuento_1_monto],[descuento_2_monto], " +
                "                NULL as [numero_comprobante],NULL as [cae], NULL as [vencimiento_cae],NULL as [aprobado_afip],NULL as [nombre_entidad],NULL as [apellido_entidad], " +
                "                NULL as [codigo_documento],NULL as [numero_documento_entidad],NULL as [codigo_comprobante],NULL as [estado],[numero_pedido_tipo] " +
                "            FROM pedidos, Pedidos_Proveedores  "+
                "            WHERE pedidos.numero_pedido = pedidos_proveedores.numero_pedido  "+
                "        )  "+
                "    ) as tbl " +
                "inner join Mails_Pedido mail "+
                "on mail.numero_pedido = tbl.numero_pedido " +
	            "inner join Telefonos_Pedido telefono "+
                "on telefono.numero_pedido = tbl.numero_pedido " +
	            "inner join Domicilios_Pedido domicilio "+
                "on domicilio.numero_pedido = tbl.numero_pedido " +
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

            CatalogoProveedores lcl_cat_proveedores = new CatalogoProveedores();
            foreach (ModeloPedido p in lcl_lst_mod_pedido)
            {
                if (p.codigoTipoPedido == Constantes.CodigosTiposPedidos.Proveedor)
                {
                    p.entidad = lcl_cat_proveedores.getOne(p.entidad.codigo);
                }
                this.getProvincia(p);
            }

            return lcl_lst_mod_pedido;
        }
        private void getProvincia(ModeloPedido p_pedido)
        {
            if (p_pedido.domicilioDeFacturacion.provincia.codigo == null)
                return;
            CatalogoProvincias lcl_cat_provincias = new CatalogoProvincias();
            p_pedido.domicilioDeFacturacion.provincia = new CatalogoProvincias().getOne(p_pedido.domicilioDeFacturacion.provincia.codigo);
            p_pedido.domicilioDeFacturacion.pais = new CatalogoPaises().getOne(p_pedido.domicilioDeFacturacion.provincia.codigoPais);
        }
        public List<ModeloPedido> buscar(ModeloPedido p_mod_pedido, List<DateTime> p_periodo,List<int> p_codigosComprobantes, bool? p_clienteGenerico, bool? p_facturadoElectronicamente)
        {
            SqlCommand comando = Conexion.crearComando();            
            string querySQL = this.getCondicionBusqueda(p_mod_pedido,p_periodo, p_codigosComprobantes, p_clienteGenerico, p_facturadoElectronicamente, ref comando);
            comando.CommandText =
                 "SELECT  tbl.[numero_pedido],[codigo_tipo_pedido],[fecha],[alicuota],[monto_subtotal],[monto_total],[observaciones], " +
                "        [codigo_entidad],[razon_social_entidad], " +
                "        [numero_comprobante],[cae],[vencimiento_cae],[aprobado_afip],[nombre_entidad],[apellido_entidad],[codigo_documento],[numero_documento_entidad],[codigo_comprobante],  " +
                "           [descuento_1_monto],[descuento_2_monto],[estado], " +
                "       mail.mail, " +
                "       telefono.tipo,telefono.numero as numero_telefono,  " +
                "       domicilio.calle,domicilio.numero as numero_domicilio,domicilio.piso,domicilio.departamento,domicilio.ciudad,domicilio.codigo_postal,domicilio.codigo_provincia " +
                "    FROM  " +
                "    (  " +
                "        (SELECT pedidos.[numero_pedido],[codigo_tipo_pedido],[fecha],[alicuota],[monto_subtotal],[monto_total],[observaciones], " +
                "                Pedidos_Personas.[codigo_entidad],Pedidos_Personas.[razon_social_entidad], " +
                "                [numero_comprobante],[cae],[vencimiento_cae],[aprobado_afip],[nombre_entidad],[apellido_entidad], " +
                "                [codigo_documento],[numero_documento_entidad],[codigo_comprobante], "+
                "               pedidos.[descuento_1_monto], pedidos.[descuento_2_monto],[estado] " +
                "            FROM pedidos, Pedidos_Personas  " +
                "            WHERE pedidos.numero_pedido = Pedidos_Personas.numero_pedido  " +
                "        )  " +
                "    UNION  " +
                "        (SELECT pedidos.[numero_pedido],[codigo_tipo_pedido],[fecha],[alicuota],[monto_subtotal],[monto_total],Pedidos.[observaciones], " +
                "                Pedidos_Proveedores.[codigo_entidad], Proveedores.razon_social as [razon_social_entidad]," +
                "                NULL as [numero_comprobante],NULL as [cae],NULL as [vencimiento_cae],NULL as [aprobado_afip],NULL as [nombre_entidad],NULL as [apellido_entidad], " +
                "                NULL as [codigo_documento],Entidades.cuit as [numero_documento_entidad],NULL as [codigo_comprobante], " +
                "               pedidos.[descuento_1_monto], pedidos.[descuento_2_monto], NULL as [estado] " +
                "            FROM pedidos, Pedidos_Proveedores, Proveedores, Entidades    " +
                "            WHERE pedidos.numero_pedido = pedidos_proveedores.numero_pedido  " +
                "                   AND Pedidos_Proveedores.codigo_entidad= Proveedores.codigo_entidad" +
                "                   AND Proveedores.codigo_entidad = Entidades.codigo "+
                "        )  " +
                "    ) as tbl " +
                "inner join Mails_Pedido mail " +
                "on mail.numero_pedido = tbl.numero_pedido " +
                "inner join Telefonos_Pedido telefono " +
                "on telefono.numero_pedido = tbl.numero_pedido " +
                "inner join Domicilios_Pedido domicilio " +
                "on domicilio.numero_pedido = tbl.numero_pedido " +
                "   WHERE " + querySQL;

            comando.Connection.Open();
            try
            {
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

                CatalogoProveedores lcl_cat_proveedores = new CatalogoProveedores();
                foreach (ModeloPedido p in lcl_mod_pedidosEncontrados)
                {
                    if (p.codigoTipoPedido == Constantes.CodigosTiposPedidos.Proveedor)
                    {
                        p.entidad = lcl_cat_proveedores.getOne(p.entidad.codigo);
                    }
                    this.getProvincia(p);
                }

                return lcl_mod_pedidosEncontrados;
            }
            catch (Exception ex)
            {
                return new List<ModeloPedido>();
            }
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

        public int getUltimoNumero(int p_codigo_tipo_pedido)
        {
            int numero = 0;
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "SELECT MAX(numero_pedido_tipo) as Mayor " +
                "FROM [Pedidos] WHERE codigo_tipo_pedido=@codigo_tipo_pedido ";
                
            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro(p_codigo_tipo_pedido, "@codigo_tipo_pedido"));
            
            comando.Connection.Open();
            SqlDataReader drPedidos = comando.ExecuteReader();
            while (drPedidos.Read())
            {
                numero = (int)drPedidos["Mayor"]; ;
            }
            comando.Connection.Close();

            return numero+1;
            

        }

        #endregion

        #region Reportes
        private ModeloReporteEncabezado getDatosReporte(SqlCommand comando, List<DateTime> p_periodos, ModeloEntidad p_entidad)
        {
            comando.Parameters.Add(this.instanciarParametro(p_periodos[0].Date, "@fecha_desde"));
            comando.Parameters.Add(this.instanciarParametro(p_periodos[1].Date, "@fecha_hasta"));
            comando.Parameters.Add(this.instanciarParametro(p_entidad.codigo, "@codigo_entidad"));
            comando.Connection.Open();
            SqlDataReader drPedidosEntreFechas = comando.ExecuteReader();

            ModeloReporteEncabezado lcl_mod_ReporteEncabezado = new ModeloReporteEncabezado()
            {
                FechaDesde = p_periodos[0],
                FechaHasta = p_periodos[1],
                PersonaDesde = p_entidad.codigo.ToString(),
                PersonaHasta = p_entidad.codigo.ToString(),
                FechaInforme = DateTime.Today
            };

            ModeloReporteDetalle_Pedidos lcl_mod_detalle = new ModeloReporteDetalle_Pedidos();
            while (drPedidosEntreFechas.Read())
            {
                lcl_mod_detalle = new ModeloReporteDetalle_Pedidos();

                lcl_mod_detalle.codigoEntidad = (int)drPedidosEntreFechas["codigo_entidad"];
                lcl_mod_detalle.descripcionEntidad = (string)drPedidosEntreFechas["descripcion_entidad"];
                lcl_mod_detalle.cantidadArticulos = (int)drPedidosEntreFechas["cantidad_articulos"];
                lcl_mod_detalle.cantidadPedidos = (int)drPedidosEntreFechas["cantidad_pedidos"];
                lcl_mod_detalle.montoTotal = (decimal)drPedidosEntreFechas["monto_total"];

                lcl_mod_ReporteEncabezado.detallePedido.Add(lcl_mod_detalle);
                lcl_mod_ReporteEncabezado.MontoTotal += lcl_mod_detalle.montoTotal;
            }
            drPedidosEntreFechas.Close();

            comando.Connection.Close();

            return lcl_mod_ReporteEncabezado;
        }
        private string getQueryReportePedidos(Constantes.Reportes.Clientes p_reporte, ModeloEntidad p_entidad, int p_cantidad)
        {
            string entidadQuery = "";
            string topCantidadQuery = "";
            if (p_entidad != null && p_entidad.codigo != 0)
            {
                entidadQuery = " AND Entidades.codigo=@codigo_entidad ";
            }
            else
            {
                if (p_cantidad > 0)
                {
                    topCantidadQuery = " TOP " + p_cantidad.ToString() + " ";
                }
            }
            string query =
                "SELECT " + topCantidadQuery +
                "   Entidades.codigo AS codigo_entidad, " +
                "   CASE WHEN Personas.razon_social is null THEN CONCAT(Personas.apellido, ', ', Personas.nombre) ELSE Personas.razon_social END as descripcion_entidad," +//ponemos la razon social del cliente, si existe
                "   COUNT(pedidos.numero_pedido) as cantidad_pedidos,SUM(cantidad) as cantidad_articulos," +
                "   SUM(Lineas_Pedidos.valor_parcial) as monto_total " +
                "FROM Pedidos " +
                "   INNER JOIN Lineas_Pedidos ON Pedidos.numero_pedido = Lineas_Pedidos.numero_pedido " +
                "   INNER JOIN Pedidos_Personas ON Pedidos_Personas.numero_pedido= Pedidos.numero_pedido " +
                "   INNER JOIN Entidades ON Entidades.codigo= Pedidos_Personas.codigo_entidad " +
                "   INNER JOIN Personas ON Personas.codigo_entidad= Entidades.codigo " +
                "WHERE Pedidos.fecha BETWEEN  @fecha_desde AND @fecha_hasta " +
                entidadQuery +
                "GROUP BY Entidades.codigo, Personas.apellido, personas.nombre, Personas.razon_social";

            string frecuenciaPedidos = " COUNT(pedidos.numero_pedido) DESC ";
            string montoPedidos = " SUM(Lineas_Pedidos.valor_parcial) DESC ";
            switch (p_reporte)
            {
                case Constantes.Reportes.Clientes.FrecuenciaDePedidos:
                    query += " ORDER BY " + frecuenciaPedidos + "," + montoPedidos;  //por si hay valores iguales en frecuencia, ordenamos por cantidad
                    break;
                case Constantes.Reportes.Clientes.MontoTotalDePedidos:
                    query += " ORDER BY " + montoPedidos + "," + frecuenciaPedidos;
                    break;
                //case Constantes.Reportes.Clientes.PedidosMasElevados:
                //    break;
                default:
                    break;
            }
            return query;
        }
        public ModeloReporteEncabezado getReporte(Constantes.Reportes.Clientes p_reporte, List<DateTime> p_periodos, ModeloEntidad p_entidad, int p_cantidad)
        {
            SqlCommand comando = Conexion.crearComando();

            comando.CommandText = this.getQueryReportePedidos(p_reporte, p_entidad, p_cantidad);

            return this.getDatosReporte(comando, p_periodos, p_entidad);
        }
        private string getQueryReportePedidos(Constantes.Reportes.Proveedores p_reporte, ModeloEntidad p_entidad, int p_cantidad)
        {
            string entidadQuery = "";
            string topCantidadQuery = "";
            if (p_entidad != null && p_entidad.codigo != 0)
            {
                entidadQuery = " AND Entidades.codigo=@codigo_entidad ";
            }
            else
            {
                if (p_cantidad > 0)
                {
                    topCantidadQuery = " TOP " + p_cantidad.ToString() + " ";
                }
            }

            string query =
            "SELECT " + topCantidadQuery +
            "   Entidades.codigo AS codigo_entidad, Proveedores.razon_social as descripcion_entidad," +
            "   COUNT(pedidos.numero_pedido) as cantidad_pedidos,SUM(cantidad) as cantidad_articulos," +
            "   SUM(Lineas_Pedidos.valor_parcial) as monto_total " +
            "FROM Pedidos " +
            "   INNER JOIN Lineas_Pedidos ON Pedidos.numero_pedido = Lineas_Pedidos.numero_pedido " +
            "   INNER JOIN Pedidos_Proveedores ON Pedidos_Proveedores.numero_pedido= Pedidos.numero_pedido " +
            "   INNER JOIN Entidades ON Entidades.codigo= Pedidos_Proveedores.codigo_entidad " +
            "   INNER JOIN Proveedores ON Proveedores.codigo_entidad= Entidades.codigo " +
            "WHERE Pedidos.fecha BETWEEN  @fecha_desde AND @fecha_hasta " +
            entidadQuery +
            "GROUP BY Entidades.codigo, Proveedores.razon_social ";

            string frecuenciaPedidos = " COUNT(pedidos.numero_pedido) DESC ";
            string montoPedidos = " SUM(Lineas_Pedidos.valor_parcial) DESC ";
            switch (p_reporte)
            {
                case Constantes.Reportes.Proveedores.FrecuenciaDePedidos:
                    query += " ORDER BY "+frecuenciaPedidos+","+montoPedidos ;  //por si hay valores iguales en frecuencia, ordenamos por cantidad
                    break;
                case Constantes.Reportes.Proveedores.MontoTotalDePedidos:
                    query += " ORDER BY " + montoPedidos + "," + frecuenciaPedidos;
                    break;
                //case Constantes.Reportes.Proveedores.PedidosMasElevados:
                //    break;
                default:
                    break;
            }
            return query;
        }
        public ModeloReporteEncabezado getReporte(Constantes.Reportes.Proveedores p_reporte, List<DateTime> p_periodos, ModeloEntidad p_entidad, int p_cantidad)
        {
            SqlCommand comando = Conexion.crearComando();

            comando.CommandText = this.getQueryReportePedidos(p_reporte, p_entidad, p_cantidad);

            return this.getDatosReporte(comando, p_periodos, p_entidad);
        }

        private ModeloReporteEncabezado getDatosReporte(SqlCommand comando,List<DateTime> p_periodos)
        {
            ModeloReporteEncabezado lcl_mod_ReporteEncabezadoArticulos = new ModeloReporteEncabezado();
            if (p_periodos != null && p_periodos.Count == 2)
            {
                comando.Parameters.Add(this.instanciarParametro(p_periodos[0].Date, "@fecha_desde"));
                comando.Parameters.Add(this.instanciarParametro(p_periodos[1].Date, "@fecha_hasta"));

                lcl_mod_ReporteEncabezadoArticulos.FechaDesde = p_periodos[0];
                lcl_mod_ReporteEncabezadoArticulos.FechaHasta = p_periodos[1];
            }

            comando.Connection.Open();

            SqlDataReader drTop10Articulos = comando.ExecuteReader();

            ModeloReporteDetalle_Articulos lcl_var_TopArticulos;
            while (drTop10Articulos.Read())
            {
                lcl_var_TopArticulos = new ModeloReporteDetalle_Articulos();
                lcl_var_TopArticulos.cantidadArticulos = (int)drTop10Articulos["cantidad_articulos"];
                lcl_var_TopArticulos.cantidadDeVentas = (int)drTop10Articulos["cantidad_ventas"];
                lcl_var_TopArticulos.codigoArticulo = (string)drTop10Articulos["codigo_articulo"];
                lcl_var_TopArticulos.precioPromedioVenta = (decimal)drTop10Articulos["precio_promedio"];

                lcl_mod_ReporteEncabezadoArticulos.MontoTotal += (lcl_var_TopArticulos.cantidadArticulos * lcl_var_TopArticulos.precioPromedioVenta);
                lcl_mod_ReporteEncabezadoArticulos.detalleArticulos.Add(lcl_var_TopArticulos);
            }
            drTop10Articulos.Close();

            comando.Connection.Close();

            return lcl_mod_ReporteEncabezadoArticulos;
        }
        private string getQueryReporteArticulos(Constantes.Reportes.Articulos p_reporte, int p_cantidad)
        {
            string topCantidadQuery = "";
            if (p_cantidad > 0)
            {
                topCantidadQuery = " TOP " + p_cantidad.ToString() + " ";
            }

            string query = "";
            switch (p_reporte)
            {
                case Constantes.Reportes.Articulos.ArticulosMasVendidos:
                    query =
                        "SELECT " + topCantidadQuery +
                        "Articulos.codigo_original AS codigo_articulo,SUM(CANTIDAD) AS cantidad_articulos, " +
                        "AVG(valor_unitario) AS precio_promedio,COUNT(DISTINCT PEDIDOS.numero_pedido) AS cantidad_ventas " +
                        "FROM Pedidos  " +
                        "INNER JOIN Lineas_Pedidos ON Pedidos.numero_pedido = Lineas_Pedidos.numero_pedido " +
                        "INNER JOIN Articulos ON Articulos.codigo_original=Lineas_Pedidos.codigo_original " +
                        "WHERE Pedidos.fecha BETWEEN @fecha_desde AND @fecha_hasta " +
                        "   AND Pedidos.codigo_tipo_pedido = "+((int)Constantes.CodigosTiposPedidos.Persona).ToString()+" "+
                        "GROUP BY Articulos.codigo_original "+
                        "ORDER BY COUNT(DISTINCT PEDIDOS.numero_pedido) DESC ";
                    break;
                case Constantes.Reportes.Articulos.DescuentosVigentes:
                    break;
                case Constantes.Reportes.Articulos.InformeStock:
                    break;
            }
            
            return query;
        }
        public ModeloReporteEncabezado getReporte(Constantes.Reportes.Articulos p_reporte, List<DateTime> p_periodos, int p_cantidad)
        {
            SqlCommand comando = Conexion.crearComando();

            comando.CommandText = this.getQueryReporteArticulos(p_reporte, p_cantidad);

            return this.getDatosReporte(comando,p_periodos);
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
                case Constantes.CodigosTiposPedidos.Persona:
                    return " Pedidos_Personas ";
                case Constantes.CodigosTiposPedidos.Proveedor:
                    return " Pedidos_Proveedores ";
                default:
                    return "";
            }
        }
        public bool add(ref ModeloPedido p_mod_pedido)
        {
            
            SqlCommand comando = Conexion.crearComando(); 

            comando.CommandText =
            "INSERT INTO [pedidos](codigo_tipo_pedido,fecha,alicuota,monto_subtotal,monto_total,observaciones, "+
            "   senia, descuento_1_monto, descuento_1_porcentaje, descuento_2_monto, descuento_2_porcentaje,numero_pedido_tipo, "+
            "   descuento_lineas_monto, descuento_lineas_porcentaje, descuento_total_monto, descuento_total_porcentaje) " +
            "   OUTPUT INSERTED.NUMERO_PEDIDO " +
            "   VALUES (@codigo_tipo_pedido,@fecha, @alicuota,@monto_subtotal,@monto_total, @observaciones, "+
            "   @senia, @descuento_1_monto, @descuento_1_porcentaje, @descuento_2_monto, @descuento_2_porcentaje,@numero_pedido_tipo, " +
            "   @descuento_lineas_monto, @descuento_lineas_porcentaje, @descuento_total_monto, @descuento_total_porcentaje) ";

            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro((int)p_mod_pedido.codigoTipoPedido, "@codigo_tipo_pedido"));
            comando.Parameters.Add(this.instanciarParametro(this.getUltimoNumero((int)p_mod_pedido.codigoTipoPedido), "@numero_pedido_tipo"));
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
            
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.getDescuentoLineas(), "@descuento_lineas_monto"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.getDescuentoLineasPorcentaje(), "@descuento_lineas_porcentaje"));
            
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.getDescuentoTotal(), "@descuento_total_monto"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.getDescuentoTotalPorcentaje(), "@descuento_total_porcentaje"));

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

            if (p_mod_pedido.codigoTipoPedido == Constantes.CodigosTiposPedidos.Persona)
            {
                rowsAffected = this.addPedidoCliente(comando,p_mod_pedido);
            }
            else if (p_mod_pedido.codigoTipoPedido == Constantes.CodigosTiposPedidos.Proveedor)
            {
                rowsAffected = this.addPedidoProveedor(comando, p_mod_pedido);
            }
            else
            {
                //return false?
                throw new Exception("Ha ocurrido un error al intentar registrar el Pedido actual. No se ha detectado el tipo de pedido.");
            }

            bool datosAdicionalesAgregados = this.addPedido_DatosAdicionales(comando, p_mod_pedido);
            comando.Connection.Close();
            
            if (rowsAffected == 1 && datosAdicionalesAgregados)
            {
                return true;
            }
            else
            {
                //return false?
                throw new Exception("Ha ocurrido un error al intentar registrar el Pedido actual.");
            }
            
            
        }

        private bool addPedido_DatosAdicionales(SqlCommand p_comando, ModeloPedido p_mod_pedido)
        {
            int rowsAffected = 0;

            if (p_mod_pedido.domicilioDeFacturacion == null)
            {
                p_mod_pedido.domicilioDeFacturacion = new ModeloDomicilio();
                //p_mod_pedido.domicilioDeFacturacion.provincia = new ModeloProvincia();
            }
            p_comando.CommandText =
                "INSERT INTO Domicilios_Pedido "+
                "   (numero_pedido,calle,numero,piso,departamento,ciudad,codigo_postal,codigo_provincia) "+
                "   VALUES (@numero_pedido,@calle,@numero,@piso,@departamento,@ciudad,@codigo_postal,@codigo_provincia) ";
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.numeroPedido, "@numero_pedido"));
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.domicilioDeFacturacion.calle, "@calle"));
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.domicilioDeFacturacion.numero, "@numero"));
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.domicilioDeFacturacion.piso, "@piso"));
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.domicilioDeFacturacion.departamento, "@departamento"));
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.domicilioDeFacturacion.ciudad, "@ciudad"));
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.domicilioDeFacturacion.codigoPostal, "@codigo_postal"));
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.domicilioDeFacturacion.provincia.codigo, "@codigo_provincia"));
            rowsAffected += p_comando.ExecuteNonQuery();

            if (p_mod_pedido.mailContacto == null)
            {
                p_mod_pedido.mailContacto = new ModeloMail();
            }
            p_comando.CommandText =
                "INSERT INTO Mails_Pedido " +
                "   (numero_pedido,mail) " +
                "   VALUES (@numero_pedido,@mail)";
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.mailContacto.mail, "@mail"));
            rowsAffected += p_comando.ExecuteNonQuery();

            if (p_mod_pedido.telefonoContacto == null)
            {
                p_mod_pedido.telefonoContacto = new ModeloTelefono();
            }
            p_comando.CommandText =
                "INSERT INTO Telefonos_pedido "+
                "   (numero_pedido,numero,tipo)"+
                "   VALUES(@numero_pedido,@numero_telefono,@tipo_telefono)";
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.telefonoContacto.numero,"@numero_telefono"));
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.telefonoContacto.tipo,"@tipo_telefono"));
            rowsAffected += p_comando.ExecuteNonQuery();

            return rowsAffected == 3;
        }

        private int addPedidoCliente(SqlCommand p_comando,ModeloPedido p_mod_pedido)
        {
            p_comando.CommandText =
           "INSERT INTO  Pedidos_Personas  (numero_pedido,numero_comprobante,cae,vencimiento_cae,aprobado_afip,codigo_entidad,nombre_entidad,apellido_entidad,"+
           "    razon_social_entidad,codigo_documento,numero_documento_entidad,codigo_comprobante, estado) " +
           "    VALUES( @numeroPedidoActual,@numero_comprobante,@cae,@vto_cae,@aprobado_afip,@codigo_entidad,@nombre_entidad,@apellido_entidad," +
           "    @razon_social_entidad,@codigo_documento,@numero_documento_entidad,@codigo_comprobante, @estado) ";
            
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.numeroPedido, "@numeroPedidoActual"));
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.numeroComprobante, "@numero_comprobante"));
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.CAE, "@cae"));
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.VencimientoCAE, "@vto_cae"));
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.aprobadoAFIP, "@aprobado_afip"));
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.entidad.codigo, "@codigo_entidad"));
            p_comando.Parameters.Add(this.instanciarParametro((p_mod_pedido.entidad as ModeloCliente).nombre, "@nombre_entidad"));
            p_comando.Parameters.Add(this.instanciarParametro((p_mod_pedido.entidad as ModeloCliente).apellido, "@apellido_entidad"));
            p_comando.Parameters.Add(this.instanciarParametro((p_mod_pedido.entidad as ModeloCliente).razonSocial, "@razon_social_entidad"));
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.documentoComprador.tipo.codigo, "@codigo_documento"));
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.documentoComprador.numero, "@numero_documento_entidad"));
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.tipoComprobante, "@codigo_comprobante"));
            p_comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.estado, "@estado"));
            

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

        public bool updateAprobadoAFIP(ModeloPedido p_mod_pedido)
        {
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "UPDATE [pedidos_Personas] " +
                "SET aprobado_afip=@aprobado_afip, " +
                "   cae=@cae,"+
                "   vencimiento_cae=@vencimiento_cae," +
                "   numero_comprobante=@numero_comprobante  " +
                "WHERE [pedidos_Personas].numero_pedido=@numero_pedido";

            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.aprobadoAFIP, "@aprobado_afip"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.numeroPedido, "@numero_pedido"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.CAE,"@cae"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.VencimientoCAE.Date,"@vencimiento_cae"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.numeroComprobante, "@numero_comprobante"));

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
        public bool updatePedidoEstado(ModeloPedido p_mod_pedido)
        {
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "UPDATE [pedidos_personas] " +
                "SET estado=@estado " +
                "WHERE [pedidos_personas].numero_pedido=@numero_pedido";

            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro(p_mod_pedido.estado, "@estado"));
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
