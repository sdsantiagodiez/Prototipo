﻿namespace Vista
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.seleccionarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarExportarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articuloProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descuentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articuloProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artículosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.preciosParaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preciosParaCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.descuentosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblLayoutPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelPrincipal_Contenedor = new System.Windows.Forms.TableLayoutPanel();
            this.pnlContenedorForm = new System.Windows.Forms.Panel();
            this.tblLayoutPanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.tlsMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripbtnPedidoCliente = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnPedidoProveedor = new System.Windows.Forms.ToolStripButton();
            this.tlsbtnDevolucion = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnFacturacion = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnReportes = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnReimpresion = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnABM = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmi_ABMentidades = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ABMarticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ABMarticulosProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ABMdescuentos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tblLayoutPanelPrincipal_Bottom = new System.Windows.Forms.TableLayoutPanel();
            this.lblHoraLog = new MaterialSkin.Controls.MaterialLabel();
            this.lblNombreUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaLog = new MaterialSkin.Controls.MaterialLabel();
            this.baseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.backUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMenuRapido.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tblLayoutPanelPrincipal.SuspendLayout();
            this.tblLayoutPanelPrincipal_Contenedor.SuspendLayout();
            this.tblLayoutPanelMenu.SuspendLayout();
            this.tlsMenu.SuspendLayout();
            this.tblLayoutPanelPrincipal_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerFechaHora
            // 
            this.timerFechaHora.Tick += new System.EventHandler(this.timerFechaHora_Tick);
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
            this.tlsMenuRapido.Size = new System.Drawing.Size(1118, 30);
            this.tlsMenuRapido.Stretch = true;
            this.tlsMenuRapido.TabIndex = 3;
            this.tlsMenuRapido.Text = "toolStrip";
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
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 619);
            this.splitter1.TabIndex = 39;
            this.splitter1.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1118, 30);
            this.menuStrip.TabIndex = 41;
            this.menuStrip.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaDeUsuarioToolStripMenuItem,
            this.toolStripMenuItem5,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cuentaDeUsuarioToolStripMenuItem
            // 
            this.cuentaDeUsuarioToolStripMenuItem.Name = "cuentaDeUsuarioToolStripMenuItem";
            this.cuentaDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cuentaDeUsuarioToolStripMenuItem.Text = "Cuenta de Usuario";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(168, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deshacerToolStripMenuItem,
            this.toolStripMenuItem2,
            this.cortarToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.toolStripMenuItem3,
            this.eliminarToolStripMenuItem,
            this.toolStripMenuItem4,
            this.seleccionarTodoToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // deshacerToolStripMenuItem
            // 
            this.deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
            this.deshacerToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.deshacerToolStripMenuItem.Text = "Deshacer";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(162, 6);
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cortarToolStripMenuItem.Text = "Cortar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.pegarToolStripMenuItem.Text = "Pegar";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(162, 6);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(162, 6);
            // 
            // seleccionarTodoToolStripMenuItem
            // 
            this.seleccionarTodoToolStripMenuItem.Name = "seleccionarTodoToolStripMenuItem";
            this.seleccionarTodoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.seleccionarTodoToolStripMenuItem.Text = "Seleccionar Todo";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarExportarDatosToolStripMenuItem,
            this.importarDatosToolStripMenuItem,
            this.toolStripMenuItem6,
            this.baseDeDatosToolStripMenuItem,
            this.toolStripSeparator2,
            this.opcionesToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 26);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // importarExportarDatosToolStripMenuItem
            // 
            this.importarExportarDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articuloProveedoresToolStripMenuItem,
            this.artículosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.descuentosToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
            this.importarExportarDatosToolStripMenuItem.Name = "importarExportarDatosToolStripMenuItem";
            this.importarExportarDatosToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.importarExportarDatosToolStripMenuItem.Text = "Exportar Datos";
            // 
            // articuloProveedoresToolStripMenuItem
            // 
            this.articuloProveedoresToolStripMenuItem.Name = "articuloProveedoresToolStripMenuItem";
            this.articuloProveedoresToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.articuloProveedoresToolStripMenuItem.Text = "Articulo Proveedores";
            this.articuloProveedoresToolStripMenuItem.Click += new System.EventHandler(this.articuloProveedoresToolStripMenuItem_Click);
            // 
            // artículosToolStripMenuItem
            // 
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            this.artículosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.artículosToolStripMenuItem.Text = "Artículos";
            this.artículosToolStripMenuItem.Click += new System.EventHandler(this.artículosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // descuentosToolStripMenuItem
            // 
            this.descuentosToolStripMenuItem.Name = "descuentosToolStripMenuItem";
            this.descuentosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.descuentosToolStripMenuItem.Text = "Descuentos";
            this.descuentosToolStripMenuItem.Click += new System.EventHandler(this.descuentosToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // importarDatosToolStripMenuItem
            // 
            this.importarDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articuloProveedorToolStripMenuItem,
            this.artículoToolStripMenuItem,
            this.clientesToolStripMenuItem1,
            this.descuentosToolStripMenuItem1,
            this.proveedoresToolStripMenuItem1});
            this.importarDatosToolStripMenuItem.Name = "importarDatosToolStripMenuItem";
            this.importarDatosToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.importarDatosToolStripMenuItem.Text = "Importar Datos";
            // 
            // articuloProveedorToolStripMenuItem
            // 
            this.articuloProveedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artículosToolStripMenuItem1,
            this.preciosParaVentaToolStripMenuItem,
            this.preciosParaCompraToolStripMenuItem});
            this.articuloProveedorToolStripMenuItem.Name = "articuloProveedorToolStripMenuItem";
            this.articuloProveedorToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.articuloProveedorToolStripMenuItem.Text = "Artículo Proveedor";
            this.articuloProveedorToolStripMenuItem.Click += new System.EventHandler(this.articuloProveedorToolStripMenuItem_Click);
            // 
            // artículosToolStripMenuItem1
            // 
            this.artículosToolStripMenuItem1.Name = "artículosToolStripMenuItem1";
            this.artículosToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.artículosToolStripMenuItem1.Text = "Artículos";
            this.artículosToolStripMenuItem1.Click += new System.EventHandler(this.artículosToolStripMenuItem1_Click);
            // 
            // preciosParaVentaToolStripMenuItem
            // 
            this.preciosParaVentaToolStripMenuItem.Name = "preciosParaVentaToolStripMenuItem";
            this.preciosParaVentaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.preciosParaVentaToolStripMenuItem.Text = "Precios para Venta";
            this.preciosParaVentaToolStripMenuItem.Click += new System.EventHandler(this.preciosParaVentaToolStripMenuItem_Click);
            // 
            // preciosParaCompraToolStripMenuItem
            // 
            this.preciosParaCompraToolStripMenuItem.Name = "preciosParaCompraToolStripMenuItem";
            this.preciosParaCompraToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.preciosParaCompraToolStripMenuItem.Text = "Precios para Compra";
            this.preciosParaCompraToolStripMenuItem.Click += new System.EventHandler(this.preciosParaCompraToolStripMenuItem_Click);
            // 
            // artículoToolStripMenuItem
            // 
            this.artículoToolStripMenuItem.Name = "artículoToolStripMenuItem";
            this.artículoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.artículoToolStripMenuItem.Text = "Artículos";
            this.artículoToolStripMenuItem.Click += new System.EventHandler(this.artículoToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // descuentosToolStripMenuItem1
            // 
            this.descuentosToolStripMenuItem1.Name = "descuentosToolStripMenuItem1";
            this.descuentosToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.descuentosToolStripMenuItem1.Text = "Descuentos";
            this.descuentosToolStripMenuItem1.Click += new System.EventHandler(this.descuentosToolStripMenuItem1_Click);
            // 
            // proveedoresToolStripMenuItem1
            // 
            this.proveedoresToolStripMenuItem1.Name = "proveedoresToolStripMenuItem1";
            this.proveedoresToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.proveedoresToolStripMenuItem1.Text = "Proveedores";
            this.proveedoresToolStripMenuItem1.Click += new System.EventHandler(this.proveedoresToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(150, 6);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.manualToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.manualToolStripMenuItem.Text = "Ver Ayuda";
            // 
            // tblLayoutPanelPrincipal
            // 
            this.tblLayoutPanelPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblLayoutPanelPrincipal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblLayoutPanelPrincipal.ColumnCount = 1;
            this.tblLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal.Controls.Add(this.tblLayoutPanelPrincipal_Contenedor, 0, 2);
            this.tblLayoutPanelPrincipal.Controls.Add(this.tblLayoutPanelPrincipal_Bottom, 0, 3);
            this.tblLayoutPanelPrincipal.Controls.Add(this.menuStrip, 0, 0);
            this.tblLayoutPanelPrincipal.Controls.Add(this.tlsMenuRapido, 0, 1);
            this.tblLayoutPanelPrincipal.Location = new System.Drawing.Point(12, 78);
            this.tblLayoutPanelPrincipal.Name = "tblLayoutPanelPrincipal";
            this.tblLayoutPanelPrincipal.RowCount = 4;
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblLayoutPanelPrincipal.Size = new System.Drawing.Size(1118, 507);
            this.tblLayoutPanelPrincipal.TabIndex = 42;
            // 
            // tblLayoutPanelPrincipal_Contenedor
            // 
            this.tblLayoutPanelPrincipal_Contenedor.ColumnCount = 2;
            this.tblLayoutPanelPrincipal_Contenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tblLayoutPanelPrincipal_Contenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal_Contenedor.Controls.Add(this.pnlContenedorForm, 1, 0);
            this.tblLayoutPanelPrincipal_Contenedor.Controls.Add(this.tblLayoutPanelMenu, 0, 0);
            this.tblLayoutPanelPrincipal_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelPrincipal_Contenedor.Location = new System.Drawing.Point(0, 63);
            this.tblLayoutPanelPrincipal_Contenedor.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.tblLayoutPanelPrincipal_Contenedor.Name = "tblLayoutPanelPrincipal_Contenedor";
            this.tblLayoutPanelPrincipal_Contenedor.RowCount = 1;
            this.tblLayoutPanelPrincipal_Contenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal_Contenedor.Size = new System.Drawing.Size(1115, 414);
            this.tblLayoutPanelPrincipal_Contenedor.TabIndex = 43;
            // 
            // pnlContenedorForm
            // 
            this.pnlContenedorForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorForm.Location = new System.Drawing.Point(196, 3);
            this.pnlContenedorForm.Name = "pnlContenedorForm";
            this.pnlContenedorForm.Size = new System.Drawing.Size(916, 408);
            this.pnlContenedorForm.TabIndex = 28;
            // 
            // tblLayoutPanelMenu
            // 
            this.tblLayoutPanelMenu.ColumnCount = 1;
            this.tblLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelMenu.Controls.Add(this.tlsMenu, 0, 0);
            this.tblLayoutPanelMenu.Controls.Add(this.btnSalir, 0, 1);
            this.tblLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tblLayoutPanelMenu.Name = "tblLayoutPanelMenu";
            this.tblLayoutPanelMenu.RowCount = 2;
            this.tblLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblLayoutPanelMenu.Size = new System.Drawing.Size(193, 414);
            this.tblLayoutPanelMenu.TabIndex = 29;
            // 
            // tlsMenu
            // 
            this.tlsMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlsMenu.GripMargin = new System.Windows.Forms.Padding(1);
            this.tlsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tlsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripbtnPedidoCliente,
            this.toolStripbtnPedidoProveedor,
            this.tlsbtnDevolucion,
            this.toolStripbtnFacturacion,
            this.toolStripbtnReportes,
            this.toolStripbtnReimpresion,
            this.toolStripbtnABM});
            this.tlsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tlsMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsMenu.Name = "tlsMenu";
            this.tlsMenu.Size = new System.Drawing.Size(193, 389);
            this.tlsMenu.TabIndex = 27;
            this.tlsMenu.Text = "toolStrip1";
            // 
            // toolStripbtnPedidoCliente
            // 
            this.toolStripbtnPedidoCliente.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnPedidoCliente.Image")));
            this.toolStripbtnPedidoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripbtnPedidoCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnPedidoCliente.Name = "toolStripbtnPedidoCliente";
            this.toolStripbtnPedidoCliente.Size = new System.Drawing.Size(191, 24);
            this.toolStripbtnPedidoCliente.Text = "Pedidos Clientes";
            this.toolStripbtnPedidoCliente.Click += new System.EventHandler(this.toolStripbtnPedidoCliente_Click);
            // 
            // toolStripbtnPedidoProveedor
            // 
            this.toolStripbtnPedidoProveedor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnPedidoProveedor.Image")));
            this.toolStripbtnPedidoProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripbtnPedidoProveedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnPedidoProveedor.Name = "toolStripbtnPedidoProveedor";
            this.toolStripbtnPedidoProveedor.Size = new System.Drawing.Size(191, 24);
            this.toolStripbtnPedidoProveedor.Tag = "";
            this.toolStripbtnPedidoProveedor.Text = "Pedidos Proveedores";
            this.toolStripbtnPedidoProveedor.Click += new System.EventHandler(this.toolStripbtnPedidoProveedor_Click);
            // 
            // tlsbtnDevolucion
            // 
            this.tlsbtnDevolucion.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnDevolucion.Image")));
            this.tlsbtnDevolucion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tlsbtnDevolucion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnDevolucion.Name = "tlsbtnDevolucion";
            this.tlsbtnDevolucion.Size = new System.Drawing.Size(191, 24);
            this.tlsbtnDevolucion.Text = "Devoluciones Clientes";
            this.tlsbtnDevolucion.Click += new System.EventHandler(this.tlsbtnDevolucion_Click);
            // 
            // toolStripbtnFacturacion
            // 
            this.toolStripbtnFacturacion.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnFacturacion.Image")));
            this.toolStripbtnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripbtnFacturacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnFacturacion.Name = "toolStripbtnFacturacion";
            this.toolStripbtnFacturacion.Size = new System.Drawing.Size(191, 24);
            this.toolStripbtnFacturacion.Text = "Facturación Pendiente";
            this.toolStripbtnFacturacion.Click += new System.EventHandler(this.toolStripbtnFacturacion_Click);
            // 
            // toolStripbtnReportes
            // 
            this.toolStripbtnReportes.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnReportes.Image")));
            this.toolStripbtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripbtnReportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnReportes.Name = "toolStripbtnReportes";
            this.toolStripbtnReportes.Size = new System.Drawing.Size(191, 24);
            this.toolStripbtnReportes.Text = "Emisión de Reportes";
            this.toolStripbtnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripbtnReportes.Click += new System.EventHandler(this.toolStripbtnReportes_Click);
            // 
            // toolStripbtnReimpresion
            // 
            this.toolStripbtnReimpresion.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnReimpresion.Image")));
            this.toolStripbtnReimpresion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripbtnReimpresion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnReimpresion.Name = "toolStripbtnReimpresion";
            this.toolStripbtnReimpresion.Size = new System.Drawing.Size(191, 24);
            this.toolStripbtnReimpresion.Text = "Reimpresión Comprobantes";
            this.toolStripbtnReimpresion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripbtnReimpresion.Click += new System.EventHandler(this.toolStripbtnReimpresion_Click);
            // 
            // toolStripbtnABM
            // 
            this.toolStripbtnABM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_ABMentidades,
            this.tsmi_ABMarticulos,
            this.tsmi_ABMarticulosProveedor,
            this.tsmi_ABMdescuentos});
            this.toolStripbtnABM.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnABM.Image")));
            this.toolStripbtnABM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripbtnABM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnABM.Name = "toolStripbtnABM";
            this.toolStripbtnABM.Size = new System.Drawing.Size(191, 24);
            this.toolStripbtnABM.Text = "Administración de Entidades";
            // 
            // tsmi_ABMentidades
            // 
            this.tsmi_ABMentidades.Name = "tsmi_ABMentidades";
            this.tsmi_ABMentidades.Size = new System.Drawing.Size(194, 22);
            this.tsmi_ABMentidades.Text = "Entidades";
            this.tsmi_ABMentidades.Click += new System.EventHandler(this.tsmi_ABMentidades_Click);
            // 
            // tsmi_ABMarticulos
            // 
            this.tsmi_ABMarticulos.Name = "tsmi_ABMarticulos";
            this.tsmi_ABMarticulos.Size = new System.Drawing.Size(194, 22);
            this.tsmi_ABMarticulos.Text = "Artículos";
            this.tsmi_ABMarticulos.Click += new System.EventHandler(this.tsmi_ABMarticulos_Click);
            // 
            // tsmi_ABMarticulosProveedor
            // 
            this.tsmi_ABMarticulosProveedor.Name = "tsmi_ABMarticulosProveedor";
            this.tsmi_ABMarticulosProveedor.Size = new System.Drawing.Size(194, 22);
            this.tsmi_ABMarticulosProveedor.Text = "Artículos de Proveedor";
            this.tsmi_ABMarticulosProveedor.Click += new System.EventHandler(this.tsmi_ABMarticulosProveedor_Click);
            // 
            // tsmi_ABMdescuentos
            // 
            this.tsmi_ABMdescuentos.Name = "tsmi_ABMdescuentos";
            this.tsmi_ABMdescuentos.Size = new System.Drawing.Size(194, 22);
            this.tsmi_ABMdescuentos.Text = "Descuentos";
            this.tsmi_ABMdescuentos.Click += new System.EventHandler(this.tsmi_ABMdescuentos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalir.Location = new System.Drawing.Point(0, 389);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(193, 25);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tblLayoutPanelPrincipal_Bottom
            // 
            this.tblLayoutPanelPrincipal_Bottom.BackColor = System.Drawing.Color.DarkGray;
            this.tblLayoutPanelPrincipal_Bottom.ColumnCount = 5;
            this.tblLayoutPanelPrincipal_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayoutPanelPrincipal_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayoutPanelPrincipal_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayoutPanelPrincipal_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayoutPanelPrincipal_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayoutPanelPrincipal_Bottom.Controls.Add(this.lblHoraLog, 4, 0);
            this.tblLayoutPanelPrincipal_Bottom.Controls.Add(this.lblNombreUsuario, 2, 0);
            this.tblLayoutPanelPrincipal_Bottom.Controls.Add(this.lblFechaLog, 3, 0);
            this.tblLayoutPanelPrincipal_Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelPrincipal_Bottom.Location = new System.Drawing.Point(0, 477);
            this.tblLayoutPanelPrincipal_Bottom.Margin = new System.Windows.Forms.Padding(0);
            this.tblLayoutPanelPrincipal_Bottom.Name = "tblLayoutPanelPrincipal_Bottom";
            this.tblLayoutPanelPrincipal_Bottom.RowCount = 1;
            this.tblLayoutPanelPrincipal_Bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal_Bottom.Size = new System.Drawing.Size(1118, 30);
            this.tblLayoutPanelPrincipal_Bottom.TabIndex = 42;
            // 
            // lblHoraLog
            // 
            this.lblHoraLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHoraLog.AutoSize = true;
            this.lblHoraLog.BackColor = System.Drawing.Color.DarkGray;
            this.lblHoraLog.Depth = 0;
            this.lblHoraLog.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblHoraLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHoraLog.Location = new System.Drawing.Point(972, 5);
            this.lblHoraLog.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHoraLog.Name = "lblHoraLog";
            this.lblHoraLog.Size = new System.Drawing.Size(65, 19);
            this.lblHoraLog.TabIndex = 32;
            this.lblHoraLog.Text = "18:01:57";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.DarkGray;
            this.lblNombreUsuario.Depth = 0;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombreUsuario.Location = new System.Drawing.Point(526, 5);
            this.lblNombreUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(63, 19);
            this.lblNombreUsuario.TabIndex = 30;
            this.lblNombreUsuario.Text = "Leandro";
            // 
            // lblFechaLog
            // 
            this.lblFechaLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaLog.AutoSize = true;
            this.lblFechaLog.BackColor = System.Drawing.Color.DarkGray;
            this.lblFechaLog.Depth = 0;
            this.lblFechaLog.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaLog.Location = new System.Drawing.Point(738, 5);
            this.lblFechaLog.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaLog.Name = "lblFechaLog";
            this.lblFechaLog.Size = new System.Drawing.Size(85, 19);
            this.lblFechaLog.TabIndex = 31;
            this.lblFechaLog.Text = "23/10/2016";
            // 
            // baseDeDatosToolStripMenuItem
            // 
            this.baseDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backUpToolStripMenuItem});
            this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
            this.baseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.baseDeDatosToolStripMenuItem.Text = "Base de Datos";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(150, 6);
            // 
            // backUpToolStripMenuItem
            // 
            this.backUpToolStripMenuItem.Name = "backUpToolStripMenuItem";
            this.backUpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.backUpToolStripMenuItem.Text = "Back Up";
            this.backUpToolStripMenuItem.Click += new System.EventHandler(this.backUpToolStripMenuItem_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1133, 619);
            this.Controls.Add(this.tblLayoutPanelPrincipal);
            this.Controls.Add(this.splitter1);
            this.Name = "frmMenuPrincipal";
            this.Text = "Menú Principal";
            this.tlsMenuRapido.ResumeLayout(false);
            this.tlsMenuRapido.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tblLayoutPanelPrincipal.ResumeLayout(false);
            this.tblLayoutPanelPrincipal.PerformLayout();
            this.tblLayoutPanelPrincipal_Contenedor.ResumeLayout(false);
            this.tblLayoutPanelMenu.ResumeLayout(false);
            this.tblLayoutPanelMenu.PerformLayout();
            this.tlsMenu.ResumeLayout(false);
            this.tlsMenu.PerformLayout();
            this.tblLayoutPanelPrincipal_Bottom.ResumeLayout(false);
            this.tblLayoutPanelPrincipal_Bottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerFechaHora;
        private System.Windows.Forms.FontDialog fontDialog1;
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
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelPrincipal;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelPrincipal_Bottom;
        private MaterialSkin.Controls.MaterialLabel lblHoraLog;
        private MaterialSkin.Controls.MaterialLabel lblNombreUsuario;
        private MaterialSkin.Controls.MaterialLabel lblFechaLog;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelPrincipal_Contenedor;
        private System.Windows.Forms.ToolStrip tlsMenu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripbtnABM;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ABMentidades;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ABMarticulos;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ABMdescuentos;
        public System.Windows.Forms.ToolStripButton toolStripbtnReportes;
        private System.Windows.Forms.ToolStripButton toolStripbtnPedidoCliente;
        private System.Windows.Forms.ToolStripButton toolStripbtnPedidoProveedor;
        private System.Windows.Forms.ToolStripButton toolStripbtnFacturacion;
        private System.Windows.Forms.ToolStripButton tlsbtnDevolucion;
        private System.Windows.Forms.Panel pnlContenedorForm;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ABMarticulosProveedor;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelMenu;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentaDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deshacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem seleccionarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarExportarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articuloProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descuentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articuloProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem descuentosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preciosParaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preciosParaCompraToolStripMenuItem;
        public System.Windows.Forms.ToolStripButton toolStripbtnReimpresion;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}