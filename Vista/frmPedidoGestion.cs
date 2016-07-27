using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaClasesCompartidas;
using Modelos;

namespace Vista
{
    public partial class frmPedidoGestion : frmMaterialSkinBase
    {
        #region Atributos
        List<ModeloPedido> glb_lst_pedidosEncontrados;
        #endregion

        #region Constructores
        public frmPedidoGestion()
        {
            InitializeComponent();

            glb_lst_pedidosEncontrados = new List<ModeloPedido>();
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
            if (pnlBase.Height < 700)
            {
                this.tblLayoutPanelPrincipal.Height = 700;  //Mínimo

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
                if (e == Constantes.TipoComprobanteVenta.Otro)
                {
                    continue;
                }
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

        private void inicializarContextMenu()
        { 

        }
        private void inicializarBotones()
        {
            this.btnBuscar.Click += (s, e) => { this.buscar(); };
            this.btnFacturar.Click += (s, e) => { this.facturar(); };
            this.btnImprimir.Click += (s, e) => { this.imprimir(); };
            this.btnVerDetalles.Click += (s, e) => { this.verDetalles(); };
        }

        private void inicializarDataGridView()
        {
            this.grpBoxResultadoBusqueda.Controls.Clear();
            this.dgvResultadoBusqueda = new DataGridView();
            this.grpBoxResultadoBusqueda.Controls.Add(this.dgvResultadoBusqueda);
            //this.dgvResultadoBusqueda.MouseDown += this.dgvResultadoBusqueda_MouseDown;

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
            this.dgvResultadoBusqueda.Columns.Add("montoTotal", "Monto");
            this.dgvResultadoBusqueda.Columns[i++].FillWeight = 1;
            this.dgvResultadoBusqueda.Columns.Add("cae", "CAE");
            this.dgvResultadoBusqueda.Columns[i++].FillWeight = 1;
            this.dgvResultadoBusqueda.Columns.Add("facturadoElectronicamente", "Facturado AFIP");
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

                row.Cells["tipoPedido"].Value = p.codigoTipoPedido == Constantes.CodigosTiposPedidos.TipoPedidoPersona? "PER":"PROV";
                row.Cells["numeroPedido"].Value = p.numeroPedido;
                row.Cells["fecha"].Value = p.fecha;
                row.Cells["tipoComprobante"].Value = p.tipoComprobante;
                row.Cells["codigoEntidad"].Value = p.entidad.codigo;
                row.Cells["numeroDocumentoEntidad"].Value = p.documentoComprador.numero;
                row.Cells["nombreEntidad"].Value = "proximamente";
                row.Cells["montoTotal"].Value = p.montoTotal;
                row.Cells["cae"].Value = p.CAE;
                row.Cells["facturadoElectronicamente"].Value = p.aprobadoAFIP == "A"? "Sí" : "No";
            }
            this.dgvResultadoBusqueda.AutoResizeColumns();
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
            if (!String.IsNullOrWhiteSpace(this.txtBoxCAE.Text))
            {
                lcl_mod_pedido.CAE = this.txtBoxCAE.Text;
            }
            if (!String.IsNullOrWhiteSpace(this.txtBoxNumeroDocumento.Text))
            {
                lcl_mod_pedido.documentoComprador.numero = this.txtBoxNumeroDocumento.Text;
            }
            if (!String.IsNullOrWhiteSpace(this.txtBoxNombre.Text))
            {
                //lcl_mod_pedido. = this.txtBoxNombre.Text;
            }
            if (!String.IsNullOrWhiteSpace(this.txtBoxApellido.Text))
            {
                //lcl_mod_pedido. = this.txtBoxApellido.Text;
            }
            if (!String.IsNullOrWhiteSpace(this.txtBoxRazonSocial.Text))
            {
                //lcl_mod_pedido. = this.txtBoxRazonSocial.Text;
            }

            return lcl_mod_pedido;
        }
        private List<Constantes.TipoComprobanteCompra> getTiposComprobanteCompraSeleccionados()
        {
            List<Constantes.TipoComprobanteCompra> lcl_lst = new List<Constantes.TipoComprobanteCompra>();
            var enums_compra = Enum.GetValues(typeof(Constantes.TipoComprobanteCompra)).Cast<Constantes.TipoComprobanteCompra>();
            foreach (var e in enums_compra)
            {
                if (e == Constantes.TipoComprobanteCompra.Otro)
                {
                    continue;
                }
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
                if (e == Constantes.TipoComprobanteVenta.Otro)
                {
                    continue;
                }
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
            List<DateTime> lcl_lst = new List<DateTime>();
            
            lcl_lst.Add(this.dtpDesde.Value);
            lcl_lst.Add(this.dtpHasta.Value);
            
            return lcl_lst;
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

            glb_lst_pedidosEncontrados = Controladores.ControladorBusqueda.buscar(lcl_mod_pedidoBusqueda, this.getPeriodoSeleccionado(), this.getTiposComprobanteCompraSeleccionados(),
                this.getTiposComprobanteVentaSeleccionados(), this.getTiposComprobanteDevolucionSeleccionados(), this.getTiposPedidosSeleccionados(), this.getFacturadoElectronicamenteSeleccionado());

            if (glb_lst_pedidosEncontrados.Count < 1)
            {
                MessageBox.Show("No se hay encontrado coincidencias.", "Resultado Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.cargarModelosPedidosEnDataGridView(glb_lst_pedidosEncontrados);
            }
        }
        
        #endregion

        #region Facturación
        private void facturar()
        { 
        }
        #endregion

        #region Impresión
        private void imprimir()
        {

        }
        #endregion

        #region Ver detalles de pedido
        private void verDetalles()
        {
 
        }
        #endregion

        #endregion

        #region Eventos
        
        #region DataGridView

        #endregion

        #region CheckedListBox

        #endregion

        #endregion
    }
}
