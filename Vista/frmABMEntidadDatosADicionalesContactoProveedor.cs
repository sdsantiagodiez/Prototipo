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
            txtBoxCUIT.MaxLength = ModeloEntidad.CUIT.longitud;
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
            //no permitir al usuario modificar dimensiones de ventan
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            
            this.StartPosition = FormStartPosition.CenterParent;
            txtBoxCodigoSeleccionado.ReadOnly = txtBoxCUITSeleccionado.ReadOnly = txtBoxRazonSocialSeleccionado.ReadOnly = true;
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

       
    }
}
