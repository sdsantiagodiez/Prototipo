﻿namespace Vista
{
    partial class frmImpresionFactura
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
            this.contenedorFactura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.modeloReporteDetalleFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ModeloReporteEncabezadoFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloReporteDetalleFacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ModeloReporteEncabezadoFacturaBindingSource
            // 
            this.ModeloReporteEncabezadoFacturaBindingSource.DataSource = typeof(Modelos.ModeloReporteEncabezadoFactura);
            // 
            // contenedorFactura
            // 
            this.contenedorFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSFactura";
            reportDataSource1.Value = this.ModeloReporteEncabezadoFacturaBindingSource;
            reportDataSource2.Name = "DSDetalleFactura";
            reportDataSource2.Value = this.modeloReporteDetalleFacturaBindingSource;
            this.contenedorFactura.LocalReport.DataSources.Add(reportDataSource1);
            this.contenedorFactura.LocalReport.DataSources.Add(reportDataSource2);
            this.contenedorFactura.LocalReport.ReportEmbeddedResource = "Reportes.FacturaA.rdlc";
            this.contenedorFactura.Location = new System.Drawing.Point(0, 0);
            this.contenedorFactura.Name = "contenedorFactura";
            this.contenedorFactura.Size = new System.Drawing.Size(827, 552);
            this.contenedorFactura.TabIndex = 0;
            // 
            // modeloReporteDetalleFacturaBindingSource
            // 
            this.modeloReporteDetalleFacturaBindingSource.DataSource = typeof(Modelos.ModeloReporteDetalleFactura);
            // 
            // frmImpresionFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 552);
            this.Controls.Add(this.contenedorFactura);
            this.Name = "frmImpresionFactura";
            this.Text = "frmImpresionFactura";
            this.Load += new System.EventHandler(this.frmImpresionFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ModeloReporteEncabezadoFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloReporteDetalleFacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer contenedorFactura;
        private System.Windows.Forms.BindingSource ModeloReporteEncabezadoFacturaBindingSource;
        private System.Windows.Forms.BindingSource modeloReporteDetalleFacturaBindingSource;
    }
}