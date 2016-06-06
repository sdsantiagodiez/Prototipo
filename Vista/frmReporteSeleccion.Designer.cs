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
            this.cmbxPedidosReportes = new System.Windows.Forms.ComboBox();
            this.cmbxVentasReportes = new System.Windows.Forms.ComboBox();
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPedidos = new System.Windows.Forms.TabPage();
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.lblReportesPedidos = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaDesdePedido = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaHastaPedido = new MaterialSkin.Controls.MaterialLabel();
            this.lblReportesVenta = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaDesdeVenta = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaHastaVenta = new MaterialSkin.Controls.MaterialLabel();
            this.txtPedidoFechaHasta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPedidoFechaDesde = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtFecDesdeVentas = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtFecHastaVentas = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnGeneraReportePedido = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnGeneraReporteVentas = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabControl.SuspendLayout();
            this.tabPedidos.SuspendLayout();
            this.tabVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbxPedidosReportes
            // 
            this.cmbxPedidosReportes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxPedidosReportes.FormattingEnabled = true;
            this.cmbxPedidosReportes.Location = new System.Drawing.Point(119, 25);
            this.cmbxPedidosReportes.Name = "cmbxPedidosReportes";
            this.cmbxPedidosReportes.Size = new System.Drawing.Size(256, 21);
            this.cmbxPedidosReportes.TabIndex = 1;
            // 
            // cmbxVentasReportes
            // 
            this.cmbxVentasReportes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxVentasReportes.FormattingEnabled = true;
            this.cmbxVentasReportes.Location = new System.Drawing.Point(119, 25);
            this.cmbxVentasReportes.Name = "cmbxVentasReportes";
            this.cmbxVentasReportes.Size = new System.Drawing.Size(256, 21);
            this.cmbxVentasReportes.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPedidos);
            this.tabControl.Controls.Add(this.tabVentas);
            this.tabControl.Depth = 0;
            this.tabControl.Location = new System.Drawing.Point(12, 90);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(394, 216);
            this.tabControl.TabIndex = 1;
            // 
            // tabPedidos
            // 
            this.tabPedidos.Controls.Add(this.btnGeneraReportePedido);
            this.tabPedidos.Controls.Add(this.cmbxPedidosReportes);
            this.tabPedidos.Controls.Add(this.lblFechaHastaPedido);
            this.tabPedidos.Controls.Add(this.txtPedidoFechaHasta);
            this.tabPedidos.Controls.Add(this.txtPedidoFechaDesde);
            this.tabPedidos.Controls.Add(this.lblFechaDesdePedido);
            this.tabPedidos.Controls.Add(this.lblReportesPedidos);
            this.tabPedidos.Location = new System.Drawing.Point(4, 22);
            this.tabPedidos.Name = "tabPedidos";
            this.tabPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPedidos.Size = new System.Drawing.Size(386, 190);
            this.tabPedidos.TabIndex = 0;
            this.tabPedidos.Text = "Pedidos";
            this.tabPedidos.UseVisualStyleBackColor = true;
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.btnGeneraReporteVentas);
            this.tabVentas.Controls.Add(this.txtFecHastaVentas);
            this.tabVentas.Controls.Add(this.txtFecDesdeVentas);
            this.tabVentas.Controls.Add(this.cmbxVentasReportes);
            this.tabVentas.Controls.Add(this.lblFechaHastaVenta);
            this.tabVentas.Controls.Add(this.lblFechaDesdeVenta);
            this.tabVentas.Controls.Add(this.lblReportesVenta);
            this.tabVentas.Location = new System.Drawing.Point(4, 22);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVentas.Size = new System.Drawing.Size(386, 190);
            this.tabVentas.TabIndex = 1;
            this.tabVentas.Text = "Ventas";
            this.tabVentas.UseVisualStyleBackColor = true;
            // 
            // tabSelector
            // 
            this.tabSelector.BaseTabControl = this.tabControl;
            this.tabSelector.Depth = 0;
            this.tabSelector.Location = new System.Drawing.Point(0, 61);
            this.tabSelector.Margin = new System.Windows.Forms.Padding(0);
            this.tabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelector.Name = "tabSelector";
            this.tabSelector.Size = new System.Drawing.Size(419, 23);
            this.tabSelector.TabIndex = 2;
            this.tabSelector.Text = "materialTabSelector1";
            // 
            // lblReportesPedidos
            // 
            this.lblReportesPedidos.AutoSize = true;
            this.lblReportesPedidos.Depth = 0;
            this.lblReportesPedidos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportesPedidos.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblReportesPedidos.Location = new System.Drawing.Point(31, 24);
            this.lblReportesPedidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblReportesPedidos.Name = "lblReportesPedidos";
            this.lblReportesPedidos.Size = new System.Drawing.Size(82, 18);
            this.lblReportesPedidos.TabIndex = 0;
            this.lblReportesPedidos.Text = "Reportes:";
            // 
            // lblFechaDesdePedido
            // 
            this.lblFechaDesdePedido.AutoSize = true;
            this.lblFechaDesdePedido.Depth = 0;
            this.lblFechaDesdePedido.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesdePedido.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFechaDesdePedido.Location = new System.Drawing.Point(3, 58);
            this.lblFechaDesdePedido.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaDesdePedido.Name = "lblFechaDesdePedido";
            this.lblFechaDesdePedido.Size = new System.Drawing.Size(110, 18);
            this.lblFechaDesdePedido.TabIndex = 1;
            this.lblFechaDesdePedido.Text = "Fecha Desde:";
            // 
            // lblFechaHastaPedido
            // 
            this.lblFechaHastaPedido.AutoSize = true;
            this.lblFechaHastaPedido.Depth = 0;
            this.lblFechaHastaPedido.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHastaPedido.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFechaHastaPedido.Location = new System.Drawing.Point(6, 97);
            this.lblFechaHastaPedido.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaHastaPedido.Name = "lblFechaHastaPedido";
            this.lblFechaHastaPedido.Size = new System.Drawing.Size(107, 18);
            this.lblFechaHastaPedido.TabIndex = 2;
            this.lblFechaHastaPedido.Text = "Fecha Hasta:";
            // 
            // lblReportesVenta
            // 
            this.lblReportesVenta.AutoSize = true;
            this.lblReportesVenta.Depth = 0;
            this.lblReportesVenta.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportesVenta.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblReportesVenta.Location = new System.Drawing.Point(31, 24);
            this.lblReportesVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblReportesVenta.Name = "lblReportesVenta";
            this.lblReportesVenta.Size = new System.Drawing.Size(82, 18);
            this.lblReportesVenta.TabIndex = 1;
            this.lblReportesVenta.Text = "Reportes:";
            // 
            // lblFechaDesdeVenta
            // 
            this.lblFechaDesdeVenta.AutoSize = true;
            this.lblFechaDesdeVenta.Depth = 0;
            this.lblFechaDesdeVenta.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesdeVenta.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFechaDesdeVenta.Location = new System.Drawing.Point(3, 58);
            this.lblFechaDesdeVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaDesdeVenta.Name = "lblFechaDesdeVenta";
            this.lblFechaDesdeVenta.Size = new System.Drawing.Size(110, 18);
            this.lblFechaDesdeVenta.TabIndex = 2;
            this.lblFechaDesdeVenta.Text = "Fecha Desde:";
            // 
            // lblFechaHastaVenta
            // 
            this.lblFechaHastaVenta.AutoSize = true;
            this.lblFechaHastaVenta.Depth = 0;
            this.lblFechaHastaVenta.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHastaVenta.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFechaHastaVenta.Location = new System.Drawing.Point(6, 97);
            this.lblFechaHastaVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaHastaVenta.Name = "lblFechaHastaVenta";
            this.lblFechaHastaVenta.Size = new System.Drawing.Size(107, 18);
            this.lblFechaHastaVenta.TabIndex = 3;
            this.lblFechaHastaVenta.Text = "Fecha Hasta:";
            // 
            // txtPedidoFechaHasta
            // 
            this.txtPedidoFechaHasta.Depth = 0;
            this.txtPedidoFechaHasta.Hint = "";
            this.txtPedidoFechaHasta.Location = new System.Drawing.Point(119, 97);
            this.txtPedidoFechaHasta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPedidoFechaHasta.Name = "txtPedidoFechaHasta";
            this.txtPedidoFechaHasta.PasswordChar = '\0';
            this.txtPedidoFechaHasta.SelectedText = "";
            this.txtPedidoFechaHasta.SelectionLength = 0;
            this.txtPedidoFechaHasta.SelectionStart = 0;
            this.txtPedidoFechaHasta.Size = new System.Drawing.Size(256, 23);
            this.txtPedidoFechaHasta.TabIndex = 3;
            this.txtPedidoFechaHasta.UseSystemPasswordChar = false;
            // 
            // txtPedidoFechaDesde
            // 
            this.txtPedidoFechaDesde.Depth = 0;
            this.txtPedidoFechaDesde.Hint = "";
            this.txtPedidoFechaDesde.Location = new System.Drawing.Point(119, 58);
            this.txtPedidoFechaDesde.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPedidoFechaDesde.Name = "txtPedidoFechaDesde";
            this.txtPedidoFechaDesde.PasswordChar = '\0';
            this.txtPedidoFechaDesde.SelectedText = "";
            this.txtPedidoFechaDesde.SelectionLength = 0;
            this.txtPedidoFechaDesde.SelectionStart = 0;
            this.txtPedidoFechaDesde.Size = new System.Drawing.Size(256, 23);
            this.txtPedidoFechaDesde.TabIndex = 4;
            this.txtPedidoFechaDesde.UseSystemPasswordChar = false;
            // 
            // txtFecDesdeVentas
            // 
            this.txtFecDesdeVentas.Depth = 0;
            this.txtFecDesdeVentas.Hint = "";
            this.txtFecDesdeVentas.Location = new System.Drawing.Point(119, 58);
            this.txtFecDesdeVentas.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFecDesdeVentas.Name = "txtFecDesdeVentas";
            this.txtFecDesdeVentas.PasswordChar = '\0';
            this.txtFecDesdeVentas.SelectedText = "";
            this.txtFecDesdeVentas.SelectionLength = 0;
            this.txtFecDesdeVentas.SelectionStart = 0;
            this.txtFecDesdeVentas.Size = new System.Drawing.Size(256, 23);
            this.txtFecDesdeVentas.TabIndex = 4;
            this.txtFecDesdeVentas.UseSystemPasswordChar = false;
            // 
            // txtFecHastaVentas
            // 
            this.txtFecHastaVentas.Depth = 0;
            this.txtFecHastaVentas.Hint = "";
            this.txtFecHastaVentas.Location = new System.Drawing.Point(119, 97);
            this.txtFecHastaVentas.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFecHastaVentas.Name = "txtFecHastaVentas";
            this.txtFecHastaVentas.PasswordChar = '\0';
            this.txtFecHastaVentas.SelectedText = "";
            this.txtFecHastaVentas.SelectionLength = 0;
            this.txtFecHastaVentas.SelectionStart = 0;
            this.txtFecHastaVentas.Size = new System.Drawing.Size(256, 23);
            this.txtFecHastaVentas.TabIndex = 5;
            this.txtFecHastaVentas.UseSystemPasswordChar = false;
            // 
            // btnGeneraReportePedido
            // 
            this.btnGeneraReportePedido.AutoSize = true;
            this.btnGeneraReportePedido.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGeneraReportePedido.Depth = 0;
            this.btnGeneraReportePedido.Location = new System.Drawing.Point(239, 148);
            this.btnGeneraReportePedido.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGeneraReportePedido.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGeneraReportePedido.Name = "btnGeneraReportePedido";
            this.btnGeneraReportePedido.Primary = false;
            this.btnGeneraReportePedido.Size = new System.Drawing.Size(136, 36);
            this.btnGeneraReportePedido.TabIndex = 5;
            this.btnGeneraReportePedido.Text = "Generar Reporte";
            this.btnGeneraReportePedido.UseVisualStyleBackColor = true;
            this.btnGeneraReportePedido.Click += new System.EventHandler(this.btnGeneraReportePedido_Click);
            // 
            // btnGeneraReporteVentas
            // 
            this.btnGeneraReporteVentas.AutoSize = true;
            this.btnGeneraReporteVentas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGeneraReporteVentas.Depth = 0;
            this.btnGeneraReporteVentas.Location = new System.Drawing.Point(239, 148);
            this.btnGeneraReporteVentas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGeneraReporteVentas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGeneraReporteVentas.Name = "btnGeneraReporteVentas";
            this.btnGeneraReporteVentas.Primary = false;
            this.btnGeneraReporteVentas.Size = new System.Drawing.Size(136, 36);
            this.btnGeneraReporteVentas.TabIndex = 6;
            this.btnGeneraReporteVentas.Text = "Generar Reporte";
            this.btnGeneraReporteVentas.UseVisualStyleBackColor = true;
            this.btnGeneraReporteVentas.Click += new System.EventHandler(this.btnGeneraReporteVentas_Click);
            // 
            // frmReporteSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(419, 320);
            this.Controls.Add(this.tabSelector);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReporteSeleccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione un Reporte";
            this.tabControl.ResumeLayout(false);
            this.tabPedidos.ResumeLayout(false);
            this.tabPedidos.PerformLayout();
            this.tabVentas.ResumeLayout(false);
            this.tabVentas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxPedidosReportes;
        private System.Windows.Forms.ComboBox cmbxVentasReportes;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage tabPedidos;
        private System.Windows.Forms.TabPage tabVentas;
        private MaterialSkin.Controls.MaterialTabSelector tabSelector;
        private MaterialSkin.Controls.MaterialFlatButton btnGeneraReportePedido;
        private MaterialSkin.Controls.MaterialLabel lblFechaHastaPedido;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPedidoFechaHasta;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPedidoFechaDesde;
        private MaterialSkin.Controls.MaterialLabel lblFechaDesdePedido;
        private MaterialSkin.Controls.MaterialLabel lblReportesPedidos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFecHastaVentas;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFecDesdeVentas;
        private MaterialSkin.Controls.MaterialLabel lblFechaHastaVenta;
        private MaterialSkin.Controls.MaterialLabel lblFechaDesdeVenta;
        private MaterialSkin.Controls.MaterialLabel lblReportesVenta;
        private MaterialSkin.Controls.MaterialFlatButton btnGeneraReporteVentas;
    }
}