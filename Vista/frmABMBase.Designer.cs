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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGuardarNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGuardarCambios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLimpiarCampos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBuscar,
            this.toolStripMenuItemNuevo,
            this.toolStripMenuItemGuardar,
            this.toolStripMenuItemEliminar,
            this.toolStripMenuItemLimpiarCampos,
            this.toolStripMenuItemCancelar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemBuscar
            // 
            this.toolStripMenuItemBuscar.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemBuscar.Name = "toolStripMenuItemBuscar";
            this.toolStripMenuItemBuscar.Size = new System.Drawing.Size(51, 20);
            this.toolStripMenuItemBuscar.Text = "Buscar";
            this.toolStripMenuItemBuscar.Click += new System.EventHandler(this.toolStripMenuItemBuscar_Click);
            // 
            // toolStripMenuItemNuevo
            // 
            this.toolStripMenuItemNuevo.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemNuevo.Name = "toolStripMenuItemNuevo";
            this.toolStripMenuItemNuevo.Size = new System.Drawing.Size(50, 20);
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
            this.toolStripMenuItemGuardar.Size = new System.Drawing.Size(58, 20);
            this.toolStripMenuItemGuardar.Text = "Guardar";
            this.toolStripMenuItemGuardar.Click += new System.EventHandler(this.toolStripMenuItemGuardar_Click);
            // 
            // toolStripMenuItemGuardarNuevo
            // 
            this.toolStripMenuItemGuardarNuevo.Name = "toolStripMenuItemGuardarNuevo";
            this.toolStripMenuItemGuardarNuevo.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItemGuardarNuevo.Text = "Guardar Nuevo";
            this.toolStripMenuItemGuardarNuevo.Click += new System.EventHandler(this.toolStripMenuItemGuardarNuevo_Click);
            // 
            // toolStripMenuItemGuardarCambios
            // 
            this.toolStripMenuItemGuardarCambios.Name = "toolStripMenuItemGuardarCambios";
            this.toolStripMenuItemGuardarCambios.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItemGuardarCambios.Text = "Guardar Cambios";
            this.toolStripMenuItemGuardarCambios.Click += new System.EventHandler(this.toolStripMenuItemGuardarCambios_Click);
            // 
            // toolStripMenuItemEliminar
            // 
            this.toolStripMenuItemEliminar.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemEliminar.Name = "toolStripMenuItemEliminar";
            this.toolStripMenuItemEliminar.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItemEliminar.Text = "Eliminar";
            this.toolStripMenuItemEliminar.Click += new System.EventHandler(this.toolStripMenuItemEliminar_Click);
            // 
            // toolStripMenuItemLimpiarCampos
            // 
            this.toolStripMenuItemLimpiarCampos.Checked = true;
            this.toolStripMenuItemLimpiarCampos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemLimpiarCampos.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemLimpiarCampos.Name = "toolStripMenuItemLimpiarCampos";
            this.toolStripMenuItemLimpiarCampos.Size = new System.Drawing.Size(93, 20);
            this.toolStripMenuItemLimpiarCampos.Text = "Limpiar Campos";
            this.toolStripMenuItemLimpiarCampos.Click += new System.EventHandler(this.toolStripMenuItemLimpiarCampos_Click);
            // 
            // toolStripMenuItemCancelar
            // 
            this.toolStripMenuItemCancelar.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemCancelar.Name = "toolStripMenuItemCancelar";
            this.toolStripMenuItemCancelar.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItemCancelar.Text = "Cancelar";
            this.toolStripMenuItemCancelar.Click += new System.EventHandler(this.toolStripMenuItemCancelar_Click);
            // 
            // frmABMBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 308);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmABMBase";
            this.Text = "Altas, Bajas y Modificaciones";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBuscar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNuevo;
        protected System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGuardar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGuardarNuevo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGuardarCambios;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEliminar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLimpiarCampos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCancelar;

    }
}