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

        #region Constructores
        public frmPedidoCierre()
        {
            InitializeComponent();
            this.inicializarTextBoxes();
            //?this.dgvArticulosVenta.AutoGenerateColumns = false;
            this.dgvArticulosVenta.AutoGenerateColumns = false;
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
            this.cmbBoxPedidosProveedores.Visible = false;
            this.controlador = new ControladorPedidoCliente();
            this.cargarPedidoEnControles(p_mod_pedido);
        }

        private void inicializarCierrePedidosProveedores(ModeloPedido p_mod_pedido)
        {
            this.cmbBoxPedidosProveedores.Visible = true;
            this.controlador = new ControladorPedidoProveedor();
            List<ModeloPedido> lcl_lst_mod_pedidos = (controlador as ControladorPedidoProveedor).getPedidosProveedores(p_mod_pedido);
            this.inicializarComboBoxPedidosProveedores(lcl_lst_mod_pedidos);
            this.cargarPedidoEnControles(lcl_lst_mod_pedidos[0]);
        }
        
        private void inicializarTextBoxes()
        {
            txtBoxDescuentoPorcentualMonto.Enabled =
            txtBoxDescuentoNetoPorcentaje.Enabled =
            txtBoxDescuentoLineas.Enabled =
            txtBoxDescuentoTotal.Enabled =
            txtBoxIVAMonto.Enabled =
            txtBoxTotal.Enabled =
            txtBoxSubtotal.Enabled = false;
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
            this.cargarDatosProvinciasEnCmbBoxProvincia(provincias);
        }
        #endregion
        #region Modelo -> Controles
        private void cargarPedidoEnControles(ModeloPedido p_mod_pedido)
        {            
            this.cargarDatosPedidoEnControles(p_mod_pedido);
            this.cargarLineasEnControles(p_mod_pedido);
            this.cargarEntidadEnControles(p_mod_pedido.entidad);
            
            this.cargarDomicilioEnControles(p_mod_pedido.domicilioDeFacturacion);
            this.cargarTelefonoEnControles(p_mod_pedido.telefonoContacto);
            this.cargarMailEnControles(p_mod_pedido.mailContacto);
        }

        private void cargarDatosPedidoEnControles(ModeloPedido p_mod_pedido)
        {
            this.txtBoxNumeroPedido.Text = p_mod_pedido.numeroPedido != 0 ? p_mod_pedido.numeroPedido.ToString() : "";
            //Puede haber más de 1 forma de pago. 40% en contado y 60% en tarjeta, por ejemplo
            //this.cmbBoxFormaPago.SelectedValue = p_mod_pedido.formasDePago!= null? p_mod_pedido.formasDePago[0]: Constantes.FormaDePago.Contado;
            //this.cmbBoxTipoComprobante.SelectedValue = 
            this.dtpFechaPedido.Value = p_mod_pedido.fecha;
            
            this.txtBoxIVAPorcentaje.Text = p_mod_pedido.iva.ToString();
            this.cargarDatosMonetariosEnControles(p_mod_pedido);

            this.rchTextBoxObservacionesPedido.Text = p_mod_pedido.observaciones;
        }
        private void cargarDatosMonetariosEnControles(ModeloPedido p_mod_pedido)
        {
            this.txtBoxSenia.Text = p_mod_pedido.senia.ToString();
            this.txtBoxDescuentoPorcentualPorcentaje.Text = (p_mod_pedido.descuentoPorcentual.descuento * 100).ToString();
            //this.txtBoxDescuentoPorcentualMonto.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:#,##0.00}", ); 
            //this.txtBoxDescuentoNetoPorcentaje.Text = ;
            this.txtBoxDescuentoNetoMonto.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:#,##0.00}", p_mod_pedido.descuentoNeto.descuento); 
            this.txtBoxDescuentoLineas.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:#,##0.00}", p_mod_pedido.getDescuentoLineas());
            this.txtBoxDescuentoTotal.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:#,##0.00}", p_mod_pedido.getDescuentoTotal());
            this.txtBoxSubtotal.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:#,##0.00}", p_mod_pedido.getSubTotal());
            this.txtBoxTotal.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:#,##0.00}", p_mod_pedido.getTotal());

            this.txtBoxIVAMonto.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:#,##0.00}", p_mod_pedido.getIVAMonto()); 
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
                dataSource.Add(new ComboBoxItem() { Name = ModeloDomicilio.getValorNormalizado(domicilio), Value = domicilio});
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
                dataSource.Add(new ComboBoxItem() { Name = ModeloTelefono.getValorNormalizado(telefono), Value = telefono});
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
            lineas.Columns.Add("codigoOriginal");
            lineas.Columns.Add("codigoArticuloProveedor");
            lineas.Columns.Add("descripcion");
            lineas.Columns.Add("cantidad");
            lineas.Columns.Add("valorUnitario");
            lineas.Columns.Add("descuento");
            lineas.Columns.Add("valorParcial");

            foreach (ModeloLineaPedido l in p_mod_pedido.lineasPedido)
            {
                var row = lineas.NewRow();
                row["codigoOriginal"] = l.articulo.codigoOriginal;
                row["codigoArticuloProveedor"] = l.articulo.codigoArticuloProveedor;
                row["descripcion"] = l.articulo.descripcion;
                row["cantidad"] = l.cantidadArticulos;
                row["valorUnitario"] = l.valorUnitario;
                row["descuento"] = l.getDescuento();
                row["valorParcial"] = l.getValorParcial();
          
                lineas.Rows.Add(row);
            }

            this.dgvArticulosVenta.DataSource = lineas;
        }

        private void cargarDatosProvinciasEnCmbBoxProvincia(List<ModeloProvincia> p_lst_mod_provincias)
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

        private void cmbBoxPedidosProveedores_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var pedido = (ModeloPedido)cmbBoxPedidosProveedores.SelectedValue;
            this.cargarPedidoEnControles(pedido);
        }
    }
}
