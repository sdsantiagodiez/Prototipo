namespace Vista
{
    partial class frmPedidoProveedorCierre
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
            this.tlpCierreProveedor = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBotonera = new System.Windows.Forms.Panel();
            this.btnEmitirComprobante = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gbxDetalleArticulos = new System.Windows.Forms.GroupBox();
            this.dgvDetalleArticulos = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gbxComprobante = new System.Windows.Forms.GroupBox();
            this.gbxObservacionesComprobante = new System.Windows.Forms.GroupBox();
            this.rtbObservacionesComprobante = new System.Windows.Forms.RichTextBox();
            this.lblTotalBruto = new System.Windows.Forms.Label();
            this.lblTotalNeto = new System.Windows.Forms.Label();
            this.lblIVANeto = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblIVAPorcentual = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblDescuentoNeto = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblNumeroComprobante = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDescuentoPorcentual = new System.Windows.Forms.Label();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.lblTipoComprobante = new System.Windows.Forms.Label();
            this.gbxProveedor = new System.Windows.Forms.GroupBox();
            this.gbxObservacionesProveedor = new System.Windows.Forms.GroupBox();
            this.rtbObservacionesProveedor = new System.Windows.Forms.RichTextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.tlpCierreProveedor.SuspendLayout();
            this.pnlBotonera.SuspendLayout();
            this.gbxDetalleArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleArticulos)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbxComprobante.SuspendLayout();
            this.gbxObservacionesComprobante.SuspendLayout();
            this.gbxProveedor.SuspendLayout();
            this.gbxObservacionesProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpCierreProveedor
            // 
            this.tlpCierreProveedor.ColumnCount = 1;
            this.tlpCierreProveedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCierreProveedor.Controls.Add(this.pnlBotonera, 0, 2);
            this.tlpCierreProveedor.Controls.Add(this.gbxDetalleArticulos, 0, 1);
            this.tlpCierreProveedor.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tlpCierreProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCierreProveedor.Location = new System.Drawing.Point(0, 0);
            this.tlpCierreProveedor.Name = "tlpCierreProveedor";
            this.tlpCierreProveedor.RowCount = 3;
            this.tlpCierreProveedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.83333F));
            this.tlpCierreProveedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.16667F));
            this.tlpCierreProveedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpCierreProveedor.Size = new System.Drawing.Size(1008, 621);
            this.tlpCierreProveedor.TabIndex = 14;
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.Controls.Add(this.btnEmitirComprobante);
            this.pnlBotonera.Controls.Add(this.btnVolver);
            this.pnlBotonera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotonera.Location = new System.Drawing.Point(3, 563);
            this.pnlBotonera.Name = "pnlBotonera";
            this.pnlBotonera.Size = new System.Drawing.Size(1002, 55);
            this.pnlBotonera.TabIndex = 2;
            // 
            // btnEmitirComprobante
            // 
            this.btnEmitirComprobante.Location = new System.Drawing.Point(852, 7);
            this.btnEmitirComprobante.Name = "btnEmitirComprobante";
            this.btnEmitirComprobante.Size = new System.Drawing.Size(120, 40);
            this.btnEmitirComprobante.TabIndex = 1;
            this.btnEmitirComprobante.Text = "Emitir Comprobante";
            this.btnEmitirComprobante.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(27, 7);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(120, 40);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // gbxDetalleArticulos
            // 
            this.gbxDetalleArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDetalleArticulos.Controls.Add(this.dgvDetalleArticulos);
            this.gbxDetalleArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetalleArticulos.Location = new System.Drawing.Point(3, 344);
            this.gbxDetalleArticulos.Name = "gbxDetalleArticulos";
            this.gbxDetalleArticulos.Size = new System.Drawing.Size(1002, 213);
            this.gbxDetalleArticulos.TabIndex = 13;
            this.gbxDetalleArticulos.TabStop = false;
            this.gbxDetalleArticulos.Text = "Artículos";
            // 
            // dgvDetalleArticulos
            // 
            this.dgvDetalleArticulos.AllowUserToAddRows = false;
            this.dgvDetalleArticulos.AllowUserToDeleteRows = false;
            this.dgvDetalleArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Descripcion,
            this.DataGridViewTextBoxColumn5,
            this.Total,
            this.Column6});
            this.dgvDetalleArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalleArticulos.Location = new System.Drawing.Point(3, 18);
            this.dgvDetalleArticulos.Name = "dgvDetalleArticulos";
            this.dgvDetalleArticulos.ReadOnly = true;
            this.dgvDetalleArticulos.RowHeadersVisible = false;
            this.dgvDetalleArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleArticulos.Size = new System.Drawing.Size(996, 192);
            this.dgvDetalleArticulos.TabIndex = 5;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column7.HeaderText = "Código Proveedor";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 132;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn5
            // 
            this.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DataGridViewTextBoxColumn5.HeaderText = "Precio Unitario";
            this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            this.DataGridViewTextBoxColumn5.ReadOnly = true;
            this.DataGridViewTextBoxColumn5.Width = 111;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Total.HeaderText = "Precio Parcial";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 107;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column6.HeaderText = "Cantidad";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 87;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.gbxComprobante, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.gbxProveedor, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1002, 335);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // gbxComprobante
            // 
            this.gbxComprobante.Controls.Add(this.gbxObservacionesComprobante);
            this.gbxComprobante.Controls.Add(this.lblTotalBruto);
            this.gbxComprobante.Controls.Add(this.lblTotalNeto);
            this.gbxComprobante.Controls.Add(this.lblIVANeto);
            this.gbxComprobante.Controls.Add(this.label9);
            this.gbxComprobante.Controls.Add(this.textBox5);
            this.gbxComprobante.Controls.Add(this.lblIVAPorcentual);
            this.gbxComprobante.Controls.Add(this.textBox3);
            this.gbxComprobante.Controls.Add(this.lblDescuentoNeto);
            this.gbxComprobante.Controls.Add(this.textBox2);
            this.gbxComprobante.Controls.Add(this.dateTimePicker1);
            this.gbxComprobante.Controls.Add(this.comboBox2);
            this.gbxComprobante.Controls.Add(this.textBox1);
            this.gbxComprobante.Controls.Add(this.comboBox1);
            this.gbxComprobante.Controls.Add(this.lblNumeroComprobante);
            this.gbxComprobante.Controls.Add(this.lblFecha);
            this.gbxComprobante.Controls.Add(this.lblDescuentoPorcentual);
            this.gbxComprobante.Controls.Add(this.lblFormaPago);
            this.gbxComprobante.Controls.Add(this.lblTipoComprobante);
            this.gbxComprobante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxComprobante.Location = new System.Drawing.Point(3, 3);
            this.gbxComprobante.Name = "gbxComprobante";
            this.gbxComprobante.Size = new System.Drawing.Size(996, 161);
            this.gbxComprobante.TabIndex = 0;
            this.gbxComprobante.TabStop = false;
            this.gbxComprobante.Text = "Comprobante";
            // 
            // gbxObservacionesComprobante
            // 
            this.gbxObservacionesComprobante.Controls.Add(this.rtbObservacionesComprobante);
            this.gbxObservacionesComprobante.Location = new System.Drawing.Point(633, 30);
            this.gbxObservacionesComprobante.Name = "gbxObservacionesComprobante";
            this.gbxObservacionesComprobante.Size = new System.Drawing.Size(357, 112);
            this.gbxObservacionesComprobante.TabIndex = 25;
            this.gbxObservacionesComprobante.TabStop = false;
            this.gbxObservacionesComprobante.Text = "Observaciones";
            // 
            // rtbObservacionesComprobante
            // 
            this.rtbObservacionesComprobante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbObservacionesComprobante.Location = new System.Drawing.Point(3, 16);
            this.rtbObservacionesComprobante.Name = "rtbObservacionesComprobante";
            this.rtbObservacionesComprobante.Size = new System.Drawing.Size(351, 93);
            this.rtbObservacionesComprobante.TabIndex = 0;
            this.rtbObservacionesComprobante.Text = "";
            // 
            // lblTotalBruto
            // 
            this.lblTotalBruto.AutoSize = true;
            this.lblTotalBruto.Location = new System.Drawing.Point(427, 110);
            this.lblTotalBruto.Name = "lblTotalBruto";
            this.lblTotalBruto.Size = new System.Drawing.Size(45, 13);
            this.lblTotalBruto.TabIndex = 22;
            this.lblTotalBruto.Text = "TOTAL:";
            // 
            // lblTotalNeto
            // 
            this.lblTotalNeto.AutoSize = true;
            this.lblTotalNeto.Location = new System.Drawing.Point(427, 33);
            this.lblTotalNeto.Name = "lblTotalNeto";
            this.lblTotalNeto.Size = new System.Drawing.Size(60, 13);
            this.lblTotalNeto.TabIndex = 19;
            this.lblTotalNeto.Text = "Total Neto:";
            // 
            // lblIVANeto
            // 
            this.lblIVANeto.AutoSize = true;
            this.lblIVANeto.Location = new System.Drawing.Point(427, 63);
            this.lblIVANeto.Name = "lblIVANeto";
            this.lblIVANeto.Size = new System.Drawing.Size(27, 13);
            this.lblIVANeto.TabIndex = 18;
            this.lblIVANeto.Text = "IVA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "%";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(287, 93);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 16;
            // 
            // lblIVAPorcentual
            // 
            this.lblIVAPorcentual.AutoSize = true;
            this.lblIVAPorcentual.Location = new System.Drawing.Point(236, 96);
            this.lblIVAPorcentual.Name = "lblIVAPorcentual";
            this.lblIVAPorcentual.Size = new System.Drawing.Size(27, 13);
            this.lblIVAPorcentual.TabIndex = 15;
            this.lblIVAPorcentual.Text = "IVA:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(107, 122);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 13;
            // 
            // lblDescuentoNeto
            // 
            this.lblDescuentoNeto.AutoSize = true;
            this.lblDescuentoNeto.Location = new System.Drawing.Point(8, 125);
            this.lblDescuentoNeto.Name = "lblDescuentoNeto";
            this.lblDescuentoNeto.Size = new System.Drawing.Size(77, 13);
            this.lblDescuentoNeto.TabIndex = 12;
            this.lblDescuentoNeto.Text = "Descuento ($):";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(287, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Contado",
            "Tarjeta"});
            this.comboBox2.Location = new System.Drawing.Point(107, 60);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(287, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Orden de Compra",
            "Presupuesto"});
            this.comboBox1.Location = new System.Drawing.Point(107, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // lblNumeroComprobante
            // 
            this.lblNumeroComprobante.AutoSize = true;
            this.lblNumeroComprobante.Location = new System.Drawing.Point(234, 34);
            this.lblNumeroComprobante.Name = "lblNumeroComprobante";
            this.lblNumeroComprobante.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroComprobante.TabIndex = 5;
            this.lblNumeroComprobante.Text = "Número:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(236, 63);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblDescuentoPorcentual
            // 
            this.lblDescuentoPorcentual.AutoSize = true;
            this.lblDescuentoPorcentual.Location = new System.Drawing.Point(8, 96);
            this.lblDescuentoPorcentual.Name = "lblDescuentoPorcentual";
            this.lblDescuentoPorcentual.Size = new System.Drawing.Size(79, 13);
            this.lblDescuentoPorcentual.TabIndex = 3;
            this.lblDescuentoPorcentual.Text = "Descuento (%):";
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(8, 63);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(82, 13);
            this.lblFormaPago.TabIndex = 1;
            this.lblFormaPago.Text = "Forma de Pago:";
            // 
            // lblTipoComprobante
            // 
            this.lblTipoComprobante.AutoSize = true;
            this.lblTipoComprobante.Location = new System.Drawing.Point(8, 34);
            this.lblTipoComprobante.Name = "lblTipoComprobante";
            this.lblTipoComprobante.Size = new System.Drawing.Size(97, 13);
            this.lblTipoComprobante.TabIndex = 0;
            this.lblTipoComprobante.Text = "Tipo Comprobante:";
            // 
            // gbxProveedor
            // 
            this.gbxProveedor.Controls.Add(this.gbxObservacionesProveedor);
            this.gbxProveedor.Controls.Add(this.lblTelefono);
            this.gbxProveedor.Controls.Add(this.lblMail);
            this.gbxProveedor.Controls.Add(this.lblRazonSocial);
            this.gbxProveedor.Controls.Add(this.lblCUIT);
            this.gbxProveedor.Controls.Add(this.lblDireccion);
            this.gbxProveedor.Controls.Add(this.lblCiudad);
            this.gbxProveedor.Controls.Add(this.lblProvincia);
            this.gbxProveedor.Controls.Add(this.lblCP);
            this.gbxProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxProveedor.Location = new System.Drawing.Point(3, 170);
            this.gbxProveedor.Name = "gbxProveedor";
            this.gbxProveedor.Size = new System.Drawing.Size(996, 162);
            this.gbxProveedor.TabIndex = 1;
            this.gbxProveedor.TabStop = false;
            this.gbxProveedor.Text = "Proveedor";
            // 
            // gbxObservacionesProveedor
            // 
            this.gbxObservacionesProveedor.Controls.Add(this.rtbObservacionesProveedor);
            this.gbxObservacionesProveedor.Location = new System.Drawing.Point(636, 25);
            this.gbxObservacionesProveedor.Name = "gbxObservacionesProveedor";
            this.gbxObservacionesProveedor.Size = new System.Drawing.Size(357, 112);
            this.gbxObservacionesProveedor.TabIndex = 28;
            this.gbxObservacionesProveedor.TabStop = false;
            this.gbxObservacionesProveedor.Text = "Observaciones";
            // 
            // rtbObservacionesProveedor
            // 
            this.rtbObservacionesProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbObservacionesProveedor.Location = new System.Drawing.Point(3, 16);
            this.rtbObservacionesProveedor.Name = "rtbObservacionesProveedor";
            this.rtbObservacionesProveedor.Size = new System.Drawing.Size(351, 93);
            this.rtbObservacionesProveedor.TabIndex = 0;
            this.rtbObservacionesProveedor.Text = "";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(441, 75);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 14;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(228, 75);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(29, 13);
            this.lblMail.TabIndex = 13;
            this.lblMail.Text = "Mail:";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(8, 28);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(73, 13);
            this.lblRazonSocial.TabIndex = 12;
            this.lblRazonSocial.Text = "Razón Social:";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(351, 28);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(35, 13);
            this.lblCUIT.TabIndex = 10;
            this.lblCUIT.Text = "CUIT:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(8, 75);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(8, 121);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 8;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(228, 120);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 7;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(441, 121);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(75, 13);
            this.lblCP.TabIndex = 6;
            this.lblCP.Text = "Código Postal:";
            // 
            // frmPedidoProveedorCierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 621);
            this.Controls.Add(this.tlpCierreProveedor);
            this.Name = "frmPedidoProveedorCierre";
            this.Text = "Cierre de Pedido Proveedor (Luis De Paoli)";
            this.tlpCierreProveedor.ResumeLayout(false);
            this.pnlBotonera.ResumeLayout(false);
            this.gbxDetalleArticulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleArticulos)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gbxComprobante.ResumeLayout(false);
            this.gbxComprobante.PerformLayout();
            this.gbxObservacionesComprobante.ResumeLayout(false);
            this.gbxProveedor.ResumeLayout(false);
            this.gbxProveedor.PerformLayout();
            this.gbxObservacionesProveedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCierreProveedor;
        private System.Windows.Forms.Panel pnlBotonera;
        private System.Windows.Forms.Button btnEmitirComprobante;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox gbxDetalleArticulos;
        internal System.Windows.Forms.DataGridView dgvDetalleArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox gbxComprobante;
        private System.Windows.Forms.GroupBox gbxObservacionesComprobante;
        private System.Windows.Forms.RichTextBox rtbObservacionesComprobante;
        private System.Windows.Forms.Label lblTotalBruto;
        private System.Windows.Forms.Label lblTotalNeto;
        private System.Windows.Forms.Label lblIVANeto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblIVAPorcentual;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblDescuentoNeto;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblNumeroComprobante;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDescuentoPorcentual;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.Label lblTipoComprobante;
        private System.Windows.Forms.GroupBox gbxProveedor;
        private System.Windows.Forms.GroupBox gbxObservacionesProveedor;
        private System.Windows.Forms.RichTextBox rtbObservacionesProveedor;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblCP;
    }
}