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
            this.pnlReportes = new System.Windows.Forms.Panel();
            this.pnlABM = new System.Windows.Forms.Panel();
            this.pnlCompras = new System.Windows.Forms.Panel();
            this.pnlVentas = new System.Windows.Forms.Panel();
            this.timerFechaHora = new System.Windows.Forms.Timer(this.components);
            this.cntxtMenuStripABM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.entidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artículosDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEmitirReporte = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnPedidoProveedor = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnVenta = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnDevolucion = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnABM = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblNombreUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaLog = new MaterialSkin.Controls.MaterialLabel();
            this.lblHoraLog = new MaterialSkin.Controls.MaterialLabel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pnlReportes.SuspendLayout();
            this.pnlABM.SuspendLayout();
            this.pnlCompras.SuspendLayout();
            this.pnlVentas.SuspendLayout();
            this.cntxtMenuStripABM.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlReportes
            // 
            this.pnlReportes.BackColor = System.Drawing.Color.White;
            this.pnlReportes.Controls.Add(this.btnEmitirReporte);
            this.pnlReportes.Location = new System.Drawing.Point(164, 101);
            this.pnlReportes.Name = "pnlReportes";
            this.pnlReportes.Size = new System.Drawing.Size(130, 49);
            this.pnlReportes.TabIndex = 23;
            // 
            // pnlABM
            // 
            this.pnlABM.BackColor = System.Drawing.Color.White;
            this.pnlABM.Controls.Add(this.btnABM);
            this.pnlABM.Location = new System.Drawing.Point(107, 347);
            this.pnlABM.Name = "pnlABM";
            this.pnlABM.Size = new System.Drawing.Size(245, 53);
            this.pnlABM.TabIndex = 25;
            // 
            // pnlCompras
            // 
            this.pnlCompras.BackColor = System.Drawing.Color.White;
            this.pnlCompras.Controls.Add(this.btnPedidoProveedor);
            this.pnlCompras.Location = new System.Drawing.Point(164, 156);
            this.pnlCompras.Name = "pnlCompras";
            this.pnlCompras.Size = new System.Drawing.Size(130, 50);
            this.pnlCompras.TabIndex = 26;
            // 
            // pnlVentas
            // 
            this.pnlVentas.BackColor = System.Drawing.Color.White;
            this.pnlVentas.Controls.Add(this.btnDevolucion);
            this.pnlVentas.Controls.Add(this.btnVenta);
            this.pnlVentas.Location = new System.Drawing.Point(141, 212);
            this.pnlVentas.Name = "pnlVentas";
            this.pnlVentas.Size = new System.Drawing.Size(178, 129);
            this.pnlVentas.TabIndex = 27;
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
            this.cntxtMenuStripABM.Size = new System.Drawing.Size(195, 70);
            // 
            // entidadesToolStripMenuItem
            // 
            this.entidadesToolStripMenuItem.Name = "entidadesToolStripMenuItem";
            this.entidadesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.entidadesToolStripMenuItem.Text = "Entidades";
            this.entidadesToolStripMenuItem.Click += new System.EventHandler(this.entidadesToolStripMenuItem_Click);
            // 
            // artículosToolStripMenuItem
            // 
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            this.artículosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.artículosToolStripMenuItem.Text = "Artículos";
            this.artículosToolStripMenuItem.Click += new System.EventHandler(this.artículosToolStripMenuItem_Click);
            // 
            // artículosDeProveedoresToolStripMenuItem
            // 
            this.artículosDeProveedoresToolStripMenuItem.Name = "artículosDeProveedoresToolStripMenuItem";
            this.artículosDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.artículosDeProveedoresToolStripMenuItem.Text = "Artículos de Proveedores";
            this.artículosDeProveedoresToolStripMenuItem.Click += new System.EventHandler(this.artículosDeProveedoresToolStripMenuItem_Click);
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
            // btnABM
            // 
            this.btnABM.AutoSize = true;
            this.btnABM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnABM.Depth = 0;
            this.btnABM.Location = new System.Drawing.Point(10, 6);
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
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(185, 449);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
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
            this.lblNombreUsuario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNombreUsuario.Location = new System.Drawing.Point(116, 71);
            this.lblNombreUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(60, 16);
            this.lblNombreUsuario.TabIndex = 30;
            this.lblNombreUsuario.Text = "Leandro";
            // 
            // lblFechaLog
            // 
            this.lblFechaLog.AutoSize = true;
            this.lblFechaLog.BackColor = System.Drawing.Color.White;
            this.lblFechaLog.Depth = 0;
            this.lblFechaLog.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaLog.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFechaLog.Location = new System.Drawing.Point(182, 71);
            this.lblFechaLog.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaLog.Name = "lblFechaLog";
            this.lblFechaLog.Size = new System.Drawing.Size(84, 16);
            this.lblFechaLog.TabIndex = 31;
            this.lblFechaLog.Text = "23/10/2016";
            // 
            // lblHoraLog
            // 
            this.lblHoraLog.AutoSize = true;
            this.lblHoraLog.BackColor = System.Drawing.Color.White;
            this.lblHoraLog.Depth = 0;
            this.lblHoraLog.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraLog.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHoraLog.Location = new System.Drawing.Point(272, 71);
            this.lblHoraLog.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHoraLog.Name = "lblHoraLog";
            this.lblHoraLog.Size = new System.Drawing.Size(68, 16);
            this.lblHoraLog.TabIndex = 32;
            this.lblHoraLog.Text = "18:01:57";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(468, 496);
            this.Controls.Add(this.lblHoraLog);
            this.Controls.Add(this.lblFechaLog);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pnlVentas);
            this.Controls.Add(this.pnlCompras);
            this.Controls.Add(this.pnlABM);
            this.Controls.Add(this.pnlReportes);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}