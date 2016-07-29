namespace Vista
{
    partial class frmOpciones
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
            this.grpBoxEstiloVisual = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelDiseño = new System.Windows.Forms.TableLayoutPanel();
            this.btnCambiarColores = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlBase.SuspendLayout();
            this.tblLayoutPanelPrincipal.SuspendLayout();
            this.grpBoxEstiloVisual.SuspendLayout();
            this.tblLayoutPanelDiseño.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.tblLayoutPanelPrincipal);
            this.pnlBase.Location = new System.Drawing.Point(12, 67);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(1197, 668);
            this.pnlBase.TabIndex = 0;
            // 
            // tblLayoutPanelPrincipal
            // 
            this.tblLayoutPanelPrincipal.ColumnCount = 1;
            this.tblLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelPrincipal.Controls.Add(this.grpBoxEstiloVisual, 0, 0);
            this.tblLayoutPanelPrincipal.Location = new System.Drawing.Point(20, 15);
            this.tblLayoutPanelPrincipal.Name = "tblLayoutPanelPrincipal";
            this.tblLayoutPanelPrincipal.RowCount = 2;
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.88871F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.11129F));
            this.tblLayoutPanelPrincipal.Size = new System.Drawing.Size(1160, 629);
            this.tblLayoutPanelPrincipal.TabIndex = 0;
            // 
            // grpBoxEstiloVisual
            // 
            this.grpBoxEstiloVisual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grpBoxEstiloVisual.Controls.Add(this.tblLayoutPanelDiseño);
            this.grpBoxEstiloVisual.Location = new System.Drawing.Point(340, 3);
            this.grpBoxEstiloVisual.Name = "grpBoxEstiloVisual";
            this.grpBoxEstiloVisual.Size = new System.Drawing.Size(479, 181);
            this.grpBoxEstiloVisual.TabIndex = 1;
            this.grpBoxEstiloVisual.TabStop = false;
            this.grpBoxEstiloVisual.Text = "Estilo Visual";
            // 
            // tblLayoutPanelDiseño
            // 
            this.tblLayoutPanelDiseño.ColumnCount = 1;
            this.tblLayoutPanelDiseño.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDiseño.Controls.Add(this.btnCambiarColores, 0, 0);
            this.tblLayoutPanelDiseño.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDiseño.Location = new System.Drawing.Point(3, 18);
            this.tblLayoutPanelDiseño.Name = "tblLayoutPanelDiseño";
            this.tblLayoutPanelDiseño.RowCount = 1;
            this.tblLayoutPanelDiseño.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDiseño.Size = new System.Drawing.Size(473, 160);
            this.tblLayoutPanelDiseño.TabIndex = 0;
            // 
            // btnCambiarColores
            // 
            this.btnCambiarColores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCambiarColores.Depth = 0;
            this.btnCambiarColores.Location = new System.Drawing.Point(161, 55);
            this.btnCambiarColores.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCambiarColores.Name = "btnCambiarColores";
            this.btnCambiarColores.Primary = true;
            this.btnCambiarColores.Size = new System.Drawing.Size(150, 50);
            this.btnCambiarColores.TabIndex = 1;
            this.btnCambiarColores.Text = "Cambiar Colores";
            this.btnCambiarColores.UseVisualStyleBackColor = true;
            this.btnCambiarColores.Click += new System.EventHandler(this.btnCambiarColores_Click);
            // 
            // frmOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 747);
            this.Controls.Add(this.pnlBase);
            this.Name = "frmOpciones";
            this.Text = "frmOpciones";
            this.pnlBase.ResumeLayout(false);
            this.tblLayoutPanelPrincipal.ResumeLayout(false);
            this.grpBoxEstiloVisual.ResumeLayout(false);
            this.tblLayoutPanelDiseño.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelPrincipal;
        private System.Windows.Forms.GroupBox grpBoxEstiloVisual;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDiseño;
        private MaterialSkin.Controls.MaterialRaisedButton btnCambiarColores;
    }
}