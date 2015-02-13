using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmAltaBajaModif : Form
    {
        public frmAltaBajaModif()
        {
            InitializeComponent();

            //si es encargado de datos muestro el panel
            //como en frmMenuPrincipal, el codigo del rol de ED es 4
            foreach (int rol in rolCollection)
            {
                if (rol == 4)
	            {
                    pnlED.Visible = true;
	            }
            }
        }
    }
}
