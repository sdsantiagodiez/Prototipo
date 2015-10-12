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
            this.menuStripABM = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.tblLayoutPanelDatos = new System.Windows.Forms.TableLayoutPanel();
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
            this.txtBoxCodigo = new System.Windows.Forms.TextBox();
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
            this.tblLayoutPanelDireccion = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuitarDireccion = new System.Windows.Forms.Button();
            this.btnAgregarDireccion = new System.Windows.Forms.Button();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtBoxCalle = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtBoxNumeroDireccion = new System.Windows.Forms.TextBox();
            this.lblPiso = new System.Windows.Forms.Label();
            this.txtBoxPiso = new System.Windows.Forms.TextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtBoxCiudad = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.txtBoxCodigoPostal = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.cmbBoxProvincia = new System.Windows.Forms.ComboBox();
            this.txtBoxDepartamento = new System.Windows.Forms.TextBox();
            this.dataGridViewDireccion = new System.Windows.Forms.DataGridView();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBoxContacto = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelContacto = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelListaNumeroTelefono = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuitarNumeroTelefono = new System.Windows.Forms.Button();
            this.lstViewNumeroTelefono = new System.Windows.Forms.ListView();
            this.tblLayoutPanelNumeroTelefono = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregarNumeroTelefono = new System.Windows.Forms.Button();
            this.txtBoxNumeroTelefono = new System.Windows.Forms.TextBox();
            this.lblNumeroTelefono = new System.Windows.Forms.Label();
            this.cmbBoxTipoNumeroTelefono = new System.Windows.Forms.ComboBox();
            this.tblLayoutPanelMail = new System.Windows.Forms.TableLayoutPanel();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.btnAgregarMail = new System.Windows.Forms.Button();
            this.tblLayoutPanelListaMail = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuitarMail = new System.Windows.Forms.Button();
            this.lstViewMail = new System.Windows.Forms.ListView();
            this.btnMasDatos = new System.Windows.Forms.Button();
            this.menuStripABM.SuspendLayout();
            this.tblLayoutPanelDatos.SuspendLayout();
            this.grpBoxTipoEntidad.SuspendLayout();
            this.pnlTipoEntidad.SuspendLayout();
            this.grpBoxObservaciones.SuspendLayout();
            this.grpBoxDatosPersonales.SuspendLayout();
            this.tblLayoutPanelDatosPersonales.SuspendLayout();
            this.grpBoxDomicilio.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblLayoutPanelDireccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDireccion)).BeginInit();
            this.grpBoxContacto.SuspendLayout();
            this.tblLayoutPanelContacto.SuspendLayout();
            this.tblLayoutPanelListaNumeroTelefono.SuspendLayout();
            this.tblLayoutPanelNumeroTelefono.SuspendLayout();
            this.tblLayoutPanelMail.SuspendLayout();
            this.tblLayoutPanelListaMail.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripABM
            // 
            this.menuStripABM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNuevo,
            this.toolStripMenuItemEliminar,
            this.toolStripMenuItemBuscar,
            this.toolStripMenuItemGuardar,
            this.toolStripMenuItemCancelar});
            this.menuStripABM.Location = new System.Drawing.Point(0, 0);
            this.menuStripABM.Name = "menuStripABM";
            this.menuStripABM.Size = new System.Drawing.Size(732, 24);
            this.menuStripABM.TabIndex = 0;
            this.menuStripABM.Text = "menuStrip1";
            // 
            // toolStripMenuItemNuevo
            // 
            this.toolStripMenuItemNuevo.Name = "toolStripMenuItemNuevo";
            this.toolStripMenuItemNuevo.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItemNuevo.Text = "Nuevo";
            this.toolStripMenuItemNuevo.Click += new System.EventHandler(this.toolStripMenuItemNuevo_Click);
            // 
            // toolStripMenuItemEliminar
            // 
            this.toolStripMenuItemEliminar.Name = "toolStripMenuItemEliminar";
            this.toolStripMenuItemEliminar.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItemEliminar.Text = "Eliminar";
            // 
            // toolStripMenuItemBuscar
            // 
            this.toolStripMenuItemBuscar.Name = "toolStripMenuItemBuscar";
            this.toolStripMenuItemBuscar.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItemBuscar.Text = "Buscar";
            // 
            // toolStripMenuItemGuardar
            // 
            this.toolStripMenuItemGuardar.Name = "toolStripMenuItemGuardar";
            this.toolStripMenuItemGuardar.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItemGuardar.Text = "Guardar";
            // 
            // toolStripMenuItemCancelar
            // 
            this.toolStripMenuItemCancelar.Name = "toolStripMenuItemCancelar";
            this.toolStripMenuItemCancelar.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItemCancelar.Text = "Cancelar";
            this.toolStripMenuItemCancelar.Click += new System.EventHandler(this.toolStripMenuItemCancelar_Click);
            // 
            // tblLayoutPanelDatos
            // 
            this.tblLayoutPanelDatos.ColumnCount = 1;
            this.tblLayoutPanelDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDatos.Controls.Add(this.grpBoxTipoEntidad, 0, 0);
            this.tblLayoutPanelDatos.Controls.Add(this.grpBoxObservaciones, 0, 4);
            this.tblLayoutPanelDatos.Controls.Add(this.grpBoxDatosPersonales, 0, 1);
            this.tblLayoutPanelDatos.Controls.Add(this.grpBoxDomicilio, 0, 2);
            this.tblLayoutPanelDatos.Controls.Add(this.grpBoxContacto, 0, 3);
            this.tblLayoutPanelDatos.Controls.Add(this.btnMasDatos, 0, 5);
            this.tblLayoutPanelDatos.Location = new System.Drawing.Point(12, 27);
            this.tblLayoutPanelDatos.Name = "tblLayoutPanelDatos";
            this.tblLayoutPanelDatos.RowCount = 6;
            this.tblLayoutPanelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tblLayoutPanelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLayoutPanelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tblLayoutPanelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tblLayoutPanelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tblLayoutPanelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tblLayoutPanelDatos.Size = new System.Drawing.Size(701, 707);
            this.tblLayoutPanelDatos.TabIndex = 4;
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
            this.radioButtonContactoProveedor.TabIndex = 14;
            this.radioButtonContactoProveedor.TabStop = true;
            this.radioButtonContactoProveedor.Text = "Contacto de Proveedor";
            this.radioButtonContactoProveedor.UseVisualStyleBackColor = true;
            // 
            // radioButtonProveedor
            // 
            this.radioButtonProveedor.AutoSize = true;
            this.radioButtonProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonProveedor.Location = new System.Drawing.Point(127, 7);
            this.radioButtonProveedor.Name = "radioButtonProveedor";
            this.radioButtonProveedor.Size = new System.Drawing.Size(95, 22);
            this.radioButtonProveedor.TabIndex = 13;
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
            this.radioButtonUsuario.TabIndex = 12;
            this.radioButtonUsuario.TabStop = true;
            this.radioButtonUsuario.Text = "Usuario de Sistema";
            this.radioButtonUsuario.UseVisualStyleBackColor = true;
            // 
            // radioButtonCliente
            // 
            this.radioButtonCliente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonCliente.AutoSize = true;
            this.radioButtonCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCliente.Location = new System.Drawing.Point(9, 7);
            this.radioButtonCliente.Name = "radioButtonCliente";
            this.radioButtonCliente.Size = new System.Drawing.Size(71, 22);
            this.radioButtonCliente.TabIndex = 10;
            this.radioButtonCliente.TabStop = true;
            this.radioButtonCliente.Text = "Cliente";
            this.radioButtonCliente.UseVisualStyleBackColor = true;
            this.radioButtonCliente.CheckedChanged += new System.EventHandler(this.radioButtonCliente_CheckedChanged);
            // 
            // grpBoxObservaciones
            // 
            this.grpBoxObservaciones.Controls.Add(this.rchTextBoxObservaciones);
            this.grpBoxObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.rchTextBoxObservaciones.TabIndex = 1;
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
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.txtBoxCodigo, 1, 0);
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
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigo.Location = new System.Drawing.Point(66, 3);
            this.txtBoxCodigo.Name = "txtBoxCodigo";
            this.txtBoxCodigo.Size = new System.Drawing.Size(152, 24);
            this.txtBoxCodigo.TabIndex = 5;
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
            this.tableLayoutPanel1.Controls.Add(this.tblLayoutPanelDireccion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewDireccion, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.98895F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.01105F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(689, 181);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tblLayoutPanelDireccion
            // 
            this.tblLayoutPanelDireccion.ColumnCount = 8;
            this.tblLayoutPanelDireccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.58427F));
            this.tblLayoutPanelDireccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.41573F));
            this.tblLayoutPanelDireccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tblLayoutPanelDireccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tblLayoutPanelDireccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tblLayoutPanelDireccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tblLayoutPanelDireccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tblLayoutPanelDireccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblLayoutPanelDireccion.Controls.Add(this.btnQuitarDireccion, 7, 1);
            this.tblLayoutPanelDireccion.Controls.Add(this.btnAgregarDireccion, 6, 1);
            this.tblLayoutPanelDireccion.Controls.Add(this.lblCalle, 0, 0);
            this.tblLayoutPanelDireccion.Controls.Add(this.txtBoxCalle, 1, 0);
            this.tblLayoutPanelDireccion.Controls.Add(this.lblNumero, 2, 0);
            this.tblLayoutPanelDireccion.Controls.Add(this.txtBoxNumeroDireccion, 3, 0);
            this.tblLayoutPanelDireccion.Controls.Add(this.lblPiso, 4, 0);
            this.tblLayoutPanelDireccion.Controls.Add(this.txtBoxPiso, 5, 0);
            this.tblLayoutPanelDireccion.Controls.Add(this.lblDepartamento, 6, 0);
            this.tblLayoutPanelDireccion.Controls.Add(this.txtBoxCiudad, 3, 1);
            this.tblLayoutPanelDireccion.Controls.Add(this.lblCiudad, 2, 1);
            this.tblLayoutPanelDireccion.Controls.Add(this.lblCodigoPostal, 0, 1);
            this.tblLayoutPanelDireccion.Controls.Add(this.txtBoxCodigoPostal, 1, 1);
            this.tblLayoutPanelDireccion.Controls.Add(this.lblProvincia, 4, 1);
            this.tblLayoutPanelDireccion.Controls.Add(this.cmbBoxProvincia, 5, 1);
            this.tblLayoutPanelDireccion.Controls.Add(this.txtBoxDepartamento, 7, 0);
            this.tblLayoutPanelDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDireccion.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelDireccion.Name = "tblLayoutPanelDireccion";
            this.tblLayoutPanelDireccion.RowCount = 2;
            this.tblLayoutPanelDireccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.72414F));
            this.tblLayoutPanelDireccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.27586F));
            this.tblLayoutPanelDireccion.Size = new System.Drawing.Size(683, 69);
            this.tblLayoutPanelDireccion.TabIndex = 0;
            // 
            // btnQuitarDireccion
            // 
            this.btnQuitarDireccion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnQuitarDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarDireccion.Location = new System.Drawing.Point(636, 41);
            this.btnQuitarDireccion.Name = "btnQuitarDireccion";
            this.btnQuitarDireccion.Size = new System.Drawing.Size(22, 22);
            this.btnQuitarDireccion.TabIndex = 16;
            this.btnQuitarDireccion.UseVisualStyleBackColor = true;
            this.btnQuitarDireccion.Click += new System.EventHandler(this.btnQuitarDireccion_Click);
            // 
            // btnAgregarDireccion
            // 
            this.btnAgregarDireccion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregarDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDireccion.Location = new System.Drawing.Point(608, 41);
            this.btnAgregarDireccion.Name = "btnAgregarDireccion";
            this.btnAgregarDireccion.Size = new System.Drawing.Size(22, 22);
            this.btnAgregarDireccion.TabIndex = 15;
            this.btnAgregarDireccion.UseVisualStyleBackColor = true;
            this.btnAgregarDireccion.Click += new System.EventHandler(this.btnAgregarDireccion_Click);
            // 
            // lblCalle
            // 
            this.lblCalle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(12, 9);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(43, 17);
            this.lblCalle.TabIndex = 1;
            this.lblCalle.Text = "Calle:";
            // 
            // txtBoxCalle
            // 
            this.txtBoxCalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCalle.Location = new System.Drawing.Point(61, 5);
            this.txtBoxCalle.Name = "txtBoxCalle";
            this.txtBoxCalle.Size = new System.Drawing.Size(114, 24);
            this.txtBoxCalle.TabIndex = 8;
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(183, 9);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(62, 17);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Número:";
            // 
            // txtBoxNumeroDireccion
            // 
            this.txtBoxNumeroDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNumeroDireccion.Location = new System.Drawing.Point(251, 5);
            this.txtBoxNumeroDireccion.Name = "txtBoxNumeroDireccion";
            this.txtBoxNumeroDireccion.Size = new System.Drawing.Size(92, 24);
            this.txtBoxNumeroDireccion.TabIndex = 9;
            // 
            // lblPiso
            // 
            this.lblPiso.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPiso.AutoSize = true;
            this.lblPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiso.Location = new System.Drawing.Point(382, 9);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(39, 17);
            this.lblPiso.TabIndex = 2;
            this.lblPiso.Text = "Piso:";
            // 
            // txtBoxPiso
            // 
            this.txtBoxPiso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPiso.Location = new System.Drawing.Point(427, 5);
            this.txtBoxPiso.Name = "txtBoxPiso";
            this.txtBoxPiso.Size = new System.Drawing.Size(91, 24);
            this.txtBoxPiso.TabIndex = 10;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(528, 9);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(102, 17);
            this.lblDepartamento.TabIndex = 7;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // txtBoxCiudad
            // 
            this.txtBoxCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCiudad.Location = new System.Drawing.Point(251, 40);
            this.txtBoxCiudad.Name = "txtBoxCiudad";
            this.txtBoxCiudad.Size = new System.Drawing.Size(92, 24);
            this.txtBoxCiudad.TabIndex = 13;
            // 
            // lblCiudad
            // 
            this.lblCiudad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(189, 43);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(56, 17);
            this.lblCiudad.TabIndex = 5;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPostal.Location = new System.Drawing.Point(3, 35);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(52, 34);
            this.lblCodigoPostal.TabIndex = 4;
            this.lblCodigoPostal.Text = "Código Postal:";
            // 
            // txtBoxCodigoPostal
            // 
            this.txtBoxCodigoPostal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoPostal.Location = new System.Drawing.Point(61, 40);
            this.txtBoxCodigoPostal.Name = "txtBoxCodigoPostal";
            this.txtBoxCodigoPostal.Size = new System.Drawing.Size(114, 24);
            this.txtBoxCodigoPostal.TabIndex = 12;
            // 
            // lblProvincia
            // 
            this.lblProvincia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(351, 43);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(70, 17);
            this.lblProvincia.TabIndex = 6;
            this.lblProvincia.Text = "Provincia:";
            // 
            // cmbBoxProvincia
            // 
            this.cmbBoxProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxProvincia.FormattingEnabled = true;
            this.cmbBoxProvincia.Items.AddRange(new object[] {
            "Buenos Aires",
            "Córdoba",
            "Corrientes",
            "Tucumán",
            "Santa Cruz",
            "Santa Fe",
            ""});
            this.cmbBoxProvincia.Location = new System.Drawing.Point(427, 39);
            this.cmbBoxProvincia.Name = "cmbBoxProvincia";
            this.cmbBoxProvincia.Size = new System.Drawing.Size(91, 26);
            this.cmbBoxProvincia.TabIndex = 14;
            // 
            // txtBoxDepartamento
            // 
            this.txtBoxDepartamento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxDepartamento.Location = new System.Drawing.Point(636, 5);
            this.txtBoxDepartamento.Name = "txtBoxDepartamento";
            this.txtBoxDepartamento.Size = new System.Drawing.Size(34, 24);
            this.txtBoxDepartamento.TabIndex = 11;
            // 
            // dataGridViewDireccion
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDireccion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDireccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDireccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.calle,
            this.numero,
            this.piso,
            this.departamento,
            this.codigoPostal,
            this.ciudad,
            this.provincia});
            this.dataGridViewDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDireccion.Location = new System.Drawing.Point(3, 78);
            this.dataGridViewDireccion.Name = "dataGridViewDireccion";
            this.dataGridViewDireccion.ReadOnly = true;
            this.dataGridViewDireccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDireccion.Size = new System.Drawing.Size(683, 100);
            this.dataGridViewDireccion.TabIndex = 1;
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
            // provincia
            // 
            this.provincia.HeaderText = "Provincia";
            this.provincia.Name = "provincia";
            this.provincia.ReadOnly = true;
            this.provincia.Width = 110;
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
            this.tblLayoutPanelContacto.Controls.Add(this.tblLayoutPanelListaNumeroTelefono, 1, 1);
            this.tblLayoutPanelContacto.Controls.Add(this.tblLayoutPanelNumeroTelefono, 1, 0);
            this.tblLayoutPanelContacto.Controls.Add(this.tblLayoutPanelMail, 0, 0);
            this.tblLayoutPanelContacto.Controls.Add(this.tblLayoutPanelListaMail, 0, 1);
            this.tblLayoutPanelContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelContacto.Location = new System.Drawing.Point(3, 20);
            this.tblLayoutPanelContacto.Name = "tblLayoutPanelContacto";
            this.tblLayoutPanelContacto.RowCount = 2;
            this.tblLayoutPanelContacto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.63636F));
            this.tblLayoutPanelContacto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.36364F));
            this.tblLayoutPanelContacto.Size = new System.Drawing.Size(689, 111);
            this.tblLayoutPanelContacto.TabIndex = 0;
            // 
            // tblLayoutPanelListaNumeroTelefono
            // 
            this.tblLayoutPanelListaNumeroTelefono.ColumnCount = 2;
            this.tblLayoutPanelListaNumeroTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelListaNumeroTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tblLayoutPanelListaNumeroTelefono.Controls.Add(this.btnQuitarNumeroTelefono, 1, 0);
            this.tblLayoutPanelListaNumeroTelefono.Controls.Add(this.lstViewNumeroTelefono, 0, 0);
            this.tblLayoutPanelListaNumeroTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelListaNumeroTelefono.Location = new System.Drawing.Point(378, 51);
            this.tblLayoutPanelListaNumeroTelefono.Name = "tblLayoutPanelListaNumeroTelefono";
            this.tblLayoutPanelListaNumeroTelefono.RowCount = 1;
            this.tblLayoutPanelListaNumeroTelefono.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelListaNumeroTelefono.Size = new System.Drawing.Size(308, 57);
            this.tblLayoutPanelListaNumeroTelefono.TabIndex = 3;
            // 
            // btnQuitarNumeroTelefono
            // 
            this.btnQuitarNumeroTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarNumeroTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarNumeroTelefono.Location = new System.Drawing.Point(280, 17);
            this.btnQuitarNumeroTelefono.Name = "btnQuitarNumeroTelefono";
            this.btnQuitarNumeroTelefono.Size = new System.Drawing.Size(25, 22);
            this.btnQuitarNumeroTelefono.TabIndex = 11;
            this.btnQuitarNumeroTelefono.UseVisualStyleBackColor = true;
            this.btnQuitarNumeroTelefono.Click += new System.EventHandler(this.btnQuitarNumeroTelefono_Click);
            // 
            // lstViewNumeroTelefono
            // 
            this.lstViewNumeroTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstViewNumeroTelefono.FullRowSelect = true;
            this.lstViewNumeroTelefono.Location = new System.Drawing.Point(3, 3);
            this.lstViewNumeroTelefono.Name = "lstViewNumeroTelefono";
            this.lstViewNumeroTelefono.Size = new System.Drawing.Size(271, 51);
            this.lstViewNumeroTelefono.TabIndex = 12;
            this.lstViewNumeroTelefono.UseCompatibleStateImageBehavior = false;
            // 
            // tblLayoutPanelNumeroTelefono
            // 
            this.tblLayoutPanelNumeroTelefono.ColumnCount = 4;
            this.tblLayoutPanelNumeroTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblLayoutPanelNumeroTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.48148F));
            this.tblLayoutPanelNumeroTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.51852F));
            this.tblLayoutPanelNumeroTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblLayoutPanelNumeroTelefono.Controls.Add(this.btnAgregarNumeroTelefono, 3, 0);
            this.tblLayoutPanelNumeroTelefono.Controls.Add(this.txtBoxNumeroTelefono, 2, 0);
            this.tblLayoutPanelNumeroTelefono.Controls.Add(this.lblNumeroTelefono, 1, 0);
            this.tblLayoutPanelNumeroTelefono.Controls.Add(this.cmbBoxTipoNumeroTelefono, 0, 0);
            this.tblLayoutPanelNumeroTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelNumeroTelefono.Location = new System.Drawing.Point(378, 3);
            this.tblLayoutPanelNumeroTelefono.Name = "tblLayoutPanelNumeroTelefono";
            this.tblLayoutPanelNumeroTelefono.RowCount = 1;
            this.tblLayoutPanelNumeroTelefono.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelNumeroTelefono.Size = new System.Drawing.Size(308, 42);
            this.tblLayoutPanelNumeroTelefono.TabIndex = 2;
            // 
            // btnAgregarNumeroTelefono
            // 
            this.btnAgregarNumeroTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarNumeroTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNumeroTelefono.Location = new System.Drawing.Point(277, 13);
            this.btnAgregarNumeroTelefono.Name = "btnAgregarNumeroTelefono";
            this.btnAgregarNumeroTelefono.Size = new System.Drawing.Size(28, 16);
            this.btnAgregarNumeroTelefono.TabIndex = 10;
            this.btnAgregarNumeroTelefono.UseVisualStyleBackColor = true;
            this.btnAgregarNumeroTelefono.Click += new System.EventHandler(this.btnAgregarNumeroTelefono_Click);
            // 
            // txtBoxNumeroTelefono
            // 
            this.txtBoxNumeroTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNumeroTelefono.Location = new System.Drawing.Point(130, 9);
            this.txtBoxNumeroTelefono.Name = "txtBoxNumeroTelefono";
            this.txtBoxNumeroTelefono.Size = new System.Drawing.Size(141, 24);
            this.txtBoxNumeroTelefono.TabIndex = 8;
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTelefono.Location = new System.Drawing.Point(63, 4);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(58, 34);
            this.lblNumeroTelefono.TabIndex = 9;
            this.lblNumeroTelefono.Text = "Número:";
            // 
            // cmbBoxTipoNumeroTelefono
            // 
            this.cmbBoxTipoNumeroTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxTipoNumeroTelefono.FormattingEnabled = true;
            this.cmbBoxTipoNumeroTelefono.Items.AddRange(new object[] {
            "TEL",
            "CEL",
            "FAX"});
            this.cmbBoxTipoNumeroTelefono.Location = new System.Drawing.Point(3, 8);
            this.cmbBoxTipoNumeroTelefono.Name = "cmbBoxTipoNumeroTelefono";
            this.cmbBoxTipoNumeroTelefono.Size = new System.Drawing.Size(54, 26);
            this.cmbBoxTipoNumeroTelefono.TabIndex = 11;
            // 
            // tblLayoutPanelMail
            // 
            this.tblLayoutPanelMail.ColumnCount = 3;
            this.tblLayoutPanelMail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.47896F));
            this.tblLayoutPanelMail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.52103F));
            this.tblLayoutPanelMail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLayoutPanelMail.Controls.Add(this.lblMail, 0, 0);
            this.tblLayoutPanelMail.Controls.Add(this.txtBoxMail, 1, 0);
            this.tblLayoutPanelMail.Controls.Add(this.btnAgregarMail, 2, 0);
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
            this.txtBoxMail.Location = new System.Drawing.Point(96, 9);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(229, 24);
            this.txtBoxMail.TabIndex = 8;
            // 
            // btnAgregarMail
            // 
            this.btnAgregarMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMail.Location = new System.Drawing.Point(331, 13);
            this.btnAgregarMail.Name = "btnAgregarMail";
            this.btnAgregarMail.Size = new System.Drawing.Size(35, 16);
            this.btnAgregarMail.TabIndex = 10;
            this.btnAgregarMail.UseVisualStyleBackColor = true;
            this.btnAgregarMail.Click += new System.EventHandler(this.btnAgregarMail_Click);
            // 
            // tblLayoutPanelListaMail
            // 
            this.tblLayoutPanelListaMail.ColumnCount = 2;
            this.tblLayoutPanelListaMail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelListaMail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tblLayoutPanelListaMail.Controls.Add(this.btnQuitarMail, 1, 0);
            this.tblLayoutPanelListaMail.Controls.Add(this.lstViewMail, 0, 0);
            this.tblLayoutPanelListaMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelListaMail.Location = new System.Drawing.Point(3, 51);
            this.tblLayoutPanelListaMail.Name = "tblLayoutPanelListaMail";
            this.tblLayoutPanelListaMail.RowCount = 1;
            this.tblLayoutPanelListaMail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelListaMail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tblLayoutPanelListaMail.Size = new System.Drawing.Size(369, 57);
            this.tblLayoutPanelListaMail.TabIndex = 1;
            // 
            // btnQuitarMail
            // 
            this.btnQuitarMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarMail.Location = new System.Drawing.Point(333, 17);
            this.btnQuitarMail.Name = "btnQuitarMail";
            this.btnQuitarMail.Size = new System.Drawing.Size(33, 22);
            this.btnQuitarMail.TabIndex = 11;
            this.btnQuitarMail.UseVisualStyleBackColor = true;
            this.btnQuitarMail.Click += new System.EventHandler(this.btnQuitarMail_Click);
            // 
            // lstViewMail
            // 
            this.lstViewMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstViewMail.Location = new System.Drawing.Point(3, 3);
            this.lstViewMail.Name = "lstViewMail";
            this.lstViewMail.Size = new System.Drawing.Size(324, 51);
            this.lstViewMail.TabIndex = 12;
            this.lstViewMail.UseCompatibleStateImageBehavior = false;
            // 
            // btnMasDatos
            // 
            this.btnMasDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMasDatos.Enabled = false;
            this.btnMasDatos.Location = new System.Drawing.Point(313, 670);
            this.btnMasDatos.Name = "btnMasDatos";
            this.btnMasDatos.Size = new System.Drawing.Size(75, 23);
            this.btnMasDatos.TabIndex = 7;
            this.btnMasDatos.Text = "Más Datos";
            this.btnMasDatos.UseVisualStyleBackColor = true;
            this.btnMasDatos.Click += new System.EventHandler(this.btnMasDatos_Click);
            // 
            // frmABMEntidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 761);
            this.Controls.Add(this.tblLayoutPanelDatos);
            this.Controls.Add(this.menuStripABM);
            this.MainMenuStrip = this.menuStripABM;
            this.Name = "frmABMEntidad";
            this.Text = "ABM Entidades";
            this.menuStripABM.ResumeLayout(false);
            this.menuStripABM.PerformLayout();
            this.tblLayoutPanelDatos.ResumeLayout(false);
            this.grpBoxTipoEntidad.ResumeLayout(false);
            this.pnlTipoEntidad.ResumeLayout(false);
            this.pnlTipoEntidad.PerformLayout();
            this.grpBoxObservaciones.ResumeLayout(false);
            this.grpBoxDatosPersonales.ResumeLayout(false);
            this.tblLayoutPanelDatosPersonales.ResumeLayout(false);
            this.tblLayoutPanelDatosPersonales.PerformLayout();
            this.grpBoxDomicilio.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tblLayoutPanelDireccion.ResumeLayout(false);
            this.tblLayoutPanelDireccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDireccion)).EndInit();
            this.grpBoxContacto.ResumeLayout(false);
            this.tblLayoutPanelContacto.ResumeLayout(false);
            this.tblLayoutPanelListaNumeroTelefono.ResumeLayout(false);
            this.tblLayoutPanelNumeroTelefono.ResumeLayout(false);
            this.tblLayoutPanelNumeroTelefono.PerformLayout();
            this.tblLayoutPanelMail.ResumeLayout(false);
            this.tblLayoutPanelMail.PerformLayout();
            this.tblLayoutPanelListaMail.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripABM;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNuevo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEliminar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBuscar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGuardar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCancelar;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDatos;
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
        private System.Windows.Forms.TextBox txtBoxCodigo;
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
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDireccion;
        private System.Windows.Forms.Button btnQuitarDireccion;
        private System.Windows.Forms.Button btnAgregarDireccion;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtBoxCalle;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtBoxNumeroDireccion;
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
        private System.Windows.Forms.DataGridView dataGridViewDireccion;
        private System.Windows.Forms.GroupBox grpBoxContacto;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelContacto;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelListaNumeroTelefono;
        private System.Windows.Forms.Button btnQuitarNumeroTelefono;
        private System.Windows.Forms.ListView lstViewNumeroTelefono;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelNumeroTelefono;
        private System.Windows.Forms.Button btnAgregarNumeroTelefono;
        private System.Windows.Forms.TextBox txtBoxNumeroTelefono;
        private System.Windows.Forms.Label lblNumeroTelefono;
        private System.Windows.Forms.ComboBox cmbBoxTipoNumeroTelefono;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.Button btnAgregarMail;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelListaMail;
        private System.Windows.Forms.Button btnQuitarMail;
        private System.Windows.Forms.ListView lstViewMail;
        private System.Windows.Forms.Button btnMasDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn provincia;
    }
}