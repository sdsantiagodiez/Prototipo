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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblLayoutPanelForm = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxTipoEntidad = new System.Windows.Forms.GroupBox();
            this.pnlTipoEntidad = new System.Windows.Forms.Panel();
            this.radioButtonContactoProveedor = new System.Windows.Forms.RadioButton();
            this.radioButtonProveedor = new System.Windows.Forms.RadioButton();
            this.radioButtonUsuario = new System.Windows.Forms.RadioButton();
            this.radioButtonCliente = new System.Windows.Forms.RadioButton();
            this.grpBoxObservaciones = new System.Windows.Forms.GroupBox();
            this.rchTextBoxObservaciones = new System.Windows.Forms.RichTextBox();
            this.grpBoxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelDatosPersonales = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.txtBoxCodigoEntidad = new System.Windows.Forms.TextBox();
            this.txtBoxDNI = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtBoxCUIT = new System.Windows.Forms.TextBox();
            this.txtBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.grpBoxDomicilio = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelDomicilio = new System.Windows.Forms.TableLayoutPanel();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtBoxCalle = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.txtBoxPiso = new System.Windows.Forms.TextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.cmbBoxProvincia = new System.Windows.Forms.ComboBox();
            this.txtBoxDepartamento = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtBoxCiudad = new System.Windows.Forms.TextBox();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.txtBoxCodigoPostal = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.cmbBoxPais = new System.Windows.Forms.ComboBox();
            this.txtBoxNumeroDomicilio = new System.Windows.Forms.TextBox();
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
            this.btnAgregarDomicilio = new System.Windows.Forms.Button();
            this.btnQuitarDomicilio = new System.Windows.Forms.Button();
            this.grpBoxContacto = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelContacto = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelTelefonoLista = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelTelefonoListaAgregarQuitar = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregarTelefono = new System.Windows.Forms.Button();
            this.btnQuitarTelefono = new System.Windows.Forms.Button();
            this.dataGridViewTelefono = new System.Windows.Forms.DataGridView();
            this.codigoTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLayoutPanelTelefono = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.cmbBoxTipoTelefono = new System.Windows.Forms.ComboBox();
            this.tblLayoutPanelMail = new System.Windows.Forms.TableLayoutPanel();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.tblLayoutPanelMailLista = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelMailListaAgregarQuitar = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuitarMail = new System.Windows.Forms.Button();
            this.btnAgregarMail = new System.Windows.Forms.Button();
            this.dataGridViewMail = new System.Windows.Forms.DataGridView();
            this.codigoMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDatosAdicionales = new System.Windows.Forms.Button();
            this.tblLayoutPanelForm.SuspendLayout();
            this.grpBoxTipoEntidad.SuspendLayout();
            this.pnlTipoEntidad.SuspendLayout();
            this.grpBoxObservaciones.SuspendLayout();
            this.grpBoxDatosPersonales.SuspendLayout();
            this.tblLayoutPanelDatosPersonales.SuspendLayout();
            this.grpBoxDomicilio.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblLayoutPanelDomicilio.SuspendLayout();
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
            this.SuspendLayout();
            // 
            // tblLayoutPanelForm
            // 
            this.tblLayoutPanelForm.ColumnCount = 1;
            this.tblLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelForm.Controls.Add(this.grpBoxTipoEntidad, 0, 0);
            this.tblLayoutPanelForm.Controls.Add(this.grpBoxObservaciones, 0, 4);
            this.tblLayoutPanelForm.Controls.Add(this.grpBoxDatosPersonales, 0, 1);
            this.tblLayoutPanelForm.Controls.Add(this.grpBoxDomicilio, 0, 2);
            this.tblLayoutPanelForm.Controls.Add(this.grpBoxContacto, 0, 3);
            this.tblLayoutPanelForm.Controls.Add(this.btnDatosAdicionales, 0, 5);
            this.tblLayoutPanelForm.Location = new System.Drawing.Point(12, 27);
            this.tblLayoutPanelForm.Name = "tblLayoutPanelForm";
            this.tblLayoutPanelForm.RowCount = 6;
            this.tblLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tblLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tblLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tblLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tblLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblLayoutPanelForm.Size = new System.Drawing.Size(701, 705);
            this.tblLayoutPanelForm.TabIndex = 4;
            // 
            // grpBoxTipoEntidad
            // 
            this.grpBoxTipoEntidad.Controls.Add(this.pnlTipoEntidad);
            this.grpBoxTipoEntidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxTipoEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxTipoEntidad.Location = new System.Drawing.Point(3, 3);
            this.grpBoxTipoEntidad.Name = "grpBoxTipoEntidad";
            this.grpBoxTipoEntidad.Size = new System.Drawing.Size(695, 59);
            this.grpBoxTipoEntidad.TabIndex = 4;
            this.grpBoxTipoEntidad.TabStop = false;
            this.grpBoxTipoEntidad.Text = "Tipo Entidad";
            // 
            // pnlTipoEntidad
            // 
            this.pnlTipoEntidad.Controls.Add(this.radioButtonContactoProveedor);
            this.pnlTipoEntidad.Controls.Add(this.radioButtonProveedor);
            this.pnlTipoEntidad.Controls.Add(this.radioButtonUsuario);
            this.pnlTipoEntidad.Controls.Add(this.radioButtonCliente);
            this.pnlTipoEntidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTipoEntidad.Location = new System.Drawing.Point(3, 20);
            this.pnlTipoEntidad.Name = "pnlTipoEntidad";
            this.pnlTipoEntidad.Size = new System.Drawing.Size(689, 36);
            this.pnlTipoEntidad.TabIndex = 7;
            // 
            // radioButtonContactoProveedor
            // 
            this.radioButtonContactoProveedor.AutoSize = true;
            this.radioButtonContactoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonContactoProveedor.Location = new System.Drawing.Point(275, 7);
            this.radioButtonContactoProveedor.Name = "radioButtonContactoProveedor";
            this.radioButtonContactoProveedor.Size = new System.Drawing.Size(180, 22);
            this.radioButtonContactoProveedor.TabIndex = 3;
            this.radioButtonContactoProveedor.TabStop = true;
            this.radioButtonContactoProveedor.Text = "Contacto de Proveedor";
            this.radioButtonContactoProveedor.UseVisualStyleBackColor = true;
            this.radioButtonContactoProveedor.CheckedChanged += new System.EventHandler(this.radioButtonContactoProveedor_CheckedChanged);
            // 
            // radioButtonProveedor
            // 
            this.radioButtonProveedor.AutoSize = true;
            this.radioButtonProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonProveedor.Location = new System.Drawing.Point(127, 7);
            this.radioButtonProveedor.Name = "radioButtonProveedor";
            this.radioButtonProveedor.Size = new System.Drawing.Size(95, 22);
            this.radioButtonProveedor.TabIndex = 2;
            this.radioButtonProveedor.TabStop = true;
            this.radioButtonProveedor.Text = "Proveedor";
            this.radioButtonProveedor.UseVisualStyleBackColor = true;
            this.radioButtonProveedor.CheckedChanged += new System.EventHandler(this.radioButtonProveedor_CheckedChanged);
            // 
            // radioButtonUsuario
            // 
            this.radioButtonUsuario.AutoSize = true;
            this.radioButtonUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonUsuario.Location = new System.Drawing.Point(482, 7);
            this.radioButtonUsuario.Name = "radioButtonUsuario";
            this.radioButtonUsuario.Size = new System.Drawing.Size(156, 22);
            this.radioButtonUsuario.TabIndex = 4;
            this.radioButtonUsuario.TabStop = true;
            this.radioButtonUsuario.Text = "Usuario de Sistema";
            this.radioButtonUsuario.UseVisualStyleBackColor = true;
            this.radioButtonUsuario.CheckedChanged += new System.EventHandler(this.radioButtonUsuario_CheckedChanged);
            // 
            // radioButtonCliente
            // 
            this.radioButtonCliente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonCliente.AutoSize = true;
            this.radioButtonCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCliente.Location = new System.Drawing.Point(9, 7);
            this.radioButtonCliente.Name = "radioButtonCliente";
            this.radioButtonCliente.Size = new System.Drawing.Size(71, 22);
            this.radioButtonCliente.TabIndex = 1;
            this.radioButtonCliente.TabStop = true;
            this.radioButtonCliente.Text = "Cliente";
            this.radioButtonCliente.UseVisualStyleBackColor = true;
            this.radioButtonCliente.CheckedChanged += new System.EventHandler(this.radioButtonCliente_CheckedChanged);
            // 
            // grpBoxObservaciones
            // 
            this.grpBoxObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxObservaciones.Controls.Add(this.rchTextBoxObservaciones);
            this.grpBoxObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxObservaciones.Location = new System.Drawing.Point(3, 538);
            this.grpBoxObservaciones.Name = "grpBoxObservaciones";
            this.grpBoxObservaciones.Size = new System.Drawing.Size(695, 116);
            this.grpBoxObservaciones.TabIndex = 6;
            this.grpBoxObservaciones.TabStop = false;
            this.grpBoxObservaciones.Text = "Observaciones";
            // 
            // rchTextBoxObservaciones
            // 
            this.rchTextBoxObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchTextBoxObservaciones.Location = new System.Drawing.Point(3, 20);
            this.rchTextBoxObservaciones.Name = "rchTextBoxObservaciones";
            this.rchTextBoxObservaciones.Size = new System.Drawing.Size(689, 93);
            this.rchTextBoxObservaciones.TabIndex = 22;
            this.rchTextBoxObservaciones.Text = "";
            // 
            // grpBoxDatosPersonales
            // 
            this.grpBoxDatosPersonales.Controls.Add(this.tblLayoutPanelDatosPersonales);
            this.grpBoxDatosPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDatosPersonales.Location = new System.Drawing.Point(3, 68);
            this.grpBoxDatosPersonales.Name = "grpBoxDatosPersonales";
            this.grpBoxDatosPersonales.Size = new System.Drawing.Size(695, 114);
            this.grpBoxDatosPersonales.TabIndex = 3;
            this.grpBoxDatosPersonales.TabStop = false;
            this.grpBoxDatosPersonales.Text = "Datos Personales";
            // 
            // tblLayoutPanelDatosPersonales
            // 
            this.tblLayoutPanelDatosPersonales.ColumnCount = 4;
            this.tblLayoutPanelDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.143686F));
            this.tblLayoutPanelDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.93179F));
            this.tblLayoutPanelDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.70682F));
            this.tblLayoutPanelDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.lblCodigo, 0, 0);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.lblDNI, 0, 1);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.lblCUIT, 0, 2);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.txtBoxCodigoEntidad, 1, 0);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.txtBoxDNI, 1, 1);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.lblApellido, 2, 0);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.txtBoxApellido, 3, 0);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.lblNombre, 2, 1);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.txtBoxNombre, 3, 1);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.lblRazonSocial, 2, 2);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.txtBoxCUIT, 1, 2);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.txtBoxRazonSocial, 3, 2);
            this.tblLayoutPanelDatosPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDatosPersonales.Location = new System.Drawing.Point(3, 20);
            this.tblLayoutPanelDatosPersonales.Name = "tblLayoutPanelDatosPersonales";
            this.tblLayoutPanelDatosPersonales.RowCount = 3;
            this.tblLayoutPanelDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tblLayoutPanelDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tblLayoutPanelDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tblLayoutPanelDatosPersonales.Size = new System.Drawing.Size(689, 91);
            this.tblLayoutPanelDatosPersonales.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(4, 6);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblDNI
            // 
            this.lblDNI.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(25, 35);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(35, 17);
            this.lblDNI.TabIndex = 1;
            this.lblDNI.Text = "DNI:";
            // 
            // lblCUIT
            // 
            this.lblCUIT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUIT.Location = new System.Drawing.Point(17, 66);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(43, 17);
            this.lblCUIT.TabIndex = 4;
            this.lblCUIT.Text = "CUIT:";
            // 
            // txtBoxCodigoEntidad
            // 
            this.txtBoxCodigoEntidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoEntidad.Location = new System.Drawing.Point(66, 3);
            this.txtBoxCodigoEntidad.Name = "txtBoxCodigoEntidad";
            this.txtBoxCodigoEntidad.Size = new System.Drawing.Size(152, 24);
            this.txtBoxCodigoEntidad.TabIndex = 5;
            // 
            // txtBoxDNI
            // 
            this.txtBoxDNI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDNI.Location = new System.Drawing.Point(66, 32);
            this.txtBoxDNI.Name = "txtBoxDNI";
            this.txtBoxDNI.Size = new System.Drawing.Size(152, 24);
            this.txtBoxDNI.TabIndex = 6;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(278, 6);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 17);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxApellido.Location = new System.Drawing.Point(346, 3);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(340, 24);
            this.txtBoxApellido.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(278, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNombre.Location = new System.Drawing.Point(346, 32);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(340, 24);
            this.txtBoxNombre.TabIndex = 9;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(245, 66);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(95, 17);
            this.lblRazonSocial.TabIndex = 10;
            this.lblRazonSocial.Text = "Razón Social:";
            // 
            // txtBoxCUIT
            // 
            this.txtBoxCUIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCUIT.Location = new System.Drawing.Point(66, 63);
            this.txtBoxCUIT.Name = "txtBoxCUIT";
            this.txtBoxCUIT.Size = new System.Drawing.Size(152, 24);
            this.txtBoxCUIT.TabIndex = 7;
            // 
            // txtBoxRazonSocial
            // 
            this.txtBoxRazonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxRazonSocial.Enabled = false;
            this.txtBoxRazonSocial.Location = new System.Drawing.Point(346, 63);
            this.txtBoxRazonSocial.Name = "txtBoxRazonSocial";
            this.txtBoxRazonSocial.Size = new System.Drawing.Size(340, 24);
            this.txtBoxRazonSocial.TabIndex = 11;
            // 
            // grpBoxDomicilio
            // 
            this.grpBoxDomicilio.Controls.Add(this.tableLayoutPanel1);
            this.grpBoxDomicilio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDomicilio.Location = new System.Drawing.Point(3, 188);
            this.grpBoxDomicilio.Name = "grpBoxDomicilio";
            this.grpBoxDomicilio.Size = new System.Drawing.Size(695, 204);
            this.grpBoxDomicilio.TabIndex = 4;
            this.grpBoxDomicilio.TabStop = false;
            this.grpBoxDomicilio.Text = "Domicilio";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tblLayoutPanelDomicilio, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tblLayoutPanelDomicilioGrid, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.98895F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.01105F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(689, 181);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tblLayoutPanelDomicilio
            // 
            this.tblLayoutPanelDomicilio.ColumnCount = 8;
            this.tblLayoutPanelDomicilio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31F));
            this.tblLayoutPanelDomicilio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69F));
            this.tblLayoutPanelDomicilio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tblLayoutPanelDomicilio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tblLayoutPanelDomicilio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tblLayoutPanelDomicilio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tblLayoutPanelDomicilio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tblLayoutPanelDomicilio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tblLayoutPanelDomicilio.Controls.Add(this.lblCalle, 0, 0);
            this.tblLayoutPanelDomicilio.Controls.Add(this.txtBoxCalle, 1, 0);
            this.tblLayoutPanelDomicilio.Controls.Add(this.lblNumero, 2, 0);
            this.tblLayoutPanelDomicilio.Controls.Add(this.lblPiso, 4, 0);
            this.tblLayoutPanelDomicilio.Controls.Add(this.txtBoxPiso, 5, 0);
            this.tblLayoutPanelDomicilio.Controls.Add(this.lblDepartamento, 6, 0);
            this.tblLayoutPanelDomicilio.Controls.Add(this.lblProvincia, 4, 1);
            this.tblLayoutPanelDomicilio.Controls.Add(this.cmbBoxProvincia, 5, 1);
            this.tblLayoutPanelDomicilio.Controls.Add(this.txtBoxDepartamento, 7, 0);
            this.tblLayoutPanelDomicilio.Controls.Add(this.lblCiudad, 0, 1);
            this.tblLayoutPanelDomicilio.Controls.Add(this.txtBoxCiudad, 1, 1);
            this.tblLayoutPanelDomicilio.Controls.Add(this.lblCodigoPostal, 2, 1);
            this.tblLayoutPanelDomicilio.Controls.Add(this.txtBoxCodigoPostal, 3, 1);
            this.tblLayoutPanelDomicilio.Controls.Add(this.lblPais, 6, 1);
            this.tblLayoutPanelDomicilio.Controls.Add(this.cmbBoxPais, 7, 1);
            this.tblLayoutPanelDomicilio.Controls.Add(this.txtBoxNumeroDomicilio, 3, 0);
            this.tblLayoutPanelDomicilio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDomicilio.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelDomicilio.Name = "tblLayoutPanelDomicilio";
            this.tblLayoutPanelDomicilio.RowCount = 2;
            this.tblLayoutPanelDomicilio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.72414F));
            this.tblLayoutPanelDomicilio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.27586F));
            this.tblLayoutPanelDomicilio.Size = new System.Drawing.Size(683, 69);
            this.tblLayoutPanelDomicilio.TabIndex = 0;
            // 
            // lblCalle
            // 
            this.lblCalle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(16, 9);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(43, 17);
            this.lblCalle.TabIndex = 1;
            this.lblCalle.Text = "Calle:";
            // 
            // txtBoxCalle
            // 
            this.txtBoxCalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCalle.Location = new System.Drawing.Point(65, 5);
            this.txtBoxCalle.Name = "txtBoxCalle";
            this.txtBoxCalle.Size = new System.Drawing.Size(132, 24);
            this.txtBoxCalle.TabIndex = 8;
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(241, 9);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(62, 17);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Número:";
            // 
            // lblPiso
            // 
            this.lblPiso.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPiso.AutoSize = true;
            this.lblPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiso.Location = new System.Drawing.Point(395, 9);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(39, 17);
            this.lblPiso.TabIndex = 2;
            this.lblPiso.Text = "Piso:";
            // 
            // txtBoxPiso
            // 
            this.txtBoxPiso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPiso.Location = new System.Drawing.Point(440, 5);
            this.txtBoxPiso.Name = "txtBoxPiso";
            this.txtBoxPiso.Size = new System.Drawing.Size(89, 24);
            this.txtBoxPiso.TabIndex = 10;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(540, 9);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(42, 17);
            this.lblDepartamento.TabIndex = 7;
            this.lblDepartamento.Text = "Dpto:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(364, 43);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(70, 17);
            this.lblProvincia.TabIndex = 6;
            this.lblProvincia.Text = "Provincia:";
            // 
            // cmbBoxProvincia
            // 
            this.cmbBoxProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxProvincia.FormattingEnabled = true;
            this.cmbBoxProvincia.Location = new System.Drawing.Point(440, 41);
            this.cmbBoxProvincia.Name = "cmbBoxProvincia";
            this.cmbBoxProvincia.Size = new System.Drawing.Size(89, 26);
            this.cmbBoxProvincia.TabIndex = 14;
            // 
            // txtBoxDepartamento
            // 
            this.txtBoxDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDepartamento.Location = new System.Drawing.Point(588, 5);
            this.txtBoxDepartamento.Name = "txtBoxDepartamento";
            this.txtBoxDepartamento.Size = new System.Drawing.Size(92, 24);
            this.txtBoxDepartamento.TabIndex = 11;
            // 
            // lblCiudad
            // 
            this.lblCiudad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(3, 43);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(56, 17);
            this.lblCiudad.TabIndex = 5;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // txtBoxCiudad
            // 
            this.txtBoxCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCiudad.Location = new System.Drawing.Point(65, 40);
            this.txtBoxCiudad.Name = "txtBoxCiudad";
            this.txtBoxCiudad.Size = new System.Drawing.Size(132, 24);
            this.txtBoxCiudad.TabIndex = 12;
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPostal.Location = new System.Drawing.Point(204, 43);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(99, 17);
            this.lblCodigoPostal.TabIndex = 4;
            this.lblCodigoPostal.Text = "Código Postal:";
            // 
            // txtBoxCodigoPostal
            // 
            this.txtBoxCodigoPostal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoPostal.Location = new System.Drawing.Point(309, 40);
            this.txtBoxCodigoPostal.Name = "txtBoxCodigoPostal";
            this.txtBoxCodigoPostal.Size = new System.Drawing.Size(49, 24);
            this.txtBoxCodigoPostal.TabIndex = 13;
            // 
            // lblPais
            // 
            this.lblPais.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(543, 43);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(39, 17);
            this.lblPais.TabIndex = 15;
            this.lblPais.Text = "País:";
            // 
            // cmbBoxPais
            // 
            this.cmbBoxPais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxPais.FormattingEnabled = true;
            this.cmbBoxPais.Location = new System.Drawing.Point(588, 41);
            this.cmbBoxPais.Name = "cmbBoxPais";
            this.cmbBoxPais.Size = new System.Drawing.Size(92, 26);
            this.cmbBoxPais.TabIndex = 15;
            this.cmbBoxPais.SelectionChangeCommitted += new System.EventHandler(this.cmbBoxPais_SelectionChangeCommitted);
            // 
            // txtBoxNumeroDomicilio
            // 
            this.txtBoxNumeroDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNumeroDomicilio.Location = new System.Drawing.Point(309, 5);
            this.txtBoxNumeroDomicilio.Name = "txtBoxNumeroDomicilio";
            this.txtBoxNumeroDomicilio.Size = new System.Drawing.Size(49, 24);
            this.txtBoxNumeroDomicilio.TabIndex = 16;
            // 
            // tblLayoutPanelDomicilioGrid
            // 
            this.tblLayoutPanelDomicilioGrid.ColumnCount = 2;
            this.tblLayoutPanelDomicilioGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.43631F));
            this.tblLayoutPanelDomicilioGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.56369F));
            this.tblLayoutPanelDomicilioGrid.Controls.Add(this.dataGridViewDomicilio, 0, 0);
            this.tblLayoutPanelDomicilioGrid.Controls.Add(this.tblLayoutPanelDomicilioAgregarQuitar, 1, 0);
            this.tblLayoutPanelDomicilioGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDomicilioGrid.Location = new System.Drawing.Point(3, 78);
            this.tblLayoutPanelDomicilioGrid.Name = "tblLayoutPanelDomicilioGrid";
            this.tblLayoutPanelDomicilioGrid.RowCount = 1;
            this.tblLayoutPanelDomicilioGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDomicilioGrid.Size = new System.Drawing.Size(683, 100);
            this.tblLayoutPanelDomicilioGrid.TabIndex = 1;
            // 
            // dataGridViewDomicilio
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDomicilio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dataGridViewDomicilio.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDomicilio.Name = "dataGridViewDomicilio";
            this.dataGridViewDomicilio.ReadOnly = true;
            this.dataGridViewDomicilio.RowHeadersVisible = false;
            this.dataGridViewDomicilio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDomicilio.Size = new System.Drawing.Size(638, 94);
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
            this.numero.Width = 70;
            // 
            // piso
            // 
            this.piso.HeaderText = "Piso";
            this.piso.Name = "piso";
            this.piso.ReadOnly = true;
            this.piso.Width = 70;
            // 
            // departamento
            // 
            this.departamento.HeaderText = "Departamento";
            this.departamento.Name = "departamento";
            this.departamento.ReadOnly = true;
            this.departamento.Width = 105;
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
            this.ciudad.Width = 110;
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
            this.provincia.Width = 110;
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
            this.tblLayoutPanelDomicilioAgregarQuitar.Location = new System.Drawing.Point(647, 3);
            this.tblLayoutPanelDomicilioAgregarQuitar.Name = "tblLayoutPanelDomicilioAgregarQuitar";
            this.tblLayoutPanelDomicilioAgregarQuitar.RowCount = 2;
            this.tblLayoutPanelDomicilioAgregarQuitar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDomicilioAgregarQuitar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDomicilioAgregarQuitar.Size = new System.Drawing.Size(33, 94);
            this.tblLayoutPanelDomicilioAgregarQuitar.TabIndex = 2;
            // 
            // btnAgregarDomicilio
            // 
            this.btnAgregarDomicilio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDomicilio.Location = new System.Drawing.Point(5, 12);
            this.btnAgregarDomicilio.Name = "btnAgregarDomicilio";
            this.btnAgregarDomicilio.Size = new System.Drawing.Size(22, 22);
            this.btnAgregarDomicilio.TabIndex = 16;
            this.btnAgregarDomicilio.UseVisualStyleBackColor = true;
            this.btnAgregarDomicilio.Click += new System.EventHandler(this.btnAgregarDomicilio_Click);
            // 
            // btnQuitarDomicilio
            // 
            this.btnQuitarDomicilio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuitarDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarDomicilio.Location = new System.Drawing.Point(5, 59);
            this.btnQuitarDomicilio.Name = "btnQuitarDomicilio";
            this.btnQuitarDomicilio.Size = new System.Drawing.Size(22, 22);
            this.btnQuitarDomicilio.TabIndex = 16;
            this.btnQuitarDomicilio.TabStop = false;
            this.btnQuitarDomicilio.UseVisualStyleBackColor = true;
            this.btnQuitarDomicilio.Click += new System.EventHandler(this.btnQuitarDomicilio_Click);
            // 
            // grpBoxContacto
            // 
            this.grpBoxContacto.Controls.Add(this.tblLayoutPanelContacto);
            this.grpBoxContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxContacto.Location = new System.Drawing.Point(3, 398);
            this.grpBoxContacto.Name = "grpBoxContacto";
            this.grpBoxContacto.Size = new System.Drawing.Size(695, 134);
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
            this.tblLayoutPanelContacto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.63636F));
            this.tblLayoutPanelContacto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.36364F));
            this.tblLayoutPanelContacto.Size = new System.Drawing.Size(689, 111);
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
            this.tblLayoutPanelTelefonoLista.Location = new System.Drawing.Point(378, 51);
            this.tblLayoutPanelTelefonoLista.Name = "tblLayoutPanelTelefonoLista";
            this.tblLayoutPanelTelefonoLista.RowCount = 1;
            this.tblLayoutPanelTelefonoLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelTelefonoLista.Size = new System.Drawing.Size(308, 57);
            this.tblLayoutPanelTelefonoLista.TabIndex = 3;
            // 
            // tblLayoutPanelTelefonoListaAgregarQuitar
            // 
            this.tblLayoutPanelTelefonoListaAgregarQuitar.ColumnCount = 1;
            this.tblLayoutPanelTelefonoListaAgregarQuitar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelTelefonoListaAgregarQuitar.Controls.Add(this.btnAgregarTelefono, 0, 0);
            this.tblLayoutPanelTelefonoListaAgregarQuitar.Controls.Add(this.btnQuitarTelefono, 0, 1);
            this.tblLayoutPanelTelefonoListaAgregarQuitar.Location = new System.Drawing.Point(278, 3);
            this.tblLayoutPanelTelefonoListaAgregarQuitar.Name = "tblLayoutPanelTelefonoListaAgregarQuitar";
            this.tblLayoutPanelTelefonoListaAgregarQuitar.RowCount = 2;
            this.tblLayoutPanelTelefonoListaAgregarQuitar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelTelefonoListaAgregarQuitar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelTelefonoListaAgregarQuitar.Size = new System.Drawing.Size(27, 51);
            this.tblLayoutPanelTelefonoListaAgregarQuitar.TabIndex = 13;
            // 
            // btnAgregarTelefono
            // 
            this.btnAgregarTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTelefono.Location = new System.Drawing.Point(3, 3);
            this.btnAgregarTelefono.Name = "btnAgregarTelefono";
            this.btnAgregarTelefono.Size = new System.Drawing.Size(21, 19);
            this.btnAgregarTelefono.TabIndex = 21;
            this.btnAgregarTelefono.UseVisualStyleBackColor = true;
            this.btnAgregarTelefono.Click += new System.EventHandler(this.btnAgregarNumeroTelefono_Click);
            // 
            // btnQuitarTelefono
            // 
            this.btnQuitarTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuitarTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarTelefono.Location = new System.Drawing.Point(3, 28);
            this.btnQuitarTelefono.Name = "btnQuitarTelefono";
            this.btnQuitarTelefono.Size = new System.Drawing.Size(21, 20);
            this.btnQuitarTelefono.TabIndex = 11;
            this.btnQuitarTelefono.TabStop = false;
            this.btnQuitarTelefono.UseVisualStyleBackColor = true;
            this.btnQuitarTelefono.Click += new System.EventHandler(this.btnQuitarNumeroTelefono_Click);
            // 
            // dataGridViewTelefono
            // 
            this.dataGridViewTelefono.AllowUserToDeleteRows = false;
            this.dataGridViewTelefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTelefono.ColumnHeadersVisible = false;
            this.dataGridViewTelefono.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTelefono,
            this.codigoTipo,
            this.tipo,
            this.numeroTelefono});
            this.dataGridViewTelefono.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTelefono.Name = "dataGridViewTelefono";
            this.dataGridViewTelefono.ReadOnly = true;
            this.dataGridViewTelefono.RowHeadersVisible = false;
            this.dataGridViewTelefono.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTelefono.Size = new System.Drawing.Size(250, 51);
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
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 50;
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
            this.tblLayoutPanelTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.48148F));
            this.tblLayoutPanelTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.51852F));
            this.tblLayoutPanelTelefono.Controls.Add(this.txtBoxTelefono, 2, 0);
            this.tblLayoutPanelTelefono.Controls.Add(this.lblTelefono, 1, 0);
            this.tblLayoutPanelTelefono.Controls.Add(this.cmbBoxTipoTelefono, 0, 0);
            this.tblLayoutPanelTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelTelefono.Location = new System.Drawing.Point(378, 3);
            this.tblLayoutPanelTelefono.Name = "tblLayoutPanelTelefono";
            this.tblLayoutPanelTelefono.RowCount = 1;
            this.tblLayoutPanelTelefono.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelTelefono.Size = new System.Drawing.Size(308, 42);
            this.tblLayoutPanelTelefono.TabIndex = 2;
            // 
            // txtBoxTelefono
            // 
            this.txtBoxTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxTelefono.Location = new System.Drawing.Point(141, 9);
            this.txtBoxTelefono.Name = "txtBoxTelefono";
            this.txtBoxTelefono.Size = new System.Drawing.Size(164, 24);
            this.txtBoxTelefono.TabIndex = 20;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(63, 12);
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
            this.cmbBoxTipoTelefono.Location = new System.Drawing.Point(3, 8);
            this.cmbBoxTipoTelefono.Name = "cmbBoxTipoTelefono";
            this.cmbBoxTipoTelefono.Size = new System.Drawing.Size(54, 26);
            this.cmbBoxTipoTelefono.TabIndex = 19;
            // 
            // tblLayoutPanelMail
            // 
            this.tblLayoutPanelMail.ColumnCount = 2;
            this.tblLayoutPanelMail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.47896F));
            this.tblLayoutPanelMail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.52103F));
            this.tblLayoutPanelMail.Controls.Add(this.lblMail, 0, 0);
            this.tblLayoutPanelMail.Controls.Add(this.txtBoxMail, 1, 0);
            this.tblLayoutPanelMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelMail.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelMail.Name = "tblLayoutPanelMail";
            this.tblLayoutPanelMail.RowCount = 1;
            this.tblLayoutPanelMail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelMail.Size = new System.Drawing.Size(369, 42);
            this.tblLayoutPanelMail.TabIndex = 0;
            // 
            // lblMail
            // 
            this.lblMail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(3, 4);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(82, 34);
            this.lblMail.TabIndex = 9;
            this.lblMail.Text = "Correo Electrónico:";
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxMail.Location = new System.Drawing.Point(108, 9);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(258, 24);
            this.txtBoxMail.TabIndex = 17;
            // 
            // tblLayoutPanelMailLista
            // 
            this.tblLayoutPanelMailLista.ColumnCount = 2;
            this.tblLayoutPanelMailLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelMailLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tblLayoutPanelMailLista.Controls.Add(this.tblLayoutPanelMailListaAgregarQuitar, 1, 0);
            this.tblLayoutPanelMailLista.Controls.Add(this.dataGridViewMail, 0, 0);
            this.tblLayoutPanelMailLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelMailLista.Location = new System.Drawing.Point(3, 51);
            this.tblLayoutPanelMailLista.Name = "tblLayoutPanelMailLista";
            this.tblLayoutPanelMailLista.RowCount = 1;
            this.tblLayoutPanelMailLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelMailLista.Size = new System.Drawing.Size(369, 57);
            this.tblLayoutPanelMailLista.TabIndex = 1;
            // 
            // tblLayoutPanelMailListaAgregarQuitar
            // 
            this.tblLayoutPanelMailListaAgregarQuitar.ColumnCount = 1;
            this.tblLayoutPanelMailListaAgregarQuitar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelMailListaAgregarQuitar.Controls.Add(this.btnQuitarMail, 0, 1);
            this.tblLayoutPanelMailListaAgregarQuitar.Controls.Add(this.btnAgregarMail, 0, 0);
            this.tblLayoutPanelMailListaAgregarQuitar.Location = new System.Drawing.Point(339, 3);
            this.tblLayoutPanelMailListaAgregarQuitar.Name = "tblLayoutPanelMailListaAgregarQuitar";
            this.tblLayoutPanelMailListaAgregarQuitar.RowCount = 2;
            this.tblLayoutPanelMailListaAgregarQuitar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelMailListaAgregarQuitar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelMailListaAgregarQuitar.Size = new System.Drawing.Size(27, 51);
            this.tblLayoutPanelMailListaAgregarQuitar.TabIndex = 13;
            // 
            // btnQuitarMail
            // 
            this.btnQuitarMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuitarMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarMail.Location = new System.Drawing.Point(3, 28);
            this.btnQuitarMail.Name = "btnQuitarMail";
            this.btnQuitarMail.Size = new System.Drawing.Size(21, 20);
            this.btnQuitarMail.TabIndex = 11;
            this.btnQuitarMail.TabStop = false;
            this.btnQuitarMail.UseVisualStyleBackColor = true;
            this.btnQuitarMail.Click += new System.EventHandler(this.btnQuitarMail_Click);
            // 
            // btnAgregarMail
            // 
            this.btnAgregarMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMail.Location = new System.Drawing.Point(3, 3);
            this.btnAgregarMail.Name = "btnAgregarMail";
            this.btnAgregarMail.Size = new System.Drawing.Size(21, 19);
            this.btnAgregarMail.TabIndex = 18;
            this.btnAgregarMail.UseVisualStyleBackColor = true;
            this.btnAgregarMail.Click += new System.EventHandler(this.btnAgregarMail_Click);
            // 
            // dataGridViewMail
            // 
            this.dataGridViewMail.AllowUserToDeleteRows = false;
            this.dataGridViewMail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMail.ColumnHeadersVisible = false;
            this.dataGridViewMail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoMail,
            this.mail});
            this.dataGridViewMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMail.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMail.Name = "dataGridViewMail";
            this.dataGridViewMail.ReadOnly = true;
            this.dataGridViewMail.RowHeadersVisible = false;
            this.dataGridViewMail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMail.Size = new System.Drawing.Size(330, 51);
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
            this.mail.Width = 300;
            // 
            // btnDatosAdicionales
            // 
            this.btnDatosAdicionales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDatosAdicionales.Location = new System.Drawing.Point(292, 670);
            this.btnDatosAdicionales.Name = "btnDatosAdicionales";
            this.btnDatosAdicionales.Size = new System.Drawing.Size(116, 23);
            this.btnDatosAdicionales.TabIndex = 7;
            this.btnDatosAdicionales.Text = "Datos Adicionales";
            this.btnDatosAdicionales.UseVisualStyleBackColor = true;
            this.btnDatosAdicionales.Click += new System.EventHandler(this.btnDatosAdicionales_Click);
            // 
            // frmABMEntidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(730, 741);
            this.Controls.Add(this.tblLayoutPanelForm);
            this.Name = "frmABMEntidad";
            this.Text = "ABM Entidades";
            this.Controls.SetChildIndex(this.tblLayoutPanelForm, 0);
            this.tblLayoutPanelForm.ResumeLayout(false);
            this.grpBoxTipoEntidad.ResumeLayout(false);
            this.pnlTipoEntidad.ResumeLayout(false);
            this.pnlTipoEntidad.PerformLayout();
            this.grpBoxObservaciones.ResumeLayout(false);
            this.grpBoxDatosPersonales.ResumeLayout(false);
            this.tblLayoutPanelDatosPersonales.ResumeLayout(false);
            this.tblLayoutPanelDatosPersonales.PerformLayout();
            this.grpBoxDomicilio.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tblLayoutPanelDomicilio.ResumeLayout(false);
            this.tblLayoutPanelDomicilio.PerformLayout();
            this.tblLayoutPanelDomicilioGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDomicilio)).EndInit();
            this.tblLayoutPanelDomicilioAgregarQuitar.ResumeLayout(false);
            this.grpBoxContacto.ResumeLayout(false);
            this.tblLayoutPanelContacto.ResumeLayout(false);
            this.tblLayoutPanelTelefonoLista.ResumeLayout(false);
            this.tblLayoutPanelTelefonoListaAgregarQuitar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelefono)).EndInit();
            this.tblLayoutPanelTelefono.ResumeLayout(false);
            this.tblLayoutPanelTelefono.PerformLayout();
            this.tblLayoutPanelMail.ResumeLayout(false);
            this.tblLayoutPanelMail.PerformLayout();
            this.tblLayoutPanelMailLista.ResumeLayout(false);
            this.tblLayoutPanelMailListaAgregarQuitar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelForm;
        private System.Windows.Forms.GroupBox grpBoxTipoEntidad;
        private System.Windows.Forms.Panel pnlTipoEntidad;
        private System.Windows.Forms.RadioButton radioButtonContactoProveedor;
        private System.Windows.Forms.RadioButton radioButtonProveedor;
        private System.Windows.Forms.RadioButton radioButtonUsuario;
        private System.Windows.Forms.RadioButton radioButtonCliente;
        private System.Windows.Forms.GroupBox grpBoxObservaciones;
        private System.Windows.Forms.RichTextBox rchTextBoxObservaciones;
        private System.Windows.Forms.GroupBox grpBoxDatosPersonales;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDatosPersonales;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.TextBox txtBoxCodigoEntidad;
        private System.Windows.Forms.TextBox txtBoxDNI;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtBoxCUIT;
        private System.Windows.Forms.TextBox txtBoxRazonSocial;
        private System.Windows.Forms.GroupBox grpBoxDomicilio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDomicilio;
        private System.Windows.Forms.Button btnQuitarDomicilio;
        private System.Windows.Forms.Button btnAgregarDomicilio;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtBoxCalle;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.TextBox txtBoxPiso;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtBoxCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.TextBox txtBoxCodigoPostal;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.ComboBox cmbBoxProvincia;
        private System.Windows.Forms.TextBox txtBoxDepartamento;
        private System.Windows.Forms.DataGridView dataGridViewDomicilio;
        private System.Windows.Forms.GroupBox grpBoxContacto;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelContacto;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelTelefonoLista;
        private System.Windows.Forms.Button btnQuitarTelefono;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelTelefono;
        private System.Windows.Forms.Button btnAgregarTelefono;
        private System.Windows.Forms.TextBox txtBoxTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.ComboBox cmbBoxTipoTelefono;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.Button btnAgregarMail;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelMailLista;
        private System.Windows.Forms.Button btnQuitarMail;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDomicilioGrid;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDomicilioAgregarQuitar;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelMailListaAgregarQuitar;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelTelefonoListaAgregarQuitar;
        private System.Windows.Forms.ComboBox cmbBoxPais;
        private System.Windows.Forms.Label lblPais;
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
        private System.Windows.Forms.DataGridView dataGridViewTelefono;
        private System.Windows.Forms.DataGridView dataGridViewMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTelefono;
        private System.Windows.Forms.Button btnDatosAdicionales;
        private System.Windows.Forms.TextBox txtBoxNumeroDomicilio;
    }
}