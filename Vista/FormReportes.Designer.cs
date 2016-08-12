namespace Vista
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ModeloReporteEncabezadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteBase = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ModeloReporteClienteDomicilio = new System.Windows.Forms.BindingSource(this.components);
            this.ModeloReporteClienteMail = new System.Windows.Forms.BindingSource(this.components);
            this.ModeloReporteClienteTelefono = new System.Windows.Forms.BindingSource(this.components);
            this.detallePedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ModeloReportePedidoEntreFechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ModeloReporteEncabezadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModeloReporteClienteDomicilio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModeloReporteClienteMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModeloReporteClienteTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModeloReportePedidoEntreFechasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ModeloReporteEncabezadoBindingSource
            // 
            this.ModeloReporteEncabezadoBindingSource.DataSource = typeof(Modelos.ModeloReporteEncabezado);
            // 
            // ReporteBase
            // 
            this.ReporteBase.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DSInformeVentas";
            reportDataSource3.Value = null;
            reportDataSource4.Name = "DSInformeVentaEncabezado";
            reportDataSource4.Value = this.ModeloReporteEncabezadoBindingSource;
            this.ReporteBase.LocalReport.DataSources.Add(reportDataSource3);
            this.ReporteBase.LocalReport.DataSources.Add(reportDataSource4);
            this.ReporteBase.LocalReport.ReportEmbeddedResource = "Reportes.VentasEntreFechas.rdlc";
            this.ReporteBase.Location = new System.Drawing.Point(0, 0);
            this.ReporteBase.Name = "ReporteBase";
            this.ReporteBase.Size = new System.Drawing.Size(827, 552);
            this.ReporteBase.TabIndex = 0;
            // 
            // ModeloReporteClienteDomicilio
            // 
            this.ModeloReporteClienteDomicilio.DataSource = typeof(Modelos.ModeloDomicilio);
            // 
            // ModeloReporteClienteMail
            // 
            this.ModeloReporteClienteMail.DataSource = typeof(Modelos.ModeloMail);
            // 
            // ModeloReporteClienteTelefono
            // 
            this.ModeloReporteClienteTelefono.DataSource = typeof(Modelos.ModeloTelefono);
            // 
            // detallePedidoBindingSource
            // 
            this.detallePedidoBindingSource.DataMember = "detallePedido";
            this.detallePedidoBindingSource.DataSource = this.ModeloReporteEncabezadoBindingSource;
            // 
            // ModeloReportePedidoEntreFechasBindingSource
            // 
            this.ModeloReportePedidoEntreFechasBindingSource.DataSource = typeof(Modelos.ModeloReporteDetalle);
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 552);
            this.Controls.Add(this.ReporteBase);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            ((System.ComponentModel.ISupportInitialize)(this.ModeloReporteEncabezadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModeloReporteClienteDomicilio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModeloReporteClienteMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModeloReporteClienteTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModeloReportePedidoEntreFechasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReporteBase;
        private System.Windows.Forms.BindingSource ModeloReporteEncabezadoBindingSource;
        private System.Windows.Forms.BindingSource ModeloReporteClienteDomicilio;
        private System.Windows.Forms.BindingSource ModeloReporteClienteMail;
        private System.Windows.Forms.BindingSource ModeloReporteClienteTelefono;
        private System.Windows.Forms.BindingSource detallePedidoBindingSource;
        private System.Windows.Forms.BindingSource ModeloReportePedidoEntreFechasBindingSource;
    }
}