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
        public event EventHandler AgregarLineaPedido;
        public event EventHandler BuscarCliente;
        public event EventHandler MostrarDetallesArticulo;
        public event EventHandler MostrarComprobante;
        ModeloPedido glb_mod_pedidoOriginalDevolucion;
        List<bool> glb_lst_respuestasValidaciones;
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
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            dgvArticulosVenta.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvArticulosVenta.EnableHeadersVisualStyles = false; 
            this.StartPosition = FormStartPosition.CenterScreen;
            this.inicializarControles();
            glb_lst_respuestasValidaciones = new List<bool>();
            for (int i = 0; i < 8; i++)
            {
                glb_lst_respuestasValidaciones.Add(false);
            }
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
                    p_mod_pedido.codigoTipoPedido = LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.Persona;
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
        }
        /// <summary>
        /// Para realizar devoluciones
        /// </summary>
        /// <param name="p_mod_pedidoDevolucion"></param>
        /// <param name="p_mod_pedidoOriginal"></param>
        public frmPedidoCierre(ModeloPedido p_mod_pedidoDevolucion, ModeloPedido p_mod_pedidoOriginal) : this(p_mod_pedidoDevolucion, ModoFormularioDevolucionCliente)
        {
            glb_mod_pedidoOriginalDevolucion = p_mod_pedidoOriginal;
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
            this.txtBoxNumeroDocumento.KeyPress += this.valorNumeroDocumento;
        }
        private void inicializarComboBox()
        {
            //Populo combobox de paises
            List<ModeloPais> lcl_lst_mod_paises = ControladorBusqueda.getPaises();
            this.cargarPaisesEnControles(lcl_lst_mod_paises);
            
            this.cmbBoxPais.SelectedItem = new ModeloPais() { codigo = "AR", pais = "Argentina" };
            
            //Populo combobox de tiposDocumentos
            List<TipoDocumento> lcl_lst_tiposDocumentos = ControladorBusqueda.getTiposDocumentos();
            this.cargarTiposDocumentosEnControles(lcl_lst_tiposDocumentos);
            

            //Creo lista Tipos de teléfono
            var dataSource = new List<ComboBoxItem>();
            dataSource.Add(new ComboBoxItem() { Name = "Sin Teléfono", Value = "" });
            dataSource.Add(new ComboBoxItem() { Name = "Fijo", Value = Constantes.TipoTelefono.Fijo });
            dataSource.Add(new ComboBoxItem() { Name = "Celular", Value = Constantes.TipoTelefono.Celular });
            dataSource.Add(new ComboBoxItem() { Name = "Fax", Value = Constantes.TipoTelefono.Fax });
            //Binding de telefonos
            this.cmbBoxTipoTelefono.DataSource = dataSource;

            this.cmbBoxFormaPago.DataSource = Enum.GetValues(typeof(Constantes.FormaDePago));
            this.cmbBoxFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbBoxFormaPago.FormattingEnabled = true;
            this.cmbBoxFormaPago.Format += delegate(object sender, ListControlConvertEventArgs e)
            {
                e.Value = Constantes.GetDescription<Constantes.FormaDePago>((Constantes.FormaDePago)e.Value);
            };

            this.cmbBoxTipoDocumento.DisplayMember=
                this.cmbBoxPais.DisplayMember =
                this.cmbBoxProvincia.DisplayMember =
                this.cmbBoxTipoTelefono.DisplayMember =
                this.cmbBoxDomicilios.DisplayMember = 
                this.cmbBoxTelefonos.DisplayMember = 
                this.cmbBoxMails.DisplayMember = "Name";
            
            this.cmbBoxTipoDocumento.ValueMember =
                this.cmbBoxPais.ValueMember=
                this.cmbBoxProvincia.ValueMember = 
                this.cmbBoxTipoTelefono.ValueMember = 
                this.cmbBoxDomicilios.ValueMember = 
                this.cmbBoxTelefonos.ValueMember = 
                this.cmbBoxMails.ValueMember = "Value";
            //Lo hago read only
            this.cmbBoxTipoDocumento.DropDownStyle =
                this.cmbBoxProvincia.DropDownStyle = 
                this.cmbBoxPais.DropDownStyle = 
                this.cmbBoxTipoTelefono.DropDownStyle = 
                this.cmbBoxDomicilios.DropDownStyle = 
                this.cmbBoxTelefonos.DropDownStyle = 
                this.cmbBoxMails.DropDownStyle = ComboBoxStyle.DropDownList;

            //Populo combobox de provincias
            this.asignarProvincias();
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
            this.cmbBoxTipoComprobante.DropDownWidth = this.getDropDownWidth(this.cmbBoxTipoComprobante)+25;
            this.cmbBoxTipoComprobante.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void inicializarControlesProveedor()
        {
            this.cmbBoxPedidosProveedores.Visible = true;
            this.btnFacturaElectronica.Visible = false;

            this.lblContactoProveedor.Visible = true;
            this.cmbBoxContactoProveedor.Visible = true;
            this.cmbBoxContactoProveedor.DropDownStyle = ComboBoxStyle.DropDownList;

            this.cmbBoxTipoComprobante.FormattingEnabled = true;
            this.cmbBoxTipoComprobante.Format += delegate(object sender, ListControlConvertEventArgs e)
                {
                    e.Value = Constantes.GetDescription<Constantes.TipoComprobanteCompra>((Constantes.TipoComprobanteCompra)e.Value);
                };

            this.cmbBoxTipoComprobante.DataSource = Enum.GetValues(typeof(Constantes.TipoComprobanteCompra));
            this.cmbBoxTipoComprobante.DropDownWidth = this.getDropDownWidth(this.cmbBoxTipoComprobante) + 25;
            this.cmbBoxTipoComprobante.DropDownStyle = ComboBoxStyle.DropDownList;
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
            //if (dataSource.Count < 1)
            //{
            //    this.cmbBoxPedidosProveedores.Enabled = false;
            //    return;
            //}
            //this.cmbBoxPedidosProveedores.Enabled = true;
            
            this.cmbBoxPedidosProveedores.DropDownWidth = this.getDropDownWidth(this.cmbBoxPedidosProveedores);
            this.cmbBoxPedidosProveedores.DisplayMember = "Name";
            this.cmbBoxPedidosProveedores.ValueMember = "Value";
            this.cmbBoxPedidosProveedores.DropDownStyle = ComboBoxStyle.DropDownList;
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
        private void actualizarPedidosProveedores(ModeloPedido p_mod_pedido)
        {
            List<ModeloPedido> lcl_lst_mod_pedidos = (controlador as ControladorPedidoProveedor).getPedidosProveedores(p_mod_pedido);
            this.inicializarComboBoxPedidosProveedores(lcl_lst_mod_pedidos);
            if (lcl_lst_mod_pedidos.Count > 0)
            {
                this.cargarPedidoEnControles((controlador as ControladorPedidoProveedor).getPedidoGlobal());
            }
        }

        private void asignarProvincias()
        {
            ModeloProvincia lcl_mod_provincia = new ModeloProvincia();
            //Inserto codigoPais del país seleccionado en el comboBox
            lcl_mod_provincia.codigoPais = (this.cmbBoxPais.SelectedValue as ModeloPais).codigo;
            //this.cmbBoxProvincia.DataSource = provincias;
            List<ModeloProvincia> lcl_lst_mod_provincias = ControladorBusqueda.getProvincias();
            List<ModeloProvincia> provincias = new List<ModeloProvincia>();
            foreach (ModeloProvincia p in lcl_lst_mod_provincias)
            {
                if (p.codigoPais == lcl_mod_provincia.codigoPais)
                {
                    provincias.Add(p);
                }
            }
            this.cargarProvinciasEnControles(provincias);
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
            this.cmbBoxDomicilios.DropDownWidth = this.getDropDownWidth(this.cmbBoxDomicilios);
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
            this.cmbBoxMails.DropDownWidth = this.getDropDownWidth(this.cmbBoxMails);
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
            this.cmbBoxTelefonos.DropDownWidth = this.getDropDownWidth(this.cmbBoxTelefonos);
            this.cmbBoxTelefonos.SelectedIndex = 0;
            this.cargarTelefonoEnControles(this.cmbBoxTelefonos.SelectedValue as ModeloTelefono);
            #endregion
        }
        private void cargarClienteEnControles(ModeloCliente p_mod_cliente)
        {
            this.chckBoxClienteGenerico.Checked = (controlador as ControladorPedidoCliente).esClienteGenerico();
            this.txtBoxApellido.Text = p_mod_cliente.apellido;
            this.txtBoxNombre.Text = p_mod_cliente.nombre;
            this.txtBoxRazonSocial.Text = p_mod_cliente.razonSocial;
        }
        private void cargarProveedorEnControles(ModeloProveedor p_mod_proveedor)
        {
            if (p_mod_proveedor.codigo == 0)
            {
                return;
            }
            this.txtBoxRazonSocial.Text = p_mod_proveedor.razonSocial;
            
            this.cargarContactosProveedorEnControles(
                ControladorBusqueda.buscar(new ModeloContactoProveedor(){proveedor = p_mod_proveedor},Constantes.ParametrosBusqueda.Entidades.Personas.ContactoProveedor.CodigoEntidad_Proveedor)
                );
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
            this.cmbBoxContactoProveedor.DropDownWidth= this.getDropDownWidth(this.cmbBoxContactoProveedor);
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
        }
        private void cargarDomicilioEnControles(ModeloDomicilio p_mod_domicilio)
        {
            if(p_mod_domicilio == null)
            {
                this.txtBoxCalle.Text =
                this.txtBoxNumeroDomicilio.Text =
                this.txtBoxPiso.Text =
                this.txtBoxDepartamento.Text =
                this.txtBoxCiudad.Text =
                this.txtBoxCodigoPostal.Text = "";
                return;
            }

            this.txtBoxCalle.Text = p_mod_domicilio.calle;
            this.txtBoxNumeroDomicilio.Text = p_mod_domicilio.numero;
            this.txtBoxPiso.Text = p_mod_domicilio.piso;
            this.txtBoxDepartamento.Text = p_mod_domicilio.departamento;
            this.txtBoxCiudad.Text = p_mod_domicilio.ciudad;
            this.txtBoxCodigoPostal.Text = p_mod_domicilio.codigoPostal;
            this.cmbBoxPais.SelectedValue = p_mod_domicilio.pais;

            this.cmbBoxProvincia.SelectedValue = p_mod_domicilio.provincia;
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
            if (p_mod_telefono == null)
            {
                this.txtBoxTelefono.Text = "";
                this.cmbBoxTipoTelefono.SelectedValue = "";
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
            this.cmbBoxTipoDocumento.DropDownWidth = this.getDropDownWidth(this.cmbBoxTipoDocumento);
        }
        private void cargarPaisesEnControles(List<ModeloPais> p_lst_mod_paises)
        {
            var dataSource = new List<ComboBoxItem>();
            List<ModeloPais> paises = p_lst_mod_paises.OrderBy(i => i.pais).ToList();
            for (int i = 0; i < paises.Count; i++)
            {
                dataSource.Add(new ComboBoxItem() { Name = paises[i].pais, Value = paises[i] });
            }
            this.cmbBoxPais.DataSource = dataSource;
            this.cmbBoxPais.DropDownWidth = this.getDropDownWidth(this.cmbBoxPais);
            
        }
        private void cargarProvinciasEnControles(List<ModeloProvincia> p_lst_mod_provincias)
        {
            var dataSource = new List<ComboBoxItem>();
            List<ModeloProvincia> provincias = p_lst_mod_provincias.OrderBy(i => i.provincia).ToList();
            for (int i = 0; i < provincias.Count; i++)
            {
                dataSource.Add(new ComboBoxItem() {Name = provincias[i].provincia, Value = provincias[i]} );
            }
            this.cmbBoxProvincia.DataSource = dataSource;
            this.cmbBoxProvincia.DropDownWidth = this.getDropDownWidth(this.cmbBoxProvincia);
        }
        #endregion
        
        #region Controles -> Modelo
        private ModeloPedido cargarControlEnPedido(object sender, EventArgs e)
        {
            if (!this.validarPedido(sender,e))
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
            }
            return lcl_mod_entidad;
        }
        private Documento cargarControlEnDocumento()
        {
            Documento lcl_documento = new Documento();
            lcl_documento.tipo = this.cmbBoxTipoDocumento.SelectedValue as TipoDocumento;
            lcl_documento.numero = this.txtBoxNumeroDocumento.Text; //"20111111112" ejemplo
            return lcl_documento;
        }
        private ModeloContactoProveedor cargarControlEnContactoProveedor()
        {
            return (ModeloContactoProveedor)this.cmbBoxContactoProveedor.SelectedValue;
        }
        private ModeloDomicilio cargarControlEnDomicilio()
        {
            if (this.vacioDomicilio())
            {
                return null;
            }
            ModeloDomicilio lcl_mod_domicilio = new ModeloDomicilio();
            lcl_mod_domicilio.calle = this.txtBoxCalle.Text;
            lcl_mod_domicilio.numero = this.txtBoxNumeroDomicilio.Text; 
            lcl_mod_domicilio.piso = this.txtBoxPiso.Text;
            lcl_mod_domicilio.departamento = this.txtBoxDepartamento.Text;
            lcl_mod_domicilio.ciudad = this.txtBoxCiudad.Text;
            lcl_mod_domicilio.codigoPostal = this.txtBoxCodigoPostal.Text; 
            lcl_mod_domicilio.provincia = (ModeloProvincia)this.cmbBoxProvincia.SelectedValue;
            lcl_mod_domicilio.pais = (ModeloPais)this.cmbBoxPais.SelectedValue;
            return lcl_mod_domicilio;
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
                                                                                                Convert.ToInt16(chckBoxResponsableInscripto.Checked));
            }
            else if (modoFormulario == ModoFormularioPedidoCliente)
            {
                tipoComprobante = ControladorPedidoCliente.getCodigoComprobante((Constantes.TipoComprobanteVenta)this.cmbBoxTipoComprobante.SelectedValue,
                                                                                                Convert.ToInt16(chckBoxResponsableInscripto.Checked));
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
                case Constantes.ParametrosBusqueda.Domicilios.Calle:
                    index = 3;
                    break;
                case Constantes.ParametrosBusqueda.Domicilios.NumeroDomicilio:
                    index = 4;
                    break;
                case Constantes.ParametrosBusqueda.Domicilios.Ciudad:
                    index = 5;
                    break;
                case Constantes.ParametrosBusqueda.Mails.Mail:
                    index = 6;
                    break;
                case Constantes.ParametrosBusqueda.Telefonos.NumeroTelefono:
                    index = 7;
                    break;
                default:
                    index = 0;
                    break;
            }
            return index;
        }

        private bool validarInputs(object sender, EventArgs e)
        {
            txtBoxNumeroDocumento_Leave(sender, e);
            txtBoxNombre_Leave(sender, e);
            txtBoxApellido_Leave(sender, e);
            txtBoxCalle_Leave(sender, e);
            txtBoxNumeroDomicilio_Leave(sender, e);
            txtBoxCiudad_Leave(sender, e);
            txtBoxMail_Leave(sender, e);
            txtBoxTelefono_Leave(sender, e);

            return (glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Cuit)]
                & glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Nombre)]
                & glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Apellido)]
                & glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Domicilios.Calle)]
                & glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Domicilios.NumeroDomicilio)]
                & glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Domicilios.Ciudad)]
                & glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Mails.Mail)]
                & glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Telefonos.NumeroTelefono)]);
        }
        private bool validarPedido(object sender, EventArgs e)
        {
            bool lcl_inputs = new bool();
            if (controlador.pedidoActual.lineasPedido.Count == 0)
            {
                MessageBox.Show("No existen líneas en el pedido actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            lcl_inputs = validarInputs(sender, e);
            if (!lcl_inputs)
            {
                MessageBox.Show("Por favor complete todos los campos obligatorios de manera correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lcl_inputs;
        }

        private bool vacioMail()
        {
            if (String.IsNullOrWhiteSpace(this.txtBoxMail.Text))
                return true;
            else
                return false;
        }
        private bool vacioDomicilio()
        {
            if (String.IsNullOrWhiteSpace(this.txtBoxCalle.Text)
                && String.IsNullOrWhiteSpace(this.txtBoxNumeroDomicilio.Text)
                && String.IsNullOrWhiteSpace(this.txtBoxPiso.Text)
                && String.IsNullOrWhiteSpace(this.txtBoxDepartamento.Text)
                && String.IsNullOrWhiteSpace(this.txtBoxCiudad.Text)
                && String.IsNullOrWhiteSpace(this.txtBoxCodigoPostal.Text))
                return true;
            else
                return false;
        }
        private bool vacioTelefono()
        {
            if (String.IsNullOrWhiteSpace(this.txtBoxTelefono.Text))
                return true;
            else
                return false;
        }
        
        
        #endregion

        #region Otros

        private void imprimirpedido()
        {
            Reportes.frmImpresionComprobante lcl_frm_comprobante = new Reportes.frmImpresionComprobante(Properties.Settings.Default.carpetaPedidosClientes, Properties.Settings.Default.carpetaPedidosProveedores);
            lcl_frm_comprobante.estadoAcrobatPDF(false);
            frmLoading lcl_frm_loading = new frmLoading("Espere por favor. Guardando pedido en formato PDF.", "Guardando Comprobante");
            bool exito = false;
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += (s, e) =>
            {
                if (controlador.pedidoActual.codigoTipoPedido == Constantes.CodigosTiposPedidos.Proveedor)
                {
                    //Imprime lote de pedidos a proveedor
                    exito = lcl_frm_comprobante.generarComprobante((controlador as ControladorPedidoProveedor).getPedidosProveedores(controlador.pedidoActual));
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
            if (exito)
            {
                this.MostrarComprobante(lcl_frm_comprobante, new EventArgs());
            }
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

        private void valorNumeroDocumento(object sender, KeyPressEventArgs e)
        {
            // solo 0-9 y borrar 
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
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
        private void cmbBoxPedidosProveedores_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var pedido = (ModeloPedido)cmbBoxPedidosProveedores.SelectedValue;

            this.cargarPedidoEnControles(pedido);
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
            this.cargarPedidoEnControles(this.controlador.pedidoActual);
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
            if (this.cargarControlEnPedido(sender,e) == null)
            {
                return;
            }
            this.imprimirpedido();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.cargarControlEnPedido(sender,e) == null)
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
            if (this.cargarControlEnPedido(sender,e) == null)
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
            }
        }

        private void chckBoxResponsableInscripto_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                //Si es responsable inscripto, sólo se puede usar CUIT para facturación electrónica
                this.cmbBoxTipoDocumento.SelectedValue = glb_lst_tiposDocumentos.SingleOrDefault(x => x.codigo == 80);
                this.cmbBoxTipoDocumento.Enabled = false;
            }
            else
            {
                this.cmbBoxTipoDocumento.Enabled = true;
            }
        }
        #endregion

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
                ModeloLineaPedido lcl_mod_lineaPedidoOriginal = glb_mod_pedidoOriginalDevolucion.getLineaPedido(lcl_mod_lineaPedido.articulo);
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
                this.controlador.pedidoActual.updateLineaPedido(controlador.pedidoActual.lineasPedido[i]);
                this.cargarPedidoEnControles(controlador.pedidoActual);
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
                    controlador.pedidoActual.removeLineaPedido(lp);
                }
                this.cargarPedidoEnControles(controlador.pedidoActual);
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
                lcl_frm_agregarArticulos = new frmPedidoDevolucion(glb_mod_pedidoOriginalDevolucion, pedidoAgregarLineas);
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
            bool respuesta = (Validar.validarInputNoNumerico(txtBoxNumeroDocumento.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Personas.Dni)
                || Validar.validarInputNoNumerico(txtBoxNumeroDocumento.Text.ToString(),Constantes.ParametrosBusqueda.Entidades.Personas.Cuit));
            glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Cuit)] = respuesta;
            if (!respuesta)
            {
                epNumeroDocumento.Icon = Properties.Resources.error;
                epNumeroDocumento.SetError(txtBoxNumeroDocumento, "Numero de Documento no válido");
            }
            else
            {
                epNumeroDocumento.Icon = Properties.Resources.success;
                epNumeroDocumento.SetError(txtBoxNumeroDocumento, "OK");
            }
        }

        private void txtBoxApellido_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxApellido.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Personas.Apellido);
            glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Apellido)] = respuesta;
            if (!respuesta)
            {
                epApellido.Icon = Properties.Resources.error;
                epApellido.SetError(txtBoxApellido, "Apellido no válido");
            }
            else
            {
                epApellido.Icon = Properties.Resources.success;
                epApellido.SetError(txtBoxApellido, "OK");
            }
        }

        private void txtBoxNombre_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxNombre.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Personas.Nombre);
            glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Nombre)] = respuesta;
            if (!respuesta)
            {
                epNombre.Icon = Properties.Resources.error;
                epNombre.SetError(txtBoxNombre, "Nombre no válido");
            }
            else
            {
                epNombre.Icon = Properties.Resources.success;
                epNombre.SetError(txtBoxNombre, "OK");
            }
        }

        private void txtBoxRazonSocial_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxRazonSocial.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Proveedores.RazonSocial);
            if (!respuesta)
            {
                epRazonSocial.Icon = Properties.Resources.error;
                epRazonSocial.SetError(txtBoxRazonSocial, "Razón Social no válida");
            }
            else
            {
                epRazonSocial.Icon = Properties.Resources.success;
                epRazonSocial.SetError(txtBoxRazonSocial, "OK");
            }
        }

        private void txtBoxCalle_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxCalle.Text.ToString(), Constantes.ParametrosBusqueda.Domicilios.Calle);
            glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Domicilios.Calle)] = respuesta;
            if (!respuesta)
            {
                epCalle.Icon = Properties.Resources.error;
                epCalle.SetError(txtBoxCalle, "Calle no válida");
            }
            else
            {
                epCalle.Icon = Properties.Resources.success;
                epCalle.SetError(txtBoxCalle, "OK");
            }
        }

        private void txtBoxNumeroDomicilio_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxNumeroDomicilio.Text.ToString(), Constantes.ParametrosBusqueda.Domicilios.NumeroDomicilio);
            glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Domicilios.NumeroDomicilio)] = respuesta;
            if (!respuesta)
            {
                epNumeroDomicilio.Icon = Properties.Resources.error;
                epNumeroDomicilio.SetError(txtBoxNumeroDomicilio, "Número de Domicilio no válido");
            }
            else
            {
                epNumeroDomicilio.Icon = Properties.Resources.success;
                epNumeroDomicilio.SetError(txtBoxNumeroDomicilio, "OK");
            }
        }

        private void txtBoxPiso_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxPiso.Text.ToString(), Constantes.ParametrosBusqueda.Domicilios.Piso);
            if (!respuesta)
            {
                epPiso.Icon = Properties.Resources.error;
                epPiso.SetError(txtBoxPiso, "Piso no válido");
            }
            else
            {
                epPiso.Icon = Properties.Resources.success;
                epPiso.SetError(txtBoxPiso, "OK");
            }
        }

        private void txtBoxDepartamento_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxDepartamento.Text.ToString(), Constantes.ParametrosBusqueda.Domicilios.Departamento);
            if (!respuesta)
            {
                epDepartamento.Icon = Properties.Resources.error;
                epDepartamento.SetError(txtBoxDepartamento, "Departamento no válido");
            }
            else
            {
                epDepartamento.Icon = Properties.Resources.success;
                epDepartamento.SetError(txtBoxDepartamento, "OK");
            }
        }

        private void txtBoxCiudad_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxCiudad.Text.ToString(), Constantes.ParametrosBusqueda.Domicilios.Ciudad);
            glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Domicilios.Ciudad)] = respuesta;
            if (!respuesta)
            {
                epCiudad.Icon = Properties.Resources.error;
                epCiudad.SetError(txtBoxCiudad, "Ciudad no válida");
            }
            else
            {
                epCiudad.Icon = Properties.Resources.success;
                epCiudad.SetError(txtBoxCiudad, "OK");
            }
        }

        private void txtBoxCodigoPostal_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxCodigoPostal.Text.ToString(), Constantes.ParametrosBusqueda.Domicilios.CodigoPostal);
            if (!respuesta)
            {
                epCodigoPostal.Icon = Properties.Resources.error;
                epCodigoPostal.SetError(txtBoxCodigoPostal, "Código Postal no válido");
            }
            else
            {
                epCodigoPostal.Icon = Properties.Resources.success;
                epCodigoPostal.SetError(txtBoxCodigoPostal, "OK");
            }
        }

        private void txtBoxMail_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxMail.Text.ToString(), Constantes.ParametrosBusqueda.Mails.Mail);
            glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Mails.Mail)] = respuesta;
            if (!respuesta)
            {
                epMail.Icon = Properties.Resources.error;
                epMail.SetError(txtBoxMail, "Mail no válido");
            }
            else
            {
                epMail.Icon = Properties.Resources.success;
                epMail.SetError(txtBoxMail, "OK");
            }
        }

        private void txtBoxTelefono_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxTelefono.Text.ToString(), Constantes.ParametrosBusqueda.Telefonos.NumeroTelefono);
            glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Telefonos.NumeroTelefono)] = respuesta;
            if (!respuesta)
            {
                epNumeroTelefono.Icon = Properties.Resources.error;
                epNumeroTelefono.SetError(txtBoxTelefono, "Mail no válido");
            }
            else
            {
                epNumeroTelefono.Icon = Properties.Resources.success;
                epNumeroTelefono.SetError(txtBoxTelefono, "OK");
            }
        }

        private void txtBoxIVAPorcentaje_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxIVAPorcentaje.Text.ToString(), Constantes.Numericos.Porcentual);
            if (!respuesta)
            {
                epIvaPorcentaje.Icon = Properties.Resources.error;
                epIvaPorcentaje.SetError(txtBoxIVAPorcentaje, "Porcentaje no válido");
            }
            else
            {
                epIvaPorcentaje.Icon = Properties.Resources.success;
                epIvaPorcentaje.SetError(txtBoxIVAPorcentaje, "OK");
            }
        }

        private void txtBoxIVAMonto_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxIVAMonto.Text.ToString(), Constantes.Numericos.EnteroPositivo);
            if (!respuesta)
            {
                epIvaMonto.Icon = Properties.Resources.error;
                epIvaMonto.SetError(txtBoxIVAMonto, "Monto no válido");
            }
            else
            {
                epIvaMonto.Icon = Properties.Resources.success;
                epIvaMonto.SetError(txtBoxIVAMonto, "OK");
            }
        }
        #endregion

        
    }
}
