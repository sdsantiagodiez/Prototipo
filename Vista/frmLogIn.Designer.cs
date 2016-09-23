namespace Vista
{
    partial class frmLogIn
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
            this.lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.lblContrasenia = new MaterialSkin.Controls.MaterialLabel();
            this.btnLogIn = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtBoxUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxContrasenia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.White;
            this.lblUsuario.Depth = 0;
            this.lblUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuario.Location = new System.Drawing.Point(45, 94);
            this.lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 19);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.BackColor = System.Drawing.Color.White;
            this.lblContrasenia.Depth = 0;
            this.lblContrasenia.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblContrasenia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblContrasenia.Location = new System.Drawing.Point(15, 130);
            this.lblContrasenia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(90, 19);
            this.lblContrasenia.TabIndex = 4;
            this.lblContrasenia.Text = "Contraseña:";
            // 
            // btnLogIn
            // 
            this.btnLogIn.AutoSize = true;
            this.btnLogIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogIn.Depth = 0;
            this.btnLogIn.Location = new System.Drawing.Point(110, 187);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Primary = false;
            this.btnLogIn.Size = new System.Drawing.Size(55, 36);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.BackColor = System.Drawing.Color.White;
            this.txtBoxUsuario.Depth = 0;
            this.txtBoxUsuario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsuario.Hint = "";
            this.txtBoxUsuario.Location = new System.Drawing.Point(122, 94);
            this.txtBoxUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.PasswordChar = '\0';
            this.txtBoxUsuario.SelectedText = "";
            this.txtBoxUsuario.SelectionLength = 0;
            this.txtBoxUsuario.SelectionStart = 0;
            this.txtBoxUsuario.Size = new System.Drawing.Size(134, 23);
            this.txtBoxUsuario.TabIndex = 0;
            this.txtBoxUsuario.UseSystemPasswordChar = false;
            this.txtBoxUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxUsuario_KeyPress);
            // 
            // txtBoxContrasenia
            // 
            this.txtBoxContrasenia.BackColor = System.Drawing.Color.White;
            this.txtBoxContrasenia.Depth = 0;
            this.txtBoxContrasenia.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxContrasenia.Hint = "";
            this.txtBoxContrasenia.Location = new System.Drawing.Point(122, 130);
            this.txtBoxContrasenia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxContrasenia.Name = "txtBoxContrasenia";
            this.txtBoxContrasenia.PasswordChar = '\0';
            this.txtBoxContrasenia.SelectedText = "";
            this.txtBoxContrasenia.SelectionLength = 0;
            this.txtBoxContrasenia.SelectionStart = 0;
            this.txtBoxContrasenia.Size = new System.Drawing.Size(134, 23);
            this.txtBoxContrasenia.TabIndex = 1;
            this.txtBoxContrasenia.UseSystemPasswordChar = true;
            this.txtBoxContrasenia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxContrasenia_KeyPress);
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtBoxContrasenia);
            this.Controls.Add(this.txtBoxUsuario);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblUsuario);
            this.Name = "frmLogIn";
            this.Text = "Ingreso al Sistema";
            this.Enter += new System.EventHandler(this.btnLogIn_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private MaterialSkin.Controls.MaterialLabel lblContrasenia;
        private MaterialSkin.Controls.MaterialFlatButton btnLogIn;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxContrasenia;
    }
}