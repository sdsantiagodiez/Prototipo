namespace Vista
{
    partial class frmPedidoCierre
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
            this.selectorControlPrincipal = new MaterialSkin.Controls.MaterialTabSelector();
            this.tbControlPrincipal = new MaterialSkin.Controls.MaterialTabControl();
            this.tbPageDatosGenerales = new System.Windows.Forms.TabPage();
            this.tblLayoutPanelDatosGenerales = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelDatosEntidadMiddle = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelRazonSocial = new System.Windows.Forms.TableLayoutPanel();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtBoxRazonSocial = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.grpBoxObservaciones = new System.Windows.Forms.GroupBox();
            this.rchTextBoxObservaciones = new System.Windows.Forms.RichTextBox();
            this.tblLayoutPanelEntidadDatos = new System.Windows.Forms.TableLayoutPanel();
            this.cmbBoxContactoProveedor = new System.Windows.Forms.ComboBox();
            this.lblContactoProveedor = new System.Windows.Forms.Label();
            this.cmbBoxTipoResponsable = new System.Windows.Forms.ComboBox();
            this.lblTipoResponsable = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBoxNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbBoxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtBoxNumeroDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxApellido = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tblLayoutPanelPedido = new System.Windows.Forms.TableLayoutPanel();
            this.lblCAE = new System.Windows.Forms.Label();
            this.lblNumeroPedido = new System.Windows.Forms.Label();
            this.lblTipoComprobante = new System.Windows.Forms.Label();
            this.cmbBoxTipoComprobante = new System.Windows.Forms.ComboBox();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.cmbBoxFormaPago = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.txtBoxNumeroPedido = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxCAE = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbPageDomicilioFacturacion = new System.Windows.Forms.TabPage();
            this.tblLayoutPanelDomicilioFacturacion = new System.Windows.Forms.TableLayoutPanel();
            this.cmbBoxDomicilios = new System.Windows.Forms.ComboBox();
            this.tbPageDatosContacto = new System.Windows.Forms.TabPage();
            this.tblLayoutPanelDatosContacto = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxCorreoElectronico = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelCorreoElectronico = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelMail = new System.Windows.Forms.TableLayoutPanel();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtBoxMail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbBoxMails = new System.Windows.Forms.ComboBox();
            this.grpBoxTelefono = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelNumeroTelefono = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelTelefono = new System.Windows.Forms.TableLayoutPanel();
            this.cmbBoxTipoTelefono = new System.Windows.Forms.ComboBox();
            this.lblTipoTelefono = new System.Windows.Forms.Label();
            this.lblNumeroTelefono = new System.Windows.Forms.Label();
            this.txtBoxTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbBoxTelefonos = new System.Windows.Forms.ComboBox();
            this.tabPageObservaciones = new System.Windows.Forms.TabPage();
            this.tableLayoutObservaciones = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.grpBoxObservacionesPedido = new System.Windows.Forms.GroupBox();
            this.pnlObservaciones = new System.Windows.Forms.Panel();
            this.rchTextBoxObservacionesPedido = new System.Windows.Forms.RichTextBox();
            this.gbxArticulos = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelLineasPedidos = new System.Windows.Forms.TableLayoutPanel();
            this.dgvArticulosVenta = new System.Windows.Forms.DataGridView();
            this.indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorParcialSinDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorParcialConDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLayoutPanelLineasPedidosBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEditar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialFlatButton();
            this.tblLayoutPanelValoresPedido = new System.Windows.Forms.TableLayoutPanel();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDescuentoLineas = new System.Windows.Forms.Label();
            this.lblDescuentoTotal = new System.Windows.Forms.Label();
            this.lblDescuentoPorcentual = new System.Windows.Forms.Label();
            this.lblDescuentoNeto = new System.Windows.Forms.Label();
            this.lblSenia = new System.Windows.Forms.Label();
            this.txtBoxIVAPorcentaje = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxIVAMonto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxSenia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxDescuento1Porcentaje = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxDescuento1Monto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxDescuento2Porcentaje = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxDescuento2Monto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxDescuentoLineas = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxDescuentoTotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxSubtotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxTotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tblLayoutPanelBotones = new System.Windows.Forms.TableLayoutPanel();
            this.cmbBoxPedidosProveedores = new System.Windows.Forms.ComboBox();
            this.btnImprimir = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnFacturaElectronica = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialFlatButton();
            this.modeloLineaPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLayoutPanelPrincipal.SuspendLayout();
            this.tbControlPrincipal.SuspendLayout();
            this.tbPageDatosGenerales.SuspendLayout();
            this.tblLayoutPanelDatosGenerales.SuspendLayout();
            this.tblLayoutPanelDatosEntidadMiddle.SuspendLayout();
            this.tblLayoutPanelRazonSocial.SuspendLayout();
            this.grpBoxObservaciones.SuspendLayout();
            this.tblLayoutPanelEntidadDatos.SuspendLayout();
            this.tblLayoutPanelPedido.SuspendLayout();
            this.tbPageDomicilioFacturacion.SuspendLayout();
            this.tblLayoutPanelDomicilioFacturacion.SuspendLayout();
            this.tbPageDatosContacto.SuspendLayout();
            this.tblLayoutPanelDatosContacto.SuspendLayout();
            this.grpBoxCorreoElectronico.SuspendLayout();
            this.tblLayoutPanelCorreoElectronico.SuspendLayout();
            this.tblLayoutPanelMail.SuspendLayout();
            this.grpBoxTelefono.SuspendLayout();
            this.tblLayoutPanelNumeroTelefono.SuspendLayout();
            this.tblLayoutPanelTelefono.SuspendLayout();
            this.tabPageObservaciones.SuspendLayout();
            this.tableLayoutObservaciones.SuspendLayout();
            this.grpBoxObservacionesPedido.SuspendLayout();
            this.pnlObservaciones.SuspendLayout();
            this.gbxArticulos.SuspendLayout();
            this.tblLayoutPanelLineasPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosVenta)).BeginInit();
            this.tblLayoutPanelLineasPedidosBotones.SuspendLayout();
            this.tblLayoutPanelValoresPedido.SuspendLayout();
            this.tblLayoutPanelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modeloLineaPedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLayoutPanelPrincipal
            // 
            this.tblLayoutPanelPrincipal.BackColor = System.Drawing.Color.White;
            this.tblLayoutPanelPrincipal.ColumnCount = 1;
            this.tblLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal.Controls.Add(this.selectorControlPrincipal, 0, 0);
            this.tblLayoutPanelPrincipal.Controls.Add(this.tbControlPrincipal, 0, 1);
            this.tblLayoutPanelPrincipal.Controls.Add(this.gbxArticulos, 0, 2);
            this.tblLayoutPanelPrincipal.Controls.Add(this.tblLayoutPanelValoresPedido, 0, 3);
            this.tblLayoutPanelPrincipal.Controls.Add(this.tblLayoutPanelBotones, 0, 4);
            this.tblLayoutPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblLayoutPanelPrincipal.Location = new System.Drawing.Point(0, 55);
            this.tblLayoutPanelPrincipal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tblLayoutPanelPrincipal.Name = "tblLayoutPanelPrincipal";
            this.tblLayoutPanelPrincipal.RowCount = 5;
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tblLayoutPanelPrincipal.Size = new System.Drawing.Size(1015, 565);
            this.tblLayoutPanelPrincipal.TabIndex = 0;
            // 
            // selectorControlPrincipal
            // 
            this.selectorControlPrincipal.BackColor = System.Drawing.Color.White;
            this.selectorControlPrincipal.BaseTabControl = this.tbControlPrincipal;
            this.selectorControlPrincipal.Depth = 0;
            this.selectorControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectorControlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.selectorControlPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.selectorControlPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.selectorControlPrincipal.Name = "selectorControlPrincipal";
            this.selectorControlPrincipal.Size = new System.Drawing.Size(1015, 40);
            this.selectorControlPrincipal.TabIndex = 1;
            // 
            // tbControlPrincipal
            // 
            this.tbControlPrincipal.Controls.Add(this.tbPageDatosGenerales);
            this.tbControlPrincipal.Controls.Add(this.tbPageDomicilioFacturacion);
            this.tbControlPrincipal.Controls.Add(this.tbPageDatosContacto);
            this.tbControlPrincipal.Controls.Add(this.tabPageObservaciones);
            this.tbControlPrincipal.Depth = 0;
            this.tbControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControlPrincipal.Location = new System.Drawing.Point(3, 43);
            this.tbControlPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbControlPrincipal.Name = "tbControlPrincipal";
            this.tbControlPrincipal.SelectedIndex = 0;
            this.tbControlPrincipal.Size = new System.Drawing.Size(1009, 184);
            this.tbControlPrincipal.TabIndex = 1;
            // 
            // tbPageDatosGenerales
            // 
            this.tbPageDatosGenerales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbPageDatosGenerales.Controls.Add(this.tblLayoutPanelDatosGenerales);
            this.tbPageDatosGenerales.Location = new System.Drawing.Point(4, 22);
            this.tbPageDatosGenerales.Name = "tbPageDatosGenerales";
            this.tbPageDatosGenerales.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageDatosGenerales.Size = new System.Drawing.Size(1001, 158);
            this.tbPageDatosGenerales.TabIndex = 0;
            this.tbPageDatosGenerales.Text = "Datos Generales";
            // 
            // tblLayoutPanelDatosGenerales
            // 
            this.tblLayoutPanelDatosGenerales.ColumnCount = 3;
            this.tblLayoutPanelDatosGenerales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tblLayoutPanelDatosGenerales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDatosGenerales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.tblLayoutPanelDatosGenerales.Controls.Add(this.tblLayoutPanelDatosEntidadMiddle, 1, 0);
            this.tblLayoutPanelDatosGenerales.Controls.Add(this.tblLayoutPanelEntidadDatos, 0, 0);
            this.tblLayoutPanelDatosGenerales.Controls.Add(this.tblLayoutPanelPedido, 2, 0);
            this.tblLayoutPanelDatosGenerales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDatosGenerales.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelDatosGenerales.Name = "tblLayoutPanelDatosGenerales";
            this.tblLayoutPanelDatosGenerales.RowCount = 1;
            this.tblLayoutPanelDatosGenerales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDatosGenerales.Size = new System.Drawing.Size(995, 152);
            this.tblLayoutPanelDatosGenerales.TabIndex = 1;
            // 
            // tblLayoutPanelDatosEntidadMiddle
            // 
            this.tblLayoutPanelDatosEntidadMiddle.ColumnCount = 1;
            this.tblLayoutPanelDatosEntidadMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDatosEntidadMiddle.Controls.Add(this.tblLayoutPanelRazonSocial, 0, 0);
            this.tblLayoutPanelDatosEntidadMiddle.Controls.Add(this.grpBoxObservaciones, 0, 1);
            this.tblLayoutPanelDatosEntidadMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDatosEntidadMiddle.Location = new System.Drawing.Point(262, 2);
            this.tblLayoutPanelDatosEntidadMiddle.Margin = new System.Windows.Forms.Padding(2);
            this.tblLayoutPanelDatosEntidadMiddle.Name = "tblLayoutPanelDatosEntidadMiddle";
            this.tblLayoutPanelDatosEntidadMiddle.RowCount = 2;
            this.tblLayoutPanelDatosEntidadMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblLayoutPanelDatosEntidadMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDatosEntidadMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelDatosEntidadMiddle.Size = new System.Drawing.Size(469, 148);
            this.tblLayoutPanelDatosEntidadMiddle.TabIndex = 16;
            // 
            // tblLayoutPanelRazonSocial
            // 
            this.tblLayoutPanelRazonSocial.ColumnCount = 2;
            this.tblLayoutPanelRazonSocial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tblLayoutPanelRazonSocial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelRazonSocial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelRazonSocial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelRazonSocial.Controls.Add(this.lblRazonSocial, 0, 0);
            this.tblLayoutPanelRazonSocial.Controls.Add(this.txtBoxRazonSocial, 1, 0);
            this.tblLayoutPanelRazonSocial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelRazonSocial.Location = new System.Drawing.Point(2, 2);
            this.tblLayoutPanelRazonSocial.Margin = new System.Windows.Forms.Padding(2);
            this.tblLayoutPanelRazonSocial.Name = "tblLayoutPanelRazonSocial";
            this.tblLayoutPanelRazonSocial.RowCount = 1;
            this.tblLayoutPanelRazonSocial.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelRazonSocial.Size = new System.Drawing.Size(465, 26);
            this.tblLayoutPanelRazonSocial.TabIndex = 17;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblRazonSocial.Location = new System.Drawing.Point(6, 6);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(73, 13);
            this.lblRazonSocial.TabIndex = 11;
            this.lblRazonSocial.Text = "Razón Social:";
            this.lblRazonSocial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxRazonSocial
            // 
            this.txtBoxRazonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxRazonSocial.Depth = 0;
            this.txtBoxRazonSocial.Hint = "";
            this.txtBoxRazonSocial.Location = new System.Drawing.Point(85, 3);
            this.txtBoxRazonSocial.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.txtBoxRazonSocial.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxRazonSocial.Name = "txtBoxRazonSocial";
            this.txtBoxRazonSocial.PasswordChar = '\0';
            this.txtBoxRazonSocial.SelectedText = "";
            this.txtBoxRazonSocial.SelectionLength = 0;
            this.txtBoxRazonSocial.SelectionStart = 0;
            this.txtBoxRazonSocial.Size = new System.Drawing.Size(350, 23);
            this.txtBoxRazonSocial.TabIndex = 14;
            this.txtBoxRazonSocial.UseSystemPasswordChar = false;
            this.txtBoxRazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxRazonSocial_KeyPress);
            this.txtBoxRazonSocial.Leave += new System.EventHandler(this.txtBoxRazonSocial_Leave);
            // 
            // grpBoxObservaciones
            // 
            this.grpBoxObservaciones.Controls.Add(this.rchTextBoxObservaciones);
            this.grpBoxObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxObservaciones.Location = new System.Drawing.Point(3, 33);
            this.grpBoxObservaciones.Name = "grpBoxObservaciones";
            this.grpBoxObservaciones.Size = new System.Drawing.Size(463, 112);
            this.grpBoxObservaciones.TabIndex = 13;
            this.grpBoxObservaciones.TabStop = false;
            this.grpBoxObservaciones.Text = "Observaciones";
            // 
            // rchTextBoxObservaciones
            // 
            this.rchTextBoxObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchTextBoxObservaciones.Location = new System.Drawing.Point(3, 16);
            this.rchTextBoxObservaciones.Name = "rchTextBoxObservaciones";
            this.rchTextBoxObservaciones.Size = new System.Drawing.Size(457, 93);
            this.rchTextBoxObservaciones.TabIndex = 26;
            this.rchTextBoxObservaciones.Text = "";
            // 
            // tblLayoutPanelEntidadDatos
            // 
            this.tblLayoutPanelEntidadDatos.ColumnCount = 3;
            this.tblLayoutPanelEntidadDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tblLayoutPanelEntidadDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelEntidadDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelEntidadDatos.Controls.Add(this.cmbBoxContactoProveedor, 1, 4);
            this.tblLayoutPanelEntidadDatos.Controls.Add(this.lblContactoProveedor, 0, 4);
            this.tblLayoutPanelEntidadDatos.Controls.Add(this.cmbBoxTipoResponsable, 1, 0);
            this.tblLayoutPanelEntidadDatos.Controls.Add(this.lblTipoResponsable, 0, 0);
            this.tblLayoutPanelEntidadDatos.Controls.Add(this.lblNombre, 0, 3);
            this.tblLayoutPanelEntidadDatos.Controls.Add(this.txtBoxNombre, 1, 3);
            this.tblLayoutPanelEntidadDatos.Controls.Add(this.cmbBoxTipoDocumento, 0, 1);
            this.tblLayoutPanelEntidadDatos.Controls.Add(this.lblApellido, 0, 2);
            this.tblLayoutPanelEntidadDatos.Controls.Add(this.txtBoxNumeroDocumento, 1, 1);
            this.tblLayoutPanelEntidadDatos.Controls.Add(this.txtBoxApellido, 1, 2);
            this.tblLayoutPanelEntidadDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelEntidadDatos.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelEntidadDatos.Name = "tblLayoutPanelEntidadDatos";
            this.tblLayoutPanelEntidadDatos.RowCount = 5;
            this.tblLayoutPanelEntidadDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayoutPanelEntidadDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayoutPanelEntidadDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayoutPanelEntidadDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayoutPanelEntidadDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayoutPanelEntidadDatos.Size = new System.Drawing.Size(254, 146);
            this.tblLayoutPanelEntidadDatos.TabIndex = 1;
            // 
            // cmbBoxContactoProveedor
            // 
            this.cmbBoxContactoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxContactoProveedor.FormattingEnabled = true;
            this.cmbBoxContactoProveedor.Location = new System.Drawing.Point(78, 120);
            this.cmbBoxContactoProveedor.MinimumSize = new System.Drawing.Size(97, 0);
            this.cmbBoxContactoProveedor.Name = "cmbBoxContactoProveedor";
            this.cmbBoxContactoProveedor.Size = new System.Drawing.Size(153, 21);
            this.cmbBoxContactoProveedor.TabIndex = 22;
            this.cmbBoxContactoProveedor.Visible = false;
            this.cmbBoxContactoProveedor.SelectedValueChanged += new System.EventHandler(this.cmbBoxContactoProveedor_SelectedValueChanged);
            // 
            // lblContactoProveedor
            // 
            this.lblContactoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContactoProveedor.AutoSize = true;
            this.lblContactoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblContactoProveedor.Location = new System.Drawing.Point(3, 124);
            this.lblContactoProveedor.Name = "lblContactoProveedor";
            this.lblContactoProveedor.Size = new System.Drawing.Size(69, 13);
            this.lblContactoProveedor.TabIndex = 21;
            this.lblContactoProveedor.Text = "Contacto:";
            this.lblContactoProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblContactoProveedor.Visible = false;
            // 
            // cmbBoxTipoResponsable
            // 
            this.cmbBoxTipoResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxTipoResponsable.FormattingEnabled = true;
            this.cmbBoxTipoResponsable.Location = new System.Drawing.Point(78, 4);
            this.cmbBoxTipoResponsable.Name = "cmbBoxTipoResponsable";
            this.cmbBoxTipoResponsable.Size = new System.Drawing.Size(153, 21);
            this.cmbBoxTipoResponsable.TabIndex = 16;
            this.cmbBoxTipoResponsable.SelectedValueChanged += new System.EventHandler(this.cmbBoxTipoResponsable_SelectedValueChanged);
            // 
            // lblTipoResponsable
            // 
            this.lblTipoResponsable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTipoResponsable.AutoSize = true;
            this.lblTipoResponsable.Location = new System.Drawing.Point(3, 0);
            this.lblTipoResponsable.Name = "lblTipoResponsable";
            this.lblTipoResponsable.Size = new System.Drawing.Size(69, 29);
            this.lblTipoResponsable.TabIndex = 15;
            this.lblTipoResponsable.Text = "Tipo Responsable:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNombre.Location = new System.Drawing.Point(3, 95);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 13);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNombre.Depth = 0;
            this.txtBoxNombre.Hint = "";
            this.txtBoxNombre.Location = new System.Drawing.Point(78, 90);
            this.txtBoxNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.PasswordChar = '\0';
            this.txtBoxNombre.SelectedText = "";
            this.txtBoxNombre.SelectionLength = 0;
            this.txtBoxNombre.SelectionStart = 0;
            this.txtBoxNombre.Size = new System.Drawing.Size(153, 23);
            this.txtBoxNombre.TabIndex = 26;
            this.txtBoxNombre.UseSystemPasswordChar = false;
            this.txtBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNombre_KeyPress);
            this.txtBoxNombre.Leave += new System.EventHandler(this.txtBoxNombre_Leave);
            // 
            // cmbBoxTipoDocumento
            // 
            this.cmbBoxTipoDocumento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbBoxTipoDocumento.FormattingEnabled = true;
            this.cmbBoxTipoDocumento.Location = new System.Drawing.Point(20, 33);
            this.cmbBoxTipoDocumento.Name = "cmbBoxTipoDocumento";
            this.cmbBoxTipoDocumento.Size = new System.Drawing.Size(52, 21);
            this.cmbBoxTipoDocumento.TabIndex = 23;
            this.cmbBoxTipoDocumento.SelectedValueChanged += new System.EventHandler(this.cmbBoxTipoDocumento_SelectedValueChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblApellido.Location = new System.Drawing.Point(3, 66);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(69, 13);
            this.lblApellido.TabIndex = 19;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxNumeroDocumento
            // 
            this.txtBoxNumeroDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNumeroDocumento.Depth = 0;
            this.txtBoxNumeroDocumento.Hint = "";
            this.txtBoxNumeroDocumento.Location = new System.Drawing.Point(78, 32);
            this.txtBoxNumeroDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxNumeroDocumento.Name = "txtBoxNumeroDocumento";
            this.txtBoxNumeroDocumento.PasswordChar = '\0';
            this.txtBoxNumeroDocumento.SelectedText = "";
            this.txtBoxNumeroDocumento.SelectionLength = 0;
            this.txtBoxNumeroDocumento.SelectionStart = 0;
            this.txtBoxNumeroDocumento.Size = new System.Drawing.Size(153, 23);
            this.txtBoxNumeroDocumento.TabIndex = 24;
            this.txtBoxNumeroDocumento.UseSystemPasswordChar = false;
            this.txtBoxNumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNumeroDocumento_KeyPress);
            this.txtBoxNumeroDocumento.Leave += new System.EventHandler(this.txtBoxNumeroDocumento_Leave);
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxApellido.Depth = 0;
            this.txtBoxApellido.Hint = "";
            this.txtBoxApellido.Location = new System.Drawing.Point(78, 61);
            this.txtBoxApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.PasswordChar = '\0';
            this.txtBoxApellido.SelectedText = "";
            this.txtBoxApellido.SelectionLength = 0;
            this.txtBoxApellido.SelectionStart = 0;
            this.txtBoxApellido.Size = new System.Drawing.Size(153, 23);
            this.txtBoxApellido.TabIndex = 25;
            this.txtBoxApellido.UseSystemPasswordChar = false;
            this.txtBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxApellido_KeyPress);
            this.txtBoxApellido.Leave += new System.EventHandler(this.txtBoxApellido_Leave);
            // 
            // tblLayoutPanelPedido
            // 
            this.tblLayoutPanelPedido.ColumnCount = 2;
            this.tblLayoutPanelPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.07116F));
            this.tblLayoutPanelPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.92884F));
            this.tblLayoutPanelPedido.Controls.Add(this.lblCAE, 0, 4);
            this.tblLayoutPanelPedido.Controls.Add(this.lblNumeroPedido, 0, 0);
            this.tblLayoutPanelPedido.Controls.Add(this.lblTipoComprobante, 0, 1);
            this.tblLayoutPanelPedido.Controls.Add(this.cmbBoxTipoComprobante, 1, 1);
            this.tblLayoutPanelPedido.Controls.Add(this.lblFormaPago, 0, 2);
            this.tblLayoutPanelPedido.Controls.Add(this.cmbBoxFormaPago, 1, 2);
            this.tblLayoutPanelPedido.Controls.Add(this.lblFecha, 0, 3);
            this.tblLayoutPanelPedido.Controls.Add(this.dtpFechaPedido, 1, 3);
            this.tblLayoutPanelPedido.Controls.Add(this.txtBoxNumeroPedido, 1, 0);
            this.tblLayoutPanelPedido.Controls.Add(this.txtBoxCAE, 1, 4);
            this.tblLayoutPanelPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelPedido.Location = new System.Drawing.Point(736, 3);
            this.tblLayoutPanelPedido.Name = "tblLayoutPanelPedido";
            this.tblLayoutPanelPedido.RowCount = 5;
            this.tblLayoutPanelPedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelPedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelPedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelPedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelPedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tblLayoutPanelPedido.Size = new System.Drawing.Size(256, 146);
            this.tblLayoutPanelPedido.TabIndex = 3;
            // 
            // lblCAE
            // 
            this.lblCAE.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCAE.AutoSize = true;
            this.lblCAE.Location = new System.Drawing.Point(76, 124);
            this.lblCAE.Name = "lblCAE";
            this.lblCAE.Size = new System.Drawing.Size(31, 13);
            this.lblCAE.TabIndex = 12;
            this.lblCAE.Text = "CAE:";
            // 
            // lblNumeroPedido
            // 
            this.lblNumeroPedido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNumeroPedido.AutoSize = true;
            this.lblNumeroPedido.Location = new System.Drawing.Point(60, 8);
            this.lblNumeroPedido.Name = "lblNumeroPedido";
            this.lblNumeroPedido.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroPedido.TabIndex = 0;
            this.lblNumeroPedido.Text = "Número:";
            // 
            // lblTipoComprobante
            // 
            this.lblTipoComprobante.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTipoComprobante.AutoSize = true;
            this.lblTipoComprobante.Location = new System.Drawing.Point(76, 37);
            this.lblTipoComprobante.Name = "lblTipoComprobante";
            this.lblTipoComprobante.Size = new System.Drawing.Size(31, 13);
            this.lblTipoComprobante.TabIndex = 1;
            this.lblTipoComprobante.Text = "Tipo:";
            // 
            // cmbBoxTipoComprobante
            // 
            this.cmbBoxTipoComprobante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxTipoComprobante.FormattingEnabled = true;
            this.cmbBoxTipoComprobante.Location = new System.Drawing.Point(113, 33);
            this.cmbBoxTipoComprobante.Name = "cmbBoxTipoComprobante";
            this.cmbBoxTipoComprobante.Size = new System.Drawing.Size(140, 21);
            this.cmbBoxTipoComprobante.TabIndex = 10;
            this.cmbBoxTipoComprobante.SelectedIndexChanged += new System.EventHandler(this.cmbBoxTipoComprobante_SelectedIndexChanged);
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(25, 66);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(82, 13);
            this.lblFormaPago.TabIndex = 2;
            this.lblFormaPago.Text = "Forma de Pago:";
            // 
            // cmbBoxFormaPago
            // 
            this.cmbBoxFormaPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxFormaPago.FormattingEnabled = true;
            this.cmbBoxFormaPago.Items.AddRange(new object[] {
            "Contado",
            "Tarjeta"});
            this.cmbBoxFormaPago.Location = new System.Drawing.Point(113, 62);
            this.cmbBoxFormaPago.Name = "cmbBoxFormaPago";
            this.cmbBoxFormaPago.Size = new System.Drawing.Size(140, 21);
            this.cmbBoxFormaPago.TabIndex = 9;
            this.cmbBoxFormaPago.SelectionChangeCommitted += new System.EventHandler(this.cmbBoxFormaPago_SelectionChangeCommitted);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(67, 95);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFechaPedido
            // 
            this.dtpFechaPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaPedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPedido.Location = new System.Drawing.Point(113, 91);
            this.dtpFechaPedido.Name = "dtpFechaPedido";
            this.dtpFechaPedido.Size = new System.Drawing.Size(140, 20);
            this.dtpFechaPedido.TabIndex = 11;
            // 
            // txtBoxNumeroPedido
            // 
            this.txtBoxNumeroPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNumeroPedido.Depth = 0;
            this.txtBoxNumeroPedido.Hint = "";
            this.txtBoxNumeroPedido.Location = new System.Drawing.Point(113, 3);
            this.txtBoxNumeroPedido.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxNumeroPedido.Name = "txtBoxNumeroPedido";
            this.txtBoxNumeroPedido.PasswordChar = '\0';
            this.txtBoxNumeroPedido.SelectedText = "";
            this.txtBoxNumeroPedido.SelectionLength = 0;
            this.txtBoxNumeroPedido.SelectionStart = 0;
            this.txtBoxNumeroPedido.Size = new System.Drawing.Size(140, 23);
            this.txtBoxNumeroPedido.TabIndex = 14;
            this.txtBoxNumeroPedido.UseSystemPasswordChar = false;
            // 
            // txtBoxCAE
            // 
            this.txtBoxCAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCAE.Depth = 0;
            this.txtBoxCAE.Hint = "";
            this.txtBoxCAE.Location = new System.Drawing.Point(113, 119);
            this.txtBoxCAE.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCAE.Name = "txtBoxCAE";
            this.txtBoxCAE.PasswordChar = '\0';
            this.txtBoxCAE.SelectedText = "";
            this.txtBoxCAE.SelectionLength = 0;
            this.txtBoxCAE.SelectionStart = 0;
            this.txtBoxCAE.Size = new System.Drawing.Size(140, 23);
            this.txtBoxCAE.TabIndex = 15;
            this.txtBoxCAE.UseSystemPasswordChar = false;
            // 
            // tbPageDomicilioFacturacion
            // 
            this.tbPageDomicilioFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbPageDomicilioFacturacion.Controls.Add(this.tblLayoutPanelDomicilioFacturacion);
            this.tbPageDomicilioFacturacion.Location = new System.Drawing.Point(4, 22);
            this.tbPageDomicilioFacturacion.Name = "tbPageDomicilioFacturacion";
            this.tbPageDomicilioFacturacion.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageDomicilioFacturacion.Size = new System.Drawing.Size(1001, 158);
            this.tbPageDomicilioFacturacion.TabIndex = 1;
            this.tbPageDomicilioFacturacion.Text = "Domicilio de Facturación";
            // 
            // tblLayoutPanelDomicilioFacturacion
            // 
            this.tblLayoutPanelDomicilioFacturacion.ColumnCount = 1;
            this.tblLayoutPanelDomicilioFacturacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDomicilioFacturacion.Controls.Add(this.cmbBoxDomicilios, 0, 1);
            this.tblLayoutPanelDomicilioFacturacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDomicilioFacturacion.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelDomicilioFacturacion.Name = "tblLayoutPanelDomicilioFacturacion";
            this.tblLayoutPanelDomicilioFacturacion.RowCount = 2;
            this.tblLayoutPanelDomicilioFacturacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.84483F));
            this.tblLayoutPanelDomicilioFacturacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.15517F));
            this.tblLayoutPanelDomicilioFacturacion.Size = new System.Drawing.Size(995, 152);
            this.tblLayoutPanelDomicilioFacturacion.TabIndex = 0;
            // 
            // cmbBoxDomicilios
            // 
            this.cmbBoxDomicilios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoxDomicilios.FormattingEnabled = true;
            this.cmbBoxDomicilios.Location = new System.Drawing.Point(437, 122);
            this.cmbBoxDomicilios.Name = "cmbBoxDomicilios";
            this.cmbBoxDomicilios.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxDomicilios.TabIndex = 2;
            this.cmbBoxDomicilios.SelectionChangeCommitted += new System.EventHandler(this.cmbBoxDomicilios_SelectionChangeCommitted);
            // 
            // tbPageDatosContacto
            // 
            this.tbPageDatosContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbPageDatosContacto.Controls.Add(this.tblLayoutPanelDatosContacto);
            this.tbPageDatosContacto.Location = new System.Drawing.Point(4, 22);
            this.tbPageDatosContacto.Name = "tbPageDatosContacto";
            this.tbPageDatosContacto.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageDatosContacto.Size = new System.Drawing.Size(1001, 158);
            this.tbPageDatosContacto.TabIndex = 2;
            this.tbPageDatosContacto.Text = "Datos de Contacto";
            // 
            // tblLayoutPanelDatosContacto
            // 
            this.tblLayoutPanelDatosContacto.ColumnCount = 4;
            this.tblLayoutPanelDatosContacto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayoutPanelDatosContacto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLayoutPanelDatosContacto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLayoutPanelDatosContacto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayoutPanelDatosContacto.Controls.Add(this.grpBoxCorreoElectronico, 1, 0);
            this.tblLayoutPanelDatosContacto.Controls.Add(this.grpBoxTelefono, 2, 0);
            this.tblLayoutPanelDatosContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDatosContacto.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelDatosContacto.Name = "tblLayoutPanelDatosContacto";
            this.tblLayoutPanelDatosContacto.RowCount = 1;
            this.tblLayoutPanelDatosContacto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.54498F));
            this.tblLayoutPanelDatosContacto.Size = new System.Drawing.Size(995, 152);
            this.tblLayoutPanelDatosContacto.TabIndex = 0;
            // 
            // grpBoxCorreoElectronico
            // 
            this.grpBoxCorreoElectronico.Controls.Add(this.tblLayoutPanelCorreoElectronico);
            this.grpBoxCorreoElectronico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxCorreoElectronico.Location = new System.Drawing.Point(101, 2);
            this.grpBoxCorreoElectronico.Margin = new System.Windows.Forms.Padding(2, 2, 8, 2);
            this.grpBoxCorreoElectronico.Name = "grpBoxCorreoElectronico";
            this.grpBoxCorreoElectronico.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxCorreoElectronico.Size = new System.Drawing.Size(388, 148);
            this.grpBoxCorreoElectronico.TabIndex = 6;
            this.grpBoxCorreoElectronico.TabStop = false;
            this.grpBoxCorreoElectronico.Text = "Correo Electrónico";
            // 
            // tblLayoutPanelCorreoElectronico
            // 
            this.tblLayoutPanelCorreoElectronico.ColumnCount = 1;
            this.tblLayoutPanelCorreoElectronico.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelCorreoElectronico.Controls.Add(this.tblLayoutPanelMail, 0, 0);
            this.tblLayoutPanelCorreoElectronico.Controls.Add(this.cmbBoxMails, 0, 1);
            this.tblLayoutPanelCorreoElectronico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelCorreoElectronico.Location = new System.Drawing.Point(2, 15);
            this.tblLayoutPanelCorreoElectronico.Margin = new System.Windows.Forms.Padding(2);
            this.tblLayoutPanelCorreoElectronico.Name = "tblLayoutPanelCorreoElectronico";
            this.tblLayoutPanelCorreoElectronico.RowCount = 2;
            this.tblLayoutPanelCorreoElectronico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.53086F));
            this.tblLayoutPanelCorreoElectronico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.46914F));
            this.tblLayoutPanelCorreoElectronico.Size = new System.Drawing.Size(384, 131);
            this.tblLayoutPanelCorreoElectronico.TabIndex = 0;
            // 
            // tblLayoutPanelMail
            // 
            this.tblLayoutPanelMail.ColumnCount = 3;
            this.tblLayoutPanelMail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0578F));
            this.tblLayoutPanelMail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.9422F));
            this.tblLayoutPanelMail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tblLayoutPanelMail.Controls.Add(this.lblMail, 0, 0);
            this.tblLayoutPanelMail.Controls.Add(this.txtBoxMail, 1, 0);
            this.tblLayoutPanelMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelMail.Location = new System.Drawing.Point(3, 8);
            this.tblLayoutPanelMail.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.tblLayoutPanelMail.Name = "tblLayoutPanelMail";
            this.tblLayoutPanelMail.RowCount = 1;
            this.tblLayoutPanelMail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelMail.Size = new System.Drawing.Size(378, 51);
            this.tblLayoutPanelMail.TabIndex = 2;
            // 
            // lblMail
            // 
            this.lblMail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblMail.Location = new System.Drawing.Point(25, 12);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(63, 26);
            this.lblMail.TabIndex = 9;
            this.lblMail.Text = "Correo Electrónico:";
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxMail.Depth = 0;
            this.txtBoxMail.Hint = "";
            this.txtBoxMail.Location = new System.Drawing.Point(94, 14);
            this.txtBoxMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.PasswordChar = '\0';
            this.txtBoxMail.SelectedText = "";
            this.txtBoxMail.SelectionLength = 0;
            this.txtBoxMail.SelectionStart = 0;
            this.txtBoxMail.Size = new System.Drawing.Size(207, 23);
            this.txtBoxMail.TabIndex = 10;
            this.txtBoxMail.UseSystemPasswordChar = false;
            this.txtBoxMail.Leave += new System.EventHandler(this.txtBoxMail_Leave);
            // 
            // cmbBoxMails
            // 
            this.cmbBoxMails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoxMails.FormattingEnabled = true;
            this.cmbBoxMails.Location = new System.Drawing.Point(131, 86);
            this.cmbBoxMails.Name = "cmbBoxMails";
            this.cmbBoxMails.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxMails.TabIndex = 4;
            this.cmbBoxMails.SelectedIndexChanged += new System.EventHandler(this.cmbBoxMails_SelectedIndexChanged);
            // 
            // grpBoxTelefono
            // 
            this.grpBoxTelefono.Controls.Add(this.tblLayoutPanelNumeroTelefono);
            this.grpBoxTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxTelefono.Location = new System.Drawing.Point(505, 2);
            this.grpBoxTelefono.Margin = new System.Windows.Forms.Padding(8, 2, 2, 2);
            this.grpBoxTelefono.Name = "grpBoxTelefono";
            this.grpBoxTelefono.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxTelefono.Size = new System.Drawing.Size(388, 148);
            this.grpBoxTelefono.TabIndex = 7;
            this.grpBoxTelefono.TabStop = false;
            this.grpBoxTelefono.Text = "Número de Teléfono";
            // 
            // tblLayoutPanelNumeroTelefono
            // 
            this.tblLayoutPanelNumeroTelefono.ColumnCount = 1;
            this.tblLayoutPanelNumeroTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelNumeroTelefono.Controls.Add(this.tblLayoutPanelTelefono, 0, 0);
            this.tblLayoutPanelNumeroTelefono.Controls.Add(this.cmbBoxTelefonos, 0, 1);
            this.tblLayoutPanelNumeroTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelNumeroTelefono.Location = new System.Drawing.Point(2, 15);
            this.tblLayoutPanelNumeroTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.tblLayoutPanelNumeroTelefono.Name = "tblLayoutPanelNumeroTelefono";
            this.tblLayoutPanelNumeroTelefono.RowCount = 2;
            this.tblLayoutPanelNumeroTelefono.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.53086F));
            this.tblLayoutPanelNumeroTelefono.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.46914F));
            this.tblLayoutPanelNumeroTelefono.Size = new System.Drawing.Size(384, 131);
            this.tblLayoutPanelNumeroTelefono.TabIndex = 0;
            // 
            // tblLayoutPanelTelefono
            // 
            this.tblLayoutPanelTelefono.ColumnCount = 5;
            this.tblLayoutPanelTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblLayoutPanelTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLayoutPanelTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblLayoutPanelTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblLayoutPanelTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblLayoutPanelTelefono.Controls.Add(this.cmbBoxTipoTelefono, 1, 0);
            this.tblLayoutPanelTelefono.Controls.Add(this.lblTipoTelefono, 0, 0);
            this.tblLayoutPanelTelefono.Controls.Add(this.lblNumeroTelefono, 2, 0);
            this.tblLayoutPanelTelefono.Controls.Add(this.txtBoxTelefono, 3, 0);
            this.tblLayoutPanelTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelTelefono.Location = new System.Drawing.Point(3, 8);
            this.tblLayoutPanelTelefono.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.tblLayoutPanelTelefono.Name = "tblLayoutPanelTelefono";
            this.tblLayoutPanelTelefono.RowCount = 1;
            this.tblLayoutPanelTelefono.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelTelefono.Size = new System.Drawing.Size(378, 51);
            this.tblLayoutPanelTelefono.TabIndex = 3;
            // 
            // cmbBoxTipoTelefono
            // 
            this.cmbBoxTipoTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxTipoTelefono.FormattingEnabled = true;
            this.cmbBoxTipoTelefono.Items.AddRange(new object[] {
            "TEL",
            "CEL",
            "FAX"});
            this.cmbBoxTipoTelefono.Location = new System.Drawing.Point(41, 15);
            this.cmbBoxTipoTelefono.Name = "cmbBoxTipoTelefono";
            this.cmbBoxTipoTelefono.Size = new System.Drawing.Size(96, 21);
            this.cmbBoxTipoTelefono.TabIndex = 24;
            // 
            // lblTipoTelefono
            // 
            this.lblTipoTelefono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTipoTelefono.AutoSize = true;
            this.lblTipoTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTipoTelefono.Location = new System.Drawing.Point(4, 19);
            this.lblTipoTelefono.Name = "lblTipoTelefono";
            this.lblTipoTelefono.Size = new System.Drawing.Size(31, 13);
            this.lblTipoTelefono.TabIndex = 27;
            this.lblTipoTelefono.Text = "Tipo:";
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNumeroTelefono.Location = new System.Drawing.Point(150, 19);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroTelefono.TabIndex = 25;
            this.lblNumeroTelefono.Text = "Número:";
            // 
            // txtBoxTelefono
            // 
            this.txtBoxTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxTelefono.Depth = 0;
            this.txtBoxTelefono.Hint = "";
            this.txtBoxTelefono.Location = new System.Drawing.Point(203, 14);
            this.txtBoxTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxTelefono.Name = "txtBoxTelefono";
            this.txtBoxTelefono.PasswordChar = '\0';
            this.txtBoxTelefono.SelectedText = "";
            this.txtBoxTelefono.SelectionLength = 0;
            this.txtBoxTelefono.SelectionStart = 0;
            this.txtBoxTelefono.Size = new System.Drawing.Size(147, 23);
            this.txtBoxTelefono.TabIndex = 28;
            this.txtBoxTelefono.UseSystemPasswordChar = false;
            this.txtBoxTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTelefono_KeyPress);
            this.txtBoxTelefono.Leave += new System.EventHandler(this.txtBoxTelefono_Leave);
            // 
            // cmbBoxTelefonos
            // 
            this.cmbBoxTelefonos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoxTelefonos.FormattingEnabled = true;
            this.cmbBoxTelefonos.Location = new System.Drawing.Point(131, 86);
            this.cmbBoxTelefonos.Name = "cmbBoxTelefonos";
            this.cmbBoxTelefonos.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxTelefonos.TabIndex = 5;
            this.cmbBoxTelefonos.SelectedIndexChanged += new System.EventHandler(this.cmbBoxTelefonos_SelectedIndexChanged);
            // 
            // tabPageObservaciones
            // 
            this.tabPageObservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageObservaciones.Controls.Add(this.tableLayoutObservaciones);
            this.tabPageObservaciones.Location = new System.Drawing.Point(4, 22);
            this.tabPageObservaciones.Name = "tabPageObservaciones";
            this.tabPageObservaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageObservaciones.Size = new System.Drawing.Size(1001, 158);
            this.tabPageObservaciones.TabIndex = 3;
            this.tabPageObservaciones.Text = "Observaciones del Pedido";
            // 
            // tableLayoutObservaciones
            // 
            this.tableLayoutObservaciones.ColumnCount = 1;
            this.tableLayoutObservaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutObservaciones.Controls.Add(this.lblUsuario, 0, 1);
            this.tableLayoutObservaciones.Controls.Add(this.grpBoxObservacionesPedido, 0, 0);
            this.tableLayoutObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutObservaciones.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutObservaciones.Name = "tableLayoutObservaciones";
            this.tableLayoutObservaciones.RowCount = 2;
            this.tableLayoutObservaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutObservaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutObservaciones.Size = new System.Drawing.Size(995, 152);
            this.tableLayoutObservaciones.TabIndex = 4;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(471, 129);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 15);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // grpBoxObservacionesPedido
            // 
            this.grpBoxObservacionesPedido.Controls.Add(this.pnlObservaciones);
            this.grpBoxObservacionesPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxObservacionesPedido.Location = new System.Drawing.Point(2, 2);
            this.grpBoxObservacionesPedido.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoxObservacionesPedido.Name = "grpBoxObservacionesPedido";
            this.grpBoxObservacionesPedido.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxObservacionesPedido.Size = new System.Drawing.Size(991, 118);
            this.grpBoxObservacionesPedido.TabIndex = 3;
            this.grpBoxObservacionesPedido.TabStop = false;
            this.grpBoxObservacionesPedido.Text = "Observaciones del Pedido";
            // 
            // pnlObservaciones
            // 
            this.pnlObservaciones.Controls.Add(this.rchTextBoxObservacionesPedido);
            this.pnlObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlObservaciones.Location = new System.Drawing.Point(2, 15);
            this.pnlObservaciones.Margin = new System.Windows.Forms.Padding(10);
            this.pnlObservaciones.Name = "pnlObservaciones";
            this.pnlObservaciones.Padding = new System.Windows.Forms.Padding(10);
            this.pnlObservaciones.Size = new System.Drawing.Size(987, 101);
            this.pnlObservaciones.TabIndex = 3;
            // 
            // rchTextBoxObservacionesPedido
            // 
            this.rchTextBoxObservacionesPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchTextBoxObservacionesPedido.Location = new System.Drawing.Point(10, 10);
            this.rchTextBoxObservacionesPedido.Margin = new System.Windows.Forms.Padding(20);
            this.rchTextBoxObservacionesPedido.Name = "rchTextBoxObservacionesPedido";
            this.rchTextBoxObservacionesPedido.Size = new System.Drawing.Size(967, 81);
            this.rchTextBoxObservacionesPedido.TabIndex = 2;
            this.rchTextBoxObservacionesPedido.Text = "";
            // 
            // gbxArticulos
            // 
            this.gbxArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxArticulos.Controls.Add(this.tblLayoutPanelLineasPedidos);
            this.gbxArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxArticulos.Location = new System.Drawing.Point(3, 233);
            this.gbxArticulos.Name = "gbxArticulos";
            this.gbxArticulos.Size = new System.Drawing.Size(1009, 193);
            this.gbxArticulos.TabIndex = 14;
            this.gbxArticulos.TabStop = false;
            this.gbxArticulos.Text = "Artículos";
            // 
            // tblLayoutPanelLineasPedidos
            // 
            this.tblLayoutPanelLineasPedidos.ColumnCount = 1;
            this.tblLayoutPanelLineasPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelLineasPedidos.Controls.Add(this.dgvArticulosVenta, 0, 0);
            this.tblLayoutPanelLineasPedidos.Controls.Add(this.tblLayoutPanelLineasPedidosBotones, 0, 1);
            this.tblLayoutPanelLineasPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelLineasPedidos.Location = new System.Drawing.Point(3, 18);
            this.tblLayoutPanelLineasPedidos.Name = "tblLayoutPanelLineasPedidos";
            this.tblLayoutPanelLineasPedidos.RowCount = 2;
            this.tblLayoutPanelLineasPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelLineasPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tblLayoutPanelLineasPedidos.Size = new System.Drawing.Size(1003, 172);
            this.tblLayoutPanelLineasPedidos.TabIndex = 6;
            // 
            // dgvArticulosVenta
            // 
            this.dgvArticulosVenta.AllowUserToAddRows = false;
            this.dgvArticulosVenta.AllowUserToDeleteRows = false;
            this.dgvArticulosVenta.AllowUserToResizeRows = false;
            this.dgvArticulosVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulosVenta.BackgroundColor = System.Drawing.Color.White;
            this.dgvArticulosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulosVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indice,
            this.codOriginal,
            this.codProveedor,
            this.descripcion,
            this.cantidad,
            this.vUnitario,
            this.descuento,
            this.valorParcialSinDescuento,
            this.valorParcialConDescuento});
            this.dgvArticulosVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticulosVenta.GridColor = System.Drawing.Color.White;
            this.dgvArticulosVenta.Location = new System.Drawing.Point(3, 3);
            this.dgvArticulosVenta.Name = "dgvArticulosVenta";
            this.dgvArticulosVenta.ReadOnly = true;
            this.dgvArticulosVenta.RowHeadersVisible = false;
            this.dgvArticulosVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulosVenta.Size = new System.Drawing.Size(997, 127);
            this.dgvArticulosVenta.TabIndex = 5;
            this.dgvArticulosVenta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvArticulosVenta_MouseDown);
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
            // tblLayoutPanelLineasPedidosBotones
            // 
            this.tblLayoutPanelLineasPedidosBotones.ColumnCount = 3;
            this.tblLayoutPanelLineasPedidosBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelLineasPedidosBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLayoutPanelLineasPedidosBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelLineasPedidosBotones.Controls.Add(this.btnAgregar, 0, 0);
            this.tblLayoutPanelLineasPedidosBotones.Controls.Add(this.btnEditar, 1, 0);
            this.tblLayoutPanelLineasPedidosBotones.Controls.Add(this.btnEliminar, 2, 0);
            this.tblLayoutPanelLineasPedidosBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelLineasPedidosBotones.Location = new System.Drawing.Point(3, 136);
            this.tblLayoutPanelLineasPedidosBotones.Name = "tblLayoutPanelLineasPedidosBotones";
            this.tblLayoutPanelLineasPedidosBotones.RowCount = 1;
            this.tblLayoutPanelLineasPedidosBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelLineasPedidosBotones.Size = new System.Drawing.Size(997, 33);
            this.tblLayoutPanelLineasPedidosBotones.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Location = new System.Drawing.Point(360, 6);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = false;
            this.btnAgregar.Size = new System.Drawing.Size(74, 21);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.AutoSize = true;
            this.btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar.Depth = 0;
            this.btnEditar.Location = new System.Drawing.Point(468, 6);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Primary = false;
            this.btnEditar.Size = new System.Drawing.Size(59, 21);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(562, 6);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = false;
            this.btnEliminar.Size = new System.Drawing.Size(74, 21);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // tblLayoutPanelValoresPedido
            // 
            this.tblLayoutPanelValoresPedido.AutoSize = true;
            this.tblLayoutPanelValoresPedido.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblLayoutPanelValoresPedido.ColumnCount = 10;
            this.tblLayoutPanelValoresPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.710307F));
            this.tblLayoutPanelValoresPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.988858F));
            this.tblLayoutPanelValoresPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.48468F));
            this.tblLayoutPanelValoresPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblLayoutPanelValoresPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.359307F));
            this.tblLayoutPanelValoresPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblLayoutPanelValoresPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.86351F));
            this.tblLayoutPanelValoresPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.55989F));
            this.tblLayoutPanelValoresPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.192201F));
            this.tblLayoutPanelValoresPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.39554F));
            this.tblLayoutPanelValoresPedido.Controls.Add(this.lblIVA, 0, 0);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.lblSubtotal, 8, 0);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.lblTotal, 8, 1);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.lblDescuentoLineas, 6, 0);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.lblDescuentoTotal, 6, 1);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.lblDescuentoPorcentual, 3, 0);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.lblDescuentoNeto, 3, 1);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.lblSenia, 1, 1);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.txtBoxIVAPorcentaje, 1, 0);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.txtBoxIVAMonto, 2, 0);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.txtBoxSenia, 2, 1);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.txtBoxDescuento1Porcentaje, 4, 0);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.txtBoxDescuento1Monto, 5, 0);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.txtBoxDescuento2Porcentaje, 4, 1);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.txtBoxDescuento2Monto, 5, 1);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.txtBoxDescuentoLineas, 7, 0);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.txtBoxDescuentoTotal, 7, 1);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.txtBoxSubtotal, 9, 0);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.txtBoxTotal, 9, 1);
            this.tblLayoutPanelValoresPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelValoresPedido.Location = new System.Drawing.Point(3, 432);
            this.tblLayoutPanelValoresPedido.Name = "tblLayoutPanelValoresPedido";
            this.tblLayoutPanelValoresPedido.RowCount = 2;
            this.tblLayoutPanelValoresPedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelValoresPedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelValoresPedido.Size = new System.Drawing.Size(1009, 73);
            this.tblLayoutPanelValoresPedido.TabIndex = 15;
            // 
            // lblIVA
            // 
            this.lblIVA.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(27, 11);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(27, 13);
            this.lblIVA.TabIndex = 0;
            this.lblIVA.Text = "IVA:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(826, 11);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 6;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(830, 48);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "TOTAL:";
            // 
            // lblDescuentoLineas
            // 
            this.lblDescuentoLineas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescuentoLineas.AutoSize = true;
            this.lblDescuentoLineas.Location = new System.Drawing.Point(569, 11);
            this.lblDescuentoLineas.Name = "lblDescuentoLineas";
            this.lblDescuentoLineas.Size = new System.Drawing.Size(98, 13);
            this.lblDescuentoLineas.TabIndex = 4;
            this.lblDescuentoLineas.Text = "Descuento Líneas:";
            // 
            // lblDescuentoTotal
            // 
            this.lblDescuentoTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescuentoTotal.AutoSize = true;
            this.lblDescuentoTotal.Location = new System.Drawing.Point(578, 48);
            this.lblDescuentoTotal.Name = "lblDescuentoTotal";
            this.lblDescuentoTotal.Size = new System.Drawing.Size(89, 13);
            this.lblDescuentoTotal.TabIndex = 5;
            this.lblDescuentoTotal.Text = "Descuento Total:";
            // 
            // lblDescuentoPorcentual
            // 
            this.lblDescuentoPorcentual.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescuentoPorcentual.AutoSize = true;
            this.lblDescuentoPorcentual.Location = new System.Drawing.Point(301, 11);
            this.lblDescuentoPorcentual.Name = "lblDescuentoPorcentual";
            this.lblDescuentoPorcentual.Size = new System.Drawing.Size(71, 13);
            this.lblDescuentoPorcentual.TabIndex = 2;
            this.lblDescuentoPorcentual.Text = "Descuento 1:";
            this.lblDescuentoPorcentual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescuentoNeto
            // 
            this.lblDescuentoNeto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescuentoNeto.AutoSize = true;
            this.lblDescuentoNeto.Location = new System.Drawing.Point(301, 48);
            this.lblDescuentoNeto.Name = "lblDescuentoNeto";
            this.lblDescuentoNeto.Size = new System.Drawing.Size(71, 13);
            this.lblDescuentoNeto.TabIndex = 3;
            this.lblDescuentoNeto.Text = "Descuento 2:";
            // 
            // lblSenia
            // 
            this.lblSenia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSenia.AutoSize = true;
            this.lblSenia.Location = new System.Drawing.Point(76, 48);
            this.lblSenia.Name = "lblSenia";
            this.lblSenia.Size = new System.Drawing.Size(38, 13);
            this.lblSenia.TabIndex = 1;
            this.lblSenia.Text = "Seña: ";
            // 
            // txtBoxIVAPorcentaje
            // 
            this.txtBoxIVAPorcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxIVAPorcentaje.Depth = 0;
            this.txtBoxIVAPorcentaje.Hint = "";
            this.txtBoxIVAPorcentaje.Location = new System.Drawing.Point(60, 6);
            this.txtBoxIVAPorcentaje.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxIVAPorcentaje.Name = "txtBoxIVAPorcentaje";
            this.txtBoxIVAPorcentaje.PasswordChar = '\0';
            this.txtBoxIVAPorcentaje.SelectedText = "";
            this.txtBoxIVAPorcentaje.SelectionLength = 0;
            this.txtBoxIVAPorcentaje.SelectionStart = 0;
            this.txtBoxIVAPorcentaje.Size = new System.Drawing.Size(54, 23);
            this.txtBoxIVAPorcentaje.TabIndex = 19;
            this.txtBoxIVAPorcentaje.UseSystemPasswordChar = false;
            this.txtBoxIVAPorcentaje.Leave += new System.EventHandler(this.txtBoxIVAPorcentaje_Leave);
            // 
            // txtBoxIVAMonto
            // 
            this.txtBoxIVAMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxIVAMonto.Depth = 0;
            this.txtBoxIVAMonto.Hint = "";
            this.txtBoxIVAMonto.Location = new System.Drawing.Point(120, 6);
            this.txtBoxIVAMonto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxIVAMonto.Name = "txtBoxIVAMonto";
            this.txtBoxIVAMonto.PasswordChar = '\0';
            this.txtBoxIVAMonto.SelectedText = "";
            this.txtBoxIVAMonto.SelectionLength = 0;
            this.txtBoxIVAMonto.SelectionStart = 0;
            this.txtBoxIVAMonto.Size = new System.Drawing.Size(140, 23);
            this.txtBoxIVAMonto.TabIndex = 20;
            this.txtBoxIVAMonto.UseSystemPasswordChar = false;
            this.txtBoxIVAMonto.Leave += new System.EventHandler(this.txtBoxIVAMonto_Leave);
            // 
            // txtBoxSenia
            // 
            this.txtBoxSenia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSenia.Depth = 0;
            this.txtBoxSenia.Hint = "";
            this.txtBoxSenia.Location = new System.Drawing.Point(120, 43);
            this.txtBoxSenia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxSenia.Name = "txtBoxSenia";
            this.txtBoxSenia.PasswordChar = '\0';
            this.txtBoxSenia.SelectedText = "";
            this.txtBoxSenia.SelectionLength = 0;
            this.txtBoxSenia.SelectionStart = 0;
            this.txtBoxSenia.Size = new System.Drawing.Size(140, 23);
            this.txtBoxSenia.TabIndex = 21;
            this.txtBoxSenia.UseSystemPasswordChar = false;
            this.txtBoxSenia.Leave += new System.EventHandler(this.txtBoxSenia_Leave);
            // 
            // txtBoxDescuento1Porcentaje
            // 
            this.txtBoxDescuento1Porcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescuento1Porcentaje.Depth = 0;
            this.txtBoxDescuento1Porcentaje.Hint = "";
            this.txtBoxDescuento1Porcentaje.Location = new System.Drawing.Point(378, 6);
            this.txtBoxDescuento1Porcentaje.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDescuento1Porcentaje.Name = "txtBoxDescuento1Porcentaje";
            this.txtBoxDescuento1Porcentaje.PasswordChar = '\0';
            this.txtBoxDescuento1Porcentaje.SelectedText = "";
            this.txtBoxDescuento1Porcentaje.SelectionLength = 0;
            this.txtBoxDescuento1Porcentaje.SelectionStart = 0;
            this.txtBoxDescuento1Porcentaje.Size = new System.Drawing.Size(68, 23);
            this.txtBoxDescuento1Porcentaje.TabIndex = 22;
            this.txtBoxDescuento1Porcentaje.UseSystemPasswordChar = false;
            this.txtBoxDescuento1Porcentaje.Leave += new System.EventHandler(this.txtBoxDescuento1Porcentaje_Leave);
            // 
            // txtBoxDescuento1Monto
            // 
            this.txtBoxDescuento1Monto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescuento1Monto.Depth = 0;
            this.txtBoxDescuento1Monto.Hint = "";
            this.txtBoxDescuento1Monto.Location = new System.Drawing.Point(452, 6);
            this.txtBoxDescuento1Monto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDescuento1Monto.Name = "txtBoxDescuento1Monto";
            this.txtBoxDescuento1Monto.PasswordChar = '\0';
            this.txtBoxDescuento1Monto.SelectedText = "";
            this.txtBoxDescuento1Monto.SelectionLength = 0;
            this.txtBoxDescuento1Monto.SelectionStart = 0;
            this.txtBoxDescuento1Monto.Size = new System.Drawing.Size(106, 23);
            this.txtBoxDescuento1Monto.TabIndex = 23;
            this.txtBoxDescuento1Monto.UseSystemPasswordChar = false;
            this.txtBoxDescuento1Monto.Leave += new System.EventHandler(this.txtBoxDescuento1Monto_Leave);
            // 
            // txtBoxDescuento2Porcentaje
            // 
            this.txtBoxDescuento2Porcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescuento2Porcentaje.Depth = 0;
            this.txtBoxDescuento2Porcentaje.Hint = "";
            this.txtBoxDescuento2Porcentaje.Location = new System.Drawing.Point(378, 43);
            this.txtBoxDescuento2Porcentaje.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDescuento2Porcentaje.Name = "txtBoxDescuento2Porcentaje";
            this.txtBoxDescuento2Porcentaje.PasswordChar = '\0';
            this.txtBoxDescuento2Porcentaje.SelectedText = "";
            this.txtBoxDescuento2Porcentaje.SelectionLength = 0;
            this.txtBoxDescuento2Porcentaje.SelectionStart = 0;
            this.txtBoxDescuento2Porcentaje.Size = new System.Drawing.Size(68, 23);
            this.txtBoxDescuento2Porcentaje.TabIndex = 24;
            this.txtBoxDescuento2Porcentaje.UseSystemPasswordChar = false;
            this.txtBoxDescuento2Porcentaje.Leave += new System.EventHandler(this.txtBoxDescuento2Porcentaje_Leave);
            // 
            // txtBoxDescuento2Monto
            // 
            this.txtBoxDescuento2Monto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescuento2Monto.Depth = 0;
            this.txtBoxDescuento2Monto.Hint = "";
            this.txtBoxDescuento2Monto.Location = new System.Drawing.Point(452, 43);
            this.txtBoxDescuento2Monto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDescuento2Monto.Name = "txtBoxDescuento2Monto";
            this.txtBoxDescuento2Monto.PasswordChar = '\0';
            this.txtBoxDescuento2Monto.SelectedText = "";
            this.txtBoxDescuento2Monto.SelectionLength = 0;
            this.txtBoxDescuento2Monto.SelectionStart = 0;
            this.txtBoxDescuento2Monto.Size = new System.Drawing.Size(106, 23);
            this.txtBoxDescuento2Monto.TabIndex = 25;
            this.txtBoxDescuento2Monto.UseSystemPasswordChar = false;
            this.txtBoxDescuento2Monto.Leave += new System.EventHandler(this.txtBoxDescuento2Monto_Leave);
            // 
            // txtBoxDescuentoLineas
            // 
            this.txtBoxDescuentoLineas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescuentoLineas.Depth = 0;
            this.txtBoxDescuentoLineas.Hint = "";
            this.txtBoxDescuentoLineas.Location = new System.Drawing.Point(673, 6);
            this.txtBoxDescuentoLineas.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDescuentoLineas.Name = "txtBoxDescuentoLineas";
            this.txtBoxDescuentoLineas.PasswordChar = '\0';
            this.txtBoxDescuentoLineas.SelectedText = "";
            this.txtBoxDescuentoLineas.SelectionLength = 0;
            this.txtBoxDescuentoLineas.SelectionStart = 0;
            this.txtBoxDescuentoLineas.Size = new System.Drawing.Size(110, 23);
            this.txtBoxDescuentoLineas.TabIndex = 26;
            this.txtBoxDescuentoLineas.UseSystemPasswordChar = false;
            // 
            // txtBoxDescuentoTotal
            // 
            this.txtBoxDescuentoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescuentoTotal.Depth = 0;
            this.txtBoxDescuentoTotal.Hint = "";
            this.txtBoxDescuentoTotal.Location = new System.Drawing.Point(673, 43);
            this.txtBoxDescuentoTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDescuentoTotal.Name = "txtBoxDescuentoTotal";
            this.txtBoxDescuentoTotal.PasswordChar = '\0';
            this.txtBoxDescuentoTotal.SelectedText = "";
            this.txtBoxDescuentoTotal.SelectionLength = 0;
            this.txtBoxDescuentoTotal.SelectionStart = 0;
            this.txtBoxDescuentoTotal.Size = new System.Drawing.Size(110, 23);
            this.txtBoxDescuentoTotal.TabIndex = 27;
            this.txtBoxDescuentoTotal.UseSystemPasswordChar = false;
            // 
            // txtBoxSubtotal
            // 
            this.txtBoxSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSubtotal.Depth = 0;
            this.txtBoxSubtotal.Hint = "";
            this.txtBoxSubtotal.Location = new System.Drawing.Point(881, 6);
            this.txtBoxSubtotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxSubtotal.Name = "txtBoxSubtotal";
            this.txtBoxSubtotal.PasswordChar = '\0';
            this.txtBoxSubtotal.SelectedText = "";
            this.txtBoxSubtotal.SelectionLength = 0;
            this.txtBoxSubtotal.SelectionStart = 0;
            this.txtBoxSubtotal.Size = new System.Drawing.Size(125, 23);
            this.txtBoxSubtotal.TabIndex = 28;
            this.txtBoxSubtotal.UseSystemPasswordChar = false;
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxTotal.Depth = 0;
            this.txtBoxTotal.Hint = "";
            this.txtBoxTotal.Location = new System.Drawing.Point(881, 43);
            this.txtBoxTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.PasswordChar = '\0';
            this.txtBoxTotal.SelectedText = "";
            this.txtBoxTotal.SelectionLength = 0;
            this.txtBoxTotal.SelectionStart = 0;
            this.txtBoxTotal.Size = new System.Drawing.Size(125, 23);
            this.txtBoxTotal.TabIndex = 29;
            this.txtBoxTotal.UseSystemPasswordChar = false;
            // 
            // tblLayoutPanelBotones
            // 
            this.tblLayoutPanelBotones.ColumnCount = 5;
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tblLayoutPanelBotones.Controls.Add(this.cmbBoxPedidosProveedores, 0, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.btnImprimir, 1, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.btnGuardar, 2, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.btnFacturaElectronica, 3, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.btnSalir, 4, 0);
            this.tblLayoutPanelBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelBotones.Location = new System.Drawing.Point(3, 511);
            this.tblLayoutPanelBotones.Name = "tblLayoutPanelBotones";
            this.tblLayoutPanelBotones.RowCount = 1;
            this.tblLayoutPanelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelBotones.Size = new System.Drawing.Size(1009, 51);
            this.tblLayoutPanelBotones.TabIndex = 16;
            // 
            // cmbBoxPedidosProveedores
            // 
            this.cmbBoxPedidosProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxPedidosProveedores.FormattingEnabled = true;
            this.cmbBoxPedidosProveedores.Location = new System.Drawing.Point(10, 15);
            this.cmbBoxPedidosProveedores.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.cmbBoxPedidosProveedores.Name = "cmbBoxPedidosProveedores";
            this.cmbBoxPedidosProveedores.Size = new System.Drawing.Size(232, 21);
            this.cmbBoxPedidosProveedores.TabIndex = 5;
            this.cmbBoxPedidosProveedores.SelectionChangeCommitted += new System.EventHandler(this.cmbBoxPedidosProveedores_SelectionChangeCommitted);
            this.cmbBoxPedidosProveedores.Click += new System.EventHandler(this.cmbBoxPedidosProveedores_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImprimir.Depth = 0;
            this.btnImprimir.Location = new System.Drawing.Point(300, 7);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImprimir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Primary = false;
            this.btnImprimir.Size = new System.Drawing.Size(74, 36);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(466, 7);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = false;
            this.btnGuardar.Size = new System.Drawing.Size(75, 36);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnFacturaElectronica
            // 
            this.btnFacturaElectronica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFacturaElectronica.AutoSize = true;
            this.btnFacturaElectronica.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFacturaElectronica.Depth = 0;
            this.btnFacturaElectronica.Location = new System.Drawing.Point(629, 7);
            this.btnFacturaElectronica.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFacturaElectronica.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFacturaElectronica.Name = "btnFacturaElectronica";
            this.btnFacturaElectronica.Primary = false;
            this.btnFacturaElectronica.Size = new System.Drawing.Size(81, 36);
            this.btnFacturaElectronica.TabIndex = 10;
            this.btnFacturaElectronica.Text = "Facturar";
            this.btnFacturaElectronica.UseVisualStyleBackColor = true;
            this.btnFacturaElectronica.Click += new System.EventHandler(this.btnFacturaElectronica_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(950, 7);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 10, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = false;
            this.btnSalir.Size = new System.Drawing.Size(49, 36);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // modeloLineaPedidoBindingSource
            // 
            this.modeloLineaPedidoBindingSource.DataSource = typeof(Modelos.ModeloLineaPedido);
            // 
            // frmPedidoCierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 620);
            this.Controls.Add(this.tblLayoutPanelPrincipal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(16, 500);
            this.Name = "frmPedidoCierre";
            this.Text = "Cierre de Pedido";
            this.tblLayoutPanelPrincipal.ResumeLayout(false);
            this.tblLayoutPanelPrincipal.PerformLayout();
            this.tbControlPrincipal.ResumeLayout(false);
            this.tbPageDatosGenerales.ResumeLayout(false);
            this.tblLayoutPanelDatosGenerales.ResumeLayout(false);
            this.tblLayoutPanelDatosEntidadMiddle.ResumeLayout(false);
            this.tblLayoutPanelRazonSocial.ResumeLayout(false);
            this.tblLayoutPanelRazonSocial.PerformLayout();
            this.grpBoxObservaciones.ResumeLayout(false);
            this.tblLayoutPanelEntidadDatos.ResumeLayout(false);
            this.tblLayoutPanelEntidadDatos.PerformLayout();
            this.tblLayoutPanelPedido.ResumeLayout(false);
            this.tblLayoutPanelPedido.PerformLayout();
            this.tbPageDomicilioFacturacion.ResumeLayout(false);
            this.tblLayoutPanelDomicilioFacturacion.ResumeLayout(false);
            this.tbPageDatosContacto.ResumeLayout(false);
            this.tblLayoutPanelDatosContacto.ResumeLayout(false);
            this.grpBoxCorreoElectronico.ResumeLayout(false);
            this.tblLayoutPanelCorreoElectronico.ResumeLayout(false);
            this.tblLayoutPanelMail.ResumeLayout(false);
            this.tblLayoutPanelMail.PerformLayout();
            this.grpBoxTelefono.ResumeLayout(false);
            this.tblLayoutPanelNumeroTelefono.ResumeLayout(false);
            this.tblLayoutPanelTelefono.ResumeLayout(false);
            this.tblLayoutPanelTelefono.PerformLayout();
            this.tabPageObservaciones.ResumeLayout(false);
            this.tableLayoutObservaciones.ResumeLayout(false);
            this.tableLayoutObservaciones.PerformLayout();
            this.grpBoxObservacionesPedido.ResumeLayout(false);
            this.pnlObservaciones.ResumeLayout(false);
            this.gbxArticulos.ResumeLayout(false);
            this.tblLayoutPanelLineasPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosVenta)).EndInit();
            this.tblLayoutPanelLineasPedidosBotones.ResumeLayout(false);
            this.tblLayoutPanelLineasPedidosBotones.PerformLayout();
            this.tblLayoutPanelValoresPedido.ResumeLayout(false);
            this.tblLayoutPanelValoresPedido.PerformLayout();
            this.tblLayoutPanelBotones.ResumeLayout(false);
            this.tblLayoutPanelBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modeloLineaPedidoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxArticulos;
        internal System.Windows.Forms.DataGridView dgvArticulosVenta;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelValoresPedido;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelBotones;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDescuentoLineas;
        private System.Windows.Forms.Label lblDescuentoTotal;
        private System.Windows.Forms.Label lblDescuentoPorcentual;
        private System.Windows.Forms.Label lblDescuentoNeto;
        private System.Windows.Forms.Label lblSenia;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDomicilioFacturacion;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDatosContacto;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelTelefono;
        private System.Windows.Forms.ComboBox cmbBoxTipoTelefono;
        private System.Windows.Forms.Label lblNumeroTelefono;
        private System.Windows.Forms.Label lblTipoTelefono;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelPrincipal;
        private System.Windows.Forms.ComboBox cmbBoxPedidosProveedores;
        private System.Windows.Forms.BindingSource modeloLineaPedidoBindingSource;
        private System.Windows.Forms.ComboBox cmbBoxDomicilios;
        private System.Windows.Forms.ComboBox cmbBoxTelefonos;
        private System.Windows.Forms.ComboBox cmbBoxMails;
        private System.Windows.Forms.DataGridViewTextBoxColumn indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn codOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn vUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorParcialSinDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorParcialConDescuento;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelLineasPedidos;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelLineasPedidosBotones;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregar;
        private MaterialSkin.Controls.MaterialFlatButton btnEditar;
        private MaterialSkin.Controls.MaterialFlatButton btnEliminar;
        private MaterialSkin.Controls.MaterialFlatButton btnImprimir;
        private MaterialSkin.Controls.MaterialFlatButton btnGuardar;
        private MaterialSkin.Controls.MaterialFlatButton btnFacturaElectronica;
        private MaterialSkin.Controls.MaterialFlatButton btnSalir;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxIVAPorcentaje;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxIVAMonto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxSenia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxDescuento1Porcentaje;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxDescuento1Monto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxDescuento2Porcentaje;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxDescuento2Monto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxDescuentoLineas;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxDescuentoTotal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxSubtotal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxTotal;
        private MaterialSkin.Controls.MaterialTabSelector selectorControlPrincipal;
        private MaterialSkin.Controls.MaterialTabControl tbControlPrincipal;
        private System.Windows.Forms.TabPage tbPageDatosGenerales;
        protected System.Windows.Forms.TableLayoutPanel tblLayoutPanelDatosGenerales;
        private System.Windows.Forms.GroupBox grpBoxObservaciones;
        private System.Windows.Forms.RichTextBox rchTextBoxObservaciones;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelEntidadDatos;
        private System.Windows.Forms.ComboBox cmbBoxContactoProveedor;
        private System.Windows.Forms.Label lblContactoProveedor;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.ComboBox cmbBoxTipoDocumento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelPedido;
        private System.Windows.Forms.Label lblCAE;
        private System.Windows.Forms.Label lblNumeroPedido;
        private System.Windows.Forms.Label lblTipoComprobante;
        private System.Windows.Forms.ComboBox cmbBoxTipoComprobante;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.ComboBox cmbBoxFormaPago;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaPedido;
        private System.Windows.Forms.TabPage tbPageDomicilioFacturacion;
        private System.Windows.Forms.TabPage tbPageDatosContacto;
        private System.Windows.Forms.TabPage tabPageObservaciones;
        private System.Windows.Forms.RichTextBox rchTextBoxObservacionesPedido;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxRazonSocial;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxNumeroDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxApellido;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxNumeroPedido;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCAE;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxMail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxTelefono;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDatosEntidadMiddle;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelRazonSocial;
        private System.Windows.Forms.GroupBox grpBoxObservacionesPedido;
        private System.Windows.Forms.GroupBox grpBoxCorreoElectronico;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelCorreoElectronico;
        private System.Windows.Forms.GroupBox grpBoxTelefono;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelNumeroTelefono;
        private System.Windows.Forms.Panel pnlObservaciones;
        private System.Windows.Forms.Label lblTipoResponsable;
        private System.Windows.Forms.ComboBox cmbBoxTipoResponsable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutObservaciones;
        private System.Windows.Forms.Label lblUsuario;
    }
}