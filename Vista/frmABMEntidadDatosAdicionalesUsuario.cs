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
        public ModeloPersonas usuario;

        public frmABMEntidadDatosAdicionalesUsuario()
        {
            InitializeComponent();
            this.inicializarFormulario();
        }

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
            ControladorBusqueda cBusqueda = new ControladorBusqueda();
            List<ModeloRoles> roles = new List<ModeloRoles>();
            ModeloRoles mRol;
            for (int i = 0; i < 10; i++ )
            {
                mRol = new ModeloRoles();
                mRol.codigo = i;
                mRol.descripcion = "Rol " + i.ToString();
                roles.Add(mRol);
            }

            chckdListBoxRol.DataSource = roles;
            chckdListBoxRol.DisplayMember = "descripcion";
            chckdListBoxRol.ValueMember = "codigo";
        }
        private List<ModeloRoles> cargarDatosEnModeloRol()
        {
            List<ModeloRoles> lModeloRol = new List<ModeloRoles>();
            ModeloRoles mRol = new ModeloRoles();
            foreach (object itemChecked in chckdListBoxRol.CheckedItems)
            {
                DataRowView rol = itemChecked as DataRowView;
                mRol.codigo = Convert.ToInt32(rol["codigo"].ToString());
                mRol.descripcion = rol["descripcion"].ToString();
            }
            return lModeloRol;
        }

        private bool validarIngresoDeDatos()
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

        private void cargarDatosEnModelo()
        {
            usuario = new ModeloPersonas();
            this.cargarUsuarioYContraseña();
            this.cargarRoles();
        }
        private void cargarUsuarioYContraseña()
        { 
        }
        private void cargarRoles()
        { }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Si validación falla, el método de validación mostrará los mensajes de error correspondientes
            if (this.validarIngresoDeDatos() == true)
            {
                this.cargarDatosEnModelo();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.usuario = null;
            this.Close();
        }

    }
}
