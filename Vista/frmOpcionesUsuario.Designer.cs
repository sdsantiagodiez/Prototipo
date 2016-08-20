namespace Vista
{
    partial class frmOpcionesUsuario
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
            this.btnGuardarCambios = new MaterialSkin.Controls.MaterialRaisedButton();
            this.selectorControlPrincipal = new MaterialSkin.Controls.MaterialTabSelector();
            this.tbControlPrincipal = new MaterialSkin.Controls.MaterialTabControl();
            this.tbPageDatosGenerales = new System.Windows.Forms.TabPage();
            this.tblLayoutPanelDatosGenerales = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelDatosPersonales = new System.Windows.Forms.TableLayoutPanel();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.txtBoxCUIT = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtBoxDNI = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtBoxApellido = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.grpBoxContraseña = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelContraseña = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblContraseñaActual = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxContraseñaActual = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxContraseñaNueva = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxContraseñaNuevaRepetir = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbPageDatosContacto = new System.Windows.Forms.TabPage();
            this.pnlDatosContacto = new System.Windows.Forms.Panel();
            this.tblLayoutPanelDatosContacto = new System.Windows.Forms.TableLayoutPanel();
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
            this.grpBoxDomicilio = new System.Windows.Forms.GroupBox();
            this.tbEstiloVisual = new System.Windows.Forms.TabPage();
            this.pnlBase.SuspendLayout();
            this.tblLayoutPanelPrincipal.SuspendLayout();
            this.tbControlPrincipal.SuspendLayout();
            this.tbPageDatosGenerales.SuspendLayout();
            this.tblLayoutPanelDatosGenerales.SuspendLayout();
            this.grpBoxDatosPersonales.SuspendLayout();
            this.tblLayoutPanelDatosPersonales.SuspendLayout();
            this.grpBoxContraseña.SuspendLayout();
            this.tblLayoutPanelContraseña.SuspendLayout();
            this.tbPageDatosContacto.SuspendLayout();
            this.pnlDatosContacto.SuspendLayout();
            this.tblLayoutPanelDatosContacto.SuspendLayout();
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
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.tblLayoutPanelPrincipal);
            this.pnlBase.Location = new System.Drawing.Point(12, 72);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(741, 515);
            this.pnlBase.TabIndex = 0;
            // 
            // tblLayoutPanelPrincipal
            // 
            this.tblLayoutPanelPrincipal.ColumnCount = 1;
            this.tblLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal.Controls.Add(this.btnGuardarCambios, 0, 2);
            this.tblLayoutPanelPrincipal.Controls.Add(this.selectorControlPrincipal, 0, 0);
            this.tblLayoutPanelPrincipal.Controls.Add(this.tbControlPrincipal, 0, 1);
            this.tblLayoutPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanelPrincipal.Name = "tblLayoutPanelPrincipal";
            this.tblLayoutPanelPrincipal.RowCount = 3;
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblLayoutPanelPrincipal.Size = new System.Drawing.Size(741, 515);
            this.tblLayoutPanelPrincipal.TabIndex = 0;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarCambios.Depth = 0;
            this.btnGuardarCambios.Location = new System.Drawing.Point(315, 470);
            this.btnGuardarCambios.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Primary = true;
            this.btnGuardarCambios.Size = new System.Drawing.Size(110, 40);
            this.btnGuardarCambios.TabIndex = 10;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // selectorControlPrincipal
            // 
            this.selectorControlPrincipal.BaseTabControl = this.tbControlPrincipal;
            this.selectorControlPrincipal.Depth = 0;
            this.selectorControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectorControlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.selectorControlPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.selectorControlPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.selectorControlPrincipal.Name = "selectorControlPrincipal";
            this.selectorControlPrincipal.Size = new System.Drawing.Size(741, 40);
            this.selectorControlPrincipal.TabIndex = 1;
            this.selectorControlPrincipal.Text = "materialTabSelector1";
            // 
            // tbControlPrincipal
            // 
            this.tbControlPrincipal.Controls.Add(this.tbPageDatosGenerales);
            this.tbControlPrincipal.Controls.Add(this.tbPageDatosContacto);
            this.tbControlPrincipal.Controls.Add(this.tbEstiloVisual);
            this.tbControlPrincipal.Depth = 0;
            this.tbControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControlPrincipal.Location = new System.Drawing.Point(3, 43);
            this.tbControlPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbControlPrincipal.Name = "tbControlPrincipal";
            this.tbControlPrincipal.SelectedIndex = 0;
            this.tbControlPrincipal.Size = new System.Drawing.Size(735, 419);
            this.tbControlPrincipal.TabIndex = 2;
            // 
            // tbPageDatosGenerales
            // 
            this.tbPageDatosGenerales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbPageDatosGenerales.Controls.Add(this.tblLayoutPanelDatosGenerales);
            this.tbPageDatosGenerales.Location = new System.Drawing.Point(4, 22);
            this.tbPageDatosGenerales.Name = "tbPageDatosGenerales";
            this.tbPageDatosGenerales.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageDatosGenerales.Size = new System.Drawing.Size(727, 393);
            this.tbPageDatosGenerales.TabIndex = 0;
            this.tbPageDatosGenerales.Text = "Datos Generales";
            // 
            // tblLayoutPanelDatosGenerales
            // 
            this.tblLayoutPanelDatosGenerales.ColumnCount = 1;
            this.tblLayoutPanelDatosGenerales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDatosGenerales.Controls.Add(this.grpBoxDatosPersonales, 0, 0);
            this.tblLayoutPanelDatosGenerales.Controls.Add(this.grpBoxContraseña, 0, 1);
            this.tblLayoutPanelDatosGenerales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDatosGenerales.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelDatosGenerales.Name = "tblLayoutPanelDatosGenerales";
            this.tblLayoutPanelDatosGenerales.RowCount = 3;
            this.tblLayoutPanelDatosGenerales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tblLayoutPanelDatosGenerales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tblLayoutPanelDatosGenerales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tblLayoutPanelDatosGenerales.Size = new System.Drawing.Size(721, 387);
            this.tblLayoutPanelDatosGenerales.TabIndex = 0;
            // 
            // grpBoxDatosPersonales
            // 
            this.grpBoxDatosPersonales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grpBoxDatosPersonales.Controls.Add(this.tblLayoutPanelDatosPersonales);
            this.grpBoxDatosPersonales.Location = new System.Drawing.Point(138, 3);
            this.grpBoxDatosPersonales.Name = "grpBoxDatosPersonales";
            this.grpBoxDatosPersonales.Size = new System.Drawing.Size(445, 204);
            this.grpBoxDatosPersonales.TabIndex = 1;
            this.grpBoxDatosPersonales.TabStop = false;
            this.grpBoxDatosPersonales.Text = "Datos Personales";
            // 
            // tblLayoutPanelDatosPersonales
            // 
            this.tblLayoutPanelDatosPersonales.ColumnCount = 2;
            this.tblLayoutPanelDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLayoutPanelDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.lblCUIT, 0, 0);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.txtBoxCUIT, 1, 0);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.lblDNI, 0, 1);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.txtBoxDNI, 1, 1);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.txtBoxNombre, 1, 2);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.lblNombre, 0, 2);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.lblApellido, 0, 3);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.txtBoxApellido, 1, 3);
            this.tblLayoutPanelDatosPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDatosPersonales.Location = new System.Drawing.Point(3, 16);
            this.tblLayoutPanelDatosPersonales.Name = "tblLayoutPanelDatosPersonales";
            this.tblLayoutPanelDatosPersonales.RowCount = 4;
            this.tblLayoutPanelDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelDatosPersonales.Size = new System.Drawing.Size(439, 185);
            this.tblLayoutPanelDatosPersonales.TabIndex = 0;
            // 
            // lblCUIT
            // 
            this.lblCUIT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUIT.Location = new System.Drawing.Point(74, 14);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(43, 17);
            this.lblCUIT.TabIndex = 15;
            this.lblCUIT.Text = "CUIT:";
            // 
            // txtBoxCUIT
            // 
            this.txtBoxCUIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCUIT.Depth = 0;
            this.txtBoxCUIT.Hint = "";
            this.txtBoxCUIT.Location = new System.Drawing.Point(123, 11);
            this.txtBoxCUIT.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtBoxCUIT.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCUIT.Name = "txtBoxCUIT";
            this.txtBoxCUIT.PasswordChar = '\0';
            this.txtBoxCUIT.SelectedText = "";
            this.txtBoxCUIT.SelectionLength = 0;
            this.txtBoxCUIT.SelectionStart = 0;
            this.txtBoxCUIT.Size = new System.Drawing.Size(301, 23);
            this.txtBoxCUIT.TabIndex = 16;
            this.txtBoxCUIT.UseSystemPasswordChar = false;
            // 
            // lblDNI
            // 
            this.lblDNI.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(82, 60);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(35, 17);
            this.lblDNI.TabIndex = 17;
            this.lblDNI.Text = "DNI:";
            // 
            // txtBoxDNI
            // 
            this.txtBoxDNI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDNI.Depth = 0;
            this.txtBoxDNI.Hint = "";
            this.txtBoxDNI.Location = new System.Drawing.Point(123, 57);
            this.txtBoxDNI.Margin = new System.Windows.Forms.Padding(3, 3, 26, 3);
            this.txtBoxDNI.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDNI.Name = "txtBoxDNI";
            this.txtBoxDNI.PasswordChar = '\0';
            this.txtBoxDNI.SelectedText = "";
            this.txtBoxDNI.SelectionLength = 0;
            this.txtBoxDNI.SelectionStart = 0;
            this.txtBoxDNI.Size = new System.Drawing.Size(290, 23);
            this.txtBoxDNI.TabIndex = 18;
            this.txtBoxDNI.UseSystemPasswordChar = false;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNombre.Depth = 0;
            this.txtBoxNombre.Hint = "";
            this.txtBoxNombre.Location = new System.Drawing.Point(123, 103);
            this.txtBoxNombre.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtBoxNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.PasswordChar = '\0';
            this.txtBoxNombre.SelectedText = "";
            this.txtBoxNombre.SelectionLength = 0;
            this.txtBoxNombre.SelectionStart = 0;
            this.txtBoxNombre.Size = new System.Drawing.Size(301, 23);
            this.txtBoxNombre.TabIndex = 19;
            this.txtBoxNombre.UseSystemPasswordChar = false;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(55, 106);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(55, 153);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 17);
            this.lblApellido.TabIndex = 21;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxApellido.Depth = 0;
            this.txtBoxApellido.Hint = "";
            this.txtBoxApellido.Location = new System.Drawing.Point(123, 150);
            this.txtBoxApellido.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtBoxApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.PasswordChar = '\0';
            this.txtBoxApellido.SelectedText = "";
            this.txtBoxApellido.SelectionLength = 0;
            this.txtBoxApellido.SelectionStart = 0;
            this.txtBoxApellido.Size = new System.Drawing.Size(301, 23);
            this.txtBoxApellido.TabIndex = 22;
            this.txtBoxApellido.UseSystemPasswordChar = false;
            // 
            // grpBoxContraseña
            // 
            this.grpBoxContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grpBoxContraseña.Controls.Add(this.tblLayoutPanelContraseña);
            this.grpBoxContraseña.Location = new System.Drawing.Point(138, 213);
            this.grpBoxContraseña.Name = "grpBoxContraseña";
            this.grpBoxContraseña.Size = new System.Drawing.Size(445, 174);
            this.grpBoxContraseña.TabIndex = 2;
            this.grpBoxContraseña.TabStop = false;
            this.grpBoxContraseña.Text = "Contraseña";
            // 
            // tblLayoutPanelContraseña
            // 
            this.tblLayoutPanelContraseña.ColumnCount = 2;
            this.tblLayoutPanelContraseña.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLayoutPanelContraseña.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelContraseña.Controls.Add(this.label3, 0, 2);
            this.tblLayoutPanelContraseña.Controls.Add(this.lblContraseñaActual, 0, 0);
            this.tblLayoutPanelContraseña.Controls.Add(this.label2, 0, 1);
            this.tblLayoutPanelContraseña.Controls.Add(this.txtBoxContraseñaActual, 1, 0);
            this.tblLayoutPanelContraseña.Controls.Add(this.txtBoxContraseñaNueva, 1, 1);
            this.tblLayoutPanelContraseña.Controls.Add(this.txtBoxContraseñaNuevaRepetir, 1, 2);
            this.tblLayoutPanelContraseña.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelContraseña.Location = new System.Drawing.Point(3, 16);
            this.tblLayoutPanelContraseña.Name = "tblLayoutPanelContraseña";
            this.tblLayoutPanelContraseña.RowCount = 3;
            this.tblLayoutPanelContraseña.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelContraseña.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelContraseña.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelContraseña.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelContraseña.Size = new System.Drawing.Size(439, 155);
            this.tblLayoutPanelContraseña.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 34);
            this.label3.TabIndex = 18;
            this.label3.Text = "Repetir Nueva Contraseña:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblContraseñaActual
            // 
            this.lblContraseñaActual.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblContraseñaActual.AutoSize = true;
            this.lblContraseñaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaActual.Location = new System.Drawing.Point(36, 8);
            this.lblContraseñaActual.Name = "lblContraseñaActual";
            this.lblContraseñaActual.Size = new System.Drawing.Size(81, 34);
            this.lblContraseñaActual.TabIndex = 16;
            this.lblContraseñaActual.Text = "Contraseña Actual:";
            this.lblContraseñaActual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 34);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nueva Contraseña:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxContraseñaActual
            // 
            this.txtBoxContraseñaActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxContraseñaActual.Depth = 0;
            this.txtBoxContraseñaActual.Hint = "";
            this.txtBoxContraseñaActual.Location = new System.Drawing.Point(123, 14);
            this.txtBoxContraseñaActual.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtBoxContraseñaActual.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxContraseñaActual.Name = "txtBoxContraseñaActual";
            this.txtBoxContraseñaActual.PasswordChar = '\0';
            this.txtBoxContraseñaActual.SelectedText = "";
            this.txtBoxContraseñaActual.SelectionLength = 0;
            this.txtBoxContraseñaActual.SelectionStart = 0;
            this.txtBoxContraseñaActual.Size = new System.Drawing.Size(301, 23);
            this.txtBoxContraseñaActual.TabIndex = 20;
            this.txtBoxContraseñaActual.UseSystemPasswordChar = false;
            // 
            // txtBoxContraseñaNueva
            // 
            this.txtBoxContraseñaNueva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxContraseñaNueva.Depth = 0;
            this.txtBoxContraseñaNueva.Hint = "";
            this.txtBoxContraseñaNueva.Location = new System.Drawing.Point(123, 65);
            this.txtBoxContraseñaNueva.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtBoxContraseñaNueva.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxContraseñaNueva.Name = "txtBoxContraseñaNueva";
            this.txtBoxContraseñaNueva.PasswordChar = '\0';
            this.txtBoxContraseñaNueva.SelectedText = "";
            this.txtBoxContraseñaNueva.SelectionLength = 0;
            this.txtBoxContraseñaNueva.SelectionStart = 0;
            this.txtBoxContraseñaNueva.Size = new System.Drawing.Size(301, 23);
            this.txtBoxContraseñaNueva.TabIndex = 21;
            this.txtBoxContraseñaNueva.UseSystemPasswordChar = false;
            // 
            // txtBoxContraseñaNuevaRepetir
            // 
            this.txtBoxContraseñaNuevaRepetir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxContraseñaNuevaRepetir.Depth = 0;
            this.txtBoxContraseñaNuevaRepetir.Hint = "";
            this.txtBoxContraseñaNuevaRepetir.Location = new System.Drawing.Point(123, 117);
            this.txtBoxContraseñaNuevaRepetir.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtBoxContraseñaNuevaRepetir.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxContraseñaNuevaRepetir.Name = "txtBoxContraseñaNuevaRepetir";
            this.txtBoxContraseñaNuevaRepetir.PasswordChar = '\0';
            this.txtBoxContraseñaNuevaRepetir.SelectedText = "";
            this.txtBoxContraseñaNuevaRepetir.SelectionLength = 0;
            this.txtBoxContraseñaNuevaRepetir.SelectionStart = 0;
            this.txtBoxContraseñaNuevaRepetir.Size = new System.Drawing.Size(301, 23);
            this.txtBoxContraseñaNuevaRepetir.TabIndex = 22;
            this.txtBoxContraseñaNuevaRepetir.UseSystemPasswordChar = false;
            // 
            // tbPageDatosContacto
            // 
            this.tbPageDatosContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbPageDatosContacto.Controls.Add(this.pnlDatosContacto);
            this.tbPageDatosContacto.Location = new System.Drawing.Point(4, 22);
            this.tbPageDatosContacto.Name = "tbPageDatosContacto";
            this.tbPageDatosContacto.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageDatosContacto.Size = new System.Drawing.Size(727, 393);
            this.tbPageDatosContacto.TabIndex = 1;
            this.tbPageDatosContacto.Text = "Datos de Contacto";
            // 
            // pnlDatosContacto
            // 
            this.pnlDatosContacto.Controls.Add(this.tblLayoutPanelDatosContacto);
            this.pnlDatosContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatosContacto.Location = new System.Drawing.Point(3, 3);
            this.pnlDatosContacto.Name = "pnlDatosContacto";
            this.pnlDatosContacto.Size = new System.Drawing.Size(721, 387);
            this.pnlDatosContacto.TabIndex = 1;
            // 
            // tblLayoutPanelDatosContacto
            // 
            this.tblLayoutPanelDatosContacto.ColumnCount = 1;
            this.tblLayoutPanelDatosContacto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDatosContacto.Controls.Add(this.grpBoxContacto, 0, 1);
            this.tblLayoutPanelDatosContacto.Controls.Add(this.grpBoxDomicilio, 0, 0);
            this.tblLayoutPanelDatosContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDatosContacto.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanelDatosContacto.Name = "tblLayoutPanelDatosContacto";
            this.tblLayoutPanelDatosContacto.RowCount = 2;
            this.tblLayoutPanelDatosContacto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblLayoutPanelDatosContacto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLayoutPanelDatosContacto.Size = new System.Drawing.Size(721, 387);
            this.tblLayoutPanelDatosContacto.TabIndex = 0;
            // 
            // grpBoxContacto
            // 
            this.grpBoxContacto.Controls.Add(this.tblLayoutPanelContacto);
            this.grpBoxContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxContacto.Location = new System.Drawing.Point(3, 235);
            this.grpBoxContacto.Name = "grpBoxContacto";
            this.grpBoxContacto.Size = new System.Drawing.Size(715, 149);
            this.grpBoxContacto.TabIndex = 6;
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
            this.tblLayoutPanelContacto.Size = new System.Drawing.Size(709, 126);
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
            this.tblLayoutPanelTelefonoLista.Location = new System.Drawing.Point(389, 53);
            this.tblLayoutPanelTelefonoLista.Name = "tblLayoutPanelTelefonoLista";
            this.tblLayoutPanelTelefonoLista.RowCount = 1;
            this.tblLayoutPanelTelefonoLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelTelefonoLista.Size = new System.Drawing.Size(317, 70);
            this.tblLayoutPanelTelefonoLista.TabIndex = 3;
            // 
            // tblLayoutPanelTelefonoListaAgregarQuitar
            // 
            this.tblLayoutPanelTelefonoListaAgregarQuitar.ColumnCount = 1;
            this.tblLayoutPanelTelefonoListaAgregarQuitar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelTelefonoListaAgregarQuitar.Controls.Add(this.btnQuitarTelefono, 0, 1);
            this.tblLayoutPanelTelefonoListaAgregarQuitar.Controls.Add(this.btnAgregarTelefono, 0, 0);
            this.tblLayoutPanelTelefonoListaAgregarQuitar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelTelefonoListaAgregarQuitar.Location = new System.Drawing.Point(287, 3);
            this.tblLayoutPanelTelefonoListaAgregarQuitar.Name = "tblLayoutPanelTelefonoListaAgregarQuitar";
            this.tblLayoutPanelTelefonoListaAgregarQuitar.RowCount = 2;
            this.tblLayoutPanelTelefonoListaAgregarQuitar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelTelefonoListaAgregarQuitar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelTelefonoListaAgregarQuitar.Size = new System.Drawing.Size(27, 64);
            this.tblLayoutPanelTelefonoListaAgregarQuitar.TabIndex = 13;
            // 
            // btnQuitarTelefono
            // 
            this.btnQuitarTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuitarTelefono.AutoSize = true;
            this.btnQuitarTelefono.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuitarTelefono.Depth = 0;
            this.btnQuitarTelefono.Location = new System.Drawing.Point(5, 38);
            this.btnQuitarTelefono.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuitarTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitarTelefono.Name = "btnQuitarTelefono";
            this.btnQuitarTelefono.Primary = false;
            this.btnQuitarTelefono.Size = new System.Drawing.Size(16, 20);
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
            this.btnAgregarTelefono.Size = new System.Drawing.Size(19, 20);
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
            this.dataGridViewTelefono.Size = new System.Drawing.Size(278, 64);
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
            this.tblLayoutPanelTelefono.Location = new System.Drawing.Point(389, 3);
            this.tblLayoutPanelTelefono.Name = "tblLayoutPanelTelefono";
            this.tblLayoutPanelTelefono.RowCount = 1;
            this.tblLayoutPanelTelefono.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelTelefono.Size = new System.Drawing.Size(317, 44);
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
            this.txtBoxTelefono.Size = new System.Drawing.Size(156, 23);
            this.txtBoxTelefono.TabIndex = 24;
            this.txtBoxTelefono.UseSystemPasswordChar = false;
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
            this.tblLayoutPanelMail.Size = new System.Drawing.Size(380, 44);
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
            this.txtBoxMail.Size = new System.Drawing.Size(244, 23);
            this.txtBoxMail.TabIndex = 10;
            this.txtBoxMail.UseSystemPasswordChar = false;
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
            this.tblLayoutPanelMailLista.Size = new System.Drawing.Size(380, 70);
            this.tblLayoutPanelMailLista.TabIndex = 1;
            // 
            // tblLayoutPanelMailListaAgregarQuitar
            // 
            this.tblLayoutPanelMailListaAgregarQuitar.ColumnCount = 1;
            this.tblLayoutPanelMailListaAgregarQuitar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelMailListaAgregarQuitar.Controls.Add(this.btnAgregarMail, 0, 0);
            this.tblLayoutPanelMailListaAgregarQuitar.Controls.Add(this.btnQuitarMail, 0, 1);
            this.tblLayoutPanelMailListaAgregarQuitar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelMailListaAgregarQuitar.Location = new System.Drawing.Point(350, 3);
            this.tblLayoutPanelMailListaAgregarQuitar.Name = "tblLayoutPanelMailListaAgregarQuitar";
            this.tblLayoutPanelMailListaAgregarQuitar.RowCount = 2;
            this.tblLayoutPanelMailListaAgregarQuitar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelMailListaAgregarQuitar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelMailListaAgregarQuitar.Size = new System.Drawing.Size(27, 64);
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
            this.btnAgregarMail.Size = new System.Drawing.Size(19, 20);
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
            this.btnQuitarMail.Location = new System.Drawing.Point(5, 38);
            this.btnQuitarMail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuitarMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitarMail.Name = "btnQuitarMail";
            this.btnQuitarMail.Primary = false;
            this.btnQuitarMail.Size = new System.Drawing.Size(16, 20);
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
            this.dataGridViewMail.Size = new System.Drawing.Size(341, 64);
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
            // grpBoxDomicilio
            // 
            this.grpBoxDomicilio.AutoSize = true;
            this.grpBoxDomicilio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDomicilio.Location = new System.Drawing.Point(3, 3);
            this.grpBoxDomicilio.Name = "grpBoxDomicilio";
            this.grpBoxDomicilio.Size = new System.Drawing.Size(715, 226);
            this.grpBoxDomicilio.TabIndex = 5;
            this.grpBoxDomicilio.TabStop = false;
            this.grpBoxDomicilio.Text = "Domicilio";
            // 
            // tbEstiloVisual
            // 
            this.tbEstiloVisual.BackColor = System.Drawing.Color.White;
            this.tbEstiloVisual.Location = new System.Drawing.Point(4, 22);
            this.tbEstiloVisual.Name = "tbEstiloVisual";
            this.tbEstiloVisual.Padding = new System.Windows.Forms.Padding(3);
            this.tbEstiloVisual.Size = new System.Drawing.Size(727, 393);
            this.tbEstiloVisual.TabIndex = 2;
            this.tbEstiloVisual.Text = "Estilo Visual";
            // 
            // frmOpcionesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 645);
            this.Controls.Add(this.pnlBase);
            this.Name = "frmOpcionesUsuario";
            this.Text = "f";
            this.pnlBase.ResumeLayout(false);
            this.tblLayoutPanelPrincipal.ResumeLayout(false);
            this.tbControlPrincipal.ResumeLayout(false);
            this.tbPageDatosGenerales.ResumeLayout(false);
            this.tblLayoutPanelDatosGenerales.ResumeLayout(false);
            this.grpBoxDatosPersonales.ResumeLayout(false);
            this.tblLayoutPanelDatosPersonales.ResumeLayout(false);
            this.tblLayoutPanelDatosPersonales.PerformLayout();
            this.grpBoxContraseña.ResumeLayout(false);
            this.tblLayoutPanelContraseña.ResumeLayout(false);
            this.tblLayoutPanelContraseña.PerformLayout();
            this.tbPageDatosContacto.ResumeLayout(false);
            this.pnlDatosContacto.ResumeLayout(false);
            this.tblLayoutPanelDatosContacto.ResumeLayout(false);
            this.tblLayoutPanelDatosContacto.PerformLayout();
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelPrincipal;
        private MaterialSkin.Controls.MaterialTabSelector selectorControlPrincipal;
        private MaterialSkin.Controls.MaterialTabControl tbControlPrincipal;
        private System.Windows.Forms.TabPage tbPageDatosGenerales;
        private System.Windows.Forms.TabPage tbPageDatosContacto;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDatosGenerales;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDatosContacto;
        private System.Windows.Forms.GroupBox grpBoxDomicilio;
        private System.Windows.Forms.GroupBox grpBoxContacto;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelContacto;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelTelefonoLista;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelTelefonoListaAgregarQuitar;
        private MaterialSkin.Controls.MaterialFlatButton btnQuitarTelefono;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregarTelefono;
        private System.Windows.Forms.DataGridView dataGridViewTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTelefono;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.ComboBox cmbBoxTipoTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxTelefono;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelMail;
        private System.Windows.Forms.Label lblMail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxMail;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelMailLista;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelMailListaAgregarQuitar;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregarMail;
        private MaterialSkin.Controls.MaterialFlatButton btnQuitarMail;
        private System.Windows.Forms.DataGridView dataGridViewMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardarCambios;
        private System.Windows.Forms.Panel pnlDatosContacto;
        private ControlDomicilio cDomicilio;
        private System.Windows.Forms.GroupBox grpBoxDatosPersonales;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDatosPersonales;
        private System.Windows.Forms.Label lblCUIT;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCUIT;
        private System.Windows.Forms.Label lblDNI;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxDNI;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxApellido;
        private System.Windows.Forms.GroupBox grpBoxContraseña;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblContraseñaActual;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxContraseñaActual;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxContraseñaNueva;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxContraseñaNuevaRepetir;
        private System.Windows.Forms.TabPage tbEstiloVisual;
    }
}