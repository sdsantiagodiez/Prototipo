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
        
        public frmPedidoClienteCierre()
        {
            InitializeComponent();
            this.dgvArticulosVenta.AutoGenerateColumns = false;
        }

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
                //ctrlVenta.cerrarPedido(ventaActual);
                
                //checkeo registro de cliente nuevo
                if (ckbxRegistrar.Checked)
                {
                    //creo el nuevo cliente
                    //TODO -> Verificación de cadenas, agregar tipo telefono
                    ModeloPersonas newCli = new ModeloPersonas();
                    newCli.nombre = txtNombre.Text;
                    newCli.apellido = txtApellido.Text;
                    newCli.dni = txtDni.Text;

                    ModeloTelefono newTel = new ModeloTelefono();
                    newTel.numero = this.txtNro.Text;
                    newCli.telefonos.Add(newTel);

                    ModeloMail newMail = new ModeloMail();
                    newMail.mail = this.txtMail.Text;
                    newCli.mails.Add(newMail);

                    //TODO -> LLENADO DE COMBOBOXES
                    ModeloDomicilio newDomicilio = new ModeloDomicilio();
                        ModeloPais newPais = new ModeloPais();
                        newPais.codigo = (string)this.cbxPais.SelectedValue;
                        newPais.pais = this.cbxPais.SelectedText;
                        newDomicilio.pais = newPais;

                        ModeloProvincia newProvincia = new ModeloProvincia();
                        newProvincia.codigo = (string)this.cbxProvincia.SelectedValue;
                        newProvincia.provincia = (string)this.cbxProvincia.SelectedText;
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
    
        internal void detalleVenta(ControladorProcesarVenta instanciaCtrl)
        {
            this.ctrlVenta = instanciaCtrl;
 	        this.ventaActual = ctrlVenta.getVentaActual();
            var bindingList = new BindingList<ModeloLineaPedido>(this.ventaActual);
            var source = new BindingSource(bindingList, null);
            this.dgvArticulosVenta.DataSource = source;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            this.lblTotalSinIvaVar.Text = ctrlVenta.getTotal();
            Decimal totalNeto = Decimal.Parse(ctrlVenta.getTotal());
            int ivaPorc = Int32.Parse(txtIvaPorc.Text);
            Decimal ivaNeto = (totalNeto * (ivaPorc / 100));
            this.lblIvaNetoVar.Text = ivaNeto.ToString("0.##");
            Decimal total = Decimal.Parse(ctrlVenta.getTotal()) + ivaNeto;
            this.lblTotalVar.Text = total.ToString("0.##");
        }

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

        private void txtBusqCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TODO -> Validar cadena de entrada

            if (e.KeyChar == (char)Keys.Enter)
            {
                //busco al cliente de la base de datos
                ModeloPersonas cliente = ctrlVenta.getCliente(txtBusqCli.Text);

                // reporto resultado
                if (!object.Equals(cliente, null))
                {
                    //lleno textboxs
                    int latest;
                    this.txtNombre.Text = cliente.nombre;
                    this.txtApellido.Text = cliente.apellido;
                    this.txtDni.Text = cliente.dni;
                    
                    latest = cliente.telefonos.Count - 1;
                    this.txtTelefono.Text = cliente.telefonos[latest].numero;

                    latest = cliente.mails.Count - 1;
                    this.txtMail.Text = cliente.mails[latest].mail;

                    latest = cliente.domicilios.Count - 1;
                    //TODO -> comboboxes pais y provincia, el texto es la desc, el value es el código, tengo que pedirlos todos a la bd
                    //this.txtPais.Text = cliente.domicilios[latest].pais.pais;
                    //this.txtProvincia.Text = cliente.domicilios[latest].provincia.provincia;
                    this.txtCiudad.Text = cliente.domicilios[latest].ciudad;
                    this.txtCalle.Text = cliente.domicilios[latest].calle;
                    this.txtNro.Text = cliente.domicilios[latest].numero;
                    this.txtPiso.Text = cliente.domicilios[latest].piso;
                    this.txtDepto.Text = cliente.domicilios[latest].departamento;
                    this.txtCp.Text = cliente.domicilios[latest].codigoPostal;
                    //TODO -> AGREGAR TIPO DE TELEFONO
                }
                else
                {
                    MessageBox.Show("Cliente inexistente");
                    this.txtDni.Text = this.txtBusqCli.Text;
                    this.txtBusqCli.Text = "";
                }
            }
        }
    }
}
