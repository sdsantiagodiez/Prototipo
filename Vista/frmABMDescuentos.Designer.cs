namespace Vista
{
    partial class frmABMDescuentos
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
            this.pnlBase = new System.Windows.Forms.Panel();
            this.tblLayoutPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxResultadoBusqueda = new System.Windows.Forms.GroupBox();
            this.grpBoxDatosBusqueda = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelParametrosBusquedaBase = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelParametrosBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigoOriginal = new MaterialSkin.Controls.MaterialLabel();
            this.lblModelo = new MaterialSkin.Controls.MaterialLabel();
            this.txtBoxCodigoOriginal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxModelo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblProveedor = new MaterialSkin.Controls.MaterialLabel();
            this.cmbBoxProveedores = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new MaterialSkin.Controls.MaterialLabel();
            this.txtBoxDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCodigoArticuloProveedor = new MaterialSkin.Controls.MaterialLabel();
            this.txtBoxCodigoArticuloProveedor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chckBoxDescuentosActivos = new MaterialSkin.Controls.MaterialCheckBox();
            this.grpBoxDescuento = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelParametrosDescuento = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxPorcentajeDescuento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblFechaHastaDescuento = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaHastaDescuento = new System.Windows.Forms.DateTimePicker();
            this.cmbBoxPorcentajeDescuento = new System.Windows.Forms.ComboBox();
            this.lblPorcentajeDescuento = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaDesdeDescuento = new MaterialSkin.Controls.MaterialLabel();
            this.lblDescripcionDescuento = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaDesdeDescuento = new System.Windows.Forms.DateTimePicker();
            this.txtBoxDescripcionDescuento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnGuardarDescuento = new MaterialSkin.Controls.MaterialRaisedButton();
            this.epCodigoOriginal = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDescripcionArticulo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCodigoArticuloProveedor = new System.Windows.Forms.ErrorProvider(this.components);
            this.epModelo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPorcentaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDescripcionDescuento = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlBase.SuspendLayout();
            this.tblLayoutPanelPrincipal.SuspendLayout();
            this.grpBoxDatosBusqueda.SuspendLayout();
            this.tblLayoutPanelParametrosBusquedaBase.SuspendLayout();
            this.tblLayoutPanelParametrosBusqueda.SuspendLayout();
            this.grpBoxDescuento.SuspendLayout();
            this.tblLayoutPanelParametrosDescuento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigoOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDescripcionArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigoArticuloProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPorcentaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDescripcionDescuento)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.tblLayoutPanelPrincipal);
            this.pnlBase.Location = new System.Drawing.Point(1, 80);
            this.pnlBase.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(1053, 575);
            this.pnlBase.TabIndex = 0;
            // 
            // tblLayoutPanelPrincipal
            // 
            this.tblLayoutPanelPrincipal.ColumnCount = 1;
            this.tblLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal.Controls.Add(this.grpBoxResultadoBusqueda, 0, 1);
            this.tblLayoutPanelPrincipal.Controls.Add(this.grpBoxDatosBusqueda, 0, 0);
            this.tblLayoutPanelPrincipal.Controls.Add(this.grpBoxDescuento, 0, 2);
            this.tblLayoutPanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanelPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.tblLayoutPanelPrincipal.Name = "tblLayoutPanelPrincipal";
            this.tblLayoutPanelPrincipal.RowCount = 3;
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tblLayoutPanelPrincipal.Size = new System.Drawing.Size(1053, 575);
            this.tblLayoutPanelPrincipal.TabIndex = 0;
            // 
            // grpBoxResultadoBusqueda
            // 
            this.grpBoxResultadoBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxResultadoBusqueda.Location = new System.Drawing.Point(4, 201);
            this.grpBoxResultadoBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxResultadoBusqueda.Name = "grpBoxResultadoBusqueda";
            this.grpBoxResultadoBusqueda.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxResultadoBusqueda.Size = new System.Drawing.Size(1045, 220);
            this.grpBoxResultadoBusqueda.TabIndex = 0;
            this.grpBoxResultadoBusqueda.TabStop = false;
            this.grpBoxResultadoBusqueda.Text = "Resultado Búsqueda";
            // 
            // grpBoxDatosBusqueda
            // 
            this.grpBoxDatosBusqueda.Controls.Add(this.tblLayoutPanelParametrosBusquedaBase);
            this.grpBoxDatosBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDatosBusqueda.Location = new System.Drawing.Point(4, 4);
            this.grpBoxDatosBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxDatosBusqueda.Name = "grpBoxDatosBusqueda";
            this.grpBoxDatosBusqueda.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxDatosBusqueda.Size = new System.Drawing.Size(1045, 189);
            this.grpBoxDatosBusqueda.TabIndex = 1;
            this.grpBoxDatosBusqueda.TabStop = false;
            this.grpBoxDatosBusqueda.Text = "Datos Artículos";
            // 
            // tblLayoutPanelParametrosBusquedaBase
            // 
            this.tblLayoutPanelParametrosBusquedaBase.ColumnCount = 1;
            this.tblLayoutPanelParametrosBusquedaBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelParametrosBusquedaBase.Controls.Add(this.tblLayoutPanelParametrosBusqueda, 0, 0);
            this.tblLayoutPanelParametrosBusquedaBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelParametrosBusquedaBase.Location = new System.Drawing.Point(4, 19);
            this.tblLayoutPanelParametrosBusquedaBase.Margin = new System.Windows.Forms.Padding(4);
            this.tblLayoutPanelParametrosBusquedaBase.Name = "tblLayoutPanelParametrosBusquedaBase";
            this.tblLayoutPanelParametrosBusquedaBase.RowCount = 2;
            this.tblLayoutPanelParametrosBusquedaBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelParametrosBusquedaBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tblLayoutPanelParametrosBusquedaBase.Size = new System.Drawing.Size(1037, 166);
            this.tblLayoutPanelParametrosBusquedaBase.TabIndex = 1;
            // 
            // tblLayoutPanelParametrosBusqueda
            // 
            this.tblLayoutPanelParametrosBusqueda.ColumnCount = 9;
            this.tblLayoutPanelParametrosBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tblLayoutPanelParametrosBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblLayoutPanelParametrosBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tblLayoutPanelParametrosBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tblLayoutPanelParametrosBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tblLayoutPanelParametrosBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tblLayoutPanelParametrosBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tblLayoutPanelParametrosBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblLayoutPanelParametrosBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tblLayoutPanelParametrosBusqueda.Controls.Add(this.lblCodigoOriginal, 0, 0);
            this.tblLayoutPanelParametrosBusqueda.Controls.Add(this.lblModelo, 3, 1);
            this.tblLayoutPanelParametrosBusqueda.Controls.Add(this.txtBoxCodigoOriginal, 1, 0);
            this.tblLayoutPanelParametrosBusqueda.Controls.Add(this.txtBoxModelo, 4, 1);
            this.tblLayoutPanelParametrosBusqueda.Controls.Add(this.btnBuscar, 7, 2);
            this.tblLayoutPanelParametrosBusqueda.Controls.Add(this.lblProveedor, 6, 0);
            this.tblLayoutPanelParametrosBusqueda.Controls.Add(this.cmbBoxProveedores, 7, 0);
            this.tblLayoutPanelParametrosBusqueda.Controls.Add(this.lblDescripcion, 0, 1);
            this.tblLayoutPanelParametrosBusqueda.Controls.Add(this.txtBoxDescripcion, 1, 1);
            this.tblLayoutPanelParametrosBusqueda.Controls.Add(this.lblCodigoArticuloProveedor, 3, 0);
            this.tblLayoutPanelParametrosBusqueda.Controls.Add(this.txtBoxCodigoArticuloProveedor, 4, 0);
            this.tblLayoutPanelParametrosBusqueda.Controls.Add(this.chckBoxDescuentosActivos, 7, 1);
            this.tblLayoutPanelParametrosBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelParametrosBusqueda.Location = new System.Drawing.Point(4, 4);
            this.tblLayoutPanelParametrosBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.tblLayoutPanelParametrosBusqueda.Name = "tblLayoutPanelParametrosBusqueda";
            this.tblLayoutPanelParametrosBusqueda.RowCount = 3;
            this.tblLayoutPanelParametrosBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelParametrosBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelParametrosBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelParametrosBusqueda.Size = new System.Drawing.Size(1029, 157);
            this.tblLayoutPanelParametrosBusqueda.TabIndex = 0;
            // 
            // lblCodigoOriginal
            // 
            this.lblCodigoOriginal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoOriginal.AutoSize = true;
            this.lblCodigoOriginal.Depth = 0;
            this.lblCodigoOriginal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCodigoOriginal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCodigoOriginal.Location = new System.Drawing.Point(13, 14);
            this.lblCodigoOriginal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoOriginal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodigoOriginal.Name = "lblCodigoOriginal";
            this.lblCodigoOriginal.Size = new System.Drawing.Size(146, 24);
            this.lblCodigoOriginal.TabIndex = 0;
            this.lblCodigoOriginal.Text = "Código Original:";
            // 
            // lblModelo
            // 
            this.lblModelo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblModelo.AutoSize = true;
            this.lblModelo.Depth = 0;
            this.lblModelo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblModelo.Location = new System.Drawing.Point(420, 66);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(80, 24);
            this.lblModelo.TabIndex = 3;
            this.lblModelo.Text = "Modelo:";
            // 
            // txtBoxCodigoOriginal
            // 
            this.txtBoxCodigoOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoOriginal.Depth = 0;
            this.txtBoxCodigoOriginal.Hint = "";
            this.txtBoxCodigoOriginal.Location = new System.Drawing.Point(167, 12);
            this.txtBoxCodigoOriginal.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.txtBoxCodigoOriginal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCodigoOriginal.Name = "txtBoxCodigoOriginal";
            this.txtBoxCodigoOriginal.PasswordChar = '\0';
            this.txtBoxCodigoOriginal.SelectedText = "";
            this.txtBoxCodigoOriginal.SelectionLength = 0;
            this.txtBoxCodigoOriginal.SelectionStart = 0;
            this.txtBoxCodigoOriginal.Size = new System.Drawing.Size(128, 28);
            this.txtBoxCodigoOriginal.TabIndex = 7;
            this.txtBoxCodigoOriginal.UseSystemPasswordChar = false;
            this.txtBoxCodigoOriginal.Leave += new System.EventHandler(this.txtBoxCodigoOriginal_Leave);
            // 
            // txtBoxModelo
            // 
            this.txtBoxModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxModelo.Depth = 0;
            this.txtBoxModelo.Hint = "";
            this.txtBoxModelo.Location = new System.Drawing.Point(508, 64);
            this.txtBoxModelo.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.txtBoxModelo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxModelo.Name = "txtBoxModelo";
            this.txtBoxModelo.PasswordChar = '\0';
            this.txtBoxModelo.SelectedText = "";
            this.txtBoxModelo.SelectionLength = 0;
            this.txtBoxModelo.SelectionStart = 0;
            this.txtBoxModelo.Size = new System.Drawing.Size(128, 28);
            this.txtBoxModelo.TabIndex = 9;
            this.txtBoxModelo.UseSystemPasswordChar = false;
            this.txtBoxModelo.Leave += new System.EventHandler(this.txtBoxModelo_Leave);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Location = new System.Drawing.Point(849, 108);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(137, 44);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblProveedor
            // 
            this.lblProveedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Depth = 0;
            this.lblProveedor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProveedor.Location = new System.Drawing.Point(740, 14);
            this.lblProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(101, 24);
            this.lblProveedor.TabIndex = 5;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // cmbBoxProveedores
            // 
            this.cmbBoxProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxProveedores.FormattingEnabled = true;
            this.cmbBoxProveedores.Location = new System.Drawing.Point(849, 13);
            this.cmbBoxProveedores.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.cmbBoxProveedores.Name = "cmbBoxProveedores";
            this.cmbBoxProveedores.Size = new System.Drawing.Size(128, 24);
            this.cmbBoxProveedores.TabIndex = 10;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Depth = 0;
            this.lblDescripcion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescripcion.Location = new System.Drawing.Point(44, 66);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(115, 24);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescripcion.Depth = 0;
            this.txtBoxDescripcion.Hint = "";
            this.txtBoxDescripcion.Location = new System.Drawing.Point(167, 64);
            this.txtBoxDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.txtBoxDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.PasswordChar = '\0';
            this.txtBoxDescripcion.SelectedText = "";
            this.txtBoxDescripcion.SelectionLength = 0;
            this.txtBoxDescripcion.SelectionStart = 0;
            this.txtBoxDescripcion.Size = new System.Drawing.Size(128, 28);
            this.txtBoxDescripcion.TabIndex = 8;
            this.txtBoxDescripcion.UseSystemPasswordChar = false;
            this.txtBoxDescripcion.Leave += new System.EventHandler(this.txtBoxDescripcion_Leave);
            // 
            // lblCodigoArticuloProveedor
            // 
            this.lblCodigoArticuloProveedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoArticuloProveedor.AutoSize = true;
            this.lblCodigoArticuloProveedor.Depth = 0;
            this.lblCodigoArticuloProveedor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCodigoArticuloProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCodigoArticuloProveedor.Location = new System.Drawing.Point(359, 2);
            this.lblCodigoArticuloProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoArticuloProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodigoArticuloProveedor.Name = "lblCodigoArticuloProveedor";
            this.lblCodigoArticuloProveedor.Size = new System.Drawing.Size(141, 48);
            this.lblCodigoArticuloProveedor.TabIndex = 1;
            this.lblCodigoArticuloProveedor.Text = "Código Artículo Proveedor:";
            this.lblCodigoArticuloProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxCodigoArticuloProveedor
            // 
            this.txtBoxCodigoArticuloProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoArticuloProveedor.Depth = 0;
            this.txtBoxCodigoArticuloProveedor.Hint = "";
            this.txtBoxCodigoArticuloProveedor.Location = new System.Drawing.Point(508, 12);
            this.txtBoxCodigoArticuloProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.txtBoxCodigoArticuloProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCodigoArticuloProveedor.Name = "txtBoxCodigoArticuloProveedor";
            this.txtBoxCodigoArticuloProveedor.PasswordChar = '\0';
            this.txtBoxCodigoArticuloProveedor.SelectedText = "";
            this.txtBoxCodigoArticuloProveedor.SelectionLength = 0;
            this.txtBoxCodigoArticuloProveedor.SelectionStart = 0;
            this.txtBoxCodigoArticuloProveedor.Size = new System.Drawing.Size(128, 28);
            this.txtBoxCodigoArticuloProveedor.TabIndex = 6;
            this.txtBoxCodigoArticuloProveedor.UseSystemPasswordChar = false;
            this.txtBoxCodigoArticuloProveedor.Leave += new System.EventHandler(this.txtBoxCodigoArticuloProveedor_Leave);
            // 
            // chckBoxDescuentosActivos
            // 
            this.chckBoxDescuentosActivos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chckBoxDescuentosActivos.AutoSize = true;
            this.chckBoxDescuentosActivos.Depth = 0;
            this.chckBoxDescuentosActivos.Font = new System.Drawing.Font("Roboto", 10F);
            this.chckBoxDescuentosActivos.Location = new System.Drawing.Point(845, 52);
            this.chckBoxDescuentosActivos.Margin = new System.Windows.Forms.Padding(0);
            this.chckBoxDescuentosActivos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chckBoxDescuentosActivos.MouseState = MaterialSkin.MouseState.HOVER;
            this.chckBoxDescuentosActivos.Name = "chckBoxDescuentosActivos";
            this.chckBoxDescuentosActivos.Ripple = true;
            this.chckBoxDescuentosActivos.Size = new System.Drawing.Size(145, 30);
            this.chckBoxDescuentosActivos.TabIndex = 4;
            this.chckBoxDescuentosActivos.Text = "Tiene Descuentos Vigentes";
            this.chckBoxDescuentosActivos.UseVisualStyleBackColor = true;
            // 
            // grpBoxDescuento
            // 
            this.grpBoxDescuento.Controls.Add(this.tblLayoutPanelParametrosDescuento);
            this.grpBoxDescuento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDescuento.Location = new System.Drawing.Point(4, 429);
            this.grpBoxDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxDescuento.Name = "grpBoxDescuento";
            this.grpBoxDescuento.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxDescuento.Size = new System.Drawing.Size(1045, 142);
            this.grpBoxDescuento.TabIndex = 2;
            this.grpBoxDescuento.TabStop = false;
            this.grpBoxDescuento.Text = "Descuento";
            // 
            // tblLayoutPanelParametrosDescuento
            // 
            this.tblLayoutPanelParametrosDescuento.ColumnCount = 8;
            this.tblLayoutPanelParametrosDescuento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tblLayoutPanelParametrosDescuento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelParametrosDescuento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tblLayoutPanelParametrosDescuento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tblLayoutPanelParametrosDescuento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelParametrosDescuento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tblLayoutPanelParametrosDescuento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelParametrosDescuento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblLayoutPanelParametrosDescuento.Controls.Add(this.txtBoxPorcentajeDescuento, 1, 1);
            this.tblLayoutPanelParametrosDescuento.Controls.Add(this.lblFechaHastaDescuento, 3, 1);
            this.tblLayoutPanelParametrosDescuento.Controls.Add(this.dtpFechaHastaDescuento, 4, 1);
            this.tblLayoutPanelParametrosDescuento.Controls.Add(this.cmbBoxPorcentajeDescuento, 1, 0);
            this.tblLayoutPanelParametrosDescuento.Controls.Add(this.lblPorcentajeDescuento, 0, 0);
            this.tblLayoutPanelParametrosDescuento.Controls.Add(this.lblFechaDesdeDescuento, 3, 0);
            this.tblLayoutPanelParametrosDescuento.Controls.Add(this.lblDescripcionDescuento, 5, 0);
            this.tblLayoutPanelParametrosDescuento.Controls.Add(this.dtpFechaDesdeDescuento, 4, 0);
            this.tblLayoutPanelParametrosDescuento.Controls.Add(this.txtBoxDescripcionDescuento, 6, 0);
            this.tblLayoutPanelParametrosDescuento.Controls.Add(this.btnGuardarDescuento, 6, 1);
            this.tblLayoutPanelParametrosDescuento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelParametrosDescuento.Location = new System.Drawing.Point(4, 19);
            this.tblLayoutPanelParametrosDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.tblLayoutPanelParametrosDescuento.Name = "tblLayoutPanelParametrosDescuento";
            this.tblLayoutPanelParametrosDescuento.RowCount = 2;
            this.tblLayoutPanelParametrosDescuento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tblLayoutPanelParametrosDescuento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tblLayoutPanelParametrosDescuento.Size = new System.Drawing.Size(1037, 119);
            this.tblLayoutPanelParametrosDescuento.TabIndex = 0;
            // 
            // txtBoxPorcentajeDescuento
            // 
            this.txtBoxPorcentajeDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPorcentajeDescuento.Depth = 0;
            this.txtBoxPorcentajeDescuento.Hint = "";
            this.txtBoxPorcentajeDescuento.Location = new System.Drawing.Point(167, 79);
            this.txtBoxPorcentajeDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPorcentajeDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxPorcentajeDescuento.Name = "txtBoxPorcentajeDescuento";
            this.txtBoxPorcentajeDescuento.PasswordChar = '\0';
            this.txtBoxPorcentajeDescuento.SelectedText = "";
            this.txtBoxPorcentajeDescuento.SelectionLength = 0;
            this.txtBoxPorcentajeDescuento.SelectionStart = 0;
            this.txtBoxPorcentajeDescuento.Size = new System.Drawing.Size(151, 28);
            this.txtBoxPorcentajeDescuento.TabIndex = 5;
            this.txtBoxPorcentajeDescuento.UseSystemPasswordChar = false;
            this.txtBoxPorcentajeDescuento.Leave += new System.EventHandler(this.txtBoxPorcentajeDescuento_Leave);
            // 
            // lblFechaHastaDescuento
            // 
            this.lblFechaHastaDescuento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFechaHastaDescuento.AutoSize = true;
            this.lblFechaHastaDescuento.Depth = 0;
            this.lblFechaHastaDescuento.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaHastaDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaHastaDescuento.Location = new System.Drawing.Point(393, 81);
            this.lblFechaHastaDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHastaDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaHastaDescuento.Name = "lblFechaHastaDescuento";
            this.lblFechaHastaDescuento.Size = new System.Drawing.Size(121, 24);
            this.lblFechaHastaDescuento.TabIndex = 2;
            this.lblFechaHastaDescuento.Text = "Fecha Hasta:";
            // 
            // dtpFechaHastaDescuento
            // 
            this.dtpFechaHastaDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaHastaDescuento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHastaDescuento.Location = new System.Drawing.Point(522, 82);
            this.dtpFechaHastaDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaHastaDescuento.Name = "dtpFechaHastaDescuento";
            this.dtpFechaHastaDescuento.Size = new System.Drawing.Size(151, 22);
            this.dtpFechaHastaDescuento.TabIndex = 8;
            // 
            // cmbBoxPorcentajeDescuento
            // 
            this.cmbBoxPorcentajeDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxPorcentajeDescuento.FormattingEnabled = true;
            this.cmbBoxPorcentajeDescuento.Location = new System.Drawing.Point(167, 18);
            this.cmbBoxPorcentajeDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxPorcentajeDescuento.Name = "cmbBoxPorcentajeDescuento";
            this.cmbBoxPorcentajeDescuento.Size = new System.Drawing.Size(151, 24);
            this.cmbBoxPorcentajeDescuento.TabIndex = 6;
            this.cmbBoxPorcentajeDescuento.SelectionChangeCommitted += new System.EventHandler(this.cmbBoxPorcentajeDescuento_SelectionChangeCommitted);
            // 
            // lblPorcentajeDescuento
            // 
            this.lblPorcentajeDescuento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPorcentajeDescuento.AutoSize = true;
            this.lblPorcentajeDescuento.Depth = 0;
            this.lblPorcentajeDescuento.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPorcentajeDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPorcentajeDescuento.Location = new System.Drawing.Point(54, 19);
            this.lblPorcentajeDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPorcentajeDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPorcentajeDescuento.Name = "lblPorcentajeDescuento";
            this.lblPorcentajeDescuento.Size = new System.Drawing.Size(105, 24);
            this.lblPorcentajeDescuento.TabIndex = 3;
            this.lblPorcentajeDescuento.Text = "Porcentaje:";
            // 
            // lblFechaDesdeDescuento
            // 
            this.lblFechaDesdeDescuento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFechaDesdeDescuento.AutoSize = true;
            this.lblFechaDesdeDescuento.Depth = 0;
            this.lblFechaDesdeDescuento.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaDesdeDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaDesdeDescuento.Location = new System.Drawing.Point(390, 19);
            this.lblFechaDesdeDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesdeDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaDesdeDescuento.Name = "lblFechaDesdeDescuento";
            this.lblFechaDesdeDescuento.Size = new System.Drawing.Size(124, 24);
            this.lblFechaDesdeDescuento.TabIndex = 1;
            this.lblFechaDesdeDescuento.Text = "Fecha Desde:";
            // 
            // lblDescripcionDescuento
            // 
            this.lblDescripcionDescuento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescripcionDescuento.AutoSize = true;
            this.lblDescripcionDescuento.Depth = 0;
            this.lblDescripcionDescuento.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDescripcionDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescripcionDescuento.Location = new System.Drawing.Point(721, 19);
            this.lblDescripcionDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescripcionDescuento.Name = "lblDescripcionDescuento";
            this.lblDescripcionDescuento.Size = new System.Drawing.Size(115, 24);
            this.lblDescripcionDescuento.TabIndex = 0;
            this.lblDescripcionDescuento.Text = "Descripción:";
            // 
            // dtpFechaDesdeDescuento
            // 
            this.dtpFechaDesdeDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaDesdeDescuento.CustomFormat = "";
            this.dtpFechaDesdeDescuento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesdeDescuento.Location = new System.Drawing.Point(522, 20);
            this.dtpFechaDesdeDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaDesdeDescuento.Name = "dtpFechaDesdeDescuento";
            this.dtpFechaDesdeDescuento.Size = new System.Drawing.Size(151, 22);
            this.dtpFechaDesdeDescuento.TabIndex = 7;
            this.dtpFechaDesdeDescuento.ValueChanged += new System.EventHandler(this.dtpFechaDesdeDescuento_ValueChanged);
            // 
            // txtBoxDescripcionDescuento
            // 
            this.txtBoxDescripcionDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescripcionDescuento.Depth = 0;
            this.txtBoxDescripcionDescuento.Hint = "";
            this.txtBoxDescripcionDescuento.Location = new System.Drawing.Point(844, 17);
            this.txtBoxDescripcionDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxDescripcionDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDescripcionDescuento.Name = "txtBoxDescripcionDescuento";
            this.txtBoxDescripcionDescuento.PasswordChar = '\0';
            this.txtBoxDescripcionDescuento.SelectedText = "";
            this.txtBoxDescripcionDescuento.SelectionLength = 0;
            this.txtBoxDescripcionDescuento.SelectionStart = 0;
            this.txtBoxDescripcionDescuento.Size = new System.Drawing.Size(151, 28);
            this.txtBoxDescripcionDescuento.TabIndex = 4;
            this.txtBoxDescripcionDescuento.UseSystemPasswordChar = false;
            this.txtBoxDescripcionDescuento.Leave += new System.EventHandler(this.txtBoxDescripcionDescuento_Leave);
            // 
            // btnGuardarDescuento
            // 
            this.btnGuardarDescuento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardarDescuento.Depth = 0;
            this.btnGuardarDescuento.Location = new System.Drawing.Point(846, 66);
            this.btnGuardarDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarDescuento.Name = "btnGuardarDescuento";
            this.btnGuardarDescuento.Primary = true;
            this.btnGuardarDescuento.Size = new System.Drawing.Size(147, 49);
            this.btnGuardarDescuento.TabIndex = 9;
            this.btnGuardarDescuento.Text = "Agregar Descuento";
            this.btnGuardarDescuento.UseVisualStyleBackColor = true;
            this.btnGuardarDescuento.Click += new System.EventHandler(this.btnGuardarDescuento_Click);
            // 
            // epCodigoOriginal
            // 
            this.epCodigoOriginal.ContainerControl = this;
            // 
            // epDescripcionArticulo
            // 
            this.epDescripcionArticulo.ContainerControl = this;
            // 
            // epCodigoArticuloProveedor
            // 
            this.epCodigoArticuloProveedor.ContainerControl = this;
            // 
            // epModelo
            // 
            this.epModelo.ContainerControl = this;
            // 
            // epPorcentaje
            // 
            this.epPorcentaje.ContainerControl = this;
            // 
            // epDescripcionDescuento
            // 
            this.epDescripcionDescuento.ContainerControl = this;
            // 
            // frmABMDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 670);
            this.Controls.Add(this.pnlBase);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmABMDescuentos";
            this.Text = "frmABMDescuentos";
            this.pnlBase.ResumeLayout(false);
            this.tblLayoutPanelPrincipal.ResumeLayout(false);
            this.grpBoxDatosBusqueda.ResumeLayout(false);
            this.tblLayoutPanelParametrosBusquedaBase.ResumeLayout(false);
            this.tblLayoutPanelParametrosBusqueda.ResumeLayout(false);
            this.tblLayoutPanelParametrosBusqueda.PerformLayout();
            this.grpBoxDescuento.ResumeLayout(false);
            this.tblLayoutPanelParametrosDescuento.ResumeLayout(false);
            this.tblLayoutPanelParametrosDescuento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigoOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDescripcionArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigoArticuloProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPorcentaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDescripcionDescuento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelPrincipal;
        private System.Windows.Forms.GroupBox grpBoxResultadoBusqueda;
        private System.Windows.Forms.GroupBox grpBoxDatosBusqueda;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelParametrosBusqueda;
        private System.Windows.Forms.GroupBox grpBoxDescuento;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelParametrosDescuento;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelParametrosBusquedaBase;
        private MaterialSkin.Controls.MaterialLabel lblCodigoOriginal;
        private MaterialSkin.Controls.MaterialLabel lblCodigoArticuloProveedor;
        private MaterialSkin.Controls.MaterialLabel lblDescripcion;
        private MaterialSkin.Controls.MaterialLabel lblModelo;
        private MaterialSkin.Controls.MaterialCheckBox chckBoxDescuentosActivos;
        private MaterialSkin.Controls.MaterialLabel lblProveedor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCodigoArticuloProveedor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCodigoOriginal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxDescripcion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxModelo;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private System.Windows.Forms.ComboBox cmbBoxProveedores;
        private MaterialSkin.Controls.MaterialLabel lblDescripcionDescuento;
        private MaterialSkin.Controls.MaterialLabel lblFechaDesdeDescuento;
        private MaterialSkin.Controls.MaterialLabel lblFechaHastaDescuento;
        private MaterialSkin.Controls.MaterialLabel lblPorcentajeDescuento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxDescripcionDescuento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxPorcentajeDescuento;
        private System.Windows.Forms.ComboBox cmbBoxPorcentajeDescuento;
        private System.Windows.Forms.DateTimePicker dtpFechaDesdeDescuento;
        private System.Windows.Forms.DateTimePicker dtpFechaHastaDescuento;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardarDescuento;
        private System.Windows.Forms.ErrorProvider epCodigoOriginal;
        private System.Windows.Forms.ErrorProvider epDescripcionArticulo;
        private System.Windows.Forms.ErrorProvider epCodigoArticuloProveedor;
        private System.Windows.Forms.ErrorProvider epModelo;
        private System.Windows.Forms.ErrorProvider epPorcentaje;
        private System.Windows.Forms.ErrorProvider epDescripcionDescuento;
    }
}