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

namespace Vista
{
    public partial class frmAltaBajaModif : Form
    {
        public frmAltaBajaModif(/*List<ModeloRoles> rolCollection*/)
        {
            InitializeComponent();

            //si es encargado de datos muestro el panel
            //como en frmMenuPrincipal, el codigo del rol de ED es 4
           // la validacion se encuentra en el frmMenuPrincipal
            /* foreach (ModeloRoles rol in rolCollection)
            {
                int nroRol = rol.getCodRol();
                if (nroRol == 4)
	            {
                    pnlED.Visible = true;
	            }
            }*/
        }
    }
}
