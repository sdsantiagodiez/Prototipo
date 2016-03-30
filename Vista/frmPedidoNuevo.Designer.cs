namespace Vista
{
    partial class frmPedidoNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidoNuevo));
            this.gbxDetalleArticuloSeleccionado = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tlpDetalles = new System.Windows.Forms.TableLayoutPanel();
            this.lblProveedorVar = new System.Windows.Forms.Label();
            this.lblObservacionesVar = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblFechaActualizacionVar = new System.Windows.Forms.Label();
            this.lblCodigoOriginalVar = new System.Windows.Forms.Label();
            this.lblExistenciaVar = new System.Windows.Forms.Label();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.lblUbicacionVar = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblPrecioVar = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcionVar = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigoProveedorVar = new System.Windows.Forms.Label();
            this.lblCodigoProveedor = new System.Windows.Forms.Label();
            this.lblCodigoOriginal = new System.Windows.Forms.Label();
            this.lblFechaActualizacion = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lblTotalVar = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gbxDetalleAgregados = new System.Windows.Forms.GroupBox();
            this.dgvDetalleAgregados = new System.Windows.Forms.DataGridView();
            this.codOrig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxArticulosAgregar = new System.Windows.Forms.GroupBox();
            this.lblCategoriaBuscar = new System.Windows.Forms.Label();
            this.dgvArtAgregar = new System.Windows.Forms.DataGridView();
            this.codOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLupa = new System.Windows.Forms.Label();
            this.txtDescripcionParcial = new System.Windows.Forms.TextBox();
            this.cbxCategoriaBusqueda = new System.Windows.Forms.ComboBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnBorrarDetalleActual = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxDetalleArticuloSeleccionado.SuspendLayout();
            this.tlpDetalles.SuspendLayout();
            this.gbxDetalleAgregados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleAgregados)).BeginInit();
            this.gbxArticulosAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDetalleArticuloSeleccionado
            // 
            this.gbxDetalleArticuloSeleccionado.Controls.Add(this.txtCantidad);
            this.gbxDetalleArticuloSeleccionado.Controls.Add(this.lblCantidad);
            this.gbxDetalleArticuloSeleccionado.Controls.Add(this.btnAgregar);
            this.gbxDetalleArticuloSeleccionado.Controls.Add(this.tlpDetalles);
            this.gbxDetalleArticuloSeleccionado.Location = new System.Drawing.Point(710, 20);
            this.gbxDetalleArticuloSeleccionado.Name = "gbxDetalleArticuloSeleccionado";
            this.gbxDetalleArticuloSeleccionado.Size = new System.Drawing.Size(294, 487);
            this.gbxDetalleArticuloSeleccionado.TabIndex = 23;
            this.gbxDetalleArticuloSeleccionado.TabStop = false;
            this.gbxDetalleArticuloSeleccionado.Text = "Detalle Artículo Seleccionado";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(81, 449);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(44, 20);
            this.txtCantidad.TabIndex = 10;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
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
            this.tlpDetalles.Controls.Add(this.lblProveedorVar, 1, 2);
            this.tlpDetalles.Controls.Add(this.lblObservacionesVar, 1, 8);
            this.tlpDetalles.Controls.Add(this.lblObservaciones, 0, 8);
            this.tlpDetalles.Controls.Add(this.lblFechaActualizacionVar, 1, 7);
            this.tlpDetalles.Controls.Add(this.lblCodigoOriginalVar, 1, 0);
            this.tlpDetalles.Controls.Add(this.lblExistenciaVar, 1, 6);
            this.tlpDetalles.Controls.Add(this.lblExistencia, 0, 6);
            this.tlpDetalles.Controls.Add(this.lblUbicacionVar, 1, 5);
            this.tlpDetalles.Controls.Add(this.lblUbicacion, 0, 5);
            this.tlpDetalles.Controls.Add(this.lblPrecioVar, 1, 4);
            this.tlpDetalles.Controls.Add(this.lblPrecio, 0, 4);
            this.tlpDetalles.Controls.Add(this.lblDescripcionVar, 1, 3);
            this.tlpDetalles.Controls.Add(this.lblDescripcion, 0, 3);
            this.tlpDetalles.Controls.Add(this.lblCodigoProveedorVar, 1, 1);
            this.tlpDetalles.Controls.Add(this.lblCodigoProveedor, 0, 1);
            this.tlpDetalles.Controls.Add(this.lblCodigoOriginal, 0, 0);
            this.tlpDetalles.Controls.Add(this.lblFechaActualizacion, 0, 7);
            this.tlpDetalles.Controls.Add(this.lblProveedor, 0, 2);
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
            // lblProveedorVar
            // 
            this.lblProveedorVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProveedorVar.AutoSize = true;
            this.lblProveedorVar.Location = new System.Drawing.Point(91, 78);
            this.lblProveedorVar.Name = "lblProveedorVar";
            this.lblProveedorVar.Size = new System.Drawing.Size(181, 13);
            this.lblProveedorVar.TabIndex = 19;
            this.lblProveedorVar.Text = "Seleccione Artículo";
            // 
            // lblObservacionesVar
            // 
            this.lblObservacionesVar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblObservacionesVar.Location = new System.Drawing.Point(91, 315);
            this.lblObservacionesVar.Name = "lblObservacionesVar";
            this.lblObservacionesVar.Size = new System.Drawing.Size(181, 82);
            this.lblObservacionesVar.TabIndex = 17;
            this.lblObservacionesVar.Text = "Seleccione Artículo";
            this.lblObservacionesVar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(3, 349);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(82, 13);
            this.lblObservaciones.TabIndex = 16;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblFechaActualizacionVar
            // 
            this.lblFechaActualizacionVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaActualizacionVar.AutoSize = true;
            this.lblFechaActualizacionVar.Location = new System.Drawing.Point(91, 291);
            this.lblFechaActualizacionVar.Name = "lblFechaActualizacionVar";
            this.lblFechaActualizacionVar.Size = new System.Drawing.Size(181, 13);
            this.lblFechaActualizacionVar.TabIndex = 15;
            this.lblFechaActualizacionVar.Text = "Seleccione Artículo";
            // 
            // lblCodigoOriginalVar
            // 
            this.lblCodigoOriginalVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigoOriginalVar.AutoSize = true;
            this.lblCodigoOriginalVar.Location = new System.Drawing.Point(91, 10);
            this.lblCodigoOriginalVar.Name = "lblCodigoOriginalVar";
            this.lblCodigoOriginalVar.Size = new System.Drawing.Size(181, 13);
            this.lblCodigoOriginalVar.TabIndex = 13;
            this.lblCodigoOriginalVar.Text = "Seleccione Artículo";
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
            // lblDescripcionVar
            // 
            this.lblDescripcionVar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescripcionVar.Location = new System.Drawing.Point(91, 102);
            this.lblDescripcionVar.Name = "lblDescripcionVar";
            this.lblDescripcionVar.Size = new System.Drawing.Size(181, 77);
            this.lblDescripcionVar.TabIndex = 3;
            this.lblDescripcionVar.Text = "Seleccione Artículo";
            this.lblDescripcionVar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 134);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblCodigoProveedorVar
            // 
            this.lblCodigoProveedorVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigoProveedorVar.AutoSize = true;
            this.lblCodigoProveedorVar.Location = new System.Drawing.Point(91, 44);
            this.lblCodigoProveedorVar.Name = "lblCodigoProveedorVar";
            this.lblCodigoProveedorVar.Size = new System.Drawing.Size(181, 13);
            this.lblCodigoProveedorVar.TabIndex = 0;
            this.lblCodigoProveedorVar.Text = "Seleccione Artículo";
            // 
            // lblCodigoProveedor
            // 
            this.lblCodigoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigoProveedor.AutoSize = true;
            this.lblCodigoProveedor.Location = new System.Drawing.Point(3, 38);
            this.lblCodigoProveedor.Name = "lblCodigoProveedor";
            this.lblCodigoProveedor.Size = new System.Drawing.Size(82, 26);
            this.lblCodigoProveedor.TabIndex = 1;
            this.lblCodigoProveedor.Text = "Código Proveedor:";
            // 
            // lblCodigoOriginal
            // 
            this.lblCodigoOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigoOriginal.AutoSize = true;
            this.lblCodigoOriginal.Location = new System.Drawing.Point(3, 10);
            this.lblCodigoOriginal.Name = "lblCodigoOriginal";
            this.lblCodigoOriginal.Size = new System.Drawing.Size(82, 13);
            this.lblCodigoOriginal.TabIndex = 12;
            this.lblCodigoOriginal.Text = "Código Original:";
            // 
            // lblFechaActualizacion
            // 
            this.lblFechaActualizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaActualizacion.AutoSize = true;
            this.lblFechaActualizacion.Location = new System.Drawing.Point(3, 285);
            this.lblFechaActualizacion.Name = "lblFechaActualizacion";
            this.lblFechaActualizacion.Size = new System.Drawing.Size(82, 26);
            this.lblFechaActualizacion.TabIndex = 14;
            this.lblFechaActualizacion.Text = "Fecha última actualización:";
            // 
            // lblProveedor
            // 
            this.lblProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(3, 78);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(82, 13);
            this.lblProveedor.TabIndex = 18;
            this.lblProveedor.Text = "Proveedor:";
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
            // gbxDetalleAgregados
            // 
            this.gbxDetalleAgregados.Controls.Add(this.dgvDetalleAgregados);
            this.gbxDetalleAgregados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetalleAgregados.Location = new System.Drawing.Point(5, 354);
            this.gbxDetalleAgregados.Name = "gbxDetalleAgregados";
            this.gbxDetalleAgregados.Size = new System.Drawing.Size(692, 203);
            this.gbxDetalleAgregados.TabIndex = 21;
            this.gbxDetalleAgregados.TabStop = false;
            this.gbxDetalleAgregados.Text = "Detalle Artículos Agregados";
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
            // gbxArticulosAgregar
            // 
            this.gbxArticulosAgregar.Controls.Add(this.lblCategoriaBuscar);
            this.gbxArticulosAgregar.Controls.Add(this.dgvArtAgregar);
            this.gbxArticulosAgregar.Controls.Add(this.lblLupa);
            this.gbxArticulosAgregar.Controls.Add(this.txtDescripcionParcial);
            this.gbxArticulosAgregar.Controls.Add(this.cbxCategoriaBusqueda);
            this.gbxArticulosAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxArticulosAgregar.Location = new System.Drawing.Point(5, 16);
            this.gbxArticulosAgregar.Name = "gbxArticulosAgregar";
            this.gbxArticulosAgregar.Size = new System.Drawing.Size(692, 332);
            this.gbxArticulosAgregar.TabIndex = 19;
            this.gbxArticulosAgregar.TabStop = false;
            this.gbxArticulosAgregar.Text = "Artículos a Agregar";
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
            // txtDescripcionParcial
            // 
            this.txtDescripcionParcial.Location = new System.Drawing.Point(234, 29);
            this.txtDescripcionParcial.Name = "txtDescripcionParcial";
            this.txtDescripcionParcial.Size = new System.Drawing.Size(374, 23);
            this.txtDescripcionParcial.TabIndex = 1;
            this.txtDescripcionParcial.Enter += new System.EventHandler(this.txtBusqArticulo_Enter);
            this.txtDescripcionParcial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqArticulo_KeyPress);
            // 
            // cbxCategoriaBusqueda
            // 
            this.cbxCategoriaBusqueda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxCategoriaBusqueda.FormattingEnabled = true;
            this.cbxCategoriaBusqueda.Items.AddRange(new object[] {
            "Código Original",
            "Código Proveedor",
            "Descripción"});
            this.cbxCategoriaBusqueda.Location = new System.Drawing.Point(90, 28);
            this.cbxCategoriaBusqueda.Name = "cbxCategoriaBusqueda";
            this.cbxCategoriaBusqueda.Size = new System.Drawing.Size(138, 24);
            this.cbxCategoriaBusqueda.TabIndex = 0;
            this.cbxCategoriaBusqueda.Text = "[Seleccionar...]";
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
            // btnBorrarDetalleActual
            // 
            this.btnBorrarDetalleActual.AutoSize = true;
            this.btnBorrarDetalleActual.Location = new System.Drawing.Point(577, 569);
            this.btnBorrarDetalleActual.Name = "btnBorrarDetalleActual";
            this.btnBorrarDetalleActual.Size = new System.Drawing.Size(120, 40);
            this.btnBorrarDetalleActual.TabIndex = 20;
            this.btnBorrarDetalleActual.Text = "Borrar Detalle Actual";
            this.btnBorrarDetalleActual.UseVisualStyleBackColor = true;
            this.btnBorrarDetalleActual.Click += new System.EventHandler(this.btnBorrarDetActual_Click);
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
            // frmPedidoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 621);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbxDetalleArticuloSeleccionado);
            this.Controls.Add(this.gbxDetalleAgregados);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.gbxArticulosAgregar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnBorrarDetalleActual);
            this.Controls.Add(this.lblTotalVar);
            this.Controls.Add(this.lblTotal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPedidoNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Pedido Cliente (Leandro Jorge)";
            this.gbxDetalleArticuloSeleccionado.ResumeLayout(false);
            this.gbxDetalleArticuloSeleccionado.PerformLayout();
            this.tlpDetalles.ResumeLayout(false);
            this.tlpDetalles.PerformLayout();
            this.gbxDetalleAgregados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleAgregados)).EndInit();
            this.gbxArticulosAgregar.ResumeLayout(false);
            this.gbxArticulosAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDetalleArticuloSeleccionado;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TableLayoutPanel tlpDetalles;
        private System.Windows.Forms.Label lblProveedorVar;
        private System.Windows.Forms.Label lblObservacionesVar;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblFechaActualizacionVar;
        private System.Windows.Forms.Label lblCodigoOriginalVar;
        private System.Windows.Forms.Label lblExistenciaVar;
        private System.Windows.Forms.Label lblExistencia;
        private System.Windows.Forms.Label lblUbicacionVar;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblPrecioVar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcionVar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCodigoProveedorVar;
        private System.Windows.Forms.Label lblCodigoProveedor;
        private System.Windows.Forms.Label lblCodigoOriginal;
        private System.Windows.Forms.Label lblFechaActualizacion;
        private System.Windows.Forms.Label lblProveedor;
        internal System.Windows.Forms.Label lblTotalVar;
        internal System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox gbxDetalleAgregados;
        internal System.Windows.Forms.DataGridView dgvDetalleAgregados;
        private System.Windows.Forms.GroupBox gbxArticulosAgregar;
        private System.Windows.Forms.Label lblCategoriaBuscar;
        internal System.Windows.Forms.DataGridView dgvArtAgregar;
        internal System.Windows.Forms.Label lblLupa;
        internal System.Windows.Forms.TextBox txtDescripcionParcial;
        internal System.Windows.Forms.ComboBox cbxCategoriaBusqueda;
        internal System.Windows.Forms.Button btnSiguiente;
        internal System.Windows.Forms.Button btnBorrarDetalleActual;
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