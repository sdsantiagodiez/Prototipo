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
            this.ReporteBase = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ModeloReportePedidoEntreFechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ModeloReportePedidoEntreFechasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteBase
            // 
            reportDataSource1.Name = "DSInformePedidos";
            reportDataSource1.Value = this.ModeloReportePedidoEntreFechasBindingSource;
            this.ReporteBase.LocalReport.DataSources.Add(reportDataSource1);
            this.ReporteBase.LocalReport.ReportEmbeddedResource = "Reportes.PedidosEntreFechas.rdlc";
            this.ReporteBase.Location = new System.Drawing.Point(12, 12);
            this.ReporteBase.Name = "ReporteBase";
            this.ReporteBase.Size = new System.Drawing.Size(803, 528);
            this.ReporteBase.TabIndex = 0;
            // 
            // ModeloReportePedidoEntreFechasBindingSource
            // 
            this.ModeloReportePedidoEntreFechasBindingSource.DataSource = typeof(Modelos.ModeloReportePedidoEntreFechas);
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
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReporteBase;
        private System.Windows.Forms.BindingSource ModeloReportePedidoEntreFechasBindingSource;
    }
}