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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.tblLayoutPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.btnGuardarCambios = new MaterialSkin.Controls.MaterialRaisedButton();
            this.selectorControlPrincipal = new MaterialSkin.Controls.MaterialTabSelector();
            this.tbControlPrincipal = new MaterialSkin.Controls.MaterialTabControl();
            this.tbPageDatosGenerales = new System.Windows.Forms.TabPage();
            this.tblLayoutPanelDatosGenerales = new System.Windows.Forms.TableLayoutPanel();
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
            this.tblLayoutPanelDomicilioDatos = new System.Windows.Forms.TableLayoutPanel();
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
            this.cDomicilio = new Vista.controlDomicilio();
            this.pnlBase.SuspendLayout();
            this.tblLayoutPanelPrincipal.SuspendLayout();
            this.tbControlPrincipal.SuspendLayout();
            this.tbPageDatosGenerales.SuspendLayout();
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
            this.grpBoxDomicilio.SuspendLayout();
            this.tblLayoutPanelDomicilioDatos.SuspendLayout();
            this.tblLayoutPanelDomicilioGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDomicilio)).BeginInit();
            this.tblLayoutPanelDomicilioAgregarQuitar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.tblLayoutPanelPrincipal);
            this.pnlBase.Location = new System.Drawing.Point(12, 72);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(741, 509);
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
            this.tblLayoutPanelPrincipal.Size = new System.Drawing.Size(741, 509);
            this.tblLayoutPanelPrincipal.TabIndex = 0;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarCambios.Depth = 0;
            this.btnGuardarCambios.Location = new System.Drawing.Point(315, 464);
            this.btnGuardarCambios.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Primary = true;
            this.btnGuardarCambios.Size = new System.Drawing.Size(110, 40);
            this.btnGuardarCambios.TabIndex = 10;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
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
            this.tbControlPrincipal.Depth = 0;
            this.tbControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControlPrincipal.Location = new System.Drawing.Point(3, 43);
            this.tbControlPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbControlPrincipal.Name = "tbControlPrincipal";
            this.tbControlPrincipal.SelectedIndex = 0;
            this.tbControlPrincipal.Size = new System.Drawing.Size(735, 413);
            this.tbControlPrincipal.TabIndex = 2;
            // 
            // tbPageDatosGenerales
            // 
            this.tbPageDatosGenerales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbPageDatosGenerales.Controls.Add(this.tblLayoutPanelDatosGenerales);
            this.tbPageDatosGenerales.Location = new System.Drawing.Point(4, 22);
            this.tbPageDatosGenerales.Name = "tbPageDatosGenerales";
            this.tbPageDatosGenerales.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageDatosGenerales.Size = new System.Drawing.Size(727, 387);
            this.tbPageDatosGenerales.TabIndex = 0;
            this.tbPageDatosGenerales.Text = "Datos Generales";
            // 
            // tblLayoutPanelDatosGenerales
            // 
            this.tblLayoutPanelDatosGenerales.ColumnCount = 1;
            this.tblLayoutPanelDatosGenerales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDatosGenerales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDatosGenerales.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelDatosGenerales.Name = "tblLayoutPanelDatosGenerales";
            this.tblLayoutPanelDatosGenerales.RowCount = 2;
            this.tblLayoutPanelDatosGenerales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDatosGenerales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDatosGenerales.Size = new System.Drawing.Size(721, 381);
            this.tblLayoutPanelDatosGenerales.TabIndex = 0;
            // 
            // tbPageDatosContacto
            // 
            this.tbPageDatosContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbPageDatosContacto.Controls.Add(this.pnlDatosContacto);
            this.tbPageDatosContacto.Location = new System.Drawing.Point(4, 22);
            this.tbPageDatosContacto.Name = "tbPageDatosContacto";
            this.tbPageDatosContacto.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageDatosContacto.Size = new System.Drawing.Size(727, 387);
            this.tbPageDatosContacto.TabIndex = 1;
            this.tbPageDatosContacto.Text = "Datos de Contacto";
            // 
            // pnlDatosContacto
            // 
            this.pnlDatosContacto.Controls.Add(this.tblLayoutPanelDatosContacto);
            this.pnlDatosContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatosContacto.Location = new System.Drawing.Point(3, 3);
            this.pnlDatosContacto.Name = "pnlDatosContacto";
            this.pnlDatosContacto.Size = new System.Drawing.Size(721, 381);
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
            this.tblLayoutPanelDatosContacto.Size = new System.Drawing.Size(721, 381);
            this.tblLayoutPanelDatosContacto.TabIndex = 0;
            // 
            // grpBoxContacto
            // 
            this.grpBoxContacto.Controls.Add(this.tblLayoutPanelContacto);
            this.grpBoxContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxContacto.Location = new System.Drawing.Point(3, 231);
            this.grpBoxContacto.Name = "grpBoxContacto";
            this.grpBoxContacto.Size = new System.Drawing.Size(715, 147);
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
            this.tblLayoutPanelContacto.Size = new System.Drawing.Size(709, 124);
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
            this.tblLayoutPanelTelefonoLista.Size = new System.Drawing.Size(317, 68);
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
            this.tblLayoutPanelTelefonoListaAgregarQuitar.Size = new System.Drawing.Size(27, 62);
            this.tblLayoutPanelTelefonoListaAgregarQuitar.TabIndex = 13;
            // 
            // btnQuitarTelefono
            // 
            this.btnQuitarTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuitarTelefono.AutoSize = true;
            this.btnQuitarTelefono.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuitarTelefono.Depth = 0;
            this.btnQuitarTelefono.Location = new System.Drawing.Point(5, 37);
            this.btnQuitarTelefono.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuitarTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitarTelefono.Name = "btnQuitarTelefono";
            this.btnQuitarTelefono.Primary = false;
            this.btnQuitarTelefono.Size = new System.Drawing.Size(16, 19);
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
            this.btnAgregarTelefono.Size = new System.Drawing.Size(19, 19);
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
            this.dataGridViewTelefono.Size = new System.Drawing.Size(278, 62);
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
            this.cmbBoxTipoTelefono.Location = new System.Drawing.Point(3, 11);
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
            this.tblLayoutPanelMailLista.Size = new System.Drawing.Size(380, 68);
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
            this.tblLayoutPanelMailListaAgregarQuitar.Size = new System.Drawing.Size(27, 62);
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
            this.btnAgregarMail.Size = new System.Drawing.Size(19, 19);
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
            this.btnQuitarMail.Location = new System.Drawing.Point(5, 37);
            this.btnQuitarMail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuitarMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitarMail.Name = "btnQuitarMail";
            this.btnQuitarMail.Primary = false;
            this.btnQuitarMail.Size = new System.Drawing.Size(16, 19);
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
            this.dataGridViewMail.Size = new System.Drawing.Size(341, 62);
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
            this.grpBoxDomicilio.Controls.Add(this.tblLayoutPanelDomicilioDatos);
            this.grpBoxDomicilio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDomicilio.Location = new System.Drawing.Point(3, 3);
            this.grpBoxDomicilio.Name = "grpBoxDomicilio";
            this.grpBoxDomicilio.Size = new System.Drawing.Size(715, 222);
            this.grpBoxDomicilio.TabIndex = 5;
            this.grpBoxDomicilio.TabStop = false;
            this.grpBoxDomicilio.Text = "Domicilio";
            // 
            // tblLayoutPanelDomicilioDatos
            // 
            this.tblLayoutPanelDomicilioDatos.ColumnCount = 1;
            this.tblLayoutPanelDomicilioDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDomicilioDatos.Controls.Add(this.tblLayoutPanelDomicilioGrid, 0, 1);
            this.tblLayoutPanelDomicilioDatos.Controls.Add(this.cDomicilio, 0, 0);
            this.tblLayoutPanelDomicilioDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDomicilioDatos.Location = new System.Drawing.Point(3, 20);
            this.tblLayoutPanelDomicilioDatos.Name = "tblLayoutPanelDomicilioDatos";
            this.tblLayoutPanelDomicilioDatos.RowCount = 2;
            this.tblLayoutPanelDomicilioDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tblLayoutPanelDomicilioDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDomicilioDatos.Size = new System.Drawing.Size(709, 199);
            this.tblLayoutPanelDomicilioDatos.TabIndex = 1;
            // 
            // tblLayoutPanelDomicilioGrid
            // 
            this.tblLayoutPanelDomicilioGrid.ColumnCount = 2;
            this.tblLayoutPanelDomicilioGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDomicilioGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tblLayoutPanelDomicilioGrid.Controls.Add(this.dataGridViewDomicilio, 0, 0);
            this.tblLayoutPanelDomicilioGrid.Controls.Add(this.tblLayoutPanelDomicilioAgregarQuitar, 1, 0);
            this.tblLayoutPanelDomicilioGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDomicilioGrid.Location = new System.Drawing.Point(3, 138);
            this.tblLayoutPanelDomicilioGrid.Name = "tblLayoutPanelDomicilioGrid";
            this.tblLayoutPanelDomicilioGrid.RowCount = 1;
            this.tblLayoutPanelDomicilioGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDomicilioGrid.Size = new System.Drawing.Size(703, 58);
            this.tblLayoutPanelDomicilioGrid.TabIndex = 1;
            // 
            // dataGridViewDomicilio
            // 
            this.dataGridViewDomicilio.AllowUserToAddRows = false;
            this.dataGridViewDomicilio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDomicilio.BackgroundColor = System.Drawing.Color.White;
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
            this.dataGridViewDomicilio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDomicilio.GridColor = System.Drawing.Color.White;
            this.dataGridViewDomicilio.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDomicilio.Name = "dataGridViewDomicilio";
            this.dataGridViewDomicilio.ReadOnly = true;
            this.dataGridViewDomicilio.RowHeadersVisible = false;
            this.dataGridViewDomicilio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDomicilio.Size = new System.Drawing.Size(664, 52);
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
            this.tblLayoutPanelDomicilioAgregarQuitar.Location = new System.Drawing.Point(673, 3);
            this.tblLayoutPanelDomicilioAgregarQuitar.Name = "tblLayoutPanelDomicilioAgregarQuitar";
            this.tblLayoutPanelDomicilioAgregarQuitar.RowCount = 2;
            this.tblLayoutPanelDomicilioAgregarQuitar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDomicilioAgregarQuitar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDomicilioAgregarQuitar.Size = new System.Drawing.Size(27, 52);
            this.tblLayoutPanelDomicilioAgregarQuitar.TabIndex = 2;
            // 
            // btnAgregarDomicilio
            // 
            this.btnAgregarDomicilio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarDomicilio.AutoSize = true;
            this.btnAgregarDomicilio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarDomicilio.Depth = 0;
            this.btnAgregarDomicilio.Location = new System.Drawing.Point(4, 6);
            this.btnAgregarDomicilio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarDomicilio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarDomicilio.Name = "btnAgregarDomicilio";
            this.btnAgregarDomicilio.Primary = false;
            this.btnAgregarDomicilio.Size = new System.Drawing.Size(19, 14);
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
            this.btnQuitarDomicilio.Location = new System.Drawing.Point(5, 32);
            this.btnQuitarDomicilio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuitarDomicilio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitarDomicilio.Name = "btnQuitarDomicilio";
            this.btnQuitarDomicilio.Primary = false;
            this.btnQuitarDomicilio.Size = new System.Drawing.Size(16, 14);
            this.btnQuitarDomicilio.TabIndex = 18;
            this.btnQuitarDomicilio.Text = "-";
            this.btnQuitarDomicilio.UseVisualStyleBackColor = true;
            // 
            // cDomicilio
            // 
            this.cDomicilio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cDomicilio.Location = new System.Drawing.Point(0, 0);
            this.cDomicilio.Margin = new System.Windows.Forms.Padding(0);
            this.cDomicilio.Name = "cDomicilio";
            this.cDomicilio.Size = new System.Drawing.Size(709, 135);
            this.cDomicilio.TabIndex = 2;
            //this.cDomicilio = new controlDomicilio();
            // 
            // frmOpcionesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 593);
            this.Controls.Add(this.pnlBase);
            this.Name = "frmOpcionesUsuario";
            this.Text = "f";
            this.pnlBase.ResumeLayout(false);
            this.tblLayoutPanelPrincipal.ResumeLayout(false);
            this.tbControlPrincipal.ResumeLayout(false);
            this.tbPageDatosGenerales.ResumeLayout(false);
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
            this.grpBoxDomicilio.ResumeLayout(false);
            this.tblLayoutPanelDomicilioDatos.ResumeLayout(false);
            this.tblLayoutPanelDomicilioGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDomicilio)).EndInit();
            this.tblLayoutPanelDomicilioAgregarQuitar.ResumeLayout(false);
            this.tblLayoutPanelDomicilioAgregarQuitar.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDomicilioDatos;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDomicilioGrid;
        private System.Windows.Forms.DataGridView dataGridViewDomicilio;
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
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDomicilioAgregarQuitar;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregarDomicilio;
        private MaterialSkin.Controls.MaterialFlatButton btnQuitarDomicilio;
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
        private controlDomicilio cDomicilio;
    }
}