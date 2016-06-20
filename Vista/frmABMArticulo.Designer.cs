namespace Vista
{
    partial class frmABMArticulo
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
            this.tblLayouttPanelForm = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxObservaciones = new System.Windows.Forms.GroupBox();
            this.rchTextBoxObservaciones = new System.Windows.Forms.RichTextBox();
            this.tblLayoutPanelDatosArticulo = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigoOriginal = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtBoxCodigoOriginal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxModelo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderActual)).BeginInit();
            this.tblLayouttPanelForm.SuspendLayout();
            this.grpBoxObservaciones.SuspendLayout();
            this.tblLayoutPanelDatosArticulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayouttPanelForm
            // 
            this.tblLayouttPanelForm.ColumnCount = 1;
            this.tblLayouttPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayouttPanelForm.Controls.Add(this.grpBoxObservaciones, 0, 1);
            this.tblLayouttPanelForm.Controls.Add(this.tblLayoutPanelDatosArticulo, 0, 0);
            this.tblLayouttPanelForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblLayouttPanelForm.Location = new System.Drawing.Point(0, 62);
            this.tblLayouttPanelForm.Name = "tblLayouttPanelForm";
            this.tblLayouttPanelForm.RowCount = 2;
            this.tblLayouttPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tblLayouttPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayouttPanelForm.Size = new System.Drawing.Size(450, 287);
            this.tblLayouttPanelForm.TabIndex = 2;
            // 
            // grpBoxObservaciones
            // 
            this.grpBoxObservaciones.Controls.Add(this.rchTextBoxObservaciones);
            this.grpBoxObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxObservaciones.Location = new System.Drawing.Point(3, 107);
            this.grpBoxObservaciones.Name = "grpBoxObservaciones";
            this.grpBoxObservaciones.Size = new System.Drawing.Size(444, 177);
            this.grpBoxObservaciones.TabIndex = 7;
            this.grpBoxObservaciones.TabStop = false;
            this.grpBoxObservaciones.Text = "Observaciones";
            // 
            // rchTextBoxObservaciones
            // 
            this.rchTextBoxObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchTextBoxObservaciones.Location = new System.Drawing.Point(3, 20);
            this.rchTextBoxObservaciones.Name = "rchTextBoxObservaciones";
            this.rchTextBoxObservaciones.Size = new System.Drawing.Size(438, 154);
            this.rchTextBoxObservaciones.TabIndex = 22;
            this.rchTextBoxObservaciones.Text = "";
            // 
            // tblLayoutPanelDatosArticulo
            // 
            this.tblLayoutPanelDatosArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayoutPanelDatosArticulo.ColumnCount = 2;
            this.tblLayoutPanelDatosArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tblLayoutPanelDatosArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDatosArticulo.Controls.Add(this.lblCodigoOriginal, 0, 0);
            this.tblLayoutPanelDatosArticulo.Controls.Add(this.lblModelo, 0, 2);
            this.tblLayoutPanelDatosArticulo.Controls.Add(this.lblDescripcion, 0, 1);
            this.tblLayoutPanelDatosArticulo.Controls.Add(this.txtBoxCodigoOriginal, 1, 0);
            this.tblLayoutPanelDatosArticulo.Controls.Add(this.txtBoxDescripcion, 1, 1);
            this.tblLayoutPanelDatosArticulo.Controls.Add(this.txtBoxModelo, 1, 2);
            this.tblLayoutPanelDatosArticulo.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelDatosArticulo.Name = "tblLayoutPanelDatosArticulo";
            this.tblLayoutPanelDatosArticulo.RowCount = 3;
            this.tblLayoutPanelDatosArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelDatosArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelDatosArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelDatosArticulo.Size = new System.Drawing.Size(444, 98);
            this.tblLayoutPanelDatosArticulo.TabIndex = 8;
            // 
            // lblCodigoOriginal
            // 
            this.lblCodigoOriginal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoOriginal.AutoSize = true;
            this.lblCodigoOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoOriginal.Location = new System.Drawing.Point(34, 0);
            this.lblCodigoOriginal.Name = "lblCodigoOriginal";
            this.lblCodigoOriginal.Size = new System.Drawing.Size(55, 32);
            this.lblCodigoOriginal.TabIndex = 0;
            this.lblCodigoOriginal.Text = "Código Original";
            // 
            // lblModelo
            // 
            this.lblModelo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(35, 73);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(54, 16);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(9, 40);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(80, 16);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtBoxCodigoOriginal
            // 
            this.txtBoxCodigoOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoOriginal.Depth = 0;
            this.txtBoxCodigoOriginal.Hint = "";
            this.txtBoxCodigoOriginal.Location = new System.Drawing.Point(95, 4);
            this.txtBoxCodigoOriginal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxCodigoOriginal.Name = "txtBoxCodigoOriginal";
            this.txtBoxCodigoOriginal.PasswordChar = '\0';
            this.txtBoxCodigoOriginal.SelectedText = "";
            this.txtBoxCodigoOriginal.SelectionLength = 0;
            this.txtBoxCodigoOriginal.SelectionStart = 0;
            this.txtBoxCodigoOriginal.Size = new System.Drawing.Size(346, 23);
            this.txtBoxCodigoOriginal.TabIndex = 6;
            this.txtBoxCodigoOriginal.UseSystemPasswordChar = false;
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescripcion.Depth = 0;
            this.txtBoxDescripcion.Hint = "";
            this.txtBoxDescripcion.Location = new System.Drawing.Point(95, 36);
            this.txtBoxDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.PasswordChar = '\0';
            this.txtBoxDescripcion.SelectedText = "";
            this.txtBoxDescripcion.SelectionLength = 0;
            this.txtBoxDescripcion.SelectionStart = 0;
            this.txtBoxDescripcion.Size = new System.Drawing.Size(346, 23);
            this.txtBoxDescripcion.TabIndex = 7;
            this.txtBoxDescripcion.UseSystemPasswordChar = false;
            // 
            // txtBoxModelo
            // 
            this.txtBoxModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxModelo.Depth = 0;
            this.txtBoxModelo.Hint = "";
            this.txtBoxModelo.Location = new System.Drawing.Point(95, 69);
            this.txtBoxModelo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxModelo.Name = "txtBoxModelo";
            this.txtBoxModelo.PasswordChar = '\0';
            this.txtBoxModelo.SelectedText = "";
            this.txtBoxModelo.SelectionLength = 0;
            this.txtBoxModelo.SelectionStart = 0;
            this.txtBoxModelo.Size = new System.Drawing.Size(346, 23);
            this.txtBoxModelo.TabIndex = 8;
            this.txtBoxModelo.UseSystemPasswordChar = false;
            // 
            // frmABMArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(450, 349);
            this.Controls.Add(this.tblLayouttPanelForm);
            this.MinimumSize = new System.Drawing.Size(450, 230);
            this.Name = "frmABMArticulo";
            this.Text = "Artículo";
            this.Move += new System.EventHandler(this.frmABMArticulo_Move);
            this.Controls.SetChildIndex(this.tblLayouttPanelForm, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderActual)).EndInit();
            this.tblLayouttPanelForm.ResumeLayout(false);
            this.grpBoxObservaciones.ResumeLayout(false);
            this.tblLayoutPanelDatosArticulo.ResumeLayout(false);
            this.tblLayoutPanelDatosArticulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayouttPanelForm;
        private System.Windows.Forms.GroupBox grpBoxObservaciones;
        private System.Windows.Forms.RichTextBox rchTextBoxObservaciones;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDatosArticulo;
        private System.Windows.Forms.Label lblCodigoOriginal;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblDescripcion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxCodigoOriginal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxDescripcion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxModelo;
    }
}
