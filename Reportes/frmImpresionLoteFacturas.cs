using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Microsoft.Reporting.WinForms;


namespace Reportes
{
    public partial class frmImpresionLoteFacturas : Form
    {
        public frmImpresionLoteFacturas()
        {
            InitializeComponent();
        }

        public frmImpresionLoteFacturas(List<ModeloReporteEncabezadoFactura> p_lst_mod_EncFac, string p_tipoComprobante)
        {
            InitializeComponent();

            ModeloReporteEncabezadoFacturaBindingSource.Clear();
            modeloReporteDetalleFacturaBindingSource.Clear();
            modeloReporteDetalleFacturaBindingSource.DataSource = typeof(List<ModeloReporteDetalleFactura>);
            ModeloReporteEncabezadoFacturaBindingSource.DataSource = p_lst_mod_EncFac;
            modeloReporteDetalleFacturaBindingSource.DataSource = p_lst_mod_EncFac;
           /* foreach (ModeloReporteEncabezadoFactura mod in p_lst_mod_EncFac)
            {
                //ModeloReporteEncabezadoFacturaBindingSource.DataSource = mod;
                //modeloReporteDetalleFacturaBindingSource.DataSource = mod.detalleFactura;
                modeloReporteDetalleFacturaBindingSource.Add(mod);
                modeloReporteDetalleFacturaBindingSource.Add(mod.detalleFactura);
            }*/
            
            
            this.contenedorLote.LocalReport.DataSources.Clear();
            this.contenedorLote.LocalReport.DataSources.Add(new ReportDataSource("DSFactura", ModeloReporteEncabezadoFacturaBindingSource));
            this.contenedorLote.LocalReport.DataSources.Add(new ReportDataSource("DSDetalleFactura", modeloReporteDetalleFacturaBindingSource));

            if (String.Equals(p_tipoComprobante, "1"))
            {
                this.contenedorLote.LocalReport.ReportEmbeddedResource = "Reportes.FacturaA.rdlc";
            }
            else if (String.Equals(p_tipoComprobante, "6"))
            {
                this.contenedorLote.LocalReport.ReportEmbeddedResource = "Reportes.FacturaB.rdlc";
            }
            else if (String.Equals(p_tipoComprobante, "3"))
            {
                this.contenedorLote.LocalReport.ReportEmbeddedResource = "Reportes.NCreditoA.rdlc";
            }
            else if (String.Equals(p_tipoComprobante, "8"))
            {
                this.contenedorLote.LocalReport.ReportEmbeddedResource = "Reportes.NCreditoB.rdlc";
            }
            else if (String.Equals(p_tipoComprobante, "0"))
            {
                this.contenedorLote.LocalReport.ReportEmbeddedResource = "Reportes.Pedido.rdlc";
            }
            this.contenedorLote.LocalReport.Refresh();
            this.contenedorLote.RefreshReport();

        }

        private void frmImpresionLoteFacturas_Load(object sender, EventArgs e)
        {

            this.contenedorLote.RefreshReport();
        }
    }
}
