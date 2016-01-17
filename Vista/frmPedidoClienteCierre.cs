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
        private List<ModeloLineaPedido> glb_lst_mod_ventaActual;
        public bool glb_emitido = false;
        private ControladorProcesarVenta glb_con_procesarVenta;
        private List<ModeloPais> glb_lst_mod_paises;
        private List<ModeloProvincia> glb_lst_mod_provincias;
        private ModeloPersonas glb_mod_cliente;
        
        
        #region Instanciaciones
        public frmPedidoClienteCierre()
        {
            InitializeComponent();
            this.dgvArticulosVenta.AutoGenerateColumns = false;
        }

        public void controladorEnUso(ControladorProcesarVenta p_controladorProcesarVenta)
        {
            //Guardo el controlador de venta
            this.glb_con_procesarVenta = p_controladorProcesarVenta;

            //busco la venta actual y la bindeo a dgv
            this.glb_lst_mod_ventaActual = glb_con_procesarVenta.getVentaActual();

            var lcl_bindingList = new BindingList<ModeloLineaPedido>(this.glb_lst_mod_ventaActual);
            var lcl_source = new BindingSource(lcl_bindingList, null);
            this.dgvArticulosVenta.DataSource = lcl_source;


            //Populo combobox de paises
            glb_lst_mod_paises = glb_con_procesarVenta.getPaises();
            this.cbxPais.DataSource = glb_lst_mod_paises;
            this.cbxPais.DisplayMember = "pais";
            this.cbxPais.ValueMember = "codigo";

            //Lo hago read only
            this.cbxPais.DropDownStyle = ComboBoxStyle.DropDownList;

            //Populo combobox de provincias
            glb_lst_mod_provincias = glb_con_procesarVenta.getProvincias();
            this.cbxProvincia.DataSource = glb_lst_mod_provincias;
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
                glb_con_procesarVenta.cerrarPedido(glb_lst_mod_ventaActual);

                //checkeo registro de cliente nuevo
                if (ckbxRegistrar.Checked)
                {
                    //creo el nuevo cliente
                    //TODO -> Verificación de cadenas
                    ModeloPersonas lcl_mod_nuevoCliente = new ModeloPersonas();
                    lcl_mod_nuevoCliente.nombre = txtNombre.Text;
                    lcl_mod_nuevoCliente.apellido = txtApellido.Text;
                    lcl_mod_nuevoCliente.dni = txtDni.Text;
                    lcl_mod_nuevoCliente.observaciones = rtbObsCliente.Text;

                    ModeloTelefono lcl_mod_nuevoTelefono = new ModeloTelefono();
                    lcl_mod_nuevoTelefono.numero = this.txtNro.Text;
                    lcl_mod_nuevoTelefono.tipo = (string)this.cbxTipoTel.SelectedValue;
                    lcl_mod_nuevoCliente.telefonos.Add(lcl_mod_nuevoTelefono);

                    ModeloMail lcl_mod_nuevoMail = new ModeloMail();
                    lcl_mod_nuevoMail.mail = this.txtMail.Text;
                    lcl_mod_nuevoCliente.mails.Add(lcl_mod_nuevoMail);

                    ModeloDomicilio lcl_mod_nuevoDomicilio = new ModeloDomicilio();
                    ModeloPais lcl_mod_nuevoPais = new ModeloPais();
                    lcl_mod_nuevoPais.codigo = (string)this.cbxPais.SelectedValue;
                    lcl_mod_nuevoPais.pais = this.cbxPais.SelectedText;
                    lcl_mod_nuevoDomicilio.pais = lcl_mod_nuevoPais;

                    ModeloProvincia lcl_mod_nuevaProvincia = new ModeloProvincia();
                    lcl_mod_nuevaProvincia.codigo = (string)this.cbxProvincia.SelectedValue;
                    lcl_mod_nuevaProvincia.provincia = this.cbxProvincia.SelectedText;
                    lcl_mod_nuevoDomicilio.provincia = lcl_mod_nuevaProvincia;
                    lcl_mod_nuevoDomicilio.ciudad = this.txtCiudad.Text;
                    lcl_mod_nuevoDomicilio.calle = this.txtCalle.Text;
                    lcl_mod_nuevoDomicilio.numero = this.txtNro.Text;
                    lcl_mod_nuevoDomicilio.piso = this.txtPiso.Text;
                    lcl_mod_nuevoDomicilio.departamento = this.txtDepto.Text;
                    lcl_mod_nuevoDomicilio.codigoPostal = this.txtCp.Text;
                    lcl_mod_nuevoCliente.domicilios.Add(lcl_mod_nuevoDomicilio);

                    glb_con_procesarVenta.addClient(lcl_mod_nuevoCliente);
                }

                //imprimo recibo
                this.print();
                //seteo emitido para terminar transacción y cierro
                glb_emitido = true;
                this.Close();
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            this.lblTotalSinIvaVar.Text = glb_con_procesarVenta.getTotal();

            //TODO -> validar que no sean alfanuméricos
            if (this.txtDescuentoNeto.Text != "" && this.txtDescuentoPorc.Text != "" && this.txtSenia.Text != "" && this.txtIvaPorc.Text != "")
            {
                Decimal lcl_totalParcial = Decimal.Parse(glb_con_procesarVenta.getTotal());
                Decimal lcl_ivaNeto = (lcl_totalParcial * (Decimal.Parse(txtIvaPorc.Text) / 100));
                this.lblIvaNetoVar.Text = lcl_ivaNeto.ToString("0.##");

                Decimal lcl_descuentoPorcentual = (lcl_totalParcial * (Decimal.Parse(txtDescuentoPorc.Text) / 100));
                Decimal lcl_descontado = lcl_descuentoPorcentual + Decimal.Parse(txtDescuentoNeto.Text) + Decimal.Parse(txtSenia.Text);
                this.lblMontoDescontadoVar.Text = lcl_descontado.ToString("0.##");

                Decimal lcl_totalBruto = Decimal.Parse(glb_con_procesarVenta.getTotal()) + lcl_ivaNeto - lcl_descontado;
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
            lcl_frm_Seleccion.bindList(glb_mod_cliente.telefonos);
            lcl_frm_Seleccion.Show();
            this.txtTelefono.Text = glb_mod_cliente.telefonos[lcl_frm_Seleccion.selectedIndex].numero;
            switch (glb_mod_cliente.telefonos[lcl_frm_Seleccion.selectedIndex].tipo)
            {
                case "TEL": this.cbxTipoTel.SelectedIndex = 0; break;
                case "CEL": this.cbxTipoTel.SelectedIndex = 1; break;
                case "FAX": this.cbxTipoTel.SelectedIndex = 2; break;
                default: break;
            }
        }

        private void btnSelMail_Click(object sender, EventArgs e)
        {
            frmSeleccion lcl_frm_Seleccion = new frmSeleccion();
            lcl_frm_Seleccion.bindList(glb_mod_cliente.mails);
            lcl_frm_Seleccion.Show();
            this.txtMail.Text = glb_mod_cliente.mails[lcl_frm_Seleccion.selectedIndex].mail;
        }

        private void btnSelDom_Click(object sender, EventArgs e)
        {
            frmSeleccion lcl_frm_Seleccion = new frmSeleccion();
            lcl_frm_Seleccion.bindList(glb_mod_cliente.domicilios);
            lcl_frm_Seleccion.Show();
            this.cbxPais.SelectedIndex = glb_lst_mod_paises.FindIndex(a => a.codigo == glb_mod_cliente.domicilios[lcl_frm_Seleccion.selectedIndex].pais.codigo);
            this.cbxProvincia.SelectedIndex = glb_lst_mod_provincias.FindIndex(a => a.codigo == glb_mod_cliente.domicilios[lcl_frm_Seleccion.selectedIndex].provincia.codigo);
            this.txtCiudad.Text = glb_mod_cliente.domicilios[lcl_frm_Seleccion.selectedIndex].ciudad;
            this.txtCalle.Text = glb_mod_cliente.domicilios[lcl_frm_Seleccion.selectedIndex].calle;
            this.txtNro.Text = glb_mod_cliente.domicilios[lcl_frm_Seleccion.selectedIndex].numero;
            this.txtPiso.Text = glb_mod_cliente.domicilios[lcl_frm_Seleccion.selectedIndex].piso;
            this.txtDepto.Text = glb_mod_cliente.domicilios[lcl_frm_Seleccion.selectedIndex].departamento;
            this.txtCp.Text = glb_mod_cliente.domicilios[lcl_frm_Seleccion.selectedIndex].codigoPostal;
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

            foreach (ModeloLineaPedido linea in glb_lst_mod_ventaActual)
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
            graphics.DrawString("Total : " + glb_con_procesarVenta.getTotal(),
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
                glb_mod_cliente = glb_con_procesarVenta.getCliente(txtBusqCli.Text);

                // reporto resultado
                if (!object.Equals(glb_mod_cliente, null))
                {
                    //limpio campo de búsqueda
                    this.txtBusqCli.Text = "";

                    //oculto checkbox registrar cliente;
                    this.ckbxRegistrar.Visible = false;

                    //muestro botonera de seleccion
                    this.pnlSelectButtons.Visible = true;

                    //lleno textboxs
                    int lcl_latest;
                    this.txtNombre.Text = glb_mod_cliente.nombre;
                    this.txtApellido.Text = glb_mod_cliente.apellido;
                    this.txtDni.Text = glb_mod_cliente.dni;
                    this.rtbObsCliente.Text = glb_mod_cliente.observaciones;

                    lcl_latest = glb_mod_cliente.telefonos.Count;
                    if (lcl_latest > 0)
                    {
                        lcl_latest--;
                        this.txtTelefono.Text = glb_mod_cliente.telefonos[lcl_latest].numero;
                        switch (glb_mod_cliente.telefonos[lcl_latest].tipo)
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

                    lcl_latest = glb_mod_cliente.mails.Count;
                    if (lcl_latest > 0)
                    {
                        lcl_latest--;
                        this.txtMail.Text = glb_mod_cliente.mails[lcl_latest].mail;
                    }
                    else
                    {
                        this.btnSelMail.Visible = false;
                    }

                    lcl_latest = glb_mod_cliente.domicilios.Count;
                    if (lcl_latest > 0)
                    {
                        lcl_latest--;
                        this.cbxPais.SelectedIndex = glb_lst_mod_paises.FindIndex(a => a.codigo == glb_mod_cliente.domicilios[lcl_latest].pais.codigo);
                        this.cbxProvincia.SelectedIndex = glb_lst_mod_provincias.FindIndex(a => a.codigo == glb_mod_cliente.domicilios[lcl_latest].provincia.codigo);
                        this.txtCiudad.Text = glb_mod_cliente.domicilios[lcl_latest].ciudad;
                        this.txtCalle.Text = glb_mod_cliente.domicilios[lcl_latest].calle;
                        this.txtNro.Text = glb_mod_cliente.domicilios[lcl_latest].numero;
                        this.txtPiso.Text = glb_mod_cliente.domicilios[lcl_latest].piso;
                        this.txtDepto.Text = glb_mod_cliente.domicilios[lcl_latest].departamento;
                        this.txtCp.Text = glb_mod_cliente.domicilios[lcl_latest].codigoPostal;
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
