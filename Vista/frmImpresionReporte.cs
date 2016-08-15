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
using System.IO;
using LibreriaClasesCompartidas;
using Controladores;

namespace Vista
{
    public partial class frmImpresionReporte : Form
    {
        public frmImpresionReporte()
        {
            InitializeComponent();
        }

        #region mostrar
        /// <summary>
        /// Crea reporte de Clientes especificado
        /// </summary>
        /// <param name="p_reporte"></param>
        /// <param name="p_periodos"></param>
        /// <returns></returns>
        public bool mostrar(LibreriaClasesCompartidas.Constantes.Reportes.Clientes p_reporte, List<DateTime> p_periodos,ModeloCliente p_cliente,int p_cantidadClientes) 
        {
            SafeInvoke(this.ReporteBase, this.ReporteBase.Reset);
            ControladorReportes lcl_con_reportes = new Controladores.ControladorReportes();
            ModeloReporteEncabezado lcl_mod_encabezadoComprobante = lcl_con_reportes.getEncabezado(p_reporte, p_periodos, p_cliente, p_cantidadClientes);

            this.iniciarDataSources(p_reporte, lcl_mod_encabezadoComprobante);

            this.iniciarReportEmbeddedResource(p_reporte);
            this.ReporteBase.LocalReport.Refresh();
            SafeInvoke(this.ReporteBase, this.ReporteBase.RefreshReport);

            return true;
        }

        /// <summary>
        /// Crea reporte de Clientes especificado para el cliente enviado como parametro
        /// </summary>
        /// <param name="p_reporte"></param>
        /// <param name="p_periodos"></param>
        /// <returns></returns>
        public bool mostrar(LibreriaClasesCompartidas.Constantes.Reportes.Proveedores p_reporte, List<DateTime> p_periodos, ModeloProveedor p_proveedor,int p_cantidadProveedores)
        {
            SafeInvoke(this.ReporteBase, this.ReporteBase.Reset);
            ControladorReportes lcl_con_reportes = new Controladores.ControladorReportes();

            ModeloReporteEncabezado lcl_mod_encabezadoComprobante = lcl_con_reportes.getEncabezado(p_reporte, p_periodos, p_proveedor, p_cantidadProveedores);

            this.iniciarDataSources(p_reporte, lcl_mod_encabezadoComprobante);

            this.iniciarReportEmbeddedResource(p_reporte);
            this.ReporteBase.LocalReport.Refresh();
            SafeInvoke(this.ReporteBase, this.ReporteBase.RefreshReport);

            return true;
        }
        /// <summary>
        /// Crea reporte de Artículos especificado
        /// </summary>
        /// <param name="p_reporte"></param>
        /// <param name="p_periodos"></param>
        /// <returns></returns>
        public bool mostrar(LibreriaClasesCompartidas.Constantes.Reportes.Articulos p_reporte, List<DateTime> p_periodos,int p_cantidadArticulos)
        {
            SafeInvoke(this.ReporteBase, this.ReporteBase.Reset);
            ControladorReportes lcl_con_reportes = new Controladores.ControladorReportes();

            ModeloReporteEncabezado lcl_mod_encabezadoComprobante = lcl_con_reportes.getEncabezado(p_reporte, p_periodos, p_cantidadArticulos);

            this.iniciarDataSources(p_reporte, lcl_mod_encabezadoComprobante);


            this.iniciarReportEmbeddedResource(p_reporte);
            this.ReporteBase.LocalReport.Refresh();
            SafeInvoke(this.ReporteBase, this.ReporteBase.RefreshReport);

            return true;
        }
        #endregion

        #region EmbeddedResource
        private void iniciarReportEmbeddedResource(Constantes.Reportes.Clientes p_reporte)
        {
            string rdlcFile = "";
            switch (p_reporte)
            {
                case Constantes.Reportes.Clientes.FrecuenciaDePedidos:
                    rdlcFile = "Reportes.VentasEntreFechas.rdlc";
                    break;
                case Constantes.Reportes.Clientes.MontoTotalDePedidos:
                    rdlcFile = "Reportes.VentasEntreFechas.rdlc";
                    break;
                //case Constantes.Reportes.Clientes.PedidosMasElevados:
                //    //rdlcFile = "Reportes.PedidoMasElevado.rdlc";  //NO CREadO
                //    break;
            }

            this.loadReportDefinition(rdlcFile);
        }
        private void iniciarReportEmbeddedResource(Constantes.Reportes.Proveedores p_reporte)
        {
            string rdlcFile = "";
            switch (p_reporte)
            {
                case Constantes.Reportes.Proveedores.FrecuenciaDePedidos:
                    rdlcFile = "Reportes.PedidosEntreFechas.rdlc";
                    break;
                case Constantes.Reportes.Proveedores.MontoTotalDePedidos:
                    rdlcFile = "Reportes.PedidosEntreFechas.rdlc";
                    break;
                //case Constantes.Reportes.Proveedores.PedidosMasElevados:
                //    //rdlcFile = "Reportes.PedidoMasElevado.rdlc";    //NO CREADO
                    break;
            }

            this.loadReportDefinition(rdlcFile);
        }
        private void iniciarReportEmbeddedResource(Constantes.Reportes.Articulos p_reporte)
        {
            string rdlcFile = "";
            switch (p_reporte)
            {
                case Constantes.Reportes.Articulos.DescuentosVigentes:
                    rdlcFile = "Reportes.DescuentoAFecha.rdlc";
                    break;
                case Constantes.Reportes.Articulos.ArticulosMasVendidos:
                    rdlcFile = "Reportes.Top10Articulos.rdlc";
                    break;
                case Constantes.Reportes.Articulos.InformeStock:
                    rdlcFile = "Reportes.StockInventario.rdlc";
                    break;
            }

            this.loadReportDefinition(rdlcFile);
        }
        private void loadReportDefinition(string p_rdlcFile)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.LoadFrom("Reportes.dll");
            var stream = assembly.GetManifestResourceStream(p_rdlcFile);

            this.ReporteBase.LocalReport.LoadReportDefinition(stream);
        }
        #endregion

        #region DataSources
        private void iniciarDataSources(LibreriaClasesCompartidas.Constantes.Reportes.Clientes p_reporte, ModeloReporteEncabezado p_encabezado)
        {
            switch (p_reporte)
            {
                case Constantes.Reportes.Clientes.FrecuenciaDePedidos:
                case Constantes.Reportes.Clientes.MontoTotalDePedidos:
                    ModeloReporteEncabezadoBindingSource.DataSource = p_encabezado;
                    ModeloReportePedidoEntreFechasBindingSource.DataSource = p_encabezado.detallePedido;
                    this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("dsEncabezadoReporte", ModeloReporteEncabezadoBindingSource));
                    this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("dsDetalleReporte", ModeloReportePedidoEntreFechasBindingSource));
                    break;
                //case Constantes.Reportes.Clientes.PedidosMasElevados:
                //    break;
                default :
                    break;
            }
        }
        private void iniciarDataSources(LibreriaClasesCompartidas.Constantes.Reportes.Proveedores p_reporte,ModeloReporteEncabezado p_encabezado)
        {
            switch (p_reporte)
            {
                case Constantes.Reportes.Proveedores.FrecuenciaDePedidos:
                case Constantes.Reportes.Proveedores.MontoTotalDePedidos:
                    ModeloReporteEncabezadoBindingSource.DataSource = p_encabezado;
                    ModeloReportePedidoEntreFechasBindingSource.DataSource = p_encabezado.detallePedido;
                    this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("dsEncabezadoReporte", ModeloReporteEncabezadoBindingSource));
                    this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("dsDetalleReporte", ModeloReportePedidoEntreFechasBindingSource));
                    break;
                //case Constantes.Reportes.Proveedores.PedidosMasElevados:
                //    break;
                default :
                    break;
            }
        }
        private void iniciarDataSources(LibreriaClasesCompartidas.Constantes.Reportes.Articulos p_reporte, ModeloReporteEncabezado p_encabezado)
        {
            switch (p_reporte)
            {
                case Constantes.Reportes.Articulos.InformeStock:
                case Constantes.Reportes.Articulos.DescuentosVigentes:
                    ModeloReportePedidoEntreFechasBindingSource.DataSource = p_encabezado.detalleArticulosDescuentos;
                    break;
                case Constantes.Reportes.Articulos.ArticulosMasVendidos:
                    ModeloReportePedidoEntreFechasBindingSource.DataSource = p_encabezado.detalleArticulos;
                    break;
                default:
                    break;
            }
            ModeloReporteEncabezadoBindingSource.DataSource = p_encabezado;
            this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("dsEncabezadoReporte", ModeloReporteEncabezadoBindingSource));
            this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("dsDetalleReporte", ModeloReportePedidoEntreFechasBindingSource));
        }
        #endregion

        public void SafeInvoke(Control uiElement, Action updater)
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
            else
            {
                updater();
            }
        }
    }
}
