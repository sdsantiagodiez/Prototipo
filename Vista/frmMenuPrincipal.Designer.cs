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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnPedidoProv = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlER = new System.Windows.Forms.Panel();
            this.btnEmitirReporte = new System.Windows.Forms.Button();
            this.pnlED = new System.Windows.Forms.Panel();
            this.btnAltBajMod = new System.Windows.Forms.Button();
            this.pnlEC = new System.Windows.Forms.Panel();
            this.pnlEV = new System.Windows.Forms.Panel();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.btnReserva = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFechaLog = new System.Windows.Forms.Label();
            this.lblHoraLog = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.pnlER.SuspendLayout();
            this.pnlED.SuspendLayout();
            this.pnlEC.SuspendLayout();
            this.pnlEV.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.lblBienvenido.Location = new System.Drawing.Point(11, 7);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(256, 42);
            this.lblBienvenido.TabIndex = 5;
            this.lblBienvenido.Text = "BIENVENIDO";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(59, 490);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(162, 40);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlER
            // 
            this.pnlER.Controls.Add(this.btnEmitirReporte);
            this.pnlER.Location = new System.Drawing.Point(39, 52);
            this.pnlER.Name = "pnlER";
            this.pnlER.Size = new System.Drawing.Size(199, 65);
            this.pnlER.TabIndex = 23;
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
            // pnlED
            // 
            this.pnlED.Controls.Add(this.btnAltBajMod);
            this.pnlED.Location = new System.Drawing.Point(39, 364);
            this.pnlED.Name = "pnlED";
            this.pnlED.Size = new System.Drawing.Size(200, 65);
            this.pnlED.TabIndex = 25;
            // 
            // btnAltBajMod
            // 
            this.btnAltBajMod.Location = new System.Drawing.Point(20, 13);
            this.btnAltBajMod.Name = "btnAltBajMod";
            this.btnAltBajMod.Size = new System.Drawing.Size(162, 40);
            this.btnAltBajMod.TabIndex = 0;
            this.btnAltBajMod.Text = "Altas, Bajas, y  Modificaciones";
            this.btnAltBajMod.UseVisualStyleBackColor = true;
            this.btnAltBajMod.Click += new System.EventHandler(this.btnAltBajMod_Click);
            // 
            // pnlEC
            // 
            this.pnlEC.Controls.Add(this.btnPedidoProv);
            this.pnlEC.Location = new System.Drawing.Point(38, 123);
            this.pnlEC.Name = "pnlEC";
            this.pnlEC.Size = new System.Drawing.Size(200, 62);
            this.pnlEC.TabIndex = 26;
            // 
            // pnlEV
            // 
            this.pnlEV.Controls.Add(this.btnDevolucion);
            this.pnlEV.Controls.Add(this.btnReserva);
            this.pnlEV.Controls.Add(this.btnVenta);
            this.pnlEV.Location = new System.Drawing.Point(39, 192);
            this.pnlEV.Name = "pnlEV";
            this.pnlEV.Size = new System.Drawing.Size(200, 166);
            this.pnlEV.TabIndex = 27;
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
            this.panel1.Location = new System.Drawing.Point(28, 435);
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
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 540);
            this.Controls.Add(this.pnlEV);
            this.Controls.Add(this.pnlEC);
            this.Controls.Add(this.pnlED);
            this.Controls.Add(this.pnlER);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblBienvenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.Text = "Programa Principal - Version Prototype";
            this.pnlER.ResumeLayout(false);
            this.pnlED.ResumeLayout(false);
            this.pnlEC.ResumeLayout(false);
            this.pnlEV.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnPedidoProv;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlER;
        private System.Windows.Forms.Button btnEmitirReporte;
        private System.Windows.Forms.Panel pnlED;
        private System.Windows.Forms.Panel pnlEC;
        private System.Windows.Forms.Panel pnlEV;
        private System.Windows.Forms.Button btnDevolucion;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Button btnAltBajMod;
        internal System.Windows.Forms.Label lblFecha;
        internal System.Windows.Forms.Label lblFechaLog;
        internal System.Windows.Forms.Label lblHoraLog;
        internal System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label lblNombreUsuario;
    }
}