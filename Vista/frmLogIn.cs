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
using Controlador;

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
            this.setPersona(ctrlSesion.buscarUsuario(usuario, contrasenia));

           
            if (!object.Equals(_persona.dniPers,  null))
            {
                //busco y guardo los roles del usuario
                this.setRoles(ctrlSesion.getRoles(_persona));

            //cierro login y devuelvo resultado ok o notifico fallo    
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
        }

        public ModeloPersonas getUsuario()
        {
            return _persona;
        }

        private void setPersona(ModeloPersonas persona)
        {
            _persona = persona;
        }

        public List<ModeloRoles> getRoles()
        {
            return _roles;
        }

        private void setRoles(List<ModeloRoles> roles)
        {
            _roles = roles;
        }
    }
}
