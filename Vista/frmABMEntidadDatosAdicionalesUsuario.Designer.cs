namespace Vista
{
    partial class frmABMEntidadDatosAdicionalesUsuario
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
            this.grpBoxDatosUsuario = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelDatosUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.pnlUsuarioContrasenia = new System.Windows.Forms.Panel();
            this.chckBoxContrasenia = new System.Windows.Forms.CheckBox();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.txtBoxContrasenia = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.chckdListBoxRol = new System.Windows.Forms.CheckedListBox();
            this.grpBoxDatosUsuario.SuspendLayout();
            this.tblLayoutPanelDatosUsuario.SuspendLayout();
            this.pnlUsuarioContrasenia.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxDatosUsuario
            // 
            this.grpBoxDatosUsuario.Controls.Add(this.tblLayoutPanelDatosUsuario);
            this.grpBoxDatosUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDatosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDatosUsuario.Location = new System.Drawing.Point(0, 0);
            this.grpBoxDatosUsuario.Name = "grpBoxDatosUsuario";
            this.grpBoxDatosUsuario.Size = new System.Drawing.Size(656, 236);
            this.grpBoxDatosUsuario.TabIndex = 9;
            this.grpBoxDatosUsuario.TabStop = false;
            this.grpBoxDatosUsuario.Text = "Datos de Usuario";
            // 
            // tblLayoutPanelDatosUsuario
            // 
            this.tblLayoutPanelDatosUsuario.ColumnCount = 2;
            this.tblLayoutPanelDatosUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDatosUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDatosUsuario.Controls.Add(this.pnlUsuarioContrasenia, 0, 0);
            this.tblLayoutPanelDatosUsuario.Controls.Add(this.chckdListBoxRol, 1, 0);
            this.tblLayoutPanelDatosUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDatosUsuario.Location = new System.Drawing.Point(3, 20);
            this.tblLayoutPanelDatosUsuario.Name = "tblLayoutPanelDatosUsuario";
            this.tblLayoutPanelDatosUsuario.RowCount = 1;
            this.tblLayoutPanelDatosUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tblLayoutPanelDatosUsuario.Size = new System.Drawing.Size(650, 213);
            this.tblLayoutPanelDatosUsuario.TabIndex = 0;
            // 
            // pnlUsuarioContrasenia
            // 
            this.pnlUsuarioContrasenia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlUsuarioContrasenia.Controls.Add(this.chckBoxContrasenia);
            this.pnlUsuarioContrasenia.Controls.Add(this.txtBoxUsuario);
            this.pnlUsuarioContrasenia.Controls.Add(this.txtBoxContrasenia);
            this.pnlUsuarioContrasenia.Controls.Add(this.lblContrasenia);
            this.pnlUsuarioContrasenia.Controls.Add(this.lblUsuario);
            this.pnlUsuarioContrasenia.Location = new System.Drawing.Point(26, 3);
            this.pnlUsuarioContrasenia.Name = "pnlUsuarioContrasenia";
            this.pnlUsuarioContrasenia.Size = new System.Drawing.Size(272, 91);
            this.pnlUsuarioContrasenia.TabIndex = 0;
            // 
            // chckBoxContrasenia
            // 
            this.chckBoxContrasenia.AutoSize = true;
            this.chckBoxContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBoxContrasenia.Location = new System.Drawing.Point(86, 64);
            this.chckBoxContrasenia.Name = "chckBoxContrasenia";
            this.chckBoxContrasenia.Size = new System.Drawing.Size(142, 20);
            this.chckBoxContrasenia.TabIndex = 10;
            this.chckBoxContrasenia.Text = "Mostrar contraseña";
            this.chckBoxContrasenia.UseVisualStyleBackColor = true;
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxUsuario.Location = new System.Drawing.Point(85, 6);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(170, 24);
            this.txtBoxUsuario.TabIndex = 9;
            // 
            // txtBoxContrasenia
            // 
            this.txtBoxContrasenia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxContrasenia.Location = new System.Drawing.Point(85, 36);
            this.txtBoxContrasenia.Name = "txtBoxContrasenia";
            this.txtBoxContrasenia.PasswordChar = '*';
            this.txtBoxContrasenia.Size = new System.Drawing.Size(170, 24);
            this.txtBoxContrasenia.TabIndex = 8;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenia.Location = new System.Drawing.Point(1, 41);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(85, 17);
            this.lblContrasenia.TabIndex = 3;
            this.lblContrasenia.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(25, 11);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 17);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario:";
            // 
            // chckdListBoxRol
            // 
            this.chckdListBoxRol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chckdListBoxRol.FormattingEnabled = true;
            this.chckdListBoxRol.Location = new System.Drawing.Point(382, 3);
            this.chckdListBoxRol.Name = "chckdListBoxRol";
            this.chckdListBoxRol.Size = new System.Drawing.Size(210, 175);
            this.chckdListBoxRol.TabIndex = 2;
            // 
            // frmABMEntidadDatosAdicionalesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 236);
            this.Controls.Add(this.grpBoxDatosUsuario);
            this.Name = "frmABMEntidadDatosAdicionalesUsuario";
            this.Text = "frmABMEntidadDatosAdicionalesUsuario";
            this.grpBoxDatosUsuario.ResumeLayout(false);
            this.tblLayoutPanelDatosUsuario.ResumeLayout(false);
            this.pnlUsuarioContrasenia.ResumeLayout(false);
            this.pnlUsuarioContrasenia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxDatosUsuario;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDatosUsuario;
        private System.Windows.Forms.Panel pnlUsuarioContrasenia;
        private System.Windows.Forms.CheckBox chckBoxContrasenia;
        private System.Windows.Forms.TextBox txtBoxUsuario;
        private System.Windows.Forms.TextBox txtBoxContrasenia;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.CheckedListBox chckdListBoxRol;
    }
}