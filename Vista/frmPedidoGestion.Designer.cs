namespace Vista
{
    partial class frmPedidoGestion
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
            this.pnlBase = new System.Windows.Forms.Panel();
            this.tblLayoutPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxResultadoBusqueda = new System.Windows.Forms.GroupBox();
            this.dgvResultadoBusqueda = new System.Windows.Forms.DataGridView();
            this.tblLayoutPanelParametrosBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelParametrosBusqueda_2 = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxFacturadoElectronicamente = new System.Windows.Forms.GroupBox();
            this.chckdListBoxFacturadoElectronicamente = new System.Windows.Forms.CheckedListBox();
            this.grpBoxTipoPedido = new System.Windows.Forms.GroupBox();
            this.chckdListBoxTipoPedido = new System.Windows.Forms.CheckedListBox();
            this.grpBoxTipoComprobante = new System.Windows.Forms.GroupBox();
            this.chckdListBoxTipoComprobante = new System.Windows.Forms.CheckedListBox();
            this.grpBoxEntreFechas = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelEntreFechas = new System.Windows.Forms.TableLayoutPanel();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaHasta = new MaterialSkin.Controls.MaterialLabel();
            this.tblLayoutPanelParametrosBusqueda_1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumeroPedido = new MaterialSkin.Controls.MaterialLabel();
            this.lblNombre = new MaterialSkin.Controls.MaterialLabel();
            this.lblCAE = new MaterialSkin.Controls.MaterialLabel();
            this.lblApellido = new MaterialSkin.Controls.MaterialLabel();
            this.lblNumeroDocumento = new MaterialSkin.Controls.MaterialLabel();
            this.lblRazonSocial = new MaterialSkin.Controls.MaterialLabel();
            this.txtBoxNumeroPedido = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxCAE = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxApellido = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxRazonSocial = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxNumeroDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tblLayoutPanelBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnImprimir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnVerDetalles = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnFacturar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlBase.SuspendLayout();
            this.tblLayoutPanelPrincipal.SuspendLayout();
            this.grpBoxResultadoBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoBusqueda)).BeginInit();
            this.tblLayoutPanelParametrosBusqueda.SuspendLayout();
            this.tblLayoutPanelParametrosBusqueda_2.SuspendLayout();
            this.grpBoxFacturadoElectronicamente.SuspendLayout();
            this.grpBoxTipoPedido.SuspendLayout();
            this.grpBoxTipoComprobante.SuspendLayout();
            this.grpBoxEntreFechas.SuspendLayout();
            this.tblLayoutPanelEntreFechas.SuspendLayout();
            this.tblLayoutPanelParametrosBusqueda_1.SuspendLayout();
            this.tblLayoutPanelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.tblLayoutPanelPrincipal);
            this.pnlBase.Location = new System.Drawing.Point(12, 72);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(1401, 718);
            this.pnlBase.TabIndex = 0;
            // 
            // tblLayoutPanelPrincipal
            // 
            this.tblLayoutPanelPrincipal.ColumnCount = 1;
            this.tblLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal.Controls.Add(this.grpBoxResultadoBusqueda, 0, 2);
            this.tblLayoutPanelPrincipal.Controls.Add(this.tblLayoutPanelParametrosBusqueda, 0, 0);
            this.tblLayoutPanelPrincipal.Controls.Add(this.tblLayoutPanelBotones, 0, 3);
            this.tblLayoutPanelPrincipal.Controls.Add(this.btnBuscar, 0, 1);
            this.tblLayoutPanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanelPrincipal.Name = "tblLayoutPanelPrincipal";
            this.tblLayoutPanelPrincipal.RowCount = 4;
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tblLayoutPanelPrincipal.Size = new System.Drawing.Size(1401, 521);
            this.tblLayoutPanelPrincipal.TabIndex = 0;
            // 
            // grpBoxResultadoBusqueda
            // 
            this.grpBoxResultadoBusqueda.Controls.Add(this.dgvResultadoBusqueda);
            this.grpBoxResultadoBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxResultadoBusqueda.Location = new System.Drawing.Point(3, 318);
            this.grpBoxResultadoBusqueda.Name = "grpBoxResultadoBusqueda";
            this.grpBoxResultadoBusqueda.Size = new System.Drawing.Size(1395, 135);
            this.grpBoxResultadoBusqueda.TabIndex = 1;
            this.grpBoxResultadoBusqueda.TabStop = false;
            this.grpBoxResultadoBusqueda.Text = "Resultado Búsqueda";
            // 
            // dgvResultadoBusqueda
            // 
            this.dgvResultadoBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadoBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultadoBusqueda.Location = new System.Drawing.Point(3, 18);
            this.dgvResultadoBusqueda.Name = "dgvResultadoBusqueda";
            this.dgvResultadoBusqueda.RowTemplate.Height = 24;
            this.dgvResultadoBusqueda.Size = new System.Drawing.Size(1389, 114);
            this.dgvResultadoBusqueda.TabIndex = 3;
            this.dgvResultadoBusqueda.SelectionChanged += new System.EventHandler(this.dgvResultadoBusqueda_SelectionChanged);
            // 
            // tblLayoutPanelParametrosBusqueda
            // 
            this.tblLayoutPanelParametrosBusqueda.ColumnCount = 1;
            this.tblLayoutPanelParametrosBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelParametrosBusqueda.Controls.Add(this.tblLayoutPanelParametrosBusqueda_2, 0, 1);
            this.tblLayoutPanelParametrosBusqueda.Controls.Add(this.tblLayoutPanelParametrosBusqueda_1, 0, 0);
            this.tblLayoutPanelParametrosBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelParametrosBusqueda.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelParametrosBusqueda.Name = "tblLayoutPanelParametrosBusqueda";
            this.tblLayoutPanelParametrosBusqueda.RowCount = 2;
            this.tblLayoutPanelParametrosBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelParametrosBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tblLayoutPanelParametrosBusqueda.Size = new System.Drawing.Size(1395, 244);
            this.tblLayoutPanelParametrosBusqueda.TabIndex = 0;
            // 
            // tblLayoutPanelParametrosBusqueda_2
            // 
            this.tblLayoutPanelParametrosBusqueda_2.ColumnCount = 4;
            this.tblLayoutPanelParametrosBusqueda_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelParametrosBusqueda_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelParametrosBusqueda_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelParametrosBusqueda_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelParametrosBusqueda_2.Controls.Add(this.grpBoxFacturadoElectronicamente, 3, 0);
            this.tblLayoutPanelParametrosBusqueda_2.Controls.Add(this.grpBoxTipoPedido, 1, 0);
            this.tblLayoutPanelParametrosBusqueda_2.Controls.Add(this.grpBoxTipoComprobante, 2, 0);
            this.tblLayoutPanelParametrosBusqueda_2.Controls.Add(this.grpBoxEntreFechas, 0, 0);
            this.tblLayoutPanelParametrosBusqueda_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelParametrosBusqueda_2.Location = new System.Drawing.Point(3, 97);
            this.tblLayoutPanelParametrosBusqueda_2.Name = "tblLayoutPanelParametrosBusqueda_2";
            this.tblLayoutPanelParametrosBusqueda_2.RowCount = 1;
            this.tblLayoutPanelParametrosBusqueda_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelParametrosBusqueda_2.Size = new System.Drawing.Size(1389, 144);
            this.tblLayoutPanelParametrosBusqueda_2.TabIndex = 5;
            // 
            // grpBoxFacturadoElectronicamente
            // 
            this.grpBoxFacturadoElectronicamente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxFacturadoElectronicamente.Controls.Add(this.chckdListBoxFacturadoElectronicamente);
            this.grpBoxFacturadoElectronicamente.Location = new System.Drawing.Point(1081, 3);
            this.grpBoxFacturadoElectronicamente.Margin = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.grpBoxFacturadoElectronicamente.Name = "grpBoxFacturadoElectronicamente";
            this.grpBoxFacturadoElectronicamente.Size = new System.Drawing.Size(268, 138);
            this.grpBoxFacturadoElectronicamente.TabIndex = 5;
            this.grpBoxFacturadoElectronicamente.TabStop = false;
            this.grpBoxFacturadoElectronicamente.Text = "Facturado AFIP";
            // 
            // chckdListBoxFacturadoElectronicamente
            // 
            this.chckdListBoxFacturadoElectronicamente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chckdListBoxFacturadoElectronicamente.FormattingEnabled = true;
            this.chckdListBoxFacturadoElectronicamente.Location = new System.Drawing.Point(3, 18);
            this.chckdListBoxFacturadoElectronicamente.Name = "chckdListBoxFacturadoElectronicamente";
            this.chckdListBoxFacturadoElectronicamente.Size = new System.Drawing.Size(262, 117);
            this.chckdListBoxFacturadoElectronicamente.TabIndex = 0;
            // 
            // grpBoxTipoPedido
            // 
            this.grpBoxTipoPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxTipoPedido.Controls.Add(this.chckdListBoxTipoPedido);
            this.grpBoxTipoPedido.Location = new System.Drawing.Point(387, 3);
            this.grpBoxTipoPedido.Margin = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.grpBoxTipoPedido.Name = "grpBoxTipoPedido";
            this.grpBoxTipoPedido.Size = new System.Drawing.Size(267, 138);
            this.grpBoxTipoPedido.TabIndex = 3;
            this.grpBoxTipoPedido.TabStop = false;
            this.grpBoxTipoPedido.Text = "Tipo Pedido";
            // 
            // chckdListBoxTipoPedido
            // 
            this.chckdListBoxTipoPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chckdListBoxTipoPedido.FormattingEnabled = true;
            this.chckdListBoxTipoPedido.Location = new System.Drawing.Point(3, 18);
            this.chckdListBoxTipoPedido.Name = "chckdListBoxTipoPedido";
            this.chckdListBoxTipoPedido.Size = new System.Drawing.Size(261, 117);
            this.chckdListBoxTipoPedido.TabIndex = 0;
            // 
            // grpBoxTipoComprobante
            // 
            this.grpBoxTipoComprobante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxTipoComprobante.Controls.Add(this.chckdListBoxTipoComprobante);
            this.grpBoxTipoComprobante.Location = new System.Drawing.Point(734, 3);
            this.grpBoxTipoComprobante.Margin = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.grpBoxTipoComprobante.Name = "grpBoxTipoComprobante";
            this.grpBoxTipoComprobante.Size = new System.Drawing.Size(267, 138);
            this.grpBoxTipoComprobante.TabIndex = 4;
            this.grpBoxTipoComprobante.TabStop = false;
            this.grpBoxTipoComprobante.Text = "Tipo Comprobante";
            // 
            // chckdListBoxTipoComprobante
            // 
            this.chckdListBoxTipoComprobante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chckdListBoxTipoComprobante.FormattingEnabled = true;
            this.chckdListBoxTipoComprobante.Location = new System.Drawing.Point(3, 18);
            this.chckdListBoxTipoComprobante.Name = "chckdListBoxTipoComprobante";
            this.chckdListBoxTipoComprobante.Size = new System.Drawing.Size(261, 117);
            this.chckdListBoxTipoComprobante.TabIndex = 1;
            // 
            // grpBoxEntreFechas
            // 
            this.grpBoxEntreFechas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxEntreFechas.Controls.Add(this.tblLayoutPanelEntreFechas);
            this.grpBoxEntreFechas.Location = new System.Drawing.Point(40, 3);
            this.grpBoxEntreFechas.Margin = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.grpBoxEntreFechas.Name = "grpBoxEntreFechas";
            this.grpBoxEntreFechas.Size = new System.Drawing.Size(267, 138);
            this.grpBoxEntreFechas.TabIndex = 2;
            this.grpBoxEntreFechas.TabStop = false;
            this.grpBoxEntreFechas.Text = "Período";
            // 
            // tblLayoutPanelEntreFechas
            // 
            this.tblLayoutPanelEntreFechas.ColumnCount = 2;
            this.tblLayoutPanelEntreFechas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.61303F));
            this.tblLayoutPanelEntreFechas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.38697F));
            this.tblLayoutPanelEntreFechas.Controls.Add(this.dtpDesde, 1, 0);
            this.tblLayoutPanelEntreFechas.Controls.Add(this.dtpHasta, 1, 1);
            this.tblLayoutPanelEntreFechas.Controls.Add(this.lblFechaDesde, 0, 0);
            this.tblLayoutPanelEntreFechas.Controls.Add(this.lblFechaHasta, 0, 1);
            this.tblLayoutPanelEntreFechas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelEntreFechas.Location = new System.Drawing.Point(3, 18);
            this.tblLayoutPanelEntreFechas.Name = "tblLayoutPanelEntreFechas";
            this.tblLayoutPanelEntreFechas.RowCount = 2;
            this.tblLayoutPanelEntreFechas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelEntreFechas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelEntreFechas.Size = new System.Drawing.Size(261, 117);
            this.tblLayoutPanelEntreFechas.TabIndex = 0;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(109, 18);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(149, 22);
            this.dtpDesde.TabIndex = 0;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(109, 76);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(149, 22);
            this.dtpHasta.TabIndex = 1;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Depth = 0;
            this.lblFechaDesde.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaDesde.Location = new System.Drawing.Point(35, 17);
            this.lblFechaDesde.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(68, 24);
            this.lblFechaDesde.TabIndex = 2;
            this.lblFechaDesde.Text = "Desde:";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Depth = 0;
            this.lblFechaHasta.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaHasta.Location = new System.Drawing.Point(28, 75);
            this.lblFechaHasta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(75, 24);
            this.lblFechaHasta.TabIndex = 3;
            this.lblFechaHasta.Text = "y hasta:";
            // 
            // tblLayoutPanelParametrosBusqueda_1
            // 
            this.tblLayoutPanelParametrosBusqueda_1.ColumnCount = 6;
            this.tblLayoutPanelParametrosBusqueda_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tblLayoutPanelParametrosBusqueda_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.27554F));
            this.tblLayoutPanelParametrosBusqueda_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblLayoutPanelParametrosBusqueda_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.66873F));
            this.tblLayoutPanelParametrosBusqueda_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tblLayoutPanelParametrosBusqueda_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.05573F));
            this.tblLayoutPanelParametrosBusqueda_1.Controls.Add(this.lblNumeroPedido, 0, 0);
            this.tblLayoutPanelParametrosBusqueda_1.Controls.Add(this.lblNombre, 0, 1);
            this.tblLayoutPanelParametrosBusqueda_1.Controls.Add(this.lblCAE, 2, 0);
            this.tblLayoutPanelParametrosBusqueda_1.Controls.Add(this.lblApellido, 2, 1);
            this.tblLayoutPanelParametrosBusqueda_1.Controls.Add(this.lblNumeroDocumento, 4, 0);
            this.tblLayoutPanelParametrosBusqueda_1.Controls.Add(this.lblRazonSocial, 4, 1);
            this.tblLayoutPanelParametrosBusqueda_1.Controls.Add(this.txtBoxNumeroPedido, 1, 0);
            this.tblLayoutPanelParametrosBusqueda_1.Controls.Add(this.txtBoxNombre, 1, 1);
            this.tblLayoutPanelParametrosBusqueda_1.Controls.Add(this.txtBoxCAE, 3, 0);
            this.tblLayoutPanelParametrosBusqueda_1.Controls.Add(this.txtBoxApellido, 3, 1);
            this.tblLayoutPanelParametrosBusqueda_1.Controls.Add(this.txtBoxRazonSocial, 5, 1);
            this.tblLayoutPanelParametrosBusqueda_1.Controls.Add(this.txtBoxNumeroDocumento, 5, 0);
            this.tblLayoutPanelParametrosBusqueda_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelParametrosBusqueda_1.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelParametrosBusqueda_1.Name = "tblLayoutPanelParametrosBusqueda_1";
            this.tblLayoutPanelParametrosBusqueda_1.RowCount = 2;
            this.tblLayoutPanelParametrosBusqueda_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelParametrosBusqueda_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelParametrosBusqueda_1.Size = new System.Drawing.Size(1389, 88);
            this.tblLayoutPanelParametrosBusqueda_1.TabIndex = 6;
            // 
            // lblNumeroPedido
            // 
            this.lblNumeroPedido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNumeroPedido.AutoSize = true;
            this.lblNumeroPedido.Depth = 0;
            this.lblNumeroPedido.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNumeroPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNumeroPedido.Location = new System.Drawing.Point(19, 10);
            this.lblNumeroPedido.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumeroPedido.Name = "lblNumeroPedido";
            this.lblNumeroPedido.Size = new System.Drawing.Size(148, 24);
            this.lblNumeroPedido.TabIndex = 0;
            this.lblNumeroPedido.Text = "Número Pedido:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Depth = 0;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombre.Location = new System.Drawing.Point(83, 54);
            this.lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(84, 24);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCAE
            // 
            this.lblCAE.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCAE.AutoSize = true;
            this.lblCAE.Depth = 0;
            this.lblCAE.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCAE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCAE.Location = new System.Drawing.Point(557, 10);
            this.lblCAE.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCAE.Name = "lblCAE";
            this.lblCAE.Size = new System.Drawing.Size(50, 24);
            this.lblCAE.TabIndex = 2;
            this.lblCAE.Text = "CAE:";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Depth = 0;
            this.lblApellido.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblApellido.Location = new System.Drawing.Point(527, 54);
            this.lblApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(80, 24);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Depth = 0;
            this.lblNumeroDocumento.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNumeroDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNumeroDocumento.Location = new System.Drawing.Point(889, 10);
            this.lblNumeroDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(185, 24);
            this.lblNumeroDocumento.TabIndex = 4;
            this.lblNumeroDocumento.Text = "Número Documento:";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Depth = 0;
            this.lblRazonSocial.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRazonSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRazonSocial.Location = new System.Drawing.Point(950, 54);
            this.lblRazonSocial.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(124, 24);
            this.lblRazonSocial.TabIndex = 5;
            this.lblRazonSocial.Text = "Razón Social:";
            // 
            // txtBoxNumeroPedido
            // 
            this.txtBoxNumeroPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNumeroPedido.Depth = 0;
            this.txtBoxNumeroPedido.Hint = "";
            this.txtBoxNumeroPedido.Location = new System.Drawing.Point(173, 8);
            this.txtBoxNumeroPedido.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxNumeroPedido.Name = "txtBoxNumeroPedido";
            this.txtBoxNumeroPedido.PasswordChar = '\0';
            this.txtBoxNumeroPedido.SelectedText = "";
            this.txtBoxNumeroPedido.SelectionLength = 0;
            this.txtBoxNumeroPedido.SelectionStart = 0;
            this.txtBoxNumeroPedido.Size = new System.Drawing.Size(334, 28);
            this.txtBoxNumeroPedido.TabIndex = 6;
            this.txtBoxNumeroPedido.UseSystemPasswordChar = false;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNombre.Depth = 0;
            this.txtBoxNombre.Hint = "";
            this.txtBoxNombre.Location = new System.Drawing.Point(173, 52);
            this.txtBoxNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.PasswordChar = '\0';
            this.txtBoxNombre.SelectedText = "";
            this.txtBoxNombre.SelectionLength = 0;
            this.txtBoxNombre.SelectionStart = 0;
            this.txtBoxNombre.Size = new System.Drawing.Size(334, 28);
            this.txtBoxNombre.TabIndex = 7;
            this.txtBoxNombre.UseSystemPasswordChar = false;
            // 
            // txtBoxCAE
            // 
            this.txtBoxCAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCAE.Depth = 0;
            this.txtBoxCAE.Hint = "";
            this.txtBoxCAE.Location = new System.Drawing.Point(613, 8);
            this.txtBoxCAE.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCAE.Name = "txtBoxCAE";
            this.txtBoxCAE.PasswordChar = '\0';
            this.txtBoxCAE.SelectedText = "";
            this.txtBoxCAE.SelectionLength = 0;
            this.txtBoxCAE.SelectionStart = 0;
            this.txtBoxCAE.Size = new System.Drawing.Size(256, 28);
            this.txtBoxCAE.TabIndex = 8;
            this.txtBoxCAE.UseSystemPasswordChar = false;
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxApellido.Depth = 0;
            this.txtBoxApellido.Hint = "";
            this.txtBoxApellido.Location = new System.Drawing.Point(613, 52);
            this.txtBoxApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.PasswordChar = '\0';
            this.txtBoxApellido.SelectedText = "";
            this.txtBoxApellido.SelectionLength = 0;
            this.txtBoxApellido.SelectionStart = 0;
            this.txtBoxApellido.Size = new System.Drawing.Size(256, 28);
            this.txtBoxApellido.TabIndex = 9;
            this.txtBoxApellido.UseSystemPasswordChar = false;
            // 
            // txtBoxRazonSocial
            // 
            this.txtBoxRazonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxRazonSocial.Depth = 0;
            this.txtBoxRazonSocial.Hint = "";
            this.txtBoxRazonSocial.Location = new System.Drawing.Point(1080, 52);
            this.txtBoxRazonSocial.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxRazonSocial.Name = "txtBoxRazonSocial";
            this.txtBoxRazonSocial.PasswordChar = '\0';
            this.txtBoxRazonSocial.SelectedText = "";
            this.txtBoxRazonSocial.SelectionLength = 0;
            this.txtBoxRazonSocial.SelectionStart = 0;
            this.txtBoxRazonSocial.Size = new System.Drawing.Size(306, 28);
            this.txtBoxRazonSocial.TabIndex = 10;
            this.txtBoxRazonSocial.UseSystemPasswordChar = false;
            // 
            // txtBoxNumeroDocumento
            // 
            this.txtBoxNumeroDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNumeroDocumento.Depth = 0;
            this.txtBoxNumeroDocumento.Hint = "";
            this.txtBoxNumeroDocumento.Location = new System.Drawing.Point(1080, 8);
            this.txtBoxNumeroDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxNumeroDocumento.Name = "txtBoxNumeroDocumento";
            this.txtBoxNumeroDocumento.PasswordChar = '\0';
            this.txtBoxNumeroDocumento.SelectedText = "";
            this.txtBoxNumeroDocumento.SelectionLength = 0;
            this.txtBoxNumeroDocumento.SelectionStart = 0;
            this.txtBoxNumeroDocumento.Size = new System.Drawing.Size(306, 28);
            this.txtBoxNumeroDocumento.TabIndex = 11;
            this.txtBoxNumeroDocumento.UseSystemPasswordChar = false;
            // 
            // tblLayoutPanelBotones
            // 
            this.tblLayoutPanelBotones.ColumnCount = 3;
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelBotones.Controls.Add(this.btnImprimir, 0, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.btnVerDetalles, 1, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.btnFacturar, 2, 0);
            this.tblLayoutPanelBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelBotones.Location = new System.Drawing.Point(3, 459);
            this.tblLayoutPanelBotones.Name = "tblLayoutPanelBotones";
            this.tblLayoutPanelBotones.RowCount = 1;
            this.tblLayoutPanelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelBotones.Size = new System.Drawing.Size(1395, 59);
            this.tblLayoutPanelBotones.TabIndex = 1;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnImprimir.Depth = 0;
            this.btnImprimir.Location = new System.Drawing.Point(494, 4);
            this.btnImprimir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Primary = true;
            this.btnImprimir.Size = new System.Drawing.Size(120, 50);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerDetalles.Depth = 0;
            this.btnVerDetalles.Location = new System.Drawing.Point(637, 4);
            this.btnVerDetalles.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Primary = true;
            this.btnVerDetalles.Size = new System.Drawing.Size(120, 50);
            this.btnVerDetalles.TabIndex = 1;
            this.btnVerDetalles.Text = "Ver Detalles";
            this.btnVerDetalles.UseVisualStyleBackColor = true;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnFacturar.Depth = 0;
            this.btnFacturar.Location = new System.Drawing.Point(780, 4);
            this.btnFacturar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Primary = true;
            this.btnFacturar.Size = new System.Drawing.Size(120, 50);
            this.btnFacturar.TabIndex = 2;
            this.btnFacturar.Text = "Facturar ";
            this.btnFacturar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Location = new System.Drawing.Point(640, 257);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(120, 50);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmPedidoGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 875);
            this.Controls.Add(this.pnlBase);
            this.Name = "frmPedidoGestion";
            this.Text = "frmPedido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPedidoGestion_FormClosing);
            this.pnlBase.ResumeLayout(false);
            this.tblLayoutPanelPrincipal.ResumeLayout(false);
            this.grpBoxResultadoBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoBusqueda)).EndInit();
            this.tblLayoutPanelParametrosBusqueda.ResumeLayout(false);
            this.tblLayoutPanelParametrosBusqueda_2.ResumeLayout(false);
            this.grpBoxFacturadoElectronicamente.ResumeLayout(false);
            this.grpBoxTipoPedido.ResumeLayout(false);
            this.grpBoxTipoComprobante.ResumeLayout(false);
            this.grpBoxEntreFechas.ResumeLayout(false);
            this.tblLayoutPanelEntreFechas.ResumeLayout(false);
            this.tblLayoutPanelEntreFechas.PerformLayout();
            this.tblLayoutPanelParametrosBusqueda_1.ResumeLayout(false);
            this.tblLayoutPanelParametrosBusqueda_1.PerformLayout();
            this.tblLayoutPanelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelPrincipal;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelParametrosBusqueda;
        private System.Windows.Forms.CheckedListBox chckdListBoxTipoPedido;
        private System.Windows.Forms.CheckedListBox chckdListBoxTipoComprobante;
        private System.Windows.Forms.GroupBox grpBoxEntreFechas;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelEntreFechas;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private MaterialSkin.Controls.MaterialLabel lblFechaDesde;
        private MaterialSkin.Controls.MaterialLabel lblFechaHasta;
        private System.Windows.Forms.GroupBox grpBoxTipoPedido;
        private System.Windows.Forms.GroupBox grpBoxTipoComprobante;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelParametrosBusqueda_2;
        private System.Windows.Forms.GroupBox grpBoxFacturadoElectronicamente;
        private System.Windows.Forms.CheckedListBox chckdListBoxFacturadoElectronicamente;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelParametrosBusqueda_1;
        private MaterialSkin.Controls.MaterialLabel lblNumeroPedido;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private MaterialSkin.Controls.MaterialLabel lblCAE;
        private MaterialSkin.Controls.MaterialLabel lblApellido;
        private MaterialSkin.Controls.MaterialLabel lblNumeroDocumento;
        private MaterialSkin.Controls.MaterialLabel lblRazonSocial;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxNumeroPedido;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCAE;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxApellido;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxRazonSocial;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxNumeroDocumento;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelBotones;
        private MaterialSkin.Controls.MaterialRaisedButton btnImprimir;
        private MaterialSkin.Controls.MaterialRaisedButton btnVerDetalles;
        private MaterialSkin.Controls.MaterialRaisedButton btnFacturar;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private System.Windows.Forms.DataGridView dgvResultadoBusqueda;
        private System.Windows.Forms.GroupBox grpBoxResultadoBusqueda;
    }
}