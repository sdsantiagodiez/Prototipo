namespace Reportes
{
    partial class FormReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ModeloReportePedidoEntreFechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ModeloReporteEncabezadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteBase = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ModeloReportePedidoEntreFechasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModeloReporteEncabezadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ModeloReportePedidoEntreFechasBindingSource
            // 
            this.ModeloReportePedidoEntreFechasBindingSource.DataMember = "detalleVenta";
            this.ModeloReportePedidoEntreFechasBindingSource.DataSource = typeof(Modelos.ModeloReporteEncabezado);
            // 
            // ModeloReporteEncabezadoBindingSource
            // 
            this.ModeloReporteEncabezadoBindingSource.DataSource = typeof(Modelos.ModeloReporteEncabezado);
            // 
            // ReporteBase
            // 
            reportDataSource1.Name = "DSInformePedidos";
            reportDataSource1.Value = this.ModeloReporteEncabezadoBindingSource;
            reportDataSource2.Name = "DSInformePedidoEncabezado";
            reportDataSource2.Value = this.ModeloReporteEncabezadoBindingSource;
            this.ReporteBase.LocalReport.DataSources.Add(reportDataSource1);
            this.ReporteBase.LocalReport.DataSources.Add(reportDataSource2);
            this.ReporteBase.LocalReport.ReportEmbeddedResource = "Reportes.PedidosEntreFechas.rdlc";
            this.ReporteBase.Location = new System.Drawing.Point(12, 12);
            this.ReporteBase.Name = "ReporteBase";
            this.ReporteBase.Size = new System.Drawing.Size(803, 528);
            this.ReporteBase.TabIndex = 0;
            this.ReporteBase.Load += new System.EventHandler(this.ReporteBase_Load);
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 552);
            this.Controls.Add(this.ReporteBase);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ModeloReportePedidoEntreFechasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModeloReporteEncabezadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReporteBase;
        private System.Windows.Forms.BindingSource ModeloReportePedidoEntreFechasBindingSource;
        private System.Windows.Forms.BindingSource ModeloReporteEncabezadoBindingSource;
    }
}