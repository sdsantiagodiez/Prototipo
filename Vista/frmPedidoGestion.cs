﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaClasesCompartidas;
using Modelos;

namespace Vista
{
    public partial class frmPedidoGestion : frmMaterialSkinBase
    {
        #region Atributos
        List<ModeloPedido> glb_lst_pedidosEncontrados;
        List<ModeloPedido> glb_lst_pedidosSeleccionados;
        MaterialSkin.Controls.MaterialContextMenuStrip cntxMenuResultadoBusqueda;
        public EventHandler verDetallesPedido;
        public EventHandler MostrarComprobante;
        bool cerrarVentana = true;//cuando se abre un pedido para ver detalle y se cierra desde la X arriba a la derecha, como que sigue cliqueando y cierra este form que esta abajo
        #endregion

        #region Constructores
        public frmPedidoGestion()
        {
            InitializeComponent();

            glb_lst_pedidosEncontrados = new List<ModeloPedido>();
            glb_lst_pedidosSeleccionados = new List<ModeloPedido>();
            this.inicializarControles();
        }
        #endregion

        #region Métodos

        #region Inicialización
        public override void inicializarForm(int ventanaAncho, int ventanaAlto)
        {
            //copiado de frmABMEntidad
            this.tblLayoutPanelPrincipal.Width = ventanaAncho - 20; //un margen derecho de 20 para que se vea scrollbar
            this.pnlBase.Width = ventanaAncho;  //un márgen derecho de 3
            this.pnlBase.Height = ventanaAlto - 60; //un márgen arriba para que se vea título
            if (pnlBase.Height < 550)
            {
                this.tblLayoutPanelPrincipal.Height = 550;  //Mínimo

                this.pnlBase.AutoScroll = true;
                ScrollBar vScrollBar = new VScrollBar();
                vScrollBar.Dock = DockStyle.Right;
                vScrollBar.Scroll += (sender, e) => { pnlBase.VerticalScroll.Value = vScrollBar.Value; };
                pnlBase.Controls.Add(vScrollBar);
            }
            else
            {
                this.tblLayoutPanelPrincipal.Height = pnlBase.Height; ; // 60 pixeles para que se vea título de ventana principal
            }

            int x = Convert.ToInt16(Math.Round(Convert.ToDouble((Width - this.tblLayoutPanelPrincipal.Width) / 2)));
            this.tblLayoutPanelPrincipal.Location = new Point(10, 0);
            this.pnlBase.Location = new Point(0, 60);
        }

        private void inicializarControles()
        {
            this.Text = "Gestión de Pedidos";

            this.inicializarCheckListBox();
            this.inicializarContextMenu();
            this.inicializarBotones();
            this.inicializarDataGridView();
            this.inicializarPeriodos();
            this.inicializarTextBox();
        }
        private void inicializarCheckListBox()
        {
            #region chckdListBoxTipoComprobante
            List<ComboBoxItem> lcl_lst_tiposComprobantes = new List<ComboBoxItem>();
            
            #region Enum TipoComprobanteCompra
            var enums_compra = Enum.GetValues(typeof(Constantes.TipoComprobanteCompra)).Cast<Constantes.TipoComprobanteCompra>();
            foreach (var e in enums_compra)
            {
                if (e == Constantes.TipoComprobanteCompra.Otro)
                {
                    continue;
                }
                lcl_lst_tiposComprobantes.Add(new ComboBoxItem()
                {
                    Name = Constantes.GetDescription<Constantes.TipoComprobanteCompra>((Constantes.TipoComprobanteCompra)e),
                    Value = e
                });
            }
            #endregion
            
            #region Enum TipoComprobanteVenta
            var enums_venta = Enum.GetValues(typeof(Constantes.TipoComprobanteVenta)).Cast<Constantes.TipoComprobanteVenta>();
            foreach (var e in enums_venta)
            {
                //if (e == Constantes.TipoComprobanteVenta.Otro)
                //{
                //    continue;
                //}
                lcl_lst_tiposComprobantes.Add(new ComboBoxItem()
                {
                    Name = Constantes.GetDescription<Constantes.TipoComprobanteVenta>((Constantes.TipoComprobanteVenta)e),
                    Value = e
                });
            }
            #endregion
            
            #region Enum TipoComprobanteDevolución
            var enums_devolucion = Enum.GetValues(typeof(Constantes.TipoComprobanteDevolucion)).Cast<Constantes.TipoComprobanteDevolucion>();
            foreach (var e in enums_devolucion)
            {
                
                lcl_lst_tiposComprobantes.Add(new ComboBoxItem()
                {
                    Name = Constantes.GetDescription<Constantes.TipoComprobanteDevolucion>((Constantes.TipoComprobanteDevolucion)e),
                    Value = e
                });
            }
            #endregion

            this.chckdListBoxTipoComprobante.DataSource = lcl_lst_tiposComprobantes;
            ((ListBox)this.chckdListBoxTipoComprobante).DisplayMember = "Name";
            ((ListBox)this.chckdListBoxTipoComprobante).ValueMember = "Value";
            this.chckdListBoxTipoComprobante.CheckOnClick = true;
            #endregion

            #region chckdListBoxTipoPedido
            List<ComboBoxItem> lcl_lst_tiposPedidos = new List<ComboBoxItem>();
            
            #region Enum TipoPedido
            var enums_pedidos = Enum.GetValues(typeof(Constantes.TipoPedido)).Cast<Constantes.TipoPedido>();
            foreach (var e in enums_pedidos)
            {
                lcl_lst_tiposPedidos.Add(new ComboBoxItem()
                {
                    Name = Constantes.GetDescription<Constantes.TipoPedido>((Constantes.TipoPedido)e),
                    Value = e
                });
            }
            #endregion

            this.chckdListBoxTipoPedido.DataSource = lcl_lst_tiposPedidos;
            ((ListBox)this.chckdListBoxTipoPedido).DisplayMember = "Name";
            ((ListBox)this.chckdListBoxTipoPedido).ValueMember = "Value";
            this.chckdListBoxTipoPedido.CheckOnClick = true;
            #endregion

            #region chckdListBoxFacturadoElectronicamente
            List<ComboBoxItem> lcl_lst_facturadoElectronicamente = new List<ComboBoxItem>();

            lcl_lst_facturadoElectronicamente.Add(new ComboBoxItem()
            {
                Name = "Sí",
                Value = true
            });
            lcl_lst_facturadoElectronicamente.Add(new ComboBoxItem()
            {
                Name = "No",
                Value = false
            });

            this.chckdListBoxFacturadoElectronicamente.DataSource = lcl_lst_facturadoElectronicamente;
            ((ListBox)this.chckdListBoxTipoPedido).DisplayMember = "Name";
            ((ListBox)this.chckdListBoxTipoPedido).ValueMember = "Value";
            this.chckdListBoxFacturadoElectronicamente.CheckOnClick = true;
            #endregion
        }
        private void inicializarTextBox()
        {
            this.txtBoxApellido.KeyPress += txtBoxBuscar_KeyPress;
            this.txtBoxNombre.KeyPress += txtBoxBuscar_KeyPress;
            this.txtBoxCAE.KeyPress += txtBoxBuscar_KeyPress;
            this.txtBoxNumeroDocumento.KeyPress += txtBoxBuscar_KeyPress;
            this.txtBoxNumeroPedido.KeyPress += txtBoxBuscar_KeyPress;
            this.txtBoxRazonSocial.KeyPress += txtBoxBuscar_KeyPress;
        }
        private void inicializarContextMenu()
        {
            this.cntxMenuResultadoBusqueda = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.cntxMenuResultadoBusqueda.Items.Add("Ver Detalles");
            this.cntxMenuResultadoBusqueda.Items[0].Click += (s, e) =>
            {
                this.verDetalles();
            };
            this.cntxMenuResultadoBusqueda.Items.Add("Facturar Electrónicamente");
            this.cntxMenuResultadoBusqueda.Items[1].Click += (s, e) =>
            {
                this.facturar();
            };
            this.cntxMenuResultadoBusqueda.Items.Add("Imprimir");
            this.cntxMenuResultadoBusqueda.Items[2].Click += (s, e) =>
            {
                this.imprimir();
            };
            this.cntxMenuResultadoBusqueda.Items.Add("Eliminar");
            this.cntxMenuResultadoBusqueda.Items[3].Click += (s, e) =>
            {
                this.eliminar();
            };
            this.cntxMenuResultadoBusqueda.Items.Add("Recepcionar Orden de Compra");
            this.cntxMenuResultadoBusqueda.Items[4].Click += (s, e) =>
            {
                this.recibirPedidoProveedor();
            };
        }
        private void inicializarContextMenu(bool p_verDetalles, bool p_facturar, bool p_imprimir, bool p_eliminar,bool p_recibirPedidoProveedor)
        {
            this.cntxMenuResultadoBusqueda.Items[0].Enabled = p_verDetalles;
            this.cntxMenuResultadoBusqueda.Items[1].Enabled = p_facturar;
            this.cntxMenuResultadoBusqueda.Items[2].Enabled = p_imprimir;
            this.cntxMenuResultadoBusqueda.Items[3].Enabled = p_eliminar;
            this.cntxMenuResultadoBusqueda.Items[4].Enabled = p_recibirPedidoProveedor;
        }
        private void inicializarBotones()
        {
            this.btnBuscar.Click += (s, e) => { this.buscar(); };
            this.btnFacturar.Click += (s, e) => { this.facturar(); };
            this.btnImprimir.Click += (s, e) => { this.imprimir(); };
            this.btnVerDetalles.Click += (s, e) => { this.verDetalles(); };
        }
        private void inicializarPeriodos()
        {
            this.chckBoxPeriodos.Checked = true;
        }
        private void inicializarDataGridView()
        {
            this.dgvResultadoBusqueda.MouseDown += this.dgvResultadoBusqueda_MouseDown;

            this.dgvResultadoBusqueda.Dock = DockStyle.Fill;
            this.dgvResultadoBusqueda.AutoGenerateColumns = false;
            this.dgvResultadoBusqueda.ReadOnly = true;
            this.dgvResultadoBusqueda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultadoBusqueda.RowHeadersVisible = false;
            this.dgvResultadoBusqueda.AllowUserToAddRows = false;
            this.dgvResultadoBusqueda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            this.dgvResultadoBusqueda.Columns.Add("dgvKey", "KEY");
            this.dgvResultadoBusqueda.Columns[0].FillWeight = 1;
            this.dgvResultadoBusqueda.Columns[0].Visible = false;
            int i = 0;

            this.dgvResultadoBusqueda.Columns.Add("tipoPedido", "Tipo");
            this.dgvResultadoBusqueda.Columns[i++].FillWeight = 1;
            this.dgvResultadoBusqueda.Columns.Add("numeroPedido", "Número");
            this.dgvResultadoBusqueda.Columns[i++].FillWeight = 1;
            this.dgvResultadoBusqueda.Columns.Add("fecha", "Fecha Pedido");
            this.dgvResultadoBusqueda.Columns[i++].FillWeight = 1;
            this.dgvResultadoBusqueda.Columns[i].DefaultCellStyle.Format = "dd/MM/yyyy";
            this.dgvResultadoBusqueda.Columns.Add("tipoComprobante", "Comprobante");
            this.dgvResultadoBusqueda.Columns[i++].FillWeight = 1;
            this.dgvResultadoBusqueda.Columns.Add("codigoEntidad", "Código Entidad");
            this.dgvResultadoBusqueda.Columns[i++].FillWeight = 1;
            this.dgvResultadoBusqueda.Columns.Add("numeroDocumentoEntidad", "Número de Documento");
            this.dgvResultadoBusqueda.Columns[i++].FillWeight = 1;
            this.dgvResultadoBusqueda.Columns.Add("nombreEntidad", "Nombre Entidad");
            this.dgvResultadoBusqueda.Columns[i++].FillWeight = 1;
            this.dgvResultadoBusqueda.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvResultadoBusqueda.Columns[i].MinimumWidth = 80;
            this.dgvResultadoBusqueda.Columns.Add("montoTotal", "Monto");
            this.dgvResultadoBusqueda.Columns[i++].FillWeight = 1;
            this.dgvResultadoBusqueda.Columns.Add("cae", "CAE");
            this.dgvResultadoBusqueda.Columns[i++].FillWeight = 1;
            this.dgvResultadoBusqueda.Columns.Add("numComprobanteAFIP", "Numero Comprobante AFIP");
            this.dgvResultadoBusqueda.Columns[i++].FillWeight = 1;
            this.dgvResultadoBusqueda.Columns.Add("vencimiento_cae", "VencimientoCAE");
            this.dgvResultadoBusqueda.Columns[i++].FillWeight = 1;
            this.dgvResultadoBusqueda.Columns.Add("facturadoElectronicamente", "Facturado AFIP");
            this.dgvResultadoBusqueda.Columns[i++].FillWeight = 1;
            this.dgvResultadoBusqueda.Columns.Add("nombre_usuario", "Usuario");
            this.dgvResultadoBusqueda.Columns[i++].FillWeight = 1;
        }
        #endregion

        #region Modelo -> Controles
        private void cargarModelosPedidosEnDataGridView(List<ModeloPedido> p_lst_pedidosEncontrados)
        {
            int rowIndex;
            this.dgvResultadoBusqueda.Rows.Clear();
            DataGridViewRow row;
            foreach (ModeloPedido p in p_lst_pedidosEncontrados)
            {
                rowIndex = this.dgvResultadoBusqueda.Rows.Add();
                row = this.dgvResultadoBusqueda.Rows[rowIndex];

                row.Cells["dgvKey"].Value = rowIndex;

                row.Cells["tipoPedido"].Value = p.codigoTipoPedido.GetDescription();
                row.Cells["numeroPedido"].Value = p.numeroPedido;
                row.Cells["fecha"].Value = p.fecha;
                row.Cells["tipoComprobante"].Value = Controladores.ControladorPedido.getNombreComprobante(p.tipoComprobante);
                row.Cells["codigoEntidad"].Value = p.entidad.codigo.ToString();
                row.Cells["numeroDocumentoEntidad"].Value = p.codigoTipoPedido == Constantes.CodigosTiposPedidos.Persona ? p.documentoComprador.numero : p.entidad.cuit;
                row.Cells["nombre_usuario"].Value = p.usuarioGenerador;
                
                row.Cells["nombreEntidad"].Value = this.getNombreEntidad(p);
                row.Cells["montoTotal"].Value = p.montoTotal;
                row.Cells["cae"].Value = p.CAE;
                if (p.CAE == null) { row.Cells["vencimiento_cae"].Value = null; }
                else
                { row.Cells["vencimiento_cae"].Value = p.VencimientoCAE.ToShortDateString();
                    row.Cells["numComprobanteAFIP"].Value = (p.numeroComprobanteAFIP != null)?Controladores.ControladorPedido.getNombreComprobante(p.tipoComprobante) + "0001-" + p.numeroComprobanteAFIP.PadLeft(8, '0'):"";
                }
                row.Cells["facturadoElectronicamente"].Value = p.aprobadoAFIP == "A"? "Sí" : "No";
            }
            this.dgvResultadoBusqueda.AutoResizeColumns();
        }
        private string getNombreEntidad(ModeloPedido p_pedido)
        {
            
            if (p_pedido.entidad.tipoEntidad == Constantes.TiposEntidad.Persona)
            {
                return (p_pedido.entidad as ModeloCliente).ToString();
            }
            else
            {
                return (p_pedido.entidad as ModeloProveedor).ToString(); 
            }
        }

        #endregion

        #region Controles -> Modelo
        private bool validarModeloPedidoBusqueda()
        {
            if (!String.IsNullOrWhiteSpace(this.txtBoxNumeroPedido.Text))
            {
                if (!Validar.validarInputNumerico(this.txtBoxNumeroPedido.Text, Constantes.Numericos.Entero))
                {
                    return false;
                }
            }
            if (!String.IsNullOrWhiteSpace(this.txtBoxCAE.Text))
            {
                if (!Validar.validarInputNoNumerico(this.txtBoxCAE.Text, Constantes.ParametrosBusqueda.Pedidos.CAE))
                {
                    return false;
                }
            }
            return true;
        }
        private ModeloPedido getModeloPedidoBusqueda()
        {
            if (!this.validarModeloPedidoBusqueda())
            {
                return null;
            }

            ModeloPedido lcl_mod_pedido = new ModeloPedido();
            if (!String.IsNullOrWhiteSpace(this.txtBoxNumeroPedido.Text))
            {
                int aux;
                int.TryParse(this.txtBoxNumeroPedido.Text, out aux);
                lcl_mod_pedido.numeroPedido = aux;
            }
            lcl_mod_pedido.CAE = !String.IsNullOrWhiteSpace(this.txtBoxCAE.Text)? this.txtBoxCAE.Text:null;
            
            lcl_mod_pedido.documentoComprador.asignarDocumento(this.txtBoxNumeroDocumento.Text);
            
            //usamos cliente porque permite nombre, apellido y razón social
            lcl_mod_pedido.entidad = new ModeloCliente()
            {
                nombre = !String.IsNullOrWhiteSpace(this.txtBoxNombre.Text) ? this.txtBoxNombre.Text : null,
                apellido = !String.IsNullOrWhiteSpace(this.txtBoxApellido.Text) ? this.txtBoxApellido.Text : null,
                razonSocial = !String.IsNullOrWhiteSpace(this.txtBoxRazonSocial.Text) ? this.txtBoxRazonSocial.Text : null
            };
            
            return lcl_mod_pedido;
        }
        private List<Constantes.TipoComprobanteCompra> getTiposComprobanteCompraSeleccionados()
        {
            List<Constantes.TipoComprobanteCompra> lcl_lst = new List<Constantes.TipoComprobanteCompra>();
            var enums_compra = Enum.GetValues(typeof(Constantes.TipoComprobanteCompra)).Cast<Constantes.TipoComprobanteCompra>();
            foreach (var e in enums_compra)
            {
                //if (e == Constantes.TipoComprobanteCompra.Otro)
                //{
                //    continue;
                //}
                foreach (ComboBoxItem item in this.chckdListBoxTipoComprobante.CheckedItems)
                {
                    if(item.Value.Equals(e))
                    {
                        lcl_lst.Add(e);
                        break;
                    }
                }
            }
            
            return lcl_lst;
        }
        private List<Constantes.TipoComprobanteVenta> getTiposComprobanteVentaSeleccionados()
        {
            List<Constantes.TipoComprobanteVenta> lcl_lst = new List<Constantes.TipoComprobanteVenta>();
            var enums_venta = Enum.GetValues(typeof(Constantes.TipoComprobanteVenta)).Cast<Constantes.TipoComprobanteVenta>();
            foreach (var e in enums_venta)
            {
                //if (e == Constantes.TipoComprobanteVenta.Otro)
                //{
                //    continue;
                //}
                foreach (ComboBoxItem item in this.chckdListBoxTipoComprobante.CheckedItems)
                {
                    if (item.Value.Equals(e))
                    {
                        lcl_lst.Add(e);
                        break;
                    }
                }
            }

            return lcl_lst;
        }
        private List<Constantes.TipoComprobanteDevolucion> getTiposComprobanteDevolucionSeleccionados()
        {
            List<Constantes.TipoComprobanteDevolucion> lcl_lst = new List<Constantes.TipoComprobanteDevolucion>();
            var enums_devolucion = Enum.GetValues(typeof(Constantes.TipoComprobanteDevolucion)).Cast<Constantes.TipoComprobanteDevolucion>();
            foreach (var e in enums_devolucion)
            {
                foreach (ComboBoxItem item in this.chckdListBoxTipoComprobante.CheckedItems)
                {
                    if (item.Value.Equals(e))
                    {
                        lcl_lst.Add(e);
                        break;
                    }
                }
            }

            return lcl_lst;
        }
        private List<Constantes.TipoPedido> getTiposPedidosSeleccionados()
        {
            List<Constantes.TipoPedido> lcl_lst = new List<Constantes.TipoPedido>();
            var enums_tiposPedidos = Enum.GetValues(typeof(Constantes.TipoPedido)).Cast<Constantes.TipoPedido>();
            foreach (var e in enums_tiposPedidos)
            {
                foreach (ComboBoxItem item in this.chckdListBoxTipoPedido.CheckedItems)
                {
                    if (item.Value.Equals(e))
                    {
                        lcl_lst.Add(e);
                        break;
                    }
                }
            }

            return lcl_lst;
        }
        /// <summary>
        /// Retorna=> 
        /// true: facturado electronicamente;
        /// false: no facturado electronicamente;
        /// null: ambos o ninguno seleccionado
        /// </summary>
        /// <returns></returns>
        private bool? getFacturadoElectronicamenteSeleccionado()
        {
            bool? facturadoElectronicamente = null;
            foreach (ComboBoxItem item in this.chckdListBoxFacturadoElectronicamente.CheckedItems)
            {
                if ((item.Value.Equals(true) || item.Value.Equals(false)) && facturadoElectronicamente == null)
                {
                    facturadoElectronicamente = (bool)item.Value;
                }
                else
                {//Ocurre cuando ambos items estan seleccionados
                    facturadoElectronicamente = null;
                }
            }
            return facturadoElectronicamente;
        }
        private List<DateTime> getPeriodoSeleccionado()
        {
            if (this.chckBoxPeriodos.Checked)
            {
                return null;
            }
            List<DateTime> lcl_lst = new List<DateTime>();
            
            lcl_lst.Add(this.dtpDesde.Value);
            lcl_lst.Add(this.dtpHasta.Value);
            
            return lcl_lst;
        }

        private List<ModeloPedido> getPedidosSeleccionados()
        {
            List<ModeloPedido> lcl_lst_pedidosSeleccionados = new List<ModeloPedido>();
            int currentRow;
            foreach (DataGridViewRow row in this.dgvResultadoBusqueda.SelectedRows)
            {
                currentRow = row.Cells["dgvKey"].Value==null?0:(int)row.Cells["dgvKey"].Value;
                
                lcl_lst_pedidosSeleccionados.Add(glb_lst_pedidosEncontrados[currentRow]);
            }

            return lcl_lst_pedidosSeleccionados;
        }
        #endregion

        #region Búsqueda
        private void buscar()
        {
            ModeloPedido lcl_mod_pedidoBusqueda = this.getModeloPedidoBusqueda();
            if (lcl_mod_pedidoBusqueda == null)
            {
                MessageBox.Show("Revise los campos ingresados.","Búsqueda",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                return;
            }

            this.buscar_mostrarMensajeEspera(lcl_mod_pedidoBusqueda);
        
            if (glb_lst_pedidosEncontrados.Count < 1)
            {
                MessageBox.Show("No se hay encontrado coincidencias.", "Resultado Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
            this.cargarModelosPedidosEnDataGridView(glb_lst_pedidosEncontrados);
        }
        private void buscar_mostrarMensajeEspera(ModeloPedido p_pedido)
        {
            BackgroundWorker bw = new BackgroundWorker();
            frmLoading lcl_frm_loading = new frmLoading("Espere por favor. Realizando búsqueda.");

            bw.DoWork += (s, e) =>
            {
                glb_lst_pedidosEncontrados = Controladores.ControladorBusqueda.buscar(p_pedido, this.getPeriodoSeleccionado(), this.getTiposComprobanteCompraSeleccionados(),
                this.getTiposComprobanteVentaSeleccionados(), this.getTiposComprobanteDevolucionSeleccionados(), this.getTiposPedidosSeleccionados(), this.getFacturadoElectronicamenteSeleccionado());
            };
            bw.RunWorkerCompleted += (s, e) =>
            {
                lcl_frm_loading.DialogResult = DialogResult.OK;
            };

            bw.RunWorkerAsync();
            lcl_frm_loading.ShowDialog();
        }
        private void txtBoxBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.buscar();
            }
        }
        #endregion

        #region Facturación
        private bool validarFacturar(List<ModeloPedido> p_lst_pedidosSeleccionados)
        {
            foreach (ModeloPedido p in p_lst_pedidosSeleccionados)
            {
                if (p.codigoTipoPedido == Constantes.CodigosTiposPedidos.Proveedor || //pedidos de proveedor no se facturan
                    p.aprobadoAFIP == "A" ||        //ya facturado
                    p.tipoComprobante == 0 || p.tipoComprobante > 1000) //comprobante que no se factura
                {
                    return false;
                }
            }
            
            return true;
        }
        private void facturar()
        { 
            glb_lst_pedidosSeleccionados = this.getPedidosSeleccionados();
            if (glb_lst_pedidosSeleccionados.Count < 1)
            {
                MessageBox.Show("Debe seleccionar un pedido para facturar. Inténtelo nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(Controladores.ControladorAFIP.CertificadoPath))
            {
                MessageBox.Show("Debe especificar un certificado en el panel de configuraciones para poder facturar electrónicamente");
                return;
            }
            if(!this.validarFacturar(glb_lst_pedidosSeleccionados))
            {
                MessageBox.Show("Ha surgido un error al intentar facturar pedidos. Inténtelo nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
                     BackgroundWorker bw = new BackgroundWorker();
                     frmLoading lcl_frm_loading = new frmLoading("Espere por favor. Realizando Facturación electrónica.");

                     bw.DoWork += (s, e) =>
                        {
                            Controladores.ControladorBusqueda lcl_con_busqueda = new Controladores.ControladorBusqueda();
                        Controladores.ControladorAFIP lcl_con_afip = new Controladores.ControladorAFIP();
                        if (!lcl_con_afip.validarConexion() || !lcl_con_afip.facturar(glb_lst_pedidosSeleccionados))
                            {
                                MessageBox.Show(lcl_con_afip.errorActual, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        foreach (ModeloPedido p in glb_lst_pedidosSeleccionados)
                            {   //actualiza pedidos facturados
                            ModeloPedido temp_ped = new ModeloPedido();
                            temp_ped=Controladores.ControladorBusqueda.buscar(p,Constantes.ParametrosBusqueda.Any)[0];
                            glb_lst_pedidosEncontrados.FirstOrDefault(x=> x.numeroPedido == p.numeroPedido).aprobadoAFIP=temp_ped.aprobadoAFIP;
                            glb_lst_pedidosEncontrados.FirstOrDefault(x=> x.numeroPedido == p.numeroPedido).CAE = temp_ped.CAE;
                            glb_lst_pedidosEncontrados.FirstOrDefault(x=> x.numeroPedido == p.numeroPedido).VencimientoCAE = temp_ped.VencimientoCAE;
                            glb_lst_pedidosEncontrados.FirstOrDefault(x=> x.numeroPedido == p.numeroPedido).numeroComprobanteAFIP = temp_ped.numeroComprobanteAFIP;
                            
                            }
                        
                        };
                        bw.RunWorkerCompleted += (s, e) =>
                        {
                            lcl_frm_loading.DialogResult = DialogResult.OK;
                            this.cargarModelosPedidosEnDataGridView(glb_lst_pedidosEncontrados);
                        };

                     bw.RunWorkerAsync();
                     lcl_frm_loading.ShowDialog();
        
        }
        #endregion

        #region Impresión
        private bool validarImprimir(List<ModeloPedido> p_lst_pedidosSeleccionados)
        {
            return p_lst_pedidosSeleccionados.Count > 0;
        }
        private void imprimir()
        {
            glb_lst_pedidosSeleccionados = this.getPedidosSeleccionados();
            if (glb_lst_pedidosSeleccionados.Count < 1)
            {
                MessageBox.Show("Debe seleccionar un pedido para imprimir. Inténtelo nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (!this.validarImprimir(glb_lst_pedidosSeleccionados))
            {
                MessageBox.Show("Ha surgido un error al intentar imprimir. Inténtelo nuevamente.","Error",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.carpetaPedidosClientes) && string.IsNullOrEmpty(Properties.Settings.Default.carpetaPedidosProveedores))
            {
                MessageBox.Show("Actualmente no se encuentran configurados los directorios para guardar los comprobantes, por lo que se guardarán en su escritorio. Diríjase a \"Configuraciones\" para modificar el lugar de guardado de los mismos.");
                string lcl_comprobantePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Comprobantes";
                System.IO.Directory.CreateDirectory(lcl_comprobantePath + "\\Clientes");
                System.IO.Directory.CreateDirectory(lcl_comprobantePath + "\\Proveedores");
                Properties.Settings.Default.carpetaPedidosClientes = lcl_comprobantePath + "\\Clientes";
                Properties.Settings.Default.carpetaPedidosProveedores = lcl_comprobantePath + "\\Proveedores";
                Properties.Settings.Default.Save();
            }
            else
            {
                if(string.IsNullOrEmpty(Properties.Settings.Default.carpetaPedidosClientes))
                {
                    MessageBox.Show("Actualmente no se encuentra configurado el directorio para guardar los comprobantes de pedido a cliente, por lo que se guardarán en su escritorio. Diríjase a \"Configuraciones\" para modificar el lugar de guardado de los mismos.");
                    string lcl_comprobantePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Comprobantes\\Clientes";
                    Properties.Settings.Default.carpetaPedidosClientes = lcl_comprobantePath;
                    Properties.Settings.Default.Save();
                }
                if(string.IsNullOrEmpty(Properties.Settings.Default.carpetaPedidosProveedores))
                {
                    MessageBox.Show("Actualmente no se encuentra configurado el directorio para guardar los comprobantes de pedido a proveedores, por lo que se guardarán en su escritorio. Diríjase a \"Configuraciones\" para modificar el lugar de guardado de los mismos.");
                    string lcl_comprobantePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Comprobantes\\Proveedores";
                    Properties.Settings.Default.carpetaPedidosProveedores = lcl_comprobantePath;
                    Properties.Settings.Default.Save();
                }
            }

            frmImpresionComprobante lcl_frm_comprobante = new frmImpresionComprobante(Properties.Settings.Default.carpetaPedidosClientes, Properties.Settings.Default.carpetaPedidosProveedores);
            this.MostrarComprobante(lcl_frm_comprobante, new EventArgs());

            frmLoading lcl_frm_loading = new frmLoading("Espere por favor. Guardando pedido en formato PDF.", "Guardando Comprobante");
            bool exito = false;
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += (s, e) =>
            {
                exito = lcl_frm_comprobante.generarComprobante(glb_lst_pedidosSeleccionados);
            };
            bw.RunWorkerCompleted += (s, e) =>
            {
                lcl_frm_loading.DialogResult = System.Windows.Forms.DialogResult.OK;
            };
            bw.RunWorkerAsync();

            lcl_frm_loading.ShowDialog();
        }
        #endregion

        #region Ver detalles de pedido
        private bool validarVerDetalles(List<ModeloPedido> p_lst_pedidosSeleccionados)
        {
            if (p_lst_pedidosSeleccionados.Count != 1)
            {
                return false;
            }

            return true;
        }
        private void verDetalles()
        {
            glb_lst_pedidosSeleccionados = this.getPedidosSeleccionados();
            if (!this.validarVerDetalles(glb_lst_pedidosSeleccionados))
            {
                return;
            }
            
            frmPedidoCierre lcl_frm_pedidoCierreVerDetalles = new frmPedidoCierre(glb_lst_pedidosSeleccionados[0], true);
            cerrarVentana = false;
            this.verDetallesPedido(lcl_frm_pedidoCierreVerDetalles, new EventArgs());
        }
        #endregion

        #region Eliminar
        private bool validarEliminacion(List<ModeloPedido> p_lst_pedidosSeleccionados)
        {
            if (p_lst_pedidosSeleccionados.Count != 1 
                || p_lst_pedidosSeleccionados[0].aprobadoAFIP == "A" 
                || !(p_lst_pedidosSeleccionados[0].tipoComprobante == 1 ||
                    p_lst_pedidosSeleccionados[0].tipoComprobante == 6))//faltara alguna validacion mas?
            {
                return false;
            }

            return true;
        }
        private void eliminar()
        {
            glb_lst_pedidosSeleccionados = this.getPedidosSeleccionados();
            DialogResult dialog = MessageBox.Show("Esta seguro que desea eliminar el pedido "+glb_lst_pedidosSeleccionados[0].numeroPedido+" ?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {

                if (!this.validarEliminacion(glb_lst_pedidosSeleccionados))
                {
                    MessageBox.Show("Debe seleccionar un unico pedido para eliminar. Inténtelo nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                BackgroundWorker bw = new BackgroundWorker();
                frmLoading lcl_frm_loading = new frmLoading("Espere por favor. Eliminando el pedido seleccionado.");

                bw.DoWork += (s, e) =>
                {
                    Controladores.ControladorBaja lcl_con_baja = new Controladores.ControladorBaja();

                    //lcl_con_baja.eliminar(glb_lst_pedidosSeleccionados[0]);

                    if (!lcl_con_baja.eliminar(glb_lst_pedidosSeleccionados[0]))
                    {
                        MessageBox.Show(lcl_con_baja.errorActual, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                };
                bw.RunWorkerCompleted += (s, e) =>
                {
                    lcl_frm_loading.DialogResult = DialogResult.OK;
                    glb_lst_pedidosEncontrados.Remove(glb_lst_pedidosSeleccionados[0]);
                    this.cargarModelosPedidosEnDataGridView(glb_lst_pedidosEncontrados);
                };

                bw.RunWorkerAsync();
                lcl_frm_loading.ShowDialog();
                MessageBox.Show("Pedido Eliminado Exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Recepcionar Pedido a Proveedor
        private void recibirPedidoProveedor()
        {
            string mensaje;
            if (new Controladores.ControladorPedidoProveedor().recepcionarPedidos(glb_lst_pedidosSeleccionados, out mensaje))
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK);
                foreach (ModeloPedido p_e in glb_lst_pedidosEncontrados)
                {
                    foreach (ModeloPedido p_s in glb_lst_pedidosSeleccionados)
                    {
                        if (p_e.numeroPedido == p_s.numeroPedido)
                        {
                            p_e.recibido = true;
                            break;
                        }
                    }
                }
                this.cargarModelosPedidosEnDataGridView(glb_lst_pedidosEncontrados);
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool validarRecibirPedidoProveedor(List<ModeloPedido> p_lst_pedidosSeleccionados)
        {
            //inicializamos con true si el método entra en el loop
            //si no, queda en false
            bool respuesta = p_lst_pedidosSeleccionados.Count >0;   
            
            foreach (ModeloPedido p in p_lst_pedidosSeleccionados)
            {
                if (p.codigoTipoPedido == Constantes.CodigosTiposPedidos.Proveedor && !p.recibido)
                {
                    continue;
                }
                else
                {
                    respuesta = false;
                    break;
                }
            }
            //true si hay más de un pedido en la lista y son todos pedidos a proveedor no recibidos
            return respuesta;
        }
        #endregion

        #endregion

        #region Eventos

        #region DataGridView
        private void dgvResultadoBusqueda_SelectionChanged(object sender, EventArgs e)
        {
            glb_lst_pedidosSeleccionados = this.getPedidosSeleccionados();
            this.btnFacturar.Enabled = this.validarFacturar(glb_lst_pedidosSeleccionados);
            this.btnImprimir.Enabled = this.validarImprimir(glb_lst_pedidosSeleccionados);
            this.btnVerDetalles.Enabled = this.validarVerDetalles(glb_lst_pedidosSeleccionados);

            this.inicializarContextMenu(this.validarVerDetalles(glb_lst_pedidosSeleccionados), 
                                        this.validarFacturar(glb_lst_pedidosSeleccionados),
                                        this.validarImprimir(glb_lst_pedidosSeleccionados),
                                        this.validarEliminacion(glb_lst_pedidosSeleccionados),
                                        this.validarRecibirPedidoProveedor(glb_lst_pedidosSeleccionados));
        }

        private void dgvResultadoBusqueda_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                int currentMouseOverRow = this.dgvResultadoBusqueda.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    if ((ModifierKeys & Keys.Control) != Keys.Control
                        && this.dgvResultadoBusqueda.Rows[currentMouseOverRow].Selected != true)
                    {//si selected == true significa que puede haber más elementos seleccionados anteriormente y no hay que perder selección
                        this.dgvResultadoBusqueda.ClearSelection();
                    }
                    this.dgvResultadoBusqueda.Rows[currentMouseOverRow].Selected = true;
                    
                    this.cntxMenuResultadoBusqueda.Show(this.dgvResultadoBusqueda, new Point(e.X, e.Y));
                }
            }

        }
        #endregion

        #region CheckedListBox

        #endregion

        #region DateTimePickers
        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            this.dtpHasta.MinDate = this.dtpDesde.Value.Date;
        }
        #endregion

        private void frmPedidoGestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cerrarVentana)
            {
                e.Cancel = cerrarVentana = true;    //previene que se cierre la ventana cuando se vuelve de verDetalle en frmPedidoCierre
            }
        }

        #endregion

        private void chckBoxPeriodos_CheckedChanged(object sender, EventArgs e)
        {
            bool check = (sender as MaterialSkin.Controls.MaterialCheckBox).Checked;
            
            this.dtpDesde.Enabled = !check;
            this.dtpHasta.Enabled = !check;
        }

        private void txtBoxNumeroDocumento_Leave(object sender, EventArgs e)
        {
            Documento lcl_documento = new Documento();
            if(lcl_documento.asignarDocumento(this.txtBoxNumeroDocumento.Text))
                this.txtBoxNumeroDocumento.Text = lcl_documento.numero;
        }
    }
}
