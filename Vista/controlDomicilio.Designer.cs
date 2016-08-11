namespace Vista
{
    partial class ControlDomicilio
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tblLayoutPanelDomicilio = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayourPanelDomicilio_1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtBoxNumeroDomicilio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxCalle = new MaterialSkin.Controls.MaterialSingleLineTextField();
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
            this.epCalle = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNumeroDomicilio = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCiudad = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPiso = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDepartamento = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCodigoPostal = new System.Windows.Forms.ErrorProvider(this.components);
            this.tblLayoutPanelDomicilio.SuspendLayout();
            this.tblLayourPanelDomicilio_1.SuspendLayout();
            this.tblLayoutPanelDomicilio_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNumeroDomicilio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigoPostal)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLayoutPanelDomicilio
            // 
            this.tblLayoutPanelDomicilio.AutoSize = true;
            this.tblLayoutPanelDomicilio.ColumnCount = 1;
            this.tblLayoutPanelDomicilio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDomicilio.Controls.Add(this.tblLayourPanelDomicilio_1, 0, 0);
            this.tblLayoutPanelDomicilio.Controls.Add(this.tblLayoutPanelDomicilio_2, 0, 1);
            this.tblLayoutPanelDomicilio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDomicilio.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanelDomicilio.Margin = new System.Windows.Forms.Padding(0);
            this.tblLayoutPanelDomicilio.Name = "tblLayoutPanelDomicilio";
            this.tblLayoutPanelDomicilio.RowCount = 2;
            this.tblLayoutPanelDomicilio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblLayoutPanelDomicilio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tblLayoutPanelDomicilio.Size = new System.Drawing.Size(777, 101);
            this.tblLayoutPanelDomicilio.TabIndex = 7;
            // 
            // tblLayourPanelDomicilio_1
            // 
            this.tblLayourPanelDomicilio_1.AutoSize = true;
            this.tblLayourPanelDomicilio_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblLayourPanelDomicilio_1.ColumnCount = 6;
            this.tblLayourPanelDomicilio_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tblLayourPanelDomicilio_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayourPanelDomicilio_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayourPanelDomicilio_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tblLayourPanelDomicilio_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tblLayourPanelDomicilio_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayourPanelDomicilio_1.Controls.Add(this.lblNumero, 3, 0);
            this.tblLayourPanelDomicilio_1.Controls.Add(this.lblCalle, 0, 0);
            this.tblLayourPanelDomicilio_1.Controls.Add(this.txtBoxNumeroDomicilio, 4, 0);
            this.tblLayourPanelDomicilio_1.Controls.Add(this.txtBoxCalle, 1, 0);
            this.tblLayourPanelDomicilio_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayourPanelDomicilio_1.Location = new System.Drawing.Point(0, 0);
            this.tblLayourPanelDomicilio_1.Margin = new System.Windows.Forms.Padding(0);
            this.tblLayourPanelDomicilio_1.Name = "tblLayourPanelDomicilio_1";
            this.tblLayourPanelDomicilio_1.RowCount = 1;
            this.tblLayourPanelDomicilio_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayourPanelDomicilio_1.Size = new System.Drawing.Size(777, 32);
            this.tblLayourPanelDomicilio_1.TabIndex = 0;
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(542, 7);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(62, 17);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Número:";
            // 
            // lblCalle
            // 
            this.lblCalle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(22, 7);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(43, 17);
            this.lblCalle.TabIndex = 1;
            this.lblCalle.Text = "Calle:";
            // 
            // txtBoxNumeroDomicilio
            // 
            this.txtBoxNumeroDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNumeroDomicilio.Depth = 0;
            this.txtBoxNumeroDomicilio.Hint = "";
            this.txtBoxNumeroDomicilio.Location = new System.Drawing.Point(610, 4);
            this.txtBoxNumeroDomicilio.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtBoxNumeroDomicilio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxNumeroDomicilio.Name = "txtBoxNumeroDomicilio";
            this.txtBoxNumeroDomicilio.PasswordChar = '\0';
            this.txtBoxNumeroDomicilio.SelectedText = "";
            this.txtBoxNumeroDomicilio.SelectionLength = 0;
            this.txtBoxNumeroDomicilio.SelectionStart = 0;
            this.txtBoxNumeroDomicilio.Size = new System.Drawing.Size(132, 23);
            this.txtBoxNumeroDomicilio.TabIndex = 20;
            this.txtBoxNumeroDomicilio.UseSystemPasswordChar = false;
            this.txtBoxNumeroDomicilio.Leave += new System.EventHandler(this.txtBoxNumeroDomicilio_Leave);
            // 
            // txtBoxCalle
            // 
            this.txtBoxCalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCalle.Depth = 0;
            this.txtBoxCalle.Hint = "";
            this.txtBoxCalle.Location = new System.Drawing.Point(71, 4);
            this.txtBoxCalle.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtBoxCalle.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCalle.Name = "txtBoxCalle";
            this.txtBoxCalle.PasswordChar = '\0';
            this.txtBoxCalle.SelectedText = "";
            this.txtBoxCalle.SelectionLength = 0;
            this.txtBoxCalle.SelectionStart = 0;
            this.txtBoxCalle.Size = new System.Drawing.Size(389, 23);
            this.txtBoxCalle.TabIndex = 19;
            this.txtBoxCalle.UseSystemPasswordChar = false;
            this.txtBoxCalle.Leave += new System.EventHandler(this.txtBoxCalle_Leave);
            // 
            // tblLayoutPanelDomicilio_2
            // 
            this.tblLayoutPanelDomicilio_2.AutoSize = true;
            this.tblLayoutPanelDomicilio_2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblLayoutPanelDomicilio_2.ColumnCount = 9;
            this.tblLayoutPanelDomicilio_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tblLayoutPanelDomicilio_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDomicilio_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelDomicilio_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tblLayoutPanelDomicilio_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDomicilio_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelDomicilio_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tblLayoutPanelDomicilio_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tblLayoutPanelDomicilio_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelDomicilio_2.Controls.Add(this.cmbBoxPais, 7, 1);
            this.tblLayoutPanelDomicilio_2.Controls.Add(this.lblPais, 6, 1);
            this.tblLayoutPanelDomicilio_2.Controls.Add(this.cmbBoxProvincia, 4, 1);
            this.tblLayoutPanelDomicilio_2.Controls.Add(this.lblProvincia, 3, 1);
            this.tblLayoutPanelDomicilio_2.Controls.Add(this.lblDepartamento, 3, 0);
            this.tblLayoutPanelDomicilio_2.Controls.Add(this.lblPiso, 0, 0);
            this.tblLayoutPanelDomicilio_2.Controls.Add(this.lblCiudad, 0, 1);
            this.tblLayoutPanelDomicilio_2.Controls.Add(this.txtBoxPiso, 1, 0);
            this.tblLayoutPanelDomicilio_2.Controls.Add(this.txtBoxCiudad, 1, 1);
            this.tblLayoutPanelDomicilio_2.Controls.Add(this.lblCodigoPostal, 6, 0);
            this.tblLayoutPanelDomicilio_2.Controls.Add(this.txtBoxDepartamento, 4, 0);
            this.tblLayoutPanelDomicilio_2.Controls.Add(this.txtBoxCodigoPostal, 7, 0);
            this.tblLayoutPanelDomicilio_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDomicilio_2.Location = new System.Drawing.Point(0, 32);
            this.tblLayoutPanelDomicilio_2.Margin = new System.Windows.Forms.Padding(0);
            this.tblLayoutPanelDomicilio_2.Name = "tblLayoutPanelDomicilio_2";
            this.tblLayoutPanelDomicilio_2.RowCount = 2;
            this.tblLayoutPanelDomicilio_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblLayoutPanelDomicilio_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblLayoutPanelDomicilio_2.Size = new System.Drawing.Size(777, 69);
            this.tblLayoutPanelDomicilio_2.TabIndex = 1;
            // 
            // cmbBoxPais
            // 
            this.cmbBoxPais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxPais.FormattingEnabled = true;
            this.cmbBoxPais.Location = new System.Drawing.Point(610, 40);
            this.cmbBoxPais.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.cmbBoxPais.Name = "cmbBoxPais";
            this.cmbBoxPais.Size = new System.Drawing.Size(117, 21);
            this.cmbBoxPais.TabIndex = 17;
            this.cmbBoxPais.SelectionChangeCommitted += new System.EventHandler(this.cmbBoxPais_SelectionChangeCommitted);
            // 
            // lblPais
            // 
            this.lblPais.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(565, 42);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(39, 17);
            this.lblPais.TabIndex = 15;
            this.lblPais.Text = "País:";
            // 
            // cmbBoxProvincia
            // 
            this.cmbBoxProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxProvincia.FormattingEnabled = true;
            this.cmbBoxProvincia.Location = new System.Drawing.Point(324, 40);
            this.cmbBoxProvincia.Name = "cmbBoxProvincia";
            this.cmbBoxProvincia.Size = new System.Drawing.Size(148, 21);
            this.cmbBoxProvincia.TabIndex = 18;
            // 
            // lblProvincia
            // 
            this.lblProvincia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(248, 42);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(70, 17);
            this.lblProvincia.TabIndex = 6;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(276, 7);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(42, 17);
            this.lblDepartamento.TabIndex = 7;
            this.lblDepartamento.Text = "Dpto:";
            // 
            // lblPiso
            // 
            this.lblPiso.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPiso.AutoSize = true;
            this.lblPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiso.Location = new System.Drawing.Point(26, 7);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(39, 17);
            this.lblPiso.TabIndex = 2;
            this.lblPiso.Text = "Piso:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(9, 42);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(56, 17);
            this.lblCiudad.TabIndex = 5;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // txtBoxPiso
            // 
            this.txtBoxPiso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPiso.Depth = 0;
            this.txtBoxPiso.Hint = "";
            this.txtBoxPiso.Location = new System.Drawing.Point(71, 4);
            this.txtBoxPiso.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtBoxPiso.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxPiso.Name = "txtBoxPiso";
            this.txtBoxPiso.PasswordChar = '\0';
            this.txtBoxPiso.SelectedText = "";
            this.txtBoxPiso.SelectionLength = 0;
            this.txtBoxPiso.SelectionStart = 0;
            this.txtBoxPiso.Size = new System.Drawing.Size(136, 23);
            this.txtBoxPiso.TabIndex = 23;
            this.txtBoxPiso.UseSystemPasswordChar = false;
            this.txtBoxPiso.Leave += new System.EventHandler(this.txtBoxPiso_Leave);
            // 
            // txtBoxCiudad
            // 
            this.txtBoxCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCiudad.Depth = 0;
            this.txtBoxCiudad.Hint = "";
            this.txtBoxCiudad.Location = new System.Drawing.Point(71, 39);
            this.txtBoxCiudad.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtBoxCiudad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCiudad.Name = "txtBoxCiudad";
            this.txtBoxCiudad.PasswordChar = '\0';
            this.txtBoxCiudad.SelectedText = "";
            this.txtBoxCiudad.SelectionLength = 0;
            this.txtBoxCiudad.SelectionStart = 0;
            this.txtBoxCiudad.Size = new System.Drawing.Size(136, 23);
            this.txtBoxCiudad.TabIndex = 20;
            this.txtBoxCiudad.UseSystemPasswordChar = false;
            this.txtBoxCiudad.Leave += new System.EventHandler(this.txtBoxCiudad_Leave);
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPostal.Location = new System.Drawing.Point(505, 7);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(99, 17);
            this.lblCodigoPostal.TabIndex = 4;
            this.lblCodigoPostal.Text = "Código Postal:";
            // 
            // txtBoxDepartamento
            // 
            this.txtBoxDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDepartamento.Depth = 0;
            this.txtBoxDepartamento.Hint = "";
            this.txtBoxDepartamento.Location = new System.Drawing.Point(324, 4);
            this.txtBoxDepartamento.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtBoxDepartamento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDepartamento.Name = "txtBoxDepartamento";
            this.txtBoxDepartamento.PasswordChar = '\0';
            this.txtBoxDepartamento.SelectedText = "";
            this.txtBoxDepartamento.SelectionLength = 0;
            this.txtBoxDepartamento.SelectionStart = 0;
            this.txtBoxDepartamento.Size = new System.Drawing.Size(136, 23);
            this.txtBoxDepartamento.TabIndex = 24;
            this.txtBoxDepartamento.UseSystemPasswordChar = false;
            this.txtBoxDepartamento.Leave += new System.EventHandler(this.txtBoxDepartamento_Leave);
            // 
            // txtBoxCodigoPostal
            // 
            this.txtBoxCodigoPostal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoPostal.Depth = 0;
            this.txtBoxCodigoPostal.Hint = "";
            this.txtBoxCodigoPostal.Location = new System.Drawing.Point(610, 4);
            this.txtBoxCodigoPostal.Margin = new System.Windows.Forms.Padding(3, 3, 38, 3);
            this.txtBoxCodigoPostal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCodigoPostal.Name = "txtBoxCodigoPostal";
            this.txtBoxCodigoPostal.PasswordChar = '\0';
            this.txtBoxCodigoPostal.SelectedText = "";
            this.txtBoxCodigoPostal.SelectionLength = 0;
            this.txtBoxCodigoPostal.SelectionStart = 0;
            this.txtBoxCodigoPostal.Size = new System.Drawing.Size(109, 23);
            this.txtBoxCodigoPostal.TabIndex = 22;
            this.txtBoxCodigoPostal.UseSystemPasswordChar = false;
            this.txtBoxCodigoPostal.Leave += new System.EventHandler(this.txtBoxCodigoPostal_Leave);
            // 
            // epCalle
            // 
            this.epCalle.ContainerControl = this;
            // 
            // epNumeroDomicilio
            // 
            this.epNumeroDomicilio.ContainerControl = this;
            // 
            // epCiudad
            // 
            this.epCiudad.ContainerControl = this;
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
            // ControlDomicilio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblLayoutPanelDomicilio);
            this.Name = "ControlDomicilio";
            this.Size = new System.Drawing.Size(777, 101);
            this.tblLayoutPanelDomicilio.ResumeLayout(false);
            this.tblLayoutPanelDomicilio.PerformLayout();
            this.tblLayourPanelDomicilio_1.ResumeLayout(false);
            this.tblLayourPanelDomicilio_1.PerformLayout();
            this.tblLayoutPanelDomicilio_2.ResumeLayout(false);
            this.tblLayoutPanelDomicilio_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNumeroDomicilio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigoPostal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDomicilio;
        private System.Windows.Forms.TableLayoutPanel tblLayourPanelDomicilio_1;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCalle;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCalle;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxNumeroDomicilio;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDomicilio_2;
        private System.Windows.Forms.ComboBox cmbBoxPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ComboBox cmbBoxProvincia;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblCiudad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxPiso;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCiudad;
        private System.Windows.Forms.Label lblCodigoPostal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxDepartamento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCodigoPostal;
        private System.Windows.Forms.ErrorProvider epCalle;
        private System.Windows.Forms.ErrorProvider epNumeroDomicilio;
        private System.Windows.Forms.ErrorProvider epCiudad;
        private System.Windows.Forms.ErrorProvider epPiso;
        private System.Windows.Forms.ErrorProvider epDepartamento;
        private System.Windows.Forms.ErrorProvider epCodigoPostal;

    }
}
