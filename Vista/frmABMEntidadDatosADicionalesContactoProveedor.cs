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
    public partial class frmABMEntidadDatosADicionalesContactoProveedor : Form
    {
        private frmResultadoBusqueda fResultadoBusqueda;

        public frmABMEntidadDatosADicionalesContactoProveedor()
        {
            InitializeComponent();
        }
        private void btnContactoProveedorSeleccionarProveedor_Click(object sender, EventArgs e)
        {
            ModeloProveedor mProveedor = new ModeloProveedor();
            
            if (LibreriaClasesCompartidas.Validar.validarValorNumerico(txtBoxCodigoContactoProveedorProveedor.Text))
            {
                mProveedor.codigo = Convert.ToInt32(txtBoxCodigoContactoProveedorProveedor.Text);
            }
            else
            {
                mProveedor.codigo = 0;
            }

            mProveedor.cuit = txtBoxCUITContactoProveedorProveedor.Text;
            mProveedor.razonSocial = txtBoxRazonSocialContactoProveedorProveedor.Text;

            fResultadoBusqueda = new frmResultadoBusqueda();
            fResultadoBusqueda.mostrarBusqueda(mProveedor);

        }
    }
}
