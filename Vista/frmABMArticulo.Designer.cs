namespace Vista
{
    partial class frmABMArticulo
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
            this.grpBoxObservaciones = new System.Windows.Forms.GroupBox();
            this.rchTextBoxObservaciones = new System.Windows.Forms.RichTextBox();
            this.tblLayoutPanelDatosArticulo = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigoOriginal = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtBoxCodigoOriginal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxModelo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.tblLayoutPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxArticulo = new System.Windows.Forms.GroupBox();
            this.pathimagen = new System.Windows.Forms.Label();
            this.tblLayoutPanelArticulo = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelImagenArticulo = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelImagenButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuitar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAgregaImagen = new MaterialSkin.Controls.MaterialRaisedButton();
            this.picBoxImagen = new System.Windows.Forms.PictureBox();
            this.grpBoxArticulosProveedores = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelArticulosProveedores_Base = new System.Windows.Forms.TableLayoutPanel();
            this.dgvArticulosProveedores = new System.Windows.Forms.DataGridView();
            this.tblLayoutPanelBotonesArticulosProveedores = new System.Windows.Forms.TableLayoutPanel();
            this.btnEliminarArticuloProveedor = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditarArticuloProveedor = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAgregarArticuloProveedor = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tblLayoutPanelArticulosProveedores = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rchTextBoxObservaciones_ArticuloProveedor = new System.Windows.Forms.RichTextBox();
            this.tblLayoutPanelArticulosProveedores_Datos_1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxCodigoArticulo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCodigoArticulo = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.txtBoxPrecioCompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbBoxProveedores = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.txtBoxUbicacion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxPrecioVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nmrcUpDownStockActual = new System.Windows.Forms.NumericUpDown();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.nmrcUpDownStockMinimo = new System.Windows.Forms.NumericUpDown();
            this.lbldescripcionArticuloProveedor = new System.Windows.Forms.Label();
            this.txtBoxDescripcionArticuloProveedor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.grpBoxObservaciones.SuspendLayout();
            this.tblLayoutPanelDatosArticulo.SuspendLayout();
            this.pnlBase.SuspendLayout();
            this.tblLayoutPanelPrincipal.SuspendLayout();
            this.grpBoxArticulo.SuspendLayout();
            this.tblLayoutPanelArticulo.SuspendLayout();
            this.tblLayoutPanelImagenArticulo.SuspendLayout();
            this.tblLayoutPanelImagenButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImagen)).BeginInit();
            this.grpBoxArticulosProveedores.SuspendLayout();
            this.tblLayoutPanelArticulosProveedores_Base.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosProveedores)).BeginInit();
            this.tblLayoutPanelBotonesArticulosProveedores.SuspendLayout();
            this.tblLayoutPanelArticulosProveedores.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tblLayoutPanelArticulosProveedores_Datos_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownStockActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownStockMinimo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxObservaciones
            // 
            this.grpBoxObservaciones.Controls.Add(this.rchTextBoxObservaciones);
            this.grpBoxObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxObservaciones.Location = new System.Drawing.Point(486, 3);
            this.grpBoxObservaciones.Name = "grpBoxObservaciones";
            this.grpBoxObservaciones.Size = new System.Drawing.Size(256, 103);
            this.grpBoxObservaciones.TabIndex = 7;
            this.grpBoxObservaciones.TabStop = false;
            this.grpBoxObservaciones.Text = "Observaciones";
            // 
            // rchTextBoxObservaciones
            // 
            this.rchTextBoxObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchTextBoxObservaciones.Location = new System.Drawing.Point(3, 20);
            this.rchTextBoxObservaciones.Name = "rchTextBoxObservaciones";
            this.rchTextBoxObservaciones.Size = new System.Drawing.Size(250, 80);
            this.rchTextBoxObservaciones.TabIndex = 22;
            this.rchTextBoxObservaciones.Text = "";
            // 
            // tblLayoutPanelDatosArticulo
            // 
            this.tblLayoutPanelDatosArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayoutPanelDatosArticulo.ColumnCount = 3;
            this.tblLayoutPanelDatosArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tblLayoutPanelDatosArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDatosArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblLayoutPanelDatosArticulo.Controls.Add(this.lblModelo, 0, 2);
            this.tblLayoutPanelDatosArticulo.Controls.Add(this.lblDescripcion, 0, 1);
            this.tblLayoutPanelDatosArticulo.Controls.Add(this.txtBoxCodigoOriginal, 1, 0);
            this.tblLayoutPanelDatosArticulo.Controls.Add(this.txtBoxDescripcion, 1, 1);
            this.tblLayoutPanelDatosArticulo.Controls.Add(this.txtBoxModelo, 1, 2);
            this.tblLayoutPanelDatosArticulo.Controls.Add(this.lblCodigoOriginal, 0, 0);
            this.tblLayoutPanelDatosArticulo.Location = new System.Drawing.Point(3, 8);
            this.tblLayoutPanelDatosArticulo.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.tblLayoutPanelDatosArticulo.Name = "tblLayoutPanelDatosArticulo";
            this.tblLayoutPanelDatosArticulo.RowCount = 3;
            this.tblLayoutPanelDatosArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelDatosArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelDatosArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelDatosArticulo.Size = new System.Drawing.Size(297, 97);
            this.tblLayoutPanelDatosArticulo.TabIndex = 8;
            // 
            // lblCodigoOriginal
            // 
            this.lblCodigoOriginal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoOriginal.AutoSize = true;
            this.lblCodigoOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblCodigoOriginal.Location = new System.Drawing.Point(52, 7);
            this.lblCodigoOriginal.Name = "lblCodigoOriginal";
            this.lblCodigoOriginal.Size = new System.Drawing.Size(56, 18);
            this.lblCodigoOriginal.TabIndex = 0;
            this.lblCodigoOriginal.Text = "Código";
            this.lblCodigoOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModelo
            // 
            this.lblModelo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblModelo.Location = new System.Drawing.Point(50, 71);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(58, 18);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblDescripcion.Location = new System.Drawing.Point(21, 39);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(87, 18);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtBoxCodigoOriginal
            // 
            this.txtBoxCodigoOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoOriginal.Depth = 0;
            this.txtBoxCodigoOriginal.Hint = "";
            this.txtBoxCodigoOriginal.Location = new System.Drawing.Point(114, 4);
            this.txtBoxCodigoOriginal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCodigoOriginal.Name = "txtBoxCodigoOriginal";
            this.txtBoxCodigoOriginal.PasswordChar = '\0';
            this.txtBoxCodigoOriginal.SelectedText = "";
            this.txtBoxCodigoOriginal.SelectionLength = 0;
            this.txtBoxCodigoOriginal.SelectionStart = 0;
            this.txtBoxCodigoOriginal.Size = new System.Drawing.Size(155, 23);
            this.txtBoxCodigoOriginal.TabIndex = 6;
            this.txtBoxCodigoOriginal.UseSystemPasswordChar = false;
            this.txtBoxCodigoOriginal.Leave += new System.EventHandler(this.txtBoxCodigoOriginal_Leave);
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescripcion.Depth = 0;
            this.txtBoxDescripcion.Hint = "";
            this.txtBoxDescripcion.Location = new System.Drawing.Point(114, 36);
            this.txtBoxDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.PasswordChar = '\0';
            this.txtBoxDescripcion.SelectedText = "";
            this.txtBoxDescripcion.SelectionLength = 0;
            this.txtBoxDescripcion.SelectionStart = 0;
            this.txtBoxDescripcion.Size = new System.Drawing.Size(155, 23);
            this.txtBoxDescripcion.TabIndex = 7;
            this.txtBoxDescripcion.UseSystemPasswordChar = false;
            this.txtBoxDescripcion.Leave += new System.EventHandler(this.txtBoxDescripcion_Leave);
            // 
            // txtBoxModelo
            // 
            this.txtBoxModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxModelo.Depth = 0;
            this.txtBoxModelo.Hint = "";
            this.txtBoxModelo.Location = new System.Drawing.Point(114, 69);
            this.txtBoxModelo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxModelo.Name = "txtBoxModelo";
            this.txtBoxModelo.PasswordChar = '\0';
            this.txtBoxModelo.SelectedText = "";
            this.txtBoxModelo.SelectionLength = 0;
            this.txtBoxModelo.SelectionStart = 0;
            this.txtBoxModelo.Size = new System.Drawing.Size(155, 23);
            this.txtBoxModelo.TabIndex = 8;
            this.txtBoxModelo.UseSystemPasswordChar = false;
            this.txtBoxModelo.Leave += new System.EventHandler(this.txtBoxModelo_Leave);
            // 
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.tblLayoutPanelPrincipal);
            this.pnlBase.Location = new System.Drawing.Point(9, 58);
            this.pnlBase.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(753, 689);
            this.pnlBase.TabIndex = 3;
            // 
            // tblLayoutPanelPrincipal
            // 
            this.tblLayoutPanelPrincipal.ColumnCount = 1;
            this.tblLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal.Controls.Add(this.grpBoxArticulo, 0, 0);
            this.tblLayoutPanelPrincipal.Controls.Add(this.grpBoxArticulosProveedores, 0, 1);
            this.tblLayoutPanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanelPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.tblLayoutPanelPrincipal.Name = "tblLayoutPanelPrincipal";
            this.tblLayoutPanelPrincipal.RowCount = 2;
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tblLayoutPanelPrincipal.Size = new System.Drawing.Size(753, 404);
            this.tblLayoutPanelPrincipal.TabIndex = 3;
            // 
            // grpBoxArticulo
            // 
            this.grpBoxArticulo.Controls.Add(this.pathimagen);
            this.grpBoxArticulo.Controls.Add(this.tblLayoutPanelArticulo);
            this.grpBoxArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxArticulo.Location = new System.Drawing.Point(2, 2);
            this.grpBoxArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoxArticulo.Name = "grpBoxArticulo";
            this.grpBoxArticulo.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxArticulo.Size = new System.Drawing.Size(749, 126);
            this.grpBoxArticulo.TabIndex = 2;
            this.grpBoxArticulo.TabStop = false;
            this.grpBoxArticulo.Text = "Artículo";
            // 
            // pathimagen
            // 
            this.pathimagen.AutoSize = true;
            this.pathimagen.Location = new System.Drawing.Point(410, 5);
            this.pathimagen.Name = "pathimagen";
            this.pathimagen.Size = new System.Drawing.Size(35, 13);
            this.pathimagen.TabIndex = 4;
            this.pathimagen.Text = "label1";
            this.pathimagen.Visible = false;
            // 
            // tblLayoutPanelArticulo
            // 
            this.tblLayoutPanelArticulo.ColumnCount = 3;
            this.tblLayoutPanelArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tblLayoutPanelArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.tblLayoutPanelArticulo.Controls.Add(this.tblLayoutPanelDatosArticulo, 0, 0);
            this.tblLayoutPanelArticulo.Controls.Add(this.grpBoxObservaciones, 2, 0);
            this.tblLayoutPanelArticulo.Controls.Add(this.tblLayoutPanelImagenArticulo, 1, 0);
            this.tblLayoutPanelArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelArticulo.Location = new System.Drawing.Point(2, 15);
            this.tblLayoutPanelArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.tblLayoutPanelArticulo.Name = "tblLayoutPanelArticulo";
            this.tblLayoutPanelArticulo.RowCount = 1;
            this.tblLayoutPanelArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelArticulo.Size = new System.Drawing.Size(745, 109);
            this.tblLayoutPanelArticulo.TabIndex = 0;
            // 
            // tblLayoutPanelImagenArticulo
            // 
            this.tblLayoutPanelImagenArticulo.BackColor = System.Drawing.Color.White;
            this.tblLayoutPanelImagenArticulo.ColumnCount = 1;
            this.tblLayoutPanelImagenArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelImagenArticulo.Controls.Add(this.tblLayoutPanelImagenButtons, 0, 1);
            this.tblLayoutPanelImagenArticulo.Controls.Add(this.picBoxImagen, 0, 0);
            this.tblLayoutPanelImagenArticulo.Location = new System.Drawing.Point(306, 3);
            this.tblLayoutPanelImagenArticulo.Name = "tblLayoutPanelImagenArticulo";
            this.tblLayoutPanelImagenArticulo.RowCount = 2;
            this.tblLayoutPanelImagenArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblLayoutPanelImagenArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelImagenArticulo.Size = new System.Drawing.Size(174, 100);
            this.tblLayoutPanelImagenArticulo.TabIndex = 9;
            // 
            // tblLayoutPanelImagenButtons
            // 
            this.tblLayoutPanelImagenButtons.ColumnCount = 2;
            this.tblLayoutPanelImagenButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelImagenButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelImagenButtons.Controls.Add(this.btnQuitar, 0, 0);
            this.tblLayoutPanelImagenButtons.Controls.Add(this.btnAgregaImagen, 0, 0);
            this.tblLayoutPanelImagenButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelImagenButtons.Location = new System.Drawing.Point(3, 78);
            this.tblLayoutPanelImagenButtons.Name = "tblLayoutPanelImagenButtons";
            this.tblLayoutPanelImagenButtons.RowCount = 1;
            this.tblLayoutPanelImagenButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelImagenButtons.Size = new System.Drawing.Size(168, 19);
            this.tblLayoutPanelImagenButtons.TabIndex = 0;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnQuitar.Depth = 0;
            this.btnQuitar.Location = new System.Drawing.Point(86, 2);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Primary = true;
            this.btnQuitar.Size = new System.Drawing.Size(80, 15);
            this.btnQuitar.TabIndex = 2;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregaImagen
            // 
            this.btnAgregaImagen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregaImagen.Depth = 0;
            this.btnAgregaImagen.Location = new System.Drawing.Point(2, 2);
            this.btnAgregaImagen.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregaImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregaImagen.Name = "btnAgregaImagen";
            this.btnAgregaImagen.Primary = true;
            this.btnAgregaImagen.Size = new System.Drawing.Size(80, 15);
            this.btnAgregaImagen.TabIndex = 1;
            this.btnAgregaImagen.Text = "Agregar";
            this.btnAgregaImagen.UseVisualStyleBackColor = true;
            this.btnAgregaImagen.Click += new System.EventHandler(this.btnAgregaImagen_Click);
            // 
            // picBoxImagen
            // 
            this.picBoxImagen.BackColor = System.Drawing.Color.Gainsboro;
            this.picBoxImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxImagen.Location = new System.Drawing.Point(3, 3);
            this.picBoxImagen.Name = "picBoxImagen";
            this.picBoxImagen.Size = new System.Drawing.Size(168, 69);
            this.picBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxImagen.TabIndex = 1;
            this.picBoxImagen.TabStop = false;
            // 
            // grpBoxArticulosProveedores
            // 
            this.grpBoxArticulosProveedores.Controls.Add(this.tblLayoutPanelArticulosProveedores_Base);
            this.grpBoxArticulosProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxArticulosProveedores.Location = new System.Drawing.Point(2, 132);
            this.grpBoxArticulosProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoxArticulosProveedores.Name = "grpBoxArticulosProveedores";
            this.grpBoxArticulosProveedores.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxArticulosProveedores.Size = new System.Drawing.Size(749, 270);
            this.grpBoxArticulosProveedores.TabIndex = 3;
            this.grpBoxArticulosProveedores.TabStop = false;
            this.grpBoxArticulosProveedores.Text = "Artículos de Proveedores";
            // 
            // tblLayoutPanelArticulosProveedores_Base
            // 
            this.tblLayoutPanelArticulosProveedores_Base.ColumnCount = 1;
            this.tblLayoutPanelArticulosProveedores_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelArticulosProveedores_Base.Controls.Add(this.dgvArticulosProveedores, 0, 2);
            this.tblLayoutPanelArticulosProveedores_Base.Controls.Add(this.tblLayoutPanelBotonesArticulosProveedores, 0, 1);
            this.tblLayoutPanelArticulosProveedores_Base.Controls.Add(this.tblLayoutPanelArticulosProveedores, 0, 0);
            this.tblLayoutPanelArticulosProveedores_Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelArticulosProveedores_Base.Location = new System.Drawing.Point(2, 15);
            this.tblLayoutPanelArticulosProveedores_Base.Margin = new System.Windows.Forms.Padding(2);
            this.tblLayoutPanelArticulosProveedores_Base.Name = "tblLayoutPanelArticulosProveedores_Base";
            this.tblLayoutPanelArticulosProveedores_Base.RowCount = 3;
            this.tblLayoutPanelArticulosProveedores_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tblLayoutPanelArticulosProveedores_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tblLayoutPanelArticulosProveedores_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelArticulosProveedores_Base.Size = new System.Drawing.Size(745, 253);
            this.tblLayoutPanelArticulosProveedores_Base.TabIndex = 1;
            // 
            // dgvArticulosProveedores
            // 
            this.dgvArticulosProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulosProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticulosProveedores.Location = new System.Drawing.Point(2, 193);
            this.dgvArticulosProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.dgvArticulosProveedores.Name = "dgvArticulosProveedores";
            this.dgvArticulosProveedores.RowTemplate.Height = 24;
            this.dgvArticulosProveedores.Size = new System.Drawing.Size(741, 58);
            this.dgvArticulosProveedores.TabIndex = 0;
            // 
            // tblLayoutPanelBotonesArticulosProveedores
            // 
            this.tblLayoutPanelBotonesArticulosProveedores.ColumnCount = 3;
            this.tblLayoutPanelBotonesArticulosProveedores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelBotonesArticulosProveedores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tblLayoutPanelBotonesArticulosProveedores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelBotonesArticulosProveedores.Controls.Add(this.btnEliminarArticuloProveedor, 2, 0);
            this.tblLayoutPanelBotonesArticulosProveedores.Controls.Add(this.btnEditarArticuloProveedor, 1, 0);
            this.tblLayoutPanelBotonesArticulosProveedores.Controls.Add(this.btnAgregarArticuloProveedor, 0, 0);
            this.tblLayoutPanelBotonesArticulosProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelBotonesArticulosProveedores.Location = new System.Drawing.Point(2, 144);
            this.tblLayoutPanelBotonesArticulosProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.tblLayoutPanelBotonesArticulosProveedores.Name = "tblLayoutPanelBotonesArticulosProveedores";
            this.tblLayoutPanelBotonesArticulosProveedores.RowCount = 1;
            this.tblLayoutPanelBotonesArticulosProveedores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelBotonesArticulosProveedores.Size = new System.Drawing.Size(741, 45);
            this.tblLayoutPanelBotonesArticulosProveedores.TabIndex = 1;
            // 
            // btnEliminarArticuloProveedor
            // 
            this.btnEliminarArticuloProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEliminarArticuloProveedor.Depth = 0;
            this.btnEliminarArticuloProveedor.Location = new System.Drawing.Point(466, 6);
            this.btnEliminarArticuloProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarArticuloProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarArticuloProveedor.Name = "btnEliminarArticuloProveedor";
            this.btnEliminarArticuloProveedor.Primary = true;
            this.btnEliminarArticuloProveedor.Size = new System.Drawing.Size(142, 32);
            this.btnEliminarArticuloProveedor.TabIndex = 2;
            this.btnEliminarArticuloProveedor.Text = "Eliminar";
            this.btnEliminarArticuloProveedor.UseVisualStyleBackColor = true;
            this.btnEliminarArticuloProveedor.Click += new System.EventHandler(this.btnEliminarArticuloProveedor_Click);
            // 
            // btnEditarArticuloProveedor
            // 
            this.btnEditarArticuloProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditarArticuloProveedor.Depth = 0;
            this.btnEditarArticuloProveedor.Location = new System.Drawing.Point(299, 6);
            this.btnEditarArticuloProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarArticuloProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarArticuloProveedor.Name = "btnEditarArticuloProveedor";
            this.btnEditarArticuloProveedor.Primary = true;
            this.btnEditarArticuloProveedor.Size = new System.Drawing.Size(142, 32);
            this.btnEditarArticuloProveedor.TabIndex = 1;
            this.btnEditarArticuloProveedor.Text = "Guardar Cambios";
            this.btnEditarArticuloProveedor.UseVisualStyleBackColor = true;
            this.btnEditarArticuloProveedor.Click += new System.EventHandler(this.btnEditarArticuloProveedor_Click);
            // 
            // btnAgregarArticuloProveedor
            // 
            this.btnAgregarArticuloProveedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregarArticuloProveedor.Depth = 0;
            this.btnAgregarArticuloProveedor.Location = new System.Drawing.Point(132, 6);
            this.btnAgregarArticuloProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarArticuloProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarArticuloProveedor.Name = "btnAgregarArticuloProveedor";
            this.btnAgregarArticuloProveedor.Primary = true;
            this.btnAgregarArticuloProveedor.Size = new System.Drawing.Size(142, 32);
            this.btnAgregarArticuloProveedor.TabIndex = 0;
            this.btnAgregarArticuloProveedor.Text = "Agregar";
            this.btnAgregarArticuloProveedor.UseVisualStyleBackColor = true;
            this.btnAgregarArticuloProveedor.Click += new System.EventHandler(this.btnAgregarArticuloProveedor_Click);
            // 
            // tblLayoutPanelArticulosProveedores
            // 
            this.tblLayoutPanelArticulosProveedores.ColumnCount = 2;
            this.tblLayoutPanelArticulosProveedores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelArticulosProveedores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.tblLayoutPanelArticulosProveedores.Controls.Add(this.groupBox1, 1, 0);
            this.tblLayoutPanelArticulosProveedores.Controls.Add(this.tblLayoutPanelArticulosProveedores_Datos_1, 0, 0);
            this.tblLayoutPanelArticulosProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelArticulosProveedores.Location = new System.Drawing.Point(2, 2);
            this.tblLayoutPanelArticulosProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.tblLayoutPanelArticulosProveedores.Name = "tblLayoutPanelArticulosProveedores";
            this.tblLayoutPanelArticulosProveedores.RowCount = 1;
            this.tblLayoutPanelArticulosProveedores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelArticulosProveedores.Size = new System.Drawing.Size(741, 138);
            this.tblLayoutPanelArticulosProveedores.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rchTextBoxObservaciones_ArticuloProveedor);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(482, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 132);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observaciones";
            // 
            // rchTextBoxObservaciones_ArticuloProveedor
            // 
            this.rchTextBoxObservaciones_ArticuloProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchTextBoxObservaciones_ArticuloProveedor.Location = new System.Drawing.Point(3, 20);
            this.rchTextBoxObservaciones_ArticuloProveedor.Name = "rchTextBoxObservaciones_ArticuloProveedor";
            this.rchTextBoxObservaciones_ArticuloProveedor.Size = new System.Drawing.Size(250, 109);
            this.rchTextBoxObservaciones_ArticuloProveedor.TabIndex = 22;
            this.rchTextBoxObservaciones_ArticuloProveedor.Text = "";
            // 
            // tblLayoutPanelArticulosProveedores_Datos_1
            // 
            this.tblLayoutPanelArticulosProveedores_Datos_1.ColumnCount = 6;
            this.tblLayoutPanelArticulosProveedores_Datos_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLayoutPanelArticulosProveedores_Datos_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelArticulosProveedores_Datos_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblLayoutPanelArticulosProveedores_Datos_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLayoutPanelArticulosProveedores_Datos_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelArticulosProveedores_Datos_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblLayoutPanelArticulosProveedores_Datos_1.Controls.Add(this.txtBoxCodigoArticulo, 1, 0);
            this.tblLayoutPanelArticulosProveedores_Datos_1.Controls.Add(this.lblCodigoArticulo, 0, 0);
            this.tblLayoutPanelArticulosProveedores_Datos_1.Controls.Add(this.lblUbicacion, 0, 3);
            this.tblLayoutPanelArticulosProveedores_Datos_1.Controls.Add(this.lblPrecioCompra, 3, 2);
            this.tblLayoutPanelArticulosProveedores_Datos_1.Controls.Add(this.txtBoxPrecioCompra, 4, 2);
            this.tblLayoutPanelArticulosProveedores_Datos_1.Controls.Add(this.cmbBoxProveedores, 4, 0);
            this.tblLayoutPanelArticulosProveedores_Datos_1.Controls.Add(this.materialLabel1, 3, 0);
            this.tblLayoutPanelArticulosProveedores_Datos_1.Controls.Add(this.lblStockActual, 3, 1);
            this.tblLayoutPanelArticulosProveedores_Datos_1.Controls.Add(this.lblPrecioVenta, 0, 2);
            this.tblLayoutPanelArticulosProveedores_Datos_1.Controls.Add(this.txtBoxUbicacion, 1, 3);
            this.tblLayoutPanelArticulosProveedores_Datos_1.Controls.Add(this.txtBoxPrecioVenta, 1, 2);
            this.tblLayoutPanelArticulosProveedores_Datos_1.Controls.Add(this.nmrcUpDownStockActual, 4, 1);
            this.tblLayoutPanelArticulosProveedores_Datos_1.Controls.Add(this.lblStockMinimo, 0, 1);
            this.tblLayoutPanelArticulosProveedores_Datos_1.Controls.Add(this.nmrcUpDownStockMinimo, 1, 1);
            this.tblLayoutPanelArticulosProveedores_Datos_1.Controls.Add(this.lbldescripcionArticuloProveedor, 3, 3);
            this.tblLayoutPanelArticulosProveedores_Datos_1.Controls.Add(this.txtBoxDescripcionArticuloProveedor, 4, 3);
            this.tblLayoutPanelArticulosProveedores_Datos_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelArticulosProveedores_Datos_1.Location = new System.Drawing.Point(2, 8);
            this.tblLayoutPanelArticulosProveedores_Datos_1.Margin = new System.Windows.Forms.Padding(2, 8, 2, 2);
            this.tblLayoutPanelArticulosProveedores_Datos_1.Name = "tblLayoutPanelArticulosProveedores_Datos_1";
            this.tblLayoutPanelArticulosProveedores_Datos_1.RowCount = 4;
            this.tblLayoutPanelArticulosProveedores_Datos_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelArticulosProveedores_Datos_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelArticulosProveedores_Datos_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelArticulosProveedores_Datos_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelArticulosProveedores_Datos_1.Size = new System.Drawing.Size(475, 128);
            this.tblLayoutPanelArticulosProveedores_Datos_1.TabIndex = 1;
            // 
            // txtBoxCodigoArticulo
            // 
            this.txtBoxCodigoArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoArticulo.Depth = 0;
            this.txtBoxCodigoArticulo.Hint = "";
            this.txtBoxCodigoArticulo.Location = new System.Drawing.Point(123, 4);
            this.txtBoxCodigoArticulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCodigoArticulo.Name = "txtBoxCodigoArticulo";
            this.txtBoxCodigoArticulo.PasswordChar = '\0';
            this.txtBoxCodigoArticulo.SelectedText = "";
            this.txtBoxCodigoArticulo.SelectionLength = 0;
            this.txtBoxCodigoArticulo.SelectionStart = 0;
            this.txtBoxCodigoArticulo.Size = new System.Drawing.Size(86, 23);
            this.txtBoxCodigoArticulo.TabIndex = 17;
            this.txtBoxCodigoArticulo.UseSystemPasswordChar = false;
            this.txtBoxCodigoArticulo.Leave += new System.EventHandler(this.txtBoxCodigoArticulo_Leave);
            // 
            // lblCodigoArticulo
            // 
            this.lblCodigoArticulo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoArticulo.AutoSize = true;
            this.lblCodigoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblCodigoArticulo.Location = new System.Drawing.Point(8, 7);
            this.lblCodigoArticulo.Name = "lblCodigoArticulo";
            this.lblCodigoArticulo.Size = new System.Drawing.Size(109, 18);
            this.lblCodigoArticulo.TabIndex = 7;
            this.lblCodigoArticulo.Text = "Código Artículo";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblUbicacion.Location = new System.Drawing.Point(43, 103);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(74, 18);
            this.lblUbicacion.TabIndex = 7;
            this.lblUbicacion.Text = "Ubicación";
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCompra.Location = new System.Drawing.Point(245, 71);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(109, 18);
            this.lblPrecioCompra.TabIndex = 14;
            this.lblPrecioCompra.Text = "Precio Compra";
            // 
            // txtBoxPrecioCompra
            // 
            this.txtBoxPrecioCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPrecioCompra.Depth = 0;
            this.txtBoxPrecioCompra.Hint = "";
            this.txtBoxPrecioCompra.Location = new System.Drawing.Point(360, 68);
            this.txtBoxPrecioCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxPrecioCompra.Name = "txtBoxPrecioCompra";
            this.txtBoxPrecioCompra.PasswordChar = '\0';
            this.txtBoxPrecioCompra.SelectedText = "";
            this.txtBoxPrecioCompra.SelectionLength = 0;
            this.txtBoxPrecioCompra.SelectionStart = 0;
            this.txtBoxPrecioCompra.Size = new System.Drawing.Size(86, 23);
            this.txtBoxPrecioCompra.TabIndex = 18;
            this.txtBoxPrecioCompra.UseSystemPasswordChar = false;
            this.txtBoxPrecioCompra.Leave += new System.EventHandler(this.txtBoxPrecioCompra_Leave);
            // 
            // cmbBoxProveedores
            // 
            this.cmbBoxProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxProveedores.FormattingEnabled = true;
            this.cmbBoxProveedores.Location = new System.Drawing.Point(360, 5);
            this.cmbBoxProveedores.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cmbBoxProveedores.Name = "cmbBoxProveedores";
            this.cmbBoxProveedores.Size = new System.Drawing.Size(79, 21);
            this.cmbBoxProveedores.TabIndex = 10;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(273, 6);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(81, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Proveedor:";
            // 
            // lblStockActual
            // 
            this.lblStockActual.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblStockActual.Location = new System.Drawing.Point(263, 39);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(91, 18);
            this.lblStockActual.TabIndex = 9;
            this.lblStockActual.Text = "Stock Actual";
            this.lblStockActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblPrecioVenta.Location = new System.Drawing.Point(25, 71);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(92, 18);
            this.lblPrecioVenta.TabIndex = 13;
            this.lblPrecioVenta.Text = "Precio Venta";
            // 
            // txtBoxUbicacion
            // 
            this.txtBoxUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxUbicacion.Depth = 0;
            this.txtBoxUbicacion.Hint = "";
            this.txtBoxUbicacion.Location = new System.Drawing.Point(123, 100);
            this.txtBoxUbicacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxUbicacion.Name = "txtBoxUbicacion";
            this.txtBoxUbicacion.PasswordChar = '\0';
            this.txtBoxUbicacion.SelectedText = "";
            this.txtBoxUbicacion.SelectionLength = 0;
            this.txtBoxUbicacion.SelectionStart = 0;
            this.txtBoxUbicacion.Size = new System.Drawing.Size(86, 23);
            this.txtBoxUbicacion.TabIndex = 20;
            this.txtBoxUbicacion.UseSystemPasswordChar = false;
            this.txtBoxUbicacion.Leave += new System.EventHandler(this.txtBoxUbicacion_Leave);
            // 
            // txtBoxPrecioVenta
            // 
            this.txtBoxPrecioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPrecioVenta.Depth = 0;
            this.txtBoxPrecioVenta.Hint = "";
            this.txtBoxPrecioVenta.Location = new System.Drawing.Point(123, 68);
            this.txtBoxPrecioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxPrecioVenta.Name = "txtBoxPrecioVenta";
            this.txtBoxPrecioVenta.PasswordChar = '\0';
            this.txtBoxPrecioVenta.SelectedText = "";
            this.txtBoxPrecioVenta.SelectionLength = 0;
            this.txtBoxPrecioVenta.SelectionStart = 0;
            this.txtBoxPrecioVenta.Size = new System.Drawing.Size(86, 23);
            this.txtBoxPrecioVenta.TabIndex = 19;
            this.txtBoxPrecioVenta.UseSystemPasswordChar = false;
            this.txtBoxPrecioVenta.Leave += new System.EventHandler(this.txtBoxPrecioVenta_Leave);
            // 
            // nmrcUpDownStockActual
            // 
            this.nmrcUpDownStockActual.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nmrcUpDownStockActual.Location = new System.Drawing.Point(360, 38);
            this.nmrcUpDownStockActual.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrcUpDownStockActual.Name = "nmrcUpDownStockActual";
            this.nmrcUpDownStockActual.Size = new System.Drawing.Size(69, 20);
            this.nmrcUpDownStockActual.TabIndex = 11;
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblStockMinimo.Location = new System.Drawing.Point(17, 39);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(100, 18);
            this.lblStockMinimo.TabIndex = 10;
            this.lblStockMinimo.Text = "Stock Mínimo";
            this.lblStockMinimo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nmrcUpDownStockMinimo
            // 
            this.nmrcUpDownStockMinimo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nmrcUpDownStockMinimo.Location = new System.Drawing.Point(123, 38);
            this.nmrcUpDownStockMinimo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrcUpDownStockMinimo.Name = "nmrcUpDownStockMinimo";
            this.nmrcUpDownStockMinimo.Size = new System.Drawing.Size(69, 20);
            this.nmrcUpDownStockMinimo.TabIndex = 12;
            // 
            // lbldescripcionArticuloProveedor
            // 
            this.lbldescripcionArticuloProveedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbldescripcionArticuloProveedor.AutoSize = true;
            this.lbldescripcionArticuloProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescripcionArticuloProveedor.Location = new System.Drawing.Point(267, 103);
            this.lbldescripcionArticuloProveedor.Name = "lbldescripcionArticuloProveedor";
            this.lbldescripcionArticuloProveedor.Size = new System.Drawing.Size(87, 18);
            this.lbldescripcionArticuloProveedor.TabIndex = 21;
            this.lbldescripcionArticuloProveedor.Text = "Descripcion";
            // 
            // txtBoxDescripcionArticuloProveedor
            // 
            this.txtBoxDescripcionArticuloProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescripcionArticuloProveedor.Depth = 0;
            this.txtBoxDescripcionArticuloProveedor.Hint = "";
            this.txtBoxDescripcionArticuloProveedor.Location = new System.Drawing.Point(360, 100);
            this.txtBoxDescripcionArticuloProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDescripcionArticuloProveedor.Name = "txtBoxDescripcionArticuloProveedor";
            this.txtBoxDescripcionArticuloProveedor.PasswordChar = '\0';
            this.txtBoxDescripcionArticuloProveedor.SelectedText = "";
            this.txtBoxDescripcionArticuloProveedor.SelectionLength = 0;
            this.txtBoxDescripcionArticuloProveedor.SelectionStart = 0;
            this.txtBoxDescripcionArticuloProveedor.Size = new System.Drawing.Size(86, 23);
            this.txtBoxDescripcionArticuloProveedor.TabIndex = 22;
            this.txtBoxDescripcionArticuloProveedor.UseSystemPasswordChar = false;
            // 
            // frmABMArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(790, 640);
            this.Controls.Add(this.pnlBase);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(450, 230);
            this.Name = "frmABMArticulo";
            this.Text = "Artículo";
            this.Controls.SetChildIndex(this.pnlBase, 0);
            this.grpBoxObservaciones.ResumeLayout(false);
            this.tblLayoutPanelDatosArticulo.ResumeLayout(false);
            this.tblLayoutPanelDatosArticulo.PerformLayout();
            this.pnlBase.ResumeLayout(false);
            this.tblLayoutPanelPrincipal.ResumeLayout(false);
            this.grpBoxArticulo.ResumeLayout(false);
            this.grpBoxArticulo.PerformLayout();
            this.tblLayoutPanelArticulo.ResumeLayout(false);
            this.tblLayoutPanelImagenArticulo.ResumeLayout(false);
            this.tblLayoutPanelImagenButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImagen)).EndInit();
            this.grpBoxArticulosProveedores.ResumeLayout(false);
            this.tblLayoutPanelArticulosProveedores_Base.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosProveedores)).EndInit();
            this.tblLayoutPanelBotonesArticulosProveedores.ResumeLayout(false);
            this.tblLayoutPanelArticulosProveedores.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tblLayoutPanelArticulosProveedores_Datos_1.ResumeLayout(false);
            this.tblLayoutPanelArticulosProveedores_Datos_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownStockActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownStockMinimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxObservaciones;
        private System.Windows.Forms.RichTextBox rchTextBoxObservaciones;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDatosArticulo;
        private System.Windows.Forms.Label lblCodigoOriginal;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblDescripcion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCodigoOriginal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxDescripcion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxModelo;
        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelPrincipal;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelArticulosProveedores_Base;
        private System.Windows.Forms.GroupBox grpBoxArticulo;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelArticulo;
        private System.Windows.Forms.GroupBox grpBoxArticulosProveedores;
        private System.Windows.Forms.DataGridView dgvArticulosProveedores;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelBotonesArticulosProveedores;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelArticulosProveedores;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelArticulosProveedores_Datos_1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rchTextBoxObservaciones_ArticuloProveedor;
        private System.Windows.Forms.Label lblUbicacion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxUbicacion;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.NumericUpDown nmrcUpDownStockMinimo;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.NumericUpDown nmrcUpDownStockActual;
        private System.Windows.Forms.Label lblPrecioVenta;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxPrecioVenta;
        private System.Windows.Forms.Label lblPrecioCompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxPrecioCompra;
        private System.Windows.Forms.Label lblCodigoArticulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCodigoArticulo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox cmbBoxProveedores;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminarArticuloProveedor;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditarArticuloProveedor;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregarArticuloProveedor;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelImagenArticulo;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelImagenButtons;
        private MaterialSkin.Controls.MaterialRaisedButton btnQuitar;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregaImagen;
        private System.Windows.Forms.PictureBox picBoxImagen;
        private System.Windows.Forms.Label pathimagen;
        private System.Windows.Forms.Label lbldescripcionArticuloProveedor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxDescripcionArticuloProveedor;
    }
}
