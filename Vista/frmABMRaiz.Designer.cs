namespace Vista
{
    partial class frmABMRaiz
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
            this.btnEntidad = new System.Windows.Forms.Button();
            this.pnlED = new System.Windows.Forms.Panel();
            this.btnAltaArticProv = new System.Windows.Forms.Button();
            this.btnAltaArtic = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlED.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEntidad
            // 
            this.btnEntidad.Location = new System.Drawing.Point(248, 32);
            this.btnEntidad.Name = "btnEntidad";
            this.btnEntidad.Size = new System.Drawing.Size(107, 23);
            this.btnEntidad.TabIndex = 0;
            this.btnEntidad.Text = "Entidades";
            this.btnEntidad.UseVisualStyleBackColor = true;
            this.btnEntidad.Click += new System.EventHandler(this.btnEntidades_Click);
            // 
            // pnlED
            // 
            this.pnlED.Controls.Add(this.btnAltaArticProv);
            this.pnlED.Controls.Add(this.btnAltaArtic);
            this.pnlED.Location = new System.Drawing.Point(28, 97);
            this.pnlED.Name = "pnlED";
            this.pnlED.Size = new System.Drawing.Size(603, 136);
            this.pnlED.TabIndex = 4;
            // 
            // btnAltaArticProv
            // 
            this.btnAltaArticProv.Location = new System.Drawing.Point(199, 79);
            this.btnAltaArticProv.Name = "btnAltaArticProv";
            this.btnAltaArticProv.Size = new System.Drawing.Size(167, 23);
            this.btnAltaArticProv.TabIndex = 11;
            this.btnAltaArticProv.Text = "Nuevo Articulo de Proveedor";
            this.btnAltaArticProv.UseVisualStyleBackColor = true;
            // 
            // btnAltaArtic
            // 
            this.btnAltaArtic.Location = new System.Drawing.Point(220, 3);
            this.btnAltaArtic.Name = "btnAltaArtic";
            this.btnAltaArtic.Size = new System.Drawing.Size(107, 23);
            this.btnAltaArtic.TabIndex = 8;
            this.btnAltaArtic.Text = "Nuevo Articulo";
            this.btnAltaArtic.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(579, 260);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmABMRaiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 295);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pnlED);
            this.Controls.Add(this.btnEntidad);
            this.Name = "frmABMRaiz";
            this.Text = "Altas, Bajas, y Modificaciones";
            this.pnlED.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEntidad;
        private System.Windows.Forms.Panel pnlED;
        private System.Windows.Forms.Button btnAltaArticProv;
        private System.Windows.Forms.Button btnAltaArtic;
        private System.Windows.Forms.Button btnSalir;
    }
}