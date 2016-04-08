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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpBoxFormaPago = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelDescuentos = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelFormaPago = new System.Windows.Forms.TableLayoutPanel();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtBoxMonto = new System.Windows.Forms.TextBox();
            this.cmbBoxFormaPago = new System.Windows.Forms.ComboBox();
            this.dgvFormasPago = new System.Windows.Forms.DataGridView();
            this.tblLayoutPanelFormaPagoBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgrearFormaPago = new System.Windows.Forms.Button();
            this.btnQuitarFormaPago = new System.Windows.Forms.Button();
            this.tblLayoutPanelFormaPagoRestante = new System.Windows.Forms.TableLayoutPanel();
            this.lblFormaPagoRestante = new System.Windows.Forms.Label();
            this.cmbBoxFormaPagoRestante = new System.Windows.Forms.ComboBox();
            this.tblLayoutPanelPrincipal.SuspendLayout();
            this.tblLayoutPanelBotones.SuspendLayout();
            this.grpBoxFormaPago.SuspendLayout();
            this.tblLayoutPanelDescuentos.SuspendLayout();
            this.tblLayoutPanelFormaPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormasPago)).BeginInit();
            this.tblLayoutPanelFormaPagoBotones.SuspendLayout();
            this.tblLayoutPanelFormaPagoRestante.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayoutPanelPrincipal
            // 
            this.tblLayoutPanelPrincipal.ColumnCount = 1;
            this.tblLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.47887F));
            this.tblLayoutPanelPrincipal.Controls.Add(this.tblLayoutPanelBotones, 0, 2);
            this.tblLayoutPanelPrincipal.Controls.Add(this.grpBoxFormaPago, 0, 0);
            this.tblLayoutPanelPrincipal.Controls.Add(this.tblLayoutPanelFormaPagoRestante, 0, 1);
            this.tblLayoutPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanelPrincipal.Name = "tblLayoutPanelPrincipal";
            this.tblLayoutPanelPrincipal.RowCount = 3;
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.82278F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.17722F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tblLayoutPanelPrincipal.Size = new System.Drawing.Size(443, 435);
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
            this.tblLayoutPanelBotones.Location = new System.Drawing.Point(3, 335);
            this.tblLayoutPanelBotones.Name = "tblLayoutPanelBotones";
            this.tblLayoutPanelBotones.RowCount = 1;
            this.tblLayoutPanelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tblLayoutPanelBotones.Size = new System.Drawing.Size(437, 97);
            this.tblLayoutPanelBotones.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(290, 37);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.Location = new System.Drawing.Point(71, 37);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grpBoxFormaPago
            // 
            this.grpBoxFormaPago.Controls.Add(this.tblLayoutPanelDescuentos);
            this.grpBoxFormaPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxFormaPago.Location = new System.Drawing.Point(3, 3);
            this.grpBoxFormaPago.Name = "grpBoxFormaPago";
            this.grpBoxFormaPago.Size = new System.Drawing.Size(437, 213);
            this.grpBoxFormaPago.TabIndex = 2;
            this.grpBoxFormaPago.TabStop = false;
            this.grpBoxFormaPago.Text = "Formas De Pago";
            // 
            // tblLayoutPanelDescuentos
            // 
            this.tblLayoutPanelDescuentos.ColumnCount = 3;
            this.tblLayoutPanelDescuentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLayoutPanelDescuentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblLayoutPanelDescuentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblLayoutPanelDescuentos.Controls.Add(this.tblLayoutPanelFormaPago, 0, 0);
            this.tblLayoutPanelDescuentos.Controls.Add(this.dgvFormasPago, 2, 0);
            this.tblLayoutPanelDescuentos.Controls.Add(this.tblLayoutPanelFormaPagoBotones, 1, 0);
            this.tblLayoutPanelDescuentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDescuentos.Location = new System.Drawing.Point(3, 16);
            this.tblLayoutPanelDescuentos.Name = "tblLayoutPanelDescuentos";
            this.tblLayoutPanelDescuentos.RowCount = 1;
            this.tblLayoutPanelDescuentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDescuentos.Size = new System.Drawing.Size(431, 194);
            this.tblLayoutPanelDescuentos.TabIndex = 1;
            // 
            // tblLayoutPanelFormaPago
            // 
            this.tblLayoutPanelFormaPago.ColumnCount = 1;
            this.tblLayoutPanelFormaPago.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelFormaPago.Controls.Add(this.lblFormaPago, 0, 2);
            this.tblLayoutPanelFormaPago.Controls.Add(this.lblMonto, 0, 0);
            this.tblLayoutPanelFormaPago.Controls.Add(this.txtBoxMonto, 0, 1);
            this.tblLayoutPanelFormaPago.Controls.Add(this.cmbBoxFormaPago, 0, 3);
            this.tblLayoutPanelFormaPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelFormaPago.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelFormaPago.Name = "tblLayoutPanelFormaPago";
            this.tblLayoutPanelFormaPago.RowCount = 4;
            this.tblLayoutPanelFormaPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLayoutPanelFormaPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLayoutPanelFormaPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLayoutPanelFormaPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLayoutPanelFormaPago.Size = new System.Drawing.Size(134, 188);
            this.tblLayoutPanelFormaPago.TabIndex = 4;
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(3, 128);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(81, 13);
            this.lblFormaPago.TabIndex = 2;
            this.lblFormaPago.Text = "Forma De Pago";
            // 
            // lblMonto
            // 
            this.lblMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(3, 34);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 4;
            this.lblMonto.Text = "Monto:";
            // 
            // txtBoxMonto
            // 
            this.txtBoxMonto.Location = new System.Drawing.Point(3, 50);
            this.txtBoxMonto.Name = "txtBoxMonto";
            this.txtBoxMonto.Size = new System.Drawing.Size(128, 20);
            this.txtBoxMonto.TabIndex = 5;
            // 
            // cmbBoxFormaPago
            // 
            this.cmbBoxFormaPago.FormattingEnabled = true;
            this.cmbBoxFormaPago.Location = new System.Drawing.Point(3, 144);
            this.cmbBoxFormaPago.Name = "cmbBoxFormaPago";
            this.cmbBoxFormaPago.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxFormaPago.TabIndex = 6;
            // 
            // dgvFormasPago
            // 
            this.dgvFormasPago.AllowUserToAddRows = false;
            this.dgvFormasPago.AllowUserToDeleteRows = false;
            this.dgvFormasPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFormasPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormasPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFormasPago.Location = new System.Drawing.Point(223, 3);
            this.dgvFormasPago.Name = "dgvFormasPago";
            this.dgvFormasPago.ReadOnly = true;
            this.dgvFormasPago.RowHeadersVisible = false;
            this.dgvFormasPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFormasPago.Size = new System.Drawing.Size(205, 188);
            this.dgvFormasPago.TabIndex = 5;
            // 
            // tblLayoutPanelFormaPagoBotones
            // 
            this.tblLayoutPanelFormaPagoBotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tblLayoutPanelFormaPagoBotones.ColumnCount = 1;
            this.tblLayoutPanelFormaPagoBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelFormaPagoBotones.Controls.Add(this.btnAgrearFormaPago, 0, 0);
            this.tblLayoutPanelFormaPagoBotones.Controls.Add(this.btnQuitarFormaPago, 0, 1);
            this.tblLayoutPanelFormaPagoBotones.Location = new System.Drawing.Point(143, 3);
            this.tblLayoutPanelFormaPagoBotones.Name = "tblLayoutPanelFormaPagoBotones";
            this.tblLayoutPanelFormaPagoBotones.RowCount = 2;
            this.tblLayoutPanelFormaPagoBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelFormaPagoBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelFormaPagoBotones.Size = new System.Drawing.Size(74, 188);
            this.tblLayoutPanelFormaPagoBotones.TabIndex = 3;
            // 
            // btnAgrearFormaPago
            // 
            this.btnAgrearFormaPago.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgrearFormaPago.Location = new System.Drawing.Point(3, 66);
            this.btnAgrearFormaPago.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.btnAgrearFormaPago.Name = "btnAgrearFormaPago";
            this.btnAgrearFormaPago.Size = new System.Drawing.Size(68, 23);
            this.btnAgrearFormaPago.TabIndex = 1;
            this.btnAgrearFormaPago.Text = "Agregar";
            this.btnAgrearFormaPago.UseVisualStyleBackColor = true;
            this.btnAgrearFormaPago.Click += new System.EventHandler(this.btnAgrearFormaPago_Click);
            // 
            // btnQuitarFormaPago
            // 
            this.btnQuitarFormaPago.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuitarFormaPago.Location = new System.Drawing.Point(3, 99);
            this.btnQuitarFormaPago.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnQuitarFormaPago.Name = "btnQuitarFormaPago";
            this.btnQuitarFormaPago.Size = new System.Drawing.Size(68, 23);
            this.btnQuitarFormaPago.TabIndex = 2;
            this.btnQuitarFormaPago.Text = "Quitar";
            this.btnQuitarFormaPago.UseVisualStyleBackColor = true;
            this.btnQuitarFormaPago.Click += new System.EventHandler(this.btnQuitarFormaPago_Click);
            // 
            // tblLayoutPanelFormaPagoRestante
            // 
            this.tblLayoutPanelFormaPagoRestante.ColumnCount = 2;
            this.tblLayoutPanelFormaPagoRestante.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelFormaPagoRestante.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelFormaPagoRestante.Controls.Add(this.lblFormaPagoRestante, 0, 0);
            this.tblLayoutPanelFormaPagoRestante.Controls.Add(this.cmbBoxFormaPagoRestante, 0, 1);
            this.tblLayoutPanelFormaPagoRestante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelFormaPagoRestante.Location = new System.Drawing.Point(3, 222);
            this.tblLayoutPanelFormaPagoRestante.Name = "tblLayoutPanelFormaPagoRestante";
            this.tblLayoutPanelFormaPagoRestante.RowCount = 2;
            this.tblLayoutPanelFormaPagoRestante.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelFormaPagoRestante.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelFormaPagoRestante.Size = new System.Drawing.Size(437, 107);
            this.tblLayoutPanelFormaPagoRestante.TabIndex = 4;
            // 
            // lblFormaPagoRestante
            // 
            this.lblFormaPagoRestante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFormaPagoRestante.AutoSize = true;
            this.lblFormaPagoRestante.Location = new System.Drawing.Point(3, 40);
            this.lblFormaPagoRestante.Name = "lblFormaPagoRestante";
            this.lblFormaPagoRestante.Size = new System.Drawing.Size(127, 13);
            this.lblFormaPagoRestante.TabIndex = 4;
            this.lblFormaPagoRestante.Text = "Forma De Pago Principal:";
            // 
            // cmbBoxFormaPagoRestante
            // 
            this.cmbBoxFormaPagoRestante.FormattingEnabled = true;
            this.cmbBoxFormaPagoRestante.Location = new System.Drawing.Point(3, 56);
            this.cmbBoxFormaPagoRestante.Name = "cmbBoxFormaPagoRestante";
            this.cmbBoxFormaPagoRestante.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxFormaPagoRestante.TabIndex = 7;
            this.cmbBoxFormaPagoRestante.SelectionChangeCommitted += new System.EventHandler(this.cmbBoxFormaPagoRestante_SelectionChangeCommitted);
            // 
            // frmPedidoCierre_FormasDePago
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(443, 435);
            this.Controls.Add(this.tblLayoutPanelPrincipal);
            this.Name = "frmPedidoCierre_FormasDePago";
            this.Text = "frmPedidoCierre_FormasDePago";
            this.tblLayoutPanelPrincipal.ResumeLayout(false);
            this.tblLayoutPanelBotones.ResumeLayout(false);
            this.grpBoxFormaPago.ResumeLayout(false);
            this.tblLayoutPanelDescuentos.ResumeLayout(false);
            this.tblLayoutPanelFormaPago.ResumeLayout(false);
            this.tblLayoutPanelFormaPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormasPago)).EndInit();
            this.tblLayoutPanelFormaPagoBotones.ResumeLayout(false);
            this.tblLayoutPanelFormaPagoRestante.ResumeLayout(false);
            this.tblLayoutPanelFormaPagoRestante.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelPrincipal;
        private System.Windows.Forms.GroupBox grpBoxFormaPago;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDescuentos;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelFormaPago;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtBoxMonto;
        private System.Windows.Forms.DataGridView dgvFormasPago;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelFormaPagoBotones;
        private System.Windows.Forms.Button btnAgrearFormaPago;
        private System.Windows.Forms.Button btnQuitarFormaPago;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelBotones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelFormaPagoRestante;
        private System.Windows.Forms.Label lblFormaPagoRestante;
        private System.Windows.Forms.ComboBox cmbBoxFormaPago;
        private System.Windows.Forms.ComboBox cmbBoxFormaPagoRestante;
    }
}