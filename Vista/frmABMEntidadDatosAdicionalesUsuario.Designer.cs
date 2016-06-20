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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblConfirmarContraseña = new System.Windows.Forms.Label();
            this.txtBoxUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxContraseña = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxConfirmarContraseña = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chckBoxMostrarContraseña = new MaterialSkin.Controls.MaterialCheckBox();
            this.chckdListBoxRol = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnModificar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAceptar = new MaterialSkin.Controls.MaterialFlatButton();
            this.grpBoxDatosUsuario.SuspendLayout();
            this.tblLayoutPanelDatosUsuario.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxDatosUsuario
            // 
            this.grpBoxDatosUsuario.BackColor = System.Drawing.Color.White;
            this.grpBoxDatosUsuario.Controls.Add(this.tblLayoutPanelDatosUsuario);
            this.grpBoxDatosUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpBoxDatosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDatosUsuario.Location = new System.Drawing.Point(0, 65);
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
            this.tblLayoutPanelDatosUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tblLayoutPanelDatosUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tblLayoutPanelDatosUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tblLayoutPanelDatosUsuario.Size = new System.Drawing.Size(365, 385);
            this.tblLayoutPanelDatosUsuario.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.74095F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.25905F));
            this.tableLayoutPanel1.Controls.Add(this.lblUsuario, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblContraseña, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblConfirmarContraseña, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxUsuario, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxContraseña, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxConfirmarContraseña, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.chckBoxMostrarContraseña, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(359, 160);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(32, 11);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 17);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(8, 51);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(85, 17);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblConfirmarContraseña
            // 
            this.lblConfirmarContraseña.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblConfirmarContraseña.AutoSize = true;
            this.lblConfirmarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContraseña.Location = new System.Drawing.Point(8, 83);
            this.lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            this.lblConfirmarContraseña.Size = new System.Drawing.Size(85, 34);
            this.lblConfirmarContraseña.TabIndex = 10;
            this.lblConfirmarContraseña.Text = "Confirmar Contraseña:";
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxUsuario.Depth = 0;
            this.txtBoxUsuario.Hint = "";
            this.txtBoxUsuario.Location = new System.Drawing.Point(99, 8);
            this.txtBoxUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.PasswordChar = '\0';
            this.txtBoxUsuario.SelectedText = "";
            this.txtBoxUsuario.SelectionLength = 0;
            this.txtBoxUsuario.SelectionStart = 0;
            this.txtBoxUsuario.Size = new System.Drawing.Size(257, 23);
            this.txtBoxUsuario.TabIndex = 13;
            this.txtBoxUsuario.UseSystemPasswordChar = false;
            // 
            // txtBoxContraseña
            // 
            this.txtBoxContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxContraseña.Depth = 0;
            this.txtBoxContraseña.Hint = "";
            this.txtBoxContraseña.Location = new System.Drawing.Point(99, 48);
            this.txtBoxContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxContraseña.Name = "txtBoxContraseña";
            this.txtBoxContraseña.PasswordChar = '\0';
            this.txtBoxContraseña.SelectedText = "";
            this.txtBoxContraseña.SelectionLength = 0;
            this.txtBoxContraseña.SelectionStart = 0;
            this.txtBoxContraseña.Size = new System.Drawing.Size(257, 23);
            this.txtBoxContraseña.TabIndex = 14;
            this.txtBoxContraseña.UseSystemPasswordChar = false;
            // 
            // txtBoxConfirmarContraseña
            // 
            this.txtBoxConfirmarContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxConfirmarContraseña.Depth = 0;
            this.txtBoxConfirmarContraseña.Hint = "";
            this.txtBoxConfirmarContraseña.Location = new System.Drawing.Point(99, 88);
            this.txtBoxConfirmarContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxConfirmarContraseña.Name = "txtBoxConfirmarContraseña";
            this.txtBoxConfirmarContraseña.PasswordChar = '\0';
            this.txtBoxConfirmarContraseña.SelectedText = "";
            this.txtBoxConfirmarContraseña.SelectionLength = 0;
            this.txtBoxConfirmarContraseña.SelectionStart = 0;
            this.txtBoxConfirmarContraseña.Size = new System.Drawing.Size(257, 23);
            this.txtBoxConfirmarContraseña.TabIndex = 15;
            this.txtBoxConfirmarContraseña.UseSystemPasswordChar = false;
            // 
            // chckBoxMostrarContraseña
            // 
            this.chckBoxMostrarContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chckBoxMostrarContraseña.AutoSize = true;
            this.chckBoxMostrarContraseña.Depth = 0;
            this.chckBoxMostrarContraseña.Font = new System.Drawing.Font("Roboto", 10F);
            this.chckBoxMostrarContraseña.Location = new System.Drawing.Point(151, 125);
            this.chckBoxMostrarContraseña.Margin = new System.Windows.Forms.Padding(0);
            this.chckBoxMostrarContraseña.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chckBoxMostrarContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.chckBoxMostrarContraseña.Name = "chckBoxMostrarContraseña";
            this.chckBoxMostrarContraseña.Ripple = true;
            this.chckBoxMostrarContraseña.Size = new System.Drawing.Size(153, 30);
            this.chckBoxMostrarContraseña.TabIndex = 16;
            this.chckBoxMostrarContraseña.Text = "Mostrar Contraseña";
            this.chckBoxMostrarContraseña.UseVisualStyleBackColor = true;
            this.chckBoxMostrarContraseña.CheckedChanged += new System.EventHandler(this.chckBoxMostrarContraseña_CheckedChanged);
            // 
            // chckdListBoxRol
            // 
            this.chckdListBoxRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.chckdListBoxRol.CheckOnClick = true;
            this.chckdListBoxRol.FormattingEnabled = true;
            this.chckdListBoxRol.Location = new System.Drawing.Point(36, 169);
            this.chckdListBoxRol.Name = "chckdListBoxRol";
            this.chckdListBoxRol.Size = new System.Drawing.Size(292, 156);
            this.chckdListBoxRol.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel2.Controls.Add(this.materialFlatButton1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnModificar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAceptar, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 337);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(359, 45);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.materialFlatButton1.Location = new System.Drawing.Point(254, 6);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(82, 33);
            this.materialFlatButton1.TabIndex = 8;
            this.materialFlatButton1.Text = "Cancelar";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.AutoSize = true;
            this.btnModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificar.Depth = 0;
            this.btnModificar.Location = new System.Drawing.Point(132, 6);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Primary = false;
            this.btnModificar.Size = new System.Drawing.Size(84, 33);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.AutoSize = true;
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.Location = new System.Drawing.Point(21, 6);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Primary = false;
            this.btnAceptar.Size = new System.Drawing.Size(73, 33);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmABMEntidadDatosAdicionalesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 473);
            this.Controls.Add(this.grpBoxDatosUsuario);
            this.MaximizeBox = false;
            this.Name = "frmABMEntidadDatosAdicionalesUsuario";
            this.Text = "Datos Adicionales de Usuario";
            this.grpBoxDatosUsuario.ResumeLayout(false);
            this.tblLayoutPanelDatosUsuario.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxDatosUsuario;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDatosUsuario;
        private System.Windows.Forms.CheckedListBox chckdListBoxRol;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblConfirmarContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxContraseña;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxConfirmarContraseña;
        private MaterialSkin.Controls.MaterialCheckBox chckBoxMostrarContraseña;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton btnModificar;
        private MaterialSkin.Controls.MaterialFlatButton btnAceptar;
    }
}