﻿namespace Vista
{
    partial class frmReimpresion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReimpresion));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTipoComprobante = new System.Windows.Forms.Label();
            this.lblComprobanteDesde = new System.Windows.Forms.Label();
            this.lblComprobanteHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnImprimir = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtBoxComprobanteDesde = new System.Windows.Forms.TextBox();
            this.txtBoxComprobanteHasta = new System.Windows.Forms.TextBox();
            this.txtBoxCliente = new System.Windows.Forms.TextBox();
            this.cmbxTipoComprobante = new System.Windows.Forms.ComboBox();
            this.btnBuscaTipoComprobante = new System.Windows.Forms.Label();
            this.btnBuscaComprobanteDesde = new System.Windows.Forms.Label();
            this.btnBuscaComprobanteHasta = new System.Windows.Forms.Label();
            this.btnBuscaCliente = new System.Windows.Forms.Label();
            this.txtBoxFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.txtBoxFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblTipoComprobante, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblComprobanteDesde, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblComprobanteHasta, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFechaDesde, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFechaHasta, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblCliente, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnImprimir, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxComprobanteDesde, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxComprobanteHasta, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxCliente, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbxTipoComprobante, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBuscaTipoComprobante, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBuscaComprobanteDesde, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnBuscaComprobanteHasta, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnBuscaCliente, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxFechaDesde, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxFechaHasta, 3, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.127736F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.76642F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.76642F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.76642F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.76642F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.76642F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.7628F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.0219F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.255473F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 309);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTipoComprobante
            // 
            this.lblTipoComprobante.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTipoComprobante.AutoSize = true;
            this.lblTipoComprobante.Location = new System.Drawing.Point(48, 19);
            this.lblTipoComprobante.Name = "lblTipoComprobante";
            this.lblTipoComprobante.Size = new System.Drawing.Size(109, 13);
            this.lblTipoComprobante.TabIndex = 12;
            this.lblTipoComprobante.Text = "Tipo de Comprobante";
            // 
            // lblComprobanteDesde
            // 
            this.lblComprobanteDesde.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblComprobanteDesde.AutoSize = true;
            this.lblComprobanteDesde.Location = new System.Drawing.Point(53, 58);
            this.lblComprobanteDesde.Name = "lblComprobanteDesde";
            this.lblComprobanteDesde.Size = new System.Drawing.Size(104, 13);
            this.lblComprobanteDesde.TabIndex = 13;
            this.lblComprobanteDesde.Text = "Comprobante Desde";
            // 
            // lblComprobanteHasta
            // 
            this.lblComprobanteHasta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblComprobanteHasta.AutoSize = true;
            this.lblComprobanteHasta.Location = new System.Drawing.Point(56, 97);
            this.lblComprobanteHasta.Name = "lblComprobanteHasta";
            this.lblComprobanteHasta.Size = new System.Drawing.Size(101, 13);
            this.lblComprobanteHasta.TabIndex = 14;
            this.lblComprobanteHasta.Text = "Comprobante Hasta";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(86, 136);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(71, 13);
            this.lblFechaDesde.TabIndex = 15;
            this.lblFechaDesde.Text = "Fecha Desde";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(89, 175);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(68, 13);
            this.lblFechaHasta.TabIndex = 16;
            this.lblFechaHasta.Text = "Fecha Hasta";
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(118, 214);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 17;
            this.lblCliente.Text = "Cliente";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImprimir.Depth = 0;
            this.btnImprimir.Location = new System.Drawing.Point(24, 248);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImprimir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Primary = true;
            this.btnImprimir.Size = new System.Drawing.Size(132, 36);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(176, 248);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(152, 36);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtBoxComprobanteDesde
            // 
            this.txtBoxComprobanteDesde.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxComprobanteDesde.Location = new System.Drawing.Point(175, 54);
            this.txtBoxComprobanteDesde.Name = "txtBoxComprobanteDesde";
            this.txtBoxComprobanteDesde.Size = new System.Drawing.Size(153, 20);
            this.txtBoxComprobanteDesde.TabIndex = 18;
            // 
            // txtBoxComprobanteHasta
            // 
            this.txtBoxComprobanteHasta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxComprobanteHasta.Location = new System.Drawing.Point(175, 93);
            this.txtBoxComprobanteHasta.Name = "txtBoxComprobanteHasta";
            this.txtBoxComprobanteHasta.Size = new System.Drawing.Size(154, 20);
            this.txtBoxComprobanteHasta.TabIndex = 19;
            // 
            // txtBoxCliente
            // 
            this.txtBoxCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxCliente.Location = new System.Drawing.Point(175, 210);
            this.txtBoxCliente.Name = "txtBoxCliente";
            this.txtBoxCliente.Size = new System.Drawing.Size(154, 20);
            this.txtBoxCliente.TabIndex = 22;
            // 
            // cmbxTipoComprobante
            // 
            this.cmbxTipoComprobante.FormattingEnabled = true;
            this.cmbxTipoComprobante.Location = new System.Drawing.Point(175, 9);
            this.cmbxTipoComprobante.Name = "cmbxTipoComprobante";
            this.cmbxTipoComprobante.Size = new System.Drawing.Size(154, 21);
            this.cmbxTipoComprobante.TabIndex = 23;
            // 
            // btnBuscaTipoComprobante
            // 
            this.btnBuscaTipoComprobante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscaTipoComprobante.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaTipoComprobante.Image")));
            this.btnBuscaTipoComprobante.Location = new System.Drawing.Point(343, 12);
            this.btnBuscaTipoComprobante.Name = "btnBuscaTipoComprobante";
            this.btnBuscaTipoComprobante.Size = new System.Drawing.Size(54, 27);
            this.btnBuscaTipoComprobante.TabIndex = 24;
            // 
            // btnBuscaComprobanteDesde
            // 
            this.btnBuscaComprobanteDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscaComprobanteDesde.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaComprobanteDesde.Image")));
            this.btnBuscaComprobanteDesde.Location = new System.Drawing.Point(343, 51);
            this.btnBuscaComprobanteDesde.Name = "btnBuscaComprobanteDesde";
            this.btnBuscaComprobanteDesde.Size = new System.Drawing.Size(54, 27);
            this.btnBuscaComprobanteDesde.TabIndex = 25;
            this.btnBuscaComprobanteDesde.Click += new System.EventHandler(this.btnBuscaComprobanteDesde_Click);
            // 
            // btnBuscaComprobanteHasta
            // 
            this.btnBuscaComprobanteHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscaComprobanteHasta.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaComprobanteHasta.Image")));
            this.btnBuscaComprobanteHasta.Location = new System.Drawing.Point(343, 90);
            this.btnBuscaComprobanteHasta.Name = "btnBuscaComprobanteHasta";
            this.btnBuscaComprobanteHasta.Size = new System.Drawing.Size(54, 27);
            this.btnBuscaComprobanteHasta.TabIndex = 26;
            this.btnBuscaComprobanteHasta.Click += new System.EventHandler(this.btnBuscaComprobanteHasta_Click);
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaCliente.Image")));
            this.btnBuscaCliente.Location = new System.Drawing.Point(343, 209);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(54, 23);
            this.btnBuscaCliente.TabIndex = 27;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // txtBoxFechaDesde
            // 
            this.txtBoxFechaDesde.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtBoxFechaDesde.Location = new System.Drawing.Point(175, 132);
            this.txtBoxFechaDesde.Name = "txtBoxFechaDesde";
            this.txtBoxFechaDesde.Size = new System.Drawing.Size(154, 20);
            this.txtBoxFechaDesde.TabIndex = 28;
            // 
            // txtBoxFechaHasta
            // 
            this.txtBoxFechaHasta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtBoxFechaHasta.Location = new System.Drawing.Point(175, 171);
            this.txtBoxFechaHasta.Name = "txtBoxFechaHasta";
            this.txtBoxFechaHasta.Size = new System.Drawing.Size(154, 20);
            this.txtBoxFechaHasta.TabIndex = 29;
            // 
            // frmReimpresion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 370);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmReimpresion";
            this.Text = "Reimpresiones";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialFlatButton btnImprimir;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private System.Windows.Forms.Label lblTipoComprobante;
        private System.Windows.Forms.Label lblComprobanteDesde;
        private System.Windows.Forms.Label lblComprobanteHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtBoxComprobanteDesde;
        private System.Windows.Forms.TextBox txtBoxComprobanteHasta;
        private System.Windows.Forms.TextBox txtBoxCliente;
        private System.Windows.Forms.ComboBox cmbxTipoComprobante;
        internal System.Windows.Forms.Label btnBuscaTipoComprobante;
        internal System.Windows.Forms.Label btnBuscaComprobanteDesde;
        internal System.Windows.Forms.Label btnBuscaComprobanteHasta;
        internal System.Windows.Forms.Label btnBuscaCliente;
        private System.Windows.Forms.DateTimePicker txtBoxFechaDesde;
        private System.Windows.Forms.DateTimePicker txtBoxFechaHasta;
    }
}