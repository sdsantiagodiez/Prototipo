namespace Vista
{
    partial class frmDescuentosArticulos
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxDescuento = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelDescuento = new System.Windows.Forms.TableLayoutPanel();
            this.lblnumeroDescuento = new System.Windows.Forms.Label();
            this.lblfechaDesde = new System.Windows.Forms.Label();
            this.lblfechaHasta = new System.Windows.Forms.Label();
            this.tbxFechaHasta = new System.Windows.Forms.TextBox();
            this.tbxFechaDesde = new System.Windows.Forms.TextBox();
            this.lblporcentajeDescuento = new System.Windows.Forms.Label();
            this.tbxnumeroDescuento = new System.Windows.Forms.TextBox();
            this.tbxPorcentajeDescuento = new System.Windows.Forms.TextBox();
            this.grpBoxArticulo = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelArticulo = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtBoxDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxCodigoOriginal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxCodigoArticulo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCodigoOriginal = new System.Windows.Forms.Label();
            this.lblCodigoProveedor = new System.Windows.Forms.Label();
            this.btnModificarArticulo = new MaterialSkin.Controls.MaterialFlatButton();
            this.grpBoxListaDescuentos = new System.Windows.Forms.GroupBox();
            this.dgvDescuentos = new System.Windows.Forms.DataGridView();
            this.indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderActual)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpBoxDescuento.SuspendLayout();
            this.tblLayoutPanelDescuento.SuspendLayout();
            this.grpBoxArticulo.SuspendLayout();
            this.tblLayoutPanelArticulo.SuspendLayout();
            this.grpBoxListaDescuentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grpBoxDescuento, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grpBoxArticulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpBoxListaDescuentos, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 496);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // grpBoxDescuento
            // 
            this.grpBoxDescuento.Controls.Add(this.tblLayoutPanelDescuento);
            this.grpBoxDescuento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDescuento.Location = new System.Drawing.Point(3, 156);
            this.grpBoxDescuento.Name = "grpBoxDescuento";
            this.grpBoxDescuento.Size = new System.Drawing.Size(444, 99);
            this.grpBoxDescuento.TabIndex = 11;
            this.grpBoxDescuento.TabStop = false;
            this.grpBoxDescuento.Text = "Descuento";
            // 
            // tblLayoutPanelDescuento
            // 
            this.tblLayoutPanelDescuento.ColumnCount = 6;
            this.tblLayoutPanelDescuento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelDescuento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tblLayoutPanelDescuento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.tblLayoutPanelDescuento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelDescuento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tblLayoutPanelDescuento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.tblLayoutPanelDescuento.Controls.Add(this.lblnumeroDescuento, 0, 0);
            this.tblLayoutPanelDescuento.Controls.Add(this.lblfechaDesde, 3, 1);
            this.tblLayoutPanelDescuento.Controls.Add(this.lblfechaHasta, 0, 1);
            this.tblLayoutPanelDescuento.Controls.Add(this.tbxFechaHasta, 4, 1);
            this.tblLayoutPanelDescuento.Controls.Add(this.tbxFechaDesde, 1, 1);
            this.tblLayoutPanelDescuento.Controls.Add(this.lblporcentajeDescuento, 3, 0);
            this.tblLayoutPanelDescuento.Controls.Add(this.tbxnumeroDescuento, 1, 0);
            this.tblLayoutPanelDescuento.Controls.Add(this.tbxPorcentajeDescuento, 4, 0);
            this.tblLayoutPanelDescuento.Location = new System.Drawing.Point(3, 23);
            this.tblLayoutPanelDescuento.Name = "tblLayoutPanelDescuento";
            this.tblLayoutPanelDescuento.RowCount = 2;
            this.tblLayoutPanelDescuento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDescuento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDescuento.Size = new System.Drawing.Size(438, 65);
            this.tblLayoutPanelDescuento.TabIndex = 0;
            // 
            // lblnumeroDescuento
            // 
            this.lblnumeroDescuento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblnumeroDescuento.AutoSize = true;
            this.lblnumeroDescuento.Location = new System.Drawing.Point(50, 7);
            this.lblnumeroDescuento.Name = "lblnumeroDescuento";
            this.lblnumeroDescuento.Size = new System.Drawing.Size(56, 18);
            this.lblnumeroDescuento.TabIndex = 4;
            this.lblnumeroDescuento.Text = "Codigo";
            // 
            // lblfechaDesde
            // 
            this.lblfechaDesde.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblfechaDesde.AutoSize = true;
            this.lblfechaDesde.Location = new System.Drawing.Point(231, 39);
            this.lblfechaDesde.Name = "lblfechaDesde";
            this.lblfechaDesde.Size = new System.Drawing.Size(92, 18);
            this.lblfechaDesde.TabIndex = 0;
            this.lblfechaDesde.Text = "Fecha Hasta";
            // 
            // lblfechaHasta
            // 
            this.lblfechaHasta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblfechaHasta.AutoSize = true;
            this.lblfechaHasta.Location = new System.Drawing.Point(10, 39);
            this.lblfechaHasta.Name = "lblfechaHasta";
            this.lblfechaHasta.Size = new System.Drawing.Size(96, 18);
            this.lblfechaHasta.TabIndex = 1;
            this.lblfechaHasta.Text = "Fecha Desde";
            // 
            // tbxFechaHasta
            // 
            this.tbxFechaHasta.Location = new System.Drawing.Point(329, 35);
            this.tbxFechaHasta.Name = "tbxFechaHasta";
            this.tbxFechaHasta.Size = new System.Drawing.Size(92, 24);
            this.tbxFechaHasta.TabIndex = 2;
            this.tbxFechaHasta.Validating += new System.ComponentModel.CancelEventHandler(this.tbxFechaHasta_Validating);
            // 
            // tbxFechaDesde
            // 
            this.tbxFechaDesde.Location = new System.Drawing.Point(112, 35);
            this.tbxFechaDesde.Name = "tbxFechaDesde";
            this.tbxFechaDesde.Size = new System.Drawing.Size(92, 24);
            this.tbxFechaDesde.TabIndex = 3;
            this.tbxFechaDesde.Validating += new System.ComponentModel.CancelEventHandler(this.tbxFechaDesde_Validating);
            // 
            // lblporcentajeDescuento
            // 
            this.lblporcentajeDescuento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblporcentajeDescuento.AutoSize = true;
            this.lblporcentajeDescuento.Location = new System.Drawing.Point(244, 7);
            this.lblporcentajeDescuento.Name = "lblporcentajeDescuento";
            this.lblporcentajeDescuento.Size = new System.Drawing.Size(79, 18);
            this.lblporcentajeDescuento.TabIndex = 5;
            this.lblporcentajeDescuento.Text = "Porcentaje";
            // 
            // tbxnumeroDescuento
            // 
            this.tbxnumeroDescuento.Location = new System.Drawing.Point(112, 3);
            this.tbxnumeroDescuento.Name = "tbxnumeroDescuento";
            this.tbxnumeroDescuento.Size = new System.Drawing.Size(92, 24);
            this.tbxnumeroDescuento.TabIndex = 6;
            // 
            // tbxPorcentajeDescuento
            // 
            this.tbxPorcentajeDescuento.Location = new System.Drawing.Point(329, 3);
            this.tbxPorcentajeDescuento.Name = "tbxPorcentajeDescuento";
            this.tbxPorcentajeDescuento.Size = new System.Drawing.Size(92, 24);
            this.tbxPorcentajeDescuento.TabIndex = 7;
            // 
            // grpBoxArticulo
            // 
            this.grpBoxArticulo.Controls.Add(this.tblLayoutPanelArticulo);
            this.grpBoxArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxArticulo.Location = new System.Drawing.Point(3, 3);
            this.grpBoxArticulo.Name = "grpBoxArticulo";
            this.grpBoxArticulo.Size = new System.Drawing.Size(444, 147);
            this.grpBoxArticulo.TabIndex = 9;
            this.grpBoxArticulo.TabStop = false;
            this.grpBoxArticulo.Text = "Artículo";
            // 
            // tblLayoutPanelArticulo
            // 
            this.tblLayoutPanelArticulo.ColumnCount = 3;
            this.tblLayoutPanelArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLayoutPanelArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tblLayoutPanelArticulo.Controls.Add(this.lblDescripcion, 0, 2);
            this.tblLayoutPanelArticulo.Controls.Add(this.txtBoxDescripcion, 1, 2);
            this.tblLayoutPanelArticulo.Controls.Add(this.txtBoxCodigoOriginal, 1, 1);
            this.tblLayoutPanelArticulo.Controls.Add(this.txtBoxCodigoArticulo, 1, 0);
            this.tblLayoutPanelArticulo.Controls.Add(this.lblCodigoOriginal, 0, 1);
            this.tblLayoutPanelArticulo.Controls.Add(this.lblCodigoProveedor, 0, 0);
            this.tblLayoutPanelArticulo.Controls.Add(this.btnModificarArticulo, 2, 1);
            this.tblLayoutPanelArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelArticulo.Location = new System.Drawing.Point(3, 20);
            this.tblLayoutPanelArticulo.Name = "tblLayoutPanelArticulo";
            this.tblLayoutPanelArticulo.RowCount = 3;
            this.tblLayoutPanelArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelArticulo.Size = new System.Drawing.Size(438, 124);
            this.tblLayoutPanelArticulo.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(30, 94);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(87, 18);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescripcion.Depth = 0;
            this.txtBoxDescripcion.Hint = "";
            this.txtBoxDescripcion.Location = new System.Drawing.Point(123, 91);
            this.txtBoxDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.PasswordChar = '\0';
            this.txtBoxDescripcion.SelectedText = "";
            this.txtBoxDescripcion.SelectionLength = 0;
            this.txtBoxDescripcion.SelectionStart = 0;
            this.txtBoxDescripcion.Size = new System.Drawing.Size(227, 23);
            this.txtBoxDescripcion.TabIndex = 10;
            this.txtBoxDescripcion.UseSystemPasswordChar = false;
            // 
            // txtBoxCodigoOriginal
            // 
            this.txtBoxCodigoOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoOriginal.Depth = 0;
            this.txtBoxCodigoOriginal.Hint = "";
            this.txtBoxCodigoOriginal.Location = new System.Drawing.Point(123, 50);
            this.txtBoxCodigoOriginal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCodigoOriginal.Name = "txtBoxCodigoOriginal";
            this.txtBoxCodigoOriginal.PasswordChar = '\0';
            this.txtBoxCodigoOriginal.SelectedText = "";
            this.txtBoxCodigoOriginal.SelectionLength = 0;
            this.txtBoxCodigoOriginal.SelectionStart = 0;
            this.txtBoxCodigoOriginal.Size = new System.Drawing.Size(227, 23);
            this.txtBoxCodigoOriginal.TabIndex = 9;
            this.txtBoxCodigoOriginal.UseSystemPasswordChar = false;
            // 
            // txtBoxCodigoArticulo
            // 
            this.txtBoxCodigoArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoArticulo.Depth = 0;
            this.txtBoxCodigoArticulo.Hint = "";
            this.txtBoxCodigoArticulo.Location = new System.Drawing.Point(123, 9);
            this.txtBoxCodigoArticulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCodigoArticulo.Name = "txtBoxCodigoArticulo";
            this.txtBoxCodigoArticulo.PasswordChar = '\0';
            this.txtBoxCodigoArticulo.SelectedText = "";
            this.txtBoxCodigoArticulo.SelectionLength = 0;
            this.txtBoxCodigoArticulo.SelectionStart = 0;
            this.txtBoxCodigoArticulo.Size = new System.Drawing.Size(227, 23);
            this.txtBoxCodigoArticulo.TabIndex = 10;
            this.txtBoxCodigoArticulo.UseSystemPasswordChar = false;
            // 
            // lblCodigoOriginal
            // 
            this.lblCodigoOriginal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoOriginal.AutoSize = true;
            this.lblCodigoOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoOriginal.Location = new System.Drawing.Point(7, 52);
            this.lblCodigoOriginal.Name = "lblCodigoOriginal";
            this.lblCodigoOriginal.Size = new System.Drawing.Size(110, 18);
            this.lblCodigoOriginal.TabIndex = 4;
            this.lblCodigoOriginal.Text = "Código Original";
            // 
            // lblCodigoProveedor
            // 
            this.lblCodigoProveedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoProveedor.AutoSize = true;
            this.lblCodigoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProveedor.Location = new System.Drawing.Point(8, 11);
            this.lblCodigoProveedor.Name = "lblCodigoProveedor";
            this.lblCodigoProveedor.Size = new System.Drawing.Size(109, 18);
            this.lblCodigoProveedor.TabIndex = 5;
            this.lblCodigoProveedor.Text = "Código Artículo";
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarArticulo.AutoSize = true;
            this.btnModificarArticulo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarArticulo.Depth = 0;
            this.btnModificarArticulo.Location = new System.Drawing.Point(357, 47);
            this.btnModificarArticulo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificarArticulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Primary = false;
            this.btnModificarArticulo.Size = new System.Drawing.Size(77, 29);
            this.btnModificarArticulo.TabIndex = 8;
            this.btnModificarArticulo.Text = "Modificar";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // grpBoxListaDescuentos
            // 
            this.grpBoxListaDescuentos.Controls.Add(this.dgvDescuentos);
            this.grpBoxListaDescuentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxListaDescuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxListaDescuentos.Location = new System.Drawing.Point(3, 261);
            this.grpBoxListaDescuentos.Name = "grpBoxListaDescuentos";
            this.grpBoxListaDescuentos.Size = new System.Drawing.Size(444, 232);
            this.grpBoxListaDescuentos.TabIndex = 8;
            this.grpBoxListaDescuentos.TabStop = false;
            this.grpBoxListaDescuentos.Text = "Lista de Descuentos";
            // 
            // dgvDescuentos
            // 
            this.dgvDescuentos.AllowUserToAddRows = false;
            this.dgvDescuentos.AllowUserToDeleteRows = false;
            this.dgvDescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescuentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indice,
            this.numeroDescuento,
            this.fechaDesde,
            this.fechaHasta,
            this.porcentajeDescuento});
            this.dgvDescuentos.Location = new System.Drawing.Point(6, 21);
            this.dgvDescuentos.Name = "dgvDescuentos";
            this.dgvDescuentos.ReadOnly = true;
            this.dgvDescuentos.Size = new System.Drawing.Size(435, 202);
            this.dgvDescuentos.TabIndex = 0;
            this.dgvDescuentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDescuentos_CellClick);
            // 
            // indice
            // 
            this.indice.DataPropertyName = "indice";
            this.indice.HeaderText = "indice";
            this.indice.Name = "indice";
            this.indice.ReadOnly = true;
            this.indice.Visible = false;
            // 
            // numeroDescuento
            // 
            this.numeroDescuento.DataPropertyName = "numeroDescuento";
            this.numeroDescuento.HeaderText = "Num";
            this.numeroDescuento.Name = "numeroDescuento";
            this.numeroDescuento.ReadOnly = true;
            this.numeroDescuento.Width = 50;
            // 
            // fechaDesde
            // 
            this.fechaDesde.DataPropertyName = "fechaDesde";
            this.fechaDesde.HeaderText = "FechaDesde";
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.ReadOnly = true;
            this.fechaDesde.Width = 120;
            // 
            // fechaHasta
            // 
            this.fechaHasta.DataPropertyName = "fechaHasta";
            this.fechaHasta.HeaderText = "FechaHasta";
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.ReadOnly = true;
            this.fechaHasta.Width = 120;
            // 
            // porcentajeDescuento
            // 
            this.porcentajeDescuento.DataPropertyName = "porcentajeDescuento";
            this.porcentajeDescuento.HeaderText = "Porcentaje";
            this.porcentajeDescuento.Name = "porcentajeDescuento";
            this.porcentajeDescuento.ReadOnly = true;
            // 
            // frmDescuentosArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 559);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 559);
            this.Name = "frmDescuentosArticulos";
            this.Text = "Descuentos por Articulo";
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderActual)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpBoxDescuento.ResumeLayout(false);
            this.tblLayoutPanelDescuento.ResumeLayout(false);
            this.tblLayoutPanelDescuento.PerformLayout();
            this.grpBoxArticulo.ResumeLayout(false);
            this.tblLayoutPanelArticulo.ResumeLayout(false);
            this.tblLayoutPanelArticulo.PerformLayout();
            this.grpBoxListaDescuentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpBoxArticulo;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelArticulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCodigoOriginal;
        private System.Windows.Forms.Label lblCodigoProveedor;
        private System.Windows.Forms.GroupBox grpBoxDescuento;
        private System.Windows.Forms.GroupBox grpBoxListaDescuentos;
        private MaterialSkin.Controls.MaterialFlatButton btnModificarArticulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCodigoOriginal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxDescripcion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCodigoArticulo;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDescuento;
        private System.Windows.Forms.Label lblnumeroDescuento;
        private System.Windows.Forms.Label lblfechaDesde;
        private System.Windows.Forms.Label lblfechaHasta;
        private System.Windows.Forms.TextBox tbxFechaHasta;
        private System.Windows.Forms.TextBox tbxFechaDesde;
        private System.Windows.Forms.Label lblporcentajeDescuento;
        private System.Windows.Forms.TextBox tbxnumeroDescuento;
        private System.Windows.Forms.TextBox tbxPorcentajeDescuento;
        private System.Windows.Forms.DataGridView dgvDescuentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeDescuento;
    }
}