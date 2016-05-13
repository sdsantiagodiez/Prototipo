using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSAFIPFE;
using Modelos;

namespace Controladores
{
    public class ControladorAFIP : Controlador
    {
        string afipFolderPath;
        string certificadoPath;
        string passwordCertificado;
        string cuitEmisor;
        string ticketPath;

        public ControladorAFIP()
        {
            afipFolderPath = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\AFIP";
            certificadoPath = afipFolderPath + @"\certificado.pfx";
            passwordCertificado = "prueba123";
            cuitEmisor = "20356445393"; //Debe ser el mismo cuit que el que está en el certificado
            ticketPath = afipFolderPath + @"\ticket.txt";
        }
    
        public bool facturar(ModeloPedido p_mod_pedido)
        {
            string respuesta ;
            WSAFIPFE.Factura fe = new WSAFIPFE.Factura();
            bool bResultado = fe.iniciar(0, cuitEmisor, certificadoPath, ""); //0 modo homologación, 1 en producción. Sólo usar 0
            if (bResultado)
            {   
                if (this.getTicketAcceso(fe))
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
                        errorActual = "Error: " + ex.Message;
                    }
                    ControladorAFIP.agregarItems(fe, p_mod_pedido);

                    fe.F1DetalleCbtesAsocItemCantidad = 0;
                    fe.F1DetalleOpcionalItemCantidad = 0;

                    fe.ArchivoXMLRecibido = afipFolderPath + @"\XML\recibido.xml";
                    fe.ArchivoXMLEnviado = afipFolderPath + @"\XML\enviado.xml";

                    bResultado = fe.F1CAESolicitar();
                    if (bResultado)
                    {
                        respuesta = "Resultado verdadero ";
                        if(fe.F1RespuestaResultado == "A")
                        {
                            ControladorAFIP.cargarRespuestaEnPedido(fe, p_mod_pedido);
                            return true;
                        }
                    }
                    else
                    {
                        respuesta = "Resultado falso ";
                    }
                    respuesta += Environment.NewLine + "Resultado global AFIP: " + fe.F1RespuestaResultado;
                    respuesta += Environment.NewLine + "Es reproceso? " + fe.F1RespuestaReProceso;
                    respuesta += Environment.NewLine + "Registros procesados por AFIP: " + fe.F1RespuestaCantidadReg.ToString();
                    respuesta += Environment.NewLine + "Error genérico global:" + fe.f1ErrorMsg1;
                    if (fe.F1RespuestaCantidadReg > 0)
                    {
                        fe.f1Indice = 0;
                        ControladorAFIP.cargarRespuestaEnPedido(fe, p_mod_pedido);
                        respuesta += Environment.NewLine + "Resultado detallado comprobante: " + p_mod_pedido.aprobadoAFIP;
                        respuesta += Environment.NewLine + "CAE comprobante: " + p_mod_pedido.CAE;
                        respuesta += Environment.NewLine + "Número comprobante:" + p_mod_pedido.numeroComprobante;
                        respuesta += Environment.NewLine + "Error detallado comprobante: " + fe.F1RespuestaDetalleObservacionMsg1;

                        respuesta = this.getError(fe);
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

            errorActual = respuesta;
            return false;
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

        /// <summary>
        /// Válida conexión y ticket acceso para comunicarse con web services de AFIP
        /// </summary>
        /// <returns></returns>
        public bool validarConexion()
        {
            WSAFIPFE.Factura fe = new WSAFIPFE.Factura();
            if (fe.iniciar(0, cuitEmisor, certificadoPath, "") )//0 modo homologación, 1 en producción. Sólo usar 0
            {
                if (!this.getTicketAcceso(fe))
                {
                    this.errorActual = "No se ha podido conseguir ticket de acceso AFIP. Verifique su conexión a internet.";
                    return false;
                }
            }
            else
            {
                this.errorActual = "No se ha podido iniciar módulo de facturación electrónica";
                return false;
            }
            return true;
        }
      
        /// <summary>
        /// Guarda ticket de acceso en archivo para posterior uso
        /// </summary>
        /// <param name="p_facturaElectronica"></param>
        private void guardarTicketAcceso(WSAFIPFE.Factura p_facturaElectronica)
        {
            string ticket = p_facturaElectronica.f1GuardarTicketAcceso();
            System.IO.File.WriteAllText(ticketPath,ticket);
        }
        /// <summary>
        /// Retorna ticket de acceso guardado anteriormente
        /// </summary>
        /// <returns></returns>
        private string readTicketAcceso()
        {
            if (System.IO.File.Exists(ticketPath))
                return System.IO.File.ReadAllText(ticketPath);
            else
                return "";
        }
        /// <summary>
        /// Obtiene ticket de acceso para conectarse a web service AFIP.
        /// </summary>
        /// <param name="p_facturaElectronica"></param>
        /// <returns></returns>
        private bool getTicketAcceso(WSAFIPFE.Factura p_facturaElectronica)
        {
            bool bResultado = false;
            p_facturaElectronica.f1RestaurarTicketAcceso(this.readTicketAcceso());
            if (p_facturaElectronica.f1TicketEsValido)
            {
                bResultado = true;
            }
            else
            {
                p_facturaElectronica.ArchivoCertificadoPassword = passwordCertificado;
                bResultado = p_facturaElectronica.f1ObtenerTicketAcceso();
                this.guardarTicketAcceso(p_facturaElectronica);
            }
            return bResultado;
        }

        private string getError(WSAFIPFE.Factura p_facturaElectronica)
        {
            int codigoError;
            string mensajeError;
            if (p_facturaElectronica.f1ErrorCode != 0)
            { 
                codigoError = p_facturaElectronica.f1ErrorCode;
                mensajeError = p_facturaElectronica.f1ErrorMsg;
            }
            else 
            {
                codigoError = p_facturaElectronica.F1RespuestaDetalleObservacionCode;
                mensajeError = p_facturaElectronica.F1RespuestaDetalleObservacionMsg;
            }
            if (codigoError == 0)
            {
                return "";
            }

            switch (codigoError)
            {
                case 10015:
                    mensajeError = "Número de documento no se encuentra en padrones de AFIP.";
                    break;
                case 10016:
                    mensajeError = "La fecha indicada no es válida:";
                    mensajeError += Environment.NewLine + "-La fecha debe ser mayor o igual a la fecha del último comprobante de este tipo emitido.";
                    mensajeError += Environment.NewLine + "-La fecha debe ser comprendida en encontrarse dentro de los 5 días previos y posteriores al día de emisión.";
                    break;
                default:
                    break;
            }
            return "Código Error: "+ codigoError.ToString() + Environment.NewLine + mensajeError;
        }
    }
}
