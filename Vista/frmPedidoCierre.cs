using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Controladores;
using Reportes;
using LibreriaClasesCompartidas;

namespace Vista
{
    public partial class frmPedidoCierre : Form
    {
        #region Atributos
       
        List<TipoDocumento> glb_lst_tiposDocumentos;
        ControladorPedido controlador;
        CheckBox chckBoxClienteGenerico;
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
                        this.Text = "Cierre Pedido de Cliente";
                        break;
                    case ModoFormularioDevolucionCliente:
                        this.inicializarControlesCliente();
                        this.Text = "Devolución de Artículos Cliente";
                        break;
                    case ModoFormularioPedidoProveedor:
                        this.inicializarControlesProveedor();
                        this.Text = "Cierre Pedido a Proveedores";
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
            this.StartPosition = FormStartPosition.CenterScreen;
            this.inicializarControles();
        }
        /// <summary>
        /// Inicializa formulario de acuerdo al codigoTipoPedido asignado al pedido
        /// </summary>
        /// <param name="p_mod_pedido"></param>
        public frmPedidoCierre(ModeloPedido p_mod_pedido) : this()
        {
            switch (p_mod_pedido.codigoTipoPedido)
            {
                case LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.TipoPedidoPersona:
                    this.inicializarCierrePedidoCliente(p_mod_pedido);
                    break;
                case LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.TipoPedidoProveedor: 
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
            this.modoFormulario = p_modoFormulario;
            switch (p_modoFormulario)
            {
                case ModoFormularioPedidoCliente:
                    p_mod_pedido.codigoTipoPedido = LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.TipoPedidoPersona;
                    this.inicializarCierrePedidoCliente(p_mod_pedido);
                    break;
                case ModoFormularioDevolucionCliente:
                    p_mod_pedido.codigoTipoPedido = LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.TipoPedidoPersona;
                    this.inicializarDevolucionPedidoCliente(p_mod_pedido);
                    break;
                case ModoFormularioPedidoProveedor:
                    p_mod_pedido.codigoTipoPedido = LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.TipoPedidoProveedor;
                    this.inicializarCierrePedidosProveedores(p_mod_pedido);
                    break;
                default :
                    MessageBox.Show("Error al iniciar ventana.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    break;
            }
        }
        #endregion

        #region Métodos
        
        #region Inicialización
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
            List<ModeloPedido> lcl_lst_mod_pedidos = (controlador as ControladorPedidoProveedor).getPedidosProveedores(p_mod_pedido);
            this.inicializarComboBoxPedidosProveedores(lcl_lst_mod_pedidos);
            
            this.cargarPedidoEnControles(lcl_lst_mod_pedidos[0]);
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

            chckBoxClienteGenerico = new CheckBox();
            chckBoxClienteGenerico.Anchor = AnchorStyles.Left;
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
        }
        private void inicializarComboBoxPedidosProveedores(List<ModeloPedido> p_mod_pedidos)
        {
            var dataSource = new List<ComboBoxItem>();
            for (int i = 0; i < p_mod_pedidos.Count; i++)
            {
                dataSource.Add(new ComboBoxItem()
                {
                    Name = "Pedido a " + (p_mod_pedidos[i].entidad as ModeloProveedor).razonSocial +
                        " (" + (i + 1).ToString() + " de " + p_mod_pedidos.Count.ToString() + ")",
                    Value = p_mod_pedidos[i]
                });
                //dataSource.Add(new ComboBoxItem() { Name = "Pedido "+(i+1).ToString()+" de "+lcl_lst_pedidosProveedor.Count.ToString(), Value = lcl_lst_pedidosProveedor[i] });
            }
            this.cmbBoxPedidosProveedores.DataSource = dataSource;
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

            this.txtBoxDescuento1Porcentaje.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"),"{0:P1}", (p_mod_pedido.descuento_1.porcentajeSobreTotal));
            this.txtBoxDescuento1Monto.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", p_mod_pedido.descuento_1.descuento);
            this.txtBoxDescuento2Porcentaje.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:P1}", (p_mod_pedido.descuento_2.porcentajeSobreTotal));
            this.txtBoxDescuento2Monto.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", p_mod_pedido.descuento_2.descuento);
            this.txtBoxDescuentoLineas.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", p_mod_pedido.getDescuentoLineas());
            this.txtBoxDescuentoTotal.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", p_mod_pedido.getDescuentoTotal());
            
            this.txtBoxTotal.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", p_mod_pedido.getTotal());
            this.txtBoxSubtotal.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", p_mod_pedido.getSubTotal());

            this.txtBoxIVAMonto.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", p_mod_pedido.getIVAMonto()); 
        }
        private void cargarEntidadEnControles(ModeloEntidad p_mod_entidad)
        {
            #region Documento
            if (!string.IsNullOrWhiteSpace(p_mod_entidad.cuit))
            {
                this.cmbBoxTipoDocumento.SelectedValue = this.glb_lst_tiposDocumentos.SingleOrDefault(x => x.codigo == 80);
                this.txtBoxNumeroDocumento.Text = p_mod_entidad.cuit;
            }
            #endregion

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
            if(string.IsNullOrWhiteSpace(p_mod_cliente.cuit) && !string.IsNullOrWhiteSpace(p_mod_cliente.dni))
            {
                this.cmbBoxTipoDocumento.SelectedValue = this.glb_lst_tiposDocumentos.SingleOrDefault(x => x.codigo == 96);
                this.txtBoxNumeroDocumento.Text = p_mod_cliente.dni;
            }
        }
        private void cargarProveedorEnControles(ModeloProveedor p_mod_proveedor)
        {
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
                row["valorParcialSinDescuento"] = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", l.getValorParcialSinDescuentos());
                row["valorParcialConDescuento"] = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", l.getValorParcial());
                
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
        private ModeloPedido cargarControlEnPedido()
        {
            if (!this.validarPedido())
            {
                return null;
            }
            //incluido todo lo monetario en controlador.pedidoActual, entidad si es pedido a proveedor,
            //y forma(s) de pago
            ModeloPedido lcl_mod_pedido = controlador.pedidoActual;
            if (lcl_mod_pedido.codigoTipoPedido == Constantes.CodigosTiposPedidos.TipoPedidoPersona)
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
                tipoComprobante = 0;
            }
            return tipoComprobante;
        }
        #endregion

        #region Validaciones
        private bool validarPedido()
        {
            if (controlador.pedidoActual.lineasPedido.Count == 0)
            {
                MessageBox.Show("No existen líneas en el pedido actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return this.validarDocumento() && this.validarTelefono() && this.validarDomicilio() && this.validarMail();
        }

        private bool validarMail()
        {
            if (!this.vacioMail())
            {
                if (!ModeloMail.validarMail(this.txtBoxMail.Text))
                {
                    MessageBox.Show("La dirección de mail ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        private bool validarDomicilio()
        {
            if (!this.vacioDomicilio())
            {
                if (!ModeloDomicilio.validarCalle(txtBoxCalle.Text))
                {
                    MessageBox.Show("Revise el campo calle del domicilio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        private bool validarTelefono()
        {
            if (!this.vacioTelefono())
            {
                if (!ModeloTelefono.validarNumero(this.txtBoxTelefono.Text))
                {
                    MessageBox.Show("El número de teléfono ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (!ModeloTelefono.validarTipo(this.cmbBoxTipoTelefono.SelectedValue.ToString()))
                {
                    MessageBox.Show("Debe seleccionar un tipo de teléfono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
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
        private bool validarDocumento()
        {
            if(this.cmbBoxTipoDocumento.SelectedValue == this.glb_lst_tiposDocumentos.SingleOrDefault(x => x.codigo == 80))
            {
                //Validamos CUIT en caso de seleccionado como opción de documento
                if(!ModeloEntidad.CUIT.ValidarCuit(this.txtBoxNumeroDocumento.Text))
                {
                    MessageBox.Show("CUIT no válido");
                    return false;
                }
            }
            return true;
        }
        
        #endregion

        #region Otros
        private ModeloCliente buscarCliente()
        {
            ModeloCliente lcl_mod_cliente = new ModeloCliente();
            frmABMEntidad lcl_frm_entidad = new frmABMEntidad(controlador.pedidoActual.entidad,frmABMEntidad.ModoFormularioClientePedido);
            lcl_frm_entidad.ShowDialog();
            return lcl_frm_entidad.glb_mod_entidadActual as ModeloCliente;
        }

        int getDropDownWidth(ComboBox p_comboBox)
        {
            int maxWidth = 0, temp = 0;
            foreach (var obj in p_comboBox.Items)
            {
                temp = TextRenderer.MeasureText(obj.ToString(), p_comboBox.Font).Width;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            return maxWidth;
        }

        private bool imprimirPedido()
        {            
            Controladores.ControladorReportes lcl_con_reporte = new ControladorReportes();
            lcl_con_reporte.ImpresionFacturas(controlador.pedidoActual).ShowDialog();
            
            return true;
        }

        private bool guardarPedido()
        {
            DialogResult dialogResult = new DialogResult();  
            do
            {
                if (!controlador.guardarPedido())
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
        #endregion

        #endregion

        #region Eventos

        #region TextBox
        private void txtBoxDescuento1Porcentaje_Leave(object sender, EventArgs e)
        {
            //para evento MouseUp
            alreadyFocused = false;
            //
            double porcentaje;
            if (!Double.TryParse(this.txtBoxDescuento1Porcentaje.Text.Replace("%", "").Replace(".", ","), out porcentaje) || (porcentaje / 100)==controlador.pedidoActual.descuento_1.porcentajeSobreTotal)
            {
                this.txtBoxDescuento1Porcentaje.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:P1}", (controlador.pedidoActual.descuento_1.porcentajeSobreTotal));
                return;
            }
            porcentaje = porcentaje / 100;

            ModeloDescuento lcl_mod_descuento = new ModeloDescuento();
            lcl_mod_descuento.porcentajeSobreTotal = porcentaje;
            controlador.pedidoActual.descuento_1 = lcl_mod_descuento;
            this.cargarDatosMonetariosEnControles(controlador.pedidoActual);
        }

        private void txtBoxDescuento1Monto_Leave(object sender, EventArgs e)
        {
            //para evento MouseUp
            alreadyFocused = false;
            //
            decimal descuento;
            if (!Decimal.TryParse(this.txtBoxDescuento1Monto.Text, out descuento) || descuento == controlador.pedidoActual.descuento_1.descuento)
            {
                this.txtBoxDescuento1Monto.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", controlador.pedidoActual.descuento_1.descuento);
                return;
            }

            ModeloDescuento lcl_mod_descuento = new ModeloDescuento();
            lcl_mod_descuento.descuento = descuento;
            controlador.pedidoActual.descuento_1 = lcl_mod_descuento;
            this.cargarDatosMonetariosEnControles(controlador.pedidoActual);
        }

        private void txtBoxDescuento2Porcentaje_Leave(object sender, EventArgs e)
        {
            //para evento MouseUp
            alreadyFocused = false;
            //
            double porcentaje;
            if (!Double.TryParse(this.txtBoxDescuento2Porcentaje.Text.Replace("%", "").Replace(".", ","), out porcentaje) || (porcentaje / 100)== controlador.pedidoActual.descuento_2.porcentajeSobreTotal )
            {
                this.txtBoxDescuento2Porcentaje.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:P1}", (controlador.pedidoActual.descuento_2.porcentajeSobreTotal));
                return;
            }
            porcentaje = porcentaje / 100;

            ModeloDescuento lcl_mod_descuento = new ModeloDescuento();
            lcl_mod_descuento.porcentajeSobreTotal = porcentaje;
            controlador.pedidoActual.descuento_2 = lcl_mod_descuento;
            this.cargarDatosMonetariosEnControles(controlador.pedidoActual);
        }

        private void txtBoxDescuento2Monto_Leave(object sender, EventArgs e)
        {
            //para evento MouseUp
            alreadyFocused = false;
            //
            decimal descuento;
            if (!Decimal.TryParse(this.txtBoxDescuento2Monto.Text.Replace("$", ""), out descuento) || descuento == controlador.pedidoActual.descuento_2.descuento)
            {
                this.txtBoxDescuento2Monto.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", controlador.pedidoActual.descuento_2.descuento);
                return;
            }
            
            ModeloDescuento lcl_mod_descuento = new ModeloDescuento();
            lcl_mod_descuento.descuento = descuento;
            controlador.pedidoActual.descuento_2 = lcl_mod_descuento;
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
            if (this.getCodigoTipoComprobante() != 0)
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

            if (this.imprimirPedido())
            {
                MessageBox.Show("Operación exitosa", "Éxito", MessageBoxButtons.OK);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.cargarControlEnPedido() == null)
            {
                return;
            }
            this.guardarPedido();
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
                ModeloCliente lcl_mod_cliente = this.buscarCliente();
                if (ControladorPedidoCliente.esClienteGenerico(lcl_mod_cliente))
                {
                    this.chckBoxClienteGenerico.Checked = true;
                }
                else
                {
                    controlador.pedidoActual.entidad = lcl_mod_cliente;
                    this.cargarEntidadEnControles(controlador.pedidoActual.entidad as ModeloCliente);
                }
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
            frmPedidoCierre_EditarLineaPedido lcl_frm_editarLineaPedido = new frmPedidoCierre_EditarLineaPedido(lcl_mod_lineaPedido, controlador.pedidoActual.codigoTipoPedido);
            lcl_frm_editarLineaPedido.ShowDialog();
            if (lcl_frm_editarLineaPedido.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                controlador.pedidoActual.lineasPedido[i] = lcl_frm_editarLineaPedido.getLineaPedido();
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

        /// <summary>
        /// Muestra ventana para agregar artículos al pedido actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void evento_agregarLinea(object sender, EventArgs e)
        {
            ModeloPedido lcl_mod_pedido = ObjectCopier.Clone(controlador.pedidoActual);
            frmPedidoNuevo frm_pedidoNuevo = new frmPedidoNuevo(lcl_mod_pedido);
            frm_pedidoNuevo.ShowDialog();
            if (frm_pedidoNuevo.DialogResult != System.Windows.Forms.DialogResult.Ignore)
            {
                controlador.pedidoActual = lcl_mod_pedido;
                this.cargarPedidoEnControles(controlador.pedidoActual);
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
            
            frmABMArticuloProveedor lcl_frm_articuloProveedor = new frmABMArticuloProveedor(controlador.pedidoActual.lineasPedido[i].articulo,frmABMArticuloProveedor.ModoFormularioVisualizarEntidad);
            lcl_frm_articuloProveedor.ShowDialog();
        }
        #endregion

        #endregion
    }
}
