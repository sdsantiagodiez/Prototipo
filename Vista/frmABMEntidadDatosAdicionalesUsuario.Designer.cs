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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblConfirmarContraseña = new System.Windows.Forms.Label();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.txtBoxContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.chckdListBoxRol = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpBoxDatosUsuario.SuspendLayout();
            this.tblLayoutPanelDatosUsuario.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxDatosUsuario
            // 
            this.grpBoxDatosUsuario.Controls.Add(this.tblLayoutPanelDatosUsuario);
            this.grpBoxDatosUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDatosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDatosUsuario.Location = new System.Drawing.Point(0, 0);
            this.grpBoxDatosUsuario.Name = "grpBoxDatosUsuario";
            this.grpBoxDatosUsuario.Size = new System.Drawing.Size(371, 408);
            this.grpBoxDatosUsuario.TabIndex = 9;
            this.grpBoxDatosUsuario.TabStop = false;
            this.grpBoxDatosUsuario.Text = "Datos de Usuario";
            // 
            // tblLayoutPanelDatosUsuario
            // 
            this.tblLayoutPanelDatosUsuario.ColumnCount = 1;
            this.tblLayoutPanelDatosUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDatosUsuario.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tblLayoutPanelDatosUsuario.Controls.Add(this.chckdListBoxRol, 0, 1);
            this.tblLayoutPanelDatosUsuario.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tblLayoutPanelDatosUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDatosUsuario.Location = new System.Drawing.Point(3, 20);
            this.tblLayoutPanelDatosUsuario.Name = "tblLayoutPanelDatosUsuario";
            this.tblLayoutPanelDatosUsuario.RowCount = 3;
            this.tblLayoutPanelDatosUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tblLayoutPanelDatosUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tblLayoutPanelDatosUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tblLayoutPanelDatosUsuario.Size = new System.Drawing.Size(365, 385);
            this.tblLayoutPanelDatosUsuario.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.74095F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.25906F));
            this.tableLayoutPanel1.Controls.Add(this.txtBoxConfirmarContraseña, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblUsuario, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblConfirmarContraseña, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxUsuario, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxContraseña, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblContraseña, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(359, 120);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // txtBoxConfirmarContraseña
            // 
            this.txtBoxConfirmarContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxConfirmarContraseña.Location = new System.Drawing.Point(98, 88);
            this.txtBoxConfirmarContraseña.Name = "txtBoxConfirmarContraseña";
            this.txtBoxConfirmarContraseña.PasswordChar = '*';
            this.txtBoxConfirmarContraseña.Size = new System.Drawing.Size(258, 24);
            this.txtBoxConfirmarContraseña.TabIndex = 11;
            this.txtBoxConfirmarContraseña.UseSystemPasswordChar = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(31, 11);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 17);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblConfirmarContraseña
            // 
            this.lblConfirmarContraseña.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblConfirmarContraseña.AutoSize = true;
            this.lblConfirmarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContraseña.Location = new System.Drawing.Point(7, 83);
            this.lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            this.lblConfirmarContraseña.Size = new System.Drawing.Size(85, 34);
            this.lblConfirmarContraseña.TabIndex = 10;
            this.lblConfirmarContraseña.Text = "Confirmar Contraseña:";
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxUsuario.Location = new System.Drawing.Point(98, 8);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(258, 24);
            this.txtBoxUsuario.TabIndex = 9;
            // 
            // txtBoxContraseña
            // 
            this.txtBoxContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxContraseña.Location = new System.Drawing.Point(98, 48);
            this.txtBoxContraseña.Name = "txtBoxContraseña";
            this.txtBoxContraseña.PasswordChar = '*';
            this.txtBoxContraseña.Size = new System.Drawing.Size(258, 24);
            this.txtBoxContraseña.TabIndex = 8;
            this.txtBoxContraseña.UseSystemPasswordChar = true;
            // 
            // lblContraseña
            // 
            this.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(7, 51);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(85, 17);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // chckdListBoxRol
            // 
            this.chckdListBoxRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.chckdListBoxRol.CheckOnClick = true;
            this.chckdListBoxRol.FormattingEnabled = true;
            this.chckdListBoxRol.Location = new System.Drawing.Point(77, 129);
            this.chckdListBoxRol.Name = "chckdListBoxRol";
            this.chckdListBoxRol.Size = new System.Drawing.Size(210, 194);
            this.chckdListBoxRol.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAceptar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancelar, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 337);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(359, 45);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAceptar.Location = new System.Drawing.Point(74, 7);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 30);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Location = new System.Drawing.Point(209, 7);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmABMEntidadDatosAdicionalesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 408);
            this.Controls.Add(this.grpBoxDatosUsuario);
            this.Name = "frmABMEntidadDatosAdicionalesUsuario";
            this.Text = "Datos Adicionales de Usuario";
            this.grpBoxDatosUsuario.ResumeLayout(false);
            this.tblLayoutPanelDatosUsuario.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxDatosUsuario;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDatosUsuario;
        private System.Windows.Forms.CheckedListBox chckdListBoxRol;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtBoxConfirmarContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblConfirmarContraseña;
        private System.Windows.Forms.TextBox txtBoxUsuario;
        private System.Windows.Forms.TextBox txtBoxContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}