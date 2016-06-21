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
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPedidos = new System.Windows.Forms.TabPage();
            this.btnGeneraReportePedido = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblFechaHastaPedido = new MaterialSkin.Controls.MaterialLabel();
            this.txtPedidoFechaHasta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPedidoFechaDesde = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblFechaDesdePedido = new MaterialSkin.Controls.MaterialLabel();
            this.lblReportesPedidos = new MaterialSkin.Controls.MaterialLabel();
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.btnGeneraReporteVentas = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtFecHastaVentas = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtFecDesdeVentas = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblFechaHastaVenta = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaDesdeVenta = new MaterialSkin.Controls.MaterialLabel();
            this.tabInventario = new System.Windows.Forms.TabPage();
            this.tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.cmbxVentasReportes = new System.Windows.Forms.ComboBox();
            this.lblReportesVenta = new MaterialSkin.Controls.MaterialLabel();
            this.cmbxInventarioReportes = new System.Windows.Forms.ComboBox();
            this.lblReportesInventario = new MaterialSkin.Controls.MaterialLabel();
            this.btnGeneraReporteInvenario = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabControl.SuspendLayout();
            this.tabPedidos.SuspendLayout();
            this.tabVentas.SuspendLayout();
            this.tabInventario.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbxPedidosReportes
            // 
            this.cmbxPedidosReportes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxPedidosReportes.FormattingEnabled = true;
            this.cmbxPedidosReportes.Location = new System.Drawing.Point(119, 25);
            this.cmbxPedidosReportes.Name = "cmbxPedidosReportes";
            this.cmbxPedidosReportes.Size = new System.Drawing.Size(254, 21);
            this.cmbxPedidosReportes.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPedidos);
            this.tabControl.Controls.Add(this.tabVentas);
            this.tabControl.Controls.Add(this.tabInventario);
            this.tabControl.Depth = 0;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 33);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(392, 221);
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
            this.tabPedidos.Size = new System.Drawing.Size(384, 195);
            this.tabPedidos.TabIndex = 0;
            this.tabPedidos.Text = "Pedidos";
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
            // lblFechaHastaPedido
            // 
            this.lblFechaHastaPedido.AutoSize = true;
            this.lblFechaHastaPedido.Depth = 0;
            this.lblFechaHastaPedido.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaHastaPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaHastaPedido.Location = new System.Drawing.Point(6, 97);
            this.lblFechaHastaPedido.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaHastaPedido.Name = "lblFechaHastaPedido";
            this.lblFechaHastaPedido.Size = new System.Drawing.Size(97, 19);
            this.lblFechaHastaPedido.TabIndex = 2;
            this.lblFechaHastaPedido.Text = "Fecha Hasta:";
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
            // lblFechaDesdePedido
            // 
            this.lblFechaDesdePedido.AutoSize = true;
            this.lblFechaDesdePedido.Depth = 0;
            this.lblFechaDesdePedido.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaDesdePedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaDesdePedido.Location = new System.Drawing.Point(3, 58);
            this.lblFechaDesdePedido.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaDesdePedido.Name = "lblFechaDesdePedido";
            this.lblFechaDesdePedido.Size = new System.Drawing.Size(99, 19);
            this.lblFechaDesdePedido.TabIndex = 1;
            this.lblFechaDesdePedido.Text = "Fecha Desde:";
            // 
            // lblReportesPedidos
            // 
            this.lblReportesPedidos.AutoSize = true;
            this.lblReportesPedidos.Depth = 0;
            this.lblReportesPedidos.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblReportesPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblReportesPedidos.Location = new System.Drawing.Point(31, 24);
            this.lblReportesPedidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblReportesPedidos.Name = "lblReportesPedidos";
            this.lblReportesPedidos.Size = new System.Drawing.Size(73, 19);
            this.lblReportesPedidos.TabIndex = 0;
            this.lblReportesPedidos.Text = "Reportes:";
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.cmbxVentasReportes);
            this.tabVentas.Controls.Add(this.lblReportesVenta);
            this.tabVentas.Controls.Add(this.btnGeneraReporteVentas);
            this.tabVentas.Controls.Add(this.txtFecHastaVentas);
            this.tabVentas.Controls.Add(this.txtFecDesdeVentas);
            this.tabVentas.Controls.Add(this.lblFechaHastaVenta);
            this.tabVentas.Controls.Add(this.lblFechaDesdeVenta);
            this.tabVentas.Location = new System.Drawing.Point(4, 22);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVentas.Size = new System.Drawing.Size(384, 195);
            this.tabVentas.TabIndex = 1;
            this.tabVentas.Text = "Ventas";
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
            // lblFechaHastaVenta
            // 
            this.lblFechaHastaVenta.AutoSize = true;
            this.lblFechaHastaVenta.Depth = 0;
            this.lblFechaHastaVenta.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaHastaVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaHastaVenta.Location = new System.Drawing.Point(6, 97);
            this.lblFechaHastaVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaHastaVenta.Name = "lblFechaHastaVenta";
            this.lblFechaHastaVenta.Size = new System.Drawing.Size(97, 19);
            this.lblFechaHastaVenta.TabIndex = 3;
            this.lblFechaHastaVenta.Text = "Fecha Hasta:";
            // 
            // lblFechaDesdeVenta
            // 
            this.lblFechaDesdeVenta.AutoSize = true;
            this.lblFechaDesdeVenta.Depth = 0;
            this.lblFechaDesdeVenta.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaDesdeVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaDesdeVenta.Location = new System.Drawing.Point(3, 58);
            this.lblFechaDesdeVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaDesdeVenta.Name = "lblFechaDesdeVenta";
            this.lblFechaDesdeVenta.Size = new System.Drawing.Size(99, 19);
            this.lblFechaDesdeVenta.TabIndex = 2;
            this.lblFechaDesdeVenta.Text = "Fecha Desde:";
            // 
            // tabInventario
            // 
            this.tabInventario.Controls.Add(this.cmbxInventarioReportes);
            this.tabInventario.Controls.Add(this.lblReportesInventario);
            this.tabInventario.Controls.Add(this.btnGeneraReporteInvenario);
            this.tabInventario.Location = new System.Drawing.Point(4, 22);
            this.tabInventario.Name = "tabInventario";
            this.tabInventario.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventario.Size = new System.Drawing.Size(384, 195);
            this.tabInventario.TabIndex = 2;
            this.tabInventario.Text = "Inventario";
            this.tabInventario.UseVisualStyleBackColor = true;
            // 
            // tabSelector
            // 
            this.tabSelector.BaseTabControl = this.tabControl;
            this.tabSelector.Depth = 0;
            this.tabSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSelector.Location = new System.Drawing.Point(0, 0);
            this.tabSelector.Margin = new System.Windows.Forms.Padding(0);
            this.tabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelector.Name = "tabSelector";
            this.tabSelector.Size = new System.Drawing.Size(398, 30);
            this.tabSelector.TabIndex = 2;
            this.tabSelector.Text = "materialTabSelector1";
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.BackColor = System.Drawing.Color.White;
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.tabSelector, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tabControl, 0, 1);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 61);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(398, 257);
            this.tlpPrincipal.TabIndex = 3;
            // 
            // cmbxVentasReportes
            // 
            this.cmbxVentasReportes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxVentasReportes.FormattingEnabled = true;
            this.cmbxVentasReportes.Location = new System.Drawing.Point(119, 21);
            this.cmbxVentasReportes.Name = "cmbxVentasReportes";
            this.cmbxVentasReportes.Size = new System.Drawing.Size(254, 21);
            this.cmbxVentasReportes.TabIndex = 7;
            // 
            // lblReportesVenta
            // 
            this.lblReportesVenta.AutoSize = true;
            this.lblReportesVenta.Depth = 0;
            this.lblReportesVenta.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblReportesVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblReportesVenta.Location = new System.Drawing.Point(31, 20);
            this.lblReportesVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblReportesVenta.Name = "lblReportesVenta";
            this.lblReportesVenta.Size = new System.Drawing.Size(73, 19);
            this.lblReportesVenta.TabIndex = 8;
            this.lblReportesVenta.Text = "Reportes:";
            // 
            // cmbxInventarioReportes
            // 
            this.cmbxInventarioReportes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxInventarioReportes.FormattingEnabled = true;
            this.cmbxInventarioReportes.Location = new System.Drawing.Point(99, 26);
            this.cmbxInventarioReportes.Name = "cmbxInventarioReportes";
            this.cmbxInventarioReportes.Size = new System.Drawing.Size(254, 21);
            this.cmbxInventarioReportes.TabIndex = 10;
            // 
            // lblReportesInventario
            // 
            this.lblReportesInventario.AutoSize = true;
            this.lblReportesInventario.Depth = 0;
            this.lblReportesInventario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblReportesInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblReportesInventario.Location = new System.Drawing.Point(11, 25);
            this.lblReportesInventario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblReportesInventario.Name = "lblReportesInventario";
            this.lblReportesInventario.Size = new System.Drawing.Size(73, 19);
            this.lblReportesInventario.TabIndex = 11;
            this.lblReportesInventario.Text = "Reportes:";
            // 
            // btnGeneraReporteInvenario
            // 
            this.btnGeneraReporteInvenario.AutoSize = true;
            this.btnGeneraReporteInvenario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGeneraReporteInvenario.Depth = 0;
            this.btnGeneraReporteInvenario.Location = new System.Drawing.Point(219, 153);
            this.btnGeneraReporteInvenario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGeneraReporteInvenario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGeneraReporteInvenario.Name = "btnGeneraReporteInvenario";
            this.btnGeneraReporteInvenario.Primary = false;
            this.btnGeneraReporteInvenario.Size = new System.Drawing.Size(136, 36);
            this.btnGeneraReporteInvenario.TabIndex = 9;
            this.btnGeneraReporteInvenario.Text = "Generar Reporte";
            this.btnGeneraReporteInvenario.UseVisualStyleBackColor = true;
            this.btnGeneraReporteInvenario.Click += new System.EventHandler(this.btnGeneraReporteInvenario_Click);
            // 
            // frmReporteSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(398, 318);
            this.Controls.Add(this.tlpPrincipal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReporteSeleccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione un Reporte";
            this.Move += new System.EventHandler(this.frmReporteSeleccion_Move);
            this.tabControl.ResumeLayout(false);
            this.tabPedidos.ResumeLayout(false);
            this.tabPedidos.PerformLayout();
            this.tabVentas.ResumeLayout(false);
            this.tabVentas.PerformLayout();
            this.tabInventario.ResumeLayout(false);
            this.tabInventario.PerformLayout();
            this.tlpPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxPedidosReportes;
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
        private MaterialSkin.Controls.MaterialFlatButton btnGeneraReporteVentas;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TabPage tabInventario;
        private System.Windows.Forms.ComboBox cmbxVentasReportes;
        private MaterialSkin.Controls.MaterialLabel lblReportesVenta;
        private System.Windows.Forms.ComboBox cmbxInventarioReportes;
        private MaterialSkin.Controls.MaterialLabel lblReportesInventario;
        private MaterialSkin.Controls.MaterialFlatButton btnGeneraReporteInvenario;
    }
}