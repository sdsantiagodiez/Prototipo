namespace Vista
{
    partial class frmLoading
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
            this.lblMensaje = new MaterialSkin.Controls.MaterialLabel();
            this.pnlBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBase
            // 
            this.pnlBase.AutoSize = true;
            this.pnlBase.Controls.Add(this.lblMensaje);
            this.pnlBase.Location = new System.Drawing.Point(12, 67);
            this.pnlBase.MinimumSize = new System.Drawing.Size(110, 0);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(310, 43);
            this.pnlBase.TabIndex = 2;
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.White;
            this.lblMensaje.Depth = 0;
            this.lblMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMensaje.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMensaje.Location = new System.Drawing.Point(0, 0);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(310, 43);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Procesando operación";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 119);
            this.Controls.Add(this.pnlBase);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmLoading";
            this.Text = "Procesando...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLoading_FormClosing);
            this.pnlBase.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblMensaje;
        private System.Windows.Forms.Panel pnlBase;


    }
}