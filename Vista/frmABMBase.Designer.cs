namespace Vista
{
    partial class frmABMBase
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGuardarNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGuardarCambios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLimpiarCampos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBuscar,
            this.toolStripMenuItemNuevo,
            this.toolStripMenuItemGuardar,
            this.toolStripMenuItemEliminar,
            this.toolStripMenuItemLimpiarCampos,
            this.toolStripMenuItemCerrar});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(761, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItemBuscar
            // 
            this.toolStripMenuItemBuscar.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemBuscar.Name = "toolStripMenuItemBuscar";
            this.toolStripMenuItemBuscar.Size = new System.Drawing.Size(64, 24);
            this.toolStripMenuItemBuscar.Text = "Buscar";
            this.toolStripMenuItemBuscar.Click += new System.EventHandler(this.toolStripMenuItemBuscar_Click);
            // 
            // toolStripMenuItemNuevo
            // 
            this.toolStripMenuItemNuevo.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemNuevo.Name = "toolStripMenuItemNuevo";
            this.toolStripMenuItemNuevo.Size = new System.Drawing.Size(64, 24);
            this.toolStripMenuItemNuevo.Text = "Nuevo";
            this.toolStripMenuItemNuevo.Click += new System.EventHandler(this.toolStripMenuItemNuevo_Click);
            // 
            // toolStripMenuItemGuardar
            // 
            this.toolStripMenuItemGuardar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemGuardarNuevo,
            this.toolStripMenuItemGuardarCambios});
            this.toolStripMenuItemGuardar.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemGuardar.Name = "toolStripMenuItemGuardar";
            this.toolStripMenuItemGuardar.Size = new System.Drawing.Size(74, 24);
            this.toolStripMenuItemGuardar.Text = "Guardar";
            this.toolStripMenuItemGuardar.Click += new System.EventHandler(this.toolStripMenuItemGuardar_Click);
            // 
            // toolStripMenuItemGuardarNuevo
            // 
            this.toolStripMenuItemGuardarNuevo.Name = "toolStripMenuItemGuardarNuevo";
            this.toolStripMenuItemGuardarNuevo.Size = new System.Drawing.Size(199, 26);
            this.toolStripMenuItemGuardarNuevo.Text = "Guardar Nuevo";
            this.toolStripMenuItemGuardarNuevo.Click += new System.EventHandler(this.toolStripMenuItemGuardarNuevo_Click);
            // 
            // toolStripMenuItemGuardarCambios
            // 
            this.toolStripMenuItemGuardarCambios.Name = "toolStripMenuItemGuardarCambios";
            this.toolStripMenuItemGuardarCambios.Size = new System.Drawing.Size(199, 26);
            this.toolStripMenuItemGuardarCambios.Text = "Guardar Cambios";
            this.toolStripMenuItemGuardarCambios.Click += new System.EventHandler(this.toolStripMenuItemGuardarCambios_Click);
            // 
            // toolStripMenuItemEliminar
            // 
            this.toolStripMenuItemEliminar.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemEliminar.Name = "toolStripMenuItemEliminar";
            this.toolStripMenuItemEliminar.Size = new System.Drawing.Size(75, 24);
            this.toolStripMenuItemEliminar.Text = "Eliminar";
            this.toolStripMenuItemEliminar.Click += new System.EventHandler(this.toolStripMenuItemEliminar_Click);
            // 
            // toolStripMenuItemLimpiarCampos
            // 
            this.toolStripMenuItemLimpiarCampos.Checked = true;
            this.toolStripMenuItemLimpiarCampos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemLimpiarCampos.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemLimpiarCampos.Name = "toolStripMenuItemLimpiarCampos";
            this.toolStripMenuItemLimpiarCampos.Size = new System.Drawing.Size(129, 24);
            this.toolStripMenuItemLimpiarCampos.Text = "Limpiar Campos";
            this.toolStripMenuItemLimpiarCampos.Click += new System.EventHandler(this.toolStripMenuItemLimpiarCampos_Click);
            // 
            // toolStripMenuItemCerrar
            // 
            this.toolStripMenuItemCerrar.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemCerrar.Name = "toolStripMenuItemCerrar";
            this.toolStripMenuItemCerrar.Size = new System.Drawing.Size(61, 24);
            this.toolStripMenuItemCerrar.Text = "Cerrar";
            this.toolStripMenuItemCerrar.Click += new System.EventHandler(this.toolStripMenuItemCerrar_Click);
            // 
            // frmABMBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 379);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmABMBase";
            this.Text = "Altas, Bajas y Modificaciones";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBuscar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNuevo;
        protected System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGuardar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGuardarNuevo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGuardarCambios;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEliminar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLimpiarCampos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCerrar;

    }
}