namespace Vista
{
    partial class frmPedidoClienteNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidoClienteNuevo));
            this.grbxDetalleSelec = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tlpDetalles = new System.Windows.Forms.TableLayoutPanel();
            this.lblProvVar = new System.Windows.Forms.Label();
            this.lblObsVar = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblFechaActualizVar = new System.Windows.Forms.Label();
            this.lblCodOrigVar = new System.Windows.Forms.Label();
            this.lblExistenciaVar = new System.Windows.Forms.Label();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.lblUbicacionVar = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblPrecioVar = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescVar = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblCodProvVar = new System.Windows.Forms.Label();
            this.lblCodProv = new System.Windows.Forms.Label();
            this.lblCodOrig = new System.Windows.Forms.Label();
            this.lblFechaActualiz = new System.Windows.Forms.Label();
            this.lblProv = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lblTotalVar = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grbxDetalleAgregados = new System.Windows.Forms.GroupBox();
            this.dgvDetalleAgregados = new System.Windows.Forms.DataGridView();
            this.codOrig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbxArtAgregar = new System.Windows.Forms.GroupBox();
            this.lblCategoriaBuscar = new System.Windows.Forms.Label();
            this.dgvArtAgregar = new System.Windows.Forms.DataGridView();
            this.codOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLupa = new System.Windows.Forms.Label();
            this.txtBusqArticulo = new System.Windows.Forms.TextBox();
            this.cmbxCategoriaBuscar = new System.Windows.Forms.ComboBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnBorrarDetActual = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grbxDetalleSelec.SuspendLayout();
            this.tlpDetalles.SuspendLayout();
            this.grbxDetalleAgregados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleAgregados)).BeginInit();
            this.grbxArtAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // grbxDetalleSelec
            // 
            this.grbxDetalleSelec.Controls.Add(this.txtCantidad);
            this.grbxDetalleSelec.Controls.Add(this.lblCantidad);
            this.grbxDetalleSelec.Controls.Add(this.btnAgregar);
            this.grbxDetalleSelec.Controls.Add(this.tlpDetalles);
            this.grbxDetalleSelec.Location = new System.Drawing.Point(710, 20);
            this.grbxDetalleSelec.Name = "grbxDetalleSelec";
            this.grbxDetalleSelec.Size = new System.Drawing.Size(294, 487);
            this.grbxDetalleSelec.TabIndex = 23;
            this.grbxDetalleSelec.TabStop = false;
            this.grbxDetalleSelec.Text = "Detalle Artículo Seleccionado";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(81, 449);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(44, 20);
            this.txtCantidad.TabIndex = 10;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(23, 452);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(168, 441);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 35);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tlpDetalles
            // 
            this.tlpDetalles.ColumnCount = 2;
            this.tlpDetalles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tlpDetalles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDetalles.Controls.Add(this.lblProvVar, 1, 2);
            this.tlpDetalles.Controls.Add(this.lblObsVar, 1, 8);
            this.tlpDetalles.Controls.Add(this.lblObs, 0, 8);
            this.tlpDetalles.Controls.Add(this.lblFechaActualizVar, 1, 7);
            this.tlpDetalles.Controls.Add(this.lblCodOrigVar, 1, 0);
            this.tlpDetalles.Controls.Add(this.lblExistenciaVar, 1, 6);
            this.tlpDetalles.Controls.Add(this.lblExistencia, 0, 6);
            this.tlpDetalles.Controls.Add(this.lblUbicacionVar, 1, 5);
            this.tlpDetalles.Controls.Add(this.lblUbicacion, 0, 5);
            this.tlpDetalles.Controls.Add(this.lblPrecioVar, 1, 4);
            this.tlpDetalles.Controls.Add(this.lblPrecio, 0, 4);
            this.tlpDetalles.Controls.Add(this.lblDescVar, 1, 3);
            this.tlpDetalles.Controls.Add(this.lblDesc, 0, 3);
            this.tlpDetalles.Controls.Add(this.lblCodProvVar, 1, 1);
            this.tlpDetalles.Controls.Add(this.lblCodProv, 0, 1);
            this.tlpDetalles.Controls.Add(this.lblCodOrig, 0, 0);
            this.tlpDetalles.Controls.Add(this.lblFechaActualiz, 0, 7);
            this.tlpDetalles.Controls.Add(this.lblProv, 0, 2);
            this.tlpDetalles.Location = new System.Drawing.Point(20, 29);
            this.tlpDetalles.Name = "tlpDetalles";
            this.tlpDetalles.RowCount = 9;
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tlpDetalles.Size = new System.Drawing.Size(268, 397);
            this.tlpDetalles.TabIndex = 1;
            // 
            // lblProvVar
            // 
            this.lblProvVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProvVar.AutoSize = true;
            this.lblProvVar.Location = new System.Drawing.Point(91, 78);
            this.lblProvVar.Name = "lblProvVar";
            this.lblProvVar.Size = new System.Drawing.Size(181, 13);
            this.lblProvVar.TabIndex = 19;
            this.lblProvVar.Text = "Seleccione Artículo";
            // 
            // lblObsVar
            // 
            this.lblObsVar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblObsVar.Location = new System.Drawing.Point(91, 315);
            this.lblObsVar.Name = "lblObsVar";
            this.lblObsVar.Size = new System.Drawing.Size(181, 82);
            this.lblObsVar.TabIndex = 17;
            this.lblObsVar.Text = "Seleccione Artículo";
            this.lblObsVar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblObs
            // 
            this.lblObs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(3, 349);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(82, 13);
            this.lblObs.TabIndex = 16;
            this.lblObs.Text = "Observaciones:";
            // 
            // lblFechaActualizVar
            // 
            this.lblFechaActualizVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaActualizVar.AutoSize = true;
            this.lblFechaActualizVar.Location = new System.Drawing.Point(91, 291);
            this.lblFechaActualizVar.Name = "lblFechaActualizVar";
            this.lblFechaActualizVar.Size = new System.Drawing.Size(181, 13);
            this.lblFechaActualizVar.TabIndex = 15;
            this.lblFechaActualizVar.Text = "Seleccione Artículo";
            // 
            // lblCodOrigVar
            // 
            this.lblCodOrigVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodOrigVar.AutoSize = true;
            this.lblCodOrigVar.Location = new System.Drawing.Point(91, 10);
            this.lblCodOrigVar.Name = "lblCodOrigVar";
            this.lblCodOrigVar.Size = new System.Drawing.Size(181, 13);
            this.lblCodOrigVar.TabIndex = 13;
            this.lblCodOrigVar.Text = "Seleccione Artículo";
            // 
            // lblExistenciaVar
            // 
            this.lblExistenciaVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExistenciaVar.AutoSize = true;
            this.lblExistenciaVar.Location = new System.Drawing.Point(91, 257);
            this.lblExistenciaVar.Name = "lblExistenciaVar";
            this.lblExistenciaVar.Size = new System.Drawing.Size(181, 13);
            this.lblExistenciaVar.TabIndex = 11;
            this.lblExistenciaVar.Text = "Seleccione Artículo";
            // 
            // lblExistencia
            // 
            this.lblExistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Location = new System.Drawing.Point(3, 257);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(82, 13);
            this.lblExistencia.TabIndex = 10;
            this.lblExistencia.Text = "Existencia:";
            // 
            // lblUbicacionVar
            // 
            this.lblUbicacionVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUbicacionVar.AutoSize = true;
            this.lblUbicacionVar.Location = new System.Drawing.Point(91, 223);
            this.lblUbicacionVar.Name = "lblUbicacionVar";
            this.lblUbicacionVar.Size = new System.Drawing.Size(181, 13);
            this.lblUbicacionVar.TabIndex = 9;
            this.lblUbicacionVar.Text = "Seleccione Artículo";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(3, 223);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(82, 13);
            this.lblUbicacion.TabIndex = 8;
            this.lblUbicacion.Text = "Ubicación:";
            // 
            // lblPrecioVar
            // 
            this.lblPrecioVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioVar.AutoSize = true;
            this.lblPrecioVar.Location = new System.Drawing.Point(91, 189);
            this.lblPrecioVar.Name = "lblPrecioVar";
            this.lblPrecioVar.Size = new System.Drawing.Size(181, 13);
            this.lblPrecioVar.TabIndex = 5;
            this.lblPrecioVar.Text = "Seleccione Artículo";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(3, 189);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(82, 13);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDescVar
            // 
            this.lblDescVar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescVar.Location = new System.Drawing.Point(91, 102);
            this.lblDescVar.Name = "lblDescVar";
            this.lblDescVar.Size = new System.Drawing.Size(181, 77);
            this.lblDescVar.TabIndex = 3;
            this.lblDescVar.Text = "Seleccione Artículo";
            this.lblDescVar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(3, 134);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(82, 13);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Descripción:";
            // 
            // lblCodProvVar
            // 
            this.lblCodProvVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodProvVar.AutoSize = true;
            this.lblCodProvVar.Location = new System.Drawing.Point(91, 44);
            this.lblCodProvVar.Name = "lblCodProvVar";
            this.lblCodProvVar.Size = new System.Drawing.Size(181, 13);
            this.lblCodProvVar.TabIndex = 0;
            this.lblCodProvVar.Text = "Seleccione Artículo";
            // 
            // lblCodProv
            // 
            this.lblCodProv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodProv.AutoSize = true;
            this.lblCodProv.Location = new System.Drawing.Point(3, 38);
            this.lblCodProv.Name = "lblCodProv";
            this.lblCodProv.Size = new System.Drawing.Size(82, 26);
            this.lblCodProv.TabIndex = 1;
            this.lblCodProv.Text = "Código Proveedor:";
            // 
            // lblCodOrig
            // 
            this.lblCodOrig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodOrig.AutoSize = true;
            this.lblCodOrig.Location = new System.Drawing.Point(3, 10);
            this.lblCodOrig.Name = "lblCodOrig";
            this.lblCodOrig.Size = new System.Drawing.Size(82, 13);
            this.lblCodOrig.TabIndex = 12;
            this.lblCodOrig.Text = "Código Original:";
            // 
            // lblFechaActualiz
            // 
            this.lblFechaActualiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaActualiz.AutoSize = true;
            this.lblFechaActualiz.Location = new System.Drawing.Point(3, 285);
            this.lblFechaActualiz.Name = "lblFechaActualiz";
            this.lblFechaActualiz.Size = new System.Drawing.Size(82, 26);
            this.lblFechaActualiz.TabIndex = 14;
            this.lblFechaActualiz.Text = "Fecha última actualización:";
            // 
            // lblProv
            // 
            this.lblProv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProv.AutoSize = true;
            this.lblProv.Location = new System.Drawing.Point(3, 78);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(82, 13);
            this.lblProv.TabIndex = 18;
            this.lblProv.Text = "Proveedor:";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(491, 569);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(80, 40);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lblTotalVar
            // 
            this.lblTotalVar.AutoSize = true;
            this.lblTotalVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTotalVar.Location = new System.Drawing.Point(421, 581);
            this.lblTotalVar.Name = "lblTotalVar";
            this.lblTotalVar.Size = new System.Drawing.Size(16, 16);
            this.lblTotalVar.TabIndex = 8;
            this.lblTotalVar.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(336, 579);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 18);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total:";
            // 
            // grbxDetalleAgregados
            // 
            this.grbxDetalleAgregados.Controls.Add(this.dgvDetalleAgregados);
            this.grbxDetalleAgregados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbxDetalleAgregados.Location = new System.Drawing.Point(5, 354);
            this.grbxDetalleAgregados.Name = "grbxDetalleAgregados";
            this.grbxDetalleAgregados.Size = new System.Drawing.Size(692, 203);
            this.grbxDetalleAgregados.TabIndex = 21;
            this.grbxDetalleAgregados.TabStop = false;
            this.grbxDetalleAgregados.Text = "Detalle Artículos Agregados";
            // 
            // dgvDetalleAgregados
            // 
            this.dgvDetalleAgregados.AllowUserToAddRows = false;
            this.dgvDetalleAgregados.AllowUserToDeleteRows = false;
            this.dgvDetalleAgregados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleAgregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleAgregados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codOrig,
            this.codProv,
            this.daaDescripcion,
            this.vUnitario,
            this.cantidad,
            this.vParcial});
            this.dgvDetalleAgregados.Location = new System.Drawing.Point(11, 23);
            this.dgvDetalleAgregados.Name = "dgvDetalleAgregados";
            this.dgvDetalleAgregados.ReadOnly = true;
            this.dgvDetalleAgregados.RowHeadersVisible = false;
            this.dgvDetalleAgregados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleAgregados.Size = new System.Drawing.Size(675, 174);
            this.dgvDetalleAgregados.TabIndex = 5;
            this.dgvDetalleAgregados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleAgregados_CellClick);
            this.dgvDetalleAgregados.Enter += new System.EventHandler(this.dgvDetalleAgregados_Enter);
            // 
            // codOrig
            // 
            this.codOrig.DataPropertyName = "codigoOriginalArt";
            this.codOrig.HeaderText = "Código Original";
            this.codOrig.Name = "codOrig";
            this.codOrig.ReadOnly = true;
            // 
            // codProv
            // 
            this.codProv.DataPropertyName = "codigoArtProveedor";
            this.codProv.HeaderText = "Código Proveedor";
            this.codProv.Name = "codProv";
            this.codProv.ReadOnly = true;
            // 
            // daaDescripcion
            // 
            this.daaDescripcion.DataPropertyName = "descripcion";
            this.daaDescripcion.HeaderText = "Descripción";
            this.daaDescripcion.Name = "daaDescripcion";
            this.daaDescripcion.ReadOnly = true;
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
            // grbxArtAgregar
            // 
            this.grbxArtAgregar.Controls.Add(this.lblCategoriaBuscar);
            this.grbxArtAgregar.Controls.Add(this.dgvArtAgregar);
            this.grbxArtAgregar.Controls.Add(this.lblLupa);
            this.grbxArtAgregar.Controls.Add(this.txtBusqArticulo);
            this.grbxArtAgregar.Controls.Add(this.cmbxCategoriaBuscar);
            this.grbxArtAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbxArtAgregar.Location = new System.Drawing.Point(5, 16);
            this.grbxArtAgregar.Name = "grbxArtAgregar";
            this.grbxArtAgregar.Size = new System.Drawing.Size(692, 332);
            this.grbxArtAgregar.TabIndex = 19;
            this.grbxArtAgregar.TabStop = false;
            this.grbxArtAgregar.Text = "Artículos a Agregar";
            // 
            // lblCategoriaBuscar
            // 
            this.lblCategoriaBuscar.AutoSize = true;
            this.lblCategoriaBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaBuscar.Location = new System.Drawing.Point(8, 31);
            this.lblCategoriaBuscar.Name = "lblCategoriaBuscar";
            this.lblCategoriaBuscar.Size = new System.Drawing.Size(76, 16);
            this.lblCategoriaBuscar.TabIndex = 4;
            this.lblCategoriaBuscar.Text = "Buscar por:";
            // 
            // dgvArtAgregar
            // 
            this.dgvArtAgregar.AllowUserToAddRows = false;
            this.dgvArtAgregar.AllowUserToDeleteRows = false;
            this.dgvArtAgregar.AllowUserToOrderColumns = true;
            this.dgvArtAgregar.AllowUserToResizeRows = false;
            this.dgvArtAgregar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArtAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtAgregar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codOriginal,
            this.codProveedor,
            this.proveedor,
            this.descripcion});
            this.dgvArtAgregar.Location = new System.Drawing.Point(11, 68);
            this.dgvArtAgregar.Name = "dgvArtAgregar";
            this.dgvArtAgregar.ReadOnly = true;
            this.dgvArtAgregar.RowHeadersVisible = false;
            this.dgvArtAgregar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtAgregar.Size = new System.Drawing.Size(675, 258);
            this.dgvArtAgregar.TabIndex = 3;
            this.dgvArtAgregar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtAgregar_CellClick);
            this.dgvArtAgregar.Enter += new System.EventHandler(this.dgvArtAgregar_Enter);
            // 
            // codOriginal
            // 
            this.codOriginal.DataPropertyName = "codigoOriginal";
            this.codOriginal.HeaderText = "Código Original";
            this.codOriginal.Name = "codOriginal";
            this.codOriginal.ReadOnly = true;
            // 
            // codProveedor
            // 
            this.codProveedor.DataPropertyName = "codigoArticuloProveedor";
            this.codProveedor.HeaderText = "Código Proveedor";
            this.codProveedor.Name = "codProveedor";
            this.codProveedor.ReadOnly = true;
            // 
            // proveedor
            // 
            this.proveedor.DataPropertyName = "razonSocialProveedor";
            this.proveedor.HeaderText = "Proveedor";
            this.proveedor.Name = "proveedor";
            this.proveedor.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // lblLupa
            // 
            this.lblLupa.Image = ((System.Drawing.Image)(resources.GetObject("lblLupa.Image")));
            this.lblLupa.Location = new System.Drawing.Point(614, 23);
            this.lblLupa.Name = "lblLupa";
            this.lblLupa.Size = new System.Drawing.Size(32, 32);
            this.lblLupa.TabIndex = 2;
            this.lblLupa.Click += new System.EventHandler(this.lblLupa_Click);
            // 
            // txtBusqArticulo
            // 
            this.txtBusqArticulo.Location = new System.Drawing.Point(234, 29);
            this.txtBusqArticulo.Name = "txtBusqArticulo";
            this.txtBusqArticulo.Size = new System.Drawing.Size(374, 23);
            this.txtBusqArticulo.TabIndex = 1;
            this.txtBusqArticulo.Enter += new System.EventHandler(this.txtBusqArticulo_Enter);
            this.txtBusqArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqArticulo_KeyPress);
            // 
            // cmbxCategoriaBuscar
            // 
            this.cmbxCategoriaBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbxCategoriaBuscar.FormattingEnabled = true;
            this.cmbxCategoriaBuscar.Items.AddRange(new object[] {
            "Código Original",
            "Código Proveedor",
            "Descripción"});
            this.cmbxCategoriaBuscar.Location = new System.Drawing.Point(90, 28);
            this.cmbxCategoriaBuscar.Name = "cmbxCategoriaBuscar";
            this.cmbxCategoriaBuscar.Size = new System.Drawing.Size(138, 24);
            this.cmbxCategoriaBuscar.TabIndex = 0;
            this.cmbxCategoriaBuscar.Text = "[Seleccionar...]";
            this.cmbxCategoriaBuscar.SelectionChangeCommitted += new System.EventHandler(this.cmbxCategoriaBuscar_SelectionChangeCommitted);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.AutoSize = true;
            this.btnSiguiente.Location = new System.Drawing.Point(876, 569);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(120, 40);
            this.btnSiguiente.TabIndex = 22;
            this.btnSiguiente.Text = "Siguiente >";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnBorrarDetActual
            // 
            this.btnBorrarDetActual.AutoSize = true;
            this.btnBorrarDetActual.Location = new System.Drawing.Point(577, 569);
            this.btnBorrarDetActual.Name = "btnBorrarDetActual";
            this.btnBorrarDetActual.Size = new System.Drawing.Size(120, 40);
            this.btnBorrarDetActual.TabIndex = 20;
            this.btnBorrarDetActual.Text = "Borrar Detalle Actual";
            this.btnBorrarDetActual.UseVisualStyleBackColor = true;
            this.btnBorrarDetActual.Click += new System.EventHandler(this.btnBorrarDetActual_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(5, 569);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmPedidoClienteNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 621);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbxDetalleSelec);
            this.Controls.Add(this.grbxDetalleAgregados);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.grbxArtAgregar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnBorrarDetActual);
            this.Controls.Add(this.lblTotalVar);
            this.Controls.Add(this.lblTotal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPedidoClienteNuevo";
            this.Text = "Nuevo Pedido Cliente (Leandro Jorge)";
            this.grbxDetalleSelec.ResumeLayout(false);
            this.grbxDetalleSelec.PerformLayout();
            this.tlpDetalles.ResumeLayout(false);
            this.tlpDetalles.PerformLayout();
            this.grbxDetalleAgregados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleAgregados)).EndInit();
            this.grbxArtAgregar.ResumeLayout(false);
            this.grbxArtAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbxDetalleSelec;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TableLayoutPanel tlpDetalles;
        private System.Windows.Forms.Label lblProvVar;
        private System.Windows.Forms.Label lblObsVar;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblFechaActualizVar;
        private System.Windows.Forms.Label lblCodOrigVar;
        private System.Windows.Forms.Label lblExistenciaVar;
        private System.Windows.Forms.Label lblExistencia;
        private System.Windows.Forms.Label lblUbicacionVar;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblPrecioVar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescVar;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblCodProvVar;
        private System.Windows.Forms.Label lblCodProv;
        private System.Windows.Forms.Label lblCodOrig;
        private System.Windows.Forms.Label lblFechaActualiz;
        private System.Windows.Forms.Label lblProv;
        internal System.Windows.Forms.Label lblTotalVar;
        internal System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox grbxDetalleAgregados;
        internal System.Windows.Forms.DataGridView dgvDetalleAgregados;
        private System.Windows.Forms.GroupBox grbxArtAgregar;
        private System.Windows.Forms.Label lblCategoriaBuscar;
        internal System.Windows.Forms.DataGridView dgvArtAgregar;
        internal System.Windows.Forms.Label lblLupa;
        internal System.Windows.Forms.TextBox txtBusqArticulo;
        internal System.Windows.Forms.ComboBox cmbxCategoriaBuscar;
        internal System.Windows.Forms.Button btnSiguiente;
        internal System.Windows.Forms.Button btnBorrarDetActual;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn codOrig;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn daaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn vUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn vParcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn codOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.Button btnCancelar;

    }
}