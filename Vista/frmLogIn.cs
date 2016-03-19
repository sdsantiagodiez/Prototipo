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
    public partial class frmLogIn : Form
    {
        private List<ModeloRoles> _roles;
        private ModeloPersonas _persona;
    
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //capturo los datos ingresados al formulario
            string usuario = txtUsuario.Text;
            string contrasenia = txtContrasenia.Text;

            //busco el usuario correspondiente y lo guardo
            ControladorInicioSesion ctrlSesion = new ControladorInicioSesion();
          
            //this.persona=ctrlSesion.buscarUsuario(usuario, contrasenia);
           
           
            //if (!object.Equals(this.persona.dni,  null))
            //{
            //    //busco y guardo los roles del usuario
            //    this.Roles=ctrlSesion.getRoles(this.persona);

            ////cierro login y devuelvo resultado ok o notifico fallo    
            //    this.DialogResult = DialogResult.OK;
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Usuario no encontrado");
            //}
        }

        public ModeloPersonas persona
        {
            get { return _persona; }
            set { this._persona = value; }
        }
        public List<ModeloRoles> Roles
        {
            get { return _roles; }
            set { this._roles = value; }
        }
    }
}
