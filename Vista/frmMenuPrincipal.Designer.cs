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
            this.tlsMenu = new System.Windows.Forms.ToolStrip();
            this.tlsbtnABM = new System.Windows.Forms.ToolStripDropDownButton();
            this.entidadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.artículosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.artículosDeProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsbtnReportes = new System.Windows.Forms.ToolStripButton();
            this.tlsbtnVenta = new System.Windows.Forms.ToolStripButton();
            this.tlsbtnPedidoProveedor = new System.Windows.Forms.ToolStripButton();
            this.tlsbtnFacturacion = new System.Windows.Forms.ToolStripButton();
            this.tlsbtnDevolucion = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mstPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMenuRapido = new System.Windows.Forms.ToolStrip();
            this.abrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.guardarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.imprimirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cortarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copiarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pegarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ayudaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cntxtMenuStripABM.SuspendLayout();
            this.tblMainMenu.SuspendLayout();
            this.tblMdiMenu.SuspendLayout();
            this.tlsMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.mstPrincipal.SuspendLayout();
            this.tlsMenuRapido.SuspendLayout();
            this.SuspendLayout();
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
            this.tblMainMenu.Controls.Add(this.tlsMenuRapido, 0, 1);
            this.tblMainMenu.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tblMainMenu.Controls.Add(this.mstPrincipal, 0, 0);
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
            this.tblMdiMenu.Controls.Add(this.tlsMenu, 0, 0);
            this.tblMdiMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMdiMenu.Location = new System.Drawing.Point(3, 63);
            this.tblMdiMenu.Name = "tblMdiMenu";
            this.tblMdiMenu.RowCount = 1;
            this.tblMdiMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMdiMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 496F));
            this.tblMdiMenu.Size = new System.Drawing.Size(975, 496);
            this.tblMdiMenu.TabIndex = 0;
            // 
            // tlsMenu
            // 
            this.tlsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlsMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.tlsMenu.GripMargin = new System.Windows.Forms.Padding(1);
            this.tlsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tlsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsbtnABM,
            this.tlsbtnReportes,
            this.tlsbtnVenta,
            this.tlsbtnPedidoProveedor,
            this.tlsbtnFacturacion,
            this.tlsbtnDevolucion});
            this.tlsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tlsMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsMenu.Name = "tlsMenu";
            this.tlsMenu.Size = new System.Drawing.Size(243, 496);
            this.tlsMenu.TabIndex = 27;
            this.tlsMenu.Text = "toolStrip1";
            // 
            // tlsbtnABM
            // 
            this.tlsbtnABM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entidadesToolStripMenuItem1,
            this.artículosToolStripMenuItem1,
            this.artículosDeProveedorToolStripMenuItem});
            this.tlsbtnABM.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnABM.Image")));
            this.tlsbtnABM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tlsbtnABM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnABM.Name = "tlsbtnABM";
            this.tlsbtnABM.Size = new System.Drawing.Size(241, 24);
            this.tlsbtnABM.Text = "ALTAS, BAJAS y MODIFICACIONES";
            this.tlsbtnABM.Click += new System.EventHandler(this.tlsbtnABM_Click);
            // 
            // entidadesToolStripMenuItem1
            // 
            this.entidadesToolStripMenuItem1.Name = "entidadesToolStripMenuItem1";
            this.entidadesToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.entidadesToolStripMenuItem1.Text = "Entidades";
            this.entidadesToolStripMenuItem1.Click += new System.EventHandler(this.entidadesToolStripMenuItem1_Click);
            // 
            // artículosToolStripMenuItem1
            // 
            this.artículosToolStripMenuItem1.Name = "artículosToolStripMenuItem1";
            this.artículosToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.artículosToolStripMenuItem1.Text = "Artículos";
            this.artículosToolStripMenuItem1.Click += new System.EventHandler(this.artículosToolStripMenuItem1_Click);
            // 
            // artículosDeProveedorToolStripMenuItem
            // 
            this.artículosDeProveedorToolStripMenuItem.Name = "artículosDeProveedorToolStripMenuItem";
            this.artículosDeProveedorToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.artículosDeProveedorToolStripMenuItem.Text = "Artículos de Proveedor";
            this.artículosDeProveedorToolStripMenuItem.Click += new System.EventHandler(this.artículosDeProveedorToolStripMenuItem_Click);
            // 
            // tlsbtnReportes
            // 
            this.tlsbtnReportes.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnReportes.Image")));
            this.tlsbtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tlsbtnReportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnReportes.Name = "tlsbtnReportes";
            this.tlsbtnReportes.Size = new System.Drawing.Size(241, 24);
            this.tlsbtnReportes.Text = "EMITIR REPORTE";
            this.tlsbtnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tlsbtnReportes.Click += new System.EventHandler(this.tlsbtnReportes_Click);
            // 
            // tlsbtnVenta
            // 
            this.tlsbtnVenta.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnVenta.Image")));
            this.tlsbtnVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tlsbtnVenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnVenta.Name = "tlsbtnVenta";
            this.tlsbtnVenta.Size = new System.Drawing.Size(241, 24);
            this.tlsbtnVenta.Text = "NUEVA VENTA";
            this.tlsbtnVenta.Click += new System.EventHandler(this.tlsbtnVenta_Click);
            // 
            // tlsbtnPedidoProveedor
            // 
            this.tlsbtnPedidoProveedor.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnPedidoProveedor.Image")));
            this.tlsbtnPedidoProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tlsbtnPedidoProveedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnPedidoProveedor.Name = "tlsbtnPedidoProveedor";
            this.tlsbtnPedidoProveedor.Size = new System.Drawing.Size(241, 24);
            this.tlsbtnPedidoProveedor.Text = "NUEVO PEDIDO";
            this.tlsbtnPedidoProveedor.Click += new System.EventHandler(this.tlsbtnPedidoProveedor_Click);
            // 
            // tlsbtnFacturacion
            // 
            this.tlsbtnFacturacion.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnFacturacion.Image")));
            this.tlsbtnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tlsbtnFacturacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnFacturacion.Name = "tlsbtnFacturacion";
            this.tlsbtnFacturacion.Size = new System.Drawing.Size(241, 24);
            this.tlsbtnFacturacion.Text = "FACTURACIÓN MASIVA";
            this.tlsbtnFacturacion.Click += new System.EventHandler(this.tlsbtnFacturacion_Click);
            // 
            // tlsbtnDevolucion
            // 
            this.tlsbtnDevolucion.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnDevolucion.Image")));
            this.tlsbtnDevolucion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tlsbtnDevolucion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnDevolucion.Name = "tlsbtnDevolucion";
            this.tlsbtnDevolucion.Size = new System.Drawing.Size(241, 24);
            this.tlsbtnDevolucion.Text = "DEVOLUCIÓN";
            this.tlsbtnDevolucion.Click += new System.EventHandler(this.tlsbtnDevolucion_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
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
            // mstPrincipal
            // 
            this.mstPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mstPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.mstPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mstPrincipal.Name = "mstPrincipal";
            this.mstPrincipal.Size = new System.Drawing.Size(981, 30);
            this.mstPrincipal.TabIndex = 2;
            this.mstPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 26);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // tlsMenuRapido
            // 
            this.tlsMenuRapido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlsMenuRapido.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripButton,
            this.guardarToolStripButton,
            this.imprimirToolStripButton,
            this.toolStripSeparator,
            this.cortarToolStripButton,
            this.copiarToolStripButton,
            this.pegarToolStripButton,
            this.toolStripSeparator1,
            this.ayudaToolStripButton});
            this.tlsMenuRapido.Location = new System.Drawing.Point(0, 30);
            this.tlsMenuRapido.Name = "tlsMenuRapido";
            this.tlsMenuRapido.Size = new System.Drawing.Size(981, 30);
            this.tlsMenuRapido.TabIndex = 3;
            this.tlsMenuRapido.Text = "toolStrip1";
            // 
            // abrirToolStripButton
            // 
            this.abrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abrirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripButton.Image")));
            this.abrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripButton.Name = "abrirToolStripButton";
            this.abrirToolStripButton.Size = new System.Drawing.Size(23, 27);
            this.abrirToolStripButton.Text = "&Abrir";
            // 
            // guardarToolStripButton
            // 
            this.guardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.guardarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripButton.Image")));
            this.guardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guardarToolStripButton.Name = "guardarToolStripButton";
            this.guardarToolStripButton.Size = new System.Drawing.Size(23, 27);
            this.guardarToolStripButton.Text = "&Guardar";
            // 
            // imprimirToolStripButton
            // 
            this.imprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprimirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripButton.Image")));
            this.imprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripButton.Name = "imprimirToolStripButton";
            this.imprimirToolStripButton.Size = new System.Drawing.Size(23, 27);
            this.imprimirToolStripButton.Text = "&Imprimir";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 30);
            // 
            // cortarToolStripButton
            // 
            this.cortarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cortarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cortarToolStripButton.Image")));
            this.cortarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cortarToolStripButton.Name = "cortarToolStripButton";
            this.cortarToolStripButton.Size = new System.Drawing.Size(23, 27);
            this.cortarToolStripButton.Text = "Cort&ar";
            // 
            // copiarToolStripButton
            // 
            this.copiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copiarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripButton.Image")));
            this.copiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripButton.Name = "copiarToolStripButton";
            this.copiarToolStripButton.Size = new System.Drawing.Size(23, 27);
            this.copiarToolStripButton.Text = "&Copiar";
            // 
            // pegarToolStripButton
            // 
            this.pegarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pegarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pegarToolStripButton.Image")));
            this.pegarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pegarToolStripButton.Name = "pegarToolStripButton";
            this.pegarToolStripButton.Size = new System.Drawing.Size(23, 27);
            this.pegarToolStripButton.Text = "&Pegar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // ayudaToolStripButton
            // 
            this.ayudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ayudaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ayudaToolStripButton.Image")));
            this.ayudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ayudaToolStripButton.Name = "ayudaToolStripButton";
            this.ayudaToolStripButton.Size = new System.Drawing.Size(23, 27);
            this.ayudaToolStripButton.Text = "Ay&uda";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 587);
            this.Controls.Add(this.tblMainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mstPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.Text = "Menú Principal";
            this.cntxtMenuStripABM.ResumeLayout(false);
            this.tblMainMenu.ResumeLayout(false);
            this.tblMainMenu.PerformLayout();
            this.tblMdiMenu.ResumeLayout(false);
            this.tblMdiMenu.PerformLayout();
            this.tlsMenu.ResumeLayout(false);
            this.tlsMenu.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.mstPrincipal.ResumeLayout(false);
            this.mstPrincipal.PerformLayout();
            this.tlsMenuRapido.ResumeLayout(false);
            this.tlsMenuRapido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerFechaHora;
        private System.Windows.Forms.ContextMenuStrip cntxtMenuStripABM;
        private System.Windows.Forms.ToolStripMenuItem entidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artículosDeProveedoresToolStripMenuItem;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialLabel lblNombreUsuario;
        private MaterialSkin.Controls.MaterialLabel lblFechaLog;
        private MaterialSkin.Controls.MaterialLabel lblHoraLog;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip tlsMenu;
        private System.Windows.Forms.ToolStripDropDownButton tlsbtnABM;
        private System.Windows.Forms.ToolStripButton tlsbtnVenta;
        private System.Windows.Forms.ToolStripMenuItem entidadesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem artículosDeProveedorToolStripMenuItem;
        public System.Windows.Forms.TableLayoutPanel tblMainMenu;
        public System.Windows.Forms.TableLayoutPanel tblMdiMenu;
        public System.Windows.Forms.ToolStripButton tlsbtnReportes;
        private System.Windows.Forms.ToolStripButton tlsbtnPedidoProveedor;
        private System.Windows.Forms.ToolStripButton tlsbtnFacturacion;
        private System.Windows.Forms.ToolStripButton tlsbtnDevolucion;
        private System.Windows.Forms.ToolStrip tlsMenuRapido;
        private System.Windows.Forms.ToolStripButton abrirToolStripButton;
        private System.Windows.Forms.ToolStripButton guardarToolStripButton;
        private System.Windows.Forms.ToolStripButton imprimirToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cortarToolStripButton;
        private System.Windows.Forms.ToolStripButton copiarToolStripButton;
        private System.Windows.Forms.ToolStripButton pegarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ayudaToolStripButton;
        private System.Windows.Forms.MenuStrip mstPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}