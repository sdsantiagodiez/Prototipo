namespace Vista
{
    partial class ControlDomicilios
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblLayoutPanelDomicilioDatos = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelDomicilioGrid = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewDomicilio = new System.Windows.Forms.DataGridView();
            this.codigoDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLayoutPanelDomicilioAgregarQuitar = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregarDomicilio = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnQuitarDomicilio = new MaterialSkin.Controls.MaterialFlatButton();
            this.tblLayoutPanelDomicilioDatos.SuspendLayout();
            this.tblLayoutPanelDomicilioGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDomicilio)).BeginInit();
            this.tblLayoutPanelDomicilioAgregarQuitar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayoutPanelDomicilioDatos
            // 
            this.tblLayoutPanelDomicilioDatos.ColumnCount = 1;
            this.tblLayoutPanelDomicilioDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDomicilioDatos.Controls.Add(this.tblLayoutPanelDomicilioGrid, 0, 1);
            this.tblLayoutPanelDomicilioDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDomicilioDatos.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanelDomicilioDatos.Name = "tblLayoutPanelDomicilioDatos";
            this.tblLayoutPanelDomicilioDatos.RowCount = 2;
            this.tblLayoutPanelDomicilioDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tblLayoutPanelDomicilioDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDomicilioDatos.Size = new System.Drawing.Size(909, 391);
            this.tblLayoutPanelDomicilioDatos.TabIndex = 2;
            // 
            // tblLayoutPanelDomicilioGrid
            // 
            this.tblLayoutPanelDomicilioGrid.ColumnCount = 2;
            this.tblLayoutPanelDomicilioGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDomicilioGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tblLayoutPanelDomicilioGrid.Controls.Add(this.dataGridViewDomicilio, 0, 0);
            this.tblLayoutPanelDomicilioGrid.Controls.Add(this.tblLayoutPanelDomicilioAgregarQuitar, 1, 0);
            this.tblLayoutPanelDomicilioGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDomicilioGrid.Location = new System.Drawing.Point(3, 109);
            this.tblLayoutPanelDomicilioGrid.Name = "tblLayoutPanelDomicilioGrid";
            this.tblLayoutPanelDomicilioGrid.RowCount = 1;
            this.tblLayoutPanelDomicilioGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDomicilioGrid.Size = new System.Drawing.Size(903, 279);
            this.tblLayoutPanelDomicilioGrid.TabIndex = 1;
            // 
            // dataGridViewDomicilio
            // 
            this.dataGridViewDomicilio.AllowUserToAddRows = false;
            this.dataGridViewDomicilio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDomicilio.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDomicilio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDomicilio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDomicilio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDomicilio,
            this.calle,
            this.numero,
            this.piso,
            this.departamento,
            this.codigoPostal,
            this.ciudad,
            this.codigoProvincia,
            this.provincia,
            this.codigoPais,
            this.pais});
            this.dataGridViewDomicilio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDomicilio.GridColor = System.Drawing.Color.White;
            this.dataGridViewDomicilio.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDomicilio.Name = "dataGridViewDomicilio";
            this.dataGridViewDomicilio.ReadOnly = true;
            this.dataGridViewDomicilio.RowHeadersVisible = false;
            this.dataGridViewDomicilio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDomicilio.Size = new System.Drawing.Size(864, 273);
            this.dataGridViewDomicilio.TabIndex = 19;
            this.dataGridViewDomicilio.TabStop = false;
            // 
            // codigoDomicilio
            // 
            this.codigoDomicilio.HeaderText = "codigoDomicilio";
            this.codigoDomicilio.Name = "codigoDomicilio";
            this.codigoDomicilio.ReadOnly = true;
            this.codigoDomicilio.Visible = false;
            // 
            // calle
            // 
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // piso
            // 
            this.piso.HeaderText = "Piso";
            this.piso.Name = "piso";
            this.piso.ReadOnly = true;
            // 
            // departamento
            // 
            this.departamento.HeaderText = "Dpto";
            this.departamento.Name = "departamento";
            this.departamento.ReadOnly = true;
            // 
            // codigoPostal
            // 
            this.codigoPostal.HeaderText = "CP";
            this.codigoPostal.Name = "codigoPostal";
            this.codigoPostal.ReadOnly = true;
            // 
            // ciudad
            // 
            this.ciudad.HeaderText = "Ciudad";
            this.ciudad.Name = "ciudad";
            this.ciudad.ReadOnly = true;
            // 
            // codigoProvincia
            // 
            this.codigoProvincia.HeaderText = "codigoProvincia";
            this.codigoProvincia.Name = "codigoProvincia";
            this.codigoProvincia.ReadOnly = true;
            this.codigoProvincia.Visible = false;
            // 
            // provincia
            // 
            this.provincia.HeaderText = "Provincia";
            this.provincia.Name = "provincia";
            this.provincia.ReadOnly = true;
            // 
            // codigoPais
            // 
            this.codigoPais.HeaderText = "codigoPais";
            this.codigoPais.Name = "codigoPais";
            this.codigoPais.ReadOnly = true;
            this.codigoPais.Visible = false;
            // 
            // pais
            // 
            this.pais.HeaderText = "País";
            this.pais.Name = "pais";
            this.pais.ReadOnly = true;
            // 
            // tblLayoutPanelDomicilioAgregarQuitar
            // 
            this.tblLayoutPanelDomicilioAgregarQuitar.ColumnCount = 1;
            this.tblLayoutPanelDomicilioAgregarQuitar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDomicilioAgregarQuitar.Controls.Add(this.btnAgregarDomicilio, 0, 0);
            this.tblLayoutPanelDomicilioAgregarQuitar.Controls.Add(this.btnQuitarDomicilio, 0, 1);
            this.tblLayoutPanelDomicilioAgregarQuitar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDomicilioAgregarQuitar.Location = new System.Drawing.Point(873, 3);
            this.tblLayoutPanelDomicilioAgregarQuitar.Name = "tblLayoutPanelDomicilioAgregarQuitar";
            this.tblLayoutPanelDomicilioAgregarQuitar.RowCount = 2;
            this.tblLayoutPanelDomicilioAgregarQuitar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDomicilioAgregarQuitar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDomicilioAgregarQuitar.Size = new System.Drawing.Size(27, 273);
            this.tblLayoutPanelDomicilioAgregarQuitar.TabIndex = 2;
            // 
            // btnAgregarDomicilio
            // 
            this.btnAgregarDomicilio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarDomicilio.AutoSize = true;
            this.btnAgregarDomicilio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarDomicilio.Depth = 0;
            this.btnAgregarDomicilio.Location = new System.Drawing.Point(4, 94);
            this.btnAgregarDomicilio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarDomicilio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarDomicilio.Name = "btnAgregarDomicilio";
            this.btnAgregarDomicilio.Primary = false;
            this.btnAgregarDomicilio.Size = new System.Drawing.Size(19, 36);
            this.btnAgregarDomicilio.TabIndex = 17;
            this.btnAgregarDomicilio.Text = "+";
            this.btnAgregarDomicilio.UseVisualStyleBackColor = true;
            // 
            // btnQuitarDomicilio
            // 
            this.btnQuitarDomicilio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuitarDomicilio.AutoSize = true;
            this.btnQuitarDomicilio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuitarDomicilio.Depth = 0;
            this.btnQuitarDomicilio.Location = new System.Drawing.Point(5, 142);
            this.btnQuitarDomicilio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuitarDomicilio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitarDomicilio.Name = "btnQuitarDomicilio";
            this.btnQuitarDomicilio.Primary = false;
            this.btnQuitarDomicilio.Size = new System.Drawing.Size(16, 36);
            this.btnQuitarDomicilio.TabIndex = 18;
            this.btnQuitarDomicilio.Text = "-";
            this.btnQuitarDomicilio.UseVisualStyleBackColor = true;
            // 
            // ControlDomicilios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblLayoutPanelDomicilioDatos);
            this.Name = "ControlDomicilios";
            this.Size = new System.Drawing.Size(909, 391);
            this.tblLayoutPanelDomicilioDatos.ResumeLayout(false);
            this.tblLayoutPanelDomicilioGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDomicilio)).EndInit();
            this.tblLayoutPanelDomicilioAgregarQuitar.ResumeLayout(false);
            this.tblLayoutPanelDomicilioAgregarQuitar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDomicilioDatos;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDomicilioGrid;
        private System.Windows.Forms.DataGridView dataGridViewDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDomicilioAgregarQuitar;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregarDomicilio;
        private MaterialSkin.Controls.MaterialFlatButton btnQuitarDomicilio;
    }
}
