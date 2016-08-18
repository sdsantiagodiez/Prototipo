﻿using System;
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
        public string Comprador_Cuit { get; set; }
        public string Comprador_IVAResponsableI { get; set; }
        public string Remito { get; set; }
        public string CentroEmisor { get; set; }
        public string NumeroComprobante { get; set; }
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
        public string CuitEmisor { get; set; }

        public ModeloReporteEncabezadoComprobante(ModeloPedido p_mod_pedido) 
        {
            // Carga en modelo Reportepedido Que hacemos si no esta aprobado, donde validamos?
            // Si no esta aprobado por afip, imprimimos igual
            
            this.detalleFactura = new List<ModeloReporteDetalleComprobante>();
            this.CAINumero = p_mod_pedido.CAE;
            this.CodigodeBarras = p_mod_pedido.getCodigoBarraCAE();
            this.Alicuota = Convert.ToDecimal(p_mod_pedido.alicuota.iva.porcentaje);
            this.CuitEmisor = ModeloPedido.cuitEmisor;
            this.CentroEmisor = "0001";//p_mod_pedido.numeroComprobante;
            this.NumeroComprobante = p_mod_pedido.numeroComprobante;
            this.Comprador_Cuit = p_mod_pedido.entidad.cuit;
            //lcl_mod_Factura.Comprador_IVAResponsableI = p_mod_pedido.documentoComprador.tipo.descripcion;
            if (p_mod_pedido.domicilioDeFacturacion == null)
            { this.Comprador_Domicilio = ""; }
            else
            {
                this.Comprador_Domicilio = p_mod_pedido.domicilioDeFacturacion.ToString();
            }
            this.Comprador_RazonSocial = p_mod_pedido.entidad.ToString();
            //lcl_mod_Factura.ConceptosNoGravados = p_mod_pedido.
            this.CondicionVenta = (p_mod_pedido.formasDePago == null) ? p_mod_pedido.formasDePago[0].forma.ToString() : null;
            foreach (ModeloLineaPedido lp in p_mod_pedido.lineasPedido)
            {
                this.detalleFactura.Add(new ModeloReporteDetalleComprobante(lp));
                //if (lp.descuentos.Count > 0)
                //{
                //    foreach (ModeloDescuentoLineaPedido d in lp.descuentos)
                //    {
                //        this.detalleFactura.Add(new ModeloReporteDetalleComprobante(lp.articulo,d));
                //    }
                //}
            }



            this.FechaComprobante = p_mod_pedido.fecha;
            this.FechaVencimiento = p_mod_pedido.VencimientoCAE;
            this.IVAComprobante = p_mod_pedido.alicuota.monto;
            this.Remito = p_mod_pedido.numeroPedido.ToString();
            this.SubtotalComprobante = p_mod_pedido.montoSubTotal;
            this.TotalComprobante = p_mod_pedido.montoTotal;
            this.TotalComprobanteLetras = LibreriaClasesCompartidas.Transformar.NumeroALetras(p_mod_pedido.montoTotal.ToString());
        }
    }
}
