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
        public string NombreEmpresa { get; set; }
        public string DireccionEmpresa { get; set; }
        public string TelefonoEmpresa { get; set; }
        public string fechaVecimiendo { get; set; }

        public FormReportes()
        {
            InitializeComponent();
        }
        
        public FormReportes(ModeloReportePedidoEntreFechas p_pedidoentrefechas)
        {   //este constructor se construye al modelo de pedido entre fechas                    
            this.ReporteBase.LocalReport.ReportEmbeddedResource ="Reportes.PedidosEntreFechas.rdlc";
            this.ReporteBase.LocalReport.Refresh();
            this.ReporteBase.RefreshReport();
            this.ReporteBase.LocalReport.DataSources.Clear();
            this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("DSInformePedidos", p_pedidoentrefechas));
            this.ReporteBase.RefreshReport();
        }

        public FormReportes(ModeloReporteVentaEntreFechas p_ventaentrefechas)
        {   //este constructor se construye al modelo de pedido entre fechas                    
            this.ReporteBase.LocalReport.ReportEmbeddedResource = "Reportes.VentaEntreFechas.rdlc";
            this.ReporteBase.LocalReport.Refresh();
            this.ReporteBase.RefreshReport();
            this.ReporteBase.LocalReport.DataSources.Clear();
            this.ReporteBase.LocalReport.DataSources.Add(new ReportDataSource("DSInformeVentas", p_ventaentrefechas));
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
            parameters[0] = new ReportParameter("parametroEmpresa", NombreEmpresa);
            parameters[1] = new ReportParameter("parametroTelEmpresa", TelefonoEmpresa);
            parameters[2] = new ReportParameter("parametroDirEmpresa", DireccionEmpresa);
            parameters[3] = new ReportParameter("parametroFecVto", fechaVecimiendo);
            this.ReporteBase.LocalReport.SetParameters(parameters);
        }


    }
}
