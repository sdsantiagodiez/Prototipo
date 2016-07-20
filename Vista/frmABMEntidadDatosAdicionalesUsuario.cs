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
using LibreriaClasesCompartidas;


namespace Vista
{
    public partial class frmABMEntidadDatosAdicionalesUsuario : frmMaterialSkinBase
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
            usuario = new ModeloUsuario();
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
            chckdListBoxRol.DataSource = ControladorBusqueda.getRoles();
            chckdListBoxRol.DisplayMember = "descripcion";
            chckdListBoxRol.ValueMember = "codigo";
        }
        private void inicializarModoUsuarioNuevo(bool value)
        {
            txtBoxUsuario.Enabled = 
            txtBoxContraseña.Enabled= 
            txtBoxConfirmarContraseña.Enabled =
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
            
            if (string.IsNullOrWhiteSpace(txtBoxContraseña.Text) && usuario.contrasenia != null)
            {
                //Sucede en caso de modificación, donde se habilita el campo contraseña para ser modificado, pero puede no ser modificado.
                //De esta forma, no aparecen errores y se puede cerrar la ventana con Aceptar en caso de que se haya cambiado algo
                return true;
            }

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
            
            this.cargarDatosControlUsuarioContraseña();
            usuario.roles = this.cargarDatosControlRoles();
        }
        private void cargarDatosControlUsuarioContraseña()
        {
            usuario.usuario = txtBoxUsuario.Text;
            //Sólo se asigna si es usuario nuevo o se modifica contraseña de usuario ya creado
            if (usuario.contrasenia == null && !string.IsNullOrWhiteSpace(txtBoxContraseña.Text))
            { 
                usuario.asignarContraseña(txtBoxContraseña.Text); 
            }
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

        private void txtBoxUsuario_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxUsuario.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Usuario);
            if (!respuesta)
            {
                epUsuario.Icon = Properties.Resources.error;
                epUsuario.SetError(txtBoxUsuario, "Usuario no válido");
            }
            else
            {
                epUsuario.Icon = Properties.Resources.success;
                epUsuario.SetError(txtBoxUsuario, "OK");
            }
        }

        private void txtBoxContraseña_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxContraseña.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Contrasenia);
            if (!respuesta)
            {
                epContraseña.Icon = Properties.Resources.error;
                epContraseña.SetError(txtBoxContraseña, "Contraseña no válida");
            }
            else
            {
                epContraseña.Icon = Properties.Resources.success;
                epContraseña.SetError(txtBoxContraseña, "OK");
            }
        }

        private void txtBoxConfirmarContraseña_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxConfirmarContraseña.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Contrasenia);
            if (!respuesta)
            {
                epContraseña.Icon = Properties.Resources.error;
                epContraseña.SetError(txtBoxConfirmarContraseña, "Contraseña no válida");
            }
            else
            {
                if (string.Equals(txtBoxContraseña.Text.ToString(), txtBoxConfirmarContraseña.Text.ToString()))
                {
                    epContraseña.Icon = Properties.Resources.success;
                    epContraseña.SetError(txtBoxConfirmarContraseña, "OK");
                }
                else
                {
                    epContraseña.Icon = Properties.Resources.error;
                    epContraseña.SetError(txtBoxConfirmarContraseña, "Las contraseñas no coinciden");
                }
            }
        }
        
    }
}
