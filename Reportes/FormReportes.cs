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

namespace Reportes
{
    public partial class FormReportes : Form
    {
        public string glb_var_NombreEmpresa { get; set; }
        public string glb_var_DireccionEmpresa { get; set; }
        public string glb_var_TelefonoEmpresa { get; set; }
        public string glb_var_fechaVecimiendo { get; set; }

        public FormReportes()
        {
            InitializeComponent();
        }
        
        public FormReportes(ModeloReporteEncabezado p_pedidoentrefechas, string p_tipoReporte)
        {   //este constructor se construye al modelo de pedido entre fechas  
            InitializeComponent();
            if (p_tipoReporte == "PedidoEntreFechas")
            {
               
                ModeloReportePedidoEntreFechasBindingSource.DataSource= typeof(ModeloReportePedidoEntreFechas);
                ModeloReporteEncabezadoBindingSource.DataSource = p_pedidoentrefechas;
                ModeloReportePedidoEntreFechasBindingSource.DataSource = p_pedidoentrefechas.detallePedido;

                this.ReporteBase.LocalReport.DataSources.RemoveAt(0);
                //this.ReporteBase.LocalReport.DataSources.RemoveAt(1);
                this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("DSInformePedidoEncabezado", ModeloReporteEncabezadoBindingSource));
                this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("DSInformePedidos", ModeloReportePedidoEntreFechasBindingSource));

                this.ReporteBase.LocalReport.ReportEmbeddedResource = "Reportes.PedidosEntreFechas.rdlc";

                this.ReporteBase.LocalReport.Refresh();
                this.ReporteBase.RefreshReport();

            }
            else if (p_tipoReporte == "VentaEntreFechas")
            {
                //este constructor se construye al modelo de venta entre fechas  



                //limpio los binding source
                ModeloReporteEncabezadoBindingSource.Clear();
                ModeloReportePedidoEntreFechasBindingSource.Clear();

                ModeloReporteEncabezadoBindingSource.DataSource = p_pedidoentrefechas;
                ModeloReportePedidoEntreFechasBindingSource.DataSource = p_pedidoentrefechas.detalleVenta;
                this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("DSInformeVentaEncabezado", ModeloReporteEncabezadoBindingSource));
                this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("DSInformeVentas", ModeloReportePedidoEntreFechasBindingSource));

                this.ReporteBase.LocalReport.ReportEmbeddedResource = "Reportes.VentasEntreFechas.rdlc";

                this.ReporteBase.LocalReport.Refresh();
                this.ReporteBase.RefreshReport();

            }
            else
            {
                ModeloReporteEncabezadoBindingSource.Clear();
                ModeloReportePedidoEntreFechasBindingSource.Clear();


                ModeloReportePedidoEntreFechasBindingSource.DataSource = typeof(ModeloReporteTop10Articulos);
                ModeloReporteEncabezadoBindingSource.DataSource = p_pedidoentrefechas;
                ModeloReportePedidoEntreFechasBindingSource.DataSource = p_pedidoentrefechas.detalleArticulos;

                this.ReporteBase.LocalReport.DataSources.RemoveAt(0);
                //this.ReporteBase.LocalReport.DataSources.RemoveAt(1);
                this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("DSInformeTop10Articulos", ModeloReportePedidoEntreFechasBindingSource));
                this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("DSInformeEncabezado", ModeloReporteEncabezadoBindingSource));
                this.ReporteBase.LocalReport.ReportEmbeddedResource = "Reportes.Top10Articulos.rdlc";

                this.ReporteBase.LocalReport.Refresh();
                this.ReporteBase.RefreshReport();

            
            }
        }

        
        public FormReportes(ModeloPedido p_ModeloPedido, ModeloPersonas p_ModeloPersonas)
        {   //este constructor se construye al modelo de pedido 
            InitializeComponent();

            ModeloReporteEncabezadoBindingSource.Clear();
            ModeloReportePedidoEntreFechasBindingSource.Clear();

            ModeloReportePedidoEntreFechasBindingSource.DataSource = typeof(ModeloPedido);
            ModeloReportePedidoEntreFechasBindingSource.DataSource = p_ModeloPedido;
            ModeloReporteEncabezadoBindingSource.DataSource = typeof(ModeloPersonas);
            ModeloReporteEncabezadoBindingSource.DataSource = p_ModeloPersonas;
            
            BindingSource ModeloReporteDetallePedido = new BindingSource();
            ModeloReporteDetallePedido.DataSource = typeof(ModeloLineaPedido);
            ModeloReporteDetallePedido.DataSource = p_ModeloPedido.lineasPedido;

          /*  //BindingSource ModeloReporteClienteDomicilio = new BindingSource();
            ModeloReporteClienteDomicilio.DataSource = typeof(ModeloDomicilio);
            ModeloReporteClienteDomicilio.DataSource = p_ModeloPersonas.domicilios[0];

            //BindingSource ModeloReporteClienteMail = new BindingSource();
            ModeloReporteClienteMail.DataSource = typeof(ModeloMail);
            ModeloReporteClienteMail.DataSource = p_ModeloPersonas.mails[0];

            //BindingSource ModeloReporteClienteTelefono = new BindingSource();
            ModeloReporteClienteTelefono.DataSource = typeof(ModeloTelefono);
            ModeloReporteClienteTelefono.DataSource = p_ModeloPersonas.telefonos[0];
            */
            
            this.ReporteBase.LocalReport.DataSources.RemoveAt(0);
           // this.ReporteBase.LocalReport.DataSources.RemoveAt(1);
            
            this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("EncabezadoPedido", ModeloReportePedidoEntreFechasBindingSource));
            //this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("DetallePedido", p_ModeloPedido.lineasPedido));
            this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("DetallePedido", ModeloReporteDetallePedido));
            this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("ClientePedido", ModeloReporteEncabezadoBindingSource));
            this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("ClienteDomicilio", ModeloReporteClienteDomicilio));
            this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("ClienteMail", ModeloReporteClienteMail));
            this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("ClienteTelefono", ModeloReporteClienteTelefono));

            this.ReporteBase.LocalReport.ReportEmbeddedResource = "Reportes.Pedido.rdlc";
            
            this.ReporteBase.LocalReport.Refresh();
            this.ReporteBase.RefreshReport();

        }

        public FormReportes(List<ModeloArticuloProveedores> p_lst_mod_artP)
        {
            InitializeComponent();
            ModeloReporteEncabezadoBindingSource.Clear();
            ModeloReportePedidoEntreFechasBindingSource.Clear();


            ModeloReporteEncabezadoBindingSource.DataSource = typeof(List<ModeloArticuloProveedores>);
            ModeloReporteEncabezadoBindingSource.DataSource = p_lst_mod_artP;

            this.ReporteBase.LocalReport.DataSources.RemoveAt(0);
            //this.ReporteBase.LocalReport.DataSources.RemoveAt(1);
            this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("DSInventarioStock", ModeloReporteEncabezadoBindingSource));
            this.ReporteBase.LocalReport.ReportEmbeddedResource = "Reportes.StockInventario.rdlc";

            this.ReporteBase.LocalReport.Refresh();
            this.ReporteBase.RefreshReport();
        
        }

        
        private void FormReportes_Load(object sender, EventArgs e)
        {
            //ReporteBase.LocalReport.DataSources.Clear();
           // AsignacionParametrosGenerales("Mundo Renault", "123456", "Pellegrini", "10/10/2010");
            //SeteoParametrosGeneralesReporte();
                        

        }
        //Setea los parametros generales de reporte como ser el nombre de la empresa, direccion telefono. Se podria
        //Tener un menu donde podamos modificar dichas cosas. A plantearlo
        private void SeteoParametrosGeneralesReporte()
        {
            ReportParameter[] parameters = new ReportParameter[4];
            parameters[0] = new ReportParameter("parametroEmpresa", glb_var_NombreEmpresa);
            parameters[1] = new ReportParameter("parametroTelEmpresa", glb_var_TelefonoEmpresa);
            parameters[2] = new ReportParameter("parametroDirEmpresa", glb_var_DireccionEmpresa);
            parameters[3] = new ReportParameter("parametroFecVto", glb_var_fechaVecimiendo);
            this.ReporteBase.LocalReport.SetParameters(parameters);
        }

        private void ReporteBase_Load(object sender, EventArgs e)
        {
            //prueba
            ReporteBase = new ReportViewer();
        }

        public void AsignacionParametrosGenerales(string p_nombreEmpresa, string p_telefonoEmpresa, string p_direccionEmpresa, string p_fechaVencimiento)
        { 
            glb_var_NombreEmpresa = p_nombreEmpresa;
            glb_var_TelefonoEmpresa = p_telefonoEmpresa;
            glb_var_DireccionEmpresa = p_direccionEmpresa;
            glb_var_fechaVecimiendo = p_fechaVencimiento;
        }

       


    }
}
