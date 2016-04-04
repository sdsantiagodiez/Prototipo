﻿namespace Vista
{
    partial class frmPedidoCierre
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
            this.tblLayoutPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.gbxArticulos = new System.Windows.Forms.GroupBox();
            this.dgvArticulosVenta = new System.Windows.Forms.DataGridView();
            this.codOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLayoutPanelValoresPedido = new System.Windows.Forms.TableLayoutPanel();
            this.lblIVA = new System.Windows.Forms.Label();
            this.txtBoxSubtotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBoxDescuentoLineas = new System.Windows.Forms.TextBox();
            this.lblDescuentoLineas = new System.Windows.Forms.Label();
            this.txtBoxDescuentoTotal = new System.Windows.Forms.TextBox();
            this.lblDescuentoTotal = new System.Windows.Forms.Label();
            this.txtBoxDescuentoPorcentualMonto = new System.Windows.Forms.TextBox();
            this.lblDescuentoPorcentual = new System.Windows.Forms.Label();
            this.txtBoxDescuentoNetoMonto = new System.Windows.Forms.TextBox();
            this.lblDescuentoNeto = new System.Windows.Forms.Label();
            this.txtBoxIVAMonto = new System.Windows.Forms.TextBox();
            this.txtBoxSenia = new System.Windows.Forms.TextBox();
            this.txtBoxIVAPorcentaje = new System.Windows.Forms.TextBox();
            this.lblSenia = new System.Windows.Forms.Label();
            this.txtBoxDescuentoPorcentualPorcentaje = new System.Windows.Forms.TextBox();
            this.txtBoxDescuentoNetoPorcentaje = new System.Windows.Forms.TextBox();
            this.tblLayoutPanelBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbBoxPedidosProveedores = new System.Windows.Forms.ComboBox();
            this.tbControlPrincipal = new System.Windows.Forms.TabControl();
            this.tbPageDatosGenerales = new System.Windows.Forms.TabPage();
            this.tblLayoutPanelDatosGenerales = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEntidadDatos = new System.Windows.Forms.Panel();
            this.grpBoxObservaciones = new System.Windows.Forms.GroupBox();
            this.rchTextBoxObservaciones = new System.Windows.Forms.RichTextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.tblLayoutPanelPedido = new System.Windows.Forms.TableLayoutPanel();
            this.cmbBoxTipoComprobante = new System.Windows.Forms.ComboBox();
            this.lblNumeroPedido = new System.Windows.Forms.Label();
            this.lblTipoComprobante = new System.Windows.Forms.Label();
            this.txtBoxNumeroPedido = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.cmbBoxFormaPago = new System.Windows.Forms.ComboBox();
            this.tblLayoutPanelEntidadDatos = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtBoxDNI = new System.Windows.Forms.TextBox();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.txtBoxCUIT = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbPageDomicilioFacturacion = new System.Windows.Forms.TabPage();
            this.tblLayoutPanelDomicilioFacturacion = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPanelDomicilio = new System.Windows.Forms.TableLayoutPanel();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtBoxCalle = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.txtBoxPiso = new System.Windows.Forms.TextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.cmbBoxProvincia = new System.Windows.Forms.ComboBox();
            this.txtBoxDepartamento = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtBoxCiudad = new System.Windows.Forms.TextBox();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.txtBoxCodigoPostal = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.cmbBoxPais = new System.Windows.Forms.ComboBox();
            this.txtBoxNumeroDomicilio = new System.Windows.Forms.TextBox();
            this.cmbBoxDomicilios = new System.Windows.Forms.ComboBox();
            this.tbPageDatosContacto = new System.Windows.Forms.TabPage();
            this.tblLayoutPanelDatosContacto = new System.Windows.Forms.TableLayoutPanel();
            this.cmbBoxTelefonos = new System.Windows.Forms.ComboBox();
            this.tblLayoutPanelMail = new System.Windows.Forms.TableLayoutPanel();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.tblLayoutPanelTelefono = new System.Windows.Forms.TableLayoutPanel();
            this.cmbBoxTipoTelefono = new System.Windows.Forms.ComboBox();
            this.txtBoxTelefono = new System.Windows.Forms.TextBox();
            this.lblNumeroTelefono = new System.Windows.Forms.Label();
            this.lblTipoTelefono = new System.Windows.Forms.Label();
            this.cmbBoxMails = new System.Windows.Forms.ComboBox();
            this.tabPageObservaciones = new System.Windows.Forms.TabPage();
            this.rchTextBoxObservacionesPedido = new System.Windows.Forms.RichTextBox();
            this.modeloLineaPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLayoutPanelPrincipal.SuspendLayout();
            this.gbxArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosVenta)).BeginInit();
            this.tblLayoutPanelValoresPedido.SuspendLayout();
            this.tblLayoutPanelBotones.SuspendLayout();
            this.tbControlPrincipal.SuspendLayout();
            this.tbPageDatosGenerales.SuspendLayout();
            this.tblLayoutPanelDatosGenerales.SuspendLayout();
            this.pnlEntidadDatos.SuspendLayout();
            this.grpBoxObservaciones.SuspendLayout();
            this.tblLayoutPanelPedido.SuspendLayout();
            this.tblLayoutPanelEntidadDatos.SuspendLayout();
            this.tbPageDomicilioFacturacion.SuspendLayout();
            this.tblLayoutPanelDomicilioFacturacion.SuspendLayout();
            this.tblLayoutPanelDomicilio.SuspendLayout();
            this.tbPageDatosContacto.SuspendLayout();
            this.tblLayoutPanelDatosContacto.SuspendLayout();
            this.tblLayoutPanelMail.SuspendLayout();
            this.tblLayoutPanelTelefono.SuspendLayout();
            this.tabPageObservaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modeloLineaPedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLayoutPanelPrincipal
            // 
            this.tblLayoutPanelPrincipal.ColumnCount = 1;
            this.tblLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal.Controls.Add(this.gbxArticulos, 0, 1);
            this.tblLayoutPanelPrincipal.Controls.Add(this.tblLayoutPanelValoresPedido, 0, 2);
            this.tblLayoutPanelPrincipal.Controls.Add(this.tblLayoutPanelBotones, 0, 3);
            this.tblLayoutPanelPrincipal.Controls.Add(this.tbControlPrincipal, 0, 0);
            this.tblLayoutPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanelPrincipal.Name = "tblLayoutPanelPrincipal";
            this.tblLayoutPanelPrincipal.RowCount = 4;
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tblLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tblLayoutPanelPrincipal.Size = new System.Drawing.Size(699, 481);
            this.tblLayoutPanelPrincipal.TabIndex = 0;
            // 
            // gbxArticulos
            // 
            this.gbxArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxArticulos.Controls.Add(this.dgvArticulosVenta);
            this.gbxArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxArticulos.Location = new System.Drawing.Point(3, 183);
            this.gbxArticulos.Name = "gbxArticulos";
            this.gbxArticulos.Size = new System.Drawing.Size(693, 159);
            this.gbxArticulos.TabIndex = 14;
            this.gbxArticulos.TabStop = false;
            this.gbxArticulos.Text = "Artículos";
            // 
            // dgvArticulosVenta
            // 
            this.dgvArticulosVenta.AllowUserToAddRows = false;
            this.dgvArticulosVenta.AllowUserToDeleteRows = false;
            this.dgvArticulosVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulosVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codOriginal,
            this.codProveedor,
            this.descripcion,
            this.cantidad,
            this.vUnitario,
            this.descuento,
            this.vParcial});
            this.dgvArticulosVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticulosVenta.Location = new System.Drawing.Point(3, 18);
            this.dgvArticulosVenta.Name = "dgvArticulosVenta";
            this.dgvArticulosVenta.ReadOnly = true;
            this.dgvArticulosVenta.RowHeadersVisible = false;
            this.dgvArticulosVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulosVenta.Size = new System.Drawing.Size(687, 138);
            this.dgvArticulosVenta.TabIndex = 5;
            // 
            // codOriginal
            // 
            this.codOriginal.DataPropertyName = "codigoOriginal";
            this.codOriginal.HeaderText = "Código Original";
            this.codOriginal.Name = "codOriginal";
            this.codOriginal.ReadOnly = true;
            // 
            // codProveedor
            // 
            this.codProveedor.DataPropertyName = "codigoArticuloProveedor";
            this.codProveedor.HeaderText = "Código Proveedor";
            this.codProveedor.Name = "codProveedor";
            this.codProveedor.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // vUnitario
            // 
            this.vUnitario.DataPropertyName = "valorUnitario";
            this.vUnitario.HeaderText = "Valor Unitario";
            this.vUnitario.Name = "vUnitario";
            this.vUnitario.ReadOnly = true;
            // 
            // descuento
            // 
            this.descuento.DataPropertyName = "descuento";
            this.descuento.HeaderText = "Descuento";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            // 
            // vParcial
            // 
            this.vParcial.DataPropertyName = "valorParcial";
            this.vParcial.HeaderText = "Valor Parcial";
            this.vParcial.Name = "vParcial";
            this.vParcial.ReadOnly = true;
            // 
            // tblLayoutPanelValoresPedido
            // 
            this.tblLayoutPanelValoresPedido.AutoSize = true;
            this.tblLayoutPanelValoresPedido.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblLayoutPanelValoresPedido.ColumnCount = 10;
            this.tblLayoutPanelValoresPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.710307F));
            this.tblLayoutPanelValoresPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.988858F));
            this.tblLayoutPanelValoresPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.48468F));
            this.tblLayoutPanelValoresPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.53482F));
            this.tblLayoutPanelValoresPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.5961F));
            this.tblLayoutPanelValoresPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.7883F));
            this.tblLayoutPanelValoresPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.86351F));
            this.tblLayoutPanelValoresPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.55989F));
            this.tblLayoutPanelValoresPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.192201F));
            this.tblLayoutPanelValoresPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.39554F));
            this.tblLayoutPanelValoresPedido.Controls.Add(this.lblIVA, 0, 0);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.txtBoxSubtotal, 9, 0);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.lblSubtotal, 8, 0);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.txtBoxTotal, 9, 1);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.lblTotal, 8, 1);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.txtBoxDescuentoLineas, 7, 0);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.lblDescuentoLineas, 6, 0);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.txtBoxDescuentoTotal, 7, 1);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.lblDescuentoTotal, 6, 1);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.txtBoxDescuentoPorcentualMonto, 5, 0);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.lblDescuentoPorcentual, 3, 0);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.txtBoxDescuentoNetoMonto, 5, 1);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.lblDescuentoNeto, 3, 1);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.txtBoxIVAMonto, 2, 0);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.txtBoxSenia, 2, 1);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.txtBoxIVAPorcentaje, 1, 0);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.lblSenia, 1, 1);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.txtBoxDescuentoPorcentualPorcentaje, 4, 0);
            this.tblLayoutPanelValoresPedido.Controls.Add(this.txtBoxDescuentoNetoPorcentaje, 4, 1);
            this.tblLayoutPanelValoresPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelValoresPedido.Location = new System.Drawing.Point(3, 348);
            this.tblLayoutPanelValoresPedido.Name = "tblLayoutPanelValoresPedido";
            this.tblLayoutPanelValoresPedido.RowCount = 2;
            this.tblLayoutPanelValoresPedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelValoresPedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelValoresPedido.Size = new System.Drawing.Size(693, 73);
            this.tblLayoutPanelValoresPedido.TabIndex = 15;
            // 
            // lblIVA
            // 
            this.lblIVA.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(9, 11);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(27, 13);
            this.lblIVA.TabIndex = 0;
            this.lblIVA.Text = "IVA:";
            // 
            // txtBoxSubtotal
            // 
            this.txtBoxSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSubtotal.Location = new System.Drawing.Point(608, 8);
            this.txtBoxSubtotal.Name = "txtBoxSubtotal";
            this.txtBoxSubtotal.Size = new System.Drawing.Size(82, 20);
            this.txtBoxSubtotal.TabIndex = 11;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(553, 11);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 6;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxTotal.Location = new System.Drawing.Point(608, 44);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.Size = new System.Drawing.Size(82, 20);
            this.txtBoxTotal.TabIndex = 15;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(557, 48);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "TOTAL:";
            // 
            // txtBoxDescuentoLineas
            // 
            this.txtBoxDescuentoLineas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescuentoLineas.Location = new System.Drawing.Point(466, 8);
            this.txtBoxDescuentoLineas.Name = "txtBoxDescuentoLineas";
            this.txtBoxDescuentoLineas.Size = new System.Drawing.Size(73, 20);
            this.txtBoxDescuentoLineas.TabIndex = 10;
            // 
            // lblDescuentoLineas
            // 
            this.lblDescuentoLineas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescuentoLineas.AutoSize = true;
            this.lblDescuentoLineas.Location = new System.Drawing.Point(398, 5);
            this.lblDescuentoLineas.Name = "lblDescuentoLineas";
            this.lblDescuentoLineas.Size = new System.Drawing.Size(62, 26);
            this.lblDescuentoLineas.TabIndex = 4;
            this.lblDescuentoLineas.Text = "Descuento Líneas:";
            // 
            // txtBoxDescuentoTotal
            // 
            this.txtBoxDescuentoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescuentoTotal.Location = new System.Drawing.Point(466, 44);
            this.txtBoxDescuentoTotal.Name = "txtBoxDescuentoTotal";
            this.txtBoxDescuentoTotal.Size = new System.Drawing.Size(73, 20);
            this.txtBoxDescuentoTotal.TabIndex = 14;
            // 
            // lblDescuentoTotal
            // 
            this.lblDescuentoTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescuentoTotal.AutoSize = true;
            this.lblDescuentoTotal.Location = new System.Drawing.Point(398, 41);
            this.lblDescuentoTotal.Name = "lblDescuentoTotal";
            this.lblDescuentoTotal.Size = new System.Drawing.Size(62, 26);
            this.lblDescuentoTotal.TabIndex = 5;
            this.lblDescuentoTotal.Text = "Total Descuento:";
            // 
            // txtBoxDescuentoPorcentualMonto
            // 
            this.txtBoxDescuentoPorcentualMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescuentoPorcentualMonto.Location = new System.Drawing.Point(298, 8);
            this.txtBoxDescuentoPorcentualMonto.Name = "txtBoxDescuentoPorcentualMonto";
            this.txtBoxDescuentoPorcentualMonto.Size = new System.Drawing.Size(88, 20);
            this.txtBoxDescuentoPorcentualMonto.TabIndex = 9;
            // 
            // lblDescuentoPorcentual
            // 
            this.lblDescuentoPorcentual.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescuentoPorcentual.AutoSize = true;
            this.lblDescuentoPorcentual.Location = new System.Drawing.Point(182, 11);
            this.lblDescuentoPorcentual.Name = "lblDescuentoPorcentual";
            this.lblDescuentoPorcentual.Size = new System.Drawing.Size(79, 13);
            this.lblDescuentoPorcentual.TabIndex = 2;
            this.lblDescuentoPorcentual.Text = "Descuento (%):";
            // 
            // txtBoxDescuentoNetoMonto
            // 
            this.txtBoxDescuentoNetoMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescuentoNetoMonto.Location = new System.Drawing.Point(298, 44);
            this.txtBoxDescuentoNetoMonto.Name = "txtBoxDescuentoNetoMonto";
            this.txtBoxDescuentoNetoMonto.Size = new System.Drawing.Size(88, 20);
            this.txtBoxDescuentoNetoMonto.TabIndex = 13;
            // 
            // lblDescuentoNeto
            // 
            this.lblDescuentoNeto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescuentoNeto.AutoSize = true;
            this.lblDescuentoNeto.Location = new System.Drawing.Point(199, 48);
            this.lblDescuentoNeto.Name = "lblDescuentoNeto";
            this.lblDescuentoNeto.Size = new System.Drawing.Size(62, 13);
            this.lblDescuentoNeto.TabIndex = 3;
            this.lblDescuentoNeto.Text = "Descuento:";
            // 
            // txtBoxIVAMonto
            // 
            this.txtBoxIVAMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxIVAMonto.Enabled = false;
            this.txtBoxIVAMonto.Location = new System.Drawing.Point(83, 8);
            this.txtBoxIVAMonto.Name = "txtBoxIVAMonto";
            this.txtBoxIVAMonto.Size = new System.Drawing.Size(93, 20);
            this.txtBoxIVAMonto.TabIndex = 8;
            // 
            // txtBoxSenia
            // 
            this.txtBoxSenia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSenia.Location = new System.Drawing.Point(83, 44);
            this.txtBoxSenia.Name = "txtBoxSenia";
            this.txtBoxSenia.Size = new System.Drawing.Size(93, 20);
            this.txtBoxSenia.TabIndex = 12;
            // 
            // txtBoxIVAPorcentaje
            // 
            this.txtBoxIVAPorcentaje.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxIVAPorcentaje.Location = new System.Drawing.Point(42, 8);
            this.txtBoxIVAPorcentaje.Name = "txtBoxIVAPorcentaje";
            this.txtBoxIVAPorcentaje.Size = new System.Drawing.Size(35, 20);
            this.txtBoxIVAPorcentaje.TabIndex = 16;
            // 
            // lblSenia
            // 
            this.lblSenia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSenia.AutoSize = true;
            this.lblSenia.Location = new System.Drawing.Point(42, 48);
            this.lblSenia.Name = "lblSenia";
            this.lblSenia.Size = new System.Drawing.Size(35, 13);
            this.lblSenia.TabIndex = 1;
            this.lblSenia.Text = "Seña: ";
            // 
            // txtBoxDescuentoPorcentualPorcentaje
            // 
            this.txtBoxDescuentoPorcentualPorcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescuentoPorcentualPorcentaje.Location = new System.Drawing.Point(267, 8);
            this.txtBoxDescuentoPorcentualPorcentaje.Name = "txtBoxDescuentoPorcentualPorcentaje";
            this.txtBoxDescuentoPorcentualPorcentaje.Size = new System.Drawing.Size(25, 20);
            this.txtBoxDescuentoPorcentualPorcentaje.TabIndex = 17;
            // 
            // txtBoxDescuentoNetoPorcentaje
            // 
            this.txtBoxDescuentoNetoPorcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDescuentoNetoPorcentaje.Location = new System.Drawing.Point(267, 44);
            this.txtBoxDescuentoNetoPorcentaje.Name = "txtBoxDescuentoNetoPorcentaje";
            this.txtBoxDescuentoNetoPorcentaje.Size = new System.Drawing.Size(25, 20);
            this.txtBoxDescuentoNetoPorcentaje.TabIndex = 18;
            // 
            // tblLayoutPanelBotones
            // 
            this.tblLayoutPanelBotones.ColumnCount = 6;
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.81492F));
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.14017F));
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.01299F));
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.013F));
            this.tblLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.01892F));
            this.tblLayoutPanelBotones.Controls.Add(this.btnImprimir, 1, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.btnEliminar, 4, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.btnEditar, 3, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.btnAgregar, 2, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.btnSalir, 5, 0);
            this.tblLayoutPanelBotones.Controls.Add(this.cmbBoxPedidosProveedores, 0, 0);
            this.tblLayoutPanelBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelBotones.Location = new System.Drawing.Point(3, 427);
            this.tblLayoutPanelBotones.Name = "tblLayoutPanelBotones";
            this.tblLayoutPanelBotones.RowCount = 1;
            this.tblLayoutPanelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelBotones.Size = new System.Drawing.Size(693, 51);
            this.tblLayoutPanelBotones.TabIndex = 16;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImprimir.Location = new System.Drawing.Point(184, 14);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEliminar.Location = new System.Drawing.Point(477, 14);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.Location = new System.Drawing.Point(391, 14);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregar.Location = new System.Drawing.Point(306, 14);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(600, 14);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // cmbBoxPedidosProveedores
            // 
            this.cmbBoxPedidosProveedores.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbBoxPedidosProveedores.FormattingEnabled = true;
            this.cmbBoxPedidosProveedores.Location = new System.Drawing.Point(10, 15);
            this.cmbBoxPedidosProveedores.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cmbBoxPedidosProveedores.Name = "cmbBoxPedidosProveedores";
            this.cmbBoxPedidosProveedores.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxPedidosProveedores.TabIndex = 5;
            this.cmbBoxPedidosProveedores.SelectionChangeCommitted += new System.EventHandler(this.cmbBoxPedidosProveedores_SelectionChangeCommitted);
            // 
            // tbControlPrincipal
            // 
            this.tbControlPrincipal.Controls.Add(this.tbPageDatosGenerales);
            this.tbControlPrincipal.Controls.Add(this.tbPageDomicilioFacturacion);
            this.tbControlPrincipal.Controls.Add(this.tbPageDatosContacto);
            this.tbControlPrincipal.Controls.Add(this.tabPageObservaciones);
            this.tbControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControlPrincipal.Location = new System.Drawing.Point(3, 3);
            this.tbControlPrincipal.Name = "tbControlPrincipal";
            this.tbControlPrincipal.SelectedIndex = 0;
            this.tbControlPrincipal.Size = new System.Drawing.Size(693, 174);
            this.tbControlPrincipal.TabIndex = 17;
            // 
            // tbPageDatosGenerales
            // 
            this.tbPageDatosGenerales.Controls.Add(this.tblLayoutPanelDatosGenerales);
            this.tbPageDatosGenerales.Location = new System.Drawing.Point(4, 22);
            this.tbPageDatosGenerales.Name = "tbPageDatosGenerales";
            this.tbPageDatosGenerales.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageDatosGenerales.Size = new System.Drawing.Size(685, 148);
            this.tbPageDatosGenerales.TabIndex = 0;
            this.tbPageDatosGenerales.Text = "Datos Generales";
            this.tbPageDatosGenerales.UseVisualStyleBackColor = true;
            // 
            // tblLayoutPanelDatosGenerales
            // 
            this.tblLayoutPanelDatosGenerales.ColumnCount = 3;
            this.tblLayoutPanelDatosGenerales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tblLayoutPanelDatosGenerales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDatosGenerales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tblLayoutPanelDatosGenerales.Controls.Add(this.pnlEntidadDatos, 1, 0);
            this.tblLayoutPanelDatosGenerales.Controls.Add(this.tblLayoutPanelPedido, 2, 0);
            this.tblLayoutPanelDatosGenerales.Controls.Add(this.tblLayoutPanelEntidadDatos, 0, 0);
            this.tblLayoutPanelDatosGenerales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDatosGenerales.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelDatosGenerales.Name = "tblLayoutPanelDatosGenerales";
            this.tblLayoutPanelDatosGenerales.RowCount = 1;
            this.tblLayoutPanelDatosGenerales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelDatosGenerales.Size = new System.Drawing.Size(679, 142);
            this.tblLayoutPanelDatosGenerales.TabIndex = 0;
            // 
            // pnlEntidadDatos
            // 
            this.pnlEntidadDatos.Controls.Add(this.grpBoxObservaciones);
            this.pnlEntidadDatos.Controls.Add(this.lblRazonSocial);
            this.pnlEntidadDatos.Controls.Add(this.txtBoxRazonSocial);
            this.pnlEntidadDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEntidadDatos.Location = new System.Drawing.Point(183, 3);
            this.pnlEntidadDatos.Name = "pnlEntidadDatos";
            this.pnlEntidadDatos.Size = new System.Drawing.Size(273, 136);
            this.pnlEntidadDatos.TabIndex = 2;
            // 
            // grpBoxObservaciones
            // 
            this.grpBoxObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxObservaciones.Controls.Add(this.rchTextBoxObservaciones);
            this.grpBoxObservaciones.Location = new System.Drawing.Point(3, 40);
            this.grpBoxObservaciones.Name = "grpBoxObservaciones";
            this.grpBoxObservaciones.Size = new System.Drawing.Size(267, 92);
            this.grpBoxObservaciones.TabIndex = 13;
            this.grpBoxObservaciones.TabStop = false;
            this.grpBoxObservaciones.Text = "Observaciones";
            // 
            // rchTextBoxObservaciones
            // 
            this.rchTextBoxObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchTextBoxObservaciones.Location = new System.Drawing.Point(3, 16);
            this.rchTextBoxObservaciones.Name = "rchTextBoxObservaciones";
            this.rchTextBoxObservaciones.Size = new System.Drawing.Size(261, 73);
            this.rchTextBoxObservaciones.TabIndex = 26;
            this.rchTextBoxObservaciones.Text = "";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblRazonSocial.Location = new System.Drawing.Point(0, 10);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(73, 13);
            this.lblRazonSocial.TabIndex = 11;
            this.lblRazonSocial.Text = "Razón Social:";
            this.lblRazonSocial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxRazonSocial
            // 
            this.txtBoxRazonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxRazonSocial.Location = new System.Drawing.Point(76, 7);
            this.txtBoxRazonSocial.Name = "txtBoxRazonSocial";
            this.txtBoxRazonSocial.Size = new System.Drawing.Size(194, 20);
            this.txtBoxRazonSocial.TabIndex = 12;
            // 
            // tblLayoutPanelPedido
            // 
            this.tblLayoutPanelPedido.ColumnCount = 2;
            this.tblLayoutPanelPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.07116F));
            this.tblLayoutPanelPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.92884F));
            this.tblLayoutPanelPedido.Controls.Add(this.cmbBoxTipoComprobante, 1, 1);
            this.tblLayoutPanelPedido.Controls.Add(this.lblNumeroPedido, 0, 0);
            this.tblLayoutPanelPedido.Controls.Add(this.lblTipoComprobante, 0, 1);
            this.tblLayoutPanelPedido.Controls.Add(this.txtBoxNumeroPedido, 1, 0);
            this.tblLayoutPanelPedido.Controls.Add(this.lblFecha, 0, 2);
            this.tblLayoutPanelPedido.Controls.Add(this.lblFormaPago, 0, 3);
            this.tblLayoutPanelPedido.Controls.Add(this.dtpFechaPedido, 1, 2);
            this.tblLayoutPanelPedido.Controls.Add(this.cmbBoxFormaPago, 1, 3);
            this.tblLayoutPanelPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelPedido.Location = new System.Drawing.Point(462, 3);
            this.tblLayoutPanelPedido.Name = "tblLayoutPanelPedido";
            this.tblLayoutPanelPedido.RowCount = 4;
            this.tblLayoutPanelPedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelPedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelPedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelPedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutPanelPedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanelPedido.Size = new System.Drawing.Size(214, 136);
            this.tblLayoutPanelPedido.TabIndex = 0;
            // 
            // cmbBoxTipoComprobante
            // 
            this.cmbBoxTipoComprobante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxTipoComprobante.FormattingEnabled = true;
            this.cmbBoxTipoComprobante.Items.AddRange(new object[] {
            "Presupuesto",
            "Ticket",
            "Factura-A",
            "Factura-B",
            "Reserva",
            "Devolución"});
            this.cmbBoxTipoComprobante.Location = new System.Drawing.Point(95, 40);
            this.cmbBoxTipoComprobante.Name = "cmbBoxTipoComprobante";
            this.cmbBoxTipoComprobante.Size = new System.Drawing.Size(116, 21);
            this.cmbBoxTipoComprobante.TabIndex = 10;
            // 
            // lblNumeroPedido
            // 
            this.lblNumeroPedido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNumeroPedido.AutoSize = true;
            this.lblNumeroPedido.Location = new System.Drawing.Point(42, 10);
            this.lblNumeroPedido.Name = "lblNumeroPedido";
            this.lblNumeroPedido.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroPedido.TabIndex = 0;
            this.lblNumeroPedido.Text = "Número:";
            // 
            // lblTipoComprobante
            // 
            this.lblTipoComprobante.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTipoComprobante.AutoSize = true;
            this.lblTipoComprobante.Location = new System.Drawing.Point(58, 44);
            this.lblTipoComprobante.Name = "lblTipoComprobante";
            this.lblTipoComprobante.Size = new System.Drawing.Size(31, 13);
            this.lblTipoComprobante.TabIndex = 1;
            this.lblTipoComprobante.Text = "Tipo:";
            // 
            // txtBoxNumeroPedido
            // 
            this.txtBoxNumeroPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNumeroPedido.Location = new System.Drawing.Point(95, 7);
            this.txtBoxNumeroPedido.Name = "txtBoxNumeroPedido";
            this.txtBoxNumeroPedido.Size = new System.Drawing.Size(116, 20);
            this.txtBoxNumeroPedido.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(49, 78);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(7, 112);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(82, 13);
            this.lblFormaPago.TabIndex = 2;
            this.lblFormaPago.Text = "Forma de Pago:";
            // 
            // dtpFechaPedido
            // 
            this.dtpFechaPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaPedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPedido.Location = new System.Drawing.Point(95, 75);
            this.dtpFechaPedido.Name = "dtpFechaPedido";
            this.dtpFechaPedido.Size = new System.Drawing.Size(116, 20);
            this.dtpFechaPedido.TabIndex = 11;
            // 
            // cmbBoxFormaPago
            // 
            this.cmbBoxFormaPago.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbBoxFormaPago.FormattingEnabled = true;
            this.cmbBoxFormaPago.Items.AddRange(new object[] {
            "Contado",
            "Tarjeta"});
            this.cmbBoxFormaPago.Location = new System.Drawing.Point(95, 108);
            this.cmbBoxFormaPago.Name = "cmbBoxFormaPago";
            this.cmbBoxFormaPago.Size = new System.Drawing.Size(116, 21);
            this.cmbBoxFormaPago.TabIndex = 9;
            // 
            // tblLayoutPanelEntidadDatos
            // 
            this.tblLayoutPanelEntidadDatos.ColumnCount = 2;
            this.tblLayoutPanelEntidadDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.5F));
            this.tblLayoutPanelEntidadDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.5F));
            this.tblLayoutPanelEntidadDatos.Controls.Add(this.lblApellido, 0, 2);
            this.tblLayoutPanelEntidadDatos.Controls.Add(this.lblCUIT, 0, 0);
            this.tblLayoutPanelEntidadDatos.Controls.Add(this.txtBoxApellido, 1, 2);
            this.tblLayoutPanelEntidadDatos.Controls.Add(this.txtBoxCUIT, 1, 0);
            this.tblLayoutPanelEntidadDatos.Controls.Add(this.lblNombre, 0, 3);
            this.tblLayoutPanelEntidadDatos.Controls.Add(this.lblDNI, 0, 1);
            this.tblLayoutPanelEntidadDatos.Controls.Add(this.txtBoxNombre, 1, 3);
            this.tblLayoutPanelEntidadDatos.Controls.Add(this.txtBoxDNI, 1, 1);
            this.tblLayoutPanelEntidadDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelEntidadDatos.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelEntidadDatos.Name = "tblLayoutPanelEntidadDatos";
            this.tblLayoutPanelEntidadDatos.RowCount = 4;
            this.tblLayoutPanelEntidadDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tblLayoutPanelEntidadDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tblLayoutPanelEntidadDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tblLayoutPanelEntidadDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tblLayoutPanelEntidadDatos.Size = new System.Drawing.Size(174, 136);
            this.tblLayoutPanelEntidadDatos.TabIndex = 1;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNombre.Location = new System.Drawing.Point(59, 107);
            this.txtBoxNombre.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombre.TabIndex = 18;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNombre.Location = new System.Drawing.Point(3, 111);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDNI
            // 
            this.lblDNI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDNI.Location = new System.Drawing.Point(3, 43);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(50, 13);
            this.lblDNI.TabIndex = 15;
            this.lblDNI.Text = "DNI:";
            this.lblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxDNI
            // 
            this.txtBoxDNI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDNI.Location = new System.Drawing.Point(59, 39);
            this.txtBoxDNI.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtBoxDNI.Name = "txtBoxDNI";
            this.txtBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDNI.TabIndex = 16;
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxApellido.Location = new System.Drawing.Point(59, 72);
            this.txtBoxApellido.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.txtBoxApellido.TabIndex = 20;
            // 
            // lblCUIT
            // 
            this.lblCUIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCUIT.Location = new System.Drawing.Point(3, 10);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(50, 13);
            this.lblCUIT.TabIndex = 13;
            this.lblCUIT.Text = "CUIT:";
            this.lblCUIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxCUIT
            // 
            this.txtBoxCUIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCUIT.Location = new System.Drawing.Point(59, 6);
            this.txtBoxCUIT.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtBoxCUIT.Name = "txtBoxCUIT";
            this.txtBoxCUIT.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCUIT.TabIndex = 14;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblApellido.Location = new System.Drawing.Point(3, 76);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(50, 13);
            this.lblApellido.TabIndex = 19;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPageDomicilioFacturacion
            // 
            this.tbPageDomicilioFacturacion.Controls.Add(this.tblLayoutPanelDomicilioFacturacion);
            this.tbPageDomicilioFacturacion.Location = new System.Drawing.Point(4, 22);
            this.tbPageDomicilioFacturacion.Name = "tbPageDomicilioFacturacion";
            this.tbPageDomicilioFacturacion.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageDomicilioFacturacion.Size = new System.Drawing.Size(685, 148);
            this.tbPageDomicilioFacturacion.TabIndex = 1;
            this.tbPageDomicilioFacturacion.Text = "Domicilio de Facturación";
            this.tbPageDomicilioFacturacion.UseVisualStyleBackColor = true;
            // 
            // tblLayoutPanelDomicilioFacturacion
            // 
            this.tblLayoutPanelDomicilioFacturacion.ColumnCount = 1;
            this.tblLayoutPanelDomicilioFacturacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDomicilioFacturacion.Controls.Add(this.tblLayoutPanelDomicilio, 0, 0);
            this.tblLayoutPanelDomicilioFacturacion.Controls.Add(this.cmbBoxDomicilios, 0, 1);
            this.tblLayoutPanelDomicilioFacturacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDomicilioFacturacion.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelDomicilioFacturacion.Name = "tblLayoutPanelDomicilioFacturacion";
            this.tblLayoutPanelDomicilioFacturacion.RowCount = 2;
            this.tblLayoutPanelDomicilioFacturacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.12121F));
            this.tblLayoutPanelDomicilioFacturacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.87879F));
            this.tblLayoutPanelDomicilioFacturacion.Size = new System.Drawing.Size(679, 142);
            this.tblLayoutPanelDomicilioFacturacion.TabIndex = 0;
            // 
            // tblLayoutPanelDomicilio
            // 
            this.tblLayoutPanelDomicilio.ColumnCount = 8;
            this.tblLayoutPanelDomicilio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31F));
            this.tblLayoutPanelDomicilio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69F));
            this.tblLayoutPanelDomicilio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tblLayoutPanelDomicilio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tblLayoutPanelDomicilio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tblLayoutPanelDomicilio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tblLayoutPanelDomicilio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tblLayoutPanelDomicilio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tblLayoutPanelDomicilio.Controls.Add(this.lblCalle, 0, 0);
            this.tblLayoutPanelDomicilio.Controls.Add(this.txtBoxCalle, 1, 0);
            this.tblLayoutPanelDomicilio.Controls.Add(this.lblNumero, 2, 0);
            this.tblLayoutPanelDomicilio.Controls.Add(this.lblPiso, 4, 0);
            this.tblLayoutPanelDomicilio.Controls.Add(this.txtBoxPiso, 5, 0);
            this.tblLayoutPanelDomicilio.Controls.Add(this.lblDepartamento, 6, 0);
            this.tblLayoutPanelDomicilio.Controls.Add(this.lblProvincia, 4, 1);
            this.tblLayoutPanelDomicilio.Controls.Add(this.cmbBoxProvincia, 5, 1);
            this.tblLayoutPanelDomicilio.Controls.Add(this.txtBoxDepartamento, 7, 0);
            this.tblLayoutPanelDomicilio.Controls.Add(this.lblCiudad, 0, 1);
            this.tblLayoutPanelDomicilio.Controls.Add(this.txtBoxCiudad, 1, 1);
            this.tblLayoutPanelDomicilio.Controls.Add(this.lblCodigoPostal, 2, 1);
            this.tblLayoutPanelDomicilio.Controls.Add(this.txtBoxCodigoPostal, 3, 1);
            this.tblLayoutPanelDomicilio.Controls.Add(this.lblPais, 6, 1);
            this.tblLayoutPanelDomicilio.Controls.Add(this.cmbBoxPais, 7, 1);
            this.tblLayoutPanelDomicilio.Controls.Add(this.txtBoxNumeroDomicilio, 3, 0);
            this.tblLayoutPanelDomicilio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDomicilio.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelDomicilio.Name = "tblLayoutPanelDomicilio";
            this.tblLayoutPanelDomicilio.RowCount = 2;
            this.tblLayoutPanelDomicilio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDomicilio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDomicilio.Size = new System.Drawing.Size(673, 82);
            this.tblLayoutPanelDomicilio.TabIndex = 1;
            // 
            // lblCalle
            // 
            this.lblCalle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCalle.Location = new System.Drawing.Point(18, 14);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(33, 13);
            this.lblCalle.TabIndex = 1;
            this.lblCalle.Text = "Calle:";
            // 
            // txtBoxCalle
            // 
            this.txtBoxCalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCalle.Location = new System.Drawing.Point(57, 10);
            this.txtBoxCalle.Name = "txtBoxCalle";
            this.txtBoxCalle.Size = new System.Drawing.Size(116, 20);
            this.txtBoxCalle.TabIndex = 11;
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNumero.Location = new System.Drawing.Point(232, 14);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Número:";
            // 
            // lblPiso
            // 
            this.lblPiso.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPiso.AutoSize = true;
            this.lblPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblPiso.Location = new System.Drawing.Point(380, 14);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(30, 13);
            this.lblPiso.TabIndex = 2;
            this.lblPiso.Text = "Piso:";
            // 
            // txtBoxPiso
            // 
            this.txtBoxPiso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPiso.Location = new System.Drawing.Point(416, 10);
            this.txtBoxPiso.Name = "txtBoxPiso";
            this.txtBoxPiso.Size = new System.Drawing.Size(89, 20);
            this.txtBoxPiso.TabIndex = 13;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDepartamento.Location = new System.Drawing.Point(525, 14);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(33, 13);
            this.lblDepartamento.TabIndex = 7;
            this.lblDepartamento.Text = "Dpto:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblProvincia.Location = new System.Drawing.Point(356, 55);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 6;
            this.lblProvincia.Text = "Provincia:";
            // 
            // cmbBoxProvincia
            // 
            this.cmbBoxProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxProvincia.FormattingEnabled = true;
            this.cmbBoxProvincia.Location = new System.Drawing.Point(416, 51);
            this.cmbBoxProvincia.Name = "cmbBoxProvincia";
            this.cmbBoxProvincia.Size = new System.Drawing.Size(89, 21);
            this.cmbBoxProvincia.TabIndex = 18;
            // 
            // txtBoxDepartamento
            // 
            this.txtBoxDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDepartamento.Location = new System.Drawing.Point(564, 10);
            this.txtBoxDepartamento.Name = "txtBoxDepartamento";
            this.txtBoxDepartamento.Size = new System.Drawing.Size(106, 20);
            this.txtBoxDepartamento.TabIndex = 14;
            // 
            // lblCiudad
            // 
            this.lblCiudad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCiudad.Location = new System.Drawing.Point(8, 55);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 5;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // txtBoxCiudad
            // 
            this.txtBoxCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCiudad.Location = new System.Drawing.Point(57, 51);
            this.txtBoxCiudad.Name = "txtBoxCiudad";
            this.txtBoxCiudad.Size = new System.Drawing.Size(116, 20);
            this.txtBoxCiudad.TabIndex = 15;
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCodigoPostal.Location = new System.Drawing.Point(204, 55);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(75, 13);
            this.lblCodigoPostal.TabIndex = 4;
            this.lblCodigoPostal.Text = "Código Postal:";
            // 
            // txtBoxCodigoPostal
            // 
            this.txtBoxCodigoPostal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCodigoPostal.Location = new System.Drawing.Point(285, 51);
            this.txtBoxCodigoPostal.Name = "txtBoxCodigoPostal";
            this.txtBoxCodigoPostal.Size = new System.Drawing.Size(49, 20);
            this.txtBoxCodigoPostal.TabIndex = 16;
            // 
            // lblPais
            // 
            this.lblPais.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblPais.Location = new System.Drawing.Point(526, 55);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(32, 13);
            this.lblPais.TabIndex = 15;
            this.lblPais.Text = "País:";
            // 
            // cmbBoxPais
            // 
            this.cmbBoxPais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxPais.FormattingEnabled = true;
            this.cmbBoxPais.Location = new System.Drawing.Point(564, 51);
            this.cmbBoxPais.Name = "cmbBoxPais";
            this.cmbBoxPais.Size = new System.Drawing.Size(106, 21);
            this.cmbBoxPais.TabIndex = 17;
            // 
            // txtBoxNumeroDomicilio
            // 
            this.txtBoxNumeroDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNumeroDomicilio.Location = new System.Drawing.Point(285, 10);
            this.txtBoxNumeroDomicilio.Name = "txtBoxNumeroDomicilio";
            this.txtBoxNumeroDomicilio.Size = new System.Drawing.Size(49, 20);
            this.txtBoxNumeroDomicilio.TabIndex = 12;
            // 
            // cmbBoxDomicilios
            // 
            this.cmbBoxDomicilios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoxDomicilios.FormattingEnabled = true;
            this.cmbBoxDomicilios.Location = new System.Drawing.Point(279, 104);
            this.cmbBoxDomicilios.Name = "cmbBoxDomicilios";
            this.cmbBoxDomicilios.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxDomicilios.TabIndex = 2;
            // 
            // tbPageDatosContacto
            // 
            this.tbPageDatosContacto.Controls.Add(this.tblLayoutPanelDatosContacto);
            this.tbPageDatosContacto.Location = new System.Drawing.Point(4, 22);
            this.tbPageDatosContacto.Name = "tbPageDatosContacto";
            this.tbPageDatosContacto.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageDatosContacto.Size = new System.Drawing.Size(685, 148);
            this.tbPageDatosContacto.TabIndex = 3;
            this.tbPageDatosContacto.Text = "Datos de Contacto";
            this.tbPageDatosContacto.UseVisualStyleBackColor = true;
            // 
            // tblLayoutPanelDatosContacto
            // 
            this.tblLayoutPanelDatosContacto.ColumnCount = 2;
            this.tblLayoutPanelDatosContacto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDatosContacto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDatosContacto.Controls.Add(this.cmbBoxTelefonos, 1, 1);
            this.tblLayoutPanelDatosContacto.Controls.Add(this.tblLayoutPanelMail, 0, 0);
            this.tblLayoutPanelDatosContacto.Controls.Add(this.tblLayoutPanelTelefono, 1, 0);
            this.tblLayoutPanelDatosContacto.Controls.Add(this.cmbBoxMails, 0, 1);
            this.tblLayoutPanelDatosContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelDatosContacto.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelDatosContacto.Name = "tblLayoutPanelDatosContacto";
            this.tblLayoutPanelDatosContacto.RowCount = 2;
            this.tblLayoutPanelDatosContacto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDatosContacto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelDatosContacto.Size = new System.Drawing.Size(679, 142);
            this.tblLayoutPanelDatosContacto.TabIndex = 0;
            // 
            // cmbBoxTelefonos
            // 
            this.cmbBoxTelefonos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoxTelefonos.FormattingEnabled = true;
            this.cmbBoxTelefonos.Location = new System.Drawing.Point(448, 96);
            this.cmbBoxTelefonos.Name = "cmbBoxTelefonos";
            this.cmbBoxTelefonos.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxTelefonos.TabIndex = 5;
            // 
            // tblLayoutPanelMail
            // 
            this.tblLayoutPanelMail.ColumnCount = 2;
            this.tblLayoutPanelMail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0578F));
            this.tblLayoutPanelMail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.9422F));
            this.tblLayoutPanelMail.Controls.Add(this.lblMail, 0, 0);
            this.tblLayoutPanelMail.Controls.Add(this.txtBoxMail, 1, 0);
            this.tblLayoutPanelMail.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPanelMail.Name = "tblLayoutPanelMail";
            this.tblLayoutPanelMail.RowCount = 2;
            this.tblLayoutPanelMail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanelMail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tblLayoutPanelMail.Size = new System.Drawing.Size(333, 65);
            this.tblLayoutPanelMail.TabIndex = 2;
            // 
            // lblMail
            // 
            this.lblMail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblMail.Location = new System.Drawing.Point(34, 3);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(63, 26);
            this.lblMail.TabIndex = 9;
            this.lblMail.Text = "Correo Electrónico:";
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxMail.Location = new System.Drawing.Point(103, 6);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(227, 20);
            this.txtBoxMail.TabIndex = 20;
            // 
            // tblLayoutPanelTelefono
            // 
            this.tblLayoutPanelTelefono.ColumnCount = 2;
            this.tblLayoutPanelTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.18497F));
            this.tblLayoutPanelTelefono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.81503F));
            this.tblLayoutPanelTelefono.Controls.Add(this.cmbBoxTipoTelefono, 1, 0);
            this.tblLayoutPanelTelefono.Controls.Add(this.txtBoxTelefono, 1, 1);
            this.tblLayoutPanelTelefono.Controls.Add(this.lblNumeroTelefono, 0, 1);
            this.tblLayoutPanelTelefono.Controls.Add(this.lblTipoTelefono, 0, 0);
            this.tblLayoutPanelTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanelTelefono.Location = new System.Drawing.Point(342, 3);
            this.tblLayoutPanelTelefono.Name = "tblLayoutPanelTelefono";
            this.tblLayoutPanelTelefono.RowCount = 2;
            this.tblLayoutPanelTelefono.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelTelefono.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanelTelefono.Size = new System.Drawing.Size(334, 65);
            this.tblLayoutPanelTelefono.TabIndex = 3;
            // 
            // cmbBoxTipoTelefono
            // 
            this.cmbBoxTipoTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxTipoTelefono.FormattingEnabled = true;
            this.cmbBoxTipoTelefono.Items.AddRange(new object[] {
            "TEL",
            "CEL",
            "FAX"});
            this.cmbBoxTipoTelefono.Location = new System.Drawing.Point(57, 5);
            this.cmbBoxTipoTelefono.Name = "cmbBoxTipoTelefono";
            this.cmbBoxTipoTelefono.Size = new System.Drawing.Size(274, 21);
            this.cmbBoxTipoTelefono.TabIndex = 24;
            // 
            // txtBoxTelefono
            // 
            this.txtBoxTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxTelefono.Location = new System.Drawing.Point(57, 38);
            this.txtBoxTelefono.Name = "txtBoxTelefono";
            this.txtBoxTelefono.Size = new System.Drawing.Size(274, 20);
            this.txtBoxTelefono.TabIndex = 26;
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNumeroTelefono.Location = new System.Drawing.Point(4, 42);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroTelefono.TabIndex = 25;
            this.lblNumeroTelefono.Text = "Número:";
            // 
            // lblTipoTelefono
            // 
            this.lblTipoTelefono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTipoTelefono.AutoSize = true;
            this.lblTipoTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTipoTelefono.Location = new System.Drawing.Point(20, 9);
            this.lblTipoTelefono.Name = "lblTipoTelefono";
            this.lblTipoTelefono.Size = new System.Drawing.Size(31, 13);
            this.lblTipoTelefono.TabIndex = 27;
            this.lblTipoTelefono.Text = "Tipo:";
            // 
            // cmbBoxMails
            // 
            this.cmbBoxMails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoxMails.FormattingEnabled = true;
            this.cmbBoxMails.Location = new System.Drawing.Point(109, 96);
            this.cmbBoxMails.Name = "cmbBoxMails";
            this.cmbBoxMails.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxMails.TabIndex = 4;
            // 
            // tabPageObservaciones
            // 
            this.tabPageObservaciones.Controls.Add(this.rchTextBoxObservacionesPedido);
            this.tabPageObservaciones.Location = new System.Drawing.Point(4, 22);
            this.tabPageObservaciones.Name = "tabPageObservaciones";
            this.tabPageObservaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageObservaciones.Size = new System.Drawing.Size(685, 148);
            this.tabPageObservaciones.TabIndex = 4;
            this.tabPageObservaciones.Text = "Observaciones";
            this.tabPageObservaciones.UseVisualStyleBackColor = true;
            // 
            // rchTextBoxObservacionesPedido
            // 
            this.rchTextBoxObservacionesPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchTextBoxObservacionesPedido.Location = new System.Drawing.Point(3, 3);
            this.rchTextBoxObservacionesPedido.Name = "rchTextBoxObservacionesPedido";
            this.rchTextBoxObservacionesPedido.Size = new System.Drawing.Size(679, 142);
            this.rchTextBoxObservacionesPedido.TabIndex = 1;
            this.rchTextBoxObservacionesPedido.Text = "";
            // 
            // modeloLineaPedidoBindingSource
            // 
            this.modeloLineaPedidoBindingSource.DataSource = typeof(Modelos.ModeloLineaPedido);
            // 
            // frmPedidoCierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(699, 481);
            this.Controls.Add(this.tblLayoutPanelPrincipal);
            this.Name = "frmPedidoCierre";
            this.Text = "frmPedidoCierre";
            this.tblLayoutPanelPrincipal.ResumeLayout(false);
            this.tblLayoutPanelPrincipal.PerformLayout();
            this.gbxArticulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosVenta)).EndInit();
            this.tblLayoutPanelValoresPedido.ResumeLayout(false);
            this.tblLayoutPanelValoresPedido.PerformLayout();
            this.tblLayoutPanelBotones.ResumeLayout(false);
            this.tbControlPrincipal.ResumeLayout(false);
            this.tbPageDatosGenerales.ResumeLayout(false);
            this.tblLayoutPanelDatosGenerales.ResumeLayout(false);
            this.pnlEntidadDatos.ResumeLayout(false);
            this.pnlEntidadDatos.PerformLayout();
            this.grpBoxObservaciones.ResumeLayout(false);
            this.tblLayoutPanelPedido.ResumeLayout(false);
            this.tblLayoutPanelPedido.PerformLayout();
            this.tblLayoutPanelEntidadDatos.ResumeLayout(false);
            this.tblLayoutPanelEntidadDatos.PerformLayout();
            this.tbPageDomicilioFacturacion.ResumeLayout(false);
            this.tblLayoutPanelDomicilioFacturacion.ResumeLayout(false);
            this.tblLayoutPanelDomicilio.ResumeLayout(false);
            this.tblLayoutPanelDomicilio.PerformLayout();
            this.tbPageDatosContacto.ResumeLayout(false);
            this.tblLayoutPanelDatosContacto.ResumeLayout(false);
            this.tblLayoutPanelMail.ResumeLayout(false);
            this.tblLayoutPanelMail.PerformLayout();
            this.tblLayoutPanelTelefono.ResumeLayout(false);
            this.tblLayoutPanelTelefono.PerformLayout();
            this.tabPageObservaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modeloLineaPedidoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxArticulos;
        internal System.Windows.Forms.DataGridView dgvArticulosVenta;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelValoresPedido;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelBotones;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.TextBox txtBoxSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtBoxDescuentoLineas;
        private System.Windows.Forms.Label lblDescuentoLineas;
        private System.Windows.Forms.TextBox txtBoxDescuentoTotal;
        private System.Windows.Forms.Label lblDescuentoTotal;
        private System.Windows.Forms.TextBox txtBoxDescuentoPorcentualMonto;
        private System.Windows.Forms.Label lblDescuentoPorcentual;
        private System.Windows.Forms.TextBox txtBoxDescuentoNetoMonto;
        private System.Windows.Forms.Label lblDescuentoNeto;
        private System.Windows.Forms.TextBox txtBoxIVAMonto;
        private System.Windows.Forms.TextBox txtBoxSenia;
        private System.Windows.Forms.TextBox txtBoxIVAPorcentaje;
        private System.Windows.Forms.Label lblSenia;
        private System.Windows.Forms.TextBox txtBoxDescuentoPorcentualPorcentaje;
        private System.Windows.Forms.TextBox txtBoxDescuentoNetoPorcentaje;
        private System.Windows.Forms.TabPage tbPageDomicilioFacturacion;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelPedido;
        private System.Windows.Forms.Label lblNumeroPedido;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.Label lblTipoComprobante;
        private System.Windows.Forms.TextBox txtBoxNumeroPedido;
        private System.Windows.Forms.ComboBox cmbBoxFormaPago;
        private System.Windows.Forms.ComboBox cmbBoxTipoComprobante;
        private System.Windows.Forms.DateTimePicker dtpFechaPedido;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDomicilioFacturacion;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDomicilio;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtBoxCalle;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.TextBox txtBoxPiso;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.ComboBox cmbBoxProvincia;
        private System.Windows.Forms.TextBox txtBoxDepartamento;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtBoxCiudad;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.TextBox txtBoxCodigoPostal;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ComboBox cmbBoxPais;
        private System.Windows.Forms.TextBox txtBoxNumeroDomicilio;
        private System.Windows.Forms.TabPage tbPageDatosContacto;
        private System.Windows.Forms.TabPage tabPageObservaciones;
        private System.Windows.Forms.RichTextBox rchTextBoxObservacionesPedido;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelDatosContacto;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelTelefono;
        private System.Windows.Forms.ComboBox cmbBoxTipoTelefono;
        private System.Windows.Forms.Label lblNumeroTelefono;
        private System.Windows.Forms.TextBox txtBoxTelefono;
        private System.Windows.Forms.Label lblTipoTelefono;
        protected System.Windows.Forms.TableLayoutPanel tblLayoutPanelDatosGenerales;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelPrincipal;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TabControl tbControlPrincipal;
        private System.Windows.Forms.TabPage tbPageDatosGenerales;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelEntidadDatos;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtBoxDNI;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.TextBox txtBoxCUIT;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Panel pnlEntidadDatos;
        private System.Windows.Forms.GroupBox grpBoxObservaciones;
        private System.Windows.Forms.RichTextBox rchTextBoxObservaciones;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtBoxRazonSocial;
        private System.Windows.Forms.ComboBox cmbBoxPedidosProveedores;
        private System.Windows.Forms.BindingSource modeloLineaPedidoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn vUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn vParcial;
        private System.Windows.Forms.ComboBox cmbBoxDomicilios;
        private System.Windows.Forms.ComboBox cmbBoxTelefonos;
        private System.Windows.Forms.ComboBox cmbBoxMails;
    }
}