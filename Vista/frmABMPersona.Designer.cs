namespace Vista
{
    partial class frmABMPersona
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbPagePermisos = new System.Windows.Forms.TabPage();
            this.tbPageDatos = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.txtBoxCodigo = new System.Windows.Forms.TextBox();
            this.txtBoxDNI = new System.Windows.Forms.TextBox();
            this.txtBoxCUIT = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.tbCtrlPersonas = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.grpBoxObservaciones = new System.Windows.Forms.GroupBox();
            this.grpBoxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.grpBoxDireccion = new System.Windows.Forms.GroupBox();
            this.grpBoxContacto = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.btnAgregarMail = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuitarMail = new System.Windows.Forms.Button();
            this.lstViewMail = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.tbPageDatos.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tbCtrlPersonas.SuspendLayout();
            this.grpBoxObservaciones.SuspendLayout();
            this.grpBoxDatosPersonales.SuspendLayout();
            this.grpBoxContacto.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.cancelarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(989, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // cancelarToolStripMenuItem
            // 
            this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.cancelarToolStripMenuItem.Text = "Cancelar";
            // 
            // tbPagePermisos
            // 
            this.tbPagePermisos.BackColor = System.Drawing.SystemColors.Control;
            this.tbPagePermisos.Location = new System.Drawing.Point(4, 22);
            this.tbPagePermisos.Name = "tbPagePermisos";
            this.tbPagePermisos.Padding = new System.Windows.Forms.Padding(3);
            this.tbPagePermisos.Size = new System.Drawing.Size(1153, 572);
            this.tbPagePermisos.TabIndex = 1;
            this.tbPagePermisos.Text = "Permisos";
            // 
            // tbPageDatos
            // 
            this.tbPageDatos.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageDatos.Controls.Add(this.tableLayoutPanel2);
            this.tbPageDatos.Location = new System.Drawing.Point(4, 22);
            this.tbPageDatos.Name = "tbPageDatos";
            this.tbPageDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageDatos.Size = new System.Drawing.Size(981, 503);
            this.tbPageDatos.TabIndex = 0;
            this.tbPageDatos.Text = "Datos";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.grpBoxObservaciones, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.grpBoxDatosPersonales, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.grpBoxDireccion, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.grpBoxContacto, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(769, 461);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblCodigo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblApellido, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDNI, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCUIT, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxCodigo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxDNI, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxCUIT, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNombre, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxApellido, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxNombre, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(757, 125);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(3, 10);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(69, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(191, 50);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(183, 17);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDNI
            // 
            this.lblDNI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(3, 50);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(69, 17);
            this.lblDNI.TabIndex = 1;
            this.lblDNI.Text = "DNI:";
            // 
            // lblCUIT
            // 
            this.lblCUIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUIT.Location = new System.Drawing.Point(3, 94);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(69, 17);
            this.lblCUIT.TabIndex = 4;
            this.lblCUIT.Text = "CUIT:";
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigo.Location = new System.Drawing.Point(78, 8);
            this.txtBoxCodigo.Name = "txtBoxCodigo";
            this.txtBoxCodigo.Size = new System.Drawing.Size(107, 20);
            this.txtBoxCodigo.TabIndex = 5;
            // 
            // txtBoxDNI
            // 
            this.txtBoxDNI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDNI.Location = new System.Drawing.Point(78, 48);
            this.txtBoxDNI.Name = "txtBoxDNI";
            this.txtBoxDNI.Size = new System.Drawing.Size(107, 20);
            this.txtBoxDNI.TabIndex = 6;
            // 
            // txtBoxCUIT
            // 
            this.txtBoxCUIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCUIT.Location = new System.Drawing.Point(78, 92);
            this.txtBoxCUIT.Name = "txtBoxCUIT";
            this.txtBoxCUIT.Size = new System.Drawing.Size(107, 20);
            this.txtBoxCUIT.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(191, 94);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(183, 17);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxApellido.Location = new System.Drawing.Point(380, 48);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(374, 20);
            this.txtBoxApellido.TabIndex = 8;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNombre.Location = new System.Drawing.Point(380, 92);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(374, 20);
            this.txtBoxNombre.TabIndex = 9;
            // 
            // tbCtrlPersonas
            // 
            this.tbCtrlPersonas.Controls.Add(this.tbPageDatos);
            this.tbCtrlPersonas.Controls.Add(this.tbPagePermisos);
            this.tbCtrlPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCtrlPersonas.Location = new System.Drawing.Point(0, 24);
            this.tbCtrlPersonas.Name = "tbCtrlPersonas";
            this.tbCtrlPersonas.SelectedIndex = 0;
            this.tbCtrlPersonas.Size = new System.Drawing.Size(989, 529);
            this.tbCtrlPersonas.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(757, 82);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // grpBoxObservaciones
            // 
            this.grpBoxObservaciones.Controls.Add(this.richTextBox1);
            this.grpBoxObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxObservaciones.Location = new System.Drawing.Point(3, 357);
            this.grpBoxObservaciones.Name = "grpBoxObservaciones";
            this.grpBoxObservaciones.Size = new System.Drawing.Size(763, 101);
            this.grpBoxObservaciones.TabIndex = 2;
            this.grpBoxObservaciones.TabStop = false;
            this.grpBoxObservaciones.Text = "Observaciones";
            // 
            // grpBoxDatosPersonales
            // 
            this.grpBoxDatosPersonales.Controls.Add(this.tableLayoutPanel1);
            this.grpBoxDatosPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDatosPersonales.Location = new System.Drawing.Point(3, 3);
            this.grpBoxDatosPersonales.Name = "grpBoxDatosPersonales";
            this.grpBoxDatosPersonales.Size = new System.Drawing.Size(763, 144);
            this.grpBoxDatosPersonales.TabIndex = 3;
            this.grpBoxDatosPersonales.TabStop = false;
            this.grpBoxDatosPersonales.Text = "Datos Personales";
            // 
            // grpBoxDireccion
            // 
            this.grpBoxDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDireccion.Location = new System.Drawing.Point(3, 153);
            this.grpBoxDireccion.Name = "grpBoxDireccion";
            this.grpBoxDireccion.Size = new System.Drawing.Size(763, 64);
            this.grpBoxDireccion.TabIndex = 4;
            this.grpBoxDireccion.TabStop = false;
            this.grpBoxDireccion.Text = "Dirección";
            // 
            // grpBoxContacto
            // 
            this.grpBoxContacto.Controls.Add(this.tableLayoutPanel3);
            this.grpBoxContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxContacto.Location = new System.Drawing.Point(3, 223);
            this.grpBoxContacto.Name = "grpBoxContacto";
            this.grpBoxContacto.Size = new System.Drawing.Size(763, 128);
            this.grpBoxContacto.TabIndex = 5;
            this.grpBoxContacto.TabStop = false;
            this.grpBoxContacto.Text = "Contacto";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(757, 109);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.98925F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.01075F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.lblMail, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtBoxMail, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnAgregarMail, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(372, 48);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxMail.Location = new System.Drawing.Point(115, 14);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(233, 20);
            this.txtBoxMail.TabIndex = 8;
            // 
            // lblMail
            // 
            this.lblMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(3, 7);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(106, 34);
            this.lblMail.TabIndex = 9;
            this.lblMail.Text = "Correo Electrónico:";
            // 
            // btnAgregarMail
            // 
            this.btnAgregarMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMail.Location = new System.Drawing.Point(354, 12);
            this.btnAgregarMail.Name = "btnAgregarMail";
            this.btnAgregarMail.Size = new System.Drawing.Size(15, 23);
            this.btnAgregarMail.TabIndex = 10;
            this.btnAgregarMail.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.btnQuitarMail, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lstViewMail, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 57);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(372, 49);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // btnQuitarMail
            // 
            this.btnQuitarMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarMail.Location = new System.Drawing.Point(355, 13);
            this.btnQuitarMail.Name = "btnQuitarMail";
            this.btnQuitarMail.Size = new System.Drawing.Size(14, 23);
            this.btnQuitarMail.TabIndex = 11;
            this.btnQuitarMail.UseVisualStyleBackColor = true;
            // 
            // lstViewMail
            // 
            this.lstViewMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstViewMail.Location = new System.Drawing.Point(3, 3);
            this.lstViewMail.Name = "lstViewMail";
            this.lstViewMail.Size = new System.Drawing.Size(346, 43);
            this.lstViewMail.TabIndex = 12;
            this.lstViewMail.UseCompatibleStateImageBehavior = false;
            // 
            // frmABMPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 553);
            this.Controls.Add(this.tbCtrlPersonas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmABMPersona";
            this.Text = "ABM Personas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbPageDatos.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tbCtrlPersonas.ResumeLayout(false);
            this.grpBoxObservaciones.ResumeLayout(false);
            this.grpBoxDatosPersonales.ResumeLayout(false);
            this.grpBoxContacto.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
        private System.Windows.Forms.TabPage tbPagePermisos;
        private System.Windows.Forms.TabPage tbPageDatos;
        private System.Windows.Forms.TabControl tbCtrlPersonas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtBoxCodigo;
        private System.Windows.Forms.TextBox txtBoxDNI;
        private System.Windows.Forms.TextBox txtBoxCUIT;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.GroupBox grpBoxObservaciones;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox grpBoxDatosPersonales;
        private System.Windows.Forms.GroupBox grpBoxDireccion;
        private System.Windows.Forms.GroupBox grpBoxContacto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.Button btnAgregarMail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnQuitarMail;
        private System.Windows.Forms.ListView lstViewMail;
    }
}