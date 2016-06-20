namespace Vista
{
    partial class frmPedidoNuevo_editarCantidad
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
            this.tblLayoutPanelDetallesArticuloOpciones = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelDetalleArticuloBotones = new System.Windows.Forms.TableLayoutPanel();
            this.nmrcUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnEditar = new MaterialSkin.Controls.MaterialFlatButton();
            this.chckBoxPermitirStockNegativo = new MaterialSkin.Controls.MaterialCheckBox();
            this.tblLayoutPanelDetallesArticuloOpciones.SuspendLayout();
            this.tblLayoutPanelDetalleArticuloBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLayoutPanelDetallesArticuloOpciones
            // 
            this.tblLayoutPanelDetallesArticuloOpciones.BackColor = System.Drawing.Color.White;
            this.tblLayoutPanelDetallesArticuloOpciones.ColumnCount = 1;
            this.tblLayoutPanelDetallesArticuloOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDetallesArticuloOpciones.Controls.Add(this.tblLayoutPanelDetalleArticuloBotones, 0, 0);
            this.tblLayoutPanelDetallesArticuloOpciones.Controls.Add(this.chckBoxPermitirStockNegativo, 0, 1);
            this.tblLayoutPanelDetallesArticuloOpciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblLayoutPanelDetallesArticuloOpciones.Location = new System.Drawing.Point(0, 64);
            this.tblLayoutPanelDetallesArticuloOpciones.Name = "tblLayoutPanelDetallesArticuloOpciones";
            this.tblLayoutPanelDetallesArticuloOpciones.RowCount = 2;
            this.tblLayoutPanelDetallesArticuloOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tblLayoutPanelDetallesArticuloOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblLayoutPanelDetallesArticuloOpciones.Size = new System.Drawing.Size(278, 111);
            this.tblLayoutPanelDetallesArticuloOpciones.TabIndex = 28;
            // 
            // tblLayoutPanelDetalleArticuloBotones
            // 
            this.tblLayoutPanelDetalleArticuloBotones.ColumnCount = 3;
            this.tblLayoutPanelDetalleArticuloBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.40659F));
            this.tblLayoutPanelDetalleArticuloBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.59341F));
            this.tblLayoutPanelDetalleArticuloBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tblLayoutPanelDetalleArticuloBotones.Controls.Add(this.nmrcUpDownCantidad, 1, 0);
            this.tblLayoutPanelDetalleArticuloBotones.Controls.Add(this.lblCantidad, 0, 0);
            this.tblLayoutPanelDetalleArticuloBotones.Controls.Add(this.btnEditar, 2, 0);
            this.tblLayoutPanelDetalleArticuloBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDetalleArticuloBotones.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelDetalleArticuloBotones.Name = "tblLayoutPanelDetalleArticuloBotones";
            this.tblLayoutPanelDetalleArticuloBotones.RowCount = 1;
            this.tblLayoutPanelDetalleArticuloBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDetalleArticuloBotones.Size = new System.Drawing.Size(272, 66);
            this.tblLayoutPanelDetalleArticuloBotones.TabIndex = 2;
            // 
            // nmrcUpDownCantidad
            // 
            this.nmrcUpDownCantidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nmrcUpDownCantidad.Location = new System.Drawing.Point(78, 23);
            this.nmrcUpDownCantidad.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmrcUpDownCantidad.Name = "nmrcUpDownCantidad";
            this.nmrcUpDownCantidad.Size = new System.Drawing.Size(45, 20);
            this.nmrcUpDownCantidad.TabIndex = 2;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(20, 26);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.AutoSize = true;
            this.btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar.Depth = 0;
            this.btnEditar.Location = new System.Drawing.Point(178, 15);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Primary = false;
            this.btnEditar.Size = new System.Drawing.Size(90, 36);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // chckBoxPermitirStockNegativo
            // 
            this.chckBoxPermitirStockNegativo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chckBoxPermitirStockNegativo.AutoSize = true;
            this.chckBoxPermitirStockNegativo.Depth = 0;
            this.chckBoxPermitirStockNegativo.Font = new System.Drawing.Font("Roboto", 10F);
            this.chckBoxPermitirStockNegativo.Location = new System.Drawing.Point(51, 76);
            this.chckBoxPermitirStockNegativo.Margin = new System.Windows.Forms.Padding(0);
            this.chckBoxPermitirStockNegativo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chckBoxPermitirStockNegativo.MouseState = MaterialSkin.MouseState.HOVER;
            this.chckBoxPermitirStockNegativo.Name = "chckBoxPermitirStockNegativo";
            this.chckBoxPermitirStockNegativo.Ripple = true;
            this.chckBoxPermitirStockNegativo.Size = new System.Drawing.Size(176, 30);
            this.chckBoxPermitirStockNegativo.TabIndex = 3;
            this.chckBoxPermitirStockNegativo.Text = "Permitir Stock Negativo";
            this.chckBoxPermitirStockNegativo.UseVisualStyleBackColor = true;
            // 
            // frmPedidoNuevo_editarCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 175);
            this.Controls.Add(this.tblLayoutPanelDetallesArticuloOpciones);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPedidoNuevo_editarCantidad";
            this.Text = "Editar Cantidad De Artículos";
            this.tblLayoutPanelDetallesArticuloOpciones.ResumeLayout(false);
            this.tblLayoutPanelDetallesArticuloOpciones.PerformLayout();
            this.tblLayoutPanelDetalleArticuloBotones.ResumeLayout(false);
            this.tblLayoutPanelDetalleArticuloBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDetallesArticuloOpciones;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDetalleArticuloBotones;
        private System.Windows.Forms.NumericUpDown nmrcUpDownCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private MaterialSkin.Controls.MaterialFlatButton btnEditar;
        private MaterialSkin.Controls.MaterialCheckBox chckBoxPermitirStockNegativo;

    }
}