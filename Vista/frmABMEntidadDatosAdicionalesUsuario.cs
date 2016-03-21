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

        public frmABMEntidadDatosAdicionalesUsuario()
        {
            InitializeComponent();
            this.inicializarFormulario();
        }

        public frmABMEntidadDatosAdicionalesUsuario(ModeloUsuario p_mod_usuario)
            : this()
        {
            _usuario = p_mod_usuario;
            this.cargarUsuarioEnControles();
            modoUsuarioNuevo = false;
        }
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
            ModeloRoles lcl_mod_rol = new ModeloRoles();
            chckdListBoxRol.DataSource = lcl_con_busqueda.buscar(lcl_mod_rol, LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Roles.All);
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
        private List<ModeloRoles> cargarDatosEnModeloRol()
        {
            List<ModeloRoles> lcl_lst_mod_roles = new List<ModeloRoles>();
            ModeloRoles lcl_mod_rol = new ModeloRoles();
            foreach (object itemChecked in chckdListBoxRol.CheckedItems)
            {
                DataRowView rol = itemChecked as DataRowView;
                lcl_mod_rol.codigo = Convert.ToInt32(rol["codigo"].ToString());
                lcl_mod_rol.descripcion = rol["descripcion"].ToString();
            }
            return lcl_lst_mod_roles;
        }
        #endregion

        #region Métodos
        #region Validación
        private bool validarDatosIngresados()
        {
            return (this.validarUsuarioYContraseña() == true && this.validarRoles() == true);
        }
        private bool validarUsuarioYContraseña()
        {
            return (this.validarUsuario() == true && this.validarContraseña() == true);   
        }
        private bool validarUsuario()
        {
            //formato ingresado, caracteres permitidos y cantidad
            return true;
        }
        private bool validarContraseña()
        {
            //formato ingresado, caracteres permitidos y cantidad
            //luego si son iguales los dos campos de contraseña
            if (txtBoxContraseña.Text != txtBoxConfirmarContraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private bool validarRoles()
        {
            return true;
        }
        #endregion
        
        #region Controles -> Modelo
        private void cargarControlesEnUsuario()
        {
            _usuario = new ModeloUsuario();
            this.cargarDatosControlUsuarioContraseña();
            this.cargarDatosControlRoles();
        }
        private void cargarDatosControlUsuarioContraseña()
        {
            _usuario.usuario = txtBoxUsuario.Text;
            _usuario.contrasenia = txtBoxContraseña.Text;
        }
        private void cargarDatosControlRoles()
        {
            List<ModeloRoles> lcl_lst_mod_roles = this.chckdListBoxRol.CheckedItems.OfType<ModeloRoles>().ToList();
            _usuario.roles = lcl_lst_mod_roles;
        }
       
        #endregion

        #region Modelo -> Controles
        private void cargarUsuarioEnControles()
        {
            txtBoxUsuario.Text = _usuario.usuario;
            this.cargarDatosRolesEnControles();
        }

        private void cargarDatosRolesEnControles()
        {
            ModeloRoles m_roles_aux;
            for (int i = 0; i < chckdListBoxRol.Items.Count; i++)
            {
                m_roles_aux = (ModeloRoles)this.chckdListBoxRol.Items[i];
                if (_usuario.roles.Contains(m_roles_aux))
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
            if (this.validarDatosIngresados() == true)
            {
                this.cargarControlesEnUsuario();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.modoUsuarioNuevo = true;
        }

    }
}
