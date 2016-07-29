using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace Reportes
{
    public partial class frmImpresionComprobante : Form
    {
        /// <summary>
        /// Se tiene que cambiar a la carpeta de cada uno. Más adelante agrego algo más dinámico 
        /// </summary>
        string path = "c:\\users\\Santiago\\desktop\\Pedido ";

        #region Constructores
        private frmImpresionComprobante()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Inicializa form con un comprobante a imprimir
        /// </summary>
        /// <param name="p_modEncabezado"></param>
        /// <param name="tipoComprobante"></param>
        public  frmImpresionComprobante(ModeloPedido p_pedido) : this()
        {
            if (p_pedido == null)
            {
                return;
            }
            this.mostrarComprobante(p_pedido);

            this.guardarComprobante(p_pedido, path);
        }
       
        /// <summary>
        /// Inicializa form con múltiples comprobantes a imprimir
        /// </summary>
        /// <param name="p_lst_pedidos"></param>
        public frmImpresionComprobante(List<ModeloPedido> p_lst_pedidos) : this()
        {
            if (p_lst_pedidos.Count < 1)
            {
                return;
            }
            foreach (ModeloPedido pedido in p_lst_pedidos)
            {
                this.mostrarComprobante(pedido);

                this.guardarComprobante(pedido, path);
            }
        }
        
        #endregion

        #region Métodos

        private void mostrarComprobante(ModeloPedido p_pedido)
        {
            ModeloReporteEncabezadoComprobante lcl_mod_encabezadoComprobante = new ModeloReporteEncabezadoComprobante(p_pedido);

            this.iniciarDataSources(lcl_mod_encabezadoComprobante);

            this.iniciarReportEmbeddedResource(p_pedido.tipoComprobante);

            this.contenedorComprobante.LocalReport.Refresh();
            this.contenedorComprobante.RefreshReport();
        }

        private void iniciarReportEmbeddedResource(int p_tipoComprobante)
        {
            switch (p_tipoComprobante)
            {
                case 1:
                    this.contenedorComprobante.LocalReport.ReportEmbeddedResource = "Reportes.FacturaA.rdlc";
                    break;
                case 6:
                    this.contenedorComprobante.LocalReport.ReportEmbeddedResource = "Reportes.FacturaB.rdlc";
                    break;
                case 3:
                    this.contenedorComprobante.LocalReport.ReportEmbeddedResource = "Reportes.NCreditoA.rdlc";
                    break;
                case 8:
                    this.contenedorComprobante.LocalReport.ReportEmbeddedResource = "Reportes.NCreditoB.rdlc";
                    break;
                default:
                    this.contenedorComprobante.LocalReport.ReportEmbeddedResource = "Reportes.Pedido.rdlc";
                    break;
            }
        }

        private void iniciarDataSources(ModeloReporteEncabezadoComprobante p_encabezado)
        {
            this.contenedorComprobante.LocalReport.DataSources.Clear();

            ModeloReporteEncabezadoFacturaBindingSource.Clear();
            ModeloReporteEncabezadoFacturaBindingSource.DataSource = p_encabezado;
            this.contenedorComprobante.LocalReport.DataSources.Add(new ReportDataSource("DSFactura", ModeloReporteEncabezadoFacturaBindingSource));

            modeloReporteDetalleFacturaBindingSource.Clear();
            modeloReporteDetalleFacturaBindingSource.DataSource = typeof(List<ModeloReporteDetalleComprobante>);
            modeloReporteDetalleFacturaBindingSource.DataSource = p_encabezado.detalleFactura;
            this.contenedorComprobante.LocalReport.DataSources.Add(new ReportDataSource("DSDetalleFactura", modeloReporteDetalleFacturaBindingSource));
            //ModeloReporteEncabezadoFacturaBindingSource.DataSource = p_lst_mod_EncFac;
            //modeloReporteDetalleFacturaBindingSource.DataSource = p_lst_mod_EncFac;

            //ModeloReporteEncabezadoFacturaBindingSource.DataSource = mod;
            //modeloReporteDetalleFacturaBindingSource.DataSource = mod.detalleFactura;
        }

        private bool guardarComprobante(ModeloPedido p_pedido,string p_path)
        {
            try
            {
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string extension;
                byte[] bytes = contenedorComprobante.LocalReport.Render("PDF", null, out mimeType, out encoding, out extension, out streamids, out warnings);

                FileStream fs = new FileStream(p_path + p_pedido.numeroPedido.ToString() + ".pdf", FileMode.Create);
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
        #endregion

        #region Eventos
        private void frmImpresionFactura_Load(object sender, EventArgs e)
        {
            this.contenedorComprobante.RefreshReport();
        }
        #endregion
    }
}
