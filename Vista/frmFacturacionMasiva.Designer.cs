namespace Vista
{
    partial class frmFacturacionMasiva
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buscarComprobantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parámetrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpContenedor = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvComprSinFact = new System.Windows.Forms.DataGridView();
            this.colFecPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacturar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxCantidadFact = new System.Windows.Forms.TextBox();
            this.lblCantidadFact = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpFechaFacturacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFactura = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.rbutFCA = new System.Windows.Forms.RadioButton();
            this.rbutFCB = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.rbutNCA = new System.Windows.Forms.RadioButton();
            this.rbutNCB = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tlpContenedor.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprSinFact)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarComprobantesToolStripMenuItem,
            this.parámetrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(926, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buscarComprobantesToolStripMenuItem
            // 
            this.buscarComprobantesToolStripMenuItem.Name = "buscarComprobantesToolStripMenuItem";
            this.buscarComprobantesToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.buscarComprobantesToolStripMenuItem.Text = "Buscar Comprobantes";
            this.buscarComprobantesToolStripMenuItem.Click += new System.EventHandler(this.buscarComprobantesToolStripMenuItem_Click);
            // 
            // parámetrosToolStripMenuItem
            // 
            this.parámetrosToolStripMenuItem.Name = "parámetrosToolStripMenuItem";
            this.parámetrosToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.parámetrosToolStripMenuItem.Text = "Preferencias";
            this.parámetrosToolStripMenuItem.Click += new System.EventHandler(this.parámetrosToolStripMenuItem_Click);
            // 
            // tlpContenedor
            // 
            this.tlpContenedor.ColumnCount = 1;
            this.tlpContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContenedor.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenedor.Location = new System.Drawing.Point(0, 24);
            this.tlpContenedor.Name = "tlpContenedor";
            this.tlpContenedor.RowCount = 1;
            this.tlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContenedor.Size = new System.Drawing.Size(926, 478);
            this.tlpContenedor.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.dgvComprSinFact, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(920, 472);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvComprSinFact
            // 
            this.dgvComprSinFact.AllowUserToAddRows = false;
            this.dgvComprSinFact.AllowUserToDeleteRows = false;
            this.dgvComprSinFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprSinFact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFecPedido,
            this.colNroPedido,
            this.colTipoComprobante,
            this.colCliente,
            this.colCuit,
            this.colMonto,
            this.colFacturar});
            this.dgvComprSinFact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComprSinFact.Location = new System.Drawing.Point(49, 26);
            this.dgvComprSinFact.Name = "dgvComprSinFact";
            this.dgvComprSinFact.ReadOnly = true;
            this.dgvComprSinFact.Size = new System.Drawing.Size(638, 324);
            this.dgvComprSinFact.TabIndex = 0;
            this.dgvComprSinFact.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComprSinFact_RowLeave);
            // 
            // colFecPedido
            // 
            this.colFecPedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFecPedido.FillWeight = 45F;
            this.colFecPedido.HeaderText = "Fecha Pedido";
            this.colFecPedido.MinimumWidth = 60;
            this.colFecPedido.Name = "colFecPedido";
            this.colFecPedido.ReadOnly = true;
            // 
            // colNroPedido
            // 
            this.colNroPedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNroPedido.FillWeight = 42.41983F;
            this.colNroPedido.HeaderText = "Num. Pedido";
            this.colNroPedido.Name = "colNroPedido";
            this.colNroPedido.ReadOnly = true;
            // 
            // colTipoComprobante
            // 
            this.colTipoComprobante.HeaderText = "Tipo Comprobante";
            this.colTipoComprobante.Name = "colTipoComprobante";
            this.colTipoComprobante.ReadOnly = true;
            this.colTipoComprobante.Width = 75;
            // 
            // colCliente
            // 
            this.colCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCliente.FillWeight = 80.83965F;
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            // 
            // colCuit
            // 
            this.colCuit.HeaderText = "Cuit";
            this.colCuit.Name = "colCuit";
            this.colCuit.ReadOnly = true;
            this.colCuit.Width = 75;
            // 
            // colMonto
            // 
            this.colMonto.DividerWidth = 1;
            this.colMonto.HeaderText = "Monto";
            this.colMonto.Name = "colMonto";
            this.colMonto.ReadOnly = true;
            this.colMonto.Width = 50;
            // 
            // colFacturar
            // 
            this.colFacturar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFacturar.DividerWidth = 5;
            this.colFacturar.FillWeight = 21.20991F;
            this.colFacturar.HeaderText = "Facturar?";
            this.colFacturar.MinimumWidth = 25;
            this.colFacturar.Name = "colFacturar";
            this.colFacturar.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.chkTodos, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(693, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(224, 324);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkTodos.Location = new System.Drawing.Point(3, 259);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(110, 42);
            this.chkTodos.TabIndex = 0;
            this.chkTodos.Text = "Seleccionar Todo";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel4.Controls.Add(this.tbxCantidadFact, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblCantidadFact, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 163);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(162, 42);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tbxCantidadFact
            // 
            this.tbxCantidadFact.Enabled = false;
            this.tbxCantidadFact.Location = new System.Drawing.Point(3, 3);
            this.tbxCantidadFact.Name = "tbxCantidadFact";
            this.tbxCantidadFact.Size = new System.Drawing.Size(34, 20);
            this.tbxCantidadFact.TabIndex = 0;
            // 
            // lblCantidadFact
            // 
            this.lblCantidadFact.AutoSize = true;
            this.lblCantidadFact.Location = new System.Drawing.Point(43, 0);
            this.lblCantidadFact.Name = "lblCantidadFact";
            this.lblCantidadFact.Size = new System.Drawing.Size(100, 13);
            this.lblCantidadFact.TabIndex = 1;
            this.lblCantidadFact.Text = "Cantidad a Facturar";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.Controls.Add(this.dtpFechaFacturacion, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblFechaFactura, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(162, 42);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // dtpFechaFacturacion
            // 
            this.dtpFechaFacturacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaFacturacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFacturacion.Location = new System.Drawing.Point(67, 11);
            this.dtpFechaFacturacion.Name = "dtpFechaFacturacion";
            this.dtpFechaFacturacion.Size = new System.Drawing.Size(92, 20);
            this.dtpFechaFacturacion.TabIndex = 12;
            // 
            // lblFechaFactura
            // 
            this.lblFechaFactura.AutoSize = true;
            this.lblFechaFactura.Location = new System.Drawing.Point(3, 0);
            this.lblFechaFactura.Name = "lblFechaFactura";
            this.lblFechaFactura.Size = new System.Drawing.Size(49, 26);
            this.lblFechaFactura.TabIndex = 13;
            this.lblFechaFactura.Text = "Fecha a Facturar:";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.rbutFCA, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.rbutFCB, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 67);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(218, 42);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // rbutFCA
            // 
            this.rbutFCA.AutoSize = true;
            this.rbutFCA.Location = new System.Drawing.Point(3, 3);
            this.rbutFCA.Name = "rbutFCA";
            this.rbutFCA.Size = new System.Drawing.Size(76, 15);
            this.rbutFCA.TabIndex = 0;
            this.rbutFCA.TabStop = true;
            this.rbutFCA.Text = "Facturas A";
            this.rbutFCA.UseVisualStyleBackColor = true;
            // 
            // rbutFCB
            // 
            this.rbutFCB.AutoSize = true;
            this.rbutFCB.Location = new System.Drawing.Point(3, 24);
            this.rbutFCB.Name = "rbutFCB";
            this.rbutFCB.Size = new System.Drawing.Size(76, 15);
            this.rbutFCB.TabIndex = 1;
            this.rbutFCB.TabStop = true;
            this.rbutFCB.Text = "Facturas B";
            this.rbutFCB.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.rbutNCA, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.rbutNCB, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 115);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(218, 42);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // rbutNCA
            // 
            this.rbutNCA.AutoSize = true;
            this.rbutNCA.Location = new System.Drawing.Point(3, 3);
            this.rbutNCA.Name = "rbutNCA";
            this.rbutNCA.Size = new System.Drawing.Size(114, 15);
            this.rbutNCA.TabIndex = 0;
            this.rbutNCA.TabStop = true;
            this.rbutNCA.Text = "Notas de Crédito A";
            this.rbutNCA.UseVisualStyleBackColor = true;
            // 
            // rbutNCB
            // 
            this.rbutNCB.AutoSize = true;
            this.rbutNCB.Location = new System.Drawing.Point(3, 24);
            this.rbutNCB.Name = "rbutNCB";
            this.rbutNCB.Size = new System.Drawing.Size(114, 15);
            this.rbutNCB.TabIndex = 1;
            this.rbutNCB.TabStop = true;
            this.rbutNCB.Text = "Notas de Crédito B";
            this.rbutNCB.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Controls.Add(this.btnFacturar, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnSalir, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(49, 356);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(638, 88);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(98, 33);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(75, 20);
            this.btnFacturar.TabIndex = 0;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(321, 33);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 20);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmFacturacionMasiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 502);
            this.Controls.Add(this.tlpContenedor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFacturacionMasiva";
            this.Text = "frmFacturacionMasiva";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tlpContenedor.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprSinFact)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buscarComprobantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parámetrosToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tlpContenedor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvComprSinFact;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox tbxCantidadFact;
        private System.Windows.Forms.Label lblCantidadFact;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DateTimePicker dtpFechaFacturacion;
        private System.Windows.Forms.Label lblFechaFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colFacturar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.RadioButton rbutFCA;
        private System.Windows.Forms.RadioButton rbutFCB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.RadioButton rbutNCA;
        private System.Windows.Forms.RadioButton rbutNCB;
    }
}