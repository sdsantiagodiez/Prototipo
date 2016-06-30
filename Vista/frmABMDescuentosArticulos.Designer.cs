namespace Vista
{
    partial class frmDescuentosArticulos
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
            this.grpBoxDescuento = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxnumeroDescuento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxFechaHasta = new System.Windows.Forms.TextBox();
            this.tbxFechaDesde = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbxPorcentajeDescuento = new System.Windows.Forms.TextBox();
            this.grpBoxArticulo = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelArticulo = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigoOriginal = new System.Windows.Forms.Label();
            this.btnBuscarArticulo = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnModificarArticulo = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtBoxCodigoOriginal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.grpBoxArticuloProveedor = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelProveedor = new System.Windows.Forms.TableLayoutPanel();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblCodigoProveedor = new System.Windows.Forms.Label();
            this.btnBuscarArticuloProveedor = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnModificarProveedor = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtBoxCodigoArtculoProveedor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxDescripcionArticuloProveedor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.grpBoxListaDescuentos = new System.Windows.Forms.GroupBox();
            this.dgvDescuentos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderActual)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpBoxDescuento.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpBoxArticulo.SuspendLayout();
            this.tblLayoutPanelArticulo.SuspendLayout();
            this.grpBoxArticuloProveedor.SuspendLayout();
            this.tblLayoutPanelProveedor.SuspendLayout();
            this.grpBoxListaDescuentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grpBoxDescuento, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.grpBoxArticulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpBoxArticuloProveedor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grpBoxListaDescuentos, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 496);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // grpBoxDescuento
            // 
            this.grpBoxDescuento.Controls.Add(this.tableLayoutPanel2);
            this.grpBoxDescuento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDescuento.Location = new System.Drawing.Point(3, 243);
            this.grpBoxDescuento.Name = "grpBoxDescuento";
            this.grpBoxDescuento.Size = new System.Drawing.Size(444, 94);
            this.grpBoxDescuento.TabIndex = 11;
            this.grpBoxDescuento.TabStop = false;
            this.grpBoxDescuento.Text = "Descuento";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.tableLayoutPanel2.Controls.Add(this.tbxnumeroDescuento, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbxFechaHasta, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbxFechaDesde, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbxPorcentajeDescuento, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(438, 65);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tbxnumeroDescuento
            // 
            this.tbxnumeroDescuento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxnumeroDescuento.AutoSize = true;
            this.tbxnumeroDescuento.Location = new System.Drawing.Point(50, 7);
            this.tbxnumeroDescuento.Name = "tbxnumeroDescuento";
            this.tbxnumeroDescuento.Size = new System.Drawing.Size(56, 18);
            this.tbxnumeroDescuento.TabIndex = 4;
            this.tbxnumeroDescuento.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Hasta";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Desde";
            // 
            // tbxFechaHasta
            // 
            this.tbxFechaHasta.Location = new System.Drawing.Point(329, 35);
            this.tbxFechaHasta.Name = "tbxFechaHasta";
            this.tbxFechaHasta.Size = new System.Drawing.Size(92, 24);
            this.tbxFechaHasta.TabIndex = 2;
            this.tbxFechaHasta.Validating += new System.ComponentModel.CancelEventHandler(this.tbxFechaHasta_Validating);
            // 
            // tbxFechaDesde
            // 
            this.tbxFechaDesde.Location = new System.Drawing.Point(112, 35);
            this.tbxFechaDesde.Name = "tbxFechaDesde";
            this.tbxFechaDesde.Size = new System.Drawing.Size(92, 24);
            this.tbxFechaDesde.TabIndex = 3;
            this.tbxFechaDesde.Validating += new System.ComponentModel.CancelEventHandler(this.tbxFechaDesde_Validating);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Porcentaje";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 24);
            this.textBox1.TabIndex = 6;
            // 
            // tbxPorcentajeDescuento
            // 
            this.tbxPorcentajeDescuento.Location = new System.Drawing.Point(329, 3);
            this.tbxPorcentajeDescuento.Name = "tbxPorcentajeDescuento";
            this.tbxPorcentajeDescuento.Size = new System.Drawing.Size(92, 24);
            this.tbxPorcentajeDescuento.TabIndex = 7;
            // 
            // grpBoxArticulo
            // 
            this.grpBoxArticulo.Controls.Add(this.tblLayoutPanelArticulo);
            this.grpBoxArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxArticulo.Location = new System.Drawing.Point(3, 3);
            this.grpBoxArticulo.Name = "grpBoxArticulo";
            this.grpBoxArticulo.Size = new System.Drawing.Size(444, 114);
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
            this.tblLayoutPanelArticulo.Controls.Add(this.lblDescripcion, 0, 1);
            this.tblLayoutPanelArticulo.Controls.Add(this.lblCodigoOriginal, 0, 0);
            this.tblLayoutPanelArticulo.Controls.Add(this.btnBuscarArticulo, 2, 0);
            this.tblLayoutPanelArticulo.Controls.Add(this.btnModificarArticulo, 2, 1);
            this.tblLayoutPanelArticulo.Controls.Add(this.txtBoxCodigoOriginal, 1, 0);
            this.tblLayoutPanelArticulo.Controls.Add(this.txtBoxDescripcion, 1, 1);
            this.tblLayoutPanelArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelArticulo.Location = new System.Drawing.Point(3, 20);
            this.tblLayoutPanelArticulo.Name = "tblLayoutPanelArticulo";
            this.tblLayoutPanelArticulo.RowCount = 2;
            this.tblLayoutPanelArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelArticulo.Size = new System.Drawing.Size(438, 91);
            this.tblLayoutPanelArticulo.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(30, 59);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(87, 18);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblCodigoOriginal
            // 
            this.lblCodigoOriginal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoOriginal.AutoSize = true;
            this.lblCodigoOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoOriginal.Location = new System.Drawing.Point(7, 13);
            this.lblCodigoOriginal.Name = "lblCodigoOriginal";
            this.lblCodigoOriginal.Size = new System.Drawing.Size(110, 18);
            this.lblCodigoOriginal.TabIndex = 4;
            this.lblCodigoOriginal.Text = "Código Original";
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarArticulo.AutoSize = true;
            this.btnBuscarArticulo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarArticulo.Depth = 0;
            this.btnBuscarArticulo.Location = new System.Drawing.Point(357, 6);
            this.btnBuscarArticulo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarArticulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Primary = false;
            this.btnBuscarArticulo.Size = new System.Drawing.Size(77, 33);
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
            this.btnModificarArticulo.Location = new System.Drawing.Point(357, 51);
            this.btnModificarArticulo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificarArticulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Primary = false;
            this.btnModificarArticulo.Size = new System.Drawing.Size(77, 34);
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
            this.txtBoxCodigoOriginal.Location = new System.Drawing.Point(123, 11);
            this.txtBoxCodigoOriginal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCodigoOriginal.Name = "txtBoxCodigoOriginal";
            this.txtBoxCodigoOriginal.PasswordChar = '\0';
            this.txtBoxCodigoOriginal.SelectedText = "";
            this.txtBoxCodigoOriginal.SelectionLength = 0;
            this.txtBoxCodigoOriginal.SelectionStart = 0;
            this.txtBoxCodigoOriginal.Size = new System.Drawing.Size(227, 23);
            this.txtBoxCodigoOriginal.TabIndex = 9;
            this.txtBoxCodigoOriginal.UseSystemPasswordChar = false;
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescripcion.Depth = 0;
            this.txtBoxDescripcion.Hint = "";
            this.txtBoxDescripcion.Location = new System.Drawing.Point(123, 56);
            this.txtBoxDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.PasswordChar = '\0';
            this.txtBoxDescripcion.SelectedText = "";
            this.txtBoxDescripcion.SelectionLength = 0;
            this.txtBoxDescripcion.SelectionStart = 0;
            this.txtBoxDescripcion.Size = new System.Drawing.Size(227, 23);
            this.txtBoxDescripcion.TabIndex = 10;
            this.txtBoxDescripcion.UseSystemPasswordChar = false;
            // 
            // grpBoxArticuloProveedor
            // 
            this.grpBoxArticuloProveedor.Controls.Add(this.tblLayoutPanelProveedor);
            this.grpBoxArticuloProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxArticuloProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxArticuloProveedor.Location = new System.Drawing.Point(3, 123);
            this.grpBoxArticuloProveedor.Name = "grpBoxArticuloProveedor";
            this.grpBoxArticuloProveedor.Size = new System.Drawing.Size(444, 114);
            this.grpBoxArticuloProveedor.TabIndex = 10;
            this.grpBoxArticuloProveedor.TabStop = false;
            this.grpBoxArticuloProveedor.Text = "Articulo Proveedor";
            // 
            // tblLayoutPanelProveedor
            // 
            this.tblLayoutPanelProveedor.ColumnCount = 3;
            this.tblLayoutPanelProveedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLayoutPanelProveedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelProveedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tblLayoutPanelProveedor.Controls.Add(this.lblRazonSocial, 0, 1);
            this.tblLayoutPanelProveedor.Controls.Add(this.lblCodigoProveedor, 0, 0);
            this.tblLayoutPanelProveedor.Controls.Add(this.btnBuscarArticuloProveedor, 2, 0);
            this.tblLayoutPanelProveedor.Controls.Add(this.btnModificarProveedor, 2, 1);
            this.tblLayoutPanelProveedor.Controls.Add(this.txtBoxCodigoArtculoProveedor, 1, 0);
            this.tblLayoutPanelProveedor.Controls.Add(this.txtBoxDescripcionArticuloProveedor, 1, 1);
            this.tblLayoutPanelProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelProveedor.Location = new System.Drawing.Point(3, 20);
            this.tblLayoutPanelProveedor.Name = "tblLayoutPanelProveedor";
            this.tblLayoutPanelProveedor.RowCount = 2;
            this.tblLayoutPanelProveedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelProveedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelProveedor.Size = new System.Drawing.Size(438, 91);
            this.tblLayoutPanelProveedor.TabIndex = 0;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(30, 59);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(87, 18);
            this.lblRazonSocial.TabIndex = 6;
            this.lblRazonSocial.Text = "Descripcion";
            // 
            // lblCodigoProveedor
            // 
            this.lblCodigoProveedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoProveedor.AutoSize = true;
            this.lblCodigoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProveedor.Location = new System.Drawing.Point(61, 13);
            this.lblCodigoProveedor.Name = "lblCodigoProveedor";
            this.lblCodigoProveedor.Size = new System.Drawing.Size(56, 18);
            this.lblCodigoProveedor.TabIndex = 5;
            this.lblCodigoProveedor.Text = "Código";
            // 
            // btnBuscarArticuloProveedor
            // 
            this.btnBuscarArticuloProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarArticuloProveedor.AutoSize = true;
            this.btnBuscarArticuloProveedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarArticuloProveedor.Depth = 0;
            this.btnBuscarArticuloProveedor.Location = new System.Drawing.Point(357, 6);
            this.btnBuscarArticuloProveedor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarArticuloProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarArticuloProveedor.Name = "btnBuscarArticuloProveedor";
            this.btnBuscarArticuloProveedor.Primary = false;
            this.btnBuscarArticuloProveedor.Size = new System.Drawing.Size(77, 33);
            this.btnBuscarArticuloProveedor.TabIndex = 8;
            this.btnBuscarArticuloProveedor.Text = "Buscar";
            this.btnBuscarArticuloProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarArticuloProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarProveedor.AutoSize = true;
            this.btnModificarProveedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarProveedor.Depth = 0;
            this.btnModificarProveedor.Location = new System.Drawing.Point(357, 51);
            this.btnModificarProveedor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificarProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Primary = false;
            this.btnModificarProveedor.Size = new System.Drawing.Size(77, 34);
            this.btnModificarProveedor.TabIndex = 9;
            this.btnModificarProveedor.Text = "Modificar";
            this.btnModificarProveedor.UseVisualStyleBackColor = true;
            this.btnModificarProveedor.Click += new System.EventHandler(this.btnModificarProveedor_Click);
            // 
            // txtBoxCodigoArtculoProveedor
            // 
            this.txtBoxCodigoArtculoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoArtculoProveedor.Depth = 0;
            this.txtBoxCodigoArtculoProveedor.Hint = "";
            this.txtBoxCodigoArtculoProveedor.Location = new System.Drawing.Point(123, 11);
            this.txtBoxCodigoArtculoProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCodigoArtculoProveedor.Name = "txtBoxCodigoArtculoProveedor";
            this.txtBoxCodigoArtculoProveedor.PasswordChar = '\0';
            this.txtBoxCodigoArtculoProveedor.SelectedText = "";
            this.txtBoxCodigoArtculoProveedor.SelectionLength = 0;
            this.txtBoxCodigoArtculoProveedor.SelectionStart = 0;
            this.txtBoxCodigoArtculoProveedor.Size = new System.Drawing.Size(227, 23);
            this.txtBoxCodigoArtculoProveedor.TabIndex = 10;
            this.txtBoxCodigoArtculoProveedor.UseSystemPasswordChar = false;
            // 
            // txtBoxDescripcionArticuloProveedor
            // 
            this.txtBoxDescripcionArticuloProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescripcionArticuloProveedor.Depth = 0;
            this.txtBoxDescripcionArticuloProveedor.Hint = "";
            this.txtBoxDescripcionArticuloProveedor.Location = new System.Drawing.Point(123, 56);
            this.txtBoxDescripcionArticuloProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDescripcionArticuloProveedor.Name = "txtBoxDescripcionArticuloProveedor";
            this.txtBoxDescripcionArticuloProveedor.PasswordChar = '\0';
            this.txtBoxDescripcionArticuloProveedor.SelectedText = "";
            this.txtBoxDescripcionArticuloProveedor.SelectionLength = 0;
            this.txtBoxDescripcionArticuloProveedor.SelectionStart = 0;
            this.txtBoxDescripcionArticuloProveedor.Size = new System.Drawing.Size(227, 23);
            this.txtBoxDescripcionArticuloProveedor.TabIndex = 11;
            this.txtBoxDescripcionArticuloProveedor.UseSystemPasswordChar = false;
            // 
            // grpBoxListaDescuentos
            // 
            this.grpBoxListaDescuentos.Controls.Add(this.dgvDescuentos);
            this.grpBoxListaDescuentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxListaDescuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxListaDescuentos.Location = new System.Drawing.Point(3, 343);
            this.grpBoxListaDescuentos.Name = "grpBoxListaDescuentos";
            this.grpBoxListaDescuentos.Size = new System.Drawing.Size(444, 150);
            this.grpBoxListaDescuentos.TabIndex = 8;
            this.grpBoxListaDescuentos.TabStop = false;
            this.grpBoxListaDescuentos.Text = "Lista de Descuentos";
            // 
            // dgvDescuentos
            // 
            this.dgvDescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescuentos.Location = new System.Drawing.Point(6, 21);
            this.dgvDescuentos.Name = "dgvDescuentos";
            this.dgvDescuentos.Size = new System.Drawing.Size(435, 123);
            this.dgvDescuentos.TabIndex = 0;
            // 
            // frmDescuentosArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 559);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 559);
            this.Name = "frmDescuentosArticulos";
            this.Text = "Descuentos por Articulo";
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderActual)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpBoxDescuento.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.grpBoxArticulo.ResumeLayout(false);
            this.tblLayoutPanelArticulo.ResumeLayout(false);
            this.tblLayoutPanelArticulo.PerformLayout();
            this.grpBoxArticuloProveedor.ResumeLayout(false);
            this.tblLayoutPanelProveedor.ResumeLayout(false);
            this.tblLayoutPanelProveedor.PerformLayout();
            this.grpBoxListaDescuentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpBoxArticulo;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelArticulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCodigoOriginal;
        private System.Windows.Forms.GroupBox grpBoxArticuloProveedor;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelProveedor;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblCodigoProveedor;
        private System.Windows.Forms.GroupBox grpBoxDescuento;
        private System.Windows.Forms.GroupBox grpBoxListaDescuentos;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarArticulo;
        private MaterialSkin.Controls.MaterialFlatButton btnModificarArticulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCodigoOriginal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxDescripcion;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarArticuloProveedor;
        private MaterialSkin.Controls.MaterialFlatButton btnModificarProveedor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCodigoArtculoProveedor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxDescripcionArticuloProveedor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label tbxnumeroDescuento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxFechaHasta;
        private System.Windows.Forms.TextBox tbxFechaDesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbxPorcentajeDescuento;
        private System.Windows.Forms.DataGridView dgvDescuentos;
    }
}