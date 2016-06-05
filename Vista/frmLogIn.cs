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
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace Vista
{
    public partial class frmLogIn : MaterialForm
    {
        ErrorProvider errorProviderActual;
        public ModeloUsuario usuarioActual;

        public frmLogIn()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;
            txtBoxUsuario.KeyPress += this.valorUsername;
            errorProviderActual = new ErrorProvider();
        }

        #region Eventos
        
        #region Button
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            ModeloUsuario lcl_mod_usuario = new ModeloUsuario();
            lcl_mod_usuario.usuario = txtBoxUsuario.Text;
            lcl_mod_usuario.asignarContraseña(txtBoxContrasenia.Text);
            
            usuarioActual = ControladorSesion.LogIn(lcl_mod_usuario);
            if (usuarioActual != null)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("El usuario o contraseña es incorrecto. Vuelva a intentarlo.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
          
        }
        #endregion
        
        #region TextBox
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
        #endregion
        
        #endregion
    }
}
