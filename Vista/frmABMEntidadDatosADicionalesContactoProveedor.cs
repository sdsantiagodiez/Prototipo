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
        private ModeloContactoProveedor _contactoProveedor;
        public ModeloContactoProveedor contactoProveedor
        {
            get { return _contactoProveedor; }
            set { _contactoProveedor = value; }
        }
       
        public frmABMEntidadDatosAdicionalesContactoProveedor()
        {
            InitializeComponent();
            this.inicializarFormulario();
            contactoProveedor = new ModeloContactoProveedor();
        }
        public frmABMEntidadDatosAdicionalesContactoProveedor(ModeloContactoProveedor p_mod_contactoProveedor) : this()
        {
            contactoProveedor = new ModeloContactoProveedor(p_mod_contactoProveedor);
            this.cargarDatosProveedorEnControles();
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
        #region Modelo -> Controles
        private void cargarDatosProveedorEnControles()
        {
            txtBoxCodigoSeleccionado.Text = contactoProveedor.proveedor.codigo.ToString();
            txtBoxCUITSeleccionado.Text = contactoProveedor.proveedor.cuit;
            txtBoxRazonSocialSeleccionado.Text = contactoProveedor.proveedor.razonSocial;
        }
        #endregion

        #region Controles -> Modelo
        private void cargarDatosEnModeloProveedor(ref ModeloProveedor lcl_mod_proveedor)
        {
            if (LibreriaClasesCompartidas.Validar.validarValorNumerico(txtBoxCodigo.Text))
            {
                lcl_mod_proveedor.codigo = Convert.ToInt32(txtBoxCodigo.Text);
            }
            else
            {
                lcl_mod_proveedor.codigo = 0;
            }

            lcl_mod_proveedor.cuit = txtBoxCUIT.Text;
            lcl_mod_proveedor.razonSocial = txtBoxRazonSocial.Text;
        }
        #endregion

        #region Eventos

        private void btnSeleccionarProveedor_Click(object sender, EventArgs e)
        {
            frmResultadoBusqueda glb_frm_resultadoBusqueda = new frmResultadoBusqueda();
            ModeloProveedor lcl_mod_proveedorSeleccionado = new ModeloProveedor();
            this.cargarDatosEnModeloProveedor(ref lcl_mod_proveedorSeleccionado);
            glb_frm_resultadoBusqueda.mostrarBusqueda(lcl_mod_proveedorSeleccionado);
            if (glb_frm_resultadoBusqueda.modeloSeleccionado != null)
            {
                contactoProveedor.proveedor = glb_frm_resultadoBusqueda.modeloSeleccionado as ModeloProveedor;
                this.cargarDatosProveedorEnControles();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.contactoProveedor = null;
            this.Close();
        }
        #endregion

       
    }
}
