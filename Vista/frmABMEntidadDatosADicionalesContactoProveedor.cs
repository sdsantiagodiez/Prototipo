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

namespace Vista
{
    public partial class frmABMEntidadDatosAdicionalesContactoProveedor : Form
    {
        private frmResultadoBusqueda fResultadoBusqueda;
        public ModeloProveedor mProveedor;
        public frmABMEntidadDatosAdicionalesContactoProveedor()
        {
            InitializeComponent();
            this.inicializarFormulario();
        }

        private void inicializarFormulario()
        {
            //no permitir al usuario modificar dimensiones de ventan
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            
            this.StartPosition = FormStartPosition.CenterParent;
            txtBoxCodigoSeleccionado.ReadOnly = txtBoxCUITSeleccionado.ReadOnly = txtBoxRazonSocialSeleccionado.ReadOnly = true;
        }
        private void cargarProveedorEnControles()
        {
            txtBoxCodigoSeleccionado.Text = mProveedor.codigo.ToString();
            txtBoxCUITSeleccionado.Text = mProveedor.cuit;
            txtBoxRazonSocialSeleccionado.Text = mProveedor.razonSocial;
        }
        private void cargarDatosEnModeloProveedor(ref ModeloProveedor pmProveedor)
        {
            if (LibreriaClasesCompartidas.Validar.validarValorNumerico(txtBoxCodigo.Text))
            {
                pmProveedor.codigo = Convert.ToInt32(txtBoxCodigo.Text);
            }
            else
            {
                pmProveedor.codigo = 0;
            }

            pmProveedor.cuit = txtBoxCUIT.Text;
            pmProveedor.razonSocial = txtBoxRazonSocial.Text;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.mProveedor = null;
            this.Close();
        }

        private void btnContactoProveedorSeleccionarProveedor_Click(object sender, EventArgs e)
        {
            fResultadoBusqueda = new frmResultadoBusqueda();
            ModeloProveedor mProveedorSeleccionado = new ModeloProveedor();
            this.cargarDatosEnModeloProveedor(ref mProveedorSeleccionado);
            fResultadoBusqueda.mostrarBusqueda(mProveedorSeleccionado);
            if (fResultadoBusqueda.mProveedor != null)
            {
                mProveedor = fResultadoBusqueda.mProveedor;
                this.cargarProveedorEnControles();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
