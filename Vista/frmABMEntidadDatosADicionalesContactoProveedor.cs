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
        List<bool> glb_lst_respuestasValidaciones;
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
            glb_lst_respuestasValidaciones = new List<bool>();
            for (int i = 0; i < 3; i++)
            {
                glb_lst_respuestasValidaciones.Add(false);
            }
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
            InicializarCmbBox(this.cmbBoxProveedores);
        }
        #endregion

        #region Validación
        private int getIndex(string p_inputName)
        {
            int index;
            switch (p_inputName)
            {
                case Constantes.ParametrosBusqueda.Entidades.Proveedores.CodigoEntidad:
                    index = 0;
                    break;
                case Constantes.ParametrosBusqueda.Entidades.Proveedores.Cuit:
                    index = 1;
                    break;
                case Constantes.ParametrosBusqueda.Entidades.Proveedores.RazonSocial:
                    index = 2;
                    break;
                default:
                    index = 0;
                    break;
            }
            return index;
        }

        private bool validarInputs(object sender, EventArgs e)
        {
            txtBoxCodigoSeleccionado_Leave(sender, e);
            txtBoxCUITSeleccionado_Leave(sender, e);
            txtBoxRazonSocialSeleccionado_Leave(sender, e);
                return (glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Proveedores.CodigoEntidad)]
                    & glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Proveedores.Cuit)]
                    & glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Proveedores.RazonSocial)]);
        }

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
            if (this.validar() & this.validarInputs(sender,e))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Asegurese de seleccionar un Proveedor para el Contacto de Proveedor actual y de ingresar los datos correctamente","Error",MessageBoxButtons.OK);
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

        #region TextBoxs
        private void txtBoxCodigoSeleccionado_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxCodigoSeleccionado.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Proveedores.CodigoEntidad);
            glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Proveedores.CodigoEntidad)] = respuesta;
            string lcl_mensaje = respuesta ? "OK" : "Código no válido";
            this.setErrorProvider(txtBoxCodigoSeleccionado, respuesta, lcl_mensaje);
        }

        private void txtBoxCUITSeleccionado_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxCUITSeleccionado.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Proveedores.Cuit);
            glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Proveedores.Cuit)] = respuesta;
            string lcl_mensaje = respuesta ? "OK" : "CUIT no válido";
            this.setErrorProvider(txtBoxCUITSeleccionado, respuesta, lcl_mensaje);
        }

        private void txtBoxRazonSocialSeleccionado_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxRazonSocialSeleccionado.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Proveedores.RazonSocial);
            glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Proveedores.RazonSocial)] = respuesta;
            string lcl_mensaje = respuesta ? "OK" : "Razón Social no válida";
            this.setErrorProvider(txtBoxRazonSocialSeleccionado, respuesta, lcl_mensaje);
        }
        #endregion
        #endregion
    }
}
