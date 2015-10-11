namespace Vista
{
    partial class frmMensajeCorto
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
            this.tblLayoutPanelAccesionExitosa = new System.Windows.Forms.TableLayoutPanel();
            this.lblCuerpo = new System.Windows.Forms.Label();
            this.lblAccionExitosaIcono = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.tblLayoutPanelAccesionExitosa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayoutPanelAccesionExitosa
            // 
            this.tblLayoutPanelAccesionExitosa.ColumnCount = 2;
            this.tblLayoutPanelAccesionExitosa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.59155F));
            this.tblLayoutPanelAccesionExitosa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.40845F));
            this.tblLayoutPanelAccesionExitosa.Controls.Add(this.lblCuerpo, 1, 0);
            this.tblLayoutPanelAccesionExitosa.Controls.Add(this.lblAccionExitosaIcono, 0, 0);
            this.tblLayoutPanelAccesionExitosa.Controls.Add(this.btn, 1, 1);
            this.tblLayoutPanelAccesionExitosa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelAccesionExitosa.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanelAccesionExitosa.Name = "tblLayoutPanelAccesionExitosa";
            this.tblLayoutPanelAccesionExitosa.RowCount = 2;
            this.tblLayoutPanelAccesionExitosa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelAccesionExitosa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblLayoutPanelAccesionExitosa.Size = new System.Drawing.Size(291, 133);
            this.tblLayoutPanelAccesionExitosa.TabIndex = 0;
            // 
            // lblCuerpo
            // 
            this.lblCuerpo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCuerpo.AutoSize = true;
            this.lblCuerpo.Location = new System.Drawing.Point(71, 37);
            this.lblCuerpo.Name = "lblCuerpo";
            this.lblCuerpo.Size = new System.Drawing.Size(217, 13);
            this.lblCuerpo.TabIndex = 0;
            this.lblCuerpo.Text = "Cuerpo de mensaje";
            this.lblCuerpo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAccionExitosaIcono
            // 
            this.lblAccionExitosaIcono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAccionExitosaIcono.AutoSize = true;
            this.lblAccionExitosaIcono.Location = new System.Drawing.Point(31, 37);
            this.lblAccionExitosaIcono.Name = "lblAccionExitosaIcono";
            this.lblAccionExitosaIcono.Size = new System.Drawing.Size(34, 13);
            this.lblAccionExitosaIcono.TabIndex = 1;
            this.lblAccionExitosaIcono.Text = "Icono";
            // 
            // btn
            // 
            this.btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn.Location = new System.Drawing.Point(191, 99);
            this.btn.Margin = new System.Windows.Forms.Padding(3, 3, 25, 3);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "Aceptar";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // frmMensajeCorto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 133);
            this.Controls.Add(this.tblLayoutPanelAccesionExitosa);
            this.Name = "frmMensajeCorto";
            this.Text = "Título";
            this.tblLayoutPanelAccesionExitosa.ResumeLayout(false);
            this.tblLayoutPanelAccesionExitosa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelAccesionExitosa;
        private System.Windows.Forms.Label lblCuerpo;
        private System.Windows.Forms.Label lblAccionExitosaIcono;
        private System.Windows.Forms.Button btn;
    }
}