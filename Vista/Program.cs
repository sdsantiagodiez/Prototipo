using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogIn lcl_frm_logIn = new frmLogIn();
            if (lcl_frm_logIn.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmMenuPrincipal(lcl_frm_logIn.usuarioActual));
            }
            else
            {
                Application.Exit();
            }

            //Si el login resulta molesto, se puede comentar lo anterior y correr la línea de acá abajo
            //Application.Run(new frmMenuPrincipal());
        }
    }
}
