namespace Vista
{
    partial class frmPedidoCierre_EditarLineaPedido
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
            this.tbleLayoutPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxArticulo = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelArticulo = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nmrcUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblValorParcialSinDescuento = new System.Windows.Forms.Label();
            this.lblValorParcialConDescuento = new System.Windows.Forms.Label();
            this.txtBoxValorUnitario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxValorParcialSinDescuento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxValorParcialConDescuento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tblLayoutPanelDescripcion = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtBoxDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.checkBoxStockNegativo = new MaterialSkin.Controls.MaterialCheckBox();
            this.tblLayoutPanelCodigos = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigoOriginal = new System.Windows.Forms.Label();
            this.lblCodigoArticuloProveedor = new System.Windows.Forms.Label();
            this.txtBoxCodigoOriginal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxCodigoArticuloProveedor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.grpBoxDescuentos = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelDescuentos = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelDescuentosDatos = new System.Windows.Forms.TableLayoutPanel();
            this.lblPorcentajeDescuento = new System.Windows.Forms.Label();
            this.lblDescuentoNeto = new System.Windows.Forms.Label();
            this.lblDescuentoDescripcion = new System.Windows.Forms.Label();
            this.txtBoxDescuentoDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxDescuentoNeto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxDescuentoPorcentaje = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgvDescuentos = new System.Windows.Forms.DataGridView();
            this.tblLayoutPanelDescuentosBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgrearDescuento = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnQuitarDescuento = new MaterialSkin.Controls.MaterialFlatButton();
            this.tblLayoutPanelBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnGuardar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.tbleLayoutPanelPrincipal.SuspendLayout();
            this.grpBoxArticulo.SuspendLayout();
            this.tblLayoutPanelArticulo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownCantidad)).BeginInit();
            this.tblLayoutPanelDescripcion.SuspendLayout();
            this.tblLayoutPanelCodigos.SuspendLayout();
            this.grpBoxDescuentos.SuspendLayout();
            this.tblLayoutPanelDescuentos.SuspendLayout();
            this.tblLayoutPanelDescuentosDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentos)).BeginInit();
            this.tblLayoutPanelDescuentosBotones.SuspendLayout();
            this.tblLayoutPanelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbleLayoutPanelPrincipal
            // 
            this.tbleLayoutPanelPrincipal.BackColor = System.Drawing.Color.White;
            this.tbleLayoutPanelPrincipal.ColumnCount = 1;
            this.tbleLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbleLayoutPanelPrincipal.Controls.Add(this.grpBoxArticulo, 0, 0);
            this.tbleLayoutPanelPrincipal.Controls.Add(this.grpBoxDescuentos, 0, 1);
            this.tbleLayoutPanelPrincipal.Controls.Add(this.tblLayoutPanelBotones, 0, 2);
            this.tbleLayoutPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbleLayoutPanelPrincipal.Location = new System.Drawing.Point(0, 64);
            this.tbleLayoutPanelPrincipal.Name = "tbleLayoutPanelPrincipal";
            this.tbleLayoutPanelPrincipal.RowCount = 3;
            this.tbleLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbleLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbleLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tbleLayoutPanelPrincipal.Size = new System.Drawing.Size(490, 435);
            this.tbleLayoutPanelPrincipal.TabIndex = 0;
            // 
            // grpBoxArticulo
            // 
            this.grpBoxArticulo.Controls.Add(this.tblLayoutPanelArticulo);
            this.grpBoxArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxArticulo.Location = new System.Drawing.Point(3, 3);
            this.grpBoxArticulo.Name = "grpBoxArticulo";
            this.grpBoxArticulo.Size = new System.Drawing.Size(484, 187);
            this.grpBoxArticulo.TabIndex = 0;
            this.grpBoxArticulo.TabStop = false;
            this.grpBoxArticulo.Text = "Articulo";
            // 
            // tblLayoutPanelArticulo
            // 
            this.tblLayoutPanelArticulo.ColumnCount = 1;
            this.tblLayoutPanelArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelArticulo.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tblLayoutPanelArticulo.Controls.Add(this.tblLayoutPanelDescripcion, 0, 1);
            this.tblLayoutPanelArticulo.Controls.Add(this.tblLayoutPanelCodigos, 0, 0);
            this.tblLayoutPanelArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelArticulo.Location = new System.Drawing.Point(3, 16);
            this.tblLayoutPanelArticulo.Name = "tblLayoutPanelArticulo";
            this.tblLayoutPanelArticulo.RowCount = 3;
            this.tblLayoutPanelArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblLayoutPanelArticulo.Size = new System.Drawing.Size(478, 168);
            this.tblLayoutPanelArticulo.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblPrecioUnitario, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCantidad, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.nmrcUpDownCantidad, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblValorParcialSinDescuento, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblValorParcialConDescuento, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxValorUnitario, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxValorParcialSinDescuento, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxValorParcialConDescuento, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 91);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(472, 74);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(27, 11);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(70, 13);
            this.lblPrecioUnitario.TabIndex = 2;
            this.lblPrecioUnitario.Text = "Valor Unitario";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(284, 11);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad";
            // 
            // nmrcUpDownCantidad
            // 
            this.nmrcUpDownCantidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nmrcUpDownCantidad.Location = new System.Drawing.Point(339, 7);
            this.nmrcUpDownCantidad.Name = "nmrcUpDownCantidad";
            this.nmrcUpDownCantidad.Size = new System.Drawing.Size(108, 20);
            this.nmrcUpDownCantidad.TabIndex = 5;
            this.nmrcUpDownCantidad.ValueChanged += new System.EventHandler(this.nmrcUpDownCantidad_ValueChanged);
            // 
            // lblValorParcialSinDescuento
            // 
            this.lblValorParcialSinDescuento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblValorParcialSinDescuento.AutoSize = true;
            this.lblValorParcialSinDescuento.Location = new System.Drawing.Point(13, 41);
            this.lblValorParcialSinDescuento.Name = "lblValorParcialSinDescuento";
            this.lblValorParcialSinDescuento.Size = new System.Drawing.Size(84, 26);
            this.lblValorParcialSinDescuento.TabIndex = 6;
            this.lblValorParcialSinDescuento.Text = "Valor Parcial Sin Descuento";
            this.lblValorParcialSinDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValorParcialConDescuento
            // 
            this.lblValorParcialConDescuento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblValorParcialConDescuento.AutoSize = true;
            this.lblValorParcialConDescuento.Location = new System.Drawing.Point(245, 41);
            this.lblValorParcialConDescuento.Name = "lblValorParcialConDescuento";
            this.lblValorParcialConDescuento.Size = new System.Drawing.Size(88, 26);
            this.lblValorParcialConDescuento.TabIndex = 7;
            this.lblValorParcialConDescuento.Text = "Valor Parcial Con Descuento";
            this.lblValorParcialConDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxValorUnitario
            // 
            this.txtBoxValorUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxValorUnitario.Depth = 0;
            this.txtBoxValorUnitario.Hint = "";
            this.txtBoxValorUnitario.Location = new System.Drawing.Point(103, 6);
            this.txtBoxValorUnitario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxValorUnitario.Name = "txtBoxValorUnitario";
            this.txtBoxValorUnitario.PasswordChar = '\0';
            this.txtBoxValorUnitario.SelectedText = "";
            this.txtBoxValorUnitario.SelectionLength = 0;
            this.txtBoxValorUnitario.SelectionStart = 0;
            this.txtBoxValorUnitario.Size = new System.Drawing.Size(130, 23);
            this.txtBoxValorUnitario.TabIndex = 4;
            this.txtBoxValorUnitario.UseSystemPasswordChar = false;
            this.txtBoxValorUnitario.Leave += new System.EventHandler(this.txtBoxValorUnitario_Leave);
            // 
            // txtBoxValorParcialSinDescuento
            // 
            this.txtBoxValorParcialSinDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxValorParcialSinDescuento.Depth = 0;
            this.txtBoxValorParcialSinDescuento.Hint = "";
            this.txtBoxValorParcialSinDescuento.Location = new System.Drawing.Point(103, 43);
            this.txtBoxValorParcialSinDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxValorParcialSinDescuento.Name = "txtBoxValorParcialSinDescuento";
            this.txtBoxValorParcialSinDescuento.PasswordChar = '\0';
            this.txtBoxValorParcialSinDescuento.SelectedText = "";
            this.txtBoxValorParcialSinDescuento.SelectionLength = 0;
            this.txtBoxValorParcialSinDescuento.SelectionStart = 0;
            this.txtBoxValorParcialSinDescuento.Size = new System.Drawing.Size(130, 23);
            this.txtBoxValorParcialSinDescuento.TabIndex = 6;
            this.txtBoxValorParcialSinDescuento.UseSystemPasswordChar = false;
            // 
            // txtBoxValorParcialConDescuento
            // 
            this.txtBoxValorParcialConDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxValorParcialConDescuento.Depth = 0;
            this.txtBoxValorParcialConDescuento.Hint = "";
            this.txtBoxValorParcialConDescuento.Location = new System.Drawing.Point(339, 43);
            this.txtBoxValorParcialConDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxValorParcialConDescuento.Name = "txtBoxValorParcialConDescuento";
            this.txtBoxValorParcialConDescuento.PasswordChar = '\0';
            this.txtBoxValorParcialConDescuento.SelectedText = "";
            this.txtBoxValorParcialConDescuento.SelectionLength = 0;
            this.txtBoxValorParcialConDescuento.SelectionStart = 0;
            this.txtBoxValorParcialConDescuento.Size = new System.Drawing.Size(130, 23);
            this.txtBoxValorParcialConDescuento.TabIndex = 7;
            this.txtBoxValorParcialConDescuento.UseSystemPasswordChar = false;
            // 
            // tblLayoutPanelDescripcion
            // 
            this.tblLayoutPanelDescripcion.ColumnCount = 3;
            this.tblLayoutPanelDescripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.14569F));
            this.tblLayoutPanelDescripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.85431F));
            this.tblLayoutPanelDescripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tblLayoutPanelDescripcion.Controls.Add(this.lblDescripcion, 0, 0);
            this.tblLayoutPanelDescripcion.Controls.Add(this.txtBoxDescripcion, 1, 0);
            this.tblLayoutPanelDescripcion.Controls.Add(this.checkBoxStockNegativo, 2, 0);
            this.tblLayoutPanelDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDescripcion.Location = new System.Drawing.Point(3, 47);
            this.tblLayoutPanelDescripcion.Name = "tblLayoutPanelDescripcion";
            this.tblLayoutPanelDescripcion.RowCount = 1;
            this.tblLayoutPanelDescripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDescripcion.Size = new System.Drawing.Size(472, 38);
            this.tblLayoutPanelDescripcion.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(13, 12);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescripcion.Depth = 0;
            this.txtBoxDescripcion.Hint = "";
            this.txtBoxDescripcion.Location = new System.Drawing.Point(82, 7);
            this.txtBoxDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.PasswordChar = '\0';
            this.txtBoxDescripcion.SelectedText = "";
            this.txtBoxDescripcion.SelectionLength = 0;
            this.txtBoxDescripcion.SelectionStart = 0;
            this.txtBoxDescripcion.Size = new System.Drawing.Size(196, 23);
            this.txtBoxDescripcion.TabIndex = 2;
            this.txtBoxDescripcion.UseSystemPasswordChar = false;
            // 
            // checkBoxStockNegativo
            // 
            this.checkBoxStockNegativo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxStockNegativo.AutoSize = true;
            this.checkBoxStockNegativo.Depth = 0;
            this.checkBoxStockNegativo.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkBoxStockNegativo.Location = new System.Drawing.Point(281, 4);
            this.checkBoxStockNegativo.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxStockNegativo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxStockNegativo.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxStockNegativo.Name = "checkBoxStockNegativo";
            this.checkBoxStockNegativo.Ripple = true;
            this.checkBoxStockNegativo.Size = new System.Drawing.Size(191, 30);
            this.checkBoxStockNegativo.TabIndex = 3;
            this.checkBoxStockNegativo.Text = "Permitir Stock Negativo";
            this.checkBoxStockNegativo.UseVisualStyleBackColor = true;
            this.checkBoxStockNegativo.CheckedChanged += new System.EventHandler(this.checkBoxStockNegativo_CheckedChanged);
            // 
            // tblLayoutPanelCodigos
            // 
            this.tblLayoutPanelCodigos.ColumnCount = 4;
            this.tblLayoutPanelCodigos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelCodigos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tblLayoutPanelCodigos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelCodigos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tblLayoutPanelCodigos.Controls.Add(this.lblCodigoOriginal, 0, 0);
            this.tblLayoutPanelCodigos.Controls.Add(this.lblCodigoArticuloProveedor, 2, 0);
            this.tblLayoutPanelCodigos.Controls.Add(this.txtBoxCodigoOriginal, 1, 0);
            this.tblLayoutPanelCodigos.Controls.Add(this.txtBoxCodigoArticuloProveedor, 3, 0);
            this.tblLayoutPanelCodigos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelCodigos.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelCodigos.Name = "tblLayoutPanelCodigos";
            this.tblLayoutPanelCodigos.RowCount = 1;
            this.tblLayoutPanelCodigos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelCodigos.Size = new System.Drawing.Size(472, 38);
            this.tblLayoutPanelCodigos.TabIndex = 4;
            // 
            // lblCodigoOriginal
            // 
            this.lblCodigoOriginal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoOriginal.AutoSize = true;
            this.lblCodigoOriginal.Location = new System.Drawing.Point(4, 12);
            this.lblCodigoOriginal.Name = "lblCodigoOriginal";
            this.lblCodigoOriginal.Size = new System.Drawing.Size(78, 13);
            this.lblCodigoOriginal.TabIndex = 0;
            this.lblCodigoOriginal.Text = "Código Original";
            // 
            // lblCodigoArticuloProveedor
            // 
            this.lblCodigoArticuloProveedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoArticuloProveedor.AutoSize = true;
            this.lblCodigoArticuloProveedor.Location = new System.Drawing.Point(239, 6);
            this.lblCodigoArticuloProveedor.Name = "lblCodigoArticuloProveedor";
            this.lblCodigoArticuloProveedor.Size = new System.Drawing.Size(78, 26);
            this.lblCodigoArticuloProveedor.TabIndex = 1;
            this.lblCodigoArticuloProveedor.Text = "Código Articulo Proveedor";
            // 
            // txtBoxCodigoOriginal
            // 
            this.txtBoxCodigoOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoOriginal.Depth = 0;
            this.txtBoxCodigoOriginal.Hint = "";
            this.txtBoxCodigoOriginal.Location = new System.Drawing.Point(88, 7);
            this.txtBoxCodigoOriginal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCodigoOriginal.Name = "txtBoxCodigoOriginal";
            this.txtBoxCodigoOriginal.PasswordChar = '\0';
            this.txtBoxCodigoOriginal.SelectedText = "";
            this.txtBoxCodigoOriginal.SelectionLength = 0;
            this.txtBoxCodigoOriginal.SelectionStart = 0;
            this.txtBoxCodigoOriginal.Size = new System.Drawing.Size(144, 23);
            this.txtBoxCodigoOriginal.TabIndex = 0;
            this.txtBoxCodigoOriginal.UseSystemPasswordChar = false;
            // 
            // txtBoxCodigoArticuloProveedor
            // 
            this.txtBoxCodigoArticuloProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoArticuloProveedor.Depth = 0;
            this.txtBoxCodigoArticuloProveedor.Hint = "";
            this.txtBoxCodigoArticuloProveedor.Location = new System.Drawing.Point(323, 7);
            this.txtBoxCodigoArticuloProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCodigoArticuloProveedor.Name = "txtBoxCodigoArticuloProveedor";
            this.txtBoxCodigoArticuloProveedor.PasswordChar = '\0';
            this.txtBoxCodigoArticuloProveedor.SelectedText = "";
            this.txtBoxCodigoArticuloProveedor.SelectionLength = 0;
            this.txtBoxCodigoArticuloProveedor.SelectionStart = 0;
            this.txtBoxCodigoArticuloProveedor.Size = new System.Drawing.Size(146, 23);
            this.txtBoxCodigoArticuloProveedor.TabIndex = 1;
            this.txtBoxCodigoArticuloProveedor.UseSystemPasswordChar = false;
            // 
            // grpBoxDescuentos
            // 
            this.grpBoxDescuentos.Controls.Add(this.tblLayoutPanelDescuentos);
            this.grpBoxDescuentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDescuentos.Location = new System.Drawing.Point(3, 196);
            this.grpBoxDescuentos.Name = "grpBoxDescuentos";
            this.grpBoxDescuentos.Size = new System.Drawing.Size(484, 187);
            this.grpBoxDescuentos.TabIndex = 1;
            this.grpBoxDescuentos.TabStop = false;
            this.grpBoxDescuentos.Text = "Descuentos";
            // 
            // tblLayoutPanelDescuentos
            // 
            this.tblLayoutPanelDescuentos.ColumnCount = 3;
            this.tblLayoutPanelDescuentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLayoutPanelDescuentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblLayoutPanelDescuentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblLayoutPanelDescuentos.Controls.Add(this.tblLayoutPanelDescuentosDatos, 0, 0);
            this.tblLayoutPanelDescuentos.Controls.Add(this.dgvDescuentos, 2, 0);
            this.tblLayoutPanelDescuentos.Controls.Add(this.tblLayoutPanelDescuentosBotones, 1, 0);
            this.tblLayoutPanelDescuentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDescuentos.Location = new System.Drawing.Point(3, 16);
            this.tblLayoutPanelDescuentos.Name = "tblLayoutPanelDescuentos";
            this.tblLayoutPanelDescuentos.RowCount = 1;
            this.tblLayoutPanelDescuentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDescuentos.Size = new System.Drawing.Size(478, 168);
            this.tblLayoutPanelDescuentos.TabIndex = 1;
            // 
            // tblLayoutPanelDescuentosDatos
            // 
            this.tblLayoutPanelDescuentosDatos.ColumnCount = 1;
            this.tblLayoutPanelDescuentosDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDescuentosDatos.Controls.Add(this.lblPorcentajeDescuento, 0, 4);
            this.tblLayoutPanelDescuentosDatos.Controls.Add(this.lblDescuentoNeto, 0, 2);
            this.tblLayoutPanelDescuentosDatos.Controls.Add(this.lblDescuentoDescripcion, 0, 0);
            this.tblLayoutPanelDescuentosDatos.Controls.Add(this.txtBoxDescuentoDescripcion, 0, 1);
            this.tblLayoutPanelDescuentosDatos.Controls.Add(this.txtBoxDescuentoNeto, 0, 3);
            this.tblLayoutPanelDescuentosDatos.Controls.Add(this.txtBoxDescuentoPorcentaje, 0, 5);
            this.tblLayoutPanelDescuentosDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDescuentosDatos.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelDescuentosDatos.Name = "tblLayoutPanelDescuentosDatos";
            this.tblLayoutPanelDescuentosDatos.RowCount = 6;
            this.tblLayoutPanelDescuentosDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLayoutPanelDescuentosDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLayoutPanelDescuentosDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLayoutPanelDescuentosDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLayoutPanelDescuentosDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLayoutPanelDescuentosDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLayoutPanelDescuentosDatos.Size = new System.Drawing.Size(145, 162);
            this.tblLayoutPanelDescuentosDatos.TabIndex = 4;
            // 
            // lblPorcentajeDescuento
            // 
            this.lblPorcentajeDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPorcentajeDescuento.AutoSize = true;
            this.lblPorcentajeDescuento.Location = new System.Drawing.Point(3, 117);
            this.lblPorcentajeDescuento.Name = "lblPorcentajeDescuento";
            this.lblPorcentajeDescuento.Size = new System.Drawing.Size(116, 13);
            this.lblPorcentajeDescuento.TabIndex = 3;
            this.lblPorcentajeDescuento.Text = "Porcentaje Descuento:";
            // 
            // lblDescuentoNeto
            // 
            this.lblDescuentoNeto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescuentoNeto.AutoSize = true;
            this.lblDescuentoNeto.Location = new System.Drawing.Point(3, 65);
            this.lblDescuentoNeto.Name = "lblDescuentoNeto";
            this.lblDescuentoNeto.Size = new System.Drawing.Size(88, 13);
            this.lblDescuentoNeto.TabIndex = 2;
            this.lblDescuentoNeto.Text = "Descuento Neto:";
            // 
            // lblDescuentoDescripcion
            // 
            this.lblDescuentoDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescuentoDescripcion.AutoSize = true;
            this.lblDescuentoDescripcion.Location = new System.Drawing.Point(3, 13);
            this.lblDescuentoDescripcion.Name = "lblDescuentoDescripcion";
            this.lblDescuentoDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescuentoDescripcion.TabIndex = 4;
            this.lblDescuentoDescripcion.Text = "Descripción:";
            // 
            // txtBoxDescuentoDescripcion
            // 
            this.txtBoxDescuentoDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescuentoDescripcion.Depth = 0;
            this.txtBoxDescuentoDescripcion.Hint = "";
            this.txtBoxDescuentoDescripcion.Location = new System.Drawing.Point(3, 29);
            this.txtBoxDescuentoDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDescuentoDescripcion.Name = "txtBoxDescuentoDescripcion";
            this.txtBoxDescuentoDescripcion.PasswordChar = '\0';
            this.txtBoxDescuentoDescripcion.SelectedText = "";
            this.txtBoxDescuentoDescripcion.SelectionLength = 0;
            this.txtBoxDescuentoDescripcion.SelectionStart = 0;
            this.txtBoxDescuentoDescripcion.Size = new System.Drawing.Size(139, 23);
            this.txtBoxDescuentoDescripcion.TabIndex = 8;
            this.txtBoxDescuentoDescripcion.UseSystemPasswordChar = false;
            // 
            // txtBoxDescuentoNeto
            // 
            this.txtBoxDescuentoNeto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescuentoNeto.Depth = 0;
            this.txtBoxDescuentoNeto.Hint = "";
            this.txtBoxDescuentoNeto.Location = new System.Drawing.Point(3, 81);
            this.txtBoxDescuentoNeto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDescuentoNeto.Name = "txtBoxDescuentoNeto";
            this.txtBoxDescuentoNeto.PasswordChar = '\0';
            this.txtBoxDescuentoNeto.SelectedText = "";
            this.txtBoxDescuentoNeto.SelectionLength = 0;
            this.txtBoxDescuentoNeto.SelectionStart = 0;
            this.txtBoxDescuentoNeto.Size = new System.Drawing.Size(139, 23);
            this.txtBoxDescuentoNeto.TabIndex = 9;
            this.txtBoxDescuentoNeto.UseSystemPasswordChar = false;
            // 
            // txtBoxDescuentoPorcentaje
            // 
            this.txtBoxDescuentoPorcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescuentoPorcentaje.Depth = 0;
            this.txtBoxDescuentoPorcentaje.Hint = "";
            this.txtBoxDescuentoPorcentaje.Location = new System.Drawing.Point(3, 134);
            this.txtBoxDescuentoPorcentaje.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDescuentoPorcentaje.Name = "txtBoxDescuentoPorcentaje";
            this.txtBoxDescuentoPorcentaje.PasswordChar = '\0';
            this.txtBoxDescuentoPorcentaje.SelectedText = "";
            this.txtBoxDescuentoPorcentaje.SelectionLength = 0;
            this.txtBoxDescuentoPorcentaje.SelectionStart = 0;
            this.txtBoxDescuentoPorcentaje.Size = new System.Drawing.Size(139, 23);
            this.txtBoxDescuentoPorcentaje.TabIndex = 10;
            this.txtBoxDescuentoPorcentaje.UseSystemPasswordChar = false;
            // 
            // dgvDescuentos
            // 
            this.dgvDescuentos.AllowUserToAddRows = false;
            this.dgvDescuentos.AllowUserToDeleteRows = false;
            this.dgvDescuentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDescuentos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescuentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDescuentos.GridColor = System.Drawing.Color.White;
            this.dgvDescuentos.Location = new System.Drawing.Point(254, 3);
            this.dgvDescuentos.Name = "dgvDescuentos";
            this.dgvDescuentos.ReadOnly = true;
            this.dgvDescuentos.RowHeadersVisible = false;
            this.dgvDescuentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDescuentos.Size = new System.Drawing.Size(221, 162);
            this.dgvDescuentos.TabIndex = 5;
            // 
            // tblLayoutPanelDescuentosBotones
            // 
            this.tblLayoutPanelDescuentosBotones.ColumnCount = 1;
            this.tblLayoutPanelDescuentosBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDescuentosBotones.Controls.Add(this.btnAgrearDescuento, 0, 0);
            this.tblLayoutPanelDescuentosBotones.Controls.Add(this.btnQuitarDescuento, 0, 1);
            this.tblLayoutPanelDescuentosBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDescuentosBotones.Location = new System.Drawing.Point(154, 3);
            this.tblLayoutPanelDescuentosBotones.Name = "tblLayoutPanelDescuentosBotones";
            this.tblLayoutPanelDescuentosBotones.RowCount = 2;
            this.tblLayoutPanelDescuentosBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDescuentosBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDescuentosBotones.Size = new System.Drawing.Size(94, 162);
            this.tblLayoutPanelDescuentosBotones.TabIndex = 3;
            // 
            // btnAgrearDescuento
            // 
            this.btnAgrearDescuento.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgrearDescuento.AutoSize = true;
            this.btnAgrearDescuento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgrearDescuento.Depth = 0;
            this.btnAgrearDescuento.Location = new System.Drawing.Point(10, 39);
            this.btnAgrearDescuento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgrearDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgrearDescuento.Name = "btnAgrearDescuento";
            this.btnAgrearDescuento.Primary = false;
            this.btnAgrearDescuento.Size = new System.Drawing.Size(74, 36);
            this.btnAgrearDescuento.TabIndex = 11;
            this.btnAgrearDescuento.Text = "Agregar";
            this.btnAgrearDescuento.UseVisualStyleBackColor = true;
            this.btnAgrearDescuento.Click += new System.EventHandler(this.btnAgrearDescuento_Click);
            // 
            // btnQuitarDescuento
            // 
            this.btnQuitarDescuento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuitarDescuento.AutoSize = true;
            this.btnQuitarDescuento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuitarDescuento.Depth = 0;
            this.btnQuitarDescuento.Location = new System.Drawing.Point(17, 87);
            this.btnQuitarDescuento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuitarDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitarDescuento.Name = "btnQuitarDescuento";
            this.btnQuitarDescuento.Primary = false;
            this.btnQuitarDescuento.Size = new System.Drawing.Size(60, 36);
            this.btnQuitarDescuento.TabIndex = 12;
            this.btnQuitarDescuento.Text = "Quitar";
            this.btnQuitarDescuento.UseVisualStyleBackColor = true;
            this.btnQuitarDescuento.Click += new System.EventHandler(this.btnQuitarDescuento_Click);
            // 
            // tblLayoutPanelBotones
            // 
            this.tblLayoutPanelBotones.ColumnCount = 2;
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelBotones.Controls.Add(this.btnGuardar, 0, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.btnCancelar, 1, 0);
            this.tblLayoutPanelBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelBotones.Location = new System.Drawing.Point(3, 389);
            this.tblLayoutPanelBotones.Name = "tblLayoutPanelBotones";
            this.tblLayoutPanelBotones.RowCount = 1;
            this.tblLayoutPanelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tblLayoutPanelBotones.Size = new System.Drawing.Size(484, 43);
            this.tblLayoutPanelBotones.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(83, 6);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = false;
            this.btnGuardar.Size = new System.Drawing.Size(75, 31);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(322, 6);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(82, 31);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmPedidoCierre_EditarLineaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 499);
            this.Controls.Add(this.tbleLayoutPanelPrincipal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPedidoCierre_EditarLineaPedido";
            this.Text = "Editar Linea Pedido";
            this.tbleLayoutPanelPrincipal.ResumeLayout(false);
            this.grpBoxArticulo.ResumeLayout(false);
            this.tblLayoutPanelArticulo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownCantidad)).EndInit();
            this.tblLayoutPanelDescripcion.ResumeLayout(false);
            this.tblLayoutPanelDescripcion.PerformLayout();
            this.tblLayoutPanelCodigos.ResumeLayout(false);
            this.tblLayoutPanelCodigos.PerformLayout();
            this.grpBoxDescuentos.ResumeLayout(false);
            this.tblLayoutPanelDescuentos.ResumeLayout(false);
            this.tblLayoutPanelDescuentosDatos.ResumeLayout(false);
            this.tblLayoutPanelDescuentosDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentos)).EndInit();
            this.tblLayoutPanelDescuentosBotones.ResumeLayout(false);
            this.tblLayoutPanelDescuentosBotones.PerformLayout();
            this.tblLayoutPanelBotones.ResumeLayout(false);
            this.tblLayoutPanelBotones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbleLayoutPanelPrincipal;
        private System.Windows.Forms.GroupBox grpBoxArticulo;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelArticulo;
        private System.Windows.Forms.GroupBox grpBoxDescuentos;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDescuentos;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelCodigos;
        private System.Windows.Forms.Label lblCodigoOriginal;
        private System.Windows.Forms.Label lblCodigoArticuloProveedor;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelBotones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nmrcUpDownCantidad;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDescuentosBotones;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDescuentosDatos;
        private System.Windows.Forms.Label lblPorcentajeDescuento;
        private System.Windows.Forms.Label lblDescuentoNeto;
        private System.Windows.Forms.DataGridView dgvDescuentos;
        private System.Windows.Forms.Label lblDescuentoDescripcion;
        private System.Windows.Forms.Label lblValorParcialSinDescuento;
        private System.Windows.Forms.Label lblValorParcialConDescuento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxValorUnitario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxValorParcialSinDescuento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxValorParcialConDescuento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxDescripcion;
        private MaterialSkin.Controls.MaterialCheckBox checkBoxStockNegativo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCodigoOriginal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCodigoArticuloProveedor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxDescuentoDescripcion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxDescuentoNeto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxDescuentoPorcentaje;
        private MaterialSkin.Controls.MaterialFlatButton btnAgrearDescuento;
        private MaterialSkin.Controls.MaterialFlatButton btnQuitarDescuento;
        private MaterialSkin.Controls.MaterialFlatButton btnGuardar;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
    }
}