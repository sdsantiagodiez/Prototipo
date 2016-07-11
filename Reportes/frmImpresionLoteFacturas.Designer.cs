namespace Reportes
{
    partial class frmImpresionLoteFacturas
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
            this.ModeloReporteEncabezadoFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contenedorLote = new Microsoft.Reporting.WinForms.ReportViewer();
            this.modeloReporteDetalleFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ModeloReporteEncabezadoFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloReporteDetalleFacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ModeloReporteEncabezadoFacturaBindingSource
            // 
            this.ModeloReporteEncabezadoFacturaBindingSource.DataSource = typeof(Modelos.ModeloReporteEncabezadoFactura);
            // 
            // contenedorLote
            // 
            this.contenedorLote.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSFactura";
            reportDataSource1.Value = this.ModeloReporteEncabezadoFacturaBindingSource;
            reportDataSource2.Name = "DSDetalleFactura";
            reportDataSource2.Value = this.ModeloReporteEncabezadoFacturaBindingSource;
            this.contenedorLote.LocalReport.DataSources.Add(reportDataSource1);
            this.contenedorLote.LocalReport.DataSources.Add(reportDataSource2);
            this.contenedorLote.LocalReport.ReportEmbeddedResource = "Reportes.FacturaA.rdlc";
            this.contenedorLote.Location = new System.Drawing.Point(0, 0);
            this.contenedorLote.Name = "contenedorLote";
            this.contenedorLote.Size = new System.Drawing.Size(792, 489);
            this.contenedorLote.TabIndex = 0;
            // 
            // modeloReporteDetalleFacturaBindingSource
            // 
            this.modeloReporteDetalleFacturaBindingSource.DataMember = "detalleFactura";
            this.modeloReporteDetalleFacturaBindingSource.DataSource = typeof(Modelos.ModeloReporteEncabezadoFactura);
            // 
            // frmImpresionLoteFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 489);
            this.Controls.Add(this.contenedorLote);
            this.MaximizeBox = false;
            this.Name = "frmImpresionLoteFacturas";
            this.Text = "frmImpresionLoteFacturas";
            this.Load += new System.EventHandler(this.frmImpresionLoteFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ModeloReporteEncabezadoFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloReporteDetalleFacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer contenedorLote;
        private System.Windows.Forms.BindingSource ModeloReporteEncabezadoFacturaBindingSource;
        private System.Windows.Forms.BindingSource modeloReporteDetalleFacturaBindingSource;
    }
}