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
//using System.IO;
//using iTextSharp.text.pdf;

namespace Vista
{
    public partial class frmImpresionComprobante : frmMaterialSkinBase
    {
        #region Atributos
        Controladores.ControladorPDF glb_controladorPDF;
        public EventHandler CerrarForm;
        string folderPathPedidosClientes;
        string folderPathPedidosProveedores;        
        #endregion

        #region Constructores
        public frmImpresionComprobante()
        {
            InitializeComponent();
            this.Text = "Visualización";
            glb_controladorPDF = new Controladores.ControladorPDF();
            
        }
        public frmImpresionComprobante(string p_folderPathClientes, string p_folderPathProveedores) : this()
        {
            folderPathPedidosClientes = p_folderPathClientes;
            folderPathPedidosProveedores = p_folderPathProveedores;
        }
        
        #endregion

        public override void inicializarForm(int ventanaAncho, int ventanaAlto)
        {
            this.contenedorComprobante.Width = ventanaAncho;
            this.contenedorComprobante.Height = ventanaAlto-60;
            this.contenedorComprobante.Location = new System.Drawing.Point(0, 60);
            
        }
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

            foreach (ModeloPedido pedido in p_lst_pedidos)
            {
                this.generarComprobante(pedido);
            }

            string destino = this.getFileName(p_lst_pedidos);
            glb_controladorPDF.concatenarPDFs(destino);

            ////System.Diagnostics.Process p = new System.Diagnostics.Process(); // se abre un proceso para abrir el archivo PDF
            ////p.StartInfo.FileName = pathFinalPDFS;
            ////p.Start();
            ////System.Diagnostics.Process.Start(pathFinalPDFS);     //abre aplicación PDF   

            //axAcroPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            //axAcroPDF.Visible = true;
            //axAcroPDF.Parent = this;

            //axAcroPDF.LoadFile(pathFinalPDFS);//Carga el archivo para mostrar una vista previa del PDF generado.
            ////axAcroPDF.Dispose();

            return true;
        }
        #region Métodos

        private void mostrarComprobante(ModeloPedido p_pedido)
        {
            SafeInvoke(this.contenedorComprobante, this.contenedorComprobante.Reset);

            ModeloReporteEncabezadoComprobante lcl_mod_encabezadoComprobante = new ModeloReporteEncabezadoComprobante(p_pedido);

            this.iniciarDataSources(lcl_mod_encabezadoComprobante);

            this.iniciarReportEmbeddedResource(p_pedido.tipoComprobante);

            this.contenedorComprobante.LocalReport.Refresh();
            
            SafeInvoke(this.contenedorComprobante, this.contenedorComprobante.RefreshReport);
           
        }
        public  void SafeInvoke(Control uiElement, Action updater)
        {
            if (uiElement == null)
            {
                throw new ArgumentNullException("uiElement");
            }

            if (uiElement.IsDisposed)
            {
                throw new ObjectDisposedException("Control is already disposed.");
            }

            if (uiElement.InvokeRequired)
            {
                uiElement.Invoke((Action)delegate { SafeInvoke(uiElement, updater); });
            }
            //else if(!this.IsHandleCreated)
            //{
            //    var x = this.Handle;
            //    this.SafeInvoke(uiElement, updater);
            //}
            else
            {
                updater();
            }
        }


        private void iniciarReportEmbeddedResource(int p_tipoComprobante)
        {
            //lo que esta comentado es un intento de mover frmImpresionComprobante a el proyecto Vista y cargar los archivos rdlc desde alli
            string rdlcFile = "";
            switch (p_tipoComprobante)
            {
                case 1:
                    //this.contenedorComprobante.LocalReport.ReportEmbeddedResource = "Reportes.FacturaA.rdlc";
                    rdlcFile = "Reportes.FacturaA.rdlc";
                    break;
                case 6:
                    //this.contenedorComprobante.LocalReport.ReportEmbeddedResource = "Reportes.FacturaB.rdlc";
                    rdlcFile = "Reportes.FacturaB.rdlc";
                    break;
                case 3:
                    //this.contenedorComprobante.LocalReport.ReportEmbeddedResource = "Reportes.NCreditoA.rdlc";
                    rdlcFile = "Reportes.NCreditoA.rdlc";
                    break;
                case 8:
                    //this.contenedorComprobante.LocalReport.ReportEmbeddedResource = "Reportes.NCreditoB.rdlc";
                    rdlcFile = "Reportes.NCreditoB.rdlc";
                    break;
                case 2001:
                    //this.contenedorComprobante.LocalReport.ReportEmbeddedResource = "Reportes.NCreditoB.rdlc";
                    rdlcFile = "Reportes.OrdenCompra.rdlc";
                    break;
                case 1001:
                    //this.contenedorComprobante.LocalReport.ReportEmbeddedResource = "Reportes.NCreditoB.rdlc";
                    rdlcFile = "Reportes.Presupuesto.rdlc";
                    break;
                default:
                    //this.contenedorComprobante.LocalReport.ReportEmbeddedResource = "Reportes.Pedido.rdlc";
                    rdlcFile = "Reportes.Pedido.rdlc";
                    break;
            }
            
            System.Reflection.Assembly assembly = System.Reflection.Assembly.LoadFrom("Reportes.dll");
            var stream = assembly.GetManifestResourceStream(rdlcFile);
            
            this.contenedorComprobante.LocalReport.LoadReportDefinition(stream);
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

                glb_controladorPDF.crearPDF(bytes,this.getFileName(p_pedido));
                
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
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

            string fileName_aux = folderPath + "Pedido_" + tipoPedido + "_" + p_pedido.numeroPedido.ToString().PadLeft(10, '0');
            string fileName = fileName_aux + ".pdf";
            for (int i = 0; System.IO.File.Exists(fileName); i++)
            {
                fileName = fileName_aux + "(" + i.ToString() + ")" + ".pdf";
            }
            return fileName;
        }

        private string getFileName(List<ModeloPedido> p_lst_pedidos)
        {
            bool soloPedidosProveedores = true;
            bool soloPedidosClientes = true;
            foreach (ModeloPedido p in p_lst_pedidos)
            {
                if (p.codigoTipoPedido == LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.Persona)
                {
                    soloPedidosProveedores = false;
                }
                else
                {
                    soloPedidosClientes = false;
                }
            }
            
            string folderPath;

            if (!soloPedidosClientes && !soloPedidosProveedores)
            {
                folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\"+"Pedidos_";
            }
            else
            {
                if (soloPedidosClientes)
                {
                    folderPath = this.folderPathPedidosClientes + "\\" + "Pedidos_CLI_";
                }
                else
                {
                    folderPath = this.folderPathPedidosProveedores + "\\" + "Pedidos_PROV_";
                }
            }
            folderPath += DateTime.Now.Year + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0'); 
            string fileName = folderPath + ".pdf";
            for (int i = 0; System.IO.File.Exists(fileName); i++)
            {
                fileName = folderPath + "(" + i.ToString() + ")" + ".pdf";
            }
            return fileName;
        }
        //public void estadoAcrobatPDF(bool estado)
        //{
        //    this.axAcroPDF.Visible = estado;
        //}
        
        #endregion

        #region Eventos
        private void frmImpresionFactura_Load(object sender, EventArgs e)
        {
            this.contenedorComprobante.RefreshReport();
        }
        private void frmImpresionComprobante_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.axAcroPDF.Dispose();
        }
        #endregion        

        private void frmImpresionComprobante_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CerrarForm != null)
            {
                this.CerrarForm(sender, e);
            }
        }
    }
    
}
