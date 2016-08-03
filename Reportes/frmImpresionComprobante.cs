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
using iTextSharp.text.pdf;

namespace Reportes
{
    public partial class frmImpresionComprobante : Form
    {
        #region Atributos
        public EventHandler CerrarForm;
        string folderPathPedidosClientes;
        string folderPathPedidosProveedores;
        FileStream destinationDocumentStream;
        List<string> PDFSaAgregar = new List<string>();
        string pathFinalPDFS = "";
        #endregion

        #region Constructores
        public frmImpresionComprobante()
        {
            InitializeComponent();
        }
        public frmImpresionComprobante(string p_folderPathClientes, string p_folderPathProveedores) : this()
        {
            folderPathPedidosClientes = p_folderPathClientes;
            folderPathPedidosProveedores = p_folderPathProveedores;
        }
        
        #endregion


        public bool generarComprobante(ModeloPedido p_pedido)
        {
            if (p_pedido == null)
            {
                return false;
            }
            try
            {
                this.mostrarComprobante(p_pedido);
            }
            catch (Exception ex)
            {
                string p = ex.Message;
            }
            this.guardarComprobante(p_pedido);

            return true;
        }

        public bool generarComprobante(List<ModeloPedido> p_lst_pedidos)
        {
            if (p_lst_pedidos.Count < 1)
            {
                return false;
            }
            this.documentoComprobantes(p_lst_pedidos);
            foreach (ModeloPedido pedido in p_lst_pedidos)
            {
                this.generarComprobante(pedido);
            }
                agregarAPDF(PDFSaAgregar, destinationDocumentStream);

                //System.Diagnostics.Process p = new System.Diagnostics.Process(); // se abre un proceso para abrir el archivo PDF
                //p.StartInfo.FileName = pathFinalPDFS;
                //p.Start();


                axAcroPDF.Dock = System.Windows.Forms.DockStyle.Fill;
                axAcroPDF.Visible = true;
                axAcroPDF.Parent = this;

                axAcroPDF.LoadFile(pathFinalPDFS);//Carga el archivo para mostrar una vista previa del PDF generado.
                //axAcroPDF.Dispose();
            
            
                       
            return true;
        }
        #region Métodos

        private void mostrarComprobante(ModeloPedido p_pedido)
        {
            //this.contenedorComprobante.Reset();

            ModeloReporteEncabezadoComprobante lcl_mod_encabezadoComprobante = new ModeloReporteEncabezadoComprobante(p_pedido);

            this.iniciarDataSources(lcl_mod_encabezadoComprobante);

            this.iniciarReportEmbeddedResource(p_pedido.tipoComprobante);

            this.contenedorComprobante.LocalReport.Refresh();
            
            this.contenedorComprobante.RefreshReport();
           
        }

        private void iniciarReportEmbeddedResource(int p_tipoComprobante)
        {
            //lo que esta comentado es un intento de mover frmImpresionComprobante a el proyecto Vista y cargar los archivos rdlc desde alli
            //string rdlcFile = "";
            switch (p_tipoComprobante)
            {
                case 1:
                    this.contenedorComprobante.LocalReport.ReportEmbeddedResource = "Reportes.FacturaA.rdlc";
                    //rdlcFile = "Reportes.FacturaA.rdlc";
                    break;
                case 6:
                    this.contenedorComprobante.LocalReport.ReportEmbeddedResource = "Reportes.FacturaB.rdlc";
                    //rdlcFile = "Reportes.FacturaB.rdlc";
                    break;
                case 3:
                    this.contenedorComprobante.LocalReport.ReportEmbeddedResource = "Reportes.NCreditoA.rdlc";
                    //rdlcFile = "Reportes.NCreditoA.rdlc";
                    break;
                case 8:
                    this.contenedorComprobante.LocalReport.ReportEmbeddedResource = "Reportes.NCreditoB.rdlc";
                    //rdlcFile = "Reportes.NCreditoB.rdlc";
                    break;
                default:
                    this.contenedorComprobante.LocalReport.ReportEmbeddedResource = "Reportes.Pedido.rdlc";
                    //rdlcFile = "Reportes.Pedido.rdlc";
                    break;
            }
            
            //System.Reflection.Assembly assembly = System.Reflection.Assembly.LoadFrom("Reportes.dll");
            //var stream = assembly.GetManifestResourceStream(rdlcFile);
            
            //this.contenedorComprobante.LocalReport.LoadReportDefinition(stream);
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

        private bool guardarComprobante(ModeloPedido p_pedido)
        {
            try
            {
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string extension;
                byte[] bytes = contenedorComprobante.LocalReport.Render("PDF", null, out mimeType, out encoding, out extension, out streamids, out warnings);

                string pathnombre_archivo = this.getFileName(p_pedido);
                FileStream fs = new FileStream(pathnombre_archivo, FileMode.Create);
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
                this.PDFSaAgregar.Add(pathnombre_archivo);
                //agregarAPDF(pathnombre_archivo, destinationDocumentStream);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        private void documentoComprobantes(List<ModeloPedido> p_lst_mod_Pedidos)
        {
            string todayNow = DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".pdf";
            if (p_lst_mod_Pedidos[0].codigoTipoPedido == LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.Persona)
            {
                pathFinalPDFS = folderPathPedidosClientes + "\\PedidosCli_" + todayNow;
                destinationDocumentStream = new FileStream(pathFinalPDFS, FileMode.Create);
            }
            else
            {
                pathFinalPDFS= folderPathPedidosProveedores + "\\PedidosPro_" + todayNow;
                destinationDocumentStream = new FileStream(pathFinalPDFS, FileMode.Create);
            }

        }

        private static void agregarAPDF(List<string> PDFPathAgregar, FileStream destinationDocumentStream)
        {

        var pdfConcat = new PdfConcatenate(destinationDocumentStream);
        foreach (string s in PDFPathAgregar)
        {
            var sourceDocumentStream = new FileStream(s, FileMode.Open, FileAccess.Read, 0);

            var pdfReader = new PdfReader(sourceDocumentStream);
            pdfReader.SelectPages("1");
            pdfConcat.AddPages(pdfReader);
            pdfReader.Close();
        }
        
        pdfConcat.Close();
        }

        private string getFileName(ModeloPedido p_pedido)
        {
            string folderPath;
            if (p_pedido.codigoTipoPedido == LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.Persona)
            {
                folderPath = this.folderPathPedidosClientes + "\\";
            }
            else
            {
                folderPath = this.folderPathPedidosProveedores + "\\";
            }

            //Pedido_(0|1)_(numeroPedido).pdf   //0|1 si es tipoPedidoCliente o tipoPedidoProveedor
            string tipoPedido = p_pedido.codigoTipoPedido == LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.Persona ? "CLI" : "PROV";

            string fileName_aux = folderPath + "Pedido_" + tipoPedido + "_" + p_pedido.numeroPedido.ToString();
            string fileName = fileName_aux + ".pdf";
            for (int i = 0; System.IO.File.Exists(fileName); i++)
            {
                fileName = fileName_aux + "(" + i.ToString() + ")" + ".pdf";
            }
            return fileName;
        }
        
        #endregion

        #region Eventos
        private void frmImpresionFactura_Load(object sender, EventArgs e)
        {
            this.contenedorComprobante.RefreshReport();
        }
        private void frmImpresionComprobante_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.axAcroPDF.Dispose();
        }
        #endregion

        
    }
    
}
