namespace Vista
{
    partial class frmABMEntidadDatosAdicionalesContactoProveedor
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
            this.grpBoxContactoProveedor = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelContactoProveedorSeleccionar = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.txtBoxCodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxCUIT = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxRazonSocial = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.grpBoxContactoProveedorProveedorSeleccionado = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado = new System.Windows.Forms.TableLayoutPanel();
            this.lblRazonSocialSeleccionado = new System.Windows.Forms.Label();
            this.lblCodigoSeleccionado = new System.Windows.Forms.Label();
            this.lblCUITSeleccionado = new System.Windows.Forms.Label();
            this.txtBoxCodigoSeleccionado = new MaterialSkin.Controls.MaterialLabel();
            this.txtBoxCUITSeleccionado = new MaterialSkin.Controls.MaterialLabel();
            this.txtBoxRazonSocialSeleccionado = new MaterialSkin.Controls.MaterialLabel();
            this.btnSeleccionarProveedor = new MaterialSkin.Controls.MaterialFlatButton();
            this.grpBoxContactoProveedor.SuspendLayout();
            this.tableLayoutPanelContactoProveedorSeleccionar.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpBoxContactoProveedorProveedorSeleccionado.SuspendLayout();
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxContactoProveedor
            // 
            this.grpBoxContactoProveedor.BackColor = System.Drawing.Color.White;
            this.grpBoxContactoProveedor.Controls.Add(this.tableLayoutPanelContactoProveedorSeleccionar);
            this.grpBoxContactoProveedor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpBoxContactoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxContactoProveedor.Location = new System.Drawing.Point(0, 64);
            this.grpBoxContactoProveedor.Name = "grpBoxContactoProveedor";
            this.grpBoxContactoProveedor.Size = new System.Drawing.Size(390, 371);
            this.grpBoxContactoProveedor.TabIndex = 10;
            this.grpBoxContactoProveedor.TabStop = false;
            this.grpBoxContactoProveedor.Text = "Contacto de Proveedor";
            // 
            // tableLayoutPanelContactoProveedorSeleccionar
            // 
            this.tableLayoutPanelContactoProveedorSeleccionar.ColumnCount = 1;
            this.tableLayoutPanelContactoProveedorSeleccionar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContactoProveedorSeleccionar.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanelContactoProveedorSeleccionar.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanelContactoProveedorSeleccionar.Controls.Add(this.grpBoxContactoProveedorProveedorSeleccionado, 0, 2);
            this.tableLayoutPanelContactoProveedorSeleccionar.Controls.Add(this.btnSeleccionarProveedor, 0, 1);
            this.tableLayoutPanelContactoProveedorSeleccionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContactoProveedorSeleccionar.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanelContactoProveedorSeleccionar.Name = "tableLayoutPanelContactoProveedorSeleccionar";
            this.tableLayoutPanelContactoProveedorSeleccionar.RowCount = 4;
            this.tableLayoutPanelContactoProveedorSeleccionar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanelContactoProveedorSeleccionar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanelContactoProveedorSeleccionar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanelContactoProveedorSeleccionar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContactoProveedorSeleccionar.Size = new System.Drawing.Size(384, 348);
            this.tableLayoutPanelContactoProveedorSeleccionar.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAceptar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancelar, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 299);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(378, 46);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAceptar.AutoSize = true;
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.Location = new System.Drawing.Point(86, 6);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 30, 6);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Primary = false;
            this.btnAceptar.Size = new System.Drawing.Size(73, 34);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(219, 6);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(30, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(82, 34);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.34861F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.65139F));
            this.tableLayoutPanel1.Controls.Add(this.lblRazonSocial, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCodigo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCUIT, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxCodigo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxCUIT, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxRazonSocial, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 110);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(9, 74);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(53, 34);
            this.lblRazonSocial.TabIndex = 11;
            this.lblRazonSocial.Text = "Razón Social:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(6, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 17);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // lblCUIT
            // 
            this.lblCUIT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUIT.Location = new System.Drawing.Point(19, 45);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(43, 17);
            this.lblCUIT.TabIndex = 7;
            this.lblCUIT.Text = "CUIT:";
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigo.Depth = 0;
            this.txtBoxCodigo.Hint = "";
            this.txtBoxCodigo.Location = new System.Drawing.Point(68, 6);
            this.txtBoxCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCodigo.Name = "txtBoxCodigo";
            this.txtBoxCodigo.PasswordChar = '\0';
            this.txtBoxCodigo.SelectedText = "";
            this.txtBoxCodigo.SelectionLength = 0;
            this.txtBoxCodigo.SelectionStart = 0;
            this.txtBoxCodigo.Size = new System.Drawing.Size(307, 23);
            this.txtBoxCodigo.TabIndex = 13;
            this.txtBoxCodigo.UseSystemPasswordChar = false;
            // 
            // txtBoxCUIT
            // 
            this.txtBoxCUIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCUIT.Depth = 0;
            this.txtBoxCUIT.Hint = "";
            this.txtBoxCUIT.Location = new System.Drawing.Point(68, 42);
            this.txtBoxCUIT.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCUIT.Name = "txtBoxCUIT";
            this.txtBoxCUIT.PasswordChar = '\0';
            this.txtBoxCUIT.SelectedText = "";
            this.txtBoxCUIT.SelectionLength = 0;
            this.txtBoxCUIT.SelectionStart = 0;
            this.txtBoxCUIT.Size = new System.Drawing.Size(307, 23);
            this.txtBoxCUIT.TabIndex = 14;
            this.txtBoxCUIT.UseSystemPasswordChar = false;
            // 
            // txtBoxRazonSocial
            // 
            this.txtBoxRazonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxRazonSocial.Depth = 0;
            this.txtBoxRazonSocial.Hint = "";
            this.txtBoxRazonSocial.Location = new System.Drawing.Point(68, 79);
            this.txtBoxRazonSocial.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxRazonSocial.Name = "txtBoxRazonSocial";
            this.txtBoxRazonSocial.PasswordChar = '\0';
            this.txtBoxRazonSocial.SelectedText = "";
            this.txtBoxRazonSocial.SelectionLength = 0;
            this.txtBoxRazonSocial.SelectionStart = 0;
            this.txtBoxRazonSocial.Size = new System.Drawing.Size(307, 23);
            this.txtBoxRazonSocial.TabIndex = 15;
            this.txtBoxRazonSocial.UseSystemPasswordChar = false;
            // 
            // grpBoxContactoProveedorProveedorSeleccionado
            // 
            this.grpBoxContactoProveedorProveedorSeleccionado.Controls.Add(this.tableLayoutPanelContactoProveedorProveedorSeleccionado);
            this.grpBoxContactoProveedorProveedorSeleccionado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxContactoProveedorProveedorSeleccionado.Location = new System.Drawing.Point(3, 165);
            this.grpBoxContactoProveedorProveedorSeleccionado.Name = "grpBoxContactoProveedorProveedorSeleccionado";
            this.grpBoxContactoProveedorProveedorSeleccionado.Size = new System.Drawing.Size(378, 128);
            this.grpBoxContactoProveedorProveedorSeleccionado.TabIndex = 1;
            this.grpBoxContactoProveedorProveedorSeleccionado.TabStop = false;
            this.grpBoxContactoProveedorProveedorSeleccionado.Text = "Proveedor Seleccionado";
            // 
            // tableLayoutPanelContactoProveedorProveedorSeleccionado
            // 
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.ColumnCount = 2;
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.52066F));
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.47934F));
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.Controls.Add(this.lblRazonSocialSeleccionado, 0, 2);
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.Controls.Add(this.lblCodigoSeleccionado, 0, 0);
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.Controls.Add(this.lblCUITSeleccionado, 0, 1);
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.Controls.Add(this.txtBoxCodigoSeleccionado, 1, 0);
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.Controls.Add(this.txtBoxCUITSeleccionado, 1, 1);
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.Controls.Add(this.txtBoxRazonSocialSeleccionado, 1, 2);
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.Name = "tableLayoutPanelContactoProveedorProveedorSeleccionado";
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.RowCount = 3;
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.Size = new System.Drawing.Size(372, 105);
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.TabIndex = 0;
            // 
            // lblRazonSocialSeleccionado
            // 
            this.lblRazonSocialSeleccionado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRazonSocialSeleccionado.AutoSize = true;
            this.lblRazonSocialSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocialSeleccionado.Location = new System.Drawing.Point(9, 69);
            this.lblRazonSocialSeleccionado.Name = "lblRazonSocialSeleccionado";
            this.lblRazonSocialSeleccionado.Size = new System.Drawing.Size(53, 34);
            this.lblRazonSocialSeleccionado.TabIndex = 12;
            this.lblRazonSocialSeleccionado.Text = "Razón Social:";
            // 
            // lblCodigoSeleccionado
            // 
            this.lblCodigoSeleccionado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoSeleccionado.AutoSize = true;
            this.lblCodigoSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoSeleccionado.Location = new System.Drawing.Point(6, 8);
            this.lblCodigoSeleccionado.Name = "lblCodigoSeleccionado";
            this.lblCodigoSeleccionado.Size = new System.Drawing.Size(56, 17);
            this.lblCodigoSeleccionado.TabIndex = 2;
            this.lblCodigoSeleccionado.Text = "Código:";
            // 
            // lblCUITSeleccionado
            // 
            this.lblCUITSeleccionado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCUITSeleccionado.AutoSize = true;
            this.lblCUITSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUITSeleccionado.Location = new System.Drawing.Point(19, 42);
            this.lblCUITSeleccionado.Name = "lblCUITSeleccionado";
            this.lblCUITSeleccionado.Size = new System.Drawing.Size(43, 17);
            this.lblCUITSeleccionado.TabIndex = 8;
            this.lblCUITSeleccionado.Text = "CUIT:";
            // 
            // txtBoxCodigoSeleccionado
            // 
            this.txtBoxCodigoSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoSeleccionado.AutoSize = true;
            this.txtBoxCodigoSeleccionado.Depth = 0;
            this.txtBoxCodigoSeleccionado.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtBoxCodigoSeleccionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBoxCodigoSeleccionado.Location = new System.Drawing.Point(68, 7);
            this.txtBoxCodigoSeleccionado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCodigoSeleccionado.Name = "txtBoxCodigoSeleccionado";
            this.txtBoxCodigoSeleccionado.Size = new System.Drawing.Size(301, 19);
            this.txtBoxCodigoSeleccionado.TabIndex = 19;
            // 
            // txtBoxCUITSeleccionado
            // 
            this.txtBoxCUITSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCUITSeleccionado.AutoSize = true;
            this.txtBoxCUITSeleccionado.Depth = 0;
            this.txtBoxCUITSeleccionado.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtBoxCUITSeleccionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBoxCUITSeleccionado.Location = new System.Drawing.Point(68, 41);
            this.txtBoxCUITSeleccionado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCUITSeleccionado.Name = "txtBoxCUITSeleccionado";
            this.txtBoxCUITSeleccionado.Size = new System.Drawing.Size(301, 19);
            this.txtBoxCUITSeleccionado.TabIndex = 20;
            // 
            // txtBoxRazonSocialSeleccionado
            // 
            this.txtBoxRazonSocialSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxRazonSocialSeleccionado.AutoSize = true;
            this.txtBoxRazonSocialSeleccionado.Depth = 0;
            this.txtBoxRazonSocialSeleccionado.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtBoxRazonSocialSeleccionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBoxRazonSocialSeleccionado.Location = new System.Drawing.Point(68, 77);
            this.txtBoxRazonSocialSeleccionado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxRazonSocialSeleccionado.Name = "txtBoxRazonSocialSeleccionado";
            this.txtBoxRazonSocialSeleccionado.Size = new System.Drawing.Size(301, 19);
            this.txtBoxRazonSocialSeleccionado.TabIndex = 21;
            // 
            // btnSeleccionarProveedor
            // 
            this.btnSeleccionarProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSeleccionarProveedor.AutoSize = true;
            this.btnSeleccionarProveedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSeleccionarProveedor.Depth = 0;
            this.btnSeleccionarProveedor.Location = new System.Drawing.Point(102, 122);
            this.btnSeleccionarProveedor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSeleccionarProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSeleccionarProveedor.Name = "btnSeleccionarProveedor";
            this.btnSeleccionarProveedor.Primary = false;
            this.btnSeleccionarProveedor.Size = new System.Drawing.Size(179, 34);
            this.btnSeleccionarProveedor.TabIndex = 0;
            this.btnSeleccionarProveedor.Text = "Seleccionar o Cambiar";
            this.btnSeleccionarProveedor.UseVisualStyleBackColor = true;
            this.btnSeleccionarProveedor.Click += new System.EventHandler(this.btnSeleccionarProveedor_Click);
            // 
            // frmABMEntidadDatosAdicionalesContactoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 435);
            this.Controls.Add(this.grpBoxContactoProveedor);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(390, 410);
            this.Name = "frmABMEntidadDatosAdicionalesContactoProveedor";
            this.Text = "Datos Adicionales de Contacto de Proveedor";
            this.grpBoxContactoProveedor.ResumeLayout(false);
            this.tableLayoutPanelContactoProveedorSeleccionar.ResumeLayout(false);
            this.tableLayoutPanelContactoProveedorSeleccionar.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpBoxContactoProveedorProveedorSeleccionado.ResumeLayout(false);
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.ResumeLayout(false);
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxContactoProveedor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContactoProveedorSeleccionar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.GroupBox grpBoxContactoProveedorProveedorSeleccionado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContactoProveedorProveedorSeleccionado;
        private System.Windows.Forms.Label lblRazonSocialSeleccionado;
        private System.Windows.Forms.Label lblCodigoSeleccionado;
        private System.Windows.Forms.Label lblCUITSeleccionado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialFlatButton btnSeleccionarProveedor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCodigo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCUIT;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxRazonSocial;
        private MaterialSkin.Controls.MaterialLabel txtBoxCodigoSeleccionado;
        private MaterialSkin.Controls.MaterialLabel txtBoxCUITSeleccionado;
        private MaterialSkin.Controls.MaterialLabel txtBoxRazonSocialSeleccionado;
        private MaterialSkin.Controls.MaterialFlatButton btnAceptar;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
    }
}