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
            this.components = new System.ComponentModel.Container();
            this.grpBoxContactoProveedor = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelContactoProveedorSeleccionar = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.grpBoxContactoProveedorProveedorSeleccionado = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado = new System.Windows.Forms.TableLayoutPanel();
            this.lblRazonSocialSeleccionado = new System.Windows.Forms.Label();
            this.lblCodigoSeleccionado = new System.Windows.Forms.Label();
            this.lblCUITSeleccionado = new System.Windows.Forms.Label();
            this.cmbBoxProveedores = new System.Windows.Forms.ComboBox();
            this.epCodigo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCUIT = new System.Windows.Forms.ErrorProvider(this.components);
            this.epRazonSocial = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCodigoSeleccionado = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCUITSeleccionado = new System.Windows.Forms.ErrorProvider(this.components);
            this.epRazonSocialSeleccionado = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtBoxCodigoSeleccionado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxCUITSeleccionado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxRazonSocialSeleccionado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.grpBoxContactoProveedor.SuspendLayout();
            this.tableLayoutPanelContactoProveedorSeleccionar.SuspendLayout();
            this.tblLayoutPanelBotones.SuspendLayout();
            this.grpBoxContactoProveedorProveedorSeleccionado.SuspendLayout();
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCUIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRazonSocial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigoSeleccionado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCUITSeleccionado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRazonSocialSeleccionado)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxContactoProveedor
            // 
            this.grpBoxContactoProveedor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpBoxContactoProveedor.BackColor = System.Drawing.Color.White;
            this.grpBoxContactoProveedor.Controls.Add(this.tableLayoutPanelContactoProveedorSeleccionar);
            this.grpBoxContactoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxContactoProveedor.Location = new System.Drawing.Point(4, 79);
            this.grpBoxContactoProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxContactoProveedor.Name = "grpBoxContactoProveedor";
            this.grpBoxContactoProveedor.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxContactoProveedor.Size = new System.Drawing.Size(509, 315);
            this.grpBoxContactoProveedor.TabIndex = 10;
            this.grpBoxContactoProveedor.TabStop = false;
            this.grpBoxContactoProveedor.Text = "Contacto de Proveedor";
            // 
            // tableLayoutPanelContactoProveedorSeleccionar
            // 
            this.tableLayoutPanelContactoProveedorSeleccionar.ColumnCount = 1;
            this.tableLayoutPanelContactoProveedorSeleccionar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContactoProveedorSeleccionar.Controls.Add(this.tblLayoutPanelBotones, 0, 2);
            this.tableLayoutPanelContactoProveedorSeleccionar.Controls.Add(this.grpBoxContactoProveedorProveedorSeleccionado, 0, 1);
            this.tableLayoutPanelContactoProveedorSeleccionar.Controls.Add(this.cmbBoxProveedores, 0, 0);
            this.tableLayoutPanelContactoProveedorSeleccionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContactoProveedorSeleccionar.Location = new System.Drawing.Point(4, 26);
            this.tableLayoutPanelContactoProveedorSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelContactoProveedorSeleccionar.Name = "tableLayoutPanelContactoProveedorSeleccionar";
            this.tableLayoutPanelContactoProveedorSeleccionar.RowCount = 3;
            this.tableLayoutPanelContactoProveedorSeleccionar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanelContactoProveedorSeleccionar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanelContactoProveedorSeleccionar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelContactoProveedorSeleccionar.Size = new System.Drawing.Size(501, 285);
            this.tableLayoutPanelContactoProveedorSeleccionar.TabIndex = 1;
            // 
            // tblLayoutPanelBotones
            // 
            this.tblLayoutPanelBotones.ColumnCount = 2;
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelBotones.Controls.Add(this.btnAceptar, 0, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.btnCancelar, 1, 0);
            this.tblLayoutPanelBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelBotones.Location = new System.Drawing.Point(4, 226);
            this.tblLayoutPanelBotones.Margin = new System.Windows.Forms.Padding(4);
            this.tblLayoutPanelBotones.Name = "tblLayoutPanelBotones";
            this.tblLayoutPanelBotones.RowCount = 1;
            this.tblLayoutPanelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelBotones.Size = new System.Drawing.Size(493, 55);
            this.tblLayoutPanelBotones.TabIndex = 14;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAceptar.AutoSize = true;
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.Location = new System.Drawing.Point(117, 9);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(5, 7, 40, 7);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Primary = false;
            this.btnAceptar.Size = new System.Drawing.Size(89, 36);
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
            this.btnCancelar.Location = new System.Drawing.Point(286, 9);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(40, 7, 5, 7);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(100, 36);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grpBoxContactoProveedorProveedorSeleccionado
            // 
            this.grpBoxContactoProveedorProveedorSeleccionado.Controls.Add(this.tableLayoutPanelContactoProveedorProveedorSeleccionado);
            this.grpBoxContactoProveedorProveedorSeleccionado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxContactoProveedorProveedorSeleccionado.Location = new System.Drawing.Point(4, 61);
            this.grpBoxContactoProveedorProveedorSeleccionado.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxContactoProveedorProveedorSeleccionado.Name = "grpBoxContactoProveedorProveedorSeleccionado";
            this.grpBoxContactoProveedorProveedorSeleccionado.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxContactoProveedorProveedorSeleccionado.Size = new System.Drawing.Size(493, 157);
            this.grpBoxContactoProveedorProveedorSeleccionado.TabIndex = 1;
            this.grpBoxContactoProveedorProveedorSeleccionado.TabStop = false;
            this.grpBoxContactoProveedorProveedorSeleccionado.Text = "Proveedor Seleccionado";
            // 
            // tableLayoutPanelContactoProveedorProveedorSeleccionado
            // 
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.ColumnCount = 3;
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.Controls.Add(this.lblRazonSocialSeleccionado, 0, 2);
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.Controls.Add(this.lblCodigoSeleccionado, 0, 0);
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.Controls.Add(this.lblCUITSeleccionado, 0, 1);
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.Controls.Add(this.txtBoxCodigoSeleccionado, 1, 0);
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.Controls.Add(this.txtBoxCUITSeleccionado, 1, 1);
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.Controls.Add(this.txtBoxRazonSocialSeleccionado, 1, 2);
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.Location = new System.Drawing.Point(4, 26);
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.Name = "tableLayoutPanelContactoProveedorProveedorSeleccionado";
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.RowCount = 3;
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.Size = new System.Drawing.Size(485, 127);
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.TabIndex = 0;
            // 
            // lblRazonSocialSeleccionado
            // 
            this.lblRazonSocialSeleccionado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRazonSocialSeleccionado.AutoSize = true;
            this.lblRazonSocialSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocialSeleccionado.Location = new System.Drawing.Point(19, 84);
            this.lblRazonSocialSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazonSocialSeleccionado.Name = "lblRazonSocialSeleccionado";
            this.lblRazonSocialSeleccionado.Size = new System.Drawing.Size(62, 40);
            this.lblRazonSocialSeleccionado.TabIndex = 12;
            this.lblRazonSocialSeleccionado.Text = "Razón Social:";
            // 
            // lblCodigoSeleccionado
            // 
            this.lblCodigoSeleccionado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoSeleccionado.AutoSize = true;
            this.lblCodigoSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoSeleccionado.Location = new System.Drawing.Point(15, 10);
            this.lblCodigoSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoSeleccionado.Name = "lblCodigoSeleccionado";
            this.lblCodigoSeleccionado.Size = new System.Drawing.Size(66, 20);
            this.lblCodigoSeleccionado.TabIndex = 2;
            this.lblCodigoSeleccionado.Text = "Código:";
            // 
            // lblCUITSeleccionado
            // 
            this.lblCUITSeleccionado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCUITSeleccionado.AutoSize = true;
            this.lblCUITSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUITSeleccionado.Location = new System.Drawing.Point(29, 51);
            this.lblCUITSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCUITSeleccionado.Name = "lblCUITSeleccionado";
            this.lblCUITSeleccionado.Size = new System.Drawing.Size(52, 20);
            this.lblCUITSeleccionado.TabIndex = 8;
            this.lblCUITSeleccionado.Text = "CUIT:";
            // 
            // cmbBoxProveedores
            // 
            this.cmbBoxProveedores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoxProveedores.FormattingEnabled = true;
            this.cmbBoxProveedores.Location = new System.Drawing.Point(131, 12);
            this.cmbBoxProveedores.Name = "cmbBoxProveedores";
            this.cmbBoxProveedores.Size = new System.Drawing.Size(238, 32);
            this.cmbBoxProveedores.TabIndex = 15;
            this.cmbBoxProveedores.SelectedValueChanged += new System.EventHandler(this.cmbBoxProveedores_SelectedValueChanged);
            // 
            // epCodigo
            // 
            this.epCodigo.ContainerControl = this;
            // 
            // epCUIT
            // 
            this.epCUIT.ContainerControl = this;
            // 
            // epRazonSocial
            // 
            this.epRazonSocial.ContainerControl = this;
            // 
            // epCodigoSeleccionado
            // 
            this.epCodigoSeleccionado.ContainerControl = this;
            // 
            // epCUITSeleccionado
            // 
            this.epCUITSeleccionado.ContainerControl = this;
            // 
            // epRazonSocialSeleccionado
            // 
            this.epRazonSocialSeleccionado.ContainerControl = this;
            // 
            // txtBoxCodigoSeleccionado
            // 
            this.txtBoxCodigoSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoSeleccionado.Depth = 0;
            this.txtBoxCodigoSeleccionado.Hint = "";
            this.txtBoxCodigoSeleccionado.Location = new System.Drawing.Point(88, 6);
            this.txtBoxCodigoSeleccionado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCodigoSeleccionado.Name = "txtBoxCodigoSeleccionado";
            this.txtBoxCodigoSeleccionado.PasswordChar = '\0';
            this.txtBoxCodigoSeleccionado.SelectedText = "";
            this.txtBoxCodigoSeleccionado.SelectionLength = 0;
            this.txtBoxCodigoSeleccionado.SelectionStart = 0;
            this.txtBoxCodigoSeleccionado.Size = new System.Drawing.Size(359, 28);
            this.txtBoxCodigoSeleccionado.TabIndex = 13;
            this.txtBoxCodigoSeleccionado.UseSystemPasswordChar = false;
            this.txtBoxCodigoSeleccionado.Leave += new System.EventHandler(this.txtBoxCodigoSeleccionado_Leave);
            // 
            // txtBoxCUITSeleccionado
            // 
            this.txtBoxCUITSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCUITSeleccionado.Depth = 0;
            this.txtBoxCUITSeleccionado.Hint = "";
            this.txtBoxCUITSeleccionado.Location = new System.Drawing.Point(88, 47);
            this.txtBoxCUITSeleccionado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCUITSeleccionado.Name = "txtBoxCUITSeleccionado";
            this.txtBoxCUITSeleccionado.PasswordChar = '\0';
            this.txtBoxCUITSeleccionado.SelectedText = "";
            this.txtBoxCUITSeleccionado.SelectionLength = 0;
            this.txtBoxCUITSeleccionado.SelectionStart = 0;
            this.txtBoxCUITSeleccionado.Size = new System.Drawing.Size(359, 28);
            this.txtBoxCUITSeleccionado.TabIndex = 14;
            this.txtBoxCUITSeleccionado.UseSystemPasswordChar = false;
            this.txtBoxCUITSeleccionado.Leave += new System.EventHandler(this.txtBoxCUITSeleccionado_Leave);
            // 
            // txtBoxRazonSocialSeleccionado
            // 
            this.txtBoxRazonSocialSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxRazonSocialSeleccionado.Depth = 0;
            this.txtBoxRazonSocialSeleccionado.Hint = "";
            this.txtBoxRazonSocialSeleccionado.Location = new System.Drawing.Point(88, 90);
            this.txtBoxRazonSocialSeleccionado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxRazonSocialSeleccionado.Name = "txtBoxRazonSocialSeleccionado";
            this.txtBoxRazonSocialSeleccionado.PasswordChar = '\0';
            this.txtBoxRazonSocialSeleccionado.SelectedText = "";
            this.txtBoxRazonSocialSeleccionado.SelectionLength = 0;
            this.txtBoxRazonSocialSeleccionado.SelectionStart = 0;
            this.txtBoxRazonSocialSeleccionado.Size = new System.Drawing.Size(359, 28);
            this.txtBoxRazonSocialSeleccionado.TabIndex = 15;
            this.txtBoxRazonSocialSeleccionado.UseSystemPasswordChar = false;
            this.txtBoxRazonSocialSeleccionado.Leave += new System.EventHandler(this.txtBoxRazonSocialSeleccionado_Leave);
            // 
            // frmABMEntidadDatosAdicionalesContactoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 400);
            this.Controls.Add(this.grpBoxContactoProveedor);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(520, 400);
            this.Name = "frmABMEntidadDatosAdicionalesContactoProveedor";
            this.Text = "Datos Adicionales de Contacto de Proveedor";
            this.grpBoxContactoProveedor.ResumeLayout(false);
            this.tableLayoutPanelContactoProveedorSeleccionar.ResumeLayout(false);
            this.tblLayoutPanelBotones.ResumeLayout(false);
            this.tblLayoutPanelBotones.PerformLayout();
            this.grpBoxContactoProveedorProveedorSeleccionado.ResumeLayout(false);
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.ResumeLayout(false);
            this.tableLayoutPanelContactoProveedorProveedorSeleccionado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCUIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRazonSocial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigoSeleccionado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCUITSeleccionado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRazonSocialSeleccionado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxContactoProveedor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContactoProveedorSeleccionar;
        private System.Windows.Forms.GroupBox grpBoxContactoProveedorProveedorSeleccionado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContactoProveedorProveedorSeleccionado;
        private System.Windows.Forms.Label lblRazonSocialSeleccionado;
        private System.Windows.Forms.Label lblCodigoSeleccionado;
        private System.Windows.Forms.Label lblCUITSeleccionado;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelBotones;
        private MaterialSkin.Controls.MaterialFlatButton btnAceptar;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private System.Windows.Forms.ErrorProvider epCodigo;
        private System.Windows.Forms.ErrorProvider epCUIT;
        private System.Windows.Forms.ErrorProvider epRazonSocial;
        private System.Windows.Forms.ErrorProvider epCodigoSeleccionado;
        private System.Windows.Forms.ErrorProvider epCUITSeleccionado;
        private System.Windows.Forms.ErrorProvider epRazonSocialSeleccionado;
        private System.Windows.Forms.ComboBox cmbBoxProveedores;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCodigoSeleccionado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCUITSeleccionado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxRazonSocialSeleccionado;
    }
}