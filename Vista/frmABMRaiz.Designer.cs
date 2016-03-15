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
            this.btnAltaArticProv = new System.Windows.Forms.Button();
            this.btnAltaArtic = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
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
            // btnAltaArticProv
            // 
            this.btnAltaArticProv.Location = new System.Drawing.Point(225, 201);
            this.btnAltaArticProv.Name = "btnAltaArticProv";
            this.btnAltaArticProv.Size = new System.Drawing.Size(167, 23);
            this.btnAltaArticProv.TabIndex = 11;
            this.btnAltaArticProv.Text = "Nuevo Articulo de Proveedor";
            this.btnAltaArticProv.UseVisualStyleBackColor = true;
            this.btnAltaArticProv.Click += new System.EventHandler(this.btnAltaArticProv_Click);
            // 
            // btnAltaArtic
            // 
            this.btnAltaArtic.Location = new System.Drawing.Point(248, 110);
            this.btnAltaArtic.Name = "btnAltaArtic";
            this.btnAltaArtic.Size = new System.Drawing.Size(107, 23);
            this.btnAltaArtic.TabIndex = 8;
            this.btnAltaArtic.Text = "Nuevo Articulo";
            this.btnAltaArtic.UseVisualStyleBackColor = true;
            this.btnAltaArtic.Click += new System.EventHandler(this.btnAltaArtic_Click);
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
            this.Controls.Add(this.btnAltaArticProv);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAltaArtic);
            this.Controls.Add(this.btnEntidad);
            this.Name = "frmABMRaiz";
            this.Text = "Altas, Bajas, y Modificaciones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEntidad;
        private System.Windows.Forms.Button btnAltaArticProv;
        private System.Windows.Forms.Button btnAltaArtic;
        private System.Windows.Forms.Button btnSalir;
    }
}