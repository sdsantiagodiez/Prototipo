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
            this.menuStripABM = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.tbPagePermisos = new System.Windows.Forms.TabPage();
            this.tbPageDatos = new System.Windows.Forms.TabPage();
            this.tblLayoutPanelDatos = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxObservaciones = new System.Windows.Forms.GroupBox();
            this.rchTextBoxObservaciones = new System.Windows.Forms.RichTextBox();
            this.grpBoxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelDatosPersonales = new System.Windows.Forms.TableLayoutPanel();
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
            this.grpBoxDireccion = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelDireccion = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuitarDireccion = new System.Windows.Forms.Button();
            this.btnAgregarDireccion = new System.Windows.Forms.Button();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtBoxCalle = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtBoxNumero = new System.Windows.Forms.TextBox();
            this.lblPiso = new System.Windows.Forms.Label();
            this.txtBoxPiso = new System.Windows.Forms.TextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtBoxCiudad = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.txtBoxCodigoPostal = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.cmbBoxProvincia = new System.Windows.Forms.ComboBox();
            this.txtBoxDepartamento = new System.Windows.Forms.TextBox();
            this.dataGridViewDireccion = new System.Windows.Forms.DataGridView();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBoxContacto = new System.Windows.Forms.GroupBox();
            this.tblLayoutPanelContacto = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelListaNumeroTelefono = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuitarNumeroTelefono = new System.Windows.Forms.Button();
            this.lstViewNumeroTelefono = new System.Windows.Forms.ListView();
            this.tblLayoutPanelNumeroTelefono = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregarNumeroTelefono = new System.Windows.Forms.Button();
            this.txtBoxNumeroTelefono = new System.Windows.Forms.TextBox();
            this.lblNumeroTelefono = new System.Windows.Forms.Label();
            this.cmbBoxTipoNumeroTelefono = new System.Windows.Forms.ComboBox();
            this.tblLayoutPanelMail = new System.Windows.Forms.TableLayoutPanel();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.btnAgregarMail = new System.Windows.Forms.Button();
            this.tblLayoutPanelListaMail = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuitarMail = new System.Windows.Forms.Button();
            this.lstViewMail = new System.Windows.Forms.ListView();
            this.tbCtrlPersonas = new System.Windows.Forms.TabControl();
            this.menuStripABM.SuspendLayout();
            this.tbPageDatos.SuspendLayout();
            this.tblLayoutPanelDatos.SuspendLayout();
            this.grpBoxObservaciones.SuspendLayout();
            this.grpBoxDatosPersonales.SuspendLayout();
            this.tblLayoutPanelDatosPersonales.SuspendLayout();
            this.grpBoxDireccion.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblLayoutPanelDireccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDireccion)).BeginInit();
            this.grpBoxContacto.SuspendLayout();
            this.tblLayoutPanelContacto.SuspendLayout();
            this.tblLayoutPanelListaNumeroTelefono.SuspendLayout();
            this.tblLayoutPanelNumeroTelefono.SuspendLayout();
            this.tblLayoutPanelMail.SuspendLayout();
            this.tblLayoutPanelListaMail.SuspendLayout();
            this.tbCtrlPersonas.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripABM
            // 
            this.menuStripABM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNuevo,
            this.toolStripMenuItemEliminar,
            this.toolStripMenuItemBuscar,
            this.toolStripMenuItemGuardar,
            this.toolStripMenuItemCancelar});
            this.menuStripABM.Location = new System.Drawing.Point(0, 0);
            this.menuStripABM.Name = "menuStripABM";
            this.menuStripABM.Size = new System.Drawing.Size(728, 24);
            this.menuStripABM.TabIndex = 0;
            this.menuStripABM.Text = "menuStrip1";
            // 
            // toolStripMenuItemNuevo
            // 
            this.toolStripMenuItemNuevo.Name = "toolStripMenuItemNuevo";
            this.toolStripMenuItemNuevo.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItemNuevo.Text = "Nuevo";
            // 
            // toolStripMenuItemEliminar
            // 
            this.toolStripMenuItemEliminar.Name = "toolStripMenuItemEliminar";
            this.toolStripMenuItemEliminar.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItemEliminar.Text = "Eliminar";
            // 
            // toolStripMenuItemBuscar
            // 
            this.toolStripMenuItemBuscar.Name = "toolStripMenuItemBuscar";
            this.toolStripMenuItemBuscar.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItemBuscar.Text = "Buscar";
            // 
            // toolStripMenuItemGuardar
            // 
            this.toolStripMenuItemGuardar.Name = "toolStripMenuItemGuardar";
            this.toolStripMenuItemGuardar.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItemGuardar.Text = "Guardar";
            // 
            // toolStripMenuItemCancelar
            // 
            this.toolStripMenuItemCancelar.Name = "toolStripMenuItemCancelar";
            this.toolStripMenuItemCancelar.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItemCancelar.Text = "Cancelar";
            // 
            // tbPagePermisos
            // 
            this.tbPagePermisos.BackColor = System.Drawing.SystemColors.Control;
            this.tbPagePermisos.Location = new System.Drawing.Point(4, 22);
            this.tbPagePermisos.Name = "tbPagePermisos";
            this.tbPagePermisos.Padding = new System.Windows.Forms.Padding(3);
            this.tbPagePermisos.Size = new System.Drawing.Size(792, 638);
            this.tbPagePermisos.TabIndex = 1;
            this.tbPagePermisos.Text = "Permisos";
            // 
            // tbPageDatos
            // 
            this.tbPageDatos.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageDatos.Controls.Add(this.tblLayoutPanelDatos);
            this.tbPageDatos.Location = new System.Drawing.Point(4, 22);
            this.tbPageDatos.Name = "tbPageDatos";
            this.tbPageDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageDatos.Size = new System.Drawing.Size(720, 611);
            this.tbPageDatos.TabIndex = 0;
            this.tbPageDatos.Text = "Datos";
            // 
            // tblLayoutPanelDatos
            // 
            this.tblLayoutPanelDatos.ColumnCount = 1;
            this.tblLayoutPanelDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDatos.Controls.Add(this.grpBoxObservaciones, 0, 3);
            this.tblLayoutPanelDatos.Controls.Add(this.grpBoxDatosPersonales, 0, 0);
            this.tblLayoutPanelDatos.Controls.Add(this.grpBoxDireccion, 0, 1);
            this.tblLayoutPanelDatos.Controls.Add(this.grpBoxContacto, 0, 2);
            this.tblLayoutPanelDatos.Location = new System.Drawing.Point(8, 6);
            this.tblLayoutPanelDatos.Name = "tblLayoutPanelDatos";
            this.tblLayoutPanelDatos.RowCount = 4;
            this.tblLayoutPanelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tblLayoutPanelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tblLayoutPanelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tblLayoutPanelDatos.Size = new System.Drawing.Size(701, 599);
            this.tblLayoutPanelDatos.TabIndex = 3;
            // 
            // grpBoxObservaciones
            // 
            this.grpBoxObservaciones.Controls.Add(this.rchTextBoxObservaciones);
            this.grpBoxObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxObservaciones.Location = new System.Drawing.Point(3, 481);
            this.grpBoxObservaciones.Name = "grpBoxObservaciones";
            this.grpBoxObservaciones.Size = new System.Drawing.Size(695, 115);
            this.grpBoxObservaciones.TabIndex = 2;
            this.grpBoxObservaciones.TabStop = false;
            this.grpBoxObservaciones.Text = "Observaciones";
            // 
            // rchTextBoxObservaciones
            // 
            this.rchTextBoxObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchTextBoxObservaciones.Location = new System.Drawing.Point(3, 16);
            this.rchTextBoxObservaciones.Name = "rchTextBoxObservaciones";
            this.rchTextBoxObservaciones.Size = new System.Drawing.Size(689, 96);
            this.rchTextBoxObservaciones.TabIndex = 1;
            this.rchTextBoxObservaciones.Text = "";
            // 
            // grpBoxDatosPersonales
            // 
            this.grpBoxDatosPersonales.Controls.Add(this.tblLayoutPanelDatosPersonales);
            this.grpBoxDatosPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDatosPersonales.Location = new System.Drawing.Point(3, 3);
            this.grpBoxDatosPersonales.Name = "grpBoxDatosPersonales";
            this.grpBoxDatosPersonales.Size = new System.Drawing.Size(695, 102);
            this.grpBoxDatosPersonales.TabIndex = 3;
            this.grpBoxDatosPersonales.TabStop = false;
            this.grpBoxDatosPersonales.Text = "Datos Personales";
            // 
            // tblLayoutPanelDatosPersonales
            // 
            this.tblLayoutPanelDatosPersonales.ColumnCount = 4;
            this.tblLayoutPanelDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.469945F));
            this.tblLayoutPanelDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.39344F));
            this.tblLayoutPanelDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.lblCodigo, 0, 0);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.lblApellido, 2, 1);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.lblDNI, 0, 1);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.lblCUIT, 0, 2);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.txtBoxCodigo, 1, 0);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.txtBoxDNI, 1, 1);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.txtBoxCUIT, 1, 2);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.lblNombre, 2, 2);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.txtBoxApellido, 3, 1);
            this.tblLayoutPanelDatosPersonales.Controls.Add(this.txtBoxNombre, 3, 2);
            this.tblLayoutPanelDatosPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDatosPersonales.Location = new System.Drawing.Point(3, 16);
            this.tblLayoutPanelDatosPersonales.Name = "tblLayoutPanelDatosPersonales";
            this.tblLayoutPanelDatosPersonales.RowCount = 3;
            this.tblLayoutPanelDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tblLayoutPanelDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tblLayoutPanelDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tblLayoutPanelDatosPersonales.Size = new System.Drawing.Size(689, 83);
            this.tblLayoutPanelDatosPersonales.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(3, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 26);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(278, 31);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 17);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDNI
            // 
            this.lblDNI.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(20, 31);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(35, 17);
            this.lblDNI.TabIndex = 1;
            this.lblDNI.Text = "DNI:";
            // 
            // lblCUIT
            // 
            this.lblCUIT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUIT.Location = new System.Drawing.Point(12, 60);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(43, 17);
            this.lblCUIT.TabIndex = 4;
            this.lblCUIT.Text = "CUIT:";
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigo.Location = new System.Drawing.Point(61, 3);
            this.txtBoxCodigo.Name = "txtBoxCodigo";
            this.txtBoxCodigo.Size = new System.Drawing.Size(107, 20);
            this.txtBoxCodigo.TabIndex = 5;
            // 
            // txtBoxDNI
            // 
            this.txtBoxDNI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDNI.Location = new System.Drawing.Point(61, 30);
            this.txtBoxDNI.Name = "txtBoxDNI";
            this.txtBoxDNI.Size = new System.Drawing.Size(107, 20);
            this.txtBoxDNI.TabIndex = 6;
            // 
            // txtBoxCUIT
            // 
            this.txtBoxCUIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCUIT.Location = new System.Drawing.Point(61, 58);
            this.txtBoxCUIT.Name = "txtBoxCUIT";
            this.txtBoxCUIT.Size = new System.Drawing.Size(107, 20);
            this.txtBoxCUIT.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(278, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxApellido.Location = new System.Drawing.Point(346, 30);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(340, 20);
            this.txtBoxApellido.TabIndex = 8;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNombre.Location = new System.Drawing.Point(346, 58);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(340, 20);
            this.txtBoxNombre.TabIndex = 9;
            // 
            // grpBoxDireccion
            // 
            this.grpBoxDireccion.Controls.Add(this.tableLayoutPanel1);
            this.grpBoxDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDireccion.Location = new System.Drawing.Point(3, 111);
            this.grpBoxDireccion.Name = "grpBoxDireccion";
            this.grpBoxDireccion.Size = new System.Drawing.Size(695, 204);
            this.grpBoxDireccion.TabIndex = 4;
            this.grpBoxDireccion.TabStop = false;
            this.grpBoxDireccion.Text = "Dirección";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tblLayoutPanelDireccion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewDireccion, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(689, 185);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tblLayoutPanelDireccion
            // 
            this.tblLayoutPanelDireccion.ColumnCount = 8;
            this.tblLayoutPanelDireccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.58427F));
            this.tblLayoutPanelDireccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.41573F));
            this.tblLayoutPanelDireccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tblLayoutPanelDireccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tblLayoutPanelDireccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tblLayoutPanelDireccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tblLayoutPanelDireccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tblLayoutPanelDireccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tblLayoutPanelDireccion.Controls.Add(this.btnQuitarDireccion, 7, 1);
            this.tblLayoutPanelDireccion.Controls.Add(this.btnAgregarDireccion, 6, 1);
            this.tblLayoutPanelDireccion.Controls.Add(this.lblCalle, 0, 0);
            this.tblLayoutPanelDireccion.Controls.Add(this.txtBoxCalle, 1, 0);
            this.tblLayoutPanelDireccion.Controls.Add(this.lblNumero, 2, 0);
            this.tblLayoutPanelDireccion.Controls.Add(this.txtBoxNumero, 3, 0);
            this.tblLayoutPanelDireccion.Controls.Add(this.lblPiso, 4, 0);
            this.tblLayoutPanelDireccion.Controls.Add(this.txtBoxPiso, 5, 0);
            this.tblLayoutPanelDireccion.Controls.Add(this.lblDepartamento, 6, 0);
            this.tblLayoutPanelDireccion.Controls.Add(this.txtBoxCiudad, 3, 1);
            this.tblLayoutPanelDireccion.Controls.Add(this.lblCiudad, 2, 1);
            this.tblLayoutPanelDireccion.Controls.Add(this.lblCodigoPostal, 0, 1);
            this.tblLayoutPanelDireccion.Controls.Add(this.txtBoxCodigoPostal, 1, 1);
            this.tblLayoutPanelDireccion.Controls.Add(this.lblProvincia, 4, 1);
            this.tblLayoutPanelDireccion.Controls.Add(this.cmbBoxProvincia, 5, 1);
            this.tblLayoutPanelDireccion.Controls.Add(this.txtBoxDepartamento, 7, 0);
            this.tblLayoutPanelDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDireccion.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelDireccion.Name = "tblLayoutPanelDireccion";
            this.tblLayoutPanelDireccion.RowCount = 2;
            this.tblLayoutPanelDireccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.72414F));
            this.tblLayoutPanelDireccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.27586F));
            this.tblLayoutPanelDireccion.Size = new System.Drawing.Size(683, 86);
            this.tblLayoutPanelDireccion.TabIndex = 0;
            // 
            // btnQuitarDireccion
            // 
            this.btnQuitarDireccion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnQuitarDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarDireccion.Location = new System.Drawing.Point(636, 54);
            this.btnQuitarDireccion.Name = "btnQuitarDireccion";
            this.btnQuitarDireccion.Size = new System.Drawing.Size(22, 22);
            this.btnQuitarDireccion.TabIndex = 16;
            this.btnQuitarDireccion.UseVisualStyleBackColor = true;
            // 
            // btnAgregarDireccion
            // 
            this.btnAgregarDireccion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregarDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDireccion.Location = new System.Drawing.Point(608, 54);
            this.btnAgregarDireccion.Name = "btnAgregarDireccion";
            this.btnAgregarDireccion.Size = new System.Drawing.Size(22, 22);
            this.btnAgregarDireccion.TabIndex = 15;
            this.btnAgregarDireccion.UseVisualStyleBackColor = true;
            // 
            // lblCalle
            // 
            this.lblCalle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(12, 13);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(43, 17);
            this.lblCalle.TabIndex = 1;
            this.lblCalle.Text = "Calle:";
            // 
            // txtBoxCalle
            // 
            this.txtBoxCalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCalle.Location = new System.Drawing.Point(61, 12);
            this.txtBoxCalle.Name = "txtBoxCalle";
            this.txtBoxCalle.Size = new System.Drawing.Size(114, 20);
            this.txtBoxCalle.TabIndex = 8;
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(183, 13);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(62, 17);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Número:";
            // 
            // txtBoxNumero
            // 
            this.txtBoxNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNumero.Location = new System.Drawing.Point(251, 12);
            this.txtBoxNumero.Name = "txtBoxNumero";
            this.txtBoxNumero.Size = new System.Drawing.Size(92, 20);
            this.txtBoxNumero.TabIndex = 9;
            // 
            // lblPiso
            // 
            this.lblPiso.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPiso.AutoSize = true;
            this.lblPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiso.Location = new System.Drawing.Point(382, 13);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(39, 17);
            this.lblPiso.TabIndex = 2;
            this.lblPiso.Text = "Piso:";
            // 
            // txtBoxPiso
            // 
            this.txtBoxPiso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPiso.Location = new System.Drawing.Point(427, 12);
            this.txtBoxPiso.Name = "txtBoxPiso";
            this.txtBoxPiso.Size = new System.Drawing.Size(91, 20);
            this.txtBoxPiso.TabIndex = 10;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(528, 13);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(102, 17);
            this.lblDepartamento.TabIndex = 7;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // txtBoxCiudad
            // 
            this.txtBoxCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCiudad.Location = new System.Drawing.Point(251, 55);
            this.txtBoxCiudad.Name = "txtBoxCiudad";
            this.txtBoxCiudad.Size = new System.Drawing.Size(92, 20);
            this.txtBoxCiudad.TabIndex = 13;
            // 
            // lblCiudad
            // 
            this.lblCiudad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(189, 56);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(56, 17);
            this.lblCiudad.TabIndex = 5;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPostal.Location = new System.Drawing.Point(3, 48);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(52, 34);
            this.lblCodigoPostal.TabIndex = 4;
            this.lblCodigoPostal.Text = "Código Postal:";
            // 
            // txtBoxCodigoPostal
            // 
            this.txtBoxCodigoPostal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoPostal.Location = new System.Drawing.Point(61, 55);
            this.txtBoxCodigoPostal.Name = "txtBoxCodigoPostal";
            this.txtBoxCodigoPostal.Size = new System.Drawing.Size(114, 20);
            this.txtBoxCodigoPostal.TabIndex = 11;
            // 
            // lblProvincia
            // 
            this.lblProvincia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(351, 56);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(70, 17);
            this.lblProvincia.TabIndex = 6;
            this.lblProvincia.Text = "Provincia:";
            // 
            // cmbBoxProvincia
            // 
            this.cmbBoxProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxProvincia.FormattingEnabled = true;
            this.cmbBoxProvincia.Items.AddRange(new object[] {
            "Buenos Aires",
            "Córdoba",
            "Corrientes",
            "Tucumán",
            "Santa Cruz",
            "Santa Fe",
            ""});
            this.cmbBoxProvincia.Location = new System.Drawing.Point(427, 54);
            this.cmbBoxProvincia.Name = "cmbBoxProvincia";
            this.cmbBoxProvincia.Size = new System.Drawing.Size(91, 21);
            this.cmbBoxProvincia.TabIndex = 14;
            // 
            // txtBoxDepartamento
            // 
            this.txtBoxDepartamento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxDepartamento.Location = new System.Drawing.Point(636, 12);
            this.txtBoxDepartamento.Name = "txtBoxDepartamento";
            this.txtBoxDepartamento.Size = new System.Drawing.Size(34, 20);
            this.txtBoxDepartamento.TabIndex = 12;
            // 
            // dataGridViewDireccion
            // 
            this.dataGridViewDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDireccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDireccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.calle,
            this.numero,
            this.piso,
            this.departamento,
            this.codigoPostal,
            this.ciudad,
            this.provincia});
            this.dataGridViewDireccion.Location = new System.Drawing.Point(3, 95);
            this.dataGridViewDireccion.Name = "dataGridViewDireccion";
            this.dataGridViewDireccion.Size = new System.Drawing.Size(683, 87);
            this.dataGridViewDireccion.TabIndex = 1;
            // 
            // calle
            // 
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            this.calle.Width = 110;
            // 
            // numero
            // 
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            this.numero.Width = 60;
            // 
            // piso
            // 
            this.piso.HeaderText = "Piso";
            this.piso.Name = "piso";
            this.piso.Width = 70;
            // 
            // departamento
            // 
            this.departamento.HeaderText = "Departamento";
            this.departamento.Name = "departamento";
            this.departamento.Width = 80;
            // 
            // codigoPostal
            // 
            this.codigoPostal.HeaderText = "Código Postal";
            this.codigoPostal.Name = "codigoPostal";
            // 
            // ciudad
            // 
            this.ciudad.HeaderText = "Ciudad";
            this.ciudad.Name = "ciudad";
            this.ciudad.Width = 110;
            // 
            // provincia
            // 
            this.provincia.HeaderText = "Provincia";
            this.provincia.Name = "provincia";
            this.provincia.Width = 110;
            // 
            // grpBoxContacto
            // 
            this.grpBoxContacto.Controls.Add(this.tblLayoutPanelContacto);
            this.grpBoxContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxContacto.Location = new System.Drawing.Point(3, 321);
            this.grpBoxContacto.Name = "grpBoxContacto";
            this.grpBoxContacto.Size = new System.Drawing.Size(695, 154);
            this.grpBoxContacto.TabIndex = 5;
            this.grpBoxContacto.TabStop = false;
            this.grpBoxContacto.Text = "Contacto";
            // 
            // tblLayoutPanelContacto
            // 
            this.tblLayoutPanelContacto.ColumnCount = 2;
            this.tblLayoutPanelContacto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.40984F));
            this.tblLayoutPanelContacto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.59016F));
            this.tblLayoutPanelContacto.Controls.Add(this.tblLayoutPanelListaNumeroTelefono, 1, 1);
            this.tblLayoutPanelContacto.Controls.Add(this.tblLayoutPanelNumeroTelefono, 1, 0);
            this.tblLayoutPanelContacto.Controls.Add(this.tblLayoutPanelMail, 0, 0);
            this.tblLayoutPanelContacto.Controls.Add(this.tblLayoutPanelListaMail, 0, 1);
            this.tblLayoutPanelContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelContacto.Location = new System.Drawing.Point(3, 16);
            this.tblLayoutPanelContacto.Name = "tblLayoutPanelContacto";
            this.tblLayoutPanelContacto.RowCount = 2;
            this.tblLayoutPanelContacto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.7037F));
            this.tblLayoutPanelContacto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.2963F));
            this.tblLayoutPanelContacto.Size = new System.Drawing.Size(689, 135);
            this.tblLayoutPanelContacto.TabIndex = 0;
            // 
            // tblLayoutPanelListaNumeroTelefono
            // 
            this.tblLayoutPanelListaNumeroTelefono.ColumnCount = 2;
            this.tblLayoutPanelListaNumeroTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelListaNumeroTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblLayoutPanelListaNumeroTelefono.Controls.Add(this.btnQuitarNumeroTelefono, 1, 0);
            this.tblLayoutPanelListaNumeroTelefono.Controls.Add(this.lstViewNumeroTelefono, 0, 0);
            this.tblLayoutPanelListaNumeroTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelListaNumeroTelefono.Location = new System.Drawing.Point(350, 62);
            this.tblLayoutPanelListaNumeroTelefono.Name = "tblLayoutPanelListaNumeroTelefono";
            this.tblLayoutPanelListaNumeroTelefono.RowCount = 1;
            this.tblLayoutPanelListaNumeroTelefono.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelListaNumeroTelefono.Size = new System.Drawing.Size(336, 70);
            this.tblLayoutPanelListaNumeroTelefono.TabIndex = 3;
            // 
            // btnQuitarNumeroTelefono
            // 
            this.btnQuitarNumeroTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarNumeroTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarNumeroTelefono.Location = new System.Drawing.Point(313, 24);
            this.btnQuitarNumeroTelefono.Name = "btnQuitarNumeroTelefono";
            this.btnQuitarNumeroTelefono.Size = new System.Drawing.Size(20, 22);
            this.btnQuitarNumeroTelefono.TabIndex = 11;
            this.btnQuitarNumeroTelefono.UseVisualStyleBackColor = true;
            // 
            // lstViewNumeroTelefono
            // 
            this.lstViewNumeroTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstViewNumeroTelefono.Location = new System.Drawing.Point(3, 3);
            this.lstViewNumeroTelefono.Name = "lstViewNumeroTelefono";
            this.lstViewNumeroTelefono.Size = new System.Drawing.Size(304, 64);
            this.lstViewNumeroTelefono.TabIndex = 12;
            this.lstViewNumeroTelefono.UseCompatibleStateImageBehavior = false;
            // 
            // tblLayoutPanelNumeroTelefono
            // 
            this.tblLayoutPanelNumeroTelefono.ColumnCount = 4;
            this.tblLayoutPanelNumeroTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblLayoutPanelNumeroTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.08108F));
            this.tblLayoutPanelNumeroTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.91892F));
            this.tblLayoutPanelNumeroTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblLayoutPanelNumeroTelefono.Controls.Add(this.btnAgregarNumeroTelefono, 3, 0);
            this.tblLayoutPanelNumeroTelefono.Controls.Add(this.txtBoxNumeroTelefono, 2, 0);
            this.tblLayoutPanelNumeroTelefono.Controls.Add(this.lblNumeroTelefono, 1, 0);
            this.tblLayoutPanelNumeroTelefono.Controls.Add(this.cmbBoxTipoNumeroTelefono, 0, 0);
            this.tblLayoutPanelNumeroTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelNumeroTelefono.Location = new System.Drawing.Point(350, 3);
            this.tblLayoutPanelNumeroTelefono.Name = "tblLayoutPanelNumeroTelefono";
            this.tblLayoutPanelNumeroTelefono.RowCount = 1;
            this.tblLayoutPanelNumeroTelefono.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelNumeroTelefono.Size = new System.Drawing.Size(336, 53);
            this.tblLayoutPanelNumeroTelefono.TabIndex = 2;
            // 
            // btnAgregarNumeroTelefono
            // 
            this.btnAgregarNumeroTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarNumeroTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNumeroTelefono.Location = new System.Drawing.Point(312, 15);
            this.btnAgregarNumeroTelefono.Name = "btnAgregarNumeroTelefono";
            this.btnAgregarNumeroTelefono.Size = new System.Drawing.Size(21, 23);
            this.btnAgregarNumeroTelefono.TabIndex = 10;
            this.btnAgregarNumeroTelefono.UseVisualStyleBackColor = true;
            // 
            // txtBoxNumeroTelefono
            // 
            this.txtBoxNumeroTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNumeroTelefono.Location = new System.Drawing.Point(133, 16);
            this.txtBoxNumeroTelefono.Name = "txtBoxNumeroTelefono";
            this.txtBoxNumeroTelefono.Size = new System.Drawing.Size(173, 20);
            this.txtBoxNumeroTelefono.TabIndex = 8;
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTelefono.Location = new System.Drawing.Point(65, 18);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(62, 17);
            this.lblNumeroTelefono.TabIndex = 9;
            this.lblNumeroTelefono.Text = "Número:";
            // 
            // cmbBoxTipoNumeroTelefono
            // 
            this.cmbBoxTipoNumeroTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxTipoNumeroTelefono.FormattingEnabled = true;
            this.cmbBoxTipoNumeroTelefono.Items.AddRange(new object[] {
            "TEL",
            "CEL",
            "FAX"});
            this.cmbBoxTipoNumeroTelefono.Location = new System.Drawing.Point(3, 16);
            this.cmbBoxTipoNumeroTelefono.Name = "cmbBoxTipoNumeroTelefono";
            this.cmbBoxTipoNumeroTelefono.Size = new System.Drawing.Size(44, 21);
            this.cmbBoxTipoNumeroTelefono.TabIndex = 11;
            // 
            // tblLayoutPanelMail
            // 
            this.tblLayoutPanelMail.ColumnCount = 3;
            this.tblLayoutPanelMail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.39297F));
            this.tblLayoutPanelMail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.60703F));
            this.tblLayoutPanelMail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tblLayoutPanelMail.Controls.Add(this.lblMail, 0, 0);
            this.tblLayoutPanelMail.Controls.Add(this.txtBoxMail, 1, 0);
            this.tblLayoutPanelMail.Controls.Add(this.btnAgregarMail, 2, 0);
            this.tblLayoutPanelMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelMail.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelMail.Name = "tblLayoutPanelMail";
            this.tblLayoutPanelMail.RowCount = 1;
            this.tblLayoutPanelMail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelMail.Size = new System.Drawing.Size(341, 53);
            this.tblLayoutPanelMail.TabIndex = 0;
            // 
            // lblMail
            // 
            this.lblMail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(6, 9);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(82, 34);
            this.lblMail.TabIndex = 9;
            this.lblMail.Text = "Correo Electrónico:";
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxMail.Location = new System.Drawing.Point(94, 16);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(215, 20);
            this.txtBoxMail.TabIndex = 8;
            // 
            // btnAgregarMail
            // 
            this.btnAgregarMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMail.Location = new System.Drawing.Point(315, 15);
            this.btnAgregarMail.Name = "btnAgregarMail";
            this.btnAgregarMail.Size = new System.Drawing.Size(23, 22);
            this.btnAgregarMail.TabIndex = 10;
            this.btnAgregarMail.UseVisualStyleBackColor = true;
            // 
            // tblLayoutPanelListaMail
            // 
            this.tblLayoutPanelListaMail.ColumnCount = 2;
            this.tblLayoutPanelListaMail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelListaMail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tblLayoutPanelListaMail.Controls.Add(this.btnQuitarMail, 1, 0);
            this.tblLayoutPanelListaMail.Controls.Add(this.lstViewMail, 0, 0);
            this.tblLayoutPanelListaMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelListaMail.Location = new System.Drawing.Point(3, 62);
            this.tblLayoutPanelListaMail.Name = "tblLayoutPanelListaMail";
            this.tblLayoutPanelListaMail.RowCount = 1;
            this.tblLayoutPanelListaMail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelListaMail.Size = new System.Drawing.Size(341, 70);
            this.tblLayoutPanelListaMail.TabIndex = 1;
            // 
            // btnQuitarMail
            // 
            this.btnQuitarMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarMail.Location = new System.Drawing.Point(316, 24);
            this.btnQuitarMail.Name = "btnQuitarMail";
            this.btnQuitarMail.Size = new System.Drawing.Size(22, 22);
            this.btnQuitarMail.TabIndex = 11;
            this.btnQuitarMail.UseVisualStyleBackColor = true;
            // 
            // lstViewMail
            // 
            this.lstViewMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstViewMail.Location = new System.Drawing.Point(3, 3);
            this.lstViewMail.Name = "lstViewMail";
            this.lstViewMail.Size = new System.Drawing.Size(307, 64);
            this.lstViewMail.TabIndex = 12;
            this.lstViewMail.UseCompatibleStateImageBehavior = false;
            // 
            // tbCtrlPersonas
            // 
            this.tbCtrlPersonas.Controls.Add(this.tbPageDatos);
            this.tbCtrlPersonas.Controls.Add(this.tbPagePermisos);
            this.tbCtrlPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCtrlPersonas.Location = new System.Drawing.Point(0, 24);
            this.tbCtrlPersonas.Name = "tbCtrlPersonas";
            this.tbCtrlPersonas.SelectedIndex = 0;
            this.tbCtrlPersonas.Size = new System.Drawing.Size(728, 637);
            this.tbCtrlPersonas.TabIndex = 1;
            // 
            // frmABMPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 661);
            this.Controls.Add(this.tbCtrlPersonas);
            this.Controls.Add(this.menuStripABM);
            this.MainMenuStrip = this.menuStripABM;
            this.Name = "frmABMPersona";
            this.Text = "ABM Personas";
            this.menuStripABM.ResumeLayout(false);
            this.menuStripABM.PerformLayout();
            this.tbPageDatos.ResumeLayout(false);
            this.tblLayoutPanelDatos.ResumeLayout(false);
            this.grpBoxObservaciones.ResumeLayout(false);
            this.grpBoxDatosPersonales.ResumeLayout(false);
            this.tblLayoutPanelDatosPersonales.ResumeLayout(false);
            this.tblLayoutPanelDatosPersonales.PerformLayout();
            this.grpBoxDireccion.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tblLayoutPanelDireccion.ResumeLayout(false);
            this.tblLayoutPanelDireccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDireccion)).EndInit();
            this.grpBoxContacto.ResumeLayout(false);
            this.tblLayoutPanelContacto.ResumeLayout(false);
            this.tblLayoutPanelListaNumeroTelefono.ResumeLayout(false);
            this.tblLayoutPanelNumeroTelefono.ResumeLayout(false);
            this.tblLayoutPanelNumeroTelefono.PerformLayout();
            this.tblLayoutPanelMail.ResumeLayout(false);
            this.tblLayoutPanelMail.PerformLayout();
            this.tblLayoutPanelListaMail.ResumeLayout(false);
            this.tbCtrlPersonas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripABM;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNuevo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEliminar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBuscar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGuardar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCancelar;
        private System.Windows.Forms.TabPage tbPagePermisos;
        private System.Windows.Forms.TabPage tbPageDatos;
        private System.Windows.Forms.TabControl tbCtrlPersonas;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDatosPersonales;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDatos;
        private System.Windows.Forms.TextBox txtBoxCodigo;
        private System.Windows.Forms.TextBox txtBoxDNI;
        private System.Windows.Forms.TextBox txtBoxCUIT;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.GroupBox grpBoxObservaciones;
        private System.Windows.Forms.RichTextBox rchTextBoxObservaciones;
        private System.Windows.Forms.GroupBox grpBoxDatosPersonales;
        private System.Windows.Forms.GroupBox grpBoxDireccion;
        private System.Windows.Forms.GroupBox grpBoxContacto;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelContacto;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.Button btnAgregarMail;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelListaMail;
        private System.Windows.Forms.Button btnQuitarMail;
        private System.Windows.Forms.ListView lstViewMail;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelListaNumeroTelefono;
        private System.Windows.Forms.Button btnQuitarNumeroTelefono;
        private System.Windows.Forms.ListView lstViewNumeroTelefono;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelNumeroTelefono;
        private System.Windows.Forms.Label lblNumeroTelefono;
        private System.Windows.Forms.TextBox txtBoxNumeroTelefono;
        private System.Windows.Forms.Button btnAgregarNumeroTelefono;
        private System.Windows.Forms.ComboBox cmbBoxTipoNumeroTelefono;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDireccion;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtBoxCalle;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtBoxNumero;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.TextBox txtBoxPiso;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtBoxDepartamento;
        private System.Windows.Forms.TextBox txtBoxCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.TextBox txtBoxCodigoPostal;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.ComboBox cmbBoxProvincia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewDireccion;
        private System.Windows.Forms.Button btnQuitarDireccion;
        private System.Windows.Forms.Button btnAgregarDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn provincia;
    }
}