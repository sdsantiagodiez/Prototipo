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
using LibreriaClasesCompartidas;


namespace Vista
{
    public partial class frmABMEntidadDatosAdicionalesContactoProveedor : frmMaterialSkinBase
    {
        #region Atributos
        private ModeloContactoProveedor _contactoProveedor;
        public ModeloContactoProveedor contactoProveedor
        
        {
            get { return _contactoProveedor; }
            set { _contactoProveedor = value; }
        }
        #endregion

        #region Constructores
        public frmABMEntidadDatosAdicionalesContactoProveedor()
        {
            InitializeComponent();

            this.inicializarFormulario();
            contactoProveedor = new ModeloContactoProveedor();

            txtBoxCUIT.KeyPress += this.valorCUIT;
            //txtBoxCUIT.MaxLength = ModeloEntidad.CUIT.longitud;
        }
        public frmABMEntidadDatosAdicionalesContactoProveedor(ModeloContactoProveedor p_mod_contactoProveedor) : this()
        {
            contactoProveedor = new ModeloContactoProveedor(p_mod_contactoProveedor);
            this.cargarDatosProveedorEnControles();
        }
        #endregion

        #region Métodos
        #region Inicialización
        private void inicializarFormulario()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            //txtBoxCodigoSeleccionado.ReadOnly = txtBoxCUITSeleccionado.ReadOnly = txtBoxRazonSocialSeleccionado.ReadOnly = true;
        }
        #endregion

        #region Validación
        private bool validar()
        {
            if (contactoProveedor.proveedor != null)
            {
                return true;
            }
            return false;
        }
        #endregion

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
            if (LibreriaClasesCompartidas.Validar.validarInputNumerico(txtBoxCodigo.Text.ToString(),LibreriaClasesCompartidas.Constantes.Numericos.Entero))
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
            if (this.validar())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Proveedor para el Contacto de Proveedor actual.","Error",MessageBoxButtons.OK);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.contactoProveedor = null;
            this.Close();
        }
        /// <summary>
        /// Diferente al valorCUIT de frmABMEntidad. No permite ingreso de guión, pero los ingresa el sistema automaticamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void valorCUIT(object sender, KeyPressEventArgs e)
        {
            // solo 0-9 y borrar 
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 ))
            {
                e.Handled = true;
                return;
            }
            
            if ((sender as TextBox).Text.Length == 2 || (sender as TextBox).Text.Length == 11)
            {
                if (e.KeyChar != 8)
                {
                    (sender as TextBox).Text +=  "-"+e.KeyChar;
                    e.Handled = true;
                    (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
                }
                
            }
            
        }

        #endregion

        #region Validaciones
        private void txtBoxCodigo_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxCodigo.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Proveedores.CodigoEntidad);
            if (!respuesta)
            {
                epCodigo.Icon = Properties.Resources.error;
                epCodigo.SetError(txtBoxCodigo, "Código no válido");
            }
            else
            {
                epCodigo.Icon = Properties.Resources.success;
                epCodigo.SetError(txtBoxCodigo, "OK");
            }
        }

        private void txtBoxCUIT_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxCUIT.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Proveedores.Cuit);
            if (!respuesta)
            {
                epCUIT.Icon = Properties.Resources.error;
                epCUIT.SetError(txtBoxCUIT, "CUIT no válido");
            }
            else
            {
                epCUIT.Icon = Properties.Resources.success;
                epCUIT.SetError(txtBoxCUIT, "OK");
            }
        }

        private void txtBoxRazonSocial_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxRazonSocial.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Proveedores.RazonSocial);
            if (!respuesta)
            {
                epRazonSocial.Icon = Properties.Resources.error;
                epRazonSocial.SetError(txtBoxRazonSocial, "Razón Social no válida");
            }
            else
            {
                epRazonSocial.Icon = Properties.Resources.success;
                epRazonSocial.SetError(txtBoxRazonSocial, "OK");
            }
        }

        private void txtBoxCodigoSeleccionado_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxCodigoSeleccionado.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Proveedores.CodigoEntidad);
            if (!respuesta)
            {
                epCodigoSeleccionado.Icon = Properties.Resources.error;
                epCodigoSeleccionado.SetError(txtBoxCodigoSeleccionado, "Código no válido");
            }
            else
            {
                epCodigoSeleccionado.Icon = Properties.Resources.success;
                epCodigoSeleccionado.SetError(txtBoxCodigoSeleccionado, "OK");
            }
        }

        private void txtBoxCUITSeleccionado_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxCUITSeleccionado.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Proveedores.Cuit);
            if (!respuesta)
            {
                epCUITSeleccionado.Icon = Properties.Resources.error;
                epCUITSeleccionado.SetError(txtBoxCUITSeleccionado, "CUIT no válido");
            }
            else
            {
                epCUITSeleccionado.Icon = Properties.Resources.success;
                epCUITSeleccionado.SetError(txtBoxCUITSeleccionado, "OK");
            }
        }

        private void txtBoxRazonSocialSeleccionado_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxRazonSocialSeleccionado.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Proveedores.RazonSocial);
            if (!respuesta)
            {
                epRazonSocialSeleccionado.Icon = Properties.Resources.error;
                epRazonSocialSeleccionado.SetError(txtBoxRazonSocialSeleccionado, "Razón Social no válida");
            }
            else
            {
                epRazonSocialSeleccionado.Icon = Properties.Resources.success;
                epRazonSocialSeleccionado.SetError(txtBoxRazonSocialSeleccionado, "OK");
            }
        }
#endregion
       
    }
}
