namespace Vista
{
    partial class frmPedidoCierre_FormasDePago
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
            this.tblLayoutPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialFlatButton();
            this.tblLayoutPanelDescuentos = new System.Windows.Forms.TableLayoutPanel();
            this.dgvFormasPago = new System.Windows.Forms.DataGridView();
            this.tblLayoutPanelFormaPagoRestante = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFormaPagoRestante = new System.Windows.Forms.Label();
            this.cmbBoxFormaPagoRestante = new System.Windows.Forms.ComboBox();
            this.grpBoxFormaPagoNueva = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelFormaPago = new System.Windows.Forms.TableLayoutPanel();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.cmbBoxFormaPago = new System.Windows.Forms.ComboBox();
            this.txtBoxMonto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tblLayoutPanelFormaPagoBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgrearFormaPago = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnQuitarFormaPago = new MaterialSkin.Controls.MaterialFlatButton();
            this.tblLayoutPanelPrincipal.SuspendLayout();
            this.tblLayoutPanelBotones.SuspendLayout();
            this.tblLayoutPanelDescuentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormasPago)).BeginInit();
            this.tblLayoutPanelFormaPagoRestante.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpBoxFormaPagoNueva.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tblLayoutPanelFormaPago.SuspendLayout();
            this.tblLayoutPanelFormaPagoBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayoutPanelPrincipal
            // 
            this.tblLayoutPanelPrincipal.BackColor = System.Drawing.Color.White;
            this.tblLayoutPanelPrincipal.ColumnCount = 1;
            this.tblLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal.Controls.Add(this.tblLayoutPanelBotones, 0, 1);
            this.tblLayoutPanelPrincipal.Controls.Add(this.tblLayoutPanelDescuentos, 0, 0);
            this.tblLayoutPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblLayoutPanelPrincipal.Location = new System.Drawing.Point(0, 63);
            this.tblLayoutPanelPrincipal.Name = "tblLayoutPanelPrincipal";
            this.tblLayoutPanelPrincipal.RowCount = 2;
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblLayoutPanelPrincipal.Size = new System.Drawing.Size(528, 405);
            this.tblLayoutPanelPrincipal.TabIndex = 0;
            // 
            // tblLayoutPanelBotones
            // 
            this.tblLayoutPanelBotones.ColumnCount = 2;
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelBotones.Controls.Add(this.btnCancelar, 1, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.btnGuardar, 0, 0);
            this.tblLayoutPanelBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelBotones.Location = new System.Drawing.Point(3, 358);
            this.tblLayoutPanelBotones.Name = "tblLayoutPanelBotones";
            this.tblLayoutPanelBotones.RowCount = 1;
            this.tblLayoutPanelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tblLayoutPanelBotones.Size = new System.Drawing.Size(522, 44);
            this.tblLayoutPanelBotones.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(271, 6);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(10, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(82, 32);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(176, 6);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 10, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = false;
            this.btnGuardar.Size = new System.Drawing.Size(75, 32);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tblLayoutPanelDescuentos
            // 
            this.tblLayoutPanelDescuentos.ColumnCount = 2;
            this.tblLayoutPanelDescuentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.97216F));
            this.tblLayoutPanelDescuentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.02784F));
            this.tblLayoutPanelDescuentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelDescuentos.Controls.Add(this.dgvFormasPago, 1, 0);
            this.tblLayoutPanelDescuentos.Controls.Add(this.tblLayoutPanelFormaPagoRestante, 0, 0);
            this.tblLayoutPanelDescuentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDescuentos.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelDescuentos.Name = "tblLayoutPanelDescuentos";
            this.tblLayoutPanelDescuentos.RowCount = 1;
            this.tblLayoutPanelDescuentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDescuentos.Size = new System.Drawing.Size(522, 349);
            this.tblLayoutPanelDescuentos.TabIndex = 1;
            // 
            // dgvFormasPago
            // 
            this.dgvFormasPago.AllowUserToAddRows = false;
            this.dgvFormasPago.AllowUserToDeleteRows = false;
            this.dgvFormasPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFormasPago.BackgroundColor = System.Drawing.Color.White;
            this.dgvFormasPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormasPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFormasPago.GridColor = System.Drawing.Color.White;
            this.dgvFormasPago.Location = new System.Drawing.Point(274, 3);
            this.dgvFormasPago.Name = "dgvFormasPago";
            this.dgvFormasPago.ReadOnly = true;
            this.dgvFormasPago.RowHeadersVisible = false;
            this.dgvFormasPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFormasPago.Size = new System.Drawing.Size(245, 343);
            this.dgvFormasPago.TabIndex = 5;
            // 
            // tblLayoutPanelFormaPagoRestante
            // 
            this.tblLayoutPanelFormaPagoRestante.ColumnCount = 1;
            this.tblLayoutPanelFormaPagoRestante.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelFormaPagoRestante.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tblLayoutPanelFormaPagoRestante.Controls.Add(this.grpBoxFormaPagoNueva, 0, 0);
            this.tblLayoutPanelFormaPagoRestante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelFormaPagoRestante.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelFormaPagoRestante.Name = "tblLayoutPanelFormaPagoRestante";
            this.tblLayoutPanelFormaPagoRestante.RowCount = 2;
            this.tblLayoutPanelFormaPagoRestante.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.80851F));
            this.tblLayoutPanelFormaPagoRestante.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.19149F));
            this.tblLayoutPanelFormaPagoRestante.Size = new System.Drawing.Size(265, 343);
            this.tblLayoutPanelFormaPagoRestante.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblFormaPagoRestante, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbBoxFormaPagoRestante, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 249);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(259, 91);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblFormaPagoRestante
            // 
            this.lblFormaPagoRestante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFormaPagoRestante.AutoSize = true;
            this.lblFormaPagoRestante.Location = new System.Drawing.Point(3, 32);
            this.lblFormaPagoRestante.Name = "lblFormaPagoRestante";
            this.lblFormaPagoRestante.Size = new System.Drawing.Size(127, 13);
            this.lblFormaPagoRestante.TabIndex = 4;
            this.lblFormaPagoRestante.Text = "Forma De Pago Principal:";
            // 
            // cmbBoxFormaPagoRestante
            // 
            this.cmbBoxFormaPagoRestante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxFormaPagoRestante.FormattingEnabled = true;
            this.cmbBoxFormaPagoRestante.Location = new System.Drawing.Point(3, 48);
            this.cmbBoxFormaPagoRestante.Name = "cmbBoxFormaPagoRestante";
            this.cmbBoxFormaPagoRestante.Size = new System.Drawing.Size(253, 21);
            this.cmbBoxFormaPagoRestante.TabIndex = 4;
            this.cmbBoxFormaPagoRestante.SelectionChangeCommitted += new System.EventHandler(this.cmbBoxFormaPagoRestante_SelectionChangeCommitted);
            // 
            // grpBoxFormaPagoNueva
            // 
            this.grpBoxFormaPagoNueva.Controls.Add(this.tableLayoutPanel2);
            this.grpBoxFormaPagoNueva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxFormaPagoNueva.Location = new System.Drawing.Point(3, 3);
            this.grpBoxFormaPagoNueva.Name = "grpBoxFormaPagoNueva";
            this.grpBoxFormaPagoNueva.Size = new System.Drawing.Size(259, 240);
            this.grpBoxFormaPagoNueva.TabIndex = 4;
            this.grpBoxFormaPagoNueva.TabStop = false;
            this.grpBoxFormaPagoNueva.Text = "Forma de Pago";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.50711F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.49289F));
            this.tableLayoutPanel2.Controls.Add(this.tblLayoutPanelFormaPago, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tblLayoutPanelFormaPagoBotones, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(253, 221);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tblLayoutPanelFormaPago
            // 
            this.tblLayoutPanelFormaPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayoutPanelFormaPago.ColumnCount = 2;
            this.tblLayoutPanelFormaPago.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelFormaPago.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblLayoutPanelFormaPago.Controls.Add(this.lblFormaPago, 0, 2);
            this.tblLayoutPanelFormaPago.Controls.Add(this.lblMonto, 0, 0);
            this.tblLayoutPanelFormaPago.Controls.Add(this.cmbBoxFormaPago, 0, 3);
            this.tblLayoutPanelFormaPago.Controls.Add(this.txtBoxMonto, 0, 1);
            this.tblLayoutPanelFormaPago.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelFormaPago.Name = "tblLayoutPanelFormaPago";
            this.tblLayoutPanelFormaPago.RowCount = 4;
            this.tblLayoutPanelFormaPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.39344F));
            this.tblLayoutPanelFormaPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.96721F));
            this.tblLayoutPanelFormaPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.93443F));
            this.tblLayoutPanelFormaPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.70491F));
            this.tblLayoutPanelFormaPago.Size = new System.Drawing.Size(154, 134);
            this.tblLayoutPanelFormaPago.TabIndex = 4;
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(3, 68);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(81, 13);
            this.lblFormaPago.TabIndex = 2;
            this.lblFormaPago.Text = "Forma De Pago";
            // 
            // lblMonto
            // 
            this.lblMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(3, 8);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 4;
            this.lblMonto.Text = "Monto:";
            // 
            // cmbBoxFormaPago
            // 
            this.cmbBoxFormaPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxFormaPago.FormattingEnabled = true;
            this.cmbBoxFormaPago.Location = new System.Drawing.Point(3, 84);
            this.cmbBoxFormaPago.Name = "cmbBoxFormaPago";
            this.cmbBoxFormaPago.Size = new System.Drawing.Size(123, 21);
            this.cmbBoxFormaPago.TabIndex = 1;
            // 
            // txtBoxMonto
            // 
            this.txtBoxMonto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxMonto.Depth = 0;
            this.txtBoxMonto.Hint = "";
            this.txtBoxMonto.Location = new System.Drawing.Point(3, 24);
            this.txtBoxMonto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxMonto.Name = "txtBoxMonto";
            this.txtBoxMonto.PasswordChar = '\0';
            this.txtBoxMonto.SelectedText = "";
            this.txtBoxMonto.SelectionLength = 0;
            this.txtBoxMonto.SelectionStart = 0;
            this.txtBoxMonto.Size = new System.Drawing.Size(123, 23);
            this.txtBoxMonto.TabIndex = 0;
            this.txtBoxMonto.UseSystemPasswordChar = false;
            this.txtBoxMonto.Leave += new System.EventHandler(this.txtBoxMonto_Leave);
            // 
            // tblLayoutPanelFormaPagoBotones
            // 
            this.tblLayoutPanelFormaPagoBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayoutPanelFormaPagoBotones.ColumnCount = 1;
            this.tblLayoutPanelFormaPagoBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelFormaPagoBotones.Controls.Add(this.btnAgrearFormaPago, 0, 0);
            this.tblLayoutPanelFormaPagoBotones.Controls.Add(this.btnQuitarFormaPago, 0, 1);
            this.tblLayoutPanelFormaPagoBotones.Location = new System.Drawing.Point(163, 3);
            this.tblLayoutPanelFormaPagoBotones.Name = "tblLayoutPanelFormaPagoBotones";
            this.tblLayoutPanelFormaPagoBotones.RowCount = 2;
            this.tblLayoutPanelFormaPagoBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelFormaPagoBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelFormaPagoBotones.Size = new System.Drawing.Size(87, 134);
            this.tblLayoutPanelFormaPagoBotones.TabIndex = 3;
            // 
            // btnAgrearFormaPago
            // 
            this.btnAgrearFormaPago.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgrearFormaPago.AutoSize = true;
            this.btnAgrearFormaPago.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgrearFormaPago.Depth = 0;
            this.btnAgrearFormaPago.Location = new System.Drawing.Point(6, 25);
            this.btnAgrearFormaPago.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgrearFormaPago.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgrearFormaPago.Name = "btnAgrearFormaPago";
            this.btnAgrearFormaPago.Primary = false;
            this.btnAgrearFormaPago.Size = new System.Drawing.Size(74, 36);
            this.btnAgrearFormaPago.TabIndex = 2;
            this.btnAgrearFormaPago.Text = "Agregar";
            this.btnAgrearFormaPago.UseVisualStyleBackColor = true;
            this.btnAgrearFormaPago.Click += new System.EventHandler(this.btnAgrearFormaPago_Click);
            // 
            // btnQuitarFormaPago
            // 
            this.btnQuitarFormaPago.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuitarFormaPago.AutoSize = true;
            this.btnQuitarFormaPago.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuitarFormaPago.Depth = 0;
            this.btnQuitarFormaPago.Location = new System.Drawing.Point(13, 73);
            this.btnQuitarFormaPago.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuitarFormaPago.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitarFormaPago.Name = "btnQuitarFormaPago";
            this.btnQuitarFormaPago.Primary = false;
            this.btnQuitarFormaPago.Size = new System.Drawing.Size(60, 36);
            this.btnQuitarFormaPago.TabIndex = 3;
            this.btnQuitarFormaPago.Text = "Quitar";
            this.btnQuitarFormaPago.UseVisualStyleBackColor = true;
            this.btnQuitarFormaPago.Click += new System.EventHandler(this.btnQuitarFormaPago_Click);
            // 
            // frmPedidoCierre_FormasDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 468);
            this.Controls.Add(this.tblLayoutPanelPrincipal);
            this.MinimumSize = new System.Drawing.Size(395, 286);
            this.Name = "frmPedidoCierre_FormasDePago";
            this.Text = "Formas de Pago";
            this.tblLayoutPanelPrincipal.ResumeLayout(false);
            this.tblLayoutPanelBotones.ResumeLayout(false);
            this.tblLayoutPanelBotones.PerformLayout();
            this.tblLayoutPanelDescuentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormasPago)).EndInit();
            this.tblLayoutPanelFormaPagoRestante.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpBoxFormaPagoNueva.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tblLayoutPanelFormaPago.ResumeLayout(false);
            this.tblLayoutPanelFormaPago.PerformLayout();
            this.tblLayoutPanelFormaPagoBotones.ResumeLayout(false);
            this.tblLayoutPanelFormaPagoBotones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelPrincipal;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDescuentos;
        private System.Windows.Forms.DataGridView dgvFormasPago;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelBotones;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelFormaPagoRestante;
        private System.Windows.Forms.Label lblFormaPagoRestante;
        private System.Windows.Forms.ComboBox cmbBoxFormaPagoRestante;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpBoxFormaPagoNueva;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelFormaPago;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.ComboBox cmbBoxFormaPago;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelFormaPagoBotones;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxMonto;
        private MaterialSkin.Controls.MaterialFlatButton btnAgrearFormaPago;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private MaterialSkin.Controls.MaterialFlatButton btnGuardar;
        private MaterialSkin.Controls.MaterialFlatButton btnQuitarFormaPago;
    }
}