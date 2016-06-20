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
            this.tlpContenedor = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvComprSinFact = new System.Windows.Forms.DataGridView();
            this.indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacturar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCantidadFact = new System.Windows.Forms.Label();
            this.tbxCantidadFact = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpFechaFacturacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFactura = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.chkTodos = new MaterialSkin.Controls.MaterialCheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFacturar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialFlatButton();
            this.buscarComprobantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parámetrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chbxFCA = new MaterialSkin.Controls.MaterialCheckBox();
            this.chbxFCB = new MaterialSkin.Controls.MaterialCheckBox();
            this.chbxNCA = new MaterialSkin.Controls.MaterialCheckBox();
            this.chbxNCB = new MaterialSkin.Controls.MaterialCheckBox();
            this.tlpContenedor.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprSinFact)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpContenedor
            // 
            this.tlpContenedor.BackColor = System.Drawing.Color.White;
            this.tlpContenedor.ColumnCount = 1;
            this.tlpContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContenedor.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpContenedor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpContenedor.Location = new System.Drawing.Point(0, 64);
            this.tlpContenedor.Name = "tlpContenedor";
            this.tlpContenedor.RowCount = 1;
            this.tlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContenedor.Size = new System.Drawing.Size(926, 478);
            this.tlpContenedor.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.68421F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tableLayoutPanel1.Controls.Add(this.dgvComprSinFact, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(920, 472);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvComprSinFact
            // 
            this.dgvComprSinFact.AllowUserToAddRows = false;
            this.dgvComprSinFact.AllowUserToDeleteRows = false;
            this.dgvComprSinFact.AllowUserToOrderColumns = true;
            this.dgvComprSinFact.AllowUserToResizeRows = false;
            this.dgvComprSinFact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComprSinFact.BackgroundColor = System.Drawing.Color.White;
            this.dgvComprSinFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprSinFact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indice,
            this.colFecPedido,
            this.colNroPedido,
            this.colTipoComprobante,
            this.colCliente,
            this.colCuit,
            this.colMonto,
            this.colFacturar});
            this.dgvComprSinFact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComprSinFact.GridColor = System.Drawing.Color.White;
            this.dgvComprSinFact.Location = new System.Drawing.Point(3, 3);
            this.dgvComprSinFact.Name = "dgvComprSinFact";
            this.dgvComprSinFact.RowHeadersVisible = false;
            this.dgvComprSinFact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComprSinFact.Size = new System.Drawing.Size(671, 361);
            this.dgvComprSinFact.TabIndex = 0;
            this.dgvComprSinFact.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComprSinFact_CellValueChanged);
            this.dgvComprSinFact.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvComprSinFact_CurrentCellDirtyStateChanged);
            // 
            // indice
            // 
            this.indice.DataPropertyName = "indice";
            this.indice.HeaderText = "indice";
            this.indice.Name = "indice";
            this.indice.Visible = false;
            // 
            // colFecPedido
            // 
            this.colFecPedido.DataPropertyName = "colFecPedido";
            this.colFecPedido.FillWeight = 45F;
            this.colFecPedido.HeaderText = "Fecha Pedido";
            this.colFecPedido.MinimumWidth = 60;
            this.colFecPedido.Name = "colFecPedido";
            this.colFecPedido.ReadOnly = true;
            // 
            // colNroPedido
            // 
            this.colNroPedido.DataPropertyName = "colNroPedido";
            this.colNroPedido.FillWeight = 42.41983F;
            this.colNroPedido.HeaderText = "Num. Pedido";
            this.colNroPedido.Name = "colNroPedido";
            this.colNroPedido.ReadOnly = true;
            // 
            // colTipoComprobante
            // 
            this.colTipoComprobante.DataPropertyName = "colTipoComprobante";
            this.colTipoComprobante.HeaderText = "Tipo Comprobante";
            this.colTipoComprobante.Name = "colTipoComprobante";
            this.colTipoComprobante.ReadOnly = true;
            // 
            // colCliente
            // 
            this.colCliente.DataPropertyName = "colCliente";
            this.colCliente.FillWeight = 80.83965F;
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            // 
            // colCuit
            // 
            this.colCuit.DataPropertyName = "colCuit";
            this.colCuit.HeaderText = "Cuit";
            this.colCuit.Name = "colCuit";
            this.colCuit.ReadOnly = true;
            // 
            // colMonto
            // 
            this.colMonto.DataPropertyName = "colMonto";
            this.colMonto.HeaderText = "Monto";
            this.colMonto.Name = "colMonto";
            this.colMonto.ReadOnly = true;
            // 
            // colFacturar
            // 
            this.colFacturar.DataPropertyName = "colFacturar";
            this.colFacturar.FillWeight = 21.20991F;
            this.colFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colFacturar.HeaderText = "Facturar?";
            this.colFacturar.MinimumWidth = 25;
            this.colFacturar.Name = "colFacturar";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.chkTodos, 0, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(680, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.96399F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.216067F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.695291F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(237, 361);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.04361F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.95639F));
            this.tableLayoutPanel4.Controls.Add(this.lblCantidadFact, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tbxCantidadFact, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 202);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(231, 29);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // lblCantidadFact
            // 
            this.lblCantidadFact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidadFact.AutoSize = true;
            this.lblCantidadFact.Location = new System.Drawing.Point(90, 8);
            this.lblCantidadFact.Name = "lblCantidadFact";
            this.lblCantidadFact.Size = new System.Drawing.Size(138, 13);
            this.lblCantidadFact.TabIndex = 1;
            this.lblCantidadFact.Text = "Cantidad a Facturar";
            // 
            // tbxCantidadFact
            // 
            this.tbxCantidadFact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCantidadFact.Depth = 0;
            this.tbxCantidadFact.Enabled = false;
            this.tbxCantidadFact.Hint = "";
            this.tbxCantidadFact.Location = new System.Drawing.Point(3, 3);
            this.tbxCantidadFact.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbxCantidadFact.Name = "tbxCantidadFact";
            this.tbxCantidadFact.PasswordChar = '\0';
            this.tbxCantidadFact.SelectedText = "";
            this.tbxCantidadFact.SelectionLength = 0;
            this.tbxCantidadFact.SelectionStart = 0;
            this.tbxCantidadFact.Size = new System.Drawing.Size(81, 23);
            this.tbxCantidadFact.TabIndex = 2;
            this.tbxCantidadFact.UseSystemPasswordChar = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.30917F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.69083F));
            this.tableLayoutPanel5.Controls.Add(this.dtpFechaFacturacion, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblFechaFactura, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(231, 48);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // dtpFechaFacturacion
            // 
            this.dtpFechaFacturacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaFacturacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFacturacion.Location = new System.Drawing.Point(114, 14);
            this.dtpFechaFacturacion.Name = "dtpFechaFacturacion";
            this.dtpFechaFacturacion.Size = new System.Drawing.Size(114, 20);
            this.dtpFechaFacturacion.TabIndex = 12;
            // 
            // lblFechaFactura
            // 
            this.lblFechaFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaFactura.AutoSize = true;
            this.lblFechaFactura.Location = new System.Drawing.Point(3, 17);
            this.lblFechaFactura.Name = "lblFechaFactura";
            this.lblFechaFactura.Size = new System.Drawing.Size(105, 13);
            this.lblFechaFactura.TabIndex = 13;
            this.lblFechaFactura.Text = "Fecha a Facturar:";
            this.lblFechaFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.chbxFCA, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.chbxFCB, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.chbxNCA, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.chbxNCB, 0, 3);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 75);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(231, 113);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // chkTodos
            // 
            this.chkTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTodos.AutoSize = true;
            this.chkTodos.Depth = 0;
            this.chkTodos.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkTodos.Location = new System.Drawing.Point(0, 300);
            this.chkTodos.Margin = new System.Windows.Forms.Padding(0);
            this.chkTodos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkTodos.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Ripple = true;
            this.chkTodos.Size = new System.Drawing.Size(237, 30);
            this.chkTodos.TabIndex = 5;
            this.chkTodos.Text = "Seleccionar Todo";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
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
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 370);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(671, 99);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFacturar.AutoSize = true;
            this.btnFacturar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFacturar.Depth = 0;
            this.btnFacturar.Location = new System.Drawing.Point(104, 40);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFacturar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Primary = false;
            this.btnFacturar.Size = new System.Drawing.Size(226, 17);
            this.btnFacturar.TabIndex = 2;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(338, 40);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = false;
            this.btnSalir.Size = new System.Drawing.Size(226, 17);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // buscarComprobantesToolStripMenuItem
            // 
            this.buscarComprobantesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.buscarComprobantesToolStripMenuItem.Name = "buscarComprobantesToolStripMenuItem";
            this.buscarComprobantesToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.buscarComprobantesToolStripMenuItem.Text = "Buscar Comprobantes";
            this.buscarComprobantesToolStripMenuItem.Click += new System.EventHandler(this.buscarComprobantesToolStripMenuItem_Click);
            // 
            // parámetrosToolStripMenuItem
            // 
            this.parámetrosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.parámetrosToolStripMenuItem.Name = "parámetrosToolStripMenuItem";
            this.parámetrosToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.parámetrosToolStripMenuItem.Text = "Preferencias";
            this.parámetrosToolStripMenuItem.Click += new System.EventHandler(this.parámetrosToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarComprobantesToolStripMenuItem,
            this.parámetrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(926, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chbxFCA
            // 
            this.chbxFCA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chbxFCA.AutoSize = true;
            this.chbxFCA.Depth = 0;
            this.chbxFCA.Font = new System.Drawing.Font("Roboto", 10F);
            this.chbxFCA.Location = new System.Drawing.Point(0, 0);
            this.chbxFCA.Margin = new System.Windows.Forms.Padding(0);
            this.chbxFCA.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chbxFCA.MouseState = MaterialSkin.MouseState.HOVER;
            this.chbxFCA.Name = "chbxFCA";
            this.chbxFCA.Ripple = true;
            this.chbxFCA.Size = new System.Drawing.Size(231, 28);
            this.chbxFCA.TabIndex = 4;
            this.chbxFCA.Text = "Factura A";
            this.chbxFCA.UseVisualStyleBackColor = true;
            // 
            // chbxFCB
            // 
            this.chbxFCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chbxFCB.AutoSize = true;
            this.chbxFCB.Depth = 0;
            this.chbxFCB.Font = new System.Drawing.Font("Roboto", 10F);
            this.chbxFCB.Location = new System.Drawing.Point(0, 28);
            this.chbxFCB.Margin = new System.Windows.Forms.Padding(0);
            this.chbxFCB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chbxFCB.MouseState = MaterialSkin.MouseState.HOVER;
            this.chbxFCB.Name = "chbxFCB";
            this.chbxFCB.Ripple = true;
            this.chbxFCB.Size = new System.Drawing.Size(231, 28);
            this.chbxFCB.TabIndex = 5;
            this.chbxFCB.Text = "Factura B";
            this.chbxFCB.UseVisualStyleBackColor = true;
            // 
            // chbxNCA
            // 
            this.chbxNCA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chbxNCA.AutoSize = true;
            this.chbxNCA.Depth = 0;
            this.chbxNCA.Font = new System.Drawing.Font("Roboto", 10F);
            this.chbxNCA.Location = new System.Drawing.Point(0, 56);
            this.chbxNCA.Margin = new System.Windows.Forms.Padding(0);
            this.chbxNCA.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chbxNCA.MouseState = MaterialSkin.MouseState.HOVER;
            this.chbxNCA.Name = "chbxNCA";
            this.chbxNCA.Ripple = true;
            this.chbxNCA.Size = new System.Drawing.Size(231, 28);
            this.chbxNCA.TabIndex = 6;
            this.chbxNCA.Text = "Nota de Crédito A";
            this.chbxNCA.UseVisualStyleBackColor = true;
            // 
            // chbxNCB
            // 
            this.chbxNCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chbxNCB.AutoSize = true;
            this.chbxNCB.Depth = 0;
            this.chbxNCB.Font = new System.Drawing.Font("Roboto", 10F);
            this.chbxNCB.Location = new System.Drawing.Point(0, 84);
            this.chbxNCB.Margin = new System.Windows.Forms.Padding(0);
            this.chbxNCB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chbxNCB.MouseState = MaterialSkin.MouseState.HOVER;
            this.chbxNCB.Name = "chbxNCB";
            this.chbxNCB.Ripple = true;
            this.chbxNCB.Size = new System.Drawing.Size(231, 29);
            this.chbxNCB.TabIndex = 7;
            this.chbxNCB.Text = "Nota de Crédito B";
            this.chbxNCB.UseVisualStyleBackColor = true;
            // 
            // frmFacturacionMasiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 542);
            this.Controls.Add(this.tlpContenedor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFacturacionMasiva";
            this.Text = "Facturación";
            this.Move += new System.EventHandler(this.frmFacturacionMasiva_Move);
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
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContenedor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvComprSinFact;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblCantidadFact;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DateTimePicker dtpFechaFacturacion;
        private System.Windows.Forms.Label lblFechaFactura;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbxCantidadFact;
        private MaterialSkin.Controls.MaterialCheckBox chkTodos;
        private MaterialSkin.Controls.MaterialFlatButton btnFacturar;
        private MaterialSkin.Controls.MaterialFlatButton btnSalir;
        private System.Windows.Forms.ToolStripMenuItem buscarComprobantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parámetrosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colFacturar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private MaterialSkin.Controls.MaterialCheckBox chbxFCA;
        private MaterialSkin.Controls.MaterialCheckBox chbxFCB;
        private MaterialSkin.Controls.MaterialCheckBox chbxNCA;
        private MaterialSkin.Controls.MaterialCheckBox chbxNCB;
    }
}