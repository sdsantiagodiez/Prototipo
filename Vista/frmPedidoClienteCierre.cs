using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Controladores;
using LibreriaClasesCompartidas;
using Reportes;

namespace Vista
{
    public partial class frmPedidoClienteCierre : Form
    {
        #region Atributos
        public bool glb_emitido = false;
        private ControladorPedido glb_con_procesarPedido;
        private FormReportes glb_frm_FormReportes;
        private ControladorReportes glb_con_Reportes;
        #endregion

        #region Constructores
        public frmPedidoClienteCierre()
        {
            InitializeComponent();
            this.inicializarComboBox();
            this.dgvArticulosVenta.AutoGenerateColumns = false;
        }
        public frmPedidoClienteCierre(ControladorPedido p_controladorProcesarPedido) : this()
        {
            //Guardo el controlador de venta
            this.glb_con_procesarPedido = p_controladorProcesarPedido;
            this.inicializarDataGridView();
            
            if (p_controladorProcesarPedido.tipoPedido == Constantes.CodigosTiposPedidos.TipoPedidoProveedor)
            {
                this.inicializarPedidoProveedor();
            }
            else if (p_controladorProcesarPedido.tipoPedido == Constantes.CodigosTiposPedidos.TipoPedidoPersona)
            {
                this.inicializarPedidoCliente();
            }
        }
        #endregion

        #region Métodos
        
        #region Inicialización
        private void inicializarComboBox()
        {
            //Populo combobox de paises
            List<ModeloPais> lcl_lst_mod_paises = ControladorBusqueda.getPaises();
            this.cbxPais.DataSource = lcl_lst_mod_paises.OrderBy(i => i.pais).ToList();
            this.cbxPais.DropDownWidth = this.getDropDownWidth(this.cbxPais);
            this.cbxPais.DisplayMember = "pais";
            this.cbxPais.ValueMember = "codigo";
            this.cbxPais.SelectedValue  = "AR";

            //Lo hago read only
            this.cbxPais.DropDownStyle = ComboBoxStyle.DropDownList;

            //Populo combobox de provincias
            this.asignarProvincias();
            this.cbxProvincia.DisplayMember = "provincia";
            this.cbxProvincia.ValueMember = "codigo";
            this.cbxProvincia.SelectedItem = null;

            //Lo hago read only
            this.cbxProvincia.DropDownStyle = ComboBoxStyle.DropDownList;

            //Creo lista Tipos de teléfono
            var dataSource = new List<Tel>();
            dataSource.Add(new Tel() { Name = "Fijo", Value = Constantes.TipoTelefono.Fijo });
            dataSource.Add(new Tel() { Name = "Celular", Value = Constantes.TipoTelefono.Celular });
            dataSource.Add(new Tel() { Name = "Fax", Value = Constantes.TipoTelefono.Fax });
            dataSource.Add(new Tel() { Name = "Sin Teléfono", Value = null });

            //Binding de telefonos
            this.cbxTipoTelefono.DataSource = dataSource;
            this.cbxTipoTelefono.DisplayMember = "Name";
            this.cbxTipoTelefono.ValueMember = "Value";

            //Lo hago read only
            this.cbxTipoTelefono.DropDownStyle = ComboBoxStyle.DropDownList;

            this.cbxFormaPago.DataSource = Enum.GetValues(typeof(Constantes.FormaDePago));
        }
        private void inicializarPedidoProveedor()
        {
            //muy básico
            this.cbxTipoComprobante.DataSource = Enum.GetValues(typeof(Constantes.TipoComprobanteCompra));
        }
        private void inicializarPedidoCliente()
        {
            //muy básico
            this.cbxTipoComprobante.DataSource = Enum.GetValues(typeof(Constantes.TipoComprobanteVenta));
            
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
        private void inicializarDataGridView()
        {
            //busco la venta actual y la bindeo a dgv
            var lcl_bindingList = new BindingList<ModeloLineaPedido>(glb_con_procesarPedido.pedidoActual.lineasPedido);
            var lcl_source = new BindingSource(lcl_bindingList, null);
            this.dgvArticulosVenta.DataSource = lcl_source;   
        }
        private void asignarProvincias()
        {
            ModeloProvincia lcl_mod_provincia = new ModeloProvincia();
            //Inserto codigoPais del país seleccionado en el comboBox
            lcl_mod_provincia.codigoPais = this.cbxPais.SelectedValue.ToString();
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

        #region Búsqueda
        private void txtBusqCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TODO -> Validar cadena de entrada

            if (e.KeyChar == (char)Keys.Enter)
            {
                //busco al cliente de la base de datos
                glb_con_procesarPedido.buscarCliente(txtBusqCli.Text);

                var lcl_mod_entidad = glb_con_procesarPedido.entidadActual;

                // reporto resultado
                if (!object.Equals(lcl_mod_entidad, null))
                {
                    //limpio campo de búsqueda
                    this.txtBusqCli.Text = "";

                    //oculto checkbox registrar cliente;
                    this.ckbxRegistrar.Visible = false;

                    //muestro botonera de seleccion
                    this.pnlSelectButtons.Visible = true;

                    //lleno textboxs
                    int lcl_latest;
                    this.txtNombre.Text = (lcl_mod_entidad as ModeloCliente ).nombre;
                    this.txtApellido.Text = (lcl_mod_entidad as ModeloCliente).apellido;
                    this.txtDni.Text = (lcl_mod_entidad as ModeloCliente).dni;
                    this.rtbObsCliente.Text = lcl_mod_entidad.observaciones;

                    lcl_latest = lcl_mod_entidad.telefonos.Count;
                    if (lcl_latest > 0)
                    {
                        lcl_latest--;
                        this.txtTelefono.Text = lcl_mod_entidad.telefonos[lcl_latest].numero;
                        switch (lcl_mod_entidad.telefonos[lcl_latest].tipo)
                        {
                            case Constantes.TipoTelefono.Fijo: this.cbxTipoTelefono.SelectedIndex = 0; break;
                            case Constantes.TipoTelefono.Celular: this.cbxTipoTelefono.SelectedIndex = 1; break;
                            case Constantes.TipoTelefono.Fax: this.cbxTipoTelefono.SelectedIndex = 2; break;
                            default: break;
                        }
                    }
                    else
                    {
                        this.btnSelTel.Visible = false;
                        this.cbxTipoTelefono.SelectedIndex = 3;

                    }

                    lcl_latest = (lcl_mod_entidad as ModeloCliente).mails.Count;
                    if (lcl_latest > 0)
                    {
                        lcl_latest--;
                        this.txtMail.Text = (lcl_mod_entidad as ModeloCliente).mails[lcl_latest].mail;
                    }
                    else
                    {
                        this.btnSelMail.Visible = false;
                    }

                    if (lcl_mod_entidad.domicilios.Count > 0)
                    {
                        lcl_latest--;
                        this.cargarDomicilioEnControles(lcl_mod_entidad.domicilios[0]);
                    }
                    else
                    {
                        this.btnSelDom.Visible = false;
                    }

                }
                else
                {
                    MessageBox.Show("Cliente inexistente");
                    this.txtDni.Text = this.txtBusqCli.Text;
                    this.txtBusqCli.Text = "";
                    this.ckbxRegistrar.Visible = true;
                }
            }
        }
        #endregion

        #region Controles -> Modelo
        private ModeloDomicilio cargarControlesEnDomicilio()
        {
            ModeloDomicilio lcl_mod_nuevoDomicilio = new ModeloDomicilio();
            
            ModeloPais lcl_mod_pais = new ModeloPais();
            lcl_mod_pais.codigo = (string)this.cbxPais.SelectedValue;
            lcl_mod_pais.pais = this.cbxPais.SelectedText;
            lcl_mod_nuevoDomicilio.pais = lcl_mod_pais;

            ModeloProvincia lcl_mod_provincia = new ModeloProvincia();
            lcl_mod_provincia.codigo = (string)this.cbxProvincia.SelectedValue;
            lcl_mod_provincia.provincia = this.cbxProvincia.SelectedText;
            lcl_mod_nuevoDomicilio.provincia = lcl_mod_provincia;
            
            lcl_mod_nuevoDomicilio.ciudad = this.txtCiudad.Text;
            lcl_mod_nuevoDomicilio.calle = this.txtCalle.Text;
            lcl_mod_nuevoDomicilio.numero = this.txtNro.Text;
            lcl_mod_nuevoDomicilio.piso = this.txtPiso.Text;
            lcl_mod_nuevoDomicilio.departamento = this.txtDepto.Text;
            lcl_mod_nuevoDomicilio.codigoPostal = this.txtCp.Text;

            return lcl_mod_nuevoDomicilio;
        }
        private ModeloMail cargarControlesEnMail()
        {
            ModeloMail lcl_mod_nuevoMail = new ModeloMail();
            lcl_mod_nuevoMail.mail = this.txtMail.Text;
            return lcl_mod_nuevoMail;
        }
        private ModeloTelefono cargarControlesEnTelefono()
        {
            ModeloTelefono lcl_mod_nuevoTelefono = new ModeloTelefono();
            lcl_mod_nuevoTelefono.numero = this.txtNro.Text;
            lcl_mod_nuevoTelefono.tipo = (string)this.cbxTipoTelefono.SelectedValue;
            return lcl_mod_nuevoTelefono;
        }
        private Constantes.FormaDePago getFormaDePago()
        {
            Constantes.FormaDePago lcl_formaPago;
            Enum.TryParse<Constantes.FormaDePago>(cbxFormaPago.SelectedValue.ToString(), out lcl_formaPago);
            return lcl_formaPago;
        }
        private Constantes.TipoComprobanteVenta getTipoComprobante()
        {
            Constantes.TipoComprobanteVenta lcl_tipoComprobante;
            Enum.TryParse<Constantes.TipoComprobanteVenta>(cbxFormaPago.SelectedValue.ToString(), out lcl_tipoComprobante);
            return lcl_tipoComprobante;
        }
        #endregion
        #region Modelo -> Controles
        private void cargarDomicilioEnControles(ModeloDomicilio p_mod_domicilio)
        {
            this.cbxPais.SelectedValue = p_mod_domicilio.pais.codigo;
            this.cbxProvincia.SelectedValue = p_mod_domicilio.provincia.codigo;

            this.txtCiudad.Text = p_mod_domicilio.ciudad;
            this.txtCalle.Text = p_mod_domicilio.calle;
            this.txtNro.Text = p_mod_domicilio.numero;
            this.txtPiso.Text = p_mod_domicilio.piso;
            this.txtDepto.Text = p_mod_domicilio.departamento;
            this.txtCp.Text = p_mod_domicilio.codigoPostal;
        }
        private void cargarDatosProvinciasEnCmbBoxProvincia(List<ModeloProvincia> p_lst_mod_provincias)
        {
            this.cbxProvincia.DataSource = p_lst_mod_provincias.OrderBy(i => i.provincia).ToList();
            this.cbxProvincia.DropDownWidth = this.getDropDownWidth(this.cbxProvincia);
            this.cbxProvincia.SelectedItem = null;
        }
        private void cargarMailEnControles(ModeloMail p_mod_mail)
        {
            this.txtMail.Text = p_mod_mail.mail;
        }
        private void cargarTelefonoEnControles(ModeloTelefono p_mod_telefono)
        {
            this.txtTelefono.Text = p_mod_telefono.numero;
            switch (p_mod_telefono.tipo)
            {
                case Constantes.TipoTelefono.Fijo: this.cbxTipoTelefono.SelectedIndex = 0; break;
                case Constantes.TipoTelefono.Celular: this.cbxTipoTelefono.SelectedIndex = 1; break;
                case Constantes.TipoTelefono.Fax: this.cbxTipoTelefono.SelectedIndex = 2; break;
                default: break;
            }
        }
        #endregion
        #endregion

        #region Eventos
        #region Botones
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            //solicito confirmación
            DialogResult dialogResult = MessageBox.Show("¿Realmente desea emitir el comprobante?", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //cierro el pedido
                glb_con_procesarPedido.cerrarPedido();

                //checkeo registro de cliente nuevo si es necesario
                if (ckbxRegistrar.Checked)
                {
                    //creo el nuevo cliente
                    //TODO -> Verificación de cadenas
                    ModeloPersonas lcl_mod_nuevoCliente = new ModeloPersonas();
                    lcl_mod_nuevoCliente.nombre = txtNombre.Text;
                    lcl_mod_nuevoCliente.apellido = txtApellido.Text;
                    lcl_mod_nuevoCliente.dni = txtDni.Text;
                    lcl_mod_nuevoCliente.observaciones = rtbObsCliente.Text;

                    lcl_mod_nuevoCliente.telefonos.Add(this.cargarControlesEnTelefono());
                    
                    lcl_mod_nuevoCliente.mails.Add(this.cargarControlesEnMail());

                    lcl_mod_nuevoCliente.domicilios.Add(this.cargarControlesEnDomicilio());

                   //glb_con_procesarPedido.addClient(lcl_mod_nuevoCliente);
                }

                //imprimo recibo (usar formularios)
                //this.print();
                //seteo emitido para terminar transacción y cierro
                glb_emitido = true;
                this.Close();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            this.lblTotalSinIvaVar.Text = glb_con_procesarPedido.getTotal();

            if (Validar.validarValorNumerico(this.txtDescuentoNeto.Text) && Validar.validarValorNumerico(this.txtDescuentoPorc.Text) 
                && Validar.validarValorNumerico(this.txtSenia.Text) && Validar.validarValorNumerico(this.txtIvaPorc.Text))
            {
                Decimal lcl_totalParcial = Decimal.Parse(glb_con_procesarPedido.getTotal());
                Decimal lcl_ivaNeto = (lcl_totalParcial * (Decimal.Parse(txtIvaPorc.Text) / 100));
                this.lblIvaNetoVar.Text = lcl_ivaNeto.ToString("0.##");

                Decimal lcl_descuentoPorcentual = (lcl_totalParcial * (Decimal.Parse(txtDescuentoPorc.Text) / 100));
                Decimal lcl_descontado = lcl_descuentoPorcentual + Decimal.Parse(txtDescuentoNeto.Text) + Decimal.Parse(txtSenia.Text);
                this.lblMontoDescontadoVar.Text = lcl_descontado.ToString("0.##");

                Decimal lcl_totalBruto = Decimal.Parse(glb_con_procesarPedido.getTotal()) + lcl_ivaNeto - lcl_descontado;
                this.lblTotalVar.Text = lcl_totalBruto.ToString("0.##");
            }
            else
            {
                MessageBox.Show("Por favor asegurarse que los campos de descuento, iva y seña contengan algún valor numérico");
            }
        }

        private void btnSelTel_Click(object sender, EventArgs e)
        {
            frmSeleccion lcl_frm_Seleccion = new frmSeleccion();
            var lcl_mod_cliente = glb_con_procesarPedido.entidadActual;

            lcl_frm_Seleccion.bindList(lcl_mod_cliente.telefonos);
            lcl_frm_Seleccion.Show();
            
            this.cargarTelefonoEnControles(lcl_mod_cliente.telefonos[lcl_frm_Seleccion.selectedIndex]);
        }

        private void btnSelMail_Click(object sender, EventArgs e)
        {
            frmSeleccion lcl_frm_Seleccion = new frmSeleccion();
            var lcl_mod_cliente = glb_con_procesarPedido.entidadActual;

            lcl_frm_Seleccion.bindList(lcl_mod_cliente.mails);
            lcl_frm_Seleccion.Show();

            this.cargarMailEnControles(lcl_mod_cliente.mails[lcl_frm_Seleccion.selectedIndex]);
        }

        private void btnSelDom_Click(object sender, EventArgs e)
        {
            frmSeleccion lcl_frm_Seleccion = new frmSeleccion();
            var lcl_mod_cliente = glb_con_procesarPedido.entidadActual;

            lcl_frm_Seleccion.bindList(lcl_mod_cliente.domicilios);
            lcl_frm_Seleccion.Show();

            this.cargarDomicilioEnControles(lcl_mod_cliente.domicilios[lcl_frm_Seleccion.selectedIndex]);
        }
        #endregion

        #region ComboBox
        private void cbxPais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.asignarProvincias();
        }
        #endregion
        #endregion

        #region Impresión (a ser reemplazada por formularios)
        //private void print()
        //{
        //    PrintDialog pd = new PrintDialog();
        //    PrintDocument pdoc = new PrintDocument();
        //    PrinterSettings ps = new PrinterSettings();

        //    Font font = new Font("Courier New", 15);
        //    PaperSize psize = new PaperSize("Custom", 100, 200);

        //    pd.Document = pdoc;
        //    pd.Document.DefaultPageSettings.PaperSize = psize;

        //    pdoc.DefaultPageSettings.PaperSize.Height = 820;
        //    pdoc.DefaultPageSettings.PaperSize.Width = 520;
        //    pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);

        //    DialogResult result = pd.ShowDialog();
        //    if (result == DialogResult.OK)
        //    {
        //        PrintPreviewDialog pp = new PrintPreviewDialog();
        //        pp.Document = pdoc;
        //        result = pp.ShowDialog();
        //        if (result == DialogResult.OK)
        //        {
        //            pdoc.Print();
        //        }
        //    }

        //}

        //void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    Graphics graphics = e.Graphics;
        //    Font font = new Font("Courier New", 10);
        //    float fontHeight = font.GetHeight();
        //    int startX = 50;
        //    int startY = 55;
        //    int Offset = 40;

        //    graphics.DrawString("Mundo Renault", new Font("Courier New", 14),
        //                        new SolidBrush(Color.Black), startX, startY + Offset);

        //    Offset = Offset + 20;
        //    graphics.DrawString(this.cbxTipoComp.Text,
        //             new Font("Courier New", 14),
        //             new SolidBrush(Color.Black), startX, startY + Offset);

        //    Offset = Offset + 20;
        //    graphics.DrawString("No. Factura: " + this.txtNroComp.Text,
        //             new Font("Courier New", 14),
        //             new SolidBrush(Color.Black), startX, startY + Offset);

        //    Offset = Offset + 20;
        //    graphics.DrawString("Forma de pago: " + this.cbxFormaPago.Text,
        //             new Font("Courier New", 14),
        //             new SolidBrush(Color.Black), startX, startY + Offset);

        //    Offset = Offset + 20;
        //    graphics.DrawString("Fecha: " + dtpFecha.Text,
        //             new Font("Courier New", 12),
        //             new SolidBrush(Color.Black), startX, startY + Offset);

        //    Offset = Offset + 20;
        //    graphics.DrawString("Descuento (%): " + txtDescuentoPorc.Text,
        //             new Font("Courier New", 12),
        //             new SolidBrush(Color.Black), startX, startY + Offset);

        //    Offset = Offset + 20;
        //    graphics.DrawString("Descuento ($): " + txtDescuentoNeto.Text,
        //             new Font("Courier New", 12),
        //             new SolidBrush(Color.Black), startX, startY + Offset);

        //    Offset = Offset + 20;
        //    graphics.DrawString("Seña ($): " + txtSenia.Text,
        //             new Font("Courier New", 12),
        //             new SolidBrush(Color.Black), startX, startY + Offset);

        //    Offset = Offset + 20;
        //    graphics.DrawString("IVA (%): " + txtIvaPorc.Text,
        //             new Font("Courier New", 12),
        //             new SolidBrush(Color.Black), startX, startY + Offset);

        //    Offset = Offset + 20;
        //    String underLine = "------------------------------------------";
        //    graphics.DrawString(underLine,
        //             new Font("Courier New", 10),
        //             new SolidBrush(Color.Black), startX, startY + Offset);


        //    Offset = Offset + 20;
        //    graphics.DrawString("Nombre: " + txtNombre.Text,
        //             new Font("Courier New", 12),
        //             new SolidBrush(Color.Black), startX, startY + Offset);

        //    Offset = Offset + 20;
        //    graphics.DrawString("Apellido: " + txtApellido.Text,
        //             new Font("Courier New", 12),
        //             new SolidBrush(Color.Black), startX, startY + Offset);

        //    Offset = Offset + 20;
        //    underLine = "------------------------------------------";
        //    graphics.DrawString(underLine,
        //             new Font("Courier New", 10),
        //             new SolidBrush(Color.Black), startX, startY + Offset);

        //    foreach (ModeloLineaPedido linea in glb_lst_mod_ventaActual)
        //    {
        //        Offset = Offset + 20;
        //        graphics.DrawString("Articulo: " + linea.descripcion,
        //                 new Font("Courier New", 12),
        //                 new SolidBrush(Color.Black), startX, startY + Offset);

        //        graphics.DrawString("Cantidad: " + linea.cantidadArticulos,
        //                 new Font("Courier New", 12),
        //                 new SolidBrush(Color.Black), startX + 300, startY + Offset);

        //        graphics.DrawString("Total parcial: " + linea.valorParcial,
        //                 new Font("Courier New", 12),
        //                 new SolidBrush(Color.Black), startX + 500, startY + Offset);
        //    }

        //    Offset = Offset + 20;
        //    graphics.DrawString("Total : " + glb_con_procesarVenta.getTotal(),
        //             new Font("Courier New", 10),
        //             new SolidBrush(Color.Black), startX, startY + Offset);

        //    Offset = Offset + 20;
        //    graphics.DrawString("Cajero: " + "Ronald McDonald",
        //             new Font("Courier New", 10),
        //             new SolidBrush(Color.Black), startX, startY + Offset);
        //}

        private void ImprimirPedido(ModeloPedido p_modeloPedido,ModeloPersonas p_modeloPersona)
        {
            glb_frm_FormReportes = glb_con_Reportes.ReporteEmitePedido(p_modeloPedido,p_modeloPersona);

            glb_frm_FormReportes.ShowDialog();
        }
        
        #endregion        
    }
   
    //clase para llenar combo box categoria a buscar
    class Tel
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
