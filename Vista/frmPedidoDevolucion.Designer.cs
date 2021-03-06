﻿namespace Vista
{
    partial class frmPedidoDevolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidoDevolucion));
            this.pnlBase = new System.Windows.Forms.Panel();
            this.tblLayoutPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelBotones = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblTotalVar = new System.Windows.Forms.Label();
            this.btnQuitar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnQuitarTodos = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSiguiente = new MaterialSkin.Controls.MaterialFlatButton();
            this.tblLayoutPanelArticulos = new System.Windows.Forms.TableLayoutPanel();
            this.gbxDetalleArticuloSeleccionado = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelDetalleArticulo = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelDetallesArticuloOpciones = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelDetalleArticuloBotones = new System.Windows.Forms.TableLayoutPanel();
            this.lblCantidad = new MaterialSkin.Controls.MaterialLabel();
            this.nmrcUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new MaterialSkin.Controls.MaterialFlatButton();
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
            this.lblPrecioActualVar = new System.Windows.Forms.Label();
            this.lblPrecioActual = new System.Windows.Forms.Label();
            this.lblDescripcionVar = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigoProveedorVar = new System.Windows.Forms.Label();
            this.lblCodigoProveedor = new System.Windows.Forms.Label();
            this.lblCodigoOriginal = new System.Windows.Forms.Label();
            this.lblFechaActualizacion = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.tblLayoutPanelDataGrids = new System.Windows.Forms.TableLayoutPanel();
            this.gbxArticulosPedido = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelBuscarPedido = new System.Windows.Forms.TableLayoutPanel();
            this.dgvArticulosPedido = new System.Windows.Forms.DataGridView();
            this.indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorParcialSinDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorParcialConDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLayoutPanelCuadroBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.lblCAE = new System.Windows.Forms.Label();
            this.lblLupa = new System.Windows.Forms.Label();
            this.txtCAE = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.gbxArticulosDevolucion = new System.Windows.Forms.GroupBox();
            this.dgvArticulosDevolucion = new System.Windows.Forms.DataGridView();
            this.indice_dgvDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codOrig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBase.SuspendLayout();
            this.tblLayoutPanelPrincipal.SuspendLayout();
            this.tblLayoutPanelBotones.SuspendLayout();
            this.tblLayoutPanelArticulos.SuspendLayout();
            this.gbxDetalleArticuloSeleccionado.SuspendLayout();
            this.tblLayoutPanelDetalleArticulo.SuspendLayout();
            this.tblLayoutPanelDetallesArticuloOpciones.SuspendLayout();
            this.tblLayoutPanelDetalleArticuloBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownCantidad)).BeginInit();
            this.tlpDetalles.SuspendLayout();
            this.tblLayoutPanelDataGrids.SuspendLayout();
            this.gbxArticulosPedido.SuspendLayout();
            this.tblLayoutPanelBuscarPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosPedido)).BeginInit();
            this.tblLayoutPanelCuadroBusqueda.SuspendLayout();
            this.gbxArticulosDevolucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosDevolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.tblLayoutPanelPrincipal);
            this.pnlBase.Location = new System.Drawing.Point(17, 61);
            this.pnlBase.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(786, 483);
            this.pnlBase.TabIndex = 3;
            // 
            // tblLayoutPanelPrincipal
            // 
            this.tblLayoutPanelPrincipal.BackColor = System.Drawing.Color.White;
            this.tblLayoutPanelPrincipal.ColumnCount = 1;
            this.tblLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal.Controls.Add(this.tblLayoutPanelBotones, 0, 1);
            this.tblLayoutPanelPrincipal.Controls.Add(this.tblLayoutPanelArticulos, 0, 0);
            this.tblLayoutPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanelPrincipal.Name = "tblLayoutPanelPrincipal";
            this.tblLayoutPanelPrincipal.RowCount = 2;
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tblLayoutPanelPrincipal.Size = new System.Drawing.Size(786, 483);
            this.tblLayoutPanelPrincipal.TabIndex = 2;
            // 
            // tblLayoutPanelBotones
            // 
            this.tblLayoutPanelBotones.ColumnCount = 6;
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tblLayoutPanelBotones.Controls.Add(this.lblTotal, 1, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.btnCancelar, 0, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.lblTotalVar, 2, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.btnQuitar, 3, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.btnQuitarTodos, 4, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.btnSiguiente, 5, 0);
            this.tblLayoutPanelBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelBotones.Location = new System.Drawing.Point(3, 426);
            this.tblLayoutPanelBotones.Name = "tblLayoutPanelBotones";
            this.tblLayoutPanelBotones.RowCount = 1;
            this.tblLayoutPanelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelBotones.Size = new System.Drawing.Size(780, 54);
            this.tblLayoutPanelBotones.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(96, 18);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 18);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(4, 9);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(82, 36);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTotalVar
            // 
            this.lblTotalVar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalVar.AutoSize = true;
            this.lblTotalVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTotalVar.Location = new System.Drawing.Point(187, 19);
            this.lblTotalVar.Name = "lblTotalVar";
            this.lblTotalVar.Size = new System.Drawing.Size(16, 16);
            this.lblTotalVar.TabIndex = 10;
            this.lblTotalVar.Text = "0";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitar.AutoSize = true;
            this.btnQuitar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuitar.Depth = 0;
            this.btnQuitar.Location = new System.Drawing.Point(244, 9);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuitar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Primary = false;
            this.btnQuitar.Size = new System.Drawing.Size(112, 36);
            this.btnQuitar.TabIndex = 6;
            this.btnQuitar.Text = "Quitar Seleccionado";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnQuitarTodos
            // 
            this.btnQuitarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarTodos.AutoSize = true;
            this.btnQuitarTodos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuitarTodos.Depth = 0;
            this.btnQuitarTodos.Location = new System.Drawing.Point(364, 9);
            this.btnQuitarTodos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuitarTodos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitarTodos.Name = "btnQuitarTodos";
            this.btnQuitarTodos.Primary = false;
            this.btnQuitarTodos.Size = new System.Drawing.Size(112, 36);
            this.btnQuitarTodos.TabIndex = 5;
            this.btnQuitarTodos.Text = "Quitar Todo";
            this.btnQuitarTodos.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSiguiente.AutoSize = true;
            this.btnSiguiente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSiguiente.Depth = 0;
            this.btnSiguiente.Location = new System.Drawing.Point(678, 9);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4, 6, 12, 6);
            this.btnSiguiente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Primary = false;
            this.btnSiguiente.Size = new System.Drawing.Size(90, 36);
            this.btnSiguiente.TabIndex = 4;
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
            this.tblLayoutPanelArticulos.Size = new System.Drawing.Size(780, 417);
            this.tblLayoutPanelArticulos.TabIndex = 1;
            // 
            // gbxDetalleArticuloSeleccionado
            // 
            this.gbxDetalleArticuloSeleccionado.Controls.Add(this.tblLayoutPanelDetalleArticulo);
            this.gbxDetalleArticuloSeleccionado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDetalleArticuloSeleccionado.Location = new System.Drawing.Point(498, 3);
            this.gbxDetalleArticuloSeleccionado.Name = "gbxDetalleArticuloSeleccionado";
            this.gbxDetalleArticuloSeleccionado.Size = new System.Drawing.Size(279, 411);
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
            this.tblLayoutPanelDetalleArticulo.Size = new System.Drawing.Size(273, 392);
            this.tblLayoutPanelDetalleArticulo.TabIndex = 26;
            // 
            // tblLayoutPanelDetallesArticuloOpciones
            // 
            this.tblLayoutPanelDetallesArticuloOpciones.ColumnCount = 1;
            this.tblLayoutPanelDetallesArticuloOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDetallesArticuloOpciones.Controls.Add(this.tblLayoutPanelDetalleArticuloBotones, 0, 0);
            this.tblLayoutPanelDetallesArticuloOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDetallesArticuloOpciones.Location = new System.Drawing.Point(3, 327);
            this.tblLayoutPanelDetallesArticuloOpciones.Name = "tblLayoutPanelDetallesArticuloOpciones";
            this.tblLayoutPanelDetallesArticuloOpciones.RowCount = 1;
            this.tblLayoutPanelDetallesArticuloOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tblLayoutPanelDetallesArticuloOpciones.Size = new System.Drawing.Size(267, 62);
            this.tblLayoutPanelDetallesArticuloOpciones.TabIndex = 27;
            // 
            // tblLayoutPanelDetalleArticuloBotones
            // 
            this.tblLayoutPanelDetalleArticuloBotones.ColumnCount = 3;
            this.tblLayoutPanelDetalleArticuloBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tblLayoutPanelDetalleArticuloBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDetalleArticuloBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tblLayoutPanelDetalleArticuloBotones.Controls.Add(this.lblCantidad, 0, 0);
            this.tblLayoutPanelDetalleArticuloBotones.Controls.Add(this.nmrcUpDownCantidad, 1, 0);
            this.tblLayoutPanelDetalleArticuloBotones.Controls.Add(this.btnAgregar, 2, 0);
            this.tblLayoutPanelDetalleArticuloBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDetalleArticuloBotones.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelDetalleArticuloBotones.Name = "tblLayoutPanelDetalleArticuloBotones";
            this.tblLayoutPanelDetalleArticuloBotones.RowCount = 1;
            this.tblLayoutPanelDetalleArticuloBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDetalleArticuloBotones.Size = new System.Drawing.Size(261, 56);
            this.tblLayoutPanelDetalleArticuloBotones.TabIndex = 2;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Depth = 0;
            this.lblCantidad.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCantidad.Location = new System.Drawing.Point(3, 18);
            this.lblCantidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(76, 19);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // nmrcUpDownCantidad
            // 
            this.nmrcUpDownCantidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nmrcUpDownCantidad.Location = new System.Drawing.Point(85, 18);
            this.nmrcUpDownCantidad.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nmrcUpDownCantidad.Name = "nmrcUpDownCantidad";
            this.nmrcUpDownCantidad.Size = new System.Drawing.Size(46, 20);
            this.nmrcUpDownCantidad.TabIndex = 2;
            this.nmrcUpDownCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrcUpDownCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nmrcUpDownCantidad_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Location = new System.Drawing.Point(143, 10);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = false;
            this.btnAgregar.Size = new System.Drawing.Size(114, 36);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
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
            this.tlpDetalles.Controls.Add(this.lblPrecioActualVar, 1, 4);
            this.tlpDetalles.Controls.Add(this.lblPrecioActual, 0, 4);
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
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlpDetalles.Size = new System.Drawing.Size(267, 318);
            this.tlpDetalles.TabIndex = 1;
            // 
            // lblProveedorVar
            // 
            this.lblProveedorVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProveedorVar.AutoSize = true;
            this.lblProveedorVar.Location = new System.Drawing.Point(91, 56);
            this.lblProveedorVar.Name = "lblProveedorVar";
            this.lblProveedorVar.Size = new System.Drawing.Size(181, 13);
            this.lblProveedorVar.TabIndex = 19;
            this.lblProveedorVar.Text = "Seleccione Artículo";
            // 
            // lblObservacionesVar
            // 
            this.lblObservacionesVar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblObservacionesVar.Location = new System.Drawing.Point(91, 225);
            this.lblObservacionesVar.Name = "lblObservacionesVar";
            this.lblObservacionesVar.Size = new System.Drawing.Size(181, 93);
            this.lblObservacionesVar.TabIndex = 17;
            this.lblObservacionesVar.Text = "Seleccione Artículo";
            this.lblObservacionesVar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(3, 265);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(82, 13);
            this.lblObservaciones.TabIndex = 16;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblFechaActualizacionVar
            // 
            this.lblFechaActualizacionVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaActualizacionVar.AutoSize = true;
            this.lblFechaActualizacionVar.Location = new System.Drawing.Point(91, 203);
            this.lblFechaActualizacionVar.Name = "lblFechaActualizacionVar";
            this.lblFechaActualizacionVar.Size = new System.Drawing.Size(181, 13);
            this.lblFechaActualizacionVar.TabIndex = 15;
            this.lblFechaActualizacionVar.Text = "Seleccione Artículo";
            // 
            // lblCodigoOriginalVar
            // 
            this.lblCodigoOriginalVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigoOriginalVar.AutoSize = true;
            this.lblCodigoOriginalVar.Location = new System.Drawing.Point(91, 6);
            this.lblCodigoOriginalVar.Name = "lblCodigoOriginalVar";
            this.lblCodigoOriginalVar.Size = new System.Drawing.Size(181, 13);
            this.lblCodigoOriginalVar.TabIndex = 13;
            this.lblCodigoOriginalVar.Text = "Seleccione Artículo";
            // 
            // lblExistenciaVar
            // 
            this.lblExistenciaVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExistenciaVar.AutoSize = true;
            this.lblExistenciaVar.Location = new System.Drawing.Point(91, 175);
            this.lblExistenciaVar.Name = "lblExistenciaVar";
            this.lblExistenciaVar.Size = new System.Drawing.Size(181, 13);
            this.lblExistenciaVar.TabIndex = 11;
            this.lblExistenciaVar.Text = "Seleccione Artículo";
            // 
            // lblExistencia
            // 
            this.lblExistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Location = new System.Drawing.Point(3, 175);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(82, 13);
            this.lblExistencia.TabIndex = 10;
            this.lblExistencia.Text = "Existencia:";
            // 
            // lblUbicacionVar
            // 
            this.lblUbicacionVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUbicacionVar.AutoSize = true;
            this.lblUbicacionVar.Location = new System.Drawing.Point(91, 150);
            this.lblUbicacionVar.Name = "lblUbicacionVar";
            this.lblUbicacionVar.Size = new System.Drawing.Size(181, 13);
            this.lblUbicacionVar.TabIndex = 9;
            this.lblUbicacionVar.Text = "Seleccione Artículo";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(3, 150);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(82, 13);
            this.lblUbicacion.TabIndex = 8;
            this.lblUbicacion.Text = "Ubicación:";
            // 
            // lblPrecioActualVar
            // 
            this.lblPrecioActualVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioActualVar.AutoSize = true;
            this.lblPrecioActualVar.Location = new System.Drawing.Point(91, 125);
            this.lblPrecioActualVar.Name = "lblPrecioActualVar";
            this.lblPrecioActualVar.Size = new System.Drawing.Size(181, 13);
            this.lblPrecioActualVar.TabIndex = 5;
            this.lblPrecioActualVar.Text = "Seleccione Artículo";
            // 
            // lblPrecioActual
            // 
            this.lblPrecioActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioActual.AutoSize = true;
            this.lblPrecioActual.Location = new System.Drawing.Point(3, 125);
            this.lblPrecioActual.Name = "lblPrecioActual";
            this.lblPrecioActual.Size = new System.Drawing.Size(82, 13);
            this.lblPrecioActual.TabIndex = 4;
            this.lblPrecioActual.Text = "Precio Actual:";
            // 
            // lblDescripcionVar
            // 
            this.lblDescripcionVar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescripcionVar.Location = new System.Drawing.Point(91, 75);
            this.lblDescripcionVar.Name = "lblDescripcionVar";
            this.lblDescripcionVar.Size = new System.Drawing.Size(181, 44);
            this.lblDescripcionVar.TabIndex = 3;
            this.lblDescripcionVar.Text = "Seleccione Artículo";
            this.lblDescripcionVar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 90);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblCodigoProveedorVar
            // 
            this.lblCodigoProveedorVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigoProveedorVar.AutoSize = true;
            this.lblCodigoProveedorVar.Location = new System.Drawing.Point(91, 31);
            this.lblCodigoProveedorVar.Name = "lblCodigoProveedorVar";
            this.lblCodigoProveedorVar.Size = new System.Drawing.Size(181, 13);
            this.lblCodigoProveedorVar.TabIndex = 0;
            this.lblCodigoProveedorVar.Text = "Seleccione Artículo";
            // 
            // lblCodigoProveedor
            // 
            this.lblCodigoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigoProveedor.AutoSize = true;
            this.lblCodigoProveedor.Location = new System.Drawing.Point(3, 25);
            this.lblCodigoProveedor.Name = "lblCodigoProveedor";
            this.lblCodigoProveedor.Size = new System.Drawing.Size(82, 25);
            this.lblCodigoProveedor.TabIndex = 1;
            this.lblCodigoProveedor.Text = "Código Proveedor:";
            // 
            // lblCodigoOriginal
            // 
            this.lblCodigoOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigoOriginal.AutoSize = true;
            this.lblCodigoOriginal.Location = new System.Drawing.Point(3, 6);
            this.lblCodigoOriginal.Name = "lblCodigoOriginal";
            this.lblCodigoOriginal.Size = new System.Drawing.Size(82, 13);
            this.lblCodigoOriginal.TabIndex = 12;
            this.lblCodigoOriginal.Text = "Código Original:";
            // 
            // lblFechaActualizacion
            // 
            this.lblFechaActualizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaActualizacion.AutoSize = true;
            this.lblFechaActualizacion.Location = new System.Drawing.Point(3, 196);
            this.lblFechaActualizacion.Name = "lblFechaActualizacion";
            this.lblFechaActualizacion.Size = new System.Drawing.Size(82, 26);
            this.lblFechaActualizacion.TabIndex = 14;
            this.lblFechaActualizacion.Text = "Fecha última actualización:";
            // 
            // lblProveedor
            // 
            this.lblProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(3, 56);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(82, 13);
            this.lblProveedor.TabIndex = 18;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // tblLayoutPanelDataGrids
            // 
            this.tblLayoutPanelDataGrids.ColumnCount = 1;
            this.tblLayoutPanelDataGrids.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDataGrids.Controls.Add(this.gbxArticulosPedido, 0, 0);
            this.tblLayoutPanelDataGrids.Controls.Add(this.gbxArticulosDevolucion, 0, 1);
            this.tblLayoutPanelDataGrids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDataGrids.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelDataGrids.Name = "tblLayoutPanelDataGrids";
            this.tblLayoutPanelDataGrids.RowCount = 2;
            this.tblLayoutPanelDataGrids.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDataGrids.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDataGrids.Size = new System.Drawing.Size(489, 411);
            this.tblLayoutPanelDataGrids.TabIndex = 25;
            // 
            // gbxArticulosPedido
            // 
            this.gbxArticulosPedido.Controls.Add(this.tblLayoutPanelBuscarPedido);
            this.gbxArticulosPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxArticulosPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxArticulosPedido.Location = new System.Drawing.Point(3, 3);
            this.gbxArticulosPedido.Name = "gbxArticulosPedido";
            this.gbxArticulosPedido.Size = new System.Drawing.Size(483, 199);
            this.gbxArticulosPedido.TabIndex = 23;
            this.gbxArticulosPedido.TabStop = false;
            this.gbxArticulosPedido.Text = "Artículos del Pedido";
            // 
            // tblLayoutPanelBuscarPedido
            // 
            this.tblLayoutPanelBuscarPedido.ColumnCount = 1;
            this.tblLayoutPanelBuscarPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelBuscarPedido.Controls.Add(this.dgvArticulosPedido, 0, 1);
            this.tblLayoutPanelBuscarPedido.Controls.Add(this.tblLayoutPanelCuadroBusqueda, 0, 0);
            this.tblLayoutPanelBuscarPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelBuscarPedido.Location = new System.Drawing.Point(3, 19);
            this.tblLayoutPanelBuscarPedido.Name = "tblLayoutPanelBuscarPedido";
            this.tblLayoutPanelBuscarPedido.RowCount = 2;
            this.tblLayoutPanelBuscarPedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tblLayoutPanelBuscarPedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelBuscarPedido.Size = new System.Drawing.Size(477, 177);
            this.tblLayoutPanelBuscarPedido.TabIndex = 0;
            // 
            // dgvArticulosPedido
            // 
            this.dgvArticulosPedido.AllowUserToAddRows = false;
            this.dgvArticulosPedido.AllowUserToDeleteRows = false;
            this.dgvArticulosPedido.AllowUserToResizeRows = false;
            this.dgvArticulosPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulosPedido.BackgroundColor = System.Drawing.Color.White;
            this.dgvArticulosPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulosPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indice,
            this.codOriginal,
            this.codProveedor,
            this.descripcion,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.descuento,
            this.valorParcialSinDescuento,
            this.valorParcialConDescuento});
            this.dgvArticulosPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticulosPedido.Location = new System.Drawing.Point(3, 52);
            this.dgvArticulosPedido.Name = "dgvArticulosPedido";
            this.dgvArticulosPedido.ReadOnly = true;
            this.dgvArticulosPedido.RowHeadersVisible = false;
            this.dgvArticulosPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulosPedido.Size = new System.Drawing.Size(471, 122);
            this.dgvArticulosPedido.TabIndex = 9;
            this.dgvArticulosPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulosPedido_CellClick);
            this.dgvArticulosPedido.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvArticulosPedido_MouseDown);
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
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "valorUnitario";
            this.dataGridViewTextBoxColumn2.HeaderText = "Valor Unitario";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // descuento
            // 
            this.descuento.DataPropertyName = "descuento";
            this.descuento.HeaderText = "Descuento";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            // 
            // valorParcialSinDescuento
            // 
            this.valorParcialSinDescuento.DataPropertyName = "valorParcialSinDescuento";
            this.valorParcialSinDescuento.HeaderText = "Valor Sin Descuento";
            this.valorParcialSinDescuento.Name = "valorParcialSinDescuento";
            this.valorParcialSinDescuento.ReadOnly = true;
            // 
            // valorParcialConDescuento
            // 
            this.valorParcialConDescuento.DataPropertyName = "valorParcialConDescuento";
            this.valorParcialConDescuento.HeaderText = "Valor Final";
            this.valorParcialConDescuento.Name = "valorParcialConDescuento";
            this.valorParcialConDescuento.ReadOnly = true;
            // 
            // tblLayoutPanelCuadroBusqueda
            // 
            this.tblLayoutPanelCuadroBusqueda.ColumnCount = 4;
            this.tblLayoutPanelCuadroBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tblLayoutPanelCuadroBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelCuadroBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblLayoutPanelCuadroBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLayoutPanelCuadroBusqueda.Controls.Add(this.lblCAE, 0, 0);
            this.tblLayoutPanelCuadroBusqueda.Controls.Add(this.lblLupa, 3, 0);
            this.tblLayoutPanelCuadroBusqueda.Controls.Add(this.txtCAE, 1, 0);
            this.tblLayoutPanelCuadroBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelCuadroBusqueda.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelCuadroBusqueda.Name = "tblLayoutPanelCuadroBusqueda";
            this.tblLayoutPanelCuadroBusqueda.RowCount = 1;
            this.tblLayoutPanelCuadroBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelCuadroBusqueda.Size = new System.Drawing.Size(471, 43);
            this.tblLayoutPanelCuadroBusqueda.TabIndex = 0;
            // 
            // lblCAE
            // 
            this.lblCAE.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCAE.AutoSize = true;
            this.lblCAE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCAE.Location = new System.Drawing.Point(12, 13);
            this.lblCAE.Name = "lblCAE";
            this.lblCAE.Size = new System.Drawing.Size(38, 16);
            this.lblCAE.TabIndex = 5;
            this.lblCAE.Text = "CAE:";
            // 
            // lblLupa
            // 
            this.lblLupa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLupa.Image = ((System.Drawing.Image)(resources.GetObject("lblLupa.Image")));
            this.lblLupa.Location = new System.Drawing.Point(434, 5);
            this.lblLupa.Name = "lblLupa";
            this.lblLupa.Size = new System.Drawing.Size(32, 32);
            this.lblLupa.TabIndex = 1;
            this.lblLupa.Click += new System.EventHandler(this.lblLupa_Click);
            // 
            // txtCAE
            // 
            this.txtCAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCAE.Depth = 0;
            this.txtCAE.Hint = "";
            this.txtCAE.Location = new System.Drawing.Point(56, 10);
            this.txtCAE.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCAE.Name = "txtCAE";
            this.txtCAE.PasswordChar = '\0';
            this.txtCAE.SelectedText = "";
            this.txtCAE.SelectionLength = 0;
            this.txtCAE.SelectionStart = 0;
            this.txtCAE.Size = new System.Drawing.Size(347, 23);
            this.txtCAE.TabIndex = 0;
            this.txtCAE.UseSystemPasswordChar = false;
            this.txtCAE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCAE_KeyPress);
            // 
            // gbxArticulosDevolucion
            // 
            this.gbxArticulosDevolucion.Controls.Add(this.dgvArticulosDevolucion);
            this.gbxArticulosDevolucion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxArticulosDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxArticulosDevolucion.Location = new System.Drawing.Point(3, 208);
            this.gbxArticulosDevolucion.Name = "gbxArticulosDevolucion";
            this.gbxArticulosDevolucion.Size = new System.Drawing.Size(483, 200);
            this.gbxArticulosDevolucion.TabIndex = 22;
            this.gbxArticulosDevolucion.TabStop = false;
            this.gbxArticulosDevolucion.Text = "Artículos a Devolver";
            // 
            // dgvArticulosDevolucion
            // 
            this.dgvArticulosDevolucion.AllowUserToAddRows = false;
            this.dgvArticulosDevolucion.AllowUserToDeleteRows = false;
            this.dgvArticulosDevolucion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulosDevolucion.BackgroundColor = System.Drawing.Color.White;
            this.dgvArticulosDevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulosDevolucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indice_dgvDevolucion,
            this.codOrig,
            this.codProv,
            this.daaDescripcion,
            this.cantidad,
            this.vUnitario,
            this.vParcial});
            this.dgvArticulosDevolucion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticulosDevolucion.Location = new System.Drawing.Point(3, 18);
            this.dgvArticulosDevolucion.Name = "dgvArticulosDevolucion";
            this.dgvArticulosDevolucion.ReadOnly = true;
            this.dgvArticulosDevolucion.RowHeadersVisible = false;
            this.dgvArticulosDevolucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulosDevolucion.Size = new System.Drawing.Size(477, 179);
            this.dgvArticulosDevolucion.TabIndex = 5;
            this.dgvArticulosDevolucion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulosDevolucion_CellClick);
            this.dgvArticulosDevolucion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvArticulosDevolucion_MouseDown);
            // 
            // indice_dgvDevolucion
            // 
            this.indice_dgvDevolucion.DataPropertyName = "indice";
            this.indice_dgvDevolucion.HeaderText = "indice";
            this.indice_dgvDevolucion.Name = "indice_dgvDevolucion";
            this.indice_dgvDevolucion.ReadOnly = true;
            this.indice_dgvDevolucion.Visible = false;
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
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // vUnitario
            // 
            this.vUnitario.DataPropertyName = "valorUnitario";
            this.vUnitario.HeaderText = "Valor Unitario";
            this.vUnitario.Name = "vUnitario";
            this.vUnitario.ReadOnly = true;
            // 
            // vParcial
            // 
            this.vParcial.DataPropertyName = "valorParcial";
            this.vParcial.HeaderText = "Valor Parcial";
            this.vParcial.Name = "vParcial";
            this.vParcial.ReadOnly = true;
            // 
            // frmPedidoDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 634);
            this.Controls.Add(this.pnlBase);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPedidoDevolucion";
            this.Text = "Devolución";
            this.pnlBase.ResumeLayout(false);
            this.tblLayoutPanelPrincipal.ResumeLayout(false);
            this.tblLayoutPanelBotones.ResumeLayout(false);
            this.tblLayoutPanelBotones.PerformLayout();
            this.tblLayoutPanelArticulos.ResumeLayout(false);
            this.gbxDetalleArticuloSeleccionado.ResumeLayout(false);
            this.tblLayoutPanelDetalleArticulo.ResumeLayout(false);
            this.tblLayoutPanelDetallesArticuloOpciones.ResumeLayout(false);
            this.tblLayoutPanelDetalleArticuloBotones.ResumeLayout(false);
            this.tblLayoutPanelDetalleArticuloBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownCantidad)).EndInit();
            this.tlpDetalles.ResumeLayout(false);
            this.tlpDetalles.PerformLayout();
            this.tblLayoutPanelDataGrids.ResumeLayout(false);
            this.gbxArticulosPedido.ResumeLayout(false);
            this.tblLayoutPanelBuscarPedido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosPedido)).EndInit();
            this.tblLayoutPanelCuadroBusqueda.ResumeLayout(false);
            this.tblLayoutPanelCuadroBusqueda.PerformLayout();
            this.gbxArticulosDevolucion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosDevolucion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelPrincipal;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelBotones;
        internal System.Windows.Forms.Label lblTotalVar;
        internal System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelArticulos;
        private System.Windows.Forms.GroupBox gbxDetalleArticuloSeleccionado;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDetalleArticulo;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDetallesArticuloOpciones;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDetalleArticuloBotones;
        private System.Windows.Forms.NumericUpDown nmrcUpDownCantidad;
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
        private System.Windows.Forms.Label lblPrecioActualVar;
        private System.Windows.Forms.Label lblPrecioActual;
        private System.Windows.Forms.Label lblDescripcionVar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCodigoProveedorVar;
        private System.Windows.Forms.Label lblCodigoProveedor;
        private System.Windows.Forms.Label lblCodigoOriginal;
        private System.Windows.Forms.Label lblFechaActualizacion;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDataGrids;
        private System.Windows.Forms.GroupBox gbxArticulosPedido;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelBuscarPedido;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelCuadroBusqueda;
        private System.Windows.Forms.Label lblCAE;
        internal System.Windows.Forms.Label lblLupa;
        private System.Windows.Forms.GroupBox gbxArticulosDevolucion;
        internal System.Windows.Forms.DataGridView dgvArticulosDevolucion;
        internal System.Windows.Forms.DataGridView dgvArticulosPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn codOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorParcialSinDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorParcialConDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn indice_dgvDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn codOrig;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn daaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn vUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn vParcial;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCAE;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private MaterialSkin.Controls.MaterialFlatButton btnQuitar;
        private MaterialSkin.Controls.MaterialFlatButton btnQuitarTodos;
        private MaterialSkin.Controls.MaterialFlatButton btnSiguiente;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregar;
        private System.Windows.Forms.Panel pnlBase;
        private MaterialSkin.Controls.MaterialLabel lblCantidad;
    }
}