namespace Vista
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
            this.tblLayoutPanelBase = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnQuitarTodos = new System.Windows.Forms.Button();
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
            this.txtCAE = new System.Windows.Forms.TextBox();
            this.gbxArticulosDevolucion = new System.Windows.Forms.GroupBox();
            this.dgvArticulosDevolucion = new System.Windows.Forms.DataGridView();
            this.indice_dgvDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codOrig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.gbxArticulosPedido.SuspendLayout();
            this.tblLayoutPanelBuscarPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosPedido)).BeginInit();
            this.tblLayoutPanelCuadroBusqueda.SuspendLayout();
            this.gbxArticulosDevolucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosDevolucion)).BeginInit();
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
            this.tblLayoutPanelBase.Size = new System.Drawing.Size(899, 573);
            this.tblLayoutPanelBase.TabIndex = 2;
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
            this.tblLayoutPanelBotones.Controls.Add(this.btnQuitarTodos, 3, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.lblTotalVar, 2, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.lblTotal, 1, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.btnCancelar, 0, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.btnSiguiente, 5, 0);
            this.tblLayoutPanelBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelBotones.Location = new System.Drawing.Point(3, 516);
            this.tblLayoutPanelBotones.Name = "tblLayoutPanelBotones";
            this.tblLayoutPanelBotones.RowCount = 1;
            this.tblLayoutPanelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelBotones.Size = new System.Drawing.Size(893, 54);
            this.tblLayoutPanelBotones.TabIndex = 0;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuitar.Location = new System.Drawing.Point(418, 7);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(80, 40);
            this.btnQuitar.TabIndex = 12;
            this.btnQuitar.Text = "Quitar Seleccionado";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnQuitarTodos
            // 
            this.btnQuitarTodos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuitarTodos.AutoSize = true;
            this.btnQuitarTodos.Location = new System.Drawing.Point(506, 8);
            this.btnQuitarTodos.Name = "btnQuitarTodos";
            this.btnQuitarTodos.Size = new System.Drawing.Size(84, 38);
            this.btnQuitarTodos.TabIndex = 13;
            this.btnQuitarTodos.Text = "Quitar Todo";
            this.btnQuitarTodos.UseVisualStyleBackColor = true;
            // 
            // lblTotalVar
            // 
            this.lblTotalVar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalVar.AutoSize = true;
            this.lblTotalVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTotalVar.Location = new System.Drawing.Point(360, 19);
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
            this.lblTotal.Location = new System.Drawing.Point(269, 18);
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
            this.btnSiguiente.Location = new System.Drawing.Point(779, 8);
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
            this.tblLayoutPanelArticulos.Size = new System.Drawing.Size(893, 507);
            this.tblLayoutPanelArticulos.TabIndex = 1;
            // 
            // gbxDetalleArticuloSeleccionado
            // 
            this.gbxDetalleArticuloSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDetalleArticuloSeleccionado.Controls.Add(this.tblLayoutPanelDetalleArticulo);
            this.gbxDetalleArticuloSeleccionado.Location = new System.Drawing.Point(611, 3);
            this.gbxDetalleArticuloSeleccionado.Name = "gbxDetalleArticuloSeleccionado";
            this.gbxDetalleArticuloSeleccionado.Size = new System.Drawing.Size(279, 501);
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
            this.tblLayoutPanelDetalleArticulo.Size = new System.Drawing.Size(273, 482);
            this.tblLayoutPanelDetalleArticulo.TabIndex = 26;
            // 
            // tblLayoutPanelDetallesArticuloOpciones
            // 
            this.tblLayoutPanelDetallesArticuloOpciones.ColumnCount = 1;
            this.tblLayoutPanelDetallesArticuloOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDetallesArticuloOpciones.Controls.Add(this.tblLayoutPanelDetalleArticuloBotones, 0, 0);
            this.tblLayoutPanelDetallesArticuloOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDetallesArticuloOpciones.Location = new System.Drawing.Point(3, 402);
            this.tblLayoutPanelDetallesArticuloOpciones.Name = "tblLayoutPanelDetallesArticuloOpciones";
            this.tblLayoutPanelDetallesArticuloOpciones.RowCount = 1;
            this.tblLayoutPanelDetallesArticuloOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tblLayoutPanelDetallesArticuloOpciones.Size = new System.Drawing.Size(267, 77);
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
            this.tblLayoutPanelDetalleArticuloBotones.Size = new System.Drawing.Size(261, 71);
            this.tblLayoutPanelDetalleArticuloBotones.TabIndex = 2;
            // 
            // nmrcUpDownCantidad
            // 
            this.nmrcUpDownCantidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nmrcUpDownCantidad.Location = new System.Drawing.Point(70, 25);
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
            this.nmrcUpDownCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nmrcUpDownCantidad_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.Location = new System.Drawing.Point(168, 18);
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
            this.lblCantidad.Location = new System.Drawing.Point(12, 29);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad:";
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
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.695652F));
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.695652F));
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.695652F));
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.56522F));
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.695652F));
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.695652F));
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.695652F));
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.695652F));
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.56522F));
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDetalles.Size = new System.Drawing.Size(267, 393);
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
            this.lblObservacionesVar.Location = new System.Drawing.Point(91, 314);
            this.lblObservacionesVar.Name = "lblObservacionesVar";
            this.lblObservacionesVar.Size = new System.Drawing.Size(181, 79);
            this.lblObservacionesVar.TabIndex = 17;
            this.lblObservacionesVar.Text = "Seleccione Artículo";
            this.lblObservacionesVar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(3, 347);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(82, 13);
            this.lblObservaciones.TabIndex = 16;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblFechaActualizacionVar
            // 
            this.lblFechaActualizacionVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaActualizacionVar.AutoSize = true;
            this.lblFechaActualizacionVar.Location = new System.Drawing.Point(91, 290);
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
            this.lblExistenciaVar.Location = new System.Drawing.Point(91, 256);
            this.lblExistenciaVar.Name = "lblExistenciaVar";
            this.lblExistenciaVar.Size = new System.Drawing.Size(181, 13);
            this.lblExistenciaVar.TabIndex = 11;
            this.lblExistenciaVar.Text = "Seleccione Artículo";
            // 
            // lblExistencia
            // 
            this.lblExistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Location = new System.Drawing.Point(3, 256);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(82, 13);
            this.lblExistencia.TabIndex = 10;
            this.lblExistencia.Text = "Existencia:";
            // 
            // lblUbicacionVar
            // 
            this.lblUbicacionVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUbicacionVar.AutoSize = true;
            this.lblUbicacionVar.Location = new System.Drawing.Point(91, 222);
            this.lblUbicacionVar.Name = "lblUbicacionVar";
            this.lblUbicacionVar.Size = new System.Drawing.Size(181, 13);
            this.lblUbicacionVar.TabIndex = 9;
            this.lblUbicacionVar.Text = "Seleccione Artículo";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(3, 222);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(82, 13);
            this.lblUbicacion.TabIndex = 8;
            this.lblUbicacion.Text = "Ubicación:";
            // 
            // lblPrecioActualVar
            // 
            this.lblPrecioActualVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioActualVar.AutoSize = true;
            this.lblPrecioActualVar.Location = new System.Drawing.Point(91, 188);
            this.lblPrecioActualVar.Name = "lblPrecioActualVar";
            this.lblPrecioActualVar.Size = new System.Drawing.Size(181, 13);
            this.lblPrecioActualVar.TabIndex = 5;
            this.lblPrecioActualVar.Text = "Seleccione Artículo";
            // 
            // lblPrecioActual
            // 
            this.lblPrecioActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioActual.AutoSize = true;
            this.lblPrecioActual.Location = new System.Drawing.Point(3, 188);
            this.lblPrecioActual.Name = "lblPrecioActual";
            this.lblPrecioActual.Size = new System.Drawing.Size(82, 13);
            this.lblPrecioActual.TabIndex = 4;
            this.lblPrecioActual.Text = "Precio Actual:";
            // 
            // lblDescripcionVar
            // 
            this.lblDescripcionVar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescripcionVar.Location = new System.Drawing.Point(91, 102);
            this.lblDescripcionVar.Name = "lblDescripcionVar";
            this.lblDescripcionVar.Size = new System.Drawing.Size(181, 76);
            this.lblDescripcionVar.TabIndex = 3;
            this.lblDescripcionVar.Text = "Seleccione Artículo";
            this.lblDescripcionVar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 133);
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
            this.lblFechaActualizacion.Location = new System.Drawing.Point(3, 284);
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
            this.tblLayoutPanelDataGrids.Controls.Add(this.gbxArticulosPedido, 0, 0);
            this.tblLayoutPanelDataGrids.Controls.Add(this.gbxArticulosDevolucion, 0, 1);
            this.tblLayoutPanelDataGrids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDataGrids.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelDataGrids.Name = "tblLayoutPanelDataGrids";
            this.tblLayoutPanelDataGrids.RowCount = 2;
            this.tblLayoutPanelDataGrids.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDataGrids.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDataGrids.Size = new System.Drawing.Size(602, 501);
            this.tblLayoutPanelDataGrids.TabIndex = 25;
            // 
            // gbxArticulosPedido
            // 
            this.gbxArticulosPedido.Controls.Add(this.tblLayoutPanelBuscarPedido);
            this.gbxArticulosPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxArticulosPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxArticulosPedido.Location = new System.Drawing.Point(3, 3);
            this.gbxArticulosPedido.Name = "gbxArticulosPedido";
            this.gbxArticulosPedido.Size = new System.Drawing.Size(596, 244);
            this.gbxArticulosPedido.TabIndex = 23;
            this.gbxArticulosPedido.TabStop = false;
            this.gbxArticulosPedido.Text = "Artículos del Pedido";
            // 
            // tblLayoutPanelBuscarPedido
            // 
            this.tblLayoutPanelBuscarPedido.ColumnCount = 1;
            this.tblLayoutPanelBuscarPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelBuscarPedido.Controls.Add(this.dgvArticulosPedido, 0, 1);
            this.tblLayoutPanelBuscarPedido.Controls.Add(this.tblLayoutPanelCuadroBusqueda, 0, 0);
            this.tblLayoutPanelBuscarPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelBuscarPedido.Location = new System.Drawing.Point(3, 19);
            this.tblLayoutPanelBuscarPedido.Name = "tblLayoutPanelBuscarPedido";
            this.tblLayoutPanelBuscarPedido.RowCount = 2;
            this.tblLayoutPanelBuscarPedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.32258F));
            this.tblLayoutPanelBuscarPedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.67742F));
            this.tblLayoutPanelBuscarPedido.Size = new System.Drawing.Size(590, 222);
            this.tblLayoutPanelBuscarPedido.TabIndex = 0;
            // 
            // dgvArticulosPedido
            // 
            this.dgvArticulosPedido.AllowUserToAddRows = false;
            this.dgvArticulosPedido.AllowUserToDeleteRows = false;
            this.dgvArticulosPedido.AllowUserToResizeRows = false;
            this.dgvArticulosPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dgvArticulosPedido.Location = new System.Drawing.Point(3, 37);
            this.dgvArticulosPedido.Name = "dgvArticulosPedido";
            this.dgvArticulosPedido.ReadOnly = true;
            this.dgvArticulosPedido.RowHeadersVisible = false;
            this.dgvArticulosPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulosPedido.Size = new System.Drawing.Size(584, 182);
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
            this.tblLayoutPanelCuadroBusqueda.ColumnCount = 3;
            this.tblLayoutPanelCuadroBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tblLayoutPanelCuadroBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelCuadroBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLayoutPanelCuadroBusqueda.Controls.Add(this.lblCAE, 0, 0);
            this.tblLayoutPanelCuadroBusqueda.Controls.Add(this.lblLupa, 2, 0);
            this.tblLayoutPanelCuadroBusqueda.Controls.Add(this.txtCAE, 1, 0);
            this.tblLayoutPanelCuadroBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelCuadroBusqueda.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelCuadroBusqueda.Name = "tblLayoutPanelCuadroBusqueda";
            this.tblLayoutPanelCuadroBusqueda.RowCount = 1;
            this.tblLayoutPanelCuadroBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelCuadroBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tblLayoutPanelCuadroBusqueda.Size = new System.Drawing.Size(584, 28);
            this.tblLayoutPanelCuadroBusqueda.TabIndex = 0;
            // 
            // lblCAE
            // 
            this.lblCAE.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCAE.AutoSize = true;
            this.lblCAE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCAE.Location = new System.Drawing.Point(12, 6);
            this.lblCAE.Name = "lblCAE";
            this.lblCAE.Size = new System.Drawing.Size(38, 16);
            this.lblCAE.TabIndex = 5;
            this.lblCAE.Text = "CAE:";
            // 
            // lblLupa
            // 
            this.lblLupa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLupa.Image = ((System.Drawing.Image)(resources.GetObject("lblLupa.Image")));
            this.lblLupa.Location = new System.Drawing.Point(547, 0);
            this.lblLupa.Name = "lblLupa";
            this.lblLupa.Size = new System.Drawing.Size(32, 28);
            this.lblLupa.TabIndex = 8;
            this.lblLupa.Click += new System.EventHandler(this.lblLupa_Click);
            // 
            // txtCAE
            // 
            this.txtCAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCAE.Location = new System.Drawing.Point(56, 3);
            this.txtCAE.Name = "txtCAE";
            this.txtCAE.Size = new System.Drawing.Size(485, 23);
            this.txtCAE.TabIndex = 7;
            this.txtCAE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCAE_KeyPress);
            // 
            // gbxArticulosDevolucion
            // 
            this.gbxArticulosDevolucion.Controls.Add(this.dgvArticulosDevolucion);
            this.gbxArticulosDevolucion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxArticulosDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxArticulosDevolucion.Location = new System.Drawing.Point(3, 253);
            this.gbxArticulosDevolucion.Name = "gbxArticulosDevolucion";
            this.gbxArticulosDevolucion.Size = new System.Drawing.Size(596, 245);
            this.gbxArticulosDevolucion.TabIndex = 22;
            this.gbxArticulosDevolucion.TabStop = false;
            this.gbxArticulosDevolucion.Text = "Artículos a Devolver";
            // 
            // dgvArticulosDevolucion
            // 
            this.dgvArticulosDevolucion.AllowUserToAddRows = false;
            this.dgvArticulosDevolucion.AllowUserToDeleteRows = false;
            this.dgvArticulosDevolucion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dgvArticulosDevolucion.Size = new System.Drawing.Size(590, 224);
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
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(899, 573);
            this.Controls.Add(this.tblLayoutPanelBase);
            this.Name = "frmPedidoDevolucion";
            this.Text = "Devolucion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPedidoDevolucion_FormClosing);
            this.tblLayoutPanelBase.ResumeLayout(false);
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

        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelBase;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelBotones;
        private System.Windows.Forms.Button btnQuitar;
        internal System.Windows.Forms.Button btnQuitarTodos;
        internal System.Windows.Forms.Label lblTotalVar;
        internal System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelArticulos;
        private System.Windows.Forms.GroupBox gbxDetalleArticuloSeleccionado;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDetalleArticulo;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDetallesArticuloOpciones;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDetalleArticuloBotones;
        private System.Windows.Forms.NumericUpDown nmrcUpDownCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCantidad;
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
        internal System.Windows.Forms.TextBox txtCAE;
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
    }
}