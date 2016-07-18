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
            this.components = new System.ComponentModel.Container();
            this.tblLayoutPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxArticulo = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelArticulo = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigoOriginal = new System.Windows.Forms.Label();
            this.btnBuscarArticulo = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnModificarArticulo = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtBoxCodigoOriginal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.grpBoxProveedor = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelProveedor = new System.Windows.Forms.TableLayoutPanel();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblCodigoProveedor = new System.Windows.Forms.Label();
            this.btnBuscarProveedor = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnModificarProveedor = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtBoxCodigoProveedor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxRazonSocial = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.grpBoxStock = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelStock = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigoArticulo = new System.Windows.Forms.Label();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.nmrcUpDownStockMinimo = new System.Windows.Forms.NumericUpDown();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.nmrcUpDownStockActual = new System.Windows.Forms.NumericUpDown();
            this.txtBoxCodigoArticulo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxPrecioCompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxPrecioVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxUbicacion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chbxActivo = new System.Windows.Forms.CheckBox();
            this.grpBoxObservaciones = new System.Windows.Forms.GroupBox();
            this.rchTextBoxObservaciones = new System.Windows.Forms.RichTextBox();
            this.epCodigoOriginal = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCodigoProveedor = new System.Windows.Forms.ErrorProvider(this.components);
            this.epRazonSocialProveedor = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCodigoArticulo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPrecioCompra = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPrecioVenta = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUbicacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlBase = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderActual)).BeginInit();
            this.tblLayoutPanelPrincipal.SuspendLayout();
            this.grpBoxArticulo.SuspendLayout();
            this.tblLayoutPanelArticulo.SuspendLayout();
            this.grpBoxProveedor.SuspendLayout();
            this.tblLayoutPanelProveedor.SuspendLayout();
            this.grpBoxStock.SuspendLayout();
            this.tblLayoutPanelStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownStockMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownStockActual)).BeginInit();
            this.grpBoxObservaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigoOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigoProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRazonSocialProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigoArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrecioCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUbicacion)).BeginInit();
            this.pnlBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayoutPanelPrincipal
            // 
            this.tblLayoutPanelPrincipal.ColumnCount = 1;
            this.tblLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal.Controls.Add(this.grpBoxArticulo, 0, 0);
            this.tblLayoutPanelPrincipal.Controls.Add(this.grpBoxProveedor, 0, 1);
            this.tblLayoutPanelPrincipal.Controls.Add(this.grpBoxStock, 0, 2);
            this.tblLayoutPanelPrincipal.Controls.Add(this.grpBoxObservaciones, 0, 3);
            this.tblLayoutPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanelPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tblLayoutPanelPrincipal.Name = "tblLayoutPanelPrincipal";
            this.tblLayoutPanelPrincipal.RowCount = 4;
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal.Size = new System.Drawing.Size(955, 613);
            this.tblLayoutPanelPrincipal.TabIndex = 1;
            // 
            // grpBoxArticulo
            // 
            this.grpBoxArticulo.Controls.Add(this.tblLayoutPanelArticulo);
            this.grpBoxArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxArticulo.Location = new System.Drawing.Point(4, 4);
            this.grpBoxArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxArticulo.Name = "grpBoxArticulo";
            this.grpBoxArticulo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxArticulo.Size = new System.Drawing.Size(947, 140);
            this.grpBoxArticulo.TabIndex = 9;
            this.grpBoxArticulo.TabStop = false;
            this.grpBoxArticulo.Text = "Artículo";
            // 
            // tblLayoutPanelArticulo
            // 
            this.tblLayoutPanelArticulo.ColumnCount = 4;
            this.tblLayoutPanelArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tblLayoutPanelArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tblLayoutPanelArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tblLayoutPanelArticulo.Controls.Add(this.lblDescripcion, 0, 1);
            this.tblLayoutPanelArticulo.Controls.Add(this.lblCodigoOriginal, 0, 0);
            this.tblLayoutPanelArticulo.Controls.Add(this.btnBuscarArticulo, 3, 0);
            this.tblLayoutPanelArticulo.Controls.Add(this.btnModificarArticulo, 3, 1);
            this.tblLayoutPanelArticulo.Controls.Add(this.txtBoxCodigoOriginal, 1, 0);
            this.tblLayoutPanelArticulo.Controls.Add(this.txtBoxDescripcion, 1, 1);
            this.tblLayoutPanelArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelArticulo.Location = new System.Drawing.Point(4, 26);
            this.tblLayoutPanelArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tblLayoutPanelArticulo.Name = "tblLayoutPanelArticulo";
            this.tblLayoutPanelArticulo.RowCount = 2;
            this.tblLayoutPanelArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelArticulo.Size = new System.Drawing.Size(939, 110);
            this.tblLayoutPanelArticulo.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(46, 70);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(110, 24);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblCodigoOriginal
            // 
            this.lblCodigoOriginal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoOriginal.AutoSize = true;
            this.lblCodigoOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoOriginal.Location = new System.Drawing.Point(15, 15);
            this.lblCodigoOriginal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoOriginal.Name = "lblCodigoOriginal";
            this.lblCodigoOriginal.Size = new System.Drawing.Size(141, 24);
            this.lblCodigoOriginal.TabIndex = 4;
            this.lblCodigoOriginal.Text = "Código Original";
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarArticulo.AutoSize = true;
            this.btnBuscarArticulo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarArticulo.Depth = 0;
            this.btnBuscarArticulo.Location = new System.Drawing.Point(831, 9);
            this.btnBuscarArticulo.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnBuscarArticulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Primary = false;
            this.btnBuscarArticulo.Size = new System.Drawing.Size(103, 36);
            this.btnBuscarArticulo.TabIndex = 7;
            this.btnBuscarArticulo.Text = "Buscar";
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarArticulo.AutoSize = true;
            this.btnModificarArticulo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarArticulo.Depth = 0;
            this.btnModificarArticulo.Location = new System.Drawing.Point(831, 64);
            this.btnModificarArticulo.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnModificarArticulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Primary = false;
            this.btnModificarArticulo.Size = new System.Drawing.Size(103, 36);
            this.btnModificarArticulo.TabIndex = 8;
            this.btnModificarArticulo.Text = "Modificar";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // txtBoxCodigoOriginal
            // 
            this.txtBoxCodigoOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoOriginal.Depth = 0;
            this.txtBoxCodigoOriginal.Hint = "";
            this.txtBoxCodigoOriginal.Location = new System.Drawing.Point(164, 13);
            this.txtBoxCodigoOriginal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxCodigoOriginal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCodigoOriginal.Name = "txtBoxCodigoOriginal";
            this.txtBoxCodigoOriginal.PasswordChar = '\0';
            this.txtBoxCodigoOriginal.SelectedText = "";
            this.txtBoxCodigoOriginal.SelectionLength = 0;
            this.txtBoxCodigoOriginal.SelectionStart = 0;
            this.txtBoxCodigoOriginal.Size = new System.Drawing.Size(625, 28);
            this.txtBoxCodigoOriginal.TabIndex = 9;
            this.txtBoxCodigoOriginal.UseSystemPasswordChar = false;
            this.txtBoxCodigoOriginal.Leave += new System.EventHandler(this.txtBoxCodigoOriginal_Leave);
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescripcion.Depth = 0;
            this.txtBoxDescripcion.Hint = "";
            this.txtBoxDescripcion.Location = new System.Drawing.Point(164, 68);
            this.txtBoxDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.PasswordChar = '\0';
            this.txtBoxDescripcion.SelectedText = "";
            this.txtBoxDescripcion.SelectionLength = 0;
            this.txtBoxDescripcion.SelectionStart = 0;
            this.txtBoxDescripcion.Size = new System.Drawing.Size(625, 28);
            this.txtBoxDescripcion.TabIndex = 10;
            this.txtBoxDescripcion.UseSystemPasswordChar = false;
            this.txtBoxDescripcion.Leave += new System.EventHandler(this.txtBoxDescripcion_Leave);
            // 
            // grpBoxProveedor
            // 
            this.grpBoxProveedor.Controls.Add(this.tblLayoutPanelProveedor);
            this.grpBoxProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxProveedor.Location = new System.Drawing.Point(4, 152);
            this.grpBoxProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxProveedor.Name = "grpBoxProveedor";
            this.grpBoxProveedor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxProveedor.Size = new System.Drawing.Size(947, 140);
            this.grpBoxProveedor.TabIndex = 10;
            this.grpBoxProveedor.TabStop = false;
            this.grpBoxProveedor.Text = "Proveedor";
            // 
            // tblLayoutPanelProveedor
            // 
            this.tblLayoutPanelProveedor.ColumnCount = 4;
            this.tblLayoutPanelProveedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tblLayoutPanelProveedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelProveedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tblLayoutPanelProveedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tblLayoutPanelProveedor.Controls.Add(this.lblRazonSocial, 0, 1);
            this.tblLayoutPanelProveedor.Controls.Add(this.lblCodigoProveedor, 0, 0);
            this.tblLayoutPanelProveedor.Controls.Add(this.btnBuscarProveedor, 3, 0);
            this.tblLayoutPanelProveedor.Controls.Add(this.btnModificarProveedor, 3, 1);
            this.tblLayoutPanelProveedor.Controls.Add(this.txtBoxCodigoProveedor, 1, 0);
            this.tblLayoutPanelProveedor.Controls.Add(this.txtBoxRazonSocial, 1, 1);
            this.tblLayoutPanelProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelProveedor.Location = new System.Drawing.Point(4, 26);
            this.tblLayoutPanelProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tblLayoutPanelProveedor.Name = "tblLayoutPanelProveedor";
            this.tblLayoutPanelProveedor.RowCount = 2;
            this.tblLayoutPanelProveedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelProveedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelProveedor.Size = new System.Drawing.Size(939, 110);
            this.tblLayoutPanelProveedor.TabIndex = 0;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(36, 70);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(120, 24);
            this.lblRazonSocial.TabIndex = 6;
            this.lblRazonSocial.Text = "Razón Social";
            // 
            // lblCodigoProveedor
            // 
            this.lblCodigoProveedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoProveedor.AutoSize = true;
            this.lblCodigoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProveedor.Location = new System.Drawing.Point(85, 15);
            this.lblCodigoProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoProveedor.Name = "lblCodigoProveedor";
            this.lblCodigoProveedor.Size = new System.Drawing.Size(71, 24);
            this.lblCodigoProveedor.TabIndex = 5;
            this.lblCodigoProveedor.Text = "Código";
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarProveedor.AutoSize = true;
            this.btnBuscarProveedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarProveedor.Depth = 0;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(831, 9);
            this.btnBuscarProveedor.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnBuscarProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Primary = false;
            this.btnBuscarProveedor.Size = new System.Drawing.Size(103, 36);
            this.btnBuscarProveedor.TabIndex = 8;
            this.btnBuscarProveedor.Text = "Buscar";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarProveedor.AutoSize = true;
            this.btnModificarProveedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarProveedor.Depth = 0;
            this.btnModificarProveedor.Location = new System.Drawing.Point(831, 64);
            this.btnModificarProveedor.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnModificarProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Primary = false;
            this.btnModificarProveedor.Size = new System.Drawing.Size(103, 36);
            this.btnModificarProveedor.TabIndex = 9;
            this.btnModificarProveedor.Text = "Modificar";
            this.btnModificarProveedor.UseVisualStyleBackColor = true;
            this.btnModificarProveedor.Click += new System.EventHandler(this.btnModificarProveedor_Click);
            // 
            // txtBoxCodigoProveedor
            // 
            this.txtBoxCodigoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoProveedor.Depth = 0;
            this.txtBoxCodigoProveedor.Hint = "";
            this.txtBoxCodigoProveedor.Location = new System.Drawing.Point(164, 13);
            this.txtBoxCodigoProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxCodigoProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCodigoProveedor.Name = "txtBoxCodigoProveedor";
            this.txtBoxCodigoProveedor.PasswordChar = '\0';
            this.txtBoxCodigoProveedor.SelectedText = "";
            this.txtBoxCodigoProveedor.SelectionLength = 0;
            this.txtBoxCodigoProveedor.SelectionStart = 0;
            this.txtBoxCodigoProveedor.Size = new System.Drawing.Size(625, 28);
            this.txtBoxCodigoProveedor.TabIndex = 10;
            this.txtBoxCodigoProveedor.UseSystemPasswordChar = false;
            this.txtBoxCodigoProveedor.Leave += new System.EventHandler(this.txtBoxCodigoProveedor_Leave);
            // 
            // txtBoxRazonSocial
            // 
            this.txtBoxRazonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxRazonSocial.Depth = 0;
            this.txtBoxRazonSocial.Hint = "";
            this.txtBoxRazonSocial.Location = new System.Drawing.Point(164, 68);
            this.txtBoxRazonSocial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxRazonSocial.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxRazonSocial.Name = "txtBoxRazonSocial";
            this.txtBoxRazonSocial.PasswordChar = '\0';
            this.txtBoxRazonSocial.SelectedText = "";
            this.txtBoxRazonSocial.SelectionLength = 0;
            this.txtBoxRazonSocial.SelectionStart = 0;
            this.txtBoxRazonSocial.Size = new System.Drawing.Size(625, 28);
            this.txtBoxRazonSocial.TabIndex = 11;
            this.txtBoxRazonSocial.UseSystemPasswordChar = false;
            this.txtBoxRazonSocial.Leave += new System.EventHandler(this.txtBoxRazonSocial_Leave);
            // 
            // grpBoxStock
            // 
            this.grpBoxStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpBoxStock.Controls.Add(this.tblLayoutPanelStock);
            this.grpBoxStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxStock.Location = new System.Drawing.Point(98, 300);
            this.grpBoxStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxStock.Name = "grpBoxStock";
            this.grpBoxStock.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxStock.Size = new System.Drawing.Size(759, 214);
            this.grpBoxStock.TabIndex = 11;
            this.grpBoxStock.TabStop = false;
            this.grpBoxStock.Text = "Stock";
            // 
            // tblLayoutPanelStock
            // 
            this.tblLayoutPanelStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tblLayoutPanelStock.ColumnCount = 4;
            this.tblLayoutPanelStock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tblLayoutPanelStock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tblLayoutPanelStock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tblLayoutPanelStock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelStock.Controls.Add(this.lblCodigoArticulo, 0, 1);
            this.tblLayoutPanelStock.Controls.Add(this.lblStockActual, 0, 2);
            this.tblLayoutPanelStock.Controls.Add(this.lblStockMinimo, 0, 3);
            this.tblLayoutPanelStock.Controls.Add(this.nmrcUpDownStockMinimo, 1, 3);
            this.tblLayoutPanelStock.Controls.Add(this.lblUbicacion, 2, 3);
            this.tblLayoutPanelStock.Controls.Add(this.lblPrecioCompra, 2, 1);
            this.tblLayoutPanelStock.Controls.Add(this.lblPrecioVenta, 2, 2);
            this.tblLayoutPanelStock.Controls.Add(this.nmrcUpDownStockActual, 1, 2);
            this.tblLayoutPanelStock.Controls.Add(this.txtBoxCodigoArticulo, 1, 1);
            this.tblLayoutPanelStock.Controls.Add(this.txtBoxPrecioCompra, 3, 1);
            this.tblLayoutPanelStock.Controls.Add(this.txtBoxPrecioVenta, 3, 2);
            this.tblLayoutPanelStock.Controls.Add(this.txtBoxUbicacion, 3, 3);
            this.tblLayoutPanelStock.Controls.Add(this.chbxActivo, 3, 0);
            this.tblLayoutPanelStock.Location = new System.Drawing.Point(48, 25);
            this.tblLayoutPanelStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tblLayoutPanelStock.Name = "tblLayoutPanelStock";
            this.tblLayoutPanelStock.RowCount = 4;
            this.tblLayoutPanelStock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.61415F));
            this.tblLayoutPanelStock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.79528F));
            this.tblLayoutPanelStock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.79529F));
            this.tblLayoutPanelStock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.79528F));
            this.tblLayoutPanelStock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblLayoutPanelStock.Size = new System.Drawing.Size(664, 186);
            this.tblLayoutPanelStock.TabIndex = 0;
            // 
            // lblCodigoArticulo
            // 
            this.lblCodigoArticulo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoArticulo.AutoSize = true;
            this.lblCodigoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoArticulo.Location = new System.Drawing.Point(17, 48);
            this.lblCodigoArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoArticulo.Name = "lblCodigoArticulo";
            this.lblCodigoArticulo.Size = new System.Drawing.Size(139, 24);
            this.lblCodigoArticulo.TabIndex = 7;
            this.lblCodigoArticulo.Text = "Código Artículo";
            // 
            // lblStockActual
            // 
            this.lblStockActual.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockActual.Location = new System.Drawing.Point(43, 97);
            this.lblStockActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(113, 24);
            this.lblStockActual.TabIndex = 9;
            this.lblStockActual.Text = "Stock Actual";
            this.lblStockActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMinimo.Location = new System.Drawing.Point(33, 148);
            this.lblStockMinimo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(123, 24);
            this.lblStockMinimo.TabIndex = 10;
            this.lblStockMinimo.Text = "Stock Mínimo";
            this.lblStockMinimo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nmrcUpDownStockMinimo
            // 
            this.nmrcUpDownStockMinimo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nmrcUpDownStockMinimo.Location = new System.Drawing.Point(164, 145);
            this.nmrcUpDownStockMinimo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmrcUpDownStockMinimo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrcUpDownStockMinimo.Name = "nmrcUpDownStockMinimo";
            this.nmrcUpDownStockMinimo.Size = new System.Drawing.Size(92, 29);
            this.nmrcUpDownStockMinimo.TabIndex = 12;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(362, 148);
            this.lblUbicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(94, 24);
            this.lblUbicacion.TabIndex = 7;
            this.lblUbicacion.Text = "Ubicación";
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCompra.Location = new System.Drawing.Point(320, 48);
            this.lblPrecioCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(136, 24);
            this.lblPrecioCompra.TabIndex = 14;
            this.lblPrecioCompra.Text = "Precio Compra";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.Location = new System.Drawing.Point(338, 97);
            this.lblPrecioVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(118, 24);
            this.lblPrecioVenta.TabIndex = 13;
            this.lblPrecioVenta.Text = "Precio Venta";
            // 
            // nmrcUpDownStockActual
            // 
            this.nmrcUpDownStockActual.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nmrcUpDownStockActual.Location = new System.Drawing.Point(164, 95);
            this.nmrcUpDownStockActual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmrcUpDownStockActual.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrcUpDownStockActual.Name = "nmrcUpDownStockActual";
            this.nmrcUpDownStockActual.Size = new System.Drawing.Size(92, 29);
            this.nmrcUpDownStockActual.TabIndex = 11;
            // 
            // txtBoxCodigoArticulo
            // 
            this.txtBoxCodigoArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoArticulo.Depth = 0;
            this.txtBoxCodigoArticulo.Hint = "";
            this.txtBoxCodigoArticulo.Location = new System.Drawing.Point(164, 46);
            this.txtBoxCodigoArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxCodigoArticulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCodigoArticulo.Name = "txtBoxCodigoArticulo";
            this.txtBoxCodigoArticulo.PasswordChar = '\0';
            this.txtBoxCodigoArticulo.SelectedText = "";
            this.txtBoxCodigoArticulo.SelectionLength = 0;
            this.txtBoxCodigoArticulo.SelectionStart = 0;
            this.txtBoxCodigoArticulo.Size = new System.Drawing.Size(119, 28);
            this.txtBoxCodigoArticulo.TabIndex = 17;
            this.txtBoxCodigoArticulo.UseSystemPasswordChar = false;
            this.txtBoxCodigoArticulo.Leave += new System.EventHandler(this.txtBoxCodigoArticulo_Leave);
            // 
            // txtBoxPrecioCompra
            // 
            this.txtBoxPrecioCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPrecioCompra.Depth = 0;
            this.txtBoxPrecioCompra.Hint = "";
            this.txtBoxPrecioCompra.Location = new System.Drawing.Point(464, 46);
            this.txtBoxPrecioCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxPrecioCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxPrecioCompra.Name = "txtBoxPrecioCompra";
            this.txtBoxPrecioCompra.PasswordChar = '\0';
            this.txtBoxPrecioCompra.SelectedText = "";
            this.txtBoxPrecioCompra.SelectionLength = 0;
            this.txtBoxPrecioCompra.SelectionStart = 0;
            this.txtBoxPrecioCompra.Size = new System.Drawing.Size(196, 28);
            this.txtBoxPrecioCompra.TabIndex = 18;
            this.txtBoxPrecioCompra.UseSystemPasswordChar = false;
            this.txtBoxPrecioCompra.Leave += new System.EventHandler(this.txtBoxPrecioCompra_Leave);
            // 
            // txtBoxPrecioVenta
            // 
            this.txtBoxPrecioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPrecioVenta.Depth = 0;
            this.txtBoxPrecioVenta.Hint = "";
            this.txtBoxPrecioVenta.Location = new System.Drawing.Point(464, 95);
            this.txtBoxPrecioVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxPrecioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxPrecioVenta.Name = "txtBoxPrecioVenta";
            this.txtBoxPrecioVenta.PasswordChar = '\0';
            this.txtBoxPrecioVenta.SelectedText = "";
            this.txtBoxPrecioVenta.SelectionLength = 0;
            this.txtBoxPrecioVenta.SelectionStart = 0;
            this.txtBoxPrecioVenta.Size = new System.Drawing.Size(196, 28);
            this.txtBoxPrecioVenta.TabIndex = 19;
            this.txtBoxPrecioVenta.UseSystemPasswordChar = false;
            this.txtBoxPrecioVenta.Leave += new System.EventHandler(this.txtBoxPrecioVenta_Leave);
            // 
            // txtBoxUbicacion
            // 
            this.txtBoxUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxUbicacion.Depth = 0;
            this.txtBoxUbicacion.Hint = "";
            this.txtBoxUbicacion.Location = new System.Drawing.Point(464, 146);
            this.txtBoxUbicacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxUbicacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxUbicacion.Name = "txtBoxUbicacion";
            this.txtBoxUbicacion.PasswordChar = '\0';
            this.txtBoxUbicacion.SelectedText = "";
            this.txtBoxUbicacion.SelectionLength = 0;
            this.txtBoxUbicacion.SelectionStart = 0;
            this.txtBoxUbicacion.Size = new System.Drawing.Size(196, 28);
            this.txtBoxUbicacion.TabIndex = 20;
            this.txtBoxUbicacion.UseSystemPasswordChar = false;
            this.txtBoxUbicacion.Leave += new System.EventHandler(this.txtBoxUbicacion_Leave);
            // 
            // chbxActivo
            // 
            this.chbxActivo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chbxActivo.AutoSize = true;
            this.chbxActivo.Location = new System.Drawing.Point(464, 4);
            this.chbxActivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbxActivo.Name = "chbxActivo";
            this.chbxActivo.Size = new System.Drawing.Size(83, 28);
            this.chbxActivo.TabIndex = 22;
            this.chbxActivo.Text = "Activo";
            this.chbxActivo.UseVisualStyleBackColor = true;
            // 
            // grpBoxObservaciones
            // 
            this.grpBoxObservaciones.Controls.Add(this.rchTextBoxObservaciones);
            this.grpBoxObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxObservaciones.Location = new System.Drawing.Point(4, 522);
            this.grpBoxObservaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxObservaciones.Name = "grpBoxObservaciones";
            this.grpBoxObservaciones.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxObservaciones.Size = new System.Drawing.Size(947, 87);
            this.grpBoxObservaciones.TabIndex = 8;
            this.grpBoxObservaciones.TabStop = false;
            this.grpBoxObservaciones.Text = "Observaciones";
            // 
            // rchTextBoxObservaciones
            // 
            this.rchTextBoxObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchTextBoxObservaciones.Location = new System.Drawing.Point(4, 26);
            this.rchTextBoxObservaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rchTextBoxObservaciones.Name = "rchTextBoxObservaciones";
            this.rchTextBoxObservaciones.Size = new System.Drawing.Size(939, 57);
            this.rchTextBoxObservaciones.TabIndex = 22;
            this.rchTextBoxObservaciones.Text = "";
            // 
            // epCodigoOriginal
            // 
            this.epCodigoOriginal.ContainerControl = this;
            // 
            // epDescripcion
            // 
            this.epDescripcion.ContainerControl = this;
            // 
            // epCodigoProveedor
            // 
            this.epCodigoProveedor.ContainerControl = this;
            // 
            // epRazonSocialProveedor
            // 
            this.epRazonSocialProveedor.ContainerControl = this;
            // 
            // epCodigoArticulo
            // 
            this.epCodigoArticulo.ContainerControl = this;
            // 
            // epPrecioCompra
            // 
            this.epPrecioCompra.ContainerControl = this;
            // 
            // epPrecioVenta
            // 
            this.epPrecioVenta.ContainerControl = this;
            // 
            // epUbicacion
            // 
            this.epUbicacion.ContainerControl = this;
            // 
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.tblLayoutPanelPrincipal);
            this.pnlBase.Location = new System.Drawing.Point(29, 91);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(955, 613);
            this.pnlBase.TabIndex = 2;
            // 
            // frmABMArticuloProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 716);
            this.Controls.Add(this.pnlBase);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MinimumSize = new System.Drawing.Size(600, 688);
            this.Name = "frmABMArticuloProveedor";
            this.Text = "Articulo Proveedor";
            this.Controls.SetChildIndex(this.pnlBase, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderActual)).EndInit();
            this.tblLayoutPanelPrincipal.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.epCodigoOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigoProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRazonSocialProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigoArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrecioCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUbicacion)).EndInit();
            this.pnlBase.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelPrincipal;
        private System.Windows.Forms.GroupBox grpBoxArticulo;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelArticulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCodigoOriginal;
        private System.Windows.Forms.GroupBox grpBoxProveedor;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelProveedor;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblCodigoProveedor;
        private System.Windows.Forms.GroupBox grpBoxStock;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelStock;
        private System.Windows.Forms.Label lblCodigoArticulo;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.GroupBox grpBoxObservaciones;
        private System.Windows.Forms.RichTextBox rchTextBoxObservaciones;
        private System.Windows.Forms.NumericUpDown nmrcUpDownStockMinimo;
        private System.Windows.Forms.NumericUpDown nmrcUpDownStockActual;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.Label lblPrecioVenta;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarArticulo;
        private MaterialSkin.Controls.MaterialFlatButton btnModificarArticulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCodigoOriginal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxDescripcion;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarProveedor;
        private MaterialSkin.Controls.MaterialFlatButton btnModificarProveedor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCodigoProveedor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxRazonSocial;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCodigoArticulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxPrecioCompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxPrecioVenta;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxUbicacion;
        private System.Windows.Forms.ErrorProvider epCodigoOriginal;
        private System.Windows.Forms.ErrorProvider epDescripcion;
        private System.Windows.Forms.ErrorProvider epCodigoProveedor;
        private System.Windows.Forms.ErrorProvider epRazonSocialProveedor;
        private System.Windows.Forms.ErrorProvider epCodigoArticulo;
        private System.Windows.Forms.ErrorProvider epPrecioCompra;
        private System.Windows.Forms.ErrorProvider epPrecioVenta;
        private System.Windows.Forms.ErrorProvider epUbicacion;
        private System.Windows.Forms.CheckBox chbxActivo;
        private System.Windows.Forms.Panel pnlBase;
    }
}