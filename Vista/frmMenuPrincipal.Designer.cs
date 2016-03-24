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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnPedidoProv = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlReportes = new System.Windows.Forms.Panel();
            this.btnEmitirReporte = new System.Windows.Forms.Button();
            this.pnlABM = new System.Windows.Forms.Panel();
            this.btnABM = new System.Windows.Forms.Button();
            this.pnlCompras = new System.Windows.Forms.Panel();
            this.pnlVentas = new System.Windows.Forms.Panel();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.btnReserva = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFechaLog = new System.Windows.Forms.Label();
            this.lblHoraLog = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.timerFechaHora = new System.Windows.Forms.Timer(this.components);
            this.cntxtMenuStripABM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.entidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artículosDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlReportes.SuspendLayout();
            this.pnlABM.SuspendLayout();
            this.pnlCompras.SuspendLayout();
            this.pnlVentas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cntxtMenuStripABM.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPedidoProv
            // 
            this.btnPedidoProv.Location = new System.Drawing.Point(21, 12);
            this.btnPedidoProv.Name = "btnPedidoProv";
            this.btnPedidoProv.Size = new System.Drawing.Size(162, 40);
            this.btnPedidoProv.TabIndex = 2;
            this.btnPedidoProv.Text = "Nuevo Pedido a Proveedor";
            this.btnPedidoProv.UseVisualStyleBackColor = true;
            this.btnPedidoProv.Click += new System.EventHandler(this.btnPedidoProv_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(20, 16);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(162, 40);
            this.btnVenta.TabIndex = 3;
            this.btnVenta.Text = "Nueva Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBienvenido.Location = new System.Drawing.Point(22, 7);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(256, 42);
            this.lblBienvenido.TabIndex = 5;
            this.lblBienvenido.Text = "BIENVENIDO";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(66, 490);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(162, 40);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlReportes
            // 
            this.pnlReportes.Controls.Add(this.btnEmitirReporte);
            this.pnlReportes.Location = new System.Drawing.Point(45, 52);
            this.pnlReportes.Name = "pnlReportes";
            this.pnlReportes.Size = new System.Drawing.Size(199, 65);
            this.pnlReportes.TabIndex = 23;
            // 
            // btnEmitirReporte
            // 
            this.btnEmitirReporte.Location = new System.Drawing.Point(20, 13);
            this.btnEmitirReporte.Name = "btnEmitirReporte";
            this.btnEmitirReporte.Size = new System.Drawing.Size(162, 40);
            this.btnEmitirReporte.TabIndex = 0;
            this.btnEmitirReporte.Text = "Emitir Reporte";
            this.btnEmitirReporte.UseVisualStyleBackColor = true;
            this.btnEmitirReporte.Click += new System.EventHandler(this.btnEmitirReporte_Click);
            // 
            // pnlABM
            // 
            this.pnlABM.Controls.Add(this.btnABM);
            this.pnlABM.Location = new System.Drawing.Point(45, 364);
            this.pnlABM.Name = "pnlABM";
            this.pnlABM.Size = new System.Drawing.Size(200, 65);
            this.pnlABM.TabIndex = 25;
            // 
            // btnABM
            // 
            this.btnABM.Location = new System.Drawing.Point(20, 13);
            this.btnABM.Name = "btnABM";
            this.btnABM.Size = new System.Drawing.Size(162, 40);
            this.btnABM.TabIndex = 0;
            this.btnABM.Text = "Altas, Bajas y Modificaciones";
            this.btnABM.UseVisualStyleBackColor = true;
            this.btnABM.Click += new System.EventHandler(this.btnABM_Click);
            // 
            // pnlCompras
            // 
            this.pnlCompras.Controls.Add(this.btnPedidoProv);
            this.pnlCompras.Location = new System.Drawing.Point(45, 123);
            this.pnlCompras.Name = "pnlCompras";
            this.pnlCompras.Size = new System.Drawing.Size(200, 62);
            this.pnlCompras.TabIndex = 26;
            // 
            // pnlVentas
            // 
            this.pnlVentas.Controls.Add(this.btnDevolucion);
            this.pnlVentas.Controls.Add(this.btnReserva);
            this.pnlVentas.Controls.Add(this.btnVenta);
            this.pnlVentas.Location = new System.Drawing.Point(45, 191);
            this.pnlVentas.Name = "pnlVentas";
            this.pnlVentas.Size = new System.Drawing.Size(199, 166);
            this.pnlVentas.TabIndex = 27;
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.Location = new System.Drawing.Point(20, 108);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(162, 40);
            this.btnDevolucion.TabIndex = 28;
            this.btnDevolucion.Text = "Procesar Devolución";
            this.btnDevolucion.UseVisualStyleBackColor = true;
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // btnReserva
            // 
            this.btnReserva.Location = new System.Drawing.Point(20, 62);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(162, 40);
            this.btnReserva.TabIndex = 4;
            this.btnReserva.Text = "Nueva Reserva";
            this.btnReserva.UseVisualStyleBackColor = true;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(10, 31);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(56, 16);
            this.lblFecha.TabIndex = 16;
            this.lblFecha.Text = "FECHA:";
            // 
            // lblFechaLog
            // 
            this.lblFechaLog.AutoSize = true;
            this.lblFechaLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaLog.Location = new System.Drawing.Point(72, 31);
            this.lblFechaLog.Name = "lblFechaLog";
            this.lblFechaLog.Size = new System.Drawing.Size(72, 16);
            this.lblFechaLog.TabIndex = 17;
            this.lblFechaLog.Text = "23/10/2014";
            // 
            // lblHoraLog
            // 
            this.lblHoraLog.AutoSize = true;
            this.lblHoraLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraLog.Location = new System.Drawing.Point(150, 31);
            this.lblHoraLog.Name = "lblHoraLog";
            this.lblHoraLog.Size = new System.Drawing.Size(56, 16);
            this.lblHoraLog.TabIndex = 18;
            this.lblHoraLog.Text = "18:15:14";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(10, 5);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(72, 16);
            this.lblUsuario.TabIndex = 14;
            this.lblUsuario.Text = "USUARIO:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblHoraLog);
            this.panel1.Controls.Add(this.lblNombreUsuario);
            this.panel1.Controls.Add(this.lblFechaLog);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Location = new System.Drawing.Point(36, 435);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 49);
            this.panel1.TabIndex = 21;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(88, 5);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(73, 16);
            this.lblNombreUsuario.TabIndex = 15;
            this.lblNombreUsuario.Text = "LEANDRO";
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
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 540);
            this.Controls.Add(this.pnlVentas);
            this.Controls.Add(this.pnlCompras);
            this.Controls.Add(this.pnlABM);
            this.Controls.Add(this.pnlReportes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblBienvenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.Text = "Programa Principal - Version Prototype";
            this.pnlReportes.ResumeLayout(false);
            this.pnlABM.ResumeLayout(false);
            this.pnlCompras.ResumeLayout(false);
            this.pnlVentas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cntxtMenuStripABM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnPedidoProv;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlReportes;
        private System.Windows.Forms.Button btnEmitirReporte;
        private System.Windows.Forms.Panel pnlABM;
        private System.Windows.Forms.Panel pnlCompras;
        private System.Windows.Forms.Panel pnlVentas;
        private System.Windows.Forms.Button btnDevolucion;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Button btnABM;
        internal System.Windows.Forms.Label lblFecha;
        internal System.Windows.Forms.Label lblFechaLog;
        internal System.Windows.Forms.Label lblHoraLog;
        internal System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Timer timerFechaHora;
        private System.Windows.Forms.ContextMenuStrip cntxtMenuStripABM;
        private System.Windows.Forms.ToolStripMenuItem entidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artículosDeProveedoresToolStripMenuItem;
    }
}