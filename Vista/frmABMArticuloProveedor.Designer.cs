namespace Vista
{
    partial class frmABMArticuloProveedor
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxArticulo = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelArticulo = new System.Windows.Forms.TableLayoutPanel();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.txtBoxCodigoOriginal = new System.Windows.Forms.TextBox();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.lblCodigoOriginal = new System.Windows.Forms.Label();
            this.grpBoxProveedor = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelProveedor = new System.Windows.Forms.TableLayoutPanel();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblCodigoProveedor = new System.Windows.Forms.Label();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.txtBoxCodigoProveedor = new System.Windows.Forms.TextBox();
            this.txtBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.btnModificarProveedor = new System.Windows.Forms.Button();
            this.grpBoxStock = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelStock = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtBoxCodigoArticulo = new System.Windows.Forms.TextBox();
            this.lblCodigoArticulo = new System.Windows.Forms.Label();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.nmrcUpDownStockMinimo = new System.Windows.Forms.NumericUpDown();
            this.txtBoxUbicacion = new System.Windows.Forms.TextBox();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.txtBoxPrecioCompra = new System.Windows.Forms.TextBox();
            this.nmrcUpDownStockActual = new System.Windows.Forms.NumericUpDown();
            this.grpBoxObservaciones = new System.Windows.Forms.GroupBox();
            this.rchTextBoxObservaciones = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderActual)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpBoxArticulo.SuspendLayout();
            this.tblLayoutPanelArticulo.SuspendLayout();
            this.grpBoxProveedor.SuspendLayout();
            this.tblLayoutPanelProveedor.SuspendLayout();
            this.grpBoxStock.SuspendLayout();
            this.tblLayoutPanelStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownStockMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownStockActual)).BeginInit();
            this.grpBoxObservaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grpBoxArticulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpBoxProveedor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grpBoxStock, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.grpBoxObservaciones, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.58064F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.97581F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.08065F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 496);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // grpBoxArticulo
            // 
            this.grpBoxArticulo.Controls.Add(this.tblLayoutPanelArticulo);
            this.grpBoxArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxArticulo.Location = new System.Drawing.Point(3, 3);
            this.grpBoxArticulo.Name = "grpBoxArticulo";
            this.grpBoxArticulo.Size = new System.Drawing.Size(428, 106);
            this.grpBoxArticulo.TabIndex = 9;
            this.grpBoxArticulo.TabStop = false;
            this.grpBoxArticulo.Text = "Artículo";
            // 
            // tblLayoutPanelArticulo
            // 
            this.tblLayoutPanelArticulo.ColumnCount = 3;
            this.tblLayoutPanelArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLayoutPanelArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tblLayoutPanelArticulo.Controls.Add(this.btnModificarArticulo, 2, 1);
            this.tblLayoutPanelArticulo.Controls.Add(this.lblDescripcion, 0, 1);
            this.tblLayoutPanelArticulo.Controls.Add(this.btnBuscarArticulo, 2, 0);
            this.tblLayoutPanelArticulo.Controls.Add(this.txtBoxCodigoOriginal, 1, 0);
            this.tblLayoutPanelArticulo.Controls.Add(this.txtBoxDescripcion, 1, 1);
            this.tblLayoutPanelArticulo.Controls.Add(this.lblCodigoOriginal, 0, 0);
            this.tblLayoutPanelArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelArticulo.Location = new System.Drawing.Point(3, 20);
            this.tblLayoutPanelArticulo.Name = "tblLayoutPanelArticulo";
            this.tblLayoutPanelArticulo.RowCount = 2;
            this.tblLayoutPanelArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelArticulo.Size = new System.Drawing.Size(422, 83);
            this.tblLayoutPanelArticulo.TabIndex = 0;
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModificarArticulo.Location = new System.Drawing.Point(342, 47);
            this.btnModificarArticulo.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(77, 30);
            this.btnModificarArticulo.TabIndex = 6;
            this.btnModificarArticulo.Text = "Modificar";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(30, 53);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(87, 18);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción";
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscarArticulo.Location = new System.Drawing.Point(342, 5);
            this.btnBuscarArticulo.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(77, 30);
            this.btnBuscarArticulo.TabIndex = 0;
            this.btnBuscarArticulo.Text = "Buscar";
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click);
            // 
            // txtBoxCodigoOriginal
            // 
            this.txtBoxCodigoOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoOriginal.Location = new System.Drawing.Point(123, 8);
            this.txtBoxCodigoOriginal.Name = "txtBoxCodigoOriginal";
            this.txtBoxCodigoOriginal.Size = new System.Drawing.Size(211, 24);
            this.txtBoxCodigoOriginal.TabIndex = 2;
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescripcion.Location = new System.Drawing.Point(123, 50);
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(211, 24);
            this.txtBoxDescripcion.TabIndex = 3;
            // 
            // lblCodigoOriginal
            // 
            this.lblCodigoOriginal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoOriginal.AutoSize = true;
            this.lblCodigoOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoOriginal.Location = new System.Drawing.Point(7, 11);
            this.lblCodigoOriginal.Name = "lblCodigoOriginal";
            this.lblCodigoOriginal.Size = new System.Drawing.Size(110, 18);
            this.lblCodigoOriginal.TabIndex = 4;
            this.lblCodigoOriginal.Text = "Código Original";
            // 
            // grpBoxProveedor
            // 
            this.grpBoxProveedor.Controls.Add(this.tblLayoutPanelProveedor);
            this.grpBoxProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxProveedor.Location = new System.Drawing.Point(3, 115);
            this.grpBoxProveedor.Name = "grpBoxProveedor";
            this.grpBoxProveedor.Size = new System.Drawing.Size(428, 103);
            this.grpBoxProveedor.TabIndex = 10;
            this.grpBoxProveedor.TabStop = false;
            this.grpBoxProveedor.Text = "Proveedor";
            // 
            // tblLayoutPanelProveedor
            // 
            this.tblLayoutPanelProveedor.ColumnCount = 3;
            this.tblLayoutPanelProveedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLayoutPanelProveedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelProveedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tblLayoutPanelProveedor.Controls.Add(this.lblRazonSocial, 0, 1);
            this.tblLayoutPanelProveedor.Controls.Add(this.lblCodigoProveedor, 0, 0);
            this.tblLayoutPanelProveedor.Controls.Add(this.btnBuscarProveedor, 2, 0);
            this.tblLayoutPanelProveedor.Controls.Add(this.txtBoxCodigoProveedor, 1, 0);
            this.tblLayoutPanelProveedor.Controls.Add(this.txtBoxRazonSocial, 1, 1);
            this.tblLayoutPanelProveedor.Controls.Add(this.btnModificarProveedor, 2, 1);
            this.tblLayoutPanelProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelProveedor.Location = new System.Drawing.Point(3, 20);
            this.tblLayoutPanelProveedor.Name = "tblLayoutPanelProveedor";
            this.tblLayoutPanelProveedor.RowCount = 2;
            this.tblLayoutPanelProveedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelProveedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelProveedor.Size = new System.Drawing.Size(422, 80);
            this.tblLayoutPanelProveedor.TabIndex = 0;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(20, 51);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(97, 18);
            this.lblRazonSocial.TabIndex = 6;
            this.lblRazonSocial.Text = "Razón Social";
            // 
            // lblCodigoProveedor
            // 
            this.lblCodigoProveedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoProveedor.AutoSize = true;
            this.lblCodigoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProveedor.Location = new System.Drawing.Point(61, 11);
            this.lblCodigoProveedor.Name = "lblCodigoProveedor";
            this.lblCodigoProveedor.Size = new System.Drawing.Size(56, 18);
            this.lblCodigoProveedor.TabIndex = 5;
            this.lblCodigoProveedor.Text = "Código";
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(342, 5);
            this.btnBuscarProveedor.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(77, 30);
            this.btnBuscarProveedor.TabIndex = 0;
            this.btnBuscarProveedor.Text = "Buscar";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // txtBoxCodigoProveedor
            // 
            this.txtBoxCodigoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoProveedor.Location = new System.Drawing.Point(123, 8);
            this.txtBoxCodigoProveedor.Name = "txtBoxCodigoProveedor";
            this.txtBoxCodigoProveedor.Size = new System.Drawing.Size(211, 24);
            this.txtBoxCodigoProveedor.TabIndex = 3;
            // 
            // txtBoxRazonSocial
            // 
            this.txtBoxRazonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxRazonSocial.Location = new System.Drawing.Point(123, 48);
            this.txtBoxRazonSocial.Name = "txtBoxRazonSocial";
            this.txtBoxRazonSocial.Size = new System.Drawing.Size(211, 24);
            this.txtBoxRazonSocial.TabIndex = 4;
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModificarProveedor.Location = new System.Drawing.Point(342, 45);
            this.btnModificarProveedor.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Size = new System.Drawing.Size(77, 30);
            this.btnModificarProveedor.TabIndex = 7;
            this.btnModificarProveedor.Text = "Modificar";
            this.btnModificarProveedor.UseVisualStyleBackColor = true;
            this.btnModificarProveedor.Click += new System.EventHandler(this.btnModificarProveedor_Click);
            // 
            // grpBoxStock
            // 
            this.grpBoxStock.Controls.Add(this.tblLayoutPanelStock);
            this.grpBoxStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxStock.Location = new System.Drawing.Point(3, 224);
            this.grpBoxStock.Name = "grpBoxStock";
            this.grpBoxStock.Size = new System.Drawing.Size(428, 168);
            this.grpBoxStock.TabIndex = 11;
            this.grpBoxStock.TabStop = false;
            this.grpBoxStock.Text = "Stock";
            // 
            // tblLayoutPanelStock
            // 
            this.tblLayoutPanelStock.ColumnCount = 4;
            this.tblLayoutPanelStock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLayoutPanelStock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tblLayoutPanelStock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tblLayoutPanelStock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelStock.Controls.Add(this.txtBoxPrecioVenta, 3, 1);
            this.tblLayoutPanelStock.Controls.Add(this.txtBoxCodigoArticulo, 1, 0);
            this.tblLayoutPanelStock.Controls.Add(this.lblCodigoArticulo, 0, 0);
            this.tblLayoutPanelStock.Controls.Add(this.lblStockActual, 0, 1);
            this.tblLayoutPanelStock.Controls.Add(this.lblStockMinimo, 0, 2);
            this.tblLayoutPanelStock.Controls.Add(this.nmrcUpDownStockMinimo, 1, 2);
            this.tblLayoutPanelStock.Controls.Add(this.txtBoxUbicacion, 3, 2);
            this.tblLayoutPanelStock.Controls.Add(this.lblUbicacion, 2, 2);
            this.tblLayoutPanelStock.Controls.Add(this.lblPrecioCompra, 2, 0);
            this.tblLayoutPanelStock.Controls.Add(this.lblPrecioVenta, 2, 1);
            this.tblLayoutPanelStock.Controls.Add(this.txtBoxPrecioCompra, 3, 0);
            this.tblLayoutPanelStock.Controls.Add(this.nmrcUpDownStockActual, 1, 1);
            this.tblLayoutPanelStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelStock.Location = new System.Drawing.Point(3, 20);
            this.tblLayoutPanelStock.Name = "tblLayoutPanelStock";
            this.tblLayoutPanelStock.RowCount = 3;
            this.tblLayoutPanelStock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.13979F));
            this.tblLayoutPanelStock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.86021F));
            this.tblLayoutPanelStock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tblLayoutPanelStock.Size = new System.Drawing.Size(422, 145);
            this.tblLayoutPanelStock.TabIndex = 0;
            // 
            // txtBoxPrecioVenta
            // 
            this.txtBoxPrecioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPrecioVenta.Location = new System.Drawing.Point(337, 62);
            this.txtBoxPrecioVenta.Name = "txtBoxPrecioVenta";
            this.txtBoxPrecioVenta.Size = new System.Drawing.Size(82, 24);
            this.txtBoxPrecioVenta.TabIndex = 16;
            this.txtBoxPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxCodigoArticulo
            // 
            this.txtBoxCodigoArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoArticulo.Location = new System.Drawing.Point(123, 15);
            this.txtBoxCodigoArticulo.Margin = new System.Windows.Forms.Padding(3, 3, 25, 3);
            this.txtBoxCodigoArticulo.Name = "txtBoxCodigoArticulo";
            this.txtBoxCodigoArticulo.Size = new System.Drawing.Size(69, 24);
            this.txtBoxCodigoArticulo.TabIndex = 6;
            // 
            // lblCodigoArticulo
            // 
            this.lblCodigoArticulo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoArticulo.AutoSize = true;
            this.lblCodigoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoArticulo.Location = new System.Drawing.Point(8, 18);
            this.lblCodigoArticulo.Name = "lblCodigoArticulo";
            this.lblCodigoArticulo.Size = new System.Drawing.Size(109, 18);
            this.lblCodigoArticulo.TabIndex = 7;
            this.lblCodigoArticulo.Text = "Código Artículo";
            // 
            // lblStockActual
            // 
            this.lblStockActual.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockActual.Location = new System.Drawing.Point(26, 65);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(91, 18);
            this.lblStockActual.TabIndex = 9;
            this.lblStockActual.Text = "Stock Actual";
            this.lblStockActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMinimo.Location = new System.Drawing.Point(17, 110);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(100, 18);
            this.lblStockMinimo.TabIndex = 10;
            this.lblStockMinimo.Text = "Stock Mínimo";
            this.lblStockMinimo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nmrcUpDownStockMinimo
            // 
            this.nmrcUpDownStockMinimo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nmrcUpDownStockMinimo.Location = new System.Drawing.Point(123, 107);
            this.nmrcUpDownStockMinimo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrcUpDownStockMinimo.Name = "nmrcUpDownStockMinimo";
            this.nmrcUpDownStockMinimo.Size = new System.Drawing.Size(69, 24);
            this.nmrcUpDownStockMinimo.TabIndex = 12;
            // 
            // txtBoxUbicacion
            // 
            this.txtBoxUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxUbicacion.Location = new System.Drawing.Point(337, 107);
            this.txtBoxUbicacion.Name = "txtBoxUbicacion";
            this.txtBoxUbicacion.Size = new System.Drawing.Size(82, 24);
            this.txtBoxUbicacion.TabIndex = 3;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(257, 110);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(74, 18);
            this.lblUbicacion.TabIndex = 7;
            this.lblUbicacion.Text = "Ubicación";
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCompra.Location = new System.Drawing.Point(222, 18);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(109, 18);
            this.lblPrecioCompra.TabIndex = 14;
            this.lblPrecioCompra.Text = "Precio Compra";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.Location = new System.Drawing.Point(239, 65);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(92, 18);
            this.lblPrecioVenta.TabIndex = 13;
            this.lblPrecioVenta.Text = "Precio Venta";
            // 
            // txtBoxPrecioCompra
            // 
            this.txtBoxPrecioCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPrecioCompra.Location = new System.Drawing.Point(337, 15);
            this.txtBoxPrecioCompra.Name = "txtBoxPrecioCompra";
            this.txtBoxPrecioCompra.Size = new System.Drawing.Size(82, 24);
            this.txtBoxPrecioCompra.TabIndex = 15;
            this.txtBoxPrecioCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nmrcUpDownStockActual
            // 
            this.nmrcUpDownStockActual.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nmrcUpDownStockActual.Location = new System.Drawing.Point(123, 62);
            this.nmrcUpDownStockActual.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrcUpDownStockActual.Name = "nmrcUpDownStockActual";
            this.nmrcUpDownStockActual.Size = new System.Drawing.Size(69, 24);
            this.nmrcUpDownStockActual.TabIndex = 11;
            // 
            // grpBoxObservaciones
            // 
            this.grpBoxObservaciones.Controls.Add(this.rchTextBoxObservaciones);
            this.grpBoxObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxObservaciones.Location = new System.Drawing.Point(3, 398);
            this.grpBoxObservaciones.Name = "grpBoxObservaciones";
            this.grpBoxObservaciones.Size = new System.Drawing.Size(428, 95);
            this.grpBoxObservaciones.TabIndex = 8;
            this.grpBoxObservaciones.TabStop = false;
            this.grpBoxObservaciones.Text = "Observaciones";
            // 
            // rchTextBoxObservaciones
            // 
            this.rchTextBoxObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchTextBoxObservaciones.Location = new System.Drawing.Point(3, 20);
            this.rchTextBoxObservaciones.Name = "rchTextBoxObservaciones";
            this.rchTextBoxObservaciones.Size = new System.Drawing.Size(422, 72);
            this.rchTextBoxObservaciones.TabIndex = 22;
            this.rchTextBoxObservaciones.Text = "";
            // 
            // frmABMArticuloProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 520);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(450, 559);
            this.Name = "frmABMArticuloProveedor";
            this.Text = "frmABMArticuloProveedor";
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderActual)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpBoxArticulo.ResumeLayout(false);
            this.tblLayoutPanelArticulo.ResumeLayout(false);
            this.tblLayoutPanelArticulo.PerformLayout();
            this.grpBoxProveedor.ResumeLayout(false);
            this.tblLayoutPanelProveedor.ResumeLayout(false);
            this.tblLayoutPanelProveedor.PerformLayout();
            this.grpBoxStock.ResumeLayout(false);
            this.tblLayoutPanelStock.ResumeLayout(false);
            this.tblLayoutPanelStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownStockMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownStockActual)).EndInit();
            this.grpBoxObservaciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpBoxArticulo;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelArticulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.TextBox txtBoxCodigoOriginal;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.Label lblCodigoOriginal;
        private System.Windows.Forms.GroupBox grpBoxProveedor;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelProveedor;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblCodigoProveedor;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.TextBox txtBoxCodigoProveedor;
        private System.Windows.Forms.TextBox txtBoxRazonSocial;
        private System.Windows.Forms.GroupBox grpBoxStock;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelStock;
        private System.Windows.Forms.TextBox txtBoxCodigoArticulo;
        private System.Windows.Forms.Label lblCodigoArticulo;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.TextBox txtBoxUbicacion;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.GroupBox grpBoxObservaciones;
        private System.Windows.Forms.RichTextBox rchTextBoxObservaciones;
        private System.Windows.Forms.NumericUpDown nmrcUpDownStockMinimo;
        private System.Windows.Forms.NumericUpDown nmrcUpDownStockActual;
        private System.Windows.Forms.TextBox txtBoxPrecioVenta;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.TextBox txtBoxPrecioCompra;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnModificarProveedor;
    }
}