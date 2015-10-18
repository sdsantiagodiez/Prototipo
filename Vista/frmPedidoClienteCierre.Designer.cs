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
            this.pnlLowerButtons = new System.Windows.Forms.Panel();
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
            this.cbxTipoTel = new System.Windows.Forms.ComboBox();
            this.lblTipoTel = new System.Windows.Forms.Label();
            this.btnSelDom = new System.Windows.Forms.Button();
            this.btnSelMail = new System.Windows.Forms.Button();
            this.btnSelTel = new System.Windows.Forms.Button();
            this.gbxDomicilio = new System.Windows.Forms.GroupBox();
            this.cbxProvincia = new System.Windows.Forms.ComboBox();
            this.cbxPais = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtDepto = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.lblDepto = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.lblNro = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblCp = new System.Windows.Forms.Label();
            this.ckbxRegistrar = new System.Windows.Forms.CheckBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtBusqCli = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblBuscarCli = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.gbxObservCliente = new System.Windows.Forms.GroupBox();
            this.rtbObsCliente = new System.Windows.Forms.RichTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.pnlSelectButtons = new System.Windows.Forms.Panel();
            this.tlpCierrePedido.SuspendLayout();
            this.pnlLowerButtons.SuspendLayout();
            this.gbxArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosVenta)).BeginInit();
            this.tlpComprobCli.SuspendLayout();
            this.gbxComprobante.SuspendLayout();
            this.gbxObservComprob.SuspendLayout();
            this.gbxCliente.SuspendLayout();
            this.gbxDomicilio.SuspendLayout();
            this.gbxObservCliente.SuspendLayout();
            this.pnlSelectButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpCierrePedido
            // 
            this.tlpCierrePedido.ColumnCount = 1;
            this.tlpCierrePedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCierrePedido.Controls.Add(this.pnlLowerButtons, 0, 2);
            this.tlpCierrePedido.Controls.Add(this.gbxArticulos, 0, 1);
            this.tlpCierrePedido.Controls.Add(this.tlpComprobCli, 0, 0);
            this.tlpCierrePedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCierrePedido.Location = new System.Drawing.Point(0, 0);
            this.tlpCierrePedido.Name = "tlpCierrePedido";
            this.tlpCierrePedido.RowCount = 3;
            this.tlpCierrePedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.03571F));
            this.tlpCierrePedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.96429F));
            this.tlpCierrePedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpCierrePedido.Size = new System.Drawing.Size(1154, 621);
            this.tlpCierrePedido.TabIndex = 13;
            // 
            // pnlLowerButtons
            // 
            this.pnlLowerButtons.Controls.Add(this.btnEmitir);
            this.pnlLowerButtons.Controls.Add(this.btnVolver);
            this.pnlLowerButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLowerButtons.Location = new System.Drawing.Point(3, 563);
            this.pnlLowerButtons.Name = "pnlLowerButtons";
            this.pnlLowerButtons.Size = new System.Drawing.Size(1148, 55);
            this.pnlLowerButtons.TabIndex = 2;
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
            this.gbxArticulos.Size = new System.Drawing.Size(1148, 201);
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
            this.dgvArticulosVenta.Size = new System.Drawing.Size(1142, 180);
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
            this.tlpComprobCli.Size = new System.Drawing.Size(1148, 347);
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
            this.gbxComprobante.Size = new System.Drawing.Size(1142, 151);
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
            this.gbxCliente.Controls.Add(this.pnlSelectButtons);
            this.gbxCliente.Controls.Add(this.cbxTipoTel);
            this.gbxCliente.Controls.Add(this.lblTipoTel);
            this.gbxCliente.Controls.Add(this.gbxDomicilio);
            this.gbxCliente.Controls.Add(this.ckbxRegistrar);
            this.gbxCliente.Controls.Add(this.txtTelefono);
            this.gbxCliente.Controls.Add(this.txtBusqCli);
            this.gbxCliente.Controls.Add(this.txtMail);
            this.gbxCliente.Controls.Add(this.lblBuscarCli);
            this.gbxCliente.Controls.Add(this.txtApellido);
            this.gbxCliente.Controls.Add(this.txtDni);
            this.gbxCliente.Controls.Add(this.gbxObservCliente);
            this.gbxCliente.Controls.Add(this.txtNombre);
            this.gbxCliente.Controls.Add(this.lblApellido);
            this.gbxCliente.Controls.Add(this.lblTelefono);
            this.gbxCliente.Controls.Add(this.lblMail);
            this.gbxCliente.Controls.Add(this.lblNombre);
            this.gbxCliente.Controls.Add(this.lblDni);
            this.gbxCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxCliente.Location = new System.Drawing.Point(3, 160);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Size = new System.Drawing.Size(1142, 184);
            this.gbxCliente.TabIndex = 1;
            this.gbxCliente.TabStop = false;
            this.gbxCliente.Text = "Cliente";
            // 
            // cbxTipoTel
            // 
            this.cbxTipoTel.FormattingEnabled = true;
            this.cbxTipoTel.Location = new System.Drawing.Point(258, 153);
            this.cbxTipoTel.Name = "cbxTipoTel";
            this.cbxTipoTel.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoTel.TabIndex = 48;
            // 
            // lblTipoTel
            // 
            this.lblTipoTel.AutoSize = true;
            this.lblTipoTel.Location = new System.Drawing.Point(221, 156);
            this.lblTipoTel.Name = "lblTipoTel";
            this.lblTipoTel.Size = new System.Drawing.Size(31, 13);
            this.lblTipoTel.TabIndex = 47;
            this.lblTipoTel.Text = "Tipo:";
            // 
            // btnSelDom
            // 
            this.btnSelDom.Location = new System.Drawing.Point(273, 3);
            this.btnSelDom.Name = "btnSelDom";
            this.btnSelDom.Size = new System.Drawing.Size(129, 23);
            this.btnSelDom.TabIndex = 46;
            this.btnSelDom.Text = "Seleccionar Domicilio";
            this.btnSelDom.UseVisualStyleBackColor = true;
            this.btnSelDom.Click += new System.EventHandler(this.btnSelDom_Click);
            // 
            // btnSelMail
            // 
            this.btnSelMail.Location = new System.Drawing.Point(138, 3);
            this.btnSelMail.Name = "btnSelMail";
            this.btnSelMail.Size = new System.Drawing.Size(129, 23);
            this.btnSelMail.TabIndex = 45;
            this.btnSelMail.Text = "Seleccionar Mail";
            this.btnSelMail.UseVisualStyleBackColor = true;
            this.btnSelMail.Click += new System.EventHandler(this.btnSelMail_Click);
            // 
            // btnSelTel
            // 
            this.btnSelTel.Location = new System.Drawing.Point(3, 3);
            this.btnSelTel.Name = "btnSelTel";
            this.btnSelTel.Size = new System.Drawing.Size(129, 23);
            this.btnSelTel.TabIndex = 44;
            this.btnSelTel.Text = "Seleccionar Teléfono";
            this.btnSelTel.UseVisualStyleBackColor = true;
            this.btnSelTel.Click += new System.EventHandler(this.btnSelTel_Click);
            // 
            // gbxDomicilio
            // 
            this.gbxDomicilio.Controls.Add(this.cbxProvincia);
            this.gbxDomicilio.Controls.Add(this.cbxPais);
            this.gbxDomicilio.Controls.Add(this.lblPais);
            this.gbxDomicilio.Controls.Add(this.txtDepto);
            this.gbxDomicilio.Controls.Add(this.txtPiso);
            this.gbxDomicilio.Controls.Add(this.txtNro);
            this.gbxDomicilio.Controls.Add(this.lblDepto);
            this.gbxDomicilio.Controls.Add(this.lblPiso);
            this.gbxDomicilio.Controls.Add(this.txtCiudad);
            this.gbxDomicilio.Controls.Add(this.txtCp);
            this.gbxDomicilio.Controls.Add(this.lblNro);
            this.gbxDomicilio.Controls.Add(this.txtCalle);
            this.gbxDomicilio.Controls.Add(this.lblCalle);
            this.gbxDomicilio.Controls.Add(this.lblCiudad);
            this.gbxDomicilio.Controls.Add(this.lblProvincia);
            this.gbxDomicilio.Controls.Add(this.lblCp);
            this.gbxDomicilio.Location = new System.Drawing.Point(260, 49);
            this.gbxDomicilio.Name = "gbxDomicilio";
            this.gbxDomicilio.Size = new System.Drawing.Size(512, 94);
            this.gbxDomicilio.TabIndex = 43;
            this.gbxDomicilio.TabStop = false;
            this.gbxDomicilio.Text = "Domicilio";
            // 
            // cbxProvincia
            // 
            this.cbxProvincia.FormattingEnabled = true;
            this.cbxProvincia.Location = new System.Drawing.Point(66, 40);
            this.cbxProvincia.Name = "cbxProvincia";
            this.cbxProvincia.Size = new System.Drawing.Size(188, 21);
            this.cbxProvincia.TabIndex = 40;
            // 
            // cbxPais
            // 
            this.cbxPais.FormattingEnabled = true;
            this.cbxPais.Location = new System.Drawing.Point(66, 13);
            this.cbxPais.Name = "cbxPais";
            this.cbxPais.Size = new System.Drawing.Size(188, 21);
            this.cbxPais.TabIndex = 39;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(30, 16);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(30, 13);
            this.lblPais.TabIndex = 38;
            this.lblPais.Text = "Pais:";
            // 
            // txtDepto
            // 
            this.txtDepto.Location = new System.Drawing.Point(308, 63);
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.Size = new System.Drawing.Size(74, 20);
            this.txtDepto.TabIndex = 36;
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(424, 39);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(42, 20);
            this.txtPiso.TabIndex = 35;
            // 
            // txtNro
            // 
            this.txtNro.Location = new System.Drawing.Point(309, 39);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(73, 20);
            this.txtNro.TabIndex = 34;
            // 
            // lblDepto
            // 
            this.lblDepto.AutoSize = true;
            this.lblDepto.Location = new System.Drawing.Point(264, 66);
            this.lblDepto.Name = "lblDepto";
            this.lblDepto.Size = new System.Drawing.Size(39, 13);
            this.lblDepto.TabIndex = 33;
            this.lblDepto.Text = "Depto.";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(388, 42);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(30, 13);
            this.lblPiso.TabIndex = 32;
            this.lblPiso.Text = "Piso:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(66, 65);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(188, 20);
            this.txtCiudad.TabIndex = 36;
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(424, 63);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(73, 20);
            this.txtCp.TabIndex = 29;
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Location = new System.Drawing.Point(276, 42);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(27, 13);
            this.lblNro.TabIndex = 31;
            this.lblNro.Text = "Nro.";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(309, 13);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(188, 20);
            this.txtCalle.TabIndex = 30;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(270, 16);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(33, 13);
            this.lblCalle.TabIndex = 9;
            this.lblCalle.Text = "Calle:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(17, 66);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 8;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(6, 42);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 7;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblCp
            // 
            this.lblCp.AutoSize = true;
            this.lblCp.Location = new System.Drawing.Point(391, 66);
            this.lblCp.Name = "lblCp";
            this.lblCp.Size = new System.Drawing.Size(27, 13);
            this.lblCp.TabIndex = 6;
            this.lblCp.Text = "C.P.";
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
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(66, 153);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(149, 20);
            this.txtTelefono.TabIndex = 38;
            // 
            // txtBusqCli
            // 
            this.txtBusqCli.Location = new System.Drawing.Point(150, 23);
            this.txtBusqCli.Name = "txtBusqCli";
            this.txtBusqCli.Size = new System.Drawing.Size(188, 20);
            this.txtBusqCli.TabIndex = 42;
            this.txtBusqCli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqCli_KeyPress);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(66, 127);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(188, 20);
            this.txtMail.TabIndex = 33;
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
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(66, 101);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(188, 20);
            this.txtApellido.TabIndex = 32;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(66, 49);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(188, 20);
            this.txtDni.TabIndex = 31;
            // 
            // gbxObservCliente
            // 
            this.gbxObservCliente.Controls.Add(this.rtbObsCliente);
            this.gbxObservCliente.Location = new System.Drawing.Point(778, 35);
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
            this.txtNombre.Location = new System.Drawing.Point(66, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(188, 20);
            this.txtNombre.TabIndex = 26;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(13, 104);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 15;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(8, 156);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 14;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(31, 130);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(29, 13);
            this.lblMail.TabIndex = 13;
            this.lblMail.Text = "Mail:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(31, 52);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 11;
            this.lblDni.Text = "DNI:";
            // 
            // pnlSelectButtons
            // 
            this.pnlSelectButtons.Controls.Add(this.btnSelTel);
            this.pnlSelectButtons.Controls.Add(this.btnSelMail);
            this.pnlSelectButtons.Controls.Add(this.btnSelDom);
            this.pnlSelectButtons.Location = new System.Drawing.Point(730, 149);
            this.pnlSelectButtons.Name = "pnlSelectButtons";
            this.pnlSelectButtons.Size = new System.Drawing.Size(406, 30);
            this.pnlSelectButtons.TabIndex = 49;
            this.pnlSelectButtons.Visible = false;
            // 
            // frmPedidoClienteCierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 621);
            this.Controls.Add(this.tlpCierrePedido);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPedidoClienteCierre";
            this.Text = "Cierre de Pedido Cliente (Leandro Jorge)";
            this.tlpCierrePedido.ResumeLayout(false);
            this.pnlLowerButtons.ResumeLayout(false);
            this.gbxArticulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosVenta)).EndInit();
            this.tlpComprobCli.ResumeLayout(false);
            this.gbxComprobante.ResumeLayout(false);
            this.gbxComprobante.PerformLayout();
            this.gbxObservComprob.ResumeLayout(false);
            this.gbxCliente.ResumeLayout(false);
            this.gbxCliente.PerformLayout();
            this.gbxDomicilio.ResumeLayout(false);
            this.gbxDomicilio.PerformLayout();
            this.gbxObservCliente.ResumeLayout(false);
            this.pnlSelectButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCierrePedido;
        private System.Windows.Forms.GroupBox gbxArticulos;
        internal System.Windows.Forms.DataGridView dgvArticulosVenta;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEmitir;
        private System.Windows.Forms.Panel pnlLowerButtons;
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
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.GroupBox gbxObservCliente;
        private System.Windows.Forms.RichTextBox rtbObsCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblCalle;
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
        private System.Windows.Forms.GroupBox gbxDomicilio;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtDepto;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.Label lblDepto;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.Button btnSelDom;
        private System.Windows.Forms.Button btnSelMail;
        private System.Windows.Forms.Button btnSelTel;
        private System.Windows.Forms.ComboBox cbxTipoTel;
        private System.Windows.Forms.Label lblTipoTel;
        private System.Windows.Forms.ComboBox cbxProvincia;
        private System.Windows.Forms.ComboBox cbxPais;
        private System.Windows.Forms.Panel pnlSelectButtons;
    }
}

