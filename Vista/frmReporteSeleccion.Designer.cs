namespace Vista
{
    partial class frmReporteSeleccion
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPedidos = new System.Windows.Forms.TabPage();
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.chkboxAllProv = new System.Windows.Forms.CheckBox();
            this.cmbxPedidosReportes = new System.Windows.Forms.ComboBox();
            this.tblPanelPedidos = new System.Windows.Forms.TableLayoutPanel();
            this.tbxPedidoFechaDesde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPedidoFechaHasta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxProvDesde = new System.Windows.Forms.TextBox();
            this.tbxProvHasta = new System.Windows.Forms.TextBox();
            this.btnGeneraReporte = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPedidos.SuspendLayout();
            this.tblPanelPedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPedidos);
            this.tabControl1.Controls.Add(this.tabVentas);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(772, 223);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPedidos
            // 
            this.tabPedidos.Controls.Add(this.tblPanelPedidos);
            this.tabPedidos.Location = new System.Drawing.Point(4, 25);
            this.tabPedidos.Name = "tabPedidos";
            this.tabPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPedidos.Size = new System.Drawing.Size(764, 194);
            this.tabPedidos.TabIndex = 0;
            this.tabPedidos.Text = "Pedidos";
            this.tabPedidos.UseVisualStyleBackColor = true;
            // 
            // tabVentas
            // 
            this.tabVentas.Location = new System.Drawing.Point(4, 25);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVentas.Size = new System.Drawing.Size(764, 168);
            this.tabVentas.TabIndex = 1;
            this.tabVentas.Text = "Ventas";
            this.tabVentas.UseVisualStyleBackColor = true;
            // 
            // chkboxAllProv
            // 
            this.chkboxAllProv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkboxAllProv.AutoSize = true;
            this.chkboxAllProv.Location = new System.Drawing.Point(128, 123);
            this.chkboxAllProv.Name = "chkboxAllProv";
            this.chkboxAllProv.Size = new System.Drawing.Size(219, 56);
            this.chkboxAllProv.TabIndex = 0;
            this.chkboxAllProv.Text = "Todos los Proveedores";
            this.chkboxAllProv.UseVisualStyleBackColor = true;
            // 
            // cmbxPedidosReportes
            // 
            this.cmbxPedidosReportes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxPedidosReportes.FormattingEnabled = true;
            this.cmbxPedidosReportes.Location = new System.Drawing.Point(128, 3);
            this.cmbxPedidosReportes.Name = "cmbxPedidosReportes";
            this.cmbxPedidosReportes.Size = new System.Drawing.Size(219, 24);
            this.cmbxPedidosReportes.TabIndex = 1;
            // 
            // tblPanelPedidos
            // 
            this.tblPanelPedidos.ColumnCount = 5;
            this.tblPanelPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblPanelPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblPanelPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.55556F));
            this.tblPanelPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tblPanelPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.55556F));
            this.tblPanelPedidos.Controls.Add(this.cmbxPedidosReportes, 1, 0);
            this.tblPanelPedidos.Controls.Add(this.label3, 0, 0);
            this.tblPanelPedidos.Controls.Add(this.label1, 2, 0);
            this.tblPanelPedidos.Controls.Add(this.tbxPedidoFechaDesde, 3, 0);
            this.tblPanelPedidos.Controls.Add(this.label2, 2, 1);
            this.tblPanelPedidos.Controls.Add(this.tbxPedidoFechaHasta, 3, 1);
            this.tblPanelPedidos.Controls.Add(this.chkboxAllProv, 1, 4);
            this.tblPanelPedidos.Controls.Add(this.label4, 2, 2);
            this.tblPanelPedidos.Controls.Add(this.label5, 2, 3);
            this.tblPanelPedidos.Controls.Add(this.tbxProvDesde, 3, 2);
            this.tblPanelPedidos.Controls.Add(this.tbxProvHasta, 3, 3);
            this.tblPanelPedidos.Controls.Add(this.btnGeneraReporte, 4, 4);
            this.tblPanelPedidos.Location = new System.Drawing.Point(6, 6);
            this.tblPanelPedidos.Name = "tblPanelPedidos";
            this.tblPanelPedidos.RowCount = 5;
            this.tblPanelPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblPanelPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblPanelPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblPanelPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblPanelPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tblPanelPedidos.Size = new System.Drawing.Size(752, 182);
            this.tblPanelPedidos.TabIndex = 2;
            // 
            // tbxPedidoFechaDesde
            // 
            this.tbxPedidoFechaDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPedidoFechaDesde.Location = new System.Drawing.Point(469, 3);
            this.tbxPedidoFechaDesde.Name = "tbxPedidoFechaDesde";
            this.tbxPedidoFechaDesde.Size = new System.Drawing.Size(161, 23);
            this.tbxPedidoFechaDesde.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Desde:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Hasta:";
            // 
            // tbxPedidoFechaHasta
            // 
            this.tbxPedidoFechaHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPedidoFechaHasta.Location = new System.Drawing.Point(469, 33);
            this.tbxPedidoFechaHasta.Name = "tbxPedidoFechaHasta";
            this.tbxPedidoFechaHasta.Size = new System.Drawing.Size(161, 23);
            this.tbxPedidoFechaHasta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Reportes:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prov. Desde:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prov. Hasta";
            // 
            // tbxProvDesde
            // 
            this.tbxProvDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxProvDesde.Location = new System.Drawing.Point(469, 63);
            this.tbxProvDesde.Name = "tbxProvDesde";
            this.tbxProvDesde.Size = new System.Drawing.Size(161, 23);
            this.tbxProvDesde.TabIndex = 9;
            // 
            // tbxProvHasta
            // 
            this.tbxProvHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxProvHasta.Location = new System.Drawing.Point(469, 93);
            this.tbxProvHasta.Name = "tbxProvHasta";
            this.tbxProvHasta.Size = new System.Drawing.Size(161, 23);
            this.tbxProvHasta.TabIndex = 10;
            // 
            // btnGeneraReporte
            // 
            this.btnGeneraReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneraReporte.Location = new System.Drawing.Point(636, 123);
            this.btnGeneraReporte.Name = "btnGeneraReporte";
            this.btnGeneraReporte.Size = new System.Drawing.Size(113, 56);
            this.btnGeneraReporte.TabIndex = 11;
            this.btnGeneraReporte.Text = "Genera Reporte";
            this.btnGeneraReporte.UseVisualStyleBackColor = true;
            // 
            // frmReporteSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(796, 263);
            this.Controls.Add(this.tabControl1);
            this.MinimizeBox = false;
            this.Name = "frmReporteSeleccion";
            this.Text = "Seleccionar un Reporte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPedidos.ResumeLayout(false);
            this.tblPanelPedidos.ResumeLayout(false);
            this.tblPanelPedidos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPedidos;
        private System.Windows.Forms.TabPage tabVentas;
        private System.Windows.Forms.ComboBox cmbxPedidosReportes;
        private System.Windows.Forms.CheckBox chkboxAllProv;
        private System.Windows.Forms.TableLayoutPanel tblPanelPedidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPedidoFechaDesde;
        private System.Windows.Forms.TextBox tbxPedidoFechaHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxProvDesde;
        private System.Windows.Forms.TextBox tbxProvHasta;
        private System.Windows.Forms.Button btnGeneraReporte;
    }
}