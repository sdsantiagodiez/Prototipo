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

            frmLogIn loginForm = new frmLogIn();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmMenuPrincipal(loginForm.getRoles(), loginForm.getUsuario()));
            }
        }
    }
}
