namespace Vista
{
    partial class frmABMEntidad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblLayoutPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxTipoEntidad = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelTipoEntidad = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonCliente = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonProveedor = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonContactoProveedor = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonUsuario = new MaterialSkin.Controls.MaterialRadioButton();
            this.grpBoxObservaciones = new System.Windows.Forms.GroupBox();
            this.rchTextBoxObservaciones = new System.Windows.Forms.RichTextBox();
            this.grpBoxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelDatosPersonales = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelDatosEntidad = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxApellido = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtBoxNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtBoxRazonSocial = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.txtBoxDNI = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxCodigoEntidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxCUIT = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chbxActivo = new System.Windows.Forms.CheckBox();
            this.grpBoxDomicilio = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelDomicilioDatos = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelDomicilio = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayourPanelDomicilio_1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtBoxCalle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxNumeroDomicilio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tblLayoutPanelDomicilio_2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbBoxPais = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.cmbBoxProvincia = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtBoxPiso = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxCiudad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.txtBoxDepartamento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxCodigoPostal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tblLayoutPanelDomicilioGrid = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewDomicilio = new System.Windows.Forms.DataGridView();
            this.codigoDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLayoutPanelDomicilioAgregarQuitar = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregarDomicilio = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnQuitarDomicilio = new MaterialSkin.Controls.MaterialFlatButton();
            this.grpBoxContacto = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelContacto = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelTelefonoLista = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelTelefonoListaAgregarQuitar = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuitarTelefono = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAgregarTelefono = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridViewTelefono = new System.Windows.Forms.DataGridView();
            this.codigoTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLayoutPanelTelefono = new System.Windows.Forms.TableLayoutPanel();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.cmbBoxTipoTelefono = new System.Windows.Forms.ComboBox();
            this.txtBoxTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tblLayoutPanelMail = new System.Windows.Forms.TableLayoutPanel();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtBoxMail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tblLayoutPanelMailLista = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelMailListaAgregarQuitar = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregarMail = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnQuitarMail = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridViewMail = new System.Windows.Forms.DataGridView();
            this.codigoMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDatosAdicionales = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.epCodigoEntidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCUIT = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDNI = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.epApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.epRazonSocial = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCalle = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNumeroDomicilio = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPiso = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDepartamento = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCodigoPostal = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCiudad = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNumeroTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderActual)).BeginInit();
            this.tblLayoutPanelPrincipal.SuspendLayout();
            this.grpBoxTipoEntidad.SuspendLayout();
            this.tblLayoutPanelTipoEntidad.SuspendLayout();
            this.grpBoxObservaciones.SuspendLayout();
            this.grpBoxDatosPersonales.SuspendLayout();
            this.tblLayoutPanelDatosPersonales.SuspendLayout();
            this.tblLayoutPanelDatosEntidad.SuspendLayout();
            this.grpBoxDomicilio.SuspendLayout();
            this.tblLayoutPanelDomicilioDatos.SuspendLayout();
            this.tblLayoutPanelDomicilio.SuspendLayout();
            this.tblLayourPanelDomicilio_1.SuspendLayout();
            this.tblLayoutPanelDomicilio_2.SuspendLayout();
            this.tblLayoutPanelDomicilioGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDomicilio)).BeginInit();
            this.tblLayoutPanelDomicilioAgregarQuitar.SuspendLayout();
            this.grpBoxContacto.SuspendLayout();
            this.tblLayoutPanelContacto.SuspendLayout();
            this.tblLayoutPanelTelefonoLista.SuspendLayout();
            this.tblLayoutPanelTelefonoListaAgregarQuitar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelefono)).BeginInit();
            this.tblLayoutPanelTelefono.SuspendLayout();
            this.tblLayoutPanelMail.SuspendLayout();
            this.tblLayoutPanelMailLista.SuspendLayout();
            this.tblLayoutPanelMailListaAgregarQuitar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMail)).BeginInit();
            this.pnlBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigoEntidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCUIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRazonSocial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNumeroDomicilio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigoPostal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNumeroTelefono)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLayoutPanelPrincipal
            // 
            this.tblLayoutPanelPrincipal.ColumnCount = 1;
            this.tblLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal.Controls.Add(this.grpBoxTipoEntidad, 0, 0);
            this.tblLayoutPanelPrincipal.Controls.Add(this.grpBoxObservaciones, 0, 4);
            this.tblLayoutPanelPrincipal.Controls.Add(this.grpBoxDatosPersonales, 0, 1);
            this.tblLayoutPanelPrincipal.Controls.Add(this.grpBoxDomicilio, 0, 2);
            this.tblLayoutPanelPrincipal.Controls.Add(this.grpBoxContacto, 0, 3);
            this.tblLayoutPanelPrincipal.Controls.Add(this.btnDatosAdicionales, 0, 5);
            this.tblLayoutPanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanelPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.tblLayoutPanelPrincipal.Name = "tblLayoutPanelPrincipal";
            this.tblLayoutPanelPrincipal.RowCount = 6;
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.71717F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.70707F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.62014F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tblLayoutPanelPrincipal.Size = new System.Drawing.Size(985, 825);
            this.tblLayoutPanelPrincipal.TabIndex = 4;
            // 
            // grpBoxTipoEntidad
            // 
            this.grpBoxTipoEntidad.Controls.Add(this.tblLayoutPanelTipoEntidad);
            this.grpBoxTipoEntidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxTipoEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxTipoEntidad.Location = new System.Drawing.Point(4, 4);
            this.grpBoxTipoEntidad.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxTipoEntidad.Name = "grpBoxTipoEntidad";
            this.grpBoxTipoEntidad.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxTipoEntidad.Size = new System.Drawing.Size(977, 63);
            this.grpBoxTipoEntidad.TabIndex = 4;
            this.grpBoxTipoEntidad.TabStop = false;
            this.grpBoxTipoEntidad.Text = "Tipo Entidad";
            // 
            // tblLayoutPanelTipoEntidad
            // 
            this.tblLayoutPanelTipoEntidad.ColumnCount = 6;
            this.tblLayoutPanelTipoEntidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelTipoEntidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLayoutPanelTipoEntidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tblLayoutPanelTipoEntidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tblLayoutPanelTipoEntidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLayoutPanelTipoEntidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelTipoEntidad.Controls.Add(this.radioButtonCliente, 1, 0);
            this.tblLayoutPanelTipoEntidad.Controls.Add(this.radioButtonProveedor, 2, 0);
            this.tblLayoutPanelTipoEntidad.Controls.Add(this.radioButtonContactoProveedor, 3, 0);
            this.tblLayoutPanelTipoEntidad.Controls.Add(this.radioButtonUsuario, 4, 0);
            this.tblLayoutPanelTipoEntidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelTipoEntidad.Location = new System.Drawing.Point(4, 26);
            this.tblLayoutPanelTipoEntidad.Margin = new System.Windows.Forms.Padding(4);
            this.tblLayoutPanelTipoEntidad.Name = "tblLayoutPanelTipoEntidad";
            this.tblLayoutPanelTipoEntidad.RowCount = 1;
            this.tblLayoutPanelTipoEntidad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelTipoEntidad.Size = new System.Drawing.Size(969, 33);
            this.tblLayoutPanelTipoEntidad.TabIndex = 5;
            // 
            // radioButtonCliente
            // 
            this.radioButtonCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonCliente.AutoSize = true;
            this.radioButtonCliente.Depth = 0;
            this.radioButtonCliente.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonCliente.Location = new System.Drawing.Point(151, 1);
            this.radioButtonCliente.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonCliente.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonCliente.Name = "radioButtonCliente";
            this.radioButtonCliente.Ripple = true;
            this.radioButtonCliente.Size = new System.Drawing.Size(120, 30);
            this.radioButtonCliente.TabIndex = 5;
            this.radioButtonCliente.TabStop = true;
            this.radioButtonCliente.Text = "Cliente";
            this.radioButtonCliente.UseVisualStyleBackColor = true;
            this.radioButtonCliente.CheckedChanged += new System.EventHandler(this.radioButtonCliente_CheckedChanged);
            // 
            // radioButtonProveedor
            // 
            this.radioButtonProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonProveedor.AutoSize = true;
            this.radioButtonProveedor.Depth = 0;
            this.radioButtonProveedor.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonProveedor.Location = new System.Drawing.Point(271, 1);
            this.radioButtonProveedor.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonProveedor.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonProveedor.Name = "radioButtonProveedor";
            this.radioButtonProveedor.Ripple = true;
            this.radioButtonProveedor.Size = new System.Drawing.Size(160, 30);
            this.radioButtonProveedor.TabIndex = 6;
            this.radioButtonProveedor.TabStop = true;
            this.radioButtonProveedor.Text = "Proveedor";
            this.radioButtonProveedor.UseVisualStyleBackColor = true;
            this.radioButtonProveedor.CheckedChanged += new System.EventHandler(this.radioButtonProveedor_CheckedChanged);
            // 
            // radioButtonContactoProveedor
            // 
            this.radioButtonContactoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonContactoProveedor.AutoSize = true;
            this.radioButtonContactoProveedor.Depth = 0;
            this.radioButtonContactoProveedor.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonContactoProveedor.Location = new System.Drawing.Point(431, 1);
            this.radioButtonContactoProveedor.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonContactoProveedor.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonContactoProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonContactoProveedor.Name = "radioButtonContactoProveedor";
            this.radioButtonContactoProveedor.Ripple = true;
            this.radioButtonContactoProveedor.Size = new System.Drawing.Size(267, 30);
            this.radioButtonContactoProveedor.TabIndex = 7;
            this.radioButtonContactoProveedor.TabStop = true;
            this.radioButtonContactoProveedor.Text = "Contacto Proveedor";
            this.radioButtonContactoProveedor.UseVisualStyleBackColor = true;
            this.radioButtonContactoProveedor.CheckedChanged += new System.EventHandler(this.radioButtonContactoProveedor_CheckedChanged);
            // 
            // radioButtonUsuario
            // 
            this.radioButtonUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonUsuario.AutoSize = true;
            this.radioButtonUsuario.Depth = 0;
            this.radioButtonUsuario.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonUsuario.Location = new System.Drawing.Point(698, 1);
            this.radioButtonUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonUsuario.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonUsuario.Name = "radioButtonUsuario";
            this.radioButtonUsuario.Ripple = true;
            this.radioButtonUsuario.Size = new System.Drawing.Size(120, 30);
            this.radioButtonUsuario.TabIndex = 8;
            this.radioButtonUsuario.TabStop = true;
            this.radioButtonUsuario.Text = "Usuario";
            this.radioButtonUsuario.UseVisualStyleBackColor = true;
            this.radioButtonUsuario.CheckedChanged += new System.EventHandler(this.radioButtonUsuario_CheckedChanged);
            // 
            // grpBoxObservaciones
            // 
            this.grpBoxObservaciones.Controls.Add(this.rchTextBoxObservaciones);
            this.grpBoxObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxObservaciones.Location = new System.Drawing.Point(4, 677);
            this.grpBoxObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxObservaciones.Name = "grpBoxObservaciones";
            this.grpBoxObservaciones.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxObservaciones.Size = new System.Drawing.Size(977, 93);
            this.grpBoxObservaciones.TabIndex = 6;
            this.grpBoxObservaciones.TabStop = false;
            this.grpBoxObservaciones.Text = "Observaciones";
            // 
            // rchTextBoxObservaciones
            // 
            this.rchTextBoxObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchTextBoxObservaciones.Location = new System.Drawing.Point(4, 26);
            this.rchTextBoxObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.rchTextBoxObservaciones.Name = "rchTextBoxObservaciones";
            this.rchTextBoxObservaciones.Size = new System.Drawing.Size(969, 63);
            this.rchTextBoxObservaciones.TabIndex = 25;
            this.rchTextBoxObservaciones.Text = "";
            // 
            // grpBoxDatosPersonales
            // 
            this.grpBoxDatosPersonales.Controls.Add(this.tblLayoutPanelDatosPersonales);
            this.grpBoxDatosPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDatosPersonales.Location = new System.Drawing.Point(4, 75);
            this.grpBoxDatosPersonales.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxDatosPersonales.Name = "grpBoxDatosPersonales";
            this.grpBoxDatosPersonales.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxDatosPersonales.Size = new System.Drawing.Size(977, 118);
            this.grpBoxDatosPersonales.TabIndex = 3;
            this.grpBoxDatosPersonales.TabStop = false;
            this.grpBoxDatosPersonales.Text = "Datos Personales";
            // 
            // tblLayoutPanelDatosPersonales
            // 
            this.tblLayoutPanelDatosPersonales.ColumnCount = 2;
            this.tblLayoutPanelDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.tblLayoutPanelDatosEntidad, 0, 0);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.chbxActivo, 1, 0);
            this.tblLayoutPanelDatosPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDatosPersonales.Location = new System.Drawing.Point(4, 26);
            this.tblLayoutPanelDatosPersonales.Margin = new System.Windows.Forms.Padding(4);
            this.tblLayoutPanelDatosPersonales.Name = "tblLayoutPanelDatosPersonales";
            this.tblLayoutPanelDatosPersonales.RowCount = 1;
            this.tblLayoutPanelDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDatosPersonales.Size = new System.Drawing.Size(969, 88);
            this.tblLayoutPanelDatosPersonales.TabIndex = 0;
            // 
            // tblLayoutPanelDatosEntidad
            // 
            this.tblLayoutPanelDatosEntidad.ColumnCount = 6;
            this.tblLayoutPanelDatosEntidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tblLayoutPanelDatosEntidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblLayoutPanelDatosEntidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tblLayoutPanelDatosEntidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelDatosEntidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tblLayoutPanelDatosEntidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelDatosEntidad.Controls.Add(this.txtBoxApellido, 3, 1);
            this.tblLayoutPanelDatosEntidad.Controls.Add(this.lblApellido, 2, 1);
            this.tblLayoutPanelDatosEntidad.Controls.Add(this.lblNombre, 0, 1);
            this.tblLayoutPanelDatosEntidad.Controls.Add(this.lblRazonSocial, 4, 1);
            this.tblLayoutPanelDatosEntidad.Controls.Add(this.txtBoxNombre, 1, 1);
            this.tblLayoutPanelDatosEntidad.Controls.Add(this.lblDNI, 4, 0);
            this.tblLayoutPanelDatosEntidad.Controls.Add(this.txtBoxRazonSocial, 5, 1);
            this.tblLayoutPanelDatosEntidad.Controls.Add(this.lblCodigo, 0, 0);
            this.tblLayoutPanelDatosEntidad.Controls.Add(this.lblCUIT, 2, 0);
            this.tblLayoutPanelDatosEntidad.Controls.Add(this.txtBoxDNI, 5, 0);
            this.tblLayoutPanelDatosEntidad.Controls.Add(this.txtBoxCodigoEntidad, 1, 0);
            this.tblLayoutPanelDatosEntidad.Controls.Add(this.txtBoxCUIT, 3, 0);
            this.tblLayoutPanelDatosEntidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDatosEntidad.Location = new System.Drawing.Point(3, 2);
            this.tblLayoutPanelDatosEntidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblLayoutPanelDatosEntidad.Name = "tblLayoutPanelDatosEntidad";
            this.tblLayoutPanelDatosEntidad.RowCount = 2;
            this.tblLayoutPanelDatosEntidad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDatosEntidad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDatosEntidad.Size = new System.Drawing.Size(863, 84);
            this.tblLayoutPanelDatosEntidad.TabIndex = 6;
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxApellido.Depth = 0;
            this.txtBoxApellido.Hint = "";
            this.txtBoxApellido.Location = new System.Drawing.Point(366, 49);
            this.txtBoxApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.PasswordChar = '\0';
            this.txtBoxApellido.SelectedText = "";
            this.txtBoxApellido.SelectionLength = 0;
            this.txtBoxApellido.SelectionStart = 0;
            this.txtBoxApellido.Size = new System.Drawing.Size(172, 28);
            this.txtBoxApellido.TabIndex = 17;
            this.txtBoxApellido.UseSystemPasswordChar = false;
            this.txtBoxApellido.Leave += new System.EventHandler(this.txtBoxApellido_Leave);
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(285, 53);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(73, 20);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(14, 53);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(565, 53);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(113, 20);
            this.lblRazonSocial.TabIndex = 10;
            this.lblRazonSocial.Text = "Razón Social:";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNombre.Depth = 0;
            this.txtBoxNombre.Hint = "";
            this.txtBoxNombre.Location = new System.Drawing.Point(95, 49);
            this.txtBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.PasswordChar = '\0';
            this.txtBoxNombre.SelectedText = "";
            this.txtBoxNombre.SelectionLength = 0;
            this.txtBoxNombre.SelectionStart = 0;
            this.txtBoxNombre.Size = new System.Drawing.Size(172, 28);
            this.txtBoxNombre.TabIndex = 18;
            this.txtBoxNombre.UseSystemPasswordChar = false;
            this.txtBoxNombre.Leave += new System.EventHandler(this.txtBoxNombre_Leave);
            // 
            // lblDNI
            // 
            this.lblDNI.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(635, 11);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(43, 20);
            this.lblDNI.TabIndex = 12;
            this.lblDNI.Text = "DNI:";
            // 
            // txtBoxRazonSocial
            // 
            this.txtBoxRazonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxRazonSocial.Depth = 0;
            this.txtBoxRazonSocial.Hint = "";
            this.txtBoxRazonSocial.Location = new System.Drawing.Point(686, 49);
            this.txtBoxRazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxRazonSocial.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxRazonSocial.Name = "txtBoxRazonSocial";
            this.txtBoxRazonSocial.PasswordChar = '\0';
            this.txtBoxRazonSocial.SelectedText = "";
            this.txtBoxRazonSocial.SelectionLength = 0;
            this.txtBoxRazonSocial.SelectionStart = 0;
            this.txtBoxRazonSocial.Size = new System.Drawing.Size(173, 28);
            this.txtBoxRazonSocial.TabIndex = 16;
            this.txtBoxRazonSocial.UseSystemPasswordChar = false;
            this.txtBoxRazonSocial.Leave += new System.EventHandler(this.txtBoxRazonSocial_Leave);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(21, 11);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(66, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblCUIT
            // 
            this.lblCUIT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUIT.Location = new System.Drawing.Point(306, 11);
            this.lblCUIT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(52, 20);
            this.lblCUIT.TabIndex = 4;
            this.lblCUIT.Text = "CUIT:";
            // 
            // txtBoxDNI
            // 
            this.txtBoxDNI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDNI.Depth = 0;
            this.txtBoxDNI.Hint = "";
            this.txtBoxDNI.Location = new System.Drawing.Point(686, 7);
            this.txtBoxDNI.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxDNI.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDNI.Name = "txtBoxDNI";
            this.txtBoxDNI.PasswordChar = '\0';
            this.txtBoxDNI.SelectedText = "";
            this.txtBoxDNI.SelectionLength = 0;
            this.txtBoxDNI.SelectionStart = 0;
            this.txtBoxDNI.Size = new System.Drawing.Size(173, 28);
            this.txtBoxDNI.TabIndex = 15;
            this.txtBoxDNI.UseSystemPasswordChar = false;
            this.txtBoxDNI.Leave += new System.EventHandler(this.txtBoxDNI_Leave);
            // 
            // txtBoxCodigoEntidad
            // 
            this.txtBoxCodigoEntidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoEntidad.Depth = 0;
            this.txtBoxCodigoEntidad.Hint = "";
            this.txtBoxCodigoEntidad.Location = new System.Drawing.Point(95, 7);
            this.txtBoxCodigoEntidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxCodigoEntidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCodigoEntidad.Name = "txtBoxCodigoEntidad";
            this.txtBoxCodigoEntidad.PasswordChar = '\0';
            this.txtBoxCodigoEntidad.SelectedText = "";
            this.txtBoxCodigoEntidad.SelectionLength = 0;
            this.txtBoxCodigoEntidad.SelectionStart = 0;
            this.txtBoxCodigoEntidad.Size = new System.Drawing.Size(172, 28);
            this.txtBoxCodigoEntidad.TabIndex = 13;
            this.txtBoxCodigoEntidad.UseSystemPasswordChar = false;
            this.txtBoxCodigoEntidad.Leave += new System.EventHandler(this.txtBoxCodigoEntidad_Leave);
            // 
            // txtBoxCUIT
            // 
            this.txtBoxCUIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCUIT.Depth = 0;
            this.txtBoxCUIT.Hint = "";
            this.txtBoxCUIT.Location = new System.Drawing.Point(366, 7);
            this.txtBoxCUIT.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxCUIT.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCUIT.Name = "txtBoxCUIT";
            this.txtBoxCUIT.PasswordChar = '\0';
            this.txtBoxCUIT.SelectedText = "";
            this.txtBoxCUIT.SelectionLength = 0;
            this.txtBoxCUIT.SelectionStart = 0;
            this.txtBoxCUIT.Size = new System.Drawing.Size(172, 28);
            this.txtBoxCUIT.TabIndex = 14;
            this.txtBoxCUIT.UseSystemPasswordChar = false;
            this.txtBoxCUIT.Leave += new System.EventHandler(this.txtBoxCUIT_Leave);
            // 
            // chbxActivo
            // 
            this.chbxActivo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chbxActivo.AutoSize = true;
            this.chbxActivo.Location = new System.Drawing.Point(873, 30);
            this.chbxActivo.Margin = new System.Windows.Forms.Padding(4);
            this.chbxActivo.Name = "chbxActivo";
            this.chbxActivo.Size = new System.Drawing.Size(83, 28);
            this.chbxActivo.TabIndex = 19;
            this.chbxActivo.Text = "Activo";
            this.chbxActivo.UseVisualStyleBackColor = true;
            // 
            // grpBoxDomicilio
            // 
            this.grpBoxDomicilio.Controls.Add(this.tblLayoutPanelDomicilioDatos);
            this.grpBoxDomicilio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDomicilio.Location = new System.Drawing.Point(4, 201);
            this.grpBoxDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxDomicilio.Name = "grpBoxDomicilio";
            this.grpBoxDomicilio.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxDomicilio.Size = new System.Drawing.Size(977, 291);
            this.grpBoxDomicilio.TabIndex = 4;
            this.grpBoxDomicilio.TabStop = false;
            this.grpBoxDomicilio.Text = "Domicilio";
            // 
            // tblLayoutPanelDomicilioDatos
            // 
            this.tblLayoutPanelDomicilioDatos.ColumnCount = 1;
            this.tblLayoutPanelDomicilioDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDomicilioDatos.Controls.Add(this.tblLayoutPanelDomicilio, 0, 0);
            this.tblLayoutPanelDomicilioDatos.Controls.Add(this.tblLayoutPanelDomicilioGrid, 0, 1);
            this.tblLayoutPanelDomicilioDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDomicilioDatos.Location = new System.Drawing.Point(4, 26);
            this.tblLayoutPanelDomicilioDatos.Margin = new System.Windows.Forms.Padding(4);
            this.tblLayoutPanelDomicilioDatos.Name = "tblLayoutPanelDomicilioDatos";
            this.tblLayoutPanelDomicilioDatos.RowCount = 2;
            this.tblLayoutPanelDomicilioDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tblLayoutPanelDomicilioDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDomicilioDatos.Size = new System.Drawing.Size(969, 261);
            this.tblLayoutPanelDomicilioDatos.TabIndex = 1;
            // 
            // tblLayoutPanelDomicilio
            // 
            this.tblLayoutPanelDomicilio.ColumnCount = 1;
            this.tblLayoutPanelDomicilio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDomicilio.Controls.Add(this.tblLayourPanelDomicilio_1, 0, 0);
            this.tblLayoutPanelDomicilio.Controls.Add(this.tblLayoutPanelDomicilio_2, 0, 1);
            this.tblLayoutPanelDomicilio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDomicilio.Location = new System.Drawing.Point(3, 2);
            this.tblLayoutPanelDomicilio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblLayoutPanelDomicilio.Name = "tblLayoutPanelDomicilio";
            this.tblLayoutPanelDomicilio.RowCount = 2;
            this.tblLayoutPanelDomicilio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tblLayoutPanelDomicilio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblLayoutPanelDomicilio.Size = new System.Drawing.Size(963, 126);
            this.tblLayoutPanelDomicilio.TabIndex = 6;
            // 
            // tblLayourPanelDomicilio_1
            // 
            this.tblLayourPanelDomicilio_1.ColumnCount = 4;
            this.tblLayourPanelDomicilio_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tblLayourPanelDomicilio_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayourPanelDomicilio_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tblLayourPanelDomicilio_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tblLayourPanelDomicilio_1.Controls.Add(this.lblNumero, 2, 0);
            this.tblLayourPanelDomicilio_1.Controls.Add(this.lblCalle, 0, 0);
            this.tblLayourPanelDomicilio_1.Controls.Add(this.txtBoxCalle, 1, 0);
            this.tblLayourPanelDomicilio_1.Controls.Add(this.txtBoxNumeroDomicilio, 3, 0);
            this.tblLayourPanelDomicilio_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayourPanelDomicilio_1.Location = new System.Drawing.Point(0, 0);
            this.tblLayourPanelDomicilio_1.Margin = new System.Windows.Forms.Padding(0);
            this.tblLayourPanelDomicilio_1.Name = "tblLayourPanelDomicilio_1";
            this.tblLayourPanelDomicilio_1.RowCount = 1;
            this.tblLayourPanelDomicilio_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayourPanelDomicilio_1.Size = new System.Drawing.Size(963, 39);
            this.tblLayourPanelDomicilio_1.TabIndex = 0;
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(686, 9);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(73, 20);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Número:";
            // 
            // lblCalle
            // 
            this.lblCalle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(35, 9);
            this.lblCalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(52, 20);
            this.lblCalle.TabIndex = 1;
            this.lblCalle.Text = "Calle:";
            // 
            // txtBoxCalle
            // 
            this.txtBoxCalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCalle.Depth = 0;
            this.txtBoxCalle.Hint = "";
            this.txtBoxCalle.Location = new System.Drawing.Point(95, 5);
            this.txtBoxCalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxCalle.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCalle.Name = "txtBoxCalle";
            this.txtBoxCalle.PasswordChar = '\0';
            this.txtBoxCalle.SelectedText = "";
            this.txtBoxCalle.SelectionLength = 0;
            this.txtBoxCalle.SelectionStart = 0;
            this.txtBoxCalle.Size = new System.Drawing.Size(515, 28);
            this.txtBoxCalle.TabIndex = 19;
            this.txtBoxCalle.UseSystemPasswordChar = false;
            this.txtBoxCalle.Leave += new System.EventHandler(this.txtBoxCalle_Leave);
            // 
            // txtBoxNumeroDomicilio
            // 
            this.txtBoxNumeroDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNumeroDomicilio.Depth = 0;
            this.txtBoxNumeroDomicilio.Hint = "";
            this.txtBoxNumeroDomicilio.Location = new System.Drawing.Point(767, 5);
            this.txtBoxNumeroDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNumeroDomicilio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxNumeroDomicilio.Name = "txtBoxNumeroDomicilio";
            this.txtBoxNumeroDomicilio.PasswordChar = '\0';
            this.txtBoxNumeroDomicilio.SelectedText = "";
            this.txtBoxNumeroDomicilio.SelectionLength = 0;
            this.txtBoxNumeroDomicilio.SelectionStart = 0;
            this.txtBoxNumeroDomicilio.Size = new System.Drawing.Size(192, 28);
            this.txtBoxNumeroDomicilio.TabIndex = 21;
            this.txtBoxNumeroDomicilio.UseSystemPasswordChar = false;
            this.txtBoxNumeroDomicilio.Leave += new System.EventHandler(this.txtBoxNumeroDomicilio_Leave);
            // 
            // tblLayoutPanelDomicilio_2
            // 
            this.tblLayoutPanelDomicilio_2.ColumnCount = 6;
            this.tblLayoutPanelDomicilio_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tblLayoutPanelDomicilio_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDomicilio_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tblLayoutPanelDomicilio_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDomicilio_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tblLayoutPanelDomicilio_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tblLayoutPanelDomicilio_2.Controls.Add(this.cmbBoxPais, 5, 1);
            this.tblLayoutPanelDomicilio_2.Controls.Add(this.lblPais, 4, 1);
            this.tblLayoutPanelDomicilio_2.Controls.Add(this.cmbBoxProvincia, 3, 1);
            this.tblLayoutPanelDomicilio_2.Controls.Add(this.lblProvincia, 2, 1);
            this.tblLayoutPanelDomicilio_2.Controls.Add(this.lblDepartamento, 2, 0);
            this.tblLayoutPanelDomicilio_2.Controls.Add(this.lblPiso, 0, 0);
            this.tblLayoutPanelDomicilio_2.Controls.Add(this.lblCiudad, 0, 1);
            this.tblLayoutPanelDomicilio_2.Controls.Add(this.txtBoxPiso, 1, 0);
            this.tblLayoutPanelDomicilio_2.Controls.Add(this.txtBoxCiudad, 1, 1);
            this.tblLayoutPanelDomicilio_2.Controls.Add(this.lblCodigoPostal, 4, 0);
            this.tblLayoutPanelDomicilio_2.Controls.Add(this.txtBoxDepartamento, 3, 0);
            this.tblLayoutPanelDomicilio_2.Controls.Add(this.txtBoxCodigoPostal, 5, 0);
            this.tblLayoutPanelDomicilio_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDomicilio_2.Location = new System.Drawing.Point(0, 39);
            this.tblLayoutPanelDomicilio_2.Margin = new System.Windows.Forms.Padding(0);
            this.tblLayoutPanelDomicilio_2.Name = "tblLayoutPanelDomicilio_2";
            this.tblLayoutPanelDomicilio_2.RowCount = 2;
            this.tblLayoutPanelDomicilio_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tblLayoutPanelDomicilio_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tblLayoutPanelDomicilio_2.Size = new System.Drawing.Size(963, 87);
            this.tblLayoutPanelDomicilio_2.TabIndex = 1;
            // 
            // cmbBoxPais
            // 
            this.cmbBoxPais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxPais.FormattingEnabled = true;
            this.cmbBoxPais.Location = new System.Drawing.Point(767, 50);
            this.cmbBoxPais.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxPais.Name = "cmbBoxPais";
            this.cmbBoxPais.Size = new System.Drawing.Size(192, 32);
            this.cmbBoxPais.TabIndex = 17;
            this.cmbBoxPais.SelectionChangeCommitted += new System.EventHandler(this.cmbBoxPais_SelectionChangeCommitted);
            // 
            // lblPais
            // 
            this.lblPais.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(712, 53);
            this.lblPais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(47, 20);
            this.lblPais.TabIndex = 15;
            this.lblPais.Text = "País:";
            // 
            // cmbBoxProvincia
            // 
            this.cmbBoxProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxProvincia.FormattingEnabled = true;
            this.cmbBoxProvincia.Location = new System.Drawing.Point(409, 50);
            this.cmbBoxProvincia.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxProvincia.Name = "cmbBoxProvincia";
            this.cmbBoxProvincia.Size = new System.Drawing.Size(201, 32);
            this.cmbBoxProvincia.TabIndex = 18;
            // 
            // lblProvincia
            // 
            this.lblProvincia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(318, 53);
            this.lblProvincia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(83, 20);
            this.lblProvincia.TabIndex = 6;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(351, 9);
            this.lblDepartamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(50, 20);
            this.lblDepartamento.TabIndex = 7;
            this.lblDepartamento.Text = "Dpto:";
            // 
            // lblPiso
            // 
            this.lblPiso.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPiso.AutoSize = true;
            this.lblPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiso.Location = new System.Drawing.Point(40, 9);
            this.lblPiso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(47, 20);
            this.lblPiso.TabIndex = 2;
            this.lblPiso.Text = "Piso:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(21, 53);
            this.lblCiudad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(66, 20);
            this.lblCiudad.TabIndex = 5;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // txtBoxPiso
            // 
            this.txtBoxPiso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPiso.Depth = 0;
            this.txtBoxPiso.Hint = "";
            this.txtBoxPiso.Location = new System.Drawing.Point(95, 5);
            this.txtBoxPiso.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPiso.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxPiso.Name = "txtBoxPiso";
            this.txtBoxPiso.PasswordChar = '\0';
            this.txtBoxPiso.SelectedText = "";
            this.txtBoxPiso.SelectionLength = 0;
            this.txtBoxPiso.SelectionStart = 0;
            this.txtBoxPiso.Size = new System.Drawing.Size(201, 28);
            this.txtBoxPiso.TabIndex = 23;
            this.txtBoxPiso.UseSystemPasswordChar = false;
            this.txtBoxPiso.Leave += new System.EventHandler(this.txtBoxPiso_Leave);
            // 
            // txtBoxCiudad
            // 
            this.txtBoxCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCiudad.Depth = 0;
            this.txtBoxCiudad.Hint = "";
            this.txtBoxCiudad.Location = new System.Drawing.Point(95, 49);
            this.txtBoxCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxCiudad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCiudad.Name = "txtBoxCiudad";
            this.txtBoxCiudad.PasswordChar = '\0';
            this.txtBoxCiudad.SelectedText = "";
            this.txtBoxCiudad.SelectionLength = 0;
            this.txtBoxCiudad.SelectionStart = 0;
            this.txtBoxCiudad.Size = new System.Drawing.Size(201, 28);
            this.txtBoxCiudad.TabIndex = 20;
            this.txtBoxCiudad.UseSystemPasswordChar = false;
            this.txtBoxCiudad.Leave += new System.EventHandler(this.txtBoxCiudad_Leave);
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPostal.Location = new System.Drawing.Point(641, 9);
            this.lblCodigoPostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(118, 20);
            this.lblCodigoPostal.TabIndex = 4;
            this.lblCodigoPostal.Text = "Código Postal:";
            // 
            // txtBoxDepartamento
            // 
            this.txtBoxDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDepartamento.Depth = 0;
            this.txtBoxDepartamento.Hint = "";
            this.txtBoxDepartamento.Location = new System.Drawing.Point(409, 5);
            this.txtBoxDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxDepartamento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDepartamento.Name = "txtBoxDepartamento";
            this.txtBoxDepartamento.PasswordChar = '\0';
            this.txtBoxDepartamento.SelectedText = "";
            this.txtBoxDepartamento.SelectionLength = 0;
            this.txtBoxDepartamento.SelectionStart = 0;
            this.txtBoxDepartamento.Size = new System.Drawing.Size(201, 28);
            this.txtBoxDepartamento.TabIndex = 24;
            this.txtBoxDepartamento.UseSystemPasswordChar = false;
            this.txtBoxDepartamento.Leave += new System.EventHandler(this.txtBoxDepartamento_Leave);
            // 
            // txtBoxCodigoPostal
            // 
            this.txtBoxCodigoPostal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoPostal.Depth = 0;
            this.txtBoxCodigoPostal.Hint = "";
            this.txtBoxCodigoPostal.Location = new System.Drawing.Point(767, 5);
            this.txtBoxCodigoPostal.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxCodigoPostal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCodigoPostal.Name = "txtBoxCodigoPostal";
            this.txtBoxCodigoPostal.PasswordChar = '\0';
            this.txtBoxCodigoPostal.SelectedText = "";
            this.txtBoxCodigoPostal.SelectionLength = 0;
            this.txtBoxCodigoPostal.SelectionStart = 0;
            this.txtBoxCodigoPostal.Size = new System.Drawing.Size(192, 28);
            this.txtBoxCodigoPostal.TabIndex = 22;
            this.txtBoxCodigoPostal.UseSystemPasswordChar = false;
            this.txtBoxCodigoPostal.Leave += new System.EventHandler(this.txtBoxCodigoPostal_Leave);
            // 
            // tblLayoutPanelDomicilioGrid
            // 
            this.tblLayoutPanelDomicilioGrid.ColumnCount = 2;
            this.tblLayoutPanelDomicilioGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDomicilioGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tblLayoutPanelDomicilioGrid.Controls.Add(this.dataGridViewDomicilio, 0, 0);
            this.tblLayoutPanelDomicilioGrid.Controls.Add(this.tblLayoutPanelDomicilioAgregarQuitar, 1, 0);
            this.tblLayoutPanelDomicilioGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDomicilioGrid.Location = new System.Drawing.Point(4, 134);
            this.tblLayoutPanelDomicilioGrid.Margin = new System.Windows.Forms.Padding(4);
            this.tblLayoutPanelDomicilioGrid.Name = "tblLayoutPanelDomicilioGrid";
            this.tblLayoutPanelDomicilioGrid.RowCount = 1;
            this.tblLayoutPanelDomicilioGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDomicilioGrid.Size = new System.Drawing.Size(961, 123);
            this.tblLayoutPanelDomicilioGrid.TabIndex = 1;
            // 
            // dataGridViewDomicilio
            // 
            this.dataGridViewDomicilio.AllowUserToAddRows = false;
            this.dataGridViewDomicilio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDomicilio.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDomicilio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDomicilio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDomicilio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDomicilio,
            this.calle,
            this.numero,
            this.piso,
            this.departamento,
            this.codigoPostal,
            this.ciudad,
            this.codigoProvincia,
            this.provincia,
            this.codigoPais,
            this.pais});
            this.dataGridViewDomicilio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDomicilio.GridColor = System.Drawing.Color.White;
            this.dataGridViewDomicilio.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDomicilio.Name = "dataGridViewDomicilio";
            this.dataGridViewDomicilio.ReadOnly = true;
            this.dataGridViewDomicilio.RowHeadersVisible = false;
            this.dataGridViewDomicilio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDomicilio.Size = new System.Drawing.Size(909, 115);
            this.dataGridViewDomicilio.TabIndex = 0;
            this.dataGridViewDomicilio.TabStop = false;
            // 
            // codigoDomicilio
            // 
            this.codigoDomicilio.HeaderText = "codigoDomicilio";
            this.codigoDomicilio.Name = "codigoDomicilio";
            this.codigoDomicilio.ReadOnly = true;
            this.codigoDomicilio.Visible = false;
            // 
            // calle
            // 
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // piso
            // 
            this.piso.HeaderText = "Piso";
            this.piso.Name = "piso";
            this.piso.ReadOnly = true;
            // 
            // departamento
            // 
            this.departamento.HeaderText = "Dpto";
            this.departamento.Name = "departamento";
            this.departamento.ReadOnly = true;
            // 
            // codigoPostal
            // 
            this.codigoPostal.HeaderText = "CP";
            this.codigoPostal.Name = "codigoPostal";
            this.codigoPostal.ReadOnly = true;
            // 
            // ciudad
            // 
            this.ciudad.HeaderText = "Ciudad";
            this.ciudad.Name = "ciudad";
            this.ciudad.ReadOnly = true;
            // 
            // codigoProvincia
            // 
            this.codigoProvincia.HeaderText = "codigoProvincia";
            this.codigoProvincia.Name = "codigoProvincia";
            this.codigoProvincia.ReadOnly = true;
            this.codigoProvincia.Visible = false;
            // 
            // provincia
            // 
            this.provincia.HeaderText = "Provincia";
            this.provincia.Name = "provincia";
            this.provincia.ReadOnly = true;
            // 
            // codigoPais
            // 
            this.codigoPais.HeaderText = "codigoPais";
            this.codigoPais.Name = "codigoPais";
            this.codigoPais.ReadOnly = true;
            this.codigoPais.Visible = false;
            // 
            // pais
            // 
            this.pais.HeaderText = "País";
            this.pais.Name = "pais";
            this.pais.ReadOnly = true;
            // 
            // tblLayoutPanelDomicilioAgregarQuitar
            // 
            this.tblLayoutPanelDomicilioAgregarQuitar.ColumnCount = 1;
            this.tblLayoutPanelDomicilioAgregarQuitar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDomicilioAgregarQuitar.Controls.Add(this.btnAgregarDomicilio, 0, 0);
            this.tblLayoutPanelDomicilioAgregarQuitar.Controls.Add(this.btnQuitarDomicilio, 0, 1);
            this.tblLayoutPanelDomicilioAgregarQuitar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDomicilioAgregarQuitar.Location = new System.Drawing.Point(921, 4);
            this.tblLayoutPanelDomicilioAgregarQuitar.Margin = new System.Windows.Forms.Padding(4);
            this.tblLayoutPanelDomicilioAgregarQuitar.Name = "tblLayoutPanelDomicilioAgregarQuitar";
            this.tblLayoutPanelDomicilioAgregarQuitar.RowCount = 2;
            this.tblLayoutPanelDomicilioAgregarQuitar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDomicilioAgregarQuitar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDomicilioAgregarQuitar.Size = new System.Drawing.Size(36, 115);
            this.tblLayoutPanelDomicilioAgregarQuitar.TabIndex = 2;
            // 
            // btnAgregarDomicilio
            // 
            this.btnAgregarDomicilio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarDomicilio.AutoSize = true;
            this.btnAgregarDomicilio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarDomicilio.Depth = 0;
            this.btnAgregarDomicilio.Location = new System.Drawing.Point(6, 14);
            this.btnAgregarDomicilio.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnAgregarDomicilio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarDomicilio.Name = "btnAgregarDomicilio";
            this.btnAgregarDomicilio.Primary = false;
            this.btnAgregarDomicilio.Size = new System.Drawing.Size(23, 36);
            this.btnAgregarDomicilio.TabIndex = 17;
            this.btnAgregarDomicilio.Text = "+";
            this.btnAgregarDomicilio.UseVisualStyleBackColor = true;
            // 
            // btnQuitarDomicilio
            // 
            this.btnQuitarDomicilio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuitarDomicilio.AutoSize = true;
            this.btnQuitarDomicilio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuitarDomicilio.Depth = 0;
            this.btnQuitarDomicilio.Location = new System.Drawing.Point(8, 64);
            this.btnQuitarDomicilio.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnQuitarDomicilio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitarDomicilio.Name = "btnQuitarDomicilio";
            this.btnQuitarDomicilio.Primary = false;
            this.btnQuitarDomicilio.Size = new System.Drawing.Size(19, 36);
            this.btnQuitarDomicilio.TabIndex = 18;
            this.btnQuitarDomicilio.Text = "-";
            this.btnQuitarDomicilio.UseVisualStyleBackColor = true;
            // 
            // grpBoxContacto
            // 
            this.grpBoxContacto.Controls.Add(this.tblLayoutPanelContacto);
            this.grpBoxContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxContacto.Location = new System.Drawing.Point(4, 500);
            this.grpBoxContacto.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxContacto.Name = "grpBoxContacto";
            this.grpBoxContacto.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxContacto.Size = new System.Drawing.Size(977, 169);
            this.grpBoxContacto.TabIndex = 5;
            this.grpBoxContacto.TabStop = false;
            this.grpBoxContacto.Text = "Contacto";
            // 
            // tblLayoutPanelContacto
            // 
            this.tblLayoutPanelContacto.ColumnCount = 2;
            this.tblLayoutPanelContacto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.57184F));
            this.tblLayoutPanelContacto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.42816F));
            this.tblLayoutPanelContacto.Controls.Add(this.tblLayoutPanelTelefonoLista, 1, 1);
            this.tblLayoutPanelContacto.Controls.Add(this.tblLayoutPanelTelefono, 1, 0);
            this.tblLayoutPanelContacto.Controls.Add(this.tblLayoutPanelMail, 0, 0);
            this.tblLayoutPanelContacto.Controls.Add(this.tblLayoutPanelMailLista, 0, 1);
            this.tblLayoutPanelContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelContacto.Location = new System.Drawing.Point(4, 26);
            this.tblLayoutPanelContacto.Margin = new System.Windows.Forms.Padding(4);
            this.tblLayoutPanelContacto.Name = "tblLayoutPanelContacto";
            this.tblLayoutPanelContacto.RowCount = 2;
            this.tblLayoutPanelContacto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tblLayoutPanelContacto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelContacto.Size = new System.Drawing.Size(969, 139);
            this.tblLayoutPanelContacto.TabIndex = 0;
            // 
            // tblLayoutPanelTelefonoLista
            // 
            this.tblLayoutPanelTelefonoLista.ColumnCount = 2;
            this.tblLayoutPanelTelefonoLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelTelefonoLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tblLayoutPanelTelefonoLista.Controls.Add(this.tblLayoutPanelTelefonoListaAgregarQuitar, 1, 0);
            this.tblLayoutPanelTelefonoLista.Controls.Add(this.dataGridViewTelefono, 0, 0);
            this.tblLayoutPanelTelefonoLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelTelefonoLista.Location = new System.Drawing.Point(532, 66);
            this.tblLayoutPanelTelefonoLista.Margin = new System.Windows.Forms.Padding(4);
            this.tblLayoutPanelTelefonoLista.Name = "tblLayoutPanelTelefonoLista";
            this.tblLayoutPanelTelefonoLista.RowCount = 1;
            this.tblLayoutPanelTelefonoLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelTelefonoLista.Size = new System.Drawing.Size(433, 69);
            this.tblLayoutPanelTelefonoLista.TabIndex = 3;
            // 
            // tblLayoutPanelTelefonoListaAgregarQuitar
            // 
            this.tblLayoutPanelTelefonoListaAgregarQuitar.ColumnCount = 1;
            this.tblLayoutPanelTelefonoListaAgregarQuitar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelTelefonoListaAgregarQuitar.Controls.Add(this.btnQuitarTelefono, 0, 1);
            this.tblLayoutPanelTelefonoListaAgregarQuitar.Controls.Add(this.btnAgregarTelefono, 0, 0);
            this.tblLayoutPanelTelefonoListaAgregarQuitar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelTelefonoListaAgregarQuitar.Location = new System.Drawing.Point(393, 4);
            this.tblLayoutPanelTelefonoListaAgregarQuitar.Margin = new System.Windows.Forms.Padding(4);
            this.tblLayoutPanelTelefonoListaAgregarQuitar.Name = "tblLayoutPanelTelefonoListaAgregarQuitar";
            this.tblLayoutPanelTelefonoListaAgregarQuitar.RowCount = 2;
            this.tblLayoutPanelTelefonoListaAgregarQuitar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelTelefonoListaAgregarQuitar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelTelefonoListaAgregarQuitar.Size = new System.Drawing.Size(36, 61);
            this.tblLayoutPanelTelefonoListaAgregarQuitar.TabIndex = 13;
            // 
            // btnQuitarTelefono
            // 
            this.btnQuitarTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuitarTelefono.AutoSize = true;
            this.btnQuitarTelefono.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuitarTelefono.Depth = 0;
            this.btnQuitarTelefono.Location = new System.Drawing.Point(8, 37);
            this.btnQuitarTelefono.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnQuitarTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitarTelefono.Name = "btnQuitarTelefono";
            this.btnQuitarTelefono.Primary = false;
            this.btnQuitarTelefono.Size = new System.Drawing.Size(19, 17);
            this.btnQuitarTelefono.TabIndex = 25;
            this.btnQuitarTelefono.Text = "-";
            this.btnQuitarTelefono.UseVisualStyleBackColor = true;
            // 
            // btnAgregarTelefono
            // 
            this.btnAgregarTelefono.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarTelefono.AutoSize = true;
            this.btnAgregarTelefono.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarTelefono.Depth = 0;
            this.btnAgregarTelefono.Location = new System.Drawing.Point(6, 7);
            this.btnAgregarTelefono.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnAgregarTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarTelefono.Name = "btnAgregarTelefono";
            this.btnAgregarTelefono.Primary = false;
            this.btnAgregarTelefono.Size = new System.Drawing.Size(23, 16);
            this.btnAgregarTelefono.TabIndex = 26;
            this.btnAgregarTelefono.Text = "+";
            this.btnAgregarTelefono.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTelefono
            // 
            this.dataGridViewTelefono.AllowUserToAddRows = false;
            this.dataGridViewTelefono.AllowUserToDeleteRows = false;
            this.dataGridViewTelefono.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTelefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTelefono.ColumnHeadersVisible = false;
            this.dataGridViewTelefono.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTelefono,
            this.codigoTipo,
            this.tipo,
            this.numeroTelefono});
            this.dataGridViewTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTelefono.GridColor = System.Drawing.Color.White;
            this.dataGridViewTelefono.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTelefono.Name = "dataGridViewTelefono";
            this.dataGridViewTelefono.ReadOnly = true;
            this.dataGridViewTelefono.RowHeadersVisible = false;
            this.dataGridViewTelefono.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTelefono.Size = new System.Drawing.Size(381, 61);
            this.dataGridViewTelefono.TabIndex = 3;
            this.dataGridViewTelefono.TabStop = false;
            // 
            // codigoTelefono
            // 
            this.codigoTelefono.HeaderText = "codigoTelefono";
            this.codigoTelefono.Name = "codigoTelefono";
            this.codigoTelefono.ReadOnly = true;
            this.codigoTelefono.Visible = false;
            // 
            // codigoTipo
            // 
            this.codigoTipo.HeaderText = "codigoTipo";
            this.codigoTipo.Name = "codigoTipo";
            this.codigoTipo.ReadOnly = true;
            this.codigoTipo.Visible = false;
            // 
            // tipo
            // 
            this.tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 5;
            // 
            // numeroTelefono
            // 
            this.numeroTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numeroTelefono.HeaderText = "Número";
            this.numeroTelefono.Name = "numeroTelefono";
            this.numeroTelefono.ReadOnly = true;
            // 
            // tblLayoutPanelTelefono
            // 
            this.tblLayoutPanelTelefono.ColumnCount = 3;
            this.tblLayoutPanelTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblLayoutPanelTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tblLayoutPanelTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelTelefono.Controls.Add(this.lblTelefono, 1, 0);
            this.tblLayoutPanelTelefono.Controls.Add(this.cmbBoxTipoTelefono, 0, 0);
            this.tblLayoutPanelTelefono.Controls.Add(this.txtBoxTelefono, 2, 0);
            this.tblLayoutPanelTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelTelefono.Location = new System.Drawing.Point(532, 4);
            this.tblLayoutPanelTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.tblLayoutPanelTelefono.Name = "tblLayoutPanelTelefono";
            this.tblLayoutPanelTelefono.RowCount = 1;
            this.tblLayoutPanelTelefono.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelTelefono.Size = new System.Drawing.Size(433, 54);
            this.tblLayoutPanelTelefono.TabIndex = 2;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(84, 17);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(83, 20);
            this.lblTelefono.TabIndex = 9;
            this.lblTelefono.Text = "Número:";
            // 
            // cmbBoxTipoTelefono
            // 
            this.cmbBoxTipoTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxTipoTelefono.FormattingEnabled = true;
            this.cmbBoxTipoTelefono.Items.AddRange(new object[] {
            "TEL",
            "CEL",
            "FAX"});
            this.cmbBoxTipoTelefono.Location = new System.Drawing.Point(4, 11);
            this.cmbBoxTipoTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxTipoTelefono.Name = "cmbBoxTipoTelefono";
            this.cmbBoxTipoTelefono.Size = new System.Drawing.Size(72, 32);
            this.cmbBoxTipoTelefono.TabIndex = 23;
            // 
            // txtBoxTelefono
            // 
            this.txtBoxTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxTelefono.Depth = 0;
            this.txtBoxTelefono.Hint = "";
            this.txtBoxTelefono.Location = new System.Drawing.Point(175, 13);
            this.txtBoxTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxTelefono.Name = "txtBoxTelefono";
            this.txtBoxTelefono.PasswordChar = '\0';
            this.txtBoxTelefono.SelectedText = "";
            this.txtBoxTelefono.SelectionLength = 0;
            this.txtBoxTelefono.SelectionStart = 0;
            this.txtBoxTelefono.Size = new System.Drawing.Size(254, 28);
            this.txtBoxTelefono.TabIndex = 24;
            this.txtBoxTelefono.UseSystemPasswordChar = false;
            this.txtBoxTelefono.Leave += new System.EventHandler(this.txtBoxTelefono_Leave);
            // 
            // tblLayoutPanelMail
            // 
            this.tblLayoutPanelMail.ColumnCount = 2;
            this.tblLayoutPanelMail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tblLayoutPanelMail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelMail.Controls.Add(this.lblMail, 0, 0);
            this.tblLayoutPanelMail.Controls.Add(this.txtBoxMail, 1, 0);
            this.tblLayoutPanelMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelMail.Location = new System.Drawing.Point(4, 4);
            this.tblLayoutPanelMail.Margin = new System.Windows.Forms.Padding(4);
            this.tblLayoutPanelMail.Name = "tblLayoutPanelMail";
            this.tblLayoutPanelMail.RowCount = 1;
            this.tblLayoutPanelMail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelMail.Size = new System.Drawing.Size(520, 54);
            this.tblLayoutPanelMail.TabIndex = 0;
            // 
            // lblMail
            // 
            this.lblMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(4, 7);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(109, 40);
            this.lblMail.TabIndex = 9;
            this.lblMail.Text = "Correo Electrónico:";
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxMail.Depth = 0;
            this.txtBoxMail.Hint = "";
            this.txtBoxMail.Location = new System.Drawing.Point(121, 13);
            this.txtBoxMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.PasswordChar = '\0';
            this.txtBoxMail.SelectedText = "";
            this.txtBoxMail.SelectionLength = 0;
            this.txtBoxMail.SelectionStart = 0;
            this.txtBoxMail.Size = new System.Drawing.Size(395, 28);
            this.txtBoxMail.TabIndex = 10;
            this.txtBoxMail.UseSystemPasswordChar = false;
            this.txtBoxMail.Leave += new System.EventHandler(this.txtBoxMail_Leave);
            // 
            // tblLayoutPanelMailLista
            // 
            this.tblLayoutPanelMailLista.ColumnCount = 2;
            this.tblLayoutPanelMailLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelMailLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tblLayoutPanelMailLista.Controls.Add(this.tblLayoutPanelMailListaAgregarQuitar, 1, 0);
            this.tblLayoutPanelMailLista.Controls.Add(this.dataGridViewMail, 0, 0);
            this.tblLayoutPanelMailLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelMailLista.Location = new System.Drawing.Point(4, 66);
            this.tblLayoutPanelMailLista.Margin = new System.Windows.Forms.Padding(4);
            this.tblLayoutPanelMailLista.Name = "tblLayoutPanelMailLista";
            this.tblLayoutPanelMailLista.RowCount = 1;
            this.tblLayoutPanelMailLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelMailLista.Size = new System.Drawing.Size(520, 69);
            this.tblLayoutPanelMailLista.TabIndex = 1;
            // 
            // tblLayoutPanelMailListaAgregarQuitar
            // 
            this.tblLayoutPanelMailListaAgregarQuitar.ColumnCount = 1;
            this.tblLayoutPanelMailListaAgregarQuitar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelMailListaAgregarQuitar.Controls.Add(this.btnAgregarMail, 0, 0);
            this.tblLayoutPanelMailListaAgregarQuitar.Controls.Add(this.btnQuitarMail, 0, 1);
            this.tblLayoutPanelMailListaAgregarQuitar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelMailListaAgregarQuitar.Location = new System.Drawing.Point(480, 4);
            this.tblLayoutPanelMailListaAgregarQuitar.Margin = new System.Windows.Forms.Padding(4);
            this.tblLayoutPanelMailListaAgregarQuitar.Name = "tblLayoutPanelMailListaAgregarQuitar";
            this.tblLayoutPanelMailListaAgregarQuitar.RowCount = 2;
            this.tblLayoutPanelMailListaAgregarQuitar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelMailListaAgregarQuitar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelMailListaAgregarQuitar.Size = new System.Drawing.Size(36, 61);
            this.tblLayoutPanelMailListaAgregarQuitar.TabIndex = 13;
            // 
            // btnAgregarMail
            // 
            this.btnAgregarMail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarMail.AutoSize = true;
            this.btnAgregarMail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarMail.Depth = 0;
            this.btnAgregarMail.Location = new System.Drawing.Point(6, 7);
            this.btnAgregarMail.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnAgregarMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarMail.Name = "btnAgregarMail";
            this.btnAgregarMail.Primary = false;
            this.btnAgregarMail.Size = new System.Drawing.Size(23, 16);
            this.btnAgregarMail.TabIndex = 1;
            this.btnAgregarMail.Text = "+";
            this.btnAgregarMail.UseVisualStyleBackColor = true;
            // 
            // btnQuitarMail
            // 
            this.btnQuitarMail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuitarMail.AutoSize = true;
            this.btnQuitarMail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuitarMail.Depth = 0;
            this.btnQuitarMail.Location = new System.Drawing.Point(8, 37);
            this.btnQuitarMail.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnQuitarMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitarMail.Name = "btnQuitarMail";
            this.btnQuitarMail.Primary = false;
            this.btnQuitarMail.Size = new System.Drawing.Size(19, 17);
            this.btnQuitarMail.TabIndex = 2;
            this.btnQuitarMail.Text = "-";
            this.btnQuitarMail.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMail
            // 
            this.dataGridViewMail.AllowUserToAddRows = false;
            this.dataGridViewMail.AllowUserToDeleteRows = false;
            this.dataGridViewMail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMail.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMail.ColumnHeadersVisible = false;
            this.dataGridViewMail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoMail,
            this.mail});
            this.dataGridViewMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMail.GridColor = System.Drawing.Color.White;
            this.dataGridViewMail.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewMail.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMail.Name = "dataGridViewMail";
            this.dataGridViewMail.ReadOnly = true;
            this.dataGridViewMail.RowHeadersVisible = false;
            this.dataGridViewMail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMail.Size = new System.Drawing.Size(468, 61);
            this.dataGridViewMail.TabIndex = 14;
            this.dataGridViewMail.TabStop = false;
            // 
            // codigoMail
            // 
            this.codigoMail.HeaderText = "codigoMail";
            this.codigoMail.Name = "codigoMail";
            this.codigoMail.ReadOnly = true;
            this.codigoMail.Visible = false;
            // 
            // mail
            // 
            this.mail.HeaderText = "mail";
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            // 
            // btnDatosAdicionales
            // 
            this.btnDatosAdicionales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDatosAdicionales.AutoSize = true;
            this.btnDatosAdicionales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDatosAdicionales.Depth = 0;
            this.btnDatosAdicionales.Location = new System.Drawing.Point(402, 781);
            this.btnDatosAdicionales.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnDatosAdicionales.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDatosAdicionales.Name = "btnDatosAdicionales";
            this.btnDatosAdicionales.Primary = false;
            this.btnDatosAdicionales.Size = new System.Drawing.Size(181, 36);
            this.btnDatosAdicionales.TabIndex = 7;
            this.btnDatosAdicionales.Text = "Datos adicionales";
            this.btnDatosAdicionales.UseVisualStyleBackColor = true;
            this.btnDatosAdicionales.Click += new System.EventHandler(this.btnDatosAdicionales_Click);
            // 
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.tblLayoutPanelPrincipal);
            this.pnlBase.Location = new System.Drawing.Point(37, 68);
            this.pnlBase.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(1077, 820);
            this.pnlBase.TabIndex = 5;
            // 
            // epCodigoEntidad
            // 
            this.epCodigoEntidad.ContainerControl = this;
            // 
            // epCUIT
            // 
            this.epCUIT.ContainerControl = this;
            // 
            // epDNI
            // 
            this.epDNI.ContainerControl = this;
            // 
            // epNombre
            // 
            this.epNombre.ContainerControl = this;
            // 
            // epApellido
            // 
            this.epApellido.ContainerControl = this;
            // 
            // epRazonSocial
            // 
            this.epRazonSocial.ContainerControl = this;
            // 
            // epCalle
            // 
            this.epCalle.ContainerControl = this;
            // 
            // epNumeroDomicilio
            // 
            this.epNumeroDomicilio.ContainerControl = this;
            // 
            // epPiso
            // 
            this.epPiso.ContainerControl = this;
            // 
            // epDepartamento
            // 
            this.epDepartamento.ContainerControl = this;
            // 
            // epCodigoPostal
            // 
            this.epCodigoPostal.ContainerControl = this;
            // 
            // epCiudad
            // 
            this.epCiudad.ContainerControl = this;
            // 
            // epMail
            // 
            this.epMail.ContainerControl = this;
            // 
            // epNumeroTelefono
            // 
            this.epNumeroTelefono.ContainerControl = this;
            // 
            // frmABMEntidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1296, 780);
            this.Controls.Add(this.pnlBase);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmABMEntidad";
            this.Text = "ABM Entidades";
            this.Controls.SetChildIndex(this.pnlBase, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderActual)).EndInit();
            this.tblLayoutPanelPrincipal.ResumeLayout(false);
            this.tblLayoutPanelPrincipal.PerformLayout();
            this.grpBoxTipoEntidad.ResumeLayout(false);
            this.tblLayoutPanelTipoEntidad.ResumeLayout(false);
            this.tblLayoutPanelTipoEntidad.PerformLayout();
            this.grpBoxObservaciones.ResumeLayout(false);
            this.grpBoxDatosPersonales.ResumeLayout(false);
            this.tblLayoutPanelDatosPersonales.ResumeLayout(false);
            this.tblLayoutPanelDatosPersonales.PerformLayout();
            this.tblLayoutPanelDatosEntidad.ResumeLayout(false);
            this.tblLayoutPanelDatosEntidad.PerformLayout();
            this.grpBoxDomicilio.ResumeLayout(false);
            this.tblLayoutPanelDomicilioDatos.ResumeLayout(false);
            this.tblLayoutPanelDomicilio.ResumeLayout(false);
            this.tblLayourPanelDomicilio_1.ResumeLayout(false);
            this.tblLayourPanelDomicilio_1.PerformLayout();
            this.tblLayoutPanelDomicilio_2.ResumeLayout(false);
            this.tblLayoutPanelDomicilio_2.PerformLayout();
            this.tblLayoutPanelDomicilioGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDomicilio)).EndInit();
            this.tblLayoutPanelDomicilioAgregarQuitar.ResumeLayout(false);
            this.tblLayoutPanelDomicilioAgregarQuitar.PerformLayout();
            this.grpBoxContacto.ResumeLayout(false);
            this.tblLayoutPanelContacto.ResumeLayout(false);
            this.tblLayoutPanelTelefonoLista.ResumeLayout(false);
            this.tblLayoutPanelTelefonoListaAgregarQuitar.ResumeLayout(false);
            this.tblLayoutPanelTelefonoListaAgregarQuitar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelefono)).EndInit();
            this.tblLayoutPanelTelefono.ResumeLayout(false);
            this.tblLayoutPanelTelefono.PerformLayout();
            this.tblLayoutPanelMail.ResumeLayout(false);
            this.tblLayoutPanelMail.PerformLayout();
            this.tblLayoutPanelMailLista.ResumeLayout(false);
            this.tblLayoutPanelMailListaAgregarQuitar.ResumeLayout(false);
            this.tblLayoutPanelMailListaAgregarQuitar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMail)).EndInit();
            this.pnlBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epCodigoEntidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCUIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRazonSocial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNumeroDomicilio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigoPostal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNumeroTelefono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelPrincipal;
        private System.Windows.Forms.GroupBox grpBoxTipoEntidad;
        private System.Windows.Forms.GroupBox grpBoxObservaciones;
        private System.Windows.Forms.RichTextBox rchTextBoxObservaciones;
        private System.Windows.Forms.GroupBox grpBoxDatosPersonales;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDatosPersonales;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.GroupBox grpBoxDomicilio;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDomicilioDatos;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.ComboBox cmbBoxProvincia;
        private System.Windows.Forms.DataGridView dataGridViewDomicilio;
        private System.Windows.Forms.GroupBox grpBoxContacto;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelContacto;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelTelefonoLista;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.ComboBox cmbBoxTipoTelefono;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelMailLista;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDomicilioGrid;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDomicilioAgregarQuitar;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelMailListaAgregarQuitar;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelTelefonoListaAgregarQuitar;
        private System.Windows.Forms.ComboBox cmbBoxPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.DataGridView dataGridViewTelefono;
        private System.Windows.Forms.DataGridView dataGridViewMail;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelTipoEntidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonCliente;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonProveedor;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonContactoProveedor;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCodigoEntidad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCUIT;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxDNI;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxRazonSocial;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxApellido;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCalle;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCiudad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxNumeroDomicilio;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCodigoPostal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxPiso;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxDepartamento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxMail;
        private MaterialSkin.Controls.MaterialFlatButton btnDatosAdicionales;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregarDomicilio;
        private MaterialSkin.Controls.MaterialFlatButton btnQuitarDomicilio;
        private MaterialSkin.Controls.MaterialFlatButton btnQuitarTelefono;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregarTelefono;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregarMail;
        private MaterialSkin.Controls.MaterialFlatButton btnQuitarMail;
        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.CheckBox chbxActivo;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDatosEntidad;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDomicilio;
        private System.Windows.Forms.TableLayoutPanel tblLayourPanelDomicilio_1;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDomicilio_2;
        private System.Windows.Forms.ErrorProvider epCodigoEntidad;
        private System.Windows.Forms.ErrorProvider epCUIT;
        private System.Windows.Forms.ErrorProvider epDNI;
        private System.Windows.Forms.ErrorProvider epNombre;
        private System.Windows.Forms.ErrorProvider epApellido;
        private System.Windows.Forms.ErrorProvider epRazonSocial;
        private System.Windows.Forms.ErrorProvider epCalle;
        private System.Windows.Forms.ErrorProvider epNumeroDomicilio;
        private System.Windows.Forms.ErrorProvider epPiso;
        private System.Windows.Forms.ErrorProvider epDepartamento;
        private System.Windows.Forms.ErrorProvider epCodigoPostal;
        private System.Windows.Forms.ErrorProvider epCiudad;
        private System.Windows.Forms.ErrorProvider epMail;
        private System.Windows.Forms.ErrorProvider epNumeroTelefono;
    }
}