using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloReporteEncabezadoFactura
    {

        public List<ModeloReporteDetalleFactura> detalleFactura {get;set;}
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
        public string CAINumero { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string CondicionVenta { get; set; }

 


    }
}
