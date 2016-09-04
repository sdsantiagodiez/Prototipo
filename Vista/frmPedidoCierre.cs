using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Controladores;
using LibreriaClasesCompartidas;

namespace Vista
{
    public partial class frmPedidoCierre : frmMaterialSkinBase
    {
        #region Atributos
        ControlDomicilio glb_con_domicilio;
        public event EventHandler AgregarLineaPedido;
        public event EventHandler BuscarCliente;
        public event EventHandler MostrarDetallesArticulo;
        public event EventHandler MostrarComprobante;
        bool[] glb_array_respuestasValidaciones = new bool[9];
        List<TipoDocumento> glb_lst_tiposDocumentos;
        ControladorPedido controlador;
        MaterialSkin.Controls.MaterialCheckBox chckBoxClienteGenerico;
        ContextMenu cntxMenuLineasPedido;
        #region ModoFormulario
        public const string ModoFormularioPedidoCliente = "Pedido Cliente";
        public const string ModoFormularioPedidoProveedor = "Pedido a Proveedor(es)";
        public const string ModoFormularioDevolucionCliente = "Devolución Cliente";

        private string _modoFormulario;
        public string modoFormulario
        {
            get { return _modoFormulario; }
            set
            {
                _modoFormulario = value;
                switch(_modoFormulario)
                {
                    case ModoFormularioPedidoCliente:
                        this.inicializarControlesCliente();
                        this.Text = "Pedido de Cliente";
                        break;
                    case ModoFormularioDevolucionCliente:
                        this.inicializarControlesCliente();
                        this.Text = "Devolución de Artículos Cliente";
                        break;
                    case ModoFormularioPedidoProveedor:
                        this.inicializarControlesProveedor();
                        this.Text = "Pedido a Proveedores";
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion
        
        #endregion

        #region Constructores
        /// <summary>
        /// Inicializa formulario con controles compartidos por todos los modos de formulario
        /// </summary>
        private frmPedidoCierre()
        {
            InitializeComponent();
            
            dgvArticulosVenta.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvArticulosVenta.EnableHeadersVisualStyles = false; 
            
            this.inicializarControles();
            this.lblUsuario.Text = "Usuario: " + ControladorSesion.nombreUsuarioLogeado;
        }
        /// <summary>
        /// Inicializa formulario de acuerdo al codigoTipoPedido asignado al pedido
        /// </summary>
        /// <param name="p_mod_pedido"></param>
        public frmPedidoCierre(ModeloPedido p_mod_pedido) : this()
        {
            switch (p_mod_pedido.codigoTipoPedido)
            {
                case LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.Persona:
                    this.inicializarCierrePedidoCliente(p_mod_pedido);
                    break;
                case LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.Proveedor: 
                    this.inicializarCierrePedidosProveedores(p_mod_pedido);
                    break;
                default:
                    MessageBox.Show("Error al iniciar ventana.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    break;
            }
        }
        /// <summary>
        /// Inicializa formulario de acuerdo al modoFormulario indicado como parámetro
        /// </summary>
        /// <param name="p_mod_pedido"></param>
        /// <param name="p_modoFormulario"></param>
        public frmPedidoCierre(ModeloPedido p_mod_pedido, string p_modoFormulario) : this()
        {
            //this.modoFormulario = p_modoFormulario;
            switch (p_modoFormulario)
            {
                case ModoFormularioPedidoCliente:
                    p_mod_pedido.codigoTipoPedido = LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.Persona;
                    this.inicializarCierrePedidoCliente(p_mod_pedido);
                    break;
                case ModoFormularioDevolucionCliente:
                    //p_mod_pedido.codigoTipoPedido = LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.Persona;
                    this.inicializarDevolucionPedidoCliente(p_mod_pedido);
                    break;
                case ModoFormularioPedidoProveedor:
                    p_mod_pedido.codigoTipoPedido = LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.Proveedor;
                    this.inicializarCierrePedidosProveedores(p_mod_pedido);
                    break;
                default :
                    MessageBox.Show("Error al iniciar ventana.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    break;
            }
        }
        public frmPedidoCierre(ModeloPedido p_mod_pedido, bool p_deshabilitarControles) : this(p_mod_pedido)
        {
            if (p_deshabilitarControles)
            {
                this.inicializarPedidoCerrado();
                this.Text = "Detalles de Pedido";
                if (p_mod_pedido.aprobadoAFIP != "A")
                {
                    this.habilitarControl(this.btnFacturaElectronica);
                }
            }

            this.glb_con_domicilio.clearErrorProviders();
        }
        /// <summary>
        /// Para realizar devoluciones
        /// </summary>
        /// <param name="p_mod_pedidoDevolucion"></param>
        /// <param name="p_mod_pedidoOriginal"></param>
        public frmPedidoCierre(ModeloPedido p_mod_pedidoDevolucion, ModeloPedido p_mod_pedidoOriginal) : this(p_mod_pedidoDevolucion, ModoFormularioDevolucionCliente)
        {
            if (!this.controlador.iniciarDevolucion(p_mod_pedidoOriginal))
            {
                MessageBox.Show("El pedido seleccionado ya tiene una devolución realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }
        #endregion

        #region Métodos
        
        #region Inicialización
        public override void inicializarForm()
        {
            if (Width - 3 > 1100)
            {
                this.tblLayoutPanelPrincipal.Width = 1100;   //Máximo
            }
            else
            {
                this.tblLayoutPanelPrincipal.Width = Width - 3; //un margen derecho de 3
            }
            if (Height < 560)
            {
                this.tblLayoutPanelPrincipal.Height = 560;  //Mínimo
            }
            else
            {
                this.tblLayoutPanelPrincipal.Height = Height - 60; // 60 pixeles para que se vea título de ventana principal
            }

            int x = Convert.ToInt16(Math.Round(Convert.ToDouble((Width - this.tblLayoutPanelPrincipal.Width) / 2)));
            this.tblLayoutPanelPrincipal.Location = new Point(x, 60);
        }

        private void inicializarCierrePedidoCliente(ModeloPedido p_mod_pedido)
        {
            modoFormulario = ModoFormularioPedidoCliente;
            
            this.controlador = new ControladorPedidoCliente();
            this.cargarPedidoEnControles(p_mod_pedido);
        }
        private void inicializarCierrePedidosProveedores(ModeloPedido p_mod_pedido)
        {
            modoFormulario = ModoFormularioPedidoProveedor;
            this.controlador = new ControladorPedidoProveedor();
            this.actualizarPedidosProveedores(p_mod_pedido);
            this.actualizarFormasDePago();

            if ((controlador as ControladorPedidoProveedor).pedidosProveedores.Count > 1)
            {
                //quiere decir que estamos viendo un pedido ya hecho desde al gestor de pedidos
                (controlador as ControladorPedidoProveedor).pedidosProveedores[1].domicilioDeFacturacion = p_mod_pedido.domicilioDeFacturacion;
                (controlador as ControladorPedidoProveedor).pedidosProveedores[1].mailContacto = p_mod_pedido.mailContacto;
                (controlador as ControladorPedidoProveedor).pedidosProveedores[1].telefonoContacto = p_mod_pedido.telefonoContacto;
                this.cmbBoxPedidosProveedores.DataSource = null;
                this.cmbBoxPedidosProveedores.DataSource = new List<ComboBoxItem>(){ new ComboBoxItem(){Name =(p_mod_pedido.entidad as ModeloProveedor).razonSocial,Value = p_mod_pedido}};
                cmbBoxPedidosProveedores_SelectionChangeCommitted(new object(), new EventArgs());
            }
        }
        private void inicializarDevolucionPedidoCliente(ModeloPedido p_mod_pedido)
        {
            this.modoFormulario = ModoFormularioDevolucionCliente;
            
            this.controlador = new ControladorPedidoCliente();
            this.cargarPedidoEnControles(p_mod_pedido);
        }
        private void inicializarPedidoAbierto()
        {
            this.habilitarControles(this);
        }
        private void inicializarPedidoCerrado()
        {
            this.desHabilitarControles(this);
            this.habilitarControl(this.btnImprimir);
            this.habilitarControl(this.btnSalir);
            this.habilitarControl(this.tbControlPrincipal);
            this.habilitarControl(this.cmbBoxPedidosProveedores);
            this.habilitarControl(this.selectorControlPrincipal);
            this.dgvArticulosVenta.ClearSelection();
        }
        private void inicializarPedidoFacturado()
        {
            this.inicializarPedidoCerrado();
            this.habilitarControl(this.btnGuardar);
        }
 
        private void inicializarControles()
        {
            this.inicializarTextBoxes();
            this.inicializarContextMenuStrip();
            this.inicializarBotones();
            this.inicializarComboBox();

            glb_con_domicilio = new ControlDomicilio();
            this.tblLayoutPanelDomicilioFacturacion.Controls.Add(glb_con_domicilio);
            glb_con_domicilio.Dock = DockStyle.Fill;

            this.rchTextBoxObservaciones.ReadOnly = true;
        }
        private void inicializarBotones()
        {
            this.btnEliminar.Click += evento_eliminarLinea;
            this.btnEditar.Click += evento_editarLinea;
            this.btnAgregar.Click += evento_agregarLinea;
        }
        private void inicializarContextMenuStrip()
        {
            cntxMenuLineasPedido = new ContextMenu();
            cntxMenuLineasPedido.MenuItems.Add("Ver detalles artículo");
            cntxMenuLineasPedido.MenuItems[0].Click += evento_verDetalleArticulo;
            cntxMenuLineasPedido.MenuItems.Add("Agregar línea");
            cntxMenuLineasPedido.MenuItems[1].Click += evento_agregarLinea;
            cntxMenuLineasPedido.MenuItems.Add("Editar línea");
            cntxMenuLineasPedido.MenuItems[2].Click += evento_editarLinea;
            cntxMenuLineasPedido.MenuItems.Add("Eliminar línea");
            cntxMenuLineasPedido.MenuItems[3].Click += evento_eliminarLinea;
        }
        private void inicializarTextBoxes()
        {
            txtBoxCAE.Enabled =
            txtBoxNumeroPedido.Enabled =
            txtBoxIVAPorcentaje.Enabled =
            txtBoxDescuentoLineas.Enabled =
            txtBoxDescuentoTotal.Enabled =
            txtBoxIVAMonto.Enabled =
            txtBoxTotal.Enabled =
            txtBoxSubtotal.Enabled = false;

            this.txtBoxDescuento1Monto.MouseUp += this.selectText;
            this.txtBoxDescuento1Porcentaje.MouseUp += this.selectText;
            this.txtBoxDescuento2Monto.MouseUp += this.selectText;
            this.txtBoxDescuento2Porcentaje.MouseUp += this.selectText;
            this.txtBoxSenia.MouseUp += this.selectText;
        }
        private void inicializarComboBox()
        {           
            //Populo combobox de tiposDocumentos
            List<TipoDocumento> lcl_lst_tiposDocumentos = ControladorBusqueda.getTiposDocumentos();
            this.cargarTiposDocumentosEnControles(lcl_lst_tiposDocumentos);
            

            //Creo lista Tipos de teléfono
            var dataSource = new List<ComboBoxItem>();
           // dataSource.Add(new ComboBoxItem() { Name = "Sin Teléfono", Value = "" });
            dataSource.Add(new ComboBoxItem() { Name = "Fijo", Value = Constantes.TipoTelefono.Fijo });
            dataSource.Add(new ComboBoxItem() { Name = "Celular", Value = Constantes.TipoTelefono.Celular });
            dataSource.Add(new ComboBoxItem() { Name = "Fax", Value = Constantes.TipoTelefono.Fax });
            //Binding de telefonos
            this.cmbBoxTipoTelefono.DataSource = dataSource;

            this.cmbBoxTipoResponsable.DataSource = Enum.GetValues(typeof(Constantes.SituacionIVA));
            this.cmbBoxTipoResponsable.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbBoxTipoResponsable.FormattingEnabled = true;
            this.cmbBoxTipoResponsable.Format += delegate(object sender, ListControlConvertEventArgs e)
            {
                e.Value = Constantes.GetDescription<Constantes.SituacionIVA>((Constantes.SituacionIVA)e.Value);
            };
            this.cmbBoxTipoResponsable.SelectedIndex = 1;

            this.cmbBoxFormaPago.DataSource = Enum.GetValues(typeof(Constantes.FormaDePago));
            this.cmbBoxFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbBoxFormaPago.FormattingEnabled = true;
            this.cmbBoxFormaPago.Format += delegate(object sender, ListControlConvertEventArgs e)
            {
                e.Value = Constantes.GetDescription<Constantes.FormaDePago>((Constantes.FormaDePago)e.Value);
            };

            this.cmbBoxTipoDocumento.DisplayMember=
                this.cmbBoxTipoTelefono.DisplayMember =
                this.cmbBoxDomicilios.DisplayMember = 
                this.cmbBoxTelefonos.DisplayMember = 
                this.cmbBoxMails.DisplayMember = "Name";
            
            this.cmbBoxTipoDocumento.ValueMember =
                this.cmbBoxTipoTelefono.ValueMember = 
                this.cmbBoxDomicilios.ValueMember = 
                this.cmbBoxTelefonos.ValueMember = 
                this.cmbBoxMails.ValueMember = "Value";
            //Lo hago read only
            this.cmbBoxTipoDocumento.DropDownStyle =
                this.cmbBoxTipoTelefono.DropDownStyle = 
                this.cmbBoxDomicilios.DropDownStyle = 
                this.cmbBoxTelefonos.DropDownStyle = 
                this.cmbBoxMails.DropDownStyle = ComboBoxStyle.DropDownList;

            //this.cmbBoxTipoDocumento.SelectedValueChanged += this.txtBoxNumeroDocumento_Leave;
        }
        private void actualizarFormasDePago()
        {
            List<Constantes.FormaDePago> formasDePago =  Enum.GetValues(typeof(Constantes.FormaDePago)).OfType<Constantes.FormaDePago>().ToList();

            if(controlador.pedidoActual.codigoTipoPedido == Constantes.CodigosTiposPedidos.Proveedor)
            {
                formasDePago.Remove(Constantes.FormaDePago.Multiple);
            }

            this.cmbBoxFormaPago.DataSource = null;
            this.cmbBoxFormaPago.DataSource = formasDePago;
        }
        private void inicializarControlesCliente()
        {
            this.cmbBoxPedidosProveedores.Visible = false;

            this.lblCAE.Visible = 
                this.txtBoxCAE.Visible = true;

            chckBoxClienteGenerico = new MaterialSkin.Controls.MaterialCheckBox();
            chckBoxClienteGenerico.Dock = DockStyle.Fill;
            chckBoxClienteGenerico.Text = "Cliente Genérico";

            chckBoxClienteGenerico.CheckedChanged += clienteGenerico_CheckedChanged;
            this.tblLayoutPanelEntidadDatos.Controls.Add(chckBoxClienteGenerico, 1, 4);

            this.cmbBoxTipoComprobante.FormattingEnabled = true;
            if (modoFormulario == ModoFormularioDevolucionCliente)
            {
                this.cmbBoxTipoComprobante.Format += delegate(object sender, ListControlConvertEventArgs e)
                {
                    e.Value = Constantes.GetDescription<Constantes.TipoComprobanteDevolucion>((Constantes.TipoComprobanteDevolucion)e.Value);
                };

                this.cmbBoxTipoComprobante.DataSource = Enum.GetValues(typeof(Constantes.TipoComprobanteDevolucion));
            }
            else
            {
                this.cmbBoxTipoComprobante.Format += delegate(object sender, ListControlConvertEventArgs e)
                {
                    e.Value = Constantes.GetDescription<Constantes.TipoComprobanteVenta>((Constantes.TipoComprobanteVenta)e.Value);
                };

                this.cmbBoxTipoComprobante.DataSource = Enum.GetValues(typeof(Constantes.TipoComprobanteVenta));
            }
            this.cmbBoxTipoComprobante.DropDownWidth = GetDropDownWidth(this.cmbBoxTipoComprobante)+25;
            this.cmbBoxTipoComprobante.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void inicializarControlesProveedor()
        {
            this.txtBoxNombre.Enabled =
            this.txtBoxApellido.Enabled =
            this.txtBoxRazonSocial.Enabled =
            this.txtBoxNumeroDocumento.Enabled =
            this.cmbBoxTipoDocumento.Enabled =
            this.txtBoxSenia.Enabled =
            this.txtBoxDescuento1Monto.Enabled =
            this.txtBoxDescuento1Porcentaje.Enabled =
            this.txtBoxDescuento2Monto.Enabled =
            this.txtBoxDescuento2Porcentaje.Enabled =
            this.cmbBoxTipoResponsable.Enabled =
            false;

            this.cmbBoxPedidosProveedores.Visible = true;
            this.lblCAE.Visible =
                this.txtBoxCAE.Visible =
            this.btnFacturaElectronica.Visible = false;

            this.lblContactoProveedor.Visible = true;
            this.cmbBoxContactoProveedor.Visible = true;
            this.cmbBoxContactoProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbBoxContactoProveedor.Enabled = false;

            this.cmbBoxTipoComprobante.FormattingEnabled = true;
            this.cmbBoxTipoComprobante.Format += delegate(object sender, ListControlConvertEventArgs e)
                {
                    e.Value = Constantes.GetDescription<Constantes.TipoComprobanteCompra>((Constantes.TipoComprobanteCompra)e.Value);
                };

            this.cmbBoxTipoComprobante.DataSource = Enum.GetValues(typeof(Constantes.TipoComprobanteCompra));
            this.cmbBoxTipoComprobante.DropDownWidth = GetDropDownWidth(this.cmbBoxTipoComprobante) + 25;
            this.cmbBoxTipoComprobante.DropDownStyle = ComboBoxStyle.DropDownList;

            this.cmbBoxTipoComprobante.Enabled = false;
        }
        private void inicializarComboBoxPedidosProveedores(List<ModeloPedido> p_mod_pedidos)
        {
            var dataSource = new List<ComboBoxItem>();
            dataSource.Add(new ComboBoxItem()
            {
                Name = "Todos",
                Value = (controlador as ControladorPedidoProveedor).getPedidoGlobal()
            });
            for (int i = 1; i < p_mod_pedidos.Count; i++)
            {
                dataSource.Add(new ComboBoxItem()
                {
                    Name = "Pedido a " + (p_mod_pedidos[i].entidad as ModeloProveedor).razonSocial +
                        " (" + i.ToString() + " de " + (p_mod_pedidos.Count -1).ToString() + ")",
                    Value = p_mod_pedidos[i]
                });
            }
            this.cmbBoxPedidosProveedores.DataSource = dataSource;

            InicializarCmbBox(this.cmbBoxPedidosProveedores);
            this.actualizarControlesPedidoProveedores();
        }
        private void actualizarControlesPedidoProveedores()
        {
            //Si esta seleccionado el pedidoGlobal, permitimos imprimir y guardar todo. No se permite individualmente
            bool pedidoGlobalSeleccionado = (this.cmbBoxPedidosProveedores.SelectedItem as ComboBoxItem).Name == "Todos";
            this.btnGuardar.Enabled =
                this.btnImprimir.Enabled =
                pedidoGlobalSeleccionado;
            this.glb_con_domicilio.Enabled =
                this.txtBoxMail.Enabled =
                this.txtBoxTelefono.Enabled =
                this.grpBoxObservacionesPedido.Enabled =
                this.cmbBoxFormaPago.Enabled=
                this.dtpFechaPedido.Enabled =
                !pedidoGlobalSeleccionado;
        }
        
        private void actualizarContextMenuStrip()
        {
            if (dgvArticulosVenta.SelectedRows.Count > 1)
            {
                cntxMenuLineasPedido.MenuItems[0].Visible = false;
                cntxMenuLineasPedido.MenuItems[1].Visible = false;
                cntxMenuLineasPedido.MenuItems[2].Text = "Editar lineas";
                cntxMenuLineasPedido.MenuItems[3].Text = "Eliminar lineas";
            }
            else
            {
                cntxMenuLineasPedido.MenuItems[0].Visible = true;
                cntxMenuLineasPedido.MenuItems[1].Visible = true;
                cntxMenuLineasPedido.MenuItems[2].Text = "Editar linea";
                cntxMenuLineasPedido.MenuItems[3].Text = "Eliminar linea";
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_mod_pedido">pedido global que contiene a los distintos pedidos a proveedores</param>
        private void actualizarPedidosProveedores(ModeloPedido p_mod_pedido)
        {
            List<ModeloPedido> lcl_lst_mod_pedidos = (controlador as ControladorPedidoProveedor).getPedidosProveedores(p_mod_pedido);
            this.inicializarComboBoxPedidosProveedores(lcl_lst_mod_pedidos);
            if (lcl_lst_mod_pedidos.Count > 0)
            {
                this.cargarPedidoEnControles((controlador as ControladorPedidoProveedor).getPedidoGlobal());
            }

        }

        private void habilitarControl(Control p_control)
        {
            if (p_control != null)
            {
                p_control.Enabled = true;
                habilitarControl(p_control.Parent);
            }
        }
        private void habilitarControles(Control p_control)
        {
            foreach (Control c in p_control.Controls)
            {
                habilitarControles(c);
            }
            p_control.Enabled = true;
        }
        private void desHabilitarControles(Control p_control)
        {
            foreach (Control c in p_control.Controls)
            {
                desHabilitarControles(c);
            }
            p_control.Enabled = false;
        } 
        #endregion
       
        #region Modelo -> Controles
        private void cargarPedidoEnControles(ModeloPedido p_mod_pedido)
        {
            this.controlador.pedidoActual = p_mod_pedido;
            
            this.cargarDatosPedidoEnControles(p_mod_pedido);
            this.cargarLineasEnControles(p_mod_pedido);
            this.cargarDocumentoEnControles(p_mod_pedido);
            this.cargarEntidadEnControles(p_mod_pedido.entidad);
            this.cargarFormaPagoEnControles(p_mod_pedido.formasDePago);

            this.cargarDomicilioEnControles(p_mod_pedido.domicilioDeFacturacion);
            this.cargarTelefonoEnControles(p_mod_pedido.telefonoContacto);
            this.cargarMailEnControles(p_mod_pedido.mailContacto);
        }

        private void cargarDatosPedidoEnControles(ModeloPedido p_mod_pedido)
        {
            this.txtBoxNumeroPedido.Text = p_mod_pedido.numeroPedido != 0 ? p_mod_pedido.numeroPedido.ToString() : "";
            this.dtpFechaPedido.Value = p_mod_pedido.fecha;
            this.txtBoxCAE.Text = !string.IsNullOrWhiteSpace(p_mod_pedido.CAE) ? p_mod_pedido.CAE: "";

            this.txtBoxIVAPorcentaje.Text = p_mod_pedido.alicuota.iva.porcentaje.ToString();
            this.cargarDatosMonetariosEnControles(p_mod_pedido);

            this.rchTextBoxObservacionesPedido.Text = p_mod_pedido.observaciones;
            if(p_mod_pedido.usuarioGenerador != null)
                this.lblUsuario.Text = "Usuario: " + p_mod_pedido.usuarioGenerador;
        }
        private void cargarDatosMonetariosEnControles(ModeloPedido p_mod_pedido)
        {
            this.txtBoxSenia.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", p_mod_pedido.senia);

            this.txtBoxDescuento1Porcentaje.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"),"{0:P1}", (p_mod_pedido.descuentos.descuento_porcentaje_1));
            this.txtBoxDescuento1Monto.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", p_mod_pedido.descuentos.descuento_monto_1);
            this.txtBoxDescuento2Porcentaje.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:P1}", (p_mod_pedido.descuentos.descuento_porcentaje_2));
            this.txtBoxDescuento2Monto.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", p_mod_pedido.descuentos.descuento_monto_2);
            this.txtBoxDescuentoLineas.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", p_mod_pedido.getDescuentoLineas());
            this.txtBoxDescuentoTotal.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", p_mod_pedido.getDescuentoTotal());
            
            this.txtBoxTotal.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", p_mod_pedido.getTotal());
            this.txtBoxSubtotal.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", p_mod_pedido.getSubTotal());

            this.txtBoxIVAMonto.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", p_mod_pedido.getIVAMonto()); 
        }
        private void cargarEntidadEnControles(ModeloEntidad p_mod_entidad)
        {
            if (p_mod_entidad.GetType() == typeof(ModeloProveedor))
            {
                this.cargarProveedorEnControles(p_mod_entidad as ModeloProveedor);
            }
            else if (p_mod_entidad.GetType() == typeof(ModeloCliente))
            {
                this.cargarClienteEnControles(p_mod_entidad as ModeloCliente);
            }
            this.rchTextBoxObservaciones.Text = p_mod_entidad.observaciones;

            #region Domicilios
            var dataSource = new List<ComboBoxItem>(); ;
            
            //dataSource = new List<ComboBoxItem>();
            foreach(ModeloDomicilio domicilio in p_mod_entidad.domicilios)
            {
                dataSource.Add(new ComboBoxItem() { Name = domicilio.ToString(), Value = domicilio});
            }
            
            dataSource.Add(new ComboBoxItem() { Name = "Otro", Value = null });
            this.cmbBoxDomicilios.DataSource = dataSource;
            this.cmbBoxDomicilios.DropDownWidth = GetDropDownWidth(this.cmbBoxDomicilios);
            this.cmbBoxDomicilios.SelectedIndex = 0;
            this.cargarDomicilioEnControles(cmbBoxDomicilios.SelectedValue as ModeloDomicilio);
            #endregion

            #region Mails
            
            dataSource = new List<ComboBoxItem>();
            foreach (ModeloMail mail in p_mod_entidad.mails)
            {
                dataSource.Add(new ComboBoxItem() { Name = mail.mail, Value = mail});
            }   
            dataSource.Add(new ComboBoxItem() { Name = "Otro", Value = null });
            this.cmbBoxMails.DataSource = dataSource;
            this.cmbBoxMails.DropDownWidth = GetDropDownWidth(this.cmbBoxMails);
            this.cmbBoxMails.SelectedIndex = 0;
            this.cargarMailEnControles(cmbBoxMails.SelectedValue as ModeloMail);
            #endregion

            #region Teléfonos

            dataSource = new List<ComboBoxItem>();
            foreach (ModeloTelefono telefono in p_mod_entidad.telefonos)
            {
                dataSource.Add(new ComboBoxItem() { Name = telefono.ToString(), Value = telefono});
            }
            dataSource.Add(new ComboBoxItem() { Name = "Otro", Value = null });
            this.cmbBoxTelefonos.DataSource = dataSource;
            this.cmbBoxTelefonos.DropDownWidth = GetDropDownWidth(this.cmbBoxTelefonos);
            this.cmbBoxTelefonos.SelectedIndex = 0;
            this.cargarTelefonoEnControles(this.cmbBoxTelefonos.SelectedValue as ModeloTelefono);
            #endregion
        }
        private void cargarClienteEnControles(ModeloCliente p_mod_cliente)
        {
            this.chckBoxClienteGenerico.Checked = (controlador as ControladorPedidoCliente).esClienteGenerico();
            this.txtBoxApellido.Text = p_mod_cliente.apellido;
            this.txtBoxNombre.Text = p_mod_cliente.nombre;

            this.cmbBoxTipoResponsable.SelectedItem = (Constantes.SituacionIVA)p_mod_cliente.codigoTipoResponsable;
            this.txtBoxRazonSocial.Text = p_mod_cliente.razonSocial;
        }
        private void cargarProveedorEnControles(ModeloProveedor p_mod_proveedor)
        {
            List<ModeloContactoProveedor> lcl_lst_contactosProveedor = new List<ModeloContactoProveedor>();
            if (p_mod_proveedor.codigo != 0)
            {
                lcl_lst_contactosProveedor = ControladorBusqueda.buscar(new ModeloContactoProveedor() { proveedor = p_mod_proveedor }, Constantes.ParametrosBusqueda.Entidades.Personas.ContactoProveedor.CodigoEntidad_Proveedor);
            }

            this.cmbBoxTipoResponsable.SelectedItem = (Constantes.SituacionIVA)p_mod_proveedor.codigoTipoResponsable;

            this.txtBoxRazonSocial.Text = p_mod_proveedor.razonSocial;
            
            this.cargarContactosProveedorEnControles(lcl_lst_contactosProveedor);
        }
        private void cargarContactosProveedorEnControles(List<ModeloContactoProveedor> p_lst_mod_contactoProveedores)
        {
            var dataSource = new List<ComboBoxItem>();
            if (p_lst_mod_contactoProveedores.Count == 0)
            {
                dataSource.Add(new ComboBoxItem() { Name = "Sin Contactos", Value = null });
            }
            else
            {
                foreach (ModeloContactoProveedor contacto in p_lst_mod_contactoProveedores)
                {
                    dataSource.Add(new ComboBoxItem() { Name = contacto.ToString(), Value = contacto });
                }
                dataSource.Add(new ComboBoxItem() { Name = "No asignar", Value = null });
            }
            this.cmbBoxContactoProveedor.DataSource = dataSource;
            this.cmbBoxContactoProveedor.DropDownWidth= GetDropDownWidth(this.cmbBoxContactoProveedor);

            this.cmbBoxContactoProveedor.Enabled = this.cmbBoxContactoProveedor.Items.Count < 2? false:true;
        }
        private void cargarDocumentoEnControles(ModeloPedido p_mod_pedido)
        {
            if (p_mod_pedido.entidad.GetType() == typeof(ModeloCliente))
            {
                if(!String.IsNullOrWhiteSpace(p_mod_pedido.documentoComprador.numero))
                {
                    this.cmbBoxTipoDocumento.SelectedValue = this.glb_lst_tiposDocumentos.SingleOrDefault(x => x.codigo == p_mod_pedido.documentoComprador.tipo.codigo);
                    this.txtBoxNumeroDocumento.Text = p_mod_pedido.documentoComprador.numero;
                    return;
                }
                if (string.IsNullOrWhiteSpace(p_mod_pedido.entidad.cuit) && !string.IsNullOrWhiteSpace((p_mod_pedido.entidad as ModeloCliente).dni))
                {
                    this.cmbBoxTipoDocumento.SelectedValue = this.glb_lst_tiposDocumentos.SingleOrDefault(x => x.codigo == 96);
                    this.txtBoxNumeroDocumento.Text = (p_mod_pedido.entidad as ModeloCliente).dni;
                    return;
                }
            }

            if (!string.IsNullOrWhiteSpace(p_mod_pedido.entidad.cuit))
            {
                this.cmbBoxTipoDocumento.SelectedValue = this.glb_lst_tiposDocumentos.SingleOrDefault(x => x.codigo == 80);
                this.txtBoxNumeroDocumento.Text = p_mod_pedido.entidad.cuit;
                return;
            }

            this.txtBoxNumeroDocumento.Text = "";
        }
        private void cargarDomicilioEnControles(ModeloDomicilio p_mod_domicilio)
        {
            this.glb_con_domicilio.SetDomicilio(p_mod_domicilio);
        }
        private void cargarMailEnControles(ModeloMail p_mod_mail)
        {
            if (p_mod_mail == null)
            {
                this.txtBoxMail.Text = "";
                return;
            }

            this.txtBoxMail.Text = p_mod_mail.mail;
        }
        private void cargarTelefonoEnControles(ModeloTelefono p_mod_telefono)
        {
            if (p_mod_telefono == null || p_mod_telefono.tipo == null)
            {
                this.txtBoxTelefono.Text = "";
                this.cmbBoxTipoTelefono.SelectedIndex  = 0;
                return;
            }

            this.txtBoxTelefono.Text = p_mod_telefono.numero;
            this.cmbBoxTipoTelefono.SelectedValue = p_mod_telefono.tipo;
        }
        private void cargarLineasEnControles(ModeloPedido p_mod_pedido)
        {
            DataTable lineas = new DataTable();
            lineas.Columns.Add("indice");
            lineas.Columns.Add("codigoOriginal");
            lineas.Columns.Add("codigoArticuloProveedor");
            lineas.Columns.Add("descripcion");
            lineas.Columns.Add("cantidad");
            lineas.Columns.Add("valorUnitario");
            lineas.Columns.Add("descuento");
            lineas.Columns.Add("valorParcialSinDescuento");
            lineas.Columns.Add("valorParcialConDescuento");
            int i = 0;
            foreach (ModeloLineaPedido l in p_mod_pedido.lineasPedido)
            {
                var row = lineas.NewRow();
                row["indice"] = i.ToString();
                i++;
                row["codigoOriginal"] = l.articulo.codigoOriginal;
                row["codigoArticuloProveedor"] = l.articulo.codigoArticuloProveedor;
                row["descripcion"] = l.articulo.descripcion;
                row["cantidad"] = l.cantidadArticulos;
                row["valorUnitario"] = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", l.valorUnitario);
                row["descuento"] =  String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", l.getDescuento());
                //row["descuento"] = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", l.descuentoLinea.PorcentajeDescuento);
                row["valorParcialSinDescuento"] = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", l.getValorParcialSinDescuentos());
                //row["valorParcialConDescuento"] = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", l.getValorParcial());
                row["valorParcialConDescuento"] = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", l.getValorParcialConDescuento());
                
                lineas.Rows.Add(row);
            }

            this.dgvArticulosVenta.DataSource = lineas;
        }
        private void cargarFormaPagoEnControles(List<FormaPago> p_formaPago)
        {
            int cantidadFormasPago = p_formaPago.Count;
            switch (cantidadFormasPago)
            {
                case 0:
                    //ver como se podría llevar el case 0 al modelo.
                    this.controlador.pedidoActual.formasDePago.Clear();
                    this.controlador.pedidoActual.addFormaPago(new FormaPago() { forma = Constantes.FormaDePago.Contado, restante = true});
                    this.cmbBoxFormaPago.SelectedItem = this.controlador.pedidoActual.formasDePago[0].forma;
                    break;
                case 1:
                    this.cmbBoxFormaPago.SelectedItem = this.controlador.pedidoActual.formasDePago[0].forma;
                    break;
                default :
                    this.cmbBoxFormaPago.SelectedItem = Constantes.FormaDePago.Multiple;
                    break;
            }
        }
        private void cargarTiposDocumentosEnControles(List<TipoDocumento> p_lst_tiposDocumentos)
        {
            var dataSource = new List<ComboBoxItem>();
            List<TipoDocumento> tiposDocumentos = p_lst_tiposDocumentos.OrderBy(i => i.descripcion).ToList();
            glb_lst_tiposDocumentos = tiposDocumentos;
            for (int i = 0; i < tiposDocumentos.Count; i++)
            {
                dataSource.Add(new ComboBoxItem() { Name = tiposDocumentos[i].descripcion, Value = tiposDocumentos[i] });
            }
            this.cmbBoxTipoDocumento.DataSource = dataSource;
            this.cmbBoxTipoDocumento.DropDownWidth = GetDropDownWidth(this.cmbBoxTipoDocumento);
        }
        #endregion
        
        #region Controles -> Modelo
        private ModeloPedido cargarControlEnPedido()
        {
            if (!this.validarPedido())
            {
                return null;
            }
            //incluido todo lo monetario en controlador.pedidoActual, entidad si es pedido a proveedor,
            //y forma(s) de pago
            ModeloPedido lcl_mod_pedido = controlador.pedidoActual;
            if (lcl_mod_pedido.codigoTipoPedido == Constantes.CodigosTiposPedidos.Persona)
            {
                lcl_mod_pedido.entidad = this.cargarControlEnCliente();
                lcl_mod_pedido.documentoComprador = this.cargarControlEnDocumento();
            }

            lcl_mod_pedido.tipoComprobante = this.getCodigoTipoComprobante();
            lcl_mod_pedido.domicilioDeFacturacion = this.cargarControlEnDomicilio();
            lcl_mod_pedido.mailContacto = this.cargarControlEnMail();
            lcl_mod_pedido.telefonoContacto = this.cargarControlEnTelefono();
            lcl_mod_pedido.observaciones = this.rchTextBoxObservacionesPedido.Text;
            lcl_mod_pedido.fecha = this.dtpFechaPedido.Value;
            lcl_mod_pedido.usuarioGenerador = ControladorSesion.nombreUsuarioLogeado;

            return lcl_mod_pedido;
        }
        private ModeloEntidad cargarControlEnCliente()
        {
            ModeloEntidad lcl_mod_entidad = new ModeloCliente();
            lcl_mod_entidad = controlador.pedidoActual.entidad;
            if(chckBoxClienteGenerico.Checked)
            {
                (lcl_mod_entidad as ModeloCliente).nombre = this.txtBoxNombre.Text;
                (lcl_mod_entidad as ModeloCliente).apellido = this.txtBoxApellido.Text;
                (lcl_mod_entidad as ModeloCliente).razonSocial = this.txtBoxRazonSocial.Text;
                (lcl_mod_entidad as ModeloCliente).codigoTipoResponsable = (int)this.cmbBoxTipoResponsable.SelectedValue;
            }
            return lcl_mod_entidad;
        }
        private Documento cargarControlEnDocumento()
        {
            Documento lcl_documento = new Documento();
            lcl_documento.tipo = this.cmbBoxTipoDocumento.SelectedValue as TipoDocumento;
            lcl_documento.numero = lcl_documento.tipo.codigo == 80?ModeloEntidad.CUIT.GetCuitNumerico(this.txtBoxNumeroDocumento.Text):this.txtBoxNumeroDocumento.Text.Replace(".","");
            
            return lcl_documento;
        }
        private ModeloContactoProveedor cargarControlEnContactoProveedor()
        {
            return (ModeloContactoProveedor)this.cmbBoxContactoProveedor.SelectedValue;
        }
        private ModeloDomicilio cargarControlEnDomicilio()
        {
            if (this.glb_con_domicilio.domicilioVacio())
            {
                return null;
            }
            return this.glb_con_domicilio.GetDomicilio();
        }
        private ModeloTelefono cargarControlEnTelefono()
        {
            if (this.vacioTelefono())
            {
                return null;
            }
            ModeloTelefono lcl_mod_telefono = new ModeloTelefono();
            lcl_mod_telefono.numero = this.txtBoxTelefono.Text; ;
            lcl_mod_telefono.tipo = this.cmbBoxTipoTelefono.SelectedValue.ToString();
            return lcl_mod_telefono;
        }
        private ModeloMail cargarControlEnMail()
        {
            if (this.vacioMail())
            {
                return null;
            }
            ModeloMail lcl_mod_mail = new ModeloMail();
            lcl_mod_mail.mail = this.txtBoxMail.Text;
            return lcl_mod_mail;
        }
        private int getCodigoTipoComprobante()
        {
            int tipoComprobante = 0;
            if (modoFormulario == ModoFormularioDevolucionCliente)
            {
                tipoComprobante = ControladorPedidoCliente.getCodigoComprobante((Constantes.TipoComprobanteDevolucion)this.cmbBoxTipoComprobante.SelectedValue,
                                                                                                (int)this.cmbBoxTipoResponsable.SelectedValue);
            }
            else if (modoFormulario == ModoFormularioPedidoCliente)
            {
                tipoComprobante = ControladorPedidoCliente.getCodigoComprobante((Constantes.TipoComprobanteVenta)this.cmbBoxTipoComprobante.SelectedValue,
                                                                                                (int)this.cmbBoxTipoResponsable.SelectedValue);
              //  tipoComprobante = ControladorPedidoCliente.getCodigoComprobante((Constantes.TipoComprobanteVenta)this.cmbBoxTipoComprobante.SelectedValue,//Situacion de IVA una vez cargados en la BD
              //                                             (controlador.pedidoActual.entidad.situacionIVA== null)?controlador.pedidoActual.entidad.situacionIVA: Convert.ToInt16(chckBoxResponsableInscripto.Checked));
            }
            else if (modoFormulario == ModoFormularioPedidoProveedor)
            {
                tipoComprobante = (int)Constantes.TipoComprobanteCompra.Pedido_Proveedor;
            }
            return tipoComprobante;
        }
        #endregion

        #region Validaciones
        private int getIndex(string p_inputName)
        {
            int index;
            switch (p_inputName)
            {
                case Constantes.ParametrosBusqueda.Entidades.Personas.Cuit:
                case Constantes.ParametrosBusqueda.Entidades.Personas.Dni:
                    index = 0;
                    break;
                case Constantes.ParametrosBusqueda.Entidades.Personas.Nombre:
                    index = 1;
                    break;
                case Constantes.ParametrosBusqueda.Entidades.Personas.Apellido:
                    index = 2;
                    break;
                case Constantes.ParametrosBusqueda.Entidades.Proveedores.RazonSocial:
                    index = 3;
                    break;
                case Constantes.ParametrosBusqueda.Domicilios.Calle:
                    index = 4;
                    break;
                case Constantes.ParametrosBusqueda.Domicilios.NumeroDomicilio:
                    index = 5;
                    break;
                case Constantes.ParametrosBusqueda.Domicilios.Ciudad:
                    index = 6;
                    break;
                case Constantes.ParametrosBusqueda.Mails.Mail:
                    index = 7;
                    break;
                case Constantes.ParametrosBusqueda.Telefonos.NumeroTelefono:
                    index = 8;
                    break;
                default:
                    index = 0;
                    break;
            }
            return index;
        }

        private bool validarInputs()
        {
            txtBoxNumeroDocumento_Leave(new object(), new EventArgs());

            txtBoxMail_Leave(new object(), new EventArgs());
            txtBoxTelefono_Leave(new object(), new EventArgs());

            return (glb_array_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Cuit)]
                && this.validarEntidad()
                && this.validarDomicilio()
                && glb_array_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Mails.Mail)]
                && glb_array_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Telefonos.NumeroTelefono)]);
        }

        private bool validarEntidad()
        {
            if(!string.IsNullOrWhiteSpace(txtBoxRazonSocial.Text))
            {
                this.txtBoxRazonSocial_Leave(new object(), new EventArgs());
            }
            else
            {
                this.txtBoxApellido_Leave(new object(), new EventArgs());
                this.txtBoxNombre_Leave(new object(), new EventArgs());
            }
            
            
            //string mensaje;
            if (this.getCodigoTipoPedido() == Constantes.CodigosTiposPedidos.Proveedor)
            {
                if (!glb_array_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Entidades.Proveedores.RazonSocial)])
                {
                    return false;
                    //mensaje = "Debe completar el campo Razon Social del proveedor";//Son proveedores que ya estan cargados. No creo que pase
                }
            }
            else
            {
                if (!glb_array_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Entidades.Proveedores.RazonSocial)]
                    && (!glb_array_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Apellido)]
                    || !glb_array_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Nombre)]))
                {
                    return false;
                }
            }
            return true;
        }
        private bool validarDomicilio()
        {
            //Permite ingreso de domicilio vacío o directamente uno totalmente válido
            
            if (glb_con_domicilio.domicilioVacio())
            {
                glb_con_domicilio.clearErrorProviders();
                return true;
            }

            return glb_con_domicilio.validar();

        }
        private bool validarPedido()
        {
            bool lcl_inputs = new bool();
            if (controlador.pedidoActual.lineasPedido.Count == 0)
            {
                MessageBox.Show("No existen líneas en el pedido actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (controlador.pedidoActual.codigoTipoPedido == Constantes.CodigosTiposPedidos.Proveedor)
            {
                return true;    //No hay campos para validar en pedido a proveedor
            }
            lcl_inputs = validarInputs();
            if (!lcl_inputs)
            {
                MessageBox.Show("Por favor complete todos los campos obligatorios de manera correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lcl_inputs;
        }

        private bool vacioMail()
        {
            return String.IsNullOrWhiteSpace(this.txtBoxMail.Text);
        }
        
        private bool vacioTelefono()
        {
            return String.IsNullOrWhiteSpace(this.txtBoxTelefono.Text);
        }
        
        
        #endregion

        #region Otros

        private void imprimirpedido()
        {
            string lcl_comprobantePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Comprobantes";
            switch (this.controlador.pedidoActual.codigoTipoPedido)
            {
                case LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.Persona:
                    if (string.IsNullOrEmpty(Properties.Settings.Default.carpetaPedidosClientes))
                    {
                        MessageBox.Show("Actualmente no se encuentra configurado el directorio para guardar los comprobantes de pedido a cliente, por lo que se guardarán en su escritorio. Diríjase a \"Configuraciones\" para modificar el lugar de guardado de los mismos.");
                        lcl_comprobantePath = lcl_comprobantePath + "\\Clientes";
                        System.IO.Directory.CreateDirectory(lcl_comprobantePath);
                        Properties.Settings.Default.carpetaPedidosClientes = lcl_comprobantePath;
                        Properties.Settings.Default.Save();
                    }
                    break;
                case LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.Proveedor:
                    if (string.IsNullOrEmpty(Properties.Settings.Default.carpetaPedidosProveedores))
                    {
                        MessageBox.Show("Actualmente no se encuentra configurado el directorio para guardar los comprobantes de pedido a proveedores, por lo que se guardarán en su escritorio. Diríjase a \"Configuraciones\" para modificar el lugar de guardado de los mismos.");
                        lcl_comprobantePath = lcl_comprobantePath + "\\Proveedores";
                        System.IO.Directory.CreateDirectory(lcl_comprobantePath);
                        Properties.Settings.Default.carpetaPedidosProveedores = lcl_comprobantePath;
                        Properties.Settings.Default.Save();
                    }
                    break;
                default:
                    break;
            }
            frmImpresionComprobante lcl_frm_comprobante = new frmImpresionComprobante(Properties.Settings.Default.carpetaPedidosClientes, Properties.Settings.Default.carpetaPedidosProveedores);
            this.MostrarComprobante(lcl_frm_comprobante, new EventArgs());
            //lcl_frm_comprobante.estadoAcrobatPDF(false);          
            frmLoading lcl_frm_loading = new frmLoading("Espere por favor. Guardando pedido en formato PDF.", "Guardando Comprobante");
            bool exito = false;
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += (s, e) =>
            {
                if (controlador.pedidoActual.codigoTipoPedido == Constantes.CodigosTiposPedidos.Proveedor)
                {
                    //Imprime lote de pedidos a proveedor
                    List<ModeloPedido> lcl_lst_pedidosProveedoresImprimir = (controlador as ControladorPedidoProveedor).getPedidosProveedores(controlador.pedidoActual);
                    lcl_lst_pedidosProveedoresImprimir.RemoveAt(0);//Se quita el pedido global que abarca todos los pedidos
                    exito = lcl_frm_comprobante.generarComprobante(lcl_lst_pedidosProveedoresImprimir);
                }
                else
                {
                    exito = lcl_frm_comprobante.generarComprobante(controlador.pedidoActual);
                }
                
            };
            bw.RunWorkerCompleted += (s, e) =>
            {
                lcl_frm_loading.DialogResult = System.Windows.Forms.DialogResult.OK;
            };
            bw.RunWorkerAsync();

            lcl_frm_loading.ShowDialog();
        }

        private bool guardarPedido()
        {
            DialogResult dialogResult = new DialogResult();  
            do
            {
                //se fija si hay que guardar un pedido cliente o lote de pedidos a proveedor
                bool guardado = (this.controlador.pedidoActual.codigoTipoPedido == Constantes.CodigosTiposPedidos.Proveedor &&
                    this.cmbBoxPedidosProveedores.SelectedIndex == 0)? (controlador as ControladorPedidoProveedor).guardarPedidos():controlador.guardarPedido();
                
                if (!guardado)
                {
                    dialogResult = MessageBox.Show(controlador.errorActual, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (dialogResult == System.Windows.Forms.DialogResult.Cancel)
                    {
                        return false;
                    }
                }
            } while (dialogResult == System.Windows.Forms.DialogResult.Retry);
            //this.txtBoxNumeroPedido.Text = controlador.pedidoActual.numeroPedido.ToString();
            this.cargarDatosPedidoEnControles(controlador.pedidoActual);
            MessageBox.Show("Pedido guardado en base de datos", "Éxito", MessageBoxButtons.OK);
            return true;
        }
       
        /// <summary>
        /// Muestra mensaje de espera mientras realiza facturación electrónica con web service de AFIP
        /// </summary>
        /// <returns></returns>
        private bool facturarAFIP()
        {
            if (controlador.pedidoActual.tipoComprobante == 0)
            {
                //no factura si comprobante no lo requiere (presupuesto, reserva, otro)
                return true;
            }
            if (string.IsNullOrEmpty(Controladores.ControladorAFIP.CertificadoPath))
            {
                MessageBox.Show("Debe especificar un certificado en el panel de configuraciones para poder facturar electrónicamente");
                return false;
            }

            bool respuesta = false;
            BackgroundWorker bw = new BackgroundWorker();
            frmLoading lcl_frm_loading = new frmLoading("Espere por favor. Realizando facturación electrónica AFIP.");
            
            bool exito = false;
            bw.DoWork += (s, e) =>
            { 
                exito = (controlador as ControladorPedidoCliente).facturarAFIP();
            };
            bw.RunWorkerCompleted += (s, e) => 
            {
                lcl_frm_loading.Hide();
                if (exito)
                {
                    MessageBox.Show("Facturación electrónica realizada", "Éxito", MessageBoxButtons.OK);
                    respuesta = true;
                }
                else
                {
                    DialogResult dialogResul = MessageBox.Show(controlador.errorActual, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (dialogResul == System.Windows.Forms.DialogResult.Retry)
                    {
                        respuesta = this.facturarAFIP();
                    }
                    respuesta = false;
                }
            };

            bw.RunWorkerAsync();
            lcl_frm_loading.ShowDialog();

            return respuesta;
        }

        public Constantes.CodigosTiposPedidos getCodigoTipoPedido()
        {
            if (controlador.GetType() == typeof(ControladorPedidoCliente))
            {
                return Constantes.CodigosTiposPedidos.Persona;
            }
            else
            {
                return Constantes.CodigosTiposPedidos.Proveedor;
            }
        }
        #endregion

        #endregion

        #region Eventos

        #region TextBox
        private void txtBoxDescuento1Porcentaje_Leave(object sender, EventArgs e)
        {
            //para evento MouseUp
            alreadyFocused = false;
            //
            decimal porcentaje;
            if (!Decimal.TryParse(this.txtBoxDescuento1Porcentaje.Text.Replace("%", "").Replace(".", ","), out porcentaje) 
                || (porcentaje / 100)==controlador.pedidoActual.descuentos.descuento_porcentaje_1)
            {
                this.txtBoxDescuento1Porcentaje.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), 
                                                            "{0:P1}", (controlador.pedidoActual.descuentos.descuento_porcentaje_1));
                return;
            }
            porcentaje = porcentaje/100 ;

            controlador.pedidoActual.descuentos.descuento_porcentaje_1 = porcentaje;
            this.cargarDatosMonetariosEnControles(controlador.pedidoActual);
        }

        private void txtBoxDescuento1Monto_Leave(object sender, EventArgs e)
        {
            //para evento MouseUp
            alreadyFocused = false;
            //
            decimal descuento;
            if (!Decimal.TryParse(this.txtBoxDescuento1Monto.Text, out descuento) 
                || descuento == controlador.pedidoActual.descuentos.descuento_monto_1)
            {
                this.txtBoxDescuento1Monto.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"),
                                                    "{0:C}", controlador.pedidoActual.descuentos.descuento_monto_1);
                return;
            }

            controlador.pedidoActual.descuentos.descuento_monto_1 = descuento;
            this.cargarDatosMonetariosEnControles(controlador.pedidoActual);
        }

        private void txtBoxDescuento2Porcentaje_Leave(object sender, EventArgs e)
        {
            //para evento MouseUp
            alreadyFocused = false;
            //
            Decimal porcentaje;
            if (!Decimal.TryParse(this.txtBoxDescuento2Porcentaje.Text.Replace("%", "").Replace(".", ","), out porcentaje) 
                || (porcentaje / 100)== controlador.pedidoActual.descuentos.descuento_porcentaje_2)
            {
                this.txtBoxDescuento2Porcentaje.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"),
                                                        "{0:P1}", (controlador.pedidoActual.descuentos.descuento_porcentaje_2));
                return;
            }
            porcentaje = porcentaje / 100;

            controlador.pedidoActual.descuentos.descuento_porcentaje_2 = porcentaje;
            this.cargarDatosMonetariosEnControles(controlador.pedidoActual);
        }

        private void txtBoxDescuento2Monto_Leave(object sender, EventArgs e)
        {
            //para evento MouseUp
            alreadyFocused = false;
            //
            decimal descuento;
            if (!Decimal.TryParse(this.txtBoxDescuento2Monto.Text.Replace("$", ""), out descuento) 
                || descuento == controlador.pedidoActual.descuentos.descuento_monto_2)
            {
                this.txtBoxDescuento2Monto.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}",
                    controlador.pedidoActual.descuentos.descuento_monto_2);
                return;
            }

            controlador.pedidoActual.descuentos.descuento_monto_2 = descuento;
            this.cargarDatosMonetariosEnControles(controlador.pedidoActual);
        }

        private void txtBoxSenia_Leave(object sender, EventArgs e)
        {
            //para evento MouseUp
            alreadyFocused = false;
            //
            decimal senia;
            if (!Decimal.TryParse(this.txtBoxSenia.Text.Replace("$", ""), out senia) || senia == controlador.pedidoActual.senia)
            {
                this.txtBoxSenia.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", controlador.pedidoActual.senia);
                return;
            }

            controlador.pedidoActual.senia = senia;
            this.cargarDatosMonetariosEnControles(controlador.pedidoActual);
        }

        private void txtBoxNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.valorNumericoTeclado(sender, e);
            if (!e.Handled)
            {
                return;//quiere decir que se ingreso un número en el evento anterior
            }
            else
            {
                e.Handled = false;//Volvemos a setear en caso que no haya sido un número el keyPress
            }

            //Admitimos además de numéricos también guiones y puntos según corresponda
            int keyCharSeparador = (this.cmbBoxTipoDocumento.SelectedValue as TipoDocumento).codigo == 80 ? 45 : 46;//45: '-' 46: '.'

            if (e.KeyChar != keyCharSeparador)
            {
                e.Handled = true;
                return;
            }
        }
        private void txtBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.valorNumericoTeclado(sender, e);
        }

        private bool alreadyFocused;
        private void selectText(object sender, MouseEventArgs e)
        {
            if (!alreadyFocused && (sender as TextBox).SelectionLength == 0)
            {
                alreadyFocused = true;
                (sender as TextBox).SelectAll();
            }
        }
        #endregion
        
        #region ComboBox
        private bool validarPedidoProveedor()
        {
            string mensaje = "";
            bool valido = true;

            this.txtBoxTelefono_Leave(new object(), new EventArgs());
            this.txtBoxMail_Leave(new object(),new EventArgs());
            
            if (!validarDomicilio() || 
                !glb_array_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Mails.Mail)] ||
                !glb_array_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Telefonos.NumeroTelefono)])
            {
                valido = false;
                mensaje = "Revise los campos del ";
                if(!validarDomicilio())
                {
                    mensaje +="domicilio";
                }
                else if(!glb_array_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Mails.Mail)])
                {
                    mensaje +="mail";
                }
                else if(!glb_array_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Telefonos.NumeroTelefono)])
                {
                    mensaje +="teléfono";
                }
                mensaje += " ingresado";
            }
            
            if (!valido)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return valido;
        }
        private void cmbBoxPedidosProveedores_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!validarPedidoProveedor())//se valida el proveedor seleccionado anteriormente para si cambiar o no la selección
            {
                this.cmbBoxPedidosProveedores.SelectedIndex = indiceAnteriorCmbBoxPedidosProveedores;
                return;
            }

            if (indiceAnteriorCmbBoxPedidosProveedores != 0)
            {
                (controlador as ControladorPedidoProveedor).pedidosProveedores[indiceAnteriorCmbBoxPedidosProveedores].mailContacto = cargarControlEnMail();
                (controlador as ControladorPedidoProveedor).pedidosProveedores[indiceAnteriorCmbBoxPedidosProveedores].telefonoContacto = cargarControlEnTelefono();
                (controlador as ControladorPedidoProveedor).pedidosProveedores[indiceAnteriorCmbBoxPedidosProveedores].domicilioDeFacturacion = cargarControlEnDomicilio();
                (controlador as ControladorPedidoProveedor).pedidosProveedores[indiceAnteriorCmbBoxPedidosProveedores].observaciones = rchTextBoxObservacionesPedido.Text;
                //cargar ContactoProveedor
                //forma de pago
            }

            var pedido = (ModeloPedido)cmbBoxPedidosProveedores.SelectedValue;

            this.cargarPedidoEnControles(pedido);
            //Se quitan errorProviders para el cambio de proveedor
            this.glb_con_domicilio.clearErrorProviders();
            this.setErrorProvider(this.txtBoxMail, true, null);
            this.setErrorProvider(this.txtBoxTelefono, true, null);

            this.actualizarControlesPedidoProveedores();
        }
        
        private void cmbBoxDomicilios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var domicilio = (ModeloDomicilio)cmbBoxDomicilios.SelectedValue;
            this.cargarDomicilioEnControles(domicilio);
        }
        private void cmbBoxMails_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mail = (ModeloMail)cmbBoxMails.SelectedValue;
            this.cargarMailEnControles(mail);
        }
        private void cmbBoxTelefonos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var telefono = (ModeloTelefono)cmbBoxTelefonos.SelectedValue;
            this.cargarTelefonoEnControles(telefono);
        }
        private void cmbBoxFormaPago_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LibreriaClasesCompartidas.Constantes.FormaDePago lcl_formaDePago = (LibreriaClasesCompartidas.Constantes.FormaDePago)this.cmbBoxFormaPago.SelectedValue;

            if (lcl_formaDePago == Constantes.FormaDePago.Multiple)
            {
                ModeloPedido lcl_mod_pedido = ObjectCopier.Clone<ModeloPedido>(this.controlador.pedidoActual);

                //lcl_mod_pedido = new 
                frmPedidoCierre_FormasDePago lcl_frm_formasDePago = new frmPedidoCierre_FormasDePago(lcl_mod_pedido);
                lcl_frm_formasDePago.ShowDialog();
                if (lcl_frm_formasDePago.DialogResult != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
                //se agrega .ToList() porque si no, no corre y no se usa directamente en el foreach porque esta linkeada con 
                //controlador.pedidoActual.formasDePago, entonces despues del Clear() da  count 0
                List<FormaPago> lcl_lst_formasPago = lcl_frm_formasDePago.getFormasDePago().ToList();
                controlador.pedidoActual.formasDePago.Clear();

                foreach (FormaPago fp in lcl_lst_formasPago)
                {
                    controlador.pedidoActual.addFormaPago(fp);
                }
            }
            else
            {
                controlador.pedidoActual.formasDePago.Clear();
                controlador.pedidoActual.addFormaPago(new FormaPago() { forma = lcl_formaDePago, restante = true });
            }
            this.cargarDatosPedidoEnControles(this.controlador.pedidoActual);
            this.cargarLineasEnControles(this.controlador.pedidoActual);
            //this.cargarPedidoEnControles(this.controlador.pedidoActual);
        }
        private void cmbBoxTipoComprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.getCodigoTipoComprobante() < 1000)
            {
                this.btnFacturaElectronica.Enabled = true;
            }
            else
            {
                this.btnFacturaElectronica.Enabled = false;
            }
        }
        #endregion

        #region Button

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (this.cargarControlEnPedido() == null)
            {
                return;
            }
            if (controlador.pedidoActual.numeroPedido == 0)
            {
                DialogResult dialogResult = MessageBox.Show("El/La " + cmbBoxTipoComprobante.Text
                + " no esta guardado en la base de datos. Desea guardar antes de imprimir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    //if (this.cargarControlEnPedido() == null)
                    //{
                    //    return;
                    //}
                    if (this.guardarPedido())
                    {
                        this.inicializarPedidoCerrado();
                    }
                }
               
            }
            //else
            //{
            //    if (this.cargarControlEnPedido() == null)
            //    {
            //        return;
            //    }
            //}
            this.imprimirpedido();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.cargarControlEnPedido() == null)
            {
                return;
            }
            
            if (this.guardarPedido())
            {
                this.inicializarPedidoCerrado();
            }
            
        }
        private void btnFacturaElectronica_Click(object sender, EventArgs e)
        {
            if (this.cargarControlEnPedido() == null)
            {
                return;
            }
            if (this.facturarAFIP())
            {
                if (this.guardarPedido())
                {
                    this.inicializarPedidoCerrado();
                }
                else
                {
                    this.inicializarPedidoFacturado();
                }  
               
                if(DialogResult.Yes==(MessageBox.Show("¿Desea imprimir la Factura?", "Impresión de Factura Electrónica",MessageBoxButtons.YesNo)))
                {
                    this.imprimirpedido();
                }
            }
            
        }
        #endregion

        #region CheckedBox
        private void clienteGenerico_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                (controlador as ControladorPedidoCliente).asignarClienteGenerico();
            }
            else
            {
                ModeloCliente lcl_mod_cliente = new ModeloCliente();
                frmABMEntidad lcl_frm_entidad = new frmABMEntidad(controlador.pedidoActual.entidad, frmABMEntidad.ModoFormularioClientePedido);
                lcl_frm_entidad.CerrarForm += buscarCliente_Closed;
                this.BuscarCliente(lcl_frm_entidad, e);
            }
        }
        public void buscarCliente_Closed(object sender, EventArgs e)
        {
            ModeloCliente lcl_mod_cliente = (sender as frmABMEntidad).glb_mod_entidadActual as ModeloCliente;
            if (ControladorPedidoCliente.esClienteGenerico(lcl_mod_cliente))
            {
                this.chckBoxClienteGenerico.Checked = true;
            }
            else
            {
                controlador.pedidoActual.entidad = lcl_mod_cliente;
                this.cargarEntidadEnControles(controlador.pedidoActual.entidad as ModeloCliente);
                this.cargarDocumentoEnControles(controlador.pedidoActual);

                this.validarInputs();
            }
        }

      
        #endregion

        private void setCuitOnly(bool p_soloPermitirCuit)
        {
            if (p_soloPermitirCuit)
            {
                //Si es responsable inscripto, sólo se puede usar CUIT para facturación electrónica
                //También si se ingresa razonSocial
                this.cmbBoxTipoDocumento.SelectedItem = glb_lst_tiposDocumentos.SingleOrDefault(x => x.codigo == 80);
                this.cmbBoxTipoDocumento.Enabled = false;
            }
            else
            {
                this.cmbBoxTipoDocumento.Enabled = true;
            }
        }

        #region DataGridView
        private void dgvArticulosVenta_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                int currentMouseOverRow = this.dgvArticulosVenta.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    if ((ModifierKeys & Keys.Control) != Keys.Control
                        && this.dgvArticulosVenta.Rows[currentMouseOverRow].Selected != true)
                    {//si selected == true significa que puede haber más elementos seleccionados anteriormente y no hay que perder selección
                        this.dgvArticulosVenta.ClearSelection();
                    }
                    this.dgvArticulosVenta.Rows[currentMouseOverRow].Selected = true;
                    this.actualizarContextMenuStrip();
                    cntxMenuLineasPedido.Show(dgvArticulosVenta, new Point(e.X, e.Y));
                }
            }
        }
        #endregion

        #region Múltiples Controles
        /// <summary>
        /// Edita 1 o más líneas del pedido actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void evento_editarLinea(object sender, EventArgs e)
        {
            if (this.dgvArticulosVenta.CurrentRow == null)
            {
                MessageBox.Show("No hay línea de pedido seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int i = Convert.ToInt32(this.dgvArticulosVenta.CurrentRow.Cells["indice"].Value);
            ModeloLineaPedido lcl_mod_lineaPedido = ObjectCopier.Clone<ModeloLineaPedido>(controlador.pedidoActual.lineasPedido[i]);
            Form lcl_frm_editarLinea;
            if (modoFormulario == ModoFormularioDevolucionCliente)
            {
                ModeloLineaPedido lcl_mod_lineaPedidoOriginal = (controlador as ControladorPedidoCliente).pedidoDevuelto.getLineaPedido(lcl_mod_lineaPedido.articulo);
                lcl_frm_editarLinea = new frmPedidoCierre_EditarLineaPedido(lcl_mod_lineaPedido, lcl_mod_lineaPedidoOriginal);
            }
            else
            {
                lcl_frm_editarLinea = new frmPedidoCierre_EditarLineaPedido(lcl_mod_lineaPedido, controlador.pedidoActual.codigoTipoPedido);
            }
            lcl_frm_editarLinea.ShowDialog();
            if (lcl_frm_editarLinea.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                controlador.pedidoActual.lineasPedido[i] = (lcl_frm_editarLinea as frmPedidoCierre_EditarLineaPedido).getLineaPedido();
                this.controlador.updateLineaPedido(controlador.pedidoActual.lineasPedido[i]);
                
                this.cargarDatosPedidoEnControles(this.controlador.pedidoActual);
                this.cargarLineasEnControles(this.controlador.pedidoActual);
                //this.cargarPedidoEnControles(controlador.pedidoActual);
                if (controlador.pedidoActual.codigoTipoPedido == Constantes.CodigosTiposPedidos.Proveedor)
                {
                    ModeloPedido p_actual = ObjectCopier.Clone(controlador.pedidoActual);
                    this.actualizarPedidosProveedores((controlador as ControladorPedidoProveedor).getPedidoGlobal());
                    this.cmbBoxPedidosProveedores.SelectedIndex = (controlador as ControladorPedidoProveedor).getIndice(p_actual);
                    cmbBoxPedidosProveedores_SelectionChangeCommitted(new object(), new EventArgs());
                }
            }
        }

        /// <summary>
        /// Elimina 1 o más líneas del pedido actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void evento_eliminarLinea(object sender, EventArgs e)
        {
            List<ModeloLineaPedido> lcl_lst_lineasPedidosEliminar = new List<ModeloLineaPedido>();
            int i;
            string detallesArticulos = "";
            foreach (DataGridViewRow row in dgvArticulosVenta.SelectedRows)
            {
                i = Convert.ToInt32(row.Cells["indice"].Value);
                lcl_lst_lineasPedidosEliminar.Add(controlador.pedidoActual.lineasPedido[i]);

                i = lcl_lst_lineasPedidosEliminar.Count - 1;
                detallesArticulos += Environment.NewLine + "- " + lcl_lst_lineasPedidosEliminar[i].articulo.descripcionArticuloProveedor + " (" + lcl_lst_lineasPedidosEliminar[i].articulo.codigoArticuloProveedor + ")";
            }

            if (lcl_lst_lineasPedidosEliminar.Count < 1)
            {
                MessageBox.Show("No hay línea de pedido seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mensaje = lcl_lst_lineasPedidosEliminar.Count > 1 ?
                    "¿Está seguro que desea eliminar las líneas correspondientes a los artículos: " :
                    "¿Está seguro que desea eliminar la línea correspondiente al artículo: ";

            DialogResult dialogResult = MessageBox.Show(mensaje +
                detallesArticulos + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (ModeloLineaPedido lp in lcl_lst_lineasPedidosEliminar)
                {
                    controlador.removeLineaPedido(lp);
                }
                
                this.cargarDatosPedidoEnControles(this.controlador.pedidoActual);
                this.cargarLineasEnControles(this.controlador.pedidoActual);
                //this.cargarPedidoEnControles(controlador.pedidoActual);
                if (controlador.pedidoActual.codigoTipoPedido == Constantes.CodigosTiposPedidos.Proveedor)
                {
                    ModeloPedido p_actual = ObjectCopier.Clone(controlador.pedidoActual);
                    this.actualizarPedidosProveedores((controlador as ControladorPedidoProveedor).getPedidoGlobal());
                    this.cmbBoxPedidosProveedores.SelectedIndex = (controlador as ControladorPedidoProveedor).getIndice(p_actual);
                    cmbBoxPedidosProveedores_SelectionChangeCommitted(new object(), new EventArgs());
                }
            }
        }
        ModeloPedido pedidoAgregarLineas;
        /// <summary>
        /// Muestra ventana para agregar artículos al pedido actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void evento_agregarLinea(object sender, EventArgs e)
        {
            pedidoAgregarLineas = new ModeloPedido();
            if (controlador.pedidoActual.codigoTipoPedido == Constantes.CodigosTiposPedidos.Proveedor)
            {
                pedidoAgregarLineas = ObjectCopier.Clone((controlador as ControladorPedidoProveedor).getPedidoGlobal());
            }
            else
            {
                pedidoAgregarLineas = ObjectCopier.Clone(controlador.pedidoActual);
            }
            
            Form lcl_frm_agregarArticulos;
            if (modoFormulario == ModoFormularioDevolucionCliente)
            {
                lcl_frm_agregarArticulos = new frmPedidoDevolucion((controlador as ControladorPedidoCliente).pedidoDevuelto, pedidoAgregarLineas);
                (lcl_frm_agregarArticulos as frmPedidoDevolucion).CerrarForm += this.evento_agregarLineaClosed;
            }
            else
            {
                lcl_frm_agregarArticulos = new frmPedidoNuevo(pedidoAgregarLineas);
                (lcl_frm_agregarArticulos as frmPedidoNuevo).CerrarForm += this.evento_agregarLineaClosed;
            }
            
            AgregarLineaPedido(lcl_frm_agregarArticulos, e);
            
        }

        private void evento_agregarLineaClosed(object sender, EventArgs e)
        {            
            if ((sender as Form).DialogResult != System.Windows.Forms.DialogResult.Ignore)
            {
                controlador.pedidoActual.removeAllLineaPedido();
                controlador.pedidoActual.addLineaPedidoList(pedidoAgregarLineas.lineasPedido);
                if(controlador.pedidoActual.codigoTipoPedido == Constantes.CodigosTiposPedidos.Proveedor)
                {
                    this.actualizarPedidosProveedores(controlador.pedidoActual);
                }
                //controlador.pedidoActual.lineasPedido = lcl_mod_pedido.lineasPedido;
                this.cargarDatosPedidoEnControles(controlador.pedidoActual);
                this.cargarLineasEnControles(controlador.pedidoActual);
            }
        }
       
        /// <summary>
        /// Muestra ventana con todos los detalles del artículo proveedor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void evento_verDetalleArticulo(object sender, EventArgs e)
        {
             if (this.dgvArticulosVenta.CurrentRow == null)
            {
                MessageBox.Show("No hay línea de pedido seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int i = Convert.ToInt32(this.dgvArticulosVenta.CurrentRow.Cells["indice"].Value);

            frmABMArticulo lcl_frm_articuloProveedor = new frmABMArticulo(controlador.pedidoActual.lineasPedido[i].articulo, frmABMArticulo.ModoFormularioVisualizarEntidad);
            MostrarDetallesArticulo(lcl_frm_articuloProveedor, e);
        }
        #endregion
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Validaciones
        private void txtBoxNumeroDocumento_Leave(object sender, EventArgs e)
        {
            string lcl_mensaje;
            bool lcl_respuesta = (this.cmbBoxTipoDocumento.SelectedValue as TipoDocumento).codigo == 80 ? //80 codigo de CUIT
                    Validar.validarLongitud(txtBoxNumeroDocumento.Text, Constantes.ParametrosBusqueda.Entidades.Personas.Cuit, out lcl_mensaje) :
                    Validar.validarLongitud(txtBoxNumeroDocumento.Text, Constantes.ParametrosBusqueda.Entidades.Personas.Dni, out lcl_mensaje);
            if (!lcl_respuesta)
            {
                this.setErrorProvider(txtBoxNumeroDocumento, false, lcl_mensaje);
                glb_array_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Cuit)] = false;
            }
            else
            {
                lcl_respuesta = (this.cmbBoxTipoDocumento.SelectedValue as TipoDocumento).codigo == 80 ? //80 codigo de CUIT
                    ModeloEntidad.CUIT.ValidarCuit(txtBoxNumeroDocumento.Text) :
                    Validar.validarInputNoNumerico(txtBoxNumeroDocumento.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Personas.Dni);

                glb_array_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Cuit)] = lcl_respuesta;

                lcl_mensaje = lcl_respuesta ? "OK" : "Número de Documento no válido";

                this.setErrorProvider(this.txtBoxNumeroDocumento, lcl_respuesta, lcl_mensaje);
            }
        }

        private void txtBoxApellido_Leave(object sender, EventArgs e)
        {
            string lcl_mensaje;
            if (!Validar.validarLongitud(txtBoxApellido.Text, Constantes.ParametrosBusqueda.Entidades.Personas.Apellido, out lcl_mensaje))
            {
                this.setErrorProvider(txtBoxApellido, false, lcl_mensaje);
                glb_array_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Apellido)] = false;
            }
            else
            {
                bool respuesta = Validar.validarInputNoNumerico(txtBoxApellido.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Personas.Apellido);
                glb_array_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Apellido)] = respuesta;

                lcl_mensaje = null;
                if (!respuesta)
                {
                    lcl_mensaje = "Apellido no válido";
                }
                else
                {
                    lcl_mensaje = "OK";
                    this.setErrorProvider(this.txtBoxRazonSocial, true, null);//Quitamos el ep en razon social si se estaba mostrando

                    if ((int)this.cmbBoxTipoResponsable.SelectedValue != 1)
                    {
                        this.setCuitOnly(false);
                    }
                }
                this.setErrorProvider(this.txtBoxApellido, respuesta, lcl_mensaje);
            }
        }

        private void txtBoxNombre_Leave(object sender, EventArgs e)
        {
            string lcl_mensaje;
            if (!Validar.validarLongitud(txtBoxNombre.Text, Constantes.ParametrosBusqueda.Entidades.Personas.Nombre, out lcl_mensaje))
            {
                this.setErrorProvider(txtBoxNombre, false, lcl_mensaje);
                glb_array_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Nombre)] = false;
            }
            else
            {
                bool respuesta = Validar.validarInputNoNumerico(txtBoxNombre.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Personas.Nombre);
                glb_array_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Nombre)] = respuesta;

                lcl_mensaje = respuesta ? "OK" : "Nombre no válido";
                if (!respuesta)
                {
                    lcl_mensaje = "Nombre no válido";
                }
                else
                {
                    lcl_mensaje = "OK";
                    this.setErrorProvider(this.txtBoxRazonSocial, true, null);//Quitamos el ep en razon social si se estaba mostrando

                    if ((int)this.cmbBoxTipoResponsable.SelectedValue != 1)
                    {
                        this.setCuitOnly(false);
                    }
                }

                this.setErrorProvider(this.txtBoxNombre, respuesta, lcl_mensaje);
            }
        }
       

        private void txtBoxRazonSocial_Leave(object sender, EventArgs e)
        {
            string lcl_mensaje;
            if (!Validar.validarLongitud(txtBoxRazonSocial.Text, Constantes.ParametrosBusqueda.Entidades.Proveedores.RazonSocial, out lcl_mensaje))
            {
                this.setErrorProvider(txtBoxRazonSocial, false, lcl_mensaje);
                glb_array_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Proveedores.RazonSocial)] = false;
            }
            else
            {
                bool respuesta = Validar.validarInputNoNumerico(txtBoxRazonSocial.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Proveedores.RazonSocial);
                glb_array_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Proveedores.RazonSocial)] = respuesta;

                lcl_mensaje = null;
                if (!respuesta)
                {
                    lcl_mensaje = "Razón Social no válida";
                }
                else
                {
                    lcl_mensaje = "OK";
                    this.setErrorProvider(this.txtBoxApellido, true, null);//Quitamos el ep en nombre y apellido si se estaba mostrando porque ya tenemos razon social vailda
                    this.setErrorProvider(this.txtBoxNombre, true, null);

                    this.setCuitOnly(true);
                }
                this.setErrorProvider(this.txtBoxRazonSocial, respuesta, lcl_mensaje);
            }
        }

        private void txtBoxMail_Leave(object sender, EventArgs e)
        {
            if (this.vacioMail())
            {
                glb_array_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Mails.Mail)] = true;
                this.setErrorProvider(txtBoxMail,true, null);
                return;
            }

            string lcl_mensaje;
            if (!Validar.validarLongitud(txtBoxMail.Text, Constantes.ParametrosBusqueda.Mails.Mail, out lcl_mensaje))
            {
                this.setErrorProvider(txtBoxMail, false, lcl_mensaje);
                glb_array_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Mails.Mail)] = false;
            }
            else
            {
                bool respuesta = Validar.validarInputNoNumerico(txtBoxMail.Text.ToString(), Constantes.ParametrosBusqueda.Mails.Mail);
                glb_array_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Mails.Mail)] = respuesta;

                lcl_mensaje = respuesta ? "OK" : "Mail no válido";
                this.setErrorProvider(this.txtBoxMail, respuesta, lcl_mensaje);
            }
        }

        private void txtBoxTelefono_Leave(object sender, EventArgs e)
        {
            if (this.vacioTelefono())
            {
                glb_array_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Telefonos.NumeroTelefono)] = true;
                this.setErrorProvider(this.txtBoxTelefono, true, null);
                return;
            }
            string lcl_mensaje;
            if (!Validar.validarLongitud(txtBoxTelefono.Text, Constantes.ParametrosBusqueda.Telefonos.NumeroTelefono, out lcl_mensaje))
            {
                this.setErrorProvider(txtBoxTelefono, false, lcl_mensaje);
                glb_array_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Telefonos.NumeroTelefono)] = false;
            }
            else
            {
                bool respuesta = Validar.validarInputNoNumerico(txtBoxTelefono.Text.ToString(), Constantes.ParametrosBusqueda.Telefonos.NumeroTelefono);
                glb_array_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Telefonos.NumeroTelefono)] = respuesta;

                lcl_mensaje = respuesta ? "OK" : "Telefono no válido";
                this.setErrorProvider(this.txtBoxTelefono, respuesta, lcl_mensaje);
            }
        }

        private void txtBoxIVAPorcentaje_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNumerico(txtBoxIVAPorcentaje.Text.ToString(), Constantes.Numericos.Porcentual);

            string mensaje = respuesta ? "OK" : "Porcentaje no válido";
            this.setErrorProvider(this.txtBoxIVAMonto, true, null);
        }

        private void txtBoxIVAMonto_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNumerico(txtBoxIVAMonto.Text.ToString(), Constantes.Numericos.EnteroPositivo);

            string mensaje = respuesta ? "OK" : "Monto no válido";
            this.setErrorProvider(this.txtBoxIVAMonto, respuesta, mensaje);
        }
        #endregion        

        private void txtBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.txtBoxRazonSocial.Text))
            {
                this.setErrorProvider(this.txtBoxApellido,false,"Debe vaciar el campo razón social para completar este campo");
                e.Handled = true;
            }
        }

        private void txtBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.txtBoxRazonSocial.Text))
            {
                this.setErrorProvider(this.txtBoxNombre,false,"Debe vaciar el campo razón social para completar este campo");
                e.Handled = true;
            }
        }

        private void txtBoxRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.txtBoxNombre.Text)||!String.IsNullOrWhiteSpace(this.txtBoxApellido.Text))
            {
                string campoVaciar = !String.IsNullOrWhiteSpace(this.txtBoxApellido.Text)?"apellido":"nombre";
                this.setErrorProvider(this.txtBoxRazonSocial, false, "Debe vaciar el campo " + campoVaciar + " para completar este campo");
                e.Handled = true;
            } 
        }

        private void cmbBoxContactoProveedor_SelectedValueChanged(object sender, EventArgs e)
        {
            ModeloContactoProveedor lcl_mod_contacto = ((sender as ComboBox).SelectedValue as ModeloContactoProveedor);
            if (lcl_mod_contacto == null)
            {
                this.txtBoxNombre.Text = "";
                this.txtBoxApellido.Text = "";
            }
            else
            {
                this.txtBoxNombre.Text = lcl_mod_contacto.nombre;
                this.txtBoxApellido.Text = lcl_mod_contacto.apellido;
            }
        }
        /// <summary>
        /// guarda el indice del pedido seleccionado antes de cambiar la selección
        /// </summary>
        private int indiceAnteriorCmbBoxPedidosProveedores;
        /// <summary>
        /// Guarda indice anterior en caso que haya que volver a ese pedido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbBoxPedidosProveedores_Click(object sender, EventArgs e)
        {
            indiceAnteriorCmbBoxPedidosProveedores = this.cmbBoxPedidosProveedores.SelectedIndex;
        }

        private void cmbBoxTipoResponsable_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.glb_array_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Entidades.Proveedores.RazonSocial)])
            {
                return;
            }
            this.setCuitOnly((int)this.cmbBoxTipoResponsable.SelectedValue == 1);
        }

        private void cmbBoxTipoDocumento_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtBoxNumeroDocumento_Leave(new object(), new EventArgs());
            }
            catch (NullReferenceException ex)//hay algo que no esta inicializado en el método leave al momento de inicializar el método SelectedValueChanged. Despues no se usa esto
            { 
            }
            if (String.IsNullOrWhiteSpace(this.txtBoxNumeroDocumento.Text))
            {
                this.setErrorProvider(this.txtBoxNumeroDocumento, false, null);//Quitamos errorProvider cuando cambiamos de tipo y esta vacío
            }
        }
    }
}
