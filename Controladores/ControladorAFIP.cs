using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSAFIPFE;
using Modelos;

namespace Controladores
{
    public class ControladorAFIP
    {
        public static string facturarTEST()
        {
            #region variables del certificado
            string afipFolderPath = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\AFIP";
            string certificadoPath = afipFolderPath + @"\certificado.pfx";
            string passwordCertificado = "prueba123";
            string cuitEmisor = "20356445393"; //Debe ser el mismo cuit que el que está en el certificado
            #endregion

            string respuesta = "éxito";
            WSAFIPFE.Factura fe = new WSAFIPFE.Factura();
            Boolean bResultado = fe.iniciar(0, cuitEmisor, certificadoPath, ""); //0 modo homologación, 1 en producción. Sólo usar 0
            if (bResultado)
            {
                fe.ArchivoCertificadoPassword = passwordCertificado;
                bResultado = fe.f1ObtenerTicketAcceso();
                if (bResultado)
                {
                    fe.F1CabeceraCantReg = 1;
                    fe.F1CabeceraPtoVta = 1;
                    fe.F1CabeceraCbteTipo = 1;

                    fe.f1Indice = 0;
                    fe.F1DetalleConcepto = 1;
                    fe.F1DetalleDocTipo = 80;
                    fe.F1DetalleDocNro = "20111111112";
                    fe.F1DetalleCbteDesde = fe.F1CompUltimoAutorizado(fe.F1CabeceraPtoVta, fe.F1CabeceraCbteTipo) + 1;
                    fe.F1DetalleCbteHasta = fe.F1CompUltimoAutorizado(fe.F1CabeceraPtoVta, fe.F1CabeceraCbteTipo) + 1;
                    fe.F1DetalleCbteFch = DateTime.Today.ToString("yyyyMMdd");
                    fe.F1DetalleImpTotal = 176.25;
                    fe.F1DetalleImpTotalConc = 0;
                    fe.F1DetalleImpNeto = 150;
                    fe.F1DetalleImpOpEx = 0;
                    //fe.F1DetalleImpTrib = 7.8;
                    fe.F1DetalleImpIva = 26.25;
                    //fe.F1DetalleFchServDesde = "20150315";
                    //fe.F1DetalleFchVtoPago = "20150315";
                    fe.F1DetalleMonId = "PES";//Moneda en PESOS ARGENTINOS
                    fe.F1DetalleMonCotiz = 1;//1 debido a que es pesos

                    //fe.F1DetalleTributoItemCantidad = 0;
                    //fe.f1IndiceItem = 0;
                    //fe.F1DetalleTributoId = 3;
                    //fe.F1DetalleTributoDesc = "Impuesto Municipal Matanza";
                    //fe.F1DetalleTributoBaseImp = 150;
                    //fe.F1DetalleTributoAlic = 5.2;
                    //fe.F1DetalleTributoImporte = 7.8;

                    fe.F1DetalleIvaItemCantidad = 2;
                    fe.f1IndiceItem = 0;
                    fe.F1DetalleIvaId = 5;
                    fe.F1DetalleIvaBaseImp = 100;
                    fe.F1DetalleIvaImporte = 21;

                    fe.f1IndiceItem = 1;
                    fe.F1DetalleIvaId = 4;
                    fe.F1DetalleIvaBaseImp = 50;
                    fe.F1DetalleIvaImporte = 5.25;


                    fe.F1DetalleCbtesAsocItemCantidad = 0;
                    fe.F1DetalleOpcionalItemCantidad = 0;

                    fe.ArchivoXMLRecibido = afipFolderPath + @"\XML\recibido.xml";
                    fe.ArchivoXMLEnviado = afipFolderPath + @"\XML\enviado.xml";
                    bResultado = fe.F1CAESolicitar();
                    if (bResultado)
                    {
                        respuesta = "resultado verdadero ";
                    }
                    else
                    {
                        respuesta = "resultado falso ";
                    }
                    respuesta +=" | "+ "resultado global AFIP: " + fe.F1RespuestaResultado;
                    respuesta +=" | "+ "es reproceso? " + fe.F1RespuestaReProceso;
                    respuesta +=" | "+ "registros procesados por AFIP: " + fe.F1RespuestaCantidadReg.ToString();
                    respuesta +=" | "+ "error genérico global:" + fe.f1ErrorMsg1;
                    if (fe.F1RespuestaCantidadReg > 0)
                    {
                        fe.f1Indice = 0;
                        respuesta +="|"+ "resultado detallado comprobante: " + fe.F1RespuestaDetalleResultado;
                        respuesta +="|"+ "cae comprobante: " + fe.F1RespuestaDetalleCae;
                        respuesta +="|"+ "número comprobante:" + fe.F1RespuestaDetalleCbteDesdeS;
                        respuesta +="|"+ "error detallado comprobante: " + fe.F1RespuestaDetalleObservacionMsg1;
                    }
                }
                else
                {
                    respuesta = "fallo acceso " + fe.UltimoMensajeError;
                }
            }
            else
            {
                respuesta = "error inicio " + fe.UltimoMensajeError;
            }
            return respuesta;
        }

        public static string facturar(ModeloPedido p_mod_pedido)
        {
            #region variables del certificado
            string afipFolderPath = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\AFIP";
            string certificadoPath = afipFolderPath + @"\certificado.pfx"; 
            string passwordCertificado = "prueba123";
            string cuitEmisor = "20356445393"; //Debe ser el mismo cuit que el que está en el certificado
            #endregion 

            string respuesta ;
            WSAFIPFE.Factura fe = new WSAFIPFE.Factura();
            bool bResultado = fe.iniciar(0, cuitEmisor, certificadoPath, ""); //0 modo homologación, 1 en producción. Sólo usar 0
            if (bResultado)
            {
                fe.ArchivoCertificadoPassword = passwordCertificado;
                bResultado = fe.f1ObtenerTicketAcceso();
                if (bResultado)
                {
                    ControladorAFIP.inicializarConstantes(fe);
                    ControladorAFIP.agregarDetallesPedido(fe, p_mod_pedido);
                    try
                    {
                    int ultimoAutorizado = fe.F1CompUltimoAutorizado(fe.F1CabeceraPtoVta, fe.F1CabeceraCbteTipo);
                    
                    fe.F1DetalleCbteDesde = ultimoAutorizado + 1;
                    fe.F1DetalleCbteHasta = ultimoAutorizado + 1;
                    }
                    catch (System.Net.WebException ex)
                    {
                        return "Error: " + ex.Message;
                    }
                    ControladorAFIP.agregarItems(fe, p_mod_pedido);

                    fe.F1DetalleCbtesAsocItemCantidad = 0;
                    fe.F1DetalleOpcionalItemCantidad = 0;

                    fe.ArchivoXMLRecibido = afipFolderPath + @"\XML\recibido.xml";
                    fe.ArchivoXMLEnviado = afipFolderPath + @"\XML\enviado.xml";

                    bResultado = fe.F1CAESolicitar();
                    if (bResultado)
                    {
                        respuesta = "resultado verdadero ";
                    }
                    else
                    {
                        respuesta = "resultado falso ";
                    }
                    respuesta += " | " + "resultado global AFIP: " + fe.F1RespuestaResultado;
                    respuesta += " | " + "es reproceso? " + fe.F1RespuestaReProceso;
                    respuesta += " | " + "registros procesados por AFIP: " + fe.F1RespuestaCantidadReg.ToString();
                    respuesta += " | " + "error genérico global:" + fe.f1ErrorMsg1;
                    if (fe.F1RespuestaCantidadReg > 0)
                    {
                        fe.f1Indice = 0;
                        ControladorAFIP.cargarRespuestaEnPedido(fe, p_mod_pedido);
                        respuesta += "|" + "resultado detallado comprobante: " + p_mod_pedido.aprobadoAFIP;
                        respuesta += "|" + "cae comprobante: " + p_mod_pedido.CAE;
                        respuesta += "|" + "número comprobante:" + p_mod_pedido.numeroComprobante;
                        respuesta += "|" + "error detallado comprobante: " + fe.F1RespuestaDetalleObservacionMsg1;
                    }
                }
                else
                {
                    respuesta = "fallo acceso " + fe.UltimoMensajeError;
                }
            }
            else
            {
                respuesta = "error inicio " + fe.UltimoMensajeError;
            }
            return respuesta;
        }
        /// <summary>
        /// Agrega valores de items a factura electrónica. Se podría mejorar la parte de obtener iva
        /// </summary>
        /// <param name="p_facturaElectronica"></param>
        /// <param name="p_mod_pedido"></param>
        private static void agregarItems(WSAFIPFE.Factura p_facturaElectronica, ModeloPedido p_mod_pedido)
        {
            p_facturaElectronica.F1DetalleIvaItemCantidad = 1;
            p_facturaElectronica.f1IndiceItem = 0;
            p_facturaElectronica.F1DetalleIvaId = p_mod_pedido.alicuota.iva.codigo;//5=codigo correspondiente a iva de 21%
            p_facturaElectronica.F1DetalleIvaBaseImp = Math.Round((double)Math.Round(p_mod_pedido.montoTotal) / (1 + (p_mod_pedido.alicuota.iva.porcentaje / 100)), 2);
            p_facturaElectronica.F1DetalleIvaImporte = Math.Round(Math.Round((double)Math.Round(p_mod_pedido.montoTotal), 2) - p_facturaElectronica.F1DetalleIvaBaseImp, 2);

            //Se usaría un for() para cada iva distinto que haya para los productos o servicios. Como solo tratamos con productos de 21%, no lo usamos
            //int cantidadItems = p_mod_pedido.lineasPedido.Count;
            //p_facturaElectronica.F1DetalleIvaItemCantidad = cantidadItems;

            //for (int i = 0; i < cantidadItems; i++)
            //{
            //    p_facturaElectronica.f1IndiceItem = i;
            //    p_facturaElectronica.F1DetalleIvaBaseImp = Math.Round(((double)p_mod_pedido.lineasPedido[i].valorParcial) / (1 + (p_mod_pedido.alicuota.iva.porcentaje / 100)), 2);
            //    p_facturaElectronica.F1DetalleIvaImporte = Math.Round(Math.Round(Convert.ToDouble(p_mod_pedido.lineasPedido[i].valorParcial),2) - p_facturaElectronica.F1DetalleIvaBaseImp,2);
            //}
        }
        /// <summary>
        /// Inserta datos del pedido para ser enviados a web service de AFIP
        /// </summary>
        /// <param name="p_facturaElectronica"></param>
        /// <param name="p_mod_pedido"></param>
        private static void agregarDetallesPedido(WSAFIPFE.Factura p_facturaElectronica, ModeloPedido p_mod_pedido)
        {
            p_facturaElectronica.F1CabeceraCbteTipo = p_mod_pedido.tipoComprobante;

            p_facturaElectronica.F1DetalleDocTipo = p_mod_pedido.documentoComprador.tipo.codigo; 
            p_facturaElectronica.F1DetalleDocNro = p_mod_pedido.documentoComprador.numero;
            p_facturaElectronica.F1DetalleCbteFch = p_mod_pedido.fecha.ToString("yyyyMMdd"); //DateTime.Today.ToString("yyyyMMdd");
            p_facturaElectronica.F1DetalleImpTotal = (double)Math.Round(p_mod_pedido.montoTotal,2);
            p_facturaElectronica.F1DetalleImpTotalConc = 0;
            p_facturaElectronica.F1DetalleImpNeto = (double)Math.Round(p_mod_pedido.montoSubTotal,2);
            p_facturaElectronica.F1DetalleImpOpEx = 0;
            p_facturaElectronica.F1DetalleImpIva = (double)Math.Round(p_mod_pedido.alicuota.monto, 2);
        }
        /// <summary>
        /// Asigna los valores predeterminados y compartidos por toda facturación
        /// </summary>
        /// <param name="p_facturaElectronica"></param>
        private static void inicializarConstantes(WSAFIPFE.Factura p_facturaElectronica)
        {
            p_facturaElectronica.F1CabeceraCantReg = 1;//1=un comprobante,>1=registro en lote //Usar solamente 1
            p_facturaElectronica.F1CabeceraPtoVta = 1;//Se modifica en caso que haya más de un punto de venta del negocio

            p_facturaElectronica.f1Indice = 0;//se refiere al primer comprobante. Cambiaria si estaríamos en lotes
            p_facturaElectronica.F1DetalleConcepto = 1;//1=Productos,2=Servicios,3=Productos y Servicios //Usar solamente 1

            p_facturaElectronica.F1DetalleMonId = "PES";//Moneda en PESOS ARGENTINOS
            p_facturaElectronica.F1DetalleMonCotiz = 1;//1 debido a que es pesos
        }
        /// <summary>
        /// Carga respuesta de AFIP (CAE, aprobación y número de comprobante) en pedido
        /// </summary>
        /// <param name="p_facturaElectronica"></param>
        /// <param name="p_mod_pedido"></param>
        private static void cargarRespuestaEnPedido(WSAFIPFE.Factura p_facturaElectronica, ModeloPedido p_mod_pedido)
        {
            p_mod_pedido.aprobadoAFIP = p_facturaElectronica.F1RespuestaDetalleResultado;
            p_mod_pedido.CAE = p_facturaElectronica.F1RespuestaDetalleCae;
            p_mod_pedido.numeroComprobante = p_facturaElectronica.F1RespuestaDetalleCbteDesdeS;
        }
    }
}
