﻿using System;
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
    public partial class frmLogIn : frmMaterialSkinBase
    {
        public ModeloUsuario usuarioActual;

        public frmLogIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txtBoxUsuario.KeyPress += this.valorUsername;
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
            //if (!ModeloUsuario.validarUsuario(e.KeyChar.ToString()) && e.KeyChar != '\b')
            //{
            //    e.Handled = true;
            //    errorProviderActual.SetError((sender as TextBox), "Caracter no válido. Solo se permite letras, números y '_'.");
            //    return;
            //}
            //if (ModeloUsuario.validarUsuario((sender as TextBox).Text))
            //{
            //    errorProviderActual.SetError((sender as TextBox), "");
            //}
        }
        private void txtBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnLogIn_Click(sender, e);
            }
        }

        #endregion

        private void txtBoxContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnLogIn_Click(sender, e);
            }
        }
        #endregion
    }
}
