using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloReporteEncabezadoComprobante
    {

        public List<ModeloReporteDetalleComprobante> detalleFactura {get;set;}
        public string Comprador_RazonSocial { get; set; }
        public string Comprador_Domicilio { get; set; }
        public string Comprador_Mail { get; set; }
        public string Comprador_Telefono { get; set; }
        public string Comprador_Cuit { get; set; }
        public string Comprador_IVAResponsableI { get; set; }
        public string Remito { get; set; }
        public string CentroEmisor { get; set; }
        public string NumeroComprobante { get; set; }
        public int NumeroControl { get; set; }
        public DateTime FechaComprobante { get; set; }
        public decimal SubtotalComprobante { get; set; }
        public decimal IVAComprobante { get; set; }
        public decimal ConceptosNoGravados { get; set; }
        public decimal Alicuota { get; set; }
        public decimal TotalComprobante { get; set; }
        public string TotalComprobanteLetras { get; set; }
        public string CAINumero { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string CondicionVenta { get; set; }
        public string CodigodeBarras { get; set; }
        public string CodigodeBarrasImagen { get; set; }
        public string CuitEmisor { get; set; }
        public string CopiaComprobante { get; set; }

        public ModeloReporteEncabezadoComprobante(ModeloPedido p_mod_pedido) 
        {
            this.setDatosBasicosComprobante(p_mod_pedido);
            this.setDatosReceptorComprobante(p_mod_pedido);
            this.setDetalleFactura(p_mod_pedido);
            this.setMontos(p_mod_pedido);
        }

        private void setDatosBasicosComprobante(ModeloPedido p_mod_pedido)
        {
            this.Alicuota = Convert.ToDecimal(p_mod_pedido.alicuota.iva.porcentaje);
            this.CAINumero = p_mod_pedido.CAE;
            //this.CodigodeBarras = LibreriaClasesCompartidas.Transformar.imagenCodigoBarras(p_mod_pedido.getCodigoBarraCAE());
            string codigoBarrasCAE = p_mod_pedido.getCodigoBarraCAE();
            this.CodigodeBarras = codigoBarrasCAE == null ? codigoBarrasCAE : LibreriaClasesCompartidas.Transformar.codigoBarras(codigoBarrasCAE.ToCharArray());
            //this.CodigodeBarras = LibreriaClasesCompartidas.Transformar.codigoBarras(p_mod_pedido.getCodigoBarraCAE().ToCharArray());//Codigo de barra luego del algoritmo
            //this.CodigodeBarrasImagen = LibreriaClasesCompartidas.Interleaved2of5.gifInterleaved(p_mod_pedido.getCodigoBarraCAE());
            this.CodigodeBarrasImagen = this.CodigodeBarras == null ? this.CodigodeBarras : LibreriaClasesCompartidas.Transformar.imagenCodigoBarras(this.CodigodeBarras);
            this.CuitEmisor = ModeloPedido.cuitEmisor;
            this.CentroEmisor = "0001";//p_mod_pedido.numeroComprobanteAFIP;
            this.NumeroComprobante = (p_mod_pedido.numeroComprobanteAFIP != null) ? p_mod_pedido.numeroComprobanteAFIP.PadLeft(8, '0') : null;
            this.NumeroControl = p_mod_pedido.numeroPedido;
            //lcl_mod_Factura.ConceptosNoGravados = p_mod_pedido.
            this.CondicionVenta = (p_mod_pedido.formasDePago != null) ? p_mod_pedido.formasDePago[0].forma.ToString() : null;
            this.FechaComprobante = p_mod_pedido.fecha;
            this.FechaVencimiento = p_mod_pedido.VencimientoCAE;
            //this.Remito = p_mod_pedido.numeroPedido.ToString().PadLeft(8,'0');
            this.Remito = (p_mod_pedido.numeroComprobante > 0) ? p_mod_pedido.numeroComprobante.ToString().PadLeft(8, '0') : null;
            this.CopiaComprobante = p_mod_pedido.copiaComprobante;
        }

        /// <summary>
        /// Receptor comprobante ya sea Cliente o Proveedor
        /// </summary>
        /// <param name="p_mod_pedido"></param>
        private void setDatosReceptorComprobante(ModeloPedido p_mod_pedido)
        {
            //por que se hace esta validación con el cuit de la entidad si ya tenemos el documentoComprador en el pedido?
            this.Comprador_Cuit = (p_mod_pedido.entidad.cuit != null) ? p_mod_pedido.entidad.cuit : p_mod_pedido.documentoComprador.numero;
            this.Comprador_IVAResponsableI = GetSituacionIVA((int)p_mod_pedido.entidad.codigoTipoResponsable);
            this.Comprador_Domicilio = p_mod_pedido.domicilioDeFacturacion == null ? "Sin Domicilio" : p_mod_pedido.domicilioDeFacturacion.ToString();
            this.Comprador_Mail = p_mod_pedido.mailContacto == null?"Sin Mail":p_mod_pedido.mailContacto.mail;
            this.Comprador_Telefono = p_mod_pedido.telefonoContacto == null? "Sin Teléfono":p_mod_pedido.telefonoContacto.numero;


            this.Comprador_RazonSocial = p_mod_pedido.entidad.ToString();
        }
        /// <summary>
        /// Carga artículos y descuentos del pedido
        /// </summary>
        /// <param name="p_mod_pedido"></param>
        private void setDetalleFactura(ModeloPedido p_mod_pedido)
        {
            this.detalleFactura = new List<ModeloReporteDetalleComprobante>();
            foreach (ModeloLineaPedido lp in p_mod_pedido.lineasPedido)
            {
                this.detalleFactura.Add(new ModeloReporteDetalleComprobante(lp));
                if (lp.descuentos.Count > 0)
                {
                    decimal monto = 0;
                    string motivos = "";
                    foreach (ModeloDescuentoLineaPedido d in lp.descuentos)
                    {
                        motivos = motivos + " - " + d.descripcion;
                        monto = monto + d.montoDescontadoSobreTotal;
                        // this.detalleFactura.Add(new ModeloReporteDetalleComprobante(lp.articulo,d));
                    }
                    this.detalleFactura.Add(new ModeloReporteDetalleComprobante(new ModeloLineaPedido(monto, motivos, lp.articulo.codigoArticuloProveedor)));
                }
            }
            if (p_mod_pedido.descuentos.descuento_total_monto > 0)
            {
                this.detalleFactura.Add((this.agregaLineaDescuentoGlobal(p_mod_pedido.descuentos.descuento_total_monto)));
            }
        }
        /// <summary>
        /// Datos monetarios (iva, subtotales, totales)
        /// </summary>
        /// <param name="p_mod_pedido"></param>
        private void setMontos(ModeloPedido p_mod_pedido)
        {
            this.IVAComprobante = p_mod_pedido.alicuota.monto;
            this.SubtotalComprobante = p_mod_pedido.montoSubTotal;
            this.TotalComprobante = p_mod_pedido.montoTotal;
            this.TotalComprobanteLetras = LibreriaClasesCompartidas.Transformar.NumeroALetras(p_mod_pedido.montoTotal.ToString());
        }

        public ModeloReporteDetalleComprobante agregaLineaDescuentoGlobal(decimal p_montoDescuento)
        {
            return new ModeloReporteDetalleComprobante(new ModeloLineaPedido(p_montoDescuento));
        }
      
        public static string GetSituacionIVA(int p_situacionIVA)
        {
            string situacion = "";
            switch (p_situacionIVA)
            {
                case 5: situacion = "Consumidor Final"; break;
                case 6: situacion = "Monotributista"; break;
                case 1: situacion = "Responsable Inscripto"; break;
                default: situacion = "Consumidor Final"; break;
            }

            return situacion;
        }
    }
}
