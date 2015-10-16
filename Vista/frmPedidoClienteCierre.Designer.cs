namespace Vista
{
    partial class frmPedidoClienteCierre
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpCierrePedido = new System.Windows.Forms.TableLayoutPanel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnEmitir = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gbxArticulos = new System.Windows.Forms.GroupBox();
            this.dgvArticulosVenta = new System.Windows.Forms.DataGridView();
            this.codOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpComprobCli = new System.Windows.Forms.TableLayoutPanel();
            this.gbxComprobante = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTotalVar = new System.Windows.Forms.Label();
            this.lblIvaNetoVar = new System.Windows.Forms.Label();
            this.lblTotalSinIvaVar = new System.Windows.Forms.Label();
            this.gbxObservComprob = new System.Windows.Forms.GroupBox();
            this.rtbObsComprob = new System.Windows.Forms.RichTextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalSinIva = new System.Windows.Forms.Label();
            this.lblIvaNeto = new System.Windows.Forms.Label();
            this.txtIvaPorc = new System.Windows.Forms.TextBox();
            this.lblIvaPorc = new System.Windows.Forms.Label();
            this.txtSenia = new System.Windows.Forms.TextBox();
            this.txtDescuentoNeto = new System.Windows.Forms.TextBox();
            this.lblDescuentoNeto = new System.Windows.Forms.Label();
            this.txtDescuentoPorc = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbxFormaPago = new System.Windows.Forms.ComboBox();
            this.txtNroComp = new System.Windows.Forms.TextBox();
            this.cbxTipoComp = new System.Windows.Forms.ComboBox();
            this.lblNumeroComp = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDescuentoPorc = new System.Windows.Forms.Label();
            this.lblSenia = new System.Windows.Forms.Label();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.lblTipoComp = new System.Windows.Forms.Label();
            this.gbxCliente = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.gbxObservCliente = new System.Windows.Forms.GroupBox();
            this.rtbObsCliente = new System.Windows.Forms.RichTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblCp = new System.Windows.Forms.Label();
            this.ckbxRegistrar = new System.Windows.Forms.CheckBox();
            this.lblBuscarCli = new System.Windows.Forms.Label();
            this.txtBusqCli = new System.Windows.Forms.TextBox();
            this.tlpCierrePedido.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.gbxArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosVenta)).BeginInit();
            this.tlpComprobCli.SuspendLayout();
            this.gbxComprobante.SuspendLayout();
            this.gbxObservComprob.SuspendLayout();
            this.gbxCliente.SuspendLayout();
            this.gbxObservCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpCierrePedido
            // 
            this.tlpCierrePedido.ColumnCount = 1;
            this.tlpCierrePedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCierrePedido.Controls.Add(this.pnlButtons, 0, 2);
            this.tlpCierrePedido.Controls.Add(this.gbxArticulos, 0, 1);
            this.tlpCierrePedido.Controls.Add(this.tlpComprobCli, 0, 0);
            this.tlpCierrePedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCierrePedido.Location = new System.Drawing.Point(0, 0);
            this.tlpCierrePedido.Name = "tlpCierrePedido";
            this.tlpCierrePedido.RowCount = 3;
            this.tlpCierrePedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.03571F));
            this.tlpCierrePedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.96429F));
            this.tlpCierrePedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpCierrePedido.Size = new System.Drawing.Size(1008, 621);
            this.tlpCierrePedido.TabIndex = 13;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnEmitir);
            this.pnlButtons.Controls.Add(this.btnVolver);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(3, 563);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1002, 55);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnEmitir
            // 
            this.btnEmitir.Location = new System.Drawing.Point(852, 7);
            this.btnEmitir.Name = "btnEmitir";
            this.btnEmitir.Size = new System.Drawing.Size(120, 40);
            this.btnEmitir.TabIndex = 1;
            this.btnEmitir.Text = "Emitir Comprobante";
            this.btnEmitir.UseVisualStyleBackColor = true;
            this.btnEmitir.Click += new System.EventHandler(this.btnEmitir_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(27, 7);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(120, 40);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // gbxArticulos
            // 
            this.gbxArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxArticulos.Controls.Add(this.dgvArticulosVenta);
            this.gbxArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxArticulos.Location = new System.Drawing.Point(3, 356);
            this.gbxArticulos.Name = "gbxArticulos";
            this.gbxArticulos.Size = new System.Drawing.Size(1002, 201);
            this.gbxArticulos.TabIndex = 13;
            this.gbxArticulos.TabStop = false;
            this.gbxArticulos.Text = "Artículos";
            // 
            // dgvArticulosVenta
            // 
            this.dgvArticulosVenta.AllowUserToAddRows = false;
            this.dgvArticulosVenta.AllowUserToDeleteRows = false;
            this.dgvArticulosVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulosVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codOriginal,
            this.codProveedor,
            this.descripcion,
            this.vUnitario,
            this.cantidad,
            this.vParcial});
            this.dgvArticulosVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticulosVenta.Location = new System.Drawing.Point(3, 18);
            this.dgvArticulosVenta.Name = "dgvArticulosVenta";
            this.dgvArticulosVenta.ReadOnly = true;
            this.dgvArticulosVenta.RowHeadersVisible = false;
            this.dgvArticulosVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulosVenta.Size = new System.Drawing.Size(996, 180);
            this.dgvArticulosVenta.TabIndex = 5;
            // 
            // codOriginal
            // 
            this.codOriginal.DataPropertyName = "codigoOriginalArt";
            this.codOriginal.HeaderText = "Código Original";
            this.codOriginal.Name = "codOriginal";
            this.codOriginal.ReadOnly = true;
            // 
            // codProveedor
            // 
            this.codProveedor.DataPropertyName = "codigoArtProveedor";
            this.codProveedor.HeaderText = "Código Proveedor";
            this.codProveedor.Name = "codProveedor";
            this.codProveedor.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // vUnitario
            // 
            this.vUnitario.DataPropertyName = "valorUnitario";
            this.vUnitario.HeaderText = "Valor Unitario";
            this.vUnitario.Name = "vUnitario";
            this.vUnitario.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidadArticulos";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // vParcial
            // 
            this.vParcial.DataPropertyName = "valorParcial";
            this.vParcial.HeaderText = "Valor Parcial";
            this.vParcial.Name = "vParcial";
            this.vParcial.ReadOnly = true;
            // 
            // tlpComprobCli
            // 
            this.tlpComprobCli.ColumnCount = 1;
            this.tlpComprobCli.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpComprobCli.Controls.Add(this.gbxComprobante, 0, 0);
            this.tlpComprobCli.Controls.Add(this.gbxCliente, 0, 1);
            this.tlpComprobCli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpComprobCli.Location = new System.Drawing.Point(3, 3);
            this.tlpComprobCli.Name = "tlpComprobCli";
            this.tlpComprobCli.RowCount = 2;
            this.tlpComprobCli.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.53314F));
            this.tlpComprobCli.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.46686F));
            this.tlpComprobCli.Size = new System.Drawing.Size(1002, 347);
            this.tlpComprobCli.TabIndex = 14;
            // 
            // gbxComprobante
            // 
            this.gbxComprobante.Controls.Add(this.btnCalcular);
            this.gbxComprobante.Controls.Add(this.lblTotalVar);
            this.gbxComprobante.Controls.Add(this.lblIvaNetoVar);
            this.gbxComprobante.Controls.Add(this.lblTotalSinIvaVar);
            this.gbxComprobante.Controls.Add(this.gbxObservComprob);
            this.gbxComprobante.Controls.Add(this.lblTotal);
            this.gbxComprobante.Controls.Add(this.lblTotalSinIva);
            this.gbxComprobante.Controls.Add(this.lblIvaNeto);
            this.gbxComprobante.Controls.Add(this.txtIvaPorc);
            this.gbxComprobante.Controls.Add(this.lblIvaPorc);
            this.gbxComprobante.Controls.Add(this.txtSenia);
            this.gbxComprobante.Controls.Add(this.txtDescuentoNeto);
            this.gbxComprobante.Controls.Add(this.lblDescuentoNeto);
            this.gbxComprobante.Controls.Add(this.txtDescuentoPorc);
            this.gbxComprobante.Controls.Add(this.dtpFecha);
            this.gbxComprobante.Controls.Add(this.cbxFormaPago);
            this.gbxComprobante.Controls.Add(this.txtNroComp);
            this.gbxComprobante.Controls.Add(this.cbxTipoComp);
            this.gbxComprobante.Controls.Add(this.lblNumeroComp);
            this.gbxComprobante.Controls.Add(this.lblFecha);
            this.gbxComprobante.Controls.Add(this.lblDescuentoPorc);
            this.gbxComprobante.Controls.Add(this.lblSenia);
            this.gbxComprobante.Controls.Add(this.lblFormaPago);
            this.gbxComprobante.Controls.Add(this.lblTipoComp);
            this.gbxComprobante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxComprobante.Location = new System.Drawing.Point(3, 3);
            this.gbxComprobante.Name = "gbxComprobante";
            this.gbxComprobante.Size = new System.Drawing.Size(996, 152);
            this.gbxComprobante.TabIndex = 0;
            this.gbxComprobante.TabStop = false;
            this.gbxComprobante.Text = "Comprobante";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(522, 120);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 29;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTotalVar
            // 
            this.lblTotalVar.AutoSize = true;
            this.lblTotalVar.Location = new System.Drawing.Point(519, 96);
            this.lblTotalVar.Name = "lblTotalVar";
            this.lblTotalVar.Size = new System.Drawing.Size(13, 13);
            this.lblTotalVar.TabIndex = 28;
            this.lblTotalVar.Text = "0";
            // 
            // lblIvaNetoVar
            // 
            this.lblIvaNetoVar.AutoSize = true;
            this.lblIvaNetoVar.Location = new System.Drawing.Point(519, 63);
            this.lblIvaNetoVar.Name = "lblIvaNetoVar";
            this.lblIvaNetoVar.Size = new System.Drawing.Size(13, 13);
            this.lblIvaNetoVar.TabIndex = 27;
            this.lblIvaNetoVar.Text = "0";
            // 
            // lblTotalSinIvaVar
            // 
            this.lblTotalSinIvaVar.AutoSize = true;
            this.lblTotalSinIvaVar.Location = new System.Drawing.Point(519, 34);
            this.lblTotalSinIvaVar.Name = "lblTotalSinIvaVar";
            this.lblTotalSinIvaVar.Size = new System.Drawing.Size(13, 13);
            this.lblTotalSinIvaVar.TabIndex = 26;
            this.lblTotalSinIvaVar.Text = "0";
            // 
            // gbxObservComprob
            // 
            this.gbxObservComprob.Controls.Add(this.rtbObsComprob);
            this.gbxObservComprob.Location = new System.Drawing.Point(633, 30);
            this.gbxObservComprob.Name = "gbxObservComprob";
            this.gbxObservComprob.Size = new System.Drawing.Size(357, 112);
            this.gbxObservComprob.TabIndex = 25;
            this.gbxObservComprob.TabStop = false;
            this.gbxObservComprob.Text = "Observaciones";
            // 
            // rtbObsComprob
            // 
            this.rtbObsComprob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbObsComprob.Location = new System.Drawing.Point(3, 16);
            this.rtbObsComprob.Name = "rtbObsComprob";
            this.rtbObsComprob.Size = new System.Drawing.Size(351, 93);
            this.rtbObsComprob.TabIndex = 0;
            this.rtbObsComprob.Text = "";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(438, 96);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 13);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "TOTAL:";
            // 
            // lblTotalSinIva
            // 
            this.lblTotalSinIva.AutoSize = true;
            this.lblTotalSinIva.Location = new System.Drawing.Point(414, 34);
            this.lblTotalSinIva.Name = "lblTotalSinIva";
            this.lblTotalSinIva.Size = new System.Drawing.Size(72, 13);
            this.lblTotalSinIva.TabIndex = 19;
            this.lblTotalSinIva.Text = "Total Sin IVA:";
            // 
            // lblIvaNeto
            // 
            this.lblIvaNeto.AutoSize = true;
            this.lblIvaNeto.Location = new System.Drawing.Point(456, 64);
            this.lblIvaNeto.Name = "lblIvaNeto";
            this.lblIvaNeto.Size = new System.Drawing.Size(27, 13);
            this.lblIvaNeto.TabIndex = 18;
            this.lblIvaNeto.Text = "IVA:";
            // 
            // txtIvaPorc
            // 
            this.txtIvaPorc.Location = new System.Drawing.Point(287, 122);
            this.txtIvaPorc.Name = "txtIvaPorc";
            this.txtIvaPorc.Size = new System.Drawing.Size(121, 20);
            this.txtIvaPorc.TabIndex = 16;
            this.txtIvaPorc.Text = "21";
            this.txtIvaPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIvaPorc
            // 
            this.lblIvaPorc.AutoSize = true;
            this.lblIvaPorc.Location = new System.Drawing.Point(237, 125);
            this.lblIvaPorc.Name = "lblIvaPorc";
            this.lblIvaPorc.Size = new System.Drawing.Size(44, 13);
            this.lblIvaPorc.TabIndex = 15;
            this.lblIvaPorc.Text = "IVA (%):";
            // 
            // txtSenia
            // 
            this.txtSenia.Location = new System.Drawing.Point(287, 93);
            this.txtSenia.Name = "txtSenia";
            this.txtSenia.Size = new System.Drawing.Size(121, 20);
            this.txtSenia.TabIndex = 14;
            this.txtSenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescuentoNeto
            // 
            this.txtDescuentoNeto.Location = new System.Drawing.Point(107, 122);
            this.txtDescuentoNeto.Name = "txtDescuentoNeto";
            this.txtDescuentoNeto.Size = new System.Drawing.Size(121, 20);
            this.txtDescuentoNeto.TabIndex = 13;
            this.txtDescuentoNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDescuentoNeto
            // 
            this.lblDescuentoNeto.AutoSize = true;
            this.lblDescuentoNeto.Location = new System.Drawing.Point(28, 125);
            this.lblDescuentoNeto.Name = "lblDescuentoNeto";
            this.lblDescuentoNeto.Size = new System.Drawing.Size(77, 13);
            this.lblDescuentoNeto.TabIndex = 12;
            this.lblDescuentoNeto.Text = "Descuento ($):";
            // 
            // txtDescuentoPorc
            // 
            this.txtDescuentoPorc.Location = new System.Drawing.Point(107, 93);
            this.txtDescuentoPorc.Name = "txtDescuentoPorc";
            this.txtDescuentoPorc.Size = new System.Drawing.Size(121, 20);
            this.txtDescuentoPorc.TabIndex = 10;
            this.txtDescuentoPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(287, 63);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 20);
            this.dtpFecha.TabIndex = 9;
            // 
            // cbxFormaPago
            // 
            this.cbxFormaPago.FormattingEnabled = true;
            this.cbxFormaPago.Items.AddRange(new object[] {
            "Contado",
            "Tarjeta"});
            this.cbxFormaPago.Location = new System.Drawing.Point(107, 60);
            this.cbxFormaPago.Name = "cbxFormaPago";
            this.cbxFormaPago.Size = new System.Drawing.Size(121, 21);
            this.cbxFormaPago.TabIndex = 8;
            // 
            // txtNroComp
            // 
            this.txtNroComp.Location = new System.Drawing.Point(287, 31);
            this.txtNroComp.Name = "txtNroComp";
            this.txtNroComp.Size = new System.Drawing.Size(121, 20);
            this.txtNroComp.TabIndex = 7;
            this.txtNroComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxTipoComp
            // 
            this.cbxTipoComp.FormattingEnabled = true;
            this.cbxTipoComp.Items.AddRange(new object[] {
            "Presupuesto",
            "Ticket",
            "Factura-A",
            "Factura-B",
            "Reserva",
            "Devolución"});
            this.cbxTipoComp.Location = new System.Drawing.Point(107, 30);
            this.cbxTipoComp.Name = "cbxTipoComp";
            this.cbxTipoComp.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoComp.TabIndex = 6;
            // 
            // lblNumeroComp
            // 
            this.lblNumeroComp.AutoSize = true;
            this.lblNumeroComp.Location = new System.Drawing.Point(234, 34);
            this.lblNumeroComp.Name = "lblNumeroComp";
            this.lblNumeroComp.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroComp.TabIndex = 5;
            this.lblNumeroComp.Text = "Número:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(241, 64);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblDescuentoPorc
            // 
            this.lblDescuentoPorc.AutoSize = true;
            this.lblDescuentoPorc.Location = new System.Drawing.Point(26, 96);
            this.lblDescuentoPorc.Name = "lblDescuentoPorc";
            this.lblDescuentoPorc.Size = new System.Drawing.Size(79, 13);
            this.lblDescuentoPorc.TabIndex = 3;
            this.lblDescuentoPorc.Text = "Descuento (%):";
            // 
            // lblSenia
            // 
            this.lblSenia.AutoSize = true;
            this.lblSenia.Location = new System.Drawing.Point(246, 96);
            this.lblSenia.Name = "lblSenia";
            this.lblSenia.Size = new System.Drawing.Size(35, 13);
            this.lblSenia.TabIndex = 2;
            this.lblSenia.Text = "Seña:";
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(23, 64);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(82, 13);
            this.lblFormaPago.TabIndex = 1;
            this.lblFormaPago.Text = "Forma de Pago:";
            // 
            // lblTipoComp
            // 
            this.lblTipoComp.AutoSize = true;
            this.lblTipoComp.Location = new System.Drawing.Point(8, 34);
            this.lblTipoComp.Name = "lblTipoComp";
            this.lblTipoComp.Size = new System.Drawing.Size(97, 13);
            this.lblTipoComp.TabIndex = 0;
            this.lblTipoComp.Text = "Tipo Comprobante:";
            // 
            // gbxCliente
            // 
            this.gbxCliente.Controls.Add(this.ckbxRegistrar);
            this.gbxCliente.Controls.Add(this.txtTelefono);
            this.gbxCliente.Controls.Add(this.txtBusqCli);
            this.gbxCliente.Controls.Add(this.txtProvincia);
            this.gbxCliente.Controls.Add(this.txtCiudad);
            this.gbxCliente.Controls.Add(this.txtCuit);
            this.gbxCliente.Controls.Add(this.txtMail);
            this.gbxCliente.Controls.Add(this.lblBuscarCli);
            this.gbxCliente.Controls.Add(this.txtApellido);
            this.gbxCliente.Controls.Add(this.txtDni);
            this.gbxCliente.Controls.Add(this.txtDireccion);
            this.gbxCliente.Controls.Add(this.txtCp);
            this.gbxCliente.Controls.Add(this.gbxObservCliente);
            this.gbxCliente.Controls.Add(this.txtNombre);
            this.gbxCliente.Controls.Add(this.lblApellido);
            this.gbxCliente.Controls.Add(this.lblTelefono);
            this.gbxCliente.Controls.Add(this.lblMail);
            this.gbxCliente.Controls.Add(this.lblNombre);
            this.gbxCliente.Controls.Add(this.lblDni);
            this.gbxCliente.Controls.Add(this.lblCuit);
            this.gbxCliente.Controls.Add(this.lblDireccion);
            this.gbxCliente.Controls.Add(this.lblCiudad);
            this.gbxCliente.Controls.Add(this.lblProvincia);
            this.gbxCliente.Controls.Add(this.lblCp);
            this.gbxCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxCliente.Location = new System.Drawing.Point(3, 161);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Size = new System.Drawing.Size(996, 183);
            this.gbxCliente.TabIndex = 1;
            this.gbxCliente.TabStop = false;
            this.gbxCliente.Text = "Cliente";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(66, 155);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(188, 20);
            this.txtTelefono.TabIndex = 38;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(344, 127);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(188, 20);
            this.txtProvincia.TabIndex = 37;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(66, 129);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(188, 20);
            this.txtCiudad.TabIndex = 36;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(344, 75);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(188, 20);
            this.txtCuit.TabIndex = 35;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(344, 101);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(188, 20);
            this.txtMail.TabIndex = 33;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(344, 49);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(188, 20);
            this.txtApellido.TabIndex = 32;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(66, 75);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(188, 20);
            this.txtDni.TabIndex = 31;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(66, 101);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(188, 20);
            this.txtDireccion.TabIndex = 30;
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(344, 153);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(188, 20);
            this.txtCp.TabIndex = 29;
            // 
            // gbxObservCliente
            // 
            this.gbxObservCliente.Controls.Add(this.rtbObsCliente);
            this.gbxObservCliente.Location = new System.Drawing.Point(630, 49);
            this.gbxObservCliente.Name = "gbxObservCliente";
            this.gbxObservCliente.Size = new System.Drawing.Size(357, 112);
            this.gbxObservCliente.TabIndex = 28;
            this.gbxObservCliente.TabStop = false;
            this.gbxObservCliente.Text = "Observaciones";
            // 
            // rtbObsCliente
            // 
            this.rtbObsCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbObsCliente.Location = new System.Drawing.Point(3, 16);
            this.rtbObsCliente.Name = "rtbObsCliente";
            this.rtbObsCliente.Size = new System.Drawing.Size(351, 93);
            this.rtbObsCliente.TabIndex = 0;
            this.rtbObsCliente.Text = "";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(66, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(188, 20);
            this.txtNombre.TabIndex = 26;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(291, 52);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 15;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(8, 158);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 14;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(309, 104);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(29, 13);
            this.lblMail.TabIndex = 13;
            this.lblMail.Text = "Mail:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(31, 80);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 11;
            this.lblDni.Text = "DNI:";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(303, 78);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(35, 13);
            this.lblCuit.TabIndex = 10;
            this.lblCuit.Text = "CUIT:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(8, 104);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(17, 132);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 8;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(284, 130);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 7;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblCp
            // 
            this.lblCp.AutoSize = true;
            this.lblCp.Location = new System.Drawing.Point(263, 156);
            this.lblCp.Name = "lblCp";
            this.lblCp.Size = new System.Drawing.Size(75, 13);
            this.lblCp.TabIndex = 6;
            this.lblCp.Text = "Código Postal:";
            // 
            // ckbxRegistrar
            // 
            this.ckbxRegistrar.AutoSize = true;
            this.ckbxRegistrar.Location = new System.Drawing.Point(429, 25);
            this.ckbxRegistrar.Name = "ckbxRegistrar";
            this.ckbxRegistrar.Size = new System.Drawing.Size(103, 17);
            this.ckbxRegistrar.TabIndex = 39;
            this.ckbxRegistrar.Text = "Registrar Cliente";
            this.ckbxRegistrar.UseVisualStyleBackColor = true;
            // 
            // lblBuscarCli
            // 
            this.lblBuscarCli.AutoSize = true;
            this.lblBuscarCli.Location = new System.Drawing.Point(41, 26);
            this.lblBuscarCli.Name = "lblBuscarCli";
            this.lblBuscarCli.Size = new System.Drawing.Size(103, 13);
            this.lblBuscarCli.TabIndex = 40;
            this.lblBuscarCli.Text = "Buscar Cliente (DNI)";
            // 
            // txtBusqCli
            // 
            this.txtBusqCli.Location = new System.Drawing.Point(150, 23);
            this.txtBusqCli.Name = "txtBusqCli";
            this.txtBusqCli.Size = new System.Drawing.Size(188, 20);
            this.txtBusqCli.TabIndex = 42;
            this.txtBusqCli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqCli_KeyPress);
            // 
            // frmPedidoClienteCierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 621);
            this.Controls.Add(this.tlpCierrePedido);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPedidoClienteCierre";
            this.Text = "Cierre de Pedido Cliente (Leandro Jorge)";
            this.tlpCierrePedido.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.gbxArticulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosVenta)).EndInit();
            this.tlpComprobCli.ResumeLayout(false);
            this.gbxComprobante.ResumeLayout(false);
            this.gbxComprobante.PerformLayout();
            this.gbxObservComprob.ResumeLayout(false);
            this.gbxCliente.ResumeLayout(false);
            this.gbxCliente.PerformLayout();
            this.gbxObservCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCierrePedido;
        private System.Windows.Forms.GroupBox gbxArticulos;
        internal System.Windows.Forms.DataGridView dgvArticulosVenta;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEmitir;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.TableLayoutPanel tlpComprobCli;
        private System.Windows.Forms.GroupBox gbxComprobante;
        private System.Windows.Forms.GroupBox gbxCliente;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cbxFormaPago;
        private System.Windows.Forms.TextBox txtNroComp;
        private System.Windows.Forms.ComboBox cbxTipoComp;
        private System.Windows.Forms.Label lblNumeroComp;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDescuentoPorc;
        private System.Windows.Forms.Label lblSenia;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.Label lblTipoComp;
        private System.Windows.Forms.TextBox txtDescuentoPorc;
        private System.Windows.Forms.TextBox txtDescuentoNeto;
        private System.Windows.Forms.Label lblDescuentoNeto;
        private System.Windows.Forms.TextBox txtSenia;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalSinIva;
        private System.Windows.Forms.Label lblIvaNeto;
        private System.Windows.Forms.TextBox txtIvaPorc;
        private System.Windows.Forms.Label lblIvaPorc;
        private System.Windows.Forms.GroupBox gbxObservComprob;
        private System.Windows.Forms.RichTextBox rtbObsComprob;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.GroupBox gbxObservCliente;
        private System.Windows.Forms.RichTextBox rtbObsCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblCp;
        private System.Windows.Forms.DataGridViewTextBoxColumn codOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn vUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn vParcial;
        private System.Windows.Forms.Label lblIvaNetoVar;
        private System.Windows.Forms.Label lblTotalSinIvaVar;
        private System.Windows.Forms.Label lblTotalVar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.CheckBox ckbxRegistrar;
        private System.Windows.Forms.TextBox txtBusqCli;
        private System.Windows.Forms.Label lblBuscarCli;
    }
}

