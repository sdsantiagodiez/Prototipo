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
using LibreriaClasesCompartidas;

namespace Vista
{
    public partial class frmPedidoCierre : Form
    {
        ControladorPedido controlador;
        CheckBox chckBoxClienteGenerico;
        #region Constructores
        public frmPedidoCierre()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.inicializarTextBoxes();
        }

        public frmPedidoCierre(ModeloPedido p_mod_pedido) : this()
        {
            this.inicializarComboBox();
            switch (p_mod_pedido.codigoTipoPedido)
            {
                case LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.TipoPedidoPersona:
                    this.inicializarCierrePedidoCliente(p_mod_pedido);
                    break;
                case LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.TipoPedidoProveedor:
                    this.inicializarCierrePedidosProveedores(p_mod_pedido);
                    break;
            }
        }
        #endregion

        #region Métodos
        #region Inicialización
        private void inicializarCierrePedidoCliente(ModeloPedido p_mod_pedido)
        {
            this.Text = "Cierre Pedido de Cliente";
            this.cmbBoxPedidosProveedores.Visible = false;
            this.controlador = new ControladorPedidoCliente();
            this.inicializarControlesCliente();
            this.cargarPedidoEnControles(p_mod_pedido);
        }

        private void inicializarCierrePedidosProveedores(ModeloPedido p_mod_pedido)
        {
            this.Text = "Cierre Pedido a Proveedores";
            this.cmbBoxPedidosProveedores.Visible = true;
            this.controlador = new ControladorPedidoProveedor();
            List<ModeloPedido> lcl_lst_mod_pedidos = (controlador as ControladorPedidoProveedor).getPedidosProveedores(p_mod_pedido);
            this.inicializarComboBoxPedidosProveedores(lcl_lst_mod_pedidos);
            this.cargarPedidoEnControles(lcl_lst_mod_pedidos[0]);
            this.inicializarControlesProveedor(lcl_lst_mod_pedidos[0].entidad as ModeloProveedor);
        }
        
        private void inicializarTextBoxes()
        {
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
            //Populo combobox de paises
            List<ModeloPais> lcl_lst_mod_paises = ControladorBusqueda.getPaises();
            this.cmbBoxPais.DataSource = lcl_lst_mod_paises.OrderBy(i => i.pais).ToList();
            this.cmbBoxPais.DropDownWidth = this.getDropDownWidth(this.cmbBoxPais);
            this.cmbBoxPais.DisplayMember = "pais";
            this.cmbBoxPais.ValueMember = "codigo";
            this.cmbBoxPais.SelectedValue = "AR";

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

            //Populo combobox de provincias
            this.asignarProvincias();
            //this.cmbBoxProvincia.SelectedItem = null;

            this.cmbBoxProvincia.DisplayMember =
                this.cmbBoxTipoTelefono.DisplayMember =
                this.cmbBoxDomicilios.DisplayMember = 
                this.cmbBoxTelefonos.DisplayMember = 
                this.cmbBoxMails.DisplayMember = "Name";
            
            this.cmbBoxProvincia.ValueMember = 
                this.cmbBoxTipoTelefono.ValueMember = 
                this.cmbBoxDomicilios.ValueMember = 
                this.cmbBoxTelefonos.ValueMember = 
                this.cmbBoxMails.ValueMember = "Value";
            //Lo hago read only
            this.cmbBoxProvincia.DropDownStyle = 
                this.cmbBoxPais.DropDownStyle = 
                this.cmbBoxTipoTelefono.DropDownStyle = 
                this.cmbBoxDomicilios.DropDownStyle = 
                this.cmbBoxTelefonos.DropDownStyle = 
                this.cmbBoxMails.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void inicializarControlesCliente()
        {
            chckBoxClienteGenerico = new CheckBox();
            chckBoxClienteGenerico.Anchor = AnchorStyles.Left;
            chckBoxClienteGenerico.Text = "Cliente Genérico";
            chckBoxClienteGenerico.CheckedChanged += clienteGenerico_CheckedChanged;
            this.tblLayoutPanelEntidadDatos.Controls.Add(chckBoxClienteGenerico, 1, 4);

            this.cmbBoxTipoComprobante.FormattingEnabled = true;
            this.cmbBoxTipoComprobante.Format += delegate(object sender, ListControlConvertEventArgs e)
            {
                e.Value = Constantes.GetDescription<Constantes.TipoComprobanteVenta>((Constantes.TipoComprobanteVenta)e.Value);
            };

            this.cmbBoxTipoComprobante.DataSource = Enum.GetValues(typeof(Constantes.TipoComprobanteVenta));
        }
        private void inicializarControlesProveedor(ModeloProveedor p_mod_proveedor)
        {
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
        
        private void asignarProvincias()
        {
            ModeloProvincia lcl_mod_provincia = new ModeloProvincia();
            //Inserto codigoPais del país seleccionado en el comboBox
            lcl_mod_provincia.codigoPais = this.cmbBoxPais.SelectedValue.ToString();
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

            this.txtBoxSubtotal.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", p_mod_pedido.montoSubTotal);
            //this.txtBoxTotal.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:#,##0.00}", p_mod_pedido.getTotal());
            this.txtBoxTotal.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", p_mod_pedido.montoTotal);

            this.txtBoxIVAMonto.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", p_mod_pedido.alicuota.monto); 
        }
        private void cargarEntidadEnControles(ModeloEntidad p_mod_entidad)
        {
            this.txtBoxCUIT.Text = p_mod_entidad.cuit;
            if(p_mod_entidad.GetType() == typeof(ModeloProveedor))
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

            #endregion
        }
        private void cargarClienteEnControles(ModeloCliente p_mod_cliente)
        {
            this.txtBoxApellido.Text = p_mod_cliente.apellido;
            this.txtBoxNombre.Text = p_mod_cliente.nombre;
            this.txtBoxDNI.Text = p_mod_cliente.dni;
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
            this.cmbBoxPais.SelectedValue = p_mod_domicilio.pais.codigo;

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
            //this.cmbBoxProvincia.SelectedItem = null;
        }
        #endregion
        
        #region Controles -> Modelo
        private ModeloPedido cargarControlEnPedido()
        {
            //incluido todo lo monetario en controlador.pedidoActual, entidad si es pedido a proveedor,
            //y forma(s) de pago
            ModeloPedido lcl_mod_pedido = controlador.pedidoActual;
            if (lcl_mod_pedido.codigoTipoPedido == Constantes.CodigosTiposPedidos.TipoPedidoPersona)
            {
                lcl_mod_pedido.entidad = this.cargarControlEnCliente();
                //el proveedor ya esta en el pedido
            }
            if (lcl_mod_pedido.codigoTipoPedido == Constantes.CodigosTiposPedidos.TipoPedidoProveedor)
            {
                
            }

            lcl_mod_pedido.domicilioDeFacturacion = this.cargarControlEnDomicilio();
            lcl_mod_pedido.mailContacto = this.cargarControlEnMail();
            lcl_mod_pedido.telefonoContacto = this.cargarControlEnTelefono();
            lcl_mod_pedido.observaciones = this.rchTextBoxObservacionesPedido.Text;

            return lcl_mod_pedido;
        }
        private ModeloEntidad cargarControlEnCliente()
        {
            ModeloEntidad lcl_mod_entidad = new ModeloCliente();

            return lcl_mod_entidad;
        }
        private ModeloContactoProveedor cargarControlEnContactoProveedor()
        {
            return (ModeloContactoProveedor)this.cmbBoxContactoProveedor.SelectedValue;
        }
        private ModeloDomicilio cargarControlEnDomicilio()
        {
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
            ModeloTelefono lcl_mod_telefono = new ModeloTelefono();
            lcl_mod_telefono.numero = this.txtBoxTelefono.Text; ;
            lcl_mod_telefono.tipo = this.cmbBoxTipoTelefono.SelectedValue.ToString();
            return lcl_mod_telefono;
        }
        private ModeloMail cargarControlEnMail()
        {
            ModeloMail lcl_mod_mail = new ModeloMail();
            lcl_mod_mail.mail = this.txtBoxMail.Text;
            return lcl_mod_mail;
        }
        #endregion
        
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
        #endregion

        #region Button
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(this.dgvArticulosVenta.CurrentRow == null)
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
                this.cargarPedidoEnControles(controlador.pedidoActual);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvArticulosVenta.CurrentRow == null)
            {
                MessageBox.Show("No hay línea de pedido seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int i = Convert.ToInt32(this.dgvArticulosVenta.CurrentRow.Cells["indice"].Value);
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea eliminar la línea correspondiente al artículo " +
                controlador.pedidoActual.lineasPedido[i].articulo.codigoArticuloProveedor + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                controlador.pedidoActual.removeLineaPedido(controlador.pedidoActual.lineasPedido[i]);
                this.cargarPedidoEnControles(controlador.pedidoActual);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (controlador.pedidoActual.lineasPedido.Count == 0)
            {
                MessageBox.Show("No existen líneas en el pedido actual para imprimir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Además de imprimir, ¿desea también guardar el pedido?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                //guardar
            }

            //imprimir
        }

        #endregion

        #region CheckedBox
        private void clienteGenerico_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                //hacer pertinente a cliente genérico
            }
        }
        #endregion

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
                controlador.pedidoActual.addFormaPago(new FormaPago() { forma = lcl_formaDePago, restante = true});
            }
            this.cargarPedidoEnControles(this.controlador.pedidoActual);
        }
        #endregion
    }
}
