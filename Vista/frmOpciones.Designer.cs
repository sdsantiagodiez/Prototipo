namespace Vista
{
    partial class frmOpciones
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
            this.pnlBase = new System.Windows.Forms.Panel();
            this.tblLayoutPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxEstiloVisual = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelDiseño = new System.Windows.Forms.TableLayoutPanel();
            this.btnCambiarColores = new MaterialSkin.Controls.MaterialRaisedButton();
            this.grpBoxDestinoAlmacenamiento = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelAlmacenamientoArchivos = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxCarpetaReportes = new System.Windows.Forms.TextBox();
            this.lblCarpetaReportes = new MaterialSkin.Controls.MaterialLabel();
            this.lblCarpetaPedidosProveedores = new MaterialSkin.Controls.MaterialLabel();
            this.lblCarpetaPedidosClientes = new MaterialSkin.Controls.MaterialLabel();
            this.btnCarpetaPedidosProveedores = new System.Windows.Forms.Button();
            this.btnCarpetaPedidosClientes = new System.Windows.Forms.Button();
            this.btnCarpetaReportes = new System.Windows.Forms.Button();
            this.txtBoxCarpetaPedidosProveedores = new System.Windows.Forms.TextBox();
            this.txtBoxCarpetaPedidosClientes = new System.Windows.Forms.TextBox();
            this.grpBoxFacturacionElectronica = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelFacturacionElectronica = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBase.SuspendLayout();
            this.tblLayoutPanelPrincipal.SuspendLayout();
            this.grpBoxEstiloVisual.SuspendLayout();
            this.tblLayoutPanelDiseño.SuspendLayout();
            this.grpBoxDestinoAlmacenamiento.SuspendLayout();
            this.tblLayoutPanelAlmacenamientoArchivos.SuspendLayout();
            this.grpBoxFacturacionElectronica.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.tblLayoutPanelPrincipal);
            this.pnlBase.Location = new System.Drawing.Point(12, 67);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(1197, 719);
            this.pnlBase.TabIndex = 0;
            // 
            // tblLayoutPanelPrincipal
            // 
            this.tblLayoutPanelPrincipal.ColumnCount = 3;
            this.tblLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tblLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelPrincipal.Controls.Add(this.grpBoxEstiloVisual, 1, 0);
            this.tblLayoutPanelPrincipal.Controls.Add(this.grpBoxDestinoAlmacenamiento, 1, 1);
            this.tblLayoutPanelPrincipal.Controls.Add(this.grpBoxFacturacionElectronica, 1, 2);
            this.tblLayoutPanelPrincipal.Location = new System.Drawing.Point(20, 15);
            this.tblLayoutPanelPrincipal.Name = "tblLayoutPanelPrincipal";
            this.tblLayoutPanelPrincipal.RowCount = 4;
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal.Size = new System.Drawing.Size(1160, 687);
            this.tblLayoutPanelPrincipal.TabIndex = 0;
            // 
            // grpBoxEstiloVisual
            // 
            this.grpBoxEstiloVisual.Controls.Add(this.tblLayoutPanelDiseño);
            this.grpBoxEstiloVisual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxEstiloVisual.Location = new System.Drawing.Point(283, 3);
            this.grpBoxEstiloVisual.Name = "grpBoxEstiloVisual";
            this.grpBoxEstiloVisual.Size = new System.Drawing.Size(594, 144);
            this.grpBoxEstiloVisual.TabIndex = 1;
            this.grpBoxEstiloVisual.TabStop = false;
            this.grpBoxEstiloVisual.Text = "Estilo Visual";
            // 
            // tblLayoutPanelDiseño
            // 
            this.tblLayoutPanelDiseño.ColumnCount = 1;
            this.tblLayoutPanelDiseño.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDiseño.Controls.Add(this.btnCambiarColores, 0, 0);
            this.tblLayoutPanelDiseño.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDiseño.Location = new System.Drawing.Point(3, 18);
            this.tblLayoutPanelDiseño.Name = "tblLayoutPanelDiseño";
            this.tblLayoutPanelDiseño.RowCount = 1;
            this.tblLayoutPanelDiseño.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDiseño.Size = new System.Drawing.Size(588, 123);
            this.tblLayoutPanelDiseño.TabIndex = 0;
            // 
            // btnCambiarColores
            // 
            this.btnCambiarColores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCambiarColores.Depth = 0;
            this.btnCambiarColores.Location = new System.Drawing.Point(219, 36);
            this.btnCambiarColores.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCambiarColores.Name = "btnCambiarColores";
            this.btnCambiarColores.Primary = true;
            this.btnCambiarColores.Size = new System.Drawing.Size(150, 50);
            this.btnCambiarColores.TabIndex = 1;
            this.btnCambiarColores.Text = "Cambiar Colores";
            this.btnCambiarColores.UseVisualStyleBackColor = true;
            this.btnCambiarColores.Click += new System.EventHandler(this.btnCambiarColores_Click);
            // 
            // grpBoxDestinoAlmacenamiento
            // 
            this.grpBoxDestinoAlmacenamiento.Controls.Add(this.tblLayoutPanelAlmacenamientoArchivos);
            this.grpBoxDestinoAlmacenamiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDestinoAlmacenamiento.Location = new System.Drawing.Point(283, 153);
            this.grpBoxDestinoAlmacenamiento.Name = "grpBoxDestinoAlmacenamiento";
            this.grpBoxDestinoAlmacenamiento.Size = new System.Drawing.Size(594, 244);
            this.grpBoxDestinoAlmacenamiento.TabIndex = 2;
            this.grpBoxDestinoAlmacenamiento.TabStop = false;
            this.grpBoxDestinoAlmacenamiento.Text = "Almacenamiento de Archivos";
            // 
            // tblLayoutPanelAlmacenamientoArchivos
            // 
            this.tblLayoutPanelAlmacenamientoArchivos.ColumnCount = 3;
            this.tblLayoutPanelAlmacenamientoArchivos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tblLayoutPanelAlmacenamientoArchivos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelAlmacenamientoArchivos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tblLayoutPanelAlmacenamientoArchivos.Controls.Add(this.txtBoxCarpetaReportes, 0, 2);
            this.tblLayoutPanelAlmacenamientoArchivos.Controls.Add(this.lblCarpetaReportes, 0, 2);
            this.tblLayoutPanelAlmacenamientoArchivos.Controls.Add(this.lblCarpetaPedidosProveedores, 0, 0);
            this.tblLayoutPanelAlmacenamientoArchivos.Controls.Add(this.lblCarpetaPedidosClientes, 0, 1);
            this.tblLayoutPanelAlmacenamientoArchivos.Controls.Add(this.btnCarpetaPedidosProveedores, 2, 0);
            this.tblLayoutPanelAlmacenamientoArchivos.Controls.Add(this.btnCarpetaPedidosClientes, 2, 1);
            this.tblLayoutPanelAlmacenamientoArchivos.Controls.Add(this.btnCarpetaReportes, 2, 2);
            this.tblLayoutPanelAlmacenamientoArchivos.Controls.Add(this.txtBoxCarpetaPedidosProveedores, 1, 0);
            this.tblLayoutPanelAlmacenamientoArchivos.Controls.Add(this.txtBoxCarpetaPedidosClientes, 1, 1);
            this.tblLayoutPanelAlmacenamientoArchivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelAlmacenamientoArchivos.Location = new System.Drawing.Point(3, 18);
            this.tblLayoutPanelAlmacenamientoArchivos.Name = "tblLayoutPanelAlmacenamientoArchivos";
            this.tblLayoutPanelAlmacenamientoArchivos.RowCount = 3;
            this.tblLayoutPanelAlmacenamientoArchivos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelAlmacenamientoArchivos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelAlmacenamientoArchivos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutPanelAlmacenamientoArchivos.Size = new System.Drawing.Size(588, 223);
            this.tblLayoutPanelAlmacenamientoArchivos.TabIndex = 0;
            // 
            // txtBoxCarpetaReportes
            // 
            this.txtBoxCarpetaReportes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCarpetaReportes.Location = new System.Drawing.Point(228, 174);
            this.txtBoxCarpetaReportes.Name = "txtBoxCarpetaReportes";
            this.txtBoxCarpetaReportes.Size = new System.Drawing.Size(305, 22);
            this.txtBoxCarpetaReportes.TabIndex = 8;
            // 
            // lblCarpetaReportes
            // 
            this.lblCarpetaReportes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCarpetaReportes.AutoSize = true;
            this.lblCarpetaReportes.Depth = 0;
            this.lblCarpetaReportes.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCarpetaReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCarpetaReportes.Location = new System.Drawing.Point(131, 173);
            this.lblCarpetaReportes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCarpetaReportes.Name = "lblCarpetaReportes";
            this.lblCarpetaReportes.Size = new System.Drawing.Size(91, 24);
            this.lblCarpetaReportes.TabIndex = 2;
            this.lblCarpetaReportes.Text = "Reportes:";
            // 
            // lblCarpetaPedidosProveedores
            // 
            this.lblCarpetaPedidosProveedores.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCarpetaPedidosProveedores.AutoSize = true;
            this.lblCarpetaPedidosProveedores.Depth = 0;
            this.lblCarpetaPedidosProveedores.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCarpetaPedidosProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCarpetaPedidosProveedores.Location = new System.Drawing.Point(14, 25);
            this.lblCarpetaPedidosProveedores.Margin = new System.Windows.Forms.Padding(0);
            this.lblCarpetaPedidosProveedores.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCarpetaPedidosProveedores.Name = "lblCarpetaPedidosProveedores";
            this.lblCarpetaPedidosProveedores.Size = new System.Drawing.Size(211, 24);
            this.lblCarpetaPedidosProveedores.TabIndex = 1;
            this.lblCarpetaPedidosProveedores.Text = "Pedidos a Proveedores:";
            // 
            // lblCarpetaPedidosClientes
            // 
            this.lblCarpetaPedidosClientes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCarpetaPedidosClientes.AutoSize = true;
            this.lblCarpetaPedidosClientes.Depth = 0;
            this.lblCarpetaPedidosClientes.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCarpetaPedidosClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCarpetaPedidosClientes.Location = new System.Drawing.Point(38, 99);
            this.lblCarpetaPedidosClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCarpetaPedidosClientes.Name = "lblCarpetaPedidosClientes";
            this.lblCarpetaPedidosClientes.Size = new System.Drawing.Size(184, 24);
            this.lblCarpetaPedidosClientes.TabIndex = 0;
            this.lblCarpetaPedidosClientes.Text = "Pedidos de Clientes:";
            // 
            // btnCarpetaPedidosProveedores
            // 
            this.btnCarpetaPedidosProveedores.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCarpetaPedidosProveedores.Location = new System.Drawing.Point(539, 25);
            this.btnCarpetaPedidosProveedores.Name = "btnCarpetaPedidosProveedores";
            this.btnCarpetaPedidosProveedores.Size = new System.Drawing.Size(45, 23);
            this.btnCarpetaPedidosProveedores.TabIndex = 3;
            this.btnCarpetaPedidosProveedores.Text = "...";
            this.btnCarpetaPedidosProveedores.UseVisualStyleBackColor = true;
            // 
            // btnCarpetaPedidosClientes
            // 
            this.btnCarpetaPedidosClientes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCarpetaPedidosClientes.Location = new System.Drawing.Point(539, 99);
            this.btnCarpetaPedidosClientes.Name = "btnCarpetaPedidosClientes";
            this.btnCarpetaPedidosClientes.Size = new System.Drawing.Size(45, 23);
            this.btnCarpetaPedidosClientes.TabIndex = 4;
            this.btnCarpetaPedidosClientes.Text = "...";
            this.btnCarpetaPedidosClientes.UseVisualStyleBackColor = true;
            // 
            // btnCarpetaReportes
            // 
            this.btnCarpetaReportes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCarpetaReportes.Location = new System.Drawing.Point(539, 174);
            this.btnCarpetaReportes.Name = "btnCarpetaReportes";
            this.btnCarpetaReportes.Size = new System.Drawing.Size(45, 23);
            this.btnCarpetaReportes.TabIndex = 5;
            this.btnCarpetaReportes.Text = "...";
            this.btnCarpetaReportes.UseVisualStyleBackColor = true;
            // 
            // txtBoxCarpetaPedidosProveedores
            // 
            this.txtBoxCarpetaPedidosProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCarpetaPedidosProveedores.Location = new System.Drawing.Point(228, 26);
            this.txtBoxCarpetaPedidosProveedores.Name = "txtBoxCarpetaPedidosProveedores";
            this.txtBoxCarpetaPedidosProveedores.Size = new System.Drawing.Size(305, 22);
            this.txtBoxCarpetaPedidosProveedores.TabIndex = 6;
            // 
            // txtBoxCarpetaPedidosClientes
            // 
            this.txtBoxCarpetaPedidosClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCarpetaPedidosClientes.Location = new System.Drawing.Point(228, 100);
            this.txtBoxCarpetaPedidosClientes.Name = "txtBoxCarpetaPedidosClientes";
            this.txtBoxCarpetaPedidosClientes.Size = new System.Drawing.Size(305, 22);
            this.txtBoxCarpetaPedidosClientes.TabIndex = 7;
            // 
            // grpBoxFacturacionElectronica
            // 
            this.grpBoxFacturacionElectronica.Controls.Add(this.tblLayoutPanelFacturacionElectronica);
            this.grpBoxFacturacionElectronica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxFacturacionElectronica.Location = new System.Drawing.Point(283, 403);
            this.grpBoxFacturacionElectronica.Name = "grpBoxFacturacionElectronica";
            this.grpBoxFacturacionElectronica.Size = new System.Drawing.Size(594, 243);
            this.grpBoxFacturacionElectronica.TabIndex = 3;
            this.grpBoxFacturacionElectronica.TabStop = false;
            this.grpBoxFacturacionElectronica.Text = "Facturación Electrónica";
            // 
            // tblLayoutPanelFacturacionElectronica
            // 
            this.tblLayoutPanelFacturacionElectronica.ColumnCount = 2;
            this.tblLayoutPanelFacturacionElectronica.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelFacturacionElectronica.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelFacturacionElectronica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelFacturacionElectronica.Location = new System.Drawing.Point(3, 18);
            this.tblLayoutPanelFacturacionElectronica.Name = "tblLayoutPanelFacturacionElectronica";
            this.tblLayoutPanelFacturacionElectronica.RowCount = 2;
            this.tblLayoutPanelFacturacionElectronica.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelFacturacionElectronica.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelFacturacionElectronica.Size = new System.Drawing.Size(588, 222);
            this.tblLayoutPanelFacturacionElectronica.TabIndex = 0;
            // 
            // frmOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 837);
            this.Controls.Add(this.pnlBase);
            this.Name = "frmOpciones";
            this.Text = "frmOpciones";
            this.pnlBase.ResumeLayout(false);
            this.tblLayoutPanelPrincipal.ResumeLayout(false);
            this.grpBoxEstiloVisual.ResumeLayout(false);
            this.tblLayoutPanelDiseño.ResumeLayout(false);
            this.grpBoxDestinoAlmacenamiento.ResumeLayout(false);
            this.tblLayoutPanelAlmacenamientoArchivos.ResumeLayout(false);
            this.tblLayoutPanelAlmacenamientoArchivos.PerformLayout();
            this.grpBoxFacturacionElectronica.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelPrincipal;
        private System.Windows.Forms.GroupBox grpBoxEstiloVisual;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDiseño;
        private MaterialSkin.Controls.MaterialRaisedButton btnCambiarColores;
        private System.Windows.Forms.GroupBox grpBoxDestinoAlmacenamiento;
        private System.Windows.Forms.GroupBox grpBoxFacturacionElectronica;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelAlmacenamientoArchivos;
        private MaterialSkin.Controls.MaterialLabel lblCarpetaReportes;
        private MaterialSkin.Controls.MaterialLabel lblCarpetaPedidosProveedores;
        private MaterialSkin.Controls.MaterialLabel lblCarpetaPedidosClientes;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelFacturacionElectronica;
        private System.Windows.Forms.Button btnCarpetaPedidosProveedores;
        private System.Windows.Forms.Button btnCarpetaPedidosClientes;
        private System.Windows.Forms.Button btnCarpetaReportes;
        private System.Windows.Forms.TextBox txtBoxCarpetaReportes;
        private System.Windows.Forms.TextBox txtBoxCarpetaPedidosProveedores;
        private System.Windows.Forms.TextBox txtBoxCarpetaPedidosClientes;
    }
}