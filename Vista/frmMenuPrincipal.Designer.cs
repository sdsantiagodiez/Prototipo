namespace Vista
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.pnlReportes = new System.Windows.Forms.Panel();
            this.btnEmitirReporte = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlABM = new System.Windows.Forms.Panel();
            this.btnABM = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlCompras = new System.Windows.Forms.Panel();
            this.btnPedidoProveedor = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlVentas = new System.Windows.Forms.Panel();
            this.btnFacturacion = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnDevolucion = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnVenta = new MaterialSkin.Controls.MaterialFlatButton();
            this.timerFechaHora = new System.Windows.Forms.Timer(this.components);
            this.cntxtMenuStripABM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.entidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artículosDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblNombreUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaLog = new MaterialSkin.Controls.MaterialLabel();
            this.lblHoraLog = new MaterialSkin.Controls.MaterialLabel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tblMainMenu = new System.Windows.Forms.TableLayoutPanel();
            this.tblMdiMenu = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.pnlReportes.SuspendLayout();
            this.pnlABM.SuspendLayout();
            this.pnlCompras.SuspendLayout();
            this.pnlVentas.SuspendLayout();
            this.cntxtMenuStripABM.SuspendLayout();
            this.tblMainMenu.SuspendLayout();
            this.tblMdiMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlReportes
            // 
            this.pnlReportes.BackColor = System.Drawing.Color.White;
            this.pnlReportes.Controls.Add(this.btnEmitirReporte);
            this.pnlReportes.Location = new System.Drawing.Point(3, 33);
            this.pnlReportes.Name = "pnlReportes";
            this.pnlReportes.Size = new System.Drawing.Size(234, 24);
            this.pnlReportes.TabIndex = 23;
            // 
            // btnEmitirReporte
            // 
            this.btnEmitirReporte.AutoSize = true;
            this.btnEmitirReporte.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEmitirReporte.Depth = 0;
            this.btnEmitirReporte.Location = new System.Drawing.Point(4, 6);
            this.btnEmitirReporte.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEmitirReporte.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEmitirReporte.Name = "btnEmitirReporte";
            this.btnEmitirReporte.Primary = false;
            this.btnEmitirReporte.Size = new System.Drawing.Size(119, 36);
            this.btnEmitirReporte.TabIndex = 1;
            this.btnEmitirReporte.Text = "Emitir Reporte";
            this.btnEmitirReporte.UseVisualStyleBackColor = true;
            this.btnEmitirReporte.Click += new System.EventHandler(this.btnEmitirReporte_Click);
            // 
            // pnlABM
            // 
            this.pnlABM.BackColor = System.Drawing.Color.White;
            this.pnlABM.Controls.Add(this.btnABM);
            this.pnlABM.Location = new System.Drawing.Point(198, 3);
            this.pnlABM.Name = "pnlABM";
            this.pnlABM.Size = new System.Drawing.Size(189, 13);
            this.pnlABM.TabIndex = 25;
            // 
            // btnABM
            // 
            this.btnABM.AutoSize = true;
            this.btnABM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnABM.Depth = 0;
            this.btnABM.Location = new System.Drawing.Point(0, 6);
            this.btnABM.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnABM.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnABM.Name = "btnABM";
            this.btnABM.Primary = false;
            this.btnABM.Size = new System.Drawing.Size(231, 36);
            this.btnABM.TabIndex = 1;
            this.btnABM.Text = "Altas, Bajas y Modificaciones";
            this.btnABM.UseVisualStyleBackColor = true;
            this.btnABM.Click += new System.EventHandler(this.btnABM_Click);
            // 
            // pnlCompras
            // 
            this.pnlCompras.BackColor = System.Drawing.Color.White;
            this.pnlCompras.Controls.Add(this.btnPedidoProveedor);
            this.pnlCompras.Location = new System.Drawing.Point(246, 3);
            this.pnlCompras.Name = "pnlCompras";
            this.pnlCompras.Size = new System.Drawing.Size(234, 50);
            this.pnlCompras.TabIndex = 26;
            // 
            // btnPedidoProveedor
            // 
            this.btnPedidoProveedor.AutoSize = true;
            this.btnPedidoProveedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPedidoProveedor.Depth = 0;
            this.btnPedidoProveedor.Location = new System.Drawing.Point(11, 6);
            this.btnPedidoProveedor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPedidoProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPedidoProveedor.Name = "btnPedidoProveedor";
            this.btnPedidoProveedor.Primary = false;
            this.btnPedidoProveedor.Size = new System.Drawing.Size(108, 36);
            this.btnPedidoProveedor.TabIndex = 3;
            this.btnPedidoProveedor.Text = "Nuevo Pedido";
            this.btnPedidoProveedor.UseVisualStyleBackColor = true;
            this.btnPedidoProveedor.Click += new System.EventHandler(this.btnPedidoProveedor_Click);
            // 
            // pnlVentas
            // 
            this.pnlVentas.BackColor = System.Drawing.Color.White;
            this.pnlVentas.Controls.Add(this.btnFacturacion);
            this.pnlVentas.Controls.Add(this.btnDevolucion);
            this.pnlVentas.Controls.Add(this.btnVenta);
            this.pnlVentas.Location = new System.Drawing.Point(3, 3);
            this.pnlVentas.Name = "pnlVentas";
            this.pnlVentas.Size = new System.Drawing.Size(234, 24);
            this.pnlVentas.TabIndex = 27;
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.AutoSize = true;
            this.btnFacturacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFacturacion.Depth = 0;
            this.btnFacturacion.Location = new System.Drawing.Point(37, 46);
            this.btnFacturacion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFacturacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Primary = false;
            this.btnFacturacion.Size = new System.Drawing.Size(105, 36);
            this.btnFacturacion.TabIndex = 31;
            this.btnFacturacion.Text = "Facturación";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.AutoSize = true;
            this.btnDevolucion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDevolucion.Depth = 0;
            this.btnDevolucion.Location = new System.Drawing.Point(4, 87);
            this.btnDevolucion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDevolucion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Primary = false;
            this.btnDevolucion.Size = new System.Drawing.Size(168, 36);
            this.btnDevolucion.TabIndex = 30;
            this.btnDevolucion.Text = "Procesar Devolución";
            this.btnDevolucion.UseVisualStyleBackColor = true;
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.AutoSize = true;
            this.btnVenta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVenta.Depth = 0;
            this.btnVenta.Location = new System.Drawing.Point(38, 6);
            this.btnVenta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Primary = false;
            this.btnVenta.Size = new System.Drawing.Size(104, 36);
            this.btnVenta.TabIndex = 29;
            this.btnVenta.Text = "Nueva Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // timerFechaHora
            // 
            this.timerFechaHora.Tick += new System.EventHandler(this.timerFechaHora_Tick);
            // 
            // cntxtMenuStripABM
            // 
            this.cntxtMenuStripABM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entidadesToolStripMenuItem,
            this.artículosToolStripMenuItem,
            this.artículosDeProveedoresToolStripMenuItem});
            this.cntxtMenuStripABM.Name = "cntxtMenuStripABM";
            this.cntxtMenuStripABM.Size = new System.Drawing.Size(206, 70);
            // 
            // entidadesToolStripMenuItem
            // 
            this.entidadesToolStripMenuItem.Name = "entidadesToolStripMenuItem";
            this.entidadesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.entidadesToolStripMenuItem.Text = "Entidades";
            this.entidadesToolStripMenuItem.Click += new System.EventHandler(this.entidadesToolStripMenuItem_Click);
            // 
            // artículosToolStripMenuItem
            // 
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            this.artículosToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.artículosToolStripMenuItem.Text = "Artículos";
            this.artículosToolStripMenuItem.Click += new System.EventHandler(this.artículosToolStripMenuItem_Click);
            // 
            // artículosDeProveedoresToolStripMenuItem
            // 
            this.artículosDeProveedoresToolStripMenuItem.Name = "artículosDeProveedoresToolStripMenuItem";
            this.artículosDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.artículosDeProveedoresToolStripMenuItem.Text = "Artículos de Proveedores";
            this.artículosDeProveedoresToolStripMenuItem.Click += new System.EventHandler(this.artículosDeProveedoresToolStripMenuItem_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalir.Location = new System.Drawing.Point(3, 3);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(189, 13);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Depth = 0;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombreUsuario.Location = new System.Drawing.Point(393, 0);
            this.lblNombreUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(63, 19);
            this.lblNombreUsuario.TabIndex = 30;
            this.lblNombreUsuario.Text = "Leandro";
            // 
            // lblFechaLog
            // 
            this.lblFechaLog.AutoSize = true;
            this.lblFechaLog.BackColor = System.Drawing.Color.White;
            this.lblFechaLog.Depth = 0;
            this.lblFechaLog.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaLog.Location = new System.Drawing.Point(588, 0);
            this.lblFechaLog.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaLog.Name = "lblFechaLog";
            this.lblFechaLog.Size = new System.Drawing.Size(85, 19);
            this.lblFechaLog.TabIndex = 31;
            this.lblFechaLog.Text = "23/10/2016";
            // 
            // lblHoraLog
            // 
            this.lblHoraLog.AutoSize = true;
            this.lblHoraLog.BackColor = System.Drawing.Color.White;
            this.lblHoraLog.Depth = 0;
            this.lblHoraLog.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblHoraLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHoraLog.Location = new System.Drawing.Point(783, 0);
            this.lblHoraLog.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHoraLog.Name = "lblHoraLog";
            this.lblHoraLog.Size = new System.Drawing.Size(65, 19);
            this.lblHoraLog.TabIndex = 32;
            this.lblHoraLog.Text = "18:01:57";
            // 
            // tblMainMenu
            // 
            this.tblMainMenu.ColumnCount = 1;
            this.tblMainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainMenu.Controls.Add(this.tblMdiMenu, 0, 2);
            this.tblMainMenu.Controls.Add(this.pnlVentas, 0, 0);
            this.tblMainMenu.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tblMainMenu.Controls.Add(this.pnlReportes, 0, 1);
            this.tblMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMainMenu.Location = new System.Drawing.Point(0, 0);
            this.tblMainMenu.Name = "tblMainMenu";
            this.tblMainMenu.RowCount = 4;
            this.tblMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblMainMenu.Size = new System.Drawing.Size(981, 587);
            this.tblMainMenu.TabIndex = 34;
            // 
            // tblMdiMenu
            // 
            this.tblMdiMenu.ColumnCount = 2;
            this.tblMdiMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMdiMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblMdiMenu.Controls.Add(this.pnlCompras, 1, 0);
            this.tblMdiMenu.Controls.Add(this.toolStrip1, 0, 0);
            this.tblMdiMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMdiMenu.Location = new System.Drawing.Point(3, 63);
            this.tblMdiMenu.Name = "tblMdiMenu";
            this.tblMdiMenu.RowCount = 1;
            this.tblMdiMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMdiMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMdiMenu.Size = new System.Drawing.Size(975, 496);
            this.tblMdiMenu.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pnlABM, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNombreUsuario, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblHoraLog, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFechaLog, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 565);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(975, 19);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(1);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(243, 496);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(241, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(241, 19);
            this.toolStripButton1.Text = "NUEVA VENTA";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(241, 24);
            this.toolStripButton2.Text = "EMITIR REPORTE";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 587);
            this.Controls.Add(this.tblMainMenu);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.Text = "Menú Principal";
            this.pnlReportes.ResumeLayout(false);
            this.pnlReportes.PerformLayout();
            this.pnlABM.ResumeLayout(false);
            this.pnlABM.PerformLayout();
            this.pnlCompras.ResumeLayout(false);
            this.pnlCompras.PerformLayout();
            this.pnlVentas.ResumeLayout(false);
            this.pnlVentas.PerformLayout();
            this.cntxtMenuStripABM.ResumeLayout(false);
            this.tblMainMenu.ResumeLayout(false);
            this.tblMdiMenu.ResumeLayout(false);
            this.tblMdiMenu.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlReportes;
        private System.Windows.Forms.Panel pnlABM;
        private System.Windows.Forms.Panel pnlCompras;
        private System.Windows.Forms.Panel pnlVentas;
        private System.Windows.Forms.Timer timerFechaHora;
        private System.Windows.Forms.ContextMenuStrip cntxtMenuStripABM;
        private System.Windows.Forms.ToolStripMenuItem entidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artículosDeProveedoresToolStripMenuItem;
        private MaterialSkin.Controls.MaterialFlatButton btnEmitirReporte;
        private MaterialSkin.Controls.MaterialFlatButton btnABM;
        private MaterialSkin.Controls.MaterialFlatButton btnPedidoProveedor;
        private MaterialSkin.Controls.MaterialFlatButton btnDevolucion;
        private MaterialSkin.Controls.MaterialFlatButton btnVenta;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialLabel lblNombreUsuario;
        private MaterialSkin.Controls.MaterialLabel lblFechaLog;
        private MaterialSkin.Controls.MaterialLabel lblHoraLog;
        private System.Windows.Forms.FontDialog fontDialog1;
        private MaterialSkin.Controls.MaterialFlatButton btnFacturacion;
        private System.Windows.Forms.TableLayoutPanel tblMainMenu;
        private System.Windows.Forms.TableLayoutPanel tblMdiMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}