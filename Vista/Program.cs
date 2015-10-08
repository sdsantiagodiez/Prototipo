using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var menuPrincipal = new frmMenuPrincipal();
            Application.Run(menuPrincipal);
            //var testForm = new frmPedidoClienteNuevo();
            //testForm.ShowDialog();
            //
            //Sin login por el momento de test
            //frmLogIn loginForm = new frmLogIn();
            //if (loginForm.ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(new frmMenuPrincipal(loginForm.getRoles(), loginForm.getUsuario()));
            //}
        }
    }
}
