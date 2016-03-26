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
using Controladores;

namespace Vista
{
    public partial class frmABMEntidadDatosAdicionalesUsuario : Form
    {
        #region Atributos
        ErrorProvider errorProviderActual;
        private ModeloUsuario _usuario;
        public ModeloUsuario usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        private bool _modoUsuarioNuevo;
        private bool modoUsuarioNuevo 
        {
            get { return _modoUsuarioNuevo; }
            set 
            { 
                _modoUsuarioNuevo = value;
                this.inicializarModoUsuarioNuevo(_modoUsuarioNuevo);
            }
        }
        #endregion

        #region Constructores
        public frmABMEntidadDatosAdicionalesUsuario()
        {
            InitializeComponent();
            this.inicializarFormulario();
            errorProviderActual = new ErrorProvider();

            txtBoxUsuario.KeyPress += this.valorUsername;
        }

        public frmABMEntidadDatosAdicionalesUsuario(ModeloUsuario p_mod_usuario)
            : this()
        {
            usuario = p_mod_usuario;
            this.cargarUsuarioEnControles();
            modoUsuarioNuevo = false;
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
            modoUsuarioNuevo = true;

            this.StartPosition = FormStartPosition.CenterParent;
            this.inicializarCheckedListBox();
        }

        private void inicializarCheckedListBox()
        {
            ControladorBusqueda lcl_con_busqueda = new ControladorBusqueda();
            chckdListBoxRol.DataSource = lcl_con_busqueda.getRoles();
            chckdListBoxRol.DisplayMember = "descripcion";
            chckdListBoxRol.ValueMember = "codigo";
        }
        private void inicializarModoUsuarioNuevo(bool value)
        {
            txtBoxUsuario.Enabled = value;
            txtBoxContraseña.Enabled = value;
            txtBoxConfirmarContraseña.Enabled = value;
            chckdListBoxRol.Enabled = value;

            btnModificar.Enabled = !value;
        }

        #endregion

        #region Validación
        private bool validarDatosIngresados()
        {
            //Se separa para permitir que primero se muestren ErrorProviders, y luego error en roles
            bool validez = this.validarUsuario();
            validez = this.validarContraseña() && validez;
            return validez && this.validarRoles();
        }
    
        private bool validarUsuario()
        {
            if (string.IsNullOrWhiteSpace(txtBoxUsuario.Text))
            {
                errorProviderActual.SetError(txtBoxUsuario, "Este campo es obligatorio. No puede permanecer vacío.");
                return false;
            } else if (!ModeloUsuario.validarUsuario(txtBoxUsuario.Text))
            {
                errorProviderActual.SetError(txtBoxUsuario, "Ha ingresado caracteres no válidos. No se permiten caracteres especiales o espacios, a excepción de '_'");
                return false;
            }
            errorProviderActual.SetError(txtBoxUsuario, "");
            return true;
        }
        private bool validarContraseña()
        {
            errorProviderActual.SetError(txtBoxContraseña, "");
            errorProviderActual.SetError(txtBoxConfirmarContraseña, "");
            if (!ModeloUsuario.validarContrasenia(txtBoxContraseña.Text))
            {
                errorProviderActual.SetError(txtBoxContraseña, "La contraseña ingresada no es válida. Debe tener por lo mínimo 8 caracteres.");
                return false;
            } else if (txtBoxContraseña.Text != txtBoxConfirmarContraseña.Text)
            {
                errorProviderActual.SetError(txtBoxConfirmarContraseña, "Las contraseñas no coinciden.");
                return false;
            }
            
            return true;
        }
        private bool validarRoles()
        {
            this.cargarDatosControlRoles();
            if (this.cargarDatosControlRoles().Count == 0)
            {
                MessageBox.Show("Debe seleccionar por lo menos un rol para el Usuario actual", "Error", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        #endregion
        
        #region Controles -> Modelo
        private void cargarControlesEnUsuario()
        {
            usuario = new ModeloUsuario();
            this.cargarDatosControlUsuarioContraseña();
            usuario.roles = this.cargarDatosControlRoles();
        }
        private void cargarDatosControlUsuarioContraseña()
        {
            usuario.usuario = txtBoxUsuario.Text;
            usuario.contrasenia = txtBoxContraseña.Text;
        }
        private List<ModeloRoles> cargarDatosControlRoles()
        {
            List<ModeloRoles> lcl_lst_mod_roles = this.chckdListBoxRol.CheckedItems.OfType<ModeloRoles>().ToList();
            return lcl_lst_mod_roles;
        }
       
        #endregion

        #region Modelo -> Controles
        private void cargarUsuarioEnControles()
        {
            txtBoxUsuario.Text = usuario.usuario;
            this.cargarDatosRolesEnControles();
        }

        private void cargarDatosRolesEnControles()
        {
            ModeloRoles m_roles_aux;
            for (int i = 0; i < chckdListBoxRol.Items.Count; i++)
            {
                m_roles_aux = (ModeloRoles)this.chckdListBoxRol.Items[i];
                if (usuario.roles.Contains(m_roles_aux))
                {
                    chckdListBoxRol.SetItemChecked(i,true);
                }
            }
        }
        #endregion

        #endregion
        
        #region Eventos
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Si validación falla, el método de validación mostrará los mensajes de error correspondientes
            if (this.validarDatosIngresados())
            {
                this.cargarControlesEnUsuario();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.modoUsuarioNuevo = true;
        }

        private void valorUsername(object sender, KeyPressEventArgs e)
        {
            if (!ModeloUsuario.validarUsuario(e.KeyChar.ToString()) && e.KeyChar != '\b')
            {
                e.Handled = true;
                errorProviderActual.SetError((sender as TextBox), "Caracter no válido. Solo se permite letras, números y '_'.");
                return;
            }
            if (ModeloUsuario.validarUsuario((sender as TextBox).Text))
            {
                errorProviderActual.SetError((sender as TextBox), "");
            }
        }

        private void chckBoxMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxConfirmarContraseña.UseSystemPasswordChar = txtBoxContraseña.UseSystemPasswordChar = !(sender as CheckBox).Checked;
        }
        #endregion
        
    }
}
