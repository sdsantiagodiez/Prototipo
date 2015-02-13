using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Datos;

namespace Vista
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasenia = txtContrasenia.Text;

            CatalogoPersonas ctlgPersonas = new CatalogoPersonas();
            List<ModeloPersonas> usuarios = ctlgPersonas.buscarPersona("usuario","usuario",usuario);
            if (object.Equals(usuarios[0].contraseniaPers,contrasenia.Trim().ToLower()))
            {
                
            }
        }
    }
}
