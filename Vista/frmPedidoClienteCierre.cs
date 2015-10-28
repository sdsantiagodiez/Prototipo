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

namespace Vista
{
    public partial class frmPedidoClienteCierre : Form
    {
        private List<ModeloLineaPedido> ventaActual;
        public bool emitido = false;
        private ControladorProcesarVenta ctrlVenta;
        private List<ModeloPais> paises;
        private List<ModeloProvincia> provincias;
        private ModeloPersonas cliente;
        
        
        #region Instanciaciones
        public frmPedidoClienteCierre()
        {
            InitializeComponent();
            this.dgvArticulosVenta.AutoGenerateColumns = false;
        }

        public void detalleVenta(ControladorProcesarVenta ctrlProcVenta)
        {
            //Guardo el controlador de venta
            this.ctrlVenta = ctrlProcVenta;

            //busco la venta actual y la bindeo a dgv
            this.ventaActual = ctrlVenta.getVentaActual();

            var bindingList = new BindingList<ModeloLineaPedido>(this.ventaActual);
            var source = new BindingSource(bindingList, null);
            this.dgvArticulosVenta.DataSource = source;


            //Populo combobox de paises
            paises = ctrlVenta.getPaises();
            this.cbxPais.DataSource = paises;
            this.cbxPais.DisplayMember = "pais";
            this.cbxPais.ValueMember = "codigo";

            //Lo hago read only
            this.cbxPais.DropDownStyle = ComboBoxStyle.DropDownList;

            //Populo combobox de provincias
            provincias = ctrlVenta.getProvincias();
            this.cbxProvincia.DataSource = provincias;
            this.cbxProvincia.DisplayMember = "provincia";
            this.cbxProvincia.ValueMember = "codigo";

            //Lo hago read only
            this.cbxProvincia.DropDownStyle = ComboBoxStyle.DropDownList;

            //Creo lista Tipos de teléfono
            var dataSource = new List<Tel>();
            dataSource.Add(new Tel() { Name = "Fijo", Value = "TEL" });
            dataSource.Add(new Tel() { Name = "Celular", Value = "CEL" });
            dataSource.Add(new Tel() { Name = "Fax", Value = "FAX" });
            dataSource.Add(new Tel() { Name = "Sin Teléfono", Value = null });

            //Binding de telefonos
            this.cbxTipoTel.DataSource = dataSource;
            this.cbxTipoTel.DisplayMember = "Name";
            this.cbxTipoTel.ValueMember = "Value";

            //Lo hago read only
            this.cbxTipoTel.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        #endregion

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
                //descuento stock
                ctrlVenta.cerrarPedido(ventaActual);

                //checkeo registro de cliente nuevo
                if (ckbxRegistrar.Checked)
                {
                    //creo el nuevo cliente
                    //TODO -> Verificación de cadenas
                    ModeloPersonas newCli = new ModeloPersonas();
                    newCli.nombre = txtNombre.Text;
                    newCli.apellido = txtApellido.Text;
                    newCli.dni = txtDni.Text;
                    newCli.observaciones = rtbObsCliente.Text;

                    ModeloTelefono newTel = new ModeloTelefono();
                    newTel.numero = this.txtNro.Text;
                    newTel.tipo = (string)this.cbxTipoTel.SelectedValue;
                    newCli.telefonos.Add(newTel);

                    ModeloMail newMail = new ModeloMail();
                    newMail.mail = this.txtMail.Text;
                    newCli.mails.Add(newMail);

                    ModeloDomicilio newDomicilio = new ModeloDomicilio();
                    ModeloPais newPais = new ModeloPais();
                    newPais.codigo = (string)this.cbxPais.SelectedValue;
                    newPais.pais = this.cbxPais.SelectedText;
                    newDomicilio.pais = newPais;

                    ModeloProvincia newProvincia = new ModeloProvincia();
                    newProvincia.codigo = (string)this.cbxProvincia.SelectedValue;
                    newProvincia.provincia = this.cbxProvincia.SelectedText;
                    newDomicilio.provincia = newProvincia;
                    newDomicilio.ciudad = this.txtCiudad.Text;
                    newDomicilio.calle = this.txtCalle.Text;
                    newDomicilio.numero = this.txtNro.Text;
                    newDomicilio.piso = this.txtPiso.Text;
                    newDomicilio.departamento = this.txtDepto.Text;
                    newDomicilio.codigoPostal = this.txtCp.Text;
                    newCli.domicilios.Add(newDomicilio);

                    ctrlVenta.addClient(newCli);
                }

                //imprimo recibo
                this.print();
                //seteo emitido para terminar transacción y cierro
                emitido = true;
                this.Close();
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            this.lblTotalSinIvaVar.Text = ctrlVenta.getTotal();

            //TODO -> validar que no sean alfanuméricos
            if (this.txtDescuentoNeto.Text != "" && this.txtDescuentoPorc.Text != "" && this.txtSenia.Text != "" && this.txtIvaPorc.Text != "")
            {
                Decimal totalParcial = Decimal.Parse(ctrlVenta.getTotal());
                Decimal ivaNeto = (totalParcial * (Decimal.Parse(txtIvaPorc.Text) / 100));
                this.lblIvaNetoVar.Text = ivaNeto.ToString("0.##");

                Decimal descPorc = (totalParcial * (Decimal.Parse(txtDescuentoPorc.Text) / 100));
                Decimal descontado = descPorc + Decimal.Parse(txtDescuentoNeto.Text) + Decimal.Parse(txtSenia.Text);
                this.lblMontoDescontadoVar.Text = descontado.ToString("0.##");

                Decimal total = Decimal.Parse(ctrlVenta.getTotal()) + ivaNeto - descontado;
                this.lblTotalVar.Text = total.ToString("0.##");
            }
            else
            {
                MessageBox.Show("Por favor asegurarse que los campos de descuento, iva y seña contengan algún valor numérico");
            }
        }

        private void btnSelTel_Click(object sender, EventArgs e)
        {
            frmSeleccion frmSel = new frmSeleccion();
            frmSel.bindList(cliente.telefonos);
            frmSel.Show();
            this.txtTelefono.Text = cliente.telefonos[frmSel.selectedIndex].numero;
            switch (cliente.telefonos[frmSel.selectedIndex].tipo)
            {
                case "TEL": this.cbxTipoTel.SelectedIndex = 0; break;
                case "CEL": this.cbxTipoTel.SelectedIndex = 1; break;
                case "FAX": this.cbxTipoTel.SelectedIndex = 2; break;
                default: break;
            }
        }

        private void btnSelMail_Click(object sender, EventArgs e)
        {
            frmSeleccion frmSel = new frmSeleccion();
            frmSel.bindList(cliente.mails);
            frmSel.Show();
            this.txtMail.Text = cliente.mails[frmSel.selectedIndex].mail;
        }

        private void btnSelDom_Click(object sender, EventArgs e)
        {
            frmSeleccion frmSel = new frmSeleccion();
            frmSel.bindList(cliente.domicilios);
            frmSel.Show();
            this.cbxPais.SelectedIndex = paises.FindIndex(a => a.codigo == cliente.domicilios[frmSel.selectedIndex].pais.codigo);
            this.cbxProvincia.SelectedIndex = provincias.FindIndex(a => a.codigo == cliente.domicilios[frmSel.selectedIndex].provincia.codigo);
            this.txtCiudad.Text = cliente.domicilios[frmSel.selectedIndex].ciudad;
            this.txtCalle.Text = cliente.domicilios[frmSel.selectedIndex].calle;
            this.txtNro.Text = cliente.domicilios[frmSel.selectedIndex].numero;
            this.txtPiso.Text = cliente.domicilios[frmSel.selectedIndex].piso;
            this.txtDepto.Text = cliente.domicilios[frmSel.selectedIndex].departamento;
            this.txtCp.Text = cliente.domicilios[frmSel.selectedIndex].codigoPostal;
        }
        #endregion

        #region Impresión
        private void print()
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();

            Font font = new Font("Courier New", 15);
            PaperSize psize = new PaperSize("Custom", 100, 200);

            pd.Document = pdoc;
            pd.Document.DefaultPageSettings.PaperSize = psize;

            pdoc.DefaultPageSettings.PaperSize.Height = 820;
            pdoc.DefaultPageSettings.PaperSize.Width = 520;
            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);

            DialogResult result = pd.ShowDialog();
            if (result == DialogResult.OK)
            {
                PrintPreviewDialog pp = new PrintPreviewDialog();
                pp.Document = pdoc;
                result = pp.ShowDialog();
                if (result == DialogResult.OK)
                {
                    pdoc.Print();
                }
            }

        }

        void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 10);
            float fontHeight = font.GetHeight();
            int startX = 50;
            int startY = 55;
            int Offset = 40;

            graphics.DrawString("Mundo Renault", new Font("Courier New", 14),
                                new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString(this.cbxTipoComp.Text,
                     new Font("Courier New", 14),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("No. Factura: " + this.txtNroComp.Text,
                     new Font("Courier New", 14),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("Forma de pago: " + this.cbxFormaPago.Text,
                     new Font("Courier New", 14),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("Fecha: " + dtpFecha.Text,
                     new Font("Courier New", 12),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("Descuento (%): " + txtDescuentoPorc.Text,
                     new Font("Courier New", 12),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("Descuento ($): " + txtDescuentoNeto.Text,
                     new Font("Courier New", 12),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("Seña ($): " + txtSenia.Text,
                     new Font("Courier New", 12),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("IVA (%): " + txtIvaPorc.Text,
                     new Font("Courier New", 12),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            String underLine = "------------------------------------------";
            graphics.DrawString(underLine,
                     new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);


            Offset = Offset + 20;
            graphics.DrawString("Nombre: " + txtNombre.Text,
                     new Font("Courier New", 12),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("Apellido: " + txtApellido.Text,
                     new Font("Courier New", 12),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            underLine = "------------------------------------------";
            graphics.DrawString(underLine,
                     new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            foreach (ModeloLineaPedido linea in ventaActual)
            {
                Offset = Offset + 20;
                graphics.DrawString("Articulo: " + linea.descripcion,
                         new Font("Courier New", 12),
                         new SolidBrush(Color.Black), startX, startY + Offset);

                graphics.DrawString("Cantidad: " + linea.cantidadArticulos,
                         new Font("Courier New", 12),
                         new SolidBrush(Color.Black), startX + 300, startY + Offset);

                graphics.DrawString("Total parcial: " + linea.valorParcial,
                         new Font("Courier New", 12),
                         new SolidBrush(Color.Black), startX + 500, startY + Offset);
            }

            Offset = Offset + 20;
            graphics.DrawString("Total : " + ctrlVenta.getTotal(),
                     new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("Cajero: " + "Ronald McDonald",
                     new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);
        }
        #endregion

        #region Búsqueda
        private void txtBusqCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TODO -> Validar cadena de entrada

            if (e.KeyChar == (char)Keys.Enter)
            {
                //busco al cliente de la base de datos
                cliente = ctrlVenta.getCliente(txtBusqCli.Text);

                // reporto resultado
                if (!object.Equals(cliente, null))
                {
                    //limpio campo de búsqueda
                    this.txtBusqCli.Text = "";

                    //oculto checkbox registrar cliente;
                    this.ckbxRegistrar.Visible = false;

                    //muestro botonera de seleccion
                    this.pnlSelectButtons.Visible = true;

                    //lleno textboxs
                    int latest;
                    this.txtNombre.Text = cliente.nombre;
                    this.txtApellido.Text = cliente.apellido;
                    this.txtDni.Text = cliente.dni;
                    this.rtbObsCliente.Text = cliente.observaciones;

                    latest = cliente.telefonos.Count;
                    if (latest > 0)
                    {
                        latest--;
                        this.txtTelefono.Text = cliente.telefonos[latest].numero;
                        switch (cliente.telefonos[latest].tipo)
                        {
                            case "TEL": this.cbxTipoTel.SelectedIndex = 0; break;
                            case "CEL": this.cbxTipoTel.SelectedIndex = 1; break;
                            case "FAX": this.cbxTipoTel.SelectedIndex = 2; break;
                            default: break;
                        }
                    }
                    else
                    {
                        this.btnSelTel.Visible = false;
                        this.cbxTipoTel.SelectedIndex = 3;

                    }

                    latest = cliente.mails.Count;
                    if (latest > 0)
                    {
                        latest--;
                        this.txtMail.Text = cliente.mails[latest].mail;
                    }
                    else
                    {
                        this.btnSelMail.Visible = false;
                    }

                    latest = cliente.domicilios.Count;
                    if (latest > 0)
                    {
                        latest--;
                        this.cbxPais.SelectedIndex = paises.FindIndex(a => a.codigo == cliente.domicilios[latest].pais.codigo);
                        this.cbxProvincia.SelectedIndex = provincias.FindIndex(a => a.codigo == cliente.domicilios[latest].provincia.codigo);
                        this.txtCiudad.Text = cliente.domicilios[latest].ciudad;
                        this.txtCalle.Text = cliente.domicilios[latest].calle;
                        this.txtNro.Text = cliente.domicilios[latest].numero;
                        this.txtPiso.Text = cliente.domicilios[latest].piso;
                        this.txtDepto.Text = cliente.domicilios[latest].departamento;
                        this.txtCp.Text = cliente.domicilios[latest].codigoPostal;
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


    }
   
    //clase para llenar combo box categoria a buscar
    class Tel
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
