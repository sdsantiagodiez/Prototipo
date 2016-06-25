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

namespace Vista
{
    public partial class frmImpresionFactura : Form
    {
        public frmImpresionFactura()
        {
            InitializeComponent();
        }

        private void frmImpresionFactura_Load(object sender, EventArgs e)
        {

            this.contenedorFactura.RefreshReport();
        }

        public frmImpresionFactura(ModeloReporteEncabezadoFactura p_modEncabezado, string tipoComprobante)
        {
            InitializeComponent();
            ModeloReporteEncabezadoFacturaBindingSource.Clear();
            modeloReporteDetalleFacturaBindingSource.Clear();
            
            modeloReporteDetalleFacturaBindingSource.DataSource = typeof(ModeloReporteDetalleFactura);
            ModeloReporteEncabezadoFacturaBindingSource.DataSource = p_modEncabezado;
            modeloReporteDetalleFacturaBindingSource.DataSource = p_modEncabezado.detalleFactura;
            this.contenedorFactura.LocalReport.DataSources.Clear();
            this.contenedorFactura.LocalReport.DataSources.Add(new ReportDataSource("DSFactura", ModeloReporteEncabezadoFacturaBindingSource));
            this.contenedorFactura.LocalReport.DataSources.Add(new ReportDataSource("DSDetalleFactura", modeloReporteDetalleFacturaBindingSource));

            if (String.Equals(tipoComprobante,"1"))
            {
                this.contenedorFactura.LocalReport.ReportEmbeddedResource = "Reportes.FacturaA.rdlc";
            }
            else if (String.Equals(tipoComprobante, "6"))
            {
                this.contenedorFactura.LocalReport.ReportEmbeddedResource = "Reportes.FacturaB.rdlc";
            }
            else if (String.Equals(tipoComprobante, "3"))
            {
                this.contenedorFactura.LocalReport.ReportEmbeddedResource = "Reportes.NCreditoA.rdlc";
            }
            else if (String.Equals(tipoComprobante, "8"))
            {
                this.contenedorFactura.LocalReport.ReportEmbeddedResource = "Reportes.NCreditoB.rdlc";
            }
            else if(String.Equals(tipoComprobante,"0"))
            {
                this.contenedorFactura.LocalReport.ReportEmbeddedResource = "Reportes.Pedido.rdlc";
            }
            this.contenedorFactura.LocalReport.Refresh();
            this.contenedorFactura.RefreshReport();
        }

    }
}
