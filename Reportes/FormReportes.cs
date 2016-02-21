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
            if (p_tipoReporte == "PedidoEntreFechas")
            {
                this.ReporteBase.LocalReport.ReportEmbeddedResource = "Reportes.PedidosEntreFechas.rdlc";
                this.ReporteBase.LocalReport.Refresh();
                this.ReporteBase.RefreshReport();
                this.ReporteBase.LocalReport.DataSources.Clear();
                this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("DSInformePedidoEncabezado", p_pedidoentrefechas));
                this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("DSInformePedidos", p_pedidoentrefechas.detallePedido));
                this.ReporteBase.RefreshReport();
            } else
            {
                //este constructor se construye al modelo de venta entre fechas                    
                this.ReporteBase.LocalReport.ReportEmbeddedResource = "Reportes.VentaEntreFechas.rdlc";
                this.ReporteBase.LocalReport.Refresh();
                this.ReporteBase.RefreshReport();
                this.ReporteBase.LocalReport.DataSources.Clear();
                this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("DSInformeVentaEncabezado", p_pedidoentrefechas));
                this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("DSInformeVentas", p_pedidoentrefechas.detalleVenta));
                this.ReporteBase.RefreshReport();
            }
        }

        
        public FormReportes(ModeloPedido p_ModeloPedido, ModeloPersonas p_ModeloPersonas)
        {   //este constructor se construye al modelo de pedido                     
            this.ReporteBase.LocalReport.ReportEmbeddedResource = "Reportes.Pedido.rdlc";
            this.ReporteBase.LocalReport.Refresh();
            this.ReporteBase.RefreshReport();
            this.ReporteBase.LocalReport.DataSources.Clear();
            this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("EncabezadoPedido", p_ModeloPedido));
            this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("DetallePedido", p_ModeloPedido.lineasPedido));
            this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("ClientePedido", p_ModeloPersonas));
            this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("ClienteDomicilio", p_ModeloPersonas.domicilios));
            this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("ClienteMail", p_ModeloPersonas.mails));
            this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("ClienteTelefono", p_ModeloPersonas.telefonos));

            this.ReporteBase.RefreshReport();
        }


        private void FormReportes_Load(object sender, EventArgs e)
        {
            //ReporteBase.LocalReport.DataSources.Clear();
            SeteoParametrosGeneralesReporte();

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


    }
}
