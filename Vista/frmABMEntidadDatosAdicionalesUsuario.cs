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

        public frmABMEntidadDatosAdicionalesUsuario()
        {
            InitializeComponent();
            this.inicializarFormulario();
        }

        public frmABMEntidadDatosAdicionalesUsuario(ModeloUsuario p_mod_usuario)
            : this()
        {
            usuario = p_mod_usuario;
            this.cargarUsuarioEnControles();
        }

        #region Métodos

        #region Inicialización
        private void inicializarFormulario()
        {
            //no permitir al usuario modificar dimensiones de ventan
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.StartPosition = FormStartPosition.CenterParent;
            this.inicializarCheckedListBox();
        }

        private void inicializarCheckedListBox()
        {
            //REVISAR FALTAN roles en controladores y catalogo
            ControladorBusqueda lcl_con_busqueda = new ControladorBusqueda();
            List<ModeloRoles> lcl_lst_mod_roles = new List<ModeloRoles>();
            ModeloRoles lcl_mod_rol;
            for (int i = 0; i < 10; i++ )
            {
                lcl_mod_rol = new ModeloRoles();
                lcl_mod_rol.codigo = i;
                lcl_mod_rol.descripcion = "Rol " + i.ToString();
                lcl_lst_mod_roles.Add(lcl_mod_rol);
            }

            chckdListBoxRol.DataSource = lcl_lst_mod_roles;
            chckdListBoxRol.DisplayMember = "descripcion";
            chckdListBoxRol.ValueMember = "codigo";
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
            usuario = new ModeloUsuario();
            this.cargarDatosControlUsuarioContraseña();
            this.cargarDatosControlRoles();
        }
        private void cargarDatosControlUsuarioContraseña()
        { 
        }
        private void cargarDatosControlRoles()
        { }
       
        #endregion

        #region Modelo -> Controles
        private void cargarUsuarioEnControles()
        {
            txtBoxUsuario.Text = usuario.usuario;
            this.cargarDatosRolesEnControles();
        }

        private void cargarDatosRolesEnControles()
        { 
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
            this.usuario = null;
            this.Close();
        }
        #endregion

    }
}
