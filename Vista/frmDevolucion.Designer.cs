namespace Vista
{
    partial class frmDevolucion
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
            this.lblNumeroPedido = new System.Windows.Forms.Label();
            this.txtNumeroPedido = new System.Windows.Forms.TextBox();
            this.txtCodigoArticuloProveedor = new System.Windows.Forms.TextBox();
            this.rtbObservacionesDevolucion = new System.Windows.Forms.RichTextBox();
            this.lblCodigoArticuloProveedor = new System.Windows.Forms.Label();
            this.lblMotivoDevolucion = new System.Windows.Forms.Label();
            this.gbxDetalleArticuloSeleccionado = new System.Windows.Forms.GroupBox();
            this.tlpDetalles = new System.Windows.Forms.TableLayoutPanel();
            this.lblProveedorVar = new System.Windows.Forms.Label();
            this.lblObservacionesVar = new System.Windows.Forms.Label();
            this.lblObservacionesArticulo = new System.Windows.Forms.Label();
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
            this.txtCantidadDevuelta = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblCantidadDevuelta = new System.Windows.Forms.Label();
            this.gbxDatosDevolucion = new System.Windows.Forms.GroupBox();
            this.txtMontoNotaCredito = new System.Windows.Forms.TextBox();
            this.lblMontoNotaCredito = new System.Windows.Forms.Label();
            this.lblObservacionesDevolucion = new System.Windows.Forms.Label();
            this.rbtDefectuoso = new System.Windows.Forms.RadioButton();
            this.rbtError = new System.Windows.Forms.RadioButton();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCodigoOriginal = new System.Windows.Forms.TextBox();
            this.lblCodigoOriginalValidacion = new System.Windows.Forms.Label();
            this.gbxDetalleArticuloSeleccionado.SuspendLayout();
            this.tlpDetalles.SuspendLayout();
            this.gbxDatosDevolucion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumeroPedido
            // 
            this.lblNumeroPedido.AutoSize = true;
            this.lblNumeroPedido.Location = new System.Drawing.Point(64, 12);
            this.lblNumeroPedido.Name = "lblNumeroPedido";
            this.lblNumeroPedido.Size = new System.Drawing.Size(81, 13);
            this.lblNumeroPedido.TabIndex = 0;
            this.lblNumeroPedido.Text = "Nro. de Pedido:";
            // 
            // txtNumeroPedido
            // 
            this.txtNumeroPedido.Location = new System.Drawing.Point(151, 9);
            this.txtNumeroPedido.Name = "txtNumeroPedido";
            this.txtNumeroPedido.Size = new System.Drawing.Size(162, 20);
            this.txtNumeroPedido.TabIndex = 1;
            // 
            // txtCodigoArticuloProveedor
            // 
            this.txtCodigoArticuloProveedor.Location = new System.Drawing.Point(151, 64);
            this.txtCodigoArticuloProveedor.Name = "txtCodigoArticuloProveedor";
            this.txtCodigoArticuloProveedor.Size = new System.Drawing.Size(162, 20);
            this.txtCodigoArticuloProveedor.TabIndex = 2;
            // 
            // rtbObservacionesDevolucion
            // 
            this.rtbObservacionesDevolucion.Location = new System.Drawing.Point(6, 69);
            this.rtbObservacionesDevolucion.Name = "rtbObservacionesDevolucion";
            this.rtbObservacionesDevolucion.Size = new System.Drawing.Size(370, 96);
            this.rtbObservacionesDevolucion.TabIndex = 3;
            this.rtbObservacionesDevolucion.Text = "";
            // 
            // lblCodigoArticuloProveedor
            // 
            this.lblCodigoArticuloProveedor.AutoSize = true;
            this.lblCodigoArticuloProveedor.Location = new System.Drawing.Point(12, 67);
            this.lblCodigoArticuloProveedor.Name = "lblCodigoArticuloProveedor";
            this.lblCodigoArticuloProveedor.Size = new System.Drawing.Size(133, 13);
            this.lblCodigoArticuloProveedor.TabIndex = 4;
            this.lblCodigoArticuloProveedor.Text = "Codigo Articulo Proveedor:";
            // 
            // lblMotivoDevolucion
            // 
            this.lblMotivoDevolucion.AutoSize = true;
            this.lblMotivoDevolucion.Location = new System.Drawing.Point(6, 21);
            this.lblMotivoDevolucion.Name = "lblMotivoDevolucion";
            this.lblMotivoDevolucion.Size = new System.Drawing.Size(114, 13);
            this.lblMotivoDevolucion.TabIndex = 5;
            this.lblMotivoDevolucion.Text = "Motivo de Devolución:";
            // 
            // gbxDetalleArticuloSeleccionado
            // 
            this.gbxDetalleArticuloSeleccionado.Controls.Add(this.tlpDetalles);
            this.gbxDetalleArticuloSeleccionado.Location = new System.Drawing.Point(400, 12);
            this.gbxDetalleArticuloSeleccionado.Name = "gbxDetalleArticuloSeleccionado";
            this.gbxDetalleArticuloSeleccionado.Size = new System.Drawing.Size(284, 426);
            this.gbxDetalleArticuloSeleccionado.TabIndex = 24;
            this.gbxDetalleArticuloSeleccionado.TabStop = false;
            this.gbxDetalleArticuloSeleccionado.Text = "Detalle Artículo Seleccionado";
            this.gbxDetalleArticuloSeleccionado.Visible = false;
            // 
            // tlpDetalles
            // 
            this.tlpDetalles.ColumnCount = 2;
            this.tlpDetalles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tlpDetalles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDetalles.Controls.Add(this.lblProveedorVar, 1, 2);
            this.tlpDetalles.Controls.Add(this.lblObservacionesVar, 1, 8);
            this.tlpDetalles.Controls.Add(this.lblObservacionesArticulo, 0, 8);
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
            this.tlpDetalles.Location = new System.Drawing.Point(6, 18);
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
            // lblObservacionesArticulo
            // 
            this.lblObservacionesArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObservacionesArticulo.AutoSize = true;
            this.lblObservacionesArticulo.Location = new System.Drawing.Point(3, 349);
            this.lblObservacionesArticulo.Name = "lblObservacionesArticulo";
            this.lblObservacionesArticulo.Size = new System.Drawing.Size(82, 13);
            this.lblObservacionesArticulo.TabIndex = 16;
            this.lblObservacionesArticulo.Text = "Observaciones:";
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
            // txtCantidadDevuelta
            // 
            this.txtCantidadDevuelta.Location = new System.Drawing.Point(139, 175);
            this.txtCantidadDevuelta.Name = "txtCantidadDevuelta";
            this.txtCantidadDevuelta.Size = new System.Drawing.Size(73, 20);
            this.txtCantidadDevuelta.TabIndex = 10;
            this.txtCantidadDevuelta.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(604, 444);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 35);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblCantidadDevuelta
            // 
            this.lblCantidadDevuelta.AutoSize = true;
            this.lblCantidadDevuelta.Location = new System.Drawing.Point(43, 178);
            this.lblCantidadDevuelta.Name = "lblCantidadDevuelta";
            this.lblCantidadDevuelta.Size = new System.Drawing.Size(90, 13);
            this.lblCantidadDevuelta.TabIndex = 9;
            this.lblCantidadDevuelta.Text = "Catidad devuelta:";
            this.lblCantidadDevuelta.Visible = false;
            // 
            // gbxDatosDevolucion
            // 
            this.gbxDatosDevolucion.Controls.Add(this.txtMontoNotaCredito);
            this.gbxDatosDevolucion.Controls.Add(this.lblMontoNotaCredito);
            this.gbxDatosDevolucion.Controls.Add(this.lblObservacionesDevolucion);
            this.gbxDatosDevolucion.Controls.Add(this.rbtDefectuoso);
            this.gbxDatosDevolucion.Controls.Add(this.rbtError);
            this.gbxDatosDevolucion.Controls.Add(this.txtCantidadDevuelta);
            this.gbxDatosDevolucion.Controls.Add(this.rtbObservacionesDevolucion);
            this.gbxDatosDevolucion.Controls.Add(this.lblCantidadDevuelta);
            this.gbxDatosDevolucion.Controls.Add(this.lblMotivoDevolucion);
            this.gbxDatosDevolucion.Location = new System.Drawing.Point(12, 91);
            this.gbxDatosDevolucion.Name = "gbxDatosDevolucion";
            this.gbxDatosDevolucion.Size = new System.Drawing.Size(382, 347);
            this.gbxDatosDevolucion.TabIndex = 25;
            this.gbxDatosDevolucion.TabStop = false;
            this.gbxDatosDevolucion.Text = "Datos Devolución";
            this.gbxDatosDevolucion.Visible = false;
            // 
            // txtMontoNotaCredito
            // 
            this.txtMontoNotaCredito.Location = new System.Drawing.Point(139, 204);
            this.txtMontoNotaCredito.Name = "txtMontoNotaCredito";
            this.txtMontoNotaCredito.Size = new System.Drawing.Size(73, 20);
            this.txtMontoNotaCredito.TabIndex = 15;
            // 
            // lblMontoNotaCredito
            // 
            this.lblMontoNotaCredito.AutoSize = true;
            this.lblMontoNotaCredito.Location = new System.Drawing.Point(19, 207);
            this.lblMontoNotaCredito.Name = "lblMontoNotaCredito";
            this.lblMontoNotaCredito.Size = new System.Drawing.Size(114, 13);
            this.lblMontoNotaCredito.TabIndex = 14;
            this.lblMontoNotaCredito.Text = "Monto nota de crédito:";
            // 
            // lblObservacionesDevolucion
            // 
            this.lblObservacionesDevolucion.AutoSize = true;
            this.lblObservacionesDevolucion.Location = new System.Drawing.Point(6, 53);
            this.lblObservacionesDevolucion.Name = "lblObservacionesDevolucion";
            this.lblObservacionesDevolucion.Size = new System.Drawing.Size(81, 13);
            this.lblObservacionesDevolucion.TabIndex = 13;
            this.lblObservacionesDevolucion.Text = "Observaciones:";
            // 
            // rbtDefectuoso
            // 
            this.rbtDefectuoso.AutoSize = true;
            this.rbtDefectuoso.Location = new System.Drawing.Point(179, 19);
            this.rbtDefectuoso.Name = "rbtDefectuoso";
            this.rbtDefectuoso.Size = new System.Drawing.Size(80, 17);
            this.rbtDefectuoso.TabIndex = 12;
            this.rbtDefectuoso.TabStop = true;
            this.rbtDefectuoso.Text = "Defectuoso";
            this.rbtDefectuoso.UseVisualStyleBackColor = true;
            // 
            // rbtError
            // 
            this.rbtError.AutoSize = true;
            this.rbtError.Location = new System.Drawing.Point(126, 19);
            this.rbtError.Name = "rbtError";
            this.rbtError.Size = new System.Drawing.Size(47, 17);
            this.rbtError.TabIndex = 11;
            this.rbtError.TabStop = true;
            this.rbtError.Text = "Error";
            this.rbtError.UseVisualStyleBackColor = true;
            this.rbtError.CheckedChanged += new System.EventHandler(this.rbtError_CheckedChanged);
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(319, 9);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 76);
            this.btnValidar.TabIndex = 26;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 444);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 35);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCodigoOriginal
            // 
            this.txtCodigoOriginal.Location = new System.Drawing.Point(151, 37);
            this.txtCodigoOriginal.Name = "txtCodigoOriginal";
            this.txtCodigoOriginal.Size = new System.Drawing.Size(162, 20);
            this.txtCodigoOriginal.TabIndex = 28;
            // 
            // lblCodigoOriginalValidacion
            // 
            this.lblCodigoOriginalValidacion.AutoSize = true;
            this.lblCodigoOriginalValidacion.Location = new System.Drawing.Point(26, 40);
            this.lblCodigoOriginalValidacion.Name = "lblCodigoOriginalValidacion";
            this.lblCodigoOriginalValidacion.Size = new System.Drawing.Size(119, 13);
            this.lblCodigoOriginalValidacion.TabIndex = 29;
            this.lblCodigoOriginalValidacion.Text = "Codigo Original Articulo:";
            // 
            // frmDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 483);
            this.Controls.Add(this.lblCodigoOriginalValidacion);
            this.Controls.Add(this.txtCodigoOriginal);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtNumeroPedido);
            this.Controls.Add(this.lblNumeroPedido);
            this.Controls.Add(this.txtCodigoArticuloProveedor);
            this.Controls.Add(this.lblCodigoArticuloProveedor);
            this.Controls.Add(this.gbxDatosDevolucion);
            this.Controls.Add(this.gbxDetalleArticuloSeleccionado);
            this.Name = "frmDevolucion";
            this.Text = "Devolución de Articulo";
            this.gbxDetalleArticuloSeleccionado.ResumeLayout(false);
            this.tlpDetalles.ResumeLayout(false);
            this.tlpDetalles.PerformLayout();
            this.gbxDatosDevolucion.ResumeLayout(false);
            this.gbxDatosDevolucion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroPedido;
        private System.Windows.Forms.TextBox txtNumeroPedido;
        private System.Windows.Forms.TextBox txtCodigoArticuloProveedor;
        private System.Windows.Forms.RichTextBox rtbObservacionesDevolucion;
        private System.Windows.Forms.Label lblCodigoArticuloProveedor;
        private System.Windows.Forms.Label lblMotivoDevolucion;
        private System.Windows.Forms.GroupBox gbxDetalleArticuloSeleccionado;
        private System.Windows.Forms.TextBox txtCantidadDevuelta;
        private System.Windows.Forms.Label lblCantidadDevuelta;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TableLayoutPanel tlpDetalles;
        private System.Windows.Forms.Label lblProveedorVar;
        private System.Windows.Forms.Label lblObservacionesVar;
        private System.Windows.Forms.Label lblObservacionesArticulo;
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
        private System.Windows.Forms.GroupBox gbxDatosDevolucion;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblObservacionesDevolucion;
        private System.Windows.Forms.RadioButton rbtDefectuoso;
        private System.Windows.Forms.RadioButton rbtError;
        private System.Windows.Forms.TextBox txtMontoNotaCredito;
        private System.Windows.Forms.Label lblMontoNotaCredito;
        private System.Windows.Forms.TextBox txtCodigoOriginal;
        private System.Windows.Forms.Label lblCodigoOriginalValidacion;
    }
}