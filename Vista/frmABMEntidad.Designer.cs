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
            this.tblLayoutPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxTipoEntidad = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelTipoEntidad = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonCliente = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonProveedor = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonContactoProveedor = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonUsuario = new MaterialSkin.Controls.MaterialRadioButton();
            this.grpBoxObservaciones = new System.Windows.Forms.GroupBox();
            this.pnlObservaciones = new System.Windows.Forms.Panel();
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
            this.grpBoxDomicilio = new System.Windows.Forms.GroupBox();
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
            this.epMail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNumeroTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderActual)).BeginInit();
            this.tblLayoutPanelPrincipal.SuspendLayout();
            this.grpBoxTipoEntidad.SuspendLayout();
            this.tblLayoutPanelTipoEntidad.SuspendLayout();
            this.grpBoxObservaciones.SuspendLayout();
            this.pnlObservaciones.SuspendLayout();
            this.grpBoxDatosPersonales.SuspendLayout();
            this.tblLayoutPanelDatosPersonales.SuspendLayout();
            this.tblLayoutPanelDatosEntidad.SuspendLayout();
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
            this.tblLayoutPanelPrincipal.Name = "tblLayoutPanelPrincipal";
            this.tblLayoutPanelPrincipal.RowCount = 6;
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.71717F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.70707F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.62014F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLayoutPanelPrincipal.Size = new System.Drawing.Size(739, 670);
            this.tblLayoutPanelPrincipal.TabIndex = 4;
            // 
            // grpBoxTipoEntidad
            // 
            this.grpBoxTipoEntidad.Controls.Add(this.tblLayoutPanelTipoEntidad);
            this.grpBoxTipoEntidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxTipoEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxTipoEntidad.Location = new System.Drawing.Point(3, 3);
            this.grpBoxTipoEntidad.Name = "grpBoxTipoEntidad";
            this.grpBoxTipoEntidad.Size = new System.Drawing.Size(733, 52);
            this.grpBoxTipoEntidad.TabIndex = 4;
            this.grpBoxTipoEntidad.TabStop = false;
            this.grpBoxTipoEntidad.Text = "Tipo Entidad";
            // 
            // tblLayoutPanelTipoEntidad
            // 
            this.tblLayoutPanelTipoEntidad.ColumnCount = 6;
            this.tblLayoutPanelTipoEntidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelTipoEntidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tblLayoutPanelTipoEntidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLayoutPanelTipoEntidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tblLayoutPanelTipoEntidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tblLayoutPanelTipoEntidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelTipoEntidad.Controls.Add(this.radioButtonCliente, 1, 0);
            this.tblLayoutPanelTipoEntidad.Controls.Add(this.radioButtonProveedor, 2, 0);
            this.tblLayoutPanelTipoEntidad.Controls.Add(this.radioButtonContactoProveedor, 3, 0);
            this.tblLayoutPanelTipoEntidad.Controls.Add(this.radioButtonUsuario, 4, 0);
            this.tblLayoutPanelTipoEntidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelTipoEntidad.Location = new System.Drawing.Point(3, 20);
            this.tblLayoutPanelTipoEntidad.Name = "tblLayoutPanelTipoEntidad";
            this.tblLayoutPanelTipoEntidad.RowCount = 1;
            this.tblLayoutPanelTipoEntidad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelTipoEntidad.Size = new System.Drawing.Size(727, 29);
            this.tblLayoutPanelTipoEntidad.TabIndex = 5;
            // 
            // radioButtonCliente
            // 
            this.radioButtonCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonCliente.AutoSize = true;
            this.radioButtonCliente.Depth = 0;
            this.radioButtonCliente.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonCliente.Location = new System.Drawing.Point(127, 0);
            this.radioButtonCliente.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonCliente.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonCliente.Name = "radioButtonCliente";
            this.radioButtonCliente.Ripple = true;
            this.radioButtonCliente.Size = new System.Drawing.Size(90, 29);
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
            this.radioButtonProveedor.Location = new System.Drawing.Point(217, 0);
            this.radioButtonProveedor.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonProveedor.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonProveedor.Name = "radioButtonProveedor";
            this.radioButtonProveedor.Ripple = true;
            this.radioButtonProveedor.Size = new System.Drawing.Size(120, 29);
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
            this.radioButtonContactoProveedor.Location = new System.Drawing.Point(337, 0);
            this.radioButtonContactoProveedor.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonContactoProveedor.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonContactoProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonContactoProveedor.Name = "radioButtonContactoProveedor";
            this.radioButtonContactoProveedor.Ripple = true;
            this.radioButtonContactoProveedor.Size = new System.Drawing.Size(172, 29);
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
            this.radioButtonUsuario.Location = new System.Drawing.Point(509, 0);
            this.radioButtonUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonUsuario.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonUsuario.Name = "radioButtonUsuario";
            this.radioButtonUsuario.Ripple = true;
            this.radioButtonUsuario.Size = new System.Drawing.Size(90, 29);
            this.radioButtonUsuario.TabIndex = 8;
            this.radioButtonUsuario.TabStop = true;
            this.radioButtonUsuario.Text = "Usuario";
            this.radioButtonUsuario.UseVisualStyleBackColor = true;
            this.radioButtonUsuario.CheckedChanged += new System.EventHandler(this.radioButtonUsuario_CheckedChanged);
            // 
            // grpBoxObservaciones
            // 
            this.grpBoxObservaciones.Controls.Add(this.pnlObservaciones);
            this.grpBoxObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxObservaciones.Location = new System.Drawing.Point(3, 549);
            this.grpBoxObservaciones.Name = "grpBoxObservaciones";
            this.grpBoxObservaciones.Size = new System.Drawing.Size(733, 76);
            this.grpBoxObservaciones.TabIndex = 6;
            this.grpBoxObservaciones.TabStop = false;
            this.grpBoxObservaciones.Text = "Observaciones";
            // 
            // pnlObservaciones
            // 
            this.pnlObservaciones.Controls.Add(this.rchTextBoxObservaciones);
            this.pnlObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlObservaciones.Location = new System.Drawing.Point(3, 20);
            this.pnlObservaciones.Margin = new System.Windows.Forms.Padding(20);
            this.pnlObservaciones.Name = "pnlObservaciones";
            this.pnlObservaciones.Padding = new System.Windows.Forms.Padding(10);
            this.pnlObservaciones.Size = new System.Drawing.Size(727, 53);
            this.pnlObservaciones.TabIndex = 26;
            // 
            // rchTextBoxObservaciones
            // 
            this.rchTextBoxObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchTextBoxObservaciones.Location = new System.Drawing.Point(10, 10);
            this.rchTextBoxObservaciones.Margin = new System.Windows.Forms.Padding(0);
            this.rchTextBoxObservaciones.Name = "rchTextBoxObservaciones";
            this.rchTextBoxObservaciones.Size = new System.Drawing.Size(707, 33);
            this.rchTextBoxObservaciones.TabIndex = 25;
            this.rchTextBoxObservaciones.Text = "";
            // 
            // grpBoxDatosPersonales
            // 
            this.grpBoxDatosPersonales.Controls.Add(this.tblLayoutPanelDatosPersonales);
            this.grpBoxDatosPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDatosPersonales.Location = new System.Drawing.Point(3, 61);
            this.grpBoxDatosPersonales.Name = "grpBoxDatosPersonales";
            this.grpBoxDatosPersonales.Size = new System.Drawing.Size(733, 96);
            this.grpBoxDatosPersonales.TabIndex = 3;
            this.grpBoxDatosPersonales.TabStop = false;
            this.grpBoxDatosPersonales.Text = "Datos Personales";
            // 
            // tblLayoutPanelDatosPersonales
            // 
            this.tblLayoutPanelDatosPersonales.ColumnCount = 1;
            this.tblLayoutPanelDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.tblLayoutPanelDatosEntidad, 0, 0);
            this.tblLayoutPanelDatosPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDatosPersonales.Location = new System.Drawing.Point(3, 20);
            this.tblLayoutPanelDatosPersonales.Name = "tblLayoutPanelDatosPersonales";
            this.tblLayoutPanelDatosPersonales.RowCount = 1;
            this.tblLayoutPanelDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDatosPersonales.Size = new System.Drawing.Size(727, 73);
            this.tblLayoutPanelDatosPersonales.TabIndex = 0;
            // 
            // tblLayoutPanelDatosEntidad
            // 
            this.tblLayoutPanelDatosEntidad.ColumnCount = 6;
            this.tblLayoutPanelDatosEntidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tblLayoutPanelDatosEntidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblLayoutPanelDatosEntidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tblLayoutPanelDatosEntidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelDatosEntidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
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
            this.tblLayoutPanelDatosEntidad.Location = new System.Drawing.Point(2, 2);
            this.tblLayoutPanelDatosEntidad.Margin = new System.Windows.Forms.Padding(2);
            this.tblLayoutPanelDatosEntidad.Name = "tblLayoutPanelDatosEntidad";
            this.tblLayoutPanelDatosEntidad.RowCount = 2;
            this.tblLayoutPanelDatosEntidad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDatosEntidad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDatosEntidad.Size = new System.Drawing.Size(723, 69);
            this.tblLayoutPanelDatosEntidad.TabIndex = 6;
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxApellido.Depth = 0;
            this.txtBoxApellido.Hint = "";
            this.txtBoxApellido.Location = new System.Drawing.Point(299, 40);
            this.txtBoxApellido.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtBoxApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.PasswordChar = '\0';
            this.txtBoxApellido.SelectedText = "";
            this.txtBoxApellido.SelectionLength = 0;
            this.txtBoxApellido.SelectionStart = 0;
            this.txtBoxApellido.Size = new System.Drawing.Size(142, 23);
            this.txtBoxApellido.TabIndex = 17;
            this.txtBoxApellido.UseSystemPasswordChar = false;
            this.txtBoxApellido.Leave += new System.EventHandler(this.txtBoxApellido_Leave);
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(231, 43);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 17);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(3, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(463, 43);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(95, 17);
            this.lblRazonSocial.TabIndex = 10;
            this.lblRazonSocial.Text = "Razón Social:";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNombre.Depth = 0;
            this.txtBoxNombre.Hint = "";
            this.txtBoxNombre.Location = new System.Drawing.Point(71, 40);
            this.txtBoxNombre.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtBoxNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.PasswordChar = '\0';
            this.txtBoxNombre.SelectedText = "";
            this.txtBoxNombre.SelectionLength = 0;
            this.txtBoxNombre.SelectionStart = 0;
            this.txtBoxNombre.Size = new System.Drawing.Size(142, 23);
            this.txtBoxNombre.TabIndex = 18;
            this.txtBoxNombre.UseSystemPasswordChar = false;
            this.txtBoxNombre.Leave += new System.EventHandler(this.txtBoxNombre_Leave);
            // 
            // lblDNI
            // 
            this.lblDNI.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(523, 8);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(35, 17);
            this.lblDNI.TabIndex = 12;
            this.lblDNI.Text = "DNI:";
            // 
            // txtBoxRazonSocial
            // 
            this.txtBoxRazonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxRazonSocial.Depth = 0;
            this.txtBoxRazonSocial.Hint = "";
            this.txtBoxRazonSocial.Location = new System.Drawing.Point(564, 40);
            this.txtBoxRazonSocial.Margin = new System.Windows.Forms.Padding(3, 3, 26, 3);
            this.txtBoxRazonSocial.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxRazonSocial.Name = "txtBoxRazonSocial";
            this.txtBoxRazonSocial.PasswordChar = '\0';
            this.txtBoxRazonSocial.SelectedText = "";
            this.txtBoxRazonSocial.SelectionLength = 0;
            this.txtBoxRazonSocial.SelectionStart = 0;
            this.txtBoxRazonSocial.Size = new System.Drawing.Size(133, 23);
            this.txtBoxRazonSocial.TabIndex = 16;
            this.txtBoxRazonSocial.UseSystemPasswordChar = false;
            this.txtBoxRazonSocial.Leave += new System.EventHandler(this.txtBoxRazonSocial_Leave);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(9, 8);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblCUIT
            // 
            this.lblCUIT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUIT.Location = new System.Drawing.Point(250, 8);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(43, 17);
            this.lblCUIT.TabIndex = 4;
            this.lblCUIT.Text = "CUIT:";
            // 
            // txtBoxDNI
            // 
            this.txtBoxDNI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDNI.Depth = 0;
            this.txtBoxDNI.Hint = "";
            this.txtBoxDNI.Location = new System.Drawing.Point(564, 5);
            this.txtBoxDNI.Margin = new System.Windows.Forms.Padding(3, 3, 26, 3);
            this.txtBoxDNI.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDNI.Name = "txtBoxDNI";
            this.txtBoxDNI.PasswordChar = '\0';
            this.txtBoxDNI.SelectedText = "";
            this.txtBoxDNI.SelectionLength = 0;
            this.txtBoxDNI.SelectionStart = 0;
            this.txtBoxDNI.Size = new System.Drawing.Size(133, 23);
            this.txtBoxDNI.TabIndex = 15;
            this.txtBoxDNI.UseSystemPasswordChar = false;
            this.txtBoxDNI.Leave += new System.EventHandler(this.txtBoxDNI_Leave);
            // 
            // txtBoxCodigoEntidad
            // 
            this.txtBoxCodigoEntidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoEntidad.Depth = 0;
            this.txtBoxCodigoEntidad.Hint = "";
            this.txtBoxCodigoEntidad.Location = new System.Drawing.Point(71, 5);
            this.txtBoxCodigoEntidad.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtBoxCodigoEntidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCodigoEntidad.Name = "txtBoxCodigoEntidad";
            this.txtBoxCodigoEntidad.PasswordChar = '\0';
            this.txtBoxCodigoEntidad.SelectedText = "";
            this.txtBoxCodigoEntidad.SelectionLength = 0;
            this.txtBoxCodigoEntidad.SelectionStart = 0;
            this.txtBoxCodigoEntidad.Size = new System.Drawing.Size(142, 23);
            this.txtBoxCodigoEntidad.TabIndex = 13;
            this.txtBoxCodigoEntidad.UseSystemPasswordChar = false;
            this.txtBoxCodigoEntidad.Leave += new System.EventHandler(this.txtBoxCodigoEntidad_Leave);
            // 
            // txtBoxCUIT
            // 
            this.txtBoxCUIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCUIT.Depth = 0;
            this.txtBoxCUIT.Hint = "";
            this.txtBoxCUIT.Location = new System.Drawing.Point(299, 5);
            this.txtBoxCUIT.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtBoxCUIT.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCUIT.Name = "txtBoxCUIT";
            this.txtBoxCUIT.PasswordChar = '\0';
            this.txtBoxCUIT.SelectedText = "";
            this.txtBoxCUIT.SelectionLength = 0;
            this.txtBoxCUIT.SelectionStart = 0;
            this.txtBoxCUIT.Size = new System.Drawing.Size(142, 23);
            this.txtBoxCUIT.TabIndex = 14;
            this.txtBoxCUIT.UseSystemPasswordChar = false;
            this.txtBoxCUIT.Leave += new System.EventHandler(this.txtBoxCUIT_Leave);
            // 
            // grpBoxDomicilio
            // 
            this.grpBoxDomicilio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDomicilio.Location = new System.Drawing.Point(3, 163);
            this.grpBoxDomicilio.Name = "grpBoxDomicilio";
            this.grpBoxDomicilio.Size = new System.Drawing.Size(733, 236);
            this.grpBoxDomicilio.TabIndex = 4;
            this.grpBoxDomicilio.TabStop = false;
            this.grpBoxDomicilio.Text = "Domicilio";
            // 
            // grpBoxContacto
            // 
            this.grpBoxContacto.Controls.Add(this.tblLayoutPanelContacto);
            this.grpBoxContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxContacto.Location = new System.Drawing.Point(3, 405);
            this.grpBoxContacto.Name = "grpBoxContacto";
            this.grpBoxContacto.Size = new System.Drawing.Size(733, 138);
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
            this.tblLayoutPanelContacto.Location = new System.Drawing.Point(3, 20);
            this.tblLayoutPanelContacto.Name = "tblLayoutPanelContacto";
            this.tblLayoutPanelContacto.RowCount = 2;
            this.tblLayoutPanelContacto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblLayoutPanelContacto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelContacto.Size = new System.Drawing.Size(727, 115);
            this.tblLayoutPanelContacto.TabIndex = 0;
            // 
            // tblLayoutPanelTelefonoLista
            // 
            this.tblLayoutPanelTelefonoLista.ColumnCount = 2;
            this.tblLayoutPanelTelefonoLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelTelefonoLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tblLayoutPanelTelefonoLista.Controls.Add(this.tblLayoutPanelTelefonoListaAgregarQuitar, 1, 0);
            this.tblLayoutPanelTelefonoLista.Controls.Add(this.dataGridViewTelefono, 0, 0);
            this.tblLayoutPanelTelefonoLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelTelefonoLista.Location = new System.Drawing.Point(399, 53);
            this.tblLayoutPanelTelefonoLista.Name = "tblLayoutPanelTelefonoLista";
            this.tblLayoutPanelTelefonoLista.RowCount = 1;
            this.tblLayoutPanelTelefonoLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelTelefonoLista.Size = new System.Drawing.Size(325, 59);
            this.tblLayoutPanelTelefonoLista.TabIndex = 3;
            // 
            // tblLayoutPanelTelefonoListaAgregarQuitar
            // 
            this.tblLayoutPanelTelefonoListaAgregarQuitar.ColumnCount = 1;
            this.tblLayoutPanelTelefonoListaAgregarQuitar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelTelefonoListaAgregarQuitar.Controls.Add(this.btnQuitarTelefono, 0, 1);
            this.tblLayoutPanelTelefonoListaAgregarQuitar.Controls.Add(this.btnAgregarTelefono, 0, 0);
            this.tblLayoutPanelTelefonoListaAgregarQuitar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelTelefonoListaAgregarQuitar.Location = new System.Drawing.Point(295, 3);
            this.tblLayoutPanelTelefonoListaAgregarQuitar.Name = "tblLayoutPanelTelefonoListaAgregarQuitar";
            this.tblLayoutPanelTelefonoListaAgregarQuitar.RowCount = 2;
            this.tblLayoutPanelTelefonoListaAgregarQuitar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelTelefonoListaAgregarQuitar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelTelefonoListaAgregarQuitar.Size = new System.Drawing.Size(27, 53);
            this.tblLayoutPanelTelefonoListaAgregarQuitar.TabIndex = 13;
            // 
            // btnQuitarTelefono
            // 
            this.btnQuitarTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuitarTelefono.AutoSize = true;
            this.btnQuitarTelefono.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuitarTelefono.Depth = 0;
            this.btnQuitarTelefono.Location = new System.Drawing.Point(5, 32);
            this.btnQuitarTelefono.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuitarTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitarTelefono.Name = "btnQuitarTelefono";
            this.btnQuitarTelefono.Primary = false;
            this.btnQuitarTelefono.Size = new System.Drawing.Size(16, 15);
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
            this.btnAgregarTelefono.Location = new System.Drawing.Point(4, 6);
            this.btnAgregarTelefono.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarTelefono.Name = "btnAgregarTelefono";
            this.btnAgregarTelefono.Primary = false;
            this.btnAgregarTelefono.Size = new System.Drawing.Size(19, 14);
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
            this.dataGridViewTelefono.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTelefono.Name = "dataGridViewTelefono";
            this.dataGridViewTelefono.ReadOnly = true;
            this.dataGridViewTelefono.RowHeadersVisible = false;
            this.dataGridViewTelefono.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTelefono.Size = new System.Drawing.Size(286, 53);
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
            this.tblLayoutPanelTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblLayoutPanelTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tblLayoutPanelTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelTelefono.Controls.Add(this.lblTelefono, 1, 0);
            this.tblLayoutPanelTelefono.Controls.Add(this.cmbBoxTipoTelefono, 0, 0);
            this.tblLayoutPanelTelefono.Controls.Add(this.txtBoxTelefono, 2, 0);
            this.tblLayoutPanelTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelTelefono.Location = new System.Drawing.Point(399, 3);
            this.tblLayoutPanelTelefono.Name = "tblLayoutPanelTelefono";
            this.tblLayoutPanelTelefono.RowCount = 1;
            this.tblLayoutPanelTelefono.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelTelefono.Size = new System.Drawing.Size(325, 44);
            this.tblLayoutPanelTelefono.TabIndex = 2;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(63, 13);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(62, 17);
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
            this.cmbBoxTipoTelefono.Location = new System.Drawing.Point(3, 9);
            this.cmbBoxTipoTelefono.Name = "cmbBoxTipoTelefono";
            this.cmbBoxTipoTelefono.Size = new System.Drawing.Size(54, 26);
            this.cmbBoxTipoTelefono.TabIndex = 23;
            // 
            // txtBoxTelefono
            // 
            this.txtBoxTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxTelefono.Depth = 0;
            this.txtBoxTelefono.Hint = "";
            this.txtBoxTelefono.Location = new System.Drawing.Point(131, 10);
            this.txtBoxTelefono.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.txtBoxTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxTelefono.Name = "txtBoxTelefono";
            this.txtBoxTelefono.PasswordChar = '\0';
            this.txtBoxTelefono.SelectedText = "";
            this.txtBoxTelefono.SelectionLength = 0;
            this.txtBoxTelefono.SelectionStart = 0;
            this.txtBoxTelefono.Size = new System.Drawing.Size(164, 23);
            this.txtBoxTelefono.TabIndex = 24;
            this.txtBoxTelefono.UseSystemPasswordChar = false;
            this.txtBoxTelefono.Leave += new System.EventHandler(this.txtBoxTelefono_Leave);
            // 
            // tblLayoutPanelMail
            // 
            this.tblLayoutPanelMail.ColumnCount = 2;
            this.tblLayoutPanelMail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tblLayoutPanelMail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelMail.Controls.Add(this.lblMail, 0, 0);
            this.tblLayoutPanelMail.Controls.Add(this.txtBoxMail, 1, 0);
            this.tblLayoutPanelMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelMail.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelMail.Name = "tblLayoutPanelMail";
            this.tblLayoutPanelMail.RowCount = 1;
            this.tblLayoutPanelMail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelMail.Size = new System.Drawing.Size(390, 44);
            this.tblLayoutPanelMail.TabIndex = 0;
            // 
            // lblMail
            // 
            this.lblMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(3, 5);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(82, 34);
            this.lblMail.TabIndex = 9;
            this.lblMail.Text = "Correo Electrónico:";
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxMail.Depth = 0;
            this.txtBoxMail.Hint = "";
            this.txtBoxMail.Location = new System.Drawing.Point(91, 10);
            this.txtBoxMail.Margin = new System.Windows.Forms.Padding(3, 3, 45, 3);
            this.txtBoxMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.PasswordChar = '\0';
            this.txtBoxMail.SelectedText = "";
            this.txtBoxMail.SelectionLength = 0;
            this.txtBoxMail.SelectionStart = 0;
            this.txtBoxMail.Size = new System.Drawing.Size(254, 23);
            this.txtBoxMail.TabIndex = 10;
            this.txtBoxMail.UseSystemPasswordChar = false;
            this.txtBoxMail.Leave += new System.EventHandler(this.txtBoxMail_Leave);
            // 
            // tblLayoutPanelMailLista
            // 
            this.tblLayoutPanelMailLista.ColumnCount = 2;
            this.tblLayoutPanelMailLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelMailLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tblLayoutPanelMailLista.Controls.Add(this.tblLayoutPanelMailListaAgregarQuitar, 1, 0);
            this.tblLayoutPanelMailLista.Controls.Add(this.dataGridViewMail, 0, 0);
            this.tblLayoutPanelMailLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelMailLista.Location = new System.Drawing.Point(3, 53);
            this.tblLayoutPanelMailLista.Name = "tblLayoutPanelMailLista";
            this.tblLayoutPanelMailLista.RowCount = 1;
            this.tblLayoutPanelMailLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelMailLista.Size = new System.Drawing.Size(390, 59);
            this.tblLayoutPanelMailLista.TabIndex = 1;
            // 
            // tblLayoutPanelMailListaAgregarQuitar
            // 
            this.tblLayoutPanelMailListaAgregarQuitar.ColumnCount = 1;
            this.tblLayoutPanelMailListaAgregarQuitar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelMailListaAgregarQuitar.Controls.Add(this.btnAgregarMail, 0, 0);
            this.tblLayoutPanelMailListaAgregarQuitar.Controls.Add(this.btnQuitarMail, 0, 1);
            this.tblLayoutPanelMailListaAgregarQuitar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelMailListaAgregarQuitar.Location = new System.Drawing.Point(360, 3);
            this.tblLayoutPanelMailListaAgregarQuitar.Name = "tblLayoutPanelMailListaAgregarQuitar";
            this.tblLayoutPanelMailListaAgregarQuitar.RowCount = 2;
            this.tblLayoutPanelMailListaAgregarQuitar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelMailListaAgregarQuitar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelMailListaAgregarQuitar.Size = new System.Drawing.Size(27, 53);
            this.tblLayoutPanelMailListaAgregarQuitar.TabIndex = 13;
            // 
            // btnAgregarMail
            // 
            this.btnAgregarMail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarMail.AutoSize = true;
            this.btnAgregarMail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarMail.Depth = 0;
            this.btnAgregarMail.Location = new System.Drawing.Point(4, 6);
            this.btnAgregarMail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarMail.Name = "btnAgregarMail";
            this.btnAgregarMail.Primary = false;
            this.btnAgregarMail.Size = new System.Drawing.Size(19, 14);
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
            this.btnQuitarMail.Location = new System.Drawing.Point(5, 32);
            this.btnQuitarMail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuitarMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitarMail.Name = "btnQuitarMail";
            this.btnQuitarMail.Primary = false;
            this.btnQuitarMail.Size = new System.Drawing.Size(16, 15);
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
            this.dataGridViewMail.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMail.Name = "dataGridViewMail";
            this.dataGridViewMail.ReadOnly = true;
            this.dataGridViewMail.RowHeadersVisible = false;
            this.dataGridViewMail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMail.Size = new System.Drawing.Size(351, 53);
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
            this.btnDatosAdicionales.Location = new System.Drawing.Point(296, 634);
            this.btnDatosAdicionales.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDatosAdicionales.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDatosAdicionales.Name = "btnDatosAdicionales";
            this.btnDatosAdicionales.Primary = false;
            this.btnDatosAdicionales.Size = new System.Drawing.Size(146, 30);
            this.btnDatosAdicionales.TabIndex = 7;
            this.btnDatosAdicionales.Text = "Datos adicionales";
            this.btnDatosAdicionales.UseVisualStyleBackColor = true;
            this.btnDatosAdicionales.Click += new System.EventHandler(this.btnDatosAdicionales_Click);
            // 
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.tblLayoutPanelPrincipal);
            this.pnlBase.Location = new System.Drawing.Point(28, 55);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(808, 666);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(972, 780);
            this.Controls.Add(this.pnlBase);
            this.Margin = new System.Windows.Forms.Padding(5);
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
            this.pnlObservaciones.ResumeLayout(false);
            this.grpBoxDatosPersonales.ResumeLayout(false);
            this.tblLayoutPanelDatosPersonales.ResumeLayout(false);
            this.tblLayoutPanelDatosEntidad.ResumeLayout(false);
            this.tblLayoutPanelDatosEntidad.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpBoxContacto;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelContacto;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelTelefonoLista;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.ComboBox cmbBoxTipoTelefono;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelMailLista;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelMailListaAgregarQuitar;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelTelefonoListaAgregarQuitar;
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
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxMail;
        private MaterialSkin.Controls.MaterialFlatButton btnDatosAdicionales;
        private MaterialSkin.Controls.MaterialFlatButton btnQuitarTelefono;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregarTelefono;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregarMail;
        private MaterialSkin.Controls.MaterialFlatButton btnQuitarMail;
        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDatosEntidad;
        private System.Windows.Forms.ErrorProvider epCodigoEntidad;
        private System.Windows.Forms.ErrorProvider epCUIT;
        private System.Windows.Forms.ErrorProvider epDNI;
        private System.Windows.Forms.ErrorProvider epNombre;
        private System.Windows.Forms.ErrorProvider epApellido;
        private System.Windows.Forms.ErrorProvider epRazonSocial;
        private System.Windows.Forms.ErrorProvider epMail;
        private System.Windows.Forms.ErrorProvider epNumeroTelefono;
        private System.Windows.Forms.Panel pnlObservaciones;
    }
}