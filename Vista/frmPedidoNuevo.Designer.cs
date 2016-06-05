﻿namespace Vista
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
            this.tblLayoutPanelBase = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnBorrarDetalleActual = new System.Windows.Forms.Button();
            this.lblTotalVar = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.tblLayoutPanelArticulos = new System.Windows.Forms.TableLayoutPanel();
            this.gbxDetalleArticuloSeleccionado = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelDetalleArticulo = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelDetallesArticuloOpciones = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelDetalleArticuloBotones = new System.Windows.Forms.TableLayoutPanel();
            this.nmrcUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.chckBoxPermitirStockNegativo = new System.Windows.Forms.CheckBox();
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
            this.tblLayoutPanelDataGrids = new System.Windows.Forms.TableLayoutPanel();
            this.gbxArticulosAgregar = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelBuscarArticulo = new System.Windows.Forms.TableLayoutPanel();
            this.dgvArticulosResultadoBusqueda = new System.Windows.Forms.DataGridView();
            this.indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLayoutPanelCuadroBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.cbxCategoriaBusqueda = new System.Windows.Forms.ComboBox();
            this.lblCategoriaBuscar = new System.Windows.Forms.Label();
            this.lblLupa = new System.Windows.Forms.Label();
            this.txtDescripcionParcial = new System.Windows.Forms.TextBox();
            this.gbxDetalleAgregados = new System.Windows.Forms.GroupBox();
            this.dgvArticulosEnPedido = new System.Windows.Forms.DataGridView();
            this.codOrig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLayoutPanelBase.SuspendLayout();
            this.tblLayoutPanelBotones.SuspendLayout();
            this.tblLayoutPanelArticulos.SuspendLayout();
            this.gbxDetalleArticuloSeleccionado.SuspendLayout();
            this.tblLayoutPanelDetalleArticulo.SuspendLayout();
            this.tblLayoutPanelDetallesArticuloOpciones.SuspendLayout();
            this.tblLayoutPanelDetalleArticuloBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownCantidad)).BeginInit();
            this.tlpDetalles.SuspendLayout();
            this.tblLayoutPanelDataGrids.SuspendLayout();
            this.gbxArticulosAgregar.SuspendLayout();
            this.tblLayoutPanelBuscarArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosResultadoBusqueda)).BeginInit();
            this.tblLayoutPanelCuadroBusqueda.SuspendLayout();
            this.gbxDetalleAgregados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosEnPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLayoutPanelBase
            // 
            this.tblLayoutPanelBase.ColumnCount = 1;
            this.tblLayoutPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelBase.Controls.Add(this.tblLayoutPanelBotones, 0, 1);
            this.tblLayoutPanelBase.Controls.Add(this.tblLayoutPanelArticulos, 0, 0);
            this.tblLayoutPanelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelBase.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanelBase.Name = "tblLayoutPanelBase";
            this.tblLayoutPanelBase.RowCount = 2;
            this.tblLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblLayoutPanelBase.Size = new System.Drawing.Size(958, 588);
            this.tblLayoutPanelBase.TabIndex = 1;
            // 
            // tblLayoutPanelBotones
            // 
            this.tblLayoutPanelBotones.ColumnCount = 6;
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tblLayoutPanelBotones.Controls.Add(this.btnQuitar, 2, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.btnBorrarDetalleActual, 3, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.lblTotalVar, 2, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.lblTotal, 1, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.btnCancelar, 0, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.btnSiguiente, 5, 0);
            this.tblLayoutPanelBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelBotones.Location = new System.Drawing.Point(3, 531);
            this.tblLayoutPanelBotones.Name = "tblLayoutPanelBotones";
            this.tblLayoutPanelBotones.RowCount = 1;
            this.tblLayoutPanelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelBotones.Size = new System.Drawing.Size(952, 54);
            this.tblLayoutPanelBotones.TabIndex = 0;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuitar.Location = new System.Drawing.Point(477, 7);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(80, 40);
            this.btnQuitar.TabIndex = 12;
            this.btnQuitar.Text = "Quitar Seleccionado";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnBorrarDetalleActual
            // 
            this.btnBorrarDetalleActual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBorrarDetalleActual.AutoSize = true;
            this.btnBorrarDetalleActual.Location = new System.Drawing.Point(565, 8);
            this.btnBorrarDetalleActual.Name = "btnBorrarDetalleActual";
            this.btnBorrarDetalleActual.Size = new System.Drawing.Size(84, 38);
            this.btnBorrarDetalleActual.TabIndex = 13;
            this.btnBorrarDetalleActual.Text = "Quitar Todo";
            this.btnBorrarDetalleActual.UseVisualStyleBackColor = true;
            // 
            // lblTotalVar
            // 
            this.lblTotalVar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalVar.AutoSize = true;
            this.lblTotalVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTotalVar.Location = new System.Drawing.Point(419, 19);
            this.lblTotalVar.Name = "lblTotalVar";
            this.lblTotalVar.Size = new System.Drawing.Size(16, 16);
            this.lblTotalVar.TabIndex = 10;
            this.lblTotalVar.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(328, 18);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 18);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(8, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 40);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSiguiente.AutoSize = true;
            this.btnSiguiente.Location = new System.Drawing.Point(838, 8);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(84, 38);
            this.btnSiguiente.TabIndex = 11;
            this.btnSiguiente.Text = "Siguiente >";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // tblLayoutPanelArticulos
            // 
            this.tblLayoutPanelArticulos.ColumnCount = 2;
            this.tblLayoutPanelArticulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelArticulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 285F));
            this.tblLayoutPanelArticulos.Controls.Add(this.gbxDetalleArticuloSeleccionado, 1, 0);
            this.tblLayoutPanelArticulos.Controls.Add(this.tblLayoutPanelDataGrids, 0, 0);
            this.tblLayoutPanelArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelArticulos.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelArticulos.Name = "tblLayoutPanelArticulos";
            this.tblLayoutPanelArticulos.RowCount = 1;
            this.tblLayoutPanelArticulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelArticulos.Size = new System.Drawing.Size(952, 522);
            this.tblLayoutPanelArticulos.TabIndex = 1;
            // 
            // gbxDetalleArticuloSeleccionado
            // 
            this.gbxDetalleArticuloSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDetalleArticuloSeleccionado.Controls.Add(this.tblLayoutPanelDetalleArticulo);
            this.gbxDetalleArticuloSeleccionado.Location = new System.Drawing.Point(670, 3);
            this.gbxDetalleArticuloSeleccionado.Name = "gbxDetalleArticuloSeleccionado";
            this.gbxDetalleArticuloSeleccionado.Size = new System.Drawing.Size(279, 504);
            this.gbxDetalleArticuloSeleccionado.TabIndex = 25;
            this.gbxDetalleArticuloSeleccionado.TabStop = false;
            this.gbxDetalleArticuloSeleccionado.Text = "Detalle Artículo Seleccionado";
            // 
            // tblLayoutPanelDetalleArticulo
            // 
            this.tblLayoutPanelDetalleArticulo.ColumnCount = 1;
            this.tblLayoutPanelDetalleArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDetalleArticulo.Controls.Add(this.tblLayoutPanelDetallesArticuloOpciones, 0, 1);
            this.tblLayoutPanelDetalleArticulo.Controls.Add(this.tlpDetalles, 0, 0);
            this.tblLayoutPanelDetalleArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDetalleArticulo.Location = new System.Drawing.Point(3, 16);
            this.tblLayoutPanelDetalleArticulo.Name = "tblLayoutPanelDetalleArticulo";
            this.tblLayoutPanelDetalleArticulo.RowCount = 2;
            this.tblLayoutPanelDetalleArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.8866F));
            this.tblLayoutPanelDetalleArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.1134F));
            this.tblLayoutPanelDetalleArticulo.Size = new System.Drawing.Size(273, 485);
            this.tblLayoutPanelDetalleArticulo.TabIndex = 26;
            // 
            // tblLayoutPanelDetallesArticuloOpciones
            // 
            this.tblLayoutPanelDetallesArticuloOpciones.ColumnCount = 1;
            this.tblLayoutPanelDetallesArticuloOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDetallesArticuloOpciones.Controls.Add(this.tblLayoutPanelDetalleArticuloBotones, 0, 0);
            this.tblLayoutPanelDetallesArticuloOpciones.Controls.Add(this.chckBoxPermitirStockNegativo, 0, 1);
            this.tblLayoutPanelDetallesArticuloOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDetallesArticuloOpciones.Location = new System.Drawing.Point(3, 404);
            this.tblLayoutPanelDetallesArticuloOpciones.Name = "tblLayoutPanelDetallesArticuloOpciones";
            this.tblLayoutPanelDetallesArticuloOpciones.RowCount = 2;
            this.tblLayoutPanelDetallesArticuloOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tblLayoutPanelDetallesArticuloOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblLayoutPanelDetallesArticuloOpciones.Size = new System.Drawing.Size(267, 78);
            this.tblLayoutPanelDetallesArticuloOpciones.TabIndex = 27;
            // 
            // tblLayoutPanelDetalleArticuloBotones
            // 
            this.tblLayoutPanelDetalleArticuloBotones.ColumnCount = 3;
            this.tblLayoutPanelDetalleArticuloBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.40659F));
            this.tblLayoutPanelDetalleArticuloBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.59341F));
            this.tblLayoutPanelDetalleArticuloBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tblLayoutPanelDetalleArticuloBotones.Controls.Add(this.nmrcUpDownCantidad, 1, 0);
            this.tblLayoutPanelDetalleArticuloBotones.Controls.Add(this.btnAgregar, 2, 0);
            this.tblLayoutPanelDetalleArticuloBotones.Controls.Add(this.lblCantidad, 0, 0);
            this.tblLayoutPanelDetalleArticuloBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDetalleArticuloBotones.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelDetalleArticuloBotones.Name = "tblLayoutPanelDetalleArticuloBotones";
            this.tblLayoutPanelDetalleArticuloBotones.RowCount = 1;
            this.tblLayoutPanelDetalleArticuloBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDetalleArticuloBotones.Size = new System.Drawing.Size(261, 44);
            this.tblLayoutPanelDetalleArticuloBotones.TabIndex = 2;
            // 
            // nmrcUpDownCantidad
            // 
            this.nmrcUpDownCantidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nmrcUpDownCantidad.Location = new System.Drawing.Point(70, 12);
            this.nmrcUpDownCantidad.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nmrcUpDownCantidad.Name = "nmrcUpDownCantidad";
            this.nmrcUpDownCantidad.Size = new System.Drawing.Size(45, 20);
            this.nmrcUpDownCantidad.TabIndex = 2;
            this.nmrcUpDownCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.Location = new System.Drawing.Point(168, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 35);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 15);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // chckBoxPermitirStockNegativo
            // 
            this.chckBoxPermitirStockNegativo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chckBoxPermitirStockNegativo.AutoSize = true;
            this.chckBoxPermitirStockNegativo.Location = new System.Drawing.Point(65, 55);
            this.chckBoxPermitirStockNegativo.Name = "chckBoxPermitirStockNegativo";
            this.chckBoxPermitirStockNegativo.Size = new System.Drawing.Size(137, 17);
            this.chckBoxPermitirStockNegativo.TabIndex = 3;
            this.chckBoxPermitirStockNegativo.Text = "Permitir Stock Negativo";
            this.chckBoxPermitirStockNegativo.UseVisualStyleBackColor = true;
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
            this.tlpDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDetalles.Location = new System.Drawing.Point(3, 3);
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
            this.tlpDetalles.Size = new System.Drawing.Size(267, 395);
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
            this.lblObservacionesVar.Size = new System.Drawing.Size(181, 80);
            this.lblObservacionesVar.TabIndex = 17;
            this.lblObservacionesVar.Text = "Seleccione Artículo";
            this.lblObservacionesVar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(3, 348);
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
            // tblLayoutPanelDataGrids
            // 
            this.tblLayoutPanelDataGrids.ColumnCount = 1;
            this.tblLayoutPanelDataGrids.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDataGrids.Controls.Add(this.gbxArticulosAgregar, 0, 0);
            this.tblLayoutPanelDataGrids.Controls.Add(this.gbxDetalleAgregados, 0, 1);
            this.tblLayoutPanelDataGrids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDataGrids.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelDataGrids.Name = "tblLayoutPanelDataGrids";
            this.tblLayoutPanelDataGrids.RowCount = 2;
            this.tblLayoutPanelDataGrids.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDataGrids.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDataGrids.Size = new System.Drawing.Size(661, 516);
            this.tblLayoutPanelDataGrids.TabIndex = 25;
            // 
            // gbxArticulosAgregar
            // 
            this.gbxArticulosAgregar.Controls.Add(this.tblLayoutPanelBuscarArticulo);
            this.gbxArticulosAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxArticulosAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxArticulosAgregar.Location = new System.Drawing.Point(3, 3);
            this.gbxArticulosAgregar.Name = "gbxArticulosAgregar";
            this.gbxArticulosAgregar.Size = new System.Drawing.Size(655, 252);
            this.gbxArticulosAgregar.TabIndex = 23;
            this.gbxArticulosAgregar.TabStop = false;
            this.gbxArticulosAgregar.Text = "Artículos a Agregar";
            // 
            // tblLayoutPanelBuscarArticulo
            // 
            this.tblLayoutPanelBuscarArticulo.ColumnCount = 1;
            this.tblLayoutPanelBuscarArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelBuscarArticulo.Controls.Add(this.dgvArticulosResultadoBusqueda, 0, 1);
            this.tblLayoutPanelBuscarArticulo.Controls.Add(this.tblLayoutPanelCuadroBusqueda, 0, 0);
            this.tblLayoutPanelBuscarArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelBuscarArticulo.Location = new System.Drawing.Point(3, 19);
            this.tblLayoutPanelBuscarArticulo.Name = "tblLayoutPanelBuscarArticulo";
            this.tblLayoutPanelBuscarArticulo.RowCount = 2;
            this.tblLayoutPanelBuscarArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.32258F));
            this.tblLayoutPanelBuscarArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.67742F));
            this.tblLayoutPanelBuscarArticulo.Size = new System.Drawing.Size(649, 230);
            this.tblLayoutPanelBuscarArticulo.TabIndex = 0;
            // 
            // dgvArticulosResultadoBusqueda
            // 
            this.dgvArticulosResultadoBusqueda.AllowUserToAddRows = false;
            this.dgvArticulosResultadoBusqueda.AllowUserToDeleteRows = false;
            this.dgvArticulosResultadoBusqueda.AllowUserToOrderColumns = true;
            this.dgvArticulosResultadoBusqueda.AllowUserToResizeRows = false;
            this.dgvArticulosResultadoBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulosResultadoBusqueda.BackgroundColor = System.Drawing.Color.White;
            this.dgvArticulosResultadoBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulosResultadoBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indice,
            this.codOriginal,
            this.codProveedor,
            this.proveedor,
            this.descripcion});
            this.dgvArticulosResultadoBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticulosResultadoBusqueda.GridColor = System.Drawing.Color.White;
            this.dgvArticulosResultadoBusqueda.Location = new System.Drawing.Point(3, 38);
            this.dgvArticulosResultadoBusqueda.Name = "dgvArticulosResultadoBusqueda";
            this.dgvArticulosResultadoBusqueda.ReadOnly = true;
            this.dgvArticulosResultadoBusqueda.RowHeadersVisible = false;
            this.dgvArticulosResultadoBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulosResultadoBusqueda.Size = new System.Drawing.Size(643, 189);
            this.dgvArticulosResultadoBusqueda.TabIndex = 4;
            this.dgvArticulosResultadoBusqueda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulosResultadoBusqueda_CellClick);
            this.dgvArticulosResultadoBusqueda.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvArticulosResultadoBusqueda_MouseDown);
            // 
            // indice
            // 
            this.indice.DataPropertyName = "indice";
            this.indice.HeaderText = "indice";
            this.indice.Name = "indice";
            this.indice.ReadOnly = true;
            this.indice.Visible = false;
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
            // tblLayoutPanelCuadroBusqueda
            // 
            this.tblLayoutPanelCuadroBusqueda.ColumnCount = 4;
            this.tblLayoutPanelCuadroBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tblLayoutPanelCuadroBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tblLayoutPanelCuadroBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelCuadroBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLayoutPanelCuadroBusqueda.Controls.Add(this.cbxCategoriaBusqueda, 0, 0);
            this.tblLayoutPanelCuadroBusqueda.Controls.Add(this.lblCategoriaBuscar, 0, 0);
            this.tblLayoutPanelCuadroBusqueda.Controls.Add(this.lblLupa, 3, 0);
            this.tblLayoutPanelCuadroBusqueda.Controls.Add(this.txtDescripcionParcial, 2, 0);
            this.tblLayoutPanelCuadroBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelCuadroBusqueda.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelCuadroBusqueda.Name = "tblLayoutPanelCuadroBusqueda";
            this.tblLayoutPanelCuadroBusqueda.RowCount = 1;
            this.tblLayoutPanelCuadroBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelCuadroBusqueda.Size = new System.Drawing.Size(643, 29);
            this.tblLayoutPanelCuadroBusqueda.TabIndex = 0;
            // 
            // cbxCategoriaBusqueda
            // 
            this.cbxCategoriaBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCategoriaBusqueda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxCategoriaBusqueda.FormattingEnabled = true;
            this.cbxCategoriaBusqueda.Items.AddRange(new object[] {
            "Código Original",
            "Código Proveedor",
            "Descripción"});
            this.cbxCategoriaBusqueda.Location = new System.Drawing.Point(88, 4);
            this.cbxCategoriaBusqueda.Name = "cbxCategoriaBusqueda";
            this.cbxCategoriaBusqueda.Size = new System.Drawing.Size(119, 24);
            this.cbxCategoriaBusqueda.TabIndex = 6;
            this.cbxCategoriaBusqueda.Text = "[Seleccionar...]";
            // 
            // lblCategoriaBuscar
            // 
            this.lblCategoriaBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCategoriaBuscar.AutoSize = true;
            this.lblCategoriaBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaBuscar.Location = new System.Drawing.Point(6, 6);
            this.lblCategoriaBuscar.Name = "lblCategoriaBuscar";
            this.lblCategoriaBuscar.Size = new System.Drawing.Size(76, 16);
            this.lblCategoriaBuscar.TabIndex = 5;
            this.lblCategoriaBuscar.Text = "Buscar por:";
            // 
            // lblLupa
            // 
            this.lblLupa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLupa.Image = ((System.Drawing.Image)(resources.GetObject("lblLupa.Image")));
            this.lblLupa.Location = new System.Drawing.Point(606, 0);
            this.lblLupa.Name = "lblLupa";
            this.lblLupa.Size = new System.Drawing.Size(32, 28);
            this.lblLupa.TabIndex = 8;
            this.lblLupa.Click += new System.EventHandler(this.lblLupa_Click);
            // 
            // txtDescripcionParcial
            // 
            this.txtDescripcionParcial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcionParcial.Location = new System.Drawing.Point(213, 3);
            this.txtDescripcionParcial.Name = "txtDescripcionParcial";
            this.txtDescripcionParcial.Size = new System.Drawing.Size(387, 23);
            this.txtDescripcionParcial.TabIndex = 7;
            this.txtDescripcionParcial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcionParcial_KeyPress);
            // 
            // gbxDetalleAgregados
            // 
            this.gbxDetalleAgregados.Controls.Add(this.dgvArticulosEnPedido);
            this.gbxDetalleAgregados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDetalleAgregados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetalleAgregados.Location = new System.Drawing.Point(3, 261);
            this.gbxDetalleAgregados.Name = "gbxDetalleAgregados";
            this.gbxDetalleAgregados.Size = new System.Drawing.Size(655, 252);
            this.gbxDetalleAgregados.TabIndex = 22;
            this.gbxDetalleAgregados.TabStop = false;
            this.gbxDetalleAgregados.Text = "Detalle Artículos Agregados";
            // 
            // dgvArticulosEnPedido
            // 
            this.dgvArticulosEnPedido.AllowUserToAddRows = false;
            this.dgvArticulosEnPedido.AllowUserToDeleteRows = false;
            this.dgvArticulosEnPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulosEnPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulosEnPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codOrig,
            this.codProv,
            this.daaDescripcion,
            this.vUnitario,
            this.cantidad,
            this.vParcial});
            this.dgvArticulosEnPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticulosEnPedido.Location = new System.Drawing.Point(3, 18);
            this.dgvArticulosEnPedido.Name = "dgvArticulosEnPedido";
            this.dgvArticulosEnPedido.ReadOnly = true;
            this.dgvArticulosEnPedido.RowHeadersVisible = false;
            this.dgvArticulosEnPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulosEnPedido.Size = new System.Drawing.Size(649, 231);
            this.dgvArticulosEnPedido.TabIndex = 5;
            this.dgvArticulosEnPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulosEnPedido_CellClick);
            this.dgvArticulosEnPedido.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvArticulosEnPedido_MouseDown);
            // 
            // codOrig
            // 
            this.codOrig.DataPropertyName = "codigoOriginal";
            this.codOrig.HeaderText = "Código Original";
            this.codOrig.Name = "codOrig";
            this.codOrig.ReadOnly = true;
            // 
            // codProv
            // 
            this.codProv.DataPropertyName = "codigoArticuloProveedor";
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
            // frmPedidoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(958, 588);
            this.Controls.Add(this.tblLayoutPanelBase);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(745, 615);
            this.Name = "frmPedidoNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Pedido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPedidoNuevo_FormClosing);
            this.tblLayoutPanelBase.ResumeLayout(false);
            this.tblLayoutPanelBotones.ResumeLayout(false);
            this.tblLayoutPanelBotones.PerformLayout();
            this.tblLayoutPanelArticulos.ResumeLayout(false);
            this.gbxDetalleArticuloSeleccionado.ResumeLayout(false);
            this.tblLayoutPanelDetalleArticulo.ResumeLayout(false);
            this.tblLayoutPanelDetallesArticuloOpciones.ResumeLayout(false);
            this.tblLayoutPanelDetallesArticuloOpciones.PerformLayout();
            this.tblLayoutPanelDetalleArticuloBotones.ResumeLayout(false);
            this.tblLayoutPanelDetalleArticuloBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownCantidad)).EndInit();
            this.tlpDetalles.ResumeLayout(false);
            this.tlpDetalles.PerformLayout();
            this.tblLayoutPanelDataGrids.ResumeLayout(false);
            this.gbxArticulosAgregar.ResumeLayout(false);
            this.tblLayoutPanelBuscarArticulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosResultadoBusqueda)).EndInit();
            this.tblLayoutPanelCuadroBusqueda.ResumeLayout(false);
            this.tblLayoutPanelCuadroBusqueda.PerformLayout();
            this.gbxDetalleAgregados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosEnPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelBase;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelBotones;
        private System.Windows.Forms.Button btnQuitar;
        internal System.Windows.Forms.Button btnBorrarDetalleActual;
        internal System.Windows.Forms.Label lblTotalVar;
        internal System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelArticulos;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDataGrids;
        private System.Windows.Forms.GroupBox gbxArticulosAgregar;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelBuscarArticulo;
        internal System.Windows.Forms.DataGridView dgvArticulosResultadoBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn codOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelCuadroBusqueda;
        internal System.Windows.Forms.ComboBox cbxCategoriaBusqueda;
        private System.Windows.Forms.Label lblCategoriaBuscar;
        internal System.Windows.Forms.Label lblLupa;
        internal System.Windows.Forms.TextBox txtDescripcionParcial;
        private System.Windows.Forms.GroupBox gbxDetalleAgregados;
        internal System.Windows.Forms.DataGridView dgvArticulosEnPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn codOrig;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn daaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn vUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn vParcial;
        private System.Windows.Forms.GroupBox gbxDetalleArticuloSeleccionado;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDetalleArticulo;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDetallesArticuloOpciones;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDetalleArticuloBotones;
        private System.Windows.Forms.NumericUpDown nmrcUpDownCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.CheckBox chckBoxPermitirStockNegativo;
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


    }
}