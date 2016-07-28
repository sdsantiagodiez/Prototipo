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
using System.Drawing.Printing;
using Microsoft.Reporting;
using Microsoft.Reporting.WinForms;
using System.IO;


namespace Reportes
{
    public partial class frmImpresionLoteFacturas : Form
    {
        public frmImpresionLoteFacturas()
        {
            InitializeComponent();
        }

        public frmImpresionLoteFacturas(List<ModeloPedido> p_lst_pedidos) : this()
        {
            ModeloReporteEncabezadoComprobante lcl_mod_encabezadoComprobante;
            foreach (ModeloPedido pedido in p_lst_pedidos)
            {
                lcl_mod_encabezadoComprobante = new ModeloReporteEncabezadoComprobante(pedido);

                ModeloReporteEncabezadoFacturaBindingSource.Clear();
                modeloReporteDetalleFacturaBindingSource.Clear();
                modeloReporteDetalleFacturaBindingSource.DataSource = typeof(List<ModeloReporteDetalleFactura>);
                //ModeloReporteEncabezadoFacturaBindingSource.DataSource = p_lst_mod_EncFac;
                //modeloReporteDetalleFacturaBindingSource.DataSource = p_lst_mod_EncFac;

                //ModeloReporteEncabezadoFacturaBindingSource.DataSource = mod;
                //modeloReporteDetalleFacturaBindingSource.DataSource = mod.detalleFactura;
                modeloReporteDetalleFacturaBindingSource.DataSource=lcl_mod_encabezadoComprobante;
                modeloReporteDetalleFacturaBindingSource.DataSource=lcl_mod_encabezadoComprobante.detalleFactura;

                this.contenedorLote.LocalReport.DataSources.Clear();
                this.contenedorLote.LocalReport.DataSources.Add(new ReportDataSource("DSFactura", ModeloReporteEncabezadoFacturaBindingSource));
                this.contenedorLote.LocalReport.DataSources.Add(new ReportDataSource("DSDetalleFactura", modeloReporteDetalleFacturaBindingSource));

                switch (pedido.tipoComprobante)
                {
                    case 1:
                        this.contenedorLote.LocalReport.ReportEmbeddedResource = "Reportes.FacturaA.rdlc";
                        break;
                    case 6:
                        this.contenedorLote.LocalReport.ReportEmbeddedResource = "Reportes.FacturaB.rdlc";
                        break;
                    case 3:
                        this.contenedorLote.LocalReport.ReportEmbeddedResource = "Reportes.NCreditoA.rdlc";
                        break;
                    case 8:
                        this.contenedorLote.LocalReport.ReportEmbeddedResource = "Reportes.NCreditoB.rdlc";
                        break;
                    default:
                        this.contenedorLote.LocalReport.ReportEmbeddedResource = "Reportes.Pedido.rdlc";
                        break;
                }
                
                this.contenedorLote.LocalReport.Refresh();
                this.contenedorLote.RefreshReport();

                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string extension;
                byte[] bytes = contenedorLote.LocalReport.Render("PDF", null, out mimeType, out encoding, out extension, out streamids, out warnings);
                
                FileStream fs = new FileStream(@"c:\users\Santiago\desktop\Pedido "+pedido.numeroPedido.ToString()+".pdf", FileMode.Create);
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
            }
        }

        private void frmImpresionLoteFacturas_Load(object sender, EventArgs e)
        {
            this.contenedorLote.RefreshReport();
        }
    }
}
