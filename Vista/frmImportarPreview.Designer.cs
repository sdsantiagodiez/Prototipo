namespace Vista
{
    partial class frmImportarPreview
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
            this.btnImportar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.chckBoxPrimeraFilaHeaders = new MaterialSkin.Controls.MaterialCheckBox();
            this.tblLayoutPanelDireccionArchivo = new System.Windows.Forms.TableLayoutPanel();
            this.lblDireccionDeArchivo = new MaterialSkin.Controls.MaterialLabel();
            this.txtBoxDireccionArchivo = new System.Windows.Forms.TextBox();
            this.btnBuscarArchivo = new System.Windows.Forms.Button();
            this.pnlBase.SuspendLayout();
            this.tblLayoutPanelPrincipal.SuspendLayout();
            this.tblLayoutPanelDireccionArchivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.tblLayoutPanelPrincipal);
            this.pnlBase.Location = new System.Drawing.Point(13, 76);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(1271, 621);
            this.pnlBase.TabIndex = 0;
            // 
            // tblLayoutPanelPrincipal
            // 
            this.tblLayoutPanelPrincipal.ColumnCount = 1;
            this.tblLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal.Controls.Add(this.btnImportar, 0, 3);
            this.tblLayoutPanelPrincipal.Controls.Add(this.chckBoxPrimeraFilaHeaders, 0, 1);
            this.tblLayoutPanelPrincipal.Controls.Add(this.tblLayoutPanelDireccionArchivo, 0, 0);
            this.tblLayoutPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanelPrincipal.Name = "tblLayoutPanelPrincipal";
            this.tblLayoutPanelPrincipal.RowCount = 4;
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tblLayoutPanelPrincipal.Size = new System.Drawing.Size(1271, 621);
            this.tblLayoutPanelPrincipal.TabIndex = 0;
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImportar.Depth = 0;
            this.btnImportar.Location = new System.Drawing.Point(554, 570);
            this.btnImportar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Primary = true;
            this.btnImportar.Size = new System.Drawing.Size(163, 37);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // chckBoxPrimeraFilaHeaders
            // 
            this.chckBoxPrimeraFilaHeaders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chckBoxPrimeraFilaHeaders.AutoSize = true;
            this.chckBoxPrimeraFilaHeaders.Depth = 0;
            this.chckBoxPrimeraFilaHeaders.Font = new System.Drawing.Font("Roboto", 10F);
            this.chckBoxPrimeraFilaHeaders.Location = new System.Drawing.Point(480, 105);
            this.chckBoxPrimeraFilaHeaders.Margin = new System.Windows.Forms.Padding(0);
            this.chckBoxPrimeraFilaHeaders.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chckBoxPrimeraFilaHeaders.MouseState = MaterialSkin.MouseState.HOVER;
            this.chckBoxPrimeraFilaHeaders.Name = "chckBoxPrimeraFilaHeaders";
            this.chckBoxPrimeraFilaHeaders.Ripple = true;
            this.chckBoxPrimeraFilaHeaders.Size = new System.Drawing.Size(311, 30);
            this.chckBoxPrimeraFilaHeaders.TabIndex = 1;
            this.chckBoxPrimeraFilaHeaders.Text = "Primera fila es nombres de atributos";
            this.chckBoxPrimeraFilaHeaders.UseVisualStyleBackColor = true;
            this.chckBoxPrimeraFilaHeaders.CheckedChanged += new System.EventHandler(this.chckBoxPrimeraFilaHeaders_CheckedChanged);
            // 
            // tblLayoutPanelDireccionArchivo
            // 
            this.tblLayoutPanelDireccionArchivo.ColumnCount = 3;
            this.tblLayoutPanelDireccionArchivo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tblLayoutPanelDireccionArchivo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tblLayoutPanelDireccionArchivo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 665F));
            this.tblLayoutPanelDireccionArchivo.Controls.Add(this.lblDireccionDeArchivo, 0, 0);
            this.tblLayoutPanelDireccionArchivo.Controls.Add(this.txtBoxDireccionArchivo, 1, 0);
            this.tblLayoutPanelDireccionArchivo.Controls.Add(this.btnBuscarArchivo, 2, 0);
            this.tblLayoutPanelDireccionArchivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDireccionArchivo.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelDireccionArchivo.Name = "tblLayoutPanelDireccionArchivo";
            this.tblLayoutPanelDireccionArchivo.RowCount = 1;
            this.tblLayoutPanelDireccionArchivo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDireccionArchivo.Size = new System.Drawing.Size(1265, 94);
            this.tblLayoutPanelDireccionArchivo.TabIndex = 2;
            // 
            // lblDireccionDeArchivo
            // 
            this.lblDireccionDeArchivo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDireccionDeArchivo.AutoSize = true;
            this.lblDireccionDeArchivo.Depth = 0;
            this.lblDireccionDeArchivo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDireccionDeArchivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDireccionDeArchivo.Location = new System.Drawing.Point(29, 35);
            this.lblDireccionDeArchivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDireccionDeArchivo.Name = "lblDireccionDeArchivo";
            this.lblDireccionDeArchivo.Size = new System.Drawing.Size(188, 24);
            this.lblDireccionDeArchivo.TabIndex = 0;
            this.lblDireccionDeArchivo.Text = "Dirección de Archivo:";
            // 
            // txtBoxDireccionArchivo
            // 
            this.txtBoxDireccionArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDireccionArchivo.Location = new System.Drawing.Point(223, 36);
            this.txtBoxDireccionArchivo.Name = "txtBoxDireccionArchivo";
            this.txtBoxDireccionArchivo.Size = new System.Drawing.Size(394, 22);
            this.txtBoxDireccionArchivo.TabIndex = 1;
            // 
            // btnBuscarArchivo
            // 
            this.btnBuscarArchivo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscarArchivo.Location = new System.Drawing.Point(623, 35);
            this.btnBuscarArchivo.Name = "btnBuscarArchivo";
            this.btnBuscarArchivo.Size = new System.Drawing.Size(45, 23);
            this.btnBuscarArchivo.TabIndex = 2;
            this.btnBuscarArchivo.Text = "...";
            this.btnBuscarArchivo.UseVisualStyleBackColor = true;
            this.btnBuscarArchivo.Click += new System.EventHandler(this.btnBuscarArchivo_Click);
            // 
            // frmImportarPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 709);
            this.Controls.Add(this.pnlBase);
            this.Name = "frmImportarPreview";
            this.Text = "Importar";
            this.pnlBase.ResumeLayout(false);
            this.tblLayoutPanelPrincipal.ResumeLayout(false);
            this.tblLayoutPanelPrincipal.PerformLayout();
            this.tblLayoutPanelDireccionArchivo.ResumeLayout(false);
            this.tblLayoutPanelDireccionArchivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelPrincipal;
        private MaterialSkin.Controls.MaterialRaisedButton btnImportar;
        private MaterialSkin.Controls.MaterialCheckBox chckBoxPrimeraFilaHeaders;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDireccionArchivo;
        private MaterialSkin.Controls.MaterialLabel lblDireccionDeArchivo;
        private System.Windows.Forms.TextBox txtBoxDireccionArchivo;
        private System.Windows.Forms.Button btnBuscarArchivo;
    }
}