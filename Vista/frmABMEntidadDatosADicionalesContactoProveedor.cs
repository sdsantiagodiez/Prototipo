using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
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
            txtBoxCodigoSeleccionado.Enabled = txtBoxCUITSeleccionado.Enabled = txtBoxRazonSocialSeleccionado.Enabled = false;
            this.inicializarCmbBoxProveedores();
        }
        private void inicializarCmbBoxProveedores()
        {
            List<ModeloProveedor> lcl_lst_mod_proveedores = Controladores.ControladorBusqueda.getProveedores().OrderBy(x => x.razonSocial).ToList();
            var dataSource = new List<ComboBoxItem>();

            for (int i = 0; i < lcl_lst_mod_proveedores.Count; i++)
            {
                dataSource.Add(new ComboBoxItem()
                {
                    Name = lcl_lst_mod_proveedores[i].razonSocial,
                    Value = lcl_lst_mod_proveedores[i]
                });
            }
            if (dataSource.Count < 1)
            {
                dataSource.Add(new ComboBoxItem() { Name = "--No existen proveedores--", Value = null });
                this.cmbBoxProveedores.Enabled = false;
            }
            else
            {
                dataSource.Insert(0, new ComboBoxItem() { Name = "--Seleccionar--", Value = null });
            }
            this.cmbBoxProveedores.DataSource = dataSource;
            base.inicializarCmbBox(this.cmbBoxProveedores);
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
            if (contactoProveedor.proveedor != null)
            {
                this.cmbBoxProveedores.SelectedValue = contactoProveedor.proveedor;
            }
        }
        private void cargarProveedorEnTextBox(ModeloProveedor p_proveedor)
        {
            if (p_proveedor != null)
            {
                txtBoxCodigoSeleccionado.Text = p_proveedor.codigo.ToString();
                txtBoxCUITSeleccionado.Text = p_proveedor.cuit;
                txtBoxRazonSocialSeleccionado.Text = p_proveedor.razonSocial;
            }
        }
        #endregion

        #region Controles -> Modelo

        #endregion
        #endregion

        #region Eventos

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

        private void cmbBoxProveedores_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.contactoProveedor == null)
            {
                return;
            }
            if ((sender as ComboBox).SelectedValue as ModeloProveedor != null)
            {
                this.contactoProveedor.proveedor = (sender as ComboBox).SelectedValue as ModeloProveedor;
                this.cargarProveedorEnTextBox(this.contactoProveedor.proveedor);
            }
            else
            {
                this.contactoProveedor.proveedor = null;
                this.cargarProveedorEnTextBox(new ModeloProveedor());
            }
        }
        #endregion

        #region Validaciones

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
